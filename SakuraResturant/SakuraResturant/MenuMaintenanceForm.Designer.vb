<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMaintenanceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateMenuTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateMenuItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenuTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenuItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMenuTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.CancelMenuTypeButton = New System.Windows.Forms.Button()
        Me.SaveMenuTypeButton = New System.Windows.Forms.Button()
        Me.MenuDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.MenuTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddMenuItemGroupBox = New System.Windows.Forms.GroupBox()
        Me.MenuTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.MenuItemCancelButton = New System.Windows.Forms.Button()
        Me.MenuItemSaveButton = New System.Windows.Forms.Button()
        Me.ItemDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ItemTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuMaintenancePanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.AddMenuTypeGroupBox.SuspendLayout()
        Me.AddMenuItemGroupBox.SuspendLayout()
        Me.MenuMaintenancePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuTypeToolStripMenuItem, Me.MenuItemToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'MenuTypeToolStripMenuItem
        '
        Me.MenuTypeToolStripMenuItem.Name = "MenuTypeToolStripMenuItem"
        Me.MenuTypeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MenuTypeToolStripMenuItem.Text = "Menu Type"
        '
        'MenuItemToolStripMenuItem
        '
        Me.MenuItemToolStripMenuItem.Name = "MenuItemToolStripMenuItem"
        Me.MenuItemToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MenuItemToolStripMenuItem.Text = "Menu Item"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateMenuTypeToolStripMenuItem, Me.UpdateMenuItemToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "&Update"
        '
        'UpdateMenuTypeToolStripMenuItem
        '
        Me.UpdateMenuTypeToolStripMenuItem.Name = "UpdateMenuTypeToolStripMenuItem"
        Me.UpdateMenuTypeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.UpdateMenuTypeToolStripMenuItem.Text = "Menu Type"
        '
        'UpdateMenuItemToolStripMenuItem
        '
        Me.UpdateMenuItemToolStripMenuItem.Name = "UpdateMenuItemToolStripMenuItem"
        Me.UpdateMenuItemToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.UpdateMenuItemToolStripMenuItem.Text = "Menu Item"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteMenuTypeToolStripMenuItem, Me.DeleteMenuItemToolStripMenuItem})
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'DeleteMenuTypeToolStripMenuItem
        '
        Me.DeleteMenuTypeToolStripMenuItem.Name = "DeleteMenuTypeToolStripMenuItem"
        Me.DeleteMenuTypeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteMenuTypeToolStripMenuItem.Text = "Menu Type"
        '
        'DeleteMenuItemToolStripMenuItem
        '
        Me.DeleteMenuItemToolStripMenuItem.Name = "DeleteMenuItemToolStripMenuItem"
        Me.DeleteMenuItemToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteMenuItemToolStripMenuItem.Text = "Menu Item"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AddMenuTypeGroupBox
        '
        Me.AddMenuTypeGroupBox.Controls.Add(Me.CancelMenuTypeButton)
        Me.AddMenuTypeGroupBox.Controls.Add(Me.SaveMenuTypeButton)
        Me.AddMenuTypeGroupBox.Controls.Add(Me.MenuDescriptionTextBox)
        Me.AddMenuTypeGroupBox.Controls.Add(Me.MenuTypeTextBox)
        Me.AddMenuTypeGroupBox.Controls.Add(Me.Label2)
        Me.AddMenuTypeGroupBox.Controls.Add(Me.Label1)
        Me.AddMenuTypeGroupBox.Location = New System.Drawing.Point(52, 15)
        Me.AddMenuTypeGroupBox.Name = "AddMenuTypeGroupBox"
        Me.AddMenuTypeGroupBox.Size = New System.Drawing.Size(559, 289)
        Me.AddMenuTypeGroupBox.TabIndex = 1
        Me.AddMenuTypeGroupBox.TabStop = False
        Me.AddMenuTypeGroupBox.Text = "Add Menu Type"
        Me.AddMenuTypeGroupBox.Visible = False
        '
        'CancelMenuTypeButton
        '
        Me.CancelMenuTypeButton.Location = New System.Drawing.Point(451, 240)
        Me.CancelMenuTypeButton.Name = "CancelMenuTypeButton"
        Me.CancelMenuTypeButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelMenuTypeButton.TabIndex = 5
        Me.CancelMenuTypeButton.Text = "&Cancel"
        Me.CancelMenuTypeButton.UseVisualStyleBackColor = True
        '
        'SaveMenuTypeButton
        '
        Me.SaveMenuTypeButton.Location = New System.Drawing.Point(358, 240)
        Me.SaveMenuTypeButton.Name = "SaveMenuTypeButton"
        Me.SaveMenuTypeButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveMenuTypeButton.TabIndex = 4
        Me.SaveMenuTypeButton.Text = "&Save"
        Me.SaveMenuTypeButton.UseVisualStyleBackColor = True
        '
        'MenuDescriptionTextBox
        '
        Me.MenuDescriptionTextBox.Location = New System.Drawing.Point(191, 96)
        Me.MenuDescriptionTextBox.MaxLength = 300
        Me.MenuDescriptionTextBox.Multiline = True
        Me.MenuDescriptionTextBox.Name = "MenuDescriptionTextBox"
        Me.MenuDescriptionTextBox.Size = New System.Drawing.Size(335, 78)
        Me.MenuDescriptionTextBox.TabIndex = 3
        '
        'MenuTypeTextBox
        '
        Me.MenuTypeTextBox.Location = New System.Drawing.Point(191, 56)
        Me.MenuTypeTextBox.MaxLength = 45
        Me.MenuTypeTextBox.Name = "MenuTypeTextBox"
        Me.MenuTypeTextBox.Size = New System.Drawing.Size(222, 23)
        Me.MenuTypeTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Menu Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Type"
        '
        'AddMenuItemGroupBox
        '
        Me.AddMenuItemGroupBox.Controls.Add(Me.MenuTypeComboBox)
        Me.AddMenuItemGroupBox.Controls.Add(Me.MenuItemCancelButton)
        Me.AddMenuItemGroupBox.Controls.Add(Me.MenuItemSaveButton)
        Me.AddMenuItemGroupBox.Controls.Add(Me.ItemDescriptionTextBox)
        Me.AddMenuItemGroupBox.Controls.Add(Me.PriceTextBox)
        Me.AddMenuItemGroupBox.Controls.Add(Me.ItemTypeTextBox)
        Me.AddMenuItemGroupBox.Controls.Add(Me.Label6)
        Me.AddMenuItemGroupBox.Controls.Add(Me.Label5)
        Me.AddMenuItemGroupBox.Controls.Add(Me.Label4)
        Me.AddMenuItemGroupBox.Controls.Add(Me.Label3)
        Me.AddMenuItemGroupBox.Location = New System.Drawing.Point(46, 41)
        Me.AddMenuItemGroupBox.Name = "AddMenuItemGroupBox"
        Me.AddMenuItemGroupBox.Size = New System.Drawing.Size(559, 289)
        Me.AddMenuItemGroupBox.TabIndex = 0
        Me.AddMenuItemGroupBox.TabStop = False
        Me.AddMenuItemGroupBox.Text = "Add Menu Item"
        Me.AddMenuItemGroupBox.Visible = False
        '
        'MenuTypeComboBox
        '
        Me.MenuTypeComboBox.FormattingEnabled = True
        Me.MenuTypeComboBox.Location = New System.Drawing.Point(155, 41)
        Me.MenuTypeComboBox.Name = "MenuTypeComboBox"
        Me.MenuTypeComboBox.Size = New System.Drawing.Size(204, 23)
        Me.MenuTypeComboBox.TabIndex = 0
        '
        'MenuItemCancelButton
        '
        Me.MenuItemCancelButton.Location = New System.Drawing.Point(451, 240)
        Me.MenuItemCancelButton.Name = "MenuItemCancelButton"
        Me.MenuItemCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.MenuItemCancelButton.TabIndex = 5
        Me.MenuItemCancelButton.Text = "&Cancel"
        Me.MenuItemCancelButton.UseVisualStyleBackColor = True
        '
        'MenuItemSaveButton
        '
        Me.MenuItemSaveButton.Location = New System.Drawing.Point(358, 240)
        Me.MenuItemSaveButton.Name = "MenuItemSaveButton"
        Me.MenuItemSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.MenuItemSaveButton.TabIndex = 4
        Me.MenuItemSaveButton.Text = "&Save"
        Me.MenuItemSaveButton.UseVisualStyleBackColor = True
        '
        'ItemDescriptionTextBox
        '
        Me.ItemDescriptionTextBox.Location = New System.Drawing.Point(155, 105)
        Me.ItemDescriptionTextBox.MaxLength = 300
        Me.ItemDescriptionTextBox.Multiline = True
        Me.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox"
        Me.ItemDescriptionTextBox.Size = New System.Drawing.Size(324, 45)
        Me.ItemDescriptionTextBox.TabIndex = 2
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(155, 156)
        Me.PriceTextBox.MaxLength = 12
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(94, 23)
        Me.PriceTextBox.TabIndex = 3
        '
        'ItemTypeTextBox
        '
        Me.ItemTypeTextBox.Location = New System.Drawing.Point(155, 72)
        Me.ItemTypeTextBox.MaxLength = 45
        Me.ItemTypeTextBox.Name = "ItemTypeTextBox"
        Me.ItemTypeTextBox.Size = New System.Drawing.Size(204, 23)
        Me.ItemTypeTextBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Item Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Item Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Menu Type"
        '
        'MenuMaintenancePanel
        '
        Me.MenuMaintenancePanel.Controls.Add(Me.AddMenuItemGroupBox)
        Me.MenuMaintenancePanel.Controls.Add(Me.AddMenuTypeGroupBox)
        Me.MenuMaintenancePanel.Location = New System.Drawing.Point(35, 74)
        Me.MenuMaintenancePanel.Name = "MenuMaintenancePanel"
        Me.MenuMaintenancePanel.Size = New System.Drawing.Size(653, 355)
        Me.MenuMaintenancePanel.TabIndex = 2
        '
        'MenuMaintenanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(733, 441)
        Me.Controls.Add(Me.MenuMaintenancePanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuMaintenanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Menu Maintenance"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.AddMenuTypeGroupBox.ResumeLayout(False)
        Me.AddMenuTypeGroupBox.PerformLayout()
        Me.AddMenuItemGroupBox.ResumeLayout(False)
        Me.AddMenuItemGroupBox.PerformLayout()
        Me.MenuMaintenancePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateMenuTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateMenuItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteMenuTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteMenuItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMenuTypeGroupBox As GroupBox
    Friend WithEvents AddMenuItemGroupBox As GroupBox
    Friend WithEvents MenuTypeComboBox As ComboBox
    Friend WithEvents MenuItemCancelButton As Button
    Friend WithEvents MenuItemSaveButton As Button
    Friend WithEvents ItemDescriptionTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ItemTypeTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CancelMenuTypeButton As Button
    Friend WithEvents SaveMenuTypeButton As Button
    Friend WithEvents MenuDescriptionTextBox As TextBox
    Friend WithEvents MenuTypeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuMaintenancePanel As Panel
End Class
