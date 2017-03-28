<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDiscountForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiscountIDTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountValueTextBox = New System.Windows.Forms.TextBox()
        Me.ValidFromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValidToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discount ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Discount Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Discount Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valid From"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valid To"
        '
        'DiscountIDTextBox
        '
        Me.DiscountIDTextBox.Location = New System.Drawing.Point(193, 44)
        Me.DiscountIDTextBox.Name = "DiscountIDTextBox"
        Me.DiscountIDTextBox.ReadOnly = True
        Me.DiscountIDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.DiscountIDTextBox.TabIndex = 0
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(193, 75)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(225, 23)
        Me.DescriptionTextBox.TabIndex = 1
        '
        'DiscountValueTextBox
        '
        Me.DiscountValueTextBox.Location = New System.Drawing.Point(193, 106)
        Me.DiscountValueTextBox.Name = "DiscountValueTextBox"
        Me.DiscountValueTextBox.Size = New System.Drawing.Size(65, 23)
        Me.DiscountValueTextBox.TabIndex = 2
        '
        'ValidFromDateTimePicker
        '
        Me.ValidFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ValidFromDateTimePicker.Location = New System.Drawing.Point(193, 135)
        Me.ValidFromDateTimePicker.Name = "ValidFromDateTimePicker"
        Me.ValidFromDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.ValidFromDateTimePicker.TabIndex = 3
        '
        'ValidToDateTimePicker
        '
        Me.ValidToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ValidToDateTimePicker.Location = New System.Drawing.Point(193, 165)
        Me.ValidToDateTimePicker.Name = "ValidToDateTimePicker"
        Me.ValidToDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.ValidToDateTimePicker.TabIndex = 4
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(138, 242)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(241, 242)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'UpdateDiscountForm
        '
        Me.AcceptButton = Me.UpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(442, 312)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ValidToDateTimePicker)
        Me.Controls.Add(Me.ValidFromDateTimePicker)
        Me.Controls.Add(Me.DiscountValueTextBox)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.DiscountIDTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UpdateDiscountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Update Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DiscountIDTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents DiscountValueTextBox As TextBox
    Friend WithEvents ValidFromDateTimePicker As DateTimePicker
    Friend WithEvents ValidToDateTimePicker As DateTimePicker
    Friend WithEvents UpdateButton As Button
    Friend WithEvents CancelButton As Button
End Class
