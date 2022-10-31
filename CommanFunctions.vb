Imports System.Data.SqlClient

Public Class CommanFunctions

    Public Shared Function allTextboxUpperCase(Pctrl As Control)
        For Each ctrl As Control In Pctrl.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).CharacterCasing = CharacterCasing.Upper
            End If
        Next
    End Function


    Public Shared Function updateDGV(dgv As DataGridView, colName As String, tableName As String)
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL(colName, tableName)
        dgv.DataSource = ds
        dgv.DataMember = tableName
    End Function

    Public Shared Function autocomplete(colNames As String, tableName As String, textbox As TextBox, dsRow As Integer)
        Dim ds As New DataSet
        ds = CommanFunctions.connectSQL(colNames, tableName)
        textbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        For Each row As DataRow In ds.Tables(0).Rows
            textbox.AutoCompleteCustomSource.Add(row(dsRow))
        Next
    End Function

    Public Shared Function restrictTextEntry(columnName As String, tableName As String, tb As TextBox)
        Dim isTextfromList As Boolean
        'Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="F:\Jitu\2022-10\NO USE\Padok_data.mdf";Integrated Security=True;Connect Timeout=30
        Dim connectionString As String = "Data Source=(LocalDB)\mssqllocaldb;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT " + columnName + " FROM " + tableName
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, tableName)
        connection.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            If tb.Text = row(0).ToString Then
                isTextfromList = True
                Exit For
            Else
                isTextfromList = False
            End If

        Next

        If String.IsNullOrWhiteSpace(tb.Text) Or isTextfromList = False Then
            'tb.Text = ""
            'tb.Focus()
            tb.BackColor = Color.Red
        End If

    End Function


    Public Shared Function emptyFieldCheck(myctrl As Control)
        Dim countEmptyBox As Integer = 0

        For Each ctrl In myctrl.Controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(ctrl.text) Then
                    countEmptyBox = countEmptyBox + 1

                End If
            End If
        Next
        If countEmptyBox > 0 Then
            MsgBox("Please fill empty Fields: " & countEmptyBox)
        End If

        Return countEmptyBox

    End Function
    Public Shared Function connectSQL(colName As String, tbleName As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT " + colName + " FROM " + tbleName
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds, ds1 As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, tbleName)
        connection.Close()
        Return ds
    End Function

    Public Shared Function attachFindItem(mf As Form)

        If Not String.IsNullOrWhiteSpace(mf.Controls("tbCloth").Text) Then

            If Not String.IsNullOrWhiteSpace(mf.Controls("tbClothModel").Text) Then

                If Not String.IsNullOrWhiteSpace(mf.Controls("tbItem").Text) Then

                    If Not String.IsNullOrWhiteSpace(mf.Controls("tbItemModel").Text) Then

                        If Not String.IsNullOrWhiteSpace(mf.Controls("tbSize").Text) Then

                            If Not String.IsNullOrWhiteSpace(mf.Controls("tbDesc").Text) Then
                                mf.Controls("tbNewitem").Text = mf.Controls("tbCloth").Text & " " & mf.Controls("tbClothModel").Text & " " & mf.Controls("tbItem").Text & " " & mf.Controls("tbItemModel").Text & " " & mf.Controls("tbSize").Text & " " & mf.Controls("tbDesc").Text
                            End If
                        Else
                            mf.Controls("tbNewitem").Text = Trim(mf.Controls("tbCloth").Text & " " & mf.Controls("tbClothModel").Text & " " & mf.Controls("tbItem").Text & " " & mf.Controls("tbItemModel").Text & " " & mf.Controls("tbDesc").Text)
                        End If
                    Else
                        mf.Controls("tbNewitem").Text = Trim(mf.Controls("tbCloth").Text & " " & mf.Controls("tbClothModel").Text & " " & mf.Controls("tbItem").Text & " " & mf.Controls("tbSize").Text & " " & mf.Controls("tbDesc").Text)
                    End If
                Else
                    mf.Controls("tbNewitem").Text = Trim(mf.Controls("tbCloth").Text & " " & mf.Controls("tbClothModel").Text & " " & mf.Controls("tbItemModel").Text & " " & mf.Controls("tbSize").Text & " " & mf.Controls("tbDesc").Text)
                End If
            Else
                mf.Controls("tbNewitem").Text = Trim(mf.Controls("tbCloth").Text & " " & mf.Controls("tbItem").Text & " " & mf.Controls("tbItemModel").Text & " " & mf.Controls("tbSize").Text & " " & mf.Controls("tbDesc").Text)
            End If
        Else
            mf.Controls("tbNewitem").Text = Trim(mf.Controls("tbClothModel").Text & " " & mf.Controls("tbItem").Text & " " & mf.Controls("tbItemModel").Text & " " & mf.Controls("tbSize").Text & " " & mf.Controls("tbDesc").Text)
        End If
    End Function
    Public Shared Function enableTextBox(chkbox As CheckBox, txtbox As TextBox)
        If chkbox.CheckState = CheckState.Checked Then
            txtbox.Enabled = True
        Else
            txtbox.Enabled = False
        End If

    End Function

    Public Shared Function connectSQLwhere(colName As String, tbleName As String, wCondition As String)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLlocalDB;initial catalog = master;Integrated Security=True"
        Dim sql As String = "SELECT " + colName + " FROM " + tbleName + " " + wCondition
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds, ds1 As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, tbleName)
        connection.Close()
        Return ds
    End Function
End Class
