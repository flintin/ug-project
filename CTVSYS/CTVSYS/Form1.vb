Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Settings.Name = TextBox1.Text
            My.Settings.Username = TextBox2.Text
            My.Settings.Password = TextBox3.Text
            My.Settings.Retype = TextBox4.Text
            MsgBox("Your account has been created.")
            Application.Restart()

        Catch ex As Exception
            MsgBox("Your account has not been created.")
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If Not TextBox3.Text = TextBox2.Text Then
            Label6.Text = "Password not mactched"
        Else
            Label6.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox6.Text = My.Settings.Username And TextBox5.Text = My.Settings.Password Then
            Myctv.Show()
            Me.Close()
        Else
            MsgBox("Invalid username or password, try again.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
