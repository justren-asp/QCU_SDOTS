Imports System.Text
Imports MySql.Data.MySqlClient

Public Class UcSearchRecords

    Private Sub UcSearchRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFilterDropdowns()
        LoadFilteredRecords()
    End Sub

    Private Sub PopulateFilterDropdowns()
        cboDepartment.Items.Clear()
        cboDepartment.Items.AddRange(New Object() {
            "All Departments",
            "College of Computer Studies (BSIT)",
            "College of Computer Studies (BSIS)",
            "College of Engineering (BSCpE)",
            "College of Business Administration (BSBA)",
            "College of Education (BSED)"
        })
        cboDepartment.SelectedIndex = 0

        cboSeverity.Items.Clear()
        cboSeverity.Items.AddRange(New Object() {
            "All Severities",
            "Minor",
            "Major",
            "Severe"
        })
        cboSeverity.SelectedIndex = 0

        cboDateRange.Items.Clear()
        cboDateRange.Items.AddRange(New Object() {
            "This School Term",
            "Last 7 Days",
            "Last 30 Days",
            "All Dates"
        })
        cboDateRange.SelectedIndex = 0
    End Sub

    Private Sub btnSearchRecords_Click(sender As Object, e As EventArgs) Handles btnSearchRecords.Click
        LoadFilteredRecords()
    End Sub

    Private Sub txtSearchKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadFilteredRecords()
        End If
    End Sub

    Public Sub LoadFilteredRecords()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As New StringBuilder()
                sql.Append("SELECT o.log_id, o.student_id, ")
                sql.Append("TRIM(CONCAT(s.last_name, ', ', s.first_name, ' ', COALESCE(s.middle_name, ''))) AS student_name, ")
                sql.Append("s.department, o.offense_type, o.severity, ")
                sql.Append("DATE_FORMAT(o.created_at, '%b %d, %Y') AS date_logged, ")
                sql.Append("COALESCE(sn.status, 'Logged') AS status ")
                sql.Append("FROM offense_logs o ")
                sql.Append("INNER JOIN students s ON o.student_id = s.student_id ")
                sql.Append("LEFT JOIN sanctions sn ON o.log_id = sn.log_id ")
                sql.Append("WHERE o.record_status = 'Active' ")

                Dim cmd As New MySqlCommand()
                cmd.Connection = conn

                Dim keyword As String = txtSearchKeyword.Text.Trim()
                If keyword <> "" Then
                    sql.Append("AND (o.student_id LIKE @kw OR s.last_name LIKE @kw OR s.first_name LIKE @kw OR CAST(o.log_id AS CHAR) LIKE @kw) ")
                    cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                End If

                If cboDepartment.SelectedIndex > 0 Then
                    sql.Append("AND s.department = @dept ")
                    cmd.Parameters.AddWithValue("@dept", cboDepartment.SelectedItem.ToString())
                End If

                If cboSeverity.SelectedIndex > 0 Then
                    sql.Append("AND o.severity = @sev ")
                    cmd.Parameters.AddWithValue("@sev", cboSeverity.SelectedItem.ToString())
                End If

                Select Case cboDateRange.SelectedItem?.ToString()
                    Case "Last 7 Days"
                        sql.Append("AND o.created_at >= DATE_SUB(NOW(), INTERVAL 7 DAY) ")
                    Case "Last 30 Days"
                        sql.Append("AND o.created_at >= DATE_SUB(NOW(), INTERVAL 30 DAY) ")
                End Select

                sql.Append("ORDER BY o.log_id DESC")
                cmd.CommandText = sql.ToString()

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvRecords.AutoGenerateColumns = False
                    colRecordID.DataPropertyName = "log_id"
                    colStudentID.DataPropertyName = "student_id"
                    colStudentName.DataPropertyName = "student_name"
                    colDepartment.DataPropertyName = "department"
                    colOffense.DataPropertyName = "offense_type"
                    colSeverity.DataPropertyName = "severity"
                    colDateLogged.DataPropertyName = "date_logged"
                    colStatus.DataPropertyName = "status"

                    dgvRecords.DataSource = dt
                    StyleGridRows()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to search offense records: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StyleGridRows()
        For Each row As DataGridViewRow In dgvRecords.Rows
            Dim sevText As String = Convert.ToString(row.Cells("colSeverity").Value)
            Select Case sevText
                Case "Minor"
                    row.Cells("colSeverity").Style.ForeColor = Color.FromArgb(202, 138, 4)
                Case "Major", "Severe"
                    row.Cells("colSeverity").Style.ForeColor = Color.FromArgb(185, 28, 28)
            End Select

            Dim statusText As String = Convert.ToString(row.Cells("colStatus").Value)
            Select Case statusText
                Case "Cleared"
                    row.Cells("colStatus").Style.ForeColor = Color.FromArgb(21, 128, 61)
                Case "Pending"
                    row.Cells("colStatus").Style.ForeColor = Color.FromArgb(180, 83, 9)
                Case Else
                    row.Cells("colStatus").Style.ForeColor = Color.FromArgb(29, 78, 216)
            End Select
        Next
    End Sub

    Private Sub dgvRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellContentClick
        If e.RowIndex < 0 Then Return
        If dgvRecords.Columns(e.ColumnIndex).Name <> "colAction" Then Return

        Dim row As DataGridViewRow = dgvRecords.Rows(e.RowIndex)
        Dim recordId As String = Convert.ToString(row.Cells("colRecordID").Value)

        ShowRecordDetails(recordId)
    End Sub

    Private Sub ShowRecordDetails(recordId As String)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT o.log_id, o.student_id, " &
                                     "TRIM(CONCAT(s.last_name, ', ', s.first_name, ' ', COALESCE(s.middle_name, ''))) AS full_name, " &
                                     "s.department, s.year_level, o.offense_type, o.custom_specification, " &
                                     "o.severity, o.warning_level, o.incident_date, o.incident_time, o.remarks, " &
                                     "COALESCE(sn.sanction_type, 'None') AS sanction_type, " &
                                     "COALESCE(sn.status, 'Logged') AS sanction_status " &
                                     "FROM offense_logs o " &
                                     "INNER JOIN students s ON o.student_id = s.student_id " &
                                     "LEFT JOIN sanctions sn ON o.log_id = sn.log_id " &
                                     "WHERE o.log_id = @id LIMIT 1"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", recordId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim details As New StringBuilder()
                            details.AppendLine($"Record ID: {reader("log_id")}")
                            details.AppendLine($"Student: {reader("full_name")} ({reader("student_id")})")
                            details.AppendLine($"Department / Year: {reader("department")} - {reader("year_level")}")
                            details.AppendLine($"Offense: {reader("offense_type")}")
                            If Convert.ToString(reader("custom_specification")) <> "" Then
                                details.AppendLine($"Specification: {reader("custom_specification")}")
                            End If
                            details.AppendLine($"Severity: {reader("severity")} ({reader("warning_level")})")
                            details.AppendLine($"Incident Date/Time: {reader("incident_date")} {reader("incident_time")}")
                            details.AppendLine($"Sanction: {reader("sanction_type")} [{reader("sanction_status")}]")
                            details.AppendLine($"Remarks: {reader("remarks")}")

                            MessageBox.Show(details.ToString(), "Offense Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to load record details: " & ex.Message, "Details Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class