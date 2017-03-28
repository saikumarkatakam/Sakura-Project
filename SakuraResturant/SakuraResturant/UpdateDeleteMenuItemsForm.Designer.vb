<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateDeleteMenuItemsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuDataGridView = New System.Windows.Forms.DataGridView()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SearchTypeLabel = New System.Windows.Forms.Label()
        Me.SearchItemLabel = New System.Windows.Forms.Label()
        Me.MenuTypeTextBox = New System.Windows.Forms.TextBox()
        Me.MenuItemTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateDeleteButton = New System.Windows.Forms.Button()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuDataGridView
        '
        Me.MenuDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.MenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDataGridView.Location = New System.Drawing.Point(82, 60)
        Me.MenuDataGridView.Name = "MenuDataGridView"
        Me.MenuDataGridView.Size = New System.Drawing.Size(660, 376)
        Me.MenuDataGridView.TabIndex = 0
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(654, 453)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(87, 27)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'SearchTypeLabel
        '
        Me.SearchTypeLabel.AutoSize = True
        Me.SearchTypeLabel.Location = New System.Drawing.Point(78, 22)
        Me.SearchTypeLabel.Name = "SearchTypeLabel"
        Me.SearchTypeLabel.Size = New System.Drawing.Size(120, 15)
        Me.SearchTypeLabel.TabIndex = 3
        Me.SearchTypeLabel.Text = "Search by Menu Type"
        '
        'SearchItemLabel
        '
        Me.SearchItemLabel.AutoSize = True
        Me.SearchItemLabel.Location = New System.Drawing.Point(407, 22)
        Me.SearchItemLabel.Name = "SearchItemLabel"
        Me.SearchItemLabel.Size = New System.Drawing.Size(113, 15)
        Me.SearchItemLabel.TabIndex = 4
        Me.SearchItemLabel.Text = "Search by Item Type"
        '
        'MenuTypeTextBox
        '
        Me.MenuTypeTextBox.Location = New System.Drawing.Point(216, 18)
        Me.MenuTypeTextBox.MaxLength = 45
        Me.MenuTypeTextBox.Name = "MenuTypeTextBox"
        Me.MenuTypeTextBox.Size = New System.Drawing.Size(184, 23)
        Me.MenuTypeTextBox.TabIndex = 0
        '
        'MenuItemTextBox
        '
        Me.MenuItemTextBox.Location = New System.Drawing.Point(540, 18)
        Me.MenuItemTextBox.MaxLength = 45
        Me.MenuItemTextBox.Name = "MenuItemTextBox"
        Me.MenuItemTextBox.Size = New System.Drawing.Size(201, 23)
        Me.MenuItemTextBox.TabIndex = 1
        '
        'UpdateDeleteButton
        '
        Me.UpdateDeleteButton.Location = New System.Drawing.Point(540, 453)
        Me.UpdateDeleteButton.Name = "UpdateDeleteButton"
        Me.UpdateDeleteButton.Size = New System.Drawing.Size(87, 27)
        Me.UpdateDeleteButton.TabIndex = 2
        Me.UpdateDeleteButton.Text = "&Update"
        Me.UpdateDeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateDeleteMenuItemsForm
        '
        Me.AcceptButton = Me.UpdateDeleteButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(800, 511)
        Me.Controls.Add(Me.UpdateDeleteButton)
        Me.Controls.Add(Me.MenuItemTextBox)
        Me.Controls.Add(Me.MenuTypeTextBox)
        Me.Controls.Add(Me.SearchItemLabel)
        Me.Controls.Add(Me.SearchTypeLabel)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.MenuDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UpdateDeleteMenuItemsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Delete Menu Details"
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuDataGridView As DataGridView
    Friend Shadows WithEvents CancelButton As Button
    Friend WithEvents SearchTypeLabel As Label
    Friend WithEvents SearchItemLabel As Label
    Friend WithEvents MenuTypeTextBox As TextBox
    Friend WithEvents MenuItemTextBox As TextBox
    Friend WithEvents UpdateDeleteButton As Button
End Class
