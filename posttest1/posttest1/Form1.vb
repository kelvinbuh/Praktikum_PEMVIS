Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.ReadOnly = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IPSemester As Double


        If Double.TryParse(TextBox1.Text, IPSemester) Then
            If IPSemester >= 0 And IPSemester <= 4 Then
                totalIP += IPSemester
                jumlahSemester += 1

                Dim ipk As Double = totalIP / jumlahSemester
                TextBox2.Text = ipk.ToString("0.00")

                If ipk >= 2 AndAlso ipk <= 2.75 Then
                    Label3.Text = "Cukup"
                ElseIf ipk > 2.75 AndAlso ipk <= 3.0 Then
                    Label3.Text = "Memuaskan"
                ElseIf ipk > 3.0 Then
                    Label3.Text = "sangat memuaskan"
                Else
                    Label3.Text = ""
                End If

                TextBox1.Text = ""
            Else
                MessageBox.Show("Masukkan IP semester antara 0  hingga 4", "Input tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalIP = 0
        jumlahSemester = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
