Public Class frmDayBookView
    Private Sub frmDayBookView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "DayBook")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "DayBook"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class