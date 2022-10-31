<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCutting
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPurId = New System.Windows.Forms.TextBox()
        Me.dgvCutting = New System.Windows.Forms.DataGridView()
        Me.btAddRow = New System.Windows.Forms.Button()
        Me.btnNewItem = New System.Windows.Forms.Button()
        Me.btnDelRow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblTotalCut = New System.Windows.Forms.Label()
        Me.btnSelectPurId = New System.Windows.Forms.Button()
        Me.lblPurId = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCuttingId = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvCutting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(225, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pur Id"
        '
        'tbPurId
        '
        Me.tbPurId.Enabled = False
        Me.tbPurId.Location = New System.Drawing.Point(270, 12)
        Me.tbPurId.Name = "tbPurId"
        Me.tbPurId.Size = New System.Drawing.Size(55, 20)
        Me.tbPurId.TabIndex = 2
        '
        'dgvCutting
        '
        Me.dgvCutting.AllowUserToAddRows = False
        Me.dgvCutting.AllowUserToDeleteRows = False
        Me.dgvCutting.AllowUserToOrderColumns = True
        Me.dgvCutting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCutting.Location = New System.Drawing.Point(12, 72)
        Me.dgvCutting.Name = "dgvCutting"
        Me.dgvCutting.Size = New System.Drawing.Size(1201, 363)
        Me.dgvCutting.TabIndex = 3
        '
        'btAddRow
        '
        Me.btAddRow.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btAddRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddRow.Location = New System.Drawing.Point(885, 12)
        Me.btAddRow.Name = "btAddRow"
        Me.btAddRow.Size = New System.Drawing.Size(102, 50)
        Me.btAddRow.TabIndex = 4
        Me.btAddRow.Text = "Add Row Ctrl +"
        Me.btAddRow.UseVisualStyleBackColor = True
        '
        'btnNewItem
        '
        Me.btnNewItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewItem.Location = New System.Drawing.Point(12, 441)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(75, 75)
        Me.btnNewItem.TabIndex = 5
        Me.btnNewItem.Text = "New Item  Ctrl  I"
        Me.btnNewItem.UseVisualStyleBackColor = True
        '
        'btnDelRow
        '
        Me.btnDelRow.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelRow.Location = New System.Drawing.Point(997, 12)
        Me.btnDelRow.Name = "btnDelRow"
        Me.btnDelRow.Size = New System.Drawing.Size(100, 50)
        Me.btnDelRow.TabIndex = 4
        Me.btnDelRow.Text = "Delete Row Ctrl -"
        Me.btnDelRow.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(740, 441)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 75)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(654, 441)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 75)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblTotalCut
        '
        Me.lblTotalCut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCut.Location = New System.Drawing.Point(1103, 46)
        Me.lblTotalCut.Name = "lblTotalCut"
        Me.lblTotalCut.Size = New System.Drawing.Size(110, 23)
        Me.lblTotalCut.TabIndex = 8
        Me.lblTotalCut.Text = "0"
        Me.lblTotalCut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSelectPurId
        '
        Me.btnSelectPurId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectPurId.Location = New System.Drawing.Point(346, 12)
        Me.btnSelectPurId.Name = "btnSelectPurId"
        Me.btnSelectPurId.Size = New System.Drawing.Size(127, 50)
        Me.btnSelectPurId.TabIndex = 10
        Me.btnSelectPurId.Text = "Select Purchase ID"
        Me.btnSelectPurId.UseVisualStyleBackColor = True
        '
        'lblPurId
        '
        Me.lblPurId.AutoSize = True
        Me.lblPurId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurId.Location = New System.Drawing.Point(488, 29)
        Me.lblPurId.Name = "lblPurId"
        Me.lblPurId.Size = New System.Drawing.Size(16, 16)
        Me.lblPurId.TabIndex = 11
        Me.lblPurId.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(631, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cutting Id :"
        '
        'lblCuttingId
        '
        Me.lblCuttingId.AutoSize = True
        Me.lblCuttingId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuttingId.Location = New System.Drawing.Point(717, 13)
        Me.lblCuttingId.Name = "lblCuttingId"
        Me.lblCuttingId.Size = New System.Drawing.Size(19, 20)
        Me.lblCuttingId.TabIndex = 13
        Me.lblCuttingId.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(137, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "New Unit Ctrl  U"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCutting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1238, 528)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCuttingId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPurId)
        Me.Controls.Add(Me.btnSelectPurId)
        Me.Controls.Add(Me.lblTotalCut)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewItem)
        Me.Controls.Add(Me.btnDelRow)
        Me.Controls.Add(Me.btAddRow)
        Me.Controls.Add(Me.dgvCutting)
        Me.Controls.Add(Me.tbPurId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.KeyPreview = True
        Me.Name = "frmCutting"
        Me.Text = "frmCutting"
        CType(Me.dgvCutting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPurId As TextBox
    Friend WithEvents dgvCutting As DataGridView
    Friend WithEvents btAddRow As Button
    Friend WithEvents btnNewItem As Button
    Friend WithEvents btnDelRow As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblTotalCut As Label
    Friend WithEvents btnSelectPurId As Button
    Friend WithEvents lblPurId As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCuttingId As Label
    Friend WithEvents Button1 As Button
End Class
