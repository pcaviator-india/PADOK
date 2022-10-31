<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLedgerEdit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLedgerId = New System.Windows.Forms.TextBox()
        Me.tbLedgerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbGroup = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblCategoryId = New System.Windows.Forms.Label()
        Me.lblGroupId = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(267, 300)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ledger Id"
        '
        'tbLedgerId
        '
        Me.tbLedgerId.Location = New System.Drawing.Point(387, 94)
        Me.tbLedgerId.Name = "tbLedgerId"
        Me.tbLedgerId.Size = New System.Drawing.Size(191, 20)
        Me.tbLedgerId.TabIndex = 2
        '
        'tbLedgerName
        '
        Me.tbLedgerName.Location = New System.Drawing.Point(387, 132)
        Me.tbLedgerName.Name = "tbLedgerName"
        Me.tbLedgerName.Size = New System.Drawing.Size(191, 20)
        Me.tbLedgerName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ledger Name"
        '
        'tbGroup
        '
        Me.tbGroup.Location = New System.Drawing.Point(387, 170)
        Me.tbGroup.Name = "tbGroup"
        Me.tbGroup.Size = New System.Drawing.Size(191, 20)
        Me.tbGroup.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Group"
        '
        'tbCategory
        '
        Me.tbCategory.Location = New System.Drawing.Point(387, 206)
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(191, 20)
        Me.tbCategory.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Category"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(521, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(420, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(319, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblCategoryId
        '
        Me.lblCategoryId.AutoSize = True
        Me.lblCategoryId.Location = New System.Drawing.Point(584, 209)
        Me.lblCategoryId.Name = "lblCategoryId"
        Me.lblCategoryId.Size = New System.Drawing.Size(13, 13)
        Me.lblCategoryId.TabIndex = 13
        Me.lblCategoryId.Text = "0"
        '
        'lblGroupId
        '
        Me.lblGroupId.AutoSize = True
        Me.lblGroupId.Location = New System.Drawing.Point(584, 173)
        Me.lblGroupId.Name = "lblGroupId"
        Me.lblGroupId.Size = New System.Drawing.Size(13, 13)
        Me.lblGroupId.TabIndex = 12
        Me.lblGroupId.Text = "0"
        '
        'frmLedgerEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(644, 397)
        Me.Controls.Add(Me.lblCategoryId)
        Me.Controls.Add(Me.lblGroupId)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbGroup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbLedgerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbLedgerId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "frmLedgerEdit"
        Me.Text = "frmLedgerEdit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbLedgerId As TextBox
    Friend WithEvents tbLedgerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbGroup As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCategory As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblCategoryId As Label
    Friend WithEvents lblGroupId As Label
End Class
