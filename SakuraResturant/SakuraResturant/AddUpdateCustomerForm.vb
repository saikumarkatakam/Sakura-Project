Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class AddUpdateCustomerForm

    Private AddUpdateAccess As New SakuraClass
    Private AddressIDInteger, EmployeeIDInteger, CustomerIDInteger As Integer

    Private Sub AddUpdateCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CustomerMaintenanceForm.AddUpdateString = "&Add" Then
            CustomerIDLabel.Visible = False
            CustomerIDTextBox.Visible = False
            PrimaryEmailIDTextBox.ReadOnly = False
        Else
            CustomerIDLabel.Visible = True
            CustomerIDTextBox.Visible = True
            CustomerIDTextBox.ReadOnly = True
            PrimaryEmailIDTextBox.ReadOnly = True

            'Display the required details in the text boxes
            AddUpdateAccess.AddParam("@customerID", CustomerMaintenanceForm.CustomerIDInteger)
            AddUpdateAccess.ExecuteQuery("SELECT * FROM customer WHERE customerID =?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            CustomerIDTextBox.Text = AddUpdateAccess.DBDataTable(0)!customerID
            FirstNameTextBox.Text = AddUpdateAccess.DBDataTable(0)!firstName
            LastNameTextBox.Text = AddUpdateAccess.DBDataTable(0)!lastName
            PhoneNumberTextBox.Text = AddUpdateAccess.DBDataTable(0)!phoneNumber
            PrimaryEmailIDTextBox.Text = AddUpdateAccess.DBDataTable(0)!primaryEmailID
            If AddUpdateAccess.DBDataTable(0)!secondaryEmailID IsNot DBNull.Value Then
                SecondaryEmailIDTextBox.Text = AddUpdateAccess.DBDataTable(0)!secondaryEmailID
            End If


            AddUpdateAccess.AddParam("@addressID", AddUpdateAccess.DBDataTable(0)!addressID)
            AddUpdateAccess.ExecuteQuery("SELECT * FROM houseaddress WHERE addressID = ?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            StreetTextBox.Text = AddUpdateAccess.DBDataTable(0)!street
            CityTextBox.Text = AddUpdateAccess.DBDataTable(0)!city
            StateComboBox.Text = AddUpdateAccess.DBDataTable(0)!state
            ZipcodeTextBox.Text = AddUpdateAccess.DBDataTable(0)!zipcode
        End If

        'Populate the state combo box
        For Each item As String In Login.StateArray
            StateComboBox.Items.Add(item)
        Next

        AddUpdateButton.Text = CustomerMaintenanceForm.AddUpdateString
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
        CustomerMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Function Validations()

        Dim ErrorString As String

        If FirstNameTextBox.Text = String.Empty Then
            ErrorString = "First Name cannot be empty."
            Return ErrorString
        ElseIf LastNameTextBox.Text = String.Empty Then
            ErrorString = "Last Name cannot be empty."
            Return ErrorString
        ElseIf PhoneNumberTextBox.Text = String.Empty Then
            ErrorString = "Phone number cannot be empty."
            Return ErrorString
        ElseIf PrimaryEmailIDTextBox.Text = String.Empty Then
            ErrorString = "Primary Email ID cannot be empty."
            Return ErrorString
        ElseIf StreetTextBox.Text = String.Empty Then
            ErrorString = "Street cannot be empty."
            Return ErrorString
        ElseIf CityTextBox.Text = String.Empty Then
            ErrorString = "City cannot be empty."
            Return ErrorString
        ElseIf StateComboBox.Text = String.Empty Then
            ErrorString = "State cannot be empty."
            Return ErrorString
        ElseIf ZipcodeTextBox.Text = String.Empty Then
            ErrorString = "Zip code cannot be empty."
            Return ErrorString
        End If

    End Function

    Private Sub AddUpdateButton_Click(sender As Object,
                                      e As EventArgs) Handles AddUpdateButton.Click

        Dim PasswordString, ErrorString As String
        Dim CustIDInteger As Integer

        'Validations
        ErrorString = Validations()
        If ErrorString <> String.Empty Then
            MessageBox.Show(ErrorString)
            Exit Sub
        End If

        If AddUpdateButton.Text = "&Add" Then

            AddUpdateAccess.AddParam("@email", PrimaryEmailIDTextBox.Text)
            AddUpdateAccess.ExecuteQuery("SELECT customerID, active FROM customer WHERE primaryEmailID = ?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            If AddUpdateAccess.RecordCountInteger > 0 Then

                CustIDInteger = AddUpdateAccess.DBDataTable(0)!customerID

                If AddUpdateAccess.DBDataTable(0)!active = 0 Then
                    'Activate the same customer
                    AddUpdateAccess.AddParam("@customerID", CustIDInteger)
                    AddUpdateAccess.ExecuteQuery("UPDATE customer SET active = 1 WHERE customerID = ?")
                    If AddUpdateAccess.ExceptionString <> String.Empty Then
                        MessageBox.Show(AddUpdateAccess.ExceptionString)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Email ID already exists.")
                    Exit Sub
                End If
            End If

            'Insert customer and houseaddress tables
            'First check if the same address already exists in the houseaddress table
            AddUpdateAccess.AddParam("@street", StreetTextBox.Text)
            AddUpdateAccess.AddParam("@city", CityTextBox.Text)
            AddUpdateAccess.AddParam("@state", StateComboBox.Text)
            AddUpdateAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
            AddUpdateAccess.ExecuteQuery("SELECT addressID FROM houseaddress WHERE street = ? AND city = ? AND state = ? AND zipcode = ?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            If AddUpdateAccess.RecordCountInteger > 0 Then
                AddressIDInteger = AddUpdateAccess.DBDataTable(0)!addressID
            Else
                AddUpdateAccess.AddParam("@street", StreetTextBox.Text)
                AddUpdateAccess.AddParam("@city", CityTextBox.Text)
                AddUpdateAccess.AddParam("@state", StateComboBox.Text)
                AddUpdateAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
                AddUpdateAccess.ExecuteQuery("INSERT INTO houseaddress(street, city, state, zipcode) VALUES(?,?,?,?)")
                If AddUpdateAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(AddUpdateAccess.ExceptionString)
                    Exit Sub
                End If

                AddUpdateAccess.ExecuteQuery("SELECT addressID FROM houseaddress ORDER BY addressID DESC LIMIT 1")
                If AddUpdateAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(AddUpdateAccess.ExceptionString)
                    Exit Sub
                End If
                AddressIDInteger = AddUpdateAccess.DBDataTable(0)!addressID
            End If

            AddUpdateAccess.AddParam("@addressID", AddressIDInteger)
            AddUpdateAccess.AddParam("@firstName", FirstNameTextBox.Text)
            AddUpdateAccess.AddParam("@lastName", LastNameTextBox.Text)
            AddUpdateAccess.AddParam("@phoneNumber", PhoneNumberTextBox.Text)
            AddUpdateAccess.AddParam("@active", 1)
            AddUpdateAccess.AddParam("@primaryEmail", PrimaryEmailIDTextBox.Text)
            AddUpdateAccess.AddParam("@secondaryEmail", SecondaryEmailIDTextBox.Text)
            AddUpdateAccess.AddParam("@password", "Welcome_01")
            AddUpdateAccess.AddParam("@createdOnDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            AddUpdateAccess.ExecuteQuery("INSERT INTO customer(addressID, firstName, lastName, phoneNumber,
                                          active, primaryEmailID, secondaryEmailID, custPassword, createdOnDate)
                                          VALUES(?,?,?,?,?,?,?,?,?)")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            'Get the CustomerID and EmployeeID (if it exists)
            AddUpdateAccess.AddParam("@emailID", PrimaryEmailIDTextBox.Text)
            AddUpdateAccess.ExecuteQuery("SELECT * FROM customer WHERE primaryEmailID =?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If
            ForgotPasswordform.CustomerIDInteger = AddUpdateAccess.DBDataTable(0)!customerID

            MessageBox.Show("Customer " & FirstNameTextBox.Text & " " & LastNameTextBox.Text & " added.")
            SendEmail(PrimaryEmailIDTextBox.Text)

        Else
            'Update the customer and if needed, the employee table
            AddUpdateAccess.AddParam("@firstName", FirstNameTextBox.Text)
            AddUpdateAccess.AddParam("@lastName", LastNameTextBox.Text)
            AddUpdateAccess.AddParam("@phoneNumber", PhoneNumberTextBox.Text)
            AddUpdateAccess.AddParam("@primaryEmail", PrimaryEmailIDTextBox.Text)
            AddUpdateAccess.AddParam("@secondaryEmail", SecondaryEmailIDTextBox.Text)
            AddUpdateAccess.AddParam("@customerID", CustomerIDTextBox.Text)
            AddUpdateAccess.ExecuteQuery("UPDATE customer SET firstName =?, lastName =?, phoneNumber =?,
                                          primaryEmailID=?, secondaryEmailID =? WHERE customerID = ?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            'Update Address details
            AddUpdateAccess.AddParam("@customerID", CustomerIDTextBox.Text)
            AddUpdateAccess.ExecuteQuery("SELECT addressID FROM customer WHERE customerID = ?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If
            AddressIDInteger = AddUpdateAccess.DBDataTable(0)!addressID

            AddUpdateAccess.AddParam("@street", StreetTextBox.Text)
            AddUpdateAccess.AddParam("@city", CityTextBox.Text)
            AddUpdateAccess.AddParam("@state", StateComboBox.Text)
            AddUpdateAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
            AddUpdateAccess.AddParam("@addressID", AddressIDInteger)
            AddUpdateAccess.ExecuteQuery("UPDATE houseaddress SET street = ?, city = ?, state = ?, zipcode = ? WHERE addressID =?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            AddUpdateAccess.AddParam("@emailID", PrimaryEmailIDTextBox.Text)
            AddUpdateAccess.ExecuteQuery("SELECT employeeID FROM employee WHERE email = ?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            If AddUpdateAccess.RecordCountInteger > 0 Then
                EmployeeIDInteger = AddUpdateAccess.DBDataTable(0)!employeeID
            End If

            If EmployeeIDInteger > 0 Then
                AddUpdateAccess.AddParam("@firstName", FirstNameTextBox.Text)
                AddUpdateAccess.AddParam("@lastName", LastNameTextBox.Text)
                AddUpdateAccess.AddParam("@phone", PhoneNumberTextBox.Text)
                AddUpdateAccess.AddParam("@email", PrimaryEmailIDTextBox.Text)
                AddUpdateAccess.AddParam("@employeeID", EmployeeIDInteger)

                AddUpdateAccess.ExecuteQuery("UPDATE employee SET firstName = ?, lastName = ?,
                                             phoneNumber = ?, email = ? WHERE employeeID = ?")
                If AddUpdateAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(AddUpdateAccess.ExceptionString)
                    Exit Sub
                End If
            End If

            MessageBox.Show("Customer " & CustomerIDTextBox.Text & " updated.")
        End If
    End Sub

    Private Sub SendEmail(EmailID)

        'Send an email to the customer/organization
        Dim BodyOfEmailString, RecipientEmailString As String

        BodyOfEmailString = "Greetings " & FirstNameTextBox.Text & "," & Environment.NewLine &
        "Thank you for being a customer of Sakura!" & Environment.NewLine &
        "Your temporary password is: Welcome_01" & Environment.NewLine &
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
            mail.Subject = "Sakura Japanese Sushi & Hibachi - Welcome!"
            mail.Body = BodyOfEmailString
            SmtpServer.Send(mail)
            MsgBox("Email sent successfully to " + EmailID)
        Catch ex As Exception

        End Try

    End Sub

End Class