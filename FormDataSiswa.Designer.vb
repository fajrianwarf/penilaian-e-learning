<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataSiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        grpFormSiswa = New GroupBox()
        dtpDaftar = New DateTimePicker()
        Label5 = New Label()
        chkAktif = New CheckBox()
        rdoPerempuan = New RadioButton()
        rdoLaki = New RadioButton()
        cboKelas = New ComboBox()
        txtNama = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtNIS = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnKembali = New Button()
        btnBersih = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnTambah = New Button()
        dgvSiswa = New DataGridView()
        NIS = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        Kelas = New DataGridViewTextBoxColumn()
        JK = New DataGridViewTextBoxColumn()
        Aktif = New DataGridViewTextBoxColumn()
        TglDaftar = New DataGridViewTextBoxColumn()
        grpFormSiswa.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvSiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpFormSiswa
        ' 
        grpFormSiswa.Controls.Add(dtpDaftar)
        grpFormSiswa.Controls.Add(Label5)
        grpFormSiswa.Controls.Add(chkAktif)
        grpFormSiswa.Controls.Add(rdoPerempuan)
        grpFormSiswa.Controls.Add(rdoLaki)
        grpFormSiswa.Controls.Add(cboKelas)
        grpFormSiswa.Controls.Add(txtNama)
        grpFormSiswa.Controls.Add(Label4)
        grpFormSiswa.Controls.Add(Label3)
        grpFormSiswa.Controls.Add(Label2)
        grpFormSiswa.Controls.Add(txtNIS)
        grpFormSiswa.Controls.Add(Label1)
        grpFormSiswa.Location = New Point(13, 14)
        grpFormSiswa.Margin = New Padding(4, 5, 4, 5)
        grpFormSiswa.Name = "grpFormSiswa"
        grpFormSiswa.Padding = New Padding(4, 5, 4, 5)
        grpFormSiswa.Size = New Size(1123, 358)
        grpFormSiswa.TabIndex = 0
        grpFormSiswa.TabStop = False
        grpFormSiswa.Text = "Form Siswa"
        ' 
        ' dtpDaftar
        ' 
        dtpDaftar.Location = New Point(196, 283)
        dtpDaftar.Margin = New Padding(4, 5, 4, 5)
        dtpDaftar.Name = "dtpDaftar"
        dtpDaftar.Size = New Size(325, 31)
        dtpDaftar.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(9, 290)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 25)
        Label5.TabIndex = 10
        Label5.Text = "Tanggal Daftar"
        ' 
        ' chkAktif
        ' 
        chkAktif.AutoSize = True
        chkAktif.Location = New Point(196, 242)
        chkAktif.Margin = New Padding(4, 5, 4, 5)
        chkAktif.Name = "chkAktif"
        chkAktif.Size = New Size(163, 29)
        chkAktif.TabIndex = 6
        chkAktif.Text = "Aktif e-Learning"
        chkAktif.UseVisualStyleBackColor = True
        ' 
        ' rdoPerempuan
        ' 
        rdoPerempuan.AutoSize = True
        rdoPerempuan.Location = New Point(317, 182)
        rdoPerempuan.Margin = New Padding(4, 5, 4, 5)
        rdoPerempuan.Name = "rdoPerempuan"
        rdoPerempuan.Size = New Size(126, 29)
        rdoPerempuan.TabIndex = 5
        rdoPerempuan.TabStop = True
        rdoPerempuan.Text = "Perempuan"
        rdoPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rdoLaki
        ' 
        rdoLaki.AutoSize = True
        rdoLaki.Location = New Point(196, 183)
        rdoLaki.Margin = New Padding(4, 5, 4, 5)
        rdoLaki.Name = "rdoLaki"
        rdoLaki.Size = New Size(100, 29)
        rdoLaki.TabIndex = 4
        rdoLaki.TabStop = True
        rdoLaki.Text = "Laki-laki"
        rdoLaki.UseVisualStyleBackColor = True
        ' 
        ' cboKelas
        ' 
        cboKelas.DropDownStyle = ComboBoxStyle.DropDownList
        cboKelas.FormattingEnabled = True
        cboKelas.Location = New Point(196, 128)
        cboKelas.Margin = New Padding(4, 5, 4, 5)
        cboKelas.Name = "cboKelas"
        cboKelas.Size = New Size(247, 33)
        cboKelas.TabIndex = 3
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(196, 80)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(247, 31)
        txtNama.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 188)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 25)
        Label4.TabIndex = 3
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 142)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 25)
        Label3.TabIndex = 2
        Label3.Text = "Kelas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 93)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 2
        Label2.Text = "Nama"
        ' 
        ' txtNIS
        ' 
        txtNIS.Location = New Point(196, 32)
        txtNIS.Margin = New Padding(4, 5, 4, 5)
        txtNIS.Name = "txtNIS"
        txtNIS.Size = New Size(247, 31)
        txtNIS.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 45)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 25)
        Label1.TabIndex = 0
        Label1.Text = "NIS"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnKembali)
        GroupBox1.Controls.Add(btnBersih)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnUbah)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Location = New Point(13, 382)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(1123, 103)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Aksi"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(547, 37)
        btnKembali.Margin = New Padding(4, 5, 4, 5)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(235, 38)
        btnKembali.TabIndex = 4
        btnKembali.Text = "Kembali ke Dashboard"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' btnBersih
        ' 
        btnBersih.Location = New Point(414, 37)
        btnBersih.Margin = New Padding(4, 5, 4, 5)
        btnBersih.Name = "btnBersih"
        btnBersih.Size = New Size(107, 38)
        btnBersih.TabIndex = 3
        btnBersih.Text = "Bersih"
        btnBersih.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(280, 37)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(107, 38)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(143, 37)
        btnUbah.Margin = New Padding(4, 5, 4, 5)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(107, 38)
        btnUbah.TabIndex = 1
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(9, 37)
        btnTambah.Margin = New Padding(4, 5, 4, 5)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(107, 38)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvSiswa
        ' 
        dgvSiswa.AllowUserToAddRows = False
        dgvSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSiswa.Columns.AddRange(New DataGridViewColumn() {NIS, Nama, Kelas, JK, Aktif, TglDaftar})
        dgvSiswa.Dock = DockStyle.Bottom
        dgvSiswa.Location = New Point(0, 495)
        dgvSiswa.Margin = New Padding(4, 5, 4, 5)
        dgvSiswa.Name = "dgvSiswa"
        dgvSiswa.ReadOnly = True
        dgvSiswa.RowHeadersWidth = 62
        dgvSiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSiswa.Size = New Size(1143, 205)
        dgvSiswa.TabIndex = 2
        ' 
        ' NIS
        ' 
        NIS.HeaderText = "NIS"
        NIS.MinimumWidth = 8
        NIS.Name = "NIS"
        NIS.ReadOnly = True
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama"
        Nama.MinimumWidth = 8
        Nama.Name = "Nama"
        Nama.ReadOnly = True
        ' 
        ' Kelas
        ' 
        Kelas.HeaderText = "Kelas"
        Kelas.MinimumWidth = 8
        Kelas.Name = "Kelas"
        Kelas.ReadOnly = True
        ' 
        ' JK
        ' 
        JK.HeaderText = "JK"
        JK.MinimumWidth = 8
        JK.Name = "JK"
        JK.ReadOnly = True
        ' 
        ' Aktif
        ' 
        Aktif.HeaderText = "Aktif"
        Aktif.MinimumWidth = 8
        Aktif.Name = "Aktif"
        Aktif.ReadOnly = True
        ' 
        ' TglDaftar
        ' 
        TglDaftar.HeaderText = "TglDaftar"
        TglDaftar.MinimumWidth = 8
        TglDaftar.Name = "TglDaftar"
        TglDaftar.ReadOnly = True
        ' 
        ' FormDataSiswa
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 700)
        Controls.Add(dgvSiswa)
        Controls.Add(GroupBox1)
        Controls.Add(grpFormSiswa)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "FormDataSiswa"
        Text = "Data Siswa"
        grpFormSiswa.ResumeLayout(False)
        grpFormSiswa.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(dgvSiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpFormSiswa As GroupBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNIS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboKelas As ComboBox
    Friend WithEvents dtpDaftar As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents chkAktif As CheckBox
    Friend WithEvents rdoPerempuan As RadioButton
    Friend WithEvents rdoLaki As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBersih As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvSiswa As DataGridView
    Friend WithEvents NIS As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Kelas As DataGridViewTextBoxColumn
    Friend WithEvents JK As DataGridViewTextBoxColumn
    Friend WithEvents Aktif As DataGridViewTextBoxColumn
    Friend WithEvents TglDaftar As DataGridViewTextBoxColumn
    Friend WithEvents btnKembali As Button
End Class
