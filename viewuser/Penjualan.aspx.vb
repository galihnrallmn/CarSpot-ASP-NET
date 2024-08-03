Public Class Penjualan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim p As New Penjualan_m()
        Dim dt As New DataTable()
        dt = p.Lihat()

        'Membuat tabel (header)
        Dim headerRow As New TableRow()
        Dim headerCell As TableCell


        headerCell = New TableCell()
        headerCell.Text = "ID"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Customer"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Merek"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Model"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Tahun"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Warna"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Jarak Tempuh"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Tranmisi"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Harga"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Aksi"
        headerRow.Cells.Add(headerCell)

        TblPenjualan.Rows.Add(headerRow)


        'Menambahkan baris data di tabel
        For Each row As DataRow In dt.Rows
            Dim tableRow As New TableRow()

            'mengisi setiap kolom tabel
            For Each col As DataColumn In dt.Columns
                Dim tableCell As New TableCell()
                tableCell.Text = row(col).ToString
                tableRow.Cells.Add(tableCell)
            Next

            'tambahkan tombol ubah di kolom aksi
            Dim actionCell As New TableCell()
            Dim btnUbah As New Button()
            btnUbah.ID = "btnUbah_" & row("ID").ToString()
            btnUbah.Text = "Ubah"
            btnUbah.CommandArgument = row("ID").ToString()
            btnUbah.CssClass = "btn btn-warning btn-sm mr-2"
            AddHandler btnUbah.Click, AddressOf BtnUbah_Click

            'tambahkan tombol hapus di kolom aksi
            Dim btnHapus As New Button()
            btnHapus.ID = "btnHapus_" & row("ID").ToString()
            btnHapus.Text = "Hapus"
            btnHapus.CommandArgument = row("ID").ToString()
            btnHapus.CssClass = "btn btn-danger btn-sm"
            btnHapus.OnClientClick = "return confirm('Apakah Anda yakin ingin menghapus merek ini?');"
            AddHandler btnHapus.Click, AddressOf BtnHapus_Click

            actionCell.Controls.Add(btnUbah)
            actionCell.Controls.Add(btnHapus)
            tableRow.Cells.Add(actionCell)
            TblPenjualan.Rows.Add(tableRow)
        Next
    End Sub

    Protected Sub BtnUbah_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim id As String = btn.CommandArgument.ToString
        Session("idtemp") = id
        Response.Redirect("PenjualanUbah.aspx")
    End Sub

    Protected Sub BtnHapus_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim id As String = btn.CommandArgument.ToString

        ' Logika untuk menghapus data berdasarkan id
        Dim p As New Penjualan_m()
        Dim status As Boolean = p.Hapus(id)
        If status = True Then
            MsgBox("Data Penjualan berhasil dihapus")
            ' Redirect atau refresh halaman setelah penghapusan
            Response.Redirect(Request.RawUrl)
        Else
            MsgBox("Gagal menghapus data penjualan")
        End If

    End Sub

End Class