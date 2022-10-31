Imports System.Data.SqlClient

Public Class frmLink
    Private Sub frmLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT p.purid,p.item, p.quantity
                            ,c.cuttingid
                            ,ci.cItem, ci.cqty
                            ,j.challanid
                            ,ji.itemissued
                            FROM purchase p
                            LEFT OUTER JOIN cutting c
                            ON p.purid=c.purid        
                            LEFT OUTER JOIN cuttingitems ci
                            ON c.cuttingid=ci.cuttingid
                            LEFT OUTER JOIN jobissue j
                            ON p.purid = j.purid
                            LEFT OUTER JOIN jobissueitemIssue ji
                            ON j.challanId=ji.challanId
                            "
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds, ds1 As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "purchase")
        connection.Close()

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "purchase"

        filldgv2()

    End Sub


    Private Sub filldgv2()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT jir.item
                            ,j.purid
                            from jobissuereceived jir
                            left outer join jobissue j
                            ON jir.challanid=j.challanid
                            "
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds, ds1 As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "jobissuereceived")
        connection.Close()

        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "jobissuereceived"
    End Sub
End Class