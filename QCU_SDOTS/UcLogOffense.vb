Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UcLogOffense

    Private ReadOnly minorOffenses As String() = {
        "Dress Code / Improper Uniform Compliance",
        "Improper Wearing or Non-Display of School ID",
        "Disobeying School Regulation (Loitering / Corridor Disturbance)",
        "Littering or Improper Waste Disposal",
        "Unreturned Borrowed Equipment / Classroom Misuse",
        "Others"
    }

    Private ReadOnly majorOffenses As String() = {
        "Academic Dishonesty (Cheating / Plagiarism / Falsification)",
        "Vandalism or Destruction of University Property",
        "Bullying, Harassment, or Threatening Behavior",
        "Theft, Extortion, or Unauthorized Possession",
        "Smoking, Alcohol, or Prohibited Substances on Campus",
        "Third Accumulated Minor Offense (Automatic Escalation)",
        "Others"
    }

    Private stagedFiles As New List(Of String)()

    Private Sub UcLogOffense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDropdowns()
        SetDefaultDateAndTime()
    End Sub

    Private Sub InitializeDropdowns()
        cboCategory.Items.Clear()
        cboCategory.Items.AddRange(New Object() {"Minor", "Major"})
        cboCategory.SelectedIndex = 0

        cboWarningLevel.Items.Clear()
        cboWarningLevel.Items.AddRange(New Object() {
            "1st Warning",
            "2nd Warning",
            "3rd Warning (Escalation)"
        })
        cboWarningLevel.SelectedIndex = 0

        cboSanction.Items.Clear()
        cboSanction.Items.AddRange(New Object() {
            "Written Warning / Reprimand",
            "Parent / Guardian Conference",
            "Community Service (10–20 hrs)",
            "Disciplinary Board Referral",
            "Suspension"
        })
        cboSanction.SelectedIndex = 0

        UpdateSpecificOffensesForCategory()
    End Sub

    Private Sub SetDefaultDateAndTime()
        txtIncidentDate.Text = DateTime.Now.ToString("MM/dd/yyyy")
        txtIncidentTime.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        UpdateSpecificOffensesForCategory()
    End Sub

    Private Sub UpdateSpecificOffensesForCategory()
        Dim selectedCat As String = If(cboCategory.SelectedItem IsNot Nothing, cboCategory.SelectedItem.ToString(), "Minor")

        cboSpecificOffense.Items.Clear()
        If selectedCat = "Major" Then
            cboSpecificOffense.Items.AddRange(majorOffenses)
            cboSanction.SelectedItem = "Disciplinary Board Referral"
        Else
            cboSpecificOffense.Items.AddRange(minorOffenses)
            cboSanction.SelectedItem = "Written Warning / Reprimand"
        End If

        If cboSpecificOffense.Items.Count > 0 Then
            cboSpecificOffense.SelectedIndex = 0
        End If

        ToggleCustomOffenseField()
    End Sub

    Private Sub cboSpecificOffense_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSpecificOffense.SelectedIndexChanged
        ToggleCustomOffenseField()
    End Sub

    Private Sub ToggleCustomOffenseField()
        Dim isOthers As Boolean = (cboSpecificOffense.SelectedItem IsNot Nothing AndAlso cboSpecificOffense.SelectedItem.ToString() = "Others")
        lblCustomOffense.Visible = isOthers
        txtCustomOffense.Visible = isOthers
        If Not isOthers Then
            txtCustomOffense.Clear()
        End If
    End Sub

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

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT student_id, last_name, first_name, middle_name, department, year_level " &
                                     "FROM students WHERE student_id = @sid LIMIT 1"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", sid)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtLastName.Text = Convert.ToString(reader("last_name"))
                            txtFirstName.Text = Convert.ToString(reader("first_name"))
                            txtMiddleName.Text = Convert.ToString(reader("middle_name"))
                            txtDepartment.Text = Convert.ToString(reader("department"))
                            txtYearLevel.Text = Convert.ToString(reader("year_level"))
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
        txtYearLevel.Clear()
    End Sub

    Private Sub btnAttachFiles_Click(sender As Object, e As EventArgs) Handles btnAttachFiles.Click
        Using dlg As New OpenFileDialog()
            dlg.Title = "Select Evidence / Proof Files"
            dlg.Multiselect = True
            dlg.Filter = "Evidence Files (*.jpg;*.jpeg;*.png;*.pdf;*.docx;*.xlsx)|*.jpg;*.jpeg;*.png;*.pdf;*.docx;*.xlsx|All Files (*.*)|*.*"

            If dlg.ShowDialog() = DialogResult.OK Then
                For Each filePath In dlg.FileNames
                    If stagedFiles.Count >= 5 Then
                        MessageBox.Show("You can attach up to 5 proof files per infraction.", "Attachment Limit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit For
                    End If
                    If Not stagedFiles.Contains(filePath) Then
                        stagedFiles.Add(filePath)
                        lstAttachments.Items.Add(Path.GetFileName(filePath))
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
        cboCategory.SelectedIndex = 0
        cboWarningLevel.SelectedIndex = 0
        txtCustomOffense.Clear()
        txtRemarks.Clear()
        stagedFiles.Clear()
        lstAttachments.Items.Clear()
        SetDefaultDateAndTime()
        UpdateSpecificOffensesForCategory()
    End Sub

    Private Sub btnSaveInfraction_Click(sender As Object, e As EventArgs) Handles btnSaveInfraction.Click
        Dim sid As String = txtStudentID.Text.Trim()
        If sid = "" Then
            MessageBox.Show("Please enter and verify a Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtLastName.Text.Trim() = "" AndAlso txtFirstName.Text.Trim() = "" Then
            LookupStudentRecord()
            If txtLastName.Text.Trim() = "" AndAlso txtFirstName.Text.Trim() = "" Then Return
        End If

        Dim category As String = cboCategory.SelectedItem.ToString()
        Dim selectedSpecific As String = cboSpecificOffense.SelectedItem.ToString()
        Dim customSpec As String = txtCustomOffense.Text.Trim()

        If selectedSpecific = "Others" AndAlso customSpec = "" Then
            MessageBox.Show("Please enter the specific offense under 'Others'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomOffense.Focus()
            Return
        End If

        ' Clean format without letter prefixes, e.g.: "Minor - Dress Code / Improper Uniform Compliance"
        Dim cleanOffenseLabel As String = If(selectedSpecific = "Others", customSpec, selectedSpecific)
        Dim formattedOffense As String = $"{category} - {cleanOffenseLabel}"

        Dim warningLvl As String = cboWarningLevel.SelectedItem.ToString()
        Dim sanctionType As String = cboSanction.SelectedItem.ToString()
        Dim incidentDate As String = txtIncidentDate.Text.Trim()
        Dim incidentTime As String = txtIncidentTime.Text.Trim()
        Dim remarks As String = txtRemarks.Text.Trim()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Auto-escalate to Major on 3rd accumulated active minor offense
                If category = "Minor" Then
                    Dim minorCountSql As String = "SELECT COUNT(*) FROM offense_logs WHERE student_id = @sid AND severity = 'Minor' AND record_status = 'Active'"
                    Using cmdCount As New MySqlCommand(minorCountSql, conn)
                        cmdCount.Parameters.AddWithValue("@sid", sid)
                        Dim existingMinors As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())
                        If existingMinors >= 2 Then
                            category = "Major"
                            formattedOffense = "Major - Third Accumulated Minor Offense (Automatic Escalation)"
                            warningLvl = "3rd Warning (Escalation)"
                            sanctionType = "Disciplinary Board Referral"
                            MessageBox.Show("Student already has 2 active minor offenses. This infraction has been escalated to a Major Offense.", "Auto-Escalation Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End If

                Dim insertOffenseSql As String = "INSERT INTO offense_logs " &
                    "(student_id, offense_type, custom_specification, severity, warning_level, incident_date, incident_time, remarks, record_status) " &
                    "VALUES (@sid, @offense, @custom, @sev, @warn, @idate, @itime, @remarks, 'Active'); " &
                    "SELECT LAST_INSERT_ID();"

                Dim newLogId As Integer = 0
                Using cmdInsert As New MySqlCommand(insertOffenseSql, conn)
                    cmdInsert.Parameters.AddWithValue("@sid", sid)
                    cmdInsert.Parameters.AddWithValue("@offense", formattedOffense)
                    cmdInsert.Parameters.AddWithValue("@custom", customSpec)
                    cmdInsert.Parameters.AddWithValue("@sev", category)
                    cmdInsert.Parameters.AddWithValue("@warn", warningLvl)
                    cmdInsert.Parameters.AddWithValue("@idate", incidentDate)
                    cmdInsert.Parameters.AddWithValue("@itime", incidentTime)
                    cmdInsert.Parameters.AddWithValue("@remarks", remarks)
                    newLogId = Convert.ToInt32(cmdInsert.ExecuteScalar())
                End Using

                Dim insertSanctionSql As String = "INSERT INTO sanctions (log_id, sanction_type, status) VALUES (@logId, @stype, 'Pending')"
                Using cmdSanction As New MySqlCommand(insertSanctionSql, conn)
                    cmdSanction.Parameters.AddWithValue("@logId", newLogId)
                    cmdSanction.Parameters.AddWithValue("@stype", sanctionType)
                    cmdSanction.ExecuteNonQuery()
                End Using

                If stagedFiles.Count > 0 Then
                    Dim insertAttachSql As String = "INSERT INTO offense_attachments (log_id, file_name, file_path, file_size_bytes) " &
                                                    "VALUES (@logId, @fname, @fpath, @fsize)"
                    For Each fullPath In stagedFiles
                        Dim info As New FileInfo(fullPath)
                        Using cmdAttach As New MySqlCommand(insertAttachSql, conn)
                            cmdAttach.Parameters.AddWithValue("@logId", newLogId)
                            cmdAttach.Parameters.AddWithValue("@fname", info.Name)
                            cmdAttach.Parameters.AddWithValue("@fpath", info.FullName)
                            cmdAttach.Parameters.AddWithValue("@fsize", If(info.Exists, info.Length, 0L))
                            cmdAttach.ExecuteNonQuery()
                        End Using
                    Next
                End If
            End Using

            MessageBox.Show("Student infraction and proof attachments saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnClearForm_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("Failed to save infraction: " & ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class