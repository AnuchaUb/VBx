<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportStock
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
        Me.crvReportStock = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cboBrand = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'crvReportStock
        '
        Me.crvReportStock.ActiveViewIndex = -1
        Me.crvReportStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReportStock.DisplayStatusBar = False
        Me.crvReportStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportStock.Location = New System.Drawing.Point(0, 0)
        Me.crvReportStock.Name = "crvReportStock"
        Me.crvReportStock.Size = New System.Drawing.Size(1024, 485)
        Me.crvReportStock.TabIndex = 0
        Me.crvReportStock.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'cboBrand
        '
        Me.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(516, 3)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(145, 24)
        Me.cboBrand.TabIndex = 1
        '
        'frmReportStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 485)
        Me.Controls.Add(Me.cboBrand)
        Me.Controls.Add(Me.crvReportStock)
        Me.Name = "frmReportStock"
        Me.Text = "ReportStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvReportStock As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cboBrand As ComboBox
End Class
