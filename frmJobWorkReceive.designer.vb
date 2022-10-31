<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobWorkReceive
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbChNo = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lbJobworker = New System.Windows.Forms.Label()
        Me.lbPurId = New System.Windows.Forms.Label()
        Me.dgvItemreceived = New System.Windows.Forms.DataGridView()
        Me.dgvRawReceived = New System.Windows.Forms.DataGridView()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbIssueDate = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvItemreceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRawReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Challan No"
        '
        'tbChNo
        '
        Me.tbChNo.Location = New System.Drawing.Point(323, 12)
        Me.tbChNo.Name = "tbChNo"
        Me.tbChNo.Size = New System.Drawing.Size(100, 20)
        Me.tbChNo.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(441, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lbJobworker
        '
        Me.lbJobworker.AutoSize = True
        Me.lbJobworker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJobworker.Location = New System.Drawing.Point(326, 53)
        Me.lbJobworker.Name = "lbJobworker"
        Me.lbJobworker.Size = New System.Drawing.Size(103, 24)
        Me.lbJobworker.TabIndex = 4
        Me.lbJobworker.Text = "Job worker"
        '
        'lbPurId
        '
        Me.lbPurId.AutoSize = True
        Me.lbPurId.Location = New System.Drawing.Point(12, 61)
        Me.lbPurId.Name = "lbPurId"
        Me.lbPurId.Size = New System.Drawing.Size(66, 13)
        Me.lbPurId.TabIndex = 5
        Me.lbPurId.Text = "Purchase ID"
        '
        'dgvItemreceived
        '
        Me.dgvItemreceived.AllowUserToAddRows = False
        Me.dgvItemreceived.AllowUserToDeleteRows = False
        Me.dgvItemreceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemreceived.Location = New System.Drawing.Point(12, 137)
        Me.dgvItemreceived.Name = "dgvItemreceived"
        Me.dgvItemreceived.Size = New System.Drawing.Size(558, 271)
        Me.dgvItemreceived.TabIndex = 6
        '
        'dgvRawReceived
        '
        Me.dgvRawReceived.AllowUserToAddRows = False
        Me.dgvRawReceived.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRawReceived.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRawReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRawReceived.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRawReceived.Location = New System.Drawing.Point(591, 137)
        Me.dgvRawReceived.Name = "dgvRawReceived"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRawReceived.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRawReceived.Size = New System.Drawing.Size(558, 271)
        Me.dgvRawReceived.TabIndex = 7
        '
        'btnReceive
        '
        Me.btnReceive.Location = New System.Drawing.Point(419, 428)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(75, 23)
        Me.btnReceive.TabIndex = 8
        Me.btnReceive.Text = "Receive"
        Me.btnReceive.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(500, 428)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbIssueDate
        '
        Me.lbIssueDate.AutoSize = True
        Me.lbIssueDate.Location = New System.Drawing.Point(126, 61)
        Me.lbIssueDate.Name = "lbIssueDate"
        Me.lbIssueDate.Size = New System.Drawing.Size(58, 13)
        Me.lbIssueDate.TabIndex = 10
        Me.lbIssueDate.Text = "Issue Date"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 424)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Receive Without Work"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Item Received"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(587, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Raw Received"
        '
        'frmJobWorkReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1161, 463)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvItemreceived)
        Me.Controls.Add(Me.dgvRawReceived)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lbIssueDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReceive)
        Me.Controls.Add(Me.lbPurId)
        Me.Controls.Add(Me.lbJobworker)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.tbChNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.KeyPreview = True
        Me.Name = "frmJobWorkReceive"
        Me.Text = "frmJobWorkReceive"
        CType(Me.dgvItemreceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRawReceived, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tbChNo As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lbJobworker As Label
    Friend WithEvents lbPurId As Label
    Friend WithEvents dgvItemreceived As DataGridView
    Friend WithEvents dgvRawReceived As DataGridView
    Friend WithEvents btnReceive As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbIssueDate As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
