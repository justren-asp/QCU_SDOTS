Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class UcClearanceGenerator

    Private isStudentVerified As Boolean = False
    Private isStudentCleared As Boolean = False
    Private verifiedStudentId As String = ""
    Private verifiedStudentFullName As String = ""
    Private verifiedDepartment As String = ""
    Private isFormattingStudentId As Boolean = False

    Private Sub UcClearanceGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblTitle.UseMnemonic = False
            AdjustLayoutForHostedHeader()
            PopulateDropdowns()
            CopySealLogoIfAvailable()
            CenterCertificateHeader()
            lblCertDateVal.Text = DateTime.Now.ToString("MMMM dd, yyyy")
            UpdateCertificatePreview()
        Catch ex As Exception
            MessageBox.Show("Failed to initialize Clearance Generator: " & ex.Message, "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Pulls top-level panels up when hosted inside MainDashboardForm so no blank gap appears
    Private Sub AdjustLayoutForHostedHeader()
        If panelHeader Is Nothing OrElse panelHeader.Visible Then Return

        Const headerOffset As Integer = 74
        For Each ctrl As Control In Me.Controls
            If ctrl IsNot panelHeader Then
                ctrl.Top = Math.Max(14, ctrl.Top - headerOffset)
                If (ctrl.Anchor And AnchorStyles.Bottom) = AnchorStyles.Bottom Then
                    ctrl.Height += headerOffset
                End If
            End If
        Next
    End Sub

    Private Sub panelCertificateSheet_Resize(sender As Object, e As EventArgs) Handles panelCertificateSheet.Resize
        CenterCertificateHeader()
    End Sub

    ' Centers the logo and certificate header block horizontally inside the certificate sheet
    Private Sub CenterCertificateHeader()
        If panelCertificateSheet Is Nothing OrElse panelCertificateSheet.ClientSize.Width <= 0 Then Return
        Dim centerX As Integer = panelCertificateSheet.ClientSize.Width \ 2

        picCertSeal.Left = centerX - (picCertSeal.Width \ 2)
        lblCertUnivName.Left = centerX - (lblCertUnivName.Width \ 2)
        lblCertSubOrg.Left = centerX - (lblCertSubOrg.Width \ 2)
        lblCertHeading.Left = centerX - (lblCertHeading.Width \ 2)
    End Sub

    ' Populates clearance purposes and temporary member signatories
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
            "Justine Renz Velasco - Temporary Reviewing Officer",
            "Jairus Gad Meneses - Temporary Reviewing Officer",
            "Ravi Garcia - Temporary Reviewing Officer",
            "Aaron Cuadra - Temporary Reviewing Officer"
        })
        cboSigningAuthority.SelectedIndex = 0
    End Sub

    ' Owner-draws dropdown items to match the shared navy selection highlight
    Private Sub ModernCombo_DrawItem(sender As Object, e As DrawItemEventArgs) Handles _
        cboPurpose.DrawItem, cboSigningAuthority.DrawItem

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

    ' Loads the QCU seal from open forms or local image files if available
    Private Sub CopySealLogoIfAvailable()
        Try
            For Each frm As Form In Application.OpenForms
                Dim pb As PictureBox = TryCast(frm.Controls.Find("PictureBox1", True).FirstOrDefault(), PictureBox)
                If pb IsNot Nothing AndAlso pb.Image IsNot Nothing Then
                    picCertSeal.Image = New Bitmap(pb.Image)
                    Return
                End If
            Next

            Dim candidatePaths As String() = {
                Path.Combine(Application.StartupPath, "qcu_logo.png"),
                Path.Combine(Application.StartupPath, "qcu_logo.jpg"),
                Path.Combine(Application.StartupPath, "Resources", "qcu_logo.png")
            }

            For Each imgPath As String In candidatePaths
                If File.Exists(imgPath) Then
                    Using tempImg As Image = Image.FromFile(imgPath)
                        picCertSeal.Image = New Bitmap(tempImg)
                    End Using
                    Return
                End If
            Next
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Seal logo copy skipped: " & ex.Message)
        End Try
    End Sub

    ' Blocks non-digit keystrokes except control/navigation keys
    Private Sub txtStudentIDInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentIDInput.KeyPress
        If Char.IsControl(e.KeyChar) Then Return
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Enforces strict 00-0000 format (digits only, hyphen after first 2 digits)
    Private Sub txtStudentIDInput_TextChanged(sender As Object, e As EventArgs) Handles txtStudentIDInput.TextChanged
        If isFormattingStudentId Then Return

        isFormattingStudentId = True
        Dim digitsOnly As New StringBuilder()
        For Each ch As Char In txtStudentIDInput.Text
            If Char.IsDigit(ch) Then
                digitsOnly.Append(ch)
                If digitsOnly.Length = 6 Then Exit For
            End If
        Next

        Dim rawDigits As String = digitsOnly.ToString()
        Dim formatted As String = If(rawDigits.Length > 2,
                                     rawDigits.Substring(0, 2) & "-" & rawDigits.Substring(2),
                                     rawDigits)

        If txtStudentIDInput.Text <> formatted Then
            txtStudentIDInput.Text = formatted
            txtStudentIDInput.SelectionStart = formatted.Length
        End If
        isFormattingStudentId = False
    End Sub

    Private Function IsValidStudentIdFormat(sid As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(sid, "^\d{2}-\d{4}$")
    End Function

    Private Sub btnVerifyStudent_Click(sender As Object, e As EventArgs) Handles btnVerifyStudent.Click
        VerifyStudentStanding()
    End Sub

    Private Sub txtStudentIDInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentIDInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            VerifyStudentStanding()
        End If
    End Sub

    ' Queries student profile and checks for active/uncleared disciplinary items
    Private Sub VerifyStudentStanding()
        Dim sid As String = txtStudentIDInput.Text.Trim()
        If sid = "" Then
            MessageBox.Show("Please enter a Student ID in 00-0000 format.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidStudentIdFormat(sid) Then
            MessageBox.Show("Student ID must follow the 00-0000 format (numbers only).", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    ' Updates status card colors and text for approved vs. on-hold standing
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

    ' Refreshes certificate preview fields from current selection and verification state
    Private Sub UpdateCertificatePreview()
        Dim purposeText As String = If(cboPurpose.SelectedItem IsNot Nothing, cboPurpose.SelectedItem.ToString(), "Graduation Requirement")
        Dim authorityText As String = If(cboSigningAuthority.SelectedItem IsNot Nothing, cboSigningAuthority.SelectedItem.ToString(), "Justine Renz Velasco - Temporary Reviewing Officer")

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