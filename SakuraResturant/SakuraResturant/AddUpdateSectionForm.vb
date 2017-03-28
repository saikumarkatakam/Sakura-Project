Public Class AddUpdateSectionForm

    Private SectionAccess As New SakuraClass
    Friend SectionIDInteger As Integer
    Private Sub AddUpdateSectionForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        SectionAccess.ExecuteQuery("SELECT sectionID AS 'Section ID', sectionName AS 'Section Name', 
                                    capacity AS 'Capacity' FROM section WHERE active = 1")
        If SectionAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(SectionAccess.ExceptionString)
            Exit Sub
        End If

        SectionDataGridView.DataSource = SectionAccess.DBDataTable
        SectionDataGridView.ReadOnly = True
        SectionDataGridView.AllowUserToAddRows = False
        SectionDataGridView.AllowUserToDeleteRows = False
        SectionDataGridView.AutoResizeColumns()
    End Sub

    Private Sub AddSectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSectionToolStripMenuItem.Click
        AddSectionForm.Show()
        Me.Close()
    End Sub

    Private Sub SectionDataGridView_CellDoubleClick(sender As Object,
                                                     e As DataGridViewCellEventArgs) Handles SectionDataGridView.CellDoubleClick

        'If nothing is clicked within the data grid view
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Exit Sub
        End If

        'On double click, update existing sections
        SectionIDInteger = SectionDataGridView.Item(0, e.RowIndex).Value
        UpdateSectionForm.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub
End Class