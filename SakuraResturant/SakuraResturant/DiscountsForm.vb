Public Class DiscountsForm

    Private DiscountAccess As New SakuraClass
    Friend DiscountIDString As String

    Private Sub AddDiscountToolStripMenuItem_Click(sender As Object,
                                                   e As EventArgs) Handles AddDiscountToolStripMenuItem.Click
        'Make the add discount group box visible
        AddDiscountGroupBox.Visible = True
        'Make the datagridview, the buttons, search label and search text box invisible
        DiscountDataGridView.Visible = False
        DBCancelButton.Visible = False
        SearchLabel.Visible = False
        SearchDiscountIDTextBox.Visible = False
        SearchDiscountIDTextBox.Clear()

        TemporaryRadioButton.Checked = False
        DatesGroupBox.Enabled = False

    End Sub

    Private Sub TemporaryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TemporaryRadioButton.CheckedChanged
        If TemporaryRadioButton.Checked Then
            DatesGroupBox.Enabled = True
        Else
            DatesGroupBox.Enabled = False
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim QueryString, FromDateString, ToDateString As String

        'Add a discount value to the database
        'Validations
        ErrorProvider1.Clear()
        If DiscountIDTextBox.Text = String.Empty Then
            ErrorProvider1.SetError(DiscountIDTextBox, "Discount ID cannot be blank")
            Exit Sub
        ElseIf DescriptionTextBox.Text = String.Empty Then
            ErrorProvider1.SetError(DescriptionTextBox, "Discount description cannot be blank")
            Exit Sub
        ElseIf DiscountValueTextBox.Text = String.Empty Or DiscountValueTextBox.Text = 0 Then
            ErrorProvider1.SetError(DiscountValueTextBox, "Discount value cannot be blank or 0")
            Exit Sub
        End If

        'Check if discount ID already exists
        DiscountAccess.AddParam("@discountID", DiscountIDTextBox.Text)
        DiscountAccess.ExecuteQuery("SELECT discountID FROM discount WHERE discountID =? AND active = 1")
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If

        If DiscountAccess.RecordCountInteger > 0 Then
            MessageBox.Show("Discount ID already exists.")
            Exit Sub
        End If

        'If it does not exist, add to the table

        ValidFromDateTimePicker.CustomFormat = "yyyy-MM-dd"
        ValidToDateTimePicker.CustomFormat = "yyyy-MM-dd"
        If TemporaryRadioButton.Checked Then
            FromDateString = ValidFromDateTimePicker.Text
            ToDateString = ValidToDateTimePicker.Text
        Else
            FromDateString = "0000-00-00"
            ToDateString = "0000-00-00"
        End If
        ValidFromDateTimePicker.CustomFormat = "MM-dd-yyyy"
        ValidToDateTimePicker.CustomFormat = "MM-dd-yyyy"

        QueryString = "INSERT INTO discount(discountID, discountDescription," &
                      "discountPercent, validFrom, validTo, active)" &
                      "VALUES('" & DiscountIDTextBox.Text & "', '" & DescriptionTextBox.Text & "' , " & Decimal.Parse(DiscountValueTextBox.Text) & ", '" & FromDateString & "', '" & ToDateString & "', 1)"
        DiscountAccess.ExecuteQuery(QueryString)
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If

        MessageBox.Show("Discount ID " & DiscountIDTextBox.Text & " added.")

        DiscountIDTextBox.Clear()
        DescriptionTextBox.Clear()
        DiscountValueTextBox.Clear()
        TemporaryRadioButton.Checked = False
        DatesGroupBox.Enabled = False

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        AddDiscountGroupBox.Visible = False
        DiscountIDTextBox.Clear()
        DescriptionTextBox.Clear()
        DiscountValueTextBox.Clear()
        ValidFromDateTimePicker.Value = Date.Now
        ValidToDateTimePicker.Value = Date.Now
        TemporaryRadioButton.Checked = False
    End Sub

    Private Sub SearchDiscountIDTextBox_KeyUp(sender As Object,
                                              e As EventArgs) Handles SearchDiscountIDTextBox.KeyUp

        DiscountAccess.AddParam("@discountID", SearchDiscountIDTextBox.Text & "%")
        DiscountAccess.ExecuteQuery("SELECT discountID AS 'Discount ID', discountDescription AS 'Discount Description',
                                     discountPercent AS 'Discount Value', validFrom AS 'Valid From', validTo AS 'Valid To' FROM discount
                                     WHERE discountID LIKE ? AND active = 1")
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If
    End Sub

    Private Sub UpdateDiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDiscountToolStripMenuItem.Click

        DiscountDataGridView.Visible = True
        AddDiscountGroupBox.Visible = False
        DBCancelButton.Visible = True

    End Sub

    Private Sub DeleteDiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDiscountToolStripMenuItem.Click

        DiscountDataGridView.Visible = True
        AddDiscountGroupBox.Visible = False
        DBCancelButton.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub

    Private Sub DBCancelButton_Click(sender As Object, e As EventArgs) Handles DBCancelButton.Click
        DiscountDataGridView.Visible = False
        DBCancelButton.Visible = False
    End Sub

    Private Sub DiscountDataGridView_CellDoubleClick(sender As Object,
                                                     e As DataGridViewCellEventArgs) Handles DiscountDataGridView.CellDoubleClick
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Exit Sub
        End If

        DiscountIDString = DiscountDataGridView.Item(0, e.RowIndex).Value
        UpdateDiscountForm.show()
        Me.Close()

    End Sub

    Private Sub DiscountsForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        DiscountAccess.ExecuteQuery("SELECT discountID AS 'Discount ID', discountDescription AS 'Discount Description',
                                     discountPercent AS 'Discount Value', validFrom AS 'Valid From', validTo AS 'Valid To' FROM discount
                                     WHERE active = 1")
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If

        DiscountDataGridView.DataSource = DiscountAccess.DBDataTable
        DiscountDataGridView.ReadOnly = True
        DiscountDataGridView.AllowUserToAddRows = False
        DiscountDataGridView.AutoResizeColumns()

    End Sub

    Private Sub DiscountDataGridView_CellClick(sender As Object,
                                               e As DataGridViewCellEventArgs) Handles DiscountDataGridView.CellClick
        Dim QueryString As String

        If DiscountDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Select one row.")
            Exit Sub
        ElseIf DiscountDataGridView.SelectedRows.Count > 1 Then
            MessageBox.Show("Select only one row.")
            Exit Sub
        End If

        If MessageBox.Show("You are going to delete the selected discount ID. " &
               "Are you sure?",
               "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        DiscountIDString = DiscountDataGridView.Rows(e.RowIndex).Cells(0).Value

        QueryString = String.Empty
        QueryString = "UPDATE discount SET active = 0 WHERE discountID = '" & DiscountIDString & "'"
        DiscountAccess.ExecuteQuery(QueryString)
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If

        MessageBox.Show("Discount ID " & DiscountDataGridView.Rows(e.RowIndex).Cells(0).Value & "deleted.")
    End Sub
End Class