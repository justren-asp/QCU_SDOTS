Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class UcLogOffense

    Private Const MaxAttachments As Integer = 3
    Private Const MaxFileSizeBytes As Long = 5L * 1024L * 1024L

    Private Shared ReadOnly AllowedExtensions As HashSet(Of String) = New HashSet(Of String)(System.StringComparer.OrdinalIgnoreCase) From {
        ".jpg", ".jpeg", ".png", ".bmp", ".gif",
        ".pdf", ".doc", ".docx"
    }

    Private Class LookupItem
        Public ReadOnly IdValue As Object
        Public ReadOnly DescriptionText As String
        Public ReadOnly HasCommunityService As Boolean

        Public Sub New(idVal As Object, desc As String, Optional commService As Boolean = False)
            IdValue = idVal
            DescriptionText = desc
            HasCommunityService = commService
        End Sub

        Public Overrides Function ToString() As String
            Return DescriptionText
        End Function
    End Class

    Private stagedFiles As New List(Of String)()

    Private Sub UcLogOffense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.UseMnemonic = False
        ConfigureDateTimePickers()
        LoadCategoriesFromDb()
        LoadWarningsFromDb()
        SetDefaultDateAndTime()
    End Sub

    Private Sub ConfigureDateTimePickers()
        dtpIncidentDate.Format = DateTimePickerFormat.[Short]
        dtpIncidentTime.Format = DateTimePickerFormat.Custom
        dtpIncidentTime.CustomFormat = "hh:mm tt"
        dtpIncidentTime.ShowUpDown = True
    End Sub

    Private Sub DateTimePicker_Paint(sender As Object, e As PaintEventArgs) Handles dtpIncidentDate.Paint, dtpIncidentTime.Paint
        Dim dtp As DateTimePicker = DirectCast(sender, DateTimePicker)
        Dim bgColor As Color = Color.FromArgb(248, 250, 252)
        Dim borderColor As Color = If(dtp.Focused, Color.FromArgb(29, 63, 158), Color.FromArgb(203, 213, 225))
        Dim textColor As Color = Color.FromArgb(15, 23, 42)

        Using bgBrush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(bgBrush, dtp.ClientRectangle)
        End Using

        Dim displayText As String = If(dtp.Format = DateTimePickerFormat.Custom,
                                         dtp.Value.ToString(dtp.CustomFormat),
                                         dtp.Value.ToShortDateString())

        Dim rightReserved As Integer = If(dtp.ShowUpDown, 44, 26)
        Dim textRect As New Rectangle(8, 0, Math.Max(10, dtp.ClientSize.Width - rightReserved - 8), dtp.ClientSize.Height)
        TextRenderer.DrawText(e.Graphics, displayText, dtp.Font, textRect, textColor,
                              TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.SingleLine)

        Using accentBrush As New SolidBrush(Color.FromArgb(241, 245, 249))
            e.Graphics.FillRectangle(accentBrush, dtp.ClientSize.Width - rightReserved, 1, rightReserved - 1, dtp.ClientSize.Height - 2)
        End Using

        Dim indicatorText As String = If(dtp.ShowUpDown, "▲▼", "▾")
        Dim indRect As New Rectangle(dtp.ClientSize.Width - rightReserved, 0, rightReserved, dtp.ClientSize.Height)
        TextRenderer.DrawText(e.Graphics, indicatorText, New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold),
                              indRect, Color.FromArgb(29, 63, 158),
                              TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.SingleLine)

        Using borderPen As New Pen(borderColor, 1.0!)
            e.Graphics.DrawRectangle(borderPen, 0, 0, dtp.ClientSize.Width - 1, dtp.ClientSize.Height - 1)
        End Using
    End Sub

    Private Sub DateTimePicker_StateChanged(sender As Object, e As EventArgs) Handles _
        dtpIncidentDate.ValueChanged, dtpIncidentTime.ValueChanged,
        dtpIncidentDate.GotFocus, dtpIncidentDate.LostFocus,
        dtpIncidentTime.GotFocus, dtpIncidentTime.LostFocus

        DirectCast(sender, DateTimePicker).Invalidate()
    End Sub

    Private Sub SetDefaultDateAndTime()
        Dim nowVal As DateTime = DateTime.Now
        dtpIncidentDate.MinDate = nowVal.AddMonths(-2).Date
        dtpIncidentDate.MaxDate = nowVal.Date
        dtpIncidentDate.Value = nowVal.Date
        dtpIncidentTime.Value = nowVal
        dtpIncidentDate.Invalidate()
        dtpIncidentTime.Invalidate()
    End Sub

    Private Sub ModernCombo_DrawItem(sender As Object, e As DrawItemEventArgs) Handles _
        cboCategory.DrawItem, cboSpecificOffense.DrawItem, cboWarningLevel.DrawItem, cboSanction.DrawItem

        If e.Index < 0 Then Return

        Dim cbo As ComboBox = DirectCast(sender, ComboBox)
        Dim isSelected As Boolean = ((e.State And DrawItemState.Selected) = DrawItemState.Selected)
        Dim isComboBoxEdit As Boolean = ((e.State And DrawItemState.ComboBoxEdit) = DrawItemState.ComboBoxEdit)

        Dim bgColor As Color = If(isSelected AndAlso Not isComboBoxEdit,
                                  Color.FromArgb(29, 63, 158),
                                  If(isComboBoxEdit, Color.FromArgb(248, 250, 252), Color.White))
        Dim fgColor As Color = If(isSelected AndAlso Not isComboBoxEdit,
                                  Color.White,
                                  Color.FromArgb(15, 23, 42))

        Using bgBrush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
        End Using

        Dim itemText As String = cbo.Items(e.Index).ToString()
        Dim textRect As New Rectangle(e.Bounds.X + 10, e.Bounds.Y, Math.Max(10, e.Bounds.Width - 20), e.Bounds.Height)
        TextRenderer.DrawText(e.Graphics, itemText, cbo.Font, textRect, fgColor,
                              TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.EndEllipsis)

        If Not isComboBoxEdit Then
            Using linePen As New Pen(Color.FromArgb(241, 245, 249), 1.0!)
                e.Graphics.DrawLine(linePen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1)
            End Using
        End If
    End Sub

    Private Sub AdjustDropDownWidth(cbo As ComboBox, minWidth As Integer)
        Dim maxW As Integer = minWidth
        Using g As Graphics = cbo.CreateGraphics()
            For Each item In cbo.Items
                Dim textW As Integer = TextRenderer.MeasureText(g, item.ToString(), cbo.Font).Width + 44
                If textW > maxW Then
                    maxW = textW
                End If
            Next
        End Using
        cbo.DropDownWidth = Math.Min(maxW, 650)
    End Sub

    Private Sub LoadCategoriesFromDb()
        cboCategory.Items.Clear()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT id, description FROM offense_category ORDER BY id ASC", conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboCategory.Items.Add(New LookupItem(Convert.ToInt32(reader("id")), Convert.ToString(reader("description"))))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to load offense categories: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If cboCategory.Items.Count = 0 Then
            cboCategory.Items.Add(New LookupItem(0, "Minor Offense"))
            cboCategory.Items.Add(New LookupItem(1, "Major Offense"))
        End If

        AdjustDropDownWidth(cboCategory, cboCategory.Width)
        cboCategory.SelectedIndex = 0
        UpdateSpecificOffensesForCategory()
    End Sub

    Private Sub LoadWarningsFromDb()
        cboWarningLevel.Items.Clear()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT id, description FROM warnings ORDER BY id ASC", conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim wid As String = Convert.ToString(reader("id"))
                            Dim desc As String = Convert.ToString(reader("description"))
                            If Not String.Equals(desc, "Others", System.StringComparison.OrdinalIgnoreCase) AndAlso
                               Not String.Equals(wid, "O", System.StringComparison.OrdinalIgnoreCase) Then
                                cboWarningLevel.Items.Add(New LookupItem(wid, desc))
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to load warning levels: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If cboWarningLevel.Items.Count = 0 Then
            cboWarningLevel.Items.Add(New LookupItem("A", "1st Warning"))
            cboWarningLevel.Items.Add(New LookupItem("B", "2nd Warning"))
            cboWarningLevel.Items.Add(New LookupItem("C", "3rd Warning"))
        End If

        AdjustDropDownWidth(cboWarningLevel, cboWarningLevel.Width)
        cboWarningLevel.SelectedIndex = 0
        UpdateSanctionsForWarning()
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        UpdateSpecificOffensesForCategory()
    End Sub

    Private Sub UpdateSpecificOffensesForCategory()
        Dim catItem As LookupItem = TryCast(cboCategory.SelectedItem, LookupItem)
        Dim catId As Integer = If(catItem IsNot Nothing, Convert.ToInt32(catItem.IdValue), 0)

        cboSpecificOffense.Items.Clear()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim sql As String = "SELECT id, description FROM offense_specific WHERE category_id = @cid ORDER BY id ASC"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cid", catId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboSpecificOffense.Items.Add(New LookupItem(Convert.ToInt32(reader("id")), Convert.ToString(reader("description"))))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to load specific offenses: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If cboSpecificOffense.Items.Count = 0 Then
            cboSpecificOffense.Items.Add(New LookupItem(6, "Others"))
        End If

        AdjustDropDownWidth(cboSpecificOffense, cboSpecificOffense.Width)
        cboSpecificOffense.SelectedIndex = 0
        ToggleCustomOffenseField()
    End Sub

    Private Sub cboSpecificOffense_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSpecificOffense.SelectedIndexChanged
        ToggleCustomOffenseField()
    End Sub

    Private Sub ToggleCustomOffenseField()
        Dim specItem As LookupItem = TryCast(cboSpecificOffense.SelectedItem, LookupItem)
        Dim isOthers As Boolean = (specItem IsNot Nothing AndAlso
                                   String.Equals(specItem.DescriptionText, "Others", System.StringComparison.OrdinalIgnoreCase))
        txtCustomOffense.Visible = isOthers
        If Not isOthers Then
            txtCustomOffense.Clear()
        End If
    End Sub

    Private Sub cboWarningLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWarningLevel.SelectedIndexChanged
        UpdateSanctionsForWarning()
    End Sub

    Private Sub UpdateSanctionsForWarning()
        Dim warnItem As LookupItem = TryCast(cboWarningLevel.SelectedItem, LookupItem)
        Dim warnId As String = If(warnItem IsNot Nothing, Convert.ToString(warnItem.IdValue), "A")

        cboSanction.Items.Clear()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim sql As String = "SELECT id, description, has_community_service FROM warning_specific WHERE warning_id = @wid ORDER BY id ASC"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@wid", warnId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim sDesc As String = Convert.ToString(reader("description"))
                            Dim hasCs As Boolean = Not IsDBNull(reader("has_community_service")) AndAlso Convert.ToInt32(reader("has_community_service")) <> 0
                            cboSanction.Items.Add(New LookupItem(Convert.ToInt32(reader("id")), sDesc, hasCs))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to load warning sanctions: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        If Not cboSanction.Items.Cast(Of Object)().Any(Function(x) String.Equals(x.ToString(), "Others", System.StringComparison.OrdinalIgnoreCase)) Then
            cboSanction.Items.Add(New LookupItem(Nothing, "Others", False))
        End If

        AdjustDropDownWidth(cboSanction, cboSanction.Width)
        cboSanction.SelectedIndex = 0
        ToggleCustomSanctionField()
    End Sub

    Private Sub cboSanction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSanction.SelectedIndexChanged
        ToggleCustomSanctionField()
    End Sub

    Private Sub ToggleCustomSanctionField()
        Dim sancItem As LookupItem = TryCast(cboSanction.SelectedItem, LookupItem)
        Dim isOthers As Boolean = (sancItem IsNot Nothing AndAlso
                                   String.Equals(sancItem.DescriptionText, "Others", System.StringComparison.OrdinalIgnoreCase))
        txtCustomSanction.Visible = isOthers
        If Not isOthers Then
            txtCustomSanction.Clear()
        End If
    End Sub

    Private Sub txtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentID.KeyPress
        If Char.IsControl(e.KeyChar) Then Return
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        Dim digitsOnly As New String(txtStudentID.Text.Where(Function(ch) Char.IsDigit(ch)).ToArray())
        If digitsOnly.Length > 6 Then
            digitsOnly = digitsOnly.Substring(0, 6)
        End If

        Dim formatted As String = If(digitsOnly.Length > 2,
                                      digitsOnly.Substring(0, 2) & "-" & digitsOnly.Substring(2),
                                      digitsOnly)

        If Not String.Equals(txtStudentID.Text, formatted, System.StringComparison.Ordinal) Then
            Dim pos As Integer = formatted.Length
            txtStudentID.Text = formatted
            txtStudentID.SelectionStart = Math.Max(0, pos)
        End If
    End Sub

    Private Function IsStrictStudentId(sid As String) As Boolean
        Return Regex.IsMatch(sid, "^\d{2}-\d{4}$")
    End Function

    Private Function FormatSectionValue(rawSection As String, dept As String) As String
        Dim cleaned As String = rawSection.Trim().ToUpperInvariant()
        If cleaned = "" Then Return ""
        If Regex.IsMatch(cleaned, "^[A-Z]{2,6}-\d[A-Z0-9]{0,2}$") Then
            Return cleaned
        End If
        Dim deptPrefix As String = New String(dept.Trim().ToUpperInvariant().Where(Function(c) Char.IsLetter(c)).ToArray())
        If deptPrefix.Length > 5 Then deptPrefix = deptPrefix.Substring(0, 5)
        If deptPrefix <> "" AndAlso Not cleaned.StartsWith(deptPrefix & "-") Then
            Return deptPrefix & "-" & cleaned
        End If
        Return cleaned
    End Function

    Private Sub btnFindStudent_Click(sender As Object, e As EventArgs) Handles btnFindStudent.Click
        LookupStudentRecord()
    End Sub

    Private Sub txtStudentID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentID.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LookupStudentRecord()
        End If
    End Sub

    Private Sub LookupStudentRecord()
        Dim sid As String = txtStudentID.Text.Trim()
        If sid = "" Then
            MessageBox.Show("Please enter a Student ID first.", "Missing Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsStrictStudentId(sid) Then
            ClearStudentFields()
            MessageBox.Show("Invalid Student ID format. Use strictly 00-0000 (numbers only).", "Invalid ID Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentID.Focus()
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT student_id, last_name, first_name, middle_name, department, section " &
                                    "FROM students WHERE student_id = @sid AND record_status = 'Active' LIMIT 1"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", sid)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim deptVal As String = Convert.ToString(reader("department"))
                            Dim rawSec As String = Convert.ToString(reader("section"))
                            txtLastName.Text = Convert.ToString(reader("last_name"))
                            txtFirstName.Text = Convert.ToString(reader("first_name"))
                            txtMiddleName.Text = Convert.ToString(reader("middle_name"))
                            txtDepartment.Text = deptVal
                            txtSection.Text = FormatSectionValue(rawSec, deptVal)
                        Else
                            ClearStudentFields()
                            MessageBox.Show($"No student found with ID '{sid}'.", "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Student lookup failed: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearStudentFields()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtDepartment.Clear()
        txtSection.Clear()
    End Sub

    Private Sub btnAttachFiles_Click(sender As Object, e As EventArgs) Handles btnAttachFiles.Click
        If stagedFiles.Count >= MaxAttachments Then
            MessageBox.Show($"Only {MaxAttachments} proof attachments are allowed per infraction.", "Attachment Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using dlg As New OpenFileDialog()
            dlg.Title = "Select Evidence / Proof Files (Optional, 1-3 Files)"
            dlg.Multiselect = True
            dlg.Filter = "Allowed Proofs (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.pdf;*.doc;*.docx)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.pdf;*.doc;*.docx"

            If dlg.ShowDialog() = DialogResult.OK Then
                For Each filePath In dlg.FileNames
                    If stagedFiles.Count >= MaxAttachments Then
                        MessageBox.Show($"You can attach up to {MaxAttachments} proof files per infraction.", "Attachment Limit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit For
                    End If

                    Dim ext As String = Path.GetExtension(filePath)
                    If Not AllowedExtensions.Contains(ext) Then
                        MessageBox.Show($"'{Path.GetFileName(filePath)}' is not an allowed format. Use images or PDF/Word files.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If

                    Dim info As New FileInfo(filePath)
                    If info.Length > MaxFileSizeBytes Then
                        MessageBox.Show($"'{info.Name}' exceeds the maximum allowed size of 5 MB.", "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If

                    If Not stagedFiles.Contains(filePath, System.StringComparer.OrdinalIgnoreCase) Then
                        stagedFiles.Add(filePath)
                        lstAttachments.Items.Add($"{info.Name} ({Math.Max(1, info.Length \ 1024)} KB)")
                    End If
                Next
            End If
        End Using
    End Sub

    Private Sub btnRemoveAttachment_Click(sender As Object, e As EventArgs) Handles btnRemoveAttachment.Click
        Dim idx As Integer = lstAttachments.SelectedIndex
        If idx < 0 Then Return
        lstAttachments.Items.RemoveAt(idx)
        If idx < stagedFiles.Count Then
            stagedFiles.RemoveAt(idx)
        End If
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        txtStudentID.Clear()
        ClearStudentFields()
        If cboCategory.Items.Count > 0 Then cboCategory.SelectedIndex = 0
        If cboWarningLevel.Items.Count > 0 Then cboWarningLevel.SelectedIndex = 0
        txtCustomOffense.Clear()
        txtCustomSanction.Clear()
        txtRemarks.Clear()
        stagedFiles.Clear()
        lstAttachments.Items.Clear()
        SetDefaultDateAndTime()
        UpdateSpecificOffensesForCategory()
        UpdateSanctionsForWarning()
    End Sub

    Private Sub btnSaveInfraction_Click(sender As Object, e As EventArgs) Handles btnSaveInfraction.Click
        Dim sid As String = txtStudentID.Text.Trim()
        If sid = "" OrElse Not IsStrictStudentId(sid) Then
            MessageBox.Show("Please enter a valid Student ID in strict format 00-0000 (numbers only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentID.Focus()
            Return
        End If

        If txtLastName.Text.Trim() = "" AndAlso txtFirstName.Text.Trim() = "" Then
            LookupStudentRecord()
            If txtLastName.Text.Trim() = "" AndAlso txtFirstName.Text.Trim() = "" Then Return
        End If

        Dim incidentCombined As New DateTime(
            dtpIncidentDate.Value.Year,
            dtpIncidentDate.Value.Month,
            dtpIncidentDate.Value.Day,
            dtpIncidentTime.Value.Hour,
            dtpIncidentTime.Value.Minute,
            0)

        Dim nowMinute As New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0)
        If incidentCombined > nowMinute Then
            MessageBox.Show("Incident date and time cannot be in the future.", "Invalid Date/Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If incidentCombined < DateTime.Now.AddMonths(-2) Then
            MessageBox.Show("Incident date cannot be older than 2 months before today.", "Invalid Date/Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim catItem As LookupItem = TryCast(cboCategory.SelectedItem, LookupItem)
        Dim categoryId As Integer = If(catItem IsNot Nothing, Convert.ToInt32(catItem.IdValue), 0)
        Dim categoryDesc As String = If(catItem IsNot Nothing, catItem.DescriptionText, "Minor Offense")
        Dim severityLabel As String = If(categoryId = 1 OrElse categoryDesc.IndexOf("Major", System.StringComparison.OrdinalIgnoreCase) >= 0, "Major", "Minor")

        Dim specItem As LookupItem = TryCast(cboSpecificOffense.SelectedItem, LookupItem)
        Dim specificId As Integer = If(specItem IsNot Nothing, Convert.ToInt32(specItem.IdValue), 6)
        Dim selectedSpecific As String = If(specItem IsNot Nothing, specItem.DescriptionText, "Others")
        Dim customSpec As String = txtCustomOffense.Text.Trim()

        If String.Equals(selectedSpecific, "Others", System.StringComparison.OrdinalIgnoreCase) AndAlso customSpec = "" Then
            MessageBox.Show("Please enter the specific offense under 'Others'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomOffense.Focus()
            Return
        End If

        Dim warnItem As LookupItem = TryCast(cboWarningLevel.SelectedItem, LookupItem)
        Dim warningId As String = If(warnItem IsNot Nothing, Convert.ToString(warnItem.IdValue), "A")
        Dim warningLvl As String = If(warnItem IsNot Nothing, warnItem.DescriptionText, "1st Warning")

        Dim sancItem As LookupItem = TryCast(cboSanction.SelectedItem, LookupItem)
        Dim sanctionSpecId As Object = If(sancItem IsNot Nothing AndAlso sancItem.IdValue IsNot Nothing, sancItem.IdValue, DBNull.Value)
        Dim selectedSanction As String = If(sancItem IsNot Nothing, sancItem.DescriptionText, "")
        Dim customSanction As String = txtCustomSanction.Text.Trim()

        If String.Equals(selectedSanction, "Others", System.StringComparison.OrdinalIgnoreCase) AndAlso customSanction = "" Then
            MessageBox.Show("Please enter the sanction under 'Others'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomSanction.Focus()
            Return
        End If

        Dim sanctionType As String = If(String.Equals(selectedSanction, "Others", System.StringComparison.OrdinalIgnoreCase), customSanction, selectedSanction)
        Dim hasCommService As Boolean = (sancItem IsNot Nothing AndAlso sancItem.HasCommunityService) OrElse
                                        (sanctionType.IndexOf("Community Service", System.StringComparison.OrdinalIgnoreCase) >= 0)
        Dim reqHours As Integer = If(hasCommService, 20, 0)
        Dim remarks As String = txtRemarks.Text.Trim()

        If sanctionType = "" Then
            MessageBox.Show("Please select a recommended sanction or action.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If remarks = "" Then
            MessageBox.Show("Please enter incident remarks.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRemarks.Focus()
            Return
        End If

        Dim cleanOffenseLabel As String = If(String.Equals(selectedSpecific, "Others", System.StringComparison.OrdinalIgnoreCase), customSpec, selectedSpecific)
        Dim formattedOffense As String = $"{severityLabel} - {cleanOffenseLabel}"
        Dim incidentDateStr As String = incidentCombined.ToString("MM/dd/yyyy")
        Dim incidentTimeStr As String = incidentCombined.ToString("hh:mm tt")

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                If String.Equals(severityLabel, "Minor", System.StringComparison.OrdinalIgnoreCase) Then
                    Dim minorCountSql As String = "SELECT COUNT(*) FROM offense_logs WHERE student_id = @sid AND severity = 'Minor' AND record_status = 'Active'"
                    Using cmdCount As New MySqlCommand(minorCountSql, conn)
                        cmdCount.Parameters.AddWithValue("@sid", sid)
                        Dim existingMinors As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())
                        If existingMinors >= 2 Then
                            categoryId = 1
                            specificId = 12
                            warningId = "C"
                            sanctionSpecId = 8
                            severityLabel = "Major"
                            formattedOffense = "Major - Third Accumulated Minor Offense (Automatic Escalation)"
                            warningLvl = "3rd Warning"
                            sanctionType = "Disciplinary Board Referral"
                            reqHours = 0
                            MessageBox.Show("Student already has 2 active minor offenses. This infraction has been escalated to a Major Offense.", "Auto-Escalation Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End If

                Using tx As MySqlTransaction = conn.BeginTransaction()
                    Dim insertOffenseSql As String = "INSERT INTO offense_logs " &
                        "(student_id, category_id, specific_offense_id, warning_id, offense_type, custom_specification, severity, warning_level, incident_date, incident_time, remarks, record_status) " &
                        "VALUES (@sid, @catId, @specId, @warnId, @offense, @custom, @sev, @warn, @idate, @itime, @remarks, 'Active'); " &
                        "SELECT LAST_INSERT_ID();"

                    Dim newLogId As Integer = 0
                    Using cmdInsert As New MySqlCommand(insertOffenseSql, conn, tx)
                        cmdInsert.Parameters.AddWithValue("@sid", sid)
                        cmdInsert.Parameters.AddWithValue("@catId", categoryId)
                        cmdInsert.Parameters.AddWithValue("@specId", specificId)
                        cmdInsert.Parameters.AddWithValue("@warnId", warningId)
                        cmdInsert.Parameters.AddWithValue("@offense", formattedOffense)
                        cmdInsert.Parameters.AddWithValue("@custom", If(customSpec <> "", customSpec, customSanction))
                        cmdInsert.Parameters.AddWithValue("@sev", severityLabel)
                        cmdInsert.Parameters.AddWithValue("@warn", warningLvl)
                        cmdInsert.Parameters.AddWithValue("@idate", incidentDateStr)
                        cmdInsert.Parameters.AddWithValue("@itime", incidentTimeStr)
                        cmdInsert.Parameters.AddWithValue("@remarks", remarks)
                        newLogId = Convert.ToInt32(cmdInsert.ExecuteScalar())
                    End Using

                    Dim insertSanctionSql As String = "INSERT INTO sanctions " &
                        "(log_id, warning_specific_id, sanction_type, completed_hours, required_hours, status) " &
                        "VALUES (@logId, @wspecId, @stype, 0, @reqHours, 'Pending')"

                    Using cmdSanction As New MySqlCommand(insertSanctionSql, conn, tx)
                        cmdSanction.Parameters.AddWithValue("@logId", newLogId)
                        cmdSanction.Parameters.AddWithValue("@wspecId", sanctionSpecId)
                        cmdSanction.Parameters.AddWithValue("@stype", sanctionType)
                        cmdSanction.Parameters.AddWithValue("@reqHours", reqHours)
                        cmdSanction.ExecuteNonQuery()
                    End Using

                    If stagedFiles.Count > 0 Then
                        Dim insertAttachSql As String = "INSERT INTO offense_attachments (log_id, file_name, file_path, file_size_bytes) " &
                                                        "VALUES (@logId, @fname, @fpath, @fsize)"
                        For Each fullPath In stagedFiles
                            Dim info As New FileInfo(fullPath)
                            Using cmdAttach As New MySqlCommand(insertAttachSql, conn, tx)
                                cmdAttach.Parameters.AddWithValue("@logId", newLogId)
                                cmdAttach.Parameters.AddWithValue("@fname", info.Name)
                                cmdAttach.Parameters.AddWithValue("@fpath", info.FullName)
                                cmdAttach.Parameters.AddWithValue("@fsize", If(info.Exists, info.Length, 0L))
                                cmdAttach.ExecuteNonQuery()
                            End Using
                        Next
                    End If

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Student infraction saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnClearForm_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("Failed to save infraction: " & ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class