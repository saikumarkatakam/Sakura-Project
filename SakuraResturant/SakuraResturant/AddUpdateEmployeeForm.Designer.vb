<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUpdateEmployeeForm
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
        Me.EmployeeGroupBox = New System.Windows.Forms.GroupBox()
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.SubPositionLabel = New System.Windows.Forms.Label()
        Me.SubPositionTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SupervisorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.AddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.EmployeeGroupBox.SuspendLayout()
        Me.AddressGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeGroupBox
        '
        Me.EmployeeGroupBox.Controls.Add(Me.PositionComboBox)
        Me.EmployeeGroupBox.Controls.Add(Me.SubPositionLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.SubPositionTextBox)
        Me.EmployeeGroupBox.Controls.Add(Me.Label7)
        Me.EmployeeGroupBox.Controls.Add(Me.SupervisorComboBox)
        Me.EmployeeGroupBox.Controls.Add(Me.Label6)
        Me.EmployeeGroupBox.Controls.Add(Me.Label5)
        Me.EmployeeGroupBox.Controls.Add(Me.Label4)
        Me.EmployeeGroupBox.Controls.Add(Me.Label3)
        Me.EmployeeGroupBox.Controls.Add(Me.Label1)
        Me.EmployeeGroupBox.Controls.Add(Me.EmployeeIDTextBox)
        Me.EmployeeGroupBox.Controls.Add(Me.EmployeeIDLabel)
        Me.EmployeeGroupBox.Controls.Add(Me.EmailTextBox)
        Me.EmployeeGroupBox.Controls.Add(Me.Label30)
        Me.EmployeeGroupBox.Controls.Add(Me.AddressGroupBox)
        Me.EmployeeGroupBox.Controls.Add(Me.PhoneNumberTextBox)
        Me.EmployeeGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.EmployeeGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.EmployeeGroupBox.Controls.Add(Me.Label31)
        Me.EmployeeGroupBox.Controls.Add(Me.Label32)
        Me.EmployeeGroupBox.Controls.Add(Me.Label34)
        Me.EmployeeGroupBox.Controls.Add(Me.Label37)
        Me.EmployeeGroupBox.Controls.Add(Me.Label39)
        Me.EmployeeGroupBox.Controls.Add(Me.Label40)
        Me.EmployeeGroupBox.Controls.Add(Me.ExitButton)
        Me.EmployeeGroupBox.Controls.Add(Me.AddUpdateButton)
        Me.EmployeeGroupBox.Location = New System.Drawing.Point(14, 17)
        Me.EmployeeGroupBox.Name = "EmployeeGroupBox"
        Me.EmployeeGroupBox.Size = New System.Drawing.Size(542, 583)
        Me.EmployeeGroupBox.TabIndex = 0
        Me.EmployeeGroupBox.TabStop = False
        Me.EmployeeGroupBox.Text = "Employee Details"
        '
        'PositionComboBox
        '
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Items.AddRange(New Object() {"Admin", "Associate", "Manager", "Staff"})
        Me.PositionComboBox.Location = New System.Drawing.Point(143, 188)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(142, 23)
        Me.PositionComboBox.TabIndex = 4
        '
        'SubPositionLabel
        '
        Me.SubPositionLabel.AutoSize = True
        Me.SubPositionLabel.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubPositionLabel.ForeColor = System.Drawing.Color.Red
        Me.SubPositionLabel.Location = New System.Drawing.Point(293, 220)
        Me.SubPositionLabel.Name = "SubPositionLabel"
        Me.SubPositionLabel.Size = New System.Drawing.Size(13, 15)
        Me.SubPositionLabel.TabIndex = 164
        Me.SubPositionLabel.Text = "*"
        '
        'SubPositionTextBox
        '
        Me.SubPositionTextBox.Location = New System.Drawing.Point(144, 220)
        Me.SubPositionTextBox.MaxLength = 45
        Me.SubPositionTextBox.Name = "SubPositionTextBox"
        Me.SubPositionTextBox.Size = New System.Drawing.Size(142, 23)
        Me.SubPositionTextBox.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "Sub Position:"
        '
        'SupervisorComboBox
        '
        Me.SupervisorComboBox.FormattingEnabled = True
        Me.SupervisorComboBox.Location = New System.Drawing.Point(143, 51)
        Me.SupervisorComboBox.Name = "SupervisorComboBox"
        Me.SupervisorComboBox.Size = New System.Drawing.Size(142, 23)
        Me.SupervisorComboBox.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Supervisor Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(454, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 15)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(293, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 15)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Position:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(447, 462)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 15)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "*"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(143, 22)
        Me.EmployeeIDTextBox.MaxLength = 45
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(142, 23)
        Me.EmployeeIDTextBox.TabIndex = 0
        '
        'EmployeeIDLabel
        '
        Me.EmployeeIDLabel.AutoSize = True
        Me.EmployeeIDLabel.Location = New System.Drawing.Point(56, 25)
        Me.EmployeeIDLabel.Name = "EmployeeIDLabel"
        Me.EmployeeIDLabel.Size = New System.Drawing.Size(76, 15)
        Me.EmployeeIDLabel.TabIndex = 153
        Me.EmployeeIDLabel.Text = "Employee ID:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(147, 462)
        Me.EmailTextBox.MaxLength = 50
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(294, 23)
        Me.EmailTextBox.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(86, 466)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(53, 15)
        Me.Label30.TabIndex = 151
        Me.Label30.Text = "Email ID:"
        '
        'AddressGroupBox
        '
        Me.AddressGroupBox.Controls.Add(Me.StateComboBox)
        Me.AddressGroupBox.Controls.Add(Me.Label19)
        Me.AddressGroupBox.Controls.Add(Me.Label14)
        Me.AddressGroupBox.Controls.Add(Me.Label17)
        Me.AddressGroupBox.Controls.Add(Me.Label18)
        Me.AddressGroupBox.Controls.Add(Me.ZipcodeTextBox)
        Me.AddressGroupBox.Controls.Add(Me.CityTextBox)
        Me.AddressGroupBox.Controls.Add(Me.StreetTextBox)
        Me.AddressGroupBox.Location = New System.Drawing.Point(44, 256)
        Me.AddressGroupBox.Name = "AddressGroupBox"
        Me.AddressGroupBox.Size = New System.Drawing.Size(404, 188)
        Me.AddressGroupBox.TabIndex = 6
        Me.AddressGroupBox.TabStop = False
        Me.AddressGroupBox.Text = "Address"
        '
        'StateComboBox
        '
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(104, 101)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(48, 23)
        Me.StateComboBox.TabIndex = 2
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
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(143, 154)
        Me.PhoneNumberTextBox.MaxLength = 45
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(142, 23)
        Me.PhoneNumberTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(143, 121)
        Me.LastNameTextBox.MaxLength = 45
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(236, 23)
        Me.LastNameTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(143, 88)
        Me.FirstNameTextBox.MaxLength = 45
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(236, 23)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(41, 157)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(91, 15)
        Me.Label31.TabIndex = 136
        Me.Label31.Text = "Phone Number:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(66, 124)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(66, 15)
        Me.Label32.TabIndex = 135
        Me.Label32.Text = "Last Name:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(65, 91)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 15)
        Me.Label34.TabIndex = 134
        Me.Label34.Text = "First Name:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Red
        Me.Label37.Location = New System.Drawing.Point(293, 154)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(13, 15)
        Me.Label37.TabIndex = 129
        Me.Label37.Text = "*"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(385, 88)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 15)
        Me.Label39.TabIndex = 128
        Me.Label39.Text = "*"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(385, 121)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(13, 15)
        Me.Label40.TabIndex = 130
        Me.Label40.Text = "*"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(302, 526)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(87, 27)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.Location = New System.Drawing.Point(174, 526)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(87, 27)
        Me.AddUpdateButton.TabIndex = 8
        Me.AddUpdateButton.Text = "&Add"
        Me.AddUpdateButton.UseVisualStyleBackColor = True
        '
        'AddUpdateEmployeeForm
        '
        Me.AcceptButton = Me.AddUpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(597, 622)
        Me.Controls.Add(Me.EmployeeGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddUpdateEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Employee Details"
        Me.EmployeeGroupBox.ResumeLayout(False)
        Me.EmployeeGroupBox.PerformLayout()
        Me.AddressGroupBox.ResumeLayout(False)
        Me.AddressGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmployeeGroupBox As GroupBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents AddUpdateButton As Button
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents EmployeeIDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SupervisorComboBox As ComboBox
    Friend WithEvents AddressGroupBox As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ZipcodeTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SubPositionLabel As Label
    Friend WithEvents SubPositionTextBox As TextBox
    Friend WithEvents PositionComboBox As ComboBox
End Class
