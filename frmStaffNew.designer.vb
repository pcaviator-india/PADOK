<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaffSalary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbStaff = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSalaryId = New System.Windows.Forms.Label()
        Me.lblLedgerId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'tbStaff
        '
        Me.tbStaff.Location = New System.Drawing.Point(84, 101)
        Me.tbStaff.Name = "tbStaff"
        Me.tbStaff.Size = New System.Drawing.Size(200, 20)
        Me.tbStaff.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(198, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(117, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Add Staff Member's Salary"
        '
        'tbSalary
        '
        Me.tbSalary.Location = New System.Drawing.Point(84, 143)
        Me.tbSalary.Name = "tbSalary"
        Me.tbSalary.Size = New System.Drawing.Size(131, 20)
        Me.tbSalary.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Salary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Salary Id"
        '
        'lblSalaryId
        '
        Me.lblSalaryId.AutoSize = True
        Me.lblSalaryId.Location = New System.Drawing.Point(87, 70)
        Me.lblSalaryId.Name = "lblSalaryId"
        Me.lblSalaryId.Size = New System.Drawing.Size(0, 13)
        Me.lblSalaryId.TabIndex = 8
        '
        'lblLedgerId
        '
        Me.lblLedgerId.AutoSize = True
        Me.lblLedgerId.Location = New System.Drawing.Point(290, 104)
        Me.lblLedgerId.Name = "lblLedgerId"
        Me.lblLedgerId.Size = New System.Drawing.Size(0, 13)
        Me.lblLedgerId.TabIndex = 9
        '
        'frmStaffSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(392, 321)
        Me.Controls.Add(Me.lblLedgerId)
        Me.Controls.Add(Me.lblSalaryId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbSalary)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbStaff)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "frmStaffSalary"
        Me.Text = "Staff - Salary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbStaff As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSalary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSalaryId As Label
    Friend WithEvents lblLedgerId As Label
End Class
