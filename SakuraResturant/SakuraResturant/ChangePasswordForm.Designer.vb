<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Me.CurrentPwdTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmNewPwdTextBox = New System.Windows.Forms.TextBox()
        Me.NewPwdTextBox = New System.Windows.Forms.TextBox()
        Me.ResetPwdLabel = New System.Windows.Forms.Label()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm New Password:"
        '
        'CurrentPwdTextBox
        '
        Me.CurrentPwdTextBox.AcceptsTab = True
        Me.CurrentPwdTextBox.Location = New System.Drawing.Point(193, 80)
        Me.CurrentPwdTextBox.MaxLength = 45
        Me.CurrentPwdTextBox.Name = "CurrentPwdTextBox"
        Me.CurrentPwdTextBox.Size = New System.Drawing.Size(169, 23)
        Me.CurrentPwdTextBox.TabIndex = 0
        '
        'ConfirmNewPwdTextBox
        '
        Me.ConfirmNewPwdTextBox.AcceptsTab = True
        Me.ConfirmNewPwdTextBox.Location = New System.Drawing.Point(193, 162)
        Me.ConfirmNewPwdTextBox.MaxLength = 45
        Me.ConfirmNewPwdTextBox.Name = "ConfirmNewPwdTextBox"
        Me.ConfirmNewPwdTextBox.Size = New System.Drawing.Size(169, 23)
        Me.ConfirmNewPwdTextBox.TabIndex = 2
        '
        'NewPwdTextBox
        '
        Me.NewPwdTextBox.AcceptsTab = True
        Me.NewPwdTextBox.Location = New System.Drawing.Point(193, 120)
        Me.NewPwdTextBox.MaxLength = 45
        Me.NewPwdTextBox.Name = "NewPwdTextBox"
        Me.NewPwdTextBox.Size = New System.Drawing.Size(169, 23)
        Me.NewPwdTextBox.TabIndex = 1
        '
        'ResetPwdLabel
        '
        Me.ResetPwdLabel.AutoSize = True
        Me.ResetPwdLabel.Location = New System.Drawing.Point(193, 207)
        Me.ResetPwdLabel.Name = "ResetPwdLabel"
        Me.ResetPwdLabel.Size = New System.Drawing.Size(137, 15)
        Me.ResetPwdLabel.TabIndex = 6
        Me.ResetPwdLabel.Text = "Passwords do not match"
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(140, 254)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(75, 23)
        Me.ChangeButton.TabIndex = 3
        Me.ChangeButton.Text = "&Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(241, 254)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 4
        Me.CancelButton.Text = "C&ancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ChangePasswordForm
        '
        Me.AcceptButton = Me.ChangeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(450, 307)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.ResetPwdLabel)
        Me.Controls.Add(Me.NewPwdTextBox)
        Me.Controls.Add(Me.ConfirmNewPwdTextBox)
        Me.Controls.Add(Me.CurrentPwdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ChangePasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CurrentPwdTextBox As TextBox
    Friend WithEvents ConfirmNewPwdTextBox As TextBox
    Friend WithEvents NewPwdTextBox As TextBox
    Friend WithEvents ResetPwdLabel As Label
    Friend WithEvents ChangeButton As Button
    Friend WithEvents CancelButton As Button
End Class
