Public Class UpdateDeleteMenuItemsForm

    Private UDAccess As New SakuraClass

    Private Sub UpdateDeleteMenuItemsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show the data depending on menu item clicked
        If MenuMaintenanceForm.MenuItemClickedString = "UpdateMenuType" Then
            SearchItemLabel.Visible = False
            MenuItemTextBox.Visible = False
            UpdateDeleteButton.Text = "&Update"

            UDAccess.ExecuteQuery("SELECT menuTypeID AS 'Menu Type ID', 
                                   menuType AS 'Menu Type', description AS 'Menu Type Description' FROM menutype
                                   WHERE active = 1")
            If UDAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(UDAccess.ExceptionString)
                Exit Sub
            End If

            For Each row As DataGridViewRow In MenuDataGridView.Rows
                MenuDataGridView.Rows(row.Index).Cells(0).ReadOnly = True
                MenuDataGridView.Rows(row.Index).Cells(1).ReadOnly = True
            Next

            MenuDataGridView.DataSource = UDAccess.DBDataTable
            MenuDataGridView.AutoResizeColumns()
            MenuDataGridView.AllowUserToAddRows = False
            MenuDataGridView.AllowUserToDeleteRows = False

        ElseIf MenuMaintenanceForm.MenuItemClickedString = "UpdateMenuItem" Then
            UpdateDeleteButton.Text = "&Update"
            UDAccess.ExecuteQuery("SELECT t.menuTypeID AS 'Menu Type ID', t.menuType AS 'Menu Type', 
                                   i.itemID as 'Item ID', i.itemType AS 'Item Type', 
                                   i.description AS 'Item Description', i.price AS 'Unit Price'
                                   FROM menutype as t JOIN menuitem as i ON t.menuTypeID = i.menuTypeID
                                   WHERE t.active = 1 OR i.active = 1")
            If UDAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(UDAccess.ExceptionString)
                Exit Sub
            End If

            MenuDataGridView.DataSource = UDAccess.DBDataTable
            MenuDataGridView.AutoResizeColumns()
            MenuDataGridView.AllowUserToAddRows = False
            MenuDataGridView.AllowUserToDeleteRows = False

            For Each row As DataGridViewRow In MenuDataGridView.Rows
                MenuDataGridView.Rows(row.Index).Cells(0).ReadOnly = True
                MenuDataGridView.Rows(row.Index).Cells(2).ReadOnly = True
            Next

        ElseIf MenuMaintenanceForm.MenuItemClickedString = "DeleteMenuType" Then
            SearchItemLabel.Visible = False
            MenuItemTextBox.Visible = False
            UpdateDeleteButton.Text = "&Delete"

            UDAccess.ExecuteQuery("SELECT menuTypeID AS 'Menu Type ID', 
                                   menuType AS 'Menu Type', description AS 'Menu Type Description' FROM menutype
                                   WHERE active = 1")
            If UDAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(UDAccess.ExceptionString)
                Exit Sub
            End If

            MenuDataGridView.DataSource = UDAccess.DBDataTable
            MenuDataGridView.AutoResizeColumns()
            MenuDataGridView.AllowUserToAddRows = False
            MenuDataGridView.AllowUserToDeleteRows = False
            MenuDataGridView.ReadOnly = True

        ElseIf MenuMaintenanceForm.MenuItemClickedString = "DeleteMenuItem" Then
            UpdateDeleteButton.Text = "&Delete"
            UDAccess.ExecuteQuery("SELECT t.menuTypeID AS 'Menu Type ID', t.menuType AS 'Menu Type', 
                                   i.itemID as 'Item ID', i.itemType AS 'Item Type', 
                                   i.description AS 'Item Description', i.price AS 'Unit Price'
                                   FROM menutype as t JOIN menuitem as i ON t.menuTypeID = i.menuTypeID
                                   WHERE t.active = 1 OR i.active = 1")
            If UDAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(UDAccess.ExceptionString)
                Exit Sub
            End If

            MenuDataGridView.DataSource = UDAccess.DBDataTable
            MenuDataGridView.AutoResizeColumns()
            MenuDataGridView.AllowUserToAddRows = False
            MenuDataGridView.AllowUserToDeleteRows = False
            MenuDataGridView.ReadOnly = True
        End If

    End Sub

    Private Sub MenuItemTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles MenuItemTextBox.KeyUp

        UDAccess.AddParam("@menuType", MenuTypeTextBox.Text & "%")
        UDAccess.AddParam("@itemType", MenuItemTextBox.Text & "%")
        UDAccess.ExecuteQuery("SELECT t.menuTypeID AS 'Menu Type ID', t.menuType AS 'Menu Type', 
                                   i.itemID as 'Item ID', i.itemType AS 'Item Type', 
                                   i.description AS 'Item Description', i.price AS 'Unit Price'
                                   FROM menutype as t JOIN menuitem as i ON t.menuTypeID = i.menuTypeID
                                   WHERE t.menuType LIKE ? AND i.itemType LIKE ? AND i.active = 1")
        If UDAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(UDAccess.ExceptionString)
            Exit Sub
        End If

        MenuDataGridView.DataSource = UDAccess.DBDataTable

    End Sub

    Private Sub MenuTypeTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles MenuTypeTextBox.KeyUp

        MenuItemTextBox.Clear()
        UDAccess.AddParam("@menuType", MenuTypeTextBox.Text & "%")
        If SearchItemLabel.Visible = True Then
            UDAccess.ExecuteQuery("SELECT t.menuTypeID AS 'Menu Type ID', t.menuType AS 'Menu Type', 
                                   i.itemID as 'Item ID', i.itemType AS 'Item Type', 
                                   i.description AS 'Item Description', i.price AS 'Unit Price'
                                   FROM menutype as t JOIN menuitem as i ON t.menuTypeID = i.menuTypeID
                                   WHERE t.menuType LIKE ? AND t.active = 1")
            If UDAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(UDAccess.ExceptionString)
                Exit Sub
            End If
        Else
            UDAccess.ExecuteQuery("SELECT menuTypeID AS 'Menu Type ID', menuType AS 'Menu Type', 
                                   description AS 'Menu Type Description' FROM menutype
                                   WHERE menuType LIKE ? AND active = 1")
            If UDAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(UDAccess.ExceptionString)
                Exit Sub
            End If
        End If

        MenuDataGridView.DataSource = UDAccess.DBDataTable
    End Sub

    Private Sub UpdateDeleteButton_Click(sender As Object, e As EventArgs) Handles UpdateDeleteButton.Click

        If UpdateDeleteButton.Text = "&Update" Then
            For Each row As DataGridViewRow In MenuDataGridView.Rows
                Select Case MenuMaintenanceForm.MenuItemClickedString
                    Case "UpdateMenuType"
                        UDAccess.AddParam("@description", MenuDataGridView.Rows(row.Index).Cells(2).Value)
                        UDAccess.AddParam("@menuID", MenuDataGridView.Rows(row.Index).Cells(0).Value)
                        UDAccess.ExecuteQuery("UPDATE menutype SET description = ? WHERE menuTypeID = ?")
                    Case "UpdateMenuItem"
                        UDAccess.AddParam("@description", MenuDataGridView.Rows(row.Index).Cells(4).Value)
                        UDAccess.AddParam("@price", MenuDataGridView.Rows(row.Index).Cells(5).Value)
                        UDAccess.AddParam("@itemType", MenuDataGridView.Rows(row.Index).Cells(2).Value)
                        UDAccess.ExecuteQuery("UPDATE menuitem SET description = ? , price = ? WHERE itemID = ?")
                End Select
            Next

            If UDAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(UDAccess.ExceptionString)
                Exit Sub
            End If

            MessageBox.Show("Update successfully complete.")
        Else
            If MenuDataGridView.SelectedRows.Count = 0 Then
                MessageBox.Show("Select one row.")
                Exit Sub
            ElseIf MenuDataGridView.SelectedRows.Count > 1 Then
                MessageBox.Show("Select only one row.")
                Exit Sub
            End If

            For Each row As DataGridViewRow In MenuDataGridView.SelectedRows
                Select Case MenuMaintenanceForm.MenuItemClickedString
                    Case "DeleteMenuType"
                        If MessageBox.Show("You are going to delete the selected menu type." &
                           "This would result in subsequent deletion of items linked to this Menu Type." &
                           "Are you sure you want to delete the selected Menu Type?",
                           "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                            Exit Sub
                        End If

                        UDAccess.AddParam("@menuTypeID", MenuDataGridView.Rows(row.Index).Cells(0).Value)
                        UDAccess.ExecuteQuery("UPDATE menutype SET active = 0 WHERE menuTypeID = ?")
                        If UDAccess.ExceptionString <> String.Empty Then
                            MessageBox.Show(UDAccess.ExceptionString)
                            Exit Sub
                        End If

                        UDAccess.AddParam("@menuTypeID", MenuDataGridView.Rows(row.Index).Cells(0).Value)
                        UDAccess.ExecuteQuery("UPDATE menuitem SET active = 0 WHERE menuTypeID = ?")
                        If UDAccess.ExceptionString <> String.Empty Then
                            MessageBox.Show(UDAccess.ExceptionString)
                            Exit Sub
                        End If

                        MessageBox.Show("Menu Type and subsequent menu item(s) deleted")

                    Case "DeleteMenuItem"
                        UDAccess.AddParam("@itemID", MenuDataGridView.Rows(row.Index).Cells(2).Value)
                        UDAccess.ExecuteQuery("UPDATE menuitem SET active = 0 WHERE itemID = ?")
                        If UDAccess.ExceptionString <> String.Empty Then
                            MessageBox.Show(UDAccess.ExceptionString)
                            Exit Sub
                        End If

                        MessageBox.Show("Menu item deleted")
                End Select
            Next

        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MenuMaintenanceForm.Show()
        Me.Close()
    End Sub
End Class