Imports System.Data.SqlClient

Public Class frmGroupCreate
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    Private Sub createGroupId()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "LedgerGroup")
        Dim GroupId As Integer
        If ds.Tables(0).Rows.Count < 1 Then
            GroupId = 1
        Else
            Dim lastrow As Integer = ds.Tables(0).Rows.Count - 1
            GroupId = ds.Tables(0).Rows(lastrow).Item(0) + 1
        End If
        lblGroupId.Text = GroupId
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim namealreadyexists As Boolean = False
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM LedgerGroup"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "LedgerGroup")
        connection.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            If row(1).ToString = TextBox1.Text Then
                namealreadyexists = True
                Exit For
            Else
                namealreadyexists = False
            End If
        Next

        createGroupId()


        'saving the item while entry is not null or white space and item does not already exist
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) And namealreadyexists = False Then

            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect

            mycommand.CommandText = "INSERT INTO Ledgergroup (GroupId,Name) 
                    VALUES (@GroupId,@name)"
            myconnect.Open()
            Try
                mycommand.Parameters.Clear()

                mycommand.Parameters.Add("@GroupId", SqlDbType.Int).Value = Convert.ToInt32(lblGroupId.Text)
                mycommand.Parameters.Add("@Name", SqlDbType.Text).Value = TextBox1.Text.ToUpper

                mycommand.ExecuteNonQuery()
                MsgBox("SUCCESS")

                '************************** CLEAR TEXT BOXES IN FORM   ************************
                TextBox1.Text = ""
                TextBox1.Focus()                '**************FOCUS BACK TO FIRST TEXTBOX 'CLOTH'
                '**********************************************************************************
                createGroupId()     '   Create new group Id



            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try
            myconnect.Close()
        Else
            MsgBox("Item Already Exists or Empty")
        End If
    End Sub

    Private Sub frmGroupCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        createGroupId()
        TextBox1.Focus()


    End Sub
End Class