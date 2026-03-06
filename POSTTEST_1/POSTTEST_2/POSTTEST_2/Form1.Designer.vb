<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudulBuku = New Label()
        lblGenre = New Label()
        lbljudulHapus = New Label()
        txtGenre = New MaskedTextBox()
        txtJudulBuku = New TextBox()
        txtJudulHapus = New TextBox()
        btnTambah = New Button()
        btnHapus = New Button()
        listTambahbuku = New GroupBox()
        listhapusbuku = New GroupBox()
        ListBox1 = New ListBox()
        listTambahbuku.SuspendLayout()
        listhapusbuku.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJudulBuku
        ' 
        lblJudulBuku.AutoSize = True
        lblJudulBuku.Location = New Point(26, 67)
        lblJudulBuku.Name = "lblJudulBuku"
        lblJudulBuku.Size = New Size(97, 25)
        lblJudulBuku.TabIndex = 0
        lblJudulBuku.Text = "Judul Buku"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(26, 128)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(58, 25)
        lblGenre.TabIndex = 1
        lblGenre.Text = "Genre"
        ' 
        ' lbljudulHapus
        ' 
        lbljudulHapus.AutoSize = True
        lbljudulHapus.Location = New Point(26, 71)
        lbljudulHapus.Name = "lbljudulHapus"
        lbljudulHapus.Size = New Size(97, 25)
        lbljudulHapus.TabIndex = 2
        lbljudulHapus.Text = "Judul Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(171, 125)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(150, 31)
        txtGenre.TabIndex = 4
        ' 
        ' txtJudulBuku
        ' 
        txtJudulBuku.Location = New Point(171, 64)
        txtJudulBuku.Name = "txtJudulBuku"
        txtJudulBuku.Size = New Size(150, 31)
        txtJudulBuku.TabIndex = 5
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(203, 68)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(150, 31)
        txtJudulHapus.TabIndex = 6
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(209, 183)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 7
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(241, 169)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' listTambahbuku
        ' 
        listTambahbuku.Controls.Add(txtJudulBuku)
        listTambahbuku.Controls.Add(txtGenre)
        listTambahbuku.Controls.Add(lblJudulBuku)
        listTambahbuku.Controls.Add(btnTambah)
        listTambahbuku.Controls.Add(lblGenre)
        listTambahbuku.Location = New Point(98, 72)
        listTambahbuku.Name = "listTambahbuku"
        listTambahbuku.Size = New Size(353, 233)
        listTambahbuku.TabIndex = 9
        listTambahbuku.TabStop = False
        listTambahbuku.Text = "Tambah Buku"
        ' 
        ' listhapusbuku
        ' 
        listhapusbuku.Controls.Add(txtJudulHapus)
        listhapusbuku.Controls.Add(lbljudulHapus)
        listhapusbuku.Controls.Add(btnHapus)
        listhapusbuku.Location = New Point(687, 72)
        listhapusbuku.Name = "listhapusbuku"
        listhapusbuku.Size = New Size(383, 219)
        listhapusbuku.TabIndex = 10
        listhapusbuku.TabStop = False
        listhapusbuku.Text = "Hapus Buku"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(411, 327)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(351, 279)
        ListBox1.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1212, 627)
        Controls.Add(ListBox1)
        Controls.Add(listhapusbuku)
        Controls.Add(listTambahbuku)
        Name = "Form1"
        Text = "Form1"
        listTambahbuku.ResumeLayout(False)
        listTambahbuku.PerformLayout()
        listhapusbuku.ResumeLayout(False)
        listhapusbuku.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblJudulBuku As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lbljudulHapus As Label
    Friend WithEvents txtGenre As MaskedTextBox
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents listTambahbuku As GroupBox
    Friend WithEvents listhapusbuku As GroupBox
    Friend WithEvents ListBox1 As ListBox

End Class
