<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcLogOffense
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelStudentInfo = New System.Windows.Forms.Panel()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnFindStudent = New System.Windows.Forms.Button()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelOffenseDetails = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.txtNarrative = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboSanction = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbMajor = New System.Windows.Forms.RadioButton()
        Me.rbMinor = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpIncidentTime = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboOffenseCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panelStudentInfo.SuspendLayout()
        Me.panelOffenseDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblSubtitle)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 65)
        Me.Panel1.TabIndex = 0
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Location = New System.Drawing.Point(20, 42)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(496, 13)
        Me.lblSubtitle.TabIndex = 4
        Me.lblSubtitle.Text = "Log individual student offenses with details, severity classification, and recomm" &
    "ended sanctions."
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(289, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Record New Student Infraction"
        '
        'panelStudentInfo
        '
        Me.panelStudentInfo.BackColor = System.Drawing.Color.White
        Me.panelStudentInfo.Controls.Add(Me.cboYearLevel)
        Me.panelStudentInfo.Controls.Add(Me.lblYearLevel)
        Me.panelStudentInfo.Controls.Add(Me.cboDepartment)
        Me.panelStudentInfo.Controls.Add(Me.lblDepartment)
        Me.panelStudentInfo.Controls.Add(Me.txtFullName)
        Me.panelStudentInfo.Controls.Add(Me.lblFullName)
        Me.panelStudentInfo.Controls.Add(Me.btnFindStudent)
        Me.panelStudentInfo.Controls.Add(Me.txtStudentID)
        Me.panelStudentInfo.Controls.Add(Me.lblStudentID)
        Me.panelStudentInfo.Controls.Add(Me.Label2)
        Me.panelStudentInfo.Location = New System.Drawing.Point(20, 70)
        Me.panelStudentInfo.Name = "panelStudentInfo"
        Me.panelStudentInfo.Size = New System.Drawing.Size(880, 110)
        Me.panelStudentInfo.TabIndex = 1
        '
        'cboYearLevel
        '
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(655, 55)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(210, 21)
        Me.cboYearLevel.TabIndex = 9
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblYearLevel.Location = New System.Drawing.Point(655, 35)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(59, 13)
        Me.lblYearLevel.TabIndex = 8
        Me.lblYearLevel.Text = "Year Level"
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(425, 55)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(220, 21)
        Me.cboDepartment.TabIndex = 7
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblDepartment.Location = New System.Drawing.Point(425, 35)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(125, 13)
        Me.lblDepartment.TabIndex = 6
        Me.lblDepartment.Text = "Department / Program"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(195, 55)
        Me.txtFullName.Multiline = True
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(220, 25)
        Me.txtFullName.TabIndex = 5
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblFullName.Location = New System.Drawing.Point(195, 35)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(60, 13)
        Me.lblFullName.TabIndex = 4
        Me.lblFullName.Text = "Full Name"
        '
        'btnFindStudent
        '
        Me.btnFindStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnFindStudent.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindStudent.ForeColor = System.Drawing.Color.White
        Me.btnFindStudent.Location = New System.Drawing.Point(130, 55)
        Me.btnFindStudent.Name = "btnFindStudent"
        Me.btnFindStudent.Size = New System.Drawing.Size(55, 25)
        Me.btnFindStudent.TabIndex = 3
        Me.btnFindStudent.Text = "FIND"
        Me.btnFindStudent.UseVisualStyleBackColor = False
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(15, 55)
        Me.txtStudentID.Multiline = True
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(110, 25)
        Me.txtStudentID.TabIndex = 2
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblStudentID.Location = New System.Drawing.Point(15, 35)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(62, 13)
        Me.lblStudentID.TabIndex = 1
        Me.lblStudentID.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(15, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student Information"
        '
        'panelOffenseDetails
        '
        Me.panelOffenseDetails.BackColor = System.Drawing.Color.White
        Me.panelOffenseDetails.Controls.Add(Me.btnSave)
        Me.panelOffenseDetails.Controls.Add(Me.btnClearForm)
        Me.panelOffenseDetails.Controls.Add(Me.txtNarrative)
        Me.panelOffenseDetails.Controls.Add(Me.Label8)
        Me.panelOffenseDetails.Controls.Add(Me.cboSanction)
        Me.panelOffenseDetails.Controls.Add(Me.Label7)
        Me.panelOffenseDetails.Controls.Add(Me.rbMajor)
        Me.panelOffenseDetails.Controls.Add(Me.rbMinor)
        Me.panelOffenseDetails.Controls.Add(Me.Label6)
        Me.panelOffenseDetails.Controls.Add(Me.dtpIncidentTime)
        Me.panelOffenseDetails.Controls.Add(Me.Label5)
        Me.panelOffenseDetails.Controls.Add(Me.dtpIncidentDate)
        Me.panelOffenseDetails.Controls.Add(Me.Label4)
        Me.panelOffenseDetails.Controls.Add(Me.cboOffenseCategory)
        Me.panelOffenseDetails.Controls.Add(Me.Label3)
        Me.panelOffenseDetails.Controls.Add(Me.Label1)
        Me.panelOffenseDetails.Location = New System.Drawing.Point(20, 195)
        Me.panelOffenseDetails.Name = "panelOffenseDetails"
        Me.panelOffenseDetails.Size = New System.Drawing.Size(880, 420)
        Me.panelOffenseDetails.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(715, 360)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 35)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearForm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.ForeColor = System.Drawing.Color.Black
        Me.btnClearForm.Location = New System.Drawing.Point(560, 360)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(140, 35)
        Me.btnClearForm.TabIndex = 21
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'txtNarrative
        '
        Me.txtNarrative.Location = New System.Drawing.Point(15, 175)
        Me.txtNarrative.Multiline = True
        Me.txtNarrative.Name = "txtNarrative"
        Me.txtNarrative.Size = New System.Drawing.Size(850, 150)
        Me.txtNarrative.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Incident Narrative / Detailed Remarks"
        '
        'cboSanction
        '
        Me.cboSanction.FormattingEnabled = True
        Me.cboSanction.Items.AddRange(New Object() {"Written Warning", "Guardian Conference", "Community Service", "Disciplinary Board Referral"})
        Me.cboSanction.Location = New System.Drawing.Point(330, 125)
        Me.cboSanction.Name = "cboSanction"
        Me.cboSanction.Size = New System.Drawing.Size(240, 21)
        Me.cboSanction.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(330, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Recommended Sanction / Intervention"
        '
        'rbMajor
        '
        Me.rbMajor.AutoSize = True
        Me.rbMajor.Location = New System.Drawing.Point(130, 125)
        Me.rbMajor.Name = "rbMajor"
        Me.rbMajor.Size = New System.Drawing.Size(91, 17)
        Me.rbMajor.TabIndex = 17
        Me.rbMajor.TabStop = True
        Me.rbMajor.Text = "Major Offense"
        Me.rbMajor.UseVisualStyleBackColor = True
        '
        'rbMinor
        '
        Me.rbMinor.AutoSize = True
        Me.rbMinor.Location = New System.Drawing.Point(15, 125)
        Me.rbMinor.Name = "rbMinor"
        Me.rbMinor.Size = New System.Drawing.Size(91, 17)
        Me.rbMinor.TabIndex = 16
        Me.rbMinor.TabStop = True
        Me.rbMinor.Text = "Minor Offense"
        Me.rbMinor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Severity Level"
        '
        'dtpIncidentTime
        '
        Me.dtpIncidentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpIncidentTime.Location = New System.Drawing.Point(580, 65)
        Me.dtpIncidentTime.Name = "dtpIncidentTime"
        Me.dtpIncidentTime.Size = New System.Drawing.Size(285, 20)
        Me.dtpIncidentTime.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(580, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Time of Incident"
        '
        'dtpIncidentDate
        '
        Me.dtpIncidentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIncidentDate.Location = New System.Drawing.Point(330, 65)
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Size = New System.Drawing.Size(240, 20)
        Me.dtpIncidentDate.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(330, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Date of Incident (MM/DD/YYYY)"
        '
        'cboOffenseCategory
        '
        Me.cboOffenseCategory.FormattingEnabled = True
        Me.cboOffenseCategory.Location = New System.Drawing.Point(15, 65)
        Me.cboOffenseCategory.Name = "cboOffenseCategory"
        Me.cboOffenseCategory.Size = New System.Drawing.Size(300, 21)
        Me.cboOffenseCategory.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Offense Category / Classification"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Offense Details"
        '
        'UcLogOffense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.panelOffenseDetails)
        Me.Controls.Add(Me.panelStudentInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UcLogOffense"
        Me.Size = New System.Drawing.Size(920, 635)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelStudentInfo.ResumeLayout(False)
        Me.panelStudentInfo.PerformLayout()
        Me.panelOffenseDetails.ResumeLayout(False)
        Me.panelOffenseDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelStudentInfo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents panelOffenseDetails As Panel
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnFindStudent As Button
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblYearLevel As Label
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpIncidentDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cboOffenseCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpIncidentTime As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents rbMinor As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents cboSanction As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rbMajor As RadioButton
    Friend WithEvents txtNarrative As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnSave As Button
End Class
