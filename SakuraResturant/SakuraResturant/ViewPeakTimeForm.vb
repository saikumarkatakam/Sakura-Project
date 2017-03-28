Public Class ViewPeakTimeForm

    Private TimeDataSet As PeakTimeDataSet
    Private TimeDataAdapter As PeakTimeDataSetTableAdapters.reservationTableAdapter

    Private Sub ViewPeakTimeForm_Load(sender As Object,
                                      e As EventArgs) Handles MyBase.Load
        Try
            TimeDataSet = New PeakTimeDataSet
            Dim TimeDataAdapter As New PeakTimeDataSetTableAdapters.reservationTableAdapter
            Dim TimeReport As New PeakTimeCrystalReport

            TimeDataAdapter.Fill(TimeDataSet.reservation)
            TimeReport.SetDataSource(TimeDataSet)

            PeakTimeCrystalReportViewer.ReportSource = TimeReport
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub ViewPeakTimeForm_FormClosed(sender As Object,
                                             e As FormClosedEventArgs) Handles Me.FormClosed
        EmployeeMainForm.Show()
        Me.Hide()
    End Sub
End Class