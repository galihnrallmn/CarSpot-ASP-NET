Public Class MerekTambah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim merek As String = TxtMerek.Text

        If merek <> "" Then
            Dim mrk As New Merek_m
            mrk.SetMerek(merek)

            Dim status As Boolean = mrk.Tambah()
            If status Then
                MsgBox("Data Merek berhasil ditambahkan")
                Response.Redirect("Merek.aspx")
            Else
                MsgBox("Data Merek tidak berhasil ditambahkan")
            End If
        Else
            MsgBox("Kode Merek dan Merek tidak boleh kosong")
        End If
    End Sub

    Protected Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Response.Redirect("Merek.aspx")
    End Sub
End Class