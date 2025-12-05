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
        Label1 = New Label()
        txtNIS = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        cboKelas = New ComboBox()
        rdoLaki = New RadioButton()
        rdoPerempuan = New RadioButton()
        chkAktif = New CheckBox()
        Label5 = New Label()
        dtpDaftar = New DateTimePicker()
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBersih = New Button()
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
        grpFormSiswa.Location = New Point(12, 12)
        grpFormSiswa.Name = "grpFormSiswa"
        grpFormSiswa.Size = New Size(504, 215)
        grpFormSiswa.TabIndex = 0
        grpFormSiswa.TabStop = False
        grpFormSiswa.Text = "Form Siswa"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIS"
        ' 
        ' txtNIS
        ' 
        txtNIS.Location = New Point(137, 19)
        txtNIS.Name = "txtNIS"
        txtNIS.Size = New Size(121, 23)
        txtNIS.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 2
        Label3.Text = "Kelas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 3
        Label4.Text = "Jenis Kelamin"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(137, 48)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(121, 23)
        txtNama.TabIndex = 4
        ' 
        ' cboKelas
        ' 
        cboKelas.FormattingEnabled = True
        cboKelas.Location = New Point(137, 77)
        cboKelas.Name = "cboKelas"
        cboKelas.Size = New Size(121, 23)
        cboKelas.TabIndex = 6
        ' 
        ' rdoLaki
        ' 
        rdoLaki.AutoSize = True
        rdoLaki.Location = New Point(137, 110)
        rdoLaki.Name = "rdoLaki"
        rdoLaki.Size = New Size(69, 19)
        rdoLaki.TabIndex = 7
        rdoLaki.TabStop = True
        rdoLaki.Text = "Laki-laki"
        rdoLaki.UseVisualStyleBackColor = True
        ' 
        ' rdoPerempuan
        ' 
        rdoPerempuan.AutoSize = True
        rdoPerempuan.Location = New Point(222, 109)
        rdoPerempuan.Name = "rdoPerempuan"
        rdoPerempuan.Size = New Size(86, 19)
        rdoPerempuan.TabIndex = 8
        rdoPerempuan.TabStop = True
        rdoPerempuan.Text = "Perempuan"
        rdoPerempuan.UseVisualStyleBackColor = True
        ' 
        ' chkAktif
        ' 
        chkAktif.AutoSize = True
        chkAktif.Location = New Point(137, 145)
        chkAktif.Name = "chkAktif"
        chkAktif.Size = New Size(111, 19)
        chkAktif.TabIndex = 9
        chkAktif.Text = "Aktif e-Learning"
        chkAktif.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 15)
        Label5.TabIndex = 10
        Label5.Text = "Tanggal Daftar"
        ' 
        ' dtpDaftar
        ' 
        dtpDaftar.Location = New Point(137, 170)
        dtpDaftar.Name = "dtpDaftar"
        dtpDaftar.Size = New Size(200, 23)
        dtpDaftar.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnBersih)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnUbah)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Location = New Point(12, 233)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(504, 76)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Aksi"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(6, 22)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(100, 22)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 1
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(196, 22)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBersih
        ' 
        btnBersih.Location = New Point(290, 22)
        btnBersih.Name = "btnBersih"
        btnBersih.Size = New Size(75, 23)
        btnBersih.TabIndex = 3
        btnBersih.Text = "Bersih"
        btnBersih.UseVisualStyleBackColor = True
        ' 
        ' dgvSiswa
        ' 
        dgvSiswa.AllowUserToAddRows = False
        dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSiswa.Columns.AddRange(New DataGridViewColumn() {NIS, Nama, Kelas, JK, Aktif, TglDaftar})
        dgvSiswa.Location = New Point(12, 315)
        dgvSiswa.Name = "dgvSiswa"
        dgvSiswa.Size = New Size(504, 123)
        dgvSiswa.TabIndex = 2
        ' 
        ' NIS
        ' 
        NIS.HeaderText = "NIS"
        NIS.Name = "NIS"
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama"
        Nama.Name = "Nama"
        ' 
        ' Kelas
        ' 
        Kelas.HeaderText = "Kelas"
        Kelas.Name = "Kelas"
        ' 
        ' JK
        ' 
        JK.HeaderText = "JK"
        JK.Name = "JK"
        ' 
        ' Aktif
        ' 
        Aktif.HeaderText = "Aktif"
        Aktif.Name = "Aktif"
        ' 
        ' TglDaftar
        ' 
        TglDaftar.HeaderText = "TglDaftar"
        TglDaftar.Name = "TglDaftar"
        ' 
        ' FormDataSiswa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvSiswa)
        Controls.Add(GroupBox1)
        Controls.Add(grpFormSiswa)
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
End Class
