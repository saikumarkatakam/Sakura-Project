<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationMaintenanceForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MakeReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EmailComboBox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ToTimeLabel = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ToDateLabel = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OrderAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DepositAmountTextBox = New System.Windows.Forms.TextBox()
        Me.FromTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OrderAdvanceButton = New System.Windows.Forms.Button()
        Me.DinningAreaRadioButton = New System.Windows.Forms.RadioButton()
        Me.FoodBarRadioButton = New System.Windows.Forms.RadioButton()
        Me.HibachiRadioButton = New System.Windows.Forms.RadioButton()
        Me.PartyRoomRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumberOfAdultsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumberOfChildrenNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ReservationGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumberOfAdultsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberOfChildrenNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeReservationToolStripMenuItem, Me.ChangeReservationToolStripMenuItem, Me.CancelReservationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MakeReservationToolStripMenuItem
        '
        Me.MakeReservationToolStripMenuItem.Name = "MakeReservationToolStripMenuItem"
        Me.MakeReservationToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.MakeReservationToolStripMenuItem.Text = "&Make Reservation"
        '
        'ChangeReservationToolStripMenuItem
        '
        Me.ChangeReservationToolStripMenuItem.Name = "ChangeReservationToolStripMenuItem"
        Me.ChangeReservationToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.ChangeReservationToolStripMenuItem.Text = "&Change Reservation"
        '
        'CancelReservationToolStripMenuItem
        '
        Me.CancelReservationToolStripMenuItem.Name = "CancelReservationToolStripMenuItem"
        Me.CancelReservationToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.CancelReservationToolStripMenuItem.Text = "Cancel &Reservation"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ReservationGroupBox
        '
        Me.ReservationGroupBox.Controls.Add(Me.Label15)
        Me.ReservationGroupBox.Controls.Add(Me.Label14)
        Me.ReservationGroupBox.Controls.Add(Me.Label13)
        Me.ReservationGroupBox.Controls.Add(Me.EmailComboBox)
        Me.ReservationGroupBox.Controls.Add(Me.Label12)
        Me.ReservationGroupBox.Controls.Add(Me.CustomerComboBox)
        Me.ReservationGroupBox.Controls.Add(Me.Label23)
        Me.ReservationGroupBox.Controls.Add(Me.Label22)
        Me.ReservationGroupBox.Controls.Add(Me.ToTimeLabel)
        Me.ReservationGroupBox.Controls.Add(Me.Label20)
        Me.ReservationGroupBox.Controls.Add(Me.ToDateLabel)
        Me.ReservationGroupBox.Controls.Add(Me.Label18)
        Me.ReservationGroupBox.Controls.Add(Me.ClearButton)
        Me.ReservationGroupBox.Controls.Add(Me.Label8)
        Me.ReservationGroupBox.Controls.Add(Me.DiscountTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.SubmitButton)
        Me.ReservationGroupBox.Controls.Add(Me.Label2)
        Me.ReservationGroupBox.Controls.Add(Me.Label11)
        Me.ReservationGroupBox.Controls.Add(Me.Label3)
        Me.ReservationGroupBox.Controls.Add(Me.OrderAmountTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.ToDateTimePicker)
        Me.ReservationGroupBox.Controls.Add(Me.TotalAmountTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.Label4)
        Me.ReservationGroupBox.Controls.Add(Me.DepositAmountTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.FromTimeDateTimePicker)
        Me.ReservationGroupBox.Controls.Add(Me.Label10)
        Me.ReservationGroupBox.Controls.Add(Me.ToTimeDateTimePicker)
        Me.ReservationGroupBox.Controls.Add(Me.Label9)
        Me.ReservationGroupBox.Controls.Add(Me.Label5)
        Me.ReservationGroupBox.Controls.Add(Me.Label1)
        Me.ReservationGroupBox.Controls.Add(Me.FromDateTimePicker)
        Me.ReservationGroupBox.Controls.Add(Me.GroupBox1)
        Me.ReservationGroupBox.Controls.Add(Me.Label6)
        Me.ReservationGroupBox.Controls.Add(Me.NumberOfAdultsNumericUpDown)
        Me.ReservationGroupBox.Controls.Add(Me.Label7)
        Me.ReservationGroupBox.Controls.Add(Me.NumberOfChildrenNumericUpDown)
        Me.ReservationGroupBox.Enabled = False
        Me.ReservationGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReservationGroupBox.Location = New System.Drawing.Point(204, 43)
        Me.ReservationGroupBox.Name = "ReservationGroupBox"
        Me.ReservationGroupBox.Size = New System.Drawing.Size(519, 670)
        Me.ReservationGroupBox.TabIndex = 0
        Me.ReservationGroupBox.TabStop = False
        Me.ReservationGroupBox.Text = "Make a Reservation - Details"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(429, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 17)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(480, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 17)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(392, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 17)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "*"
        '
        'EmailComboBox
        '
        Me.EmailComboBox.FormattingEnabled = True
        Me.EmailComboBox.Location = New System.Drawing.Point(154, 60)
        Me.EmailComboBox.Name = "EmailComboBox"
        Me.EmailComboBox.Size = New System.Drawing.Size(232, 23)
        Me.EmailComboBox.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 15)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Customer Email ID"
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(154, 31)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(320, 23)
        Me.CustomerComboBox.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(847, 199)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 17)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(313, 409)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 17)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "*"
        '
        'ToTimeLabel
        '
        Me.ToTimeLabel.AutoSize = True
        Me.ToTimeLabel.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToTimeLabel.ForeColor = System.Drawing.Color.Red
        Me.ToTimeLabel.Location = New System.Drawing.Point(405, 374)
        Me.ToTimeLabel.Name = "ToTimeLabel"
        Me.ToTimeLabel.Size = New System.Drawing.Size(14, 17)
        Me.ToTimeLabel.TabIndex = 40
        Me.ToTimeLabel.Text = "*"
        Me.ToTimeLabel.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(405, 344)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 17)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "*"
        '
        'ToDateLabel
        '
        Me.ToDateLabel.AutoSize = True
        Me.ToDateLabel.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDateLabel.ForeColor = System.Drawing.Color.Red
        Me.ToDateLabel.Location = New System.Drawing.Point(405, 312)
        Me.ToDateLabel.Name = "ToDateLabel"
        Me.ToDateLabel.Size = New System.Drawing.Size(14, 17)
        Me.ToDateLabel.TabIndex = 38
        Me.ToDateLabel.Text = "*"
        Me.ToDateLabel.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(405, 281)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 17)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "*"
        '
        'ClearButton
        '
        Me.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearButton.Location = New System.Drawing.Point(292, 626)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(159, 27)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Customer Name"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(167, 511)
        Me.DiscountTextBox.MaxLength = 5
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(103, 23)
        Me.DiscountTextBox.TabIndex = 10
        '
        'SubmitButton
        '
        Me.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SubmitButton.Location = New System.Drawing.Point(114, 626)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(159, 27)
        Me.SubmitButton.TabIndex = 9
        Me.SubmitButton.Text = "Confirm Reservation"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 514)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Discount Percent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To Date"
        '
        'OrderAmountTextBox
        '
        Me.OrderAmountTextBox.Location = New System.Drawing.Point(167, 540)
        Me.OrderAmountTextBox.MaxLength = 13
        Me.OrderAmountTextBox.Name = "OrderAmountTextBox"
        Me.OrderAmountTextBox.ReadOnly = True
        Me.OrderAmountTextBox.Size = New System.Drawing.Size(103, 23)
        Me.OrderAmountTextBox.TabIndex = 11
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.ToDateTimePicker.Enabled = False
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(166, 312)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.ToDateTimePicker.TabIndex = 4
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(167, 569)
        Me.TotalAmountTextBox.MaxLength = 13
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.ReadOnly = True
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(103, 23)
        Me.TotalAmountTextBox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To Time"
        '
        'DepositAmountTextBox
        '
        Me.DepositAmountTextBox.Location = New System.Drawing.Point(167, 482)
        Me.DepositAmountTextBox.MaxLength = 13
        Me.DepositAmountTextBox.Name = "DepositAmountTextBox"
        Me.DepositAmountTextBox.ReadOnly = True
        Me.DepositAmountTextBox.Size = New System.Drawing.Size(103, 23)
        Me.DepositAmountTextBox.TabIndex = 9
        '
        'FromTimeDateTimePicker
        '
        Me.FromTimeDateTimePicker.CustomFormat = "HH:mm"
        Me.FromTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromTimeDateTimePicker.Location = New System.Drawing.Point(166, 343)
        Me.FromTimeDateTimePicker.Name = "FromTimeDateTimePicker"
        Me.FromTimeDateTimePicker.ShowUpDown = True
        Me.FromTimeDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.FromTimeDateTimePicker.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(66, 572)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Amount"
        '
        'ToTimeDateTimePicker
        '
        Me.ToTimeDateTimePicker.CustomFormat = "HH:mm"
        Me.ToTimeDateTimePicker.Enabled = False
        Me.ToTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToTimeDateTimePicker.Location = New System.Drawing.Point(166, 374)
        Me.ToTimeDateTimePicker.Name = "ToTimeDateTimePicker"
        Me.ToTimeDateTimePicker.ShowUpDown = True
        Me.ToTimeDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.ToTimeDateTimePicker.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 543)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Order Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "From Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 485)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Deposit Amount"
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(166, 281)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.FromDateTimePicker.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OrderAdvanceButton)
        Me.GroupBox1.Controls.Add(Me.DinningAreaRadioButton)
        Me.GroupBox1.Controls.Add(Me.FoodBarRadioButton)
        Me.GroupBox1.Controls.Add(Me.HibachiRadioButton)
        Me.GroupBox1.Controls.Add(Me.PartyRoomRadioButton)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(43, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Section"
        '
        'OrderAdvanceButton
        '
        Me.OrderAdvanceButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OrderAdvanceButton.Location = New System.Drawing.Point(159, 95)
        Me.OrderAdvanceButton.Name = "OrderAdvanceButton"
        Me.OrderAdvanceButton.Size = New System.Drawing.Size(147, 23)
        Me.OrderAdvanceButton.TabIndex = 4
        Me.OrderAdvanceButton.Text = "Order food in advance?"
        Me.OrderAdvanceButton.UseVisualStyleBackColor = True
        Me.OrderAdvanceButton.Visible = False
        '
        'DinningAreaRadioButton
        '
        Me.DinningAreaRadioButton.AutoSize = True
        Me.DinningAreaRadioButton.Checked = True
        Me.DinningAreaRadioButton.Location = New System.Drawing.Point(21, 22)
        Me.DinningAreaRadioButton.Name = "DinningAreaRadioButton"
        Me.DinningAreaRadioButton.Size = New System.Drawing.Size(129, 19)
        Me.DinningAreaRadioButton.TabIndex = 0
        Me.DinningAreaRadioButton.TabStop = True
        Me.DinningAreaRadioButton.Text = "Restaurant / Dine In"
        Me.DinningAreaRadioButton.UseVisualStyleBackColor = True
        '
        'FoodBarRadioButton
        '
        Me.FoodBarRadioButton.AutoSize = True
        Me.FoodBarRadioButton.Location = New System.Drawing.Point(21, 47)
        Me.FoodBarRadioButton.Name = "FoodBarRadioButton"
        Me.FoodBarRadioButton.Size = New System.Drawing.Size(72, 19)
        Me.FoodBarRadioButton.TabIndex = 1
        Me.FoodBarRadioButton.TabStop = True
        Me.FoodBarRadioButton.Text = "Food Bar"
        Me.FoodBarRadioButton.UseVisualStyleBackColor = True
        '
        'HibachiRadioButton
        '
        Me.HibachiRadioButton.AutoSize = True
        Me.HibachiRadioButton.Location = New System.Drawing.Point(21, 72)
        Me.HibachiRadioButton.Name = "HibachiRadioButton"
        Me.HibachiRadioButton.Size = New System.Drawing.Size(66, 19)
        Me.HibachiRadioButton.TabIndex = 2
        Me.HibachiRadioButton.TabStop = True
        Me.HibachiRadioButton.Text = "Hibachi"
        Me.HibachiRadioButton.UseVisualStyleBackColor = True
        '
        'PartyRoomRadioButton
        '
        Me.PartyRoomRadioButton.AutoSize = True
        Me.PartyRoomRadioButton.Location = New System.Drawing.Point(21, 97)
        Me.PartyRoomRadioButton.Name = "PartyRoomRadioButton"
        Me.PartyRoomRadioButton.Size = New System.Drawing.Size(87, 19)
        Me.PartyRoomRadioButton.TabIndex = 3
        Me.PartyRoomRadioButton.Text = "Party Room"
        Me.PartyRoomRadioButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Number Of Adults"
        '
        'NumberOfAdultsNumericUpDown
        '
        Me.NumberOfAdultsNumericUpDown.Location = New System.Drawing.Point(167, 409)
        Me.NumberOfAdultsNumericUpDown.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumberOfAdultsNumericUpDown.Name = "NumberOfAdultsNumericUpDown"
        Me.NumberOfAdultsNumericUpDown.Size = New System.Drawing.Size(140, 23)
        Me.NumberOfAdultsNumericUpDown.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 443)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Number Of Children"
        '
        'NumberOfChildrenNumericUpDown
        '
        Me.NumberOfChildrenNumericUpDown.Location = New System.Drawing.Point(167, 440)
        Me.NumberOfChildrenNumericUpDown.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumberOfChildrenNumericUpDown.Name = "NumberOfChildrenNumericUpDown"
        Me.NumberOfChildrenNumericUpDown.Size = New System.Drawing.Size(140, 23)
        Me.NumberOfChildrenNumericUpDown.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ReservationMaintenanceForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1008, 725)
        Me.Controls.Add(Me.ReservationGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReservationMaintenanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Reservation Options"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ReservationGroupBox.ResumeLayout(False)
        Me.ReservationGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumberOfAdultsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberOfChildrenNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChangeReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservationGroupBox As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ToTimeLabel As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ToDateLabel As Label
    Friend WithEvents Label18 As Label
    Friend Shadows WithEvents ClearButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OrderAmountTextBox As TextBox
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents TotalAmountTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DepositAmountTextBox As TextBox
    Friend WithEvents FromTimeDateTimePicker As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents ToTimeDateTimePicker As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OrderAdvanceButton As Button
    Friend WithEvents DinningAreaRadioButton As RadioButton
    Friend WithEvents FoodBarRadioButton As RadioButton
    Friend WithEvents HibachiRadioButton As RadioButton
    Friend WithEvents PartyRoomRadioButton As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents NumberOfAdultsNumericUpDown As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents NumberOfChildrenNumericUpDown As NumericUpDown
    Friend WithEvents CustomerComboBox As ComboBox
    Friend WithEvents MakeReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents EmailComboBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label15 As Label
End Class
