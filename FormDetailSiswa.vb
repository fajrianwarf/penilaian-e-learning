Public Class FormDetailSiswa

    Public Property SelectedNamaSiswa As String   ' di-set dari FormRekapNilai

    Private Sub FormDetailSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrWhiteSpace(SelectedNamaSiswa) Then
            Me.Close()
            Return
        End If

        Me.Text = "Detail Nilai - " & SelectedNamaSiswa
        lblNama.Text = SelectedNamaSiswa

        LoadDetail()
    End Sub

    Private Sub LoadDetail()
        dgvDetailNilai.Rows.Clear()

        Dim totalNilai As Double = 0
        Dim count As Integer = 0
        Dim gradeTerbaik As GradeHuruf = GradeHuruf.E
        Dim kelasPertama As String = ""

        For Each g As GradeRecord In Grades
            If g.NamaSiswa = SelectedNamaSiswa Then

                dgvDetailNilai.Rows.Add(
                    g.NamaMapel,
                    g.NilaiAkhir.ToString("0.00"),
                    g.Grade.ToString(),
                    g.Status
                )

                totalNilai += g.NilaiAkhir
                count += 1

                ' simpan kelas dari record pertama
                If kelasPertama = "" Then
                    kelasPertama = g.Kelas
                End If

                ' grade terbaik: A (0) lebih baik dari B (1), dst
                If g.Grade < gradeTerbaik Then
                    gradeTerbaik = g.Grade
                End If
            End If
        Next

        lblKelas.Text = If(String.IsNullOrEmpty(kelasPertama), "-", kelasPertama)

        If count > 0 Then
            txtRataRata.Text = (totalNilai / count).ToString("0.00")
            txtGradeTertinggi.Text = gradeTerbaik.ToString()
        Else
            txtRataRata.Text = "-"
            txtGradeTertinggi.Text = "-"
        End If

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class
