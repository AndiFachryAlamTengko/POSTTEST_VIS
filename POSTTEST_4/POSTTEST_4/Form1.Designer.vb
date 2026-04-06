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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatKartuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbljudul = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmbKomunitas = New System.Windows.Forms.ComboBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.dtpLahir = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mtxtTelp = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSimpanCetak = New System.Windows.Forms.Button()
        Me.cbGame = New System.Windows.Forms.CheckBox()
        Me.cbSosial = New System.Windows.Forms.CheckBox()
        Me.cbMemasak = New System.Windows.Forms.CheckBox()
        Me.cbFotografi = New System.Windows.Forms.CheckBox()
        Me.cbTraveling = New System.Windows.Forms.CheckBox()
        Me.cbMembaca = New System.Windows.Forms.CheckBox()
        Me.cbOlahraga = New System.Windows.Forms.CheckBox()
        Me.cbMusik = New System.Windows.Forms.CheckBox()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbAnggota = New System.Windows.Forms.RadioButton()
        Me.rbKetua = New System.Windows.Forms.RadioButton()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem, Me.LihatKartuToolStripMenuItem, Me.SimpanDataToolStripMenuItem, Me.BukaDataToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1029, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'LihatKartuToolStripMenuItem
        '
        Me.LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        Me.LihatKartuToolStripMenuItem.Size = New System.Drawing.Size(111, 29)
        Me.LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        '
        'SimpanDataToolStripMenuItem
        '
        Me.SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        Me.SimpanDataToolStripMenuItem.Size = New System.Drawing.Size(130, 29)
        Me.SimpanDataToolStripMenuItem.Text = "Simpan Data"
        '
        'BukaDataToolStripMenuItem
        '
        Me.BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        Me.BukaDataToolStripMenuItem.Size = New System.Drawing.Size(108, 29)
        Me.BukaDataToolStripMenuItem.Text = "Buka Data"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'lbljudul
        '
        Me.lbljudul.AutoSize = True
        Me.lbljudul.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbljudul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbljudul.Location = New System.Drawing.Point(546, 106)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(184, 20)
        Me.lbljudul.TabIndex = 1
        Me.lbljudul.Text = "Aplikasi Kartu Komunitas"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(409, 139)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(453, 267)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbKomunitas)
        Me.TabPage1.Controls.Add(Me.rbPerempuan)
        Me.TabPage1.Controls.Add(Me.rbLaki)
        Me.TabPage1.Controls.Add(Me.dtpLahir)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtNama)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(445, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Utama"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbKomunitas
        '
        Me.cmbKomunitas.FormattingEnabled = True
        Me.cmbKomunitas.Items.AddRange(New Object() {"Programmer", "Multimedia", "Desain Grafis", "Gaming"})
        Me.cmbKomunitas.Location = New System.Drawing.Point(137, 167)
        Me.cmbKomunitas.Name = "cmbKomunitas"
        Me.cmbKomunitas.Size = New System.Drawing.Size(282, 28)
        Me.cmbKomunitas.TabIndex = 11
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(285, 133)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(116, 24)
        Me.rbPerempuan.TabIndex = 10
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(137, 133)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(105, 24)
        Me.rbLaki.TabIndex = 9
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki - Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'dtpLahir
        '
        Me.dtpLahir.Location = New System.Drawing.Point(137, 93)
        Me.dtpLahir.Name = "dtpLahir"
        Me.dtpLahir.Size = New System.Drawing.Size(200, 26)
        Me.dtpLahir.TabIndex = 8
        Me.dtpLahir.Value = New Date(2026, 4, 6, 0, 0, 0, 0)
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(137, 54)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(282, 26)
        Me.txtID.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Komunitas :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jenis Kelamin :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal Lahir :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Anggota :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(137, 17)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(282, 26)
        Me.txtNama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Lengkap :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtAlamat)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.mtxtTelp)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(445, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kontak & Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(82, 119)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(274, 89)
        Me.txtAlamat.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(82, 74)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(274, 26)
        Me.txtEmail.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Alamat :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Email :"
        '
        'mtxtTelp
        '
        Me.mtxtTelp.Location = New System.Drawing.Point(82, 24)
        Me.mtxtTelp.Mask = " 0000-0000-0000"
        Me.mtxtTelp.Name = "mtxtTelp"
        Me.mtxtTelp.Size = New System.Drawing.Size(136, 26)
        Me.mtxtTelp.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No Hp :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(445, 234)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Profil & aktivitas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSimpanCetak)
        Me.GroupBox1.Controls.Add(Me.cbGame)
        Me.GroupBox1.Controls.Add(Me.cbSosial)
        Me.GroupBox1.Controls.Add(Me.cbMemasak)
        Me.GroupBox1.Controls.Add(Me.cbFotografi)
        Me.GroupBox1.Controls.Add(Me.cbTraveling)
        Me.GroupBox1.Controls.Add(Me.cbMembaca)
        Me.GroupBox1.Controls.Add(Me.cbOlahraga)
        Me.GroupBox1.Controls.Add(Me.cbMusik)
        Me.GroupBox1.Controls.Add(Me.rbAdmin)
        Me.GroupBox1.Controls.Add(Me.rbAnggota)
        Me.GroupBox1.Controls.Add(Me.rbKetua)
        Me.GroupBox1.Controls.Add(Me.picFoto)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 222)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Peran"
        '
        'btnSimpanCetak
        '
        Me.btnSimpanCetak.Location = New System.Drawing.Point(157, 189)
        Me.btnSimpanCetak.Name = "btnSimpanCetak"
        Me.btnSimpanCetak.Size = New System.Drawing.Size(203, 27)
        Me.btnSimpanCetak.TabIndex = 12
        Me.btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        Me.btnSimpanCetak.UseVisualStyleBackColor = True
        '
        'cbGame
        '
        Me.cbGame.AutoSize = True
        Me.cbGame.Location = New System.Drawing.Point(138, 65)
        Me.cbGame.Name = "cbGame"
        Me.cbGame.Size = New System.Drawing.Size(79, 24)
        Me.cbGame.TabIndex = 3
        Me.cbGame.Text = "Game"
        Me.cbGame.UseVisualStyleBackColor = True
        '
        'cbSosial
        '
        Me.cbSosial.AutoSize = True
        Me.cbSosial.Location = New System.Drawing.Point(296, 155)
        Me.cbSosial.Name = "cbSosial"
        Me.cbSosial.Size = New System.Drawing.Size(78, 24)
        Me.cbSosial.TabIndex = 11
        Me.cbSosial.Text = "Sosial"
        Me.cbSosial.UseVisualStyleBackColor = True
        '
        'cbMemasak
        '
        Me.cbMemasak.AutoSize = True
        Me.cbMemasak.Location = New System.Drawing.Point(296, 125)
        Me.cbMemasak.Name = "cbMemasak"
        Me.cbMemasak.Size = New System.Drawing.Size(104, 24)
        Me.cbMemasak.TabIndex = 10
        Me.cbMemasak.Text = "Memasak"
        Me.cbMemasak.UseVisualStyleBackColor = True
        '
        'cbFotografi
        '
        Me.cbFotografi.AutoSize = True
        Me.cbFotografi.Location = New System.Drawing.Point(296, 95)
        Me.cbFotografi.Name = "cbFotografi"
        Me.cbFotografi.Size = New System.Drawing.Size(99, 24)
        Me.cbFotografi.TabIndex = 9
        Me.cbFotografi.Text = "Fotografi"
        Me.cbFotografi.UseVisualStyleBackColor = True
        '
        'cbTraveling
        '
        Me.cbTraveling.AutoSize = True
        Me.cbTraveling.Location = New System.Drawing.Point(296, 65)
        Me.cbTraveling.Name = "cbTraveling"
        Me.cbTraveling.Size = New System.Drawing.Size(98, 24)
        Me.cbTraveling.TabIndex = 8
        Me.cbTraveling.Text = "Traveling"
        Me.cbTraveling.UseVisualStyleBackColor = True
        '
        'cbMembaca
        '
        Me.cbMembaca.AutoSize = True
        Me.cbMembaca.Location = New System.Drawing.Point(138, 155)
        Me.cbMembaca.Name = "cbMembaca"
        Me.cbMembaca.Size = New System.Drawing.Size(105, 24)
        Me.cbMembaca.TabIndex = 7
        Me.cbMembaca.Text = "Membaca"
        Me.cbMembaca.UseVisualStyleBackColor = True
        '
        'cbOlahraga
        '
        Me.cbOlahraga.AutoSize = True
        Me.cbOlahraga.Location = New System.Drawing.Point(138, 125)
        Me.cbOlahraga.Name = "cbOlahraga"
        Me.cbOlahraga.Size = New System.Drawing.Size(100, 24)
        Me.cbOlahraga.TabIndex = 6
        Me.cbOlahraga.Text = "Olahraga"
        Me.cbOlahraga.UseVisualStyleBackColor = True
        '
        'cbMusik
        '
        Me.cbMusik.AutoSize = True
        Me.cbMusik.Location = New System.Drawing.Point(138, 95)
        Me.cbMusik.Name = "cbMusik"
        Me.cbMusik.Size = New System.Drawing.Size(76, 24)
        Me.cbMusik.TabIndex = 5
        Me.cbMusik.Text = "Musik"
        Me.cbMusik.UseVisualStyleBackColor = True
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Location = New System.Drawing.Point(306, 25)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(79, 24)
        Me.rbAdmin.TabIndex = 4
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbAnggota
        '
        Me.rbAnggota.AutoSize = True
        Me.rbAnggota.Location = New System.Drawing.Point(205, 25)
        Me.rbAnggota.Name = "rbAnggota"
        Me.rbAnggota.Size = New System.Drawing.Size(95, 24)
        Me.rbAnggota.TabIndex = 3
        Me.rbAnggota.TabStop = True
        Me.rbAnggota.Text = "Anggota"
        Me.rbAnggota.UseVisualStyleBackColor = True
        '
        'rbKetua
        '
        Me.rbKetua.AutoSize = True
        Me.rbKetua.Location = New System.Drawing.Point(123, 25)
        Me.rbKetua.Name = "rbKetua"
        Me.rbKetua.Size = New System.Drawing.Size(76, 24)
        Me.rbKetua.TabIndex = 2
        Me.rbKetua.TabStop = True
        Me.rbKetua.Text = "Ketua"
        Me.rbKetua.UseVisualStyleBackColor = True
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(6, 25)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(100, 124)
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(6, 164)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 28)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Pilih Foto"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 540)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbljudul)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbljudul As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents mtxtTelp As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents cbSosial As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents btnSimpanCetak As Button
End Class
