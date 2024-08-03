Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Response.Redirect("/viewpublic/BerandaPub.aspx")
    End Sub

    Protected Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text
        Dim dt As New DataTable


        'validasi username dan password tidak kosong
        If username = "" Then
            MsgBox("Username tidak boleh kosong")
            TxtUsername.Focus()
        ElseIf password = "" Then
            MsgBox("Password tidak boleh kosong")
            TxtPassword.Focus()
        Else
            Dim ap As New AkunPengguna_m
            dt = ap.CekLogin(username, password)


            'cek apakah dt kosong
            Dim jumbar As Integer = dt.Rows.Count
            If jumbar = 0 Then
                MsgBox("Maaf username/password yang Anda masukkan kurang tepat")
                Response.Redirect("/viewuser/Login.aspx")
            Else
                Dim idakun As Integer = dt.Rows(0).Item("idakun")
                Dim level As String = dt.Rows(0).Item("level")
                Session.Add("idakun", idakun)
                Session.Add("level", level)

                'Cek jenis levelnya, berdasarkan diagram activity
                If level = "admin" Then
                    Response.Redirect("/viewuser/Beranda.aspx")
                ElseIf level = "customer" Then
                    Response.Redirect("/viewuser/PenjualanCust.aspx")
                Else
                    Dim dt_member As New DataTable
                    Dim m As New Member_m
                    dt_member = m.LihatLogin(idakun)
                    Dim idmember As String = dt_member.Rows(0).Item("idmember")
                    Dim nama As String = dt_member.Rows(0).Item("nama")
                    Session.Add("idmember", idmember)
                    Session.Add("nama", nama)
                    Response.Redirect("/viewuser/Beranda.aspx")
                End If
            End If
        End If
    End Sub
End Class