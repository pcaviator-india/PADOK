Imports System.Data.SqlClient

Public Class frmAttendenceRegister
    Private Sub frmAttendenceRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim month As Integer = dtpFrom.Value.Month
        Dim year As Integer = dtpFrom.Value.Year

        Dim lastday As Integer = Date.DaysInMonth(year, month)

        lbldaysinmonth.Text = lastday

        dtpFrom.Value = New Date(year, month, 1)
        dtpTo.Value = New Date(year, month, lastday)

        fillDgvAtt()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub DataGridView1_GotFocus(sender As Object, e As EventArgs) Handles DataGridView1.GotFocus
        fillnameCOl()
        fillAdvance()
        fillBalance()


    End Sub

    Private Sub fillDgvAtt()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT a.LedgerId, sum(a.attendence) as TTlAttendence 
                            from attendence a
                            WHERE date >= '" & dtpFrom.Value.ToShortDateString & "' and date <= '" & dtpTo.Value.ToShortDateString & "' group by a.LedgerId"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds, ds1 As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Attendence")
        connection.Close()

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Attendence"
        ' DataGridView1.Columns("name").DisplayIndex = 1
        If DataGridView1.ColumnCount <> 7 Then

            Dim textcolumn As New DataGridViewTextBoxColumn
            With textcolumn
                .HeaderText = "Name"
                .Name = "Name"
            End With
            DataGridView1.Columns.Insert(1, textcolumn)

            Dim textcolumn1 As New DataGridViewTextBoxColumn
            With textcolumn1
                .HeaderText = "MSalary"
                .Name = "MSalary"
            End With
            DataGridView1.Columns.Insert(2, textcolumn1)

            Dim textcolumn2 As New DataGridViewTextBoxColumn
            With textcolumn2
                .HeaderText = "CSalary"
                .Name = "CSalary"
            End With
            DataGridView1.Columns.Insert(4, textcolumn2)

            Dim textcolumn4 As New DataGridViewTextBoxColumn
            With textcolumn4
                .HeaderText = "Advance"
                .Name = "Advance"
            End With
            DataGridView1.Columns.Insert(5, textcolumn4)

            Dim textcolumn3 As New DataGridViewTextBoxColumn
            With textcolumn3
                .HeaderText = "Balance"
                .Name = "Balance"
            End With
            DataGridView1.Columns.Insert(6, textcolumn3)



        End If
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        fillDgvAtt()
        fillnameCOl()
        daysCurrentSel()
        fillAdvance()
        fillBalance()


    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        fillDgvAtt()
        fillnameCOl()
        daysCurrentSel()
        fillAdvance()
        fillBalance()
    End Sub

    Private Sub fillAdvance()
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "daybook")
        Dim advanceTotal As Decimal
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each dsRow As DataRow In ds.Tables(0).Rows
                If row.Cells("NAME").Value = dsRow(2) Then
                    advanceTotal = advanceTotal + dsRow(3)
                End If
                row.Cells("Advance").Value = advanceTotal
            Next
        Next
    End Sub

    Private Sub fillBalance()
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("Balance").Value = row.Cells("CSalary").Value - row.Cells("Advance").Value
        Next
    End Sub

    Private Sub fillnameCOl()
        'Dim ds As New DataSet
        'ds = CommanFunctions.connectSQL("Ledgerid,Salary", "salary")

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT l.ledgerid,l.name,s.salary from Ledger l
                            left outer join salary s
                            ON l.LedgerId=s.LedgerId"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds, ds1 As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Ledger")
        connection.Close()



        Dim ttlDays As Integer
        Dim curMOnth As Integer = dtpFrom.Value.Month
        Dim curYear As Integer = dtpFrom.Value.Year
        ttlDays = Date.DaysInMonth(curYear, curMOnth)


        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each dsRow As DataRow In ds.Tables(0).Rows
                If row.Cells("Ledgerid").Value = dsRow.Item(0) Then
                    row.Cells("Name").Value = dsRow.Item(1)
                    row.Cells("MSalary").Value = dsRow.Item(2)
                    row.Cells("CSalary").Value = CInt(row.Cells("MSalary").Value / ttlDays * row.Cells("ttlAttendence").Value)
                    ' row.Cells("Balance").Value = row.Cells("CSalary").Value - row.Cells("TtlAdvance").Value
                End If
            Next
        Next
    End Sub

    Private Sub daysCurrentSel()
        Dim Fday As Date = dtpFrom.Value.Date
        Dim Lday As Date = dtpTo.Value.Date
        Dim daysSel As Integer = Lday.Subtract(Fday).Days + 1

        lbldaysinmonth.Text = daysSel
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim curRow As Integer = DataGridView1.CurrentRow().Index
        Dim LedgerId As Integer = DataGridView1.Rows(curRow).Cells("Ledgerid").Value
        Dim LedgerName As String = DataGridView1.Rows(curRow).Cells("Name").Value
        Dim frm As New frmAttendenceDetail(LedgerId, LedgerName)
        frm.ShowDialog()
    End Sub
End Class
