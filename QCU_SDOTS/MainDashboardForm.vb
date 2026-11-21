Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Partial Public Class MainDashboardForm

    Private Sub MainDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        panelMainContent.Dock = DockStyle.Fill
        panelDashboardView.Dock = DockStyle.Fill

        ' Hide Student ID in the dashboard preview table and keep Record ID visible
        If dgvRecentViolations.Columns.Contains("colRecordID") Then
            dgvRecentViolations.Columns("colRecordID").Visible = True
        End If
        If dgvRecentViolations.Columns.Contains("colStudentID") Then
            dgvRecentViolations.Columns("colStudentID").Visible = False
        End If

        panelDashboardView.Visible = True
        UpdateSidebarNavigation(btnDashboardSidebar)
        RefreshDashboardData()
    End Sub

    ' ==========================================
    ' SIDEBAR NAVIGATION
    ' ==========================================

    Private Sub UpdateSidebarNavigation(activeBtn As Button)
        Dim activeColor As Color = Color.FromArgb(37, 99, 235)
        Dim defaultColor As Color = Color.FromArgb(30, 41, 59)
        Dim activeTextColor As Color = Color.White
        Dim defaultTextColor As Color = Color.LightGray

        For Each ctrl As Control In panelSidebar.Controls
            If TypeOf ctrl Is Button Then
                Dim navBtn As Button = DirectCast(ctrl, Button)
                navBtn.BackColor = defaultColor
                navBtn.ForeColor = defaultTextColor
            End If
        Next

        If activeBtn IsNot Nothing Then
            activeBtn.BackColor = activeColor
            activeBtn.ForeColor = activeTextColor
        End If
    End Sub

    Private Sub btnDashboardSidebar_Click(sender As Object, e As EventArgs) Handles btnDashboardSidebar.Click
        UpdateSidebarNavigation(btnDashboardSidebar)
        RemoveActiveUserControls()
        panelDashboardView.Visible = True
        panelDashboardView.BringToFront()
        RefreshDashboardData()
    End Sub

    Private Sub btnLogOffenseSidebar_Click(sender As Object, e As EventArgs) Handles btnLogOffenseSidebar.Click
        UpdateSidebarNavigation(btnLogOffenseSidebar)
        panelDashboardView.Visible = False
        ShowUserControl(New UcLogOffense())
    End Sub

    Private Sub btnQuickLog_Click(sender As Object, e As EventArgs) Handles btnQuickLog.Click
        btnLogOffenseSidebar_Click(sender, e)
    End Sub

    Private Sub btnSanctionTrackerSidebar_Click(sender As Object, e As EventArgs) Handles btnSanctionTrackerSidebar.Click
        UpdateSidebarNavigation(btnSanctionTrackerSidebar)
        panelDashboardView.Visible = False
        ShowUserControl(New UcSanctionTracker())
    End Sub

    Private Sub btnSearchRecordsSidebar_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UpdateSidebarNavigation(Button4)
        panelDashboardView.Visible = False
        ShowUserControl(New UcSearchRecords())
    End Sub

    Private Sub btnClearanceSidebar_Click(sender As Object, e As EventArgs) Handles btnClearanceSidebar.Click
        UpdateSidebarNavigation(btnClearanceSidebar)
        panelDashboardView.Visible = False
        ShowUserControl(New UcClearanceGenerator())
    End Sub

    Private Sub btnReportsSidebar_Click(sender As Object, e As EventArgs) Handles btnReportsSidebar.Click
        UpdateSidebarNavigation(btnReportsSidebar)
        ' Exports student/offense records to CSV/Excel for Registrar/Guidance instead of old graph form
        ExportStudentRecordsForRegistrar()
    End Sub

    Private Sub btnLogoutSidebar_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Dim login As New LoginForm()
            login.Show()
            Me.Close()
        End If
    End Sub

    ' ==========================================
    ' REGISTRAR / GUIDANCE DATA EXPORT
    ' ==========================================

    Public Sub ExportStudentRecordsForRegistrar()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Exports student list with separated Last Name, First Name, Middle Name and active status
                Dim sql As String = "SELECT s.student_id AS `Student ID`, s.last_name AS `Last Name`, " &
                                     "s.first_name AS `First Name`, s.middle_name AS `Middle Name`, " &
                                     "s.department AS `Department`, s.year_level AS `Year Level`, " &
                                     "s.record_status AS `Status` " &
                                     "FROM students s " &
                                     "ORDER BY s.last_name ASC, s.first_name ASC"

                Using adapter As New MySqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No student records found to export.")
                        Return
                    End If

                    Using sfd As New SaveFileDialog()
                        sfd.Filter = "CSV File (*.csv)|*.csv"
                        sfd.FileName = $"QCU_Registrar_Student_List_{DateTime.Now:yyyyMMdd}.csv"

                        If sfd.ShowDialog() = DialogResult.OK Then
                            Dim sb As New StringBuilder()

                            ' Write column headers
                            Dim headers As New List(Of String)()
                            For Each col As DataColumn In dt.Columns
                                headers.Add(EscapeCsv(col.ColumnName))
                            Next
                            sb.AppendLine(String.Join(",", headers))

                            ' Write rows
                            For Each row As DataRow In dt.Rows
                                Dim fields As New List(Of String)()
                                For Each col As DataColumn In dt.Columns
                                    fields.Add(EscapeCsv(row(col).ToString()))
                                Next
                                sb.AppendLine(String.Join(",", fields))
                            Next

                            File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
                            MessageBox.Show("Student data exported for Registrar successfully.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error exporting student data: " & ex.Message)
        End Try
    End Sub

    Private Function EscapeCsv(val As String) As String
        Dim clean As String = val.Replace("""", """""")
        Return $"""{clean}"""
    End Function

    ' ==========================================
    ' USER CONTROL & DASHBOARD DATA METHODS
    ' ==========================================

    Private Sub ShowUserControl(uc As UserControl)
        RemoveActiveUserControls()
        uc.Dock = DockStyle.Fill
        panelMainContent.Controls.Add(uc)
        uc.BringToFront()
    End Sub

    Private Sub RemoveActiveUserControls()
        For i As Integer = panelMainContent.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = panelMainContent.Controls(i)
            If TypeOf ctrl Is UserControl Then
                panelMainContent.Controls.RemoveAt(i)
                ctrl.Dispose()
            End If
        Next
    End Sub

    Public Sub RefreshDashboardData()
        LoadDashboardStatistics()
        LoadRecentViolations()
        LoadTopViolations()
    End Sub

    Private Sub LoadDashboardStatistics()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sqlTotal As String = "SELECT COUNT(*) FROM offense_logs WHERE record_status = 'Active'"
                Using cmd As New MySqlCommand(sqlTotal, conn)
                    Dim totalCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If lblTotalInfractions IsNot Nothing Then
                        lblTotalInfractions.Text = totalCount.ToString("N0")
                    End If
                End Using

                Dim sqlPending As String = "SELECT COUNT(*) FROM sanctions sn " &
                                           "INNER JOIN offense_logs o ON sn.log_id = o.log_id " &
                                           "WHERE sn.status = 'Pending' AND o.record_status = 'Active'"
                Using cmd As New MySqlCommand(sqlPending, conn)
                    Dim pendingCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If lblPendingSanctions IsNot Nothing Then
                        lblPendingSanctions.Text = pendingCount.ToString("N0")
                    End If
                End Using

                Dim sqlClearance As String = "SELECT COUNT(*) FROM sanctions sn " &
                                             "INNER JOIN offense_logs o ON sn.log_id = o.log_id " &
                                             "WHERE sn.status = 'Cleared' AND o.record_status = 'Active'"
                Using cmd As New MySqlCommand(sqlClearance, conn)
                    Dim clearedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If lblClearanceIssued IsNot Nothing Then
                        lblClearanceIssued.Text = clearedCount.ToString("N0")
                    End If
                End Using

                Dim sqlActive As String = "SELECT COUNT(*) FROM offense_logs " &
                                          "WHERE severity IN ('Major', 'Severe') AND record_status = 'Active'"
                Using cmd As New MySqlCommand(sqlActive, conn)
                    Dim activeCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If lblActiveViolations IsNot Nothing Then
                        lblActiveViolations.Text = activeCount.ToString("N0")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load summary counters: " & ex.Message, "Database Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LoadRecentViolations()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT o.log_id, o.student_id, " &
                                     "TRIM(CONCAT(s.last_name, ', ', s.first_name, ' ', COALESCE(s.middle_name, ''))) AS student_name, " &
                                     "o.offense_type, DATE_FORMAT(o.created_at, '%m/%d/%Y') AS date_logged, " &
                                     "COALESCE(sn.status, 'Logged') AS status " &
                                     "FROM offense_logs o " &
                                     "INNER JOIN students s ON o.student_id = s.student_id " &
                                     "LEFT JOIN sanctions sn ON o.log_id = sn.log_id " &
                                     "WHERE o.record_status = 'Active' " &
                                     "ORDER BY o.log_id DESC LIMIT 15"

                Using adapter As New MySqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvRecentViolations.AutoGenerateColumns = False

                    If dgvRecentViolations.Columns.Contains("colRecordID") Then
                        dgvRecentViolations.Columns("colRecordID").DataPropertyName = "log_id"
                        dgvRecentViolations.Columns("colRecordID").Visible = True
                    End If
                    If dgvRecentViolations.Columns.Contains("colStudentID") Then
                        dgvRecentViolations.Columns("colStudentID").DataPropertyName = "student_id"
                        dgvRecentViolations.Columns("colStudentID").Visible = False
                    End If
                    If dgvRecentViolations.Columns.Contains("colStudentName") Then dgvRecentViolations.Columns("colStudentName").DataPropertyName = "student_name"
                    If dgvRecentViolations.Columns.Contains("colViolation") Then dgvRecentViolations.Columns("colViolation").DataPropertyName = "offense_type"
                    If dgvRecentViolations.Columns.Contains("colDate") Then dgvRecentViolations.Columns("colDate").DataPropertyName = "date_logged"
                    If dgvRecentViolations.Columns.Contains("colStatus") Then dgvRecentViolations.Columns("colStatus").DataPropertyName = "status"

                    dgvRecentViolations.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to retrieve recent violation logs: " & ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadTopViolations()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT offense_type, COUNT(*) AS total_count " &
                                     "FROM offense_logs WHERE record_status = 'Active' " &
                                     "GROUP BY offense_type " &
                                     "ORDER BY total_count DESC LIMIT 3"

                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim rankingText As String = ""
                        Dim rankIndex As Integer = 1

                        While reader.Read()
                            rankingText &= $"{rankIndex}. {reader("offense_type")} ({reader("total_count")})" & Environment.NewLine
                            rankIndex += 1
                        End While

                        If lblTopViolationsList IsNot Nothing Then
                            If Not String.IsNullOrWhiteSpace(rankingText) Then
                                lblTopViolationsList.Text = rankingText.TrimEnd()
                            Else
                                lblTopViolationsList.Text = "No infraction entries logged yet."
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Top violations fetch failed: " & ex.Message)
        End Try
    End Sub

    Private Sub MainDashboardForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Application.OpenForms.Count = 0 Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Application.Exit()
    End Sub

End Class