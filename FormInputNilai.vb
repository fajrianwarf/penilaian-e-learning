Public Class FormInputNilai

    Private Sub FormInputNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombos()
        ResetForm()
    End Sub

    Private Sub LoadCombos()
        ' isi combo siswa dari list Students
        cboSiswa.Items.Clear()
        For Each s As Student In Students
            ' tampilkan "NIS - Nama"
            cboSiswa.Items.Add(s.NIS & " - " & s.Nama)
        Next

        ' isi combo mapel dari list Courses
        cboMapel.Items.Clear()
        For Each c As Course In Courses
            ' tampilkan "Kode - Nama"
            cboMapel.Items.Add(c.Kode & " - " & c.Nama)
        Next

        If cboSiswa.Items.Count > 0 Then cboSiswa.SelectedIndex = 0
        If cboMapel.Items.Count > 0 Then cboMapel.SelectedIndex = 0
    End Sub

    Private Sub ResetForm()
        numTugas.Value = 0
        numQuiz.Value = 0
        numUTS.Value = 0
        numUAS.Value = 0
        txtNilaiAkhir.Clear()
        txtGrade.Clear()
        txtStatus.Clear()
    End Sub

    Private Function HitungGrade(nilai As Double) As GradeHuruf
        If nilai >= 85 Then
            Return GradeHuruf.A
        ElseIf nilai >= 75 Then
            Return GradeHuruf.B
        ElseIf nilai >= 65 Then
            Return GradeHuruf.C
        ElseIf nilai >= 55 Then
            Return GradeHuruf.D
        Else
            Return GradeHuruf.E
        End If
    End Function

    ' ========== BUTTON HITUNG ==========
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If cboSiswa.Items.Count = 0 Or cboMapel.Items.Count = 0 Then
            MessageBox.Show("Data siswa dan mata pelajaran belum ada.", "Perhatian")
            Return
        End If

        ' ambil nilai dari NumericUpDown
        Dim tugas As Double = CDbl(numTugas.Value)
        Dim quiz As Double = CDbl(numQuiz.Value)
        Dim uts As Double = CDbl(numUTS.Value)
        Dim uas As Double = CDbl(numUAS.Value)

        ' perhitungan dengan operator aritmatika
        Dim nilaiAkhir As Double
        nilaiAkhir = tugas * BobotTugas _
                     + quiz * BobotQuiz _
                     + uts * BobotUTS _
                     + uas * BobotUAS

        Dim grade As GradeHuruf = HitungGrade(nilaiAkhir)
        Dim status As String
        If nilaiAkhir >= NilaiMinimalLulus Then
            status = "Lulus"
        Else
            status = "Tidak Lulus"
        End If

        txtNilaiAkhir.Text = nilaiAkhir.ToString("0.00")
        txtGrade.Text = grade.ToString()
        txtStatus.Text = status

        MessageBox.Show("Perhitungan nilai berhasil.", "Informasi")
    End Sub

    ' ========== BUTTON SIMPAN ==========
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(txtNilaiAkhir.Text) Then
            MessageBox.Show("Hitung nilai terlebih dahulu sebelum menyimpan.", "Perhatian")
            Return
        End If

        ' ambil nama siswa dan kelas dari list Students berdasarkan pilihan combo
        Dim namaCombo As String = cboSiswa.Text  ' contoh: "12345 - Budi"
        Dim nisDipilih As String = ""
        Dim namaDipilih As String = ""
        Dim posStrip As Integer = namaCombo.IndexOf("-"c)
        If posStrip > 0 Then
            nisDipilih = namaCombo.Substring(0, posStrip).Trim()
            namaDipilih = namaCombo.Substring(posStrip + 1).Trim()
        End If

        Dim kelasDipilih As String = ""
        For Each s As Student In Students
            If s.NIS = nisDipilih Then
                kelasDipilih = s.Kelas
                Exit For
            End If
        Next

        ' ambil nama mapel dari combo
        Dim mapelCombo As String = cboMapel.Text  ' contoh: "MTK - Matematika"
        Dim namaMapel As String = mapelCombo
        posStrip = mapelCombo.IndexOf("-"c)
        If posStrip > 0 Then
            namaMapel = mapelCombo.Substring(posStrip + 1).Trim()
        End If

        Dim rec As New GradeRecord()
        rec.NamaSiswa = namaDipilih
        rec.Kelas = kelasDipilih
        rec.NamaMapel = namaMapel
        rec.NilaiTugas = CDbl(numTugas.Value)
        rec.NilaiQuiz = CDbl(numQuiz.Value)
        rec.NilaiUTS = CDbl(numUTS.Value)
        rec.NilaiUAS = CDbl(numUAS.Value)
        rec.NilaiAkhir = Double.Parse(txtNilaiAkhir.Text)
        rec.Grade = HitungGrade(rec.NilaiAkhir)
        rec.Status = txtStatus.Text

        Grades.Add(rec)

        MessageBox.Show("Data penilaian berhasil disimpan.", "Informasi")
    End Sub

    ' ========== BUTTON RESET ==========
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub
End Class
