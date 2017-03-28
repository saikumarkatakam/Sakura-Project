Public Class MenuMaintenanceForm

    Private MenuAccess As New SakuraClass
    Friend MenuItemClickedString As String

    Private Sub MenuTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuTypeToolStripMenuItem.Click
        'Make Add Menu Type visible
        AddMenuTypeGroupBox.Visible = True
        AddMenuItemGroupBox.Visible = False
    End Sub

    Private Sub SaveMenuTypeButton_Click(sender As Object, e As EventArgs) Handles SaveMenuTypeButton.Click

        'Validations
        If MenuTypeTextBox.Text = String.Empty Then
            MessageBox.Show("Menu Type cannot be blank")
            Exit Sub
        ElseIf MenuDescriptionTextBox.Text = String.Empty Then
            MessageBox.Show("Menu Description cannot be blank")
            Exit Sub
        End If

        'First, check whether the menu type already exists
        MenuAccess.AddParam("@menuType", MenuTypeTextBox.Text)
        MenuAccess.ExecuteQuery("SELECT * FROM menutype WHERE menuType = ?")
        If MenuAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(MenuAccess.ExceptionString)
            Exit Sub
        End If

        If MenuAccess.RecordCountInteger > 0 Then
            MessageBox.Show("Menu Type already exists.")
            MenuTypeTextBox.Clear()
            MenuDescriptionTextBox.Clear()
            Exit Sub
        Else
            'Add the details into Menu Type table
            MenuAccess.AddParam("@menuType", MenuTypeTextBox.Text)
            MenuAccess.AddParam("@menuDescription", MenuDescriptionTextBox.Text)
            MenuAccess.AddParam("@active", 1)
            MenuAccess.ExecuteQuery("INSERT INTO menutype(menuType,description,active) VALUES(?,?,?)")
            If MenuAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(MenuAccess.ExceptionString)
                Exit Sub
            End If

            MessageBox.Show("Menu Type " & MenuTypeTextBox.Text & " " & "added.")
        End If
    End Sub

    Private Sub CancelMenuTypeButton_Click(sender As Object, e As EventArgs) Handles CancelMenuTypeButton.Click
        'Clear the text boxes
        MenuTypeTextBox.Clear()
        MenuDescriptionTextBox.Clear()
        'Make the Menu Type Group box invisible
        AddMenuTypeGroupBox.Visible = False
    End Sub

    Private Sub MenuItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItemToolStripMenuItem.Click
        'Make Add Menu Item visible
        AddMenuTypeGroupBox.Visible = False
        AddMenuItemGroupBox.Visible = True
    End Sub

    Private Sub MenuItemSaveButton_Click(sender As Object, e As EventArgs) Handles MenuItemSaveButton.Click

        Dim MenuTypeIDInteger As Integer

        'Validations
        If ItemTypeTextBox.Text = String.Empty Then
            MessageBox.Show("Item type cannot be blank.")
            Exit Sub
        ElseIf MenuTypeComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Menu type cannot be blank.")
            Exit Sub
        ElseIf PriceTextBox.Text = String.Empty Then
            MessageBox.Show("Price cannot be 0")
            Exit Sub
        End If

        'First check whether the menu item already exists
        MenuAccess.AddParam("@itemType", ItemTypeTextBox.Text)
        MenuAccess.ExecuteQuery("SELECT * FROM menuitem WHERE itemType = ?")
        If MenuAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(MenuAccess.ExceptionString)
            Exit Sub
        End If

        If MenuAccess.RecordCountInteger > 0 Then
            MessageBox.Show("Item Type already exists.")
            Exit Sub
        End If

        'Get the Menu Type ID
        MenuAccess.AddParam("@menuType", MenuTypeComboBox.SelectedItem.ToString())
        MenuAccess.ExecuteQuery("SELECT menuTypeID FROM menutype WHERE menuType = ?")
        If MenuAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(MenuAccess.ExceptionString)
            Exit Sub
        End If

        MenuTypeIDInteger = MenuAccess.DBDataTable.Rows(0)!menuTypeID

        'Add details into the menuitem table
        MenuAccess.AddParam("@menuTypeID", MenuTypeIDInteger)
        MenuAccess.AddParam("@itemType", ItemTypeTextBox.Text)
        MenuAccess.AddParam("@itemDescription", ItemDescriptionTextBox.Text)
        MenuAccess.AddParam("@price", PriceTextBox.Text)
        MenuAccess.AddParam("@active", 1)
        MenuAccess.ExecuteQuery("INSERT INTO menuitem(menuTypeID, itemType, description, price, active) 
                                 VALUES(?,?,?,?,?)")
        If MenuAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(MenuAccess.ExceptionString)
            Exit Sub
        End If

        MessageBox.Show("Menu Item " & ItemTypeTextBox.Text & " " & "added.")

    End Sub

    Private Sub MenuItemCancelButton_Click(sender As Object, e As EventArgs) Handles MenuItemCancelButton.Click
        MenuTypeComboBox.SelectedIndex = -1
        ItemTypeTextBox.Clear()
        ItemDescriptionTextBox.Clear()
        PriceTextBox.Clear()
        AddMenuItemGroupBox.Visible = False
    End Sub

    Private Sub AddMenuItemGroupBox_Enter(sender As Object, e As EventArgs) Handles AddMenuItemGroupBox.Enter
        MenuAccess.ExecuteQuery("SELECT menuType FROM menuType")
        If MenuAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(MenuAccess.ExceptionString)
            Exit Sub
        End If

        For Each item In MenuAccess.DBDataTable.Rows
            MenuTypeComboBox.Items.Add(item("menuType"))
        Next
    End Sub

    Private Sub UpdateMenuTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMenuTypeToolStripMenuItem.Click
        MenuItemClickedString = "UpdateMenuType"
        AddMenuItemGroupBox.Visible = False
        AddMenuTypeGroupBox.Visible = False
        MenuTypeTextBox.Clear()
        MenuDescriptionTextBox.Clear()
        ItemTypeTextBox.Clear()
        ItemDescriptionTextBox.Clear()
        PriceTextBox.Clear()
        UpdateDeleteMenuItemsForm.Show()
    End Sub

    Private Sub UpdateMenuItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMenuItemToolStripMenuItem.Click
        MenuItemClickedString = "UpdateMenuItem"
        AddMenuItemGroupBox.Visible = False
        AddMenuTypeGroupBox.Visible = False
        MenuTypeTextBox.Clear()
        MenuDescriptionTextBox.Clear()
        ItemTypeTextBox.Clear()
        ItemDescriptionTextBox.Clear()
        PriceTextBox.Clear()
        UpdateDeleteMenuItemsForm.Show()
    End Sub

    Private Sub DeleteMenuTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMenuTypeToolStripMenuItem.Click
        MenuItemClickedString = "DeleteMenuType"
        AddMenuItemGroupBox.Visible = False
        AddMenuTypeGroupBox.Visible = False
        MenuTypeTextBox.Clear()
        MenuDescriptionTextBox.Clear()
        ItemTypeTextBox.Clear()
        ItemDescriptionTextBox.Clear()
        PriceTextBox.Clear()
        UpdateDeleteMenuItemsForm.Show()
    End Sub

    Private Sub DeleteMenuItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMenuItemToolStripMenuItem.Click
        MenuItemClickedString = "DeleteMenuItem"
        AddMenuItemGroupBox.Visible = False
        AddMenuTypeGroupBox.Visible = False
        MenuTypeTextBox.Clear()
        MenuDescriptionTextBox.Clear()
        ItemTypeTextBox.Clear()
        ItemDescriptionTextBox.Clear()
        PriceTextBox.Clear()
        UpdateDeleteMenuItemsForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub
End Class