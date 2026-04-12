Public Class Form1
    Dim fotoPath As String = ""

    ' ================= PILIH FOTO =================
    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        Try
            Using openFile As New OpenFileDialog()
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
                openFile.Title = "Pilih Foto"

                If openFile.ShowDialog() = DialogResult.OK Then
                    fotoPath = openFile.FileName
                    PictureBox1.Image = Image.FromFile(fotoPath)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal membuka foto: " & ex.Message)
        End Try
    End Sub

    ' ================= CETAK DATA =================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            ' ===== VALIDASI =====
            If txtName.Text = "" Or txtID.Text = "" Or txtGmail.Text = "" Then
                MessageBox.Show("Data wajib diisi!")
                Exit Sub
            End If

            ' ===== AMBIL HOBI (VERSI CB) =====
            Dim hobi As New List(Of String)
            If cbGame.Checked Then hobi.Add("Main Game")
            If cbShopping.Checked Then hobi.Add("Shopping")
            If cbMusik.Checked Then hobi.Add("Musik")
            If cbJalan.Checked Then hobi.Add("Jalan-jalan")
            If cbNgoding.Checked Then hobi.Add("Ngoding")
            If cbBasket.Checked Then hobi.Add("Basket")
            If cbFutsal.Checked Then hobi.Add("Futsal")
            If cbLari.Checked Then hobi.Add("Lari")

            ' ===== PINDAH KE FORM2 =====
            Dim f2 As New Form2()

            f2.lblEmail.Text = txtGmail.Text
            f2.lblID.Text = txtID.Text
            f2.lblName.Text = txtName.Text
            f2.lblTelpon.Text = txtNoTelp.Text
            f2.lblKomunitas.Text = cbKomunitas.Text
            f2.lblHobi.Text = String.Join(", ", hobi)
            f2.lblAlamat.Text = txtAlamat.Text

            ' ===== FOTO =====
            If fotoPath <> "" AndAlso IO.File.Exists(fotoPath) Then
                f2.pbFotoOutput.Image = Image.FromFile(fotoPath)
                f2.pbFotoOutput.SizeMode = PictureBoxSizeMode.StretchImage
            End If

            f2.Show()

        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message)
        End Try
    End Sub

    ' ================= KELUAR =================
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class