Imports System.Data.SqlClient

Public Class frmCurrentStock
    Private Sub frmCurrentStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        fillDGV()

    End Sub


    Private Sub fillDGV()
        Try
            Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            'Dim sql As String = "SELECT p.purid, max(p.quantity) as PurchaseQty, max(p.shrinkage) as PShrink
            '                            ,sum(ci.cqty * ci.cavg) as TTLCutting
            '                           ,sum(ji.qtyissued) as IssuedJob
            '                FROM (purchase p
            '                LEFT OUTER JOIN cutting c
            '                ON p.purid=c.purid
            '                LEFT JOIN Cuttingitems ci
            '                ON C.CuttingId = CI.CuttingId
            '                Left Join jobissue j
            '                On p.purid=j.purid
            '                Left Join jobissueitemissue ji
            '                On j.challanid=ji.challanid
            '                )
            '                group by p.purid"
            Dim sql As String = "SELECT purid,item,quantity,shrinkage from purchase"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "purchase")
            connection.Close()

            DataGridView1.DataSource = ds
            DataGridView1.DataMember = ("purchase")

            addNonboundCol()

        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub addNonboundCol()
        If DataGridView1.ColumnCount <> 8 Then

            Dim textcolumn As New DataGridViewTextBoxColumn
            With textcolumn
                .HeaderText = "Cutting"
                .Name = "Cutting"
            End With
            DataGridView1.Columns.Insert(4, textcolumn)

            Dim textcolumn1 As New DataGridViewTextBoxColumn
            With textcolumn1
                .HeaderText = "ProcessPack"
                .Name = "ProcessPack"
            End With
            DataGridView1.Columns.Insert(5, textcolumn1)

            Dim textcolumn2 As New DataGridViewTextBoxColumn
            With textcolumn2
                .HeaderText = "DirectPack"
                .Name = "DirectPack"
            End With
            DataGridView1.Columns.Insert(6, textcolumn2)

            Dim textcolumn3 As New DataGridViewTextBoxColumn
            With textcolumn3
                .HeaderText = "Balance"
                .Name = "Balance"
            End With
            DataGridView1.Columns.Insert(7, textcolumn3)


        End If
    End Sub

    Private Sub fillNonboundCol()
        fillcutting()
        fillProcessPack()
        fillDirectPack()
    End Sub

    Private Sub DataGridView1_GotFocus(sender As Object, e As EventArgs) Handles DataGridView1.GotFocus
        fillNonboundCol()
    End Sub

    Private Sub fillcutting()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT c.purid, sum(ci.cqty*ci.cavg) as TTlCut
                              FROM cutting c
                              LEFT OUTER JOIN cuttingitems ci
                              ON c.cuttingid=ci.cuttingId                             
                                group by c.purid"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "cutting")
        connection.Close()

        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each dsRow As DataRow In ds.Tables(0).Rows
                If row.Cells("purid").Value = dsRow.Item("purID") Then
                    row.Cells("Cutting").Value = dsRow.Item("TtlCut")
                    'row.Cells("Cutting").Value = "123"
                    'MsgBox(row.Cells("purid").Value & " :: " & dsRow.Item("purId") & " ::" & dsRow.Item("TtlCut"))
                End If

            Next
        Next
    End Sub

    Private Sub fillIssue()

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT ji.purid, sum(ci.cqty*ci.cavg) as TTlCut
                              FROM cutting c
                              LEFT OUTER JOIN cuttingitems ci
                              ON c.cuttingid=ci.cuttingId
                              group by c.purid"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "cutting")
        connection.Close()
        DataGridView1.DataSource = ds

        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each dsRow As DataRow In ds.Tables(0).Rows
                If row.Cells("purid").Value = dsRow.Item("purID") Then
                    row.Cells("Cutting").Value = dsRow.Item("TtlCut")
                End If
            Next
        Next

    End Sub

    Private Sub fillProcessPack()

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim sql As String = "SELECT s.purid, sum(s.quantity * ci.cavg) as ttlpkd
                            FROM cuttingItems ci
                            left outer join cutting c
                            ON ci.cuttingid = c.cuttingid
                            left outer join purchase p
                            ON p.purid = c.purid
                            LEFT outer join shipmentdetail s
                            ON s.purid = p.purid
                            group by s.purid
                            "

            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds, ds1 As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "cuttingitems")
            connection.Close()


            For Each row As DataGridViewRow In DataGridView1.Rows
            For Each dsrow As DataRow In ds.Tables(0).Rows
                If Not IsDBNull(dsrow.Item("purid")) Then


                    If row.Cells("purid").Value = dsrow.Item("purid") Then
                        row.Cells("ProcessPack").Value = dsrow.Item("Ttlpkd")
                    End If
                End If
            Next
        Next

        Try
        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub fillDirectPack()

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

        Dim sql As String = "SELECT s.purid, sum(s.quantity) as ttlpkd
                            FROM purchase p
                            LEFT outer join shipmentdetail s
                            ON s.purid = p.purid
                            where s.item LIKE p.item
                            group by s.purid
                            "

        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds, ds1 As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "purchase")
        connection.Close()



        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each dsrow As DataRow In ds.Tables(0).Rows
                If row.Cells("purid").Value = dsrow.Item("purID") Then
                    row.Cells("DirectPack").Value = dsrow.Item("Ttlpkd")
                End If
            Next
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class