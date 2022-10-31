
Imports System.Data.SqlClient

Public Class frmShrinkage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowOptionsForm()
    End Sub

    Private Sub ShowOptionsForm()

        Dim options = New frmSelectPurId

        AddHandler options.savedOptions, AddressOf OnOptionsSave

        options.ShowDialog()

    End Sub

    Private Sub OnOptionsSave(ByVal strData As String)

        'Or whatever you want to do on frmMain with Options Data.
        'MsgBox(strData)
        lblPurId.Text = strData

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lblPurId.Text <> 0 AndAlso Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            Try
                Dim myconnect As New SqlClient.SqlConnection
                myconnect.ConnectionString = "Data Source=(LocalDB)\mssqllocaldb;initial catalog = master;Integrated Security=True"
                Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
                mycommand.Connection = myconnect
                mycommand.CommandText = "Update Purchase set Shrinkage =@Shrinkage where [PurId] = @PurId"
                myconnect.Open()

                'mycommand.Parameters.Clear()
                'mycommand.Parameters.Add("@CuttingId", SqlDbType.Int).Value = lblCuttingId.Text
                'mycommand.Parameters.

                With mycommand.Parameters
                    .AddWithValue("@Shrinkage", TextBox1.Text)
                    .AddWithValue("@PurId", lblPurId.Text)
                End With

                mycommand.ExecuteNonQuery()

            Catch ex As SqlException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            TextBox1.Text = ""
            lblPurId.Text = 0

        Else
            MsgBox("Select Purchase Id")
        End If
    End Sub

    Private Sub frmShrinkage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommanFunctions.allTextboxUpperCase(Me)
    End Sub
End Class