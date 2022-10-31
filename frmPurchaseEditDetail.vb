Public Class frmPurchaseEditDetail
    Dim selPurId As Integer = 0
    Dim selChalNo As String = ""
    Dim selBillNo As String = ""
    Dim SelSupplier As String = ""

    Public Sub New(ByVal PurId As Integer, ByVal CHaNo As String, BillNo As String, Supplier As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        selPurId = PurId
        selChalNo = CHaNo
        selBillNo = BillNo
        SelSupplier = Supplier

    End Sub

    Private Sub frmPurchaseEditDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPurId.Text = selPurId
        tbChallanNo.Text = selChalNo
        tbBillNo.Text = selBillNo
        tbSupplier.Text = SelSupplier

        Dim ds As New DataSet
        ds = CommanFunctions.connectSQLwhere("PurId,Date,Item,Quantity,Unit,Rate,Width_Size,Shrinkage", "Purchase", "WHERE Bill_No LIKE '" & selBillNo & "' OR Challan_No LIKE '" & selChalNo & "' AND Supplier LIKE '" & SelSupplier & "'")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Purchase"
        DateTimePicker1.Value = ds.Tables(0).Rows(0).Item(1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class