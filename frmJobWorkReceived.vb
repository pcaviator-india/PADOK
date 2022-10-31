Imports System.Data.SqlClient

Public Class frmJobWorkReceived
    Private Sub frmJobWorkReceived_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        dgvJobIssue.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvJobIssue.MultiSelect = False
        dgvJobIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Dim ds As New DataSet()
        ds = CommanFunctions.connectSQL("*", "jobissue")
        dgvJobIssue.DataSource = ds
        dgvJobIssue.DataMember = "jobissue"
    End Sub

    Private Sub dgvJobIssue_Click(sender As Object, e As EventArgs) Handles dgvJobIssue.Click
        Dim curselChId As Integer
        curselChId = dgvJobIssue.SelectedRows(0).Cells(0).Value.ToString

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * from jobIssueItemReceive where ChallanId like " + "'" + curselChId.ToString + "'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim dss As New DataSet()
        connection.Open()
        dataadapter.Fill(dss, "jobissueItemreceive")
        connection.Close()

        dgvItemissued.DataSource = dss
        dgvItemissued.DataMember = "jobissueItemReceive"



        Dim sqlR As String = "SELECT * from jobIssueReceived where ChallanId like " + "'" + curselChId.ToString + "'"
        Dim connectionR As New SqlConnection(connectionString)
        Dim dataadapterR As New SqlDataAdapter(sqlR, connectionR)
        Dim dssR As New DataSet()
        connectionR.Open()
        dataadapterR.Fill(dssR, "jobissueReceived")
        connectionR.Close()

        dgvItemReceived.DataSource = dssR
        dgvItemReceived.DataMember = "jobissueReceived"
    End Sub

    Private Sub dgvItemReceived_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemReceived.CellContentClick

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class