Public Class Form2

    Private Sub CTVInfoDBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CTVInfoDBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.CTVInfoDB' table. You can move, or remove it, as needed.
        'Me.CTVInfoDBTableAdapter.Fill(Me.DatabaseDataSet.CTVInfoDB)

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim search As String = "%" + txtsearch.Text + "%"

        Me.CTVInfoDBTableAdapter.FillBySearchName(Me.DatabaseDataSet.CTVInfoDB, search, search)
    End Sub

End Class