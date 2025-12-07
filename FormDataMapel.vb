Public Class FormDataMapel

    Private Sub FormDataMapel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGrid()
        LoadKategori()
        RefreshGrid()
        numSKS.Value = 2
    End Sub

    Private Sub LoadKategori()
        cboKategori.Items.Clear()
        ' isi dari enum KategoriMapel
        cboKategori.Items.Add(KategoriMapel.Teori)
        cboKategori.Items.Add(KategoriMapel.Praktik)
        cboKategori.Items.Add(KategoriMapel.Project)
        If cboKategori.Items.Count > 0 Then
            cboKategori.SelectedIndex = 0
        End If
    End Sub

    Private Sub RefreshGrid()
        dgvMapel.Rows.Clear()
        For Each c As Course In Courses
            dgvMapel.Rows.Add(c.Kode,
                              c.Nama,
                              c.SKS,
                              c.Kategori.ToString())
        Next
    End Sub

    Private Sub SetupGrid()
        With dgvMapel
            .AutoGenerateColumns = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
        End With
    End Sub


    Private Sub ClearForm()
        txtKode.Clear()
        txtNama.Clear()
        numSKS.Value = 2
        If cboKategori.Items.Count > 0 Then cboKategori.SelectedIndex = 0
        txtKode.Focus()
    End Sub

    Private Function ValidasiInput() As Boolean
        If txtKode.Text.Trim() = "" Then
            MessageBox.Show("Kode mapel belum diisi.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKode.Focus()
            Return False
        End If

        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama mapel belum diisi.", "Validasi")
            txtNama.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function CariCourseByKode(kode As String) As Course
        For Each c As Course In Courses
            If c.Kode = kode Then
                Return c
            End If
        Next
        Return Nothing
    End Function

    ' ===== Button Tambah =====
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Exit Sub

        If CariCourseByKode(txtKode.Text.Trim()) IsNot Nothing Then
            MessageBox.Show("Kode mapel sudah ada.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim c As New Course()
        c.Kode = txtKode.Text.Trim()
        c.Nama = txtNama.Text.Trim()
        c.SKS = CInt(numSKS.Value)
        c.Kategori = CType(cboKategori.SelectedItem, KategoriMapel)

        Courses.Add(c)
        RefreshGrid()
        ClearForm()
        MessageBox.Show("Data mata pelajaran berhasil ditambahkan.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ===== Button Ubah =====
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not ValidasiInput() Then Exit Sub

        Dim c = CariCourseByKode(txtKode.Text.Trim())
        If c Is Nothing Then
            MessageBox.Show("Data mapel tidak ditemukan.", "Error")
            Return
        End If

        c.Nama = txtNama.Text.Trim()
        c.SKS = CInt(numSKS.Value)
        c.Kategori = CType(cboKategori.SelectedItem, KategoriMapel)

        RefreshGrid()
        MessageBox.Show("Data mapel berhasil diubah.", "Info")
    End Sub

    ' ===== Button Hapus =====
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim kode = txtKode.Text.Trim()
        If kode = "" Then
            MessageBox.Show("Isi kode mapel yang akan dihapus.", "Info")
            Return
        End If

        Dim c = CariCourseByKode(kode)
        If c Is Nothing Then
            MessageBox.Show("Data mapel tidak ditemukan.", "Error")
            Return
        End If

        If MessageBox.Show("Yakin hapus data mapel ini?", "Konfirmasi",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Courses.Remove(c)
            RefreshGrid()
            ClearForm()
        End If
    End Sub

    ' ===== Button Bersih =====
    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        ClearForm()
    End Sub

    ' Klik baris grid → isi form
    Private Sub dgvMapel_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvMapel.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row = dgvMapel.Rows(e.RowIndex)
        txtKode.Text = row.Cells(0).Value?.ToString()
        txtNama.Text = row.Cells(1).Value?.ToString()

        Dim sks As Integer
        Integer.TryParse(row.Cells(2).Value?.ToString(), sks)
        numSKS.Value = sks

        ' Kategori disimpan sebagai teks, kita samakan dengan isi combo
        cboKategori.Text = row.Cells(3).Value?.ToString()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

End Class
