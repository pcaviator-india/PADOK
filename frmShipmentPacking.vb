Imports System.Data.SqlClient

Public Class frmShipmentPacking

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myconnect As New SqlClient.SqlConnection

        myconnect.ConnectionString = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = myconnect
        mycommand.CommandText = "INSERT INTO ShipmentDetail (ShipmentNo,TmpboxNo,PurId,Item,Quantity,Unit,WeightBox,WeightPc,SizeL,SizeW,SizeH) 
                    VALUES (@ShipmentNo,@TmpboxNo,@PurId,@Item,@Quantity,@Unit,@WeightBox,@WeightPc,@SizeL,@SizeW,@SizeH)"
        myconnect.Open()

        Try
            mycommand.Parameters.Clear()

            mycommand.Parameters.Add("@ShipmentNo", SqlDbType.Char).Value = tbShipmentNo.Text
            mycommand.Parameters.Add("@TmpboxNo", SqlDbType.Char).Value = tbTempBoxNo.Text
            mycommand.Parameters.Add("@PurId", SqlDbType.Char).Value = cmbbxPurid.SelectedItem.ToString
            mycommand.Parameters.Add("@Item", SqlDbType.Char).Value = tbItem.Text
            mycommand.Parameters.Add("@Quantity", SqlDbType.Char).Value = tbQuantity.Text
            mycommand.Parameters.Add("@Unit", SqlDbType.Char).Value = tbUnit.Text
            mycommand.Parameters.Add("@WeightBox", SqlDbType.Char).Value = tbWeightBox.Text
            mycommand.Parameters.Add("@WeightPc", SqlDbType.Char).Value = tbWeightPc.Text
            mycommand.Parameters.Add("@SizeL", SqlDbType.Char).Value = tbSizeL.Text
            mycommand.Parameters.Add("@SizeW", SqlDbType.Char).Value = tbSizeW.Text
            mycommand.Parameters.Add("@SizeH", SqlDbType.Char).Value = tbSizeH.Text

            mycommand.ExecuteNonQuery()
            ' MsgBox("SUCCESS")
            fillDGVshipmentdetail()
            ToolStripStatusLabel1.Text = "Success"

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                End If
            Next
            cmbbxPurid.Items.Clear()
            tbShipmentNo.Focus()

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)
        End Try

        myconnect.Close()


    End Sub
    Private Sub fillDGVshipmentdetail()
        Dim dgvds As New DataSet
        dgvds = CommanFunctions.connectSQL("*", "ShipmentDetail")
        dgvShipmentDetail.DataSource = dgvds
        dgvShipmentDetail.DataMember = "ShipmentDetail"

    End Sub

    Private Sub fillTbItem()
        tbItem.AutoCompleteSource = AutoCompleteSource.CustomSource

        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("Item_Name", "Item")

        For Each row As DataRow In ds.Tables(0).Rows
            tbItem.AutoCompleteCustomSource.Add(row(0).ToString)
        Next

    End Sub

    Private Sub tbItem_GotFocus(sender As Object, e As EventArgs) Handles tbItem.GotFocus

    End Sub

    Private Sub frmShipmentPacking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        tbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        cmbbxPurid.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        fillTbItem()
        fillDGVshipmentdetail()


    End Sub



    Private Sub tbPurId_GotFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub getPurIDItem4ItemSelected()

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"

        Dim sql As String = "SELECT p.purid                            
                            from purchase p
                            left join jobissue j
                            on p.purid = j.purid
                            left join jobissuereceived jir
                            on j.challanid=jir.challanid                          
                                              
                           where p.item Like '" & tbItem.Text & "'
                            or jir.item Like '" & tbItem.Text & "'
                           group by p.purid
                            "

        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds, ds1 As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "purchase")
        connection.Close()

        cmbbxPurid.AutoCompleteSource = AutoCompleteSource.CustomSource

        For Each row As DataRow In ds.Tables(0).Rows
            Dim ttlItems As Integer
            ttlItems = cmbbxPurid.Items.Count
            cmbbxPurid.Items.Add(row(0).ToString)
        Next


    End Sub

    Private Sub tbItem_LostFocus(sender As Object, e As EventArgs) Handles tbItem.LostFocus
        clearcmbbox()
        getPurIDItem4ItemSelected()
    End Sub

    Private Sub tbItem_TextChanged(sender As Object, e As EventArgs) Handles tbItem.TextChanged

    End Sub

    Private Sub clearcmbbox()
        Dim iCount As Integer = cmbbxPurid.Items.Count
        If iCount > 0 Then
            For i = iCount - 1 To 0
                cmbbxPurid.Items.RemoveAt(i)
            Next
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class