Imports System.Data.SqlClient

Public Class frmNewItem
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs)
    '    For Each frm As Form In Padok.MdiChildren
    '        If TypeOf frm Is frmNewUnit Then
    '            frm.Focus()
    '            frm.WindowState = FormWindowState.Normal
    '        Else
    '            frmNewUnit.MdiParent = Padok
    '            frmNewUnit.Show()
    '        End If
    '    Next
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' to check if added name already exists or not
        Dim namealreadyexists As Boolean = False
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM Item"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Item")
        connection.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            If row(0).ToString = tbNewitem.Text Then
                namealreadyexists = True
                Exit For
            Else
                namealreadyexists = False
            End If
        Next

        'saving the item while entry is not null or white space and item does not already exist
        If Not String.IsNullOrWhiteSpace(tbNewitem.Text) And namealreadyexists = False Then

            Dim myconnect As New SqlClient.SqlConnection

            myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()

            mycommand.Connection = myconnect

            mycommand.CommandText = "INSERT INTO Item (Item_Name,Cloth,ClothModel,Item,ItemModel,Size,[Desc]) 
                    VALUES (@newitem,@Cloth,@ClothModel,@Item,@ItemModel,@Size,@Desc)"
            myconnect.Open()
            Try
                mycommand.Parameters.Clear()
                mycommand.Parameters.Add("@NewItem", SqlDbType.Char).Value = tbNewitem.Text
                mycommand.Parameters.Add("@Cloth", SqlDbType.Char).Value = tbCloth.Text
                mycommand.Parameters.Add("@ClothModel", SqlDbType.Char).Value = tbClothModel.Text
                mycommand.Parameters.Add("@Item", SqlDbType.Char).Value = tbItem.Text
                mycommand.Parameters.Add("@ItemModel", SqlDbType.Char).Value = tbItemModel.Text
                mycommand.Parameters.Add("@Size", SqlDbType.Char).Value = tbSize.Text
                mycommand.Parameters.Add("@Desc", SqlDbType.Char).Value = tbDesc.Text
                mycommand.ExecuteNonQuery()
                MsgBox("SUCCESS")

                '************************** CLEAR TEXT BOXES IN FORM   ************************
                For Each ctrl In Me.Controls
                    If (ctrl.GetType() Is GetType(TextBox)) Then
                        Dim txt As TextBox = CType(ctrl, TextBox)
                        txt.Text = ""
                    End If
                Next
                tbCloth.Focus()                 '**************FOCUS BACK TO FIRST TEXTBOX 'CLOTH'
                '**********************************************************************************

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try
            myconnect.Close()
        Else
            MsgBox("Item Already Exists or Empty")
        End If
    End Sub

    Private Sub tbNewitem_TextChanged(sender As Object, e As EventArgs) Handles tbNewitem.TextChanged
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT * FROM Item WHERE Item_name Like '%" & tbNewitem.Text & "%'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Item")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "item"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbCloth.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbClothModel_TextChanged(sender As Object, e As EventArgs) Handles tbClothModel.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbItem_TextChanged(sender As Object, e As EventArgs) Handles tbItem.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbItemModel_TextChanged(sender As Object, e As EventArgs) Handles tbItemModel.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbSize_TextChanged(sender As Object, e As EventArgs) Handles tbSize.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub tbDesc_TextChanged(sender As Object, e As EventArgs) Handles tbDesc.TextChanged
        concatAllExceptBlank()
    End Sub

    Private Sub frmNewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        tbCloth.Focus()
    End Sub
    Private Sub concatAllExceptBlank()

        tbNewitem.Text = ""

        Dim txtboxes() As String = {tbCloth.Text, tbClothModel.Text, tbItem.Text, tbItemModel.Text, tbSize.Text, tbDesc.Text}
        tbNewitem.Text = tbCloth.Text.ToUpper
        For i = 1 To 5
            If Not String.IsNullOrWhiteSpace(txtboxes(i)) Then
                tbNewitem.Text = tbNewitem.Text & " " & txtboxes(i).ToUpper
            End If
        Next



    End Sub
End Class