Public Class frmPurchaseEdit
    Private Sub frmPurchaseEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.updateDGV(DataGridView1, "*", "Purchase")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim curRow As Integer = DataGridView1.CurrentRow().Index
        Dim PurchaseId As Integer = DataGridView1.Rows(curRow).Cells("PurId").Value
        Dim ChallanNo As String = DataGridView1.Rows(curRow).Cells("Challan_no").Value
        Dim Billno As String = DataGridView1.Rows(curRow).Cells("Bill_no").Value
        Dim supplier As String = DataGridView1.Rows(curRow).Cells("Supplier").Value
        Dim frm As New frmPurchaseEditDetail(PurchaseId, ChallanNo, BillNO, Supplier)
        frm.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class