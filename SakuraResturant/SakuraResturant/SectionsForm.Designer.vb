<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SectionsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PartyRadioButton = New System.Windows.Forms.RadioButton()
        Me.GrillRadioButton = New System.Windows.Forms.RadioButton()
        Me.HibachiRadioButton = New System.Windows.Forms.RadioButton()
        Me.DineInRadioButton = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImagesPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ImagesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PartyRadioButton)
        Me.GroupBox1.Controls.Add(Me.GrillRadioButton)
        Me.GroupBox1.Controls.Add(Me.HibachiRadioButton)
        Me.GroupBox1.Controls.Add(Me.DineInRadioButton)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(28, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Section"
        '
        'PartyRadioButton
        '
        Me.PartyRadioButton.AutoSize = True
        Me.PartyRadioButton.Location = New System.Drawing.Point(20, 157)
        Me.PartyRadioButton.Name = "PartyRadioButton"
        Me.PartyRadioButton.Size = New System.Drawing.Size(52, 19)
        Me.PartyRadioButton.TabIndex = 3
        Me.PartyRadioButton.TabStop = True
        Me.PartyRadioButton.Text = "Party"
        Me.PartyRadioButton.UseVisualStyleBackColor = True
        '
        'GrillRadioButton
        '
        Me.GrillRadioButton.AutoSize = True
        Me.GrillRadioButton.Location = New System.Drawing.Point(20, 120)
        Me.GrillRadioButton.Name = "GrillRadioButton"
        Me.GrillRadioButton.Size = New System.Drawing.Size(101, 19)
        Me.GrillRadioButton.TabIndex = 2
        Me.GrillRadioButton.TabStop = True
        Me.GrillRadioButton.Text = "Grill/Barbeque"
        Me.GrillRadioButton.UseVisualStyleBackColor = True
        '
        'HibachiRadioButton
        '
        Me.HibachiRadioButton.AutoSize = True
        Me.HibachiRadioButton.Location = New System.Drawing.Point(20, 81)
        Me.HibachiRadioButton.Name = "HibachiRadioButton"
        Me.HibachiRadioButton.Size = New System.Drawing.Size(66, 19)
        Me.HibachiRadioButton.TabIndex = 1
        Me.HibachiRadioButton.TabStop = True
        Me.HibachiRadioButton.Text = "&Hibachi"
        Me.HibachiRadioButton.UseVisualStyleBackColor = True
        '
        'DineInRadioButton
        '
        Me.DineInRadioButton.AutoSize = True
        Me.DineInRadioButton.Location = New System.Drawing.Point(20, 39)
        Me.DineInRadioButton.Name = "DineInRadioButton"
        Me.DineInRadioButton.Size = New System.Drawing.Size(123, 19)
        Me.DineInRadioButton.TabIndex = 0
        Me.DineInRadioButton.TabStop = True
        Me.DineInRadioButton.Text = "&Restaurant/Dine In"
        Me.DineInRadioButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Ho&me"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LOGOUTToolStripMenuItem.Text = "&LOGOUT"
        Me.LOGOUTToolStripMenuItem.Visible = False
        '
        'Timer1
        '
        '
        'ImagesPictureBox
        '
        Me.ImagesPictureBox.Location = New System.Drawing.Point(279, 54)
        Me.ImagesPictureBox.Name = "ImagesPictureBox"
        Me.ImagesPictureBox.Size = New System.Drawing.Size(680, 480)
        Me.ImagesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagesPictureBox.TabIndex = 1
        Me.ImagesPictureBox.TabStop = False
        '
        'SectionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.ImagesPictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SectionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese & Thai Restaurant - Sections"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ImagesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PartyRadioButton As RadioButton
    Friend WithEvents GrillRadioButton As RadioButton
    Friend WithEvents HibachiRadioButton As RadioButton
    Friend WithEvents DineInRadioButton As RadioButton
    Friend WithEvents ImagesPictureBox As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
