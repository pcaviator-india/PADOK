Imports System.Data.SqlClient

Public Class frmNewJobWorker
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmNewJobWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbnewJobWorker.TextChanged
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM jobworkparty WHERE partyName Like '" & tbnewJobWorker.Text & "%'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "jobworkparty")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "jobworkparty"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim namealreadyexists As Boolean = False
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM jobworkparty"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "jobworkparty")
        connection.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            If row(0).ToString = tbnewJobWorker.Text Then
                namealreadyexists = True
                Exit For
            Else
                namealreadyexists = False
            End If

        Next

        If Not String.IsNullOrWhiteSpace(tbnewJobWorker.Text) And namealreadyexists = False Then

            'Dim newitem As Char
            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect
            mycommand.CommandText = "INSERT INTO jobworkparty (partyname) 
                    VALUES (@newparty)"
            myconnect.Open()

            Try
                mycommand.Parameters.Add("@Newparty", SqlDbType.Char).Value = tbnewJobWorker.Text
                mycommand.ExecuteNonQuery()
                MsgBox("SUCCESS")
                tbnewJobWorker.Text = ""
                tbnewJobWorker.Focus()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try

            myconnect.Close()

        Else
            MsgBox("Item Already Exists or Empty")
        End If
    End Sub
End Class