Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class UcSearchRecords

    Private Sub UcSearchRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.UseMnemonic = False
        AdjustLayoutForHostedHeader()
        ConfigureGridAppearance()
        LoadFilterOptions()

        Try
            SearchDisciplinaryRecords()
        Catch ex As MySqlException
            MessageBox.Show("MySQL connection failed while loading records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Failed to initialize Search Records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Pulls top-level panels up when hosted inside MainDashboardForm so no blank gap appears
    Private Sub AdjustLayoutForHostedHeader()
        If panelHeader Is Nothing OrElse panelHeader.Visible Then Return

        Const headerOffset As Integer = 74
        For Each ctrl As Control In Me.Controls
            If ctrl IsNot panelHeader Then
                ctrl.Top = Math.Max(14, ctrl.Top - headerOffset)
                If (ctrl.Anchor And AnchorStyles.Bottom) = AnchorStyles.Bottom Then
                    ctrl.Height += headerOffset
                End If
            End If
        Next
    End Sub

    ' Applies the shared slate and navy styling to the results DataGridView
    Private Sub ConfigureGridAppearance()
        dgvRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252)
        dgvRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85)
        dgvRecords.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        dgvRecords.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252)
        dgvRecords.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(51, 65, 85)

        dgvRecords.DefaultCellStyle.BackColor = Color.White
        dgvRecords.DefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42)
        dgvRecords.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        dgvRecords.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255)
        dgvRecords.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42)
    End Sub

    ' Populates category and sanction status filter dropdowns
    Private Sub LoadFilterOptions()
        cboFilterCategory.Items.Clear()
        cboFilterCategory.Items.Add("All Categories")
        cboFilterCategory.Items.Add("Minor")
        cboFilterCategory.Items.Add("Major")
        cboFilterCategory.SelectedIndex = 0

        cboFilterStatus.Items.Clear()
        cboFilterStatus.Items.Add("All Statuses")
        cboFilterStatus.Items.Add("Pending")
        cboFilterStatus.Items.Add("Escalated")
        cboFilterStatus.Items.Add("Cleared")
        cboFilterStatus.Items.Add("Overdue")
        cboFilterStatus.SelectedIndex = 0
    End Sub

    ' Owner-draws combo items to match the modern navy selection style used across forms
    Private Sub ModernCombo_DrawItem(sender As Object, e As DrawItemEventArgs) Handles _
        cboFilterCategory.DrawItem, cboFilterStatus.DrawItem

        If e.Index < 0 Then Return

        Dim cbo As ComboBox = DirectCast(sender, ComboBox)
        Dim isSelected As Boolean = ((e.State And DrawItemState.Selected) = DrawItemState.Selected)
        Dim isComboBoxEdit As Boolean = ((e.State And DrawItemState.ComboBoxEdit) = DrawItemState.ComboBoxEdit)

        Dim bgColor As Color = If(isSelected AndAlso Not isComboBoxEdit,
                                  Color.FromArgb(29, 63, 158),
                                  If(isComboBoxEdit, Color.FromArgb(248, 250, 252), Color.White))
        Dim fgColor As Color = If(isSelected AndAlso Not isComboBoxEdit,
                                  Color.White,
                                  Color.FromArgb(15, 23, 42))

        Using bgBrush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
        End Using

        Dim itemText As String = cbo.Items(e.Index).ToString()
        Dim textRect As New Rectangle(e.Bounds.X + 10, e.Bounds.Y, Math.Max(10, e.Bounds.Width - 20), e.Bounds.Height)
        TextRenderer.DrawText(e.Graphics, itemText, cbo.Font, textRect, fgColor,
                              TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.EndEllipsis)

        If Not isComboBoxEdit Then
            Using linePen As New Pen(Color.FromArgb(241, 245, 249), 1.0!)
                e.Graphics.DrawLine(linePen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1)
            End Using
        End If
    End Sub

    Public Sub SearchDisciplinaryRecords()
        Dim keyword As String = txtSearchQuery.Text.Trim()
        Dim selectedCategory As String = If(cboFilterCategory.SelectedItem IsNot Nothing, cboFilterCategory.SelectedItem.ToString(), "All Categories")
        Dim selectedStatus As String = If(cboFilterStatus.SelectedItem IsNot Nothing, cboFilterStatus.SelectedItem.ToString(), "All Statuses")

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT o.log_id, s.student_id, " &
                                    "TRIM(CONCAT(s.last_name, ', ', s.first_name, ' ', COALESCE(s.middle_name, ''))) AS student_name, " &
                                    "COALESCE(s.department, '') AS department, " &
                                    "o.offense_type, o.warning_level, o.incident_date, " &
                                    "COALESCE(sn.status, 'Pending') AS sanction_status " &
                                    "FROM offense_logs o " &
                                    "INNER JOIN students s ON o.student_id = s.student_id " &
                                    "LEFT JOIN sanctions sn ON sn.log_id = o.log_id " &
                                    "WHERE o.record_status = 'Active'"

                If keyword <> "" Then
                    sql &= " AND (s.student_id LIKE @kw " &
                           "OR s.last_name LIKE @kw " &
                           "OR s.first_name LIKE @kw " &
                           "OR s.department LIKE @kw " &
                           "OR o.offense_type LIKE @kw " &
                           "OR o.remarks LIKE @kw)"
                End If

                If Not String.Equals(selectedCategory, "All Categories", System.StringComparison.OrdinalIgnoreCase) Then
                    sql &= " AND o.severity = @sev"
                End If

                If Not String.Equals(selectedStatus, "All Statuses", System.StringComparison.OrdinalIgnoreCase) Then
                    sql &= " AND COALESCE(sn.status, 'Pending') = @status"
                End If

                sql &= " ORDER BY o.log_id DESC"

                Using adapter As New MySqlDataAdapter(sql, conn)
                    If keyword <> "" Then
                        adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    End If
                    If Not String.Equals(selectedCategory, "All Categories", System.StringComparison.OrdinalIgnoreCase) Then
                        adapter.SelectCommand.Parameters.AddWithValue("@sev", selectedCategory)
                    End If
                    If Not String.Equals(selectedStatus, "All Statuses", System.StringComparison.OrdinalIgnoreCase) Then
                        adapter.SelectCommand.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvRecords.AutoGenerateColumns = False
                    colLogID.DataPropertyName = "log_id"
                    colStudentID.DataPropertyName = "student_id"
                    colStudentName.DataPropertyName = "student_name"
                    colDepartment.DataPropertyName = "department"
                    colOffenseType.DataPropertyName = "offense_type"
                    colWarningLevel.DataPropertyName = "warning_level"
                    colIncidentDate.DataPropertyName = "incident_date"
                    colSanctionStatus.DataPropertyName = "sanction_status"

                    dgvRecords.DataSource = dt
                    StyleStatusCells()
                    lblResultCount.Text = $"{dt.Rows.Count:N0} " & If(dt.Rows.Count = 1, "record found", "records found")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to search disciplinary records: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Color-codes status cells consistently with UcSanctionTracker
    Private Sub StyleStatusCells()
        For Each row As DataGridViewRow In dgvRecords.Rows
            Dim statusText As String = Convert.ToString(row.Cells("colSanctionStatus").Value)
            Select Case statusText
                Case "Cleared", "Completed"
                    row.Cells("colSanctionStatus").Style.ForeColor = Color.FromArgb(21, 128, 61)
                Case "Pending", "In-progress"
                    row.Cells("colSanctionStatus").Style.ForeColor = Color.FromArgb(29, 63, 158)
                Case "Escalated"
                    row.Cells("colSanctionStatus").Style.ForeColor = Color.FromArgb(180, 83, 9)
                Case "Overdue"
                    row.Cells("colSanctionStatus").Style.ForeColor = Color.FromArgb(185, 28, 28)
            End Select
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchDisciplinaryRecords()
    End Sub

    Private Sub txtSearchQuery_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchQuery.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SearchDisciplinaryRecords()
        End If
    End Sub

    Private Sub FilterDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
        cboFilterCategory.SelectedIndexChanged, cboFilterStatus.SelectedIndexChanged

        If IsHandleCreated Then
            SearchDisciplinaryRecords()
        End If
    End Sub

    Private Sub btnResetFilters_Click(sender As Object, e As EventArgs) Handles btnResetFilters.Click
        txtSearchQuery.Clear()
        If cboFilterCategory.Items.Count > 0 Then cboFilterCategory.SelectedIndex = 0
        If cboFilterStatus.Items.Count > 0 Then cboFilterStatus.SelectedIndex = 0
        SearchDisciplinaryRecords()
    End Sub

End Class