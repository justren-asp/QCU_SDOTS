<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcSanctionTracker
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
        Me.panelCardInProgress = New System.Windows.Forms.Panel()
        Me.lblCaptionInProgress = New System.Windows.Forms.Label()
        Me.lblCountInProgress = New System.Windows.Forms.Label()
        Me.panelCardEscalated = New System.Windows.Forms.Panel()
        Me.lblCaptionEscalated = New System.Windows.Forms.Label()
        Me.lblCountEscalated = New System.Windows.Forms.Label()
        Me.panelCardCompleted = New System.Windows.Forms.Panel()
        Me.lblCaptionCompleted = New System.Windows.Forms.Label()
        Me.lblCountCompleted = New System.Windows.Forms.Label()
        Me.panelCardOverdue = New System.Windows.Forms.Panel()
        Me.lblCaptionOverdue = New System.Windows.Forms.Label()
        Me.lblCountOverdue = New System.Windows.Forms.Label()
        Me.panelLedgerCard = New System.Windows.Forms.Panel()
        Me.dgvSanctions = New System.Windows.Forms.DataGridView()
        Me.colSanctionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSanctionAssigned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProgressMetrics = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDeadline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatusBadge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLedgerTitle = New System.Windows.Forms.Label()
        Me.panelUpdateCard = New System.Windows.Forms.Panel()
        Me.btnApplyUpdate = New System.Windows.Forms.Button()
        Me.txtOfficerRemarks = New System.Windows.Forms.TextBox()
        Me.lblOfficerRemarks = New System.Windows.Forms.Label()
        Me.chkEscalatedBoard = New System.Windows.Forms.CheckBox()
        Me.chkCompletedClosed = New System.Windows.Forms.CheckBox()
        Me.chkInProgress = New System.Windows.Forms.CheckBox()
        Me.lblUpdateStatus = New System.Windows.Forms.Label()
        Me.numServiceHours = New System.Windows.Forms.NumericUpDown()
        Me.lblServiceHours = New System.Windows.Forms.Label()
        Me.txtSelectedStudentID = New System.Windows.Forms.TextBox()
        Me.lblSelectedStudentID = New System.Windows.Forms.Label()
        Me.lblUpdateTitle = New System.Windows.Forms.Label()
        Me.panelHeader.SuspendLayout()
        Me.panelCardInProgress.SuspendLayout()
        Me.panelCardEscalated.SuspendLayout()
        Me.panelCardCompleted.SuspendLayout()
        Me.panelCardOverdue.SuspendLayout()
        Me.panelLedgerCard.SuspendLayout()
        CType(Me.dgvSanctions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelUpdateCard.SuspendLayout()
        CType(Me.numServiceHours, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Size = New System.Drawing.Size(420, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Active Sanction Monitoring & Reconciliation"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 45)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(422, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Track active sanctions, update student progress, and manage reconciliation status."
        '
        'panelCardInProgress
        '
        Me.panelCardInProgress.BackColor = System.Drawing.Color.White
        Me.panelCardInProgress.Controls.Add(Me.lblCaptionInProgress)
        Me.panelCardInProgress.Controls.Add(Me.lblCountInProgress)
        Me.panelCardInProgress.Location = New System.Drawing.Point(24, 92)
        Me.panelCardInProgress.Name = "panelCardInProgress"
        Me.panelCardInProgress.Size = New System.Drawing.Size(250, 102)
        Me.panelCardInProgress.TabIndex = 1
        '
        'lblCountInProgress
        '
        Me.lblCountInProgress.AutoSize = True
        Me.lblCountInProgress.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountInProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.lblCountInProgress.Location = New System.Drawing.Point(104, 14)
        Me.lblCountInProgress.Name = "lblCountInProgress"
        Me.lblCountInProgress.Size = New System.Drawing.Size(44, 41)
        Me.lblCountInProgress.TabIndex = 0
        Me.lblCountInProgress.Text = "0"
        '
        'lblCaptionInProgress
        '
        Me.lblCaptionInProgress.AutoSize = True
        Me.lblCaptionInProgress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCaptionInProgress.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaptionInProgress.Location = New System.Drawing.Point(88, 66)
        Me.lblCaptionInProgress.Name = "lblCaptionInProgress"
        Me.lblCaptionInProgress.Size = New System.Drawing.Size(77, 19)
        Me.lblCaptionInProgress.TabIndex = 1
        Me.lblCaptionInProgress.Text = "In-progress"
        '
        'panelCardEscalated
        '
        Me.panelCardEscalated.BackColor = System.Drawing.Color.White
        Me.panelCardEscalated.Controls.Add(Me.lblCaptionEscalated)
        Me.panelCardEscalated.Controls.Add(Me.lblCountEscalated)
        Me.panelCardEscalated.Location = New System.Drawing.Point(291, 92)
        Me.panelCardEscalated.Name = "panelCardEscalated"
        Me.panelCardEscalated.Size = New System.Drawing.Size(250, 102)
        Me.panelCardEscalated.TabIndex = 2
        '
        'lblCountEscalated
        '
        Me.lblCountEscalated.AutoSize = True
        Me.lblCountEscalated.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountEscalated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblCountEscalated.Location = New System.Drawing.Point(112, 14)
        Me.lblCountEscalated.Name = "lblCountEscalated"
        Me.lblCountEscalated.Size = New System.Drawing.Size(44, 41)
        Me.lblCountEscalated.TabIndex = 0
        Me.lblCountEscalated.Text = "0"
        '
        'lblCaptionEscalated
        '
        Me.lblCaptionEscalated.AutoSize = True
        Me.lblCaptionEscalated.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCaptionEscalated.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaptionEscalated.Location = New System.Drawing.Point(82, 66)
        Me.lblCaptionEscalated.Name = "lblCaptionEscalated"
        Me.lblCaptionEscalated.Size = New System.Drawing.Size(102, 19)
        Me.lblCaptionEscalated.TabIndex = 1
        Me.lblCaptionEscalated.Text = "Escalated board"
        '
        'panelCardCompleted
        '
        Me.panelCardCompleted.BackColor = System.Drawing.Color.White
        Me.panelCardCompleted.Controls.Add(Me.lblCaptionCompleted)
        Me.panelCardCompleted.Controls.Add(Me.lblCountCompleted)
        Me.panelCardCompleted.Location = New System.Drawing.Point(558, 92)
        Me.panelCardCompleted.Name = "panelCardCompleted"
        Me.panelCardCompleted.Size = New System.Drawing.Size(250, 102)
        Me.panelCardCompleted.TabIndex = 3
        '
        'lblCountCompleted
        '
        Me.lblCountCompleted.AutoSize = True
        Me.lblCountCompleted.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountCompleted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblCountCompleted.Location = New System.Drawing.Point(96, 14)
        Me.lblCountCompleted.Name = "lblCountCompleted"
        Me.lblCountCompleted.Size = New System.Drawing.Size(62, 41)
        Me.lblCountCompleted.TabIndex = 0
        Me.lblCountCompleted.Text = "0"
        '
        'lblCaptionCompleted
        '
        Me.lblCaptionCompleted.AutoSize = True
        Me.lblCaptionCompleted.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCaptionCompleted.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaptionCompleted.Location = New System.Drawing.Point(68, 66)
        Me.lblCaptionCompleted.Name = "lblCaptionCompleted"
        Me.lblCaptionCompleted.Size = New System.Drawing.Size(119, 19)
        Me.lblCaptionCompleted.TabIndex = 1
        Me.lblCaptionCompleted.Text = "Completed / closed"
        '
        'panelCardOverdue
        '
        Me.panelCardOverdue.BackColor = System.Drawing.Color.White
        Me.panelCardOverdue.Controls.Add(Me.lblCaptionOverdue)
        Me.panelCardOverdue.Controls.Add(Me.lblCountOverdue)
        Me.panelCardOverdue.Location = New System.Drawing.Point(825, 92)
        Me.panelCardOverdue.Name = "panelCardOverdue"
        Me.panelCardOverdue.Size = New System.Drawing.Size(251, 102)
        Me.panelCardOverdue.TabIndex = 4
        '
        'lblCountOverdue
        '
        Me.lblCountOverdue.AutoSize = True
        Me.lblCountOverdue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountOverdue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblCountOverdue.Location = New System.Drawing.Point(112, 14)
        Me.lblCountOverdue.Name = "lblCountOverdue"
        Me.lblCountOverdue.Size = New System.Drawing.Size(44, 41)
        Me.lblCountOverdue.TabIndex = 0
        Me.lblCountOverdue.Text = "0"
        '
        'lblCaptionOverdue
        '
        Me.lblCaptionOverdue.AutoSize = True
        Me.lblCaptionOverdue.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCaptionOverdue.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaptionOverdue.Location = New System.Drawing.Point(80, 66)
        Me.lblCaptionOverdue.Name = "lblCaptionOverdue"
        Me.lblCaptionOverdue.Size = New System.Drawing.Size(107, 19)
        Me.lblCaptionOverdue.TabIndex = 1
        Me.lblCaptionOverdue.Text = "Overdue deadline"
        '
        'panelLedgerCard
        '
        Me.panelLedgerCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelLedgerCard.BackColor = System.Drawing.Color.White
        Me.panelLedgerCard.Controls.Add(Me.dgvSanctions)
        Me.panelLedgerCard.Controls.Add(Me.lblLedgerTitle)
        Me.panelLedgerCard.Location = New System.Drawing.Point(24, 212)
        Me.panelLedgerCard.Name = "panelLedgerCard"
        Me.panelLedgerCard.Size = New System.Drawing.Size(752, 532)
        Me.panelLedgerCard.TabIndex = 5
        '
        'lblLedgerTitle
        '
        Me.lblLedgerTitle.AutoSize = True
        Me.lblLedgerTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblLedgerTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblLedgerTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblLedgerTitle.Name = "lblLedgerTitle"
        Me.lblLedgerTitle.Size = New System.Drawing.Size(218, 19)
        Me.lblLedgerTitle.TabIndex = 0
        Me.lblLedgerTitle.Text = "Student Sanction Progress Ledger"
        '
        'dgvSanctions
        '
        Me.dgvSanctions.AllowUserToAddRows = False
        Me.dgvSanctions.AllowUserToDeleteRows = False
        Me.dgvSanctions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSanctions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSanctions.BackgroundColor = System.Drawing.Color.White
        Me.dgvSanctions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSanctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanctions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSanctionID, Me.colStudentID, Me.colStudentName, Me.colSanctionAssigned, Me.colProgressMetrics, Me.colDeadline, Me.colStatusBadge})
        Me.dgvSanctions.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgvSanctions.Location = New System.Drawing.Point(16, 42)
        Me.dgvSanctions.Name = "dgvSanctions"
        Me.dgvSanctions.ReadOnly = True
        Me.dgvSanctions.RowHeadersVisible = False
        Me.dgvSanctions.RowTemplate.Height = 32
        Me.dgvSanctions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSanctions.Size = New System.Drawing.Size(720, 474)
        Me.dgvSanctions.TabIndex = 1
        '
        'colSanctionID
        '
        Me.colSanctionID.HeaderText = "Sanction ID"
        Me.colSanctionID.Name = "colSanctionID"
        Me.colSanctionID.Visible = False
        '
        'colStudentID
        '
        Me.colStudentID.HeaderText = "Student ID"
        Me.colStudentID.Name = "colStudentID"
        Me.colStudentID.Visible = False
        '
        'colStudentName
        '
        Me.colStudentName.FillWeight = 135.0!
        Me.colStudentName.HeaderText = "Student Name"
        Me.colStudentName.Name = "colStudentName"
        '
        'colSanctionAssigned
        '
        Me.colSanctionAssigned.FillWeight = 130.0!
        Me.colSanctionAssigned.HeaderText = "Sanction Assigned"
        Me.colSanctionAssigned.Name = "colSanctionAssigned"
        '
        'colProgressMetrics
        '
        Me.colProgressMetrics.FillWeight = 110.0!
        Me.colProgressMetrics.HeaderText = "Progress Metrics"
        Me.colProgressMetrics.Name = "colProgressMetrics"
        '
        'colDeadline
        '
        Me.colDeadline.FillWeight = 95.0!
        Me.colDeadline.HeaderText = "Deadline"
        Me.colDeadline.Name = "colDeadline"
        '
        'colStatusBadge
        '
        Me.colStatusBadge.FillWeight = 90.0!
        Me.colStatusBadge.HeaderText = "Status Badge"
        Me.colStatusBadge.Name = "colStatusBadge"
        '
        'panelUpdateCard
        '
        Me.panelUpdateCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelUpdateCard.BackColor = System.Drawing.Color.White
        Me.panelUpdateCard.Controls.Add(Me.btnApplyUpdate)
        Me.panelUpdateCard.Controls.Add(Me.txtOfficerRemarks)
        Me.panelUpdateCard.Controls.Add(Me.lblOfficerRemarks)
        Me.panelUpdateCard.Controls.Add(Me.chkEscalatedBoard)
        Me.panelUpdateCard.Controls.Add(Me.chkCompletedClosed)
        Me.panelUpdateCard.Controls.Add(Me.chkInProgress)
        Me.panelUpdateCard.Controls.Add(Me.lblUpdateStatus)
        Me.panelUpdateCard.Controls.Add(Me.numServiceHours)
        Me.panelUpdateCard.Controls.Add(Me.lblServiceHours)
        Me.panelUpdateCard.Controls.Add(Me.txtSelectedStudentID)
        Me.panelUpdateCard.Controls.Add(Me.lblSelectedStudentID)
        Me.panelUpdateCard.Controls.Add(Me.lblUpdateTitle)
        Me.panelUpdateCard.Location = New System.Drawing.Point(792, 212)
        Me.panelUpdateCard.Name = "panelUpdateCard"
        Me.panelUpdateCard.Size = New System.Drawing.Size(284, 532)
        Me.panelUpdateCard.TabIndex = 6
        '
        'lblUpdateTitle
        '
        Me.lblUpdateTitle.AutoSize = True
        Me.lblUpdateTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblUpdateTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblUpdateTitle.Name = "lblUpdateTitle"
        Me.lblUpdateTitle.Size = New System.Drawing.Size(226, 19)
        Me.lblUpdateTitle.TabIndex = 0
        Me.lblUpdateTitle.Text = "Update Selected Student Progress"
        '
        'lblSelectedStudentID
        '
        Me.lblSelectedStudentID.AutoSize = True
        Me.lblSelectedStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSelectedStudentID.ForeColor = System.Drawing.Color.DimGray
        Me.lblSelectedStudentID.Location = New System.Drawing.Point(16, 44)
        Me.lblSelectedStudentID.Name = "lblSelectedStudentID"
        Me.lblSelectedStudentID.Size = New System.Drawing.Size(69, 15)
        Me.lblSelectedStudentID.TabIndex = 1
        Me.lblSelectedStudentID.Text = "Student ID"
        '
        'txtSelectedStudentID
        '
        Me.txtSelectedStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSelectedStudentID.Location = New System.Drawing.Point(16, 64)
        Me.txtSelectedStudentID.Name = "txtSelectedStudentID"
        Me.txtSelectedStudentID.ReadOnly = True
        Me.txtSelectedStudentID.Size = New System.Drawing.Size(250, 25)
        Me.txtSelectedStudentID.TabIndex = 2
        '
        'lblServiceHours
        '
        Me.lblServiceHours.AutoSize = True
        Me.lblServiceHours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblServiceHours.ForeColor = System.Drawing.Color.DimGray
        Me.lblServiceHours.Location = New System.Drawing.Point(16, 100)
        Me.lblServiceHours.Name = "lblServiceHours"
        Me.lblServiceHours.Size = New System.Drawing.Size(173, 15)
        Me.lblServiceHours.TabIndex = 3
        Me.lblServiceHours.Text = "Add Completed Service Hours"
        '
        'numServiceHours
        '
        Me.numServiceHours.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.numServiceHours.Location = New System.Drawing.Point(16, 120)
        Me.numServiceHours.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numServiceHours.Name = "numServiceHours"
        Me.numServiceHours.Size = New System.Drawing.Size(250, 25)
        Me.numServiceHours.TabIndex = 4
        '
        'lblUpdateStatus
        '
        Me.lblUpdateStatus.AutoSize = True
        Me.lblUpdateStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUpdateStatus.ForeColor = System.Drawing.Color.DimGray
        Me.lblUpdateStatus.Location = New System.Drawing.Point(16, 158)
        Me.lblUpdateStatus.Name = "lblUpdateStatus"
        Me.lblUpdateStatus.Size = New System.Drawing.Size(134, 15)
        Me.lblUpdateStatus.TabIndex = 5
        Me.lblUpdateStatus.Text = "Update Sanction Status"
        '
        'chkInProgress
        '
        Me.chkInProgress.AutoSize = True
        Me.chkInProgress.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.chkInProgress.Location = New System.Drawing.Point(18, 180)
        Me.chkInProgress.Name = "chkInProgress"
        Me.chkInProgress.Size = New System.Drawing.Size(141, 21)
        Me.chkInProgress.TabIndex = 6
        Me.chkInProgress.Text = "In-progress monitor"
        Me.chkInProgress.UseVisualStyleBackColor = True
        '
        'chkCompletedClosed
        '
        Me.chkCompletedClosed.AutoSize = True
        Me.chkCompletedClosed.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.chkCompletedClosed.Location = New System.Drawing.Point(18, 205)
        Me.chkCompletedClosed.Name = "chkCompletedClosed"
        Me.chkCompletedClosed.Size = New System.Drawing.Size(143, 21)
        Me.chkCompletedClosed.TabIndex = 7
        Me.chkCompletedClosed.Text = "Completed / cleared"
        Me.chkCompletedClosed.UseVisualStyleBackColor = True
        '
        'chkEscalatedBoard
        '
        Me.chkEscalatedBoard.AutoSize = True
        Me.chkEscalatedBoard.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.chkEscalatedBoard.Location = New System.Drawing.Point(18, 230)
        Me.chkEscalatedBoard.Name = "chkEscalatedBoard"
        Me.chkEscalatedBoard.Size = New System.Drawing.Size(131, 21)
        Me.chkEscalatedBoard.TabIndex = 8
        Me.chkEscalatedBoard.Text = "Escalated to board"
        Me.chkEscalatedBoard.UseVisualStyleBackColor = True
        '
        'lblOfficerRemarks
        '
        Me.lblOfficerRemarks.AutoSize = True
        Me.lblOfficerRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOfficerRemarks.ForeColor = System.Drawing.Color.DimGray
        Me.lblOfficerRemarks.Location = New System.Drawing.Point(16, 264)
        Me.lblOfficerRemarks.Name = "lblOfficerRemarks"
        Me.lblOfficerRemarks.Size = New System.Drawing.Size(138, 15)
        Me.lblOfficerRemarks.TabIndex = 9
        Me.lblOfficerRemarks.Text = "Officer Remarks / Log"
        '
        'txtOfficerRemarks
        '
        Me.txtOfficerRemarks.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOfficerRemarks.Location = New System.Drawing.Point(16, 284)
        Me.txtOfficerRemarks.Multiline = True
        Me.txtOfficerRemarks.Name = "txtOfficerRemarks"
        Me.txtOfficerRemarks.Size = New System.Drawing.Size(250, 165)
        Me.txtOfficerRemarks.TabIndex = 10
        '
        'btnApplyUpdate
        '
        Me.btnApplyUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnApplyUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnApplyUpdate.FlatAppearance.BorderSize = 0
        Me.btnApplyUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnApplyUpdate.ForeColor = System.Drawing.Color.White
        Me.btnApplyUpdate.Location = New System.Drawing.Point(16, 472)
        Me.btnApplyUpdate.Name = "btnApplyUpdate"
        Me.btnApplyUpdate.Size = New System.Drawing.Size(250, 38)
        Me.btnApplyUpdate.TabIndex = 11
        Me.btnApplyUpdate.Text = "Apply & Update Record"
        Me.btnApplyUpdate.UseVisualStyleBackColor = False
        '
        'UcSanctionTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.panelUpdateCard)
        Me.Controls.Add(Me.panelLedgerCard)
        Me.Controls.Add(Me.panelCardOverdue)
        Me.Controls.Add(Me.panelCardCompleted)
        Me.Controls.Add(Me.panelCardEscalated)
        Me.Controls.Add(Me.panelCardInProgress)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "UcSanctionTracker"
        Me.Size = New System.Drawing.Size(1100, 768)
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.panelCardInProgress.ResumeLayout(False)
        Me.panelCardInProgress.PerformLayout()
        Me.panelCardEscalated.ResumeLayout(False)
        Me.panelCardEscalated.PerformLayout()
        Me.panelCardCompleted.ResumeLayout(False)
        Me.panelCardCompleted.PerformLayout()
        Me.panelCardOverdue.ResumeLayout(False)
        Me.panelCardOverdue.PerformLayout()
        Me.panelLedgerCard.ResumeLayout(False)
        Me.panelLedgerCard.PerformLayout()
        CType(Me.dgvSanctions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelUpdateCard.ResumeLayout(False)
        Me.panelUpdateCard.PerformLayout()
        CType(Me.numServiceHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelCardInProgress As Panel
    Friend WithEvents lblCaptionInProgress As Label
    Friend WithEvents lblCountInProgress As Label
    Friend WithEvents panelCardEscalated As Panel
    Friend WithEvents lblCaptionEscalated As Label
    Friend WithEvents lblCountEscalated As Label
    Friend WithEvents panelCardCompleted As Panel
    Friend WithEvents lblCaptionCompleted As Label
    Friend WithEvents lblCountCompleted As Label
    Friend WithEvents panelCardOverdue As Panel
    Friend WithEvents lblCaptionOverdue As Label
    Friend WithEvents lblCountOverdue As Label
    Friend WithEvents panelLedgerCard As Panel
    Friend WithEvents dgvSanctions As DataGridView
    Friend WithEvents colSanctionID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colSanctionAssigned As DataGridViewTextBoxColumn
    Friend WithEvents colProgressMetrics As DataGridViewTextBoxColumn
    Friend WithEvents colDeadline As DataGridViewTextBoxColumn
    Friend WithEvents colStatusBadge As DataGridViewTextBoxColumn
    Friend WithEvents lblLedgerTitle As Label
    Friend WithEvents panelUpdateCard As Panel
    Friend WithEvents btnApplyUpdate As Button
    Friend WithEvents txtOfficerRemarks As TextBox
    Friend WithEvents lblOfficerRemarks As Label
    Friend WithEvents chkEscalatedBoard As CheckBox
    Friend WithEvents chkCompletedClosed As CheckBox
    Friend WithEvents chkInProgress As CheckBox
    Friend WithEvents lblUpdateStatus As Label
    Friend WithEvents numServiceHours As NumericUpDown
    Friend WithEvents lblServiceHours As Label
    Friend WithEvents txtSelectedStudentID As TextBox
    Friend WithEvents lblSelectedStudentID As Label
    Friend WithEvents lblUpdateTitle As Label
End Class