<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseEditDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblChallanNO = New System.Windows.Forms.Label()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbChallanNo = New System.Windows.Forms.TextBox()
        Me.tbBillNo = New System.Windows.Forms.TextBox()
        Me.tbSupplier = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblPurId = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(918, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblChallanNO
        '
        Me.lblChallanNO.AutoSize = True
        Me.lblChallanNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChallanNO.Location = New System.Drawing.Point(328, 21)
        Me.lblChallanNO.Name = "lblChallanNO"
        Me.lblChallanNO.Size = New System.Drawing.Size(82, 16)
        Me.lblChallanNO.TabIndex = 2
        Me.lblChallanNO.Text = "ChallanNO"
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.Location = New System.Drawing.Point(441, 21)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(50, 16)
        Me.lblBillNo.TabIndex = 3
        Me.lblBillNo.Text = "BillNo"
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(559, 21)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(62, 16)
        Me.lblSupplier.TabIndex = 4
        Me.lblSupplier.Text = "Suppler"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(981, 375)
        Me.DataGridView1.TabIndex = 5
        '
        'tbChallanNo
        '
        Me.tbChallanNo.Location = New System.Drawing.Point(331, 40)
        Me.tbChallanNo.Name = "tbChallanNo"
        Me.tbChallanNo.Size = New System.Drawing.Size(100, 20)
        Me.tbChallanNo.TabIndex = 6
        '
        'tbBillNo
        '
        Me.tbBillNo.Location = New System.Drawing.Point(444, 40)
        Me.tbBillNo.Name = "tbBillNo"
        Me.tbBillNo.Size = New System.Drawing.Size(100, 20)
        Me.tbBillNo.TabIndex = 7
        '
        'tbSupplier
        '
        Me.tbSupplier.Location = New System.Drawing.Point(562, 40)
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.Size = New System.Drawing.Size(197, 20)
        Me.tbSupplier.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'lblPurId
        '
        Me.lblPurId.AutoSize = True
        Me.lblPurId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurId.Location = New System.Drawing.Point(24, 26)
        Me.lblPurId.Name = "lblPurId"
        Me.lblPurId.Size = New System.Drawing.Size(44, 16)
        Me.lblPurId.TabIndex = 0
        Me.lblPurId.Text = "PurId"
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Location = New System.Drawing.Point(825, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 75)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmPurchaseEditDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(1005, 480)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSupplier)
        Me.Controls.Add(Me.tbBillNo)
        Me.Controls.Add(Me.tbChallanNo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.lblBillNo)
        Me.Controls.Add(Me.lblChallanNO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPurId)
        Me.KeyPreview = True
        Me.Name = "frmPurchaseEditDetail"
        Me.Text = "frmPurchaseEditDetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents lblChallanNO As Label
    Friend WithEvents lblBillNo As Label
    Friend WithEvents lblSupplier As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbChallanNo As TextBox
    Friend WithEvents tbBillNo As TextBox
    Friend WithEvents tbSupplier As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblPurId As Label
    Friend WithEvents btnSave As Button
End Class
