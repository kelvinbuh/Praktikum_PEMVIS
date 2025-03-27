Imports System.IO

Public Class form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.JPG;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        ' Validasi inputan tidak boleh kosong
        If textboxNama.Text = "" OrElse textboxUmur.Text = "" OrElse
            textboxNoTelepon.Text = "" OrElse textboxAlamat.Text = "" OrElse
            (Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked) OrElse
            datetimepickerTanggalLahir.Value = Nothing Then

            MessageBox.Show("Inputan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi minimal 1 checkbox hobby harus dipilih
        Dim hobiDipilih As Boolean = False
        For Each ctrl As Control In groupboxHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = CType(ctrl, CheckBox)
                If chk.Checked Then
                    hobiDipilih = True
                    Exit For
                End If
            End If
        Next

        If Not hobiDipilih Then
            MessageBox.Show("Pilih minimal satu hobi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Membuka Form2 sebagai kartu hasil cetak
        Dim formKartu As New Form2()

        formKartu.labelNama.Text = textboxNama.Text
        formKartu.labelUmur.Text = textboxUmur.Text
        formKartu.labelNoTelepon.Text = textboxNoTelepon.Text
        formKartu.labelAlamat.Text = textboxAlamat.Text
        formKartu.labelTanggalLahir.Text = datetimepickerTanggalLahir.Value.ToString("dd MMMM yyyy")

        ' Menentukan jenis kelamin
        If rbLakiLaki.Checked Then
            formKartu.labelJenisKelamin.Text = "Laki-Laki"
        ElseIf rbPerempuan.Checked Then
            formKartu.labelJenisKelamin.Text = "Perempuan"
        End If

        ' Menggabungkan semua hobi yang dipilih
        Dim hobi As String = ""
        For Each ctrl As Control In groupboxHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = CType(ctrl, CheckBox)
                If chk.Checked Then
                    hobi &= chk.Text & ", "
                End If
            End If
        Next

        ' Menghilangkan koma terakhir
        formKartu.labelHobby.Text = hobi.TrimEnd(","c, " "c)

        ' Menampilkan gambar jika ada
        If PictureBox1.Image IsNot Nothing Then
            formKartu.PictureBox1.Image = PictureBox1.Image
        End If

        formKartu.ShowDialog()
    End Sub

    ' Membatasi input pada textbox Nama hanya huruf
    Private Sub textboxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Membatasi input pada textbox Umur hanya angka
    Private Sub textboxUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Membatasi input pada textbox Nomor Telepon hanya angka
    Private Sub textboxNoTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxNoTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
