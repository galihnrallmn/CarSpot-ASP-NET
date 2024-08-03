Public Class Member_m
    Dim idmember As String
    Dim idakun As String
    Dim nama As String
    Dim nohp As String

    Public Function LihatLogin(idakun As Integer) As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT idmember, nama FROM member WHERE idakun = " & idakun
        Dim k As New KoneksiDB
        dt = k.GetResult(query)
        Return dt
    End Function

End Class
