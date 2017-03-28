Public Class EmployeeMainForm

    Friend ViewTypeString As String
    Private Emp As New SakuraClass
    Private Sub EmployeeMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the welcome String
        EmployeeNameLabel.Text = "Welcome,  " & Login.EmployeeFirstNameString & " " &
                                                Login.EmployeeLastNameString
        'Based on the position, only display few menu strip items
        If Login.EmployeePositionString = "manager" Or Login.EmployeePositionString = "Manager" Then
            ReservationsToolStripMenuItem.Enabled = False
            CustomerToolStripMenuItem.Enabled = False
            EmployeeToolStripMenuItem.Enabled = False
            MaintenanceToolStripMenuItem.Enabled = False
            ScheduleToolStripMenuItem.Enabled = True
            ReportsToolStripMenuItem.Enabled = True
            CustomersToolStripMenuItem.Enabled = True
            EmployeesToolStripMenuItem.Enabled = True
        ElseIf Login.EmployeePositionString = "admin" Or Login.EmployeePositionString = "Admin" Then
            ReservationsToolStripMenuItem.Enabled = False
            CustomerToolStripMenuItem.Enabled = True
            EmployeeToolStripMenuItem.Enabled = True
            MaintenanceToolStripMenuItem.Enabled = True
            ScheduleToolStripMenuItem.Enabled = False
            ReportsToolStripMenuItem.Enabled = False
            ViewToolStripMenuItem.Enabled = True
            CustomersToolStripMenuItem.Enabled = True
            EmployeesToolStripMenuItem.Enabled = True
        ElseIf Login.EmployeePositionString = "associate" Or Login.EmployeePositionString = "Associate" Then
            ReservationsToolStripMenuItem.Enabled = True
            CustomerToolStripMenuItem.Enabled = False
            EmployeeToolStripMenuItem.Enabled = False
            MaintenanceToolStripMenuItem.Enabled = False
            ScheduleToolStripMenuItem.Enabled = True
            ReportsToolStripMenuItem.Enabled = False
            CustomersToolStripMenuItem.Enabled = True
            EmployeesToolStripMenuItem.Enabled = True
        Else
            ReservationsToolStripMenuItem.Enabled = False
            CustomerToolStripMenuItem.Enabled = False
            EmployeeToolStripMenuItem.Enabled = False
            MaintenanceToolStripMenuItem.Enabled = False
            ScheduleToolStripMenuItem.Enabled = False
            ReportsToolStripMenuItem.Enabled = False
            CustomersToolStripMenuItem.Enabled = True
            EmployeesToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        MenuMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub SectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionToolStripMenuItem.Click
        AddUpdateSectionForm.Show()
        Me.Close()
    End Sub

    Private Sub DiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscountsToolStripMenuItem.Click
        DiscountsForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewTodaysReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTodaysReservationsToolStripMenuItem.Click
        ScheduleListForm.ScheduleListLabel.Text = "Today's Reservations"
        ScheduleListForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewFutureReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFutureReservationsToolStripMenuItem.Click
        ScheduleListForm.ScheduleListLabel.Text = "Future Reservations"
        ScheduleListForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewPastReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPastReservationsToolStripMenuItem.Click
        ScheduleListForm.ScheduleListLabel.Text = "Past Reservations"
        ScheduleListForm.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        EmployeeMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub ReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationsToolStripMenuItem.Click
        ReservationMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        CustomerMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        ViewTypeString = "Customers"
        ViewCustomerEmployeeForm.Show()
        Me.Close()
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        ViewTypeString = "Employees"
        ViewCustomerEmployeeForm.Show()
        Me.Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object,
                                                      e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Login.DB.ChangePasswordString = Me.Name
        ChangePasswordForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewSectionReportToolStripMenuItem1_Click(sender As Object,
                                                          e As EventArgs) Handles ViewSectionReportToolStripMenuItem1.Click
        SectionReportForm.Show()
        Me.Hide()
    End Sub

    Private Sub ByCityToolStripMenuItem_Click(sender As Object,
                                              e As EventArgs) Handles ByCityToolStripMenuItem.Click
        ViewCityReservationForm.Show()
        Me.Hide()
    End Sub

    Private Sub ByCustomerToolStripMenuItem_Click(sender As Object,
                                                  e As EventArgs) Handles ByCustomerToolStripMenuItem.Click
        ViewCustomerReservationForm.Show()
        Me.Hide()
    End Sub

    Private Sub ByEmployeeToolStripMenuItem_Click(sender As Object,
                                                  e As EventArgs) Handles ByEmployeeToolStripMenuItem.Click
        EmployeeReservationForm.Show()
        Me.Hide()
    End Sub

    Private Sub ChangePersonalInfoToolStripMenuItem_Click(sender As Object,
                                                          e As EventArgs) Handles ChangePersonalInfoToolStripMenuItem.Click
        ChangePersonalInfoForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewTimeReportToolStripMenuItem_Click(sender As Object,
                                                      e As EventArgs) Handles ViewTimeReportToolStripMenuItem.Click
        ViewPeakTimeForm.Show()
        Me.Hide()
    End Sub
End Class