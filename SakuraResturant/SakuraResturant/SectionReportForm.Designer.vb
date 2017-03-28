<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SectionReportForm
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
        Me.SectionCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SectionCrystalReport1 = New SakuraResturant.SectionCrystalReport()
        Me.SuspendLayout()
        '
        'SectionCrystalReportViewer
        '
        Me.SectionCrystalReportViewer.ActiveViewIndex = 0
        Me.SectionCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SectionCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.SectionCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SectionCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.SectionCrystalReportViewer.Name = "SectionCrystalReportViewer"
        Me.SectionCrystalReportViewer.ReportSource = Me.SectionCrystalReport1
        Me.SectionCrystalReportViewer.Size = New System.Drawing.Size(690, 463)
        Me.SectionCrystalReportViewer.TabIndex = 0
        '
        'SectionReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 463)
        Me.Controls.Add(Me.SectionCrystalReportViewer)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SectionReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Section Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SectionCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SectionCrystalReport1 As SectionCrystalReport
End Class
