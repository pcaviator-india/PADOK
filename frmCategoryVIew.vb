Public Class frmCategoryVIew
    Private Sub frmCategoryVIew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldgv()

    End Sub
    Private Sub filldgv()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "LedgerCategory")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "LedgerCategory"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class