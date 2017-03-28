<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCityReservationForm
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
        Me.CityCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CityCrystalReport1 = New SakuraResturant.CityCrystalReport()
        Me.SuspendLayout()
        '
        'CityCrystalReportViewer
        '
        Me.CityCrystalReportViewer.ActiveViewIndex = -1
        Me.CityCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CityCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CityCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CityCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CityCrystalReportViewer.Name = "CityCrystalReportViewer"
        Me.CityCrystalReportViewer.Size = New System.Drawing.Size(663, 474)
        Me.CityCrystalReportViewer.TabIndex = 0
        '
        'ViewCityReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 474)
        Me.Controls.Add(Me.CityCrystalReportViewer)
        Me.Name = "ViewCityReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Reservations by City"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CityCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CityCrystalReport1 As CityCrystalReport
End Class
