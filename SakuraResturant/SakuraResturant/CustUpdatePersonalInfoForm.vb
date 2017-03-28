Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration

Public Class CustUpdatePersonalInfoForm

    Private ChangeAccess As New SakuraClass
    Private Sub CustUpdatePersonalInfoForm_Load(sender As Object,
                                                e As EventArgs) Handles MyBase.Load
        'Display the required details in the text boxes
        ChangeAccess.AddParam("@customerID", Login.CustomerIDInteger)
        ChangeAccess.ExecuteQuery("SELECT * FROM customer WHERE customerID =?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        CustomerIDTextBox.Text = ChangeAccess.DBDataTable(0)!customerID
        FirstNameTextBox.Text = ChangeAccess.DBDataTable(0)!firstName
        LastNameTextBox.Text = ChangeAccess.DBDataTable(0)!lastName
        PhoneNumberTextBox.Text = ChangeAccess.DBDataTable(0)!phoneNumber
        PrimaryEmailIDTextBox.Text = ChangeAccess.DBDataTable(0)!primaryEmailID
        If ChangeAccess.DBDataTable(0)!secondaryEmailID IsNot DBNull.Value Then
            SecondaryEmailIDTextBox.Text = ChangeAccess.DBDataTable(0)!secondaryEmailID
        End If

        ChangeAccess.AddParam("@addressID", ChangeAccess.DBDataTable(0)!addressID)
        ChangeAccess.ExecuteQuery("SELECT * FROM houseaddress WHERE addressID = ?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        StreetTextBox.Text = ChangeAccess.DBDataTable(0)!street
        CityTextBox.Text = ChangeAccess.DBDataTable(0)!city
        StateComboBox.Text = ChangeAccess.DBDataTable(0)!state
        ZipcodeTextBox.Text = ChangeAccess.DBDataTable(0)!zipcode

        'Populate the state combo box
        For Each item As String In Login.StateArray
            StateComboBox.Items.Add(item)
        Next
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

    Private Sub ChangeButton_Click(sender As Object,
                                   e As EventArgs) Handles ChangeButton.Click

        Dim ErrorString As String
        Dim AddressIDInteger As Integer

        'Validations
        ErrorString = Validations()
        If ErrorString <> String.Empty Then
            MessageBox.Show(ErrorString)
            Exit Sub
        End If

        'Update the customer and if needed, the employee table
        ChangeAccess.AddParam("@firstName", FirstNameTextBox.Text)
        ChangeAccess.AddParam("@lastName", LastNameTextBox.Text)
        ChangeAccess.AddParam("@phoneNumber", PhoneNumberTextBox.Text)
        ChangeAccess.AddParam("@primaryEmail", PrimaryEmailIDTextBox.Text)
        ChangeAccess.AddParam("@secondaryEmail", SecondaryEmailIDTextBox.Text)
        ChangeAccess.AddParam("@customerID", CustomerIDTextBox.Text)
        ChangeAccess.ExecuteQuery("UPDATE customer SET firstName =?, lastName =?, phoneNumber =?,
                                          primaryEmailID=?, secondaryEmailID =? WHERE customerID = ?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        'Update Address details
        ChangeAccess.AddParam("@customerID", CustomerIDTextBox.Text)
        ChangeAccess.ExecuteQuery("SELECT addressID FROM customer WHERE customerID = ?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If
        AddressIDInteger = ChangeAccess.DBDataTable(0)!addressID

        ChangeAccess.AddParam("@street", StreetTextBox.Text)
        ChangeAccess.AddParam("@city", CityTextBox.Text)
        ChangeAccess.AddParam("@state", StateComboBox.Text)
        ChangeAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
        ChangeAccess.AddParam("@addressID", AddressIDInteger)
        ChangeAccess.ExecuteQuery("UPDATE houseaddress SET street = ?, city = ?, state = ?, zipcode = ? WHERE addressID =?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        If Login.EmployeeIDInteger > 0 Then
            ChangeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            ChangeAccess.AddParam("@lastName", LastNameTextBox.Text)
            ChangeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            ChangeAccess.AddParam("@email", PrimaryEmailIDTextBox.Text)
            ChangeAccess.AddParam("@employeeID", Login.EmployeeIDInteger)

            ChangeAccess.ExecuteQuery("UPDATE employee SET firstName = ?, lastName = ?,
                                             phoneNumber = ?, email = ? WHERE employeeID = ?")
            If ChangeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ChangeAccess.ExceptionString)
                Exit Sub
            End If
        End If

        MessageBox.Show("Customer details updated.")

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
        CustomerLogin.Show()
        Me.Close()
    End Sub

End Class