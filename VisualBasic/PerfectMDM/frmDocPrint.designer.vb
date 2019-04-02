Imports CrystalDecisions.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocPrint))
        Me.cmsCR = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ÎòïğàâèòüÏîEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmsCR.SuspendLayout
        Me.SuspendLayout
        '
        'cmsCR
        '
        Me.cmsCR.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÎòïğàâèòüÏîEmailToolStripMenuItem})
        Me.cmsCR.Name = "cmsCR"
        Me.cmsCR.Size = New System.Drawing.Size(187, 26)
        '
        'ÎòïğàâèòüÏîEmailToolStripMenuItem
        '
        Me.ÎòïğàâèòüÏîEmailToolStripMenuItem.Name = "ÎòïğàâèòüÏîEmailToolStripMenuItem"
        Me.ÎòïğàâèòüÏîEmailToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ÎòïğàâèòüÏîEmailToolStripMenuItem.Text = "Îòïğàâèòü ïî e-mail"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1276, 578)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'frmDocPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 578)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmDocPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ñôîğìèğîâàííûé äîêóìåíò"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmsCR.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents cmsCR As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ÎòïğàâèòüÏîEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
