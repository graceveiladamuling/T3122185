Imports System.Data.Odbc
Public Class frmLogin
    Dim cPassLogin, cStatusUser As String
    Private Sub frmLogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        txtUser.Text = GetSetting("SisfoAkademik", "Data", "User", "")
        txtPass.UseSystemPasswordChar = True
        btnPass.Visible = False

    End Sub
End Class
    
