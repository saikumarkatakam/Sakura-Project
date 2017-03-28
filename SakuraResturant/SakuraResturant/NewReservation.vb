Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class NewReservation

    Public TotalAmountDecimal, DepositDecimal, DiscountDecimal,
            OrderAmountDecimal, DiscountValueDecimal As Decimal
    Private SectionIDInteger, ReservationIDInteger,
        ItemIDInteger As Integer
    Private PaymentStatusString As String
    Public DiscountIDString As String
    Public DiscountBoolean As Boolean = False
    Private Reservation As New SakuraClass

    Private Sub NewReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.DB.CallingFormString = Me.Name
        Login.DB.ReservationString = Me.Name

        'Restaurant/Dine in radio button checked by default
        DinningAreaRadioButton.Checked = True

        'Display the customer Name in the reservation details
        CustomerNameTextBox.Text = Login.CustomerFirstNameString & " " &
                                   Login.CustomerLastNameString

        TotalAmountDecimal = 0
        DepositDecimal = 0
        DiscountDecimal = 0
        DiscountValueDecimal = 0
        OrderAmountDecimal = 0

    End Sub

    Private Sub NewReservation_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        'Order Amount to be updated
        If AddToCartForm.OrderAmountDecimal > 0 Then
            OrderAmountDecimal = AddToCartForm.OrderAmountDecimal
        End If

        OrderAmountTextBox.Text = OrderAmountDecimal.ToString("C")
    End Sub

    Private Sub PartyRoomRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PartyRoomRadioButton.CheckedChanged

        If PartyRoomRadioButton.Checked = True Then
            'To date and To time need to be enabled
            ToDateTimePicker.Enabled = True
            ToTimeDateTimePicker.Enabled = True
            ToDateLabel.Visible = True
            ToTimeLabel.Visible = True
            'Display the deposit amount
            DepositDecimal = 20
            'Display the Order food in advance button
            OrderAdvanceButton.Visible = True
        Else
            ToDateTimePicker.Enabled = False
            ToTimeDateTimePicker.Enabled = False
            OrderAdvanceButton.Visible = False
            ToDateLabel.Visible = False
            ToTimeLabel.Visible = False
            DepositDecimal = 0
        End If

        DepositAmountTextBox.Text = DepositDecimal.ToString("C")

    End Sub

    Private Sub OrderAdvanceButton_Click(sender As Object, e As EventArgs) Handles OrderAdvanceButton.Click
        'Call the Menu Form to order food
        MenuForm.Show()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

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

        If PartyRoomRadioButton.Checked Then
            MessageBox.Show("Please proceed to payment")
        End If

        'Get the employee ID, if the customer is also an employee
        EmployeeIDTextBox.Text = Login.EmployeeIDInteger

        If EmployeeIDTextBox.Text = 0 Then

            If (NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value) > 10 Then
                DiscountIDString = "CD10"
                Reservation.AddParam("@discountID", DiscountIDString)
                Reservation.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
                If Reservation.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservation.ExceptionString)
                    Exit Sub
                End If

                DiscountDecimal = Reservation.DBDataTable.Rows(0)("discountPercent")

            ElseIf NumberOfChildrenNumericUpDown.Value >= 2 And NumberOfAdultsNumericUpDown.Value <> 0 Then
                DiscountIDString = "FKM01"
                Reservation.AddParam("@discountID", DiscountIDString)
                Reservation.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
                If Reservation.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservation.ExceptionString)
                    Exit Sub
                End If

                DiscountDecimal = Reservation.DBDataTable.Rows(0)("discountPercent")

            Else
                DiscountIDString = "ND"
                Reservation.AddParam("@discountID", DiscountIDString)
                Reservation.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
                If Reservation.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservation.ExceptionString)
                    Exit Sub
                End If

                DiscountDecimal = Reservation.DBDataTable.Rows(0)("discountPercent")
            End If
        Else
            DiscountIDString = "ED20"
            Reservation.AddParam("@discountID", "ED20")
            Reservation.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
            If Reservation.ExceptionString <> String.Empty Then
                MessageBox.Show(Reservation.ExceptionString)
                Exit Sub
            End If

            DiscountDecimal = Reservation.DBDataTable.Rows(0)("discountPercent")
        End If

        DiscountTextBox.Text = DiscountDecimal.ToString()

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
                DiscountBoolean = True
            End If
        End If

        TotalAmountTextBox.Text = TotalAmountDecimal.ToString("C")

        AmountPaidTextBox.Text = TotalAmountTextBox.Text

        'Disable Reservation details
        'Make payment details visible
        SubmitButton.Enabled = False
        PaymentGroupBox.Visible = True
    End Sub

    Private Sub BookReservation()

        Dim QueryString, FromDateString, ToDateString, FromTimeString, ToTimeString As String

        Select Case True
            Case DinningAreaRadioButton.Checked
                Reservation.AddParam("@sectionName", DinningAreaRadioButton.Text)
            Case FoodBarRadioButton.Checked
                Reservation.AddParam("@sectionName", FoodBarRadioButton.Text)
            Case HibachiRadioButton.Checked
                Reservation.AddParam("@sectionName", HibachiRadioButton.Text)
            Case PartyRoomRadioButton.Checked
                Reservation.AddParam("@sectionName", PartyRoomRadioButton.Text)
        End Select

        Reservation.ExecuteQuery("SELECT sectionID FROM section WHERE sectionName = ?")
        If Reservation.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservation.ExceptionString)
            Exit Sub
        End If
        SectionIDInteger = Reservation.DBDataTable.Rows(0)("sectionID")

        FromDateTimePicker.CustomFormat = "yyyy-MM-dd"
        ToDateTimePicker.CustomFormat = "yyyy-MM-dd"

        FromDateString = FromDateTimePicker.Text
        If ToDateTimePicker.Enabled = False Then
            ToDateString = FromDateString
        Else
            ToDateString = ToDateTimePicker.Text
        End If

        FromDateTimePicker.CustomFormat = "MM/dd/yyyy"
        ToDateTimePicker.CustomFormat = "MM/dd/yyyy"

        FromTimeString = FromTimeDateTimePicker.Text
        If ToTimeDateTimePicker.Enabled = False Then
            ToTimeString = FromTimeString
        Else
            ToTimeString = ToTimeDateTimePicker.Text
        End If

        'Check whether a reservation already exists for that particular from date & time
        'Only in the case of the party room
        If PartyRoomRadioButton.Checked Then
            Reservation.AddParam("@fromDate", FromDateString)
            Reservation.AddParam("@fromTime", FromTimeDateTimePicker.Text)
            Reservation.ExecuteQuery("SELECT reservationID FROM reservation WHERE fromDate = ? AND fromTime = ?")
            If Reservation.ExceptionString <> String.Empty Then
                MessageBox.Show(Reservation.ExceptionString)
                Exit Sub
            End If

            If Reservation.RecordCountInteger > 0 Then
                MessageBox.Show("A reservation already exists at this time. Please choose a different time.")
                Exit Sub
            End If

            'If party room is selected, minimum people should be 10
            If NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value < 10 Then
                MessageBox.Show("Minimum number of people must be 10.")
                Exit Sub
            End If
        End If

        QueryString = "INSERT INTO reservation(customerID, discountID, sectionID, paymentStatus, depositAmount, orderAmount,fromDate,toDate,fromTime,toTime,numberOfAdults,numberOfChildren,totalAmount,reservationStatus) VALUES(" & Login.CustomerIDInteger.ToString("N0") & ",'" & DiscountIDString & "'," & SectionIDInteger.ToString("N0") & ",'" & PaymentStatusString & "'," & DepositDecimal & "," & OrderAmountDecimal & ",'" & FromDateString & "','" & ToDateString & "','" & FromTimeString & "','" & ToTimeString & "', " & NumberOfAdultsNumericUpDown.Value & "," & NumberOfChildrenNumericUpDown.Value & "," & TotalAmountDecimal & ",""Reserved"")"

        Reservation.ExecuteQuery(QueryString)
        If Reservation.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservation.ExceptionString)
            Exit Sub
        End If

        Reservation.ExecuteQuery("SELECT reservationID, fromDate, fromTime FROM reservation ORDER BY reservationID DESC LIMIT 1")
        If Reservation.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservation.ExceptionString)
            Exit Sub
        End If
        ReservationIDInteger = Integer.Parse(Reservation.DBDataTable.Rows(0)("reservationID"))
        SendEmail(Login.CustomerEmailIDString)
        MessageBox.Show("Your reservation Is successful." & Environment.NewLine &
                        "An email has been sent to " & Login.CustomerEmailIDString)

        'Order Table
        If AddToCartForm.CartTable IsNot Nothing Then
            For Each Row As DataRow In AddToCartForm.CartTable.Rows
                Reservation.AddParam("@itemType", Row.Item("Item Type"))
                Reservation.ExecuteQuery("SELECT itemID FROM menuitem WHERE itemType = ?")
                If Reservation.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservation.ExceptionString)
                    Exit Sub
                End If

                ItemIDInteger = Reservation.DBDataTable.Rows(0)!itemID

                'Insert into customerorder table
                QueryString = String.Empty
                QueryString = "INSERT INTO customerorder(reservationID, itemID, quantity, orderPrice) VALUES(" & ReservationIDInteger & "," & ItemIDInteger &" ," & Row.Item("Quantity") & " ," & Row.Item("Price") & ")"
                Reservation.ExecuteQuery(QueryString)
                If Reservation.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservation.ExceptionString)
                    Exit Sub
                End If
            Next
        End If
        DiscountBoolean = False
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Reservation.CallingFormString = "CustomerLogin"
        CustomerLogin.Show()
        MenuForm.Close()
        AddToCartForm.Close()
        Me.Close()
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
        "Reservation ID: " & Reservation.DBDataTable.Rows(0)!reservationID.ToString() & Environment.NewLine &
        "Date: " & Reservation.DBDataTable.Rows(0)!fromDate.ToString() & Environment.NewLine &
        "Time: " & Reservation.DBDataTable.Rows(0)!fromTime.ToString() & Environment.NewLine & Environment.NewLine &
        DiscountTextString & Environment.NewLine &
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

    Private Sub ConfirmPaymentButton_Click(sender As Object, e As EventArgs) Handles ConfirmPaymentButton.Click

        ErrorProvider1.Clear()

        If CreditCardNameTextBox.Text = String.Empty Then
            Me.ErrorProvider1.SetError(CreditCardNameTextBox,
                           "Card Holder Name cannot be blank")
            Exit Sub
        End If

        If CreditCardNoTextBox.Text = String.Empty Then
            Me.ErrorProvider1.SetError(CreditCardNoTextBox,
               "Credit card number cannot be blank")
            Exit Sub
        End If

        If CVVTextBox.Text = String.Empty Then
            Me.ErrorProvider1.SetError(CVVTextBox,
                                         "CVV cannot be blank")
            Exit Sub
        End If

        PaymentStatusString = "Paid"

        BookReservation()
        PaymentGroupBox.Visible = False
        CreditCardNameTextBox.Clear()
        CVVTextBox.Clear()
        CreditCardNoTextBox.Clear()

    End Sub

    Private Sub CancelPaymentButton_Click(sender As Object, e As EventArgs) Handles CancelPaymentButton.Click

        'Clear the boxes
        AmountPaidTextBox.Clear()
        CreditCardNameTextBox.Clear()
        CreditCardNoTextBox.Clear()
        CVVTextBox.Clear()
        ExpiryDateTimePicker.Value = DateTime.Now

        'Hide the Payment group box
        'Enable the reservation group box
        PaymentGroupBox.Visible = False
        SubmitButton.Enabled = True
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

End Class