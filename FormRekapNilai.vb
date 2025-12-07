Public Class FormRekapNilai

    Private Sub FormRekapNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFilters()
        LoadRekap()
    End Sub

    Private Sub LoadFilters()
        ' isi filter kelas dari data siswa
        cboFilterKelas.Items.Clear()
        cboFilterKelas.Items.Add("Semua")

        For Each s As Student In Students
            Dim k As String = s.Kelas
            Dim sudahAda As Boolean = False
            For Each item In cboFilterKelas.Items
                If item.ToString() = k Then
                    sudahAda = True
                    Exit For
                End If
            Next
            If Not sudahAda AndAlso k <> "" Then
                cboFilterKelas.Items.Add(k)
            End If
        Next

        ' isi filter mapel dari data course
        cboFilterMapel.Items.Clear()
        cboFilterMapel.Items.Add("Semua")

        For Each c As Course In Courses
            Dim nama As String = c.Nama
            Dim sudahAda As Boolean = False
            For Each item In cboFilterMapel.Items
                If item.ToString() = nama Then
                    sudahAda = True
                    Exit For
                End If
            Next
            If Not sudahAda AndAlso nama <> "" Then
                cboFilterMapel.Items.Add(nama)
            End If
        Next

        If cboFilterKelas.Items.Count > 0 Then cboFilterKelas.SelectedIndex = 0
        If cboFilterMapel.Items.Count > 0 Then cboFilterMapel.SelectedIndex = 0
    End Sub

    Private Sub LoadRekap()
        dgvRekap.Rows.Clear()

        Dim filterKelas As String = cboFilterKelas.Text
        Dim filterMapel As String = cboFilterMapel.Text

        Dim totalNilai As Double = 0
        Dim count As Integer = 0
        Dim jmlLulus As Integer = 0
        Dim jmlTidakLulus As Integer = 0

        For Each g As GradeRecord In Grades

            Dim lolosKelas As Boolean = (filterKelas = "Semua" OrElse g.Kelas = filterKelas)
            Dim lolosMapel As Boolean = (filterMapel = "Semua" OrElse g.NamaMapel = filterMapel)

            If lolosKelas AndAlso lolosMapel Then
                dgvRekap.Rows.Add(
                    g.NamaSiswa,
                    g.Kelas,
                    g.NamaMapel,
                    g.NilaiAkhir.ToString("0.00"),
                    g.Grade.ToString(),
                    g.Status
                )

                totalNilai += g.NilaiAkhir
                count += 1

                If g.NilaiAkhir >= NilaiMinimalLulus Then
                    jmlLulus += 1
                Else
                    jmlTidakLulus += 1
                End If
            End If
        Next

        If count > 0 Then
            txtRataRata.Text = (totalNilai / count).ToString("0.00")
        Else
            txtRataRata.Text = "-"
        End If

        txtJmlLulus.Text = jmlLulus.ToString()
        txtJmlTdkLulus.Text = jmlTidakLulus.ToString()
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        LoadRekap()
    End Sub

    Private Sub btnDetailSiswa_Click(sender As Object, e As EventArgs) Handles btnDetailSiswa.Click
        If dgvRekap.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih salah satu baris siswa terlebih dahulu.", "Informasi")
            Return
        End If

        Dim namaSiswa As String = dgvRekap.CurrentRow.Cells(0).Value?.ToString()
        If String.IsNullOrWhiteSpace(namaSiswa) Then
            MessageBox.Show("Nama siswa tidak valid.", "Error")
            Return
        End If

        If Not Grades.Any(Function(gr) gr.NamaSiswa = namaSiswa) Then
            MessageBox.Show("Siswa ini belum memiliki data nilai.", "Informasi")
            Return
        End If

        Dim dlg As New FormDetailSiswa()
        dlg.SelectedNamaSiswa = namaSiswa
        dlg.ShowDialog()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
