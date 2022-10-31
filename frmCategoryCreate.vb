Imports System.Data.SqlClient

Public Class frmCategoryCreate
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim namealreadyexists As Boolean = False

        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "LedgerCategory")

        For Each row As DataRow In ds.Tables(0).Rows
            If row(1).ToString = TextBox1.Text Then
                namealreadyexists = True
                Exit For
            Else
                namealreadyexists = False
            End If
        Next

        createCategoryId()


        'saving the item while entry is not null or white space and item does not already exist
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) And namealreadyexists = False Then

            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect

            mycommand.CommandText = "INSERT INTO LedgerCategory (CategoryId,Name) 
                    VALUES (@CategoryId,@Name)"
            myconnect.Open()
            Try
                mycommand.Parameters.Clear()

                mycommand.Parameters.Add("@CategoryId", SqlDbType.Int).Value = Convert.ToInt32(lblCategoryId.Text)
                mycommand.Parameters.Add("@Name", SqlDbType.Text).Value = TextBox1.Text.ToUpper

                mycommand.ExecuteNonQuery()
                MsgBox("SUCCESS")

                '************************** CLEAR TEXT BOXES IN FORM   ************************
                TextBox1.Text = ""
                TextBox1.Focus()                '**************FOCUS BACK TO FIRST TEXTBOX
                '**********************************************************************************
                createCategoryId()     '   Create new Category Id



            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try
            myconnect.Close()
        Else
            MsgBox("Category Already Exists or Empty")
        End If
    End Sub
    Private Sub createCategoryId()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "LedgerCategory")
        Dim CategoryId As Integer
        If ds.Tables(0).Rows.Count < 1 Then
            CategoryId = 1
        Else
            Dim lastrow As Integer = ds.Tables(0).Rows.Count - 1
            CategoryId = ds.Tables(0).Rows(lastrow).Item(0) + 1


        End If
        lblCategoryId.Text = CategoryId
    End Sub

    Private Sub frmCategoryCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)

        createCategoryId()

    End Sub
End Class