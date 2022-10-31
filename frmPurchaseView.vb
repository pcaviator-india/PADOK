Imports System.Data.SqlClient

Public Class frmPurchaseView
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM purchase"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "purchase")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "purchase"
    End Sub

    Private Sub DataGridView1_GotFocus(sender As Object, e As EventArgs) Handles DataGridView1.GotFocus
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM purchase"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "purchase")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "purchase"
    End Sub

    Private Sub clearPurEditForm()
        DateTimePicker1.ResetText()
        TbPurChallan.Text = ""
        TbPurBill.Text = ""
        TbPurItem.Text = ""
        TbPurLa.Text = ""
        TbPurLm.Text = ""
        TbPurQuantity.Text = ""
        TbPurRate.Text = ""
        TbPurShrink.Text = ""
        TbPurSupplier.Text = ""
        TbPurUnit.Text = ""
        TbPurWidth.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim selRow As Integer = DataGridView1.CurrentRow.Index
        Dim selPurId As Integer = DataGridView1.Item(0, selRow).Value
        Dim colCount As Integer = DataGridView1.ColumnCount()
        Dim SelRowArray() As Object = {
            "LbPurID",
            "DateTimePicker1",
            "TbPurChallan",
            "TbPurBill",
            "TbPurSupplier",
            "TbPurItem",
            "TbPurQuantity",
            "TbPurUnit",
            "TbPurRate",
            "TbPurWidth",
            "TbPurLm",
            "TbPurLa",
            "TbPurShrink"}

        LbPurID.Text = DataGridView1.Item(0, selRow).Value
        DateTimePicker1.Value = Convert.ToDateTime(DataGridView1.Item(1, selRow).Value.ToString())
        TbPurChallan.Text = DataGridView1.Item(2, selRow).Value
        TbPurBill.Text = DataGridView1.Item(3, selRow).Value
        TbPurSupplier.Text = DataGridView1.Item(4, selRow).Value
        TbPurItem.Text = DataGridView1.Item(5, selRow).Value
        TbPurQuantity.Text = DataGridView1.Item(6, selRow).Value
        TbPurUnit.Text = DataGridView1.Item(7, selRow).Value
        TbPurRate.Text = DataGridView1.Item(8, selRow).Value
        TbPurWidth.Text = DataGridView1.Item(9, selRow).Value
        TbPurLm.Text = DataGridView1.Item(10, selRow).Value
        TbPurLa.Text = DataGridView1.Item(11, selRow).Value
        TbPurLa.Text = DataGridView1.Item(11, selRow).Value
        TbPurLa.Text = DataGridView1.Item(11, selRow).Value
        'TbPurShrink.Text = DataGridView1.Item(12, selRow).Value

    End Sub

    Private Sub frmPurchaseEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
    End Sub
End Class