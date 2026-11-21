Imports MySql.Data.MySqlClient

Public Class UcSanctionTracker

    Private selectedSanctionId As Integer = 0
    Private selectedLogId As Integer = 0
    Private isUpdatingCheckboxes As Boolean = False

    Private Sub UcSanctionTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnsureSanctionColumnsExist()
        RefreshSanctionTracker()
    End Sub

    ' Safely adds optional tracking columns if not yet present in sanctions table
    Private Sub EnsureSanctionColumnsExist()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                AddColumnIfMissing(conn, "sanctions", "completed_hours", "INT DEFAULT 0")
                AddColumnIfMissing(conn, "sanctions", "required_hours", "INT DEFAULT 20")
                AddColumnIfMissing(conn, "sanctions", "deadline_date", "VARCHAR(25) DEFAULT 'Dec 15, 2026'")
                AddColumnIfMissing(conn, "sanctions", "officer_remarks", "TEXT")
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Column check skipped: " & ex.Message)
        End Try
    End Sub

    Private Sub AddColumnIfMissing(conn As MySqlConnection, tableName As String, colName As String, colDef As String)
        Dim checkSql As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS " &
                               "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @tbl AND COLUMN_NAME = @col"
        Using cmdCheck As New MySqlCommand(checkSql, conn)
            cmdCheck.Parameters.AddWithValue("@tbl", tableName)
            cmdCheck.Parameters.AddWithValue("@col", colName)
            If Convert.ToInt32(cmdCheck.ExecuteScalar()) = 0 Then
                Using cmdAlter As New MySqlCommand($"ALTER TABLE `{tableName}` ADD COLUMN `{colName}` {colDef}", conn)
                    cmdAlter.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub

    Public Sub RefreshSanctionTracker()
        LoadSummaryCounts()
        LoadSanctionLedger()
    End Sub

    Private Sub LoadSummaryCounts()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' In-progress (Pending)
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM sanctions sn INNER JOIN offense_logs o ON sn.log_id = o.log_id WHERE o.record_status = 'Active' AND sn.status = 'Pending'", conn)
                    lblCountInProgress.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0")
                End Using

                ' Escalated board
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM sanctions sn INNER JOIN offense_logs o ON sn.log_id = o.log_id WHERE o.record_status = 'Active' AND sn.status IN ('Escalated', 'Overdue')", conn)
                    lblCountEscalated.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0")
                End Using

                ' Completed / closed (Cleared)
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM sanctions sn INNER JOIN offense_logs o ON sn.log_id = o.log_id WHERE o.record_status = 'Active' AND sn.status = 'Cleared'", conn)
                    lblCountCompleted.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0")
                End Using

                ' Overdue deadline
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM sanctions sn INNER JOIN offense_logs o ON sn.log_id = o.log_id WHERE o.record_status = 'Active' AND sn.status = 'Overdue'", conn)
                    lblCountOverdue.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load sanction summary counts: " & ex.Message, "Database Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LoadSanctionLedger()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT sn.sanction_id, o.log_id, s.student_id, " &
                                     "TRIM(CONCAT(s.last_name, ', ', s.first_name, ' ', COALESCE(s.middle_name, ''))) AS student_name, " &
                                     "sn.sanction_type, " &
                                     "CONCAT(COALESCE(sn.completed_hours, 0), '/', COALESCE(sn.required_hours, 20), ' Hrs') AS progress_metrics, " &
                                     "COALESCE(sn.deadline_date, 'Dec 15, 2026') AS deadline_date, " &
                                     "CASE sn.status " &
                                     "  WHEN 'Pending' THEN 'In-progress' " &
                                     "  WHEN 'Cleared' THEN 'Completed' " &
                                     "  WHEN 'Escalated' THEN 'Escalated' " &
                                     "  WHEN 'Overdue' THEN 'Overdue' " &
                                     "  ELSE sn.status " &
                                     "END AS status_badge, " &
                                     "sn.status AS raw_status, " &
                                     "COALESCE(sn.officer_remarks, o.remarks, '') AS officer_remarks " &
                                     "FROM sanctions sn " &
                                     "INNER JOIN offense_logs o ON sn.log_id = o.log_id " &
                                     "INNER JOIN students s ON o.student_id = s.student_id " &
                                     "WHERE o.record_status = 'Active' " &
                                     "ORDER BY sn.sanction_id DESC"

                Using adapter As New MySqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvSanctions.AutoGenerateColumns = False
                    colSanctionID.DataPropertyName = "sanction_id"
                    colStudentID.DataPropertyName = "student_id"
                    colStudentName.DataPropertyName = "student_name"
                    colSanctionAssigned.DataPropertyName = "sanction_type"
                    colProgressMetrics.DataPropertyName = "progress_metrics"
                    colDeadline.DataPropertyName = "deadline_date"
                    colStatusBadge.DataPropertyName = "status_badge"

                    dgvSanctions.DataSource = dt
                    StyleSanctionRows()

                    If dgvSanctions.Rows.Count > 0 Then
                        PopulateUpdatePanelFromRow(dgvSanctions.Rows(0))
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load sanction ledger: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StyleSanctionRows()
        For Each row As DataGridViewRow In dgvSanctions.Rows
            Dim badgeText As String = Convert.ToString(row.Cells("colStatusBadge").Value)
            Select Case badgeText
                Case "Completed", "Cleared"
                    row.Cells("colStatusBadge").Style.ForeColor = Color.FromArgb(21, 128, 61)
                Case "In-progress", "Pending"
                    row.Cells("colStatusBadge").Style.ForeColor = Color.FromArgb(29, 78, 216)
                Case "Escalated"
                    row.Cells("colStatusBadge").Style.ForeColor = Color.FromArgb(180, 83, 9)
                Case "Overdue"
                    row.Cells("colStatusBadge").Style.ForeColor = Color.FromArgb(185, 28, 28)
            End Select
        Next
    End Sub

    Private Sub dgvSanctions_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSanctions.SelectionChanged
        If dgvSanctions.CurrentRow IsNot Nothing Then
            PopulateUpdatePanelFromRow(dgvSanctions.CurrentRow)
        End If
    End Sub

    Private Sub PopulateUpdatePanelFromRow(row As DataGridViewRow)
        If row Is Nothing OrElse row.DataBoundItem Is Nothing Then Return
        Dim drv As DataRowView = TryCast(row.DataBoundItem, DataRowView)
        If drv Is Nothing Then Return

        selectedSanctionId = Convert.ToInt32(drv("sanction_id"))
        selectedLogId = Convert.ToInt32(drv("log_id"))

        txtSelectedStudentID.Text = Convert.ToString(drv("student_id"))
        numServiceHours.Value = 0
        txtOfficerRemarks.Text = Convert.ToString(drv("officer_remarks"))

        Dim rawStatus As String = Convert.ToString(drv("raw_status"))

        isUpdatingCheckboxes = True
        chkInProgress.Checked = (rawStatus = "Pending")
        chkCompletedClosed.Checked = (rawStatus = "Cleared")
        chkEscalatedBoard.Checked = (rawStatus = "Escalated" OrElse rawStatus = "Overdue")
        isUpdatingCheckboxes = False
    End Sub

    Private Sub StatusCheckbox_CheckedChanged(sender As Object, e As EventArgs) _
        Handles chkInProgress.CheckedChanged, chkCompletedClosed.CheckedChanged, chkEscalatedBoard.CheckedChanged

        If isUpdatingCheckboxes Then Return
        Dim clicked As CheckBox = TryCast(sender, CheckBox)
        If clicked Is Nothing OrElse Not clicked.Checked Then Return

        isUpdatingCheckboxes = True
        If clicked IsNot chkInProgress Then chkInProgress.Checked = False
        If clicked IsNot chkCompletedClosed Then chkCompletedClosed.Checked = False
        If clicked IsNot chkEscalatedBoard Then chkEscalatedBoard.Checked = False
        isUpdatingCheckboxes = False
    End Sub

    Private Sub btnApplyUpdate_Click(sender As Object, e As EventArgs) Handles btnApplyUpdate.Click
        If selectedSanctionId <= 0 Then
            MessageBox.Show("Please select a student sanction record from the ledger first.")
            Return
        End If

        Dim newStatus As String = "Pending"
        If chkCompletedClosed.Checked Then
            newStatus = "Cleared"
        ElseIf chkEscalatedBoard.Checked Then
            newStatus = "Escalated"
        ElseIf chkInProgress.Checked Then
            newStatus = "Pending"
        End If

        Dim addedHours As Integer = CInt(numServiceHours.Value)
        Dim remarksText As String = txtOfficerRemarks.Text.Trim()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "UPDATE sanctions " &
                                     "SET completed_hours = COALESCE(completed_hours, 0) + @hrs, " &
                                     "    status = @status, " &
                                     "    officer_remarks = @remarks " &
                                     "WHERE sanction_id = @sid"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@hrs", addedHours)
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@remarks", remarksText)
                    cmd.Parameters.AddWithValue("@sid", selectedSanctionId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Sanction progress updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshSanctionTracker()
        Catch ex As Exception
            MessageBox.Show("Failed to update sanction progress: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class