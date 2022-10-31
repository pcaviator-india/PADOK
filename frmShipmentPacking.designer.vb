<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShipmentPacking
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
        Me.tbTempBoxNo = New System.Windows.Forms.TextBox()
        Me.tbItem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUnit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSizeW = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbSizeL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbWeightPc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbWeightBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbSizeH = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvShipmentDetail = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbShipmentNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbbxPurid = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvShipmentDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Temp Box No"
        '
        'tbTempBoxNo
        '
        Me.tbTempBoxNo.Location = New System.Drawing.Point(127, 49)
        Me.tbTempBoxNo.Name = "tbTempBoxNo"
        Me.tbTempBoxNo.Size = New System.Drawing.Size(80, 20)
        Me.tbTempBoxNo.TabIndex = 2
        '
        'tbItem
        '
        Me.tbItem.Location = New System.Drawing.Point(127, 75)
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Size = New System.Drawing.Size(170, 20)
        Me.tbItem.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Name"
        '
        'tbUnit
        '
        Me.tbUnit.Location = New System.Drawing.Point(425, 49)
        Me.tbUnit.Name = "tbUnit"
        Me.tbUnit.Size = New System.Drawing.Size(84, 20)
        Me.tbUnit.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unit"
        '
        'tbQuantity
        '
        Me.tbQuantity.Location = New System.Drawing.Point(127, 101)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(80, 20)
        Me.tbQuantity.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quantity"
        '
        'tbSizeW
        '
        Me.tbSizeW.Location = New System.Drawing.Point(592, 75)
        Me.tbSizeW.Name = "tbSizeW"
        Me.tbSizeW.Size = New System.Drawing.Size(90, 20)
        Me.tbSizeW.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(536, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Box W"
        '
        'tbSizeL
        '
        Me.tbSizeL.Location = New System.Drawing.Point(592, 49)
        Me.tbSizeL.Name = "tbSizeL"
        Me.tbSizeL.Size = New System.Drawing.Size(90, 20)
        Me.tbSizeL.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(536, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Box L"
        '
        'tbWeightPc
        '
        Me.tbWeightPc.Location = New System.Drawing.Point(425, 101)
        Me.tbWeightPc.Name = "tbWeightPc"
        Me.tbWeightPc.Size = New System.Drawing.Size(84, 20)
        Me.tbWeightPc.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(310, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Weight Peice (Kg)"
        '
        'tbWeightBox
        '
        Me.tbWeightBox.Location = New System.Drawing.Point(425, 75)
        Me.tbWeightBox.Name = "tbWeightBox"
        Me.tbWeightBox.Size = New System.Drawing.Size(84, 20)
        Me.tbWeightBox.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(310, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Weight Box (Kg)"
        '
        'tbSizeH
        '
        Me.tbSizeH.Location = New System.Drawing.Point(592, 101)
        Me.tbSizeH.Name = "tbSizeH"
        Me.tbSizeH.Size = New System.Drawing.Size(90, 20)
        Me.tbSizeH.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(536, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Box H"
        '
        'dgvShipmentDetail
        '
        Me.dgvShipmentDetail.AllowUserToAddRows = False
        Me.dgvShipmentDetail.AllowUserToDeleteRows = False
        Me.dgvShipmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShipmentDetail.Location = New System.Drawing.Point(12, 127)
        Me.dgvShipmentDetail.Name = "dgvShipmentDetail"
        Me.dgvShipmentDetail.ReadOnly = True
        Me.dgvShipmentDetail.Size = New System.Drawing.Size(1000, 327)
        Me.dgvShipmentDetail.TabIndex = 18
        Me.dgvShipmentDetail.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(696, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbShipmentNo
        '
        Me.tbShipmentNo.Location = New System.Drawing.Point(127, 18)
        Me.tbShipmentNo.Name = "tbShipmentNo"
        Me.tbShipmentNo.Size = New System.Drawing.Size(80, 20)
        Me.tbShipmentNo.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Shipment No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(310, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Purchase ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(213, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.TabStop = False
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbbxPurid
        '
        Me.cmbbxPurid.FormattingEnabled = True
        Me.cmbbxPurid.Location = New System.Drawing.Point(425, 14)
        Me.cmbbxPurid.Name = "cmbbxPurid"
        Me.cmbbxPurid.Size = New System.Drawing.Size(84, 21)
        Me.cmbbxPurid.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(789, 471)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(885, 22)
        Me.StatusStrip1.TabIndex = 26
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'frmShipmentPacking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(885, 526)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbbxPurid)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbShipmentNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvShipmentDetail)
        Me.Controls.Add(Me.tbSizeH)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbSizeW)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbSizeL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbWeightPc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbWeightBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbUnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTempBoxNo)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "frmShipmentPacking"
        Me.Text = "frmShipmentPacking"
        CType(Me.dgvShipmentDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbTempBoxNo As TextBox
    Friend WithEvents tbItem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUnit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbSizeW As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbSizeL As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbWeightPc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbWeightBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbSizeH As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvShipmentDetail As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents tbShipmentNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbbxPurid As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
