<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCustomerReservationForm
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
        Me.CustReserveCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CustReserveCrystalReport2 = New SakuraResturant.CustReserveCrystalReport()
        Me.CustReserveCrystalReport1 = New SakuraResturant.CustReserveCrystalReport()
        Me.SuspendLayout()
        '
        'CustReserveCrystalReportViewer
        '
        Me.CustReserveCrystalReportViewer.ActiveViewIndex = 0
        Me.CustReserveCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustReserveCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CustReserveCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustReserveCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CustReserveCrystalReportViewer.Name = "CustReserveCrystalReportViewer"
        Me.CustReserveCrystalReportViewer.ReportSource = Me.CustReserveCrystalReport2
        Me.CustReserveCrystalReportViewer.Size = New System.Drawing.Size(784, 741)
        Me.CustReserveCrystalReportViewer.TabIndex = 0
        '
        'ViewCustomerReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(784, 741)
        Me.Controls.Add(Me.CustReserveCrystalReportViewer)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ViewCustomerReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Customer Reservation Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustReserveCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CustReserveCrystalReport1 As CustReserveCrystalReport
    Friend WithEvents CustReserveCrystalReport2 As CustReserveCrystalReport
End Class
