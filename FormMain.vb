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
        MessageBox.Show("Aplikasi Penilaian E-Learning" & Environment.NewLine &
                        "Dibuat untuk tugas UTS Pemrograman Visual.",
                        "Tentang Aplikasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
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

End Class
