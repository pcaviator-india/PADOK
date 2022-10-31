Public Class frmLedgerView
    Private Sub frmLedgerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        fillDgv()

    End Sub

    Private Sub fillDgv()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("LedgerId,Name", "Ledger")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Ledger"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class