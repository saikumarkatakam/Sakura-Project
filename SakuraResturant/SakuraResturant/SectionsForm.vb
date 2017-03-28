Public Class SectionsForm
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click

        If LOGOUTToolStripMenuItem.Visible = False Then
            Login.Show()
            Me.Close()
        Else
            CustomerLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub DineInRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DineInRadioButton.CheckedChanged
        Timer1.Start()
        'ImagesPictureBox.Image = My.Resources.common_dinning_area
    End Sub

    Private Sub HibachiRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles HibachiRadioButton.CheckedChanged
        ImagesPictureBox.Image = My.Resources.Hibachi_area
    End Sub

    Private Sub GrillRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GrillRadioButton.CheckedChanged
        ImagesPictureBox.Image = My.Resources.Hibachi_area_2
    End Sub

    Private Sub PartyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PartyRadioButton.CheckedChanged
        ImagesPictureBox.Image = My.Resources.sushi_area
    End Sub

    Private Sub SectionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login.DB.CallingFormString = "CustomerLogin" Then
            LOGOUTToolStripMenuItem.Visible = True
        ElseIf Login.db.CallingFormString = "Login" Then
            LOGOUTToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Create a number between a certain value and becomes the interval
        Timer1.Interval = 5000
        Select Case True
            Case DineInRadioButton.Checked
                ChangeDineInImages()
            Case HibachiRadioButton.Checked
                ChangeHibachiImages()
            Case GrillRadioButton.Checked

            Case PartyRadioButton.Checked
        End Select

    End Sub

    Private Sub ChangeDineInImages()

        Static Dim iImage1 As Integer

        Select Case iImage1
            Case 0
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.common_dinning_area
                iImage1 += 1
            Case 1
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.DineInArea1
                iImage1 += 1
            Case 2
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.DineInArea2
                iImage1 += 1
            Case 3
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.DineInArea3
                iImage1 += 1
            Case 4
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.DineInArea4
                iImage1 = 0
        End Select
    End Sub

    Private Sub ChangeHibachiImages()

        Static Dim iImage1 As Integer

        Select Case iImage1
            Case 0
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.Hibachi_area
                iImage1 += 1
            Case 1
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.Hibachi_area_2
                iImage1 += 1
            Case 2
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.Hibachi_Area_5
                iImage1 += 1
            Case 3
                ImagesPictureBox.Visible = True
                ImagesPictureBox.Image = My.Resources.Hibachi_Area_4
                iImage1 = 0
        End Select
    End Sub

End Class