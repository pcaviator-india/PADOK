Imports System.Data.SqlClient

Public Class frmJobWorkReceive
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

        'dgv items to receive fill up
        Dim sqlR As String = "SELECT * from jobIssueItemReceive where ChallanId like " + "'" + tbChNo.Text + "'"
        Dim connectionR As New SqlConnection(connectionString)
        Dim dataadapterR As New SqlDataAdapter(sqlR, connectionR)
        Dim dssR As New DataSet()
        connectionR.Open()
        dataadapterR.Fill(dssR, "jobissueItemReceive")
        connectionR.Close()

        dgvItemreceived.DataSource = dssR
        dgvItemreceived.DataMember = "jobissueItemReceive"

        dgvItemreceived.Columns(0).ReadOnly = True
        dgvItemreceived.Columns(1).ReadOnly = True
        dgvItemreceived.Columns(2).ReadOnly = True
        dgvItemreceived.Columns(4).ReadOnly = True

        '***************************

        'dgv items to receive as raw
        Dim sqlRaw As String = "SELECT * from jobIssueItemIssue where ChallanId like " + "'" + tbChNo.Text + "'"
        Dim connectionRaw As New SqlConnection(connectionString)
        Dim dataadapterRaw As New SqlDataAdapter(sqlRaw, connectionR)
        Dim dssRaw As New DataSet()
        connectionRaw.Open()
        dataadapterRaw.Fill(dssRaw, "jobissueItemIssue")
        connectionR.Close()

        dgvRawReceived.DataSource = dssRaw
        dgvRawReceived.DataMember = "jobissueItemIssue"

        dgvRawReceived.Columns(0).ReadOnly = True
        dgvRawReceived.Columns(1).ReadOnly = True
        dgvRawReceived.Columns(2).ReadOnly = True
        dgvRawReceived.Columns(4).ReadOnly = True




        '***************************

        'other labels to fill
        Dim sql As String = "SELECT ChDate,PurId,JobWorker from jobIssue where ChallanId like " + "'" + tbChNo.Text + "'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connectionR)
        Dim dss As New DataSet()
        connection.Open()
        dataadapter.Fill(dss, "jobissue")
        connection.Close()
        Try
            lbIssueDate.Text = dss.Tables(0).Rows(0).Item(0).ToString
            lbJobworker.Text = dss.Tables(0).Rows(0).Item(2).ToString
            lbPurId.Text = dss.Tables(0).Rows(0).Item(1).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub frmJobWorkReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        dgvRawReceived.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRawReceived.MultiSelect = False
        dgvRawReceived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        dgvItemreceived.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItemreceived.MultiSelect = False
        dgvItemreceived.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        dgvRawReceived.Visible = False


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'If tabReceiveItems.TabPages(1).Enabled = False Then
        '    tabReceiveItems.TabPages(1).Enabled = True
        'Else
        '    tabReceiveItems.TabPages(1).Enabled = False
        'End If
        'If tabReceiveItems.Controls.Count = 1 Then
        '    tabReceiveItems.Controls.Add(tabItemsIssued)
        'Else
        '    tabReceiveItems.Controls.Remove(tabItemsIssued)

        'End If

        If dgvRawReceived.Visible = False Then
            dgvRawReceived.Visible = True
        Else
            dgvRawReceived.Visible = False

        End If



    End Sub

    Private Sub btnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click


        Dim myconnect As New SqlClient.SqlConnection
        myconnect.ConnectionString = "Data Source=(LocalDB)\mssqllocaldb;initial catalog = master;Integrated Security=True"
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        Dim mycommand1 As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = myconnect
        mycommand.CommandText = "INSERT INTO JobIssueReceived (Id,ChallanId,Date,item,Quantity,Unit,Memo)
                    VALUES (@Id,@ChallanId,@Date,@Item,@quantity,@Unit,@memo)"
        If CheckBox1.CheckState = CheckState.Checked Then
            mycommand1.Connection = myconnect
            mycommand1.CommandText = "INSERT INTO JobIssueRawReceived (Id,ChallanId,Date,item,Quantity,Unit,Memo)
                    VALUES (@Id1,@ChallanId1,@Date1,@item1,@quantity1,@Unit1,@memo1)"
        End If
        myconnect.Open()

        Try
            For Each row As DataGridViewRow In dgvItemreceived.Rows

                mycommand.Parameters.Clear()

                mycommand.Parameters.Add("@Id", SqlDbType.Int).Value = row.Cells(0).Value

                mycommand.Parameters.Add("@ChallanId", SqlDbType.Int).Value = row.Cells(1).Value

                mycommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTimePicker1.Value

                mycommand.Parameters.Add("@Item", SqlDbType.NChar).Value = row.Cells(2).Value

                mycommand.Parameters.Add("@quantity", SqlDbType.Decimal).Value = row.Cells(3).Value

                mycommand.Parameters.Add("@Unit", SqlDbType.NChar).Value = row.Cells(4).Value

                mycommand.Parameters.Add("@Memo", SqlDbType.NChar).Value = row.Cells(5).Value

                mycommand.ExecuteNonQuery()

            Next
            If CheckBox1.CheckState = CheckState.Checked Then
                For Each row As DataGridViewRow In dgvRawReceived.Rows
                    mycommand1.Parameters.Clear()

                    mycommand1.Parameters.Add("@Id1", SqlDbType.Int).Value = row.Cells(0).Value

                    mycommand1.Parameters.Add("@ChallanId1", SqlDbType.Int).Value = row.Cells(1).Value

                    mycommand1.Parameters.Add("@Date1", SqlDbType.DateTime).Value = DateTimePicker1.Value

                    mycommand1.Parameters.Add("@Item1", SqlDbType.NChar).Value = row.Cells(2).Value

                    mycommand1.Parameters.Add("@quantity1", SqlDbType.Decimal).Value = row.Cells(3).Value

                    mycommand1.Parameters.Add("@Unit1", SqlDbType.NChar).Value = row.Cells(4).Value

                    mycommand1.Parameters.Add("@Memo1", SqlDbType.NChar).Value = row.Cells(5).Value

                    mycommand1.ExecuteNonQuery()

                Next
            End If
            MsgBox("Success")
            lbIssueDate.Text = ""
            lbPurId.Text = ""
            tbChNo.Text = ""
            lbJobworker.Text = ""
            dgvItemreceived.DataMember = ""
            tbChNo.Focus()



        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvItemtoreceive_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemreceived.CellContentClick

    End Sub
End Class