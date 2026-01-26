<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        mnuDataSiswa = New ToolStripMenuItem()
        mnuDataMapel = New ToolStripMenuItem()
        PenilaianToolStripMenuItem = New ToolStripMenuItem()
        mnuInputNilai = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        mnuRekapNilai = New ToolStripMenuItem()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SaveDataCSVToolStripMenuItem = New ToolStripMenuItem()
        UploadDataCSVToolStripMenuItem = New ToolStripMenuItem()
        PrintAllDataPDFToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        mnuTentang = New ToolStripMenuItem()
        btnExit = New ToolStripMenuItem()
        lblDashboardSubtitle = New Label()
        lblDashboardTitle = New Label()
        grpRingkasan = New GroupBox()
        lblPersenLulus = New Label()
        Label4 = New Label()
        lblJumlahPenilaian = New Label()
        Label3 = New Label()
        lblJumlahMapel = New Label()
        Label2 = New Label()
        lblJumlahSiswa = New Label()
        Label1 = New Label()
        saveData = New Button()
        uploadData = New Button()
        printAllData = New Button()
        MenuStrip1.SuspendLayout()
        grpRingkasan.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MasterToolStripMenuItem, PenilaianToolStripMenuItem, LaporanToolStripMenuItem, FileToolStripMenuItem, HelpToolStripMenuItem, btnExit})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDataSiswa, mnuDataMapel})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(55, 20)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' mnuDataSiswa
        ' 
        mnuDataSiswa.Name = "mnuDataSiswa"
        mnuDataSiswa.Size = New Size(179, 22)
        mnuDataSiswa.Text = "Data Siswa"
        ' 
        ' mnuDataMapel
        ' 
        mnuDataMapel.Name = "mnuDataMapel"
        mnuDataMapel.Size = New Size(179, 22)
        mnuDataMapel.Text = "Data Mata Pelajaran"
        ' 
        ' PenilaianToolStripMenuItem
        ' 
        PenilaianToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuInputNilai})
        PenilaianToolStripMenuItem.Name = "PenilaianToolStripMenuItem"
        PenilaianToolStripMenuItem.Size = New Size(67, 20)
        PenilaianToolStripMenuItem.Text = "Penilaian"
        ' 
        ' mnuInputNilai
        ' 
        mnuInputNilai.Name = "mnuInputNilai"
        mnuInputNilai.Size = New Size(129, 22)
        mnuInputNilai.Text = "Input Nilai"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuRekapNilai})
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(62, 20)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' mnuRekapNilai
        ' 
        mnuRekapNilai.Name = "mnuRekapNilai"
        mnuRekapNilai.Size = New Size(133, 22)
        mnuRekapNilai.Text = "Rekap Nilai"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SaveDataCSVToolStripMenuItem, UploadDataCSVToolStripMenuItem, PrintAllDataPDFToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' SaveDataCSVToolStripMenuItem
        ' 
        SaveDataCSVToolStripMenuItem.Name = "SaveDataCSVToolStripMenuItem"
        SaveDataCSVToolStripMenuItem.Size = New Size(175, 22)
        SaveDataCSVToolStripMenuItem.Text = "Save Data (CSV)"
        ' 
        ' UploadDataCSVToolStripMenuItem
        ' 
        UploadDataCSVToolStripMenuItem.Name = "UploadDataCSVToolStripMenuItem"
        UploadDataCSVToolStripMenuItem.Size = New Size(175, 22)
        UploadDataCSVToolStripMenuItem.Text = "Upload Data (CSV)"
        ' 
        ' PrintAllDataPDFToolStripMenuItem
        ' 
        PrintAllDataPDFToolStripMenuItem.Name = "PrintAllDataPDFToolStripMenuItem"
        PrintAllDataPDFToolStripMenuItem.Size = New Size(175, 22)
        PrintAllDataPDFToolStripMenuItem.Text = "Print All Data (PDF)"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuTentang})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' mnuTentang
        ' 
        mnuTentang.Name = "mnuTentang"
        mnuTentang.Size = New Size(161, 22)
        mnuTentang.Text = "Tentang Aplikasi"
        ' 
        ' btnExit
        ' 
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(52, 20)
        btnExit.Text = "Keluar"
        ' 
        ' lblDashboardSubtitle
        ' 
        lblDashboardSubtitle.AutoSize = True
        lblDashboardSubtitle.Location = New Point(11, 50)
        lblDashboardSubtitle.Margin = New Padding(2, 0, 2, 0)
        lblDashboardSubtitle.Name = "lblDashboardSubtitle"
        lblDashboardSubtitle.Size = New Size(309, 15)
        lblDashboardSubtitle.TabIndex = 5
        lblDashboardSubtitle.Text = "Ringkasan data siswa, mata pelajaran, dan hasil penilaian."
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.Location = New Point(8, 26)
        lblDashboardTitle.Margin = New Padding(2, 0, 2, 0)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(283, 25)
        lblDashboardTitle.TabIndex = 4
        lblDashboardTitle.Text = "Dashboard Penilaian E-Learning"
        ' 
        ' grpRingkasan
        ' 
        grpRingkasan.Controls.Add(lblPersenLulus)
        grpRingkasan.Controls.Add(Label4)
        grpRingkasan.Controls.Add(lblJumlahPenilaian)
        grpRingkasan.Controls.Add(Label3)
        grpRingkasan.Controls.Add(lblJumlahMapel)
        grpRingkasan.Controls.Add(Label2)
        grpRingkasan.Controls.Add(lblJumlahSiswa)
        grpRingkasan.Controls.Add(Label1)
        grpRingkasan.Location = New Point(11, 74)
        grpRingkasan.Name = "grpRingkasan"
        grpRingkasan.Size = New Size(472, 156)
        grpRingkasan.TabIndex = 3
        grpRingkasan.TabStop = False
        grpRingkasan.Text = "Ringkasan Data"
        ' 
        ' lblPersenLulus
        ' 
        lblPersenLulus.AutoSize = True
        lblPersenLulus.Location = New Point(155, 109)
        lblPersenLulus.Name = "lblPersenLulus"
        lblPersenLulus.Size = New Size(25, 15)
        lblPersenLulus.TabIndex = 7
        lblPersenLulus.Text = "- %"
        lblPersenLulus.UseMnemonic = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 15)
        Label4.TabIndex = 6
        Label4.Text = "Persentase Lulus"
        ' 
        ' lblJumlahPenilaian
        ' 
        lblJumlahPenilaian.AutoSize = True
        lblJumlahPenilaian.Location = New Point(155, 84)
        lblJumlahPenilaian.Name = "lblJumlahPenilaian"
        lblJumlahPenilaian.Size = New Size(13, 15)
        lblJumlahPenilaian.TabIndex = 5
        lblJumlahPenilaian.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 4
        Label3.Text = "Jumlah Penilaian"
        ' 
        ' lblJumlahMapel
        ' 
        lblJumlahMapel.AutoSize = True
        lblJumlahMapel.Location = New Point(155, 57)
        lblJumlahMapel.Name = "lblJumlahMapel"
        lblJumlahMapel.Size = New Size(13, 15)
        lblJumlahMapel.TabIndex = 3
        lblJumlahMapel.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 15)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah Mata Pelajaran"
        ' 
        ' lblJumlahSiswa
        ' 
        lblJumlahSiswa.AutoSize = True
        lblJumlahSiswa.Location = New Point(155, 30)
        lblJumlahSiswa.Name = "lblJumlahSiswa"
        lblJumlahSiswa.Size = New Size(13, 15)
        lblJumlahSiswa.TabIndex = 1
        lblJumlahSiswa.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 0
        Label1.Text = "Jumlah Siswa"
        ' 
        ' saveData
        ' 
        saveData.Location = New Point(11, 235)
        saveData.Margin = New Padding(2, 2, 2, 2)
        saveData.Name = "saveData"
        saveData.Size = New Size(78, 29)
        saveData.TabIndex = 6
        saveData.Text = "Save Data"
        saveData.UseVisualStyleBackColor = True
        ' 
        ' uploadData
        ' 
        uploadData.Location = New Point(94, 235)
        uploadData.Margin = New Padding(2, 2, 2, 2)
        uploadData.Name = "uploadData"
        uploadData.Size = New Size(100, 29)
        uploadData.TabIndex = 7
        uploadData.Text = "Upload Data"
        uploadData.UseVisualStyleBackColor = True
        ' 
        ' printAllData
        ' 
        printAllData.Location = New Point(382, 235)
        printAllData.Margin = New Padding(2, 2, 2, 2)
        printAllData.Name = "printAllData"
        printAllData.Size = New Size(102, 29)
        printAllData.TabIndex = 8
        printAllData.Text = "Print All Data"
        printAllData.UseVisualStyleBackColor = True
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(printAllData)
        Controls.Add(uploadData)
        Controls.Add(saveData)
        Controls.Add(lblDashboardSubtitle)
        Controls.Add(lblDashboardTitle)
        Controls.Add(grpRingkasan)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormMain"
        Text = "Aplikasi Penilaian E-Learning"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        grpRingkasan.ResumeLayout(False)
        grpRingkasan.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDataSiswa As ToolStripMenuItem
    Friend WithEvents mnuDataMapel As ToolStripMenuItem
    Friend WithEvents PenilaianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuInputNilai As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuRekapNilai As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuTentang As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents lblDashboardSubtitle As Label
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents grpRingkasan As GroupBox
    Friend WithEvents lblPersenLulus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblJumlahPenilaian As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblJumlahMapel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblJumlahSiswa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveData As Button
    Friend WithEvents uploadData As Button
    Friend WithEvents SaveDataCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadDataCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintAllDataPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents printAllData As Button

End Class
