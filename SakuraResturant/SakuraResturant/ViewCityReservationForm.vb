Public Class ViewCityReservationForm

    Private CDataSet As CityDataSet
    Private CityDataAdapter As CityDataSetTableAdapters.CityTableAdapter

    Private Sub ViewCityReservationForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        EmployeeMainForm.Show()
        Me.Hide()
    End Sub

    Private Sub ViewCityReservationForm_Load(sender As Object,
                                             e As EventArgs) Handles MyBase.Load
        Try
            CDataSet = New CityDataSet
            Dim CityReport As New CityCrystalReport
            Dim CityDataAdapter As New CityDataSetTableAdapters.CityTableAdapter

            CityDataAdapter.Fill(CDataSet.City)
            CityReport.SetDataSource(CDataSet)

            CityCrystalReportViewer.ReportSource = CityReport

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class