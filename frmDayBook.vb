Public Class frmDayBook
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DataGridView1.Rows.Add()
        Dim rowCount As Integer = DataGridView1.Rows.Count
        If rowCount > 0 Then
            DataGridView1.Rows(rowCount - 1).Cells(0).Value = tbTo.Text
            DataGridView1.Rows(rowCount - 1).Cells(1).Value = tbAmount.Text
            DataGridView1.Rows(rowCount - 1).Cells(2).Value = tbMemo.Text
        End If
        tbTo.Focus()
        clearTxtBoxExcept(Me, "tbFrom")
    End Sub
    Private Sub clearTxtBoxExcept(frm As Control, Optional txtboxName As String = "")
        For Each ctrl As Control In frm.Controls
            If TypeOf (ctrl) Is TextBox And ctrl.Name <> txtboxName Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    Private Sub frmDayBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 3
        DataGridView1.Columns(0).Name = "To"
        DataGridView1.Columns(1).Name = "Amount"
        DataGridView1.Columns(2).Name = "Memo"
        DataGridView1.Columns(0).Width = 250

        tbFrom.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbTo.AutoCompleteSource = AutoCompleteSource.CustomSource

        tbFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CommanFunctions.allTextboxUpperCase(Me)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim myconnect As New SqlClient.SqlConnection

        myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

        mycommand.Connection = myconnect
        mycommand.CommandText = "INSERT INTO Daybook (Date,FromLedger,ToLedger,Amount,Memo) 
                    VALUES (@Date,@LFrom,@To,@Amount,@Memo)"
        myconnect.Open()

        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                mycommand.Parameters.Clear()
                mycommand.Parameters.Add("@Date", SqlDbType.Date).Value = DateTimePicker1.Value.ToShortDateString
                mycommand.Parameters.Add("@LFrom", SqlDbType.Text).Value = tbFrom.Text
                mycommand.Parameters.Add("@To", SqlDbType.Text).Value = row.Cells(0).Value.ToString.ToUpper
                mycommand.Parameters.Add("@Amount", SqlDbType.Decimal).Value = Convert.ToInt32(row.Cells(1).Value)
                mycommand.Parameters.Add("@Memo", SqlDbType.Text).Value = row.Cells(2).Value
                mycommand.ExecuteNonQuery()
            Next

            MsgBox("SUCCESS")

            clearTxtBoxExcept(Me)
            lblFromId.Text = ""
            lblToId.Text = ""
            DataGridView1.Rows.Clear()
            tbFrom.Focus()
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)

        End Try

        myconnect.Close()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNewLedger.Click
        frmLedgerCreate.ShowDialog()

    End Sub

    Private Sub tbFrom_TextChanged(sender As Object, e As EventArgs) Handles tbFrom.TextChanged

    End Sub

    Private Sub getLedgerID(name As String, lblname As Label)
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "Ledger")
        For Each row As DataRow In ds.Tables(0).Rows
            If row(1) = name Then
                lblname.Text = row(0)
            End If
        Next


    End Sub

    Private Sub tbFrom_LostFocus(sender As Object, e As EventArgs) Handles tbFrom.LostFocus
        getLedgerID(tbFrom.Text, lblFromId)
    End Sub

    Private Sub tbTo_TextChanged(sender As Object, e As EventArgs) Handles tbTo.TextChanged

    End Sub

    Private Sub tbTo_LostFocus(sender As Object, e As EventArgs) Handles tbTo.LostFocus
        getLedgerID(tbTo.Text, lblToId)
    End Sub

    Private Sub tbFrom_GotFocus(sender As Object, e As EventArgs) Handles tbFrom.GotFocus
        CommanFunctions.autocomplete("name", "Ledger", tbFrom, 0)

    End Sub

    Private Sub tbTo_GotFocus(sender As Object, e As EventArgs) Handles tbTo.GotFocus
        CommanFunctions.autocomplete("name", "Ledger", tbTo, 0)
    End Sub
End Class
