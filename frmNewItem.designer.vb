<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewItem
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
        Me.tbNewitem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbCloth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbClothModel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbItem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbItemModel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbSize = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbNewitem
        '
        Me.tbNewitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbNewitem.Location = New System.Drawing.Point(580, 28)
        Me.tbNewitem.Name = "tbNewitem"
        Me.tbNewitem.Size = New System.Drawing.Size(479, 20)
        Me.tbNewitem.TabIndex = 5
        Me.tbNewitem.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Item Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(585, 248)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 20)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(771, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 20)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(504, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(555, 150)
        Me.DataGridView1.TabIndex = 22
        Me.DataGridView1.TabStop = False
        '
        'tbCloth
        '
        Me.tbCloth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbCloth.Location = New System.Drawing.Point(108, 28)
        Me.tbCloth.Name = "tbCloth"
        Me.tbCloth.Size = New System.Drawing.Size(118, 20)
        Me.tbCloth.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Cloth"
        '
        'tbClothModel
        '
        Me.tbClothModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbClothModel.Location = New System.Drawing.Point(108, 54)
        Me.tbClothModel.Name = "tbClothModel"
        Me.tbClothModel.Size = New System.Drawing.Size(118, 20)
        Me.tbClothModel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Cloth Model"
        '
        'tbItem
        '
        Me.tbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbItem.Location = New System.Drawing.Point(108, 80)
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Size = New System.Drawing.Size(118, 20)
        Me.tbItem.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Item"
        '
        'tbItemModel
        '
        Me.tbItemModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbItemModel.Location = New System.Drawing.Point(108, 106)
        Me.tbItemModel.Name = "tbItemModel"
        Me.tbItemModel.Size = New System.Drawing.Size(118, 20)
        Me.tbItemModel.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Item Model"
        '
        'tbSize
        '
        Me.tbSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbSize.Location = New System.Drawing.Point(108, 132)
        Me.tbSize.Name = "tbSize"
        Me.tbSize.Size = New System.Drawing.Size(118, 20)
        Me.tbSize.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Size"
        '
        'tbDesc
        '
        Me.tbDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbDesc.Location = New System.Drawing.Point(108, 158)
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.Size = New System.Drawing.Size(282, 20)
        Me.tbDesc.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Description"
        '
        'frmNewItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1071, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbDesc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbSize)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbItemModel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbClothModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCloth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbNewitem)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmNewItem"
        Me.Text = "Item - New"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNewitem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbCloth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbClothModel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbItem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbItemModel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbSize As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents Label7 As Label
End Class
