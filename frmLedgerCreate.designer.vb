<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLedgerCreate
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbgroup = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbLedger = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNewGroup = New System.Windows.Forms.Button()
        Me.btnNewCategory = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLedgerId = New System.Windows.Forms.Label()
        Me.lblgroupId = New System.Windows.Forms.Label()
        Me.lblCategoryId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(145, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbCategory
        '
        Me.tbCategory.Location = New System.Drawing.Point(119, 143)
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(272, 20)
        Me.tbCategory.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Category Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbgroup
        '
        Me.tbgroup.Location = New System.Drawing.Point(119, 105)
        Me.tbgroup.Name = "tbgroup"
        Me.tbgroup.Size = New System.Drawing.Size(272, 20)
        Me.tbgroup.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Group Name"
        '
        'tbLedger
        '
        Me.tbLedger.Location = New System.Drawing.Point(119, 67)
        Me.tbLedger.Name = "tbLedger"
        Me.tbLedger.Size = New System.Drawing.Size(272, 20)
        Me.tbLedger.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ledger Name"
        '
        'btnNewGroup
        '
        Me.btnNewGroup.Location = New System.Drawing.Point(448, 103)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(95, 23)
        Me.btnNewGroup.TabIndex = 16
        Me.btnNewGroup.Text = "New Group"
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'btnNewCategory
        '
        Me.btnNewCategory.Location = New System.Drawing.Point(448, 141)
        Me.btnNewCategory.Name = "btnNewCategory"
        Me.btnNewCategory.Size = New System.Drawing.Size(95, 23)
        Me.btnNewCategory.TabIndex = 17
        Me.btnNewCategory.Text = "New Category"
        Me.btnNewCategory.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Ledger Id"
        '
        'lblLedgerId
        '
        Me.lblLedgerId.AutoSize = True
        Me.lblLedgerId.Location = New System.Drawing.Point(116, 34)
        Me.lblLedgerId.Name = "lblLedgerId"
        Me.lblLedgerId.Size = New System.Drawing.Size(0, 13)
        Me.lblLedgerId.TabIndex = 19
        '
        'lblgroupId
        '
        Me.lblgroupId.AutoSize = True
        Me.lblgroupId.Location = New System.Drawing.Point(397, 108)
        Me.lblgroupId.Name = "lblgroupId"
        Me.lblgroupId.Size = New System.Drawing.Size(0, 13)
        Me.lblgroupId.TabIndex = 21
        '
        'lblCategoryId
        '
        Me.lblCategoryId.AutoSize = True
        Me.lblCategoryId.Location = New System.Drawing.Point(397, 146)
        Me.lblCategoryId.Name = "lblCategoryId"
        Me.lblCategoryId.Size = New System.Drawing.Size(0, 13)
        Me.lblCategoryId.TabIndex = 20
        '
        'frmLedgerCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(555, 279)
        Me.Controls.Add(Me.lblgroupId)
        Me.Controls.Add(Me.lblCategoryId)
        Me.Controls.Add(Me.lblLedgerId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnNewCategory)
        Me.Controls.Add(Me.btnNewGroup)
        Me.Controls.Add(Me.tbLedger)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbgroup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tbCategory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.Name = "frmLedgerCreate"
        Me.Text = "frmLedgerCreate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents tbCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tbgroup As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbLedger As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNewGroup As Button
    Friend WithEvents btnNewCategory As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblLedgerId As Label
    Friend WithEvents lblgroupId As Label
    Friend WithEvents lblCategoryId As Label
End Class
