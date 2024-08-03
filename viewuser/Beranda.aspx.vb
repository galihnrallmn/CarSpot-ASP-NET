Imports MySql.Data.MySqlClient

Public Class Beranda
    Inherits System.Web.UI.Page

    Protected jumlahMerek As Integer
    Protected jumlahMobil As Integer
    Protected jumlahPenjualan As Integer
    Protected mobilData As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GetJumlahData()
            GetMobilData()
        End If
    End Sub

    Private Sub GetJumlahData()
        Dim k As New KoneksiDB()
        Dim dtMerek As DataTable = k.GetResult("SELECT COUNT(*) AS Jumlah FROM merek")
        Dim dtMobil As DataTable = k.GetResult("SELECT COUNT(*) AS Jumlah FROM mobil")
        Dim dtPenjualan As DataTable = k.GetResult("SELECT COUNT(*) AS Jumlah FROM penjualan")

        If dtMerek.Rows.Count > 0 Then jumlahMerek = Convert.ToInt32(dtMerek.Rows(0)("Jumlah"))
        If dtMobil.Rows.Count > 0 Then jumlahMobil = Convert.ToInt32(dtMobil.Rows(0)("Jumlah"))
        If dtPenjualan.Rows.Count > 0 Then jumlahPenjualan = Convert.ToInt32(dtPenjualan.Rows(0)("Jumlah"))
    End Sub

    Private Sub GetMobilData()
        Dim k As New KoneksiDB()
        Dim dt As DataTable = k.GetResult("SELECT m.merek, COUNT(mb.idmobil) AS Jumlah FROM merek m LEFT JOIN mobil mb ON m.idmerek = mb.idmerek GROUP BY m.merek")

        Dim labels As New List(Of String)()
        Dim data As New List(Of Integer)()

        For Each row As DataRow In dt.Rows
            labels.Add(row("merek").ToString())
            data.Add(Convert.ToInt32(row("Jumlah")))
        Next

        Dim json As String = "{ labels: " & Newtonsoft.Json.JsonConvert.SerializeObject(labels) & ", datasets: [{ label: 'Jumlah Mobil', data: " & Newtonsoft.Json.JsonConvert.SerializeObject(data) & ", backgroundColor: 'rgba(75, 192, 192, 0.2)', borderColor: 'rgba(75, 192, 192, 1)', borderWidth: 1 }] }"
        mobilData = json
    End Sub
End Class