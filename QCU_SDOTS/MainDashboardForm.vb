Imports MySql.Data.MySqlClient

Public Class MainDashboardForm

    Private Sub MainDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load statistics and recent activity when the dashboard opens
        LoadDashboardStatistics()
        LoadRecentViolations()
    End Sub

    Private Sub LoadDashboardStatistics()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' 1. Get Total Infractions Count
                Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM offense_logs", conn)
                Dim totalInfractions As Integer = Convert.ToInt32(cmdTotal.ExecuteScalar())
                lblTotalInfractions.Text = totalInfractions.ToString()

                ' 2. Get Pending Sanctions Count
                Dim cmdPending As New MySqlCommand("SELECT COUNT(*) FROM sanctions WHERE status = 'Pending'", conn)
                Dim pendingSanctions As Integer = Convert.ToInt32(cmdPending.ExecuteScalar())
                lblPendingSanctions.Text = pendingSanctions.ToString()

                ' 3. Get Active Violations Count (e.g., Severe or Major)
                Dim cmdActive As New MySqlCommand("SELECT COUNT(*) FROM offense_logs WHERE severity IN ('Major', 'Severe')", conn)
                Dim activeViolations As Integer = Convert.ToInt32(cmdActive.ExecuteScalar())
                lblClearanceIssued.Text = activeViolations.ToString()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading dashboard statistics: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadRecentViolations()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Query joining offense_logs and students to get names
                Dim query As String = "SELECT o.log_id, CONCAT(s.first_name, ' ', s.last_name) AS student_name, o.offense_type, o.offense_date, o.severity " &
                                      "FROM offense_logs o " &
                                      "JOIN students s ON o.student_id = s.student_id " &
                                      "ORDER BY o.offense_date DESC LIMIT 10"

                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Bind data to your DataGridView (make sure your grid is named dgvRecentViolations)
                    dgvRecentViolations.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading recent violations: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class