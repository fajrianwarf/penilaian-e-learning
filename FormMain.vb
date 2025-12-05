Public Class FormMain

    ' Saat form pertama kali dibuka
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDashboard()
    End Sub

    ' Saat form kembali aktif setelah form lain ditutup
    Private Sub FormMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDashboard()
    End Sub

    Private Sub UpdateDashboard()
        lblJumlahSiswa.Text = Students.Count.ToString()
        lblJumlahMapel.Text = Courses.Count.ToString()
    End Sub

    ' ==== MENU EVENTS ====

    Private Sub mnuDataSiswa_Click(sender As Object, e As EventArgs) Handles mnuDataSiswa.Click
        Dim f As New FormDataSiswa()
        f.ShowDialog()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Me.Close()
    End Sub

    Private Sub mnuTentang_Click(sender As Object, e As EventArgs) Handles mnuTentang.Click
        MessageBox.Show("Aplikasi Penilaian E-Learning" & Environment.NewLine &
                        "Dibuat untuk tugas Praktikum Visual.",
                        "Tentang Aplikasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuDataMapel_Click(sender As Object, e As EventArgs) Handles mnuDataMapel.Click
        Dim f As New FormDataMapel()
        f.ShowDialog()
    End Sub


    ' mnuDataMapel, mnuInputNilai, mnuRekapNilai
    ' nanti dipakai saat screen lain sudah kamu buat
End Class
