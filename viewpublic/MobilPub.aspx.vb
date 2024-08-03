Public Class MobilPub
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim m As New Mobil_m()
        Dim dt As DataTable
        dt = m.LihatMobil()

        ' Membuat tabel (header)
        Dim headerRow As New TableRow()
        Dim headerCell As TableCell

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
        headerCell.Text = "Transmisi"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Harga"
        headerRow.Cells.Add(headerCell)

        headerCell = New TableCell()
        headerCell.Text = "Foto"
        headerRow.Cells.Add(headerCell)

        TblMobil.Rows.Add(headerRow)

        ' Menambahkan baris data di tabel
        For Each row As DataRow In dt.Rows
            Dim tableRow As New TableRow()

            ' Mengisi setiap kolom tabel
            For Each col As DataColumn In dt.Columns
                Dim tableCell As New TableCell()
                If col.ColumnName = "Foto" Then
                    Dim fotoFile As String = If(IsDBNull(row(col)), "blank.jpg", row(col).ToString())
                    If String.IsNullOrEmpty(fotoFile) Then
                        fotoFile = "blank.jpg"
                    End If

                    ' Periksa apakah file ada
                    If System.IO.File.Exists(Server.MapPath("../uploads/" & fotoFile)) Then
                        tableCell.Text = $"<img src='../uploads/{fotoFile}' alt='Foto Mobil' style='width:100px;height:auto;' />"
                    Else
                        tableCell.Text = "<img src='../uploads/blank.jpg' alt='Foto Mobil Tidak Ada' style='width:100px;height:auto;' />"
                    End If
                Else
                    tableCell.Text = row(col).ToString()
                End If
                tableRow.Cells.Add(tableCell)
            Next

            TblMobil.Rows.Add(tableRow)
        Next
    End Sub

End Class