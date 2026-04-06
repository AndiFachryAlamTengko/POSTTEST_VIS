Public Class Form1

    ' ================= VALIDASI =================
    Private Function Validasi() As Boolean
        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If Not mtxtTelp.MaskCompleted Then
            MessageBox.Show("Nomor telepon belum lengkap")
            Return False
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Return False
        End If

        If cmbKomunitas.Text = "" Then
            MessageBox.Show("Pilih komunitas")
            Return False
        End If

        If Not (cbGame.Checked Or cbMusik.Checked Or cbOlahraga.Checked Or cbMembaca.Checked _
            Or cbTraveling.Checked Or cbFotografi.Checked Or cbMemasak.Checked Or cbSosial.Checked) Then

            MessageBox.Show("Pilih minimal 1 hobi")
            Return False
        End If

        Return True
    End Function

    ' ================= INPUT NAMA (HURUF) =================
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' ================= INPUT ID (ANGKA) =================
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' ================= LOAD COMBOBOX =================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKomunitas.Items.Add("Programmer")
        cmbKomunitas.Items.Add("Desain Grafis")
        cmbKomunitas.Items.Add("Multimedia")
        cmbKomunitas.Items.Add("Jaringan")
        cmbKomunitas.Items.Add("Cyber Security")
        cmbKomunitas.Items.Add("Game Developer")
    End Sub

    ' ================= BROWSE FOTO =================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png"

        If ofd.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    ' ================= SIMPAN & CETAK =================
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Validasi() = False Then Exit Sub

        Dim hobi As String = ""

        If cbGame.Checked Then hobi &= "Game, "
        If cbMusik.Checked Then hobi &= "Musik, "
        If cbOlahraga.Checked Then hobi &= "Olahraga, "
        If cbMembaca.Checked Then hobi &= "Membaca, "
        If cbTraveling.Checked Then hobi &= "Traveling, "
        If cbFotografi.Checked Then hobi &= "Fotografi, "
        If cbMemasak.Checked Then hobi &= "Memasak, "
        If cbSosial.Checked Then hobi &= "Sosial, "

        Dim f As New Form2

        f.lblNama.Text = "Nama: " & txtNama.Text
        f.lblID.Text = "ID: " & txtID.Text
        f.lblKomunitas.Text = "Komunitas: " & cmbKomunitas.Text
        f.lblTelp.Text = "Telp: " & mtxtTelp.Text
        f.lblEmail.Text = "Email: " & txtEmail.Text
        f.lblAlamat.Text = "Alamat: " & txtAlamat.Text
        f.lblHobi.Text = "Hobi: " & hobi

        If picFoto.Image IsNot Nothing Then
            f.PictureBox1.Image = picFoto.Image
        End If

        f.Show()
    End Sub

    ' ================= MENU SIMPAN =================
    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd.FileName,
                txtNama.Text & "|" & txtID.Text & "|" & cmbKomunitas.Text, False)

            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

    ' ================= MENU BUKA =================
    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Text File|*.txt"

        If ofd.ShowDialog = DialogResult.OK Then
            Dim data = My.Computer.FileSystem.ReadAllText(ofd.FileName).Split("|")

            txtNama.Text = data(0)
            txtID.Text = data(1)
            cmbKomunitas.Text = data(2)
        End If
    End Sub

    ' ================= MENU KELUAR =================
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class