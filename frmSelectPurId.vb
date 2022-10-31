Public Class frmSelectPurId

    Friend Event savedOptions(ByVal strdata As String)

    Private Sub frmSelectPurId_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL("*", "Purchase")

        dgvPurId.DataSource = ds
        dgvPurId.DataMember = "Purchase"

        dgvPurId.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPurId.MultiSelect = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = dgvPurId.CurrentRow.Cells(0).Value
        RaiseEvent savedOptions(i)
        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class