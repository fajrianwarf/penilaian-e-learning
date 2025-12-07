<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRekapNilai
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
        GroupBox1 = New GroupBox()
        btnTampilkan = New Button()
        cboFilterMapel = New ComboBox()
        Label2 = New Label()
        cboFilterKelas = New ComboBox()
        Label1 = New Label()
        dgvRekap = New DataGridView()
        NamaSiswa = New DataGridViewTextBoxColumn()
        Kelas = New DataGridViewTextBoxColumn()
        NamaMapel = New DataGridViewTextBoxColumn()
        NilaiAkhir = New DataGridViewTextBoxColumn()
        Grade = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        grpRingkasan = New GroupBox()
        txtJmlTdkLulus = New TextBox()
        Label5 = New Label()
        txtJmlLulus = New TextBox()
        Label4 = New Label()
        txtRataRata = New TextBox()
        Label3 = New Label()
        btnDetailSiswa = New Button()
        btnKeluar = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvRekap, ComponentModel.ISupportInitialize).BeginInit()
        grpRingkasan.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTampilkan)
        GroupBox1.Controls.Add(cboFilterMapel)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cboFilterKelas)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(470, 164)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(219, 116)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 3
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' cboFilterMapel
        ' 
        cboFilterMapel.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterMapel.FormattingEnabled = True
        cboFilterMapel.Location = New Point(149, 70)
        cboFilterMapel.Name = "cboFilterMapel"
        cboFilterMapel.Size = New Size(182, 33)
        cboFilterMapel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 25)
        Label2.TabIndex = 2
        Label2.Text = "Mapel"
        ' 
        ' cboFilterKelas
        ' 
        cboFilterKelas.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterKelas.FormattingEnabled = True
        cboFilterKelas.Location = New Point(149, 24)
        cboFilterKelas.Name = "cboFilterKelas"
        cboFilterKelas.Size = New Size(182, 33)
        cboFilterKelas.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kelas"
        ' 
        ' dgvRekap
        ' 
        dgvRekap.AllowUserToAddRows = False
        dgvRekap.AllowUserToDeleteRows = False
        dgvRekap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRekap.Columns.AddRange(New DataGridViewColumn() {NamaSiswa, Kelas, NamaMapel, NilaiAkhir, Grade, Status})
        dgvRekap.Location = New Point(12, 182)
        dgvRekap.Name = "dgvRekap"
        dgvRekap.ReadOnly = True
        dgvRekap.RowHeadersWidth = 62
        dgvRekap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRekap.Size = New Size(776, 190)
        dgvRekap.TabIndex = 1
        ' 
        ' NamaSiswa
        ' 
        NamaSiswa.HeaderText = "Nama Siswa"
        NamaSiswa.MinimumWidth = 8
        NamaSiswa.Name = "NamaSiswa"
        NamaSiswa.ReadOnly = True
        NamaSiswa.Width = 150
        ' 
        ' Kelas
        ' 
        Kelas.HeaderText = "Kelas"
        Kelas.MinimumWidth = 8
        Kelas.Name = "Kelas"
        Kelas.ReadOnly = True
        Kelas.Width = 150
        ' 
        ' NamaMapel
        ' 
        NamaMapel.HeaderText = "Nama Mapel"
        NamaMapel.MinimumWidth = 8
        NamaMapel.Name = "NamaMapel"
        NamaMapel.ReadOnly = True
        NamaMapel.Width = 150
        ' 
        ' NilaiAkhir
        ' 
        NilaiAkhir.HeaderText = "Nilai Akhir"
        NilaiAkhir.MinimumWidth = 8
        NilaiAkhir.Name = "NilaiAkhir"
        NilaiAkhir.ReadOnly = True
        NilaiAkhir.Width = 150
        ' 
        ' Grade
        ' 
        Grade.HeaderText = "Grade"
        Grade.MinimumWidth = 8
        Grade.Name = "Grade"
        Grade.ReadOnly = True
        Grade.Width = 150
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 8
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.Width = 150
        ' 
        ' grpRingkasan
        ' 
        grpRingkasan.Controls.Add(txtJmlTdkLulus)
        grpRingkasan.Controls.Add(Label5)
        grpRingkasan.Controls.Add(txtJmlLulus)
        grpRingkasan.Controls.Add(Label4)
        grpRingkasan.Controls.Add(txtRataRata)
        grpRingkasan.Controls.Add(Label3)
        grpRingkasan.Location = New Point(12, 396)
        grpRingkasan.Name = "grpRingkasan"
        grpRingkasan.Size = New Size(470, 185)
        grpRingkasan.TabIndex = 2
        grpRingkasan.TabStop = False
        grpRingkasan.Text = "Ringkasan"
        ' 
        ' txtJmlTdkLulus
        ' 
        txtJmlTdkLulus.Location = New Point(193, 129)
        txtJmlTdkLulus.Name = "txtJmlTdkLulus"
        txtJmlTdkLulus.ReadOnly = True
        txtJmlTdkLulus.Size = New Size(150, 31)
        txtJmlTdkLulus.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 25)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah Tidak Lulus"
        ' 
        ' txtJmlLulus
        ' 
        txtJmlLulus.Location = New Point(193, 85)
        txtJmlLulus.Name = "txtJmlLulus"
        txtJmlLulus.ReadOnly = True
        txtJmlLulus.Size = New Size(150, 31)
        txtJmlLulus.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 25)
        Label4.TabIndex = 2
        Label4.Text = "Jumlah Lulus"
        ' 
        ' txtRataRata
        ' 
        txtRataRata.Location = New Point(193, 34)
        txtRataRata.Name = "txtRataRata"
        txtRataRata.ReadOnly = True
        txtRataRata.Size = New Size(150, 31)
        txtRataRata.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 25)
        Label3.TabIndex = 0
        Label3.Text = "Rata-rata Nilai"
        ' 
        ' btnDetailSiswa
        ' 
        btnDetailSiswa.Location = New Point(12, 602)
        btnDetailSiswa.Name = "btnDetailSiswa"
        btnDetailSiswa.Size = New Size(144, 34)
        btnDetailSiswa.TabIndex = 4
        btnDetailSiswa.Text = "Detail Siswa"
        btnDetailSiswa.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(273, 602)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(209, 34)
        btnKeluar.TabIndex = 4
        btnKeluar.Text = "Kembali ke Dashboard"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' FormRekapNilai
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 693)
        Controls.Add(btnKeluar)
        Controls.Add(btnDetailSiswa)
        Controls.Add(grpRingkasan)
        Controls.Add(dgvRekap)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormRekapNilai"
        Text = "Rekap & Evaluasi Nilai"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvRekap, ComponentModel.ISupportInitialize).EndInit()
        grpRingkasan.ResumeLayout(False)
        grpRingkasan.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboFilterKelas As ComboBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents cboFilterMapel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvRekap As DataGridView
    Friend WithEvents NamaSiswa As DataGridViewTextBoxColumn
    Friend WithEvents Kelas As DataGridViewTextBoxColumn
    Friend WithEvents NamaMapel As DataGridViewTextBoxColumn
    Friend WithEvents NilaiAkhir As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents grpRingkasan As GroupBox
    Friend WithEvents txtJmlTdkLulus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJmlLulus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRataRata As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDetailSiswa As Button
    Friend WithEvents btnKeluar As Button
End Class
