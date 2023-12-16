Imports System.Data.Odbc

Public Class frmListUser
    Dim cPassSHA256 As String
    Private Sub frmListUser_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCariNama.Text = ""
        Tampilkan()
    End Sub
    Private Sub frmUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub

    Sub Tampilkan()
        Dim btnReset As New DataGridViewButtonColumn()
        Dim btnEdit As New DataGridViewButtonColumn()
        Dim btnHapus As New DataGridViewButtonColumn()
        DGV.Columns.Clear()
        If txtCariNama.Text <> "" Then

        da = New OdbcDataAdapter("Select User_Id,nama_user,level,status from tbuser where(" & ")%' & txtCariNama.Text & "' order by user_Id", Conn)
        Else
            da = New OdbcDataAdapter("Select User_Id,nama_user,level,status from tbuser order by user_Id", Conn)
        End If

        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbuser")
        DGV.DataSource = (ds.Tables("tbuser"))
        DGV.ReadOnly = True
        DGV.AllowUserToAddRows = False
        DGV.Columns(0).Width = 100
        DGV.Columns(1).Width = 200
        DGV.Columns(2).Width = 60
        DGV.Columns(3).Width = 60
        DGV.RowTemplate.Height = 25
        ' DGV.GridColor = Color.Blue
        DGV.DefaultCellStyle.ForeColor = Color.Blue
        DGV.RowHeadersDefaultCellStyle.BackColor = Color.LightYellow
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.ColumnHeadersDefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(2).DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter

        DGV.Columns(0).HeaderText = "User Id"
        DGV.Columns(1).HeaderText = "Nama User"
        DGV.Columns(2).HeaderText = "Level"
        DGV.Columns(3).HeaderText = "Status"
        DGV.Columns().Add(btnReset)
        btnReset.HeaderText = ""
        btnReset.Name = "btnReset"
        btnReset.Text = "Reset"
        btnReset.UseColumnTextForButtonValue = True
        DGV.Columns().Add(btnEdit)
        btnEdit.HeaderText = ""
        btnEdit.Name = "btEdit"
        btnEdit.Text = "Edit"
        btnEdit.DefaultCellStyle.ForeColor = Color.Maroon
        btnEdit.UseColumnTextForButtonValue = True
        DGV.Columns().Add(btnHapus)
        btnHapus.HeaderText = ""
        btnHapus.Name = "btHapus"
        btnHapus.Text = "Hapus"
        btnHapus.DefaultCellStyle.ForeColor = Color.Maroon
        btnHapus.UseColumnTextForButtonValue = True
        DGV.Columns(4).Width = 60
        DGV.Columns(5).Width = 60
        DGV.Columns(6).Width = 60

    End Sub
    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim cUser_id As String
        If e.ColumnIndex = 4 Then
            tblEdit = True
            cUser_id = DGV.SelectedRows.Item(0).Cells(0).Value()
            cPassSHA256 = SHA256(cUser_id)
            If MessageBox.Show("Yakin akan Direset..?", "Reset Password", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("Select * from tbuser where user_id='" & cUser_id & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Dim sqledit As String = "Update tbuser set " & _
                    "password='" & cPassSHA256 & "' where user_id='" & cUser_id & "'"
                    cmd = New OdbcCommand(sqledit, Conn)
                    cmd.ExecuteNonQuery(MsgBox("Password Berhasil direset", MsgBoxStyle.Critical, "Sukses ...!"))
                    Exit Sub
                End If
            End If
        End If
        If e.ColumnIndex = 5 Then
            tblEdit = True
            frmEntryUser.txtuserId.Text = DGV.SelectedRows.Item(0).Cells(0).Value()
            frmEntryUser.Show()
        End If

        If e.ColumnIndex = 6 Then
            cUser_id = DGV.SelectedRows.Item(0).Cells(0).Value()
            cmd = New OdbcCommand("Select count(*) as jml from tbuser ", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.Item(0) = 1 Then
                MsgBox("Maaf..., Data User tidak dapat dihapus", MsgBoxStyle.Critical, "Perhatian...!")
                Exit Sub
            Else
                If MessageBox.Show("Yakin akan dihapus..?", "Hapus Data", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cmd = New OdbcCommand("Delete from tbuser where user_id='" &
                   cUser_id & "'", Conn)
                    cmd.ExecuteNonQuery()
                    Tampilkan()
                End If
            End If
        End If
    End Sub
    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        tblEdit = False
        frmEntryUser.Show(Me)
    End Sub
    Private Sub txtCariNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariNama.TextChanged
        Tampilkan()
    End Sub
End Class