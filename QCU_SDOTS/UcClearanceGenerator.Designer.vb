<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcClearanceGenerator
    Inherits System.Windows.Forms.UserControl

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
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelVerifyCard = New System.Windows.Forms.Panel()
        Me.btnVerifyStudent = New System.Windows.Forms.Button()
        Me.txtStudentIDInput = New System.Windows.Forms.TextBox()
        Me.lblEnterStudentIDReq = New System.Windows.Forms.Label()
        Me.lblEnterStudentID = New System.Windows.Forms.Label()
        Me.lblVerifyTitle = New System.Windows.Forms.Label()
        Me.panelStatusCard = New System.Windows.Forms.Panel()
        Me.lblStatusBody = New System.Windows.Forms.Label()
        Me.lblStatusBadge = New System.Windows.Forms.Label()
        Me.lblStatusTitle = New System.Windows.Forms.Label()
        Me.panelParamsCard = New System.Windows.Forms.Panel()
        Me.btnGeneratePrintQueue = New System.Windows.Forms.Button()
        Me.cboSigningAuthority = New System.Windows.Forms.ComboBox()
        Me.lblSigningAuthority = New System.Windows.Forms.Label()
        Me.cboPurpose = New System.Windows.Forms.ComboBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.lblParamsTitle = New System.Windows.Forms.Label()
        Me.panelPreviewOuter = New System.Windows.Forms.Panel()
        Me.btnPrintDocument = New System.Windows.Forms.Button()
        Me.lblPreviewTitle = New System.Windows.Forms.Label()
        Me.panelCertificateSheet = New System.Windows.Forms.Panel()
        Me.lblCertSignatoryName = New System.Windows.Forms.Label()
        Me.lblCertPurposeVal = New System.Windows.Forms.Label()
        Me.lblCertPurposeHdr = New System.Windows.Forms.Label()
        Me.lblCertDateVal = New System.Windows.Forms.Label()
        Me.lblCertDateHdr = New System.Windows.Forms.Label()
        Me.lblCertBody2 = New System.Windows.Forms.Label()
        Me.lblCertBody1 = New System.Windows.Forms.Label()
        Me.lblCertHeading = New System.Windows.Forms.Label()
        Me.lblCertSubOrg = New System.Windows.Forms.Label()
        Me.lblCertUnivName = New System.Windows.Forms.Label()
        Me.picCertSeal = New System.Windows.Forms.PictureBox()
        Me.panelHeader.SuspendLayout()
        Me.panelVerifyCard.SuspendLayout()
        Me.panelStatusCard.SuspendLayout()
        Me.panelParamsCard.SuspendLayout()
        Me.panelPreviewOuter.SuspendLayout()
        Me.panelCertificateSheet.SuspendLayout()
        CType(Me.picCertSeal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.White
        Me.panelHeader.Controls.Add(Me.lblSubtitle)
        Me.panelHeader.Controls.Add(Me.lblTitle)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1180, 74)
        Me.panelHeader.TabIndex = 0
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 44)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(532, 17)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Verify disciplinary clearance eligibility and print the official Clearance Certif" &
    "icate document."
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(24, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(353, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Disciplinary Clearance Generator"
        Me.lblTitle.UseMnemonic = False
        '
        'panelVerifyCard
        '
        Me.panelVerifyCard.BackColor = System.Drawing.Color.White
        Me.panelVerifyCard.Controls.Add(Me.btnVerifyStudent)
        Me.panelVerifyCard.Controls.Add(Me.txtStudentIDInput)
        Me.panelVerifyCard.Controls.Add(Me.lblEnterStudentIDReq)
        Me.panelVerifyCard.Controls.Add(Me.lblEnterStudentID)
        Me.panelVerifyCard.Controls.Add(Me.lblVerifyTitle)
        Me.panelVerifyCard.Location = New System.Drawing.Point(24, 88)
        Me.panelVerifyCard.Name = "panelVerifyCard"
        Me.panelVerifyCard.Size = New System.Drawing.Size(372, 152)
        Me.panelVerifyCard.TabIndex = 1
        '
        'btnVerifyStudent
        '
        Me.btnVerifyStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnVerifyStudent.FlatAppearance.BorderSize = 0
        Me.btnVerifyStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerifyStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnVerifyStudent.ForeColor = System.Drawing.Color.White
        Me.btnVerifyStudent.Location = New System.Drawing.Point(18, 96)
        Me.btnVerifyStudent.Name = "btnVerifyStudent"
        Me.btnVerifyStudent.Size = New System.Drawing.Size(148, 36)
        Me.btnVerifyStudent.TabIndex = 3
        Me.btnVerifyStudent.Text = "Verify Student"
        Me.btnVerifyStudent.UseVisualStyleBackColor = False
        '
        'txtStudentIDInput
        '
        Me.txtStudentIDInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtStudentIDInput.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtStudentIDInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtStudentIDInput.Location = New System.Drawing.Point(18, 59)
        Me.txtStudentIDInput.MaxLength = 7
        Me.txtStudentIDInput.Name = "txtStudentIDInput"
        Me.txtStudentIDInput.Size = New System.Drawing.Size(336, 24)
        Me.txtStudentIDInput.TabIndex = 2
        '
        'lblEnterStudentIDReq
        '
        Me.lblEnterStudentIDReq.AutoSize = True
        Me.lblEnterStudentIDReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblEnterStudentIDReq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblEnterStudentIDReq.Location = New System.Drawing.Point(129, 38)
        Me.lblEnterStudentIDReq.Name = "lblEnterStudentIDReq"
        Me.lblEnterStudentIDReq.Size = New System.Drawing.Size(14, 17)
        Me.lblEnterStudentIDReq.TabIndex = 5
        Me.lblEnterStudentIDReq.Text = "*"
        '
        'lblEnterStudentID
        '
        Me.lblEnterStudentID.AutoSize = True
        Me.lblEnterStudentID.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblEnterStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblEnterStudentID.Location = New System.Drawing.Point(18, 38)
        Me.lblEnterStudentID.Name = "lblEnterStudentID"
        Me.lblEnterStudentID.Size = New System.Drawing.Size(110, 17)
        Me.lblEnterStudentID.TabIndex = 1
        Me.lblEnterStudentID.Text = "Enter Student ID"
        '
        'lblVerifyTitle
        '
        Me.lblVerifyTitle.AutoSize = True
        Me.lblVerifyTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblVerifyTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblVerifyTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblVerifyTitle.Name = "lblVerifyTitle"
        Me.lblVerifyTitle.Size = New System.Drawing.Size(161, 19)
        Me.lblVerifyTitle.TabIndex = 0
        Me.lblVerifyTitle.Text = "Verify Student Records"
        '
        'panelStatusCard
        '
        Me.panelStatusCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.panelStatusCard.Controls.Add(Me.lblStatusBody)
        Me.panelStatusCard.Controls.Add(Me.lblStatusBadge)
        Me.panelStatusCard.Controls.Add(Me.lblStatusTitle)
        Me.panelStatusCard.Location = New System.Drawing.Point(24, 252)
        Me.panelStatusCard.Name = "panelStatusCard"
        Me.panelStatusCard.Size = New System.Drawing.Size(372, 162)
        Me.panelStatusCard.TabIndex = 2
        '
        'lblStatusBody
        '
        Me.lblStatusBody.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblStatusBody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblStatusBody.Location = New System.Drawing.Point(18, 64)
        Me.lblStatusBody.Name = "lblStatusBody"
        Me.lblStatusBody.Size = New System.Drawing.Size(336, 82)
        Me.lblStatusBody.TabIndex = 2
        Me.lblStatusBody.Text = "Enter a Student ID (00-0000) and click Verify Student to check disciplinary stand" &
    "ing and pending sanctions."
        '
        'lblStatusBadge
        '
        Me.lblStatusBadge.AutoSize = True
        Me.lblStatusBadge.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatusBadge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblStatusBadge.Location = New System.Drawing.Point(18, 40)
        Me.lblStatusBadge.Name = "lblStatusBadge"
        Me.lblStatusBadge.Size = New System.Drawing.Size(196, 17)
        Me.lblStatusBadge.TabIndex = 1
        Me.lblStatusBadge.Text = "✓ CLEARANCE STATUS: READY"
        '
        'lblStatusTitle
        '
        Me.lblStatusTitle.AutoSize = True
        Me.lblStatusTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblStatusTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblStatusTitle.Name = "lblStatusTitle"
        Me.lblStatusTitle.Size = New System.Drawing.Size(119, 19)
        Me.lblStatusTitle.TabIndex = 0
        Me.lblStatusTitle.Text = "Clearance Status"
        '
        'panelParamsCard
        '
        Me.panelParamsCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelParamsCard.BackColor = System.Drawing.Color.White
        Me.panelParamsCard.Controls.Add(Me.btnGeneratePrintQueue)
        Me.panelParamsCard.Controls.Add(Me.cboSigningAuthority)
        Me.panelParamsCard.Controls.Add(Me.lblSigningAuthority)
        Me.panelParamsCard.Controls.Add(Me.cboPurpose)
        Me.panelParamsCard.Controls.Add(Me.lblPurpose)
        Me.panelParamsCard.Controls.Add(Me.lblParamsTitle)
        Me.panelParamsCard.Location = New System.Drawing.Point(24, 426)
        Me.panelParamsCard.Name = "panelParamsCard"
        Me.panelParamsCard.Size = New System.Drawing.Size(372, 318)
        Me.panelParamsCard.TabIndex = 3
        '
        'btnGeneratePrintQueue
        '
        Me.btnGeneratePrintQueue.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnGeneratePrintQueue.FlatAppearance.BorderSize = 0
        Me.btnGeneratePrintQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePrintQueue.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnGeneratePrintQueue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnGeneratePrintQueue.Location = New System.Drawing.Point(18, 178)
        Me.btnGeneratePrintQueue.Name = "btnGeneratePrintQueue"
        Me.btnGeneratePrintQueue.Size = New System.Drawing.Size(172, 36)
        Me.btnGeneratePrintQueue.TabIndex = 5
        Me.btnGeneratePrintQueue.Text = "Generate Print Queue"
        Me.btnGeneratePrintQueue.UseVisualStyleBackColor = False
        '
        'cboSigningAuthority
        '
        Me.cboSigningAuthority.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cboSigningAuthority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSigningAuthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSigningAuthority.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSigningAuthority.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboSigningAuthority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboSigningAuthority.FormattingEnabled = True
        Me.cboSigningAuthority.ItemHeight = 28
        Me.cboSigningAuthority.Location = New System.Drawing.Point(18, 128)
        Me.cboSigningAuthority.Name = "cboSigningAuthority"
        Me.cboSigningAuthority.Size = New System.Drawing.Size(336, 34)
        Me.cboSigningAuthority.TabIndex = 4
        '
        'lblSigningAuthority
        '
        Me.lblSigningAuthority.AutoSize = True
        Me.lblSigningAuthority.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSigningAuthority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblSigningAuthority.Location = New System.Drawing.Point(18, 108)
        Me.lblSigningAuthority.Name = "lblSigningAuthority"
        Me.lblSigningAuthority.Size = New System.Drawing.Size(118, 17)
        Me.lblSigningAuthority.TabIndex = 3
        Me.lblSigningAuthority.Text = "Signing Authority"
        '
        'cboPurpose
        '
        Me.cboPurpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cboPurpose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPurpose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPurpose.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboPurpose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cboPurpose.FormattingEnabled = True
        Me.cboPurpose.ItemHeight = 28
        Me.cboPurpose.Location = New System.Drawing.Point(18, 62)
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.Size = New System.Drawing.Size(336, 34)
        Me.cboPurpose.TabIndex = 2
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblPurpose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblPurpose.Location = New System.Drawing.Point(18, 42)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(138, 17)
        Me.lblPurpose.TabIndex = 1
        Me.lblPurpose.Text = "Purpose of Clearance"
        '
        'lblParamsTitle
        '
        Me.lblParamsTitle.AutoSize = True
        Me.lblParamsTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblParamsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblParamsTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblParamsTitle.Name = "lblParamsTitle"
        Me.lblParamsTitle.Size = New System.Drawing.Size(158, 19)
        Me.lblParamsTitle.TabIndex = 0
        Me.lblParamsTitle.Text = "Document Parameters"
        '
        'panelPreviewOuter
        '
        Me.panelPreviewOuter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelPreviewOuter.BackColor = System.Drawing.Color.White
        Me.panelPreviewOuter.Controls.Add(Me.btnPrintDocument)
        Me.panelPreviewOuter.Controls.Add(Me.lblPreviewTitle)
        Me.panelPreviewOuter.Controls.Add(Me.panelCertificateSheet)
        Me.panelPreviewOuter.Location = New System.Drawing.Point(408, 88)
        Me.panelPreviewOuter.Name = "panelPreviewOuter"
        Me.panelPreviewOuter.Size = New System.Drawing.Size(748, 656)
        Me.panelPreviewOuter.TabIndex = 4
        '
        'btnPrintDocument
        '
        Me.btnPrintDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintDocument.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnPrintDocument.FlatAppearance.BorderSize = 0
        Me.btnPrintDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintDocument.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnPrintDocument.ForeColor = System.Drawing.Color.White
        Me.btnPrintDocument.Location = New System.Drawing.Point(596, 10)
        Me.btnPrintDocument.Name = "btnPrintDocument"
        Me.btnPrintDocument.Size = New System.Drawing.Size(134, 34)
        Me.btnPrintDocument.TabIndex = 1
        Me.btnPrintDocument.Text = "Print Document"
        Me.btnPrintDocument.UseVisualStyleBackColor = False
        '
        'lblPreviewTitle
        '
        Me.lblPreviewTitle.AutoSize = True
        Me.lblPreviewTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblPreviewTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblPreviewTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblPreviewTitle.Name = "lblPreviewTitle"
        Me.lblPreviewTitle.Size = New System.Drawing.Size(207, 19)
        Me.lblPreviewTitle.TabIndex = 0
        Me.lblPreviewTitle.Text = "Document Print Preview Area"
        '
        'panelCertificateSheet
        '
        Me.panelCertificateSheet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelCertificateSheet.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.panelCertificateSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelCertificateSheet.Controls.Add(Me.lblCertSignatoryName)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertPurposeVal)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertPurposeHdr)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertDateVal)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertDateHdr)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertBody2)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertBody1)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertHeading)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertSubOrg)
        Me.panelCertificateSheet.Controls.Add(Me.lblCertUnivName)
        Me.panelCertificateSheet.Controls.Add(Me.picCertSeal)
        Me.panelCertificateSheet.Location = New System.Drawing.Point(24, 52)
        Me.panelCertificateSheet.Name = "panelCertificateSheet"
        Me.panelCertificateSheet.Size = New System.Drawing.Size(700, 468)
        Me.panelCertificateSheet.TabIndex = 2
        '
        'lblCertSignatoryName
        '
        Me.lblCertSignatoryName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCertSignatoryName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertSignatoryName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertSignatoryName.Location = New System.Drawing.Point(388, 376)
        Me.lblCertSignatoryName.Name = "lblCertSignatoryName"
        Me.lblCertSignatoryName.Size = New System.Drawing.Size(268, 52)
        Me.lblCertSignatoryName.TabIndex = 10
        Me.lblCertSignatoryName.Text = "Justine Renz Velasco" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temporary Reviewing Officer"
        '
        'lblCertPurposeVal
        '
        Me.lblCertPurposeVal.AutoSize = True
        Me.lblCertPurposeVal.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCertPurposeVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertPurposeVal.Location = New System.Drawing.Point(42, 312)
        Me.lblCertPurposeVal.Name = "lblCertPurposeVal"
        Me.lblCertPurposeVal.Size = New System.Drawing.Size(160, 17)
        Me.lblCertPurposeVal.TabIndex = 7
        Me.lblCertPurposeVal.Text = "Graduation Requirement"
        '
        'lblCertPurposeHdr
        '
        Me.lblCertPurposeHdr.AutoSize = True
        Me.lblCertPurposeHdr.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCertPurposeHdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblCertPurposeHdr.Location = New System.Drawing.Point(42, 294)
        Me.lblCertPurposeHdr.Name = "lblCertPurposeHdr"
        Me.lblCertPurposeHdr.Size = New System.Drawing.Size(60, 15)
        Me.lblCertPurposeHdr.TabIndex = 6
        Me.lblCertPurposeHdr.Text = "PURPOSE"
        '
        'lblCertDateVal
        '
        Me.lblCertDateVal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCertDateVal.AutoSize = True
        Me.lblCertDateVal.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCertDateVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertDateVal.Location = New System.Drawing.Point(456, 312)
        Me.lblCertDateVal.Name = "lblCertDateVal"
        Me.lblCertDateVal.Size = New System.Drawing.Size(126, 17)
        Me.lblCertDateVal.TabIndex = 9
        Me.lblCertDateVal.Text = "November 28, 2026"
        '
        'lblCertDateHdr
        '
        Me.lblCertDateHdr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCertDateHdr.AutoSize = True
        Me.lblCertDateHdr.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCertDateHdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblCertDateHdr.Location = New System.Drawing.Point(456, 294)
        Me.lblCertDateHdr.Name = "lblCertDateHdr"
        Me.lblCertDateHdr.Size = New System.Drawing.Size(81, 15)
        Me.lblCertDateHdr.TabIndex = 8
        Me.lblCertDateHdr.Text = "DATE ISSUED"
        '
        'lblCertBody2
        '
        Me.lblCertBody2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCertBody2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblCertBody2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblCertBody2.Location = New System.Drawing.Point(42, 218)
        Me.lblCertBody2.Name = "lblCertBody2"
        Me.lblCertBody2.Size = New System.Drawing.Size(614, 56)
        Me.lblCertBody2.TabIndex = 5
        Me.lblCertBody2.Text = "As of the date of issuance listed below, verify student records to confirm whethe" &
    "r the student has any active or pending disciplinary infractions."
        '
        'lblCertBody1
        '
        Me.lblCertBody1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCertBody1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblCertBody1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblCertBody1.Location = New System.Drawing.Point(42, 160)
        Me.lblCertBody1.Name = "lblCertBody1"
        Me.lblCertBody1.Size = New System.Drawing.Size(614, 52)
        Me.lblCertBody1.TabIndex = 4
        Me.lblCertBody1.Text = "This is to certify that the student below has undergone a standard disciplinary v" &
    "erification review under the Quezon City University Student Manual."
        '
        'lblCertHeading
        '
        Me.lblCertHeading.AutoSize = True
        Me.lblCertHeading.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblCertHeading.Location = New System.Drawing.Point(186, 126)
        Me.lblCertHeading.Name = "lblCertHeading"
        Me.lblCertHeading.Size = New System.Drawing.Size(318, 20)
        Me.lblCertHeading.TabIndex = 3
        Me.lblCertHeading.Text = "CERTIFICATE OF DISCIPLINARY CLEARANCE"
        '
        'lblCertSubOrg
        '
        Me.lblCertSubOrg.AutoSize = True
        Me.lblCertSubOrg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCertSubOrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblCertSubOrg.Location = New System.Drawing.Point(231, 95)
        Me.lblCertSubOrg.Name = "lblCertSubOrg"
        Me.lblCertSubOrg.Size = New System.Drawing.Size(211, 15)
        Me.lblCertSubOrg.TabIndex = 2
        Me.lblCertSubOrg.Text = "Office of Student Affairs and Discipline"
        '
        'lblCertUnivName
        '
        Me.lblCertUnivName.AutoSize = True
        Me.lblCertUnivName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertUnivName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertUnivName.Location = New System.Drawing.Point(252, 74)
        Me.lblCertUnivName.Name = "lblCertUnivName"
        Me.lblCertUnivName.Size = New System.Drawing.Size(198, 20)
        Me.lblCertUnivName.TabIndex = 1
        Me.lblCertUnivName.Text = "QUEZON CITY UNIVERSITY"
        '
        'picCertSeal
        '
        Me.picCertSeal.BackColor = System.Drawing.Color.White
        Me.picCertSeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCertSeal.Image = Global.QCU_SDOTS.My.Resources.Resources.qcu_logo
        Me.picCertSeal.Location = New System.Drawing.Point(322, 14)
        Me.picCertSeal.Name = "picCertSeal"
        Me.picCertSeal.Size = New System.Drawing.Size(54, 54)
        Me.picCertSeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCertSeal.TabIndex = 0
        Me.picCertSeal.TabStop = False
        '
        'UcClearanceGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.panelPreviewOuter)
        Me.Controls.Add(Me.panelParamsCard)
        Me.Controls.Add(Me.panelStatusCard)
        Me.Controls.Add(Me.panelVerifyCard)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "UcClearanceGenerator"
        Me.Size = New System.Drawing.Size(1180, 768)
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.panelVerifyCard.ResumeLayout(False)
        Me.panelVerifyCard.PerformLayout()
        Me.panelStatusCard.ResumeLayout(False)
        Me.panelStatusCard.PerformLayout()
        Me.panelParamsCard.ResumeLayout(False)
        Me.panelParamsCard.PerformLayout()
        Me.panelPreviewOuter.ResumeLayout(False)
        Me.panelPreviewOuter.PerformLayout()
        Me.panelCertificateSheet.ResumeLayout(False)
        Me.panelCertificateSheet.PerformLayout()
        CType(Me.picCertSeal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelVerifyCard As Panel
    Friend WithEvents btnVerifyStudent As Button
    Friend WithEvents txtStudentIDInput As TextBox
    Friend WithEvents lblEnterStudentIDReq As Label
    Friend WithEvents lblEnterStudentID As Label
    Friend WithEvents lblVerifyTitle As Label
    Friend WithEvents panelStatusCard As Panel
    Friend WithEvents lblStatusBody As Label
    Friend WithEvents lblStatusBadge As Label
    Friend WithEvents lblStatusTitle As Label
    Friend WithEvents panelParamsCard As Panel
    Friend WithEvents btnGeneratePrintQueue As Button
    Friend WithEvents cboSigningAuthority As ComboBox
    Friend WithEvents lblSigningAuthority As Label
    Friend WithEvents cboPurpose As ComboBox
    Friend WithEvents lblPurpose As Label
    Friend WithEvents lblParamsTitle As Label
    Friend WithEvents panelPreviewOuter As Panel
    Friend WithEvents btnPrintDocument As Button
    Friend WithEvents lblPreviewTitle As Label
    Friend WithEvents panelCertificateSheet As Panel
    Friend WithEvents lblCertSignatoryName As Label
    Friend WithEvents lblCertPurposeVal As Label
    Friend WithEvents lblCertPurposeHdr As Label
    Friend WithEvents lblCertDateVal As Label
    Friend WithEvents lblCertDateHdr As Label
    Friend WithEvents lblCertBody2 As Label
    Friend WithEvents lblCertBody1 As Label
    Friend WithEvents lblCertHeading As Label
    Friend WithEvents lblCertSubOrg As Label
    Friend WithEvents lblCertUnivName As Label
    Friend WithEvents picCertSeal As PictureBox
End Class