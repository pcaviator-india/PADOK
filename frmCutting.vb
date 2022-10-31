Imports System.Data.SqlClient

Public Class frmCutting
    Private Sub frmCutting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '************************************************
        '***** TbPurid textbox Fill

        'Dim ds As New DataSet()
        'ds = CommanFunctions.connectSQL("purid,item", "purchase")

        ''Creating new column in dataser ds as "Name"
        'ds.Tables(0).Columns.Add("name", GetType(String))

        ''Concatenating "purid" and "Item"  in name
        'If ds.Tables(0).Rows.Count > 0 Then
        '    For Each dt As DataTable In ds.Tables
        '        For Each dr As DataRow In dt.Rows
        '            dr("name") = dr("purid").ToString + " :   " + dr("Item").ToString
        '        Next
        '    Next

        '    tbPurId.AutoCompleteSource = AutoCompleteSource.CustomSource

        '    '************* Adding dataset third column values to autocomplete custom source of PurId textbox *****************
        '    For Each row As DataRow In ds.Tables(0).Rows
        '        tbPurId.AutoCompleteCustomSource.Add(row(2).ToString)
        '    Next
        '    tbPurId.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        'End If
        '****************************************************





        '****************************************************
        '***** dgv CUtting fill

        Dim dsDGV As New DataSet()
        dsDGV = CommanFunctions.connectSQL("Item_name", "item")

        Dim dsrows As Long
        dsrows = dsDGV.Tables(0).Rows.Count

        dgvCutting.ColumnCount = 6

        dgvCutting.Columns(0).Name = "Item"
        dgvCutting.Columns(0).HeaderText = "Item"
        dgvCutting.Columns(1).Name = "Quantity"
        dgvCutting.Columns(1).HeaderText = "Quantity"
        dgvCutting.Columns(2).Name = "Unit"
        dgvCutting.Columns(2).HeaderText = "Unit"
        dgvCutting.Columns(3).Name = "Average"
        dgvCutting.Columns(3).HeaderText = "Average"
        dgvCutting.Columns(4).Name = "Memo"
        dgvCutting.Columns(4).HeaderText = "Memo"
        dgvCutting.Columns(5).Name = "Total"
        dgvCutting.Columns(5).HeaderText = "Total"
        dgvCutting.Columns(5).ReadOnly = True


        'dgvCutting.Columns("Item").DisplayIndex = 0
        'dgvCutting.Columns("Quantity").DisplayIndex = 1
        'dgvCutting.Columns("Average").DisplayIndex = 3
        'dgvCutting.Columns("Memo").DisplayIndex = 4
        dgvCutting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCutting.Columns.Item("item").Width = 500

        '***************************************************************************************


        dgvCutting.Rows.Add()   ' Add First row in Datagridview Cutting

        createCuttingID()


    End Sub

    Private Sub createCuttingID()

        '***************************************************************************************
        '   Create Cutting Id
        Dim dsCuttingId As DataSet

        dsCuttingId = CommanFunctions.connectSQL("CuttingId", "Cutting")

        Dim dsCutRowCnt As Integer
        Dim vCuttingId As Integer = 0


        dsCutRowCnt = dsCuttingId.Tables(0).Rows.Count

        If dsCutRowCnt > 0 Then
            vCuttingId = dsCuttingId.Tables(0).Rows(dsCutRowCnt - 1).Item(0) + 1
        Else
            vCuttingId = 1
        End If
        lblCuttingId.Text = vCuttingId
        '   Create Cutting Id End
        '*****************************************************************************************
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCutting.EditingControlShowing

        Select Case dgvCutting.CurrentCell.ColumnIndex
            Case 0
                Dim titleText As String = dgvCutting.Columns(0).HeaderText
                If titleText.Equals("Item") Then
                    Dim autoText As TextBox = TryCast(e.Control, TextBox)
                    If autoText IsNot Nothing Then
                        autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                        autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                        Dim DataCollection As New AutoCompleteStringCollection()
                        addItems(DataCollection, "Item_name", "Item")
                        autoText.AutoCompleteCustomSource = DataCollection
                    End If
                End If
            Case 2
                Dim titleText As String = dgvCutting.Columns(2).HeaderText
                If titleText.Equals("Unit") Then
                    Dim autoText As TextBox = TryCast(e.Control, TextBox)
                    If autoText IsNot Nothing Then
                        autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                        autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                        Dim DataCollection As New AutoCompleteStringCollection()
                        addItems(DataCollection, "Item_Unit", "Unit")
                        autoText.AutoCompleteCustomSource = DataCollection
                    End If
                End If
        End Select

    End Sub

    Public Sub addItems(ByVal col As AutoCompleteStringCollection, colName As String, tbleName As String)
        Dim ds1 As New DataSet
        ds1 = CommanFunctions.connectSQL(colName, tbleName)
        For Each dsRow As DataRow In ds1.Tables(0).Rows
            col.Add(dsRow(0))
        Next
    End Sub

    Private Sub btAddRow_Click(sender As Object, e As EventArgs) Handles btAddRow.Click
        dgvCutting.Rows.Add()

    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        frmNewItem.ShowDialog()

    End Sub


    Private Sub btnDelRow_Click(sender As Object, e As EventArgs) Handles btnDelRow.Click
        deleteLastRow()
    End Sub

    Private Sub deleteLastRow()
        Dim LastRow As Integer
        LastRow = dgvCutting.Rows.Count
        If LastRow > 0 Then
            dgvCutting.Rows.RemoveAt(LastRow - 1)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub dgvCutting_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCutting.CellValueChanged
        Dim qty, avg, ttl, gttl As Decimal
        gttl = 0
        If dgvCutting.Rows.Count > 0 Then
            For i = 0 To dgvCutting.Rows.Count - 1

                qty = dgvCutting.Rows(i).Cells(1).Value
                avg = Convert.ToDecimal(dgvCutting.Rows(i).Cells(3).Value)
                ttl = qty * avg
                dgvCutting.Rows(i).Cells(5).Value = ttl
                gttl = gttl + ttl

            Next

        End If
        lblTotalCut.Text = gttl
    End Sub

    Private Sub btnSelectPurId_Click(sender As Object, e As EventArgs) Handles btnSelectPurId.Click
        'Dim selectedPurID As Integer = frmSelectPurId.ShowDialog()
        ' MsgBox(selectedPurID)
        ShowOptionsForm()

    End Sub

    Private Sub ShowOptionsForm()

        Dim options = New frmSelectPurId

        AddHandler options.SavedOptions, AddressOf OnOptionsSave

        options.ShowDialog()

    End Sub

    Private Sub OnOptionsSave(ByVal strData As String)

        'Or whatever you want to do on frmMain with Options Data.
        'MsgBox(strData)
        lblPurId.Text = strData

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmNewUnit.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '****************************************
        '   Check if all fields are filled up and PurId is selected from List

        Dim purIdSel, checkAllFields As Boolean

        For Each row As DataGridViewRow In dgvCutting.Rows
            For i = 0 To 3
                If String.IsNullOrWhiteSpace(row.Cells(i).Value) Then
                    checkAllFields = False
                    Exit For
                Else
                    checkAllFields = True

                End If
            Next

        Next

        If lblPurId.Text > 0 Then
            purIdSel = True
        Else
            purIdSel = False
        End If
        '************************************************************************



        '************************************************************************
        If checkAllFields = True AndAlso purIdSel = True Then
            Dim myconnect As New SqlClient.SqlConnection
            myconnect.ConnectionString = "Data Source=(LocalDB)\mssqllocaldb;initial catalog = master;Integrated Security=True"
            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            Dim mycommandCI As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect
            mycommandCI.Connection = myconnect

            mycommand.CommandText = "INSERT INTO Cutting (CuttingId,cDate,PurId)
                    VALUES (@CuttingId,@cDate,@PurId)"
            mycommandCI.CommandText = "INSERT INTO CuttingItems (CuttingId,citem,cQty,cUnit,cAvg,cMemo)
                    VALUES (@CuttingId,@citem,@cQty,@cUnit,@cAvg,@cMemo)"


            myconnect.Open()
            Try

                mycommand.Parameters.Clear()

                mycommand.Parameters.Add("@CuttingId", SqlDbType.Int).Value = lblCuttingId.Text

                mycommand.Parameters.Add("@cDate", SqlDbType.DateTime).Value = DateTimePicker1.Value.Date

                mycommand.Parameters.Add("@purId", SqlDbType.Int).Value = lblPurId.Text

                mycommand.ExecuteNonQuery()


                For Each row As DataGridViewRow In dgvCutting.Rows
                    mycommandCI.Parameters.Clear()

                    mycommandCI.Parameters.Add("@CuttingId", SqlDbType.Int).Value = lblCuttingId.Text

                    mycommandCI.Parameters.Add("@cItem", SqlDbType.NChar).Value = row.Cells(0).Value

                    mycommandCI.Parameters.Add("@cQty", SqlDbType.Decimal).Value = row.Cells(1).Value

                    mycommandCI.Parameters.Add("@cUnit", SqlDbType.NChar).Value = row.Cells(2).Value

                    mycommandCI.Parameters.Add("@cAvg", SqlDbType.Decimal).Value = row.Cells(3).Value

                    If Not String.IsNullOrWhiteSpace(row.Cells(4).Value) Then
                        mycommandCI.Parameters.Add("@cMemo", SqlDbType.NChar).Value = row.Cells(4).Value
                    Else
                        mycommandCI.Parameters.Add("@cMemo", SqlDbType.NChar).Value = ""
                    End If



                    mycommandCI.ExecuteNonQuery()
                Next


            Catch ex As SqlException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            MsgBox("Success")

            Dim dgvrowcount As Integer
            dgvrowcount = dgvCutting.Rows.Count - 1


            For i = dgvrowcount To 0
                dgvCutting.Rows.RemoveAt(i)
            Next

            createCuttingID()

            lblPurId.Text = 0

            dgvCutting.Rows.Add()

        ElseIf checkAllFields = False AndAlso purIdSel = False Then
            MsgBox("fill all fields and Select Purchase Id from List")
        ElseIf purIdSel = False Then
            MsgBox("Select Purchase Id from List")
        ElseIf checkAllFields = False Then
            MsgBox("fill all fields")
        End If



    End Sub

    Private Sub frmCutting_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case (e.Modifiers)
            Case Keys.Control           'when ctrl is pressed
                Select Case e.KeyCode
                    Case Keys.X             'when x is pressed along with ctrl
                        Me.Close()          'close form
                    Case Keys.S             'when s is pressed along with ctrl
                        'save purchase
                    Case Keys.Add
                        dgvCutting.Rows.Add()
                    Case Keys.Subtract
                        deleteLastRow()
                    Case Keys.I
                        frmNewItem.ShowDialog()
                    Case Keys.U
                        frmNewUnit.ShowDialog()

                End Select

        End Select
    End Sub
End Class