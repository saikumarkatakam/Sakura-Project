Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration

Public Class ChangePasswordForm

    Private PwdAccess As New SakuraClass
    Private Sub ChangeButton_Click(sender As Object,
                                   e As EventArgs) Handles ChangeButton.Click

        Dim PasswordString, NewPasswordString As String
        Dim CustBoolean As Boolean = False
        Dim EmpBoolean As Boolean = False

        'Validations
        If CurrentPwdTextBox.Text = String.Empty Then
            MessageBox.Show("Current password must be entered.")
            Exit Sub
        ElseIf NewPwdTextBox.Text = String.Empty Then
            MessageBox.Show("New password must be entered.")
            Exit Sub
        ElseIf ConfirmNewPwdTextBox.Text = String.Empty Then
            MessageBox.Show("New password must be re-entered.")
            Exit Sub
        End If

        If ResetPwdLabel.Text = "Passwords match" Then
            'First encrypt the current password to match it with the 
            'email ID of the customer
            PasswordString = EncryptData(CurrentPwdTextBox.Text)

            PwdAccess.AddParam("@customerID", Login.CustomerIDInteger)
            PwdAccess.AddParam("@password", PasswordString)
            PwdAccess.ExecuteQuery("SELECT custPassword FROM customer WHERE customerID = ? AND custPassword = ? AND active = 1")
            If PwdAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(PwdAccess.ExceptionString)
                Exit Sub
            End If

            If PwdAccess.RecordCountInteger = 0 Then
                CustBoolean = True
            End If

            PwdAccess.AddParam("@employeeID", Login.EmployeeIDInteger)
            PwdAccess.AddParam("@password", PasswordString)
            PwdAccess.ExecuteQuery("SELECT empPassword FROM employee WHERE employeeID = ? AND empPassword = ? AND active = 1")
            If PwdAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(PwdAccess.ExceptionString)
                Exit Sub
            End If

            If PwdAccess.RecordCountInteger = 0 Then
                EmpBoolean = True
            End If

            If CustBoolean = True And EmpBoolean = True Then
                MessageBox.Show("Incorrect current password")
                Exit Sub
            End If

            'Next, encrypt the new password
            NewPasswordString = EncryptData(ConfirmNewPwdTextBox.Text)

            PwdAccess.AddParam("@password", NewPasswordString)
            PwdAccess.AddParam("@emailID", Login.CustomerIDInteger)
            PwdAccess.ExecuteQuery("UPDATE customer SET custPassword = ? WHERE customerID = ?")
            If PwdAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(PwdAccess.ExceptionString)
                Exit Sub
            End If

            'Change it in the employee table as well
            If Login.EmployeeIDInteger > 0 Then
                PwdAccess.AddParam("@password", NewPasswordString)
                PwdAccess.AddParam("@emailID", Login.EmployeeIDInteger)
                PwdAccess.ExecuteQuery("UPDATE employee SET empPassword = ? WHERE employeeID = ?")
                If PwdAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(PwdAccess.ExceptionString)
                    Exit Sub
                End If
            End If

            MessageBox.Show("Password successfully changed.")

            If Login.DB.ChangePasswordString = "EmployeeMainForm" Then
                EmployeeMainForm.Show()
            ElseIf Login.Db.ChangePasswordString = "CustomerLogin" Then
                CustomerLogin.Show()
            End If
            Me.Close()
        End If

    End Sub

    Private Sub ConfirmNewPwdTextBox_TextChanged(sender As Object,
                                                 e As EventArgs) Handles ConfirmNewPwdTextBox.TextChanged

        If NewPwdTextBox.Text <> ConfirmNewPwdTextBox.Text Then
            ResetPwdLabel.Text = "Passwords do not match"
        Else
            ResetPwdLabel.Text = "Passwords match"
        End If
    End Sub

    Public Function EncryptData(ByVal PlainTextString As String) As String

        Dim PasswordString As String = PlainTextString 'The password to be encrypted
        Dim HashedDataByte As Byte() 'Byte array containing the encrypted string
        Dim Encoder As New UTF8Encoding() 'Used to convert the string into byte format
        Dim Md5Hasher As New MD5CryptoServiceProvider 'MD5 is an encryption method

        HashedDataByte = Md5Hasher.ComputeHash(Encoder.GetBytes(PlainTextString))

        'Convert the byte array into a string
        Return Convert.ToBase64String(HashedDataByte)

    End Function

    Private Sub CancelButton_Click(sender As Object,
                                   e As EventArgs) Handles CancelButton.Click
        If Login.DB.ChangePasswordString = "EmployeeMainForm" Then
            EmployeeMainForm.Show()
        ElseIf Login.DB.ChangePasswordString = "CustomerLogin" Then
            CustomerLogin.Show()
        End If
        Me.Close()
    End Sub
End Class