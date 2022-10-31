<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewJobWork
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
        Me.dgvJobWorkList = New System.Windows.Forms.DataGridView()
        Me.dgvSelectedJobWorkIssue = New System.Windows.Forms.DataGridView()
        Me.dgvSelectedJobWorkReceive = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvJobWorkList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSelectedJobWorkIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSelectedJobWorkReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvJobWorkList
        '
        Me.dgvJobWorkList.AllowUserToAddRows = False
        Me.dgvJobWorkList.AllowUserToDeleteRows = False
        Me.dgvJobWorkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobWorkList.Location = New System.Drawing.Point(12, 33)
        Me.dgvJobWorkList.Name = "dgvJobWorkList"
        Me.dgvJobWorkList.ReadOnly = True
        Me.dgvJobWorkList.Size = New System.Drawing.Size(359, 417)
        Me.dgvJobWorkList.TabIndex = 0
        '
        'dgvSelectedJobWorkIssue
        '
        Me.dgvSelectedJobWorkIssue.AllowUserToAddRows = False
        Me.dgvSelectedJobWorkIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelectedJobWorkIssue.Location = New System.Drawing.Point(377, 33)
        Me.dgvSelectedJobWorkIssue.Name = "dgvSelectedJobWorkIssue"
        Me.dgvSelectedJobWorkIssue.ReadOnly = True
        Me.dgvSelectedJobWorkIssue.Size = New System.Drawing.Size(381, 195)
        Me.dgvSelectedJobWorkIssue.TabIndex = 1
        '
        'dgvSelectedJobWorkReceive
        '
        Me.dgvSelectedJobWorkReceive.AllowUserToAddRows = False
        Me.dgvSelectedJobWorkReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelectedJobWorkReceive.Location = New System.Drawing.Point(377, 259)
        Me.dgvSelectedJobWorkReceive.Name = "dgvSelectedJobWorkReceive"
        Me.dgvSelectedJobWorkReceive.ReadOnly = True
        Me.dgvSelectedJobWorkReceive.Size = New System.Drawing.Size(381, 191)
        Me.dgvSelectedJobWorkReceive.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1183, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(782, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(381, 195)
        Me.DataGridView1.TabIndex = 4
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(782, 259)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(381, 191)
        Me.DataGridView2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Raw Issued"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(777, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Raw Received"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(377, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Finished To Receive"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(777, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Finished Received"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Challan"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(1050, 463)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmViewJobWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1354, 512)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSelectedJobWorkReceive)
        Me.Controls.Add(Me.dgvSelectedJobWorkIssue)
        Me.Controls.Add(Me.dgvJobWorkList)
        Me.KeyPreview = True
        Me.Name = "frmViewJobWork"
        Me.Text = "JobWork - View"
        CType(Me.dgvJobWorkList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSelectedJobWorkIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSelectedJobWorkReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvJobWorkList As DataGridView
    Friend WithEvents dgvSelectedJobWorkIssue As DataGridView
    Friend WithEvents dgvSelectedJobWorkReceive As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As Button
End Class
