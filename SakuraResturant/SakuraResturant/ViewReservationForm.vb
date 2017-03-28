Public Class ViewReservationForm

    Private ViewAccess As New SakuraClass
    
    Private Sub BackToolStripMenuItem_Click(sender As Object,
                                            e As EventArgs) Handles BackToolStripMenuItem.Click
        CustomerLogin.Show()
        Me.Close()
    End Sub

    Private Sub ViewReservationForm_Load(sender As Object,
                                         e As EventArgs) Handles MyBase.Load
        'Display all the reservations for that particular person
        ViewAccess.AddParam("@customerID", Login.CustomerIDInteger)
        ViewAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount', r.reservationStatus AS 'Reservation Status' FROM reservation as r 
                                        JOIN section as s ON r.sectionID = s.sectionID
                                        JOIN discount as d ON d.discountID = r.discountID
                                        WHERE r.customerID = ?")
        If ViewAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ViewAccess.ExceptionString)
            Exit Sub
        End If

        ViewDataGridView.DataSource = ViewAccess.DBDataTable
        ViewDataGridView.ReadOnly = True
        ViewDataGridView.AllowUserToAddRows = False
        ViewDataGridView.AutoResizeColumns()
    End Sub

    Private Sub ReservationComboBox_SelectedIndexChanged(sender As Object,
                                                         e As EventArgs) Handles ReservationComboBox.SelectedIndexChanged
        If ReservationComboBox.SelectedItem <> "" Then
            ViewAccess.AddParam("@customerID", Login.CustomerIDInteger)
            ViewAccess.AddParam("@reservationStatus", ReservationComboBox.SelectedItem)
            ViewAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount', r.reservationStatus AS 'Reservation Status' FROM reservation as r 
                                        JOIN section as s ON r.sectionID = s.sectionID
                                        JOIN discount as d ON d.discountID = r.discountID
                                        WHERE r.customerID = ? AND r.reservationStatus = ?")
            If ViewAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ViewAccess.ExceptionString)
                Exit Sub
            End If
        Else
            ViewAccess.AddParam("@customerID", Login.CustomerIDInteger)
            ViewAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount', r.reservationStatus AS 'Reservation Status' FROM reservation as r 
                                        JOIN section as s ON r.sectionID = s.sectionID
                                        JOIN discount as d ON d.discountID = r.discountID
                                        WHERE r.customerID = ?")
            If ViewAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ViewAccess.ExceptionString)
                Exit Sub
            End If
        End If

        ViewDataGridView.DataSource = ViewAccess.DBDataTable
        ViewDataGridView.ReadOnly = True
        ViewDataGridView.AllowUserToAddRows = False
        ViewDataGridView.AutoResizeColumns()
    End Sub
End Class