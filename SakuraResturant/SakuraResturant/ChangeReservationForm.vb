Public Class ChangeReservationForm

    Private ChangeAccess As New SakuraClass
    Friend ReservationIDInteger As Integer

    Private Sub ChangeReservationForm_Load(sender As Object,
                                           e As EventArgs) Handles MyBase.Load
        'Display the customer name
        CustomerNameTextBox.Text = Login.CustomerFirstNameString & " " &
                                   Login.CustomerLastNameString
        'Display all the reservations of that customer
        'from the current date onwards
        ChangeAccess.AddParam("@customerID", Login.CustomerIDInteger)
        ChangeAccess.ExecuteQuery("SELECT r.reservationID AS 'Reservation ID', s.sectionName AS 'Section Name', 
                                        r.discountID AS 'Discount ID', d.discountPercent AS 'Discount Value',
                                        r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', 
                                        r.fromDate AS 'From Date', r.toDate AS 'To Date',
                                        r.fromTime AS 'From Time', r.toTime AS 'To Time', 
                                        r.numberOfAdults AS 'Number Of Adults', r.numberOfChildren AS 'Number Of Children', 
                                        r.totalAmount AS 'Total Amount' FROM reservation as r 
                                        JOIN section as s ON r.sectionID = s.sectionID
                                        JOIN discount as d ON d.discountID = r.discountID
                                        WHERE r.customerID = ? AND r.reservationStatus = ""Reserved""")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        'Display the details in the datagrid view
        ReservationsDataGridView.DataSource = ChangeAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AllowUserToAddRows = False
        ReservationsDataGridView.AutoResizeColumns()

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Login.DB.CallingFormString = "CustomerLogin"
        CustomerLogin.Show()
        Me.Close()
    End Sub

    Private Sub ReservationsDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReservationsDataGridView.CellDoubleClick
        ReservationIDInteger = ReservationsDataGridView.Rows(e.RowIndex).Cells(0).Value
        IndividualReservationForm.Show()
    End Sub

    Private Sub ChangeReservationForm_Activated(sender As Object,
                                                e As EventArgs) Handles Me.Activated
        Login.DB.ReservationString = Me.Name
        Login.DB.CallingFormString = Me.Name
    End Sub
End Class