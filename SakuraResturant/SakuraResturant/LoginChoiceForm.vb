Public Class LoginChoiceForm
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If CustomerRadioButton.Checked = True Then
            'Welcome message
            MessageBox.Show("Welcome, " & Login.CustomerFirstNameString & " !")
            CustomerLogin.Show()
            Me.Close()
        End If

        If EmployeeRadioButton.Checked = True Then
            EmployeeMainForm.Show()
            Me.Close()
        End If
    End Sub
End Class