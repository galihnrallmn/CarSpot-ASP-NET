Public Class PenjualanTambah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadMobil()
            LoadCustomer()
        End If
    End Sub

    Protected Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim idmobil As Integer = Convert.ToInt32(DdlMobil.SelectedValue)
        Dim idmember As Integer = Convert.ToInt32(DdlCustomer.SelectedValue)
        Dim tglpenjualan As String = TxtTglPenjualan.Text

        If idmobil <> 0 AndAlso idmember <> 0 AndAlso Not String.IsNullOrEmpty(tglpenjualan) Then
            Dim p As New Penjualan_m
            p.SetPenjualan(idmobil, idmember, tglpenjualan)

            Dim status As Boolean = p.Tambah()
            If status Then
                MsgBox("Data Penjualan berhasil ditambahkan")
                Response.Redirect("Penjualan.aspx")
            Else
                MsgBox("Data Penjualan tidak berhasil ditambahkan")
            End If
        Else
            MsgBox("Inputan tidak boleh kosong")
        End If
    End Sub

    Protected Sub LoadMobil()
        Dim p As New Penjualan_m()
        Dim dt As DataTable = p.LihatMobil()

        dt.Columns.Add("DisplayText", GetType(String), "merek + ' ' + model + ' ' + warna + ' ' + tahun + ' ' + tranmisi + ', ' + Convert(jaraktempuh, 'System.String') + ' KM, ' + 'Rp. ' + Convert(harga, 'System.String')")

        DdlMobil.DataSource = dt
        DdlMobil.DataTextField = "DisplayText"
        DdlMobil.DataValueField = "idmobil"
        DdlMobil.DataBind()

        DdlMobil.Items.Insert(0, New ListItem("--Pilih Mobil--", "0"))
    End Sub

    Protected Sub LoadCustomer()
        Dim p As New Penjualan_m()
        Dim dt As DataTable = p.LihatCustomer()

        DdlCustomer.DataSource = dt
        DdlCustomer.DataTextField = "nama"
        DdlCustomer.DataValueField = "idmember"
        DdlCustomer.DataBind()

        DdlCustomer.Items.Insert(0, New ListItem("--Pilih Customer--", "0"))
    End Sub


    Protected Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Response.Redirect("Penjualan.aspx")
    End Sub
End Class