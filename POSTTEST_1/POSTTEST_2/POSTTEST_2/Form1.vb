Public Class Form1

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudulHapus.Text <> "" And txtGenre.Text <> "" Then

            TambahBuku(txtJudulHapus.Text, txtGenre.Text)

            ListBox1.Items.Clear()

            For i As Integer = 0 To jumlahBuku - 1
                ListBox1.Items.Add(FormatBuku(daftarBuku(i, 0), daftarBuku(i, 1)))
            Next

            txtJudulHapus.Clear()
            txtGenre.Clear()

        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judul As String = txtJudulHapus.Text

        For i As Integer = 0 To jumlahBuku - 1

            If daftarBuku(i, 0) = judul Then

                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                    daftarBuku(j, 1) = daftarBuku(j + 1, 1)
                Next

                jumlahBuku -= 1
                Exit For

            End If

        Next

        ListBox1.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            ListBox1.Items.Add(FormatBuku(daftarBuku(i, 0), daftarBuku(i, 1)))
        Next

        txtJudulHapus.Clear()

    End Sub

    Private Sub lblJudulBuku_Click(sender As Object, e As EventArgs) Handles lblJudulBuku.Click

    End Sub

    Private Sub lblJudul_Click(sender As Object, e As EventArgs) Handles lbljudulHapus.Click

    End Sub
End Class