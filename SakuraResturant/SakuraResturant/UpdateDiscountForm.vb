Public Class UpdateDiscountForm

    Private DiscountIDString, ValidFromString, ValidToString As String
    Private UpdateAccess As New SakuraClass

    Private Sub UpdateDiscountForm_Load(sender As Object,
                                        e As EventArgs) Handles MyBase.Load

        DiscountIDString = DiscountsForm.DiscountIDString
        UpdateAccess.AddParam("@discountID", DiscountIDString)
        UpdateAccess.ExecuteQuery("SELECT * FROM discount WHERE discountID = ? AND active = 1")
        If UpdateAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(UpdateAccess.ExceptionString)
            Exit Sub
        End If

        DiscountIDTextBox.Text = DiscountIDString
        DescriptionTextBox.Text = UpdateAccess.DBDataTable(0)!discountDescription
        DiscountValueTextBox.Text = UpdateAccess.DBDataTable(0)!discountPercent
        If UpdateAccess.DBDataTable(0)!validFrom IsNot DBNull.Value Then
            ValidFromDateTimePicker.Value = UpdateAccess.DBDataTable(0)!validFrom
        Else
            ValidFromDateTimePicker.CustomFormat = " "
            ValidFromString = "0000-00-00"
        End If

        If UpdateAccess.DBDataTable(0)!validTo IsNot DBNull.Value Then
            ValidToDateTimePicker.Value = UpdateAccess.DBDataTable(0)!validTo
        Else
            ValidToDateTimePicker.CustomFormat = " "
            ValidToString = "0000-00-00"
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        DiscountsForm.Show()
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object,
                                   e As EventArgs) Handles UpdateButton.Click

        'UpdateAccess.AddParam("@description", DescriptionTextBox.Text)
        'UpdateAccess.AddParam("@value", Decimal.Parse(DiscountValueTextBox.Text))
        'UpdateAccess.AddParam("@validFrom", ValidFromDateTimePicker.Text)
        'UpdateAccess.AddParam("@validTo", ValidToDateTimePicker.Text)
        'UpdateAccess.AddParam("@discountID", DiscountIDTextBox.Text)

        Dim QueryString As String

        If ValidFromDateTimePicker.Text <> " " Then
            ValidFromString = ValidFromDateTimePicker.Text
        Else
            ValidFromString = "0000-00-00"
        End If

        If ValidToDateTimePicker.Text <> " " Then
            ValidToString = ValidToDateTimePicker.Text
        Else
            ValidToString = "0000-00-00"
        End If

        QueryString = "UPDATE discount SET discountDescription = '" & DescriptionTextBox.Text & "', discountPercent = " & DiscountValueTextBox.Text & ", validFrom = '" & ValidFromString & "', validTo = '" & ValidToString & "' WHERE discountID = '" & DiscountIDTextBox.Text & "'"
        UpdateAccess.ExecuteQuery(QueryString)
        If UpdateAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(UpdateAccess.ExceptionString)
            Exit Sub
        End If

        MessageBox.Show("Discount ID " & DiscountIDTextBox.Text & " updated successfully.")

    End Sub
End Class