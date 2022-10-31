Imports System.Data.SqlClient

Public Class frmAttendence
    Private Sub frmAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = ("dd/mm/yyyy")
        DataGridView1.MultiSelect = False
        ' DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnCount = 2

        DataGridView1.Columns(0).Name = "LedgerId"
        DataGridView1.Columns(1).Name = "Attendence"

        Dim Categoryds As New DataSet
        Categoryds = CommanFunctions.connectSQL("*", "LedgerCategory")

        Dim CatId As Integer
        For Each row As DataRow In Categoryds.Tables(0).Rows
            If row(1) = "STAFF" Then
                CatId = row(0)
            End If
        Next

        Dim ds As New DataSet
        ds = CommanFunctions.connectSQLwhere("Name", "Ledger", "where CategoryId = '" & CatId & "'")



        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Ledger"


        DataGridView1.Columns("Name").Width = 150
        DataGridView1.Columns("Name").ReadOnly = True

        DataGridView1.Columns("LedgerId").DisplayIndex = 0
        DataGridView1.Columns("Name").DisplayIndex = 1
        DataGridView1.Columns("Attendence").DisplayIndex = 2
        CommanFunctions.allTextboxUpperCase(Me)


    End Sub
    Private Sub fillLedgerId()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "Ledger")

        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each drow As DataRow In ds.Tables(0).Rows
                '   MsgBox(row.Cells("Name").Value & " :: " & drow(1))
                If Trim(row.Cells("Name").Value) = Trim(drow(1)) Then
                    row.Cells("LedgerId").Value = drow(0)
                End If
            Next
        Next

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmLedgerCreate.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datealreadyexists As Boolean = False

        Dim ds As New DataSet()
        ds = CommanFunctions.connectSQL("Date", "ATTENDENCE")


        For Each row As DataRow In ds.Tables(0).Rows
            If row(0) = DateTimePicker1.Value.ToShortDateString Then
                datealreadyexists = True
                Exit For
            Else
                datealreadyexists = False
            End If

        Next

        If datealreadyexists = False Then

            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect
            mycommand.CommandText = "INSERT INTO Attendence (Date,LedgerId,Attendence) 
                    VALUES (@Date,@LedgerId,@Attendence)"
            myconnect.Open()


            Try
                For Each row As DataGridViewRow In DataGridView1.Rows
                    mycommand.Parameters.Clear()
                    mycommand.Parameters.Add("@Date", SqlDbType.Date).Value = DateTimePicker1.Value
                    'mycommand.Parameters.Add("@SalaryId", SqlDbType.Int).Value = salId
                    mycommand.Parameters.Add("@LedgerId", SqlDbType.Int).Value = row.Cells("LedgerId").Value
                    mycommand.Parameters.Add("@Attendence", SqlDbType.Decimal).Value = row.Cells("Attendence").Value
                    mycommand.ExecuteNonQuery()

                Next

                MsgBox("SUCCESS")
                For Each row As DataGridViewRow In DataGridView1.Rows
                    row.Cells("Attendence").Value = ""
                Next

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try

            myconnect.Close()


        Else
            MsgBox("Date Already Exists")
        End If
    End Sub
    Private Function generateSalaryId()

        Dim dsS As New DataSet
        dsS = CommanFunctions.connectSQL("SalaryId", "Salary")


        Dim ttlrows As Integer = dsS.Tables(0).Rows.Count
        Dim Salid As Integer = 0


        If ttlrows > 0 Then
            Salid = dsS.Tables(0).Rows(ttlrows - 1).Item(0) + 1

        Else
            Salid = 1
        End If
        MsgBox(Salid)
        Return Salid

    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmAttendence_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

        fillLedgerId()

    End Sub
End Class