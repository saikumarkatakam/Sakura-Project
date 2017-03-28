Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class AddUpdateEmployeeForm

    Private EmployeeAccess As New SakuraClass
    Private AddressIDInteger, SupervisorIDInteger, CustomerIDInteger As Integer

    Private PasswordString, OriginalPasswordString As String

    Private Sub AddUpdateEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If EmployeeMaintenanceForm.AddUpdateString = "&Add" Then
            'Hide the employee ID
            EmployeeIDLabel.Visible = False
            EmployeeIDTextBox.Visible = False
            EmailTextBox.ReadOnly = False
        Else
            'Show the employee ID
            EmployeeIDLabel.Visible = True
            EmployeeIDTextBox.Visible = True
            EmployeeIDTextBox.ReadOnly = True
            EmailTextBox.ReadOnly = True

            EmployeeAccess.AddParam("@employeeID", EmployeeMaintenanceForm.EmployeeIDInteger)
            EmployeeAccess.ExecuteQuery("SELECT * FROM employee WHERE employeeID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            'Display the details in the respective text boxes
            EmployeeIDTextBox.Text = EmployeeAccess.DBDataTable(0)!employeeID
            FirstNameTextBox.Text = EmployeeAccess.DBDataTable(0)!firstName
            LastNameTextBox.Text = EmployeeAccess.DBDataTable(0)!lastName
            PositionComboBox.Text = EmployeeAccess.DBDataTable(0)!position
            If PositionComboBox.Text = "Staff" Then
                SubPositionTextBox.Enabled = True
                SubPositionLabel.Visible = True
                SubPositionTextBox.Text = EmployeeAccess.DBDataTable(0)!subPosition
            Else
                SubPositionTextBox.Enabled = False
                SubPositionLabel.Visible = False
                SubPositionTextBox.Clear()
            End If
            PhoneNumberTextBox.Text = EmployeeAccess.DBDataTable(0)!phoneNumber
            EmailTextBox.Text = EmployeeAccess.DBDataTable(0)!email

            If EmployeeAccess.DBDataTable(0)!supervisorID IsNot DBNull.Value Then
                SupervisorIDInteger = EmployeeAccess.DBDataTable(0)!supervisorID
            End If

            AddressIDInteger = EmployeeAccess.DBDataTable(0)!addressID

            EmployeeAccess.AddParam("@addressID", AddressIDInteger)
            EmployeeAccess.ExecuteQuery("SELECT * FROM houseaddress WHERE addressID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            StreetTextBox.Text = EmployeeAccess.DBDataTable(0)!street
            CityTextBox.Text = EmployeeAccess.DBDataTable(0)!city
            StateComboBox.Text = EmployeeAccess.DBDataTable(0)!state
            ZipcodeTextBox.Text = EmployeeAccess.DBDataTable(0)!zipcode

            If SupervisorIDInteger > 0 Then
                EmployeeAccess.AddParam("@employeeID", SupervisorIDInteger)
                EmployeeAccess.ExecuteQuery("SELECT firstName, lastName FROM employee
                                         WHERE employeeID = ?")
                If EmployeeAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(EmployeeAccess.ExceptionString)
                    Exit Sub
                End If
                SupervisorComboBox.Text = EmployeeAccess.DBDataTable(0)!firstName & " " & EmployeeAccess.DBDataTable(0)!lastName
            End If
        End If

        'Fill in the supervisor combo box
        EmployeeAccess.AddParam("@position", "Manager")
        EmployeeAccess.ExecuteQuery("SELECT firstName, lastName FROM employee
                                         WHERE position = ?")
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If

        'Add blank for supervisor as well
        SupervisorComboBox.Items.Add(" ")
        For Each item In EmployeeAccess.DBDataTable.Rows
            SupervisorComboBox.Items.Add(item("firstName") & " " & item("lastName"))
        Next

        'Fill the state combo box
        For Each item As String In Login.StateArray
            StateComboBox.Items.Add(item)
        Next

        'Change the name of the button to add/update an employee
        AddUpdateButton.Text = EmployeeMaintenanceForm.AddUpdateString

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        EmployeeMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click

        Dim ErrorString As String

        ErrorString = Validations()

        If ErrorString <> String.Empty Then
            MessageBox.Show(ErrorString)
            Exit Sub
        End If

        If AddUpdateButton.Text = "&Add" Then

            'Check if email ID already exists
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.ExecuteQuery("SELECT email FROM employee WHERE email = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            If EmployeeAccess.RecordCountInteger > 0 Then
                MessageBox.Show("Email ID already exists.")
                Exit Sub
            End If

            'Add the employee to the employee and houseaddress tables
            'First check if the same address already exists in the houseaddress table
            EmployeeAccess.AddParam("@street", StreetTextBox.Text)
            EmployeeAccess.AddParam("@city", CityTextBox.Text)
            EmployeeAccess.AddParam("@state", StateComboBox.Text)
            EmployeeAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
            EmployeeAccess.ExecuteQuery("SELECT addressID FROM houseaddress WHERE street = ? AND city = ? AND state = ? AND zipcode = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            If EmployeeAccess.RecordCountInteger > 0 Then
                AddressIDInteger = EmployeeAccess.DBDataTable(0)!addressID
            Else
                EmployeeAccess.AddParam("@street", StreetTextBox.Text)
                EmployeeAccess.AddParam("@city", CityTextBox.Text)
                EmployeeAccess.AddParam("@state", StateComboBox.Text)
                EmployeeAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
                EmployeeAccess.ExecuteQuery("INSERT INTO houseaddress(street, city, state, zipcode) VALUES (?,?,?,?)")
                If EmployeeAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(EmployeeAccess.ExceptionString)
                    Exit Sub
                End If

                EmployeeAccess.ExecuteQuery("SELECT addressID FROM houseaddress ORDER BY addressID DESC LIMIT 1")
                If EmployeeAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(EmployeeAccess.ExceptionString)
                    Exit Sub
                End If
                AddressIDInteger = EmployeeAccess.DBDataTable(0)!addressID
            End If

            If SupervisorIDInteger = 0 Then
                EmployeeAccess.AddParam("@supervisorID", DBNull.Value)
            Else
                EmployeeAccess.AddParam("@supervisorID", SupervisorIDInteger)
            End If
            EmployeeAccess.AddParam("@addressID", AddressIDInteger)
            EmployeeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            EmployeeAccess.AddParam("@lastName", LastNameTextBox.Text)
            EmployeeAccess.AddParam("@position", PositionComboBox.Text)
            EmployeeAccess.AddParam("@subposition", SubPositionTextBox.Text)
            EmployeeAccess.AddParam("@active", 1)
            EmployeeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.AddParam("@password", "Welcome_01")
            EmployeeAccess.AddParam("@createdOn", DateAndTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

            EmployeeAccess.ExecuteQuery("INSERT INTO employee(supervisorID, addressID, firstName, lastName,position,subPosition, active, phoneNumber, email, empPassword, createdOnDate) VALUES(?,?,?,?,?,?,?,?,?,?,?)")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            EmployeeAccess.ExecuteQuery("SELECT employeeID FROM employee ORDER BY employeeID DESC LIMIT 1")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            'Add to customer table
            EmployeeAccess.AddParam("@addressID", AddressIDInteger)
            EmployeeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            EmployeeAccess.AddParam("@lastName", LastNameTextBox.Text)
            EmployeeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            EmployeeAccess.AddParam("@active", 1)
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.AddParam("@password", "Welcome_01")
            EmployeeAccess.AddParam("@createdOn", DateAndTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

            EmployeeAccess.ExecuteQuery("INSERT INTO customer(addressID, firstName, lastName, phoneNumber,active, primaryEmailID, custPassword,createdOnDate) VALUES(?,?,?,?,?,?,?,?)")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            EmployeeAccess.ExecuteQuery("SELECT customerID FROM customer ORDER BY customerID DESC LIMIT 1")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            MessageBox.Show("Employee successfully added. Activation email sent to: " & EmailTextBox.Text)
            SendEmail(EmailTextBox.Text)

        Else
            'Update the employee and houseaddress tables
            EmployeeAccess.AddParam("@supervisorID", SupervisorIDInteger)
            EmployeeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            EmployeeAccess.AddParam("@lastName", LastNameTextBox.Text)
            EmployeeAccess.AddParam("@position", PositionComboBox.Text)
            EmployeeAccess.AddParam("@subposition", SubPositionTextBox.Text)
            EmployeeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.AddParam("@employeeID", EmployeeIDTextBox.Text)

            EmployeeAccess.ExecuteQuery("UPDATE employee SET supervisorID = ?, firstName = ?, lastName = ?, position = ?, subPosition = ?, phoneNumber = ?, email = ? WHERE employeeID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            'Update address table
            EmployeeAccess.AddParam("@employeeID", EmployeeIDTextBox.Text)
            EmployeeAccess.ExecuteQuery("SELECT addressID FROM employee WHERE employeeID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If
            AddressIDInteger = EmployeeAccess.DBDataTable(0)!addressID

            EmployeeAccess.AddParam("@street", StreetTextBox.Text)
            EmployeeAccess.AddParam("@city", CityTextBox.Text)
            EmployeeAccess.AddParam("@state", StateComboBox.Text)
            EmployeeAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
            EmployeeAccess.AddParam("@addressID", AddressIDInteger)
            EmployeeAccess.ExecuteQuery("UPDATE houseaddress SET street = ?, city = ?,
                                         state = ?, zipcode = ? WHERE addressID = ?")

            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            'Update Customer table
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.ExecuteQuery("SELECT customerID FROM customer WHERE primaryEmailID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            If EmployeeAccess.RecordCountInteger > 0 Then
                CustomerIDInteger = EmployeeAccess.DBDataTable(0)!customerID
            Else
                MessageBox.Show("Employee ID " & EmployeeIDTextBox.Text & " updated successfully.")
                Exit Sub
            End If

            EmployeeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            EmployeeAccess.AddParam("@lastName", LastNameTextBox.Text)
            EmployeeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.AddParam("@customerID", CustomerIDInteger)

            EmployeeAccess.ExecuteQuery("UPDATE customer SET firstName = ?, lastName = ?, phoneNumber = ?, 
                                         primaryEmailID = ? WHERE customerID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            MessageBox.Show("Employee ID " & EmployeeIDTextBox.Text & " updated successfully.")

        End If
    End Sub

    Private Sub SupervisorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupervisorComboBox.SelectedIndexChanged

        If SupervisorComboBox.Text <> String.Empty Then
            Dim NameString As String = SupervisorComboBox.SelectedItem
            Dim SplitString As String() = NameString.Split()

            EmployeeAccess.AddParam("@firstName", SplitString(0))
            EmployeeAccess.AddParam("@firstName", SplitString(1))
            EmployeeAccess.AddParam("@position", "Manager")

            EmployeeAccess.ExecuteQuery("SELECT employeeID FROM employee WHERE firstName = ? AND lastName = ? AND position = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            SupervisorIDInteger = EmployeeAccess.DBDataTable(0)!employeeID
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

    Private Sub SendEmail(EmailID)

        'Send an email to the customer/organization
        Dim BodyOfEmailString, RecipientEmailString As String

        BodyOfEmailString = "Greetings, " & Environment.NewLine & Environment.NewLine &
        "We are pleased to have you on-board the Sakura family!" & Environment.NewLine &
        "Your email ID is: " & EmailID & Environment.NewLine &
        "Your temporary password is: Welcome_01" & Environment.NewLine &
        "Please try to login with the temporary password, and reset the same." & Environment.NewLine &
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
        ElseIf PositionComboBox.Text = String.Empty Then
            ErrorString = "Position cannot be empty."
            Return ErrorString
        ElseIf PositionComboBox.Text = "Staff" And SubPositionTextBox.Text = String.Empty Then
            ErrorString = "Sub-position cannot be empty"
            Return ErrorString
        ElseIf EmailTextBox.Text = String.Empty Then
            ErrorString = "Email ID cannot be empty."
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

End Class