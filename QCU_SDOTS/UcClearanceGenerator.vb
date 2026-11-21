Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class UcClearanceGenerator

    Private isStudentVerified As Boolean = False
    Private isStudentCleared As Boolean = False
    Private verifiedStudentId As String = ""
    Private verifiedStudentFullName As String = ""
    Private verifiedDepartment As String = ""

    Private Sub UcClearanceGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDropdowns()
        CopySealLogoIfAvailable()
        lblCertDateVal.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        UpdateCertificatePreview()
    End Sub

    Private Sub PopulateDropdowns()
        cboPurpose.Items.Clear()
        cboPurpose.Items.AddRange(New Object() {
            "Graduation Requirement",
            "Enrollment / Shifting",
            "Scholarship / Financial Aid",
            "Transfer / Honorable Dismissal",
            "Good Moral / Employment"
        })
        cboPurpose.SelectedIndex = 0

        cboSigningAuthority.Items.Clear()
        cboSigningAuthority.Items.AddRange(New Object() {
            "Dr. Maria R. Dela Cruz - Director of Student Affairs",
            "Atty. Ramon S. Mendoza - Head, Discipline Unit",
            "Prof. Elena G. Santos - Dean of Student Services"
        })
        cboSigningAuthority.SelectedIndex = 0
    End Sub

    Private Sub CopySealLogoIfAvailable()
        Dim loginForm = Application.OpenForms.OfType(Of LoginForm)().FirstOrDefault()
        If loginForm IsNot Nothing AndAlso loginForm.PictureBox1 IsNot Nothing AndAlso loginForm.PictureBox1.Image IsNot Nothing Then
            picCertSeal.Image = loginForm.PictureBox1.Image
        End If
    End Sub

    Private Sub btnVerifyStudent_Click(sender As Object, e As EventArgs) Handles btnVerifyStudent.Click
        VerifyStudentStanding()
    End Sub

    Private Sub txtStudentIDInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentIDInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            VerifyStudentStanding()
        End If
    End Sub

    Private Sub VerifyStudentStanding()
        Dim sid As String = txtStudentIDInput.Text.Trim()
        If sid = "" Then
            MessageBox.Show("Please enter a Student ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim studentSql As String = "SELECT student_id, " &
                                         "TRIM(CONCAT(first_name, ' ', COALESCE(NULLIF(middle_name, ''), ''), ' ', last_name)) AS full_name, " &
                                         "department, record_status " &
                                         "FROM students WHERE student_id = @sid LIMIT 1"

                Using cmdStudent As New MySqlCommand(studentSql, conn)
                    cmdStudent.Parameters.AddWithValue("@sid", sid)
                    Using reader As MySqlDataReader = cmdStudent.ExecuteReader()
                        If Not reader.Read() Then
                            isStudentVerified = False
                            isStudentCleared = False
                            SetStatusPanel(False, "STUDENT NOT FOUND",
                                           $"No student record found for ID '{sid}'. Please verify the Student ID and try again.")
                            UpdateCertificatePreview()
                            Return
                        End If

                        verifiedStudentId = Convert.ToString(reader("student_id"))
                        verifiedStudentFullName = Convert.ToString(reader("full_name")).Replace("  ", " ")
                        verifiedDepartment = Convert.ToString(reader("department"))
                    End Using
                End Using

                ' Check active offense logs or pending/escalated/overdue sanctions
                Dim pendingSql As String = "SELECT COUNT(*) FROM offense_logs o " &
                                         "LEFT JOIN sanctions sn ON o.log_id = sn.log_id " &
                                         "WHERE o.student_id = @sid AND o.record_status = 'Active' " &
                                         "AND (sn.status IS NULL OR sn.status <> 'Cleared')"

                Dim pendingCount As Integer = 0
                Using cmdCheck As New MySqlCommand(pendingSql, conn)
                    cmdCheck.Parameters.AddWithValue("@sid", verifiedStudentId)
                    pendingCount = Convert.ToInt32(cmdCheck.ExecuteScalar())
                End Using

                isStudentVerified = True
                If pendingCount = 0 Then
                    isStudentCleared = True
                    SetStatusPanel(True, "CLEARANCE STATUS: APPROVED",
                                   $"This student ({verifiedStudentFullName}) has zero active or pending disciplinary records. Eligible to print.")
                Else
                    isStudentCleared = False
                    SetStatusPanel(False, "CLEARANCE STATUS: ON HOLD",
                                   $"This student ({verifiedStudentFullName}) has {pendingCount} active/pending disciplinary item(s) on record. Clearance requires resolution.")
                End If

                UpdateCertificatePreview()
            End Using
        Catch ex As Exception
            MessageBox.Show("Verification failed: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetStatusPanel(approved As Boolean, badgeText As String, bodyText As String)
        lblStatusBadge.Text = If(approved, "✓ " & badgeText, "⚠ " & badgeText)
        lblStatusBody.Text = bodyText

        If approved Then
            panelStatusCard.BackColor = Color.FromArgb(240, 253, 244)
            lblStatusBadge.ForeColor = Color.FromArgb(21, 128, 61)
            lblStatusBody.ForeColor = Color.FromArgb(22, 101, 52)
        Else
            panelStatusCard.BackColor = Color.FromArgb(254, 242, 242)
            lblStatusBadge.ForeColor = Color.FromArgb(185, 28, 28)
            lblStatusBody.ForeColor = Color.FromArgb(153, 27, 27)
        End If
    End Sub

    Private Sub cboPurpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPurpose.SelectedIndexChanged
        UpdateCertificatePreview()
    End Sub

    Private Sub cboSigningAuthority_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSigningAuthority.SelectedIndexChanged
        UpdateCertificatePreview()
    End Sub

    Private Sub btnGeneratePrintQueue_Click(sender As Object, e As EventArgs) Handles btnGeneratePrintQueue.Click
        If Not isStudentVerified Then
            MessageBox.Show("Please verify a Student ID first before generating the print queue.", "Verify Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        UpdateCertificatePreview()
        MessageBox.Show($"Clearance certificate queued for {verifiedStudentFullName} ({verifiedStudentId}).", "Print Queue Ready", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UpdateCertificatePreview()
        Dim purposeText As String = If(cboPurpose.SelectedItem IsNot Nothing, cboPurpose.SelectedItem.ToString(), "Graduation Requirement")
        Dim authorityText As String = If(cboSigningAuthority.SelectedItem IsNot Nothing, cboSigningAuthority.SelectedItem.ToString(), "Dr. Maria R. Dela Cruz - Director of Student Affairs")

        lblCertPurposeVal.Text = purposeText
        lblCertDateVal.Text = DateTime.Now.ToString("MMMM dd, yyyy")

        Dim parts = authorityText.Split(New String() {" - "}, StringSplitOptions.None)
        If parts.Length >= 2 Then
            lblCertSignatoryName.Text = parts(0).Trim() & Environment.NewLine & parts(1).Trim()
        Else
            lblCertSignatoryName.Text = authorityText
        End If

        If isStudentVerified Then
            lblCertBody1.Text = $"This is to certify that {verifiedStudentFullName}, with Student Identification Number {verifiedStudentId} ({verifiedDepartment}), has undergone a disciplinary verification review."

            If isStudentCleared Then
                lblCertBody2.Text = $"As of {lblCertDateVal.Text}, the student has no pending disciplinary sanctions on record and is hereby granted disciplinary clearance for {purposeText}."
            Else
                lblCertBody2.Text = $"As of {lblCertDateVal.Text}, disciplinary verification indicates pending/active record items requiring clearance review prior to final release."
            End If
        End If
    End Sub

    Private Sub btnPrintDocument_Click(sender As Object, e As EventArgs) Handles btnPrintDocument.Click
        If Not isStudentVerified Then
            MessageBox.Show("Please verify a Student ID first.", "Nothing to Print", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not isStudentCleared Then
            Dim confirmPrint = MessageBox.Show("This student currently has pending/active disciplinary records. Do you still want to open the print preview?", "Pending Records Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmPrint = DialogResult.No Then Return
        End If

        Using printDoc As New PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintCertificatePage
            Using previewDlg As New PrintPreviewDialog()
                previewDlg.Document = printDoc
                previewDlg.WindowState = FormWindowState.Maximized
                previewDlg.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub PrintCertificatePage(sender As Object, e As PrintPageEventArgs)
        Using bmp As New Bitmap(panelCertificateSheet.Width, panelCertificateSheet.Height)
            panelCertificateSheet.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
            e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        End Using
    End Sub

End Class