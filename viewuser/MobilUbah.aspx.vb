Imports System.IO

Public Class MobilUbah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As Integer = Val(Session("idtemp").ToString)

        If Not IsPostBack Then
            LoadMerek()

            Dim m As New Mobil_m()
            Dim dt As New DataTable
            dt = m.LihatDetail(id)
            If dt.Rows.Count > 0 Then
                DdlMerek.SelectedValue = dt.Rows(0).Item("idmerek").ToString()
                TxtModel.Text = dt.Rows(0).Item("model").ToString()
                TxtTahun.Text = dt.Rows(0).Item("tahun").ToString()
                TxtWarna.Text = dt.Rows(0).Item("warna").ToString()
                TxtJarakTempuh.Text = dt.Rows(0).Item("jaraktempuh").ToString()
                DdlTransmisi.SelectedValue = dt.Rows(0).Item("tranmisi").ToString()
                TxtHarga.Text = dt.Rows(0).Item("harga").ToString()
                ImgFoto.ImageUrl = "../uploads/" & dt.Rows(0).Item("foto").ToString()
            Else
                MsgBox("Data tidak ditemukan.")
            End If
        End If
    End Sub

    Protected Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim id As Integer = Val(Session("idtemp").ToString)

        Dim idmerek As Integer = Convert.ToInt32(DdlMerek.SelectedValue)
        Dim model As String = TxtModel.Text.Trim()
        Dim tahun As String = TxtTahun.Text.Trim()
        Dim warna As String = TxtWarna.Text.Trim()
        Dim jaraktempuh As String = TxtJarakTempuh.Text.Trim()
        Dim tranmisi As String = DdlTransmisi.SelectedValue
        Dim harga As String = TxtHarga.Text.Trim()
        Dim foto As String = ImgFoto.ImageUrl.Replace("../uploads/", "")

        If FileUpload1.HasFile Then
            Dim fileName As String = Path.GetFileName(FileUpload1.PostedFile.FileName)
            Dim filePath As String = Server.MapPath("../uploads/") & fileName
            FileUpload1.PostedFile.SaveAs(filePath)
            foto = fileName
        End If

        ' Pengecekan input
        If idmerek = 0 Then
            MsgBox("Pilih Merek terlebih dahulu.")
            DdlMerek.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(model) OrElse String.IsNullOrWhiteSpace(tahun) OrElse
           String.IsNullOrWhiteSpace(warna) OrElse String.IsNullOrWhiteSpace(jaraktempuh) OrElse
           String.IsNullOrWhiteSpace(tranmisi) OrElse String.IsNullOrWhiteSpace(harga) Then
            MsgBox("Inputan tidak boleh kosong.")
            Return
        End If

        ' Menyiapkan objek Mobil_m dan mengubah data
        Dim m As New Mobil_m()
        m.SetMobil(idmerek, model, tahun, warna, jaraktempuh, tranmisi, harga, foto)

        Dim status As Boolean = m.Ubah(id)
        If status Then
            MsgBox("Data mobil berhasil diubah")
            Response.Redirect("Mobil.aspx")
        Else
            MsgBox("Data mobil tidak berhasil diubah")
        End If
    End Sub

    Protected Sub LoadMerek()
        Dim m As New Mobil_m()
        Dim dt As DataTable = m.LihatMerek()

        DdlMerek.DataSource = dt
        DdlMerek.DataTextField = "merek"
        DdlMerek.DataValueField = "idmerek"
        DdlMerek.DataBind()

        DdlMerek.Items.Insert(0, New ListItem("--Pilih Merek--", "0"))
    End Sub

    Protected Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Response.Redirect("Mobil.aspx")
    End Sub
End Class