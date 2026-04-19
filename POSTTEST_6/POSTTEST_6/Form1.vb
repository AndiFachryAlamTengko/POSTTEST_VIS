Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form1

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_tiket")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        LoadKelas()
        TampilData()
    End Sub

    Sub LoadKelas()
        Dim da As New MySqlDataAdapter("SELECT * FROM kelas", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbKelas.DataSource = dt
        cmbKelas.DisplayMember = "nama_kelas"
        cmbKelas.ValueMember = "id_kelas"
    End Sub

    Sub TampilData()
        Dim da As New MySqlDataAdapter("SELECT tiket.id_tiket, nama_penumpang, tujuan, tanggal, jumlah_tiket, kelas.nama_kelas FROM tiket JOIN kelas ON tiket.id_kelas = kelas.id_kelas", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        dgvTiket.DataSource = dt
        lblJumlahData.Text = "Jumlah Data: " & dt.Rows.Count
    End Sub

    Sub HitungTotal()
        If txtJumlah.Text = "" Then Exit Sub

        Dim cmd As New MySqlCommand("SELECT harga FROM kelas WHERE id_kelas=" & cmbKelas.SelectedValue, conn)
        Dim harga As Integer = cmd.ExecuteScalar()

        Dim total As Integer = Val(txtJumlah.Text) * harga

        If Val(txtJumlah.Text) > 3 Then
            total = total * 0.9
        End If

        txtTotal.Text = total
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungTotal()
    End Sub

    Private Sub cmbKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKelas.SelectedIndexChanged
        HitungTotal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtNama.Text = "" Then
            MessageBox.Show("Nama wajib diisi")
            Exit Sub
        End If

        Dim query As String = "
        INSERT INTO tiket (nama_penumpang, tujuan, tanggal, jumlah_tiket, id_kelas)
        SELECT '" & txtNama.Text & "','" & txtTujuan.Text & "','" & dtTanggal.Value.ToString("yyyy-MM-dd") & "'," & txtJumlah.Text & "," & cmbKelas.SelectedValue & "
        FROM DUAL
        WHERE NOT EXISTS (
            SELECT * FROM tiket 
            WHERE nama_penumpang='" & txtNama.Text & "' 
            AND tujuan='" & txtTujuan.Text & "' 
            AND tanggal='" & dtTanggal.Value.ToString("yyyy-MM-dd") & "'
        )"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()

        TampilData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvTiket.CurrentRow Is Nothing Then Exit Sub

        Dim id As String = dgvTiket.CurrentRow.Cells(0).Value

        Dim cmd As New MySqlCommand("DELETE FROM tiket WHERE id_tiket=" & id, conn)
        cmd.ExecuteNonQuery()

        TampilData()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim da As New MySqlDataAdapter("SELECT tiket.*, kelas.nama_kelas FROM tiket JOIN kelas ON tiket.id_kelas = kelas.id_kelas WHERE nama_penumpang LIKE '%" & txtCari.Text & "%'", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        dgvTiket.DataSource = dt
    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        txtNama.Clear()
        txtTujuan.Clear()
        txtJumlah.Clear()
        txtTotal.Clear()
        txtCari.Clear()
    End Sub

    Private Sub lblJumlahData_Click(sender As Object, e As EventArgs) Handles lblJumlahData.Click

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub txtTujuan_TextChanged(sender As Object, e As EventArgs) Handles txtTujuan.TextChanged

    End Sub
End Class