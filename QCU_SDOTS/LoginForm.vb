Imports System.IO
Imports MySql.Data.MySqlClient

Partial Public Class LoginForm

    Private ReadOnly RememberFilePath As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "QCU_SDOTS",
        "remember_user.txt"
    )

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnLogin
        lblStatusMessage.Text = ""
        ConfigurePhotoOverlay()
        LoadRememberedUser()
    End Sub

    Private Sub ConfigurePhotoOverlay()
        lblQuoteText.Parent = picCampusBg
        lblQuoteOffice.Parent = picCampusBg
        panelAccentBar.Parent = picCampusBg
        lblQuoteText.BackColor = Color.Transparent
        lblQuoteOffice.BackColor = Color.Transparent
        lblQuoteText.ForeColor = Color.White
        lblQuoteOffice.ForeColor = Color.FromArgb(241, 245, 249)
        panelAccentBar.BackColor = Color.FromArgb(245, 183, 0)
    End Sub

    Private Sub LoadRememberedUser()
        Try
            If File.Exists(RememberFilePath) Then
                Dim savedUser As String = File.ReadAllText(RememberFilePath).Trim()
                If savedUser <> "" Then
                    txtUsername.Text = savedUser
                    chkRememberMe.Checked = True
                    txtPassword.Focus()
                    Return
                End If
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("LoadRememberedUser error: " & ex.Message)
        End Try

        chkRememberMe.Checked = False
        txtUsername.Focus()
    End Sub

    Private Sub SaveOrClearRememberedUser(username As String)
        Try
            Dim folderPath As String = Path.GetDirectoryName(RememberFilePath)
            If chkRememberMe.Checked Then
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
                File.WriteAllText(RememberFilePath, username.Trim())
            Else
                If File.Exists(RememberFilePath) Then
                    File.Delete(RememberFilePath)
                End If
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("SaveOrClearRememberedUser error: " & ex.Message)
        End Try
    End Sub

    Private Sub InputBox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblStatusMessage.Text = ""

        Dim usernameInput As String = txtUsername.Text.Trim()
        Dim passwordInput As String = txtPassword.Text

        If usernameInput = "" Then
            lblStatusMessage.Text = "Please enter your Username / User ID."
            txtUsername.Focus()
            Return
        End If

        If passwordInput = "" Then
            lblStatusMessage.Text = "Please enter your password."
            txtPassword.Focus()
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT user_id, username, full_name, role, is_active " &
                                     "FROM users " &
                                     "WHERE username = @user AND password_hash = @pass LIMIT 1"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@user", usernameInput)
                    cmd.Parameters.AddWithValue("@pass", passwordInput)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim isActive As Integer = If(IsDBNull(reader("is_active")), 1, Convert.ToInt32(reader("is_active")))
                            If isActive = 0 Then
                                lblStatusMessage.Text = "This account is inactive. Contact the administrator."
                                Return
                            End If

                            Dim fullName As String = Convert.ToString(reader("full_name"))
                            Dim roleName As String = Convert.ToString(reader("role"))
                            Dim loggedUser As String = Convert.ToString(reader("username"))

                            SaveOrClearRememberedUser(loggedUser)

                            Dim dashboard As New MainDashboardForm()
                            dashboard.lblLoggedUser.Text = $"{fullName} ({roleName})"
                            dashboard.Show()
                            Me.Hide()
                        Else
                            lblStatusMessage.Text = "Invalid username or password."
                            txtPassword.SelectAll()
                            txtPassword.Focus()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            lblStatusMessage.Text = "Database connection failed: " & ex.Message
        End Try
    End Sub

End Class