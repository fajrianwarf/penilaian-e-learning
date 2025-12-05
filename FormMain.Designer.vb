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
        FileToolStripMenuItem = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        mnuDataSiswa = New ToolStripMenuItem()
        mnuDataMapel = New ToolStripMenuItem()
        PenilaianToolStripMenuItem = New ToolStripMenuItem()
        mnuInputNilai = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        mnuRekapNilai = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        mnuTentang = New ToolStripMenuItem()
        tabMain = New TabControl()
        tabDashboard = New TabPage()
        grpRingkasan = New GroupBox()
        lblJumlahMapel = New Label()
        Label2 = New Label()
        lblJumlahSiswa = New Label()
        Label1 = New Label()
        tabInfo = New TabPage()
        MenuStrip1.SuspendLayout()
        tabMain.SuspendLayout()
        tabDashboard.SuspendLayout()
        grpRingkasan.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterToolStripMenuItem, PenilaianToolStripMenuItem, LaporanToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuKeluar})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(107, 22)
        mnuKeluar.Text = "Keluar"
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
        mnuTentang.Size = New Size(180, 22)
        mnuTentang.Text = "Tentang Aplikasi"
        ' 
        ' tabMain
        ' 
        tabMain.Controls.Add(tabDashboard)
        tabMain.Controls.Add(tabInfo)
        tabMain.Dock = DockStyle.Fill
        tabMain.Location = New Point(0, 24)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(800, 426)
        tabMain.TabIndex = 1
        ' 
        ' tabDashboard
        ' 
        tabDashboard.Controls.Add(grpRingkasan)
        tabDashboard.Location = New Point(4, 24)
        tabDashboard.Name = "tabDashboard"
        tabDashboard.Padding = New Padding(3)
        tabDashboard.Size = New Size(792, 398)
        tabDashboard.TabIndex = 0
        tabDashboard.Text = "Dashboard"
        tabDashboard.UseVisualStyleBackColor = True
        ' 
        ' grpRingkasan
        ' 
        grpRingkasan.Controls.Add(lblJumlahMapel)
        grpRingkasan.Controls.Add(Label2)
        grpRingkasan.Controls.Add(lblJumlahSiswa)
        grpRingkasan.Controls.Add(Label1)
        grpRingkasan.Location = New Point(0, 6)
        grpRingkasan.Name = "grpRingkasan"
        grpRingkasan.Size = New Size(472, 134)
        grpRingkasan.TabIndex = 0
        grpRingkasan.TabStop = False
        grpRingkasan.Text = "Ringkasan Data"
        ' 
        ' lblJumlahMapel
        ' 
        lblJumlahMapel.AutoSize = True
        lblJumlahMapel.Location = New Point(155, 56)
        lblJumlahMapel.Name = "lblJumlahMapel"
        lblJumlahMapel.Size = New Size(13, 15)
        lblJumlahMapel.TabIndex = 3
        lblJumlahMapel.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 15)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah Mata Pelajaran"
        ' 
        ' lblJumlahSiswa
        ' 
        lblJumlahSiswa.AutoSize = True
        lblJumlahSiswa.Location = New Point(155, 29)
        lblJumlahSiswa.Name = "lblJumlahSiswa"
        lblJumlahSiswa.Size = New Size(13, 15)
        lblJumlahSiswa.TabIndex = 1
        lblJumlahSiswa.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 0
        Label1.Text = "Jumlah Siswa"
        ' 
        ' tabInfo
        ' 
        tabInfo.Location = New Point(4, 24)
        tabInfo.Name = "tabInfo"
        tabInfo.Padding = New Padding(3)
        tabInfo.Size = New Size(792, 398)
        tabInfo.TabIndex = 1
        tabInfo.Text = "Info Aplikasi"
        tabInfo.UseVisualStyleBackColor = True
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tabMain)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormMain"
        Text = "Aplikasi Penilaian E-Learning"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        tabMain.ResumeLayout(False)
        tabDashboard.ResumeLayout(False)
        grpRingkasan.ResumeLayout(False)
        grpRingkasan.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDataSiswa As ToolStripMenuItem
    Friend WithEvents mnuDataMapel As ToolStripMenuItem
    Friend WithEvents PenilaianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuInputNilai As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuRekapNilai As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuTentang As ToolStripMenuItem
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabDashboard As TabPage
    Friend WithEvents tabInfo As TabPage
    Friend WithEvents grpRingkasan As GroupBox
    Friend WithEvents lblJumlahMapel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblJumlahSiswa As Label
    Friend WithEvents Label1 As Label

End Class
