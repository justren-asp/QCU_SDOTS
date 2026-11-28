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
        Me.panelFilterCard = New System.Windows.Forms.Panel()
        Me.lblFilterSectionTitle = New System.Windows.Forms.Label()
        Me.lblSearchQuery = New System.Windows.Forms.Label()
        Me.txtSearchQuery = New System.Windows.Forms.TextBox()
        Me.lblFilterCategory = New System.Windows.Forms.Label()
        Me.cboFilterCategory = New System.Windows.Forms.ComboBox()
        Me.lblFilterStatus = New System.Windows.Forms.Label()
        Me.cboFilterStatus = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnResetFilters = New System.Windows.Forms.Button()
        Me.panelResultsCard = New System.Windows.Forms.Panel()
        Me.lblResultsTitle = New System.Windows.Forms.Label()
        Me.lblResultCount = New System.Windows.Forms.Label()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.colLogID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDepartment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOffenseType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWarningLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIncidentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSanctionStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelHeader.SuspendLayout()
        Me.panelFilterCard.SuspendLayout()
        Me.panelResultsCard.SuspendLayout()
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
        Me.lblTitle.Size = New System.Drawing.Size(274, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Search Disciplinary Records"
        Me.lblTitle.UseMnemonic = False
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 44)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(514, 17)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Search logged student infractions by ID, name, department, offense, or sanction status."
        '
        'panelFilterCard
        '
        Me.panelFilterCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelFilterCard.BackColor = System.Drawing.Color.White
        Me.panelFilterCard.Controls.Add(Me.btnResetFilters)
        Me.panelFilterCard.Controls.Add(Me.btnSearch)
        Me.panelFilterCard.Controls.Add(Me.cboFilterStatus)
        Me.panelFilterCard.Controls.Add(Me.lblFilterStatus)
        Me.panelFilterCard.Controls.Add(Me.cboFilterCategory)
        Me.panelFilterCard.Controls.Add(Me.lblFilterCategory)
        Me.panelFilterCard.Controls.Add(Me.txtSearchQuery)
        Me.panelFilterCard.Controls.Add(Me.lblSearchQuery)
        Me.panelFilterCard.Controls.Add(Me.lblFilterSectionTitle)
        Me.panelFilterCard.Location = New System.Drawing.Point(24, 88)
        Me.panelFilterCard.Name = "panelFilterCard"
        Me.panelFilterCard.Size = New System.Drawing.Size(1132, 104)
        Me.panelFilterCard.TabIndex = 1
        '
        'lblFilterSectionTitle
        '
        Me.lblFilterSectionTitle.AutoSize = True
        Me.lblFilterSectionTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblFilterSectionTitle.ForeColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.lblFilterSectionTitle.Location = New System.Drawing.Point(18, 10)
        Me.lblFilterSectionTitle.Name = "lblFilterSectionTitle"
        Me.lblFilterSectionTitle.Size = New System.Drawing.Size(118, 19)
        Me.lblFilterSectionTitle.TabIndex = 0
        Me.lblFilterSectionTitle.Text = "Search & Filters"
        '
        'lblSearchQuery
        '
        Me.lblSearchQuery.AutoSize = True
        Me.lblSearchQuery.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchQuery.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblSearchQuery.Location = New System.Drawing.Point(18, 36)
        Me.lblSearchQuery.Name = "lblSearchQuery"
        Me.lblSearchQuery.Size = New System.Drawing.Size(166, 17)
        Me.lblSearchQuery.TabIndex = 1
        Me.lblSearchQuery.Text = "Student ID, Name, or Keyword"
        '
        'txtSearchQuery
        '
        Me.txtSearchQuery.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtSearchQuery.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtSearchQuery.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.txtSearchQuery.Location = New System.Drawing.Point(18, 57)
        Me.txtSearchQuery.Name = "txtSearchQuery"
        Me.txtSearchQuery.Size = New System.Drawing.Size(372, 25)
        Me.txtSearchQuery.TabIndex = 2
        '
        'lblFilterCategory
        '
        Me.lblFilterCategory.AutoSize = True
        Me.lblFilterCategory.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblFilterCategory.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblFilterCategory.Location = New System.Drawing.Point(404, 36)
        Me.lblFilterCategory.Name = "lblFilterCategory"
        Me.lblFilterCategory.Size = New System.Drawing.Size(119, 17)
        Me.lblFilterCategory.TabIndex = 3
        Me.lblFilterCategory.Text = "Offense Category"
        '
        'cboFilterCategory
        '
        Me.cboFilterCategory.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.cboFilterCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFilterCategory.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.cboFilterCategory.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cboFilterCategory.FormattingEnabled = True
        Me.cboFilterCategory.ItemHeight = 28
        Me.cboFilterCategory.Location = New System.Drawing.Point(404, 54)
        Me.cboFilterCategory.Name = "cboFilterCategory"
        Me.cboFilterCategory.Size = New System.Drawing.Size(196, 34)
        Me.cboFilterCategory.TabIndex = 4
        '
        'lblFilterStatus
        '
        Me.lblFilterStatus.AutoSize = True
        Me.lblFilterStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.lblFilterStatus.Location = New System.Drawing.Point(614, 36)
        Me.lblFilterStatus.Name = "lblFilterStatus"
        Me.lblFilterStatus.Size = New System.Drawing.Size(106, 17)
        Me.lblFilterStatus.TabIndex = 5
        Me.lblFilterStatus.Text = "Sanction Status"
        '
        'cboFilterStatus
        '
        Me.cboFilterStatus.BackColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.cboFilterStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFilterStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.cboFilterStatus.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cboFilterStatus.FormattingEnabled = True
        Me.cboFilterStatus.ItemHeight = 28
        Me.cboFilterStatus.Location = New System.Drawing.Point(614, 54)
        Me.cboFilterStatus.Name = "cboFilterStatus"
        Me.cboFilterStatus.Size = New System.Drawing.Size(196, 34)
        Me.cboFilterStatus.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(29, 63, 158)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(826, 54)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 34)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search Records"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnResetFilters
        '
        Me.btnResetFilters.BackColor = System.Drawing.Color.FromArgb(226, 232, 240)
        Me.btnResetFilters.FlatAppearance.BorderSize = 0
        Me.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetFilters.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.btnResetFilters.Location = New System.Drawing.Point(968, 54)
        Me.btnResetFilters.Name = "btnResetFilters"
        Me.btnResetFilters.Size = New System.Drawing.Size(146, 34)
        Me.btnResetFilters.TabIndex = 8
        Me.btnResetFilters.Text = "Reset Filters"
        Me.btnResetFilters.UseVisualStyleBackColor = False
        '
        'panelResultsCard
        '
        Me.panelResultsCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelResultsCard.BackColor = System.Drawing.Color.White
        Me.panelResultsCard.Controls.Add(Me.dgvRecords)
        Me.panelResultsCard.Controls.Add(Me.lblResultCount)
        Me.panelResultsCard.Controls.Add(Me.lblResultsTitle)
        Me.panelResultsCard.Location = New System.Drawing.Point(24, 204)
        Me.panelResultsCard.Name = "panelResultsCard"
        Me.panelResultsCard.Size = New System.Drawing.Size(1132, 540)
        Me.panelResultsCard.TabIndex = 2
        '
        'lblResultsTitle
        '
        Me.lblResultsTitle.AutoSize = True
        Me.lblResultsTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblResultsTitle.ForeColor = System.Drawing.Color.FromArgb(24, 43, 92)
        Me.lblResultsTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblResultsTitle.Name = "lblResultsTitle"
        Me.lblResultsTitle.Size = New System.Drawing.Size(172, 19)
        Me.lblResultsTitle.TabIndex = 0
        Me.lblResultsTitle.Text = "Disciplinary Record Results"
        '
        'lblResultCount
        '
        Me.lblResultCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultCount.AutoSize = True
        Me.lblResultCount.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblResultCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139)
        Me.lblResultCount.Location = New System.Drawing.Point(1018, 14)
        Me.lblResultCount.Name = "lblResultCount"
        Me.lblResultCount.Size = New System.Drawing.Size(96, 17)
        Me.lblResultCount.TabIndex = 1
        Me.lblResultCount.Text = "0 records found"
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
        Me.dgvRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecords.ColumnHeadersHeight = 36
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLogID, Me.colStudentID, Me.colStudentName, Me.colDepartment, Me.colOffenseType, Me.colWarningLevel, Me.colIncidentDate, Me.colSanctionStatus})
        Me.dgvRecords.EnableHeadersVisualStyles = False
        Me.dgvRecords.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.dgvRecords.GridColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.dgvRecords.Location = New System.Drawing.Point(18, 42)
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.ReadOnly = True
        Me.dgvRecords.RowHeadersVisible = False
        Me.dgvRecords.RowTemplate.Height = 34
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(1096, 480)
        Me.dgvRecords.TabIndex = 2
        '
        'colLogID
        '
        Me.colLogID.HeaderText = "Log ID"
        Me.colLogID.Name = "colLogID"
        Me.colLogID.Visible = False
        '
        'colStudentID
        '
        Me.colStudentID.FillWeight = 90.0!
        Me.colStudentID.HeaderText = "Student ID"
        Me.colStudentID.Name = "colStudentID"
        '
        'colStudentName
        '
        Me.colStudentName.FillWeight = 140.0!
        Me.colStudentName.HeaderText = "Student Name"
        Me.colStudentName.Name = "colStudentName"
        '
        'colDepartment
        '
        Me.colDepartment.FillWeight = 135.0!
        Me.colDepartment.HeaderText = "Department"
        Me.colDepartment.Name = "colDepartment"
        '
        'colOffenseType
        '
        Me.colOffenseType.FillWeight = 175.0!
        Me.colOffenseType.HeaderText = "Offense"
        Me.colOffenseType.Name = "colOffenseType"
        '
        'colWarningLevel
        '
        Me.colWarningLevel.FillWeight = 95.0!
        Me.colWarningLevel.HeaderText = "Warning"
        Me.colWarningLevel.Name = "colWarningLevel"
        '
        'colIncidentDate
        '
        Me.colIncidentDate.FillWeight = 95.0!
        Me.colIncidentDate.HeaderText = "Incident Date"
        Me.colIncidentDate.Name = "colIncidentDate"
        '
        'colSanctionStatus
        '
        Me.colSanctionStatus.FillWeight = 95.0!
        Me.colSanctionStatus.HeaderText = "Status"
        Me.colSanctionStatus.Name = "colSanctionStatus"
        '
        'UcSearchRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(241, 245, 249)
        Me.Controls.Add(Me.panelResultsCard)
        Me.Controls.Add(Me.panelFilterCard)
        Me.Controls.Add(Me.panelHeader)
        Me.Name = "UcSearchRecords"
        Me.Size = New System.Drawing.Size(1180, 768)
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.panelFilterCard.ResumeLayout(False)
        Me.panelFilterCard.PerformLayout()
        Me.panelResultsCard.ResumeLayout(False)
        Me.panelResultsCard.PerformLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelFilterCard As Panel
    Friend WithEvents lblFilterSectionTitle As Label
    Friend WithEvents lblSearchQuery As Label
    Friend WithEvents txtSearchQuery As TextBox
    Friend WithEvents lblFilterCategory As Label
    Friend WithEvents cboFilterCategory As ComboBox
    Friend WithEvents lblFilterStatus As Label
    Friend WithEvents cboFilterStatus As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnResetFilters As Button
    Friend WithEvents panelResultsCard As Panel
    Friend WithEvents lblResultsTitle As Label
    Friend WithEvents lblResultCount As Label
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents colLogID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colDepartment As DataGridViewTextBoxColumn
    Friend WithEvents colOffenseType As DataGridViewTextBoxColumn
    Friend WithEvents colWarningLevel As DataGridViewTextBoxColumn
    Friend WithEvents colIncidentDate As DataGridViewTextBoxColumn
    Friend WithEvents colSanctionStatus As DataGridViewTextBoxColumn
End Class