<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiscountsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddDiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteDiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DiscountDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddDiscountGroupBox = New System.Windows.Forms.GroupBox()
        Me.DatesGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ValidFromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValidToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TemporaryRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountValueTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.SearchDiscountIDTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DBCancelButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DiscountDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddDiscountGroupBox.SuspendLayout()
        Me.DatesGroupBox.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDiscountToolStripMenuItem, Me.UpdateDiscountToolStripMenuItem, Me.DeleteDiscountToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(637, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddDiscountToolStripMenuItem
        '
        Me.AddDiscountToolStripMenuItem.Name = "AddDiscountToolStripMenuItem"
        Me.AddDiscountToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.AddDiscountToolStripMenuItem.Text = "&Add Discount"
        '
        'UpdateDiscountToolStripMenuItem
        '
        Me.UpdateDiscountToolStripMenuItem.Name = "UpdateDiscountToolStripMenuItem"
        Me.UpdateDiscountToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.UpdateDiscountToolStripMenuItem.Text = "&Update Discount"
        '
        'DeleteDiscountToolStripMenuItem
        '
        Me.DeleteDiscountToolStripMenuItem.Name = "DeleteDiscountToolStripMenuItem"
        Me.DeleteDiscountToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.DeleteDiscountToolStripMenuItem.Text = "&Delete Discount"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DiscountDataGridView)
        Me.Panel1.Controls.Add(Me.AddDiscountGroupBox)
        Me.Panel1.Location = New System.Drawing.Point(29, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 341)
        Me.Panel1.TabIndex = 1
        '
        'DiscountDataGridView
        '
        Me.DiscountDataGridView.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.DiscountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiscountDataGridView.Location = New System.Drawing.Point(3, 0)
        Me.DiscountDataGridView.Name = "DiscountDataGridView"
        Me.DiscountDataGridView.Size = New System.Drawing.Size(558, 338)
        Me.DiscountDataGridView.TabIndex = 1
        Me.DiscountDataGridView.Visible = False
        '
        'AddDiscountGroupBox
        '
        Me.AddDiscountGroupBox.Controls.Add(Me.DatesGroupBox)
        Me.AddDiscountGroupBox.Controls.Add(Me.SaveButton)
        Me.AddDiscountGroupBox.Controls.Add(Me.CancelButton)
        Me.AddDiscountGroupBox.Controls.Add(Me.TemporaryRadioButton)
        Me.AddDiscountGroupBox.Controls.Add(Me.DiscountValueTextBox)
        Me.AddDiscountGroupBox.Controls.Add(Me.DescriptionTextBox)
        Me.AddDiscountGroupBox.Controls.Add(Me.DiscountIDTextBox)
        Me.AddDiscountGroupBox.Controls.Add(Me.Label3)
        Me.AddDiscountGroupBox.Controls.Add(Me.Label2)
        Me.AddDiscountGroupBox.Controls.Add(Me.Label1)
        Me.AddDiscountGroupBox.Location = New System.Drawing.Point(84, 24)
        Me.AddDiscountGroupBox.Name = "AddDiscountGroupBox"
        Me.AddDiscountGroupBox.Size = New System.Drawing.Size(437, 303)
        Me.AddDiscountGroupBox.TabIndex = 0
        Me.AddDiscountGroupBox.TabStop = False
        Me.AddDiscountGroupBox.Text = "Add Discount"
        Me.AddDiscountGroupBox.Visible = False
        '
        'DatesGroupBox
        '
        Me.DatesGroupBox.Controls.Add(Me.Label4)
        Me.DatesGroupBox.Controls.Add(Me.Label5)
        Me.DatesGroupBox.Controls.Add(Me.ValidFromDateTimePicker)
        Me.DatesGroupBox.Controls.Add(Me.ValidToDateTimePicker)
        Me.DatesGroupBox.Location = New System.Drawing.Point(75, 152)
        Me.DatesGroupBox.Name = "DatesGroupBox"
        Me.DatesGroupBox.Size = New System.Drawing.Size(340, 109)
        Me.DatesGroupBox.TabIndex = 13
        Me.DatesGroupBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valid From"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valid To"
        '
        'ValidFromDateTimePicker
        '
        Me.ValidFromDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.ValidFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ValidFromDateTimePicker.Location = New System.Drawing.Point(84, 34)
        Me.ValidFromDateTimePicker.Name = "ValidFromDateTimePicker"
        Me.ValidFromDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.ValidFromDateTimePicker.TabIndex = 8
        '
        'ValidToDateTimePicker
        '
        Me.ValidToDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.ValidToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ValidToDateTimePicker.Location = New System.Drawing.Point(84, 64)
        Me.ValidToDateTimePicker.Name = "ValidToDateTimePicker"
        Me.ValidToDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.ValidToDateTimePicker.TabIndex = 9
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(242, 267)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(337, 267)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 11
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TemporaryRadioButton
        '
        Me.TemporaryRadioButton.AutoSize = True
        Me.TemporaryRadioButton.Location = New System.Drawing.Point(26, 133)
        Me.TemporaryRadioButton.Name = "TemporaryRadioButton"
        Me.TemporaryRadioButton.Size = New System.Drawing.Size(141, 19)
        Me.TemporaryRadioButton.TabIndex = 12
        Me.TemporaryRadioButton.TabStop = True
        Me.TemporaryRadioButton.Text = "Temporary discounts?"
        Me.TemporaryRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountValueTextBox
        '
        Me.DiscountValueTextBox.Location = New System.Drawing.Point(158, 97)
        Me.DiscountValueTextBox.MaxLength = 5
        Me.DiscountValueTextBox.Name = "DiscountValueTextBox"
        Me.DiscountValueTextBox.Size = New System.Drawing.Size(57, 23)
        Me.DiscountValueTextBox.TabIndex = 7
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(158, 66)
        Me.DescriptionTextBox.MaxLength = 50
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(225, 23)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'DiscountIDTextBox
        '
        Me.DiscountIDTextBox.Location = New System.Drawing.Point(158, 37)
        Me.DiscountIDTextBox.MaxLength = 7
        Me.DiscountIDTextBox.Name = "DiscountIDTextBox"
        Me.DiscountIDTextBox.Size = New System.Drawing.Size(81, 23)
        Me.DiscountIDTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Discount Value (in %)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Discount Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discount ID"
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(29, 34)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(122, 15)
        Me.SearchLabel.TabIndex = 2
        Me.SearchLabel.Text = "Search by Discount ID"
        Me.SearchLabel.Visible = False
        '
        'SearchDiscountIDTextBox
        '
        Me.SearchDiscountIDTextBox.Location = New System.Drawing.Point(157, 31)
        Me.SearchDiscountIDTextBox.MaxLength = 7
        Me.SearchDiscountIDTextBox.Name = "SearchDiscountIDTextBox"
        Me.SearchDiscountIDTextBox.Size = New System.Drawing.Size(99, 23)
        Me.SearchDiscountIDTextBox.TabIndex = 3
        Me.SearchDiscountIDTextBox.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DBCancelButton
        '
        Me.DBCancelButton.Location = New System.Drawing.Point(515, 413)
        Me.DBCancelButton.Name = "DBCancelButton"
        Me.DBCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.DBCancelButton.TabIndex = 5
        Me.DBCancelButton.Text = "&Cancel"
        Me.DBCancelButton.UseVisualStyleBackColor = True
        '
        'DiscountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(637, 454)
        Me.Controls.Add(Me.DBCancelButton)
        Me.Controls.Add(Me.SearchDiscountIDTextBox)
        Me.Controls.Add(Me.SearchLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DiscountsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Discounts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DiscountDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddDiscountGroupBox.ResumeLayout(False)
        Me.AddDiscountGroupBox.PerformLayout()
        Me.DatesGroupBox.ResumeLayout(False)
        Me.DatesGroupBox.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddDiscountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteDiscountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddDiscountGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents DiscountIDTextBox As TextBox
    Friend WithEvents DiscountValueTextBox As TextBox
    Friend WithEvents ValidToDateTimePicker As DateTimePicker
    Friend WithEvents ValidFromDateTimePicker As DateTimePicker
    Friend WithEvents DiscountDataGridView As DataGridView
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchDiscountIDTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TemporaryRadioButton As RadioButton
    Friend WithEvents DBCancelButton As Button
    Friend WithEvents DatesGroupBox As GroupBox
    Friend WithEvents SaveButton As Button
    Friend Shadows WithEvents CancelButton As Button
    Friend WithEvents UpdateDiscountToolStripMenuItem As ToolStripMenuItem
End Class
