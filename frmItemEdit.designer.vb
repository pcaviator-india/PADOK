<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemEdit
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCloth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbClothModel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbItem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbItemModel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSize = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbDesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(894, 265)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'tbId
        '
        Me.tbId.Enabled = False
        Me.tbId.Location = New System.Drawing.Point(83, 12)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(118, 20)
        Me.tbId.TabIndex = 2
        Me.tbId.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(831, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(831, 47)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(831, 84)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cloth"
        '
        'tbCloth
        '
        Me.tbCloth.Location = New System.Drawing.Point(83, 47)
        Me.tbCloth.Name = "tbCloth"
        Me.tbCloth.Size = New System.Drawing.Size(243, 20)
        Me.tbCloth.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cloth Model"
        '
        'tbClothModel
        '
        Me.tbClothModel.Location = New System.Drawing.Point(83, 84)
        Me.tbClothModel.Name = "tbClothModel"
        Me.tbClothModel.Size = New System.Drawing.Size(243, 20)
        Me.tbClothModel.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Item"
        '
        'tbItem
        '
        Me.tbItem.Location = New System.Drawing.Point(83, 119)
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Size = New System.Drawing.Size(222, 20)
        Me.tbItem.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Item Model"
        '
        'tbItemModel
        '
        Me.tbItemModel.Location = New System.Drawing.Point(428, 12)
        Me.tbItemModel.Name = "tbItemModel"
        Me.tbItemModel.Size = New System.Drawing.Size(222, 20)
        Me.tbItemModel.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(359, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Size"
        '
        'tbSize
        '
        Me.tbSize.Location = New System.Drawing.Point(428, 49)
        Me.tbSize.Name = "tbSize"
        Me.tbSize.Size = New System.Drawing.Size(222, 20)
        Me.tbSize.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Desc"
        '
        'tbDesc
        '
        Me.tbDesc.Location = New System.Drawing.Point(428, 86)
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.Size = New System.Drawing.Size(267, 20)
        Me.tbDesc.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Full Name"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Location = New System.Drawing.Point(425, 126)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(0, 13)
        Me.lblFullname.TabIndex = 23
        '
        'frmItemEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1008, 444)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbDesc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbItemModel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbClothModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCloth)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "frmItemEdit"
        Me.Text = "frmItemEdit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCloth As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbClothModel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbItem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbItemModel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbSize As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFullname As Label
End Class
