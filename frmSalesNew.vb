Public Class frmSalesNew
    Private Sub frmSalesNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "ShipmentDetail")

        Dim chkbox As New DataGridViewCheckBoxColumn

        dgvShipmentDetail.Columns.Insert(0, chkbox)
        dgvShipmentDetail.DataSource = ds
        dgvShipmentDetail.DataMember = "shipmentdetail"
        dgvShipmentDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        dgvShipmentDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For i = 0 To dgvShipmentDetail.ColumnCount - 1
            dgvShipmentDetail.Columns(i).ReadOnly = True
        Next

    End Sub

    Private Sub dgvShipmentDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShipmentDetail.CellContentClick




    End Sub

    Private Sub dgvShipmentDetail_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShipmentDetail.CellValueChanged

    End Sub

    Private Sub dgvShipmentDetail_Click(sender As Object, e As EventArgs) Handles dgvShipmentDetail.Click

    End Sub

    Private Sub dgvShipmentDetail_DoubleClick(sender As Object, e As EventArgs) Handles dgvShipmentDetail.DoubleClick
        Dim CurBox As Integer

        CurBox = dgvShipmentDetail.SelectedRows(0).Cells(3).Value


        For Each row As DataGridViewRow In dgvShipmentDetail.Rows

            If row.Cells(0).Value = 0 Then
                If row.Cells(3).Value = CurBox Then
                    row.Cells(0).Value = -1
                End If
            Else
                If row.Cells(3).Value = CurBox Then
                    row.Cells(0).Value = 0
                End If
            End If
        Next



        'MsgBox(CurBox)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class