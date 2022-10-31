Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class frmPurchaseNew
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
    Private Sub savePurchase()
        Dim datagridrowcount As Long

        datagridrowcount = DataGridView1.Rows.Count

        If datagridrowcount < 1 Then
            MsgBox("Add items to save Purchase")
        Else

            Dim emptyFields As Integer = emptyFieldCheck()

            If emptyFields = 0 Then

                Dim myconnect As New SqlClient.SqlConnection
                myconnect.ConnectionString = "Data Source=(LocalDB)\mssqllocaldb;initial catalog = master;Integrated Security=True"
                Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
                mycommand.Connection = myconnect
                mycommand.CommandText = "INSERT INTO purchase (date,challan_no,Bill_no,supplier,item,quantity,unit,rate,width_size,l_mentioned,L_actual) 
                    VALUES (@purDate,@purchallan,@purBill,@pursupplier,@purItem,@purQuantity,@purUnit,@purRate,@purWidth,@purLmentioned,@purLactual)"
                myconnect.Open()

                Try
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        mycommand.Parameters.Clear()

                        mycommand.Parameters.Add("@purDate", SqlDbType.DateTime).Value = DateTimePicker1.Value.Date

                        mycommand.Parameters.Add("@purChallan", SqlDbType.NChar).Value = TbPurChallan.Text

                        mycommand.Parameters.Add("@purBill", SqlDbType.NChar).Value = TbPurBill.Text

                        mycommand.Parameters.Add("@purSupplier", SqlDbType.NChar).Value = TbPurSupplier.Text

                        mycommand.Parameters.Add("@purItem", SqlDbType.NChar).Value = row.Cells(0).Value

                        mycommand.Parameters.Add("@purquantity", SqlDbType.NChar).Value = row.Cells(1).Value

                        mycommand.Parameters.Add("@purUnit", SqlDbType.NChar).Value = row.Cells(2).Value

                        mycommand.Parameters.Add("@purRate", SqlDbType.NChar).Value = row.Cells(3).Value

                        mycommand.Parameters.Add("@purWidth", SqlDbType.NChar).Value = row.Cells(4).Value

                        mycommand.Parameters.Add("@purLmentioned", SqlDbType.Decimal).Value = row.Cells(5).Value

                        mycommand.Parameters.Add("@purlactual", SqlDbType.Decimal).Value = row.Cells(6).Value

                        mycommand.ExecuteNonQuery()
                    Next
                    MsgBox("Success")
                    clearPurNewForm()
                    TbPurSupplier.Focus()

                Catch ex As System.Data.SqlClient.SqlException
                    MsgBox(ex.Message)
                End Try

                myconnect.Close()


            Else
                '    MsgBox("Fill empty Fields: " & emptyFields)
            End If


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        savePurchase()
    End Sub

    Private Sub clearPurNewForm()
        DateTimePicker1.ResetText()
        TbPurChallan.Text = ""
        TbPurBill.Text = ""
        TbPurItem.Text = ""
        TbPurLa.Text = ""
        TbPurLm.Text = ""
        TbPurQuantity.Text = ""
        TbPurRate.Text = ""
        TbPurSupplier.Text = ""
        TbPurUnit.Text = ""
        TbPurWidth.Text = ""

        For Each row As DataGridViewRow In DataGridView1.Rows
            DataGridView1.Rows.Remove(row)
        Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        clearPurNewForm()

    End Sub

    'Private Sub TextBoxes_Validating(ByVal sender As Object,
    '                             ByVal e As System.ComponentModel.CancelEventArgs) Handles TbPurChallan.Validating,
    '                                                                                        TbPurBill.Validating, TbPurItem.Validating, TbPurLa.Validating, TbPurLm.Validating, TbPurQuantity.Validating, TbPurRate.Validating, TbPurShrink.Validating, TbPurSupplier.Validating, TbPurUnit.Validating, TbPurWidth.Validating
    '    Dim field = DirectCast(sender, TextBox)

    '    If String.IsNullOrWhiteSpace(field.Text) Then
    '        field.HideSelection = False
    '        field.SelectAll()
    '        'MessageBox.Show("You must enter a value.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '        field.HideSelection = True

    '        e.Cancel = True
    '    End If
    'End Sub

    Private Function emptyFieldCheck()
        Dim countEmptyBox As Integer = 0

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(ctrl.text) Then
                    countEmptyBox = countEmptyBox + 1

                End If
            End If
        Next
        If countEmptyBox > 0 Then
            MsgBox("Please fill empty Fields: " & countEmptyBox)
        End If

        Return countEmptyBox

    End Function

    'Function To Check Number Validity
    Public Function ValidateDecimal(ByVal strqty As String) As Boolean

        Dim qtyValid As Boolean
        ''Create Reg Exp Pattern
        Dim strquantitypattern As String = "\d{1,6}\.?\d{0,2}"

        'Create Reg Ex Object
        Dim reqty As New Regex(strquantitypattern)

        'Something Typed In
        If Not String.IsNullOrEmpty(strqty) Then
            qtyValid = reqty.IsMatch(strqty) 'Check Validity
        Else
            qtyValid = False 'Not Valid / Empty
        End If
        Return qtyValid 'Return True / False

    End Function


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'If Me.ValidateChildren() Then
        '    MsgBox("nice job")
        '    'All fields passed validation so proceed.
        'Else
        '    MessageBox.Show("You must enter a value.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        CommanFunctions.emptyFieldCheck(Me)


    End Sub

    Private Sub TbPurQuantity_TextChanged(sender As Object, e As EventArgs) Handles TbPurQuantity.TextChanged
        TbPurQuantity.BackColor = Color.White

    End Sub

    Private Sub TbPurQuantity_LostFocus(sender As Object, e As EventArgs) Handles TbPurQuantity.LostFocus
        If Not ValidateDecimal(TbPurQuantity.Text) Then 'Call Phone Validation Function
            ' MessageBox.Show("Please Enter  Number In Correct Format!")
            'TbPurQuantity.Clear() 'Clear Input
            'TbPurQuantity.Focus() 'Return Focus
            TbPurQuantity.BackColor = Color.Red


        End If
    End Sub

    Private Sub TbPurRate_LostFocus(sender As Object, e As EventArgs) Handles TbPurRate.LostFocus
        If Not ValidateDecimal(TbPurRate.Text) Then 'Call Phone Validation Function
            'MessageBox.Show("Please Enter  Number In Correct Format!")
            'TbPurRate.Clear() 'Clear Input
            'TbPurRate.Focus() 'Return Focus
            TbPurRate.BackColor = Color.Red

        End If
    End Sub

    Private Sub btnAddItemtoPurchase_Click(sender As Object, e As EventArgs) Handles btnAddItemtoPurchase.Click

        DataGridView1.ColumnCount = 7

        DataGridView1.Columns(0).Name = "Item"
        DataGridView1.Columns(1).Name = "Quantity"
        DataGridView1.Columns(2).Name = "Unit"
        DataGridView1.Columns(3).Name = "Rate"
        DataGridView1.Columns(4).Name = "Width"
        DataGridView1.Columns(4).Name = "L Mentioned"
        DataGridView1.Columns(4).Name = "L Actual"

        Dim addItem As Boolean = False


        For Each txtbx In pnlAddIteminPurchase.Controls.OfType(Of TextBox)
            If Not String.IsNullOrWhiteSpace(txtbx.Text) Then
                addItem = True
            Else
                addItem = False

            End If
        Next
        If addItem = True Then
            Dim row As String() = New String() {TbPurItem.Text, TbPurQuantity.Text, TbPurUnit.Text, TbPurRate.Text, TbPurWidth.Text, TbPurLm.Text, TbPurLa.Text}
            DataGridView1.Rows.Add(row)

            For Each txtbx In pnlAddIteminPurchase.Controls.OfType(Of TextBox)
                txtbx.Text = ""
            Next

            TbPurItem.Focus()
        Else
            MsgBox("please fill all details of item to add in list")

        End If

    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        frmNewItem.ShowDialog()
        CommanFunctions.autocomplete("item_name", "item", TbPurItem, 0)
    End Sub

    Private Sub Purchase_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        CommanFunctions.allTextboxUpperCase(pnlAddIteminPurchase)
        '*** setting auto complete mode to suggest, to get suggestion while typing from supplier database
        TbPurSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TbPurItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TbPurUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '**** Set focus on supplier textbox on form load
        TbPurSupplier.Select()

        TbPurWidth.Enabled = False
        TbPurLa.Enabled = False
        TbPurLm.Enabled = False

        'TbPurWidth.Text = 0
        'TbPurLa.Text = 0
        'TbPurLm.Text = 0
    End Sub

    Private Sub btnNewUnit_Click(sender As Object, e As EventArgs) Handles btnNewUnit.Click
        frmNewUnit.ShowDialog()
        CommanFunctions.autocomplete("*", "Unit", TbPurUnit, 0)
    End Sub


    Private Sub TbPurUnit_GotFocus(sender As Object, e As EventArgs) Handles TbPurUnit.GotFocus
        TbPurUnit.AutoCompleteSource = AutoCompleteSource.CustomSource
        CommanFunctions.autocomplete("*", "unit", TbPurUnit, 0)

    End Sub

    Private Sub TbPurItem_TextChanged(sender As Object, e As EventArgs) Handles TbPurItem.TextChanged
        TbPurItem.BackColor = Color.White

    End Sub

    Private Sub TbPurItem_GotFocus(sender As Object, e As EventArgs) Handles TbPurItem.GotFocus
        TbPurItem.AutoCompleteSource = AutoCompleteSource.CustomSource
        CommanFunctions.autocomplete("item_name", "item", TbPurItem, 0)
    End Sub

    Private Sub TbPurSupplier_TextChanged(sender As Object, e As EventArgs) Handles TbPurSupplier.TextChanged
        TbPurSupplier.BackColor = Color.White
    End Sub

    Private Sub TbPurSupplier_GotFocus(sender As Object, e As EventArgs) Handles TbPurSupplier.GotFocus
        TbPurSupplier.AutoCompleteSource = AutoCompleteSource.CustomSource
        CommanFunctions.autocomplete("Name", "Ledger", TbPurSupplier, 0)
    End Sub

    Private Sub btnNewSupplier_Click(sender As Object, e As EventArgs) Handles btnNewSupplier.Click
        frmLedgerCreate.ShowDialog()
        CommanFunctions.autocomplete("Name", "Ledger", TbPurSupplier, 0)

    End Sub

    Private Sub frmPurchaseNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case (e.Modifiers)
            Case Keys.Control           'when ctrl is pressed
                Select Case e.KeyCode
                    Case Keys.X             'when x is pressed along with ctrl
                        Me.Close()          'close form
                    Case Keys.S             'when s is pressed along with ctrl
                        savePurchase()      'save purchase
                End Select

        End Select
    End Sub

    Private Sub TbPurSupplier_Validated(sender As Object, e As EventArgs) Handles TbPurSupplier.Validated
        CommanFunctions.restrictTextEntry("NAME", "LEDGER", TbPurSupplier)
    End Sub

    Private Sub TbPurItem_Validated(sender As Object, e As EventArgs) Handles TbPurItem.Validated
        CommanFunctions.restrictTextEntry("item_name", "Item", TbPurItem)
    End Sub

    Private Sub TbPurUnit_Validated(sender As Object, e As EventArgs) Handles TbPurUnit.Validated
        CommanFunctions.restrictTextEntry("item_unit", "unit", TbPurUnit)
    End Sub

    Private Sub TbPurUnit_TextChanged(sender As Object, e As EventArgs) Handles TbPurUnit.TextChanged
        TbPurUnit.BackColor = Color.White
    End Sub

    Private Sub TbPurRate_TextChanged(sender As Object, e As EventArgs) Handles TbPurRate.TextChanged
        TbPurRate.BackColor = Color.White

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxWidth.CheckedChanged
        CommanFunctions.enableTextBox(chkbxWidth, TbPurWidth)
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxLm.CheckedChanged
        CommanFunctions.enableTextBox(chkbxLm, TbPurLm)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkbxLa.CheckedChanged
        CommanFunctions.enableTextBox(ChkbxLa, TbPurLa)
    End Sub

End Class