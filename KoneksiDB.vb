Imports MySql.Data.MySqlClient
Public Class KoneksiDB
    Dim username, password, server, database As String
    Dim mycn As MySqlConnection
    Dim mydata As MySqlDataAdapter
    Dim mycmd As MySqlCommand

    Public Sub New()
        username = "root"
        password = ""
        server = "localhost"
        database = "mobilsorum"

        Dim con_str As String
        con_str = "user=" & username & ";"
        con_str &= "pwd=" & password & ";"
        con_str &= "server=" & server & ";"
        con_str &= "database=" & database

        mycn = New MySqlConnection(con_str)
    End Sub

    Public Sub CekKoneksi()
        Try
            mycn.Open()
            mycn.Close()
            MsgBox("Koneksi Berhasil")
        Catch ex As Exception
            If mycn.State = ConnectionState.Open Then
                mycn.Close()
            End If
            MsgBox("Koneksi Gagal")
        End Try
    End Sub

    Public Function GetResult(query As String, Optional parameters As MySqlParameter() = Nothing) As DataTable
        Dim dt As New DataTable
        Try
            mycn.Open()
            mycmd = New MySqlCommand(query, mycn)
            If parameters IsNot Nothing Then
                mycmd.Parameters.AddRange(parameters)
            End If
            mydata = New MySqlDataAdapter(mycmd)
            mydata.Fill(dt)
            mycn.Close()
        Catch ex As Exception
            If mycn.State = ConnectionState.Open Then
                mycn.Close()
            End If
            MsgBox("Data tidak dapat ditampilkan, kemungkinan ada permasalahan terkait koneksi database. Hubungi admin!", MsgBoxStyle.Information, "Informasi")
        End Try
        Return dt
    End Function

    Public Function Execute(query As String, parameters As MySqlParameter()) As Boolean
        Dim status As Boolean
        Try
            mycn.Open()
            mycmd = New MySqlCommand(query, mycn)
            mycmd.Parameters.AddRange(parameters)
            mycmd.ExecuteNonQuery()
            status = True
            mycn.Close()
        Catch ex As Exception
            If mycn.State = ConnectionState.Open Then
                mycn.Close()
                MsgBox(ex.Message)
                status = False
            End If
        End Try
        Return status
    End Function

    Public Function GetCount(query As String) As Integer
        Dim count As Integer
        Try
            mycn.Open()
            mycmd = New MySqlCommand(query, mycn)
            count = Convert.ToInt32(mycmd.ExecuteScalar())
            mycn.Close()
        Catch ex As Exception
            If mycn.State = ConnectionState.Open Then
                mycn.Close()
            End If
            MsgBox("Operasi gagal: " & ex.Message)
        End Try
        Return count
    End Function

    Public Function GetMobilByMerek() As DataTable
        Dim query As String = "SELECT merek.merek, COUNT(mobil.idmobil) AS jumlah FROM mobil INNER JOIN merek ON mobil.idmerek = merek.idmerek GROUP BY mobil.idmerek"
        Return GetResult(query)
    End Function
End Class
