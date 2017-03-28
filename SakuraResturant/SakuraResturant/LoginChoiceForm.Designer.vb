<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginChoiceForm
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
        Me.CustomerRadioButton = New System.Windows.Forms.RadioButton()
        Me.EmployeeRadioButton = New System.Windows.Forms.RadioButton()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CustomerRadioButton
        '
        Me.CustomerRadioButton.AutoSize = True
        Me.CustomerRadioButton.Location = New System.Drawing.Point(72, 91)
        Me.CustomerRadioButton.Name = "CustomerRadioButton"
        Me.CustomerRadioButton.Size = New System.Drawing.Size(124, 19)
        Me.CustomerRadioButton.TabIndex = 1
        Me.CustomerRadioButton.Text = "Login as &Customer"
        Me.CustomerRadioButton.UseVisualStyleBackColor = True
        '
        'EmployeeRadioButton
        '
        Me.EmployeeRadioButton.AutoSize = True
        Me.EmployeeRadioButton.Checked = True
        Me.EmployeeRadioButton.Location = New System.Drawing.Point(72, 57)
        Me.EmployeeRadioButton.Name = "EmployeeRadioButton"
        Me.EmployeeRadioButton.Size = New System.Drawing.Size(124, 19)
        Me.EmployeeRadioButton.TabIndex = 0
        Me.EmployeeRadioButton.TabStop = True
        Me.EmployeeRadioButton.Text = "Login as &Employee"
        Me.EmployeeRadioButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(176, 160)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(83, 160)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'LoginChoiceForm
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(297, 213)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EmployeeRadioButton)
        Me.Controls.Add(Me.CustomerRadioButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginChoiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Login As"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerRadioButton As RadioButton
    Friend WithEvents EmployeeRadioButton As RadioButton
    Friend Shadows WithEvents CancelButton As Button
    Friend WithEvents OKButton As Button
End Class
