<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsumSale
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
        Me.crvReportsale = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvReportsale
        '
        Me.crvReportsale.ActiveViewIndex = -1
        Me.crvReportsale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportsale.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReportsale.DisplayStatusBar = False
        Me.crvReportsale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportsale.Location = New System.Drawing.Point(0, 0)
        Me.crvReportsale.Name = "crvReportsale"
        Me.crvReportsale.Size = New System.Drawing.Size(965, 564)
        Me.crvReportsale.TabIndex = 0
        Me.crvReportsale.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmsumSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 564)
        Me.Controls.Add(Me.crvReportsale)
        Me.Name = "frmsumSale"
        Me.Text = "Report Sale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvReportsale As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
