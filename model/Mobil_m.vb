Imports MySql.Data.MySqlClient

Public Class Mobil_m
    Dim idmerek As Integer
    Dim model As String
    Dim tahun As String
    Dim warna As String
    Dim jaraktempuh As Integer
    Dim tranmisi As String
    Dim harga As Integer
    Dim foto As String


    Public Function Lihat() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT idmobil AS ID, merek.merek AS Merek, model AS Model, tahun AS Tahun, warna AS Warna, jaraktempuh AS ""Jarak Tempuh"", tranmisi AS Transmisi, harga AS Harga, foto AS Foto FROM mobil INNER JOIN merek ON mobil.idmerek = merek.idmerek ORDER BY idmobil DESC"

        Dim m As New KoneksiDB
        dt = m.GetResult(query)

        Return dt
    End Function

    Public Function LihatMobil() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT merek.merek AS Merek, model AS Model, tahun AS Tahun, warna AS Warna, jaraktempuh AS ""Jarak Tempuh"", tranmisi AS Transmisi, harga AS Harga, foto AS Foto FROM mobil INNER JOIN merek ON mobil.idmerek = merek.idmerek ORDER BY idmobil DESC"

        Dim m As New KoneksiDB
        dt = m.GetResult(query)

        Return dt
    End Function

    Public Function Tambah() As Boolean
        Dim query As String = "INSERT INTO mobil (idmobil, idmerek, model, tahun, warna, jaraktempuh, tranmisi, harga, foto) VALUES (NULL, @idmerek, @model, @tahun, @warna, @jaraktempuh, @tranmisi, @harga, @foto)"
        Dim parameters As MySqlParameter() = {
            New MySqlParameter("@idmerek", idmerek),
            New MySqlParameter("@model", model),
            New MySqlParameter("@tahun", tahun),
            New MySqlParameter("@warna", warna),
            New MySqlParameter("@jaraktempuh", jaraktempuh),
            New MySqlParameter("@tranmisi", tranmisi),
            New MySqlParameter("@harga", harga),
            New MySqlParameter("@foto", foto)
        }

        Dim k As New KoneksiDB
        Dim status As Boolean = k.Execute(query, parameters)
        Return status
    End Function

    Public Sub SetMobil(idmerek As Integer, model As String, tahun As String, warna As String, jaraktempuh As Integer, tranmisi As String, harga As Integer, foto As String)
        Me.idmerek = idmerek
        Me.idmerek = idmerek
        Me.model = model
        Me.tahun = tahun
        Me.warna = warna
        Me.jaraktempuh = jaraktempuh
        Me.tranmisi = tranmisi
        Me.harga = harga
        Me.foto = foto
    End Sub

    Public Function LihatDetail(id As Integer) As DataTable
        Dim dt As DataTable
        Dim query As String = "SELECT idmerek, model, tahun, warna, jaraktempuh, tranmisi, harga, foto FROM mobil WHERE idmobil = " & id

        Dim k As New KoneksiDB
        dt = k.GetResult(query)

        Return dt
    End Function

    Public Function Ubah(id As Integer) As Boolean
        Dim query As String = "UPDATE mobil SET idmerek = @idmerek, model = @model, tahun = @tahun, warna = @warna, jaraktempuh = @jaraktempuh, tranmisi = @tranmisi, harga = @harga, foto = @foto WHERE idmobil = @id"
        Dim params As MySqlParameter() = {
        New MySqlParameter("@idmerek", idmerek),
        New MySqlParameter("@model", model),
        New MySqlParameter("@tahun", tahun),
        New MySqlParameter("@warna", warna),
        New MySqlParameter("@jaraktempuh", jaraktempuh),
        New MySqlParameter("@tranmisi", tranmisi),
        New MySqlParameter("@harga", harga),
        New MySqlParameter("@foto", foto),
        New MySqlParameter("@id", id)
        }

        Dim k As New KoneksiDB
        Return k.Execute(query, params)
    End Function

    Public Function Hapus(id As Integer) As Boolean
        Dim query As String = "DELETE FROM mobil WHERE idmobil = @id"
        Dim params As MySqlParameter() = {
        New MySqlParameter("@id", id)
    }
        Dim k As New KoneksiDB
        Return k.Execute(query, params)
    End Function

    Public Function LihatMerek() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT idmerek, merek FROM merek"

        Dim kdb As New KoneksiDB
        dt = kdb.GetResult(query)
        Return dt
    End Function
End Class
