<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataFakultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramStudiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapDataMhsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapDataDosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapMataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssCopyRight = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssWaktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(555, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataUserToolStripMenuItem, Me.DataFakultasToolStripMenuItem, Me.ProgramStudiToolStripMenuItem, Me.MahasiswaToolStripMenuItem, Me.DosenToolStripMenuItem, Me.MataKuliahToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'DataFakultasToolStripMenuItem
        '
        Me.DataFakultasToolStripMenuItem.Name = "DataFakultasToolStripMenuItem"
        Me.DataFakultasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataFakultasToolStripMenuItem.Text = "Data Fakultas"
        '
        'ProgramStudiToolStripMenuItem
        '
        Me.ProgramStudiToolStripMenuItem.Name = "ProgramStudiToolStripMenuItem"
        Me.ProgramStudiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgramStudiToolStripMenuItem.Text = "Program Studi"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        '
        'DosenToolStripMenuItem
        '
        Me.DosenToolStripMenuItem.Name = "DosenToolStripMenuItem"
        Me.DosenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DosenToolStripMenuItem.Text = "Dosen"
        '
        'MataKuliahToolStripMenuItem
        '
        Me.MataKuliahToolStripMenuItem.Name = "MataKuliahToolStripMenuItem"
        Me.MataKuliahToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MataKuliahToolStripMenuItem.Text = "Mata Kuliah"
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProsesToolStripMenuItem.Text = "Proses"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapDataMhsToolStripMenuItem, Me.LapDataDosenToolStripMenuItem, Me.LapMataKuliahToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LapDataMhsToolStripMenuItem
        '
        Me.LapDataMhsToolStripMenuItem.Name = "LapDataMhsToolStripMenuItem"
        Me.LapDataMhsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LapDataMhsToolStripMenuItem.Text = "Lap.Data Mhs"
        '
        'LapDataDosenToolStripMenuItem
        '
        Me.LapDataDosenToolStripMenuItem.Name = "LapDataDosenToolStripMenuItem"
        Me.LapDataDosenToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LapDataDosenToolStripMenuItem.Text = "Lap. Data Dosen"
        '
        'LapMataKuliahToolStripMenuItem
        '
        Me.LapMataKuliahToolStripMenuItem.Name = "LapMataKuliahToolStripMenuItem"
        Me.LapMataKuliahToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LapMataKuliahToolStripMenuItem.Text = "Lap. Mata Kuliah"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(555, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Aquamarine
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssCopyRight, Me.tssUser, Me.tssLevel, Me.tssWaktu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 255)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(555, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssCopyRight
        '
        Me.tssCopyRight.Name = "tssCopyRight"
        Me.tssCopyRight.Size = New System.Drawing.Size(60, 17)
        Me.tssCopyRight.Text = "Copyright"
        '
        'tssUser
        '
        Me.tssUser.Name = "tssUser"
        Me.tssUser.Size = New System.Drawing.Size(30, 17)
        Me.tssUser.Text = "User"
        '
        'tssLevel
        '
        Me.tssLevel.Name = "tssLevel"
        Me.tssLevel.Size = New System.Drawing.Size(34, 17)
        Me.tssLevel.Text = "Level"
        '
        'tssWaktu
        '
        Me.tssWaktu.Name = "tssWaktu"
        Me.tssWaktu.Size = New System.Drawing.Size(41, 17)
        Me.tssWaktu.Text = "Waktu"
        '
        'frmMenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 277)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuAdmin"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssCopyRight As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssWaktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataFakultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramStudiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DosenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MataKuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDataMhsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDataDosenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapMataKuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
