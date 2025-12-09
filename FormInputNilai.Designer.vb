<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputNilai
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
        cboMapel = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        cboSiswa = New ComboBox()
        GroupBox2 = New GroupBox()
        numUAS = New NumericUpDown()
        Label6 = New Label()
        numUTS = New NumericUpDown()
        Label5 = New Label()
        numQuiz = New NumericUpDown()
        numTugas = New NumericUpDown()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox3 = New GroupBox()
        txtStatus = New TextBox()
        Label9 = New Label()
        txtGrade = New TextBox()
        Label8 = New Label()
        txtNilaiAkhir = New TextBox()
        Label7 = New Label()
        GroupBox4 = New GroupBox()
        btnKembali = New Button()
        btnReset = New Button()
        btnSimpan = New Button()
        btnHitung = New Button()
        GroupBox5 = New GroupBox()
        lblInfoGrade = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(numUAS, ComponentModel.ISupportInitialize).BeginInit()
        CType(numUTS, ComponentModel.ISupportInitialize).BeginInit()
        CType(numQuiz, ComponentModel.ISupportInitialize).BeginInit()
        CType(numTugas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cboMapel)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cboSiswa)
        GroupBox1.Location = New Point(8, 7)
        GroupBox1.Margin = New Padding(2, 2, 2, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 2, 2, 2)
        GroupBox1.Size = New Size(288, 78)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Identitas"
        ' 
        ' cboMapel
        ' 
        cboMapel.DropDownStyle = ComboBoxStyle.DropDownList
        cboMapel.FormattingEnabled = True
        cboMapel.Location = New Point(143, 46)
        cboMapel.Margin = New Padding(2, 2, 2, 2)
        cboMapel.Name = "cboMapel"
        cboMapel.Size = New Size(129, 23)
        cboMapel.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 46)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 2
        Label2.Text = "Mapel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 20)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 1
        Label1.Text = "Siswa"
        ' 
        ' cboSiswa
        ' 
        cboSiswa.DropDownStyle = ComboBoxStyle.DropDownList
        cboSiswa.FormattingEnabled = True
        cboSiswa.Location = New Point(143, 18)
        cboSiswa.Margin = New Padding(2, 2, 2, 2)
        cboSiswa.Name = "cboSiswa"
        cboSiswa.Size = New Size(129, 23)
        cboSiswa.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(numUAS)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(numUTS)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(numQuiz)
        GroupBox2.Controls.Add(numTugas)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(8, 95)
        GroupBox2.Margin = New Padding(2, 2, 2, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2, 2, 2, 2)
        GroupBox2.Size = New Size(288, 138)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Nilai"
        ' 
        ' numUAS
        ' 
        numUAS.Location = New Point(143, 100)
        numUAS.Margin = New Padding(2, 2, 2, 2)
        numUAS.Name = "numUAS"
        numUAS.Size = New Size(127, 23)
        numUAS.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 100)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 15)
        Label6.TabIndex = 6
        Label6.Text = "UAS"
        ' 
        ' numUTS
        ' 
        numUTS.Location = New Point(143, 75)
        numUTS.Margin = New Padding(2, 2, 2, 2)
        numUTS.Name = "numUTS"
        numUTS.Size = New Size(127, 23)
        numUTS.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 76)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 4
        Label5.Text = "UTS"
        ' 
        ' numQuiz
        ' 
        numQuiz.Location = New Point(143, 50)
        numQuiz.Margin = New Padding(2, 2, 2, 2)
        numQuiz.Name = "numQuiz"
        numQuiz.Size = New Size(127, 23)
        numQuiz.TabIndex = 3
        ' 
        ' numTugas
        ' 
        numTugas.Location = New Point(143, 24)
        numTugas.Margin = New Padding(2, 2, 2, 2)
        numTugas.Name = "numTugas"
        numTugas.Size = New Size(127, 23)
        numTugas.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 51)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 1
        Label4.Text = "Quiz"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 25)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 0
        Label3.Text = "Tugas"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtStatus)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtGrade)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(txtNilaiAkhir)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(8, 236)
        GroupBox3.Margin = New Padding(2, 2, 2, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(2, 2, 2, 2)
        GroupBox3.Size = New Size(543, 139)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Hasil"
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(144, 71)
        txtStatus.Margin = New Padding(2, 2, 2, 2)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(127, 23)
        txtStatus.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 71)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 15)
        Label9.TabIndex = 4
        Label9.Text = "Status"
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(144, 45)
        txtGrade.Margin = New Padding(2, 2, 2, 2)
        txtGrade.Name = "txtGrade"
        txtGrade.ReadOnly = True
        txtGrade.Size = New Size(127, 23)
        txtGrade.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(13, 49)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 15)
        Label8.TabIndex = 2
        Label8.Text = "Grade"
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(143, 21)
        txtNilaiAkhir.Margin = New Padding(2, 2, 2, 2)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.ReadOnly = True
        txtNilaiAkhir.Size = New Size(127, 23)
        txtNilaiAkhir.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 25)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 15)
        Label7.TabIndex = 0
        Label7.Text = "Nilai Akhir"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnKembali)
        GroupBox4.Controls.Add(btnReset)
        GroupBox4.Controls.Add(btnSimpan)
        GroupBox4.Controls.Add(btnHitung)
        GroupBox4.Location = New Point(8, 382)
        GroupBox4.Margin = New Padding(2, 2, 2, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(2, 2, 2, 2)
        GroupBox4.Size = New Size(543, 75)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Aksi"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(331, 25)
        btnKembali.Margin = New Padding(2, 2, 2, 2)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(146, 28)
        btnKembali.TabIndex = 3
        btnKembali.Text = "Kembali ke Dashboard"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(242, 25)
        btnReset.Margin = New Padding(2, 2, 2, 2)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(78, 28)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(103, 25)
        btnSimpan.Margin = New Padding(2, 2, 2, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(127, 28)
        btnSimpan.TabIndex = 1
        btnSimpan.Text = "Simpan ke rekap"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(12, 25)
        btnHitung.Margin = New Padding(2, 2, 2, 2)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(78, 28)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(lblInfoGrade)
        GroupBox5.Location = New Point(300, 7)
        GroupBox5.Margin = New Padding(2, 2, 2, 2)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(2, 2, 2, 2)
        GroupBox5.Size = New Size(251, 226)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        GroupBox5.Text = "Informasi Grade dan Status"
        ' 
        ' lblInfoGrade
        ' 
        lblInfoGrade.Location = New Point(4, 25)
        lblInfoGrade.Margin = New Padding(2, 0, 2, 0)
        lblInfoGrade.Name = "lblInfoGrade"
        lblInfoGrade.Size = New Size(243, 199)
        lblInfoGrade.TabIndex = 0
        lblInfoGrade.Text = "-"
        ' 
        ' FormInputNilai
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 468)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2, 2, 2, 2)
        MaximizeBox = False
        Name = "FormInputNilai"
        Text = "Input Nilai & Penilaian"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(numUAS, ComponentModel.ISupportInitialize).EndInit()
        CType(numUTS, ComponentModel.ISupportInitialize).EndInit()
        CType(numQuiz, ComponentModel.ISupportInitialize).EndInit()
        CType(numTugas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSiswa As ComboBox
    Friend WithEvents cboMapel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents numTugas As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numUAS As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents numUTS As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents numQuiz As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblInfoGrade As Label
    Friend WithEvents btnKembali As Button
End Class
