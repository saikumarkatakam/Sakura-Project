Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class CustomerLogin
    Private AddressIDInteger As Integer
    Public CustomerIDInteger As Integer
    Public CustomerFirstNameString, CustomerLastNameString As String

    Public Function EncryptData(ByVal PlainTextString As String) As String

        Dim PasswordString As String = PlainTextString 'The password to be encrypted
        Dim HashedDataByte As Byte() 'Byte array containing the encrypted string
        Dim Encoder As New UTF8Encoding() 'Used to convert the string into byte format
        Dim Md5Hasher As New MD5CryptoServiceProvider 'MD5 is an encryption method

        HashedDataByte = Md5Hasher.ComputeHash(Encoder.GetBytes(PlainTextString))

        'Convert the byte array into a string
        Return Convert.ToBase64String(HashedDataByte)

    End Function

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ViewSectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSectionsToolStripMenuItem.Click
        SectionsForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMenuToolStripMenuItem.Click
        MenuForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the Calling Form String
        Login.DB.CallingFormString = Me.Name
    End Sub

    Private Sub ChangeReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeReservationToolStripMenuItem.Click
        ChangeReservationForm.Show()
        Me.Close()
    End Sub

    Private Sub CancelReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelReservationToolStripMenuItem.Click
        CancelReservationForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewYourReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewYourReservationsToolStripMenuItem.Click
        ViewReservationForm.Show()
        Me.Close()
    End Sub

    Private Sub MakeReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeReservationToolStripMenuItem.Click
        NewReservation.Show()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        ContactUsForm.Show()
        Me.Close()
    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click


        'Ask for confirmation, then de-activate
        If MessageBox.Show("You are going to deactivate your account." &
                           " Are you sure?",
                           "Deactivate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        Login.DB.AddParam("@customerID", Login.CustomerIDInteger)
        Login.DB.ExecuteQuery("UPDATE customer SET active = 0 WHERE customerID = ?")
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        'Cancel all pending reservations of the customer
        Login.DB.AddParam("@customerID", Login.CustomerIDInteger)
        Login.DB.ExecuteQuery("UPDATE reservation SET reservationStatus = 'Cancelled' WHERE customerID = ?")
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        'Cancel all the food orders as well
        Login.DB.AddParam("@customerID", Login.CustomerIDInteger)
        Login.DB.ExecuteQuery("SELECT reservationID FROM reservation WHERE customerID = ?")
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        If Login.DB.RecordCountInteger > 0 Then
            For Each row As DataRow In Login.DB.DBDataTable.Rows
                Login.DB.AddParam("@reservationID", row("reservationID"))
                Login.DB.ExecuteQuery("UPDATE customerorder SET active = 0 WHERE reservationID = ?")
                If Login.DB.ExceptionString <> String.Empty Then
                    Continue For
                End If
            Next
        End If

        MessageBox.Show("Goodbye, for now!")
        LogOutToolStripMenuItem_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub UpdatePersonalInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePersonalInfoToolStripMenuItem.Click
        CustUpdatePersonalInfoForm.Show()
        Me.Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Login.DB.ChangePasswordString = Me.Name
        ChangePasswordForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Set the Calling Form String
        Login.DB.CallingFormString = Me.Name
    End Sub
End Class