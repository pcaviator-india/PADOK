Imports System.Data.SqlClient

Public Class frmViewJobWork
    Private Sub frmViewJobWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        dgvJobWorkList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvJobWorkList.MultiSelect = False
        dgvJobWorkList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        dgvSelectedJobWorkIssue.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSelectedJobWorkIssue.MultiSelect = False
        dgvSelectedJobWorkIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        dgvSelectedJobWorkReceive.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSelectedJobWorkReceive.MultiSelect = False
        dgvSelectedJobWorkReceive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Dim ds As New DataSet()
        ds = CommanFunctions.connectSQL("*", "jobissue")
        dgvJobWorkList.DataSource = ds
        dgvJobWorkList.DataMember = "jobissue"



    End Sub


    Private Sub dgvJobWorkList_Click(sender As Object, e As EventArgs) Handles dgvJobWorkList.Click
        Dim curselChId As Integer
        curselChId = dgvJobWorkList.SelectedRows(0).Cells(0).Value.ToString

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

        Dim sql As String = "SELECT * from jobIssueItemIssue where ChallanId like " + "'" + curselChId.ToString + "'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim dss As New DataSet()
        connection.Open()
        dataadapter.Fill(dss, "jobissueItemIssue")
        connection.Close()

        dgvSelectedJobWorkIssue.DataSource = dss
        dgvSelectedJobWorkIssue.DataMember = "jobissueItemIssue"

        'Dim sql1 = "SELECT sum(quantity) as ttlqty from jobIssueRawReceived where ChallanId like " + "'" + curselChId.ToString + "'"
        'Dim connection1 As New SqlConnection(connectionString)
        'Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
        'Dim dss1 As New DataSet()
        'connection.Open()
        'dataadapter.Fill(dss1, "jobissueItemRawreceived")






        Dim sqlR As String = "SELECT * from jobIssueItemReceive where jobissueitemreceive.ChallanId like " + "'" + curselChId.ToString + "'"
        Dim connectionR As New SqlConnection(connectionString)
        Dim dataadapterR As New SqlDataAdapter(sqlR, connectionR)
        Dim dssR As New DataSet()
        connectionR.Open()
        dataadapterR.Fill(dssR, "jobissueItemReceive")
        connectionR.Close()

        dgvSelectedJobWorkReceive.DataSource = dssR
        dgvSelectedJobWorkReceive.DataMember = "jobissueItemReceive"




        '************************************************************************************************
        ' Add two tables in one to show data from both


        Dim sqla As String = "SELECT Id,sum(jobissueRawReceived.quantity) from jobissueRawReceived where challanId like " + "'" + curselChId.ToString + "' group by Id"
        Dim connectiona As New SqlConnection(connectionString)
        Dim dataadaptera As New SqlDataAdapter(sqla, connectiona)
        Dim dssa As New DataSet()
        connectiona.Open()
        dataadaptera.Fill(dssa, "jobissueRawReceived")
        connectiona.Close()

        DataGridView1.DataSource = dssa
        DataGridView1.DataMember = "jobissueRawReceived"


        Dim sqlF As String = "SELECT Id,sum(jobissueReceived.quantity) from jobissueReceived where challanId like " + "'" + curselChId.ToString + "' group by Id"
        Dim dataadapterF As New SqlDataAdapter(sqlF, connection)
        Dim dssF As New DataSet()
        connection.Open()
        dataadapterF.Fill(dssF, "jobissueReceived")
        connection.Close()

        DataGridView2.DataSource = dssF
        DataGridView2.DataMember = "jobissueReceived"

        '***********************************************************************************************

    End Sub


    Private Sub dgvJobWorkList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvJobWorkList.SelectionChanged

    End Sub

    Private Sub dgvJobWorkList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobWorkList.CellContentClick

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class