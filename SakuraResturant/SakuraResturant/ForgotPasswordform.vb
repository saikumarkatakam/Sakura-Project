Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class ForgotPasswordform
    Public DB As New SakuraClass
    Public TempPasswordString As String
    Public CustomerIDInteger, EmployeeIDInteger As Integer
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If EmailIDTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter an email ID")
        End If

        DB.AddParam("@emailID", EmailIDTextBox.Text)
        DB.ExecuteQuery("SELECT * FROM employee WHERE email =?")
        If DB.ExceptionString <> String.Empty Then
            MessageBox.Show(DB.ExceptionString)
            Exit Sub
        End If

        If DB.RecordCountInteger > 0 Then
            EmployeeIDInteger = DB.DBDataTable(0)!employeeID

            DB.AddParam("@employeeID", EmployeeIDInteger)
            DB.ExecuteQuery("UPDATE employee SET empPassword = 'ResetPwd123' WHERE employeeID = ?")
            If DB.ExceptionString <> String.Empty Then
                MessageBox.Show(DB.ExceptionString)
                Exit Sub
            End If
        End If

        DB.AddParam("@primaryEmailID", EmailIDTextBox.Text)
        DB.ExecuteQuery("SELECT * FROM customer WHERE primaryEmailID=?")
        If DB.ExceptionString <> String.Empty Then
            MessageBox.Show(DB.ExceptionString)
            Exit Sub
        End If

        If DB.RecordCountInteger = 0 Then
            MessageBox.Show("Email ID does not exist")
            Exit Sub
        Else
            TempPasswordString = "ResetPwd123"
            CustomerIDInteger = DB.DBDataTable(0)!customerID

            DB.AddParam("@customerID", CustomerIDInteger)
            DB.ExecuteQuery("UPDATE customer SET custPassword = 'ResetPwd123' WHERE customerID =?")
            If DB.ExceptionString <> String.Empty Then
                MessageBox.Show(DB.ExceptionString)
                Exit Sub
            End If

            SendEmail(EmailIDTextBox.Text)
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Public Function GetRandomString(ByVal iLength As Integer) As String
        Dim sResult As String = ""
        Dim allowChrs() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789!@#$%^&*".ToCharArray()
        Dim rdm As New Random()

        For i As Integer = 0 To iLength - 1
            sResult += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Return sResult
    End Function

    Private Sub SendEmail(EmailID)

        'Send an email to the customer/organization
        Dim BodyOfEmailString, RecipientEmailString As String

        BodyOfEmailString = "Greetings, " & Environment.NewLine &
        "Your temporary password is: " & TempPasswordString & " " & Environment.NewLine &
        "Please try to login with the temporary password, and reset your password." & Environment.NewLine &
        "Regards," & Environment.NewLine &
        "Sakura Management"

        RecipientEmailString = EmailID

        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New _
            Net.NetworkCredential("sakurarestaurantmanagement@gmail.com", "Sakura@123")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("sakurarestaurantmanagement@gmail.com")
            mail.To.Add(RecipientEmailString)
            mail.Subject = "Sakura Japanese Sushi & Hibachi - Password Reset"
            mail.Body = BodyOfEmailString
            SmtpServer.Send(mail)
            MsgBox("Email sent successfully to " + EmailID)
        Catch ex As Exception

        End Try

    End Sub
End Class