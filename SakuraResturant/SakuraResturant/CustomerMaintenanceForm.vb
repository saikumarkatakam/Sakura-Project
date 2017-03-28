Public Class CustomerMaintenanceForm

    Friend AddUpdateString, EmailIDString As String
    Friend CustomerIDInteger, EmployeeIDInteger As Integer
    Private CustomerAccess As New SakuraClass
    Private Sub CustomerMaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerAccess.ExecuteQuery("SELECT c.customerID AS 'Customer ID', c.firstName AS 'First Name',
                                     c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number', h.street AS 'Street', h.city AS 'City', h.state AS 'State', h.zipcode AS 'Zip Code',
                                     c.primaryEmailID AS 'Email ID - Primary', c.secondaryEmailID AS 'Email ID - Secondary', c.custPassword AS 'Password'
                                     FROM customer AS c JOIN houseaddress AS h
                                     ON c.addressID = h.addressID WHERE c.active = 1")
        If CustomerAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(CustomerAccess.ExceptionString)
            Exit Sub
        End If

        CustomerDataGridView.DataSource = CustomerAccess.DBDataTable
        CustomerDataGridView.ReadOnly = True
        CustomerDataGridView.AllowUserToAddRows = False
        CustomerDataGridView.AutoResizeColumns()

    End Sub

    Private Sub RefreshDataGridView()
        CustomerAccess.ExecuteQuery("SELECT c.customerID AS 'Customer ID', c.firstName AS 'First Name',
                                     c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number', h.street AS 'Street', h.city AS 'City', h.state AS 'State', h.zipcode AS 'Zip Code',
                                     c.primaryEmailID AS 'Email ID - Primary', c.secondaryEmailID AS 'Email ID - Secondary', c.custPassword AS 'Password'
                                     FROM customer AS c JOIN houseaddress AS h
                                     ON c.addressID = h.addressID WHERE c.active = 1")
        If CustomerAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(CustomerAccess.ExceptionString)
            Exit Sub
        End If

        CustomerDataGridView.DataSource = CustomerAccess.DBDataTable
        CustomerDataGridView.ReadOnly = True
        CustomerDataGridView.AllowUserToAddRows = False
        CustomerDataGridView.AutoResizeColumns()
    End Sub

    Private Sub AddCustomerToolStripMenuItem_Click(sender As Object,
                                               e As EventArgs) Handles AddCustomerToolStripMenuItem.Click
        AddUpdateString = "&Add"
        AddUpdateCustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerDataGridView_CellDoubleClick(sender As Object,
                                                      e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellDoubleClick
        AddUpdateString = "&Update"
        CustomerIDInteger = CustomerDataGridView.Item(0, e.RowIndex).Value
        AddUpdateCustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub DeleteCustomerToolStripMenuItem_Click(sender As Object,
                                                      e As EventArgs) Handles DeleteCustomerToolStripMenuItem.Click

        If MessageBox.Show("You are going to delete the selected customer. " & Environment.NewLine &
                             " Are you sure you want to delete the selected customer record?",
                   "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        'Delete/archive the customer record
        CustomerAccess.AddParam("@customerID", CustomerIDInteger)
        CustomerAccess.ExecuteQuery("UPDATE customer SET active = 0 WHERE customerID = ?")

        'Throw exception if Delete fails
        If CustomerAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(CustomerAccess.ExceptionString)
            Exit Sub
        End If

        'Check if the email ID is linked to an employee as well
        CustomerAccess.AddParam("@email", EmailIDString)
        CustomerAccess.ExecuteQuery("SELECT employeeID FROM employee WHERE email = ?")
        If CustomerAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(CustomerAccess.ExceptionString)
            Exit Sub
        End If

        If CustomerAccess.RecordCountInteger > 0 Then
            EmployeeIDInteger = CustomerAccess.DBDataTable(0)!employeeID

            CustomerAccess.AddParam("@employeeID", EmployeeIDInteger)
            CustomerAccess.ExecuteQuery("UPDATE employee SET active = 0 WHERE employeeID = ?")

            'Throw exception if Delete fails
            If CustomerAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(CustomerAccess.ExceptionString)
                Exit Sub
            End If
        End If

        MessageBox.Show("Customer successfully deleted.")
        RefreshDataGridView()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object,
                                            e As EventArgs) Handles ExitToolStripMenuItem.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellClick
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            DeleteCustomerToolStripMenuItem.Enabled = False
            Exit Sub
        End If

        CustomerIDInteger = CustomerDataGridView.Item(0, e.RowIndex).Value
        EmailIDString = CustomerDataGridView.Item(8, e.RowIndex).Value
        DeleteCustomerToolStripMenuItem.Enabled = True
    End Sub
End Class