Imports System.Data.SqlClient

Public Class frmCategoryEdit
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim c, d As Integer
        c = dgvCategory.SelectedRows.Item(0).Index
        d = dgvCategory.Rows(c).Cells(0).Value

        Dim con As New SqlConnection
        Dim CMD As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "delete  FROM LEdgerCategory where CategoryId= @CategoryId"
            CMD.Parameters.Add(New SqlParameter("@CategoryId", d))
            CMD.ExecuteNonQuery()
            MsgBox("Deleted")
            CommanFunctions.updateDGV(dgvCategory, "*", "LedgerCategory")
            clearAll()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub clearAll()
        dgvCategory.ClearSelection()
        tbCategoryId.Text = ""
        tbCategoryName.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con As New SqlConnection
        Dim CMD As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "UPDATE LedgerCategory SET Name=@Name
                                WHERE CategoryId=@CategoryId"

            CMD.Parameters.Add("@CategoryId", SqlDbType.Int).Value = tbCategoryId.Text
            CMD.Parameters.Add("@Name", SqlDbType.Text).Value = tbCategoryName.Text

            CMD.ExecuteNonQuery()
            MsgBox("Success")
            CommanFunctions.updateDGV(dgvCategory, "*", "LedgerCategory")
            clearAll()

        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub

    Private Sub frmCategoryEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCategory.MultiSelect = False

        CommanFunctions.updateDGV(dgvCategory, "*", "LedgerCategory")
    End Sub

    Private Sub dgvCategory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCategory.SelectionChanged
        Dim curRow As Integer = dgvCategory.CurrentRow.Index
        tbCategoryName.Text = dgvCategory.Rows(curRow).Cells(1).Value
        tbCategoryId.Text = dgvCategory.Rows(curRow).Cells(0).Value
    End Sub

    Private Sub dgvCategory_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCategory.DataBindingComplete
        dgvCategory.ClearSelection()
        clearAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class