Imports System.Data.SqlClient
Public Class frmItemView
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_GotFocus(sender As Object, e As EventArgs) Handles DataGridView1.GotFocus
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim ds As New DataSet()
        ds = CommanFunctions.connectSQL("*", "Item")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "item"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c, d As Integer
        c = DataGridView1.SelectedRows.Item(0).Index
        d = DataGridView1.Rows(c).Cells(0).Value

        Dim con As New SqlConnection
        Dim CMD As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "delete  FROM Item where itemId= @ItemId"
            CMD.Parameters.Add(New SqlParameter("@ItemId", d))
            CMD.ExecuteNonQuery()

        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)


        Finally
            con.Close()
        End Try

        'Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

        'Dim sql As String = "delete  FROM Item where itemId= '@d'"
        'Dim connection As New SqlConnection(connectionString)

        'CMD.Connection = connection


        'Dim dataadapter As New SqlDataAdapter(sql, connection)
        'connection.Open()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmItemView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
End Class