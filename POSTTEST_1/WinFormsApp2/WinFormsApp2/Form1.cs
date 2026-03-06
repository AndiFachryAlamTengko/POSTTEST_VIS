private void btnTambah_Click(object sender, EventArgs e)
{
    string judul = txtJudul.Text;
    string genre = txtGenre.Text;

    if (judul != "" && genre != "")
    {
        listBuku.Items.Add(judul + " (" + genre + ")");
        txtJudul.Clear();
        txtGenre.Clear();
    }
    else
    {
        MessageBox.Show("Judul dan Genre harus diisi!");
    }
}

private void btnHapus_Click(object sender, EventArgs e)
{
    string judulHapus = txtJudulHapus.Text;

    for (int i = 0; i < listBuku.Items.Count; i++)
    {
        if (listBuku.Items[i].ToString().Contains(judulHapus))
        {
            listBuku.Items.RemoveAt(i);
            break;
        }
    }

    txtJudulHapus.Clear();
}