Public Module Module1

    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    'Procedure untuk menambah buku
    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub

    'Function untuk format tampilan buku
    Public Function FormatBuku(ByVal judul As String, ByVal genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

End Module