Imports System.Data.SqlClient

Public Class frmStaffSalary
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim namealreadyexists As Boolean

        Dim ds As New DataSet()
        ds = CommanFunctions.connectSQL("LedgerId", "Salary")
        For Each row As DataRow In ds.Tables(0).Rows

            If Trim(row(0)) = lblLedgerId.Text Then
                namealreadyexists = True
                Exit For
            Else
                namealreadyexists = False
            End If

        Next
        generateSalaryId()

        If Not String.IsNullOrWhiteSpace(tbStaff.Text) And namealreadyexists = False Then

            'Dim newitem As Char
            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect
            mycommand.CommandText = "INSERT INTO Salary (SalaryId,LedgerId,salary) 
                    VALUES (@SalaryId,@LedgerId,@salary)"
            myconnect.Open()

            Try
                mycommand.Parameters.Add("@SalaryId", SqlDbType.Int).Value = Convert.ToInt32(lblSalaryId.Text)
                mycommand.Parameters.Add("@LedgerId", SqlDbType.Int).Value = Convert.ToInt32(lblLedgerId.Text)
                mycommand.Parameters.Add("@Salary", SqlDbType.Decimal).Value = tbSalary.Text

                mycommand.ExecuteNonQuery()
                MsgBox("SUCCESS")
                tbStaff.Text = ""
                tbSalary.Text = ""
                lblSalaryId.Text = ""
                lblLedgerId.Text = ""
                tbStaff.Focus()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try

            myconnect.Close()

        Else
            MsgBox("Salary Already Exists or Box Empty")
        End If
    End Sub

    Private Sub frmStaffNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        generateSalaryId()
        tbStaff.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmStaffNew_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        generateSalaryId()
    End Sub


    Private Sub generateSalaryId()
        Dim dsS As New DataSet
        dsS = CommanFunctions.connectSQL("SalaryId", "Salary")

        Dim ttlrows As Integer = dsS.Tables(0).Rows.Count
        Dim SalaryId As Integer = 0

        If ttlrows > 0 Then
            SalaryId = dsS.Tables(0).Rows(ttlrows - 1).Item(0) + 1
        Else
            SalaryId = 1
        End If

        lblSalaryId.Text = SalaryId

    End Sub

    Private Sub tbStaff_LostFocus(sender As Object, e As EventArgs) Handles tbStaff.LostFocus
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "Ledger")
        For Each row As DataRow In ds.Tables(0).Rows
            If row(1) = tbStaff.Text Then
                lblLedgerId.Text = row(0)
            End If
        Next
    End Sub

    Private Sub tbStaff_GotFocus(sender As Object, e As EventArgs) Handles tbStaff.GotFocus
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("Name", "ledger")
        tbStaff.AutoCompleteSource = AutoCompleteSource.CustomSource

        For Each row As DataRow In ds.Tables(0).Rows
            tbStaff.AutoCompleteCustomSource.Add(row(0))
        Next


    End Sub
End Class