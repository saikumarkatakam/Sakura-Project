Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class EmployeeIndividualReservationForm

    Private Reservations As New SakuraClass
    Private IndexInteger, ItemIDInteger, ReservationIDInteger, SectionIDInteger, EmployeeIDInteger As Integer
    Private DepositDecimal, OrderDecimal, DiscountDecimal, TotalDecimal As Decimal
    Private DiscountIDString, EmailIDString As String
    Private DiscountBoolean As Boolean
    Private OriginalDateString, OriginalTimeString As String
    Private OriginalDeposit, OriginalOrder, OriginalDiscount, OriginalTotal As Decimal

    Private Sub EmployeeIndividualReservationForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Dim DiscountValueDecimal As Decimal

        If PartyRoomRadioButton.Checked Then
            If AddToCartForm.OrderAmountDecimal > 0 Then
                OrderDecimal = AddToCartForm.OrderAmountDecimal
                'If there is a difference between the original order
                'amount and new one, change the original
                If OriginalOrder <> OrderDecimal Then
                    OriginalOrder = OrderDecimal
                    OriginalTotal = OriginalOrder - DepositDecimal
                End If
                TotalDecimal = OrderDecimal - DepositDecimal
            ElseIf OrderDecimal > 0 Then
                TotalDecimal = OrderDecimal - DepositDecimal
            Else
                TotalDecimal = DepositDecimal
            End If

            DiscountValueDecimal = TotalDecimal * DiscountDecimal
            TotalDecimal = TotalDecimal - DiscountValueDecimal

            OrderAmountTextBox.Text = OrderDecimal.ToString("C")
            TotalAmountTextBox.Text = TotalDecimal.ToString("C")
        Else
            DepositAmountTextBox.Clear()
            OrderAmountTextBox.Clear()
            TotalAmountTextBox.Clear()
        End If
    End Sub

    Private Sub IndividualReservationForm_Load(sender As Object,
                                                   e As EventArgs) Handles MyBase.Load

        Login.DB.OrderButtonString = Me.Name

        'Get details based on Reservation ID clicked
        Reservations.AddParam("@ReservationID", EmployeeChangeReservationForm.EmpReservationIDInteger)
        Reservations.ExecuteQuery("SELECT r.reservationID, s.sectionName, 
                                        r.discountID, d.discountPercent, r.PaymentStatus,
                                        r.depositAmount, r.orderAmount, 
                                        r.fromDate, r.toDate,
                                        r.fromTime, r.toTime, 
                                        r.numberOfAdults, r.numberOfChildren, 
                                        r.totalAmount, c.primaryEmailID FROM reservation as r 
                                        JOIN section as s ON r.sectionID = s.sectionID
                                        JOIN discount as d ON d.discountID = r.discountID
                                        JOIN customer as c ON c.customerID = r.customerID                                        
                                        WHERE r.reservationID = ?")
        If Reservations.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservations.ExceptionString)
            Exit Sub
        End If

        'Display the details in the corresponding fields
        DepositDecimal = Reservations.DBDataTable(0)!depositAmount
        DiscountDecimal = Reservations.DBDataTable(0)!discountPercent
        DiscountIDString = Reservations.DBDataTable(0)!discountID
        OrderDecimal = Reservations.DBDataTable(0)!orderAmount
        TotalDecimal = Reservations.DBDataTable(0)!totalAmount

        ReservationIDTextBox.Text = Reservations.DBDataTable(0)!reservationID

        DepositAmountTextBox.Text = DepositDecimal.ToString("C")
        DiscountTextBox.Text = DiscountDecimal.ToString("P0")
        OrderAmountTextBox.Text = OrderDecimal.ToString("C")
        TotalAmountTextBox.Text = TotalDecimal.ToString("C")

        Select Case Reservations.DBDataTable(0)!sectionName
            Case "Party Room"
                PartyRoomRadioButton.Checked = True
                ToDateTimePicker.Enabled = True
                ToTimeDateTimePicker.Enabled = True
                PaidCheckBox.Visible = True
            Case "Restaurant / Dine In"
                DinningAreaRadioButton.Checked = True
                ToDateTimePicker.Enabled = False
                ToTimeDateTimePicker.Enabled = False
                ViewOrderButton.Visible = False
                PaidCheckBox.Visible = True
            Case "Food Bar"
                FoodBarRadioButton.Checked = True
                ToDateTimePicker.Enabled = False
                ToTimeDateTimePicker.Enabled = False
                ViewOrderButton.Visible = False
                PaidCheckBox.Visible = True
            Case "Hibachi"
                HibachiRadioButton.Checked = True
                ToDateTimePicker.Enabled = False
                ToTimeDateTimePicker.Enabled = False
                ViewOrderButton.Visible = False
                PaidCheckBox.Visible = True
        End Select

        SectionGroupBox.Enabled = False

        FromDateTimePicker.Value = Reservations.DBDataTable(0)!fromDate
        FromDateTimePicker.CustomFormat = "yyyy-MM-dd"
        OriginalDateString = FromDateTimePicker.Text
        FromDateTimePicker.CustomFormat = "MM/dd/yyyy"
        ToDateTimePicker.Value = Reservations.DBDataTable(0)!toDate
        FromTimeDateTimePicker.Text = Reservations.DBDataTable(0)!fromTime.ToString()
        OriginalTimeString = FromTimeDateTimePicker.Text
        ToTimeDateTimePicker.Text = Reservations.DBDataTable(0)!toTime.ToString()

        NumberOfAdultsNumericUpDown.Value = Reservations.DBDataTable(0)!numberOfAdults
        NumberOfChildrenNumericUpDown.Value = Reservations.DBDataTable(0)!numberOfChildren


        'Get the employee ID, if it exists
        EmailIDString = Reservations.DBDataTable(0)!primaryEmailID
        Reservations.AddParam("@email", EmailIDString)
        Reservations.ExecuteQuery("SELECT employeeID FROM employee WHERE email = ?")
        If Reservations.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservations.ExceptionString)
            Exit Sub
        End If

        If Reservations.RecordCountInteger > 0 Then
            EmployeeIDInteger = Reservations.DBDataTable.Rows(0)!employeeID
        Else
            EmployeeIDInteger = 0
        End If

        'Check if food has already been ordered
        If PartyRoomRadioButton.Checked Then
            Reservations.AddParam("@reservationID", ReservationIDTextBox.Text)
            Reservations.ExecuteQuery("SELECT c.itemID, c.quantity, c.orderPrice, m.itemType, m.description
                                    FROM customerorder AS c JOIN menuitem AS m ON c.itemID = m.itemID
                                    WHERE c.reservationID =?")
            If Reservations.ExceptionString <> String.Empty Then
                MessageBox.Show(Reservations.ExceptionString)
                Exit Sub
            End If

            If Reservations.RecordCountInteger > 0 Then
                ViewOrderButton.Visible = True
                'Populate the CartDetails Array with the already existing items
                For Each item As DataRow In Reservations.DBDataTable.Rows
                    MenuForm.CartDetailsArray(IndexInteger).ItemTypeString = item("itemType")
                    MenuForm.CartDetailsArray(IndexInteger).ItemDescriptionString = item("description")
                    MenuForm.CartDetailsArray(IndexInteger).UnitPriceDecimal = item("orderPrice")
                    MenuForm.CartDetailsArray(IndexInteger).QuantityInteger = item("quantity")
                    MenuForm.CartDetailsArray(IndexInteger).TotalPriceDecimal = (item("orderPrice") * item("quantity"))

                    IndexInteger += 1
                Next
            End If
        End If

    End Sub
    Private Sub CancelButton_Click(sender As Object,
                                   e As EventArgs) Handles CancelButton.Click
        EmployeeChangeReservationForm.Show()
        Me.Close()
    End Sub

    Private Sub OrderAdvanceButton_Click(sender As Object,
                                         e As EventArgs) 
        'Set the Calling Form String
        Login.DB.CallingFormString = Me.Name
        Login.DB.ReservationString = Me.Name
        MenuForm.Show()
    End Sub

    Private Sub UpdateReservationButton_Click(sender As Object,
                                              e As EventArgs) Handles UpdateReservationButton.Click
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

        'In case the number of people changes, we would need to alter the discounts
        If NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value <= 10 Then
            DiscountDecimal = 0
            DiscountBoolean = False
        End If

        'Discounts
        'Only apply discounts IF it hasn't already been applied
        If DiscountDecimal = 0 Then
            ApplyDiscounts()
        Else
            DiscountBoolean = True
        End If

        DiscountTextBox.Text = DiscountDecimal.ToString("P0")

        ChangeReservation()
    End Sub

    Private Sub ApplyDiscounts()

        If EmployeeIDInteger > 0 Then
            DiscountIDString = "ED20"
            Reservations.AddParam("@discountID", DiscountIDString)
            Reservations.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
            If Reservations.ExceptionString <> String.Empty Then
                MessageBox.Show(Reservations.ExceptionString)
                Exit Sub
            End If

            DiscountBoolean = True
            DiscountDecimal = Reservations.DBDataTable.Rows(0)("discountPercent")

        ElseIf NumberOfChildrenNumericUpDown.Value > 2 Then
            DiscountIDString = "FKM01"
            Reservations.AddParam("@discountID", DiscountIDString)
            Reservations.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
            If Reservations.ExceptionString <> String.Empty Then
                MessageBox.Show(Reservations.ExceptionString)
                Exit Sub
            End If

            DiscountBoolean = True
            DiscountDecimal = Reservations.DBDataTable.Rows(0)("discountPercent")

        ElseIf (NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value) > 10 Then
            DiscountIDString = "CD10"
            Reservations.AddParam("@discountID", DiscountIDString)
            Reservations.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
            If Reservations.ExceptionString <> String.Empty Then
                MessageBox.Show(Reservations.ExceptionString)
                Exit Sub
            End If

            DiscountBoolean = True
            DiscountDecimal = Reservations.DBDataTable.Rows(0)("discountPercent")
        Else
            DiscountIDString = "ND"
            Reservations.AddParam("@discountID", DiscountIDString)
            Reservations.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
            If Reservations.ExceptionString <> String.Empty Then
                MessageBox.Show(Reservations.ExceptionString)
                Exit Sub
            End If

            DiscountBoolean = False
            DiscountDecimal = Reservations.DBDataTable.Rows(0)("discountPercent")
        End If
    End Sub

    Private Sub PartyRoomRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PartyRoomRadioButton.CheckedChanged
        'Check if food has already been ordered
        If PartyRoomRadioButton.Checked Then
            'To date and To time need to be enabled
            ToDateTimePicker.Enabled = True
            ToTimeDateTimePicker.Enabled = True
            ToDateLabel.Visible = True
            ToTimeLabel.Visible = True

            'Restore the original values, when toggling happens
            'Display the deposit amount
            DepositDecimal = 20
            DiscountTextBox.Text = OriginalDiscount.ToString("C")
            OrderAmountTextBox.Text = OriginalOrder.ToString("C")
            TotalAmountTextBox.Text = OriginalTotal.ToString("C")

        Else
            ToDateTimePicker.Enabled = False
            ToTimeDateTimePicker.Enabled = False
            ToDateLabel.Visible = False
            ToTimeLabel.Visible = False
            DepositAmountTextBox.Clear()

            DiscountTextBox.Clear()
            OrderAmountTextBox.Clear()
            TotalAmountTextBox.Clear()
            DepositDecimal = 0
            OrderDecimal = 0
            TotalDecimal = 0
        End If

        DepositAmountTextBox.Text = DepositDecimal.ToString("C")

    End Sub

    Private Sub ChangeReservation()

        Dim QueryString, PaymentStatusString, FromDateString, ToDateString As String

        Select Case True
            Case DinningAreaRadioButton.Checked
                Reservations.AddParam("@sectionName", DinningAreaRadioButton.Text)
            Case FoodBarRadioButton.Checked
                Reservations.AddParam("@sectionName", FoodBarRadioButton.Text)
            Case HibachiRadioButton.Checked
                Reservations.AddParam("@sectionName", HibachiRadioButton.Text)
            Case PartyRoomRadioButton.Checked
                Reservations.AddParam("@sectionName", PartyRoomRadioButton.Text)
        End Select

        Reservations.ExecuteQuery("SELECT sectionID FROM section WHERE sectionName = ?")
        If Reservations.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservations.ExceptionString)
            Exit Sub
        End If
        SectionIDInteger = Reservations.DBDataTable.Rows(0)("sectionID")

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

        'Check whether a reservation already exists for that particular from date & time
        'Only in the case of the party room
        If PartyRoomRadioButton.Checked Then

            If PaidCheckBox.Checked Then
                PaymentStatusString = "Paid"
            Else
                PaymentStatusString = "Payment Due"
            End If

            'Check if the date and time originally found are not the same
            'as the changed values
            If OriginalDateString <> FromDateString And OriginalTimeString <> FromTimeDateTimePicker.Text Then
                Reservations.AddParam("@fromDate", FromDateString)
                Reservations.AddParam("@fromTime", FromTimeDateTimePicker.Text)
                Reservations.ExecuteQuery("SELECT reservationID FROM reservation WHERE fromDate = ? AND fromTime = ?")
                If Reservations.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservations.ExceptionString)
                    Exit Sub
                End If

                If Reservations.RecordCountInteger > 0 Then
                    MessageBox.Show("A reservation already exists at this date and time.")
                    Exit Sub
                End If
            End If

            'If party room is selected, minimum people should be 10
            If NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value < 10 Then
                MessageBox.Show("Minimum number of people must be 10.")
                Exit Sub
            End If
        Else
            PaymentStatusString = "NA"
        End If

        ReservationIDInteger = Integer.Parse(ReservationIDTextBox.Text)

        QueryString = "UPDATE reservation SET discountID = '" & DiscountIDString & "', sectionID = " & SectionIDInteger & ", paymentStatus = '" & PaymentStatusString & "', depositAmount = " & DepositDecimal & ", orderAmount = " & OrderDecimal & ",fromDate = '" & FromDateString & "',toDate = '" & ToDateString & "',fromTime = '" & FromTimeDateTimePicker.Text & "',toTime = '" & ToTimeDateTimePicker.Text & "',numberOfAdults = " & NumberOfAdultsNumericUpDown.Value & ",numberOfChildren = " & NumberOfChildrenNumericUpDown.Value & ",totalAmount = " & TotalDecimal & " WHERE reservationID = " & ReservationIDInteger & ""
        Reservations.ExecuteQuery(QueryString)
        If Reservations.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservations.ExceptionString)
            Exit Sub
        End If

        SendEmail(EmailIDString)

        MessageBox.Show("Your reservation change is successful." & Environment.NewLine &
                        "An email has been sent to " & EmailIDString)

        'Order Table
        If AddToCartForm.CartTable IsNot Nothing Then
            For Each Row As DataRow In AddToCartForm.CartTable.Rows

                'Depending on whether the item type already exists in the order,
                'Insert or update the table customerorder
                Reservations.AddParam("@itemType", Row.Item("Item Type"))
                Reservations.ExecuteQuery("SELECT itemID FROM menuitem WHERE itemType = ?")
                If Reservations.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservations.ExceptionString)
                    Exit Sub
                End If
                ItemIDInteger = Reservations.DBDataTable.Rows(0)!itemID

                Reservations.AddParam("@reservationID", ReservationIDTextBox.Text)
                Reservations.AddParam("@itemID", ItemIDInteger)
                Reservations.ExecuteQuery("SELECT * FROM customerorder WHERE reservationID = ? AND itemID =?")
                If Reservations.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservations.ExceptionString)
                    Exit Sub
                End If

                If Reservations.RecordCountInteger > 0 Then

                    ItemIDInteger = Reservations.DBDataTable.Rows(0)("itemID")

                    'Update the record, in customerorder
                    QueryString = String.Empty
                    QueryString = "UPDATE customerorder SET quantity = " & Row.Item("Quantity") & ", orderPrice = " & Row.Item("Price") & "" &
                        "WHERE reservationID = " & ReservationIDInteger & " AND itemID = " & ItemIDInteger & ""
                    Reservations.ExecuteQuery(QueryString)
                    If Reservations.ExceptionString <> String.Empty Then
                        MessageBox.Show(Reservations.ExceptionString)
                        Exit Sub
                    End If
                Else
                    Reservations.AddParam("@itemType", Row.Item("Item Type"))
                    Reservations.ExecuteQuery("SELECT itemID FROM menuitem WHERE itemType = ?")
                    If Reservations.ExceptionString <> String.Empty Then
                        MessageBox.Show(Reservations.ExceptionString)
                        Exit Sub
                    End If

                    ItemIDInteger = Reservations.DBDataTable.Rows(0)!itemID

                    'Insert into customerorder table
                    QueryString = String.Empty
                    QueryString = "INSERT INTO customerorder(reservationID, itemID, quantity, orderPrice) VALUES(" & ReservationIDInteger & "," & ItemIDInteger & " ," & Row.Item("Quantity") & " ," & Row.Item("Price") & ")"
                    Reservations.ExecuteQuery(QueryString)
                    If Reservations.ExceptionString <> String.Empty Then
                        MessageBox.Show(Reservations.ExceptionString)
                        Exit Sub
                    End If
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
                                "Please show the coupon code " & DiscountIDString & " to the receptionist upon arrival. "
        Else
            DiscountTextString = String.Empty
        End If

        BodyOfEmailString = "Greetings " & Login.CustomerFirstNameString & "," & Environment.NewLine & Environment.NewLine &
        "Your reservation has been changed. Please find the reservation details below: " & Environment.NewLine & Environment.NewLine &
        "Reservation ID: " & ReservationIDInteger & Environment.NewLine &
        "From Date: " & FromDateTimePicker.Text & Environment.NewLine &
        "To Date: " & ToDateTimePicker.Text & Environment.NewLine &
        "From Time: " & FromTimeDateTimePicker.Text & Environment.NewLine &
        "To Time: " & ToTimeDateTimePicker.Text & Environment.NewLine & Environment.NewLine &
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
            mail.Subject = "Sakura Japanese Sushi & Hibachi - Reservation change confirmation"
            mail.Body = BodyOfEmailString
            SmtpServer.Send(mail)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ViewOrderButton_Click(sender As Object,
                                    e As EventArgs) Handles ViewOrderButton.Click
        Login.DB.ReservationString = Me.Name
        AddToCartForm.Show()
        Me.Hide()
    End Sub

End Class