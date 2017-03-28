<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeReservationForm
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
        Me.EmployeeCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.EmployeeCrystalReport2 = New SakuraResturant.EmployeeCrystalReport()
        Me.EmployeeCrystalReport1 = New SakuraResturant.EmployeeCrystalReport()
        Me.SuspendLayout()
        '
        'EmployeeCrystalReportViewer
        '
        Me.EmployeeCrystalReportViewer.ActiveViewIndex = 0
        Me.EmployeeCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmployeeCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.EmployeeCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeeCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeCrystalReportViewer.Name = "EmployeeCrystalReportViewer"
        Me.EmployeeCrystalReportViewer.ReportSource = Me.EmployeeCrystalReport2
        Me.EmployeeCrystalReportViewer.Size = New System.Drawing.Size(658, 482)
        Me.EmployeeCrystalReportViewer.TabIndex = 0
        '
        'EmployeeReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(658, 482)
        Me.Controls.Add(Me.EmployeeCrystalReportViewer)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "EmployeeReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Reservations by Employees"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmployeeCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents EmployeeCrystalReport1 As EmployeeCrystalReport
    Friend WithEvents EmployeeCrystalReport2 As EmployeeCrystalReport
End Class
