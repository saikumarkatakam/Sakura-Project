Public Class ViewCustomerEmployeeForm

    Private ViewAccess As New SakuraClass

    Private Sub ViewCustomerEmployeeForm_Load(sender As Object,
                                              e As EventArgs) Handles MyBase.Load
        'Based on whether it is a customer or an employee, show the corresponding
        'details
        If EmployeeMainForm.ViewTypeString = "Customers" Then
            ViewAccess.ExecuteQuery("SELECT c.customerID AS 'Customer ID', c.firstName AS 'First Name',
                                     c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number', h.street AS 'Street', h.city AS 'City', h.state AS 'State', h.zipcode AS 'Zip Code',
                                     c.primaryEmailID AS 'Email ID - Primary', c.secondaryEmailID AS 'Email ID - Secondary'
                                     FROM customer AS c JOIN houseaddress AS h
                                     ON c.addressID = h.addressID WHERE c.active = 1")
            If ViewAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ViewAccess.ExceptionString)
                Exit Sub
            End If
        Else
            ViewAccess.ExecuteQuery("SELECT e.employeeID AS 'Employee ID', e.firstName AS 'First Name', 
                                     e.lastName AS 'Last Name', s.firstName AS 'Supervisor First Name', s.lastName AS 'Supervisor Last Name',
                                     h.street AS 'Street', h.city AS 'City', h.state AS 'State',
                                     h.zipcode AS 'Zip Code', e.position AS 'Position', e.phoneNumber AS 'Phone Number',
                                     e.email AS 'Email ID' FROM employee AS e
                                     LEFT JOIN employee AS s ON s.employeeID = e.supervisorID
                                     JOIN houseaddress AS h ON e.addressID = h.addressID WHERE e.active = 1")
            If ViewAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ViewAccess.ExceptionString)
                Exit Sub
            End If
        End If

        CustEmpDataGridView.DataSource = ViewAccess.DBDataTable
        CustEmpDataGridView.ReadOnly = True
        CustEmpDataGridView.AllowUserToAddRows = False
        CustEmpDataGridView.AutoResizeColumns()

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub
End Class