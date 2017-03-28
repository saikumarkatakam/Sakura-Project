Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class ScheduleListForm

    Private ScheduleAccess As New SakuraClass
    Private PrintFont As New Drawing.Font("Times New Roman", 20, FontStyle.Regular)

    Private Sub ScheduleListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If ScheduleListLabel.Text = "Today's Reservations" Then
            DateLabel.Visible = False
            ReservationsDateTimePicker.Visible = False
            PrintReservationToolStripMenuItem.Enabled = True
            SendReminderToolStripMenuItem.Enabled = True

            ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
            ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"

            ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)

            'Display the current reservations
            ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name',
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE r.fromDate = ?")

            If ScheduleAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ScheduleAccess.ExceptionString)
                Exit Sub
            End If

            ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
            ReservationsDateTimePicker.CustomFormat = ""

            ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
            ReservationsDataGridView.ReadOnly = True
            ReservationsDataGridView.AutoResizeColumns()

        ElseIf ScheduleListLabel.Text = "Future Reservations" Then
            DateLabel.Visible = True
            ReservationsDateTimePicker.Visible = True
            ReservationsDateTimePicker.MinDate = DateTime.Today
            PrintReservationToolStripMenuItem.Enabled = False
            SendReminderToolStripMenuItem.Enabled = False

            ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
            ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"

            ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)

            'Display the future reservations
            ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name',
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE r.fromDate > ?")

            If ScheduleAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ScheduleAccess.ExceptionString)
                Exit Sub
            End If

            ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
            ReservationsDateTimePicker.CustomFormat = ""

            ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
            ReservationsDataGridView.ReadOnly = True
            ReservationsDataGridView.AutoResizeColumns()

        Else
            DateLabel.Visible = True
            ReservationsDateTimePicker.Visible = True
            ReservationsDateTimePicker.MaxDate = DateTime.Today
            PrintReservationToolStripMenuItem.Enabled = False
            SendReminderToolStripMenuItem.Enabled = False

            ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
            ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"

            ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)

            'Display the past reservations
            ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name',
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE r.fromDate < ?")

            If ScheduleAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ScheduleAccess.ExceptionString)
                Exit Sub
            End If

            ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
            ReservationsDateTimePicker.CustomFormat = ""

            ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
            ReservationsDataGridView.ReadOnly = True
            ReservationsDataGridView.AutoResizeColumns()
        End If
    End Sub

    Private Sub ReservationsDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ReservationsDateTimePicker.ValueChanged

        ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
        ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"
        ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)
        ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name',
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE r.fromDate = ?")

        If ScheduleAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ScheduleAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = False
        ReservationsDataGridView.AutoResizeColumns()

        ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
        ReservationsDateTimePicker.CustomFormat = " "
    End Sub

    Private Sub FirstNameTextBox_KeyUp(sender As Object, e As EventArgs) Handles FirstNameTextBox.KeyUp
        LastNameTextBox.Clear()
        ScheduleAccess.AddParam("@firstName", FirstNameTextBox.Text & "%")

        If ReservationsDateTimePicker.Visible = True Then
            ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
            ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"
            ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)
            ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
            ReservationsDateTimePicker.CustomFormat = ""
        Else
            ScheduleAccess.AddParam("@fromDate", Date.Now)
        End If

        ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name',
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE c.firstName LIKE ? AND r.fromDate = ?")

        If ScheduleAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ScheduleAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AutoResizeColumns()

    End Sub

    Private Sub LastNameTextBox_KeyUp(sender As Object, e As EventArgs) Handles LastNameTextBox.KeyUp
        FirstNameTextBox.Clear()
        ScheduleAccess.AddParam("@lastName", LastNameTextBox.Text & "%")
        If ReservationsDateTimePicker.Visible = True Then
            ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
            ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"
            ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)
            ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
            ReservationsDateTimePicker.CustomFormat = ""
        Else
            ScheduleAccess.AddParam("@fromDate", Date.Now)
        End If
        ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name',
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE c.lastName LIKE ? AND r.fromDate = ?")

        If ScheduleAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ScheduleAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AutoResizeColumns()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object,
                                         e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        If ReservationsDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a row.")
            Exit Sub
        End If

        For Each row As DataGridViewRow In ReservationsDataGridView.SelectedRows
            e.Graphics.DrawString("Reservation ID:  " & ReservationsDataGridView.Rows(row.Index).Cells(4).Value, PrintFont, Brushes.Black, 100, 100)
            e.Graphics.DrawString("First Name:  " & ReservationsDataGridView.Rows(row.Index).Cells(0).Value, PrintFont, Brushes.Black, 100, 150)
            e.Graphics.DrawString("Last Name:  " & ReservationsDataGridView.Rows(row.Index).Cells(1).Value, PrintFont, Brushes.Black, 100, 200)
            e.Graphics.DrawString("Phone Number:  " & ReservationsDataGridView.Rows(row.Index).Cells(2).Value, PrintFont, Brushes.Black, 100, 250)
            e.Graphics.DrawString("Email ID:  " & ReservationsDataGridView.Rows(row.Index).Cells(3).Value, PrintFont, Brushes.Black, 100, 300)
            e.Graphics.DrawString("Section:  " & ReservationsDataGridView.Rows(row.Index).Cells(5).Value, PrintFont, Brushes.Black, 100, 350)
            e.Graphics.DrawString("From Date:  " & ReservationsDataGridView.Rows(row.Index).Cells(9).Value, PrintFont, Brushes.Black, 100, 400)
            e.Graphics.DrawString("To Date:  " & ReservationsDataGridView.Rows(row.Index).Cells(10).Value, PrintFont, Brushes.Black, 100, 450)
            e.Graphics.DrawString("From Time:  " & ReservationsDataGridView.Rows(row.Index).Cells(11).Value.ToString(), PrintFont, Brushes.Black, 100, 500)
            e.Graphics.DrawString("To Time:  " & ReservationsDataGridView.Rows(row.Index).Cells(12).Value.ToString(), PrintFont, Brushes.Black, 100, 550)
            e.Graphics.DrawString("No. Of Adults:  " & ReservationsDataGridView.Rows(row.Index).Cells(13).Value, PrintFont, Brushes.Black, 100, 600)
            e.Graphics.DrawString("No. Of Children:  " & ReservationsDataGridView.Rows(row.Index).Cells(14).Value, PrintFont, Brushes.Black, 100, 650)
            e.Graphics.DrawString("Total Amount:  " & ReservationsDataGridView.Rows(row.Index).Cells(17).Value, PrintFont, Brushes.Black, 100, 700)
        Next
    End Sub

    Private Sub PrintReservationToolStripMenuItem_Click(sender As Object,
                                                        e As EventArgs) Handles PrintReservationToolStripMenuItem.Click
        PrintPreviewDialog1.WindowState = FormWindowState.Normal
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDialog1.ClientSize = New Size(600, 600)

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub SendReminderToolStripMenuItem_Click(sender As Object,
                                                    e As EventArgs) Handles SendReminderToolStripMenuItem.Click
        If ReservationsDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a row.")
            Exit Sub
        ElseIf ReservationsDataGridView.SelectedRows.Count > 1 Then
            MessageBox.Show("Select only one row.")
            Exit Sub
        End If

        For Each row As DataGridViewRow In ReservationsDataGridView.SelectedRows

            'Send an email to the customer/organization
            Dim BodyOfEmailString, RecipientEmailString As String

            BodyOfEmailString = "Greetings " & ReservationsDataGridView.Rows(row.Index).Cells(0).Value & "," & Environment.NewLine & Environment.NewLine &
            "This is to remind you, that you have a reservation booked on: " & ReservationsDataGridView.Rows(row.Index).Cells(9).Value & " at " & ReservationsDataGridView.Rows(row.Index).Cells(11).Value.ToString() & Environment.NewLine &
            "Please note that the reservation will be cancelled if you do not arrive within 15 minutes of the reserved time. " & Environment.NewLine & Environment.NewLine &
            "Regards," & Environment.NewLine &
            "Sakura Management"

            RecipientEmailString = ReservationsDataGridView.Rows(row.Index).Cells(3).Value

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
                mail.Subject = "Sakura Japanese Sushi & Hibachi - Reservation reminder"
                mail.Body = BodyOfEmailString
                SmtpServer.Send(mail)

                MessageBox.Show("Reminder sent to: " & ReservationsDataGridView.Rows(row.Index).Cells(3).Value)
            Catch ex As Exception

            End Try
        Next

    End Sub

End Class