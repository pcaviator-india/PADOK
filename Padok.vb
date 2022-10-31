Imports System.Data.SqlClient
Imports System.IO


Public Class Padok
    Private Sub NewPurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPurchaseToolStripMenuItem.Click

        frmPurchaseNew.MdiParent() = Me
        frmPurchaseNew.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub EditPurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPurchaseToolStripMenuItem.Click

        frmPurchaseView.MdiParent() = Me
        frmPurchaseView.Show()

    End Sub

    Private Sub StartPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartPageToolStripMenuItem.Click

        'Start.MdiParent() = Me
        'Start.Show()

    End Sub

    Private Sub Padok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
        'AppDomain.CurrentDomain.SetData("DataDirectory", "C:\Users\jitendra\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB")
        Me.WindowState = FormWindowState.Maximized
        'Start.MdiParent() = Me
        ' Start.Show()

    End Sub

    Private Sub NewItemToolStripMenuItem_Click(sender As Object, e As EventArgs)

        frmNewItem.MdiParent() = Me
        frmNewItem.Show()

    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmItemView.MdiParent() = Me
        frmItemView.Show()

    End Sub

    Private Sub NewUnitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmNewUnit.MdiParent() = Me
        frmNewUnit.Show()

    End Sub

    Private Sub EditUnitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmViewUnit.MdiParent() = Me
        frmViewUnit.Show()

    End Sub

    Private Sub IssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueToolStripMenuItem.Click
        frmJobIssue.MdiParent() = Me
        frmJobIssue.Show()


    End Sub

    Private Sub NewJobWorkerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewJobWorkerToolStripMenuItem.Click
        frmNewJobWorker.MdiParent() = Me
        frmNewJobWorker.Show()
    End Sub

    Private Sub InstallDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallDatabaseToolStripMenuItem.Click
        'creating and initializing the connection string
        'Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=(localdb)\mssqllocaldb;initial catalog= master;Integrated Security=True;Pooling=False")

        'since we need to create a new database set the Initial Catalog as Master
        'Which means we are creating database under master DB
        'Dim myCommand As String '//To store the sql command To be executed
        ' myCommand = "CREATE database padok_data  ON (NAME=padok_data, FILENAME='padok_data.mdf')" ' the command that creates New database
        'Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString) ' creating command For execution

        'Try
        '    cmd.Connection.Open() '//open a connection With cmd
        '    cmd.ExecuteNonQuery() '//Execute the query
        '    cmd.Connection.Close() '//Close the connection
        'Catch ex As SqlException
        '    MsgBox(ex.Message)
        '    'MsgBox(" Already installed database", MsgBoxStyle.Critical, " Makadiya - Warning")
        'Catch ex As Exception
        '    MsgBox(Ex.message)
        'End Try
        'Creating table to the dynamicaly created database
        Dim sqlfile(15) As String

        Dim fpath As String = My.Application.Info.DirectoryPath



        sqlfile(0) = fpath & "\sql/challanno.txt"
        sqlfile(1) = fpath & "\sql/cutting.txt"
        sqlfile(2) = fpath & "\sql/cuttingitems.txt"
        sqlfile(3) = fpath & "\sql/item.txt"
        sqlfile(4) = fpath & "\sql/JobIssue.txt"
        sqlfile(5) = fpath & "\sql/JObissueItemIssue.txt"
        sqlfile(6) = fpath & "\sql/jobissueitemreceive.txt"
        sqlfile(7) = fpath & "\sql/JobIssuereceived.txt"
        sqlfile(8) = fpath & "\sql/JobworkParty.txt"
        sqlfile(9) = fpath & "\sql/Purchase.txt"
        sqlfile(10) = fpath & "\sql/Salary.txt"
        sqlfile(11) = fpath & "\sql/ShipmentDetail.txt"
        sqlfile(12) = fpath & "\sql/Staff.txt"
        sqlfile(13) = fpath & "\sql/Supplier.txt"
        sqlfile(14) = fpath & "\sql/Unit.txt"
        sqlfile(15) = fpath & "\sql/JobIssueRawReceived.txt"


        Dim cn As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLlocaldb;initial catalog =master;Integrated Security=True;Pooling=False")
        'here the connection string is initialized with Initial Catalog as padok_data
        'Dim sql As String '//sql query String
        Dim cmd As SqlCommand

        '******************************************************
        ' get list of tables in database
        Dim dds As New DataSet()
        Try
            Dim sqlstr As String = " SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES"
            Dim dataadapter As New SqlDataAdapter(sqlstr, cn)

            dataadapter.Fill(dds)
            cn.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()

        End Try
        '*********************************************************
        ' Delete tables in list

        Dim dcmd As New SqlCommand
        Dim delstr As String
        For Each row As DataRow In dds.Tables(0).Rows

            delstr = "drop table " & row(0).ToString
            dcmd = New SqlCommand(delstr, cn)
            cn.Open()
            dcmd.ExecuteNonQuery()
            cn.Close()
        Next










        For i = 0 To 15

            Dim sqlText = File.ReadAllText(sqlfile(i))
            cmd = New SqlCommand(sqlText, cn) ' // create command With connection And query String 
            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()

            Catch ex As SqlException
                MsgBox(ex.Message)
                'MsgBox(" Already existing table", MsgBoxStyle.Critical, " Makadiya - Warning")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then cn.Close()

            End Try
        Next
    End Sub

    Private Sub JobWorkPendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobWorkPendingToolStripMenuItem.Click
        frmViewJobWork.MdiParent() = Me
        frmViewJobWork.Show()

    End Sub

    Private Sub ReceiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveToolStripMenuItem.Click
        frmJobWorkReceive.MdiParent = Me
        frmJobWorkReceive.Show()
    End Sub

    Private Sub JobWorkReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobWorkReceivedToolStripMenuItem.Click
        frmJobWorkReceived.MdiParent() = Me
        frmJobWorkReceived.Show()
    End Sub

    Private Sub PackingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PackingToolStripMenuItem1.Click
        frmShipmentPacking.MdiParent() = Me
        frmShipmentPacking.Show()

    End Sub

    Private Sub NewSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSalesToolStripMenuItem.Click
        frmSalesNew.MdiParent() = Me
        frmSalesNew.Show()

    End Sub

    Private Sub CuttingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuttingToolStripMenuItem.Click
        frmCutting.MdiParent() = Me
        frmCutting.Show()
    End Sub

    Private Sub CuttingViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuttingViewToolStripMenuItem.Click
        frmCuttingView.MdiParent() = Me
        frmCuttingView.Show()
    End Sub

    Private Sub CurrentStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentStockToolStripMenuItem.Click
        frmCurrentStock.MdiParent() = Me
        frmCurrentStock.Show()

    End Sub

    Private Sub ShrinkageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShrinkageToolStripMenuItem.Click
        frmShrinkage.MdiParent() = Me
        frmShrinkage.Show()
    End Sub

    Private Sub AttendenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendenceToolStripMenuItem.Click
        frmAttendence.MdiParent() = Me
        frmAttendence.Show()
    End Sub

    Private Sub StaffNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffNewToolStripMenuItem.Click
        frmStaffSalary.MdiParent() = Me
        frmStaffSalary.Show()

    End Sub

    Private Sub AttendenceViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendenceViewToolStripMenuItem.Click
        frmAttendenceRegister.MdiParent() = Me
        frmAttendenceRegister.Show()
    End Sub

    Private Sub AttendenceDetailToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' frmAttendenceDetail.MdiParent() = Me
        ' frmAttendenceDetail.Show()
    End Sub

    Private Sub LinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkToolStripMenuItem.Click
        frmLink.MdiParent() = Me
        frmLink.Show()
    End Sub

    Private Sub DayBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DayBookToolStripMenuItem.Click
        frmDayBook.MdiParent() = Me
        frmDayBook.Show()

    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        frmNewItem.MdiParent() = Me
        frmNewItem.Show()

    End Sub

    Private Sub UnitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UnitToolStripMenuItem1.Click
        frmNewUnit.MdiParent() = Me
        frmNewUnit.Show()

    End Sub

    Private Sub GroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupToolStripMenuItem.Click
        frmGroupCreate.MdiParent() = Me
        frmGroupCreate.Show()

    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        frmCategoryCreate.MdiParent() = Me
        frmCategoryCreate.Show()
    End Sub

    Private Sub LedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LedgerToolStripMenuItem.Click
        frmLedgerCreate.MdiParent() = Me
        frmLedgerCreate.Show()
    End Sub

    Private Sub CloseAllWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllWindowsToolStripMenuItem.Click
        Dim childcount As Integer = Me.MdiChildren.Count - 1
        For i = childcount To 0 Step -1
            If Me.MdiChildren(i).Name <> "Start" Then
                Me.MdiChildren(i).Close()
            End If

        Next
    End Sub

    Private Sub GroupToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GroupToolStripMenuItem1.Click
        frmGroupView.MdiParent() = Me
        frmGroupView.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem1.Click
        frmCategoryVIew.MdiParent() = Me
        frmCategoryVIew.Show()
    End Sub

    Private Sub ItemToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem1.Click
        frmLedgerView.MdiParent() = Me
        frmLedgerView.Show()
    End Sub

    Private Sub ItemToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem2.Click
        frmItemView.MdiParent() = Me
        frmItemView.Show()
    End Sub

    Private Sub UnitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UnitToolStripMenuItem2.Click
        frmViewUnit.MdiParent() = Me
        frmViewUnit.Show()
    End Sub

    Private Sub GroupToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GroupToolStripMenuItem2.Click
        frmGroupEdit.MdiParent() = Me
        frmGroupEdit.Show()
    End Sub

    Private Sub LedgerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LedgerToolStripMenuItem1.Click
        frmLedgerEdit.MdiParent() = Me
        frmLedgerEdit.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem2.Click
        frmCategoryEdit.MdiParent() = Me
        frmCategoryEdit.Show()
    End Sub

    Private Sub ItemToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem3.Click
        frmItemEdit.MdiParent() = Me
        frmItemEdit.Show()
    End Sub

    Private Sub DayBookViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DayBookViewToolStripMenuItem.Click
        frmDayBookView.MdiParent() = Me
        frmDayBookView.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        frmReportsCreate.MdiParent() = Me
        frmReportsCreate.Show()
    End Sub

    Private Sub UnitToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles UnitToolStripMenuItem3.Click
        frmUnitEdit.MdiParent() = Me
        frmUnitEdit.Show()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PurchaseEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseEditToolStripMenuItem.Click
        frmPurchaseEdit.MdiParent() = Me
        frmPurchaseEdit.Show()
    End Sub


End Class