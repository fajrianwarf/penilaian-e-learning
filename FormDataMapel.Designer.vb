<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataMapel
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
        grpFormMapel = New GroupBox()
        cboKategori = New ComboBox()
        Label4 = New Label()
        numSKS = New NumericUpDown()
        Label3 = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        txtKode = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnBersih = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnTambah = New Button()
        dgvMapel = New DataGridView()
        Kode = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        SKS = New DataGridViewTextBoxColumn()
        Kategori = New DataGridViewTextBoxColumn()
        grpFormMapel.SuspendLayout()
        CType(numSKS, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvMapel, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpFormMapel
        ' 
        grpFormMapel.Controls.Add(cboKategori)
        grpFormMapel.Controls.Add(Label4)
        grpFormMapel.Controls.Add(numSKS)
        grpFormMapel.Controls.Add(Label3)
        grpFormMapel.Controls.Add(txtNama)
        grpFormMapel.Controls.Add(Label2)
        grpFormMapel.Controls.Add(txtKode)
        grpFormMapel.Controls.Add(Label1)
        grpFormMapel.Location = New Point(12, 12)
        grpFormMapel.Name = "grpFormMapel"
        grpFormMapel.Size = New Size(397, 220)
        grpFormMapel.TabIndex = 0
        grpFormMapel.TabStop = False
        grpFormMapel.Text = "Form Mata Pelajaran"
        ' 
        ' cboKategori
        ' 
        cboKategori.FormattingEnabled = True
        cboKategori.Location = New Point(127, 119)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(121, 23)
        cboKategori.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 6
        Label4.Text = "Kategori"
        ' 
        ' numSKS
        ' 
        numSKS.Location = New Point(128, 88)
        numSKS.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        numSKS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numSKS.Name = "numSKS"
        numSKS.Size = New Size(120, 23)
        numSKS.TabIndex = 5
        numSKS.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 4
        Label3.Text = "SKS / Jam"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(128, 54)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nama Mapel"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(128, 22)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(100, 23)
        txtKode.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kode Mapel"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnBersih)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnUbah)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Location = New Point(12, 238)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(397, 76)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Aksi"
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
        ' btnHapus
        ' 
        btnHapus.Location = New Point(196, 22)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
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
        ' btnTambah
        ' 
        btnTambah.Location = New Point(6, 22)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvMapel
        ' 
        dgvMapel.AllowUserToAddRows = False
        dgvMapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMapel.Columns.AddRange(New DataGridViewColumn() {Kode, Nama, SKS, Kategori})
        dgvMapel.Location = New Point(12, 320)
        dgvMapel.Name = "dgvMapel"
        dgvMapel.Size = New Size(397, 123)
        dgvMapel.TabIndex = 3
        ' 
        ' Kode
        ' 
        Kode.HeaderText = "Kode"
        Kode.Name = "Kode"
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama Mapel"
        Nama.Name = "Nama"
        ' 
        ' SKS
        ' 
        SKS.HeaderText = "SKS"
        SKS.Name = "SKS"
        ' 
        ' Kategori
        ' 
        Kategori.HeaderText = "Kategori"
        Kategori.Name = "Kategori"
        ' 
        ' FormDataMapel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvMapel)
        Controls.Add(GroupBox1)
        Controls.Add(grpFormMapel)
        Name = "FormDataMapel"
        Text = "Data Mata Pelajaran"
        grpFormMapel.ResumeLayout(False)
        grpFormMapel.PerformLayout()
        CType(numSKS, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(dgvMapel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpFormMapel As GroupBox
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents numSKS As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBersih As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMapel As DataGridView
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents SKS As DataGridViewTextBoxColumn
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
End Class
