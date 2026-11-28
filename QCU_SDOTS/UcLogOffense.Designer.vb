<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcLogOffense
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
        Me.panelStudentCard = New System.Windows.Forms.Panel()
        Me.lblStudentSectionTitle = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentIDReq = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnFindStudent = New System.Windows.Forms.Button()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.panelOffenseCard = New System.Windows.Forms.Panel()
        Me.lblOffenseSectionTitle = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblCategoryReq = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblSpecificOffense = New System.Windows.Forms.Label()
        Me.lblSpecificOffenseReq = New System.Windows.Forms.Label()
        Me.cboSpecificOffense = New System.Windows.Forms.ComboBox()
        Me.txtCustomOffense = New System.Windows.Forms.TextBox()
        Me.lblIncidentDate = New System.Windows.Forms.Label()
        Me.lblIncidentDateReq = New System.Windows.Forms.Label()
        Me.dtpIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.lblIncidentTime = New System.Windows.Forms.Label()
        Me.lblIncidentTimeReq = New System.Windows.Forms.Label()
        Me.dtpIncidentTime = New System.Windows.Forms.DateTimePicker()
        Me.lblWarningLevel = New System.Windows.Forms.Label()
        Me.lblWarningLevelReq = New System.Windows.Forms.Label()
        Me.cboWarningLevel = New System.Windows.Forms.ComboBox()
        Me.lblSanction = New System.Windows.Forms.Label()
        Me.lblSanctionReq = New System.Windows.Forms.Label()
        Me.cboSanction = New System.Windows.Forms.ComboBox()
        Me.txtCustomSanction = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblRemarksReq = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.panelProofBox = New System.Windows.Forms.Panel()
        Me.lblProofTitle = New System.Windows.Forms.Label()
        Me.lblProofRules = New System.Windows.Forms.Label()
        Me.btnAttachFiles = New System.Windows.Forms.Button()
        Me.btnRemoveAttachment = New System.Windows.Forms.Button()
        Me.lstAttachments = New System.Windows.Forms.ListBox()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnSaveInfraction = New System.Windows.Forms.Button()
        Me.panelHeader.SuspendLayout()
        Me.panelStudentCard.SuspendLayout()
        Me.panelOffenseCard.SuspendLayout()
        Me.panelProofBox.SuspendLayout()
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.lblTitle.Location = New System.Drawing.Point(24, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(356, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Record New Student Infraction"
        Me.lblTitle.UseMnemonic = False
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 44)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(540, 17)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Verify student ID (00-0000), select offense & warning rules, and attach proof if available."
        '
        'panelStudentCard
        '
        Me.panelStudentCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelStudentCard.BackColor = System.Drawing.Color.White
        Me.panelStudentCard.Controls.Add(Me.txtSection)
        Me.panelStudentCard.Controls.Add(Me.lblSection)
        Me.panelStudentCard.Controls.Add(Me.txtDepartment)
        Me.panelStudentCard.Controls.Add(Me.lblDepartment)
        Me.panelStudentCard.Controls.Add(Me.txtMiddleName)
        Me.panelStudentCard.Controls.Add(Me.lblMiddleName)
        Me.panelStudentCard.Controls.Add(Me.txtFirstName)
        Me.panelStudentCard.Controls.Add(Me.lblFirstName)
        Me.panelStudentCard.Controls.Add(Me.txtLastName)
        Me.panelStudentCard.Controls.Add(Me.lblLastName)
        Me.panelStudentCard.Controls.Add(Me.btnFindStudent)
        Me.panelStudentCard.Controls.Add(Me.txtStudentID)
        Me.panelStudentCard.Controls.Add(Me.lblStudentIDReq)
        Me.panelStudentCard.Controls.Add(Me.lblStudentID)
        Me.panelStudentCard.Controls.Add(Me.lblStudentSectionTitle)
        Me.panelStudentCard.Location = New System.Drawing.Point(24, 86)
        Me.panelStudentCard.Name = "panelStudentCard"
        Me.panelStudentCard.Size = New System.Drawing.Size(1132, 160)
        Me.panelStudentCard.TabIndex = 1
        '
        'lblStudentSectionTitle
        '
        Me.lblStudentSectionTitle.AutoSize = True
        Me.lblStudentSectionTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudentSectionTitle.ForeColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.lblStudentSectionTitle.Location = New System.Drawing.Point(18, 10)
        Me.lblStudentSectionTitle.Name = "lblStudentSectionTitle"
        Me.lblStudentSectionTitle.Size = New System.Drawing.Size(165, 19)
        Me.lblStudentSectionTitle.TabIndex = 0
        Me.lblStudentSectionTitle.Text = "Student Information"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblStudentID.Location = New System.Drawing.Point(18, 36)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(74, 17)
        Me.lblStudentID.TabIndex = 1
        Me.lblStudentID.Text = "Student ID"
        '
        'lblStudentIDReq
        '
        Me.lblStudentIDReq.AutoSize = True
        Me.lblStudentIDReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudentIDReq.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.lblStudentIDReq.Location = New System.Drawing.Point(94, 36)
        Me.lblStudentIDReq.Name = "lblStudentIDReq"
        Me.lblStudentIDReq.Size = New System.Drawing.Size(14, 17)
        Me.lblStudentIDReq.TabIndex = 2
        Me.lblStudentIDReq.Text = "*"
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.txtStudentID.Location = New System.Drawing.Point(18, 57)
        Me.txtStudentID.MaxLength = 7
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(128, 25)
        Me.txtStudentID.TabIndex = 3
        '
        'btnFindStudent
        '
        Me.btnFindStudent.BackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.btnFindStudent.FlatAppearance.BorderSize = 0
        Me.btnFindStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnFindStudent.ForeColor = System.Drawing.Color.White
        Me.btnFindStudent.Location = New System.Drawing.Point(154, 55)
        Me.btnFindStudent.Name = "btnFindStudent"
        Me.btnFindStudent.Size = New System.Drawing.Size(78, 29)
        Me.btnFindStudent.TabIndex = 4
        Me.btnFindStudent.Text = "Find"
        Me.btnFindStudent.UseVisualStyleBackColor = False
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblLastName.Location = New System.Drawing.Point(246, 36)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(75, 17)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.txtLastName.Location = New System.Drawing.Point(246, 57)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(274, 25)
        Me.txtLastName.TabIndex = 6
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblFirstName.Location = New System.Drawing.Point(534, 36)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(77, 17)
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.txtFirstName.Location = New System.Drawing.Point(534, 57)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(282, 25)
        Me.txtFirstName.TabIndex = 8
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblMiddleName.Location = New System.Drawing.Point(830, 36)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(91, 17)
        Me.lblMiddleName.TabIndex = 9
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.txtMiddleName.Location = New System.Drawing.Point(830, 57)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = True
        Me.txtMiddleName.Size = New System.Drawing.Size(282, 25)
        Me.txtMiddleName.TabIndex = 10
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblDepartment.Location = New System.Drawing.Point(246, 92)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(151, 17)
        Me.lblDepartment.TabIndex = 11
        Me.lblDepartment.Text = "Department / Program"
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.txtDepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtDepartment.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.txtDepartment.Location = New System.Drawing.Point(246, 114)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(570, 25)
        Me.txtDepartment.TabIndex = 12
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSection.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblSection.Location = New System.Drawing.Point(830, 92)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(55, 17)
        Me.lblSection.TabIndex = 13
        Me.lblSection.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.txtSection.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtSection.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.txtSection.Location = New System.Drawing.Point(830, 114)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(282, 25)
        Me.txtSection.TabIndex = 14
        '
        'panelOffenseCard
        '
        Me.panelOffenseCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelOffenseCard.BackColor = System.Drawing.Color.White
        Me.panelOffenseCard.Controls.Add(Me.btnSaveInfraction)
        Me.panelOffenseCard.Controls.Add(Me.btnClearForm)
        Me.panelOffenseCard.Controls.Add(Me.panelProofBox)
        Me.panelOffenseCard.Controls.Add(Me.txtRemarks)
        Me.panelOffenseCard.Controls.Add(Me.lblRemarksReq)
        Me.panelOffenseCard.Controls.Add(Me.lblRemarks)
        Me.panelOffenseCard.Controls.Add(Me.txtCustomSanction)
        Me.panelOffenseCard.Controls.Add(Me.cboSanction)
        Me.panelOffenseCard.Controls.Add(Me.lblSanctionReq)
        Me.panelOffenseCard.Controls.Add(Me.lblSanction)
        Me.panelOffenseCard.Controls.Add(Me.cboWarningLevel)
        Me.panelOffenseCard.Controls.Add(Me.lblWarningLevelReq)
        Me.panelOffenseCard.Controls.Add(Me.lblWarningLevel)
        Me.panelOffenseCard.Controls.Add(Me.dtpIncidentTime)
        Me.panelOffenseCard.Controls.Add(Me.lblIncidentTimeReq)
        Me.panelOffenseCard.Controls.Add(Me.lblIncidentTime)
        Me.panelOffenseCard.Controls.Add(Me.dtpIncidentDate)
        Me.panelOffenseCard.Controls.Add(Me.lblIncidentDateReq)
        Me.panelOffenseCard.Controls.Add(Me.lblIncidentDate)
        Me.panelOffenseCard.Controls.Add(Me.txtCustomOffense)
        Me.panelOffenseCard.Controls.Add(Me.cboSpecificOffense)
        Me.panelOffenseCard.Controls.Add(Me.lblSpecificOffenseReq)
        Me.panelOffenseCard.Controls.Add(Me.lblSpecificOffense)
        Me.panelOffenseCard.Controls.Add(Me.cboCategory)
        Me.panelOffenseCard.Controls.Add(Me.lblCategoryReq)
        Me.panelOffenseCard.Controls.Add(Me.lblCategory)
        Me.panelOffenseCard.Controls.Add(Me.lblOffenseSectionTitle)
        Me.panelOffenseCard.Location = New System.Drawing.Point(24, 258)
        Me.panelOffenseCard.Name = "panelOffenseCard"
        Me.panelOffenseCard.Size = New System.Drawing.Size(1132, 494)
        Me.panelOffenseCard.TabIndex = 2
        '
        'lblOffenseSectionTitle
        '
        Me.lblOffenseSectionTitle.AutoSize = True
        Me.lblOffenseSectionTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblOffenseSectionTitle.ForeColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.lblOffenseSectionTitle.Location = New System.Drawing.Point(18, 10)
        Me.lblOffenseSectionTitle.Name = "lblOffenseSectionTitle"
        Me.lblOffenseSectionTitle.Size = New System.Drawing.Size(121, 19)
        Me.lblOffenseSectionTitle.TabIndex = 0
        Me.lblOffenseSectionTitle.Text = "Offense Details"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblCategory.Location = New System.Drawing.Point(18, 36)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(119, 17)
        Me.lblCategory.TabIndex = 1
        Me.lblCategory.Text = "Offense Category"
        '
        'lblCategoryReq
        '
        Me.lblCategoryReq.AutoSize = True
        Me.lblCategoryReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCategoryReq.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.lblCategoryReq.Location = New System.Drawing.Point(139, 36)
        Me.lblCategoryReq.Name = "lblCategoryReq"
        Me.lblCategoryReq.Size = New System.Drawing.Size(14, 17)
        Me.lblCategoryReq.TabIndex = 2
        Me.lblCategoryReq.Text = "*"
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCategory.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.cboCategory.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.ItemHeight = 28
        Me.cboCategory.Location = New System.Drawing.Point(18, 57)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(172, 34)
        Me.cboCategory.TabIndex = 3
        '
        'lblSpecificOffense
        '
        Me.lblSpecificOffense.AutoSize = True
        Me.lblSpecificOffense.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSpecificOffense.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblSpecificOffense.Location = New System.Drawing.Point(202, 36)
        Me.lblSpecificOffense.Name = "lblSpecificOffense"
        Me.lblSpecificOffense.Size = New System.Drawing.Size(106, 17)
        Me.lblSpecificOffense.TabIndex = 4
        Me.lblSpecificOffense.Text = "Specific Offense"
        '
        'lblSpecificOffenseReq
        '
        Me.lblSpecificOffenseReq.AutoSize = True
        Me.lblSpecificOffenseReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSpecificOffenseReq.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.lblSpecificOffenseReq.Location = New System.Drawing.Point(310, 36)
        Me.lblSpecificOffenseReq.Name = "lblSpecificOffenseReq"
        Me.lblSpecificOffenseReq.Size = New System.Drawing.Size(14, 17)
        Me.lblSpecificOffenseReq.TabIndex = 5
        Me.lblSpecificOffenseReq.Text = "*"
        '
        'cboSpecificOffense
        '
        Me.cboSpecificOffense.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.cboSpecificOffense.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSpecificOffense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpecificOffense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSpecificOffense.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.cboSpecificOffense.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cboSpecificOffense.FormattingEnabled = True
        Me.cboSpecificOffense.ItemHeight = 28
        Me.cboSpecificOffense.Location = New System.Drawing.Point(202, 57)
        Me.cboSpecificOffense.Name = "cboSpecificOffense"
        Me.cboSpecificOffense.Size = New System.Drawing.Size(372, 34)
        Me.cboSpecificOffense.TabIndex = 6
        '
        'txtCustomOffense
        '
        Me.txtCustomOffense.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtCustomOffense.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtCustomOffense.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.txtCustomOffense.Location = New System.Drawing.Point(584, 59)
        Me.txtCustomOffense.Name = "txtCustomOffense"
        Me.txtCustomOffense.Size = New System.Drawing.Size(184, 25)
        Me.txtCustomOffense.TabIndex = 7
        Me.txtCustomOffense.Visible = False
        '
        'lblIncidentDate
        '
        Me.lblIncidentDate.AutoSize = True
        Me.lblIncidentDate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblIncidentDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblIncidentDate.Location = New System.Drawing.Point(780, 36)
        Me.lblIncidentDate.Name = "lblIncidentDate"
        Me.lblIncidentDate.Size = New System.Drawing.Size(108, 17)
        Me.lblIncidentDate.TabIndex = 8
        Me.lblIncidentDate.Text = "Date of Incident"
        '
        'lblIncidentDateReq
        '
        Me.lblIncidentDateReq.AutoSize = True
        Me.lblIncidentDateReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblIncidentDateReq.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.lblIncidentDateReq.Location = New System.Drawing.Point(890, 36)
        Me.lblIncidentDateReq.Name = "lblIncidentDateReq"
        Me.lblIncidentDateReq.Size = New System.Drawing.Size(14, 17)
        Me.lblIncidentDateReq.TabIndex = 9
        Me.lblIncidentDateReq.Text = "*"
        '
        'dtpIncidentDate
        '
        Me.dtpIncidentDate.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.dtpIncidentDate.CalendarForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.dtpIncidentDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpIncidentDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.dtpIncidentDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpIncidentDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
        Me.dtpIncidentDate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.dtpIncidentDate.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.dtpIncidentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIncidentDate.Location = New System.Drawing.Point(780, 57)
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Size = New System.Drawing.Size(162, 32)
        Me.dtpIncidentDate.TabIndex = 10
        '
        'lblIncidentTime
        '
        Me.lblIncidentTime.AutoSize = True
        Me.lblIncidentTime.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblIncidentTime.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblIncidentTime.Location = New System.Drawing.Point(954, 36)
        Me.lblIncidentTime.Name = "lblIncidentTime"
        Me.lblIncidentTime.Size = New System.Drawing.Size(104, 17)
        Me.lblIncidentTime.TabIndex = 11
        Me.lblIncidentTime.Text = "Time of Incident"
        '
        'lblIncidentTimeReq
        '
        Me.lblIncidentTimeReq.AutoSize = True
        Me.lblIncidentTimeReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblIncidentTimeReq.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.lblIncidentTimeReq.Location = New System.Drawing.Point(1060, 36)
        Me.lblIncidentTimeReq.Name = "lblIncidentTimeReq"
        Me.lblIncidentTimeReq.Size = New System.Drawing.Size(14, 17)
        Me.lblIncidentTimeReq.TabIndex = 12
        Me.lblIncidentTimeReq.Text = "*"
        '
        'dtpIncidentTime
        '
        Me.dtpIncidentTime.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.dtpIncidentTime.CalendarForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.dtpIncidentTime.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpIncidentTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.dtpIncidentTime.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpIncidentTime.CustomFormat = "hh:mm tt"
        Me.dtpIncidentTime.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.dtpIncidentTime.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.dtpIncidentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIncidentTime.Location = New System.Drawing.Point(954, 57)
        Me.dtpIncidentTime.Name = "dtpIncidentTime"
        Me.dtpIncidentTime.ShowUpDown = True
        Me.dtpIncidentTime.Size = New System.Drawing.Size(158, 32)
        Me.dtpIncidentTime.TabIndex = 13
        '
        'lblWarningLevel
        '
        Me.lblWarningLevel.AutoSize = True
        Me.lblWarningLevel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblWarningLevel.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblWarningLevel.Location = New System.Drawing.Point(18, 98)
        Me.lblWarningLevel.Name = "lblWarningLevel"
        Me.lblWarningLevel.Size = New System.Drawing.Size(96, 17)
        Me.lblWarningLevel.TabIndex = 14
        Me.lblWarningLevel.Text = "Warning Level"
        '
        'lblWarningLevelReq
        '
        Me.lblWarningLevelReq.AutoSize = True
        Me.lblWarningLevelReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblWarningLevelReq.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.lblWarningLevelReq.Location = New System.Drawing.Point(116, 98)
        Me.lblWarningLevelReq.Name = "lblWarningLevelReq"
        Me.lblWarningLevelReq.Size = New System.Drawing.Size(14, 17)
        Me.lblWarningLevelReq.TabIndex = 15
        Me.lblWarningLevelReq.Text = "*"
        '
        'cboWarningLevel
        '
        Me.cboWarningLevel.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.cboWarningLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboWarningLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWarningLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboWarningLevel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.cboWarningLevel.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cboWarningLevel.FormattingEnabled = True
        Me.cboWarningLevel.ItemHeight = 28
        Me.cboWarningLevel.Location = New System.Drawing.Point(18, 119)
        Me.cboWarningLevel.Name = "cboWarningLevel"
        Me.cboWarningLevel.Size = New System.Drawing.Size(172, 34)
        Me.cboWarningLevel.TabIndex = 16
        '
        'lblSanction
        '
        Me.lblSanction.AutoSize = True
        Me.lblSanction.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSanction.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblSanction.Location = New System.Drawing.Point(202, 98)
        Me.lblSanction.Name = "lblSanction"
        Me.lblSanction.Size = New System.Drawing.Size(198, 17)
        Me.lblSanction.TabIndex = 17
        Me.lblSanction.Text = "Recommended Sanction / Action"
        '
        'lblSanctionReq
        '
        Me.lblSanctionReq.AutoSize = True
        Me.lblSanctionReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSanctionReq.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.lblSanctionReq.Location = New System.Drawing.Point(402, 98)
        Me.lblSanctionReq.Name = "lblSanctionReq"
        Me.lblSanctionReq.Size = New System.Drawing.Size(14, 17)
        Me.lblSanctionReq.TabIndex = 18
        Me.lblSanctionReq.Text = "*"
        '
        'cboSanction
        '
        Me.cboSanction.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.cboSanction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSanction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSanction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSanction.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.cboSanction.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cboSanction.FormattingEnabled = True
        Me.cboSanction.ItemHeight = 28
        Me.cboSanction.Location = New System.Drawing.Point(202, 119)
        Me.cboSanction.Name = "cboSanction"
        Me.cboSanction.Size = New System.Drawing.Size(372, 34)
        Me.cboSanction.TabIndex = 19
        '
        'txtCustomSanction
        '
        Me.txtCustomSanction.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtCustomSanction.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtCustomSanction.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.txtCustomSanction.Location = New System.Drawing.Point(584, 121)
        Me.txtCustomSanction.Name = "txtCustomSanction"
        Me.txtCustomSanction.Size = New System.Drawing.Size(184, 25)
        Me.txtCustomSanction.TabIndex = 20
        Me.txtCustomSanction.Visible = False
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblRemarks.Location = New System.Drawing.Point(18, 160)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(184, 17)
        Me.lblRemarks.TabIndex = 21
        Me.lblRemarks.Text = "Incident Narrative / Remarks"
        '
        'lblRemarksReq
        '
        Me.lblRemarksReq.AutoSize = True
        Me.lblRemarksReq.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblRemarksReq.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
        Me.lblRemarksReq.Location = New System.Drawing.Point(204, 160)
        Me.lblRemarksReq.Name = "lblRemarksReq"
        Me.lblRemarksReq.Size = New System.Drawing.Size(14, 17)
        Me.lblRemarksReq.TabIndex = 22
        Me.lblRemarksReq.Text = "*"
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.txtRemarks.Location = New System.Drawing.Point(18, 181)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(750, 246)
        Me.txtRemarks.TabIndex = 23
        '
        'panelProofBox
        '
        Me.panelProofBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelProofBox.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.panelProofBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProofBox.Controls.Add(Me.lstAttachments)
        Me.panelProofBox.Controls.Add(Me.btnRemoveAttachment)
        Me.panelProofBox.Controls.Add(Me.btnAttachFiles)
        Me.panelProofBox.Controls.Add(Me.lblProofRules)
        Me.panelProofBox.Controls.Add(Me.lblProofTitle)
        Me.panelProofBox.Location = New System.Drawing.Point(780, 181)
        Me.panelProofBox.Name = "panelProofBox"
        Me.panelProofBox.Size = New System.Drawing.Size(332, 246)
        Me.panelProofBox.TabIndex = 24
        '
        'lblProofTitle
        '
        Me.lblProofTitle.AutoSize = True
        Me.lblProofTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblProofTitle.ForeColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.lblProofTitle.Location = New System.Drawing.Point(12, 8)
        Me.lblProofTitle.Name = "lblProofTitle"
        Me.lblProofTitle.Size = New System.Drawing.Size(195, 17)
        Me.lblProofTitle.TabIndex = 0
        Me.lblProofTitle.Text = "Evidence / Proof (Optional, 1-3)"
        '
        'lblProofRules
        '
        Me.lblProofRules.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblProofRules.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblProofRules.Location = New System.Drawing.Point(12, 28)
        Me.lblProofRules.Name = "lblProofRules"
        Me.lblProofRules.Size = New System.Drawing.Size(306, 36)
        Me.lblProofRules.TabIndex = 1
        Me.lblProofRules.Text = "Attach if available: Images (.jpg,.png,.gif,.bmp) or Docs (.pdf,.doc,.docx), max 5 MB."
        '
        'btnAttachFiles
        '
        Me.btnAttachFiles.BackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.btnAttachFiles.FlatAppearance.BorderSize = 0
        Me.btnAttachFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachFiles.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAttachFiles.ForeColor = System.Drawing.Color.White
        Me.btnAttachFiles.Location = New System.Drawing.Point(12, 70)
        Me.btnAttachFiles.Name = "btnAttachFiles"
        Me.btnAttachFiles.Size = New System.Drawing.Size(124, 30)
        Me.btnAttachFiles.TabIndex = 2
        Me.btnAttachFiles.Text = "Attach Files"
        Me.btnAttachFiles.UseVisualStyleBackColor = False
        '
        'btnRemoveAttachment
        '
        Me.btnRemoveAttachment.BackColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.btnRemoveAttachment.FlatAppearance.BorderSize = 0
        Me.btnRemoveAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveAttachment.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveAttachment.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.btnRemoveAttachment.Location = New System.Drawing.Point(144, 70)
        Me.btnRemoveAttachment.Name = "btnRemoveAttachment"
        Me.btnRemoveAttachment.Size = New System.Drawing.Size(102, 30)
        Me.btnRemoveAttachment.TabIndex = 3
        Me.btnRemoveAttachment.Text = "Remove"
        Me.btnRemoveAttachment.UseVisualStyleBackColor = False
        '
        'lstAttachments
        '
        Me.lstAttachments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAttachments.BackColor = System.Drawing.Color.White
        Me.lstAttachments.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lstAttachments.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.lstAttachments.FormattingEnabled = True
        Me.lstAttachments.ItemHeight = 20
        Me.lstAttachments.Location = New System.Drawing.Point(12, 108)
        Me.lstAttachments.Name = "lstAttachments"
        Me.lstAttachments.Size = New System.Drawing.Size(306, 126)
        Me.lstAttachments.TabIndex = 4
        '
        'btnClearForm
        '
        Me.btnClearForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearForm.BackColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.btnClearForm.FlatAppearance.BorderSize = 0
        Me.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearForm.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearForm.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.btnClearForm.Location = New System.Drawing.Point(824, 439)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(132, 38)
        Me.btnClearForm.TabIndex = 25
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'btnSaveInfraction
        '
        Me.btnSaveInfraction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveInfraction.BackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.btnSaveInfraction.FlatAppearance.BorderSize = 0
        Me.btnSaveInfraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveInfraction.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveInfraction.ForeColor = System.Drawing.Color.White
        Me.btnSaveInfraction.Location = New System.Drawing.Point(964, 439)
        Me.btnSaveInfraction.Name = "btnSaveInfraction"
        Me.btnSaveInfraction.Size = New System.Drawing.Size(148, 38)
        Me.btnSaveInfraction.TabIndex = 26
        Me.btnSaveInfraction.Text = "Save Infraction"
        Me.btnSaveInfraction.UseVisualStyleBackColor = False
        '
        'UcLogOffense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.Controls.Add(Me.panelOffenseCard)
        Me.Controls.Add(Me.panelStudentCard)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "UcLogOffense"
        Me.Size = New System.Drawing.Size(1180, 768)
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.panelStudentCard.ResumeLayout(False)
        Me.panelStudentCard.PerformLayout()
        Me.panelOffenseCard.ResumeLayout(False)
        Me.panelOffenseCard.PerformLayout()
        Me.panelProofBox.ResumeLayout(False)
        Me.panelProofBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelStudentCard As Panel
    Friend WithEvents txtSection As TextBox
    Friend WithEvents lblSection As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnFindStudent As Button
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents lblStudentIDReq As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblStudentSectionTitle As Label
    Friend WithEvents panelOffenseCard As Panel
    Friend WithEvents btnSaveInfraction As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents panelProofBox As Panel
    Friend WithEvents lstAttachments As ListBox
    Friend WithEvents btnRemoveAttachment As Button
    Friend WithEvents btnAttachFiles As Button
    Friend WithEvents lblProofRules As Label
    Friend WithEvents lblProofTitle As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblRemarksReq As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtCustomSanction As TextBox
    Friend WithEvents cboSanction As ComboBox
    Friend WithEvents lblSanctionReq As Label
    Friend WithEvents lblSanction As Label
    Friend WithEvents cboWarningLevel As ComboBox
    Friend WithEvents lblWarningLevelReq As Label
    Friend WithEvents lblWarningLevel As Label
    Friend WithEvents dtpIncidentTime As DateTimePicker
    Friend WithEvents lblIncidentTimeReq As Label
    Friend WithEvents lblIncidentTime As Label
    Friend WithEvents dtpIncidentDate As DateTimePicker
    Friend WithEvents lblIncidentDateReq As Label
    Friend WithEvents lblIncidentDate As Label
    Friend WithEvents txtCustomOffense As TextBox
    Friend WithEvents cboSpecificOffense As ComboBox
    Friend WithEvents lblSpecificOffenseReq As Label
    Friend WithEvents lblSpecificOffense As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblCategoryReq As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblOffenseSectionTitle As Label
End Class