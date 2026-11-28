<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboardForm
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
        Me.panelSidebar = New System.Windows.Forms.Panel()
        Me.lblBrandSub = New System.Windows.Forms.Label()
        Me.lblBrandTitle = New System.Windows.Forms.Label()
        Me.btnNavDashboard = New System.Windows.Forms.Button()
        Me.btnNavLogOffense = New System.Windows.Forms.Button()
        Me.btnNavSanctions = New System.Windows.Forms.Button()
        Me.btnNavSearch = New System.Windows.Forms.Button()
        Me.btnNavClearance = New System.Windows.Forms.Button()
        Me.btnExportCsv = New System.Windows.Forms.Button()
        Me.panelTopBar = New System.Windows.Forms.Panel()
        Me.lblLoggedUser = New System.Windows.Forms.Label()
        Me.lblFormSubtitle = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.panelContentHost = New System.Windows.Forms.Panel()
        Me.panelDashboardOverview = New System.Windows.Forms.Panel()
        Me.tlpOverviewCards = New System.Windows.Forms.TableLayoutPanel()
        Me.panelCardTotalLogs = New System.Windows.Forms.Panel()
        Me.lblCaptionTotalLogs = New System.Windows.Forms.Label()
        Me.lblCountTotalLogs = New System.Windows.Forms.Label()
        Me.panelCardPendingSanctions = New System.Windows.Forms.Panel()
        Me.lblCaptionPendingSanctions = New System.Windows.Forms.Label()
        Me.lblCountPendingSanctions = New System.Windows.Forms.Label()
        Me.panelCardCleared = New System.Windows.Forms.Panel()
        Me.lblCaptionCleared = New System.Windows.Forms.Label()
        Me.lblCountCleared = New System.Windows.Forms.Label()
        Me.panelCardOverdueCases = New System.Windows.Forms.Panel()
        Me.lblCaptionOverdueCases = New System.Windows.Forms.Label()
        Me.lblCountOverdueCases = New System.Windows.Forms.Label()
        Me.panelRecentCard = New System.Windows.Forms.Panel()
        Me.lblRecentTitle = New System.Windows.Forms.Label()
        Me.dgvRecentLogs = New System.Windows.Forms.DataGridView()
        Me.colRecentLogID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecentStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecentStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecentSection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecentOffense = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRecentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelSidebar.SuspendLayout()
        Me.panelTopBar.SuspendLayout()
        Me.panelContentHost.SuspendLayout()
        Me.panelDashboardOverview.SuspendLayout()
        Me.tlpOverviewCards.SuspendLayout()
        Me.panelCardTotalLogs.SuspendLayout()
        Me.panelCardPendingSanctions.SuspendLayout()
        Me.panelCardCleared.SuspendLayout()
        Me.panelCardOverdueCases.SuspendLayout()
        Me.panelRecentCard.SuspendLayout()
        CType(Me.dgvRecentLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSidebar
        '
        Me.panelSidebar.BackColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.panelSidebar.Controls.Add(Me.btnExportCsv)
        Me.panelSidebar.Controls.Add(Me.btnNavClearance)
        Me.panelSidebar.Controls.Add(Me.btnNavSearch)
        Me.panelSidebar.Controls.Add(Me.btnNavSanctions)
        Me.panelSidebar.Controls.Add(Me.btnNavLogOffense)
        Me.panelSidebar.Controls.Add(Me.btnNavDashboard)
        Me.panelSidebar.Controls.Add(Me.lblBrandSub)
        Me.panelSidebar.Controls.Add(Me.lblBrandTitle)
        Me.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.panelSidebar.Name = "panelSidebar"
        Me.panelSidebar.Size = New System.Drawing.Size(240, 820)
        Me.panelSidebar.TabIndex = 0
        '
        'lblBrandTitle
        '
        Me.lblBrandTitle.AutoSize = True
        Me.lblBrandTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrandTitle.ForeColor = System.Drawing.Color.White
        Me.lblBrandTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblBrandTitle.Name = "lblBrandTitle"
        Me.lblBrandTitle.Size = New System.Drawing.Size(119, 25)
        Me.lblBrandTitle.TabIndex = 0
        Me.lblBrandTitle.Text = "QCU SDOTS"
        '
        'lblBrandSub
        '
        Me.lblBrandSub.AutoSize = True
        Me.lblBrandSub.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225)
        Me.lblBrandSub.Location = New System.Drawing.Point(20, 45)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Size = New System.Drawing.Size(184, 15)
        Me.lblBrandSub.TabIndex = 1
        Me.lblBrandSub.Text = "Student Offense & Sanction System"
        '
        'btnNavDashboard
        '
        Me.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.btnNavDashboard.FlatAppearance.BorderSize = 0
        Me.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNavDashboard.ForeColor = System.Drawing.Color.White
        Me.btnNavDashboard.Location = New System.Drawing.Point(14, 84)
        Me.btnNavDashboard.Name = "btnNavDashboard"
        Me.btnNavDashboard.Size = New System.Drawing.Size(212, 38)
        Me.btnNavDashboard.TabIndex = 2
        Me.btnNavDashboard.Text = "Dashboard Overview"
        Me.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavDashboard.UseVisualStyleBackColor = False
        '
        'btnNavLogOffense
        '
        Me.btnNavLogOffense.BackColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.btnNavLogOffense.FlatAppearance.BorderSize = 0
        Me.btnNavLogOffense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavLogOffense.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNavLogOffense.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.btnNavLogOffense.Location = New System.Drawing.Point(14, 130)
        Me.btnNavLogOffense.Name = "btnNavLogOffense"
        Me.btnNavLogOffense.Size = New System.Drawing.Size(212, 38)
        Me.btnNavLogOffense.TabIndex = 3
        Me.btnNavLogOffense.Text = "Log Offense"
        Me.btnNavLogOffense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavLogOffense.UseVisualStyleBackColor = False
        '
        'btnNavSanctions
        '
        Me.btnNavSanctions.BackColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.btnNavSanctions.FlatAppearance.BorderSize = 0
        Me.btnNavSanctions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavSanctions.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNavSanctions.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.btnNavSanctions.Location = New System.Drawing.Point(14, 176)
        Me.btnNavSanctions.Name = "btnNavSanctions"
        Me.btnNavSanctions.Size = New System.Drawing.Size(212, 38)
        Me.btnNavSanctions.TabIndex = 4
        Me.btnNavSanctions.Text = "Sanction Tracker"
        Me.btnNavSanctions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavSanctions.UseVisualStyleBackColor = False
        '
        'btnNavSearch
        '
        Me.btnNavSearch.BackColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.btnNavSearch.FlatAppearance.BorderSize = 0
        Me.btnNavSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNavSearch.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.btnNavSearch.Location = New System.Drawing.Point(14, 222)
        Me.btnNavSearch.Name = "btnNavSearch"
        Me.btnNavSearch.Size = New System.Drawing.Size(212, 38)
        Me.btnNavSearch.TabIndex = 5
        Me.btnNavSearch.Text = "Search Records"
        Me.btnNavSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavSearch.UseVisualStyleBackColor = False
        '
        'btnNavClearance
        '
        Me.btnNavClearance.BackColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.btnNavClearance.FlatAppearance.BorderSize = 0
        Me.btnNavClearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavClearance.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNavClearance.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.btnNavClearance.Location = New System.Drawing.Point(14, 268)
        Me.btnNavClearance.Name = "btnNavClearance"
        Me.btnNavClearance.Size = New System.Drawing.Size(212, 38)
        Me.btnNavClearance.TabIndex = 6
        Me.btnNavClearance.Text = "Clearance Generator"
        Me.btnNavClearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavClearance.UseVisualStyleBackColor = False
        '
        'btnExportCsv
        '
        Me.btnExportCsv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.btnExportCsv.FlatAppearance.BorderSize = 0
        Me.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportCsv.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnExportCsv.ForeColor = System.Drawing.Color.White
        Me.btnExportCsv.Location = New System.Drawing.Point(14, 762)
        Me.btnExportCsv.Name = "btnExportCsv"
        Me.btnExportCsv.Size = New System.Drawing.Size(212, 38)
        Me.btnExportCsv.TabIndex = 7
        Me.btnExportCsv.Text = "Export Records (CSV)"
        Me.btnExportCsv.UseVisualStyleBackColor = False
        '
        'panelTopBar
        '
        Me.panelTopBar.BackColor = System.Drawing.Color.White
        Me.panelTopBar.Controls.Add(Me.lblLoggedUser)
        Me.panelTopBar.Controls.Add(Me.lblFormSubtitle)
        Me.panelTopBar.Controls.Add(Me.lblFormTitle)
        Me.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTopBar.Location = New System.Drawing.Point(240, 0)
        Me.panelTopBar.Name = "panelTopBar"
        Me.panelTopBar.Size = New System.Drawing.Size(1180, 74)
        Me.panelTopBar.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.lblFormTitle.Location = New System.Drawing.Point(24, 10)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(242, 30)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Disciplinary Dashboard"
        Me.lblFormTitle.UseMnemonic = False
        '
        'lblFormSubtitle
        '
        Me.lblFormSubtitle.AutoSize = True
        Me.lblFormSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblFormSubtitle.Location = New System.Drawing.Point(24, 44)
        Me.lblFormSubtitle.Name = "lblFormSubtitle"
        Me.lblFormSubtitle.Size = New System.Drawing.Size(446, 17)
        Me.lblFormSubtitle.TabIndex = 1
        Me.lblFormSubtitle.Text = "Monitor active student offenses, sanction progress, and clearance readiness."
        '
        'lblLoggedUser
        '
        Me.lblLoggedUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoggedUser.AutoSize = True
        Me.lblLoggedUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoggedUser.ForeColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.lblLoggedUser.Location = New System.Drawing.Point(940, 14)
        Me.lblLoggedUser.Name = "lblLoggedUser"
        Me.lblLoggedUser.Size = New System.Drawing.Size(216, 15)
        Me.lblLoggedUser.TabIndex = 2
        Me.lblLoggedUser.Text = "Logged in: Admin"
        '
        'panelContentHost
        '
        Me.panelContentHost.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.panelContentHost.Controls.Add(Me.panelDashboardOverview)
        Me.panelContentHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContentHost.Location = New System.Drawing.Point(240, 74)
        Me.panelContentHost.Name = "panelContentHost"
        Me.panelContentHost.Size = New System.Drawing.Size(1180, 746)
        Me.panelContentHost.TabIndex = 2
        '
        'panelDashboardOverview
        '
        Me.panelDashboardOverview.BackColor = System.Drawing.Color.Transparent
        Me.panelDashboardOverview.Controls.Add(Me.panelRecentCard)
        Me.panelDashboardOverview.Controls.Add(Me.tlpOverviewCards)
        Me.panelDashboardOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashboardOverview.Location = New System.Drawing.Point(0, 0)
        Me.panelDashboardOverview.Name = "panelDashboardOverview"
        Me.panelDashboardOverview.Size = New System.Drawing.Size(1180, 746)
        Me.panelDashboardOverview.TabIndex = 0
        '
        'tlpOverviewCards
        '
        Me.tlpOverviewCards.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpOverviewCards.BackColor = System.Drawing.Color.Transparent
        Me.tlpOverviewCards.ColumnCount = 4
        Me.tlpOverviewCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpOverviewCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpOverviewCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpOverviewCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpOverviewCards.Controls.Add(Me.panelCardTotalLogs, 0, 0)
        Me.tlpOverviewCards.Controls.Add(Me.panelCardPendingSanctions, 1, 0)
        Me.tlpOverviewCards.Controls.Add(Me.panelCardCleared, 2, 0)
        Me.tlpOverviewCards.Controls.Add(Me.panelCardOverdueCases, 3, 0)
        Me.tlpOverviewCards.Location = New System.Drawing.Point(18, 14)
        Me.tlpOverviewCards.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpOverviewCards.Name = "tlpOverviewCards"
        Me.tlpOverviewCards.RowCount = 1
        Me.tlpOverviewCards.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpOverviewCards.Size = New System.Drawing.Size(1144, 106)
        Me.tlpOverviewCards.TabIndex = 0
        '
        'panelCardTotalLogs
        '
        Me.panelCardTotalLogs.BackColor = System.Drawing.Color.White
        Me.panelCardTotalLogs.Controls.Add(Me.lblCaptionTotalLogs)
        Me.panelCardTotalLogs.Controls.Add(Me.lblCountTotalLogs)
        Me.panelCardTotalLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCardTotalLogs.Location = New System.Drawing.Point(6, 2)
        Me.panelCardTotalLogs.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.panelCardTotalLogs.Name = "panelCardTotalLogs"
        Me.panelCardTotalLogs.Size = New System.Drawing.Size(274, 102)
        Me.panelCardTotalLogs.TabIndex = 0
        '
        'lblCountTotalLogs
        '
        Me.lblCountTotalLogs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountTotalLogs.AutoSize = True
        Me.lblCountTotalLogs.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountTotalLogs.ForeColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.lblCountTotalLogs.Location = New System.Drawing.Point(118, 14)
        Me.lblCountTotalLogs.Name = "lblCountTotalLogs"
        Me.lblCountTotalLogs.Size = New System.Drawing.Size(37, 41)
        Me.lblCountTotalLogs.TabIndex = 0
        Me.lblCountTotalLogs.Text = "0"
        '
        'lblCaptionTotalLogs
        '
        Me.lblCaptionTotalLogs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptionTotalLogs.AutoSize = True
        Me.lblCaptionTotalLogs.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCaptionTotalLogs.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblCaptionTotalLogs.Location = New System.Drawing.Point(87, 66)
        Me.lblCaptionTotalLogs.Name = "lblCaptionTotalLogs"
        Me.lblCaptionTotalLogs.Size = New System.Drawing.Size(100, 17)
        Me.lblCaptionTotalLogs.TabIndex = 1
        Me.lblCaptionTotalLogs.Text = "Active Offenses"
        '
        'panelCardPendingSanctions
        '
        Me.panelCardPendingSanctions.BackColor = System.Drawing.Color.White
        Me.panelCardPendingSanctions.Controls.Add(Me.lblCaptionPendingSanctions)
        Me.panelCardPendingSanctions.Controls.Add(Me.lblCountPendingSanctions)
        Me.panelCardPendingSanctions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCardPendingSanctions.Location = New System.Drawing.Point(292, 2)
        Me.panelCardPendingSanctions.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.panelCardPendingSanctions.Name = "panelCardPendingSanctions"
        Me.panelCardPendingSanctions.Size = New System.Drawing.Size(274, 102)
        Me.panelCardPendingSanctions.TabIndex = 1
        '
        'lblCountPendingSanctions
        '
        Me.lblCountPendingSanctions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountPendingSanctions.AutoSize = True
        Me.lblCountPendingSanctions.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountPendingSanctions.ForeColor = System.Drawing.Color.FromArgb(180, 83, 9)
        Me.lblCountPendingSanctions.Location = New System.Drawing.Point(118, 14)
        Me.lblCountPendingSanctions.Name = "lblCountPendingSanctions"
        Me.lblCountPendingSanctions.Size = New System.Drawing.Size(37, 41)
        Me.lblCountPendingSanctions.TabIndex = 0
        Me.lblCountPendingSanctions.Text = "0"
        '
        'lblCaptionPendingSanctions
        '
        Me.lblCaptionPendingSanctions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptionPendingSanctions.AutoSize = True
        Me.lblCaptionPendingSanctions.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCaptionPendingSanctions.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblCaptionPendingSanctions.Location = New System.Drawing.Point(75, 66)
        Me.lblCaptionPendingSanctions.Name = "lblCaptionPendingSanctions"
        Me.lblCaptionPendingSanctions.Size = New System.Drawing.Size(124, 17)
        Me.lblCaptionPendingSanctions.TabIndex = 1
        Me.lblCaptionPendingSanctions.Text = "Pending Sanctions"
        '
        'panelCardCleared
        '
        Me.panelCardCleared.BackColor = System.Drawing.Color.White
        Me.panelCardCleared.Controls.Add(Me.lblCaptionCleared)
        Me.panelCardCleared.Controls.Add(Me.lblCountCleared)
        Me.panelCardCleared.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCardCleared.Location = New System.Drawing.Point(578, 2)
        Me.panelCardCleared.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.panelCardCleared.Name = "panelCardCleared"
        Me.panelCardCleared.Size = New System.Drawing.Size(274, 102)
        Me.panelCardCleared.TabIndex = 2
        '
        'lblCountCleared
        '
        Me.lblCountCleared.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountCleared.AutoSize = True
        Me.lblCountCleared.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountCleared.ForeColor = System.Drawing.Color.FromArgb(21, 128, 61)
        Me.lblCountCleared.Location = New System.Drawing.Point(118, 14)
        Me.lblCountCleared.Name = "lblCountCleared"
        Me.lblCountCleared.Size = New System.Drawing.Size(37, 41)
        Me.lblCountCleared.TabIndex = 0
        Me.lblCountCleared.Text = "0"
        '
        'lblCaptionCleared
        '
        Me.lblCaptionCleared.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptionCleared.AutoSize = True
        Me.lblCaptionCleared.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCaptionCleared.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblCaptionCleared.Location = New System.Drawing.Point(75, 66)
        Me.lblCaptionCleared.Name = "lblCaptionCleared"
        Me.lblCaptionCleared.Size = New System.Drawing.Size(124, 17)
        Me.lblCaptionCleared.TabIndex = 1
        Me.lblCaptionCleared.Text = "Cleared Sanctions"
        '
        'panelCardOverdueCases
        '
        Me.panelCardOverdueCases.BackColor = System.Drawing.Color.White
        Me.panelCardOverdueCases.Controls.Add(Me.lblCaptionOverdueCases)
        Me.panelCardOverdueCases.Controls.Add(Me.lblCountOverdueCases)
        Me.panelCardOverdueCases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCardOverdueCases.Location = New System.Drawing.Point(864, 2)
        Me.panelCardOverdueCases.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.panelCardOverdueCases.Name = "panelCardOverdueCases"
        Me.panelCardOverdueCases.Size = New System.Drawing.Size(274, 102)
        Me.panelCardOverdueCases.TabIndex = 3
        '
        'lblCountOverdueCases
        '
        Me.lblCountOverdueCases.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountOverdueCases.AutoSize = True
        Me.lblCountOverdueCases.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCountOverdueCases.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28)
        Me.lblCountOverdueCases.Location = New System.Drawing.Point(118, 14)
        Me.lblCountOverdueCases.Name = "lblCountOverdueCases"
        Me.lblCountOverdueCases.Size = New System.Drawing.Size(37, 41)
        Me.lblCountOverdueCases.TabIndex = 0
        Me.lblCountOverdueCases.Text = "0"
        '
        'lblCaptionOverdueCases
        '
        Me.lblCaptionOverdueCases.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptionOverdueCases.AutoSize = True
        Me.lblCaptionOverdueCases.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCaptionOverdueCases.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblCaptionOverdueCases.Location = New System.Drawing.Point(81, 66)
        Me.lblCaptionOverdueCases.Name = "lblCaptionOverdueCases"
        Me.lblCaptionOverdueCases.Size = New System.Drawing.Size(111, 17)
        Me.lblCaptionOverdueCases.TabIndex = 1
        Me.lblCaptionOverdueCases.Text = "Overdue Cases"
        '
        'panelRecentCard
        '
        Me.panelRecentCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelRecentCard.BackColor = System.Drawing.Color.White
        Me.panelRecentCard.Controls.Add(Me.dgvRecentLogs)
        Me.panelRecentCard.Controls.Add(Me.lblRecentTitle)
        Me.panelRecentCard.Location = New System.Drawing.Point(24, 132)
        Me.panelRecentCard.Name = "panelRecentCard"
        Me.panelRecentCard.Size = New System.Drawing.Size(1132, 590)
        Me.panelRecentCard.TabIndex = 1
        '
        'lblRecentTitle
        '
        Me.lblRecentTitle.AutoSize = True
        Me.lblRecentTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.lblRecentTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblRecentTitle.Name = "lblRecentTitle"
        Me.lblRecentTitle.Size = New System.Drawing.Size(202, 19)
        Me.lblRecentTitle.TabIndex = 0
        Me.lblRecentTitle.Text = "Recent Disciplinary Activity"
        '
        'dgvRecentLogs
        '
        Me.dgvRecentLogs.AllowUserToAddRows = False
        Me.dgvRecentLogs.AllowUserToDeleteRows = False
        Me.dgvRecentLogs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecentLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentLogs.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecentLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecentLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecentLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecentLogs.ColumnHeadersHeight = 36
        Me.dgvRecentLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRecentLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRecentLogID, Me.colRecentStudentID, Me.colRecentStudentName, Me.colRecentSection, Me.colRecentOffense, Me.colRecentStatus})
        Me.dgvRecentLogs.EnableHeadersVisualStyles = False
        Me.dgvRecentLogs.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.dgvRecentLogs.GridColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.dgvRecentLogs.Location = New System.Drawing.Point(18, 42)
        Me.dgvRecentLogs.Name = "dgvRecentLogs"
        Me.dgvRecentLogs.ReadOnly = True
        Me.dgvRecentLogs.RowHeadersVisible = False
        Me.dgvRecentLogs.RowTemplate.Height = 34
        Me.dgvRecentLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecentLogs.Size = New System.Drawing.Size(1096, 530)
        Me.dgvRecentLogs.TabIndex = 1
        '
        'colRecentLogID
        '
        Me.colRecentLogID.HeaderText = "Log ID"
        Me.colRecentLogID.Name = "colRecentLogID"
        Me.colRecentLogID.Visible = False
        '
        'colRecentStudentID
        '
        Me.colRecentStudentID.FillWeight = 95.0!
        Me.colRecentStudentID.HeaderText = "Student ID"
        Me.colRecentStudentID.Name = "colRecentStudentID"
        '
        'colRecentStudentName
        '
        Me.colRecentStudentName.FillWeight = 145.0!
        Me.colRecentStudentName.HeaderText = "Student Name"
        Me.colRecentStudentName.Name = "colRecentStudentName"
        '
        'colRecentSection
        '
        Me.colRecentSection.FillWeight = 100.0!
        Me.colRecentSection.HeaderText = "Section"
        Me.colRecentSection.Name = "colRecentSection"
        '
        'colRecentOffense
        '
        Me.colRecentOffense.FillWeight = 180.0!
        Me.colRecentOffense.HeaderText = "Offense"
        Me.colRecentOffense.Name = "colRecentOffense"
        '
        'colRecentStatus
        '
        Me.colRecentStatus.FillWeight = 95.0!
        Me.colRecentStatus.HeaderText = "Status"
        Me.colRecentStatus.Name = "colRecentStatus"
        '
        'MainDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.ClientSize = New System.Drawing.Size(1420, 820)
        Me.Controls.Add(Me.panelContentHost)
        Me.Controls.Add(Me.panelTopBar)
        Me.Controls.Add(Me.panelSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.Name = "MainDashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU SDOTS - Disciplinary Management System"
        Me.panelSidebar.ResumeLayout(False)
        Me.panelSidebar.PerformLayout()
        Me.panelTopBar.ResumeLayout(False)
        Me.panelTopBar.PerformLayout()
        Me.panelContentHost.ResumeLayout(False)
        Me.panelDashboardOverview.ResumeLayout(False)
        Me.tlpOverviewCards.ResumeLayout(False)
        Me.panelCardTotalLogs.ResumeLayout(False)
        Me.panelCardTotalLogs.PerformLayout()
        Me.panelCardPendingSanctions.ResumeLayout(False)
        Me.panelCardPendingSanctions.PerformLayout()
        Me.panelCardCleared.ResumeLayout(False)
        Me.panelCardCleared.PerformLayout()
        Me.panelCardOverdueCases.ResumeLayout(False)
        Me.panelCardOverdueCases.PerformLayout()
        Me.panelRecentCard.ResumeLayout(False)
        Me.panelRecentCard.PerformLayout()
        CType(Me.dgvRecentLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSidebar As Panel
    Friend WithEvents lblBrandSub As Label
    Friend WithEvents lblBrandTitle As Label
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnNavLogOffense As Button
    Friend WithEvents btnNavSanctions As Button
    Friend WithEvents btnNavSearch As Button
    Friend WithEvents btnNavClearance As Button
    Friend WithEvents btnExportCsv As Button
    Friend WithEvents panelTopBar As Panel
    Friend WithEvents lblLoggedUser As Label
    Friend WithEvents lblFormSubtitle As Label
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents panelContentHost As Panel
    Friend WithEvents panelDashboardOverview As Panel
    Friend WithEvents tlpOverviewCards As TableLayoutPanel
    Friend WithEvents panelCardTotalLogs As Panel
    Friend WithEvents lblCaptionTotalLogs As Label
    Friend WithEvents lblCountTotalLogs As Label
    Friend WithEvents panelCardPendingSanctions As Panel
    Friend WithEvents lblCaptionPendingSanctions As Label
    Friend WithEvents lblCountPendingSanctions As Label
    Friend WithEvents panelCardCleared As Panel
    Friend WithEvents lblCaptionCleared As Label
    Friend WithEvents lblCountCleared As Label
    Friend WithEvents panelCardOverdueCases As Panel
    Friend WithEvents lblCaptionOverdueCases As Label
    Friend WithEvents lblCountOverdueCases As Label
    Friend WithEvents panelRecentCard As Panel
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents dgvRecentLogs As DataGridView
    Friend WithEvents colRecentLogID As DataGridViewTextBoxColumn
    Friend WithEvents colRecentStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colRecentStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colRecentSection As DataGridViewTextBoxColumn
    Friend WithEvents colRecentOffense As DataGridViewTextBoxColumn
    Friend WithEvents colRecentStatus As DataGridViewTextBoxColumn
End Class