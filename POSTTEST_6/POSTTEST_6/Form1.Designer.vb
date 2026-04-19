<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBersih = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTujuan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTiket = New System.Windows.Forms.DataGridView()
        Me.gbInput = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        CType(Me.dgvTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJumlahData
        '
        Me.lblJumlahData.AutoSize = True
        Me.lblJumlahData.Location = New System.Drawing.Point(429, 398)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(107, 20)
        Me.lblJumlahData.TabIndex = 24
        Me.lblJumlahData.Text = "Jumlah Data :"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(725, 58)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 33)
        Me.btnCari.TabIndex = 22
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(429, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cari Nama :"
        '
        'btnBersih
        '
        Me.btnBersih.Location = New System.Drawing.Point(237, 315)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(75, 33)
        Me.btnBersih.TabIndex = 20
        Me.btnBersih.Text = "Bersih"
        Me.btnBersih.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(159, 202)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(121, 26)
        Me.txtTotal.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total :"
        '
        'cmbKelas
        '
        Me.cmbKelas.FormattingEnabled = True
        Me.cmbKelas.Items.AddRange(New Object() {"Ekonomi ", " VIP"})
        Me.cmbKelas.Location = New System.Drawing.Point(159, 168)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(121, 28)
        Me.cmbKelas.TabIndex = 8
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(159, 135)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(121, 26)
        Me.txtJumlah.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Kelas :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jumlah Tiket :"
        '
        'dtTanggal
        '
        Me.dtTanggal.Location = New System.Drawing.Point(159, 103)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(172, 26)
        Me.dtTanggal.TabIndex = 5
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(75, 315)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(156, 315)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 33)
        Me.btnHapus.TabIndex = 18
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(-6, 315)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 33)
        Me.btnSimpan.TabIndex = 17
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal :"
        '
        'txtTujuan
        '
        Me.txtTujuan.Location = New System.Drawing.Point(159, 66)
        Me.txtTujuan.Name = "txtTujuan"
        Me.txtTujuan.Size = New System.Drawing.Size(219, 26)
        Me.txtTujuan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tujuan :"
        '
        'dgvTiket
        '
        Me.dgvTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiket.Location = New System.Drawing.Point(433, 93)
        Me.dgvTiket.Name = "dgvTiket"
        Me.dgvTiket.RowHeadersWidth = 62
        Me.dgvTiket.RowTemplate.Height = 28
        Me.dgvTiket.Size = New System.Drawing.Size(355, 302)
        Me.dgvTiket.TabIndex = 23
        '
        'gbInput
        '
        Me.gbInput.Controls.Add(Me.txtTotal)
        Me.gbInput.Controls.Add(Me.Label8)
        Me.gbInput.Controls.Add(Me.cmbKelas)
        Me.gbInput.Controls.Add(Me.txtJumlah)
        Me.gbInput.Controls.Add(Me.Label5)
        Me.gbInput.Controls.Add(Me.Label4)
        Me.gbInput.Controls.Add(Me.dtTanggal)
        Me.gbInput.Controls.Add(Me.Label3)
        Me.gbInput.Controls.Add(Me.txtTujuan)
        Me.gbInput.Controls.Add(Me.Label2)
        Me.gbInput.Controls.Add(Me.Label1)
        Me.gbInput.Controls.Add(Me.txtNama)
        Me.gbInput.Location = New System.Drawing.Point(-6, 61)
        Me.gbInput.Name = "gbInput"
        Me.gbInput.Size = New System.Drawing.Size(410, 248)
        Me.gbInput.TabIndex = 16
        Me.gbInput.TabStop = False
        Me.gbInput.Text = "Input Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Penumpang :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(159, 34)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(219, 26)
        Me.txtNama.TabIndex = 1
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(94, 9)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(641, 37)
        Me.lblJudul.TabIndex = 15
        Me.lblJudul.Text = "SISTEM PEMESANAN TIKET PESAWAT"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(534, 61)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(185, 26)
        Me.txtCari.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblJumlahData)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBersih)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dgvTiket)
        Me.Controls.Add(Me.gbInput)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.txtCari)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvTiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInput.ResumeLayout(False)
        Me.gbInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJumlahData As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBersih As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTujuan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTiket As DataGridView
    Friend WithEvents gbInput As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtCari As TextBox
End Class
