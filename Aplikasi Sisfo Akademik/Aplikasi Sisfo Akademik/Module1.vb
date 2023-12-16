Imports System.Data.Odbc
Imports System.Text
Imports System.Security.Cryptography
Module Module1
    Public Conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public rd As OdbcDataReader
    Public rd2 As OdbcDataReader
    Public cmd As OdbcCommand
    Public cLevelUser, cUserId, mPath, cNamaUser, cKode_Prodi, cKode_Fak, cNIM As String
    Public tblEdit, Valid As Boolean
    Public Sub Koneksi()
        'Procedure koneksi database dengan MySql
        mPath = Application.StartupPath & "\"
        Try
            Conn = New OdbcConnection("DSN=dsnAkademik;MultipleActiveResultSets=True")
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal", vbExclamation, "Koneksi Gagal")
        End Try
    End Sub
    Public Function StripNonAlphaNum(ByRef sText As String) As String
        Dim strRegex As String = "[^a-zA-Z0-9 -]"
        Dim rgx As New System.Text.RegularExpressions.Regex(strRegex)
        Return rgx.Replace(sText, "")
    End Function
    Public Function SHA256(ByVal Content As String) As String
        'Function untuk mengenkrip password dengan algoritma SHA256
        Dim MoleCul3 As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = MoleCul3.ComputeHash(ByteString)
        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString
    End Function

End Module
