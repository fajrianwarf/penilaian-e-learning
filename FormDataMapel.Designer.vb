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
        btnKembali = New Button()
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
        grpFormMapel.Location = New Point(13, 14)
        grpFormMapel.Margin = New Padding(4, 5, 4, 5)
        grpFormMapel.Name = "grpFormMapel"
        grpFormMapel.Padding = New Padding(4, 5, 4, 5)
        grpFormMapel.Size = New Size(1117, 260)
        grpFormMapel.TabIndex = 0
        grpFormMapel.TabStop = False
        grpFormMapel.Text = "Form Mata Pelajaran"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Location = New Point(181, 204)
        cboKategori.Margin = New Padding(4, 5, 4, 5)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(206, 33)
        cboKategori.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 212)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 25)
        Label4.TabIndex = 6
        Label4.Text = "Kategori"
        ' 
        ' numSKS
        ' 
        numSKS.Location = New Point(181, 154)
        numSKS.Margin = New Padding(4, 5, 4, 5)
        numSKS.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        numSKS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numSKS.Name = "numSKS"
        numSKS.Size = New Size(206, 31)
        numSKS.TabIndex = 3
        numSKS.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 160)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 25)
        Label3.TabIndex = 4
        Label3.Text = "SKS / Jam"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(181, 97)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(206, 31)
        txtNama.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 103)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 25)
        Label2.TabIndex = 2
        Label2.Text = "Nama Mapel"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(183, 44)
        txtKode.Margin = New Padding(4, 5, 4, 5)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(204, 31)
        txtKode.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 50)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Mapel"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnKembali)
        GroupBox1.Controls.Add(btnBersih)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnUbah)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Location = New Point(13, 284)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(1117, 100)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Aksi"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(545, 37)
        btnKembali.Margin = New Padding(4, 5, 4, 5)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(219, 38)
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
        ' dgvMapel
        ' 
        dgvMapel.AllowUserToAddRows = False
        dgvMapel.AllowUserToDeleteRows = False
        dgvMapel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMapel.Columns.AddRange(New DataGridViewColumn() {Kode, Nama, SKS, Kategori})
        dgvMapel.Dock = DockStyle.Bottom
        dgvMapel.Location = New Point(0, 401)
        dgvMapel.Margin = New Padding(4, 5, 4, 5)
        dgvMapel.Name = "dgvMapel"
        dgvMapel.ReadOnly = True
        dgvMapel.RowHeadersWidth = 62
        dgvMapel.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMapel.Size = New Size(1143, 205)
        dgvMapel.TabIndex = 3
        ' 
        ' Kode
        ' 
        Kode.HeaderText = "Kode"
        Kode.MinimumWidth = 8
        Kode.Name = "Kode"
        Kode.ReadOnly = True
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama Mapel"
        Nama.MinimumWidth = 8
        Nama.Name = "Nama"
        Nama.ReadOnly = True
        ' 
        ' SKS
        ' 
        SKS.HeaderText = "SKS"
        SKS.MinimumWidth = 8
        SKS.Name = "SKS"
        SKS.ReadOnly = True
        ' 
        ' Kategori
        ' 
        Kategori.HeaderText = "Kategori"
        Kategori.MinimumWidth = 8
        Kategori.Name = "Kategori"
        Kategori.ReadOnly = True
        ' 
        ' FormDataMapel
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 606)
        Controls.Add(dgvMapel)
        Controls.Add(GroupBox1)
        Controls.Add(grpFormMapel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
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
    Friend WithEvents btnKembali As Button
End Class
