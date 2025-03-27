<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        PictureBox1 = New PictureBox()
        btnBrowse = New Button()
        labelNama = New Label()
        labelUmur = New Label()
        labelTanggalLahir = New Label()
        labelNoTelepon = New Label()
        labelAlamat = New Label()
        textboxNama = New TextBox()
        textboxAlamat = New TextBox()
        textboxNoTelepon = New TextBox()
        textboxUmur = New TextBox()
        datetimepickerTanggalLahir = New DateTimePicker()
        groupboxJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLakiLaki = New RadioButton()
        groupboxHobby = New GroupBox()
        cbTenis = New CheckBox()
        cbMenulis = New CheckBox()
        cbSurfing = New CheckBox()
        cbMembaca = New CheckBox()
        cbHiking = New CheckBox()
        cbCatur = New CheckBox()
        cbBerenang = New CheckBox()
        cbMenari = New CheckBox()
        cbMenggambar = New CheckBox()
        cbMenyanyi = New CheckBox()
        btnCetakKartu = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        groupboxJenisKelamin.SuspendLayout()
        groupboxHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 117)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(12, 176)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' labelNama
        ' 
        labelNama.AutoSize = True
        labelNama.Location = New Point(144, 39)
        labelNama.Name = "labelNama"
        labelNama.Size = New Size(39, 15)
        labelNama.TabIndex = 2
        labelNama.Text = "Nama"
        ' 
        ' labelUmur
        ' 
        labelUmur.AutoSize = True
        labelUmur.Location = New Point(146, 74)
        labelUmur.Name = "labelUmur"
        labelUmur.Size = New Size(37, 15)
        labelUmur.TabIndex = 3
        labelUmur.Text = "Umur"
        ' 
        ' labelTanggalLahir
        ' 
        labelTanggalLahir.AutoSize = True
        labelTanggalLahir.Location = New Point(144, 106)
        labelTanggalLahir.Name = "labelTanggalLahir"
        labelTanggalLahir.Size = New Size(77, 15)
        labelTanggalLahir.TabIndex = 4
        labelTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' labelNoTelepon
        ' 
        labelNoTelepon.AutoSize = True
        labelNoTelepon.Location = New Point(144, 141)
        labelNoTelepon.Name = "labelNoTelepon"
        labelNoTelepon.Size = New Size(67, 15)
        labelNoTelepon.TabIndex = 5
        labelNoTelepon.Text = "No Telepon"
        ' 
        ' labelAlamat
        ' 
        labelAlamat.AutoSize = True
        labelAlamat.Location = New Point(146, 176)
        labelAlamat.Name = "labelAlamat"
        labelAlamat.Size = New Size(45, 15)
        labelAlamat.TabIndex = 6
        labelAlamat.Text = "Alamat"
        ' 
        ' textboxNama
        ' 
        textboxNama.Location = New Point(253, 36)
        textboxNama.Name = "textboxNama"
        textboxNama.Size = New Size(213, 23)
        textboxNama.TabIndex = 7
        ' 
        ' textboxAlamat
        ' 
        textboxAlamat.Location = New Point(253, 177)
        textboxAlamat.Name = "textboxAlamat"
        textboxAlamat.Size = New Size(213, 23)
        textboxAlamat.TabIndex = 8
        ' 
        ' textboxNoTelepon
        ' 
        textboxNoTelepon.Location = New Point(253, 138)
        textboxNoTelepon.Name = "textboxNoTelepon"
        textboxNoTelepon.Size = New Size(213, 23)
        textboxNoTelepon.TabIndex = 9
        ' 
        ' textboxUmur
        ' 
        textboxUmur.Location = New Point(253, 71)
        textboxUmur.Name = "textboxUmur"
        textboxUmur.Size = New Size(213, 23)
        textboxUmur.TabIndex = 10
        ' 
        ' datetimepickerTanggalLahir
        ' 
        datetimepickerTanggalLahir.Location = New Point(253, 106)
        datetimepickerTanggalLahir.Name = "datetimepickerTanggalLahir"
        datetimepickerTanggalLahir.Size = New Size(213, 23)
        datetimepickerTanggalLahir.TabIndex = 11
        ' 
        ' groupboxJenisKelamin
        ' 
        groupboxJenisKelamin.Controls.Add(rbPerempuan)
        groupboxJenisKelamin.Controls.Add(rbLakiLaki)
        groupboxJenisKelamin.Location = New Point(76, 284)
        groupboxJenisKelamin.Name = "groupboxJenisKelamin"
        groupboxJenisKelamin.Size = New Size(200, 100)
        groupboxJenisKelamin.TabIndex = 12
        groupboxJenisKelamin.TabStop = False
        groupboxJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(42, 63)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Location = New Point(42, 29)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(72, 19)
        rbLakiLaki.TabIndex = 0
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki-Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' groupboxHobby
        ' 
        groupboxHobby.Controls.Add(cbTenis)
        groupboxHobby.Controls.Add(cbMenulis)
        groupboxHobby.Controls.Add(cbSurfing)
        groupboxHobby.Controls.Add(cbMembaca)
        groupboxHobby.Controls.Add(cbHiking)
        groupboxHobby.Controls.Add(cbCatur)
        groupboxHobby.Controls.Add(cbBerenang)
        groupboxHobby.Controls.Add(cbMenari)
        groupboxHobby.Controls.Add(cbMenggambar)
        groupboxHobby.Controls.Add(cbMenyanyi)
        groupboxHobby.Location = New Point(326, 241)
        groupboxHobby.Name = "groupboxHobby"
        groupboxHobby.Size = New Size(251, 143)
        groupboxHobby.TabIndex = 13
        groupboxHobby.TabStop = False
        groupboxHobby.Text = "Hobby"
        ' 
        ' cbTenis
        ' 
        cbTenis.AutoSize = True
        cbTenis.Location = New Point(146, 118)
        cbTenis.Name = "cbTenis"
        cbTenis.Size = New Size(52, 19)
        cbTenis.TabIndex = 21
        cbTenis.Text = "Tenis"
        cbTenis.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(6, 68)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(68, 19)
        cbMenulis.TabIndex = 23
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbSurfing
        ' 
        cbSurfing.AutoSize = True
        cbSurfing.Location = New Point(146, 93)
        cbSurfing.Name = "cbSurfing"
        cbSurfing.Size = New Size(64, 19)
        cbSurfing.TabIndex = 20
        cbSurfing.Text = "Surfing"
        cbSurfing.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(6, 22)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(79, 19)
        cbMembaca.TabIndex = 14
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbHiking
        ' 
        cbHiking.AutoSize = True
        cbHiking.Location = New Point(146, 68)
        cbHiking.Name = "cbHiking"
        cbHiking.Size = New Size(61, 19)
        cbHiking.TabIndex = 18
        cbHiking.Text = "Hiking"
        cbHiking.UseVisualStyleBackColor = True
        ' 
        ' cbCatur
        ' 
        cbCatur.AutoSize = True
        cbCatur.Location = New Point(146, 43)
        cbCatur.Name = "cbCatur"
        cbCatur.Size = New Size(55, 19)
        cbCatur.TabIndex = 19
        cbCatur.Text = "Catur"
        cbCatur.UseVisualStyleBackColor = True
        ' 
        ' cbBerenang
        ' 
        cbBerenang.AutoSize = True
        cbBerenang.Location = New Point(6, 43)
        cbBerenang.Name = "cbBerenang"
        cbBerenang.Size = New Size(76, 19)
        cbBerenang.TabIndex = 22
        cbBerenang.Text = "Berenang"
        cbBerenang.UseVisualStyleBackColor = True
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(6, 93)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(63, 19)
        cbMenari.TabIndex = 16
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(146, 22)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(98, 19)
        cbMenggambar.TabIndex = 17
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(6, 118)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(78, 19)
        cbMenyanyi.TabIndex = 15
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.Location = New Point(76, 410)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(501, 23)
        btnCetakKartu.TabIndex = 14
        btnCetakKartu.Text = "Cetak Kartu"
        btnCetakKartu.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCetakKartu)
        Controls.Add(groupboxHobby)
        Controls.Add(groupboxJenisKelamin)
        Controls.Add(datetimepickerTanggalLahir)
        Controls.Add(textboxUmur)
        Controls.Add(textboxNoTelepon)
        Controls.Add(textboxAlamat)
        Controls.Add(textboxNama)
        Controls.Add(labelAlamat)
        Controls.Add(labelNoTelepon)
        Controls.Add(labelTanggalLahir)
        Controls.Add(labelUmur)
        Controls.Add(labelNama)
        Controls.Add(btnBrowse)
        Controls.Add(PictureBox1)
        Name = "form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        groupboxJenisKelamin.ResumeLayout(False)
        groupboxJenisKelamin.PerformLayout()
        groupboxHobby.ResumeLayout(False)
        groupboxHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents labelNama As Label
    Friend WithEvents labelUmur As Label
    Friend WithEvents labelTanggalLahir As Label
    Friend WithEvents labelNoTelepon As Label
    Friend WithEvents labelAlamat As Label
    Friend WithEvents textboxNama As TextBox
    Friend WithEvents textboxAlamat As TextBox
    Friend WithEvents textboxNoTelepon As TextBox
    Friend WithEvents textboxUmur As TextBox
    Friend WithEvents datetimepickerTanggalLahir As DateTimePicker
    Friend WithEvents groupboxJenisKelamin As GroupBox
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents groupboxHobby As GroupBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbHiking As CheckBox
    Friend WithEvents cbCatur As CheckBox
    Friend WithEvents cbSurfing As CheckBox
    Friend WithEvents cbTenis As CheckBox
    Friend WithEvents cbBerenang As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents btnCetakKartu As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
