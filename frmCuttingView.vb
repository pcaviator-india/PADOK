Imports System.Data.SqlClient
Imports System.Text


Public Class frmCuttingView
    Private Sub frmCuttingView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        'Dim ds As New DataSet
        'ds = CommanFunctions.connectSQL("*", "Cutting")
        Try

            Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
            Dim sql As String = "SELECT cutting.*, cuttingitems.citem, cuttingitems.cqty, cuttingitems.cavg from (cutting join cuttingitems on cutting.cuttingid=cuttingitems.cuttingid)"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Cutting")
            connection.Close()

            dgvViewCutting.DataSource = ds
            dgvViewCutting.DataMember = "Cutting"

            dgvViewCutting.MultiSelect = False
            dgvViewCutting.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvViewCutting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvViewCutting.Columns.Item("cItem").Width = 250

            cmbBoxFilter.MaxDropDownItems = 5
            cmbBoxFilter.Items.Add("Purchase Id")
            cmbBoxFilter.Items.Add("Item Name")
        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DateTimePicker1.CustomFormat = "mm/dd/YYYY"
        DateTimePicker2.CustomFormat = "mm/dd/YYYY"



    End Sub

    Private Sub tbFilter_TextChanged(sender As Object, e As EventArgs) Handles tbFilter.TextChanged

        'Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        'Dim sql As String = "SELECT cutting.*, cuttingitems.citem, cuttingitems.cqty, cuttingitems.cavg from (cutting join cuttingitems on cutting.cuttingid=cuttingitems.cuttingid)"
        'Dim connection As New SqlConnection(connectionString)
        'Dim dataadapter As New SqlDataAdapter(sql, connection)
        'Dim ds As New DataSet()
        'connection.Open()
        'dataadapter.Fill(ds, "Cutting")
        'connection.Close()

        'Dim bs As New BindingSource
        'Dim dview As New DataView(ds.Tables(0))
        'bs.DataSource = dview

        'Try
        '    If Not String.IsNullOrWhiteSpace(tbFilter.Text) Then

        '        Select Case cmbBoxFilter.SelectedItem
        '            Case "Purchase Id"
        '                If CheckBox1.CheckState = CheckState.Checked Then
        '                    bs.Filter = String.Format("CONVERT(PurId,'System.String') LIKE '" & tbFilter.Text & "%' AND cDate >= #{0:M/dd/yyyy}# AND cDate <= #{1:M/dd/yyyy}#",
        '           DateTimePicker1.Value, DateTimePicker2.Value)
        '                Else
        '                    bs.Filter = "CONVERT(PurId,'System.String') LIKE '" & tbFilter.Text & "%'"
        '                End If
        '            Case "Item Name"
        '                bs.Filter = "cItem LIKE '%" & tbFilter.Text & "%'"
        '        End Select

        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'dgvViewCutting.DataSource = bs

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT cutting.*, cuttingitems.citem, cuttingitems.cqty, cuttingitems.cavg from cutting join cuttingitems on cutting.cuttingid=cuttingitems.cuttingid"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Cutting")
        connection.Close()

        Dim bs As New BindingSource
        Dim dview As New DataView(ds.Tables(0))
        bs.DataSource = dview


        Try
            'If Not String.IsNullOrWhiteSpace(tbFilter.Text) Then

            Select Case cmbBoxFilter.SelectedItem
                    Case "Purchase Id"
                        If CheckBox1.CheckState = CheckState.Checked Then
                            bs.Filter = String.Format("CONVERT(PurId,'System.String') LIKE '" & tbFilter.Text & "%' AND cDate >= #{0:M/dd/yyyy}# AND cDate <= #{1:M/dd/yyyy}#",
                   DateTimePicker1.Value, DateTimePicker2.Value)
                        Else
                            bs.Filter = "CONVERT(PurId,'System.String') LIKE '" & tbFilter.Text & "%'"
                        End If
                    Case "Item Name"
                        If CheckBox1.CheckState = CheckState.Checked Then
                            bs.Filter = String.Format("cItem LIKE '%" & tbFilter.Text & "%' And CDate >= #{0:M/ dd / yyyy}# And CDate <= #{1:M/ dd / yyyy}#",
                   DateTimePicker1.Value, DateTimePicker2.Value)
                        Else
                            bs.Filter = "cItem LIKE '%" & tbFilter.Text & "%'"
                        End If
                    Case Else
                        bs.Filter = String.Format("cDate >= #{0:M/dd/yyyy}# AND cDate <= #{1:M/dd/yyyy}#",
                                        DateTimePicker1.Value, DateTimePicker2.Value)
                End Select

            ' End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dgvViewCutting.DataSource = bs


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class