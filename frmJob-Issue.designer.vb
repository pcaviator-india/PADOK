<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJobIssue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbJobWorkerSelect = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbChallanNo = New System.Windows.Forms.Label()
        Me.DgvItemIssue = New System.Windows.Forms.DataGridView()
        Me.DgvItemReceive = New System.Windows.Forms.DataGridView()
        Me.lbPurId = New System.Windows.Forms.Label()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNewItem = New System.Windows.Forms.Button()
        Me.lbChallanID = New System.Windows.Forms.Label()
        Me.btnAddRowIssue = New System.Windows.Forms.Button()
        Me.btnAddRowReceive = New System.Windows.Forms.Button()
        Me.btnSelectPurId = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DgvItemIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvItemReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Job Worker"
        '
        'tbJobWorkerSelect
        '
        Me.tbJobWorkerSelect.Location = New System.Drawing.Point(303, 12)
        Me.tbJobWorkerSelect.Name = "tbJobWorkerSelect"
        Me.tbJobWorkerSelect.Size = New System.Drawing.Size(200, 20)
        Me.tbJobWorkerSelect.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(103, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(74, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "select one"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Purchase ID"
        '
        'lbChallanNo
        '
        Me.lbChallanNo.AutoSize = True
        Me.lbChallanNo.Location = New System.Drawing.Point(612, 16)
        Me.lbChallanNo.Name = "lbChallanNo"
        Me.lbChallanNo.Size = New System.Drawing.Size(62, 13)
        Me.lbChallanNo.TabIndex = 6
        Me.lbChallanNo.Text = "Challan No:"
        '
        'DgvItemIssue
        '
        Me.DgvItemIssue.AllowUserToAddRows = False
        Me.DgvItemIssue.AllowUserToDeleteRows = False
        Me.DgvItemIssue.AllowUserToOrderColumns = True
        Me.DgvItemIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItemIssue.Location = New System.Drawing.Point(12, 110)
        Me.DgvItemIssue.Name = "DgvItemIssue"
        Me.DgvItemIssue.Size = New System.Drawing.Size(572, 300)
        Me.DgvItemIssue.TabIndex = 7
        '
        'DgvItemReceive
        '
        Me.DgvItemReceive.AllowUserToAddRows = False
        Me.DgvItemReceive.AllowUserToDeleteRows = False
        Me.DgvItemReceive.AllowUserToOrderColumns = True
        Me.DgvItemReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItemReceive.Location = New System.Drawing.Point(614, 110)
        Me.DgvItemReceive.Name = "DgvItemReceive"
        Me.DgvItemReceive.Size = New System.Drawing.Size(572, 300)
        Me.DgvItemReceive.TabIndex = 8
        '
        'lbPurId
        '
        Me.lbPurId.AutoSize = True
        Me.lbPurId.Location = New System.Drawing.Point(339, 52)
        Me.lbPurId.Name = "lbPurId"
        Me.lbPurId.Size = New System.Drawing.Size(66, 13)
        Me.lbPurId.TabIndex = 9
        Me.lbPurId.Text = "Purchase ID"
        '
        'btnIssue
        '
        Me.btnIssue.Location = New System.Drawing.Point(421, 421)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(71, 23)
        Me.btnIssue.TabIndex = 11
        Me.btnIssue.Text = "Issue"
        Me.btnIssue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1023, 417)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Items to Issue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(612, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Items to Receive"
        '
        'btnNewItem
        '
        Me.btnNewItem.Location = New System.Drawing.Point(979, 84)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(71, 23)
        Me.btnNewItem.TabIndex = 15
        Me.btnNewItem.Text = "New Item"
        Me.btnNewItem.UseVisualStyleBackColor = True
        '
        'lbChallanID
        '
        Me.lbChallanID.AutoSize = True
        Me.lbChallanID.Location = New System.Drawing.Point(680, 16)
        Me.lbChallanID.Name = "lbChallanID"
        Me.lbChallanID.Size = New System.Drawing.Size(56, 13)
        Me.lbChallanID.TabIndex = 16
        Me.lbChallanID.Text = "Challan ID"
        '
        'btnAddRowIssue
        '
        Me.btnAddRowIssue.Location = New System.Drawing.Point(523, 84)
        Me.btnAddRowIssue.Name = "btnAddRowIssue"
        Me.btnAddRowIssue.Size = New System.Drawing.Size(27, 23)
        Me.btnAddRowIssue.TabIndex = 17
        Me.btnAddRowIssue.Text = "+"
        Me.btnAddRowIssue.UseVisualStyleBackColor = True
        '
        'btnAddRowReceive
        '
        Me.btnAddRowReceive.Location = New System.Drawing.Point(1118, 81)
        Me.btnAddRowReceive.Name = "btnAddRowReceive"
        Me.btnAddRowReceive.Size = New System.Drawing.Size(27, 23)
        Me.btnAddRowReceive.TabIndex = 18
        Me.btnAddRowReceive.Text = "+"
        Me.btnAddRowReceive.UseVisualStyleBackColor = True
        '
        'btnSelectPurId
        '
        Me.btnSelectPurId.Location = New System.Drawing.Point(214, 48)
        Me.btnSelectPurId.Name = "btnSelectPurId"
        Me.btnSelectPurId.Size = New System.Drawing.Size(119, 20)
        Me.btnSelectPurId.TabIndex = 19
        Me.btnSelectPurId.Text = "Select Purchase Id"
        Me.btnSelectPurId.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(557, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1151, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmJobIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 452)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSelectPurId)
        Me.Controls.Add(Me.btnAddRowReceive)
        Me.Controls.Add(Me.btnAddRowIssue)
        Me.Controls.Add(Me.lbChallanID)
        Me.Controls.Add(Me.btnNewItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.lbPurId)
        Me.Controls.Add(Me.DgvItemReceive)
        Me.Controls.Add(Me.DgvItemIssue)
        Me.Controls.Add(Me.lbChallanNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbJobWorkerSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmJobIssue"
        Me.Text = "Job - Issue"
        CType(Me.DgvItemIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvItemReceive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tbJobWorkerSelect As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbChallanNo As Label
    Friend WithEvents DgvItemIssue As DataGridView
    Friend WithEvents DgvItemReceive As DataGridView
    Friend WithEvents lbPurId As Label
    Friend WithEvents btnIssue As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNewItem As Button
    Friend WithEvents lbChallanID As Label
    Friend WithEvents btnAddRowIssue As Button
    Friend WithEvents btnAddRowReceive As Button
    Friend WithEvents btnSelectPurId As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
