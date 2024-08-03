Public Class Logout
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim level = Session("level")
        Session.Remove("level")
        Session.Remove("idakun")
        If level = "member" Then
            Session.Remove("idmember")
            Session.Remove("nama")
        End If

        MsgBox("Logout berhasil, Anda telah keluar dari sistem")

        Response.Redirect("/viewpublic/BerandaPub.aspx")
    End Sub

End Class