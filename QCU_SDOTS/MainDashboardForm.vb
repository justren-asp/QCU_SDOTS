Imports System.Drawing
Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class MainDashboardForm

    Private currentUserControl As UserControl = Nothing

    Private Sub MainDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFormTitle.UseMnemonic = False
        ConfigureGridAppearance()
        SetActiveNavButton(btnNavDashboard)
        RefreshDashboardOverview()
    End Sub

    ' Applies shared slate and navy grid styling across modules
    Private Sub ConfigureGridAppearance()
        dgvRecentLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252)
        dgvRecentLogs.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85)
        dgvRecentLogs.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        dgvRecentLogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252)
        dgvRecentLogs.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(51, 65, 85)

        dgvRecentLogs.DefaultCellStyle.BackColor = Color.White
        dgvRecentLogs.DefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42)
        dgvRecentLogs.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        dgvRecentLogs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255)
        dgvRecentLogs.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42)
    End Sub

    ' Highlights the active sidebar navigation button
    Private Sub SetActiveNavButton(activeBtn As Button)
        Dim navButtons As Button() = {
            btnNavDashboard,
            btnNavLogOffense,
            btnNavSanctions,
            btnNavSearch,
            btnNavClearance
        }

        For Each btn As Button In navButtons
            If btn Is activeBtn Then
                btn.BackColor = Color.FromArgb(29, 63, 158)
                btn.ForeColor = Color.White
            Else
                btn.BackColor = Color.FromArgb(24, 43, 92)
                btn.ForeColor = Color.FromArgb(226, 232, 240)
            End If
        Next
    End Sub

    ' Pulls non-header controls up so hiding panelHeader leaves no empty gap
    Private Sub PullHostedControlsUp(uc As UserControl)
        Dim headerCtrl As Control = uc.Controls.Find("panelHeader", True).FirstOrDefault()
        If headerCtrl IsNot Nothing Then
            headerCtrl.Visible = False
        End If

        Const targetTopMargin As Integer = 14
        Dim minCurrentTop As Integer = Integer.MaxValue

        For Each ctrl As Control In uc.Controls
            If ctrl IsNot headerCtrl AndAlso ctrl.Visible Then
                If ctrl.Top < minCurrentTop Then
                    minCurrentTop = ctrl.Top
                End If
            End If
        Next

        If minCurrentTop = Integer.MaxValue OrElse minCurrentTop <= targetTopMargin Then Return

        Dim deltaY As Integer = minCurrentTop - targetTopMargin
        For Each ctrl As Control In uc.Controls
            If ctrl IsNot headerCtrl Then
                ctrl.Top -= deltaY
                If (ctrl.Anchor And AnchorStyles.Bottom) = AnchorStyles.Bottom Then
                    ctrl.Height += deltaY
                End If
            End If
        Next
    End Sub

    ' Hosts a UserControl inside panelContentHost without duplicate headers or top blank space
    Private Sub ShowUserControl(uc As UserControl, titleText As String, subtitleText As String)
        lblFormTitle.Text = titleText
        lblFormSubtitle.Text = subtitleText
        panelDashboardOverview.Visible = False

        If currentUserControl IsNot Nothing Then
            panelContentHost.Controls.Remove(currentUserControl)
            currentUserControl.Dispose()
            currentUserControl = Nothing
        End If

        uc.Dock = DockStyle.Fill
        currentUserControl = uc
        panelContentHost.Controls.Add(currentUserControl)
        PullHostedControlsUp(currentUserControl)
        currentUserControl.BringToFront()
    End Sub

    Public Sub RefreshDashboardOverview()
        lblFormTitle.Text = "Disciplinary Dashboard"
        lblFormSubtitle.Text = "Monitor active student offenses, sanction progress, and clearance readiness."

        If currentUserControl IsNot Nothing Then
            panelContentHost.Controls.Remove(currentUserControl)
            currentUserControl.Dispose()
            currentUserControl = Nothing
        End If

        panelDashboardOverview.Visible = True
        panelDashboardOverview.BringToFront()

        Try
            LoadOverviewCounts()
            LoadRecentRecords()
        Catch ex As Exception
            MessageBox.Show("Failed to refresh dashboard data: " & ex.Message, "Database Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LoadOverviewCounts()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM offense_logs WHERE record_status = 'Active'", conn)
                lblCountTotalLogs.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0")
            End Using

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM sanctions sn INNER JOIN offense_logs o ON sn.log_id = o.log_id WHERE o.record_status = 'Active' AND sn.status IN ('Pending', 'Escalated')", conn)
                lblCountPendingSanctions.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0")
            End Using

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM sanctions sn INNER JOIN offense_logs o ON sn.log_id = o.log_id WHERE o.record_status = 'Active' AND sn.status = 'Cleared'", conn)
                lblCountCleared.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0")
            End Using

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM sanctions sn INNER JOIN offense_logs o ON sn.log_id = o.log_id WHERE o.record_status = 'Active' AND sn.status = 'Overdue'", conn)
                lblCountOverdueCases.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0")
            End Using
        End Using
    End Sub

    ' Loads recent offense/sanction rows using s.section instead of year_level
    Private Sub LoadRecentRecords()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String = "SELECT o.log_id, s.student_id, " &
                                "TRIM(CONCAT(s.last_name, ', ', s.first_name, ' ', COALESCE(s.middle_name, ''))) AS student_name, " &
                                "COALESCE(s.section, '') AS section, " &
                                "o.offense_type, " &
                                "COALESCE(sn.status, 'Pending') AS status " &
                                "FROM offense_logs o " &
                                "INNER JOIN students s ON o.student_id = s.student_id " &
                                "LEFT JOIN sanctions sn ON sn.log_id = o.log_id " &
                                "WHERE o.record_status = 'Active' " &
                                "ORDER BY o.log_id DESC LIMIT 25"

            Using adapter As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgvRecentLogs.AutoGenerateColumns = False
                colRecentLogID.DataPropertyName = "log_id"
                colRecentStudentID.DataPropertyName = "student_id"
                colRecentStudentName.DataPropertyName = "student_name"
                colRecentSection.DataPropertyName = "section"
                colRecentOffense.DataPropertyName = "offense_type"
                colRecentStatus.DataPropertyName = "status"

                dgvRecentLogs.DataSource = dt
                StyleStatusCells()
            End Using
        End Using
    End Sub

    Private Sub StyleStatusCells()
        For Each row As DataGridViewRow In dgvRecentLogs.Rows
            Dim statusText As String = Convert.ToString(row.Cells("colRecentStatus").Value)
            Select Case statusText
                Case "Cleared", "Completed"
                    row.Cells("colRecentStatus").Style.ForeColor = Color.FromArgb(21, 128, 61)
                Case "Pending", "In-progress"
                    row.Cells("colRecentStatus").Style.ForeColor = Color.FromArgb(29, 63, 158)
                Case "Escalated"
                    row.Cells("colRecentStatus").Style.ForeColor = Color.FromArgb(180, 83, 9)
                Case "Overdue"
                    row.Cells("colRecentStatus").Style.ForeColor = Color.FromArgb(185, 28, 28)
            End Select
        Next
    End Sub

    ' Exports disciplinary records using MariaDB/MySQL backtick aliases and s.section
    Private Function GetExportRecordsTable() As DataTable
        Dim dt As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String = "SELECT s.student_id AS `Student ID`, " &
                                "TRIM(CONCAT(s.last_name, ', ', s.first_name, ' ', COALESCE(s.middle_name, ''))) AS `Student Name`, " &
                                "COALESCE(s.department, '') AS `Department`, " &
                                "COALESCE(s.section, '') AS `Section`, " &
                                "o.offense_type AS `Offense`, " &
                                "o.warning_level AS `Warning Level`, " &
                                "o.incident_date AS `Incident Date`, " &
                                "COALESCE(sn.status, 'Pending') AS `Sanction Status` " &
                                "FROM offense_logs o " &
                                "INNER JOIN students s ON o.student_id = s.student_id " &
                                "LEFT JOIN sanctions sn ON sn.log_id = o.log_id " &
                                "WHERE o.record_status = 'Active' " &
                                "ORDER BY o.log_id DESC"

            Using adapter As New MySqlDataAdapter(sql, conn)
                adapter.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Private Sub ExportRecordsToCsv()
        Try
            Dim dt As DataTable = GetExportRecordsTable()
            Using sfd As New SaveFileDialog()
                sfd.Filter = "CSV Files (*.csv)|*.csv"
                sfd.FileName = $"QCU_Disciplinary_Records_{DateTime.Now:yyyyMMdd}.csv"

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim sb As New StringBuilder()
                    Dim headers = dt.Columns.Cast(Of DataColumn)().Select(Function(col) EscapeCsvField(col.ColumnName))
                    sb.AppendLine(String.Join(",", headers))

                    For Each row As DataRow In dt.Rows
                        Dim fields = dt.Columns.Cast(Of DataColumn)().Select(Function(col) EscapeCsvField(Convert.ToString(row(col))))
                        sb.AppendLine(String.Join(",", fields))
                    Next

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
                    MessageBox.Show("Records exported successfully with Section column.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to export records: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function EscapeCsvField(value As String) As String
        If value Is Nothing Then value = ""
        Dim escaped As String = value.Replace("""", """""")
        Return $"""{escaped}"""
    End Function

    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        SetActiveNavButton(btnNavDashboard)
        RefreshDashboardOverview()
    End Sub

    Private Sub btnNavLogOffense_Click(sender As Object, e As EventArgs) Handles btnNavLogOffense.Click
        SetActiveNavButton(btnNavLogOffense)
        ShowUserControl(New UcLogOffense(), "Log Student Offense", "Record student infractions, warning levels, and sanctions.")
    End Sub

    Private Sub btnNavSanctions_Click(sender As Object, e As EventArgs) Handles btnNavSanctions.Click
        SetActiveNavButton(btnNavSanctions)
        ShowUserControl(New UcSanctionTracker(), "Active Sanction Monitoring & Reconciliation", "Track active sanctions, update student progress, and manage reconciliation status.")
    End Sub

    Private Sub btnNavSearch_Click(sender As Object, e As EventArgs) Handles btnNavSearch.Click
        SetActiveNavButton(btnNavSearch)
        ShowUserControl(New UcSearchRecords(), "Search Disciplinary Records", "Search logged student infractions by ID, name, department, offense, or sanction status.")
    End Sub

    Private Sub btnNavClearance_Click(sender As Object, e As EventArgs) Handles btnNavClearance.Click
        SetActiveNavButton(btnNavClearance)
        ShowUserControl(New UcClearanceGenerator(), "Disciplinary Clearance Generator", "Verify disciplinary clearance eligibility and print the official Clearance Certificate document.")
    End Sub

    Private Sub btnExportCsv_Click(sender As Object, e As EventArgs) Handles btnExportCsv.Click
        ExportRecordsToCsv()
    End Sub

End Class