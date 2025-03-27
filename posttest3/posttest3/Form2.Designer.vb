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
        PictureBox1 = New PictureBox()
        labelNama = New Label()
        labelUmur = New Label()
        labelTanggalLahir = New Label()
        labelNoTelepon = New Label()
        labelAlamat = New Label()
        labelJenisKelamin = New Label()
        labelHobby = New Label()
        labelKartuKomunitas = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(68, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 125)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' labelNama
        ' 
        labelNama.AutoSize = True
        labelNama.Location = New Point(232, 50)
        labelNama.Name = "labelNama"
        labelNama.Size = New Size(39, 15)
        labelNama.TabIndex = 1
        labelNama.Text = "Nama"
        ' 
        ' labelUmur
        ' 
        labelUmur.AutoSize = True
        labelUmur.Location = New Point(232, 83)
        labelUmur.Name = "labelUmur"
        labelUmur.Size = New Size(37, 15)
        labelUmur.TabIndex = 2
        labelUmur.Text = "Umur"
        ' 
        ' labelTanggalLahir
        ' 
        labelTanggalLahir.AutoSize = True
        labelTanggalLahir.Location = New Point(232, 176)
        labelTanggalLahir.Name = "labelTanggalLahir"
        labelTanggalLahir.Size = New Size(77, 15)
        labelTanggalLahir.TabIndex = 3
        labelTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' labelNoTelepon
        ' 
        labelNoTelepon.AutoSize = True
        labelNoTelepon.Location = New Point(232, 111)
        labelNoTelepon.Name = "labelNoTelepon"
        labelNoTelepon.Size = New Size(67, 15)
        labelNoTelepon.TabIndex = 4
        labelNoTelepon.Text = "No Telepon"
        ' 
        ' labelAlamat
        ' 
        labelAlamat.AutoSize = True
        labelAlamat.Location = New Point(232, 210)
        labelAlamat.Name = "labelAlamat"
        labelAlamat.Size = New Size(45, 15)
        labelAlamat.TabIndex = 5
        labelAlamat.Text = "Alamat"
        ' 
        ' labelJenisKelamin
        ' 
        labelJenisKelamin.AutoSize = True
        labelJenisKelamin.Location = New Point(234, 244)
        labelJenisKelamin.Name = "labelJenisKelamin"
        labelJenisKelamin.Size = New Size(78, 15)
        labelJenisKelamin.TabIndex = 6
        labelJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' labelHobby
        ' 
        labelHobby.AutoSize = True
        labelHobby.Location = New Point(234, 137)
        labelHobby.Name = "labelHobby"
        labelHobby.Size = New Size(43, 15)
        labelHobby.TabIndex = 7
        labelHobby.Text = "Hobby"
        ' 
        ' labelKartuKomunitas
        ' 
        labelKartuKomunitas.AutoSize = True
        labelKartuKomunitas.Location = New Point(243, 9)
        labelKartuKomunitas.Name = "labelKartuKomunitas"
        labelKartuKomunitas.Size = New Size(95, 15)
        labelKartuKomunitas.TabIndex = 9
        labelKartuKomunitas.Text = "Kartu Komunitas"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(labelKartuKomunitas)
        Controls.Add(labelHobby)
        Controls.Add(labelJenisKelamin)
        Controls.Add(labelAlamat)
        Controls.Add(labelNoTelepon)
        Controls.Add(labelTanggalLahir)
        Controls.Add(labelUmur)
        Controls.Add(labelNama)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelNama As Label
    Friend WithEvents labelUmur As Label
    Friend WithEvents labelTanggalLahir As Label
    Friend WithEvents labelNoTelepon As Label
    Friend WithEvents labelAlamat As Label
    Friend WithEvents labelJenisKelamin As Label
    Friend WithEvents labelHobby As Label
    Friend WithEvents labelKartuKomunitas As Label
End Class
