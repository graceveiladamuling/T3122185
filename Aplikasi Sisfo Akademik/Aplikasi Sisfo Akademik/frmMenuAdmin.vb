Public Class frmMenuAdmin

    Private Sub frmMenuAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Sistem Informasi Akademik Unisan Gorontalo"    End Sub

    Private Sub mnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnKeluar.Click
        If MessageBox.Show("Benar Ingin Keluar dari Sistem..?", "Konfirmasi", _
                           MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Conn.Close()
            End
        End If
    End Sub
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        mnKeluar_Click(sender, e)    End Sub
    Private Sub mnDataUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDataUser.Click
        frmListUser.Show()
        frmListUser.MdiParent = Me
    End Sub
End Class