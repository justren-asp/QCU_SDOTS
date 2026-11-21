<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcSearchRecords
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
        Me.panelFilters = New System.Windows.Forms.Panel()
        Me.btnSearchRecords = New System.Windows.Forms.Button()
        Me.cboDateRange = New System.Windows.Forms.ComboBox()
        Me.lblDateRange = New System.Windows.Forms.Label()
        Me.cboSeverity = New System.Windows.Forms.ComboBox()
        Me.lblSeverity = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtSearchKeyword = New System.Windows.Forms.TextBox()
        Me.lblSearchKeyword = New System.Windows.Forms.Label()
        Me.lblFilterSectionTitle = New System.Windows.Forms.Label()
        Me.panelTableCard = New System.Windows.Forms.Panel()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.colRecordID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDepartment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOffense = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSeverity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateLogged = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblTableTitle = New System.Windows.Forms.Label()
        Me.panelHeader.SuspendLayout()
        Me.panelFilters.SuspendLayout()
        Me.panelTableCard.SuspendLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelHeader.Size = New System.Drawing.Size(1100, 78)
        Me.panelHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(24, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(316, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Search Student Offense Records"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 46)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(498, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Search and filter disciplinary records by student ID, name, department, severity, and date range."
        '
        'panelFilters
        '
        Me.panelFilters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelFilters.BackColor = System.Drawing.Color.White
        Me.panelFilters.Controls.Add(Me.btnSearchRecords)
        Me.panelFilters.Controls.Add(Me.cboDateRange)
        Me.panelFilters.Controls.Add(Me.lblDateRange)
        Me.panelFilters.Controls.Add(Me.cboSeverity)
        Me.panelFilters.Controls.Add(Me.lblSeverity)
        Me.panelFilters.Controls.Add(Me.cboDepartment)
        Me.panelFilters.Controls.Add(Me.lblDepartment)
        Me.panelFilters.Controls.Add(Me.txtSearchKeyword)
        Me.panelFilters.Controls.Add(Me.lblSearchKeyword)
        Me.panelFilters.Controls.Add(Me.lblFilterSectionTitle)
        Me.panelFilters.Location = New System.Drawing.Point(24, 96)
        Me.panelFilters.Name = "panelFilters"
        Me.panelFilters.Size = New System.Drawing.Size(1052, 112)
        Me.panelFilters.TabIndex = 1
        '
        'lblFilterSectionTitle
        '
        Me.lblFilterSectionTitle.AutoSize = True
        Me.lblFilterSectionTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblFilterSectionTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFilterSectionTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblFilterSectionTitle.Name = "lblFilterSectionTitle"
        Me.lblFilterSectionTitle.Size = New System.Drawing.Size(123, 19)
        Me.lblFilterSectionTitle.TabIndex = 0
        Me.lblFilterSectionTitle.Text = "Search & Filter Criteria"
        '
        'lblSearchKeyword
        '
        Me.lblSearchKeyword.AutoSize = True
        Me.lblSearchKeyword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchKeyword.ForeColor = System.Drawing.Color.DimGray
        Me.lblSearchKeyword.Location = New System.Drawing.Point(18, 40)
        Me.lblSearchKeyword.Name = "lblSearchKeyword"
        Me.lblSearchKeyword.Size = New System.Drawing.Size(142, 15)
        Me.lblSearchKeyword.TabIndex = 1
        Me.lblSearchKeyword.Text = "Student ID or Last Name"
        '
        'txtSearchKeyword
        '
        Me.txtSearchKeyword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearchKeyword.Location = New System.Drawing.Point(18, 60)
        Me.txtSearchKeyword.Name = "txtSearchKeyword"
        Me.txtSearchKeyword.Size = New System.Drawing.Size(215, 25)
        Me.txtSearchKeyword.TabIndex = 2
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDepartment.ForeColor = System.Drawing.Color.DimGray
        Me.lblDepartment.Location = New System.Drawing.Point(248, 40)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(75, 15)
        Me.lblDepartment.TabIndex = 3
        Me.lblDepartment.Text = "Department"
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(248, 60)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(230, 25)
        Me.cboDepartment.TabIndex = 4
        '
        'lblSeverity
        '
        Me.lblSeverity.AutoSize = True
        Me.lblSeverity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeverity.ForeColor = System.Drawing.Color.DimGray
        Me.lblSeverity.Location = New System.Drawing.Point(493, 40)
        Me.lblSeverity.Name = "lblSeverity"
        Me.lblSeverity.Size = New System.Drawing.Size(102, 15)
        Me.lblSeverity.TabIndex = 5
        Me.lblSeverity.Text = "Offense Severity"
        '
        'cboSeverity
        '
        Me.cboSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeverity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboSeverity.FormattingEnabled = True
        Me.cboSeverity.Location = New System.Drawing.Point(493, 60)
        Me.cboSeverity.Name = "cboSeverity"
        Me.cboSeverity.Size = New System.Drawing.Size(165, 25)
        Me.cboSeverity.TabIndex = 6
        '
        'lblDateRange
        '
        Me.lblDateRange.AutoSize = True
        Me.lblDateRange.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateRange.ForeColor = System.Drawing.Color.DimGray
        Me.lblDateRange.Location = New System.Drawing.Point(673, 40)
        Me.lblDateRange.Name = "lblDateRange"
        Me.lblDateRange.Size = New System.Drawing.Size(72, 15)
        Me.lblDateRange.TabIndex = 7
        Me.lblDateRange.Text = "Date Range"
        '
        'cboDateRange
        '
        Me.cboDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateRange.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboDateRange.FormattingEnabled = True
        Me.cboDateRange.Location = New System.Drawing.Point(673, 60)
        Me.cboDateRange.Name = "cboDateRange"
        Me.cboDateRange.Size = New System.Drawing.Size(175, 25)
        Me.cboDateRange.TabIndex = 8
        '
        'btnSearchRecords
        '
        Me.btnSearchRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSearchRecords.FlatAppearance.BorderSize = 0
        Me.btnSearchRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchRecords.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchRecords.ForeColor = System.Drawing.Color.White
        Me.btnSearchRecords.Location = New System.Drawing.Point(892, 56)
        Me.btnSearchRecords.Name = "btnSearchRecords"
        Me.btnSearchRecords.Size = New System.Drawing.Size(140, 32)
        Me.btnSearchRecords.TabIndex = 9
        Me.btnSearchRecords.Text = "Search Records"
        Me.btnSearchRecords.UseVisualStyleBackColor = False
        '
        'panelTableCard
        '
        Me.panelTableCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTableCard.BackColor = System.Drawing.Color.White
        Me.panelTableCard.Controls.Add(Me.dgvRecords)
        Me.panelTableCard.Controls.Add(Me.lblTableTitle)
        Me.panelTableCard.Location = New System.Drawing.Point(24, 224)
        Me.panelTableCard.Name = "panelTableCard"
        Me.panelTableCard.Size = New System.Drawing.Size(1052, 520)
        Me.panelTableCard.TabIndex = 2
        '
        'lblTableTitle
        '
        Me.lblTableTitle.AutoSize = True
        Me.lblTableTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTableTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblTableTitle.Name = "lblTableTitle"
        Me.lblTableTitle.Size = New System.Drawing.Size(156, 19)
        Me.lblTableTitle.TabIndex = 0
        Me.lblTableTitle.Text = "Infraction Records Table"
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecords.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRecordID, Me.colStudentID, Me.colStudentName, Me.colDepartment, Me.colOffense, Me.colSeverity, Me.colDateLogged, Me.colStatus, Me.colAction})
        Me.dgvRecords.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dgvRecords.Location = New System.Drawing.Point(18, 44)
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.ReadOnly = True
        Me.dgvRecords.RowHeadersVisible = False
        Me.dgvRecords.RowTemplate.Height = 34
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(1016, 458)
        Me.dgvRecords.TabIndex = 1
        '
        'colRecordID
        '
        Me.colRecordID.FillWeight = 80.0!
        Me.colRecordID.HeaderText = "Record ID"
        Me.colRecordID.Name = "colRecordID"
        '
        'colStudentID
        '
        Me.colStudentID.FillWeight = 85.0!
        Me.colStudentID.HeaderText = "Student ID"
        Me.colStudentID.Name = "colStudentID"
        '
        'colStudentName
        '
        Me.colStudentName.FillWeight = 135.0!
        Me.colStudentName.HeaderText = "Student Name"
        Me.colStudentName.Name = "colStudentName"
        '
        'colDepartment
        '
        Me.colDepartment.FillWeight = 140.0!
        Me.colDepartment.HeaderText = "Department"
        Me.colDepartment.Name = "colDepartment"
        '
        'colOffense
        '
        Me.colOffense.FillWeight = 185.0!
        Me.colOffense.HeaderText = "Offense / Violation"
        Me.colOffense.Name = "colOffense"
        '
        'colSeverity
        '
        Me.colSeverity.FillWeight = 85.0!
        Me.colSeverity.HeaderText = "Severity"
        Me.colSeverity.Name = "colSeverity"
        '
        'colDateLogged
        '
        Me.colDateLogged.FillWeight = 95.0!
        Me.colDateLogged.HeaderText = "Date Logged"
        Me.colDateLogged.Name = "colDateLogged"
        '
        'colStatus
        '
        Me.colStatus.FillWeight = 85.0!
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colAction
        '
        Me.colAction.FillWeight = 70.0!
        Me.colAction.HeaderText = "Action"
        Me.colAction.Name = "colAction"
        Me.colAction.Text = "View"
        Me.colAction.UseColumnTextForButtonValue = True
        '
        'UcSearchRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Controls.Add(Me.panelTableCard)
        Me.Controls.Add(Me.panelFilters)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "UcSearchRecords"
        Me.Size = New System.Drawing.Size(1100, 768)
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.panelFilters.ResumeLayout(False)
        Me.panelFilters.PerformLayout()
        Me.panelTableCard.ResumeLayout(False)
        Me.panelTableCard.PerformLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelFilters As Panel
    Friend WithEvents btnSearchRecords As Button
    Friend WithEvents cboDateRange As ComboBox
    Friend WithEvents lblDateRange As Label
    Friend WithEvents cboSeverity As ComboBox
    Friend WithEvents lblSeverity As Label
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtSearchKeyword As TextBox
    Friend WithEvents lblSearchKeyword As Label
    Friend WithEvents lblFilterSectionTitle As Label
    Friend WithEvents panelTableCard As Panel
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents colRecordID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colDepartment As DataGridViewTextBoxColumn
    Friend WithEvents colOffense As DataGridViewTextBoxColumn
    Friend WithEvents colSeverity As DataGridViewTextBoxColumn
    Friend WithEvents colDateLogged As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colAction As DataGridViewButtonColumn
    Friend WithEvents lblTableTitle As Label
End Class