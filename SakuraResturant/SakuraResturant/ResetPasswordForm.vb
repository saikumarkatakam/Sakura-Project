Public Class ResetPasswordForm

    Private Reset As New SakuraClass
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Login.Show()
        Me.Close()
    End Sub
    Private Sub ResetPasswordButton_Click(sender As Object, e As EventArgs) Handles ResetPasswordButton.Click
        If TempPasswordTextBox.Text <> ForgotPasswordform.TempPasswordString Then
            MessageBox.Show("Incorrect Temporary Password")
            Exit Sub
        End If

        If EmailIDTextBox.Text = String.Empty Then
            MessageBox.Show("Email ID must be provided")
            Exit Sub
        Else
            Reset.AddParam("@emailID", EmailIDTextBox.Text)
            Reset.ExecuteQuery("SELECT * FROM customer WHERE primaryEmailID = ?")
            If Reset.ExceptionString <> String.Empty Then
                MessageBox.Show(Reset.ExceptionString)
                Exit Sub
            End If

            If Reset.RecordCountInteger = 0 Then
                MessageBox.Show("Email ID does not exist")
                Exit Sub
            End If

        End If
        ResetPasswordGroupBox.Visible = True
    End Sub

    Private Sub ConfirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.TextChanged
        'Compare first and second Passwords
        If ResetPasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            PasswordMatchLabel.Text = "Passwords do not match"
        Else
            PasswordMatchLabel.Text = "Passwords match"
        End If
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If PasswordMatchLabel.Text = "Passwords do not match" Then
            Exit Sub
        Else

            Dim PasswordString As String = Login.EncryptData(ResetPasswordTextBox.Text)

            If ForgotPasswordform.CustomerIDInteger > 0 Then
                Login.DB.AddParam("@password", PasswordString)
                Login.DB.AddParam("@customerID", ForgotPasswordform.CustomerIDInteger)

                Login.DB.ExecuteQuery("UPDATE customer SET custPassword = ? WHERE customerID=?")
                If Login.DB.ExceptionString <> String.Empty Then
                    MessageBox.Show(Login.DB.ExceptionString)
                    Exit Sub
                End If
            End If

            If ForgotPasswordform.EmployeeIDInteger > 0 Then
                Login.DB.AddParam("@password", PasswordString)
                Login.DB.AddParam("@employeeID", ForgotPasswordform.EmployeeIDInteger)

                Login.DB.ExecuteQuery("UPDATE employee SET empPassword = ? WHERE employeeID = ?")

                If Login.DB.ExceptionString <> String.Empty Then
                    MessageBox.Show(Login.DB.ExceptionString)
                    Exit Sub
                End If
            End If

            MessageBox.Show("Your password has been reset successfully. Please login again")
            ForgotPasswordform.TempPasswordString = String.Empty
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class