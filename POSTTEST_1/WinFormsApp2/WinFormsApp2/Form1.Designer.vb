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
        Label1 = New Label()
        Label2 = New Label()
        txtJudulBuku = New TextBox()
        txtGenre = New TextBox()
        btnTambah = New Button()
        Label3 = New Label()
        TextBox1 = New TextBox()
        btnHapus = New Button()
        groupHapus = New GroupBox()
        groupTambahBuku = New GroupBox()
        ListBuku = New ListBox()
        groupHapus.SuspendLayout()
        groupTambahBuku.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' txtJudulBuku
        ' 
        txtJudulBuku.Location = New Point(130, 38)
        txtJudulBuku.Name = "txtJudulBuku"
        txtJudulBuku.Size = New Size(150, 31)
        txtJudulBuku.TabIndex = 2
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(130, 94)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(150, 31)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(168, 141)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 5
        Label3.Text = "Judul Buku"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(134, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 6
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(172, 135)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' groupHapus
        ' 
        groupHapus.Controls.Add(Label3)
        groupHapus.Controls.Add(btnHapus)
        groupHapus.Controls.Add(TextBox1)
        groupHapus.Location = New Point(445, 32)
        groupHapus.Name = "groupHapus"
        groupHapus.Size = New Size(300, 175)
        groupHapus.TabIndex = 9
        groupHapus.TabStop = False
        groupHapus.Text = "Hapus Buku"
        ' 
        ' groupTambahBuku
        ' 
        groupTambahBuku.Controls.Add(btnTambah)
        groupTambahBuku.Controls.Add(txtJudulBuku)
        groupTambahBuku.Controls.Add(Label2)
        groupTambahBuku.Controls.Add(txtGenre)
        groupTambahBuku.Controls.Add(Label1)
        groupTambahBuku.Location = New Point(91, 32)
        groupTambahBuku.Name = "groupTambahBuku"
        groupTambahBuku.Size = New Size(300, 181)
        groupTambahBuku.TabIndex = 10
        groupTambahBuku.TabStop = False
        groupTambahBuku.Text = "Tambah Buku"
        ' 
        ' ListBuku
        ' 
        ListBuku.FormattingEnabled = True
        ListBuku.Location = New Point(211, 265)
        ListBuku.Name = "ListBuku"
        ListBuku.Size = New Size(322, 179)
        ListBuku.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(875, 450)
        Controls.Add(ListBuku)
        Controls.Add(groupTambahBuku)
        Controls.Add(groupHapus)
        Name = "Form1"
        Text = "Form1"
        groupHapus.ResumeLayout(False)
        groupHapus.PerformLayout()
        groupTambahBuku.ResumeLayout(False)
        groupTambahBuku.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents groupHapus As GroupBox
    Friend WithEvents groupTambahBuku As GroupBox
    Friend WithEvents ListBuku As ListBox

End Class
