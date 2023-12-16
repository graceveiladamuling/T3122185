Public Class frmLatihan1
    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        txtNim.Text = ""
        txtNama.Text = ""
        txtT4Lahir.Text = ""
        rbtLaki.Checked = False
        rbtPerempuan.Checked = False
        cboAgama.Text = ""
        clbPilProdi.SetItemChecked(0, False)
        clbPilProdi.SetItemChecked(1, False)
        clbPilProdi.SetItemChecked(2, False)
        clbPilProdi.SetItemChecked(3, False)
        clbPilProdi.SetItemChecked(4, False)
        nudGelDaftar.Value = 1
        txtNim.Focus()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
