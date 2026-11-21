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
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.txtYearLevel = New System.Windows.Forms.TextBox()
        Me.panelOffenseCard = New System.Windows.Forms.Panel()
        Me.lblOffenseSectionTitle = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblSpecificOffense = New System.Windows.Forms.Label()
        Me.cboSpecificOffense = New System.Windows.Forms.ComboBox()
        Me.lblCustomOffense = New System.Windows.Forms.Label()
        Me.txtCustomOffense = New System.Windows.Forms.TextBox()
        Me.lblIncidentDate = New System.Windows.Forms.Label()
        Me.txtIncidentDate = New System.Windows.Forms.TextBox()
        Me.lblIncidentTime = New System.Windows.Forms.Label()
        Me.txtIncidentTime = New System.Windows.Forms.TextBox()
        Me.lblWarningLevel = New System.Windows.Forms.Label()
        Me.cboWarningLevel = New System.Windows.Forms.ComboBox()
        Me.lblSanction = New System.Windows.Forms.Label()
        Me.cboSanction = New System.Windows.Forms.ComboBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.panelProofBox = New System.Windows.Forms.Panel()
        Me.lblProofTitle = New System.Windows.Forms.Label()
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
        Me.panelHeader.Size = New System.Drawing.Size(1120, 74)
        Me.panelHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(24, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(277, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Record New Student Infraction"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 45)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(520, 17)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Log student offenses, classify severity and warning level, specify custom violations, and attach proof files."
        '
        'panelStudentCard
        '
        Me.panelStudentCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelStudentCard.BackColor = System.Drawing.Color.White
        Me.panelStudentCard.Controls.Add(Me.txtYearLevel)
        Me.panelStudentCard.Controls.Add(Me.lblYearLevel)
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
        Me.panelStudentCard.Controls.Add(Me.lblStudentID)
        Me.panelStudentCard.Controls.Add(Me.lblStudentSectionTitle)
        Me.panelStudentCard.Location = New System.Drawing.Point(24, 88)
        Me.panelStudentCard.Name = "panelStudentCard"
        Me.panelStudentCard.Size = New System.Drawing.Size(1072, 162)
        Me.panelStudentCard.TabIndex = 1
        '
        'lblStudentSectionTitle
        '
        Me.lblStudentSectionTitle.AutoSize = True
        Me.lblStudentSectionTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudentSectionTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblStudentSectionTitle.Location = New System.Drawing.Point(18, 10)
        Me.lblStudentSectionTitle.Name = "lblStudentSectionTitle"
        Me.lblStudentSectionTitle.Size = New System.Drawing.Size(136, 19)
        Me.lblStudentSectionTitle.TabIndex = 0
        Me.lblStudentSectionTitle.Text = "Student Information"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentID.ForeColor = System.Drawing.Color.DimGray
        Me.lblStudentID.Location = New System.Drawing.Point(18, 36)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(74, 15)
        Me.lblStudentID.TabIndex = 1
        Me.lblStudentID.Text = "Student ID *"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStudentID.Location = New System.Drawing.Point(18, 56)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(130, 25)
        Me.txtStudentID.TabIndex = 2
        '
        'btnFindStudent
        '
        Me.btnFindStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFindStudent.FlatAppearance.BorderSize = 0
        Me.btnFindStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnFindStudent.ForeColor = System.Drawing.Color.White
        Me.btnFindStudent.Location = New System.Drawing.Point(156, 54)
        Me.btnFindStudent.Name = "btnFindStudent"
        Me.btnFindStudent.Size = New System.Drawing.Size(64, 29)
        Me.btnFindStudent.TabIndex = 3
        Me.btnFindStudent.Text = "Find"
        Me.btnFindStudent.UseVisualStyleBackColor = False
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.ForeColor = System.Drawing.Color.DimGray
        Me.lblLastName.Location = New System.Drawing.Point(238, 36)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(69, 15)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtLastName.Location = New System.Drawing.Point(238, 56)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(255, 25)
        Me.txtLastName.TabIndex = 5
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.ForeColor = System.Drawing.Color.DimGray
        Me.lblFirstName.Location = New System.Drawing.Point(510, 36)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(70, 15)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(510, 56)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(265, 25)
        Me.txtFirstName.TabIndex = 7
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMiddleName.ForeColor = System.Drawing.Color.DimGray
        Me.lblMiddleName.Location = New System.Drawing.Point(792, 36)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(83, 15)
        Me.lblMiddleName.TabIndex = 8
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMiddleName.Location = New System.Drawing.Point(792, 56)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = True
        Me.txtMiddleName.Size = New System.Drawing.Size(260, 25)
        Me.txtMiddleName.TabIndex = 9
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDepartment.ForeColor = System.Drawing.Color.DimGray
        Me.lblDepartment.Location = New System.Drawing.Point(238, 94)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(134, 15)
        Me.lblDepartment.TabIndex = 10
        Me.lblDepartment.Text = "Department / Program"
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtDepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDepartment.Location = New System.Drawing.Point(238, 114)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(537, 25)
        Me.txtDepartment.TabIndex = 11
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblYearLevel.ForeColor = System.Drawing.Color.DimGray
        Me.lblYearLevel.Location = New System.Drawing.Point(792, 94)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(66, 15)
        Me.lblYearLevel.TabIndex = 12
        Me.lblYearLevel.Text = "Year Level"
        '
        'txtYearLevel
        '
        Me.txtYearLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtYearLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtYearLevel.Location = New System.Drawing.Point(792, 114)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.ReadOnly = True
        Me.txtYearLevel.Size = New System.Drawing.Size(260, 25)
        Me.txtYearLevel.TabIndex = 13
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
        Me.panelOffenseCard.Controls.Add(Me.lblRemarks)
        Me.panelOffenseCard.Controls.Add(Me.cboSanction)
        Me.panelOffenseCard.Controls.Add(Me.lblSanction)
        Me.panelOffenseCard.Controls.Add(Me.cboWarningLevel)
        Me.panelOffenseCard.Controls.Add(Me.lblWarningLevel)
        Me.panelOffenseCard.Controls.Add(Me.txtIncidentTime)
        Me.panelOffenseCard.Controls.Add(Me.lblIncidentTime)
        Me.panelOffenseCard.Controls.Add(Me.txtIncidentDate)
        Me.panelOffenseCard.Controls.Add(Me.lblIncidentDate)
        Me.panelOffenseCard.Controls.Add(Me.txtCustomOffense)
        Me.panelOffenseCard.Controls.Add(Me.lblCustomOffense)
        Me.panelOffenseCard.Controls.Add(Me.cboSpecificOffense)
        Me.panelOffenseCard.Controls.Add(Me.lblSpecificOffense)
        Me.panelOffenseCard.Controls.Add(Me.cboCategory)
        Me.panelOffenseCard.Controls.Add(Me.lblCategory)
        Me.panelOffenseCard.Controls.Add(Me.lblOffenseSectionTitle)
        Me.panelOffenseCard.Location = New System.Drawing.Point(24, 262)
        Me.panelOffenseCard.Name = "panelOffenseCard"
        Me.panelOffenseCard.Size = New System.Drawing.Size(1072, 488)
        Me.panelOffenseCard.TabIndex = 2
        '
        'lblOffenseSectionTitle
        '
        Me.lblOffenseSectionTitle.AutoSize = True
        Me.lblOffenseSectionTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblOffenseSectionTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblOffenseSectionTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblOffenseSectionTitle.Name = "lblOffenseSectionTitle"
        Me.lblOffenseSectionTitle.Size = New System.Drawing.Size(113, 19)
        Me.lblOffenseSectionTitle.TabIndex = 0
        Me.lblOffenseSectionTitle.Text = "Offense Details"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.DimGray
        Me.lblCategory.Location = New System.Drawing.Point(18, 40)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(118, 15)
        Me.lblCategory.TabIndex = 1
        Me.lblCategory.Text = "Offense Category *"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(18, 60)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(155, 25)
        Me.cboCategory.TabIndex = 2
        '
        'lblSpecificOffense
        '
        Me.lblSpecificOffense.AutoSize = True
        Me.lblSpecificOffense.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSpecificOffense.ForeColor = System.Drawing.Color.DimGray
        Me.lblSpecificOffense.Location = New System.Drawing.Point(188, 40)
        Me.lblSpecificOffense.Name = "lblSpecificOffense"
        Me.lblSpecificOffense.Size = New System.Drawing.Size(106, 15)
        Me.lblSpecificOffense.TabIndex = 3
        Me.lblSpecificOffense.Text = "Specific Offense *"
        '
        'cboSpecificOffense
        '
        Me.cboSpecificOffense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpecificOffense.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboSpecificOffense.FormattingEnabled = True
        Me.cboSpecificOffense.Location = New System.Drawing.Point(188, 60)
        Me.cboSpecificOffense.Name = "cboSpecificOffense"
        Me.cboSpecificOffense.Size = New System.Drawing.Size(482, 25)
        Me.cboSpecificOffense.TabIndex = 4
        '
        'lblIncidentDate
        '
        Me.lblIncidentDate.AutoSize = True
        Me.lblIncidentDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblIncidentDate.ForeColor = System.Drawing.Color.DimGray
        Me.lblIncidentDate.Location = New System.Drawing.Point(686, 40)
        Me.lblIncidentDate.Name = "lblIncidentDate"
        Me.lblIncidentDate.Size = New System.Drawing.Size(156, 15)
        Me.lblIncidentDate.TabIndex = 5
        Me.lblIncidentDate.Text = "Date of Incident (MM/DD/YYYY)"
        '
        'txtIncidentDate
        '
        Me.txtIncidentDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtIncidentDate.Location = New System.Drawing.Point(686, 60)
        Me.txtIncidentDate.Name = "txtIncidentDate"
        Me.txtIncidentDate.Size = New System.Drawing.Size(185, 25)
        Me.txtIncidentDate.TabIndex = 6
        '
        'lblIncidentTime
        '
        Me.lblIncidentTime.AutoSize = True
        Me.lblIncidentTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblIncidentTime.ForeColor = System.Drawing.Color.DimGray
        Me.lblIncidentTime.Location = New System.Drawing.Point(886, 40)
        Me.lblIncidentTime.Name = "lblIncidentTime"
        Me.lblIncidentTime.Size = New System.Drawing.Size(96, 15)
        Me.lblIncidentTime.TabIndex = 7
        Me.lblIncidentTime.Text = "Time of Incident"
        '
        'txtIncidentTime
        '
        Me.txtIncidentTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtIncidentTime.Location = New System.Drawing.Point(886, 60)
        Me.txtIncidentTime.Name = "txtIncidentTime"
        Me.txtIncidentTime.Size = New System.Drawing.Size(166, 25)
        Me.txtIncidentTime.TabIndex = 8
        '
        'lblWarningLevel
        '
        Me.lblWarningLevel.AutoSize = True
        Me.lblWarningLevel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblWarningLevel.ForeColor = System.Drawing.Color.DimGray
        Me.lblWarningLevel.Location = New System.Drawing.Point(18, 98)
        Me.lblWarningLevel.Name = "lblWarningLevel"
        Me.lblWarningLevel.Size = New System.Drawing.Size(92, 15)
        Me.lblWarningLevel.TabIndex = 9
        Me.lblWarningLevel.Text = "Warning Level"
        '
        'cboWarningLevel
        '
        Me.cboWarningLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWarningLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboWarningLevel.FormattingEnabled = True
        Me.cboWarningLevel.Location = New System.Drawing.Point(18, 118)
        Me.cboWarningLevel.Name = "cboWarningLevel"
        Me.cboWarningLevel.Size = New System.Drawing.Size(220, 25)
        Me.cboWarningLevel.TabIndex = 10
        '
        'lblSanction
        '
        Me.lblSanction.AutoSize = True
        Me.lblSanction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSanction.ForeColor = System.Drawing.Color.DimGray
        Me.lblSanction.Location = New System.Drawing.Point(254, 98)
        Me.lblSanction.Name = "lblSanction"
        Me.lblSanction.Size = New System.Drawing.Size(171, 15)
        Me.lblSanction.TabIndex = 11
        Me.lblSanction.Text = "Recommended Sanction / Action"
        '
        'cboSanction
        '
        Me.cboSanction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSanction.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboSanction.FormattingEnabled = True
        Me.cboSanction.Location = New System.Drawing.Point(254, 118)
        Me.cboSanction.Name = "cboSanction"
        Me.cboSanction.Size = New System.Drawing.Size(305, 25)
        Me.cboSanction.TabIndex = 12
        '
        'lblCustomOffense
        '
        Me.lblCustomOffense.AutoSize = True
        Me.lblCustomOffense.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomOffense.ForeColor = System.Drawing.Color.DimGray
        Me.lblCustomOffense.Location = New System.Drawing.Point(575, 98)
        Me.lblCustomOffense.Name = "lblCustomOffense"
        Me.lblCustomOffense.Size = New System.Drawing.Size(195, 15)
        Me.lblCustomOffense.TabIndex = 13
        Me.lblCustomOffense.Text = "Specify Offense (If Others)"
        Me.lblCustomOffense.Visible = False
        '
        'txtCustomOffense
        '
        Me.txtCustomOffense.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCustomOffense.Location = New System.Drawing.Point(575, 118)
        Me.txtCustomOffense.Name = "txtCustomOffense"
        Me.txtCustomOffense.Size = New System.Drawing.Size(477, 25)
        Me.txtCustomOffense.TabIndex = 14
        Me.txtCustomOffense.Visible = False
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks.ForeColor = System.Drawing.Color.DimGray
        Me.lblRemarks.Location = New System.Drawing.Point(18, 156)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(192, 15)
        Me.lblRemarks.TabIndex = 15
        Me.lblRemarks.Text = "Incident Narrative / Detailed Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(18, 176)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(652, 246)
        Me.txtRemarks.TabIndex = 16
        '
        'panelProofBox
        '
        Me.panelProofBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelProofBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.panelProofBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProofBox.Controls.Add(Me.lstAttachments)
        Me.panelProofBox.Controls.Add(Me.btnRemoveAttachment)
        Me.panelProofBox.Controls.Add(Me.btnAttachFiles)
        Me.panelProofBox.Controls.Add(Me.lblProofTitle)
        Me.panelProofBox.Location = New System.Drawing.Point(686, 176)
        Me.panelProofBox.Name = "panelProofBox"
        Me.panelProofBox.Size = New System.Drawing.Size(366, 246)
        Me.panelProofBox.TabIndex = 17
        '
        'lblProofTitle
        '
        Me.lblProofTitle.AutoSize = True
        Me.lblProofTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblProofTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblProofTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblProofTitle.Name = "lblProofTitle"
        Me.lblProofTitle.Size = New System.Drawing.Size(171, 17)
        Me.lblProofTitle.TabIndex = 0
        Me.lblProofTitle.Text = "Evidence / Proof Attachments"
        '
        'btnAttachFiles
        '
        Me.btnAttachFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAttachFiles.FlatAppearance.BorderSize = 0
        Me.btnAttachFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachFiles.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnAttachFiles.ForeColor = System.Drawing.Color.White
        Me.btnAttachFiles.Location = New System.Drawing.Point(12, 34)
        Me.btnAttachFiles.Name = "btnAttachFiles"
        Me.btnAttachFiles.Size = New System.Drawing.Size(115, 28)
        Me.btnAttachFiles.TabIndex = 1
        Me.btnAttachFiles.Text = "Attach Files"
        Me.btnAttachFiles.UseVisualStyleBackColor = False
        '
        'btnRemoveAttachment
        '
        Me.btnRemoveAttachment.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRemoveAttachment.FlatAppearance.BorderSize = 0
        Me.btnRemoveAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveAttachment.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveAttachment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnRemoveAttachment.Location = New System.Drawing.Point(135, 34)
        Me.btnRemoveAttachment.Name = "btnRemoveAttachment"
        Me.btnRemoveAttachment.Size = New System.Drawing.Size(85, 28)
        Me.btnRemoveAttachment.TabIndex = 2
        Me.btnRemoveAttachment.Text = "Remove"
        Me.btnRemoveAttachment.UseVisualStyleBackColor = False
        '
        'lstAttachments
        '
        Me.lstAttachments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAttachments.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lstAttachments.FormattingEnabled = True
        Me.lstAttachments.ItemHeight = 15
        Me.lstAttachments.Location = New System.Drawing.Point(12, 70)
        Me.lstAttachments.Name = "lstAttachments"
        Me.lstAttachments.Size = New System.Drawing.Size(340, 162)
        Me.lstAttachments.TabIndex = 3
        '
        'btnClearForm
        '
        Me.btnClearForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnClearForm.FlatAppearance.BorderSize = 0
        Me.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearForm.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnClearForm.Location = New System.Drawing.Point(780, 436)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(120, 36)
        Me.btnClearForm.TabIndex = 18
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'btnSaveInfraction
        '
        Me.btnSaveInfraction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveInfraction.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSaveInfraction.FlatAppearance.BorderSize = 0
        Me.btnSaveInfraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveInfraction.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveInfraction.ForeColor = System.Drawing.Color.White
        Me.btnSaveInfraction.Location = New System.Drawing.Point(912, 436)
        Me.btnSaveInfraction.Name = "btnSaveInfraction"
        Me.btnSaveInfraction.Size = New System.Drawing.Size(140, 36)
        Me.btnSaveInfraction.TabIndex = 19
        Me.btnSaveInfraction.Text = "Save Infraction"
        Me.btnSaveInfraction.UseVisualStyleBackColor = False
        '
        'UcLogOffense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.panelOffenseCard)
        Me.Controls.Add(Me.panelStudentCard)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "UcLogOffense"
        Me.Size = New System.Drawing.Size(1120, 768)
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
    Friend WithEvents txtYearLevel As TextBox
    Friend WithEvents lblYearLevel As Label
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
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblStudentSectionTitle As Label
    Friend WithEvents panelOffenseCard As Panel
    Friend WithEvents btnSaveInfraction As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents panelProofBox As Panel
    Friend WithEvents lstAttachments As ListBox
    Friend WithEvents btnRemoveAttachment As Button
    Friend WithEvents btnAttachFiles As Button
    Friend WithEvents lblProofTitle As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents cboSanction As ComboBox
    Friend WithEvents lblSanction As Label
    Friend WithEvents txtCustomOffense As TextBox
    Friend WithEvents lblCustomOffense As Label
    Friend WithEvents cboSpecificOffense As ComboBox
    Friend WithEvents lblSpecificOffense As Label
    Friend WithEvents txtIncidentTime As TextBox
    Friend WithEvents lblIncidentTime As Label
    Friend WithEvents txtIncidentDate As TextBox
    Friend WithEvents lblIncidentDate As Label
    Friend WithEvents cboWarningLevel As ComboBox
    Friend WithEvents lblWarningLevel As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblOffenseSectionTitle As Label
End Class