Imports System.Data.SqlClient

Public Class frmUnitEdit
    Private Sub frmUnitEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        fillDGV()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

    End Sub



    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim curRow As Integer = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Rows(curRow).Cells(0).Value

    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
        TextBox1.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub fillDGV()
        Dim dgv As New DataGridView
        dgv = DataGridView1

        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "Unit")
        dgv.DataSource = ds
        dgv.DataMember = "Unit"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con As New SqlConnection
        Dim CMD As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "UPDATE Unit SET Item_Unit=@Name
                                WHERE Item_Unit like @oldName"

            CMD.Parameters.Add("@Name", SqlDbType.Text).Value = TextBox1.Text
            CMD.Parameters.Add("@OldName", SqlDbType.Text).Value = DataGridView1.CurrentRow.Cells(0).Value

            CMD.ExecuteNonQuery()
            MsgBox("Success")
            CommanFunctions.updateDGV(DataGridView1, "*", "Unit")


        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim c As Integer
        Dim d As String



        Dim con As New SqlConnection
        Dim CMD As New SqlCommand
        Try
            c = DataGridView1.SelectedRows.Item(0).Index
            d = DataGridView1.Rows(c).Cells(0).Value
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "delete FROM Unit where Item_Unit LIKE @Unit"
            CMD.Parameters.Add(New SqlParameter("@Unit", d))
            CMD.ExecuteNonQuery()
            MsgBox("Deleted")
            CommanFunctions.updateDGV(DataGridView1, "*", "Unit")
            TextBox1.Text = ""
            TextBox1.Focus()
            DataGridView1.ClearSelection()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class