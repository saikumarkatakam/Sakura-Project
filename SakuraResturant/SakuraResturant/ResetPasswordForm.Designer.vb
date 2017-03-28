<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPasswordForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordMatchLabel = New System.Windows.Forms.Label()
        Me.EmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.TempPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ResetPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ResetPasswordButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ResetPasswordGroupBox = New System.Windows.Forms.GroupBox()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.ResetPasswordGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(124, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email ID "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(60, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temporary Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(36, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(20, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirm Password"
        '
        'PasswordMatchLabel
        '
        Me.PasswordMatchLabel.AutoSize = True
        Me.PasswordMatchLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PasswordMatchLabel.Location = New System.Drawing.Point(138, 99)
        Me.PasswordMatchLabel.Name = "PasswordMatchLabel"
        Me.PasswordMatchLabel.Size = New System.Drawing.Size(137, 15)
        Me.PasswordMatchLabel.TabIndex = 4
        Me.PasswordMatchLabel.Text = "Passwords do not match"
        '
        'EmailIDTextBox
        '
        Me.EmailIDTextBox.Location = New System.Drawing.Point(194, 36)
        Me.EmailIDTextBox.MaxLength = 50
        Me.EmailIDTextBox.Name = "EmailIDTextBox"
        Me.EmailIDTextBox.Size = New System.Drawing.Size(255, 23)
        Me.EmailIDTextBox.TabIndex = 0
        '
        'TempPasswordTextBox
        '
        Me.TempPasswordTextBox.Location = New System.Drawing.Point(194, 69)
        Me.TempPasswordTextBox.MaxLength = 13
        Me.TempPasswordTextBox.Name = "TempPasswordTextBox"
        Me.TempPasswordTextBox.Size = New System.Drawing.Size(83, 23)
        Me.TempPasswordTextBox.TabIndex = 1
        '
        'ResetPasswordTextBox
        '
        Me.ResetPasswordTextBox.Location = New System.Drawing.Point(141, 34)
        Me.ResetPasswordTextBox.MaxLength = 45
        Me.ResetPasswordTextBox.Name = "ResetPasswordTextBox"
        Me.ResetPasswordTextBox.Size = New System.Drawing.Size(226, 23)
        Me.ResetPasswordTextBox.TabIndex = 0
        Me.ResetPasswordTextBox.UseSystemPasswordChar = True
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(141, 64)
        Me.ConfirmPasswordTextBox.MaxLength = 45
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(226, 23)
        Me.ConfirmPasswordTextBox.TabIndex = 1
        Me.ConfirmPasswordTextBox.UseSystemPasswordChar = True
        '
        'ResetPasswordButton
        '
        Me.ResetPasswordButton.Location = New System.Drawing.Point(194, 98)
        Me.ResetPasswordButton.Name = "ResetPasswordButton"
        Me.ResetPasswordButton.Size = New System.Drawing.Size(114, 23)
        Me.ResetPasswordButton.TabIndex = 2
        Me.ResetPasswordButton.Text = "&Reset Password"
        Me.ResetPasswordButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(374, 304)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(84, 23)
        Me.CancelButton.TabIndex = 5
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ResetPasswordGroupBox
        '
        Me.ResetPasswordGroupBox.Controls.Add(Me.Label3)
        Me.ResetPasswordGroupBox.Controls.Add(Me.Label4)
        Me.ResetPasswordGroupBox.Controls.Add(Me.PasswordMatchLabel)
        Me.ResetPasswordGroupBox.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.ResetPasswordGroupBox.Controls.Add(Me.ResetPasswordTextBox)
        Me.ResetPasswordGroupBox.Location = New System.Drawing.Point(63, 145)
        Me.ResetPasswordGroupBox.Name = "ResetPasswordGroupBox"
        Me.ResetPasswordGroupBox.Size = New System.Drawing.Size(395, 137)
        Me.ResetPasswordGroupBox.TabIndex = 3
        Me.ResetPasswordGroupBox.TabStop = False
        Me.ResetPasswordGroupBox.Visible = False
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(274, 304)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(84, 23)
        Me.ConfirmButton.TabIndex = 4
        Me.ConfirmButton.Text = "C&onfirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'ResetPasswordForm
        '
        Me.AcceptButton = Me.ResetPasswordButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(508, 354)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.ResetPasswordGroupBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ResetPasswordButton)
        Me.Controls.Add(Me.TempPasswordTextBox)
        Me.Controls.Add(Me.EmailIDTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ResetPasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Password Reset"
        Me.ResetPasswordGroupBox.ResumeLayout(False)
        Me.ResetPasswordGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordMatchLabel As Label
    Friend WithEvents EmailIDTextBox As TextBox
    Friend WithEvents TempPasswordTextBox As TextBox
    Friend WithEvents ResetPasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents ResetPasswordButton As Button
    Friend Shadows WithEvents CancelButton As Button
    Friend WithEvents ResetPasswordGroupBox As GroupBox
    Friend WithEvents ConfirmButton As Button
End Class
