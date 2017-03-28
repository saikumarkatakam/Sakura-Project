Public Class EmployeeMaintenanceForm

    Friend AddUpdateString As String
    Friend EmployeeIDInteger, CustomerIDInteger As Integer
    Private EmailIDString As String
    Private EmployeeAccess As New SakuraClass
    Private Sub EmployeeMaintenanceForm_Load(sender As Object,
                                             e As EventArgs) Handles MyBase.Load
        EmployeeAccess.ExecuteQuery("SELECT e.employeeID AS 'Employee ID', e.firstName AS 'First Name', 
                                     e.lastName AS 'Last Name', s.firstName AS 'Supervisor First Name', s.lastName AS 'Supervisor Last Name',
                                     h.street AS 'Street', h.city AS 'City', h.state AS 'State',
                                     h.zipcode AS 'Zip Code', e.position AS 'Position', e.phoneNumber AS 'Phone Number',
                                     e.email AS 'Email ID' FROM employee AS e
                                     LEFT JOIN employee AS s ON s.employeeID = e.supervisorID
                                     JOIN houseaddress AS h ON e.addressID = h.addressID WHERE e.active = 1")
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If

        EmployeeDataGridView.DataSource = EmployeeAccess.DBDataTable
        EmployeeDataGridView.ReadOnly = True
        EmployeeDataGridView.AutoResizeColumns()
        EmployeeDataGridView.AllowUserToAddRows = False

    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object,
                                               e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        AddUpdateString = "&Add"
        AddUpdateEmployeeForm.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object,
                                            e As EventArgs) Handles ExitToolStripMenuItem.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeDataGridView_CellDoubleClick(sender As Object,
                                                     e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellDoubleClick
        AddUpdateString = "&Update"
        EmployeeIDInteger = EmployeeDataGridView.Item(0, e.RowIndex).Value
        AddUpdateEmployeeForm.Show()
        Me.Close()
    End Sub

    Private Sub RefreshGridView()
        EmployeeAccess.ExecuteQuery("SELECT e.employeeID AS 'Employee ID', e.firstName AS 'First Name', 
                                     e.lastName AS 'Last Name', s.firstName AS 'Supervisor First Name', s.lastName AS 'Supervisor Last Name',
                                     h.street AS 'Street', h.city AS 'City', h.state AS 'State',
                                     h.zipcode AS 'Zip Code', e.position AS 'Position', e.phoneNumber AS 'Phone Number',
                                     e.email AS 'Email ID' FROM employee AS e
                                     LEFT JOIN employee AS s ON s.employeeID = e.supervisorID
                                     JOIN houseaddress AS h ON e.addressID = h.addressID WHERE e.active = 1")
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If

        EmployeeDataGridView.DataSource = EmployeeAccess.DBDataTable
        EmployeeDataGridView.ReadOnly = True
        EmployeeDataGridView.AutoResizeColumns()
        EmployeeDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object,
                                                      e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click

        Dim PositionString As String
        Dim SupervisorIDInteger As Integer

        'Delete employee based on employee ID
        If MessageBox.Show("You are going to delete the selected employee." & Environment.NewLine &
                            "Are you sure you want to delete the selected employee record?",
                           "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        'Check if employee is supervisor
        EmployeeAccess.AddParam("@EmployeeID", EmployeeIDInteger)
        EmployeeAccess.ExecuteQuery("SELECT position FROM employee WHERE employeeID = ?")
        'Throw exception
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If
        PositionString = EmployeeAccess.DBDataTable(0)!position

        If PositionString = "Manager" Then
            SupervisorIDInteger = EmployeeIDInteger
        End If

        EmployeeAccess.AddParam("@EmployeeID", EmployeeIDInteger)
        EmployeeAccess.ExecuteQuery("UPDATE employee SET active = 0 WHERE employeeID = ?")

        'Throw exception if Delete fails
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If

        'In case the person deleted is a supervisor, clear the field "Supervisor"
        'for the employees reporting to them
        EmployeeAccess.AddParam("@supervisorID", SupervisorIDInteger)
        EmployeeAccess.ExecuteQuery("UPDATE employee SET supervisorID = null WHERE supervisorID = ?")
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If

        'Delete from Customer table as well
        EmployeeAccess.AddParam("@Email", EmailIDString)
        EmployeeAccess.ExecuteQuery("SELECT customerID FROM customer WHERE primaryEmailID = ?")
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If

        If EmployeeAccess.RecordCountInteger > 0 Then
            CustomerIDInteger = EmployeeAccess.DBDataTable(0)!customerID

            EmployeeAccess.AddParam("@customerID", CustomerIDInteger)
            EmployeeAccess.ExecuteQuery("UPDATE customer SET active = 0 WHERE customerID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If
        End If
        MessageBox.Show("Employee deleted successfully.")
        RefreshGridView()

    End Sub

    Private Sub EmployeeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellClick
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            DeleteEmployeeToolStripMenuItem.Enabled = False
            Exit Sub
        End If

        EmployeeIDInteger = EmployeeDataGridView.Item(0, e.RowIndex).Value
        EmailIDString = EmployeeDataGridView.Item(11, e.RowIndex).Value
        DeleteEmployeeToolStripMenuItem.Enabled = True
    End Sub
End Class