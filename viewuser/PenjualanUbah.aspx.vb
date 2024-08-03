Public Class PenjualanUbah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As Integer = Val(Session("idtemp").ToString)

        If Not IsPostBack Then
            LoadMobil()
            LoadCustomer()

            Dim p As New Penjualan_m()
            Dim dt As New DataTable
            dt = p.LihatDetail(id)
            If dt.Rows.Count > 0 Then
                DdlMobil.SelectedValue = dt.Rows(0).Item("idmobil").ToString()
                DdlCustomer.SelectedValue = dt.Rows(0).Item("idmember").ToString()
                TxtTglPenjualan.Text = Convert.ToDateTime(dt.Rows(0).Item("tglpenjualan")).ToString("yyyy-MM-dd")
            Else
                MsgBox("Data tidak ditemukan.")
            End If
        End If
    End Sub

    Protected Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim id As Integer = Val(Session("idtemp").ToString)
        Dim idmobil As Integer = Convert.ToInt32(DdlMobil.SelectedValue)
        Dim idmember As Integer = Convert.ToInt32(DdlCustomer.SelectedValue)
        Dim tglpenjualan As String = TxtTglPenjualan.Text

        If idmobil <> 0 AndAlso idmember <> 0 AndAlso Not String.IsNullOrEmpty(tglpenjualan) Then
            Dim p As New Penjualan_m()
            p.SetPenjualan(idmobil, idmember, tglpenjualan)

            Dim status As Boolean = p.Ubah(id)
            If status Then
                MsgBox("Data penjualan berhasil diubah")
                Response.Redirect("Penjualan.aspx")
            Else
                MsgBox("Data penjualan tidak berhasil diubah")
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