<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tech_EmplEquip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tech_EmplEquip))
        Me.lstEquipment = New System.Windows.Forms.ListBox()
        Me.lstEml = New System.Windows.Forms.ListBox()
        Me.tsbtnUnSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSelect = New System.Windows.Forms.ToolStripButton()
        Me.lstSelect = New System.Windows.Forms.ListBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'lstEquipment
        '
        Me.lstEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstEquipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstEquipment.HorizontalScrollbar = true
        Me.lstEquipment.ItemHeight = 17
        Me.lstEquipment.Location = New System.Drawing.Point(4, 4)
        Me.lstEquipment.Margin = New System.Windows.Forms.Padding(4)
        Me.lstEquipment.Name = "lstEquipment"
        Me.TableLayoutPanel1.SetRowSpan(Me.lstEquipment, 2)
        Me.lstEquipment.Size = New System.Drawing.Size(438, 644)
        Me.lstEquipment.TabIndex = 77
        Me.lstEquipment.TabStop = false
        '
        'lstEml
        '
        Me.lstEml.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstEml.FormattingEnabled = true
        Me.lstEml.HorizontalScrollbar = true
        Me.lstEml.ItemHeight = 17
        Me.lstEml.Location = New System.Drawing.Point(450, 154)
        Me.lstEml.Margin = New System.Windows.Forms.Padding(4)
        Me.lstEml.Name = "lstEml"
        Me.lstEml.Size = New System.Drawing.Size(374, 494)
        Me.lstEml.TabIndex = 74
        '
        'tsbtnUnSelect
        '
        Me.tsbtnUnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUnSelect.Image = CType(resources.GetObject("tsbtnUnSelect.Image"),System.Drawing.Image)
        Me.tsbtnUnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUnSelect.Name = "tsbtnUnSelect"
        Me.tsbtnUnSelect.Size = New System.Drawing.Size(380, 24)
        Me.tsbtnUnSelect.Text = "<<<"
        '
        'tsbtnSelect
        '
        Me.tsbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSelect.Image = CType(resources.GetObject("tsbtnSelect.Image"),System.Drawing.Image)
        Me.tsbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSelect.Name = "tsbtnSelect"
        Me.tsbtnSelect.Size = New System.Drawing.Size(380, 24)
        Me.tsbtnSelect.Text = ">>>"
        '
        'lstSelect
        '
        Me.lstSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstSelect.FormattingEnabled = true
        Me.lstSelect.HorizontalScrollbar = true
        Me.lstSelect.ItemHeight = 17
        Me.lstSelect.Location = New System.Drawing.Point(832, 4)
        Me.lstSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSelect.Name = "lstSelect"
        Me.TableLayoutPanel1.SetRowSpan(Me.lstSelect, 2)
        Me.lstSelect.Size = New System.Drawing.Size(440, 644)
        Me.lstSelect.TabIndex = 76
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = false
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnSelect, Me.tsbtnUnSelect})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(446, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(382, 150)
        Me.ToolStrip2.TabIndex = 75
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35!))
        Me.TableLayoutPanel1.Controls.Add(Me.lstEquipment, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstSelect, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstEml, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 652)
        Me.TableLayoutPanel1.TabIndex = 79
        '
        'tech_EmplEquip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 652)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "tech_EmplEquip"
        Me.Text = "Допуски"
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lstEquipment As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstSelect As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnUnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstEml As System.Windows.Forms.ListBox
End Class
