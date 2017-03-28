Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Login
    Public DB As New SakuraClass

    Private AddressIDInteger As Integer
    Private EmployeeBoolean, CustomerBoolean As Boolean
    Public CustomerIDInteger, EmployeeIDInteger As Integer
    Public CustomerFirstNameString, CustomerLastNameString, CustomerEmailIDString, EmployeeFirstNameString,
           EmployeeLastNameString, EmployeePositionString, EmployeeEmailString As String
    Public StateArray() As String = {" ", "ME", "NH", "VT", "MA", "CT", "RI", "NY", "VA", "NC",
            "SC", "GA", "FL", "DE", "NJ", "OH", "MI", "IL", "IN", "IA", "KS", "NE", "OK",
            "TX", "AL", "TN", "MO", "ND", "SD", "WY", "MT", "ID", "NV", "WA", "OR", "CO",
            "NM", "AZ", "WV", "PA", "CA", "AR", "HI", "MN", "WI", "MD", "MS", "AK", "LA",
            "UT", "KY"}

    Private Sub ForgotPasswordLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLinkLabel.LinkClicked
        ForgotPasswordform.ShowDialog()
    End Sub

    Private Sub SigninButton_Click(sender As Object, e As EventArgs) Handles SigninButton.Click

        Dim PasswordString As String

        DB.AddParam("@primaryEmailID", EmailIDTextBox.Text)
        DB.ExecuteQuery("SELECT custPassword FROM customer WHERE primaryEmailID=? AND active = 1")
        If DB.ExceptionString <> String.Empty Then
            MessageBox.Show(DB.ExceptionString)
            Exit Sub
        End If

        If DB.RecordCountInteger > 0 Then
            PasswordString = DB.DBDataTable(0)!custPassword
        Else
            DB.AddParam("@emailID", EmailIDTextBox.Text)
            DB.ExecuteQuery("SELECT * FROM employee WHERE email = ? AND active = 1")
            If DB.ExceptionString <> String.Empty Then
                MessageBox.Show(DB.ExceptionString)
                Exit Sub
            End If

            If DB.RecordCountInteger > 0 Then
                PasswordString = DB.DBDataTable(0)!empPassword
            End If

            If DB.RecordCountInteger = 0 Then
                MessageBox.Show("Email ID does not exist")
                Exit Sub
            End If
        End If

        'When a password has been reset or a new customer/employee has been added
        If PasswordString = "Welcome_01" Or PasswordString = "ResetPwd123" Then

            ForgotPasswordform.TempPasswordString = PasswordTextBox.Text

            DB.AddParam("@primaryEmailID", EmailIDTextBox.Text)
            DB.ExecuteQuery("SELECT customerID FROM customer WHERE primaryEmailID=? AND active = 1")
            If DB.ExceptionString <> String.Empty Then
                MessageBox.Show(DB.ExceptionString)
                Exit Sub
            End If

            If DB.RecordCountInteger > 0 Then
                ForgotPasswordform.CustomerIDInteger = DB.DBDataTable(0)!customerID
            End If

            DB.AddParam("@EmailID", EmailIDTextBox.Text)
            DB.ExecuteQuery("SELECT employeeID FROM employee WHERE email=? AND active = 1")
            If DB.ExceptionString <> String.Empty Then
                MessageBox.Show(DB.ExceptionString)
                Exit Sub
            End If

            If DB.RecordCountInteger > 0 Then
                ForgotPasswordform.EmployeeIDInteger = DB.DBDataTable(0)!employeeID
            End If

            ResetPasswordForm.Show()
            Me.Hide()

        Else

            If EmailIDTextBox.Text = String.Empty Then
                MessageBox.Show("Email ID cannot be empty")
                Exit Sub
            ElseIf PasswordTextBox.Text = String.Empty Then
                MessageBox.Show("Password cannot be empty")
                Exit Sub
            End If

            LoginProcess()

            'Based on the flags do the necessary actions
            If CustomerBoolean = True And EmployeeBoolean = False Then
                'Welcome message
                MessageBox.Show("Welcome, " & CustomerFirstNameString & " !")

                'Clear Email ID and password boxes and disable the Login button
                EmailIDTextBox.Clear()
                PasswordTextBox.Clear()

                'Call the Customer form
                CustomerLogin.Show()
                Me.Hide()

            ElseIf CustomerBoolean = True And EmployeeBoolean = True Then
                'Call the choice screen
                LoginChoiceForm.Show()
                Me.Hide()

            ElseIf CustomerBoolean = False And EmployeeBoolean = True Then
                'Call the Employee screen
                EmployeeMainForm.Show()
                Me.Hide()

            ElseIf CustomerBoolean = False And EmployeeBoolean = False Then
                'No record exists
                MessageBox.Show("Email ID/Password combination do not exist")
                EmailIDTextBox.Clear()
                PasswordTextBox.Clear()
                Exit Sub
            End If
        End If

    End Sub

    Private Sub LoginProcess()

        'Encrypt Password and check if it exists
        Dim PasswordString As String = EncryptData(PasswordTextBox.Text)

        DB.AddParam("@primaryEmailID", EmailIDTextBox.Text)
        DB.AddParam("@password", PasswordString)
        DB.ExecuteQuery("SELECT * FROM customer WHERE primaryEmailID=? AND custPassword=? AND active = 1")
        If DB.ExceptionString <> String.Empty Then
            MessageBox.Show(DB.ExceptionString)
            Exit Sub
        End If

        If DB.RecordCountInteger > 0 Then
            'A customer Record exists
            CustomerBoolean = True
            'To use for reservations & orders
            CustomerIDInteger = DB.DBDataTable.Rows(0).Item(0)
            CustomerFirstNameString = DB.DBDataTable.Rows(0).Item(2)
            CustomerLastNameString = DB.DBDataTable.Rows(0).Item(3)

            CustomerEmailIDString = EmailIDTextBox.Text
        Else
            CustomerBoolean = False
        End If

        DB.AddParam("@email", EmailIDTextBox.Text)
        DB.AddParam("@password", PasswordString)
        DB.ExecuteQuery("SELECT * FROM employee WHERE email=? AND empPassword=? AND active = 1")
        If DB.ExceptionString <> String.Empty Then
            MessageBox.Show(DB.ExceptionString)
            Exit Sub
        End If

        If DB.RecordCountInteger > 0 Then
            'An employee Record exists
            EmployeeBoolean = True
            EmployeeIDInteger = DB.DBDataTable.Rows(0)("employeeID")
            EmployeeFirstNameString = DB.DBDataTable.Rows(0)("firstName")
            EmployeeLastNameString = DB.DBDataTable.Rows(0)("lastName")
            EmployeePositionString = DB.DBDataTable.Rows(0)("position")
            EmployeeEmailString = DB.DBDataTable.Rows(0)("email")
        Else
            EmployeeBoolean = False
        End If

    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        'Make the Sign up group box visible
        SignUpGroupBox.Visible = True

        'Disable the Sign In group box
        SignInGroupBox.Enabled = False
        'Clear the email ID and password text boxes
        EmailIDTextBox.Clear()
        PasswordTextBox.Clear()
        ErrorProvider1.Clear()

        'Fill up the combobox for states
        For Each item As String In StateArray
            StateComboBox.Items.Add(item)
        Next

        StateComboBox.Sorted() = True

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'Make the Sign up group box invisible, and the sign in group
        'box enabled
        SignUpGroupBox.Visible = False
        SignInGroupBox.Enabled = True

        'Clear all text boxes
        ClearValues()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Dim CustIDInteger As Integer
        Dim PasswordString As String

        'Registers a new customer into the system
        If FirstNameTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.FirstNameTextBox, "Please enter your first Name")
            Exit Sub
        ElseIf LastNameTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.LastNameTextBox, "Please enter the Last Name")
            Exit Sub
        ElseIf PrimaryEmailIDTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.PrimaryEmailIDTextBox, "Please enter the primary email id")
            Exit Sub
        ElseIf PhoneNumberTextBox.Text = String.Empty Then
            Me.ErrorProvider1.SetError(Me.PhoneNumberTextBox, "Please enter valid phone number")
            Exit Sub
        ElseIf StreetTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.StreetTextBox, "Please enter the street address")
            Exit Sub
        ElseIf CityTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.CityTextBox, "Please enter the city")
            Exit Sub
        ElseIf StateComboBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.StateComboBox, "Please enter the state")
            Exit Sub
        ElseIf ZipCodeTextBox.Text = String.Empty Then
            Me.ErrorProvider1.SetError(Me.ZipCodeTextBox, "Please enter valid zipcode")
            Exit Sub
        ElseIf SignUpPasswordTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.SignUpPasswordTextBox, "Please enter the password")
            Exit Sub
        ElseIf RepeatPasswordTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.RepeatPasswordTextBox, "Please repeat the password")
            Exit Sub
        Else
            'First check if the same customer already exists
            DB.AddParam("@primaryEmaiID", PrimaryEmailIDTextBox.Text)
            DB.ExecuteQuery("SELECT customerID, active FROM customer WHERE primaryEmailID = ?")
            If DB.ExceptionString <> String.Empty Then
                MessageBox.Show(DB.ExceptionString)
                Exit Sub
            End If

            If DB.RecordCountInteger > 0 Then
                CustIDInteger = DB.DBDataTable(0)!customerID

                If DB.DBDataTable(0)!active = 0 Then
                    'Activate the same customer
                    PasswordString = EncryptData(RepeatPasswordTextBox.Text)
                    DB.AddParam("@password", PasswordString)
                    DB.AddParam("@customerID", CustIDInteger)
                    DB.ExecuteQuery("UPDATE customer SET active = 1, custPassword = ?  WHERE customerID = ?")
                    If DB.ExceptionString <> String.Empty Then
                        MessageBox.Show(DB.ExceptionString)
                        Exit Sub
                    End If

                    MessageBox.Show("Welcome back!")

                Else
                    MessageBox.Show("Email ID already exists.")
                    Exit Sub
                End If
            Else
                'Check if the same address already exists
                'if it does, use that AddressID
                DB.AddParam("@street", StreetTextBox.Text)
                DB.AddParam("@city", CityTextBox.Text)
                DB.AddParam("@state", StateComboBox.Text)
                DB.AddParam("@zipcode", ZipCodeTextBox.Text)
                DB.ExecuteQuery("SELECT addressID FROM houseaddress WHERE street = ? AND city = ? AND state = ? AND zipcode = ?")
                If DB.ExceptionString <> String.Empty Then
                    MessageBox.Show(DB.ExceptionString)
                    Exit Sub
                End If

                If DB.RecordCountInteger > 0 Then
                    AddressIDInteger = DB.DBDataTable.Rows(0)("addressID")
                Else
                    DB.AddParam("@street", StreetTextBox.Text)
                    DB.AddParam("@city", CityTextBox.Text)
                    DB.AddParam("@state", StateComboBox.Text)
                    DB.AddParam("@zipcode", ZipCodeTextBox.Text)
                    DB.ExecuteQuery("INSERT INTO houseaddress(street, city, state, zipcode) VALUES(?,?,?,?)")
                    If DB.ExceptionString <> String.Empty Then
                        MessageBox.Show(DB.ExceptionString)
                        Exit Sub
                    End If

                    'Select from HouseAddress, to get the most recently inserted address ID
                    DB.ExecuteQuery("SELECT addressID FROM houseaddress ORDER BY addressID DESC LIMIT 1")
                    If DB.ExceptionString <> String.Empty Then
                        MessageBox.Show(DB.ExceptionString)
                        Exit Sub
                    End If

                    AddressIDInteger = DB.DBDataTable.Rows(0)("addressID")
                End If

                PasswordString = String.Empty
                PasswordString = EncryptData(SignUpPasswordTextBox.Text)

                DB.AddParam("@addressID", AddressIDInteger)
                DB.AddParam("@firstName", FirstNameTextBox.Text)
                DB.AddParam("@lastName", LastNameTextBox.Text)
                DB.AddParam("@phonenumber", PhoneNumberTextBox.Text)
                DB.AddParam("@active", 1)
                DB.AddParam("@primaryEmailID", PrimaryEmailIDTextBox.Text)
                DB.AddParam("@secondaryEmailID", SecondaryEmailIDTextBox.Text)
                DB.AddParam("@Password", PasswordString)
                DB.AddParam("@createdOnDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                DB.ExecuteQuery("INSERT INTO customer(addressID, firstName, lastName, phonenumber, active, primaryEmailID, secondaryEmailID, custPassword, createdOnDate) VALUES(?,?,?,?,?,?,?,?,?)")
                If DB.ExceptionString <> String.Empty Then
                    MessageBox.Show(DB.ExceptionString)
                    Exit Sub
                End If

                MessageBox.Show("You have registered successfully. Confirmation email sent to " & PrimaryEmailIDTextBox.Text)
            End If

            ClearValues()
            'Hide Sign up group box
            SignUpGroupBox.Visible = False
            SignInGroupBox.Enabled = True

        End If
    End Sub

    Private Sub ViewMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMenuToolStripMenuItem.Click
        DB.CallingFormString = Me.Name
        MenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub ViewSectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSectionsToolStripMenuItem.Click
        SectionsForm.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub ClearValues()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        PrimaryEmailIDTextBox.Clear()
        SecondaryEmailIDTextBox.Clear()
        PhoneNumberTextBox.Clear()
        SignUpPasswordTextBox.Clear()
        RepeatPasswordTextBox.Clear()
        StreetTextBox.Clear()
        CityTextBox.Clear()
        StateComboBox.SelectedIndex = -1
        ZipCodeTextBox.Clear()
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

    Private Sub RepeatPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles RepeatPasswordTextBox.TextChanged
        'Compare first and second Passwords
        If SignUpPasswordTextBox.Text <> RepeatPasswordTextBox.Text Then
            PasswordMatchLabel.Text = "Passwords do not match"
            Exit Sub
        Else
            PasswordMatchLabel.Text = "Passwords match"
        End If
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        EmailIDTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub
End Class
