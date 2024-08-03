Public Class AkunPengguna_m
    Dim idakun As Integer
    Dim username As String
    Dim password As String
    Dim level As String

    Public Function CekLogin(username As String, password As String) As DataTable
        Dim dt As New DataTable


        'mengambil data akun_pengguna berdasarkan nilai username
        Dim query As String = "SELECT * FROM akunpengguna WHERE username = '" & username & "'"
        Dim k As New KoneksiDB
        dt = k.GetResult(query)


        'menguji apakah dt ada isinya?
        Dim jumbar As Integer = dt.Rows.Count
        If jumbar > 0 Then


            'memverifikasi password
            Dim hashed_pass As String = dt.Rows(0).Item("password")
            Dim valid As Boolean = BCrypt.Net.BCrypt.Verify(password, hashed_pass)
            If valid = False Then
                dt = New DataTable  'mengosongkan dt jika tidak valid
            End If
        End If
        Return dt

    End Function
End Class
