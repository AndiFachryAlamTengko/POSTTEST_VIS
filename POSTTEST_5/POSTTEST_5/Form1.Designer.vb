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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.gbInput = New System.Windows.Forms.GroupBox()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTujuan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnBersih = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.gbInput.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(159, 37)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(219, 26)
        Me.txtNama.TabIndex = 1
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(631, 123)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(185, 26)
        Me.txtCari.TabIndex = 3
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(178, 16)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(641, 37)
        Me.lblJudul.TabIndex = 4
        Me.lblJudul.Text = "SISTEM PEMESANAN TIKET PESAWAT"
        '
        'gbInput
        '
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
        Me.gbInput.Location = New System.Drawing.Point(85, 92)
        Me.gbInput.Name = "gbInput"
        Me.gbInput.Size = New System.Drawing.Size(408, 217)
        Me.gbInput.TabIndex = 5
        Me.gbInput.TabStop = False
        Me.gbInput.Text = "Input Data"
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
        Me.Label5.Location = New System.Drawing.Point(6, 163)
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
        Me.txtTujuan.Location = New System.Drawing.Point(159, 70)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Penumpang :"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(85, 325)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 33)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(247, 325)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 33)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(166, 325)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnBersih
        '
        Me.btnBersih.Location = New System.Drawing.Point(328, 325)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(75, 33)
        Me.btnBersih.TabIndex = 9
        Me.btnBersih.Text = "Bersih"
        Me.btnBersih.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(538, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cari Nama :"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(822, 123)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 26)
        Me.btnCari.TabIndex = 11
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(542, 162)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 62
        Me.dgvData.RowTemplate.Height = 28
        Me.dgvData.Size = New System.Drawing.Size(355, 302)
        Me.dgvData.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 476)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Jumlah Data :"
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(652, 476)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(18, 20)
        Me.lblJumlah.TabIndex = 14
        Me.lblJumlah.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 532)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBersih)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.gbInput)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.txtCari)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbInput.ResumeLayout(False)
        Me.gbInput.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents gbInput As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTujuan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBersih As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lblJumlah As Label
End Class
