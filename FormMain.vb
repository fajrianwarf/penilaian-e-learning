Public Class FormMain
    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Hanya konfirmasi jika user yang menutup (klik X / Alt+F4 / Close)
        If e.CloseReason = CloseReason.UserClosing Then
            Dim result = MessageBox.Show(
            "Yakin ingin keluar dari aplikasi?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.No Then
                e.Cancel = True   ' batal tutup form
            End If
        End If
    End Sub


    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDashboard()
    End Sub

    Private Sub FormMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDashboard()
    End Sub

    Private Sub UpdateDashboard()
        lblJumlahSiswa.Text = Students.Count.ToString()
        lblJumlahMapel.Text = Courses.Count.ToString()

        Dim totalNilai As Double = 0
        Dim count As Integer = 0
        Dim jmlLulus As Integer = 0

        For Each g As GradeRecord In Grades
            totalNilai += g.NilaiAkhir
            count += 1
            If g.Status = "Lulus" Then
                jmlLulus += 1
            End If
        Next

        If count > 0 Then
            Dim rataRata As Double = totalNilai / count
            Dim persenLulus As Double = (jmlLulus * 100.0) / count

            lblJumlahPenilaian.Text = count.ToString()
            lblPersenLulus.Text = persenLulus.ToString("0.0") & " %"
        Else
            lblJumlahPenilaian.Text = "0"
            lblPersenLulus.Text = "- %"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show(
        "Yakin ingin keluar dari aplikasi?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub mnuTentang_Click(sender As Object, e As EventArgs) Handles mnuTentang.Click
        Dim msg As String = "Aplikasi Penilaian E-Learning" & Environment.NewLine &
                            "Dibuat untuk tugas UTS Pemrograman Visual." & Environment.NewLine & Environment.NewLine &
                            "Tips Debugging: pilih Yes untuk melihat panduan Watch Window & Breakpoints."

        Dim res = MessageBox.Show(msg,
                                 "Tentang Aplikasi",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Information)

        If res = DialogResult.Yes Then
            ShowDebuggingGuide()
        End If
    End Sub

    Private Sub OpenChildForm(child As Form)
        Me.Hide()
        child.StartPosition = FormStartPosition.CenterScreen
        child.ShowDialog()
        Me.Show()
    End Sub

    Private Sub mnuDataSiswa_Click(sender As Object, e As EventArgs) Handles mnuDataSiswa.Click
        OpenChildForm(New FormDataSiswa())
    End Sub

    Private Sub mnuDataMapel_Click(sender As Object, e As EventArgs) Handles mnuDataMapel.Click
        OpenChildForm(New FormDataMapel())
    End Sub

    Private Sub mnuInputNilai_Click(sender As Object, e As EventArgs) Handles mnuInputNilai.Click
        OpenChildForm(New FormInputNilai())
    End Sub

    Private Sub mnuRekapNilai_Click(sender As Object, e As EventArgs) Handles mnuRekapNilai.Click
        OpenChildForm(New FormRekapNilai())
    End Sub

    ' =============================
    ' SAVE / UPLOAD / PRINT DATA
    ' Tombol dan menu sudah disiapkan di designer:
    ' - saveData / SaveDataCSVToolStripMenuItem
    ' - uploadData / UploadDataCSVToolStripMenuItem
    ' - printAllData / PrintAllDataPDFToolStripMenuItem
    ' =============================

    Private Sub SaveData_Click(sender As Object, e As EventArgs) _
        Handles saveData.Click, SaveDataCSVToolStripMenuItem.Click

        Dim startedAt As DateTime = DateTime.Now

        Try
            Using dlg As New FolderBrowserDialog()
                dlg.Description = "Pilih folder untuk menyimpan data (CSV)"
                dlg.SelectedPath = AppStorage.GetDefaultDataDirectory()

                If dlg.ShowDialog(Me) <> DialogResult.OK Then Return

                Dim info As String = ""
                If DataPersistence.SaveAllToCsv(dlg.SelectedPath, info) Then
                    Dim elapsed As TimeSpan = DateTime.Now - startedAt
                    MessageBox.Show(
                        info & Environment.NewLine &
                        "Selesai dalam: " & elapsed.ToString("mm\:ss\.fff"),
                        "Save Data (CSV)",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi error saat menyimpan data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UploadData_Click(sender As Object, e As EventArgs) _
        Handles uploadData.Click, UploadDataCSVToolStripMenuItem.Click

        Dim startedAt As DateTime = DateTime.Now

        Try
            Using dlg As New FolderBrowserDialog()
                dlg.Description = "Pilih folder sumber data (CSV) untuk di-upload"
                dlg.SelectedPath = AppStorage.GetDefaultDataDirectory()

                If dlg.ShowDialog(Me) <> DialogResult.OK Then Return

                If MessageBox.Show(
                    "Upload akan menimpa data yang sedang ada di aplikasi." & Environment.NewLine &
                    "Lanjutkan?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) <> DialogResult.Yes Then
                    Return
                End If

                Dim info As String = ""
                If DataPersistence.LoadAllFromCsv(dlg.SelectedPath, info) Then
                    Dim elapsed As TimeSpan = DateTime.Now - startedAt
                    MessageBox.Show(
                        info & Environment.NewLine &
                        "Selesai dalam: " & elapsed.ToString("mm\:ss\.fff"),
                        "Upload Data (CSV)",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )
                    UpdateDashboard()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi error saat upload data: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintAllData_Click(sender As Object, e As EventArgs) _
        Handles printAllData.Click, PrintAllDataPDFToolStripMenuItem.Click

        Try
            If Students.Count = 0 AndAlso Courses.Count = 0 AndAlso Grades.Count = 0 Then
                MessageBox.Show("Tidak ada data untuk dicetak.", "Info")
                Return
            End If

            Dim doc As Printing.PrintDocument = ReportPrinting.CreatePrintDocument(Me)

            ' Preview dulu agar user dapat memilih Print to PDF jika dibutuhkan.
            Using preview As New PrintPreviewDialog()
                preview.Document = doc
                preview.WindowState = FormWindowState.Maximized
                preview.ShowDialog(Me)
            End Using

        Catch ex As Exception
            MessageBox.Show("Terjadi error saat print: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===== Panduan Debugging (Watch / Breakpoints) =====
    ' Poin ini memang tidak "mengubah" aplikasi, tetapi disediakan sebagai panduan
    ' untuk memenuhi checklist materi.
    Private Sub ShowDebuggingGuide()
        Dim guide As String = DebugGuide.GetGuideText()
        MessageBox.Show(guide, "Panduan Debugging (Watch & Breakpoints)", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
