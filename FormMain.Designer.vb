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
        MenuStrip1.SuspendLayout()
        grpRingkasan.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MasterToolStripMenuItem, PenilaianToolStripMenuItem, LaporanToolStripMenuItem, HelpToolStripMenuItem, btnExit})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(1143, 35)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDataSiswa, mnuDataMapel})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(82, 29)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' mnuDataSiswa
        ' 
        mnuDataSiswa.Name = "mnuDataSiswa"
        mnuDataSiswa.Size = New Size(270, 34)
        mnuDataSiswa.Text = "Data Siswa"
        ' 
        ' mnuDataMapel
        ' 
        mnuDataMapel.Name = "mnuDataMapel"
        mnuDataMapel.Size = New Size(270, 34)
        mnuDataMapel.Text = "Data Mata Pelajaran"
        ' 
        ' PenilaianToolStripMenuItem
        ' 
        PenilaianToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuInputNilai})
        PenilaianToolStripMenuItem.Name = "PenilaianToolStripMenuItem"
        PenilaianToolStripMenuItem.Size = New Size(96, 29)
        PenilaianToolStripMenuItem.Text = "Penilaian"
        ' 
        ' mnuInputNilai
        ' 
        mnuInputNilai.Name = "mnuInputNilai"
        mnuInputNilai.Size = New Size(270, 34)
        mnuInputNilai.Text = "Input Nilai"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuRekapNilai})
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(92, 29)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' mnuRekapNilai
        ' 
        mnuRekapNilai.Name = "mnuRekapNilai"
        mnuRekapNilai.Size = New Size(270, 34)
        mnuRekapNilai.Text = "Rekap Nilai"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuTentang})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 29)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' mnuTentang
        ' 
        mnuTentang.Name = "mnuTentang"
        mnuTentang.Size = New Size(270, 34)
        mnuTentang.Text = "Tentang Aplikasi"
        ' 
        ' btnExit
        ' 
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(76, 29)
        btnExit.Text = "Keluar"
        ' 
        ' lblDashboardSubtitle
        ' 
        lblDashboardSubtitle.AutoSize = True
        lblDashboardSubtitle.Location = New Point(16, 84)
        lblDashboardSubtitle.Name = "lblDashboardSubtitle"
        lblDashboardSubtitle.Size = New Size(463, 25)
        lblDashboardSubtitle.TabIndex = 5
        lblDashboardSubtitle.Text = "Ringkasan data siswa, mata pelajaran, dan hasil penilaian."
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.Location = New Point(12, 44)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(410, 38)
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
        grpRingkasan.Location = New Point(16, 123)
        grpRingkasan.Margin = New Padding(4, 5, 4, 5)
        grpRingkasan.Name = "grpRingkasan"
        grpRingkasan.Padding = New Padding(4, 5, 4, 5)
        grpRingkasan.Size = New Size(674, 260)
        grpRingkasan.TabIndex = 3
        grpRingkasan.TabStop = False
        grpRingkasan.Text = "Ringkasan Data"
        ' 
        ' lblPersenLulus
        ' 
        lblPersenLulus.AutoSize = True
        lblPersenLulus.Location = New Point(222, 182)
        lblPersenLulus.Margin = New Padding(4, 0, 4, 0)
        lblPersenLulus.Name = "lblPersenLulus"
        lblPersenLulus.Size = New Size(39, 25)
        lblPersenLulus.TabIndex = 7
        lblPersenLulus.Text = "- %"
        lblPersenLulus.UseMnemonic = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 182)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 25)
        Label4.TabIndex = 6
        Label4.Text = "Persentase Lulus"
        ' 
        ' lblJumlahPenilaian
        ' 
        lblJumlahPenilaian.AutoSize = True
        lblJumlahPenilaian.Location = New Point(222, 140)
        lblJumlahPenilaian.Margin = New Padding(4, 0, 4, 0)
        lblJumlahPenilaian.Name = "lblJumlahPenilaian"
        lblJumlahPenilaian.Size = New Size(22, 25)
        lblJumlahPenilaian.TabIndex = 5
        lblJumlahPenilaian.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 140)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 25)
        Label3.TabIndex = 4
        Label3.Text = "Jumlah Penilaian"
        ' 
        ' lblJumlahMapel
        ' 
        lblJumlahMapel.AutoSize = True
        lblJumlahMapel.Location = New Point(222, 95)
        lblJumlahMapel.Margin = New Padding(4, 0, 4, 0)
        lblJumlahMapel.Name = "lblJumlahMapel"
        lblJumlahMapel.Size = New Size(22, 25)
        lblJumlahMapel.TabIndex = 3
        lblJumlahMapel.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 95)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 25)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah Mata Pelajaran"
        ' 
        ' lblJumlahSiswa
        ' 
        lblJumlahSiswa.AutoSize = True
        lblJumlahSiswa.Location = New Point(222, 50)
        lblJumlahSiswa.Margin = New Padding(4, 0, 4, 0)
        lblJumlahSiswa.Name = "lblJumlahSiswa"
        lblJumlahSiswa.Size = New Size(22, 25)
        lblJumlahSiswa.TabIndex = 1
        lblJumlahSiswa.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 50)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 25)
        Label1.TabIndex = 0
        Label1.Text = "Jumlah Siswa"
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(lblDashboardSubtitle)
        Controls.Add(lblDashboardTitle)
        Controls.Add(grpRingkasan)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
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

End Class
