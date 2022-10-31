Imports System.Data.SqlClient

Public Class frmNewSupplier
    Private Sub tbNewSupplier_TextChanged(sender As Object, e As EventArgs) Handles tbNewSupplier.TextChanged
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM supplier WHERE supplier Like '" & tbNewSupplier.Text & "%'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "supplier")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "supplier"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim namealreadyexists As Boolean = False
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM supplier "
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "supplier")
        connection.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            If row(0).ToString = tbNewSupplier.Text Then
                namealreadyexists = True
                Exit For
            Else
                namealreadyexists = False
            End If

        Next

        If Not String.IsNullOrWhiteSpace(tbNewSupplier.Text) And namealreadyexists = False Then

            'Dim newitem As Char
            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect
            mycommand.CommandText = "INSERT INTO supplier (supplier) 
                    VALUES (@newsupplier)"

            myconnect.Open()

            Try
                mycommand.Parameters.Add("@Newsupplier", SqlDbType.Char).Value = tbNewSupplier.Text
                mycommand.ExecuteNonQuery()
                MsgBox("SUCCESS")
                tbNewSupplier.Text = ""
                tbNewSupplier.Focus()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try

            myconnect.Close()

        Else
            MsgBox("Item Already Exists or Empty")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmNewSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
    End Sub
End Class