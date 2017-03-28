Public Class SectionReportForm

    Private SecDataSet As SectionDataSet
    Private SectionAdapter As SectionDataSetTableAdapters.SectionTableAdapter

    Private Sub SectionReportForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        EmployeeMainForm.Show()
        Me.Hide()
    End Sub

    Private Sub SectionReportForm_Load(sender As Object,
                                       e As EventArgs) Handles MyBase.Load
        Try
            SecDataSet = New SectionDataSet
            Dim SectionReport As New SectionCrystalReport
            Dim SectionAdapter As New SectionDataSetTableAdapters.SectionTableAdapter

            SectionAdapter.Fill(SecDataSet.Section)
            SectionReport.SetDataSource(SecDataSet)
            SectionCrystalReportViewer.ReportSource = SectionReport

        Catch ex As Exception

        End Try
    End Sub
End Class