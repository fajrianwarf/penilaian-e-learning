<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailSiswa
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
        Label1 = New Label()
        lblNama = New TextBox()
        Label2 = New Label()
        lblKelas = New TextBox()
        dgvDetailNilai = New DataGridView()
        NamaMapel = New DataGridViewTextBoxColumn()
        Grade = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        txtRataRata = New TextBox()
        Label4 = New Label()
        txtGradeTertinggi = New TextBox()
        btnTutup = New Button()
        CType(dgvDetailNilai, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' lblNama
        ' 
        lblNama.Location = New Point(100, 6)
        lblNama.Name = "lblNama"
        lblNama.ReadOnly = True
        lblNama.Size = New Size(150, 31)
        lblNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 25)
        Label2.TabIndex = 2
        Label2.Text = "Kelas"
        ' 
        ' lblKelas
        ' 
        lblKelas.Location = New Point(100, 56)
        lblKelas.Name = "lblKelas"
        lblKelas.ReadOnly = True
        lblKelas.Size = New Size(150, 31)
        lblKelas.TabIndex = 3
        ' 
        ' dgvDetailNilai
        ' 
        dgvDetailNilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetailNilai.Columns.AddRange(New DataGridViewColumn() {NamaMapel, Grade, Status})
        dgvDetailNilai.Location = New Point(12, 114)
        dgvDetailNilai.Name = "dgvDetailNilai"
        dgvDetailNilai.RowHeadersWidth = 62
        dgvDetailNilai.Size = New Size(662, 225)
        dgvDetailNilai.TabIndex = 4
        ' 
        ' NamaMapel
        ' 
        NamaMapel.HeaderText = "Nama Mapel"
        NamaMapel.MinimumWidth = 8
        NamaMapel.Name = "NamaMapel"
        NamaMapel.Width = 150
        ' 
        ' Grade
        ' 
        Grade.HeaderText = "Grade"
        Grade.MinimumWidth = 8
        Grade.Name = "Grade"
        Grade.Width = 150
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 8
        Status.Name = "Status"
        Status.Width = 150
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 357)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 5
        Label3.Text = "Rata-rata"
        ' 
        ' txtRataRata
        ' 
        txtRataRata.Location = New Point(143, 354)
        txtRataRata.Name = "txtRataRata"
        txtRataRata.ReadOnly = True
        txtRataRata.Size = New Size(150, 31)
        txtRataRata.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 401)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 25)
        Label4.TabIndex = 7
        Label4.Text = "Grade terbaik"
        ' 
        ' txtGradeTertinggi
        ' 
        txtGradeTertinggi.Location = New Point(143, 395)
        txtGradeTertinggi.Name = "txtGradeTertinggi"
        txtGradeTertinggi.ReadOnly = True
        txtGradeTertinggi.Size = New Size(150, 31)
        txtGradeTertinggi.TabIndex = 8
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(562, 453)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(112, 34)
        btnTutup.TabIndex = 9
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' FormDetailSiswa
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 565)
        Controls.Add(btnTutup)
        Controls.Add(txtGradeTertinggi)
        Controls.Add(Label4)
        Controls.Add(txtRataRata)
        Controls.Add(Label3)
        Controls.Add(dgvDetailNilai)
        Controls.Add(lblKelas)
        Controls.Add(Label2)
        Controls.Add(lblNama)
        Controls.Add(Label1)
        Name = "FormDetailSiswa"
        Text = "Detail Siswa"
        CType(dgvDetailNilai, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKelas As TextBox
    Friend WithEvents dgvDetailNilai As DataGridView
    Friend WithEvents NamaMapel As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRataRata As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGradeTertinggi As TextBox
    Friend WithEvents btnTutup As Button
End Class
