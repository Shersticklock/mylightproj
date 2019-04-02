<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigTechOper
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigTechOper))
        Me.lstDep = New System.Windows.Forms.ListBox()
        Me.lstSelect = New System.Windows.Forms.ListBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnUnSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lstOper = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'lstDep
        '
        Me.lstDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstDep.HorizontalScrollbar = true
        Me.lstDep.ItemHeight = 17
        Me.lstDep.Location = New System.Drawing.Point(4, 4)
        Me.lstDep.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDep.Name = "lstDep"
        Me.TableLayoutPanel1.SetRowSpan(Me.lstDep, 2)
        Me.lstDep.Size = New System.Drawing.Size(419, 376)
        Me.lstDep.TabIndex = 77
        Me.lstDep.TabStop = false
        '
        'lstSelect
        '
        Me.lstSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstSelect.FormattingEnabled = true
        Me.lstSelect.HorizontalScrollbar = true
        Me.lstSelect.ItemHeight = 17
        Me.lstSelect.Location = New System.Drawing.Point(844, 4)
        Me.lstSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSelect.Name = "lstSelect"
        Me.TableLayoutPanel1.SetRowSpan(Me.lstSelect, 2)
        Me.lstSelect.Size = New System.Drawing.Size(428, 376)
        Me.lstSelect.TabIndex = 76
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = false
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.tsbtnSelect, Me.tsbtnUnSelect, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(427, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(413, 136)
        Me.ToolStrip2.TabIndex = 75
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(411, 18)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(411, 6)
        '
        'tsbtnSelect
        '
        Me.tsbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnSelect.Image = CType(resources.GetObject("tsbtnSelect.Image"),System.Drawing.Image)
        Me.tsbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSelect.Name = "tsbtnSelect"
        Me.tsbtnSelect.Size = New System.Drawing.Size(411, 24)
        Me.tsbtnSelect.Text = ">>>"
        '
        'tsbtnUnSelect
        '
        Me.tsbtnUnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnUnSelect.Image = CType(resources.GetObject("tsbtnUnSelect.Image"),System.Drawing.Image)
        Me.tsbtnUnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUnSelect.Name = "tsbtnUnSelect"
        Me.tsbtnUnSelect.Size = New System.Drawing.Size(411, 24)
        Me.tsbtnUnSelect.Text = "<<<"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(411, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(411, 22)
        Me.ToolStripButton1.Text = "Выход"
        '
        'lstOper
        '
        Me.lstOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstOper.FormattingEnabled = true
        Me.lstOper.HorizontalScrollbar = true
        Me.lstOper.ItemHeight = 17
        Me.lstOper.Location = New System.Drawing.Point(431, 140)
        Me.lstOper.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOper.Name = "lstOper"
        Me.lstOper.Size = New System.Drawing.Size(405, 240)
        Me.lstOper.TabIndex = 74
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.48554!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.34399!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.09437!))
        Me.TableLayoutPanel1.Controls.Add(Me.lstDep, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstSelect, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstOper, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 384)
        Me.TableLayoutPanel1.TabIndex = 78
        '
        'frmConfigTechOper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 384)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConfigTechOper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "ControlTagItem-операции"
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lstDep As System.Windows.Forms.ListBox
    Friend WithEvents lstSelect As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnUnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstOper As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
