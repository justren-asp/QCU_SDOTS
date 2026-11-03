<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashboardForm))
        Me.panelSidebar = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLogOffenseSidebar = New System.Windows.Forms.Button()
        Me.btnDashboardSidebar = New System.Windows.Forms.Button()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panelMainContent = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnClearance = New System.Windows.Forms.Button()
        Me.BtnSearchRecords = New System.Windows.Forms.Button()
        Me.BtnQuickLog = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvRecentViolations = New System.Windows.Forms.DataGridView()
        Me.colRecordID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colViolation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblActiveViolations = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblClearanceIssued = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPendingSanctions = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalInfractions = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelSidebar.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.panelMainContent.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvRecentViolations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSidebar
        '
        Me.panelSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.panelSidebar.Controls.Add(Me.Label10)
        Me.panelSidebar.Controls.Add(Me.Button7)
        Me.panelSidebar.Controls.Add(Me.Button6)
        Me.panelSidebar.Controls.Add(Me.Button5)
        Me.panelSidebar.Controls.Add(Me.Button4)
        Me.panelSidebar.Controls.Add(Me.Button3)
        Me.panelSidebar.Controls.Add(Me.btnLogOffenseSidebar)
        Me.panelSidebar.Controls.Add(Me.btnDashboardSidebar)
        Me.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.panelSidebar.Name = "panelSidebar"
        Me.panelSidebar.Size = New System.Drawing.Size(260, 661)
        Me.panelSidebar.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 25)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "ADMIN CONSOLE"
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(12, 354)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(232, 40)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Log out"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(12, 308)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(232, 40)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Reports & Analytics"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(12, 262)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(232, 40)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Clearance Generator"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(12, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(232, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Search Records"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(12, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(232, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Sanction Tracker"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnLogOffenseSidebar
        '
        Me.btnLogOffenseSidebar.FlatAppearance.BorderSize = 0
        Me.btnLogOffenseSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOffenseSidebar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOffenseSidebar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogOffenseSidebar.Location = New System.Drawing.Point(12, 124)
        Me.btnLogOffenseSidebar.Name = "btnLogOffenseSidebar"
        Me.btnLogOffenseSidebar.Size = New System.Drawing.Size(232, 40)
        Me.btnLogOffenseSidebar.TabIndex = 1
        Me.btnLogOffenseSidebar.Text = "Log Offense / Profile"
        Me.btnLogOffenseSidebar.UseVisualStyleBackColor = True
        '
        'btnDashboardSidebar
        '
        Me.btnDashboardSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDashboardSidebar.FlatAppearance.BorderSize = 0
        Me.btnDashboardSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboardSidebar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboardSidebar.ForeColor = System.Drawing.Color.White
        Me.btnDashboardSidebar.Location = New System.Drawing.Point(12, 78)
        Me.btnDashboardSidebar.Name = "btnDashboardSidebar"
        Me.btnDashboardSidebar.Size = New System.Drawing.Size(232, 40)
        Me.btnDashboardSidebar.TabIndex = 0
        Me.btnDashboardSidebar.Text = "Dashboard"
        Me.btnDashboardSidebar.UseVisualStyleBackColor = False
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.White
        Me.panelHeader.Controls.Add(Me.Panel8)
        Me.panelHeader.Controls.Add(Me.Label11)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(260, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(924, 65)
        Me.panelHeader.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(924, 65)
        Me.Panel8.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SYSTEM OVERVIEW AND STATISTICS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(23, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(340, 25)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "SYSTEM OVERVIEW AND STATISTICS"
        '
        'panelMainContent
        '
        Me.panelMainContent.Controls.Add(Me.Panel6)
        Me.panelMainContent.Controls.Add(Me.Panel5)
        Me.panelMainContent.Controls.Add(Me.dgvRecentViolations)
        Me.panelMainContent.Controls.Add(Me.Panel4)
        Me.panelMainContent.Controls.Add(Me.Panel3)
        Me.panelMainContent.Controls.Add(Me.Panel2)
        Me.panelMainContent.Controls.Add(Me.Panel1)
        Me.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainContent.Location = New System.Drawing.Point(260, 65)
        Me.panelMainContent.Name = "panelMainContent"
        Me.panelMainContent.Size = New System.Drawing.Size(924, 596)
        Me.panelMainContent.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Location = New System.Drawing.Point(712, 323)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 251)
        Me.Panel6.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(17, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "2. Unauthorized Absence"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(17, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "1. Dress Code Non-Compliance"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(17, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Top Violations This Term"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.BtnClearance)
        Me.Panel5.Controls.Add(Me.BtnSearchRecords)
        Me.Panel5.Controls.Add(Me.BtnQuickLog)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(712, 139)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 164)
        Me.Panel5.TabIndex = 3
        '
        'BtnClearance
        '
        Me.BtnClearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnClearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearance.ForeColor = System.Drawing.Color.Black
        Me.BtnClearance.Location = New System.Drawing.Point(20, 117)
        Me.BtnClearance.Name = "BtnClearance"
        Me.BtnClearance.Size = New System.Drawing.Size(168, 29)
        Me.BtnClearance.TabIndex = 3
        Me.BtnClearance.Text = "Generate Clearance Slip"
        Me.BtnClearance.UseVisualStyleBackColor = False
        '
        'BtnSearchRecords
        '
        Me.BtnSearchRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnSearchRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchRecords.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchRecords.ForeColor = System.Drawing.Color.Black
        Me.BtnSearchRecords.Location = New System.Drawing.Point(20, 82)
        Me.BtnSearchRecords.Name = "BtnSearchRecords"
        Me.BtnSearchRecords.Size = New System.Drawing.Size(168, 29)
        Me.BtnSearchRecords.TabIndex = 2
        Me.BtnSearchRecords.Text = "Search Student Records"
        Me.BtnSearchRecords.UseVisualStyleBackColor = False
        '
        'BtnQuickLog
        '
        Me.BtnQuickLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BtnQuickLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuickLog.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuickLog.ForeColor = System.Drawing.Color.White
        Me.BtnQuickLog.Location = New System.Drawing.Point(20, 47)
        Me.BtnQuickLog.Name = "BtnQuickLog"
        Me.BtnQuickLog.Size = New System.Drawing.Size(168, 29)
        Me.BtnQuickLog.TabIndex = 1
        Me.BtnQuickLog.Text = "Quick-Log Student Offense"
        Me.BtnQuickLog.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Disciplinary Quick Actions"
        '
        'dgvRecentViolations
        '
        Me.dgvRecentViolations.AllowUserToAddRows = False
        Me.dgvRecentViolations.AllowUserToDeleteRows = False
        Me.dgvRecentViolations.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecentViolations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentViolations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRecordID, Me.colStudentName, Me.colViolation, Me.colDate, Me.colStatus})
        Me.dgvRecentViolations.Location = New System.Drawing.Point(16, 139)
        Me.dgvRecentViolations.Name = "dgvRecentViolations"
        Me.dgvRecentViolations.ReadOnly = True
        Me.dgvRecentViolations.Size = New System.Drawing.Size(665, 435)
        Me.dgvRecentViolations.TabIndex = 2
        '
        'colRecordID
        '
        Me.colRecordID.HeaderText = "Record ID"
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.ReadOnly = True
        '
        'colStudentName
        '
        Me.colStudentName.HeaderText = "Student Name"
        Me.colStudentName.Name = "colStudentName"
        Me.colStudentName.ReadOnly = True
        '
        'colViolation
        '
        Me.colViolation.HeaderText = "Offense / Violation"
        Me.colViolation.Name = "colViolation"
        Me.colViolation.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date Logged"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblActiveViolations)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(712, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 90)
        Me.Panel4.TabIndex = 1
        '
        'lblActiveViolations
        '
        Me.lblActiveViolations.AutoSize = True
        Me.lblActiveViolations.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveViolations.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveViolations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblActiveViolations.Location = New System.Drawing.Point(78, 16)
        Me.lblActiveViolations.Name = "lblActiveViolations"
        Me.lblActiveViolations.Size = New System.Drawing.Size(49, 37)
        Me.lblActiveViolations.TabIndex = 4
        Me.lblActiveViolations.Text = "14"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(53, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Active Violations"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblClearanceIssued)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(481, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 90)
        Me.Panel3.TabIndex = 1
        '
        'lblClearanceIssued
        '
        Me.lblClearanceIssued.AutoSize = True
        Me.lblClearanceIssued.BackColor = System.Drawing.Color.Transparent
        Me.lblClearanceIssued.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearanceIssued.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblClearanceIssued.Location = New System.Drawing.Point(77, 16)
        Me.lblClearanceIssued.Name = "lblClearanceIssued"
        Me.lblClearanceIssued.Size = New System.Drawing.Size(49, 37)
        Me.lblClearanceIssued.TabIndex = 3
        Me.lblClearanceIssued.Text = "14"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(50, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Clearances Issued"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblPendingSanctions)
        Me.Panel2.Location = New System.Drawing.Point(246, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 90)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(47, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Pending Sanctions"
        '
        'lblPendingSanctions
        '
        Me.lblPendingSanctions.AutoSize = True
        Me.lblPendingSanctions.BackColor = System.Drawing.Color.Transparent
        Me.lblPendingSanctions.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingSanctions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.lblPendingSanctions.Location = New System.Drawing.Point(75, 16)
        Me.lblPendingSanctions.Name = "lblPendingSanctions"
        Me.lblPendingSanctions.Size = New System.Drawing.Size(49, 37)
        Me.lblPendingSanctions.TabIndex = 2
        Me.lblPendingSanctions.Text = "37"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblTotalInfractions)
        Me.Panel1.Location = New System.Drawing.Point(16, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 90)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(50, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Infractions"
        '
        'lblTotalInfractions
        '
        Me.lblTotalInfractions.AutoSize = True
        Me.lblTotalInfractions.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalInfractions.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInfractions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.lblTotalInfractions.Location = New System.Drawing.Point(66, 16)
        Me.lblTotalInfractions.Name = "lblTotalInfractions"
        Me.lblTotalInfractions.Size = New System.Drawing.Size(65, 37)
        Me.lblTotalInfractions.TabIndex = 0
        Me.lblTotalInfractions.Text = "142"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(292, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(340, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SYSTEM OVERVIEW AND STATISTICS"
        '
        'MainDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.panelMainContent)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.panelSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainDashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU Student Disciplinary and Offense Tracking System [Main Dashboard]"
        Me.panelSidebar.ResumeLayout(False)
        Me.panelSidebar.PerformLayout()
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.panelMainContent.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvRecentViolations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSidebar As Panel
    Friend WithEvents btnDashboardSidebar As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLogOffenseSidebar As Button
    Friend WithEvents panelHeader As Panel
    Friend WithEvents panelMainContent As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalInfractions As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPendingSanctions As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvRecentViolations As DataGridView
    Friend WithEvents lblActiveViolations As Label
    Friend WithEvents lblClearanceIssued As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents colRecordID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colViolation As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSearchRecords As Button
    Friend WithEvents BtnQuickLog As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnClearance As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
