Imports MySql.Data.MySqlClient

Public Class LoginForm

    ' Shared session variables across forms
    Public Shared CurrentUserID As Integer = 0
    Public Shared CurrentUsername As String = ""
    Public Shared CurrentFullName As String = ""
    Public Shared CurrentUserRole As String = ""

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' 1. Basic Input Validation
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Authenticate Against Database using GetConnection()
        Try
            ' Using statement automatically handles connection lifecycle management
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT user_id, username, password_hash, full_name, role FROM users WHERE username = @username AND password_hash = @password LIMIT 1"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Save session details globally
                            CurrentUserID = Convert.ToInt32(reader("user_id"))
                            CurrentUsername = reader("username").ToString()
                            CurrentFullName = reader("full_name").ToString()
                            CurrentUserRole = reader("role").ToString()

                            MessageBox.Show($"Welcome, {CurrentFullName}! Role: {CurrentUserRole}", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' 3. Open Main Dashboard and Hide Login
                            Dim dashboard As New MainDashboardForm()
                            dashboard.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPassword.Clear()
                            txtPassword.Focus()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Show / Hide Password Checkbox Logic
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class