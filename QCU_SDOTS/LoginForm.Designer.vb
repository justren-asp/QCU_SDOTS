<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpLoginSplit = New System.Windows.Forms.TableLayoutPanel()
        Me.panelFormLeft = New System.Windows.Forms.Panel()
        Me.panelFormCenter = New System.Windows.Forms.Panel()
        Me.lblAuthNotice = New System.Windows.Forms.Label()
        Me.lblStatusMessage = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkRememberMe = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblBrandSub = New System.Windows.Forms.Label()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.picQcuLogo = New System.Windows.Forms.PictureBox()
        Me.panelPhotoRight = New System.Windows.Forms.Panel()
        Me.panelAccentBar = New System.Windows.Forms.Panel()
        Me.lblQuoteOffice = New System.Windows.Forms.Label()
        Me.lblQuoteText = New System.Windows.Forms.Label()
        Me.picCampusBg = New System.Windows.Forms.PictureBox()
        Me.tlpLoginSplit.SuspendLayout()
        Me.panelFormLeft.SuspendLayout()
        Me.panelFormCenter.SuspendLayout()
        CType(Me.picQcuLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPhotoRight.SuspendLayout()
        CType(Me.picCampusBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLoginSplit
        '
        Me.tlpLoginSplit.ColumnCount = 2
        Me.tlpLoginSplit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0!))
        Me.tlpLoginSplit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.0!))
        Me.tlpLoginSplit.Controls.Add(Me.panelFormLeft, 0, 0)
        Me.tlpLoginSplit.Controls.Add(Me.panelPhotoRight, 1, 0)
        Me.tlpLoginSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLoginSplit.Location = New System.Drawing.Point(0, 0)
        Me.tlpLoginSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLoginSplit.Name = "tlpLoginSplit"
        Me.tlpLoginSplit.RowCount = 1
        Me.tlpLoginSplit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLoginSplit.Size = New System.Drawing.Size(1200, 720)
        Me.tlpLoginSplit.TabIndex = 0
        '
        'panelFormLeft
        '
        Me.panelFormLeft.BackColor = System.Drawing.Color.White
        Me.panelFormLeft.Controls.Add(Me.panelFormCenter)
        Me.panelFormLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFormLeft.Location = New System.Drawing.Point(0, 0)
        Me.panelFormLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.panelFormLeft.Name = "panelFormLeft"
        Me.panelFormLeft.Size = New System.Drawing.Size(552, 720)
        Me.panelFormLeft.TabIndex = 0
        '
        'panelFormCenter
        '
        Me.panelFormCenter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelFormCenter.BackColor = System.Drawing.Color.White
        Me.panelFormCenter.Controls.Add(Me.lblAuthNotice)
        Me.panelFormCenter.Controls.Add(Me.lblStatusMessage)
        Me.panelFormCenter.Controls.Add(Me.btnLogin)
        Me.panelFormCenter.Controls.Add(Me.chkRememberMe)
        Me.panelFormCenter.Controls.Add(Me.txtPassword)
        Me.panelFormCenter.Controls.Add(Me.lblPassword)
        Me.panelFormCenter.Controls.Add(Me.txtUsername)
        Me.panelFormCenter.Controls.Add(Me.lblUsername)
        Me.panelFormCenter.Controls.Add(Me.lblBrandSub)
        Me.panelFormCenter.Controls.Add(Me.lblBrandName)
        Me.panelFormCenter.Controls.Add(Me.picQcuLogo)
        Me.panelFormCenter.Location = New System.Drawing.Point(96, 90)
        Me.panelFormCenter.Name = "panelFormCenter"
        Me.panelFormCenter.Size = New System.Drawing.Size(360, 540)
        Me.panelFormCenter.TabIndex = 0
        '
        'lblAuthNotice
        '
        Me.lblAuthNotice.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblAuthNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblAuthNotice.Location = New System.Drawing.Point(0, 416)
        Me.lblAuthNotice.Name = "lblAuthNotice"
        Me.lblAuthNotice.Size = New System.Drawing.Size(360, 20)
        Me.lblAuthNotice.TabIndex = 10
        Me.lblAuthNotice.Text = "AUTHORIZED DISCIPLINE OFFICERS & ADMIN ONLY"
        Me.lblAuthNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatusMessage
        '
        Me.lblStatusMessage.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblStatusMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblStatusMessage.Location = New System.Drawing.Point(12, 362)
        Me.lblStatusMessage.Name = "lblStatusMessage"
        Me.lblStatusMessage.Size = New System.Drawing.Size(336, 36)
        Me.lblStatusMessage.TabIndex = 9
        Me.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(12, 318)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(336, 36)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "LOG IN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'chkRememberMe
        '
        Me.chkRememberMe.AutoSize = True
        Me.chkRememberMe.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.chkRememberMe.Location = New System.Drawing.Point(12, 284)
        Me.chkRememberMe.Name = "chkRememberMe"
        Me.chkRememberMe.Size = New System.Drawing.Size(232, 19)
        Me.chkRememberMe.TabIndex = 7
        Me.chkRememberMe.Text = "Remember credentials on this machine"
        Me.chkRememberMe.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(12, 248)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(336, 24)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(12, 230)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(59, 15)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(12, 192)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(336, 24)
        Me.txtUsername.TabIndex = 4
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(12, 174)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(117, 15)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username / User ID"
        '
        'lblBrandSub
        '
        Me.lblBrandSub.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lblBrandSub.Location = New System.Drawing.Point(0, 134)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Size = New System.Drawing.Size(360, 20)
        Me.lblBrandSub.TabIndex = 2
        Me.lblBrandSub.Text = "Student Disciplinary and Offense Tracking System"
        Me.lblBrandSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrandName
        '
        Me.lblBrandName.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrandName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblBrandName.Location = New System.Drawing.Point(0, 100)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(360, 34)
        Me.lblBrandName.TabIndex = 1
        Me.lblBrandName.Text = "QCU SDOTS"
        Me.lblBrandName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picQcuLogo
        '
        Me.picQcuLogo.Image = Global.QCU_SDOTS.My.Resources.Resources.qcu_logo
        Me.picQcuLogo.Location = New System.Drawing.Point(140, 12)
        Me.picQcuLogo.Name = "picQcuLogo"
        Me.picQcuLogo.Size = New System.Drawing.Size(80, 80)
        Me.picQcuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQcuLogo.TabIndex = 0
        Me.picQcuLogo.TabStop = False
        '
        'panelPhotoRight
        '
        Me.panelPhotoRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.panelPhotoRight.Controls.Add(Me.panelAccentBar)
        Me.panelPhotoRight.Controls.Add(Me.lblQuoteOffice)
        Me.panelPhotoRight.Controls.Add(Me.lblQuoteText)
        Me.panelPhotoRight.Controls.Add(Me.picCampusBg)
        Me.panelPhotoRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPhotoRight.Location = New System.Drawing.Point(552, 0)
        Me.panelPhotoRight.Margin = New System.Windows.Forms.Padding(0)
        Me.panelPhotoRight.Name = "panelPhotoRight"
        Me.panelPhotoRight.Size = New System.Drawing.Size(648, 720)
        Me.panelPhotoRight.TabIndex = 1
        '
        'panelAccentBar
        '
        Me.panelAccentBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelAccentBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelAccentBar.Location = New System.Drawing.Point(34, 534)
        Me.panelAccentBar.Name = "panelAccentBar"
        Me.panelAccentBar.Size = New System.Drawing.Size(44, 4)
        Me.panelAccentBar.TabIndex = 3
        '
        'lblQuoteOffice
        '
        Me.lblQuoteOffice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuoteOffice.AutoSize = True
        Me.lblQuoteOffice.BackColor = System.Drawing.Color.Transparent
        Me.lblQuoteOffice.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblQuoteOffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblQuoteOffice.Location = New System.Drawing.Point(34, 634)
        Me.lblQuoteOffice.Name = "lblQuoteOffice"
        Me.lblQuoteOffice.Size = New System.Drawing.Size(263, 17)
        Me.lblQuoteOffice.TabIndex = 2
        Me.lblQuoteOffice.Text = "QCU Office of Student Affairs and Discipline"
        '
        'lblQuoteText
        '
        Me.lblQuoteText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuoteText.BackColor = System.Drawing.Color.Transparent
        Me.lblQuoteText.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Bold)
        Me.lblQuoteText.ForeColor = System.Drawing.Color.White
        Me.lblQuoteText.Location = New System.Drawing.Point(34, 548)
        Me.lblQuoteText.Name = "lblQuoteText"
        Me.lblQuoteText.Size = New System.Drawing.Size(576, 78)
        Me.lblQuoteText.TabIndex = 1
        Me.lblQuoteText.Text = "Every report, tracked." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Every action, accountable."
        '
        'picCampusBg
        '
        Me.picCampusBg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCampusBg.Image = Global.QCU_SDOTS.My.Resources.Resources.QCU_Image
        Me.picCampusBg.Location = New System.Drawing.Point(0, 0)
        Me.picCampusBg.Name = "picCampusBg"
        Me.picCampusBg.Size = New System.Drawing.Size(648, 720)
        Me.picCampusBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCampusBg.TabIndex = 0
        Me.picCampusBg.TabStop = False
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.tlpLoginSplit)
        Me.MinimumSize = New System.Drawing.Size(960, 620)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU Student Disciplinary and Offense Tracking System [Log In]"
        Me.tlpLoginSplit.ResumeLayout(False)
        Me.panelFormLeft.ResumeLayout(False)
        Me.panelFormCenter.ResumeLayout(False)
        Me.panelFormCenter.PerformLayout()
        CType(Me.picQcuLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPhotoRight.ResumeLayout(False)
        Me.panelPhotoRight.PerformLayout()
        CType(Me.picCampusBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLoginSplit As TableLayoutPanel
    Friend WithEvents panelFormLeft As Panel
    Friend WithEvents panelFormCenter As Panel
    Friend WithEvents lblAuthNotice As Label
    Friend WithEvents lblStatusMessage As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents chkRememberMe As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblBrandSub As Label
    Friend WithEvents lblBrandName As Label
    Friend WithEvents picQcuLogo As PictureBox
    Friend WithEvents panelPhotoRight As Panel
    Friend WithEvents panelAccentBar As Panel
    Friend WithEvents lblQuoteOffice As Label
    Friend WithEvents lblQuoteText As Label
    Friend WithEvents picCampusBg As PictureBox
End Class