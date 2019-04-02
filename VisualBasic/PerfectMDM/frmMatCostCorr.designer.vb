<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatCostCorr
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatCostCorr))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvMatCorr = New System.Windows.Forms.TreeView()
        Me.tlpAttrMat = New System.Windows.Forms.TableLayoutPanel()
        Me.nudK = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMatType = New System.Windows.Forms.ComboBox()
        Me.nudKbay = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnSaveMat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ВставитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDelType = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDelCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAddTypeInCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAddCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsTV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.iml1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.tlpAttrMat.SuspendLayout
        CType(Me.nudK,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudKbay,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        Me.cmsTV.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34!))
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1146, 624)
        Me.TableLayoutPanel1.TabIndex = 52
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 6)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvMatCorr)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tlpAttrMat)
        Me.SplitContainer1.Size = New System.Drawing.Size(1047, 612)
        Me.SplitContainer1.SplitterDistance = 431
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 50
        '
        'tvMatCorr
        '
        Me.tvMatCorr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMatCorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMatCorr.Location = New System.Drawing.Point(0, 0)
        Me.tvMatCorr.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tvMatCorr.Name = "tvMatCorr"
        Me.tvMatCorr.Size = New System.Drawing.Size(427, 608)
        Me.tvMatCorr.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.tvMatCorr, "Первый уровень - категории, второй уровень - типы материалов")
        '
        'tlpAttrMat
        '
        Me.tlpAttrMat.AutoSize = true
        Me.tlpAttrMat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAttrMat.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpAttrMat.ColumnCount = 2
        Me.tlpAttrMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAttrMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAttrMat.Controls.Add(Me.nudK, 1, 1)
        Me.tlpAttrMat.Controls.Add(Me.Label1, 0, 1)
        Me.tlpAttrMat.Controls.Add(Me.cmbMatType, 0, 0)
        Me.tlpAttrMat.Controls.Add(Me.nudKbay, 1, 2)
        Me.tlpAttrMat.Controls.Add(Me.Label2, 0, 2)
        Me.tlpAttrMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpAttrMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpAttrMat.Location = New System.Drawing.Point(0, 0)
        Me.tlpAttrMat.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tlpAttrMat.Name = "tlpAttrMat"
        Me.tlpAttrMat.RowCount = 4
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.Size = New System.Drawing.Size(606, 110)
        Me.tlpAttrMat.TabIndex = 1
        '
        'nudK
        '
        Me.nudK.DecimalPlaces = 4
        Me.nudK.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudK.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudK.Location = New System.Drawing.Point(457, 41)
        Me.nudK.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudK.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudK.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudK.Name = "nudK"
        Me.nudK.Size = New System.Drawing.Size(143, 26)
        Me.nudK.TabIndex = 43
        Me.nudK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudK.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 38)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Коэфициент для продажной цены"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMatType
        '
        Me.tlpAttrMat.SetColumnSpan(Me.cmbMatType, 2)
        Me.cmbMatType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatType.Enabled = false
        Me.cmbMatType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMatType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatType.FormattingEnabled = true
        Me.cmbMatType.Location = New System.Drawing.Point(5, 5)
        Me.cmbMatType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMatType.Name = "cmbMatType"
        Me.cmbMatType.Size = New System.Drawing.Size(596, 25)
        Me.cmbMatType.TabIndex = 45
        '
        'nudKbay
        '
        Me.nudKbay.DecimalPlaces = 4
        Me.nudKbay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudKbay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudKbay.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudKbay.Location = New System.Drawing.Point(456, 78)
        Me.nudKbay.Margin = New System.Windows.Forms.Padding(4)
        Me.nudKbay.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudKbay.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudKbay.Name = "nudKbay"
        Me.nudKbay.Size = New System.Drawing.Size(145, 26)
        Me.nudKbay.TabIndex = 46
        Me.nudKbay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudKbay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(442, 34)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Коэфициент для закупочной цены"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnSaveMat, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(1057, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(89, 624)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'tsbtnSaveMat
        '
        Me.tsbtnSaveMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSaveMat.Image = CType(resources.GetObject("tsbtnSaveMat.Image"),System.Drawing.Image)
        Me.tsbtnSaveMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSaveMat.Name = "tsbtnSaveMat"
        Me.tsbtnSaveMat.Size = New System.Drawing.Size(87, 22)
        Me.tsbtnSaveMat.Text = "Применить"
        Me.tsbtnSaveMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(87, 6)
        Me.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(87, 22)
        Me.tsbtnExit.Text = "Выход"
        Me.tsbtnExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ВставитьToolStripMenuItem
        '
        Me.ВставитьToolStripMenuItem.Name = "ВставитьToolStripMenuItem"
        Me.ВставитьToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ВставитьToolStripMenuItem.Text = "Вставить"
        '
        'КопироватьToolStripMenuItem
        '
        Me.КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        Me.КопироватьToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.КопироватьToolStripMenuItem.Text = "Копировать"
        '
        'tsmDelType
        '
        Me.tsmDelType.Name = "tsmDelType"
        Me.tsmDelType.Size = New System.Drawing.Size(188, 22)
        Me.tsmDelType.Text = "Удалить тип"
        '
        'tsmDelCat
        '
        Me.tsmDelCat.Name = "tsmDelCat"
        Me.tsmDelCat.Size = New System.Drawing.Size(188, 22)
        Me.tsmDelCat.Text = "Удалить категорию"
        '
        'tsmAddTypeInCat
        '
        Me.tsmAddTypeInCat.Name = "tsmAddTypeInCat"
        Me.tsmAddTypeInCat.Size = New System.Drawing.Size(188, 22)
        Me.tsmAddTypeInCat.Text = "Добавить тип"
        '
        'tsmAddCat
        '
        Me.tsmAddCat.Name = "tsmAddCat"
        Me.tsmAddCat.Size = New System.Drawing.Size(188, 22)
        Me.tsmAddCat.Text = "Добавить категорию"
        '
        'cmsTV
        '
        Me.cmsTV.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAddCat, Me.tsmAddTypeInCat, Me.tsmDelCat, Me.tsmDelType, Me.КопироватьToolStripMenuItem, Me.ВставитьToolStripMenuItem})
        Me.cmsTV.Name = "cmsTV"
        Me.cmsTV.Size = New System.Drawing.Size(189, 136)
        '
        'iml1
        '
        Me.iml1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iml1.ImageSize = New System.Drawing.Size(16, 16)
        Me.iml1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        '
        'frmMatCostCorr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 624)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmMatCostCorr"
        Me.Text = "frmMatCostCorr"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.tlpAttrMat.ResumeLayout(false)
        Me.tlpAttrMat.PerformLayout
        CType(Me.nudK,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudKbay,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.cmsTV.ResumeLayout(false)
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tvMatCorr As System.Windows.Forms.TreeView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tlpAttrMat As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSaveMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ВставитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КопироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAddTypeInCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAddCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsTV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents iml1 As System.Windows.Forms.ImageList
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents nudK As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMatType As System.Windows.Forms.ComboBox
    Friend WithEvents nudKbay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
