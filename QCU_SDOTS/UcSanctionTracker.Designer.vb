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
        Me.tlpSummaryCards = New System.Windows.Forms.TableLayoutPanel()
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
        Me.tlpSummaryCards.SuspendLayout()
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
        Me.lblTitle.Size = New System.Drawing.Size(442, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Active Sanction Monitoring & Reconciliation"
        Me.lblTitle.UseMnemonic = False
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 44)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(486, 17)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Track active sanctions, update student progress, and manage reconciliation status."
        '
        'tlpSummaryCards
        '
        Me.tlpSummaryCards.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpSummaryCards.BackColor = System.Drawing.Color.Transparent
        Me.tlpSummaryCards.ColumnCount = 4
        Me.tlpSummaryCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSummaryCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSummaryCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSummaryCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSummaryCards.Controls.Add(Me.panelCardInProgress, 0, 0)
        Me.tlpSummaryCards.Controls.Add(Me.panelCardEscalated, 1, 0)
        Me.tlpSummaryCards.Controls.Add(Me.panelCardCompleted, 2, 0)
        Me.tlpSummaryCards.Controls.Add(Me.panelCardOverdue, 3, 0)
        Me.tlpSummaryCards.Location = New System.Drawing.Point(18, 86)
        Me.tlpSummaryCards.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSummaryCards.Name = "tlpSummaryCards"
        Me.tlpSummaryCards.RowCount = 1
        Me.tlpSummaryCards.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSummaryCards.Size = New System.Drawing.Size(1144, 106)
        Me.tlpSummaryCards.TabIndex = 1
        '
        'panelCardInProgress
        '
        Me.panelCardInProgress.BackColor = System.Drawing.Color.White
        Me.panelCardInProgress.Controls.Add(Me.lblCaptionInProgress)
        Me.panelCardInProgress.Controls.Add(Me.lblCountInProgress)
        Me.panelCardInProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCardInProgress.Location = New System.Drawing.Point(6, 2)
        Me.panelCardInProgress.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.panelCardInProgress.Name = "panelCardInProgress"
        Me.panelCardInProgress.Size = New System.Drawing.Size(274, 102)
        Me.panelCardInProgress.TabIndex = 0
        '
        'lblCountInProgress
        '
        Me.lblCountInProgress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountInProgress.AutoSize = True
        Me.lblCountInProgress.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountInProgress.ForeColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.lblCountInProgress.Location = New System.Drawing.Point(118, 14)
        Me.lblCountInProgress.Name = "lblCountInProgress"
        Me.lblCountInProgress.Size = New System.Drawing.Size(37, 41)
        Me.lblCountInProgress.TabIndex = 0
        Me.lblCountInProgress.Text = "0"
        '
        'lblCaptionInProgress
        '
        Me.lblCaptionInProgress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptionInProgress.AutoSize = True
        Me.lblCaptionInProgress.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCaptionInProgress.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblCaptionInProgress.Location = New System.Drawing.Point(97, 66)
        Me.lblCaptionInProgress.Name = "lblCaptionInProgress"
        Me.lblCaptionInProgress.Size = New System.Drawing.Size(80, 17)
        Me.lblCaptionInProgress.TabIndex = 1
        Me.lblCaptionInProgress.Text = "In-progress"
        '
        'panelCardEscalated
        '
        Me.panelCardEscalated.BackColor = System.Drawing.Color.White
        Me.panelCardEscalated.Controls.Add(Me.lblCaptionEscalated)
        Me.panelCardEscalated.Controls.Add(Me.lblCountEscalated)
        Me.panelCardEscalated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCardEscalated.Location = New System.Drawing.Point(292, 2)
        Me.panelCardEscalated.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.panelCardEscalated.Name = "panelCardEscalated"
        Me.panelCardEscalated.Size = New System.Drawing.Size(274, 102)
        Me.panelCardEscalated.TabIndex = 1
        '
        'lblCountEscalated
        '
        Me.lblCountEscalated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountEscalated.AutoSize = True
        Me.lblCountEscalated.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountEscalated.ForeColor = System.Drawing.Color.FromArgb(180, 83, 9)
        Me.lblCountEscalated.Location = New System.Drawing.Point(118, 14)
        Me.lblCountEscalated.Name = "lblCountEscalated"
        Me.lblCountEscalated.Size = New System.Drawing.Size(37, 41)
        Me.lblCountEscalated.TabIndex = 0
        Me.lblCountEscalated.Text = "0"
        '
        'lblCaptionEscalated
        '
        Me.lblCaptionEscalated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptionEscalated.AutoSize = True
        Me.lblCaptionEscalated.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCaptionEscalated.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblCaptionEscalated.Location = New System.Drawing.Point(85, 66)
        Me.lblCaptionEscalated.Name = "lblCaptionEscalated"
        Me.lblCaptionEscalated.Size = New System.Drawing.Size(104, 17)
        Me.lblCaptionEscalated.TabIndex = 1
        Me.lblCaptionEscalated.Text = "Escalated board"
        '
        'panelCardCompleted
        '
        Me.panelCardCompleted.BackColor = System.Drawing.Color.White
        Me.panelCardCompleted.Controls.Add(Me.lblCaptionCompleted)
        Me.panelCardCompleted.Controls.Add(Me.lblCountCompleted)
        Me.panelCardCompleted.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCardCompleted.Location = New System.Drawing.Point(578, 2)
        Me.panelCardCompleted.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.panelCardCompleted.Name = "panelCardCompleted"
        Me.panelCardCompleted.Size = New System.Drawing.Size(274, 102)
        Me.panelCardCompleted.TabIndex = 2
        '
        'lblCountCompleted
        '
        Me.lblCountCompleted.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountCompleted.AutoSize = True
        Me.lblCountCompleted.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountCompleted.ForeColor = System.Drawing.Color.FromArgb(21, 128, 61)
        Me.lblCountCompleted.Location = New System.Drawing.Point(118, 14)
        Me.lblCountCompleted.Name = "lblCountCompleted"
        Me.lblCountCompleted.Size = New System.Drawing.Size(37, 41)
        Me.lblCountCompleted.TabIndex = 0
        Me.lblCountCompleted.Text = "0"
        '
        'lblCaptionCompleted
        '
        Me.lblCaptionCompleted.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptionCompleted.AutoSize = True
        Me.lblCaptionCompleted.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCaptionCompleted.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblCaptionCompleted.Location = New System.Drawing.Point(75, 66)
        Me.lblCaptionCompleted.Name = "lblCaptionCompleted"
        Me.lblCaptionCompleted.Size = New System.Drawing.Size(124, 17)
        Me.lblCaptionCompleted.TabIndex = 1
        Me.lblCaptionCompleted.Text = "Completed / closed"
        '
        'panelCardOverdue
        '
        Me.panelCardOverdue.BackColor = System.Drawing.Color.White
        Me.panelCardOverdue.Controls.Add(Me.lblCaptionOverdue)
        Me.panelCardOverdue.Controls.Add(Me.lblCountOverdue)
        Me.panelCardOverdue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCardOverdue.Location = New System.Drawing.Point(864, 2)
        Me.panelCardOverdue.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.panelCardOverdue.Name = "panelCardOverdue"
        Me.panelCardOverdue.Size = New System.Drawing.Size(274, 102)
        Me.panelCardOverdue.TabIndex = 3
        '
        'lblCountOverdue
        '
        Me.lblCountOverdue.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountOverdue.AutoSize = True
        Me.lblCountOverdue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountOverdue.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28)
        Me.lblCountOverdue.Location = New System.Drawing.Point(118, 14)
        Me.lblCountOverdue.Name = "lblCountOverdue"
        Me.lblCountOverdue.Size = New System.Drawing.Size(37, 41)
        Me.lblCountOverdue.TabIndex = 0
        Me.lblCountOverdue.Text = "0"
        '
        'lblCaptionOverdue
        '
        Me.lblCaptionOverdue.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptionOverdue.AutoSize = True
        Me.lblCaptionOverdue.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCaptionOverdue.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblCaptionOverdue.Location = New System.Drawing.Point(81, 66)
        Me.lblCaptionOverdue.Name = "lblCaptionOverdue"
        Me.lblCaptionOverdue.Size = New System.Drawing.Size(111, 17)
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
        Me.panelLedgerCard.Location = New System.Drawing.Point(24, 204)
        Me.panelLedgerCard.Name = "panelLedgerCard"
        Me.panelLedgerCard.Size = New System.Drawing.Size(816, 540)
        Me.panelLedgerCard.TabIndex = 5
        '
        'lblLedgerTitle
        '
        Me.lblLedgerTitle.AutoSize = True
        Me.lblLedgerTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblLedgerTitle.ForeColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.lblLedgerTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblLedgerTitle.Name = "lblLedgerTitle"
        Me.lblLedgerTitle.Size = New System.Drawing.Size(229, 19)
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
        Me.dgvSanctions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSanctions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSanctions.ColumnHeadersHeight = 36
        Me.dgvSanctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSanctions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSanctionID, Me.colStudentID, Me.colStudentName, Me.colSanctionAssigned, Me.colProgressMetrics, Me.colDeadline, Me.colStatusBadge})
        Me.dgvSanctions.EnableHeadersVisualStyles = False
        Me.dgvSanctions.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.dgvSanctions.GridColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.dgvSanctions.Location = New System.Drawing.Point(18, 42)
        Me.dgvSanctions.Name = "dgvSanctions"
        Me.dgvSanctions.ReadOnly = True
        Me.dgvSanctions.RowHeadersVisible = False
        Me.dgvSanctions.RowTemplate.Height = 34
        Me.dgvSanctions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSanctions.Size = New System.Drawing.Size(780, 480)
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
        Me.panelUpdateCard.Location = New System.Drawing.Point(852, 204)
        Me.panelUpdateCard.Name = "panelUpdateCard"
        Me.panelUpdateCard.Size = New System.Drawing.Size(304, 540)
        Me.panelUpdateCard.TabIndex = 6
        '
        'lblUpdateTitle
        '
        Me.lblUpdateTitle.AutoSize = True
        Me.lblUpdateTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.lblUpdateTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblUpdateTitle.Name = "lblUpdateTitle"
        Me.lblUpdateTitle.Size = New System.Drawing.Size(238, 19)
        Me.lblUpdateTitle.TabIndex = 0
        Me.lblUpdateTitle.Text = "Update Selected Student Progress"
        '
        'lblSelectedStudentID
        '
        Me.lblSelectedStudentID.AutoSize = True
        Me.lblSelectedStudentID.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSelectedStudentID.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblSelectedStudentID.Location = New System.Drawing.Point(18, 42)
        Me.lblSelectedStudentID.Name = "lblSelectedStudentID"
        Me.lblSelectedStudentID.Size = New System.Drawing.Size(74, 17)
        Me.lblSelectedStudentID.TabIndex = 1
        Me.lblSelectedStudentID.Text = "Student ID"
        '
        'txtSelectedStudentID
        '
        Me.txtSelectedStudentID.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.txtSelectedStudentID.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtSelectedStudentID.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.txtSelectedStudentID.Location = New System.Drawing.Point(18, 63)
        Me.txtSelectedStudentID.Name = "txtSelectedStudentID"
        Me.txtSelectedStudentID.ReadOnly = True
        Me.txtSelectedStudentID.Size = New System.Drawing.Size(268, 25)
        Me.txtSelectedStudentID.TabIndex = 2
        '
        'lblServiceHours
        '
        Me.lblServiceHours.AutoSize = True
        Me.lblServiceHours.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblServiceHours.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblServiceHours.Location = New System.Drawing.Point(18, 98)
        Me.lblServiceHours.Name = "lblServiceHours"
        Me.lblServiceHours.Size = New System.Drawing.Size(188, 17)
        Me.lblServiceHours.TabIndex = 3
        Me.lblServiceHours.Text = "Add Completed Service Hours"
        '
        'numServiceHours
        '
        Me.numServiceHours.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.numServiceHours.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.numServiceHours.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.numServiceHours.Location = New System.Drawing.Point(18, 119)
        Me.numServiceHours.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numServiceHours.Name = "numServiceHours"
        Me.numServiceHours.Size = New System.Drawing.Size(268, 25)
        Me.numServiceHours.TabIndex = 4
        '
        'lblUpdateStatus
        '
        Me.lblUpdateStatus.AutoSize = True
        Me.lblUpdateStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblUpdateStatus.Location = New System.Drawing.Point(18, 156)
        Me.lblUpdateStatus.Name = "lblUpdateStatus"
        Me.lblUpdateStatus.Size = New System.Drawing.Size(145, 17)
        Me.lblUpdateStatus.TabIndex = 5
        Me.lblUpdateStatus.Text = "Update Sanction Status"
        '
        'chkInProgress
        '
        Me.chkInProgress.AutoSize = True
        Me.chkInProgress.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.chkInProgress.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.chkInProgress.Location = New System.Drawing.Point(18, 179)
        Me.chkInProgress.Name = "chkInProgress"
        Me.chkInProgress.Size = New System.Drawing.Size(134, 21)
        Me.chkInProgress.TabIndex = 6
        Me.chkInProgress.Text = "In-progress monitor"
        Me.chkInProgress.UseVisualStyleBackColor = True
        '
        'chkCompletedClosed
        '
        Me.chkCompletedClosed.AutoSize = True
        Me.chkCompletedClosed.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.chkCompletedClosed.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.chkCompletedClosed.Location = New System.Drawing.Point(18, 204)
        Me.chkCompletedClosed.Name = "chkCompletedClosed"
        Me.chkCompletedClosed.Size = New System.Drawing.Size(136, 21)
        Me.chkCompletedClosed.TabIndex = 7
        Me.chkCompletedClosed.Text = "Completed / cleared"
        Me.chkCompletedClosed.UseVisualStyleBackColor = True
        '
        'chkEscalatedBoard
        '
        Me.chkEscalatedBoard.AutoSize = True
        Me.chkEscalatedBoard.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.chkEscalatedBoard.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.chkEscalatedBoard.Location = New System.Drawing.Point(18, 229)
        Me.chkEscalatedBoard.Name = "chkEscalatedBoard"
        Me.chkEscalatedBoard.Size = New System.Drawing.Size(124, 21)
        Me.chkEscalatedBoard.TabIndex = 8
        Me.chkEscalatedBoard.Text = "Escalated to board"
        Me.chkEscalatedBoard.UseVisualStyleBackColor = True
        '
        'lblOfficerRemarks
        '
        Me.lblOfficerRemarks.AutoSize = True
        Me.lblOfficerRemarks.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblOfficerRemarks.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblOfficerRemarks.Location = New System.Drawing.Point(18, 262)
        Me.lblOfficerRemarks.Name = "lblOfficerRemarks"
        Me.lblOfficerRemarks.Size = New System.Drawing.Size(148, 17)
        Me.lblOfficerRemarks.TabIndex = 9
        Me.lblOfficerRemarks.Text = "Officer Remarks / Log"
        '
        'txtOfficerRemarks
        '
        Me.txtOfficerRemarks.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtOfficerRemarks.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtOfficerRemarks.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.txtOfficerRemarks.Location = New System.Drawing.Point(18, 283)
        Me.txtOfficerRemarks.Multiline = True
        Me.txtOfficerRemarks.Name = "txtOfficerRemarks"
        Me.txtOfficerRemarks.Size = New System.Drawing.Size(268, 192)
        Me.txtOfficerRemarks.TabIndex = 10
        '
        'btnApplyUpdate
        '
        Me.btnApplyUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnApplyUpdate.BackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.btnApplyUpdate.FlatAppearance.BorderSize = 0
        Me.btnApplyUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyUpdate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnApplyUpdate.ForeColor = System.Drawing.Color.White
        Me.btnApplyUpdate.Location = New System.Drawing.Point(18, 488)
        Me.btnApplyUpdate.Name = "btnApplyUpdate"
        Me.btnApplyUpdate.Size = New System.Drawing.Size(268, 36)
        Me.btnApplyUpdate.TabIndex = 11
        Me.btnApplyUpdate.Text = "Apply & Update Record"
        Me.btnApplyUpdate.UseVisualStyleBackColor = False
        '
        'UcSanctionTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.Controls.Add(Me.panelUpdateCard)
        Me.Controls.Add(Me.panelLedgerCard)
        Me.Controls.Add(Me.tlpSummaryCards)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "UcSanctionTracker"
        Me.Size = New System.Drawing.Size(1180, 768)
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.tlpSummaryCards.ResumeLayout(False)
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
    Friend WithEvents tlpSummaryCards As TableLayoutPanel
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