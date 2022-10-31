Imports System.Data.SqlClient



Public Class frmJobIssue

    Private Sub frmJobIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        Dim ds As New DataSet()
        ds = CommanFunctions.connectSQL("Item_name", "item")

        Dim dsrows, dsrows1 As Long
        dsrows = ds.Tables(0).Rows.Count

        DgvItemIssue.ColumnCount = 2
        DgvItemReceive.ColumnCount = 2
        DgvItemIssue.Columns(0).Name = "Quantity"
        DgvItemIssue.Columns(0).HeaderText = "Quantity"
        DgvItemIssue.Columns(1).Name = "Memo"
        DgvItemIssue.Columns(1).HeaderText = "Memo"

        Dim cmb, cmbRcve, cmb1, cmbRcve1 As New DataGridViewComboBoxColumn()
        cmb.HeaderText = "Item Select"
        cmb.Name = "Item"
        cmbRcve.HeaderText = "Item Select"
        cmbRcve.Name = "Item"

        If dsrows > 0 Then
            cmb.MaxDropDownItems = dsrows
            cmbRcve.MaxDropDownItems = dsrows

            For Each dsRow As DataRow In ds.Tables(0).Rows
                cmb.Items.Add(dsRow(0))
                cmbRcve.Items.Add(dsRow(0))
            Next

        Else
            cmb.MaxDropDownItems = 1
            cmbRcve.MaxDropDownItems = 1
            cmb.Items.Add("")
            cmbRcve.Items.Add("")

        End If
        DgvItemIssue.Columns.Add(cmb)
        DgvItemReceive.Columns.Add(cmbRcve)

        Dim ds1 As New DataSet()
        ds1 = CommanFunctions.connectSQL("*", "unit")

        dsrows1 = ds1.Tables(0).Rows.Count

        cmb1.HeaderText = "Unit"
        cmb1.Name = "Unit"
        cmbRcve1.HeaderText = "Unit"
        cmbRcve1.Name = "Unit"

        If dsrows1 > 0 Then
            cmb1.MaxDropDownItems = dsrows1
            cmbRcve1.MaxDropDownItems = dsrows1
            For Each dsRow As DataRow In ds1.Tables(0).Rows
                cmb1.Items.Add(dsRow(0))
                cmbRcve1.Items.Add(dsRow(0))
            Next

        Else
            cmb1.MaxDropDownItems = 1
            cmbRcve1.MaxDropDownItems = 1

            cmb1.Items.Add("")
            cmbRcve1.Items.Add("")
        End If

        DgvItemIssue.Columns.Add(cmb1)
        DgvItemReceive.Columns.Add(cmbRcve1)

        DgvItemIssue.Columns("Item").DisplayIndex = 0
        DgvItemIssue.Columns("Quantity").DisplayIndex = 1
        DgvItemIssue.Columns("Memo").DisplayIndex = 3
        DgvItemIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DgvItemReceive.Columns(0).Name = "Quantity"
        DgvItemReceive.Columns(0).HeaderText = "Quantity"
        DgvItemReceive.Columns(1).Name = "Memo"
        DgvItemReceive.Columns(1).HeaderText = "Memo"

        DgvItemReceive.Columns("Item").DisplayIndex = 0
        DgvItemReceive.Columns("Quantity").DisplayIndex = 1
        DgvItemReceive.Columns("Memo").DisplayIndex = 3
        DgvItemReceive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DgvItemIssue.Columns("item").Width = 250
        DgvItemReceive.Columns("item").Width = 250

        '*** Purchase Id Combobox fill
        fillPurIDComboBox()
        lbPurId.Text = ""
        tbJobWorkerSelect.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    Private Sub fillPurIDComboBox()

        Dim ds As New DataSet()
        ds = CommanFunctions.connectSQL("purid,item", "purchase")

        'Creating new column in dataseT ds as "Name"
        ds.Tables(0).Columns.Add("name", GetType(String))

        'Concatenating "purid" and "Item"  in name

        If ds.Tables(0).Rows.Count > 0 Then
            For Each dt As DataTable In ds.Tables
                For Each dr As DataRow In dt.Rows
                    dr("name") = dr("purid").ToString + " :   " + dr("Item").ToString
                Next
            Next

            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "PurID"
            ComboBox1.DisplayMember = "name"

            ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        End If

    End Sub

    Private Sub displaypurid()
        Dim cbtext As String = ComboBox1.SelectedValue.ToString
        'MsgBox(cbtext)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT PurID,item FROM purchase where purId like '" & cbtext & "'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "purchase")
        connection.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            lbPurId.Text = row(1)
        Next

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        ' displaypuridItem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLedgerCreate.ShowDialog()
        CommanFunctions.autocomplete("name", "Ledger", tbJobWorkerSelect, 0)
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles tbJobWorkerSelect.GotFocus

        CommanFunctions.autocomplete("name", "Ledger", tbJobWorkerSelect, 0)

        'Dim ds As New DataSet()
        'ds = CommanFunctions.connectSQL("Name", "Ledger")
        'tbJobWorkerSelect.AutoCompleteSource = AutoCompleteSource.CustomSource
        'For Each row As DataRow In ds.Tables(0).Rows
        '    tbJobWorkerSelect.AutoCompleteCustomSource.Add(row(0).ToString)
        'Next


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        frmNewItem.ShowDialog()
    End Sub

    Private Sub tbPartySelect_TextChanged(sender As Object, e As EventArgs) Handles tbJobWorkerSelect.TextChanged
        tbJobWorkerSelect.BackColor = Color.White

    End Sub

    Private Sub tbPartySelect_LostFocus(sender As Object, e As EventArgs) Handles tbJobWorkerSelect.LostFocus
        CommanFunctions.restrictTextEntry("Name", "Ledger", tbJobWorkerSelect)
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click

        Dim dgrowcountI, dgrowcountR As Long
        dgrowcountI = DgvItemIssue.Rows.Count
        dgrowcountR = DgvItemReceive.Rows.Count

        If dgrowcountI < 1 And dgrowcountR < 1 Then
            MsgBox("Add items to Issue and Receive")
        Else
            Dim emptyFields As Integer = CommanFunctions.emptyFieldCheck(Me)

            If emptyFields = 0 Then

                Dim myconnect As New SqlClient.SqlConnection
                myconnect.ConnectionString = "Data Source=(LocalDB)\mssqllocaldb;initial catalog = master;Integrated Security=True"
                Dim mycommandItemI As SqlClient.SqlCommand = New SqlClient.SqlCommand()
                mycommandItemI.Connection = myconnect
                mycommandItemI.CommandText = "INSERT INTO JobIssueItemIssue (ChallanId,itemIssued,QtyIssued,UnitIssued,MemoIssued)
                    VALUES (@ChallanId,@itemIssued,@qtyIssued,@UnitIssued,@memoIssued)"

                Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
                mycommand.Connection = myconnect
                mycommand.CommandText = "INSERT INTO jobIssue (ChallanId,chdate,jobWorker,PurId) 
                    VALUES (@ChallanId,@chDate,@jobWorker,@PurId)"

                Dim mycommandItemR As SqlClient.SqlCommand = New SqlClient.SqlCommand()
                mycommandItemR.Connection = myconnect
                mycommandItemR.CommandText = "INSERT INTO JobIssueItemReceive (ChallanId,itemReceive,QtyReceive,UnitReceive,MemoReceive)
                    VALUES (@ChallanId,@itemReceive,@qtyReceive,@UnitReceive,@memoReceive)"


                myconnect.Open()

                Dim dsChlnId As DataSet

                dsChlnId = CommanFunctions.connectSQL("ChallanId", "JobIssue")

                Dim dsChlnRowCnt As Integer
                Dim vChallanId As Integer = 0


                dsChlnRowCnt = dsChlnId.Tables(0).Rows.Count

                If dsChlnRowCnt > 0 Then
                    vChallanId = dsChlnId.Tables(0).Rows(dsChlnRowCnt - 1).Item(0) + 1
                Else
                    vChallanId = 1
                End If

                MsgBox(vChallanId)
                Try
                    mycommand.Parameters.Clear()

                    mycommand.Parameters.Add("@ChallanId", SqlDbType.Int).Value = vChallanId

                    mycommand.Parameters.Add("@chDate", SqlDbType.DateTime).Value = DateTimePicker1.Value.Date

                    mycommand.Parameters.Add("@jobworker", SqlDbType.NChar).Value = tbJobWorkerSelect.Text

                    mycommand.Parameters.Add("@purId", SqlDbType.Int).Value = Convert.ToInt32(lbPurId.Text)

                    mycommand.ExecuteNonQuery()

                    For Each row As DataGridViewRow In DgvItemIssue.Rows

                        mycommandItemI.Parameters.Clear()

                        mycommandItemI.Parameters.Add("@ChallanId", SqlDbType.Int).Value = vChallanId

                        mycommandItemI.Parameters.Add("@ItemIssued", SqlDbType.NChar).Value = row.Cells("item").Value

                        mycommandItemI.Parameters.Add("@qtyIssued", SqlDbType.Decimal).Value = row.Cells("quantity").Value

                        mycommandItemI.Parameters.Add("@UnitIssued", SqlDbType.NChar).Value = row.Cells("Unit").Value

                        mycommandItemI.Parameters.Add("@memoIssued", SqlDbType.NChar).Value = row.Cells("Memo").Value

                        mycommandItemI.ExecuteNonQuery()

                    Next


                    For Each row As DataGridViewRow In DgvItemReceive.Rows

                        mycommandItemR.Parameters.Clear()

                        mycommandItemR.Parameters.Add("@ChallanId", SqlDbType.Int).Value = vChallanId

                        mycommandItemR.Parameters.Add("@ItemReceive", SqlDbType.NChar).Value = row.Cells("item").Value

                        mycommandItemR.Parameters.Add("@qtyReceive", SqlDbType.Decimal).Value = row.Cells("quantity").Value

                        mycommandItemR.Parameters.Add("@UnitReceive", SqlDbType.NChar).Value = row.Cells("Unit").Value

                        mycommandItemR.Parameters.Add("@memoReceive", SqlDbType.NChar).Value = row.Cells("Memo").Value

                        mycommandItemR.ExecuteNonQuery()

                    Next

                    MsgBox("Success")
                    emptyDGV(DgvItemIssue)
                    emptyDGV(DgvItemReceive)
                    tbJobWorkerSelect.Text = ""
                    lbPurId.Text = ""
                    DgvItemIssue.Rows.Clear()
                    DgvItemReceive.Rows.Clear()


                Catch ex As System.Data.SqlClient.SqlException
                    MsgBox(ex.Message)
                End Try

                myconnect.Close()
                ' clearPurNewForm()
            Else
                '    MsgBox("Fill empty Fields: " & emptyFields)
            End If


        End If
    End Sub

    Private Sub emptyDGV(dgv As DataGridView)
        For Each row As DataGridViewRow In dgv.Rows
            dgv.Rows.Remove(row)
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'displaypurid()
        lbPurId.Text = ComboBox1.SelectedValue.ToString

    End Sub

    Private Sub btnAddRowIssue_Click(sender As Object, e As EventArgs) Handles btnAddRowIssue.Click
        DgvItemIssue.Rows.Add()
    End Sub

    Private Sub btnAddRowReceive_Click(sender As Object, e As EventArgs) Handles btnAddRowReceive.Click
        DgvItemReceive.Rows.Add()

    End Sub

    Private Sub DgvItemIssue_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItemIssue.CellContentClick


    End Sub

    Private Sub btnSelectPurId_Click(sender As Object, e As EventArgs) Handles btnSelectPurId.Click
        ShowOptionsForm()

    End Sub

    Private Sub ShowOptionsForm()

        Dim options = New frmSelectPurId
        AddHandler options.savedOptions, AddressOf OnOptionsSave
        options.ShowDialog()

    End Sub

    Private Sub OnOptionsSave(ByVal strData As String)
        'Or whatever you want to do on frmMain with Options Data.

        lbPurId.Text = strData

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = DgvItemIssue.Rows.Count
        If i > 0 Then
            DgvItemIssue.Rows.RemoveAt(i - 1)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer = DgvItemReceive.Rows.Count
        If i > 0 Then
            DgvItemReceive.Rows.RemoveAt(i - 1)
        End If

    End Sub
End Class