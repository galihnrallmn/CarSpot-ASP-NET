Public Class MerekUbah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As Integer = Val(Session("idtemp").ToString)

        If IsPostBack = False Then
            Dim m As New Merek_m()
            Dim dt As New DataTable
            dt = m.LihatDetail(id)
            TxtMerek.Text = dt.Rows(0).Item("merek").ToString
        End If
    End Sub

    Protected Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim id As Integer = Val(Session("idtemp").ToString)

        Dim m As New Merek_m
        Dim status As Boolean
        Dim merek As String = TxtMerek.Text
        If merek = "" Then
            MsgBox("Data merek wajib diisi")
            TxtMerek.Focus()
        Else
            m.SetMerek(merek)
            status = m.Ubah(id)
            If status = True Then
                MsgBox("Data merek berhasil diubah")
                Response.Redirect("Merek.aspx")
            End If
        End If
    End Sub

    Protected Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Response.Redirect("Merek.aspx")
    End Sub
End Class