Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration

Public Class ChangePersonalInfoForm

    Private ChangeAccess As New SakuraClass
    Private AddressIDInteger, SupervisorIDInteger As Integer

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub

    Private Sub ChangePersonalInfoForm_Load(sender As Object,
                                            e As EventArgs) Handles MyBase.Load
        'Based on employeeID get all required details
        ChangeAccess.AddParam("@employeeID", Login.EmployeeIDInteger)
        ChangeAccess.ExecuteQuery("SELECT * FROM employee WHERE employeeID = ?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If
        AddressIDInteger = ChangeAccess.DBDataTable(0)!addressID

        'Display the details in the respective text boxes
        EmployeeIDTextBox.Text = ChangeAccess.DBDataTable(0)!employeeID
        FirstNameTextBox.Text = ChangeAccess.DBDataTable(0)!firstName
        LastNameTextBox.Text = ChangeAccess.DBDataTable(0)!lastName
        PositionTextBox.Text = ChangeAccess.DBDataTable(0)!position
        If PositionTextBox.Text = "Staff" Then
            SubPositionTextBox.Text = ChangeAccess.DBDataTable(0)!subPosition
        Else
            SubPositionTextBox.Clear()
        End If
        PhoneNumberTextBox.Text = ChangeAccess.DBDataTable(0)!phoneNumber
        EmailTextBox.Text = ChangeAccess.DBDataTable(0)!email

        If ChangeAccess.DBDataTable(0)!supervisorID IsNot DBNull.Value Then
            SupervisorIDInteger = ChangeAccess.DBDataTable(0)!supervisorID

            If SupervisorIDInteger > 0 Then
                ChangeAccess.AddParam("@employeeID", SupervisorIDInteger)
                ChangeAccess.ExecuteQuery("SELECT firstName, lastName FROM employee
                                         WHERE employeeID = ?")
                If ChangeAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(ChangeAccess.ExceptionString)
                    Exit Sub
                End If
                SupervisorTextBox.Text = ChangeAccess.DBDataTable(0)!firstName & " " & ChangeAccess.DBDataTable(0)!lastName
            End If
        End If

        ChangeAccess.AddParam("@addressID", AddressIDInteger)
        ChangeAccess.ExecuteQuery("SELECT * FROM houseaddress WHERE addressID = ?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        StreetTextBox.Text = ChangeAccess.DBDataTable(0)!street
        CityTextBox.Text = ChangeAccess.DBDataTable(0)!city
        StateComboBox.Text = ChangeAccess.DBDataTable(0)!state
        ZipcodeTextBox.Text = ChangeAccess.DBDataTable(0)!zipcode

        'Fill the state combo box
        For Each item As String In Login.StateArray
            StateComboBox.Items.Add(item)
        Next
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

    Private Sub ChangeButton_Click(sender As Object,
                                   e As EventArgs) Handles ChangeButton.Click

        Dim ErrorString, PasswordString As String

        ErrorString = Validations()

        If ErrorString <> String.Empty Then
            MessageBox.Show(ErrorString)
            Exit Sub
        End If

        'Update the employee and houseaddress tables
        ChangeAccess.AddParam("@supervisorID", SupervisorIDInteger)
        ChangeAccess.AddParam("@firstName", FirstNameTextBox.Text)
        ChangeAccess.AddParam("@lastName", LastNameTextBox.Text)
        ChangeAccess.AddParam("@position", PositionTextBox.Text)
        ChangeAccess.AddParam("@subposition", SubPositionTextBox.Text)
        ChangeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
        ChangeAccess.AddParam("@email", EmailTextBox.Text)
        ChangeAccess.AddParam("@employeeID", EmployeeIDTextBox.Text)

        ChangeAccess.ExecuteQuery("UPDATE employee SET supervisorID = ?, firstName = ?, lastName = ?, position = ?, subPosition = ?, phoneNumber = ?, email = ? WHERE employeeID = ?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        'Update address table
        ChangeAccess.AddParam("@employeeID", EmployeeIDTextBox.Text)
        ChangeAccess.ExecuteQuery("SELECT addressID FROM employee WHERE employeeID = ?")
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
        ChangeAccess.ExecuteQuery("UPDATE houseaddress SET street = ?, city = ?,
                                         state = ?, zipcode = ? WHERE addressID = ?")

        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        'Update Customer table
        ChangeAccess.AddParam("@email", EmailTextBox.Text)
        ChangeAccess.ExecuteQuery("SELECT customerID FROM customer WHERE primaryEmailID = ?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        If ChangeAccess.RecordCountInteger > 0 Then
            Login.CustomerIDInteger = ChangeAccess.DBDataTable(0)!customerID
        Else
            MessageBox.Show("Employee ID " & EmployeeIDTextBox.Text & " updated successfully.")
            Exit Sub
        End If

        ChangeAccess.AddParam("@firstName", FirstNameTextBox.Text)
        ChangeAccess.AddParam("@lastName", LastNameTextBox.Text)
        ChangeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
        ChangeAccess.AddParam("@email", EmailTextBox.Text)
        ChangeAccess.AddParam("@customerID", Login.CustomerIDInteger)

        ChangeAccess.ExecuteQuery("UPDATE customer SET firstName = ?, lastName = ?, phoneNumber = ?, 
                                         primaryEmailID = ? WHERE customerID = ?")
        If ChangeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ChangeAccess.ExceptionString)
            Exit Sub
        End If

        MessageBox.Show("Your employee details have been updated successfully.")

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