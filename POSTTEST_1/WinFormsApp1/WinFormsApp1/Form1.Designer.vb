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
        leflef = New Label()
        Label2 = New Label()
        lblIPK = New Label()
        lblPredikat = New Label()
        txtIPS = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' leflef
        ' 
        leflef.AutoSize = True
        leflef.Location = New Point(133, 101)
        leflef.Name = "leflef"
        leflef.Size = New Size(37, 25)
        leflef.TabIndex = 0
        leflef.Text = "IPS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(133, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 25)
        Label2.TabIndex = 1
        Label2.Text = "IPK"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(197, 208)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(46, 25)
        lblIPK.TabIndex = 2
        lblIPK.Text = "0.00"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(197, 252)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(19, 25)
        lblPredikat.TabIndex = 3
        lblPredikat.Text = "-"
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(197, 101)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(230, 31)
        txtIPS.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(197, 138)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(315, 138)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPS)
        Controls.Add(lblPredikat)
        Controls.Add(lblIPK)
        Controls.Add(Label2)
        Controls.Add(leflef)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents leflef As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button

End Class
