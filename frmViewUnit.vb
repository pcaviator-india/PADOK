Imports System.Data.SqlClient

Public Class frmViewUnit
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_GotFocus(sender As Object, e As EventArgs) Handles DataGridView1.GotFocus
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Dim ds As New DataSet()
        ds = CommanFunctions.connectSQL("*", "unit")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Unit"
    End Sub

    Private Sub frmViewUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class