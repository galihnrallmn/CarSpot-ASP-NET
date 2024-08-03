Imports MySql.Data.MySqlClient

Public Class Penjualan_m
    Dim idpenjualan As Integer
    Dim idmobil As Integer
    Dim idmember As Integer
    Dim tglpenjualan As Date

    Public Function Lihat() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT idpenjualan AS ID, member.nama AS Customer, merek.merek AS Merek, mobil.model AS Model, mobil.tahun AS Tahun, mobil.warna AS Warna, mobil.jaraktempuh AS ""Jarak Tempuh"", mobil.tranmisi AS Transmisi, mobil.harga AS Harga FROM penjualan INNER JOIN mobil ON penjualan.idmobil = mobil.idmobil INNER JOIN merek ON mobil.idmerek = merek.idmerek INNER JOIN member ON penjualan.idmember = member.idmember ORDER BY idpenjualan DESC"

        Dim k As New KoneksiDB
        dt = k.GetResult(query)

        Return dt
    End Function

    Public Function Tambah() As Boolean
        Dim query As String = "INSERT INTO penjualan (idpenjualan, idmobil, idmember, tglpenjualan) VALUES (NULL, @idmobil, @idmember, @tglpenjualan)"
        Dim parameters As MySqlParameter() = {
            New MySqlParameter("@idmobil", idmobil),
            New MySqlParameter("@idmember", idmember),
            New MySqlParameter("@tglpenjualan", tglpenjualan)
        }

        Dim k As New KoneksiDB
        Dim status As Boolean = k.Execute(query, parameters)
        Return status
    End Function

    Public Sub SetPenjualan(idmobil As Integer, idmember As Integer, tglpenjualan As Date)
        Me.idmobil = idmobil
        Me.idmember = idmember
        Me.tglpenjualan = tglpenjualan
    End Sub

    Public Function LihatDetail(id As Integer) As DataTable
        Dim dt As DataTable
        Dim query As String = "SELECT idmobil, idmember, tglpenjualan FROM penjualan WHERE idpenjualan = " & id

        Dim k As New KoneksiDB
        dt = k.GetResult(query)

        Return dt
    End Function

    Public Function Ubah(id As Integer) As Boolean
        Dim query As String = "UPDATE penjualan SET idmobil = @idmobil, idmember = @idmember, tglpenjualan = @tglpenjualan Where idpenjualan = " & id
        Dim params As MySqlParameter() = {
        New MySqlParameter("@idmobil", idmobil),
        New MySqlParameter("@idmember", idmember),
        New MySqlParameter("@tglpenjualan", tglpenjualan)
        }

        Dim status As Boolean
        Dim k As New KoneksiDB
        status = k.Execute(query, params)

        Return status
    End Function

    Public Function Hapus(id As Integer) As Boolean
        Dim query As String = "DELETE FROM penjualan WHERE idpenjualan = @id"
        Dim params As MySqlParameter() = {
            New MySqlParameter("@id", id)
            }
        Dim status As Boolean
        Dim k As New KoneksiDB
        status = k.Execute(query, params)

        Return status
    End Function

    Public Function LihatMobil() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT idmobil, merek.merek, model, tahun, warna, jaraktempuh, tranmisi, harga FROM mobil INNER JOIN merek ON mobil.idmerek = merek.idmerek ORDER BY idmobil DESC"

        Dim kdb As New KoneksiDB
        dt = kdb.GetResult(query)
        Return dt
    End Function

    Public Function LihatCustomer() As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT idmember, nama FROM member ORDER BY idmember DESC"

        Dim kdb As New KoneksiDB
        dt = kdb.GetResult(query)
        Return dt
    End Function
End Class
