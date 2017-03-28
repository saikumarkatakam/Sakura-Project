<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustUpdatePersonalInfoForm
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
        Me.CustomerGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.AddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.SecondaryEmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.PrimaryEmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.CustomerGroupBox.SuspendLayout()
        Me.AddressGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerGroupBox
        '
        Me.CustomerGroupBox.Controls.Add(Me.Label9)
        Me.CustomerGroupBox.Controls.Add(Me.Label8)
        Me.CustomerGroupBox.Controls.Add(Me.Label1)
        Me.CustomerGroupBox.Controls.Add(Me.Label39)
        Me.CustomerGroupBox.Controls.Add(Me.CancelButton)
        Me.CustomerGroupBox.Controls.Add(Me.ChangeButton)
        Me.CustomerGroupBox.Controls.Add(Me.AddressGroupBox)
        Me.CustomerGroupBox.Controls.Add(Me.SecondaryEmailIDTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.PrimaryEmailIDTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.PhoneNumberTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.CustomerIDTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.Label6)
        Me.CustomerGroupBox.Controls.Add(Me.Label5)
        Me.CustomerGroupBox.Controls.Add(Me.Label4)
        Me.CustomerGroupBox.Controls.Add(Me.Label3)
        Me.CustomerGroupBox.Controls.Add(Me.Label2)
        Me.CustomerGroupBox.Controls.Add(Me.CustomerIDLabel)
        Me.CustomerGroupBox.Location = New System.Drawing.Point(137, 35)
        Me.CustomerGroupBox.Name = "CustomerGroupBox"
        Me.CustomerGroupBox.Size = New System.Drawing.Size(431, 522)
        Me.CustomerGroupBox.TabIndex = 1
        Me.CustomerGroupBox.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(363, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 15)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(264, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 15)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(334, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 15)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "*"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(334, 64)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 15)
        Me.Label39.TabIndex = 152
        Me.Label39.Text = "*"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(234, 465)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(123, 465)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(75, 23)
        Me.ChangeButton.TabIndex = 5
        Me.ChangeButton.Text = "&Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'AddressGroupBox
        '
        Me.AddressGroupBox.Controls.Add(Me.StateComboBox)
        Me.AddressGroupBox.Controls.Add(Me.Label15)
        Me.AddressGroupBox.Controls.Add(Me.Label13)
        Me.AddressGroupBox.Controls.Add(Me.Label12)
        Me.AddressGroupBox.Controls.Add(Me.Label11)
        Me.AddressGroupBox.Controls.Add(Me.Label19)
        Me.AddressGroupBox.Controls.Add(Me.Label14)
        Me.AddressGroupBox.Controls.Add(Me.Label17)
        Me.AddressGroupBox.Controls.Add(Me.Label18)
        Me.AddressGroupBox.Controls.Add(Me.ZipcodeTextBox)
        Me.AddressGroupBox.Controls.Add(Me.CityTextBox)
        Me.AddressGroupBox.Controls.Add(Me.StreetTextBox)
        Me.AddressGroupBox.Location = New System.Drawing.Point(25, 242)
        Me.AddressGroupBox.Name = "AddressGroupBox"
        Me.AddressGroupBox.Size = New System.Drawing.Size(379, 186)
        Me.AddressGroupBox.TabIndex = 4
        Me.AddressGroupBox.TabStop = False
        Me.AddressGroupBox.Text = "Address"
        '
        'StateComboBox
        '
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(104, 101)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(47, 23)
        Me.StateComboBox.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(192, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 15)
        Me.Label15.TabIndex = 160
        Me.Label15.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(157, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 15)
        Me.Label13.TabIndex = 159
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(252, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 15)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(360, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 15)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(44, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 15)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Zipcode:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(61, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "State:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(66, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 15)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "City:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(57, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 15)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "Street:"
        '
        'ZipcodeTextBox
        '
        Me.ZipcodeTextBox.Location = New System.Drawing.Point(103, 138)
        Me.ZipcodeTextBox.MaxLength = 45
        Me.ZipcodeTextBox.Name = "ZipcodeTextBox"
        Me.ZipcodeTextBox.Size = New System.Drawing.Size(83, 23)
        Me.ZipcodeTextBox.TabIndex = 3
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(103, 64)
        Me.CityTextBox.MaxLength = 45
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(143, 23)
        Me.CityTextBox.TabIndex = 1
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(103, 27)
        Me.StreetTextBox.MaxLength = 45
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(252, 23)
        Me.StreetTextBox.TabIndex = 0
        '
        'SecondaryEmailIDTextBox
        '
        Me.SecondaryEmailIDTextBox.Location = New System.Drawing.Point(161, 188)
        Me.SecondaryEmailIDTextBox.MaxLength = 50
        Me.SecondaryEmailIDTextBox.Name = "SecondaryEmailIDTextBox"
        Me.SecondaryEmailIDTextBox.Size = New System.Drawing.Size(196, 23)
        Me.SecondaryEmailIDTextBox.TabIndex = 3
        '
        'PrimaryEmailIDTextBox
        '
        Me.PrimaryEmailIDTextBox.Location = New System.Drawing.Point(161, 157)
        Me.PrimaryEmailIDTextBox.MaxLength = 50
        Me.PrimaryEmailIDTextBox.Name = "PrimaryEmailIDTextBox"
        Me.PrimaryEmailIDTextBox.ReadOnly = True
        Me.PrimaryEmailIDTextBox.Size = New System.Drawing.Size(196, 23)
        Me.PrimaryEmailIDTextBox.TabIndex = 3
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(161, 129)
        Me.PhoneNumberTextBox.MaxLength = 10
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(97, 23)
        Me.PhoneNumberTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(161, 98)
        Me.LastNameTextBox.MaxLength = 45
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(167, 23)
        Me.LastNameTextBox.TabIndex = 1
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(161, 64)
        Me.FirstNameTextBox.MaxLength = 45
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(167, 23)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(161, 33)
        Me.CustomerIDTextBox.MaxLength = 10
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(83, 23)
        Me.CustomerIDTextBox.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Secondary Email ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Primary Email ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Location = New System.Drawing.Point(72, 36)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(73, 15)
        Me.CustomerIDLabel.TabIndex = 0
        Me.CustomerIDLabel.Text = "Customer ID"
        '
        'CustUpdatePersonalInfoForm
        '
        Me.AcceptButton = Me.ChangeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(684, 583)
        Me.Controls.Add(Me.CustomerGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CustUpdatePersonalInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Personal Information"
        Me.CustomerGroupBox.ResumeLayout(False)
        Me.CustomerGroupBox.PerformLayout()
        Me.AddressGroupBox.ResumeLayout(False)
        Me.AddressGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerGroupBox As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents AddressGroupBox As GroupBox
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ZipcodeTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents SecondaryEmailIDTextBox As TextBox
    Friend WithEvents PrimaryEmailIDTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerIDLabel As Label
End Class
