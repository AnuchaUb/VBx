<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaledetail
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
        Me.crvSaledetail = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cbosale = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'crvSaledetail
        '
        Me.crvSaledetail.ActiveViewIndex = -1
        Me.crvSaledetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvSaledetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvSaledetail.DisplayStatusBar = False
        Me.crvSaledetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvSaledetail.Location = New System.Drawing.Point(0, 0)
        Me.crvSaledetail.Name = "crvSaledetail"
        Me.crvSaledetail.Size = New System.Drawing.Size(809, 528)
        Me.crvSaledetail.TabIndex = 0
        Me.crvSaledetail.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'cbosale
        '
        Me.cbosale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosale.FormattingEnabled = True
        Me.cbosale.Location = New System.Drawing.Point(482, 3)
        Me.cbosale.Name = "cbosale"
        Me.cbosale.Size = New System.Drawing.Size(121, 24)
        Me.cbosale.TabIndex = 1
        '
        'frmSaledetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 528)
        Me.Controls.Add(Me.cbosale)
        Me.Controls.Add(Me.crvSaledetail)
        Me.Name = "frmSaledetail"
        Me.Text = "Sale Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvSaledetail As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbosale As ComboBox
End Class
