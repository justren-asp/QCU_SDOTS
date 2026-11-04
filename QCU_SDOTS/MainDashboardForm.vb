Imports MySql.Data.MySqlClient

Partial Public Class MainDashboardForm

    Private Sub MainDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup initial panel view and highlight dashboard navigation
        panelDashboardView.Visible = True
        UpdateSidebarNavigation(btnDashboardSidebar)

        ' Load statistics and list views
        RefreshDashboardData()
    End Sub

    ' ==========================================
    ' NAVIGATION & STYLING
    ' ==========================================

    Private Sub UpdateSidebarNavigation(activeBtn As Button)
        ' Navigation color configuration matching your theme
        Dim activeColor As Color = Color.FromArgb(37, 99, 235)   ' Royal Blue
        Dim defaultColor As Color = Color.FromArgb(30, 41, 59)  ' Dark Sidebar Neutral
        Dim activeTextColor As Color = Color.White
        Dim defaultTextColor As Color = Color.LightGray

        ' Reset all nav buttons to default state
        btnDashboardSidebar.BackColor = defaultColor
        btnDashboardSidebar.ForeColor = defaultTextColor
        btnLogOffenseSidebar.BackColor = defaultColor
        btnLogOffenseSidebar.ForeColor = defaultTextColor

        ' Highlight the currently active button
        If activeBtn IsNot Nothing Then
            activeBtn.BackColor = activeColor
            activeBtn.ForeColor = activeTextColor
        End If
    End Sub

    Private Sub btnDashboardSidebar_Click(sender As Object, e As EventArgs) Handles btnDashboardSidebar.Click
        UpdateSidebarNavigation(btnDashboardSidebar)
        panelDashboardView.Visible = True

        ' Clean up user controls to prevent memory leaks
        RemoveLogOffenseControl()

        ' Refresh stats and data tables
        RefreshDashboardData()
    End Sub

    Private Sub btnLogOffenseSidebar_Click(sender As Object, e As EventArgs) Handles btnLogOffenseSidebar.Click
        UpdateSidebarNavigation(btnLogOffenseSidebar)
        panelDashboardView.Visible = False

        ' Inject Log Offense user control dynamically if not already active
        Dim currentControl = GetActiveLogOffenseControl()
        If currentControl Is Nothing Then
            Dim ucLog As New UcLogOffense()
            ucLog.Dock = DockStyle.Fill
            panelMainContent.Controls.Add(ucLog)
            ucLog.BringToFront()
        Else
            currentControl.BringToFront()
        End If
    End Sub

    Private Sub btnQuickLog_Click(sender As Object, e As EventArgs) Handles btnQuickLog.Click
        btnLogOffenseSidebar_Click(sender, e)
    End Sub

    ' ==========================================
    ' DATA LOADING METHODS
    ' ==========================================

    Public Sub RefreshDashboardData()
        LoadDashboardStatistics()
        LoadRecentViolations()
        LoadTopViolations()
    End Sub

    Private Sub LoadDashboardStatistics()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Total Infractions Count
                Dim sqlTotal As String = "SELECT COUNT(*) FROM offense_logs"
                Using cmd As New MySqlCommand(sqlTotal, conn)
                    Dim totalCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If lblTotalInfractions IsNot Nothing Then
                        lblTotalInfractions.Text = totalCount.ToString("N0")
                    End If
                End Using

                ' Pending Sanctions Count
                Dim sqlPending As String = "SELECT COUNT(*) FROM sanctions WHERE status = 'Pending'"
                Using cmd As New MySqlCommand(sqlPending, conn)
                    Dim pendingCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If lblPendingSanctions IsNot Nothing Then
                        lblPendingSanctions.Text = pendingCount.ToString("N0")
                    End If
                End Using

                ' Clearances Issued Count
                Dim sqlClearance As String = "SELECT COUNT(*) FROM sanctions WHERE status = 'Cleared'"
                Using cmd As New MySqlCommand(sqlClearance, conn)
                    Dim clearedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If lblClearanceIssued IsNot Nothing Then
                        lblClearanceIssued.Text = clearedCount.ToString("N0")
                    End If
                End Using

                ' Active Major/Severe Violations Count
                Dim sqlActive As String = "SELECT COUNT(*) FROM offense_logs WHERE severity IN ('Major', 'Severe')"
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

                ' Uses created_at matching your updated MySQL schema
                Dim sql As String = "SELECT o.log_id, o.student_id, CONCAT(s.first_name, ' ', s.last_name) AS student_name, " &
                                     "o.offense_type, DATE_FORMAT(o.created_at, '%m/%d/%Y') AS date_logged, " &
                                     "COALESCE(sn.status, 'Logged') AS status " &
                                     "FROM offense_logs o " &
                                     "INNER JOIN students s ON o.student_id = s.student_id " &
                                     "LEFT JOIN sanctions sn ON o.log_id = sn.log_id " &
                                     "ORDER BY o.created_at DESC LIMIT 15"

                Using adapter As New MySqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvRecentViolations.AutoGenerateColumns = False

                    If dgvRecentViolations.Columns.Contains("colRecordID") Then dgvRecentViolations.Columns("colRecordID").DataPropertyName = "log_id"
                    If dgvRecentViolations.Columns.Contains("colStudentID") Then dgvRecentViolations.Columns("colStudentID").DataPropertyName = "student_id"
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
                                     "FROM offense_logs " &
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

    ' ==========================================
    ' CONTROL HELPERS
    ' ==========================================

    Private Function GetActiveLogOffenseControl() As UcLogOffense
        For Each c As Control In panelMainContent.Controls
            If TypeOf c Is UcLogOffense Then
                Return CType(c, UcLogOffense)
            End If
        Next
        Return Nothing
    End Function

    Private Sub RemoveLogOffenseControl()
        Dim target = GetActiveLogOffenseControl()
        If target IsNot Nothing Then
            panelMainContent.Controls.Remove(target)
            target.Dispose()
        End If
    End Sub

End Class