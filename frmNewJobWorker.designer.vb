<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewJobWorker
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
        Me.lbJobWorker = New System.Windows.Forms.Label()
        Me.tbnewJobWorker = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNewGroup = New System.Windows.Forms.Button()
        Me.btnNewCategory = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbJobWorker
        '
        Me.lbJobWorker.AutoSize = True
        Me.lbJobWorker.Location = New System.Drawing.Point(23, 68)
        Me.lbJobWorker.Name = "lbJobWorker"
        Me.lbJobWorker.Size = New System.Drawing.Size(59, 13)
        Me.lbJobWorker.TabIndex = 0
        Me.lbJobWorker.Text = "Job Woker"
        '
        'tbnewJobWorker
        '
        Me.tbnewJobWorker.Location = New System.Drawing.Point(88, 65)
        Me.tbnewJobWorker.Name = "tbnewJobWorker"
        Me.tbnewJobWorker.Size = New System.Drawing.Size(233, 20)
        Me.tbnewJobWorker.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(110, 172)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(205, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(407, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(312, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Group"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(86, 136)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(233, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Category"
        '
        'btnNewGroup
        '
        Me.btnNewGroup.Location = New System.Drawing.Point(326, 98)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGroup.TabIndex = 9
        Me.btnNewGroup.Text = "New"
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'btnNewCategory
        '
        Me.btnNewCategory.Location = New System.Drawing.Point(326, 133)
        Me.btnNewCategory.Name = "btnNewCategory"
        Me.btnNewCategory.Size = New System.Drawing.Size(75, 23)
        Me.btnNewCategory.TabIndex = 10
        Me.btnNewCategory.Text = "New"
        Me.btnNewCategory.UseVisualStyleBackColor = True
        '
        'frmNewJobWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(732, 231)
        Me.Controls.Add(Me.btnNewCategory)
        Me.Controls.Add(Me.btnNewGroup)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbnewJobWorker)
        Me.Controls.Add(Me.lbJobWorker)
        Me.KeyPreview = True
        Me.Name = "frmNewJobWorker"
        Me.Text = "frmNewJobWorker"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbJobWorker As Label
    Friend WithEvents tbnewJobWorker As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNewGroup As Button
    Friend WithEvents btnNewCategory As Button
End Class
