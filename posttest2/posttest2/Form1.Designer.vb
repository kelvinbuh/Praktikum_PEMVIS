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
        GroupBox1 = New GroupBox()
        txtGenre = New TextBox()
        Button_tambah = New Button()
        Label2 = New Label()
        Judul_Buku = New TextBox()
        Label1 = New Label()
        Hapus_buku = New GroupBox()
        Button_hapus = New Button()
        Hapus_judul_buku = New TextBox()
        Label3 = New Label()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        Hapus_buku.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(Button_tambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Judul_Buku)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(223, 146)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(106, 64)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(100, 23)
        txtGenre.TabIndex = 5
        ' 
        ' Button_tambah
        ' 
        Button_tambah.Location = New Point(131, 102)
        Button_tambah.Name = "Button_tambah"
        Button_tambah.Size = New Size(75, 23)
        Button_tambah.TabIndex = 4
        Button_tambah.Text = "Tambah"
        Button_tambah.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 2
        Label2.Text = "Genre"
        ' 
        ' Judul_Buku
        ' 
        Judul_Buku.Location = New Point(106, 24)
        Judul_Buku.Name = "Judul_Buku"
        Judul_Buku.Size = New Size(100, 23)
        Judul_Buku.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' Hapus_buku
        ' 
        Hapus_buku.Controls.Add(Button_hapus)
        Hapus_buku.Controls.Add(Hapus_judul_buku)
        Hapus_buku.Controls.Add(Label3)
        Hapus_buku.Location = New Point(362, 12)
        Hapus_buku.Name = "Hapus_buku"
        Hapus_buku.Size = New Size(207, 114)
        Hapus_buku.TabIndex = 1
        Hapus_buku.TabStop = False
        Hapus_buku.Text = "Hapus Buku"
        ' 
        ' Button_hapus
        ' 
        Button_hapus.Location = New Point(132, 91)
        Button_hapus.Name = "Button_hapus"
        Button_hapus.Size = New Size(75, 23)
        Button_hapus.TabIndex = 2
        Button_hapus.Text = "Hapus"
        Button_hapus.UseVisualStyleBackColor = True
        ' 
        ' Hapus_judul_buku
        ' 
        Hapus_judul_buku.Location = New Point(100, 24)
        Hapus_judul_buku.Name = "Hapus_judul_buku"
        Hapus_judul_buku.Size = New Size(100, 23)
        Hapus_judul_buku.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(200, 177)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(239, 139)
        ListBox1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(Hapus_buku)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Hapus_buku.ResumeLayout(False)
        Hapus_buku.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Judul_Buku As TextBox
    Friend WithEvents Button_tambah As Button
    Friend WithEvents Hapus_buku As GroupBox
    Friend WithEvents Button_hapus As Button
    Friend WithEvents Hapus_judul_buku As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtGenre As TextBox

End Class
