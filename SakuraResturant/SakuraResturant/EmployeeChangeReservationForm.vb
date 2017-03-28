Public Class EmployeeChangeReservationForm

    Friend ReservationAccess As New SakuraClass
    Friend EmpReservationIDInteger As Integer

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ReservationMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeChangeReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Login.DB.ReservationString = Me.Name
        Login.DB.CallingFormString = Me.Name

        ReservationAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', c.firstName AS 'First Name', c.LastName AS 'Last Name', 
                                        r.paymentStatus AS 'Payment Status', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount' FROM reservation as r 
                                        JOIN customer AS c ON c.customerID = r.customerID
                                        JOIN section as s ON r.sectionID = s.sectionID
                                        JOIN discount as d ON d.discountID = r.discountID
                                        WHERE r.reservationStatus = 'Reserved'")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ReservationAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AllowUserToAddRows = False
        ReservationsDataGridView.AutoResizeColumns()
    End Sub

    Private Sub ReservationsDataGridView_CellDoubleClick(sender As Object,
                                                          e As DataGridViewCellEventArgs) Handles ReservationsDataGridView.CellDoubleClick

        EmpReservationIDInteger = ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value
        EmployeeIndividualReservationForm.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeChangeReservationForm_Activated(sender As Object,
                                                        e As EventArgs) Handles Me.Activated

        Login.DB.ReservationString = Me.Name
        Login.DB.CallingFormString = Me.Name

        ReservationAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', c.firstName AS 'First Name', c.LastName AS 'Last Name', 
                                        r.paymentStatus AS 'Payment Status', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount' FROM reservation as r 
                                        JOIN customer AS c ON c.customerID = r.customerID
                                        JOIN section as s ON r.sectionID = s.sectionID
                                        JOIN discount as d ON d.discountID = r.discountID
                                        WHERE r.reservationStatus = 'Reserved'")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ReservationAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AllowUserToAddRows = False
        ReservationsDataGridView.AutoResizeColumns()
    End Sub

    Private Sub FirstNameTextBox_Keyup(sender As Object,
                                   e As EventArgs) Handles FirstNameTextBox.KeyUp

        ReservationAccess.AddParam("@firstName", FirstNameTextBox.Text & "%")
        ReservationAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', c.firstName AS 'Customer First Name',
                                        c.lastNAme AS 'Customer Last Name', c.primaryEmailID AS 'Email ID', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount' FROM reservation as r 
                                        JOIN customer AS c ON r.customerID = c.customerID
                                        JOIN section AS s ON r.sectionID = s.sectionID
                                        JOIN discount AS d ON d.discountID = r.discountID WHERE c.firstName LIKE ? AND r.reservationStatus = ""Reserved""")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ReservationAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AllowUserToAddRows = False
        ReservationsDataGridView.AutoResizeColumns()

    End Sub

    Private Sub LastNameTextBox_KeyUp(sender As Object,
                                            e As EventArgs) Handles LastNameTextBox.KeyUp

        ReservationAccess.AddParam("@lastName", LastNameTextBox.Text & "%")
        ReservationAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', c.firstName AS 'Customer First Name',
                                        c.lastNAme AS 'Customer Last Name', c.primaryEmailID AS 'Email ID', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount' FROM reservation as r 
                                        JOIN customer AS c ON r.customerID = c.customerID
                                        JOIN section AS s ON r.sectionID = s.sectionID
                                        JOIN discount AS d ON d.discountID = r.discountID WHERE c.lastName LIKE ? AND r.reservationStatus = ""Reserved""")
        If ReservationAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ReservationAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ReservationAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AllowUserToAddRows = False
        ReservationsDataGridView.AutoResizeColumns()
    End Sub

End Class