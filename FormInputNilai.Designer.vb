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
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(411, 130)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Identitas"
        ' 
        ' cboMapel
        ' 
        cboMapel.DropDownStyle = ComboBoxStyle.DropDownList
        cboMapel.FormattingEnabled = True
        cboMapel.Location = New Point(204, 76)
        cboMapel.Name = "cboMapel"
        cboMapel.Size = New Size(182, 33)
        cboMapel.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 25)
        Label2.TabIndex = 2
        Label2.Text = "Mapel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 25)
        Label1.TabIndex = 1
        Label1.Text = "Siswa"
        ' 
        ' cboSiswa
        ' 
        cboSiswa.DropDownStyle = ComboBoxStyle.DropDownList
        cboSiswa.FormattingEnabled = True
        cboSiswa.Location = New Point(204, 30)
        cboSiswa.Name = "cboSiswa"
        cboSiswa.Size = New Size(182, 33)
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
        GroupBox2.Location = New Point(12, 158)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(411, 230)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Nilai"
        ' 
        ' numUAS
        ' 
        numUAS.Location = New Point(204, 167)
        numUAS.Name = "numUAS"
        numUAS.Size = New Size(182, 31)
        numUAS.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 167)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 25)
        Label6.TabIndex = 6
        Label6.Text = "UAS"
        ' 
        ' numUTS
        ' 
        numUTS.Location = New Point(204, 125)
        numUTS.Name = "numUTS"
        numUTS.Size = New Size(182, 31)
        numUTS.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 25)
        Label5.TabIndex = 4
        Label5.Text = "UTS"
        ' 
        ' numQuiz
        ' 
        numQuiz.Location = New Point(204, 83)
        numQuiz.Name = "numQuiz"
        numQuiz.Size = New Size(182, 31)
        numQuiz.TabIndex = 3
        ' 
        ' numTugas
        ' 
        numTugas.Location = New Point(204, 40)
        numTugas.Name = "numTugas"
        numTugas.Size = New Size(182, 31)
        numTugas.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 25)
        Label4.TabIndex = 1
        Label4.Text = "Quiz"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 25)
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
        GroupBox3.Location = New Point(12, 394)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(776, 231)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Hasil"
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(206, 119)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(180, 31)
        txtStatus.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 119)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 25)
        Label9.TabIndex = 4
        Label9.Text = "Status"
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(206, 75)
        txtGrade.Name = "txtGrade"
        txtGrade.ReadOnly = True
        txtGrade.Size = New Size(180, 31)
        txtGrade.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(19, 81)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 25)
        Label8.TabIndex = 2
        Label8.Text = "Grade"
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(204, 35)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.ReadOnly = True
        txtNilaiAkhir.Size = New Size(180, 31)
        txtNilaiAkhir.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 41)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 25)
        Label7.TabIndex = 0
        Label7.Text = "Nilai Akhir"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnKembali)
        GroupBox4.Controls.Add(btnReset)
        GroupBox4.Controls.Add(btnSimpan)
        GroupBox4.Controls.Add(btnHitung)
        GroupBox4.Location = New Point(12, 636)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(776, 93)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Aksi"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(406, 42)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(209, 34)
        btnKembali.TabIndex = 3
        btnKembali.Text = "Kembali ke Dashboard"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(274, 42)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(147, 42)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 1
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(17, 42)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(lblInfoGrade)
        GroupBox5.Location = New Point(429, 12)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(359, 376)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        GroupBox5.Text = "Informasi Grade dan Status"
        ' 
        ' lblInfoGrade
        ' 
        lblInfoGrade.Location = New Point(6, 41)
        lblInfoGrade.Name = "lblInfoGrade"
        lblInfoGrade.Size = New Size(347, 332)
        lblInfoGrade.TabIndex = 0
        lblInfoGrade.Text = "-"
        ' 
        ' FormInputNilai
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 761)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
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
