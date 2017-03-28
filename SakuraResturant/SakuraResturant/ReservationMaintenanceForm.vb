Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class ReservationMaintenanceForm

    Private ReservationAccess As New SakuraClass
    Private DiscountDecimal, DepositDecimal, OrderAmountDecimal,
            TotalAmountDecimal, DiscountValueDecimal As Decimal
    Private DiscountIDString As String
    Private DiscountBoolean As Boolean
    Private SectionIDInteger, ReservationIDInteger, ItemIDInteger, CustomerIDInteger As Integer

    Private Sub ChangeReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeReservationToolStripMenuItem.Click
        ReservationGroupBox.Enabled = False
        EmployeeChangeReservationForm.Show()
        Me.Close()
    End Sub

    Private Sub CancelReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelReservationToolStripMenuItem.Click
        ReservationGroupBox.Enabled = False
        EmployeeCancelReservationForm.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub

    Private Sub ReservationMaintenanceForm_Load(sender As Object,
                                                e As EventArgs) Handles MyBase.Load

        Dim CustomerCountInteger As Integer

        'Populate the customer names
        ReservationAccess.ExecuteQuery("SELECT firstName, lastName, primaryEmailID FROM customer WHERE active = 1")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        CustomerCountInteger = ReservationAccess.DBDataTable.Rows.Count

        For i = 0 To CustomerCountInteger - 1

            Dim FirstNameString, LastNameString As String
            Dim EmpAccess As New SakuraClass

            FirstNameString = ReservationAccess.DBDataTable.Rows(i).Item(0).ToString
            LastNameString = ReservationAccess.DBDataTable.Rows(i).Item(1).ToString

            'If the person is an employee, do not add them
            EmpAccess.AddParam("@email", ReservationAccess.DBDataTable.Rows(i).Item(2))
            EmpAccess.ExecuteQuery("SELECT employeeID FROM employee WHERE email =?")
            If EmpAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmpAccess.ExceptionString)
                Exit Sub
            End If

            If EmpAccess.RecordCountInteger = 0 Then
                CustomerComboBox.Items.Add(FirstNameString & " " & LastNameString)
            End If
        Next

    End Sub

    Private Sub CustomerComboBox_SelectedIndexChanged(sender As Object,
                                                      e As EventArgs) Handles CustomerComboBox.SelectedIndexChanged

        EmailComboBox.Items.Clear()
        EmailComboBox.Text = " "
        'When a customer name is selected, use the customer name to get the possible email
        'addresses
        Dim NameString As String = CustomerComboBox.SelectedItem
        Dim SplitString As String() = NameString.Split(" ")

        ReservationAccess.AddParam("@firstName", SplitString(0))
        ReservationAccess.AddParam("@lastName", SplitString(1))
        ReservationAccess.ExecuteQuery("SELECT primaryEmailID FROM customer WHERE firstName = ? AND lastName = ? AND active = 1")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        For i = 0 To ReservationAccess.DBDataTable.Rows.Count - 1
            EmailComboBox.Items.Add(ReservationAccess.DBDataTable.Rows(i).Item(0))
        Next

    End Sub

    Private Sub EmailComboBox_SelectedIndexChanged(sender As Object,
                                                   e As EventArgs) Handles EmailComboBox.SelectedIndexChanged
        'Get the customer ID
        ReservationAccess.AddParam("@email", EmailComboBox.SelectedItem)
        ReservationAccess.ExecuteQuery("SELECT customerID FROM customer WHERE primaryEmailID = ? AND active = 1")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If
        CustomerIDInteger = ReservationAccess.DBDataTable(0)!customerID

    End Sub

    Private Sub ClearButton_Click(sender As Object,
                                  e As EventArgs) Handles ClearButton.Click
        'Clear all values in the reservation form
        CustomerComboBox.Text = String.Empty
        CustomerComboBox.Text = String.Empty
        EmailComboBox.Text = String.Empty
        EmailComboBox.Text = String.Empty
        FromDateTimePicker.Text = Date.Now
        ToDateTimePicker.Text = Date.Now
        FromTimeDateTimePicker.Text = TimeOfDay
        ToTimeDateTimePicker.Text = TimeOfDay
        NumberOfAdultsNumericUpDown.Value = 0
        NumberOfChildrenNumericUpDown.Value = 0
        DinningAreaRadioButton.Checked = True
        OrderAdvanceButton.Visible = False
        DepositAmountTextBox.Clear()
        DiscountTextBox.Clear()
        OrderAmountTextBox.Clear()
        TotalAmountTextBox.Clear()

        DepositDecimal = 0
        DiscountDecimal = 0
        DiscountValueDecimal = 0
        OrderAmountDecimal = 0
        TotalAmountDecimal = 0
    End Sub

    Private Sub OrderAdvanceButton_Click(sender As Object,
                                         e As EventArgs) Handles OrderAdvanceButton.Click
        Login.DB.CallingFormString = Me.Name
        MenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub MakeReservationToolStripMenuItem_Click(sender As Object,
                                                       e As EventArgs) Handles MakeReservationToolStripMenuItem.Click
        ReservationGroupBox.Enabled = True
    End Sub

    Private Sub PartyRoomRadioButton_CheckedChanged(sender As Object,
                                                    e As EventArgs) Handles PartyRoomRadioButton.CheckedChanged
        If PartyRoomRadioButton.Checked Then
            OrderAdvanceButton.Visible = True
            DepositDecimal = 20.0
            DepositAmountTextBox.Text = DepositDecimal.ToString("C")
        Else
            OrderAdvanceButton.Visible = False
            DepositDecimal = 0.0
            DepositAmountTextBox.Clear()
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object,
                                   e As EventArgs) Handles SubmitButton.Click
        'Validations
        ErrorProvider1.Clear()

        If PartyRoomRadioButton.Checked Then
            If FromDateTimePicker.Text > ToDateTimePicker.Text Then
                Me.ErrorProvider1.SetError(ToDateTimePicker,
                                           "To date cannot be lesser than From date")
                Exit Sub
            End If

            If FromTimeDateTimePicker.Text > ToTimeDateTimePicker.Text Then
                Me.ErrorProvider1.SetError(ToTimeDateTimePicker,
                               "To time cannot be lesser than From time")
                Exit Sub
            End If

            If NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value > 40 Then
                Me.ErrorProvider1.SetError(NumberOfAdultsNumericUpDown,
                           "Number of people must be lesser than 40")
                Exit Sub
            End If
        End If

        If NumberOfAdultsNumericUpDown.Value = 0 Then
            Me.ErrorProvider1.SetError(NumberOfAdultsNumericUpDown,
                                       "Number of Adults must be atleast one")
            Exit Sub
        End If

        'Discount calculations
        If (NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value) > 10 Then
            DiscountIDString = "CD10"
        ElseIf NumberOfAdultsNumericUpDown.Value <> 0 And NumberOfChildrenNumericUpDown.Value >= 2 Then
            DiscountIDString = "FKM01"
        Else
            DiscountIDString = "ND"
        End If

        ReservationAccess.AddParam("@discountID", DiscountIDString)
        ReservationAccess.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        DiscountDecimal = ReservationAccess.DBDataTable.Rows(0)("discountPercent")
        DiscountTextBox.Text = DiscountDecimal.ToString()

        'If the party room is not selected
        If PartyRoomRadioButton.Checked = False Then
            BookReservation()
            Exit Sub
        End If

        'Calculate the total Amount
        If OrderAmountDecimal > 0 Then
            TotalAmountDecimal = OrderAmountDecimal - DepositDecimal
            DiscountValueDecimal = TotalAmountDecimal * DiscountDecimal
            TotalAmountDecimal = TotalAmountDecimal - DiscountValueDecimal
        Else
            'If no food is ordered, just add the 
            'Deposit amount as Total
            TotalAmountDecimal = DepositDecimal
            If DiscountDecimal > 0 Then
                'Send an email with the coupon code and description
                'Along with the reservation details
                DiscountValueDecimal = TotalAmountDecimal * DiscountDecimal
                TotalAmountDecimal = TotalAmountDecimal - DiscountValueDecimal
                DiscountBoolean = True
            End If
        End If

        TotalAmountTextBox.Text = TotalAmountDecimal.ToString("C")

        BookReservation()

    End Sub

    Private Sub BookReservation()

        Dim QueryString, PaymentStatusString, FromDateString, ToDateString, FromTimeString, ToTimeString As String

        Select Case True
            Case DinningAreaRadioButton.Checked
                PaymentStatusString = "NA"
                ReservationAccess.AddParam("@sectionName", DinningAreaRadioButton.Text)
            Case FoodBarRadioButton.Checked
                PaymentStatusString = "NA"
                ReservationAccess.AddParam("@sectionName", FoodBarRadioButton.Text)
            Case HibachiRadioButton.Checked
                PaymentStatusString = "NA"
                ReservationAccess.AddParam("@sectionName", HibachiRadioButton.Text)
            Case PartyRoomRadioButton.Checked
                PaymentStatusString = "Payment Due"
                ReservationAccess.AddParam("@sectionName", PartyRoomRadioButton.Text)
        End Select

        ReservationAccess.ExecuteQuery("SELECT sectionID FROM section WHERE sectionName = ?")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If
        SectionIDInteger = ReservationAccess.DBDataTable.Rows(0)("sectionID")

        FromDateTimePicker.CustomFormat = "yyyy-MM-dd"
        ToDateTimePicker.CustomFormat = "yyyy-MM-dd"

        FromDateString = FromDateTimePicker.Text
        If ToDateTimePicker.Enabled = False Then
            ToDateString = FromDateTimePicker.Text
        Else
            ToDateString = ToDateTimePicker.Text
        End If

        FromDateTimePicker.CustomFormat = "MM/dd/yyyy"
        ToDateTimePicker.CustomFormat = "MM/dd/yyyy"

        FromTimeString = FromTimeDateTimePicker.Text
        If ToTimeDateTimePicker.Enabled = False Then
            ToTimeString = FromTimeDateTimePicker.Text
        Else
            ToTimeString = ToTimeDateTimePicker.Text
        End If

        'Check whether a reservation already exists for that particular from date & time
        'Only in the case of the party room
        If PartyRoomRadioButton.Checked Then
            ReservationAccess.AddParam("@fromDate", FromDateString)
            ReservationAccess.AddParam("@fromTime", FromTimeDateTimePicker.Text)
            ReservationAccess.ExecuteQuery("SELECT reservationID FROM reservation WHERE fromDate = ? AND fromTime = ?")
            If ReservationAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ReservationAccess.ExceptionString)
                Exit Sub
            End If

            If ReservationAccess.RecordCountInteger > 0 Then
                MessageBox.Show("A reservation already exists at this date and time.")
                Exit Sub
            End If

            'If party room is selected, minimum people should be 10
            If NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value < 10 Then
                MessageBox.Show("Minimum number of people must be 10.")
                Exit Sub
            End If
        End If

        QueryString = "INSERT INTO reservation(customerID, employeeID, discountID, sectionID, paymentStatus, depositAmount, orderAmount,fromDate,toDate,fromTime,toTime,numberOfAdults,numberOfChildren,totalAmount,reservationStatus)" &
                       " VALUES(" & CustomerIDInteger & "," & Login.EmployeeIDInteger & ",'" & DiscountIDString & "'," & SectionIDInteger.ToString("N0") & ",'" & PaymentStatusString & "', " & DepositDecimal & "," & OrderAmountDecimal & ",'" & FromDateString & "','" & ToDateString & "','" & FromTimeString & "','" & ToTimeString & "', " & NumberOfAdultsNumericUpDown.Value & "," & NumberOfChildrenNumericUpDown.Value & "," & TotalAmountDecimal & ",""Reserved"")"

        ReservationAccess.ExecuteQuery(QueryString)
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        ReservationAccess.ExecuteQuery("SELECT reservationID, fromDate, fromTime FROM reservation ORDER BY reservationID DESC LIMIT 1")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If
        ReservationIDInteger = Integer.Parse(ReservationAccess.DBDataTable.Rows(0)("reservationID"))

        SendEmail(EmailComboBox.SelectedItem)
        MessageBox.Show("Your reservation Is successful." & Environment.NewLine &
                        "An email has been sent to " & EmailComboBox.Text)

        'Order Table
        If AddToCartForm.CartTable IsNot Nothing Then
            For Each Row As DataRow In AddToCartForm.CartTable.Rows
                ReservationAccess.AddParam("@itemType", Row.Item("Item Type"))
                ReservationAccess.ExecuteQuery("SELECT itemID FROM menuitem WHERE itemType = ?")
                If ReservationAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(ReservationAccess.ExceptionString)
                    Exit Sub
                End If

                ItemIDInteger = ReservationAccess.DBDataTable.Rows(0)!itemID

                'Insert into customerorder table
                QueryString = String.Empty
                QueryString = "INSERT INTO customerorder(reservationID, itemID, quantity, orderPrice) VALUES(" & ReservationIDInteger & "," & ItemIDInteger & " ," & Row.Item("Quantity") & " ," & Row.Item("Price") & ")"
                ReservationAccess.ExecuteQuery(QueryString)
                If ReservationAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(ReservationAccess.ExceptionString)
                    Exit Sub
                End If
            Next
        End If
        DiscountBoolean = False
    End Sub

    Private Sub SendEmail(EmailID)

        'Send an email to the customer/organization
        Dim BodyOfEmailString, RecipientEmailString, DiscountTextString As String

        If DiscountBoolean = True Then
            DiscountTextString = "You have availed a discount of " & DiscountDecimal.ToString("P0") & Environment.NewLine &
                                "Please show the coupon code " & DiscountIDString & "to the receptionist upon arrival. "
        Else
            DiscountTextString = String.Empty
        End If

        BodyOfEmailString = "Greetings " & Login.CustomerFirstNameString & "," & Environment.NewLine & Environment.NewLine &
        "Your reservation has been booked. Please find the reservation details below: " & Environment.NewLine & Environment.NewLine &
        "Reservation ID: " & ReservationAccess.DBDataTable.Rows(0)!reservationID.ToString() & Environment.NewLine &
        "Date: " & ReservationAccess.DBDataTable.Rows(0)!fromDate.ToString() & Environment.NewLine &
        "Time: " & ReservationAccess.DBDataTable.Rows(0)!fromTime.ToString() & Environment.NewLine & Environment.NewLine &
        DiscountTextString & Environment.NewLine & Environment.NewLine &
        "Total Amount Due is: " & TotalAmountTextBox.Text & Environment.NewLine &
        "Regards," & Environment.NewLine &
        "Sakura Management"

        RecipientEmailString = EmailID

        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New _
            Net.NetworkCredential("sakurarestaurantmanagement@gmail.com", "Sakura@123")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("sakurarestaurantmanagement@gmail.com")
            mail.To.Add(RecipientEmailString)
            mail.Subject = "Sakura Japanese Sushi & Hibachi - Reservation booking confirmation"
            mail.Body = BodyOfEmailString
            SmtpServer.Send(mail)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReservationMaintenanceForm_Activated(sender As Object,
                                                     e As EventArgs) Handles Me.Activated
        'Order Amount to be updated
        If AddToCartForm.OrderAmountDecimal > 0 Then
            OrderAmountDecimal = AddToCartForm.OrderAmountDecimal
        End If

        OrderAmountTextBox.Text = OrderAmountDecimal.ToString("C")
    End Sub
End Class