Imports System.EnterpriseServices
Imports System.IO

Public Class MobilTambah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadMerek()
        End If
    End Sub

    Protected Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim idmerek As Integer = Convert.ToInt32(DdlMerek.SelectedValue)
        Dim model As String = TxtModel.Text.Trim()
        Dim tahun As String = TxtTahun.Text.Trim()
        Dim warna As String = TxtWarna.Text.Trim()
        Dim jaraktempuh As String = TxtJarakTempuh.Text.Trim()
        Dim tranmisi As String = DdlTransmisi.SelectedValue
        Dim harga As String = TxtHarga.Text.Trim()
        Dim foto As String = ""

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

        ' Menyiapkan objek Mobil_m dan menambahkan data
        Dim m As New Mobil_m()
        m.SetMobil(idmerek, model, tahun, warna, jaraktempuh, tranmisi, harga, foto)

        Dim status As Boolean = m.Tambah()
        If status Then
            MsgBox("Data Mobil berhasil ditambahkan")
            Response.Redirect("Mobil.aspx")
        Else
            MsgBox("Data Mobil tidak berhasil ditambahkan")
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