Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim() = "nani" AndAlso TextBox2.Text.Trim() = "3300" Then

            Dim form As New Form
            My.Forms.Form1.Hide()
            My.Forms.Form2.Show()

        Else

            MessageBox.Show("Enter valid username and password")
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
