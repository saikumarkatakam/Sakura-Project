<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        Me.MenuTypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddToCartButton = New System.Windows.Forms.Button()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.MenuTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTypeDataGridView
        '
        Me.MenuTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MenuTypeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MenuTypeDataGridView.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.MenuTypeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MenuTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuTypeDataGridView.Location = New System.Drawing.Point(29, 51)
        Me.MenuTypeDataGridView.Name = "MenuTypeDataGridView"
        Me.MenuTypeDataGridView.ReadOnly = True
        Me.MenuTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MenuTypeDataGridView.Size = New System.Drawing.Size(200, 450)
        Me.MenuTypeDataGridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu Type"
        '
        'MenuItemDataGridView
        '
        Me.MenuItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MenuItemDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MenuItemDataGridView.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.MenuItemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MenuItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuItemDataGridView.Location = New System.Drawing.Point(253, 51)
        Me.MenuItemDataGridView.Name = "MenuItemDataGridView"
        Me.MenuItemDataGridView.ReadOnly = True
        Me.MenuItemDataGridView.Size = New System.Drawing.Size(671, 450)
        Me.MenuItemDataGridView.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(249, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Menu Item"
        '
        'AddToCartButton
        '
        Me.AddToCartButton.Enabled = False
        Me.AddToCartButton.Location = New System.Drawing.Point(457, 525)
        Me.AddToCartButton.Name = "AddToCartButton"
        Me.AddToCartButton.Size = New System.Drawing.Size(146, 37)
        Me.AddToCartButton.TabIndex = 0
        Me.AddToCartButton.Text = "&Add to Cart"
        Me.AddToCartButton.UseVisualStyleBackColor = True
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Enabled = False
        Me.CheckOutButton.Location = New System.Drawing.Point(626, 525)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(128, 37)
        Me.CheckOutButton.TabIndex = 1
        Me.CheckOutButton.Text = "&Check Out"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(774, 525)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(128, 37)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AcceptButton = Me.AddToCartButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(936, 590)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CheckOutButton)
        Me.Controls.Add(Me.AddToCartButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuItemDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuTypeDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.MenuTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuTypeDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuItemDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents AddToCartButton As Button
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents ExitButton As Button
End Class
