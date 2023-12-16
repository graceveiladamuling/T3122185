Imports System.Data.Odbc

Public Class frmEntryUser
    Dim Level() = {"Admin", "User"}
    Dim Status_Aktif() = {"Aktif", "Tidak"}
    Dim cPassSHA256 As String

    Private Sub frmUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub frmUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each i As String In Level
            cboLevel.Items.Add(i)
        Next
        cboLevel.SelectedIndex = 1
        For Each i As String In Status_Aktif
            cboStatus.Items.Add(i)
        Next
        cboStatus_Aktif.SelectedIndex = 0
        If tblEdit = False Then
            Call databaru()
            Call tidaksiapisi()
        Else
 cmd = New OdbcCommand("select * from tbuser where user_id='" & txtuserId.Text
& "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                Call siapisi()
                txtUserName.Text = rd.Item("nama_user")
                cboLevel.Text = rd.Item("level")
                cboStatus_Aktif.Text = rd.Item("status")
                txtUserId.Enabled = False
            End If
        End If
    End Sub

    Sub databaru()
        txtUserName.Text = ""
        cboLevel.SelectedIndex = 1
        cboStatus_Aktif.SelectedIndex = 0
        txtUserName.Focus()
    End Sub
    Sub siapisi()
        txtUserName.Enabled = True
        cboLevel.Enabled = True
        cboStatus_Aktif.Enabled = True
        btnSimpan.Enabled = True
    End Sub
    Sub tidaksiapisi()
        txtUserName.Enabled = False
        cboLevel.Enabled = False
        cboStatus_Aktif.Enabled = False
        btnSimpan.Enabled = False
    End Sub
    Private Sub txtUserId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserId.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OdbcCommand("select * from tbuser where user_id='" & txtUserId.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txtUserName.Text = rd.Item("nama_user")
                cboLevel.Text = rd.Item("level")
                cboStatus_Aktif.Text = rd.Item("status")
                Call siapisi()
                txtUserId.Enabled = False
            Else
                Call databaru()
                Call siapisi()
            End If
        End If
    End Sub
    Private Sub txtUserId_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserId.Validated
        btnSimpan.Enabled = True
    End Sub
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Call Validasi()
        If Valid = True Then
            cPassSHA256 = SHA256(txtUserId.Text)
            cmd = New OdbcCommand("Select * from tbuser where user_id='" & txtUserId.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "Insert into tbuser" (User_id,nama_user,password,level,status) values " & _ "('" & txtuserId.Text & "','" & txtUserName.Text & "','" & cPassSHA256 & "','" & cboLevel.Text & "','" & cboStatus.Text & "')"
                cmd = New OdbcCommand(sqltambah, Conn)
            Else
                Dim sqledit As String = "Update tbuser set " & _
                "nama_user='" & txtUserName.Text & "', " & _
                "level='" & cboLevel.Text & "', " & _
                "status='" & cboStatus_Aktif.Text & "' where user_id='" & txtUserId.Text & "'"
                cmd = New OdbcCommand(sqledit, Conn)
            End If
            cmd.ExecuteNonQuery()
            Me.Close()
            Me.Visible = False
            End
    End Sub
    Sub Validasi()
        If txtUserName.Text = "" Then
            MsgBox("Nama User Belum diisi", , "Perhatian...!")
            txtUserName.Focus()
            Valid = False
            Exit Sub
        Else
            Valid = True
        End If
        If cboLevel.Text = "" Then
            MsgBox("Level User Belum diisi", , "Perhatian...!")
            cboLevel.Focus()
            Valid = False
            Exit Sub
        Else
            Valid = True
        End If
    End Sub
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
        Me.Visible = False
    End Sub
End Class