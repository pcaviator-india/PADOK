Public Class frmGroupView
    Private Sub frmGroupView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        filldgv()

    End Sub

    Private Sub filldgv()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "LedgerGroup")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "ledgerGroup"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class