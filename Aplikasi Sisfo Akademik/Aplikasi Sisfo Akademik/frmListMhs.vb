Imports System.Data.Odbc
Public Class frmListMhs
    Sub TampilProdi()
        CboProdi.Items.Clear()
        cmd = New OdbcCommand("select distinct nama_prodi from tbprogram_studi order by kode_prodi", Conn)
        rd = cmd.ExecuteReader
        While rd.Read
            CboProdi.Items.Add(rd.Item(0))
        End While
    End Sub
    
    Private Sub frmListMhs_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub frmListMhs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cKode_Prodi = ""
        Call TampilProdi()
        Call Tampilkandata()
    End Sub
    Sub Tampilkandata()
        Dim btnEdit As New DataGridViewButtonColumn()
        Dim btnHapus As New DataGridViewButtonColumn()
        DGV.Columns.Clear()
        DGV.Columns.Add("kol0", "NIM")
        DGV.Columns.Add("kol1", "Nama Mahasiswa")
        DGV.Columns.Add("kol2", "JK")
        DGV.Columns.Add("kol3", "Tempat Lahir")
        DGV.Columns.Add("kol4", "Tgl. Lahir")
        DGV.Columns.Add("kol5", "Agama")
        DGV.Columns.Add("kol6", "Thn Masuk")
        DGV.Columns.Add("kol7", "Status")
        DGV.Columns.Add("kol8", "Program Studi")
        Dim sql As String = "Select a.nim,a.nama_mhs,a.jenis_kel,a.t4_lahir,a.tgl_lahir, " & _
            " a.agama, a.tahun_masuk, a.status, b.nama_prodi from tbmahasiswa a, tbProgram_studi b " & _
            " where a.kode_prodi=b.kode_prodi " & _
            " and a.kode_prodi ='" & cKode_Prodi & "' order by a.nim"
        cmd = New OdbcCommand(sql, Conn)

        rd = cmd.ExecuteReader
        Dim i As Integer = 0
        While rd.Read
            DGV.Rows.Add()
            DGV.Item(0, i).Value = rd("nim")
            DGV.Item(1, i).Value = rd("nama_mhs")
            DGV.Item(2, i).Value = rd("jenis_kel")
            DGV.Item(3, i).Value = rd("t4_lahir")
            DGV.Item(4, i).Value = rd("tgl_lahir")
            DGV.Item(5, i).Value = rd("agama")
            DGV.Item(6, i).Value = rd("tahun_masuk")
            DGV.Item(7, i).Value = rd("status")
            DGV.Item(8, i).Value = rd("nama_prodi")
            i += 1
        End While

        rd.Close()
        DGV.ReadOnly = True
        DGV.AllowUserToAddRows = False
        DGV.Columns(0).Width = 60
        DGV.Columns(1).Width = 170
        DGV.Columns(2).Width = 50
        DGV.Columns(3).Width = 130
        DGV.GridColor = Color.Blue
        DGV.DefaultCellStyle.ForeColor = Color.Black
        DGV.RowHeadersDefaultCellStyle.BackColor = Color.DeepPink
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Format = "dd-MM-yyyy"
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
        DGV.Columns(9).Width = 60
        DGV.Columns(10).Width = 60
        txtJml.Text = DGV.RowCount
    End Sub
    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim cNama As String
        If e.ColumnIndex = 9 Then
            tblEdit = True
            frmMahasiswa.Text = "Edit Data Mahasiswa"
            cNIM = DGV.SelectedRows.Item(0).Cells(0).Value()
            cNama = DGV.SelectedRows.Item(0).Cells(1).Value()
            frmMahasiswa.Show()
        End If
        If e.ColumnIndex = 10 Then
            cNIM = DGV.SelectedRows.Item(0).Cells(0).Value()
            cNama = DGV.SelectedRows.Item(0).Cells(1).Value()

            If MessageBox.Show("Yakin akan dihapus..?" & Environment.NewLine & "" & _
                "atas nama : " & cNama.ToString, "Hapus Data", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                cmd = New OdbcCommand("Delete from tbmahasiswa where nim='" & cNIM & "'", Conn)
                cmd.ExecuteNonQuery()
                Tampilkandata()
            End If
        End If
    End Sub
    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        tblEdit = False
        frmMahasiswa.Text = "Tambah Data Mahasiswa"
        frmMahasiswa.Show()
    End Sub
    Private Sub CboProdi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProdi.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbprogram_studi where nama_prodi='" & CboProdi.Text & "' ", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            cKode_Prodi = rd.Item("kode_prodi")
            Call Tampilkandata()
        End If
    End Sub
End Class