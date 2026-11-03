Imports MySql.Data.MySqlClient

Public Class UcLogOffense

    Private isStudentFound As Boolean = False

    Private Sub UcLogOffense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default selections if items exist
        If cboOffenseCategory.Items.Count > 0 Then cboOffenseCategory.SelectedIndex = 0
        If cboDepartment.Items.Count > 0 Then cboDepartment.SelectedIndex = 0
        If cboYearLevel.Items.Count > 0 Then cboYearLevel.SelectedIndex = 0
        If cboSanction.Items.Count > 0 Then cboSanction.SelectedIndex = 0

        rbMinor.Checked = True
    End Sub

    ' 1. Search Student by ID and populate Info Panel
    Private Sub btnFindStudent_Click(sender As Object, e As EventArgs) Handles btnFindStudent.Click
        Dim studentID As String = txtStudentID.Text.Trim()

        If String.IsNullOrEmpty(studentID) Then
            MessageBox.Show("Please enter a Student ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT first_name, last_name, department, course, year_section FROM students WHERE student_id = @id LIMIT 1"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", studentID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate Full Name
                            txtFullName.Text = $"{reader("first_name")} {reader("last_name")}"

                            ' Populate Department ComboBox
                            Dim dept As String = reader("department").ToString()
                            If cboDepartment.Items.Contains(dept) Then
                                cboDepartment.SelectedItem = dept
                            Else
                                cboDepartment.Text = dept
                            End If

                            ' Populate Year Level ComboBox
                            Dim yearSec As String = $"{reader("course")} - {reader("year_section")}"
                            If cboYearLevel.Items.Contains(yearSec) Then
                                cboYearLevel.SelectedItem = yearSec
                            Else
                                cboYearLevel.Text = yearSec
                            End If

                            isStudentFound = True
                        Else
                            MessageBox.Show("Student ID not found in database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ClearStudentFields()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 2. Save Offense Log and Sanction to Database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not isStudentFound Then
            MessageBox.Show("Please search and verify a valid student ID first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNarrative.Text) Then
            MessageBox.Show("Please enter incident narrative remarks.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Determine Severity Level
        Dim severity As String = "Minor"
        If rbMajor.Checked Then severity = "Major"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Step A: Insert into offense_logs and capture generated log_id
                Dim queryOffense As String = "INSERT INTO offense_logs (student_id, offense_type, severity, description, reported_by) " &
                                             "VALUES (@student_id, @offense_type, @severity, @description, @reported_by); " &
                                             "SELECT LAST_INSERT_ID();"

                Dim newLogID As Integer = 0
                Using cmdOffense As New MySqlCommand(queryOffense, conn)
                    cmdOffense.Parameters.AddWithValue("@student_id", txtStudentID.Text.Trim())
                    cmdOffense.Parameters.AddWithValue("@offense_type", cboOffenseCategory.Text)
                    cmdOffense.Parameters.AddWithValue("@severity", severity)
                    cmdClearParameters(cmdOffense, "@description", txtNarrative.Text.Trim())
                    cmdOffense.Parameters.AddWithValue("@reported_by", LoginForm.CurrentUserID) ' Linked to active login session

                    newLogID = Convert.ToInt32(cmdOffense.ExecuteScalar())
                End Using

                ' Step B: Insert corresponding record into sanctions table
                Dim selectedSanction As String = If(cboSanction.SelectedItem IsNot Nothing, cboSanction.SelectedItem.ToString(), "Written Warning / Reprimand")

                Dim querySanction As String = "INSERT INTO sanctions (log_id, sanction_type, status) VALUES (@log_id, @sanction_type, 'Pending')"
                Using cmdSanction As New MySqlCommand(querySanction, conn)
                    cmdSanction.Parameters.AddWithValue("@log_id", newLogID)
                    cmdSanction.Parameters.AddWithValue("@sanction_type", selectedSanction)
                    cmdSanction.ExecuteNonQuery()
                End Using

            End Using

            MessageBox.Show("Student infraction and sanction recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFormFields()

        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper to safely add parameters avoiding duplicates
    Private Sub cmdClearParameters(cmd As MySqlCommand, paramName As String, value As String)
        cmd.Parameters.AddWithValue(paramName, value)
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        ClearFormFields()
    End Sub

    Private Sub ClearStudentFields()
        txtFullName.Clear()
        If cboDepartment.Items.Count > 0 Then cboDepartment.SelectedIndex = 0
        If cboYearLevel.Items.Count > 0 Then cboYearLevel.SelectedIndex = 0
        isStudentFound = False
    End Sub

    Private Sub ClearFormFields()
        txtStudentID.Clear()
        ClearStudentFields()
        txtNarrative.Clear()
        If cboOffenseCategory.Items.Count > 0 Then cboOffenseCategory.SelectedIndex = 0
        If cboSanction.Items.Count > 0 Then cboSanction.SelectedIndex = 0
        rbMinor.Checked = True
    End Sub

End Class