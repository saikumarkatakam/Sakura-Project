<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerLogin
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
        Me.ViewSectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewYourReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatePersonalInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSectionsToolStripMenuItem, Me.ViewMenuToolStripMenuItem, Me.ReservationsToolStripMenuItem, Me.ContactUsToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.SettingsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewSectionsToolStripMenuItem
        '
        Me.ViewSectionsToolStripMenuItem.Name = "ViewSectionsToolStripMenuItem"
        Me.ViewSectionsToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ViewSectionsToolStripMenuItem.Text = "View &Sections"
        '
        'ViewMenuToolStripMenuItem
        '
        Me.ViewMenuToolStripMenuItem.Name = "ViewMenuToolStripMenuItem"
        Me.ViewMenuToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.ViewMenuToolStripMenuItem.Text = "View &Menu"
        '
        'ReservationsToolStripMenuItem
        '
        Me.ReservationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeReservationToolStripMenuItem, Me.ChangeReservationToolStripMenuItem, Me.CancelReservationToolStripMenuItem, Me.ViewYourReservationsToolStripMenuItem})
        Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
        Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ReservationsToolStripMenuItem.Text = "&Reservations"
        '
        'MakeReservationToolStripMenuItem
        '
        Me.MakeReservationToolStripMenuItem.Name = "MakeReservationToolStripMenuItem"
        Me.MakeReservationToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.MakeReservationToolStripMenuItem.Text = "&Make Reservation"
        '
        'ChangeReservationToolStripMenuItem
        '
        Me.ChangeReservationToolStripMenuItem.Name = "ChangeReservationToolStripMenuItem"
        Me.ChangeReservationToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ChangeReservationToolStripMenuItem.Text = "C&hange Reservation"
        '
        'CancelReservationToolStripMenuItem
        '
        Me.CancelReservationToolStripMenuItem.Name = "CancelReservationToolStripMenuItem"
        Me.CancelReservationToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CancelReservationToolStripMenuItem.Text = "Canc&el Reservation"
        '
        'ViewYourReservationsToolStripMenuItem
        '
        Me.ViewYourReservationsToolStripMenuItem.Name = "ViewYourReservationsToolStripMenuItem"
        Me.ViewYourReservationsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ViewYourReservationsToolStripMenuItem.Text = "&View your Reservations"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ContactUsToolStripMenuItem.Text = "&Contact Us"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(70, 20)
        Me.AboutToolStripMenuItem1.Text = "&About Us"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdatePersonalInfoToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.DeleteAccountToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'UpdatePersonalInfoToolStripMenuItem
        '
        Me.UpdatePersonalInfoToolStripMenuItem.Name = "UpdatePersonalInfoToolStripMenuItem"
        Me.UpdatePersonalInfoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UpdatePersonalInfoToolStripMenuItem.Text = "&Update Personal Info"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'DeleteAccountToolStripMenuItem
        '
        Me.DeleteAccountToolStripMenuItem.Name = "DeleteAccountToolStripMenuItem"
        Me.DeleteAccountToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DeleteAccountToolStripMenuItem.Text = "&Deactivate Account"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.LogOutToolStripMenuItem.Text = "&LOGOUT"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CustomerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = Global.SakuraResturant.My.Resources.Resources.CustomerLogin_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CustomerLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese & Thai Restaurant"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewSectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewYourReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdatePersonalInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
End Class
