Imports System.Data

Public Class AddToCartForm

    Public OrderAmountDecimal As Decimal
    Public Cart As New SakuraClass
    Friend CartTable As New DataTable


    Private Sub AddToCartForm_Load(sender As Object,
                                   e As EventArgs) Handles MyBase.Load

        If Login.DB.ReservationString = "IndividualReservationForm" Or Login.DB.ReservationString = "EmployeeIndividualReservationForm" Then
            ConfirmButton.Enabled = False
        Else
            ConfirmButton.Enabled = True
        End If

        CartTable.Columns.Add("Selected", GetType(Boolean))
        CartTable.Columns.Add("Item Type", GetType(String))
        CartTable.Columns.Add("Item Description", GetType(String))
        CartTable.Columns.Add("Price", GetType(Decimal))
        CartTable.Columns.Add("Quantity", GetType(Integer))
        CartTable.Columns.Add("Total Price", GetType(Decimal))


        For Each item As MenuForm.CartDetails In MenuForm.CartDetailsArray
            If item.ItemTypeString <> String.Empty Then
                CartTable.Rows.Add(True, item.ItemTypeString, item.ItemDescriptionString, item.UnitPriceDecimal, item.QuantityInteger, item.TotalPriceDecimal)
            End If
        Next

        'Pass data table to Data grid view
        CartDataGridView.DataSource = CartTable
        CartDataGridView.AllowUserToAddRows = False

        'To check the checkboxes
        For Each row As DataGridViewRow In CartDataGridView.Rows
            CartDataGridView.Rows(row.Index).Cells(0).Value = True

            'Make few fields read-only
            If Login.DB.ReservationString = "IndividualReservationForm" Or Login.DB.ReservationString = "EmployeeIndividualReservationForm" Then
                CartDataGridView.Rows(row.Index).Cells(4).ReadOnly = True
            End If
            CartDataGridView.Rows(row.Index).Cells(1).ReadOnly = True
            CartDataGridView.Rows(row.Index).Cells(2).ReadOnly = True
            CartDataGridView.Rows(row.Index).Cells(3).ReadOnly = True
            CartDataGridView.Rows(row.Index).Cells(5).ReadOnly = True
        Next

    End Sub

    Private Function GetDataTable() As DataTable
        ' This Function needs to build the data table.
        Return New DataTable()
    End Function

    Private Sub CancelButton_Click(sender As Object,
                               e As EventArgs) Handles CancelButton.Click
        If Login.DB.ReservationString = "IndividualReservationForm" Then
            IndividualReservationForm.Show()
        ElseIf Login.DB.ReservationString = "EmployeeIndividualReservationForm" Then
            EmployeeIndividualReservationForm.Show()
        Else
            MenuForm.Show()
        End If

        Me.Close()
    End Sub

    Private Sub CartDataGridView_CellEndEdit(sender As Object,
                                             e As DataGridViewCellEventArgs) Handles CartDataGridView.CellEndEdit

        'When there is a change in the Quantity field, 
        'the total price needs to be updated
        If CartDataGridView.Rows(e.RowIndex).Cells(4).Value > 0 Then
            CartDataGridView.Rows(e.RowIndex).Cells(5).Value = CartDataGridView.Rows(e.RowIndex).Cells(4).Value *
                CartDataGridView.Rows(e.RowIndex).Cells(3).Value
        End If
    End Sub

    Private Sub ConfirmButton_Click(sender As Object,
                                    e As EventArgs) Handles ConfirmButton.Click

        OrderAmountDecimal = 0

        For Each row As DataGridViewRow In CartDataGridView.Rows
            If CartDataGridView.Rows(row.Index).Cells(0).Value = True Then
                If CartDataGridView.Rows(row.Index).Cells(4).Value > 0 Then
                    OrderAmountDecimal += CartDataGridView.Rows(row.Index).Cells(5).Value
                Else
                    MessageBox.Show("Quantity cannot be zero.")
                    Exit Sub
                End If
            End If
        Next

        If OrderAmountDecimal >= 20 Then
            MessageBox.Show("Your order total is: " & OrderAmountDecimal.ToString("C"))
        Else
            MessageBox.Show("Minimum order amount is $20.")
            Exit Sub
        End If

        If Login.DB.ReservationString = "ChangeReservationForm" Then
            IndividualReservationForm.Show()
        ElseIf Login.Db.ReservationString = "EmployeeIndividualReservationForm" Then
            EmployeeIndividualReservationForm.Show()
        ElseIf Login.db.ReservationString = "EmployeeChangeReservationForm" Then
            EmployeeChangeReservationForm.Show()
        ElseIf Login.Db.ReservationString = "IndividualReservationForm" Then
            IndividualReservationForm.Show()
        Else
            NewReservation.Show()
        End If

        MenuForm.Hide()
        Me.Hide()

    End Sub

End Class