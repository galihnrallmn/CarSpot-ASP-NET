Imports MySql.Data.MySqlClient

Public Class Merek_m
    Dim merek As String

    Public Function Lihat() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT  idmerek AS ID, MEREK FROM merek ORDER BY idmerek DESC"

        Dim m As New KoneksiDB
        dt = m.GetResult(query)

        Return dt
    End Function

    Public Function Tambah() As Boolean
        Dim query As String = "INSERT INTO merek VALUES (NULL, @merek)"
        Dim parameters As MySqlParameter() = {
            New MySqlParameter("@merek", merek)
        }

        Dim k As New KoneksiDB
        Dim status As Boolean = k.Execute(query, parameters)
        Return status
    End Function

    Public Sub SetMerek(merek As String)
        Me.merek = merek
    End Sub

    Public Function LihatDetail(id As Integer) As DataTable
        Dim dt As DataTable
        Dim query As String = "SELECT merek FROM merek WHERE idmerek = " & id

        Dim k As New KoneksiDB
        dt = k.GetResult(query)

        Return dt
    End Function

    Public Function Ubah(id As Integer) As Boolean
        Dim query As String = "UPDATE merek SET merek = @merek Where idmerek = " & id
        Dim params As MySqlParameter() = {
        New MySqlParameter("@merek", merek)
        }

        Dim status As Boolean
        Dim k As New KoneksiDB
        status = k.Execute(query, params)

        Return status
    End Function

    Public Function Hapus(id As Integer) As Boolean
        Dim query As String = "DELETE FROM merek WHERE idmerek = @id"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@id", id)
            }
        Dim status As Boolean
        Dim k As New KoneksiDB
        status = k.Execute(query, params)

        Return status
    End Function
End Class
