Public Class EmployeeReservationForm

    Private EmpDataSet As EmployeeDataSet
    Private EmpDataAdapter As EmployeeDataSetTableAdapters.EmployeeTableAdapter

    Private Sub EmployeeReservationForm_Load(sender As Object,
                                             e As EventArgs) Handles MyBase.Load
        Try
            EmpDataSet = New EmployeeDataSet
            Dim EmployeeReport As New EmployeeCrystalReport
            Dim EmpDataAdapter As New EmployeeDataSetTableAdapters.EmployeeTableAdapter

            EmpDataAdapter.Fill(EmpDataSet.Employee)
            EmployeeReport.SetDataSource(EmpDataSet)
            EmployeeCrystalReportViewer.ReportSource = EmployeeReport
            EmployeeCrystalReportViewer.Refresh()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EmployeeReservationForm_FormClosed(sender As Object,
                                                   e As FormClosedEventArgs) Handles Me.FormClosed
        EmployeeMainForm.Show()
        Me.Hide()
    End Sub
End Class