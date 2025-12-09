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
        lblEmpty = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvRekap, ComponentModel.ISupportInitialize).BeginInit()
        grpRingkasan.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cboFilterMapel)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cboFilterKelas)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(8, 7)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(329, 78)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter"
        ' 
        ' cboFilterMapel
        ' 
        cboFilterMapel.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterMapel.FormattingEnabled = True
        cboFilterMapel.Location = New Point(104, 42)
        cboFilterMapel.Margin = New Padding(2)
        cboFilterMapel.Name = "cboFilterMapel"
        cboFilterMapel.Size = New Size(129, 23)
        cboFilterMapel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 44)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 2
        Label2.Text = "Mapel"
        ' 
        ' cboFilterKelas
        ' 
        cboFilterKelas.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterKelas.FormattingEnabled = True
        cboFilterKelas.Location = New Point(104, 14)
        cboFilterKelas.Margin = New Padding(2)
        cboFilterKelas.Name = "cboFilterKelas"
        cboFilterKelas.Size = New Size(129, 23)
        cboFilterKelas.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 16)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kelas"
        ' 
        ' dgvRekap
        ' 
        dgvRekap.AllowUserToAddRows = False
        dgvRekap.AllowUserToDeleteRows = False
        dgvRekap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRekap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRekap.Columns.AddRange(New DataGridViewColumn() {NamaSiswa, Kelas, NamaMapel, NilaiAkhir, Grade, Status})
        dgvRekap.Location = New Point(8, 89)
        dgvRekap.Margin = New Padding(2)
        dgvRekap.Name = "dgvRekap"
        dgvRekap.ReadOnly = True
        dgvRekap.RowHeadersWidth = 62
        dgvRekap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRekap.Size = New Size(591, 145)
        dgvRekap.TabIndex = 1
        ' 
        ' NamaSiswa
        ' 
        NamaSiswa.FillWeight = 170.778F
        NamaSiswa.HeaderText = "Nama Siswa"
        NamaSiswa.MinimumWidth = 8
        NamaSiswa.Name = "NamaSiswa"
        NamaSiswa.ReadOnly = True
        ' 
        ' Kelas
        ' 
        Kelas.FillWeight = 129.908478F
        Kelas.HeaderText = "Kelas"
        Kelas.MinimumWidth = 8
        Kelas.Name = "Kelas"
        Kelas.ReadOnly = True
        ' 
        ' NamaMapel
        ' 
        NamaMapel.FillWeight = 100.671646F
        NamaMapel.HeaderText = "Nama Mapel"
        NamaMapel.MinimumWidth = 8
        NamaMapel.Name = "NamaMapel"
        NamaMapel.ReadOnly = True
        ' 
        ' NilaiAkhir
        ' 
        NilaiAkhir.FillWeight = 79.75649F
        NilaiAkhir.HeaderText = "Nilai Akhir"
        NilaiAkhir.MinimumWidth = 8
        NilaiAkhir.Name = "NilaiAkhir"
        NilaiAkhir.ReadOnly = True
        ' 
        ' Grade
        ' 
        Grade.FillWeight = 64.794426F
        Grade.HeaderText = "Grade"
        Grade.MinimumWidth = 8
        Grade.Name = "Grade"
        Grade.ReadOnly = True
        ' 
        ' Status
        ' 
        Status.FillWeight = 54.0910072F
        Status.HeaderText = "Status"
        Status.MinimumWidth = 8
        Status.Name = "Status"
        Status.ReadOnly = True
        ' 
        ' grpRingkasan
        ' 
        grpRingkasan.Controls.Add(txtJmlTdkLulus)
        grpRingkasan.Controls.Add(Label5)
        grpRingkasan.Controls.Add(txtJmlLulus)
        grpRingkasan.Controls.Add(Label4)
        grpRingkasan.Controls.Add(txtRataRata)
        grpRingkasan.Controls.Add(Label3)
        grpRingkasan.Location = New Point(8, 255)
        grpRingkasan.Margin = New Padding(2)
        grpRingkasan.Name = "grpRingkasan"
        grpRingkasan.Padding = New Padding(2)
        grpRingkasan.Size = New Size(329, 111)
        grpRingkasan.TabIndex = 2
        grpRingkasan.TabStop = False
        grpRingkasan.Text = "Ringkasan"
        ' 
        ' txtJmlTdkLulus
        ' 
        txtJmlTdkLulus.Location = New Point(135, 77)
        txtJmlTdkLulus.Margin = New Padding(2)
        txtJmlTdkLulus.Name = "txtJmlTdkLulus"
        txtJmlTdkLulus.ReadOnly = True
        txtJmlTdkLulus.Size = New Size(106, 23)
        txtJmlTdkLulus.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(4, 81)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 15)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah Tidak Lulus"
        ' 
        ' txtJmlLulus
        ' 
        txtJmlLulus.Location = New Point(135, 51)
        txtJmlLulus.Margin = New Padding(2)
        txtJmlLulus.Name = "txtJmlLulus"
        txtJmlLulus.ReadOnly = True
        txtJmlLulus.Size = New Size(106, 23)
        txtJmlLulus.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(4, 51)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 2
        Label4.Text = "Jumlah Lulus"
        ' 
        ' txtRataRata
        ' 
        txtRataRata.Location = New Point(135, 20)
        txtRataRata.Margin = New Padding(2)
        txtRataRata.Name = "txtRataRata"
        txtRataRata.ReadOnly = True
        txtRataRata.Size = New Size(106, 23)
        txtRataRata.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(4, 22)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 0
        Label3.Text = "Rata-rata Nilai"
        ' 
        ' btnDetailSiswa
        ' 
        btnDetailSiswa.Location = New Point(8, 373)
        btnDetailSiswa.Margin = New Padding(2)
        btnDetailSiswa.Name = "btnDetailSiswa"
        btnDetailSiswa.Size = New Size(101, 27)
        btnDetailSiswa.TabIndex = 4
        btnDetailSiswa.Text = "Detail Siswa"
        btnDetailSiswa.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(191, 373)
        btnKeluar.Margin = New Padding(2)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(146, 27)
        btnKeluar.TabIndex = 4
        btnKeluar.Text = "Kembali ke Dashboard"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblEmpty
        ' 
        lblEmpty.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblEmpty.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpty.Location = New Point(143, 165)
        lblEmpty.Name = "lblEmpty"
        lblEmpty.Size = New Size(306, 26)
        lblEmpty.TabIndex = 5
        lblEmpty.Text = "Belum ada data penilaian tersimpan. " & vbCrLf & "Silakan input nilai lalu simpan ke rekap"
        lblEmpty.TextAlign = ContentAlignment.MiddleCenter
        lblEmpty.Visible = False
        ' 
        ' FormRekapNilai
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(610, 416)
        Controls.Add(lblEmpty)
        Controls.Add(btnKeluar)
        Controls.Add(btnDetailSiswa)
        Controls.Add(grpRingkasan)
        Controls.Add(dgvRekap)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2)
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
    Friend WithEvents lblEmpty As Label
End Class
