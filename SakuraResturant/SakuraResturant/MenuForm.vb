Public Class MenuForm

    Public MenuTypeIDInteger As Integer
    Public MenuTypeString As String

    Private IndexInteger As Integer = 0

    Public Structure CartDetails
        Dim MenuTypeString As String
        Dim ItemTypeString As String
        Dim ItemDescriptionString As String
        Dim UnitPriceDecimal As Decimal
        Dim QuantityInteger As Integer
        Dim TotalPriceDecimal As Decimal
    End Structure

    Public CartDetailsArray(1000) As CartDetails

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Display the Menu Types from the Menu Type table
        MenuTypeDataGridView.ReadOnly = True 'To prevent change of data on the DataGrid

        Login.DB.ExecuteQuery("SELECT menuType FROM menutype WHERE active = 1")

        'Display the Exception, if it exists
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        'Display the data onto the DataGridView
        MenuTypeDataGridView.DataSource = Login.DB.DBDataTable
        MenuTypeDataGridView.ColumnHeadersVisible = False
        MenuTypeDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub MenuTypeDataGridView_CellClick(sender As Object,
                                               e As DataGridViewCellEventArgs) Handles MenuTypeDataGridView.CellClick

        Dim MenuTypeString As String

        'When the MenuTypeDataGridView Cell is clicked, the items
        'corresponding to that Menu Type must be displayed
        'Capture the MenuType value clicked
        MenuTypeString = MenuTypeDataGridView.Item(0, e.RowIndex).Value
        Login.DB.AddParam("@menuType", MenuTypeString)
        Login.DB.ExecuteQuery("SELECT menuTypeID FROM menutype where menuType = ? AND active = 1")

        'Display the Exception, if it exists
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        'Get the Menu Type ID
        MenuTypeIDInteger = Login.DB.DBDataTable(0)!menuTypeID
        Login.DB.AddParam("@menuTypeID", MenuTypeIDInteger)
        Login.DB.ExecuteQuery("SELECT itemType, description, price FROM menuitem WHERE menuTypeID = ? AND active = 1")

        'Display the Exception, if it exists
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        'Display Items corresponding to the header
        MenuItemDataGridView.DataSource = Login.DB.DBDataTable
        MenuItemDataGridView.ColumnHeadersVisible = False
        MenuItemDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub MenuTypeDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MenuTypeDataGridView.RowHeaderMouseClick

        Dim MenuTypeIDInteger As Integer

        'When the MenuTypeDataGridView Cell is clicked, the items
        'corresponding to that Menu Type must be displayed
        'Capture the MenuType value clicked
        MenuTypeString = MenuTypeDataGridView.Item(0, e.RowIndex).Value
        Login.DB.AddParam("@menuType", MenuTypeString)
        Login.DB.ExecuteQuery("SELECT menuTypeID FROM menutype where menuType = ? AND active = 1")

        'Display the Exception, if it exists
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        'Get the Menu Type ID
        MenuTypeIDInteger = Login.DB.DBDataTable(0)!menuTypeID
        Login.DB.AddParam("@menuTypeID", MenuTypeIDInteger)
        Login.DB.ExecuteQuery("SELECT itemType, description, price FROM menuitem WHERE menuTypeID = ? AND active = 1")

        'Display the Exception, if it exists
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        'Display Items corresponding to the header
        MenuItemDataGridView.DataSource = Login.DB.DBDataTable
        MenuItemDataGridView.ColumnHeadersVisible = False
        MenuItemDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub MenuItemDataGridView_RowHeaderMouseClick(sender As Object,
                                   e As DataGridViewCellMouseEventArgs) Handles MenuItemDataGridView.RowHeaderMouseClick
        If e.RowIndex < 0 Then
            AddToCartButton.Enabled = False
            Exit Sub
        End If

        'Enable the "Add to cart" button
        If Login.DB.CallingFormString = "Login" Or Login.DB.CallingFormString = "CustomerLogin" Then
            AddToCartButton.Enabled = False
        Else
            AddToCartButton.Enabled = True
        End If

    End Sub

    Private Sub AddToCartButton_Click(sender As Object, e As EventArgs) Handles AddToCartButton.Click

        'Check if atleast one row is selected
        If MenuItemDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Select atleast one item")
            Exit Sub
        End If

        For Each item As MenuForm.CartDetails In CartDetailsArray
            If item.ItemTypeString <> String.Empty Then
                IndexInteger += 1
            End If
        Next

        For Each row As DataGridViewRow In MenuItemDataGridView.SelectedRows
            CartDetailsArray(IndexInteger).ItemTypeString = row.Cells("ItemType").Value.ToString()
            CartDetailsArray(IndexInteger).ItemDescriptionString = row.Cells("Description").Value.ToString()
            CartDetailsArray(IndexInteger).UnitPriceDecimal = row.Cells("Price").Value
            'CartDetailsArray(IndexInteger).MenuTypeString = MenuTypeString

            IndexInteger += 1
        Next

        'Item(s) added to cart
        MessageBox.Show("Item(s) added to cart")

        'Enable the Check Out Button
        CheckOutButton.Enabled = True
    End Sub

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        AddToCartForm.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If Login.DB.CallingFormString = "Login" Then
            Login.Show()
            Me.Close()
        ElseIf Login.db.CallingFormString = "CustomerLogin" Then
            CustomerLogin.Show()
            Me.Close()
        ElseIf Login.DB.CallingFormString = "NewReservation" Then
            NewReservation.Show()
            Me.Close()
        ElseIf Login.DB.CallingFormString = "IndividualReservationForm" Then
            IndividualReservationForm.Show()
            Me.Close()
        ElseIf Login.DB.CallingFormString = "ReservationMaintenanceForm" Then
            ReservationMaintenanceForm.Show()
            Me.Close()
        ElseIf Login.db.CallingFormString = "EmployeeIndividualReservationForm" Then
            EmployeeIndividualReservationForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ChangePrevButton_Click(sender As Object,
                                       e As EventArgs)
        AddToCartForm.Show()
    End Sub
End Class
