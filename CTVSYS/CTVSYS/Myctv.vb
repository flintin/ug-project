Public Class Myctv

    Private Sub Myctv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.CTVInfoDB' table. You can move, or remove it, as needed.
        Me.CTVInfoDBTableAdapter.Fill(Me.DatabaseDataSet.CTVInfoDB)
        Label1.Text = My.Settings.Name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CTVInfoDBBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CTVInfoDBBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CTVInfoDBBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error GoTo SaveErr
        CTVInfoDBBindingSource.EndEdit()
        CTVInfoDBTableAdapter.Update(DatabaseDataSet.CTVInfoDB)
        MessageBox.Show("Record saved!")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CTVInfoDBBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
    End Sub
End Class