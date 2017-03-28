Public Class ContactUsForm
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        CustomerLogin.Show()
        Me.Close()
    End Sub
End Class