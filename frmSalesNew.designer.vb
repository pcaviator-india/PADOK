<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesNew
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
        Me.dgvShipmentDetail = New System.Windows.Forms.DataGridView()
        Me.btnCreateInvoice = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvShipmentDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvShipmentDetail
        '
        Me.dgvShipmentDetail.AllowUserToAddRows = False
        Me.dgvShipmentDetail.AllowUserToDeleteRows = False
        Me.dgvShipmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShipmentDetail.Location = New System.Drawing.Point(12, 60)
        Me.dgvShipmentDetail.Name = "dgvShipmentDetail"
        Me.dgvShipmentDetail.Size = New System.Drawing.Size(1135, 347)
        Me.dgvShipmentDetail.TabIndex = 1
        '
        'btnCreateInvoice
        '
        Me.btnCreateInvoice.Location = New System.Drawing.Point(733, 425)
        Me.btnCreateInvoice.Name = "btnCreateInvoice"
        Me.btnCreateInvoice.Size = New System.Drawing.Size(151, 23)
        Me.btnCreateInvoice.TabIndex = 2
        Me.btnCreateInvoice.Text = "Create Invoice"
        Me.btnCreateInvoice.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Items to Add to Invoice"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(546, 425)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSalesNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(896, 467)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateInvoice)
        Me.Controls.Add(Me.dgvShipmentDetail)
        Me.KeyPreview = True
        Me.Name = "frmSalesNew"
        Me.Text = "frmSalesNew"
        CType(Me.dgvShipmentDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvShipmentDetail As DataGridView
    Friend WithEvents btnCreateInvoice As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class
