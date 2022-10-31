<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPurchaseNew
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPurChallan = New System.Windows.Forms.TextBox()
        Me.TbPurSupplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbPurBill = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbPurItem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbPurQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbPurUnit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbPurRate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbPurWidth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbPurLm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbPurLa = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnNewSupplier = New System.Windows.Forms.Button()
        Me.btnNewItem = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddItemtoPurchase = New System.Windows.Forms.Button()
        Me.pnlAddIteminPurchase = New System.Windows.Forms.Panel()
        Me.ChkbxLa = New System.Windows.Forms.CheckBox()
        Me.chkbxLm = New System.Windows.Forms.CheckBox()
        Me.chkbxWidth = New System.Windows.Forms.CheckBox()
        Me.btnNewUnit = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddIteminPurchase.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Challan No."
        '
        'TbPurChallan
        '
        Me.TbPurChallan.Location = New System.Drawing.Point(499, 45)
        Me.TbPurChallan.Name = "TbPurChallan"
        Me.TbPurChallan.Size = New System.Drawing.Size(200, 20)
        Me.TbPurChallan.TabIndex = 3
        '
        'TbPurSupplier
        '
        Me.TbPurSupplier.Location = New System.Drawing.Point(80, 41)
        Me.TbPurSupplier.Name = "TbPurSupplier"
        Me.TbPurSupplier.Size = New System.Drawing.Size(200, 20)
        Me.TbPurSupplier.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Supplier"
        '
        'TbPurBill
        '
        Me.TbPurBill.Location = New System.Drawing.Point(499, 18)
        Me.TbPurBill.Name = "TbPurBill"
        Me.TbPurBill.Size = New System.Drawing.Size(200, 20)
        Me.TbPurBill.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bill no."
        '
        'TbPurItem
        '
        Me.TbPurItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TbPurItem.Location = New System.Drawing.Point(81, 12)
        Me.TbPurItem.Name = "TbPurItem"
        Me.TbPurItem.Size = New System.Drawing.Size(332, 20)
        Me.TbPurItem.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Item"
        '
        'TbPurQuantity
        '
        Me.TbPurQuantity.Location = New System.Drawing.Point(81, 38)
        Me.TbPurQuantity.Name = "TbPurQuantity"
        Me.TbPurQuantity.Size = New System.Drawing.Size(158, 20)
        Me.TbPurQuantity.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'TbPurUnit
        '
        Me.TbPurUnit.Location = New System.Drawing.Point(81, 64)
        Me.TbPurUnit.Name = "TbPurUnit"
        Me.TbPurUnit.Size = New System.Drawing.Size(158, 20)
        Me.TbPurUnit.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Unit"
        '
        'TbPurRate
        '
        Me.TbPurRate.Location = New System.Drawing.Point(81, 90)
        Me.TbPurRate.Name = "TbPurRate"
        Me.TbPurRate.Size = New System.Drawing.Size(158, 20)
        Me.TbPurRate.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Rate"
        '
        'TbPurWidth
        '
        Me.TbPurWidth.Location = New System.Drawing.Point(624, 12)
        Me.TbPurWidth.Name = "TbPurWidth"
        Me.TbPurWidth.Size = New System.Drawing.Size(143, 20)
        Me.TbPurWidth.TabIndex = 8
        Me.TbPurWidth.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cloth Width / Size"
        '
        'TbPurLm
        '
        Me.TbPurLm.Location = New System.Drawing.Point(624, 38)
        Me.TbPurLm.Name = "TbPurLm"
        Me.TbPurLm.Size = New System.Drawing.Size(143, 20)
        Me.TbPurLm.TabIndex = 9
        Me.TbPurLm.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(525, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "L Mentioned"
        '
        'TbPurLa
        '
        Me.TbPurLa.Location = New System.Drawing.Point(624, 64)
        Me.TbPurLa.Name = "TbPurLa"
        Me.TbPurLa.Size = New System.Drawing.Size(143, 20)
        Me.TbPurLa.TabIndex = 10
        Me.TbPurLa.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(525, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "L Actual"
        '
        'btnClearAll
        '
        Me.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearAll.Location = New System.Drawing.Point(621, 433)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAll.TabIndex = 12
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(702, 434)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(783, 433)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 434)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 23)
        Me.Button4.TabIndex = 27
        Me.Button4.TabStop = False
        Me.Button4.Text = "check blanks"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnNewSupplier
        '
        Me.btnNewSupplier.Location = New System.Drawing.Point(286, 39)
        Me.btnNewSupplier.Name = "btnNewSupplier"
        Me.btnNewSupplier.Size = New System.Drawing.Size(75, 23)
        Me.btnNewSupplier.TabIndex = 28
        Me.btnNewSupplier.TabStop = False
        Me.btnNewSupplier.Text = "New"
        Me.btnNewSupplier.UseVisualStyleBackColor = True
        '
        'btnNewItem
        '
        Me.btnNewItem.Location = New System.Drawing.Point(419, 9)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(75, 20)
        Me.btnNewItem.TabIndex = 29
        Me.btnNewItem.TabStop = False
        Me.btnNewItem.Text = "New"
        Me.btnNewItem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 221)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(846, 197)
        Me.DataGridView1.TabIndex = 30
        Me.DataGridView1.TabStop = False
        '
        'btnAddItemtoPurchase
        '
        Me.btnAddItemtoPurchase.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddItemtoPurchase.Location = New System.Drawing.Point(672, 116)
        Me.btnAddItemtoPurchase.Name = "btnAddItemtoPurchase"
        Me.btnAddItemtoPurchase.Size = New System.Drawing.Size(110, 23)
        Me.btnAddItemtoPurchase.TabIndex = 11
        Me.btnAddItemtoPurchase.Text = "Add Item"
        Me.btnAddItemtoPurchase.UseVisualStyleBackColor = True
        '
        'pnlAddIteminPurchase
        '
        Me.pnlAddIteminPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAddIteminPurchase.Controls.Add(Me.ChkbxLa)
        Me.pnlAddIteminPurchase.Controls.Add(Me.chkbxLm)
        Me.pnlAddIteminPurchase.Controls.Add(Me.chkbxWidth)
        Me.pnlAddIteminPurchase.Controls.Add(Me.btnNewUnit)
        Me.pnlAddIteminPurchase.Controls.Add(Me.Label5)
        Me.pnlAddIteminPurchase.Controls.Add(Me.btnAddItemtoPurchase)
        Me.pnlAddIteminPurchase.Controls.Add(Me.TbPurUnit)
        Me.pnlAddIteminPurchase.Controls.Add(Me.Label7)
        Me.pnlAddIteminPurchase.Controls.Add(Me.btnNewItem)
        Me.pnlAddIteminPurchase.Controls.Add(Me.TbPurRate)
        Me.pnlAddIteminPurchase.Controls.Add(Me.Label9)
        Me.pnlAddIteminPurchase.Controls.Add(Me.TbPurQuantity)
        Me.pnlAddIteminPurchase.Controls.Add(Me.TbPurWidth)
        Me.pnlAddIteminPurchase.Controls.Add(Me.Label8)
        Me.pnlAddIteminPurchase.Controls.Add(Me.Label6)
        Me.pnlAddIteminPurchase.Controls.Add(Me.Label10)
        Me.pnlAddIteminPurchase.Controls.Add(Me.TbPurItem)
        Me.pnlAddIteminPurchase.Controls.Add(Me.TbPurLm)
        Me.pnlAddIteminPurchase.Controls.Add(Me.Label11)
        Me.pnlAddIteminPurchase.Controls.Add(Me.TbPurLa)
        Me.pnlAddIteminPurchase.Location = New System.Drawing.Point(12, 71)
        Me.pnlAddIteminPurchase.Name = "pnlAddIteminPurchase"
        Me.pnlAddIteminPurchase.Size = New System.Drawing.Size(805, 144)
        Me.pnlAddIteminPurchase.TabIndex = 4
        Me.pnlAddIteminPurchase.TabStop = True
        '
        'ChkbxLa
        '
        Me.ChkbxLa.AutoSize = True
        Me.ChkbxLa.Location = New System.Drawing.Point(777, 68)
        Me.ChkbxLa.Name = "ChkbxLa"
        Me.ChkbxLa.Size = New System.Drawing.Size(15, 14)
        Me.ChkbxLa.TabIndex = 35
        Me.ChkbxLa.UseVisualStyleBackColor = True
        '
        'chkbxLm
        '
        Me.chkbxLm.AutoSize = True
        Me.chkbxLm.Location = New System.Drawing.Point(777, 41)
        Me.chkbxLm.Name = "chkbxLm"
        Me.chkbxLm.Size = New System.Drawing.Size(15, 14)
        Me.chkbxLm.TabIndex = 34
        Me.chkbxLm.UseVisualStyleBackColor = True
        '
        'chkbxWidth
        '
        Me.chkbxWidth.AutoSize = True
        Me.chkbxWidth.Location = New System.Drawing.Point(777, 14)
        Me.chkbxWidth.Name = "chkbxWidth"
        Me.chkbxWidth.Size = New System.Drawing.Size(15, 14)
        Me.chkbxWidth.TabIndex = 33
        Me.chkbxWidth.UseVisualStyleBackColor = True
        '
        'btnNewUnit
        '
        Me.btnNewUnit.Location = New System.Drawing.Point(245, 64)
        Me.btnNewUnit.Name = "btnNewUnit"
        Me.btnNewUnit.Size = New System.Drawing.Size(75, 20)
        Me.btnNewUnit.TabIndex = 32
        Me.btnNewUnit.TabStop = False
        Me.btnNewUnit.Text = "New"
        Me.btnNewUnit.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(718, 460)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Ctrl + S"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(801, 460)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Ctrl + X"
        '
        'frmPurchaseNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(870, 500)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.pnlAddIteminPurchase)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnNewSupplier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbPurChallan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbPurSupplier)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TbPurBill)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.Name = "frmPurchaseNew"
        Me.Text = "Purchase_New"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddIteminPurchase.ResumeLayout(False)
        Me.pnlAddIteminPurchase.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPurChallan As TextBox
    Friend WithEvents TbPurSupplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbPurBill As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbPurItem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbPurQuantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbPurUnit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbPurRate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbPurWidth As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbPurLm As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbPurLa As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnNewSupplier As Button
    Friend WithEvents btnNewItem As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddItemtoPurchase As Button
    Friend WithEvents pnlAddIteminPurchase As Panel
    Friend WithEvents btnNewUnit As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ChkbxLa As CheckBox
    Friend WithEvents chkbxLm As CheckBox
    Friend WithEvents chkbxWidth As CheckBox
End Class
