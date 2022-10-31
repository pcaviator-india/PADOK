Imports System.Data.SqlClient

Public Class frmGroupEdit

    Private Sub frmGroupEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        CommanFunctions.updateDGV(DataGridView1, "*", "LedgerGroup")
        'filldgv()
    End Sub

    Private Sub filldgv()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "LedgerGroup")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "LedgerGroup"

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim c, d As Integer
        c = DataGridView1.SelectedRows.Item(0).Index
        d = DataGridView1.Rows(c).Cells(0).Value

        Dim con As New SqlConnection
        Dim CMD As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "delete  FROM LEdgerGroup where GroupId= @GroupId"
            CMD.Parameters.Add(New SqlParameter("@GroupId", d))
            CMD.ExecuteNonQuery()
            MsgBox("Deleted")
            CommanFunctions.updateDGV(DataGridView1, "*", "LedgerGroup")
            clearAll()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim curRow As Integer = DataGridView1.CurrentRow.Index
        tbGroupName.Text = DataGridView1.Rows(curRow).Cells(1).Value
        lblGroupId.Text = DataGridView1.Rows(curRow).Cells(0).Value

    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        clearAll()
    End Sub
    Private Sub clearAll()
        DataGridView1.ClearSelection()
        tbGroupName.Text = ""
        lblGroupId.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim CMD As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "UPDATE LedgerGroup SET Name=@Name
                                WHERE GroupId=@GroupId"

            CMD.Parameters.Add("@GroupId", SqlDbType.Int).Value = lblGroupId.Text
            CMD.Parameters.Add("@Name", SqlDbType.Text).Value = tbGroupName.Text

            CMD.ExecuteNonQuery()
            MsgBox("Success")
            CommanFunctions.updateDGV(DataGridView1, "*", "LedgerGroup")
            clearAll()

        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub


End Class