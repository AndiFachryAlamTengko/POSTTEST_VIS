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
        btnTambah = New Button()
        btnEdit = New Button()
        Hapus = New Button()
        nama = New Label()
        dgvHasil = New DataGridView()
        Label2 = New Label()
        Label1 = New Label()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        CType(dgvHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(599, 118)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(599, 188)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(112, 34)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Hapus
        ' 
        Hapus.Location = New Point(599, 264)
        Hapus.Name = "Hapus"
        Hapus.Size = New Size(112, 34)
        Hapus.TabIndex = 2
        Hapus.Text = "Hapus"
        Hapus.UseVisualStyleBackColor = True
        ' 
        ' nama
        ' 
        nama.AutoSize = True
        nama.BackColor = SystemColors.ButtonHighlight
        nama.Location = New Point(323, 57)
        nama.Name = "nama"
        nama.Size = New Size(0, 25)
        nama.TabIndex = 3
        ' 
        ' dgvHasil
        ' 
        dgvHasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHasil.Location = New Point(129, 188)
        dgvHasil.Name = "dgvHasil"
        dgvHasil.RowHeadersWidth = 62
        dgvHasil.Size = New Size(360, 225)
        dgvHasil.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GrayText
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(129, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 25)
        Label2.TabIndex = 5
        Label2.Text = "NIM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(129, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 6
        Label1.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(235, 51)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 7
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(235, 103)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(150, 31)
        txtNIM.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(dgvHasil)
        Controls.Add(nama)
        Controls.Add(Hapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Name = "Form1"
        Text = "Form1"
        CType(dgvHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Hapus As Button
    Friend WithEvents nama As Label
    Friend WithEvents dgvHasil As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox

    Private Sub txtNIM_TextChanged(sender As Object, e As EventArgs) Handles txtNIM.TextChanged

    End Sub
End Class
