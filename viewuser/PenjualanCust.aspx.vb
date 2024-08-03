Public Class PenjualanCust
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

            TblPenjualan.Rows.Add(tableRow)
        Next
    End Sub

End Class