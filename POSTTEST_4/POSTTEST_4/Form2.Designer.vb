<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHobi = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelp = New System.Windows.Forms.Label()
        Me.lblKomunitas = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(406, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KARTU KOMUNITAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(303, 172)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 151)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblHobi
        '
        Me.lblHobi.AutoSize = True
        Me.lblHobi.Location = New System.Drawing.Point(299, 342)
        Me.lblHobi.Name = "lblHobi"
        Me.lblHobi.Size = New System.Drawing.Size(46, 20)
        Me.lblHobi.TabIndex = 2
        Me.lblHobi.Text = "Hobi:"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(450, 332)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(67, 20)
        Me.lblAlamat.TabIndex = 3
        Me.lblAlamat.Text = "Alamat :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(450, 303)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email :"
        '
        'lblTelp
        '
        Me.lblTelp.AutoSize = True
        Me.lblTelp.Location = New System.Drawing.Point(450, 275)
        Me.lblTelp.Name = "lblTelp"
        Me.lblTelp.Size = New System.Drawing.Size(89, 20)
        Me.lblTelp.TabIndex = 5
        Me.lblTelp.Text = "No Telpon :"
        '
        'lblKomunitas
        '
        Me.lblKomunitas.AutoSize = True
        Me.lblKomunitas.Location = New System.Drawing.Point(450, 244)
        Me.lblKomunitas.Name = "lblKomunitas"
        Me.lblKomunitas.Size = New System.Drawing.Size(92, 20)
        Me.lblKomunitas.TabIndex = 6
        Me.lblKomunitas.Text = "Komunitas :"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(450, 212)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(99, 20)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID Anggota :"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(450, 180)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(125, 20)
        Me.lblNama.TabIndex = 8
        Me.lblNama.Text = "Nama Lengkap :"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 617)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblKomunitas)
        Me.Controls.Add(Me.lblTelp)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblHobi)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents lblHobi As Label
    Public WithEvents lblAlamat As Label
    Public WithEvents lblEmail As Label
    Public WithEvents lblTelp As Label
    Public WithEvents lblKomunitas As Label
    Public WithEvents lblID As Label
    Public WithEvents lblNama As Label
End Class
