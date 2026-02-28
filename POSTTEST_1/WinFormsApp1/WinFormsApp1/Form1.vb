Public Class Form1

    ' Variabel penyimpanan
    Dim totalNilai As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ips As Double

        ' Validasi input angka
        If Double.TryParse(txtIPS.Text, ips) Then

            ' Validasi rentang 0 - 4
            If ips < 0 Or ips > 4 Then
                MessageBox.Show("IPS harus antara 0 sampai 4")
                Exit Sub
            End If

            ' Tambah data
            totalNilai = totalNilai + ips
            jumlahSemester = jumlahSemester + 1

            ' Hitung IPK
            Dim ipk As Double = totalNilai / jumlahSemester

            ' Tampilkan IPK
            lblIPK.Text = ipk.ToString("0.00")

            ' Tentukan predikat
            If ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                lblPredikat.Text = "Cukup"
            Else
                lblPredikat.Text = "-"
            End If

            ' Kosongkan input
            txtIPS.Clear()

        Else
            MessageBox.Show("Masukkan angka yang benar")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Reset semua nilai
        totalNilai = 0
        jumlahSemester = 0

        lblIPK.Text = "0.00"
        lblPredikat.Text = "-"
        txtIPS.Clear()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles leflef.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class