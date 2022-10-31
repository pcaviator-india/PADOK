<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobWorkReceived
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvJobIssue = New System.Windows.Forms.DataGridView()
        Me.dgvItemissued = New System.Windows.Forms.DataGridView()
        Me.dgvItemReceived = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvJobIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItemissued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItemReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvJobIssue
        '
        Me.dgvJobIssue.AllowUserToAddRows = False
        Me.dgvJobIssue.AllowUserToDeleteRows = False
        Me.dgvJobIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobIssue.Location = New System.Drawing.Point(12, 12)
        Me.dgvJobIssue.Name = "dgvJobIssue"
        Me.dgvJobIssue.ReadOnly = True
        Me.dgvJobIssue.Size = New System.Drawing.Size(325, 364)
        Me.dgvJobIssue.TabIndex = 0
        '
        'dgvItemissued
        '
        Me.dgvItemissued.AllowUserToAddRows = False
        Me.dgvItemissued.AllowUserToDeleteRows = False
        Me.dgvItemissued.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemissued.Location = New System.Drawing.Point(343, 12)
        Me.dgvItemissued.Name = "dgvItemissued"
        Me.dgvItemissued.ReadOnly = True
        Me.dgvItemissued.Size = New System.Drawing.Size(439, 180)
        Me.dgvItemissued.TabIndex = 1
        '
        'dgvItemReceived
        '
        Me.dgvItemReceived.AllowUserToAddRows = False
        Me.dgvItemReceived.AllowUserToDeleteRows = False
        Me.dgvItemReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemReceived.Location = New System.Drawing.Point(788, 12)
        Me.dgvItemReceived.Name = "dgvItemReceived"
        Me.dgvItemReceived.ReadOnly = True
        Me.dgvItemReceived.Size = New System.Drawing.Size(484, 180)
        Me.dgvItemReceived.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(296, 408)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmJobWorkReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1258, 459)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvItemReceived)
        Me.Controls.Add(Me.dgvItemissued)
        Me.Controls.Add(Me.dgvJobIssue)
        Me.KeyPreview = True
        Me.Name = "frmJobWorkReceived"
        Me.Text = "frmJobWorkReceived"
        CType(Me.dgvJobIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItemissued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItemReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvJobIssue As DataGridView
    Friend WithEvents dgvItemissued As DataGridView
    Friend WithEvents dgvItemReceived As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnExit As Button
End Class
