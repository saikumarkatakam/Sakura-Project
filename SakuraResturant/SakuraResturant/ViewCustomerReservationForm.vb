Public Class ViewCustomerReservationForm
    Private CustDataSet As CustReserveDataSet
    Private CustomerAdapter As CustReserveDataSetTableAdapters.CustReserveDataTableTableAdapter

    Private Sub ViewCustomerReservationForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        EmployeeMainForm.Show()
        Me.Hide()
    End Sub

    Private Sub ViewCustomerReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CustDataSet = New CustReserveDataSet
            Dim CustomerReport As New CustReserveCrystalReport
            Dim CustomerAdapter As New CustReserveDataSetTableAdapters.CustReserveDataTableTableAdapter

            CustomerAdapter.Fill(CustDataSet.CustReserveDataTable)
            CustomerReport.SetDataSource(CustDataSet)

            CustReserveCrystalReportViewer.ReportSource = CustomerReport

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class