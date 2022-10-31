<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPurchaseView
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TbPurShrink = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbPurLa = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbPurLm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbPurWidth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbPurRate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbPurUnit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbPurQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbPurItem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbPurBill = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbPurSupplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbPurChallan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LbPurID = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1158, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(784, 529)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 30)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(693, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(693, 493)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Modify"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(784, 493)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 30)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Delete All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TbPurShrink
        '
        Me.TbPurShrink.Location = New System.Drawing.Point(475, 621)
        Me.TbPurShrink.Name = "TbPurShrink"
        Me.TbPurShrink.Size = New System.Drawing.Size(200, 20)
        Me.TbPurShrink.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(376, 626)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Shrinkage"
        '
        'TbPurLa
        '
        Me.TbPurLa.Location = New System.Drawing.Point(475, 595)
        Me.TbPurLa.Name = "TbPurLa"
        Me.TbPurLa.Size = New System.Drawing.Size(200, 20)
        Me.TbPurLa.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(376, 598)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "L Actual"
        '
        'TbPurLm
        '
        Me.TbPurLm.Location = New System.Drawing.Point(475, 569)
        Me.TbPurLm.Name = "TbPurLm"
        Me.TbPurLm.Size = New System.Drawing.Size(200, 20)
        Me.TbPurLm.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(376, 572)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "L Mentioned"
        '
        'TbPurWidth
        '
        Me.TbPurWidth.Location = New System.Drawing.Point(475, 543)
        Me.TbPurWidth.Name = "TbPurWidth"
        Me.TbPurWidth.Size = New System.Drawing.Size(200, 20)
        Me.TbPurWidth.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(376, 546)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Cloth Width / Size"
        '
        'TbPurRate
        '
        Me.TbPurRate.Location = New System.Drawing.Point(142, 699)
        Me.TbPurRate.Name = "TbPurRate"
        Me.TbPurRate.Size = New System.Drawing.Size(200, 20)
        Me.TbPurRate.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 702)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Rate"
        '
        'TbPurUnit
        '
        Me.TbPurUnit.Location = New System.Drawing.Point(142, 673)
        Me.TbPurUnit.Name = "TbPurUnit"
        Me.TbPurUnit.Size = New System.Drawing.Size(200, 20)
        Me.TbPurUnit.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 676)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Unit"
        '
        'TbPurQuantity
        '
        Me.TbPurQuantity.Location = New System.Drawing.Point(142, 647)
        Me.TbPurQuantity.Name = "TbPurQuantity"
        Me.TbPurQuantity.Size = New System.Drawing.Size(200, 20)
        Me.TbPurQuantity.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 650)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Quantity"
        '
        'TbPurItem
        '
        Me.TbPurItem.Location = New System.Drawing.Point(142, 621)
        Me.TbPurItem.Name = "TbPurItem"
        Me.TbPurItem.Size = New System.Drawing.Size(200, 20)
        Me.TbPurItem.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 624)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Item"
        '
        'TbPurBill
        '
        Me.TbPurBill.Location = New System.Drawing.Point(142, 595)
        Me.TbPurBill.Name = "TbPurBill"
        Me.TbPurBill.Size = New System.Drawing.Size(200, 20)
        Me.TbPurBill.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 598)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Bill no."
        '
        'TbPurSupplier
        '
        Me.TbPurSupplier.Location = New System.Drawing.Point(142, 569)
        Me.TbPurSupplier.Name = "TbPurSupplier"
        Me.TbPurSupplier.Size = New System.Drawing.Size(200, 20)
        Me.TbPurSupplier.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 572)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Supplier"
        '
        'TbPurChallan
        '
        Me.TbPurChallan.Location = New System.Drawing.Point(142, 543)
        Me.TbPurChallan.Name = "TbPurChallan"
        Me.TbPurChallan.Size = New System.Drawing.Size(200, 20)
        Me.TbPurChallan.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 546)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Challan No."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(142, 515)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 521)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(74, 493)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Purchase Id"
        '
        'LbPurID
        '
        Me.LbPurID.AutoSize = True
        Me.LbPurID.Location = New System.Drawing.Point(144, 493)
        Me.LbPurID.Name = "LbPurID"
        Me.LbPurID.Size = New System.Drawing.Size(37, 13)
        Me.LbPurID.TabIndex = 49
        Me.LbPurID.Text = "          "
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(393, 667)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 28)
        Me.Button5.TabIndex = 50
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmPurchaseEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1173, 733)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LbPurID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TbPurShrink)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TbPurLa)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TbPurLm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TbPurWidth)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbPurRate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbPurUnit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TbPurQuantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbPurItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbPurBill)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbPurSupplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbPurChallan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "frmPurchaseEdit"
        Me.Text = "Purchase - View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TbPurShrink As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TbPurLa As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TbPurLm As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbPurWidth As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbPurRate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbPurUnit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbPurQuantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbPurItem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbPurBill As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbPurSupplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbPurChallan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LbPurID As Label
    Friend WithEvents Button5 As Button
End Class
