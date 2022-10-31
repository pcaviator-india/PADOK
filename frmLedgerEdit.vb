Imports System.Data.SqlClient

Public Class frmLedgerEdit
    Private Sub frmLedgerEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        CommanFunctions.updateDGV(DataGridView1, "*", "Ledger")

        ' filldgv()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        tbGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub filldgv()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "Ledger")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Ledger"

    End Sub




    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim curRow As Integer = DataGridView1.CurrentRow.Index
            tbLedgerId.Text = DataGridView1.Rows(curRow).Cells(0).Value
            tbLedgerName.Text = DataGridView1.Rows(curRow).Cells(1).Value
            lblGroupId.Text = DataGridView1.Rows(curRow).Cells(2).Value
            lblCategoryId.Text = DataGridView1.Rows(curRow).Cells(3).Value

            Dim ds As New DataSet
            ds = CommanFunctions.connectSQL("*", "LedgerGroup")

            For Each row As DataRow In ds.Tables(0).Rows
                If row(0) = lblGroupId.Text Then
                    tbGroup.Text = row(1)
                End If
            Next
            ds.Clear()
            ds = CommanFunctions.connectSQL("*", "LedgerCategory")
            For Each row As DataRow In ds.Tables(0).Rows
                If row(0) = lblCategoryId.Text Then
                    tbCategory.Text = row(1)
                End If
            Next
        End If

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
                CMD.CommandText = "delete FROM Ledger where LedgerId= @LedgerId"
                CMD.Parameters.Add(New SqlParameter("@LedgerId", d))
                CMD.ExecuteNonQuery()

                MsgBox("Success")
                CommanFunctions.updateDGV(DataGridView1, "*", "Ledger")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim CMD As New SqlCommand

        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            con.Open()
            CMD.Connection = con
            CMD.CommandText = "UPDATE Ledger SET Name=@Name, GroupId=@GroupId,CategoryId=@CategoryId
                                WHERE LedgerId=@LedgerId"

            CMD.Parameters.Add("@LedgerId", SqlDbType.Int).Value = tbLedgerId.Text
            CMD.Parameters.Add("@Name", SqlDbType.Text).Value = tbLedgerName.Text
            CMD.Parameters.Add("@GroupId", SqlDbType.Int).Value = lblGroupId.Text
            CMD.Parameters.Add("@CategoryId", SqlDbType.Int).Value = lblCategoryId.Text


            CMD.ExecuteNonQuery()
            MsgBox("Success")
            CommanFunctions.updateDGV(DataGridView1, "*", "Ledger")
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
        DataGridView1.ClearSelection()
        tbLedgerName.Text = ""
        tbLedgerId.Text = ""
        tbGroup.Text = ""
        tbCategory.Text = ""
        lblCategoryId.Text = ""
        lblGroupId.Text = ""

    End Sub


    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        clearAll()


    End Sub



    Private Sub tbCategory_LostFocus(sender As Object, e As EventArgs) Handles tbCategory.LostFocus

        Dim DS As New DataSet
        DS = CommanFunctions.connectSQL("*", "LedgerCategory")

        For Each row As DataRow In DS.Tables(0).Rows
            If row(1) = tbCategory.Text Then
                lblCategoryId.Text = row(0)
            End If
        Next
    End Sub

    Private Sub tbCategory_GotFocus(sender As Object, e As EventArgs) Handles tbCategory.GotFocus
        CommanFunctions.autocomplete("Name", "LedgerCategory", tbCategory, 0)

    End Sub

    Private Sub tbGroup_TextChanged(sender As Object, e As EventArgs) Handles tbGroup.TextChanged


    End Sub

    Private Sub tbGroup_GotFocus(sender As Object, e As EventArgs) Handles tbGroup.GotFocus
        CommanFunctions.autocomplete("Name", "LedgerGroup", tbGroup, 0)
    End Sub

    Private Sub tbCategory_TextChanged(sender As Object, e As EventArgs) Handles tbCategory.TextChanged


    End Sub

    Private Sub tbGroup_LostFocus(sender As Object, e As EventArgs) Handles tbGroup.LostFocus
        Dim DS As New DataSet
        DS = CommanFunctions.connectSQL("*", "LedgerGroup")

        For Each row As DataRow In DS.Tables(0).Rows
            If row(1) = tbGroup.Text Then
                lblGroupId.Text = row(0)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class