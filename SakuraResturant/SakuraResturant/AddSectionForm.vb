Public Class AddSectionForm

    Private AddSection As New SakuraClass

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        AddUpdateSectionForm.Show()
        Me.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        'Validations
        If SectionNameTextBox.Text = String.Empty Then
            MessageBox.Show("Section Name cannot be blank")
            Exit Sub
        ElseIf SectionCapacityTextBox.Text = String.Empty Or SectionCapacityTextBox.Text = 0 Then
            MessageBox.Show("Capacity cannot be blank or 0")
            Exit Sub
        End If

        AddSection.AddParam("@sectionName", SectionNameTextBox.Text)
        AddSection.ExecuteQuery("SELECT sectionID FROM section WHERE sectionName =?")
        If AddSection.ExceptionString <> String.Empty Then
            MessageBox.Show(AddSection.ExceptionString)
            Exit Sub
        End If

        If AddSection.RecordCountInteger > 0 Then
            MessageBox.Show("Section Name already exists")
            Exit Sub
        End If

        AddSection.AddParam("@sectionName", SectionNameTextBox.Text)
        AddSection.AddParam("@capacity", SectionCapacityTextBox.Text)
        AddSection.ExecuteQuery("INSERT INTO section(sectionName, capacity) VALUES(?,?)")
        If AddSection.ExceptionString <> String.Empty Then
            MessageBox.Show(AddSection.ExceptionString)
            Exit Sub
        End If

        MessageBox.Show("Section " & SectionNameTextBox.Text & " added.")
        SectionNameTextBox.Clear()
        SectionCapacityTextBox.Clear()

    End Sub
End Class