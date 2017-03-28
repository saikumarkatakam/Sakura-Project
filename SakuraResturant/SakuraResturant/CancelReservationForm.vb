Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class CancelReservationForm

    Private ReservationAccess As New SakuraClass
    Private TotalDecimal As Decimal
    Private ReservationIDInteger As Integer
    Private CustomerEmailString As String
    Private Sub BackToolStripMenuItem_Click(sender As Object,
                                        e As EventArgs) Handles BackToolStripMenuItem.Click
        CustomerLogin.Show()
        Me.Close()
    End Sub

    Private Sub ReservationDataGridView_CellDoubleClick(sender As Object,
                                                         e As DataGridViewCellEventArgs) Handles ReservationsDataGridView.CellDoubleClick
        Dim QueryString As String

        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Exit Sub
        End If

        ReservationIDInteger = ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value
        CustomerEmailString = ReservationsDataGridView.Rows(e.RowIndex).Cells(3).Value

        'Ask for confirmation, then delete the selected record
        If MessageBox.Show("You are going to cancel the selected reservation." &
                           " Are you sure?",
                           "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        QueryString = "UPDATE reservation SET reservationStatus = ""Cancelled"", refundID = " & ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value & "  WHERE reservationID =" & ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value & ""
        ReservationAccess.ExecuteQuery(QueryString)
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        'Delete from customerorder table if records exist for that reservation
        QueryString = "SELECT * FROM customerorder WHERE reservationID = " & ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value & ""
        ReservationAccess.ExecuteQuery(QueryString)
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        If ReservationAccess.RecordCountInteger > 0 Then
            QueryString = String.Empty
            QueryString = "UPDATE customerorder SET active = 0 WHERE reservationID = " & ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value & ""
            ReservationAccess.ExecuteQuery(QueryString)
            If ReservationAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ReservationAccess.ExceptionString)
                Exit Sub
            End If
        End If

        QueryString = "SELECT totalAmount FROM reservation WHERE reservationID = " & ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value & ""
        ReservationAccess.ExecuteQuery(QueryString)
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If
        TotalDecimal = ReservationAccess.DBDataTable(0)!totalAmount

        MessageBox.Show("Reservation " & ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value & " cancelled.")
        SendEmail(CustomerEmailString)
        MessageBox.Show("Cancellation & Refund details sent to: " & CustomerEmailString)
        'Refresh the grid
        CancelReservationForm_Load(sender, e)
    End Sub

    Private Sub CancelReservationForm_Load(sender As Object,
                                           e As EventArgs) Handles MyBase.Load

        ReservationAccess.AddParam("@customerID", Login.CustomerIDInteger)
        ReservationAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', c.firstName AS 'Customer First Name', 
                                        c.lastNAme AS 'Customer Last Name', c.primaryEmailID AS 'Email ID', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount' FROM reservation AS r 
                                        JOIN customer AS c ON r.customerID = c.customerID
                                        JOIN section AS s ON r.sectionID = s.sectionID
                                        JOIN discount AS d ON d.discountID = r.discountID WHERE c.customerID = ? AND r.reservationStatus = ""Reserved""")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ReservationAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AllowUserToAddRows = False
        ReservationsDataGridView.AutoResizeColumns()
    End Sub

    Private Sub SendEmail(EmailID)

        'Send an email to the customer/organization
        Dim BodyOfEmailString, RecipientEmailString As String


        BodyOfEmailString = "Greetings " & Login.CustomerFirstNameString & "," & Environment.NewLine & Environment.NewLine &
        "Your reservation has been cancelled. Please find the reservation details below: " & Environment.NewLine & Environment.NewLine &
        "Reservation ID: " & ReservationIDInteger & Environment.NewLine & Environment.NewLine &
        "Your Refund amount is: " & TotalDecimal & Environment.NewLine &
        "This amount will be refunded to you in 2-5 business days." & Environment.NewLine &
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
            mail.Subject = "Sakura Japanese Sushi & Hibachi - Reservation Cancellation & Refund information"
            mail.Body = BodyOfEmailString
            SmtpServer.Send(mail)
        Catch ex As Exception

        End Try

    End Sub
End Class