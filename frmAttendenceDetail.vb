Public Class frmAttendenceDetail
    Private Sub frmAttendenceDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)

        Dim month As Integer = dtpFrom.Value.Month
        Dim year As Integer = dtpFrom.Value.Year

        Dim lastday As Integer = Date.DaysInMonth(year, month)
        dtpFrom.Value = New Date(year, month, 1)
        dtpTo.Value = New Date(year, month, lastday)

        lblLedgerName.Text = selLedgerName

        filldataDGV(selLedgerId)

        'changeSundayCellColor()

    End Sub
    Private Sub DataGridview1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        For Each row As DataGridViewRow In DataGridView1.Rows
            'dayofweek = row.Cells(0).Value
            Dim ddate As Date
            ddate = Convert.ToDateTime(row.Cells(0).Value)
            If ddate.DayOfWeek = 0 Then
                row.Cells(0).Style.BackColor = Color.Red
            End If

        Next
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        filldataDGV(selLedgerId)
        'changeSundayCellColor()

    End Sub
    Private Sub filldataDGV(selLedgerId As Integer)

        Dim ds As New DataSet

        Dim whereClause As String = "where date >= '" & dtpFrom.Value.ToShortDateString & "' and date <= '" & dtpTo.Value.ToShortDateString & "' and Ledgerid like '" & selLedgerId & "'"

        ds = CommanFunctions.connectSQLwhere("date,Attendence", "Attendence", whereClause)
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Attendence"
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        filldataDGV(selLedgerId)
    End Sub
    Dim selLedgerId As Integer = 0
    Dim selLedgerName As String = ""
    Public Sub New(ByVal LedgerId As Integer, ByVal LedgerName As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        selLedgerId = LedgerId
        selLedgerName = LedgerName
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class