<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnPass = New System.Windows.Forms.Button()
        Me.chkRemember = New System.Windows.Forms.CheckBox()
        Me.LinkDaftar = New System.Windows.Forms.LinkLabel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.LinkLupaPassword = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(97, 161)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(232, 20)
        Me.txtUser.TabIndex = 2
        '
        'btnPass
        '
        Me.btnPass.Location = New System.Drawing.Point(350, 188)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(62, 23)
        Me.btnPass.TabIndex = 3
        Me.btnPass.Text = "Button1"
        Me.btnPass.UseVisualStyleBackColor = True
        '
        'chkRemember
        '
        Me.chkRemember.AutoSize = True
        Me.chkRemember.Location = New System.Drawing.Point(97, 221)
        Me.chkRemember.Name = "chkRemember"
        Me.chkRemember.Size = New System.Drawing.Size(128, 17)
        Me.chkRemember.TabIndex = 4
        Me.chkRemember.Text = "Remember Username"
        Me.chkRemember.UseVisualStyleBackColor = True
        '
        'LinkDaftar
        '
        Me.LinkDaftar.AutoSize = True
        Me.LinkDaftar.LinkColor = System.Drawing.Color.White
        Me.LinkDaftar.Location = New System.Drawing.Point(94, 322)
        Me.LinkDaftar.Name = "LinkDaftar"
        Me.LinkDaftar.Size = New System.Drawing.Size(61, 13)
        Me.LinkDaftar.TabIndex = 5
        Me.LinkDaftar.TabStop = True
        Me.LinkDaftar.Text = "Daftar Baru"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(97, 191)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(232, 20)
        Me.txtPass.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(156, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnMasuk.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnMasuk.Location = New System.Drawing.Point(97, 244)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(232, 41)
        Me.btnMasuk.TabIndex = 8
        Me.btnMasuk.Text = "Masuk"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'LinkLupaPassword
        '
        Me.LinkLupaPassword.AutoSize = True
        Me.LinkLupaPassword.LinkColor = System.Drawing.Color.White
        Me.LinkLupaPassword.Location = New System.Drawing.Point(249, 322)
        Me.LinkLupaPassword.Name = "LinkLupaPassword"
        Me.LinkLupaPassword.Size = New System.Drawing.Size(80, 13)
        Me.LinkLupaPassword.TabIndex = 9
        Me.LinkLupaPassword.TabStop = True
        Me.LinkLupaPassword.Text = "Lupa Password"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(437, 371)
        Me.Controls.Add(Me.LinkLupaPassword)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.LinkDaftar)
        Me.Controls.Add(Me.chkRemember)
        Me.Controls.Add(Me.btnPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents btnPass As System.Windows.Forms.Button
    Friend WithEvents chkRemember As System.Windows.Forms.CheckBox
    Friend WithEvents LinkDaftar As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMasuk As System.Windows.Forms.Button
    Friend WithEvents LinkLupaPassword As System.Windows.Forms.LinkLabel

End Class
