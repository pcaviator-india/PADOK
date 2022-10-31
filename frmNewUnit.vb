Imports System.Data.SqlClient

Public Class frmNewUnit
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles tbNewUnit.TextChanged
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM Unit WHERE Item_Unit Like '" & tbNewUnit.Text & "%'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Unit")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Unit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim namealreadyexists As Boolean = False
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM Unit"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Unit")
        connection.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            If row(0).ToString = tbNewUnit.Text Then
                namealreadyexists = True
                Exit For
            Else
                namealreadyexists = False
            End If

        Next

        If Not String.IsNullOrWhiteSpace(tbNewUnit.Text) And namealreadyexists = False Then

            'Dim newitem As Char
            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect
            mycommand.CommandText = "INSERT INTO Unit (Item_Unit) 
                    VALUES (@newUnit)"

            myconnect.Open()

            Try
                mycommand.Parameters.Add("@NewUnit", SqlDbType.Char).Value = tbNewUnit.Text
                mycommand.ExecuteNonQuery()
                MsgBox("SUCCESS")
                tbNewUnit.Text = ""
                tbNewUnit.Focus()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try

            myconnect.Close()

        Else
            MsgBox("Item Already Exists or Empty")
        End If
    End Sub

    Private Sub frmNewUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
    End Sub
End Class