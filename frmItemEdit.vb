Imports System.Data.SqlClient

Public Class frmItemEdit
    Private Sub frmItemEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        CommanFunctions.updateDGV(DataGridView1, "*", "Item")
        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ClearSelection()
    End Sub

    Private Sub concatAllExceptBlank()

        lblFullname.Text = ""
        Dim txtboxes() As String = {tbCloth.Text, tbClothModel.Text, tbItem.Text, tbItemModel.Text, tbSize.Text, tbDesc.Text}
        lblFullname.Text = tbCloth.Text.ToUpper
        For i = 1 To 5
            If Not String.IsNullOrWhiteSpace(txtboxes(i)) Then
                lblFullname.Text = lblFullname.Text & " " & txtboxes(i).ToUpper
            End If
        Next
    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.ClearSelection()
        clearAll()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim curRow As Integer = DataGridView1.CurrentRow.Index
            Dim dgv As New DataGridView
            dgv = DataGridView1
            tbCloth.Text = dgv.Rows(curRow).Cells(2).Value.ToString.ToUpper
            tbClothModel.Text = dgv.Rows(curRow).Cells(3).Value.ToString.ToUpper
            tbItem.Text = dgv.Rows(curRow).Cells(4).Value.ToString.ToUpper
            tbItemModel.Text = dgv.Rows(curRow).Cells(5).Value.ToString.ToUpper
            tbSize.Text = dgv.Rows(curRow).Cells(6).Value.ToString.ToUpper
            tbDesc.Text = dgv.Rows(curRow).Cells(7).Value.ToString.ToUpper
            tbId.Text = dgv.Rows(curRow).Cells(0).Value.ToString.ToUpper
        Catch ex As Exception

        End Try

    End Sub
    Private Sub clearAll()
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.Text = ""
            End If
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c, d As Integer
        If DataGridView1.SelectedRows.Count > 0 Then

            c = DataGridView1.SelectedRows.Item(0).Index
            d = DataGridView1.Rows(c).Cells(0).Value

            Dim con As New SqlConnection
            Dim CMD As New SqlCommand

            Try
                con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
                con.Open()
                CMD.Connection = con
                CMD.CommandText = "delete FROM Item where ItemId= @ItemId"
                CMD.Parameters.Add(New SqlParameter("@ItemId", d))
                CMD.ExecuteNonQuery()

                MsgBox("Success")
                CommanFunctions.updateDGV(DataGridView1, "*", "Item")
                clearAll()

            Catch ex As SqlException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub tbClothModel_TextChanged(sender As Object, e As EventArgs) Handles tbClothModel.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbCloth_TextChanged(sender As Object, e As EventArgs) Handles tbCloth.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbDesc_TextChanged(sender As Object, e As EventArgs) Handles tbDesc.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbItem_TextChanged(sender As Object, e As EventArgs) Handles tbItem.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbItemModel_TextChanged(sender As Object, e As EventArgs) Handles tbItemModel.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbSize_TextChanged(sender As Object, e As EventArgs) Handles tbSize.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim CMD As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "UPDATE Item SET Item_Name=@Name, Cloth=@Cloth, CLothModel=@ClothModel, Item=@Item, ItemModel=@ItemModel, Size=@Size, [Desc]=@Desc
                                WHERE ItemId=@ItemId"
            CMD.Parameters.Add("@ItemId", SqlDbType.Int).Value = tbId.Text
            CMD.Parameters.Add("@Name", SqlDbType.Text).Value = lblFullname.Text.ToUpper
            CMD.Parameters.Add("@Cloth", SqlDbType.Text).Value = tbCloth.Text.ToUpper
            CMD.Parameters.Add("@ClothModel", SqlDbType.Text).Value = tbClothModel.Text.ToUpper
            CMD.Parameters.Add("@Item", SqlDbType.Text).Value = tbItem.Text.ToUpper
            CMD.Parameters.Add("@ItemModel", SqlDbType.Text).Value = tbItemModel.Text.ToUpper
            CMD.Parameters.Add("@Size", SqlDbType.Text).Value = tbSize.Text.ToUpper
            CMD.Parameters.Add("@Desc", SqlDbType.Text).Value = tbDesc.Text.ToUpper

            CMD.ExecuteNonQuery()
            MsgBox("Success")
            CommanFunctions.updateDGV(DataGridView1, "*", "Item")
            clearAll()

        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class