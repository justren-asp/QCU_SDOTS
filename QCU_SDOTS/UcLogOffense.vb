Imports MySql.Data.MySqlClient

Public Class UcLogOffense

    Private isStudentFound As Boolean = False

    Private Sub UcLogOffense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDropdowns()
        rbMinor.Checked = True
    End Sub

    Private Sub InitDropdowns()
        If cboOffenseCategory.Items.Count = 0 Then
            cboOffenseCategory.Items.AddRange(New Object() {
                "Uniform Violation",
                "ID Not Visible / No ID",
                "Disorderly Behavior",
                "Vandalism",
                "Cheating / Academic Dishonesty",
                "Smoking / Vaping within Campus",
                "Bullying / Harassment"
            })
            cboOffenseCategory.SelectedIndex = 0
        End If

        If cboDepartment.Items.Count = 0 Then
            cboDepartment.Items.AddRange(New Object() {
                "CCS", "CBA", "CE", "CAS"
            })
            cboDepartment.SelectedIndex = 0
        End If

        If cboYearLevel.Items.Count = 0 Then
            cboYearLevel.Items.AddRange(New Object() {
                "BSIT - 1A", "BSIT - 1B", "BSIT - 2A", "BSIT - 2B", "BSIT - 3A", "BSIT - 3B", "BSIT - 4A", "BSIT - 4B",
                "BSCS - 1A", "BSCS - 2A", "BSCS - 3A", "BSCS - 4A"
            })
            cboYearLevel.SelectedIndex = 0
        End If

        If cboSanction.Items.Count = 0 Then
            cboSanction.Items.AddRange(New Object() {
                "Written Warning / Reprimand",
                "Community Service (5 Hours)",
                "Community Service (10 Hours)",
                "Parent Conference / Disciplinary Hearing",
                "Suspension (3 Days)"
            })
            cboSanction.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnFindStudent_Click(sender As Object, e As EventArgs) Handles btnFindStudent.Click
        Dim id As String = txtStudentID.Text.Trim()

        If id = "" Then
            MessageBox.Show("Please enter a Student ID.", "Search Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim sql As String = "SELECT first_name, last_name, department, course, year_section FROM students WHERE student_id = @id LIMIT 1"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", id)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtFullName.Text = dr("first_name").ToString() & " " & dr("last_name").ToString()

                            Dim dept As String = dr("department").ToString()
                            If cboDepartment.Items.Contains(dept) Then
                                cboDepartment.SelectedItem = dept
                            Else
                                cboDepartment.Text = dept
                            End If

                            Dim ySec As String = dr("course").ToString() & " - " & dr("year_section").ToString()
                            If cboYearLevel.Items.Contains(ySec) Then
                                cboYearLevel.SelectedItem = ySec
                            Else
                                cboYearLevel.Text = ySec
                            End If

                            isStudentFound = True
                        Else
                            MessageBox.Show("Student ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ResetStudentInfo()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not isStudentFound Then
            MessageBox.Show("Please select a valid student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNarrative.Text.Trim() = "" Then
            MessageBox.Show("Please enter an incident description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sev As String = "Minor"
        If rbMajor.Checked Then sev = "Major"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sqlOffense As String = "INSERT INTO offense_logs (student_id, offense_type, severity, description, reported_by) " &
                                           "VALUES (@id, @offense, @sev, @desc, @user); SELECT LAST_INSERT_ID();"

                Dim logID As Integer = 0
                Using cmd As New MySqlCommand(sqlOffense, conn)
                    cmd.Parameters.AddWithValue("@id", txtStudentID.Text.Trim())
                    cmd.Parameters.AddWithValue("@offense", cboOffenseCategory.Text)
                    cmd.Parameters.AddWithValue("@sev", sev)
                    cmd.Parameters.AddWithValue("@desc", txtNarrative.Text.Trim())
                    cmd.Parameters.AddWithValue("@user", LoginForm.CurrentUserID)

                    logID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                Dim sqlSanction As String = "INSERT INTO sanctions (log_id, sanction_type, status) VALUES (@log_id, @type, 'Pending')"
                Using cmdSanction As New MySqlCommand(sqlSanction, conn)
                    cmdSanction.Parameters.AddWithValue("@log_id", logID)
                    cmdSanction.Parameters.AddWithValue("@type", cboSanction.Text)
                    cmdSanction.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Offense record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetAllFields()

        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        ResetAllFields()
    End Sub

    Private Sub ResetStudentInfo()
        txtStudentID.Clear()
        txtFullName.Clear()
        If cboDepartment.Items.Count > 0 Then cboDepartment.SelectedIndex = 0
        If cboYearLevel.Items.Count > 0 Then cboYearLevel.SelectedIndex = 0
        isStudentFound = False
    End Sub

    Private Sub ResetAllFields()
        ResetStudentInfo()
        txtNarrative.Clear()
        If cboOffenseCategory.Items.Count > 0 Then cboOffenseCategory.SelectedIndex = 0
        If cboSanction.Items.Count > 0 Then cboSanction.SelectedIndex = 0
        rbMinor.Checked = True
    End Sub

End Class