Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private baseTops As New Dictionary(Of Control, Integer)()
    Private baseBottomOffsets As New Dictionary(Of Control, Integer)()
    Private layoutInitialized As Boolean = False

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.White
        txtPassword.UseSystemPasswordChar = True

        CaptureLayoutBaselines()
        ApplyCenterSplitAlignment()
    End Sub

    Private Sub LoginForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ApplyCenterSplitAlignment()
    End Sub

    Private Sub CaptureLayoutBaselines()
        If layoutInitialized Then Return

        Dim leftControls As Control() = {
            PictureBox1, Label2, Label3, Label4, txtUsername,
            Label5, txtPassword, chkShowPassword, btnLogin, Panel1, Label6
        }

        For Each ctrl In leftControls
            If ctrl IsNot Nothing Then
                baseTops(ctrl) = ctrl.Top
            End If
        Next

        If panelBanner IsNot Nothing Then
            For Each bannerCtrl As Control In New Control() {Panel2, Label1, Label8}
                If bannerCtrl IsNot Nothing Then
                    baseBottomOffsets(bannerCtrl) = panelBanner.Height - bannerCtrl.Top
                End If
            Next
        End If

        layoutInitialized = True
    End Sub

    Private Sub ApplyCenterSplitAlignment()
        If Not layoutInitialized Then CaptureLayoutBaselines()
        If Me.ClientSize.Width <= 0 OrElse Me.ClientSize.Height <= 0 Then Return

        ' Split screen evenly at the center (left half = white column, right half = banner)
        Dim leftWidth As Integer = Me.ClientSize.Width \ 2
        Dim leftCenterX As Integer = leftWidth \ 2

        Dim groupHeight As Integer = 450
        Dim topStart As Integer = Math.Max(36, (Me.ClientSize.Height - groupHeight) \ 2)
        Dim topShift As Integer = topStart - 110

        For Each pair In baseTops
            Dim ctrl As Control = pair.Key
            If ctrl IsNot Nothing Then
                ctrl.Top = pair.Value + topShift
                ctrl.Left = leftCenterX - (ctrl.Width \ 2)
            End If
        Next

        Dim fieldWidth As Integer = Math.Min(360, Math.Max(280, leftWidth - 140))
        Dim fieldLeft As Integer = leftCenterX - (fieldWidth \ 2)

        txtUsername.Width = fieldWidth
        txtUsername.Left = fieldLeft

        txtPassword.Width = fieldWidth
        txtPassword.Left = fieldLeft

        btnLogin.Width = fieldWidth
        btnLogin.Left = fieldLeft

        Panel1.Width = fieldWidth
        Panel1.Left = fieldLeft

        chkShowPassword.Left = fieldLeft
        Label4.Left = fieldLeft
        Label5.Left = fieldLeft

        If panelBanner IsNot Nothing Then
            panelBanner.Location = New Point(leftWidth, 0)
            panelBanner.Size = New Size(Me.ClientSize.Width - leftWidth, Me.ClientSize.Height)

            For Each pair In baseBottomOffsets
                Dim bCtrl As Control = pair.Key
                If bCtrl IsNot Nothing Then
                    bCtrl.Left = 40
                    bCtrl.Top = Math.Max(40, panelBanner.Height - pair.Value)
                End If
            Next
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim sql As String = "SELECT user_id, role FROM users WHERE username = @user AND password = @pass LIMIT 1"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim dash As New MainDashboardForm()
                            dash.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid username or password.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Application.OpenForms.Count = 0 Then
            Application.Exit()
        End If
    End Sub

End Class