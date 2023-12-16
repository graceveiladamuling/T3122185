<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLatihan1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtT4Lahir = New System.Windows.Forms.TextBox()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbtLaki = New System.Windows.Forms.RadioButton()
        Me.cboAgama = New System.Windows.Forms.ComboBox()
        Me.clbPilProdi = New System.Windows.Forms.CheckedListBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.nudGelDaftar = New System.Windows.Forms.NumericUpDown()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudGelDaftar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Pendaftaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tgl. Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Agama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-1, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pilihan Program Studi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Gel. Pendaftran"
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(112, 22)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(134, 20)
        Me.txtNim.TabIndex = 7
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(112, 54)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(222, 20)
        Me.txtNama.TabIndex = 8
        '
        'txtT4Lahir
        '
        Me.txtT4Lahir.Location = New System.Drawing.Point(112, 85)
        Me.txtT4Lahir.Name = "txtT4Lahir"
        Me.txtT4Lahir.Size = New System.Drawing.Size(222, 20)
        Me.txtT4Lahir.TabIndex = 9
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglLahir.Location = New System.Drawing.Point(112, 119)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(97, 20)
        Me.dtpTglLahir.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtPerempuan)
        Me.GroupBox1.Controls.Add(Me.rbtLaki)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 49)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'rbtPerempuan
        '
        Me.rbtPerempuan.AutoSize = True
        Me.rbtPerempuan.Location = New System.Drawing.Point(76, 19)
        Me.rbtPerempuan.Name = "rbtPerempuan"
        Me.rbtPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbtPerempuan.TabIndex = 1
        Me.rbtPerempuan.TabStop = True
        Me.rbtPerempuan.Text = "Perempuan"
        Me.rbtPerempuan.UseVisualStyleBackColor = True
        '
        'rbtLaki
        '
        Me.rbtLaki.AutoSize = True
        Me.rbtLaki.Location = New System.Drawing.Point(6, 19)
        Me.rbtLaki.Name = "rbtLaki"
        Me.rbtLaki.Size = New System.Drawing.Size(64, 17)
        Me.rbtLaki.TabIndex = 0
        Me.rbtLaki.TabStop = True
        Me.rbtLaki.Text = "Laki-laki"
        Me.rbtLaki.UseVisualStyleBackColor = True
        '
        'cboAgama
        '
        Me.cboAgama.FormattingEnabled = True
        Me.cboAgama.Location = New System.Drawing.Point(112, 217)
        Me.cboAgama.Name = "cboAgama"
        Me.cboAgama.Size = New System.Drawing.Size(134, 21)
        Me.cboAgama.TabIndex = 12
        '
        'clbPilProdi
        '
        Me.clbPilProdi.FormattingEnabled = True
        Me.clbPilProdi.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen", "Ilmu Hukum", "Akuntansi"})
        Me.clbPilProdi.Location = New System.Drawing.Point(112, 254)
        Me.clbPilProdi.Name = "clbPilProdi"
        Me.clbPilProdi.Size = New System.Drawing.Size(164, 94)
        Me.clbPilProdi.TabIndex = 13
        '
        'nudGelDaftar
        '
        Me.nudGelDaftar.Location = New System.Drawing.Point(115, 359)
        Me.nudGelDaftar.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudGelDaftar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGelDaftar.Name = "nudGelDaftar"
        Me.nudGelDaftar.Size = New System.Drawing.Size(67, 20)
        Me.nudGelDaftar.TabIndex = 14
        Me.nudGelDaftar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnBaru
        '
        Me.btnBaru.ForeColor = System.Drawing.Color.Black
        Me.btnBaru.Location = New System.Drawing.Point(410, 286)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 43)
        Me.btnBaru.TabIndex = 15
        Me.btnBaru.Text = "Baru"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(410, 335)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 43)
        Me.btnKeluar.TabIndex = 16
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.graceT3122185.My.Resources.Resources.WhatsApp_Image_2023_09_08_at_17_38_49
        Me.PictureBox1.Location = New System.Drawing.Point(385, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmLatihan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(517, 390)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.nudGelDaftar)
        Me.Controls.Add(Me.clbPilProdi)
        Me.Controls.Add(Me.cboAgama)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpTglLahir)
        Me.Controls.Add(Me.txtT4Lahir)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLatihan1"
        Me.Text = "Latihan 1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudGelDaftar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNim As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtT4Lahir As System.Windows.Forms.TextBox
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rbtLaki As System.Windows.Forms.RadioButton
    Friend WithEvents cboAgama As System.Windows.Forms.ComboBox
    Friend WithEvents clbPilProdi As System.Windows.Forms.CheckedListBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents nudGelDaftar As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnBaru As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
