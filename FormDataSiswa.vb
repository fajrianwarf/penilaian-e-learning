Public Class FormDataSiswa

    Private Sub FormDataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKelas()
        RefreshGrid()
        rdoLaki.Checked = True
        chkAktif.Checked = True
        dtpDaftar.Value = Date.Today
    End Sub

    Private Sub LoadKelas()
        cboKelas.Items.Clear()
        cboKelas.Items.AddRange(New Object() {
            "IF101", "IF102",
            "IF103", "IF104",
            "IF105", "IF106"
        })
        If cboKelas.Items.Count > 0 Then
            cboKelas.SelectedIndex = 0
        End If
    End Sub

    Private Sub RefreshGrid()
        dgvSiswa.Rows.Clear()
        For Each s In Students
            Dim jkDisplay As String

            If s.JenisKelamin = "L" Then
                jkDisplay = "Laki-laki"
            ElseIf s.JenisKelamin = "P" Then
                jkDisplay = "Perempuan"
            Else
                jkDisplay = s.JenisKelamin
            End If

            dgvSiswa.Rows.Add(
                s.NIM,
                s.Nama,
                s.Kelas,
                jkDisplay,
                If(s.Aktif, "Aktif", "Tidak"),
                s.TanggalDaftar.ToShortDateString()
            )
        Next
    End Sub

    Private Sub ClearForm()
        txtNIS.Clear()
        txtNama.Clear()
        If cboKelas.Items.Count > 0 Then cboKelas.SelectedIndex = 0
        rdoLaki.Checked = True
        chkAktif.Checked = True
        dtpDaftar.Value = Date.Today
        txtNIS.Focus()
    End Sub

    Private Function ValidasiInput() As Boolean
        If txtNIS.Text.Trim() = "" Then
            MessageBox.Show("NIM belum diisi.", "Validasi")
            txtNIS.Focus()
            Return False
        End If
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama belum diisi.", "Validasi")
            txtNama.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function CariStudentByNIS(nis As String) As Student
        For Each s In Students
            If s.NIM = nis Then
                Return s
            End If
        Next
        Return Nothing
    End Function


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Exit Sub

        If CariStudentByNIS(txtNIS.Text.Trim()) IsNot Nothing Then
            MessageBox.Show("NIM sudah ada.", "Info")
            Return
        End If

        Dim s As New Student()
        s.NIM = txtNIS.Text.Trim()
        s.Nama = txtNama.Text.Trim()
        s.Kelas = cboKelas.Text
        s.JenisKelamin = If(rdoLaki.Checked, "L", "P")
        s.Aktif = chkAktif.Checked
        s.TanggalDaftar = dtpDaftar.Value.Date

        Students.Add(s)
        RefreshGrid()
        ClearForm()
        MessageBox.Show("Data siswa berhasil ditambahkan.", "Info")
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not ValidasiInput() Then Exit Sub

        Dim s = CariStudentByNIS(txtNIS.Text.Trim())
        If s Is Nothing Then
            MessageBox.Show("Data dengan NIM tersebut tidak ditemukan.", "Error")
            Return
        End If

        s.Nama = txtNama.Text.Trim()
        s.Kelas = cboKelas.Text
        s.JenisKelamin = If(rdoLaki.Checked, "L", "P")
        s.Aktif = chkAktif.Checked
        s.TanggalDaftar = dtpDaftar.Value.Date

        RefreshGrid()
        MessageBox.Show("Data siswa berhasil diubah.", "Info")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim nis = txtNIS.Text.Trim()
        If nis = "" Then
            MessageBox.Show("Isi NIM yang akan dihapus.", "Info")
            Return
        End If

        Dim s = CariStudentByNIS(nis)
        If s Is Nothing Then
            MessageBox.Show("Data tidak ditemukan.", "Error")
            Return
        End If

        If MessageBox.Show("Yakin hapus data ini?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Students.Remove(s)
            RefreshGrid()
            ClearForm()
        End If
    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        ClearForm()
    End Sub

    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvSiswa.CellClick

        If e.RowIndex < 0 Then Exit Sub
        Dim row = dgvSiswa.Rows(e.RowIndex)

        txtNIS.Text = row.Cells(0).Value?.ToString()
        txtNama.Text = row.Cells(1).Value?.ToString()
        cboKelas.Text = row.Cells(2).Value?.ToString()

        Dim jk = row.Cells(3).Value?.ToString()
        rdoLaki.Checked = (jk = "L")
        rdoPerempuan.Checked = (jk = "P")

        chkAktif.Checked = (row.Cells(4).Value?.ToString() = "Aktif")

        Dim tgl As Date
        If Date.TryParse(row.Cells(5).Value?.ToString(), tgl) Then
            dtpDaftar.Value = tgl
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

End Class
