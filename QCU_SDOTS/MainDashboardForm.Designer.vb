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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelMainContent = New System.Windows.Forms.Panel()
        Me.panelDashboardView = New System.Windows.Forms.Panel()
        Me.panelTopViolations = New System.Windows.Forms.Panel()
        Me.lblTopViolationsList = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelQuickActions = New System.Windows.Forms.Panel()
        Me.btnGenerateClearance = New System.Windows.Forms.Button()
        Me.btnSearchRecords = New System.Windows.Forms.Button()
        Me.btnQuickLog = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvRecentViolations = New System.Windows.Forms.DataGridView()
        Me.colRecordID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colViolation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblActiveViolations = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClearanceIssued = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPendingSanctions = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalInfractions = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDashboardSubtitle = New System.Windows.Forms.Label()
        Me.lblDashboardTitle = New System.Windows.Forms.Label()
        Me.panelSidebar.SuspendLayout()
        Me.panelMainContent.SuspendLayout()
        Me.panelDashboardView.SuspendLayout()
        Me.panelTopViolations.SuspendLayout()
        Me.panelQuickActions.SuspendLayout()
        CType(Me.dgvRecentViolations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        'panelMainContent
        '
        Me.panelMainContent.Controls.Add(Me.panelDashboardView)
        Me.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainContent.Location = New System.Drawing.Point(260, 0)
        Me.panelMainContent.Name = "panelMainContent"
        Me.panelMainContent.Size = New System.Drawing.Size(924, 661)
        Me.panelMainContent.TabIndex = 1
        '
        'panelDashboardView
        '
        Me.panelDashboardView.Controls.Add(Me.panelTopViolations)
        Me.panelDashboardView.Controls.Add(Me.panelQuickActions)
        Me.panelDashboardView.Controls.Add(Me.dgvRecentViolations)
        Me.panelDashboardView.Controls.Add(Me.Panel5)
        Me.panelDashboardView.Controls.Add(Me.Panel4)
        Me.panelDashboardView.Controls.Add(Me.Panel3)
        Me.panelDashboardView.Controls.Add(Me.Panel2)
        Me.panelDashboardView.Controls.Add(Me.Panel1)
        Me.panelDashboardView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashboardView.Location = New System.Drawing.Point(0, 0)
        Me.panelDashboardView.Name = "panelDashboardView"
        Me.panelDashboardView.Size = New System.Drawing.Size(924, 661)
        Me.panelDashboardView.TabIndex = 0
        '
        'panelTopViolations
        '
        Me.panelTopViolations.BackColor = System.Drawing.Color.White
        Me.panelTopViolations.Controls.Add(Me.lblTopViolationsList)
        Me.panelTopViolations.Controls.Add(Me.Label7)
        Me.panelTopViolations.Location = New System.Drawing.Point(680, 395)
        Me.panelTopViolations.Name = "panelTopViolations"
        Me.panelTopViolations.Size = New System.Drawing.Size(210, 244)
        Me.panelTopViolations.TabIndex = 25
        '
        'lblTopViolationsList
        '
        Me.lblTopViolationsList.BackColor = System.Drawing.Color.Transparent
        Me.lblTopViolationsList.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopViolationsList.ForeColor = System.Drawing.Color.Black
        Me.lblTopViolationsList.Location = New System.Drawing.Point(23, 45)
        Me.lblTopViolationsList.Name = "lblTopViolationsList"
        Me.lblTopViolationsList.Size = New System.Drawing.Size(163, 180)
        Me.lblTopViolationsList.TabIndex = 6
        Me.lblTopViolationsList.Text = "1. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Top Violations This Term"
        '
        'panelQuickActions
        '
        Me.panelQuickActions.BackColor = System.Drawing.Color.White
        Me.panelQuickActions.Controls.Add(Me.btnGenerateClearance)
        Me.panelQuickActions.Controls.Add(Me.btnSearchRecords)
        Me.panelQuickActions.Controls.Add(Me.btnQuickLog)
        Me.panelQuickActions.Controls.Add(Me.Label6)
        Me.panelQuickActions.Location = New System.Drawing.Point(680, 205)
        Me.panelQuickActions.Name = "panelQuickActions"
        Me.panelQuickActions.Size = New System.Drawing.Size(210, 175)
        Me.panelQuickActions.TabIndex = 10
        '
        'btnGenerateClearance
        '
        Me.btnGenerateClearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnGenerateClearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateClearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateClearance.ForeColor = System.Drawing.Color.Black
        Me.btnGenerateClearance.Location = New System.Drawing.Point(16, 121)
        Me.btnGenerateClearance.Name = "btnGenerateClearance"
        Me.btnGenerateClearance.Size = New System.Drawing.Size(180, 35)
        Me.btnGenerateClearance.TabIndex = 24
        Me.btnGenerateClearance.Text = "Generate Clearance Slip"
        Me.btnGenerateClearance.UseVisualStyleBackColor = False
        '
        'btnSearchRecords
        '
        Me.btnSearchRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSearchRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchRecords.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRecords.ForeColor = System.Drawing.Color.Black
        Me.btnSearchRecords.Location = New System.Drawing.Point(16, 80)
        Me.btnSearchRecords.Name = "btnSearchRecords"
        Me.btnSearchRecords.Size = New System.Drawing.Size(180, 35)
        Me.btnSearchRecords.TabIndex = 22
        Me.btnSearchRecords.Text = "Search Offense Records"
        Me.btnSearchRecords.UseVisualStyleBackColor = False
        '
        'btnQuickLog
        '
        Me.btnQuickLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnQuickLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickLog.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickLog.ForeColor = System.Drawing.Color.White
        Me.btnQuickLog.Location = New System.Drawing.Point(16, 42)
        Me.btnQuickLog.Name = "btnQuickLog"
        Me.btnQuickLog.Size = New System.Drawing.Size(180, 32)
        Me.btnQuickLog.TabIndex = 23
        Me.btnQuickLog.Text = "+ Log New Offense"
        Me.btnQuickLog.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(60, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Quick Actions"
        '
        'dgvRecentViolations
        '
        Me.dgvRecentViolations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentViolations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRecordID, Me.colStudentID, Me.colStudentName, Me.colViolation, Me.colDate, Me.colStatus})
        Me.dgvRecentViolations.Location = New System.Drawing.Point(20, 205)
        Me.dgvRecentViolations.Name = "dgvRecentViolations"
        Me.dgvRecentViolations.Size = New System.Drawing.Size(650, 434)
        Me.dgvRecentViolations.TabIndex = 9
        '
        'colRecordID
        '
        Me.colRecordID.HeaderText = "Record ID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colStudentID
        '
        Me.colStudentID.HeaderText = "Student ID"
        Me.colStudentID.Name = "colStudentID"
        '
        'colStudentName
        '
        Me.colStudentName.HeaderText = "Student Name"
        Me.colStudentName.Name = "colStudentName"
        '
        'colViolation
        '
        Me.colViolation.HeaderText = "Offense Type"
        Me.colViolation.Name = "colViolation"
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date Logged"
        Me.colDate.Name = "colDate"
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lblActiveViolations)
        Me.Panel5.Location = New System.Drawing.Point(680, 85)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 100)
        Me.Panel5.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(59, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Active Violations"
        '
        'lblActiveViolations
        '
        Me.lblActiveViolations.AutoSize = True
        Me.lblActiveViolations.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveViolations.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveViolations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblActiveViolations.Location = New System.Drawing.Point(92, 22)
        Me.lblActiveViolations.Name = "lblActiveViolations"
        Me.lblActiveViolations.Size = New System.Drawing.Size(28, 32)
        Me.lblActiveViolations.TabIndex = 5
        Me.lblActiveViolations.Text = "0"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblClearanceIssued)
        Me.Panel4.Location = New System.Drawing.Point(460, 85)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 100)
        Me.Panel4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(54, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Clearances Issued"
        '
        'lblClearanceIssued
        '
        Me.lblClearanceIssued.AutoSize = True
        Me.lblClearanceIssued.BackColor = System.Drawing.Color.Transparent
        Me.lblClearanceIssued.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearanceIssued.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblClearanceIssued.Location = New System.Drawing.Point(93, 22)
        Me.lblClearanceIssued.Name = "lblClearanceIssued"
        Me.lblClearanceIssued.Size = New System.Drawing.Size(28, 32)
        Me.lblClearanceIssued.TabIndex = 5
        Me.lblClearanceIssued.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblPendingSanctions)
        Me.Panel3.Location = New System.Drawing.Point(240, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 100)
        Me.Panel3.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(55, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pending Sanctions"
        '
        'lblPendingSanctions
        '
        Me.lblPendingSanctions.AutoSize = True
        Me.lblPendingSanctions.BackColor = System.Drawing.Color.Transparent
        Me.lblPendingSanctions.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingSanctions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.lblPendingSanctions.Location = New System.Drawing.Point(94, 22)
        Me.lblPendingSanctions.Name = "lblPendingSanctions"
        Me.lblPendingSanctions.Size = New System.Drawing.Size(28, 32)
        Me.lblPendingSanctions.TabIndex = 5
        Me.lblPendingSanctions.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblTotalInfractions)
        Me.Panel2.Location = New System.Drawing.Point(20, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 100)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(57, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total Infractions"
        '
        'lblTotalInfractions
        '
        Me.lblTotalInfractions.AutoSize = True
        Me.lblTotalInfractions.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalInfractions.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInfractions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.lblTotalInfractions.Location = New System.Drawing.Point(90, 22)
        Me.lblTotalInfractions.Name = "lblTotalInfractions"
        Me.lblTotalInfractions.Size = New System.Drawing.Size(28, 32)
        Me.lblTotalInfractions.TabIndex = 5
        Me.lblTotalInfractions.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblDashboardSubtitle)
        Me.Panel1.Controls.Add(Me.lblDashboardTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 65)
        Me.Panel1.TabIndex = 1
        '
        'lblDashboardSubtitle
        '
        Me.lblDashboardSubtitle.AutoSize = True
        Me.lblDashboardSubtitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.lblDashboardSubtitle.Location = New System.Drawing.Point(20, 42)
        Me.lblDashboardSubtitle.Name = "lblDashboardSubtitle"
        Me.lblDashboardSubtitle.Size = New System.Drawing.Size(424, 13)
        Me.lblDashboardSubtitle.TabIndex = 4
        Me.lblDashboardSubtitle.Text = "Monitor institutional infraction metrics, pending disciplinary actions, and live " &
    "logs."
        '
        'lblDashboardTitle
        '
        Me.lblDashboardTitle.AutoSize = True
        Me.lblDashboardTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblDashboardTitle.Name = "lblDashboardTitle"
        Me.lblDashboardTitle.Size = New System.Drawing.Size(284, 25)
        Me.lblDashboardTitle.TabIndex = 0
        Me.lblDashboardTitle.Text = "System Overview and Statistics"
        '
        'MainDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.panelMainContent)
        Me.Controls.Add(Me.panelSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainDashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU Student Disciplinary and Offense Tracking System [Main Dashboard]"
        Me.panelSidebar.ResumeLayout(False)
        Me.panelSidebar.PerformLayout()
        Me.panelMainContent.ResumeLayout(False)
        Me.panelDashboardView.ResumeLayout(False)
        Me.panelTopViolations.ResumeLayout(False)
        Me.panelTopViolations.PerformLayout()
        Me.panelQuickActions.ResumeLayout(False)
        Me.panelQuickActions.PerformLayout()
        CType(Me.dgvRecentViolations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panelMainContent As Panel
    Friend WithEvents panelDashboardView As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDashboardSubtitle As Label
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalInfractions As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPendingSanctions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblClearanceIssued As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblActiveViolations As Label
    Friend WithEvents dgvRecentViolations As DataGridView
    Friend WithEvents colRecordID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colViolation As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents panelQuickActions As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnQuickLog As Button
    Friend WithEvents btnGenerateClearance As Button
    Friend WithEvents btnSearchRecords As Button
    Friend WithEvents panelTopViolations As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTopViolationsList As Label
End Class
