Public Class Form1
    ' Saat Form dibuka, tampilkan daftar buku (jika ada)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanDaftarBuku()
    End Sub

    ' FUNCTION - Untuk menggabungkan judul dan genre
    Private Function FormatBuku(ByVal judul As String, ByVal genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

    ' PROCEDURE - Untuk menambahkan buku ke array (pakai ByVal)
    Private Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < daftarBuku.Length Then
            daftarBuku(jumlahBuku) = FormatBuku(judul, genre)
            jumlahBuku += 1
        Else
            MessageBox.Show("Kapasitas daftar buku sudah penuh!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' PROCEDURE - Untuk menghapus buku berdasarkan judul
    Private Sub HapusBuku(ByVal judul As String)
        Dim indexDitemukan As Integer = -1

        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i).StartsWith(judul & " (") Then
                indexDitemukan = i
                Exit For
            End If
        Next

        If indexDitemukan <> -1 Then
            ' Geser data ke atas untuk menutup posisi yang dihapus
            For j As Integer = indexDitemukan To jumlahBuku - 2
                daftarBuku(j) = daftarBuku(j + 1)
            Next
            daftarBuku(jumlahBuku - 1) = Nothing
            jumlahBuku -= 1
        Else
            MessageBox.Show("Judul buku tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' PROCEDURE - Menampilkan daftar buku di ListBox
    Private Sub TampilkanDaftarBuku()
        ListBox1.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            ListBox1.Items.Add(daftarBuku(i))
        Next
    End Sub

    ' EVENT - Tombol Tambah
    Private Sub Button_tambah_Click(sender As Object, e As EventArgs) Handles Button_tambah.Click
        Dim judul As String = Judul_Buku.Text
        Dim genre As String = txtGenre.Text

        If judul <> "" And genre <> "" Then
            TambahBuku(judul, genre)
            TampilkanDaftarBuku()
            Judul_Buku.Clear()
            txtGenre.Clear()
        Else
            MessageBox.Show("Harap isi Judul dan Genre terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' EVENT - Tombol Hapus
    Private Sub Button_hapus_Click(sender As Object, e As EventArgs) Handles Button_hapus.Click
        Dim judulHapus As String = Hapus_judul_buku.Text

        If judulHapus <> "" Then
            HapusBuku(judulHapus)
            TampilkanDaftarBuku()
            Hapus_judul_buku.Clear()
        Else
            MessageBox.Show("Masukkan Judul Buku yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Genre_TextChanged(sender As Object, e As EventArgs) Handles txtGenre.TextChanged

    End Sub
End Class
