<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomize
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomize))
        Me.clbColumnMain = New System.Windows.Forms.CheckedListBox()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnSaveSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'clbColumnMain
        '
        Me.clbColumnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbColumnMain.CheckOnClick = true
        Me.TableLayoutPanel1.SetColumnSpan(Me.clbColumnMain, 2)
        Me.clbColumnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbColumnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbColumnMain.FormattingEnabled = true
        Me.clbColumnMain.Location = New System.Drawing.Point(5, 6)
        Me.clbColumnMain.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.clbColumnMain.Name = "clbColumnMain"
        Me.clbColumnMain.Size = New System.Drawing.Size(886, 498)
        Me.clbColumnMain.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.clbColumnMain, "Если список пустой, то в главном реестре необходимо обновить список заказов")
        '
        'txtTest
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTest, 2)
        Me.txtTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTest.Location = New System.Drawing.Point(5, 516)
        Me.txtTest.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(886, 24)
        Me.txtTest.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnSaveSettings, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(896, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.TableLayoutPanel1.SetRowSpan(Me.ToolStrip1, 2)
        Me.ToolStrip1.Size = New System.Drawing.Size(89, 546)
        Me.ToolStrip1.TabIndex = 70
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnSaveSettings
        '
        Me.tsbtnSaveSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSaveSettings.Image = CType(resources.GetObject("tsbtnSaveSettings.Image"),System.Drawing.Image)
        Me.tsbtnSaveSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSaveSettings.Name = "tsbtnSaveSettings"
        Me.tsbtnSaveSettings.Size = New System.Drawing.Size(87, 22)
        Me.tsbtnSaveSettings.Text = "Применить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(87, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(87, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTest, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clbColumnMain, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(985, 546)
        Me.TableLayoutPanel1.TabIndex = 71
        '
        'frmCustomize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 546)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmCustomize"
        Me.Text = "Видимость столбцов в главном реестре"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents clbColumnMain As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtTest As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSaveSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
