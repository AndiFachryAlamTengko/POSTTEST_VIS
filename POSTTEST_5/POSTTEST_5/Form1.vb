Imports MySqlConnector

Public Class Form1

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    '================ KONEKSI =================
    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_tiket")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Tidak bisa konek ke database")
        End Try
    End Sub

    '================ TAMPIL DATA =================
    Sub tampil()
        koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tiket", conn)
        dt = New DataTable
        da.Fill(dt)
        dgvData.DataSource = dt
        lblJumlah.Text = dt.Rows.Count
    End Sub

    '================ BERSIH =================
    Sub bersih()
        txtNama.Clear()
        txtTujuan.Clear()
        txtJumlah.Clear()
        cmbKelas.Text = ""
        txtCari.Clear()
    End Sub

    '================ LOAD =================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKelas.Items.Add("Ekonomi Reguler")
        cmbKelas.Items.Add("Bisnis Premium")
        cmbKelas.Items.Add("First Class VIP")

        tampil()
    End Sub

    '================ SIMPAN =================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or txtTujuan.Text = "" Or txtJumlah.Text = "" Then
            MessageBox.Show("Data belum lengkap")
            Exit Sub
        End If

        koneksi()
        cmd = New MySqlCommand("INSERT INTO tiket VALUES ('','" & txtNama.Text & "','" & txtTujuan.Text & "','" & dtTanggal.Value.ToString("yyyy-MM-dd") & "','" & txtJumlah.Text & "','" & cmbKelas.Text & "')", conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil disimpan")
        tampil()
        bersih()
    End Sub

    '================ KLIK DATA =================
    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        On Error Resume Next
        Dim i As Integer = dgvData.CurrentRow.Index

        txtNama.Text = dgvData.Item(1, i).Value
        txtTujuan.Text = dgvData.Item(2, i).Value
        dtTanggal.Value = dgvData.Item(3, i).Value
        txtJumlah.Text = dgvData.Item(4, i).Value
        cmbKelas.Text = dgvData.Item(5, i).Value
    End Sub

    '================ EDIT =================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        koneksi()
        cmd = New MySqlCommand("UPDATE tiket SET nama_penumpang='" & txtNama.Text & "', tujuan='" & txtTujuan.Text & "', tanggal='" & dtTanggal.Value.ToString("yyyy-MM-dd") & "', jumlah_tiket='" & txtJumlah.Text & "', kelas='" & cmbKelas.Text & "' WHERE id='" & dgvData.CurrentRow.Cells(0).Value & "'", conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil diubah")
        tampil()
        bersih()
    End Sub

    '================ HAPUS =================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            koneksi()
            cmd = New MySqlCommand("DELETE FROM tiket WHERE id='" & dgvData.CurrentRow.Cells(0).Value & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus")
            tampil()
            bersih()
        End If
    End Sub

    '================ CARI =================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tiket WHERE nama_penumpang LIKE '%" & txtCari.Text & "%'", conn)
        dt = New DataTable
        da.Fill(dt)
        dgvData.DataSource = dt
    End Sub

    '================ BERSIH BUTTON =================
    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        bersih()
    End Sub

End Class