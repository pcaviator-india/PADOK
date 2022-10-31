Public Class frmLedgerCreate
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    Private Sub btnNewGroup_Click(sender As Object, e As EventArgs) Handles btnNewGroup.Click
        frmGroupCreate.ShowDialog()
        CommanFunctions.autocomplete("*", "LedgerGroup", tbgroup, 1)

    End Sub

    Private Sub btnNewCategory_Click(sender As Object, e As EventArgs) Handles btnNewCategory.Click
        frmCategoryCreate.ShowDialog()
        CommanFunctions.autocomplete("*", "LedgerCategory", tbCategory, 1)

    End Sub

    Private Sub tbgroup_GotFocus(sender As Object, e As EventArgs) Handles tbgroup.GotFocus

        CommanFunctions.autocomplete("*", "LedgerGroup", tbgroup, 1)

    End Sub

    Private Sub frmLedgerCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        tbgroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub tbCategory_GotFocus(sender As Object, e As EventArgs) Handles tbCategory.GotFocus

        CommanFunctions.autocomplete("*", "LedgerCategory", tbCategory, 1)

    End Sub
    Private Sub createLedgerId()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "Ledger")
        Dim LedgerId As Integer
        If ds.Tables(0).Rows.Count < 1 Then
            LedgerId = 1
        Else
            Dim lastrow As Integer = ds.Tables(0).Rows.Count - 1
            LedgerId = ds.Tables(0).Rows(lastrow).Item(0) + 1


        End If
        lblLedgerId.Text = LedgerId
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim namealreadyexists As Boolean = False

        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "Ledger")

        For Each row As DataRow In ds.Tables(0).Rows
            If row(1).ToString = tbLedger.Text Then
                namealreadyexists = True
                Exit For
            Else
                namealreadyexists = False
            End If
        Next

        createLedgerId()


        'saving the item while entry is not null or white space and item does not already exist
        If Not String.IsNullOrWhiteSpace(tbLedger.Text) And namealreadyexists = False Then

            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect

            mycommand.CommandText = "INSERT INTO Ledger(LedgerId,Name,GroupId,CategoryId) 
                    VALUES (@LedgerId,@Name,@GroupId,@CategoryId)"
            myconnect.Open()
            Try
                mycommand.Parameters.Clear()

                mycommand.Parameters.Add("@LedgerId", SqlDbType.Int).Value = Convert.ToInt32(lblLedgerId.Text)
                mycommand.Parameters.Add("@Name", SqlDbType.Char).Value = tbLedger.Text.ToUpper
                mycommand.Parameters.Add("@GroupId", SqlDbType.Int).Value = Convert.ToInt32(lblgroupId.Text)
                mycommand.Parameters.Add("@CategoryId", SqlDbType.Int).Value = Convert.ToInt32(lblCategoryId.Text)

                mycommand.ExecuteNonQuery()
                MsgBox("SUCCESS")

                '************************** CLEAR TEXT BOXES IN FORM   ************************
                tbLedger.Text = ""
                tbgroup.Text = ""
                tbCategory.Text = ""
                lblCategoryId.Text = ""
                lblgroupId.Text = ""
                tbLedger.Focus()                '**************FOCUS BACK TO FIRST TEXTBOX
                '**********************************************************************************
                createLedgerId()     '   Create new Ledger Id



            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try
            myconnect.Close()
        Else
            MsgBox("Ledger Already Exists or Empty")
        End If
    End Sub

    Private Sub tbgroup_LostFocus(sender As Object, e As EventArgs) Handles tbgroup.LostFocus
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "LedgerGroup")
        For Each row As DataRow In ds.Tables(0).Rows
            If tbgroup.Text = row(1) Then
                lblgroupId.Text = row(0)
            End If
        Next
    End Sub

    Private Sub tbCategory_LostFocus(sender As Object, e As EventArgs) Handles tbCategory.LostFocus
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "LedgerCategory")

        For Each row As DataRow In ds.Tables(0).Rows
            If tbCategory.Text = row(1) Then
                lblCategoryId.Text = row(0)
            End If
        Next
    End Sub
End Class