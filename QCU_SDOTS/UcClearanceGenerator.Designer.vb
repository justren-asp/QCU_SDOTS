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
        Me.panelHeader.Size = New System.Drawing.Size(1100, 76)
        Me.panelHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(24, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(343, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Disciplinary Clearance Generator"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 45)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(492, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Verify disciplinary clearance eligibility and print the official Clearance Certificate document."
        '
        'panelVerifyCard
        '
        Me.panelVerifyCard.BackColor = System.Drawing.Color.White
        Me.panelVerifyCard.Controls.Add(Me.btnVerifyStudent)
        Me.panelVerifyCard.Controls.Add(Me.txtStudentIDInput)
        Me.panelVerifyCard.Controls.Add(Me.lblEnterStudentID)
        Me.panelVerifyCard.Controls.Add(Me.lblVerifyTitle)
        Me.panelVerifyCard.Location = New System.Drawing.Point(24, 92)
        Me.panelVerifyCard.Name = "panelVerifyCard"
        Me.panelVerifyCard.Size = New System.Drawing.Size(365, 152)
        Me.panelVerifyCard.TabIndex = 1
        '
        'lblVerifyTitle
        '
        Me.lblVerifyTitle.AutoSize = True
        Me.lblVerifyTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblVerifyTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblVerifyTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblVerifyTitle.Name = "lblVerifyTitle"
        Me.lblVerifyTitle.Size = New System.Drawing.Size(173, 19)
        Me.lblVerifyTitle.TabIndex = 0
        Me.lblVerifyTitle.Text = "Verify Student Records"
        '
        'lblEnterStudentID
        '
        Me.lblEnterStudentID.AutoSize = True
        Me.lblEnterStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEnterStudentID.ForeColor = System.Drawing.Color.DimGray
        Me.lblEnterStudentID.Location = New System.Drawing.Point(16, 38)
        Me.lblEnterStudentID.Name = "lblEnterStudentID"
        Me.lblEnterStudentID.Size = New System.Drawing.Size(113, 15)
        Me.lblEnterStudentID.TabIndex = 1
        Me.lblEnterStudentID.Text = "Enter Student ID *"
        '
        'txtStudentIDInput
        '
        Me.txtStudentIDInput.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStudentIDInput.Location = New System.Drawing.Point(16, 58)
        Me.txtStudentIDInput.Name = "txtStudentIDInput"
        Me.txtStudentIDInput.Size = New System.Drawing.Size(332, 25)
        Me.txtStudentIDInput.TabIndex = 2
        '
        'btnVerifyStudent
        '
        Me.btnVerifyStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnVerifyStudent.FlatAppearance.BorderSize = 0
        Me.btnVerifyStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerifyStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnVerifyStudent.ForeColor = System.Drawing.Color.White
        Me.btnVerifyStudent.Location = New System.Drawing.Point(16, 96)
        Me.btnVerifyStudent.Name = "btnVerifyStudent"
        Me.btnVerifyStudent.Size = New System.Drawing.Size(145, 34)
        Me.btnVerifyStudent.TabIndex = 3
        Me.btnVerifyStudent.Text = "Verify Student"
        Me.btnVerifyStudent.UseVisualStyleBackColor = False
        '
        'panelStatusCard
        '
        Me.panelStatusCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.panelStatusCard.Controls.Add(Me.lblStatusBody)
        Me.panelStatusCard.Controls.Add(Me.lblStatusBadge)
        Me.panelStatusCard.Controls.Add(Me.lblStatusTitle)
        Me.panelStatusCard.Location = New System.Drawing.Point(24, 256)
        Me.panelStatusCard.Name = "panelStatusCard"
        Me.panelStatusCard.Size = New System.Drawing.Size(365, 166)
        Me.panelStatusCard.TabIndex = 2
        '
        'lblStatusTitle
        '
        Me.lblStatusTitle.AutoSize = True
        Me.lblStatusTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblStatusTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblStatusTitle.Name = "lblStatusTitle"
        Me.lblStatusTitle.Size = New System.Drawing.Size(123, 19)
        Me.lblStatusTitle.TabIndex = 0
        Me.lblStatusTitle.Text = "Clearance Status"
        '
        'lblStatusBadge
        '
        Me.lblStatusBadge.AutoSize = True
        Me.lblStatusBadge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatusBadge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblStatusBadge.Location = New System.Drawing.Point(16, 42)
        Me.lblStatusBadge.Name = "lblStatusBadge"
        Me.lblStatusBadge.Size = New System.Drawing.Size(172, 15)
        Me.lblStatusBadge.TabIndex = 1
        Me.lblStatusBadge.Text = "✓ CLEARANCE STATUS: READY"
        '
        'lblStatusBody
        '
        Me.lblStatusBody.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusBody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblStatusBody.Location = New System.Drawing.Point(16, 66)
        Me.lblStatusBody.Name = "lblStatusBody"
        Me.lblStatusBody.Size = New System.Drawing.Size(332, 82)
        Me.lblStatusBody.TabIndex = 2
        Me.lblStatusBody.Text = "Enter a Student ID and click Verify Student to check disciplinary standing and pending sanctions."
        '
        'panelParamsCard
        '
        Me.panelParamsCard.BackColor = System.Drawing.Color.White
        Me.panelParamsCard.Controls.Add(Me.btnGeneratePrintQueue)
        Me.panelParamsCard.Controls.Add(Me.cboSigningAuthority)
        Me.panelParamsCard.Controls.Add(Me.lblSigningAuthority)
        Me.panelParamsCard.Controls.Add(Me.cboPurpose)
        Me.panelParamsCard.Controls.Add(Me.lblPurpose)
        Me.panelParamsCard.Controls.Add(Me.lblParamsTitle)
        Me.panelParamsCard.Location = New System.Drawing.Point(24, 434)
        Me.panelParamsCard.Name = "panelParamsCard"
        Me.panelParamsCard.Size = New System.Drawing.Size(365, 310)
        Me.panelParamsCard.TabIndex = 3
        '
        'lblParamsTitle
        '
        Me.lblParamsTitle.AutoSize = True
        Me.lblParamsTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblParamsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblParamsTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblParamsTitle.Name = "lblParamsTitle"
        Me.lblParamsTitle.Size = New System.Drawing.Size(172, 19)
        Me.lblParamsTitle.TabIndex = 0
        Me.lblParamsTitle.Text = "Document Parameters"
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPurpose.ForeColor = System.Drawing.Color.DimGray
        Me.lblPurpose.Location = New System.Drawing.Point(16, 44)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(134, 15)
        Me.lblPurpose.TabIndex = 1
        Me.lblPurpose.Text = "Purpose of Clearance"
        '
        'cboPurpose
        '
        Me.cboPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPurpose.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboPurpose.FormattingEnabled = True
        Me.cboPurpose.Location = New System.Drawing.Point(16, 64)
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.Size = New System.Drawing.Size(332, 25)
        Me.cboPurpose.TabIndex = 2
        '
        'lblSigningAuthority
        '
        Me.lblSigningAuthority.AutoSize = True
        Me.lblSigningAuthority.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSigningAuthority.ForeColor = System.Drawing.Color.DimGray
        Me.lblSigningAuthority.Location = New System.Drawing.Point(16, 106)
        Me.lblSigningAuthority.Name = "lblSigningAuthority"
        Me.lblSigningAuthority.Size = New System.Drawing.Size(113, 15)
        Me.lblSigningAuthority.TabIndex = 3
        Me.lblSigningAuthority.Text = "Signing Authority"
        '
        'cboSigningAuthority
        '
        Me.cboSigningAuthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSigningAuthority.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboSigningAuthority.FormattingEnabled = True
        Me.cboSigningAuthority.Location = New System.Drawing.Point(16, 126)
        Me.cboSigningAuthority.Name = "cboSigningAuthority"
        Me.cboSigningAuthority.Size = New System.Drawing.Size(332, 25)
        Me.cboSigningAuthority.TabIndex = 4
        '
        'btnGeneratePrintQueue
        '
        Me.btnGeneratePrintQueue.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnGeneratePrintQueue.FlatAppearance.BorderSize = 0
        Me.btnGeneratePrintQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePrintQueue.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnGeneratePrintQueue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnGeneratePrintQueue.Location = New System.Drawing.Point(16, 174)
        Me.btnGeneratePrintQueue.Name = "btnGeneratePrintQueue"
        Me.btnGeneratePrintQueue.Size = New System.Drawing.Size(165, 36)
        Me.btnGeneratePrintQueue.TabIndex = 5
        Me.btnGeneratePrintQueue.Text = "Generate Print Queue"
        Me.btnGeneratePrintQueue.UseVisualStyleBackColor = False
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
        Me.panelPreviewOuter.Location = New System.Drawing.Point(405, 92)
        Me.panelPreviewOuter.Name = "panelPreviewOuter"
        Me.panelPreviewOuter.Size = New System.Drawing.Size(671, 652)
        Me.panelPreviewOuter.TabIndex = 4
        '
        'lblPreviewTitle
        '
        Me.lblPreviewTitle.AutoSize = True
        Me.lblPreviewTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblPreviewTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblPreviewTitle.Location = New System.Drawing.Point(18, 16)
        Me.lblPreviewTitle.Name = "lblPreviewTitle"
        Me.lblPreviewTitle.Size = New System.Drawing.Size(195, 19)
        Me.lblPreviewTitle.TabIndex = 0
        Me.lblPreviewTitle.Text = "Document Print Preview Area"
        '
        'btnPrintDocument
        '
        Me.btnPrintDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintDocument.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnPrintDocument.FlatAppearance.BorderSize = 0
        Me.btnPrintDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintDocument.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintDocument.ForeColor = System.Drawing.Color.White
        Me.btnPrintDocument.Location = New System.Drawing.Point(525, 12)
        Me.btnPrintDocument.Name = "btnPrintDocument"
        Me.btnPrintDocument.Size = New System.Drawing.Size(128, 30)
        Me.btnPrintDocument.TabIndex = 1
        Me.btnPrintDocument.Text = "Print Document"
        Me.btnPrintDocument.UseVisualStyleBackColor = False
        '
        'panelCertificateSheet
        '
        Me.panelCertificateSheet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.panelCertificateSheet.Location = New System.Drawing.Point(48, 56)
        Me.panelCertificateSheet.Name = "panelCertificateSheet"
        Me.panelCertificateSheet.Size = New System.Drawing.Size(575, 576)
        Me.panelCertificateSheet.TabIndex = 2
        '
        'picCertSeal
        '
        Me.picCertSeal.Location = New System.Drawing.Point(125, 22)
        Me.picCertSeal.Name = "picCertSeal"
        Me.picCertSeal.Size = New System.Drawing.Size(52, 52)
        Me.picCertSeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCertSeal.TabIndex = 0
        Me.picCertSeal.TabStop = False
        '
        'lblCertUnivName
        '
        Me.lblCertUnivName.AutoSize = True
        Me.lblCertUnivName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertUnivName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertUnivName.Location = New System.Drawing.Point(188, 26)
        Me.lblCertUnivName.Name = "lblCertUnivName"
        Me.lblCertUnivName.Size = New System.Drawing.Size(179, 20)
        Me.lblCertUnivName.TabIndex = 1
        Me.lblCertUnivName.Text = "QUEZON CITY UNIVERSITY"
        '
        'lblCertSubOrg
        '
        Me.lblCertSubOrg.AutoSize = True
        Me.lblCertSubOrg.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCertSubOrg.ForeColor = System.Drawing.Color.DimGray
        Me.lblCertSubOrg.Location = New System.Drawing.Point(188, 48)
        Me.lblCertSubOrg.Name = "lblCertSubOrg"
        Me.lblCertSubOrg.Size = New System.Drawing.Size(226, 15)
        Me.lblCertSubOrg.TabIndex = 2
        Me.lblCertSubOrg.Text = "Office of Student Affairs and Discipline"
        '
        'lblCertHeading
        '
        Me.lblCertHeading.AutoSize = True
        Me.lblCertHeading.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Bold)
        Me.lblCertHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertHeading.Location = New System.Drawing.Point(132, 96)
        Me.lblCertHeading.Name = "lblCertHeading"
        Me.lblCertHeading.Size = New System.Drawing.Size(316, 21)
        Me.lblCertHeading.TabIndex = 3
        Me.lblCertHeading.Text = "CERTIFICATE OF DISCIPLINARY CLEARANCE"
        '
        'lblCertBody1
        '
        Me.lblCertBody1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCertBody1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblCertBody1.Location = New System.Drawing.Point(56, 138)
        Me.lblCertBody1.Name = "lblCertBody1"
        Me.lblCertBody1.Size = New System.Drawing.Size(462, 68)
        Me.lblCertBody1.TabIndex = 4
        Me.lblCertBody1.Text = "This is to certify that the student below has undergone a standard disciplinary verification review under the Quezon City University Student Manual."
        '
        'lblCertBody2
        '
        Me.lblCertBody2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCertBody2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblCertBody2.Location = New System.Drawing.Point(56, 218)
        Me.lblCertBody2.Name = "lblCertBody2"
        Me.lblCertBody2.Size = New System.Drawing.Size(462, 74)
        Me.lblCertBody2.TabIndex = 5
        Me.lblCertBody2.Text = "As of the date of issuance listed below, verify student records to confirm whether the student has any active or pending disciplinary infractions."
        '
        'lblCertPurposeHdr
        '
        Me.lblCertPurposeHdr.AutoSize = True
        Me.lblCertPurposeHdr.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertPurposeHdr.ForeColor = System.Drawing.Color.DimGray
        Me.lblCertPurposeHdr.Location = New System.Drawing.Point(56, 326)
        Me.lblCertPurposeHdr.Name = "lblCertPurposeHdr"
        Me.lblCertPurposeHdr.Size = New System.Drawing.Size(52, 13)
        Me.lblCertPurposeHdr.TabIndex = 6
        Me.lblCertPurposeHdr.Text = "PURPOSE"
        '
        'lblCertPurposeVal
        '
        Me.lblCertPurposeVal.AutoSize = True
        Me.lblCertPurposeVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertPurposeVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertPurposeVal.Location = New System.Drawing.Point(56, 344)
        Me.lblCertPurposeVal.Name = "lblCertPurposeVal"
        Me.lblCertPurposeVal.Size = New System.Drawing.Size(142, 15)
        Me.lblCertPurposeVal.TabIndex = 7
        Me.lblCertPurposeVal.Text = "Graduation Requirement"
        '
        'lblCertDateHdr
        '
        Me.lblCertDateHdr.AutoSize = True
        Me.lblCertDateHdr.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertDateHdr.ForeColor = System.Drawing.Color.DimGray
        Me.lblCertDateHdr.Location = New System.Drawing.Point(348, 326)
        Me.lblCertDateHdr.Name = "lblCertDateHdr"
        Me.lblCertDateHdr.Size = New System.Drawing.Size(75, 13)
        Me.lblCertDateHdr.TabIndex = 8
        Me.lblCertDateHdr.Text = "DATE ISSUED"
        '
        'lblCertDateVal
        '
        Me.lblCertDateVal.AutoSize = True
        Me.lblCertDateVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCertDateVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertDateVal.Location = New System.Drawing.Point(348, 344)
        Me.lblCertDateVal.Name = "lblCertDateVal"
        Me.lblCertDateVal.Size = New System.Drawing.Size(118, 15)
        Me.lblCertDateVal.TabIndex = 9
        Me.lblCertDateVal.Text = "November 21, 2026"
        '
        'lblCertSignatoryName
        '
        Me.lblCertSignatoryName.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCertSignatoryName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCertSignatoryName.Location = New System.Drawing.Point(320, 448)
        Me.lblCertSignatoryName.Name = "lblCertSignatoryName"
        Me.lblCertSignatoryName.Size = New System.Drawing.Size(205, 45)
        Me.lblCertSignatoryName.TabIndex = 10
        Me.lblCertSignatoryName.Text = "Dr. Maria R. Dela Cruz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Director, Office of Student Affairs"
        '
        'UcClearanceGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.panelPreviewOuter)
        Me.Controls.Add(Me.panelParamsCard)
        Me.Controls.Add(Me.panelStatusCard)
        Me.Controls.Add(Me.panelVerifyCard)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "UcClearanceGenerator"
        Me.Size = New System.Drawing.Size(1100, 768)
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