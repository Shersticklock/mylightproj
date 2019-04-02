<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatFormats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatFormats))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstMaterials = New System.Windows.Forms.ListBox()
        Me.tlpAttrMat = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNewMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEditMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSaveMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDeleteMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtformatName = New System.Windows.Forms.TextBox()
        Me.cmbAccessible = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsizeY = New System.Windows.Forms.TextBox()
        Me.txtsizeX = New System.Windows.Forms.TextBox()
        Me.chkDefault = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnacFormat = New System.Windows.Forms.TextBox()
        Me.txttotalDimX = New System.Windows.Forms.TextBox()
        Me.txttotalDimY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.tlpAttrMat.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstMaterials)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tlpAttrMat)
        Me.SplitContainer1.Size = New System.Drawing.Size(1163, 295)
        Me.SplitContainer1.SplitterDistance = 430
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 44
        '
        'lstMaterials
        '
        Me.lstMaterials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMaterials.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstMaterials.HorizontalScrollbar = true
        Me.lstMaterials.ItemHeight = 17
        Me.lstMaterials.Location = New System.Drawing.Point(0, 0)
        Me.lstMaterials.Margin = New System.Windows.Forms.Padding(4)
        Me.lstMaterials.Name = "lstMaterials"
        Me.lstMaterials.Size = New System.Drawing.Size(426, 291)
        Me.lstMaterials.TabIndex = 0
        '
        'tlpAttrMat
        '
        Me.tlpAttrMat.AutoSize = true
        Me.tlpAttrMat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAttrMat.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpAttrMat.ColumnCount = 3
        Me.tlpAttrMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAttrMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAttrMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188!))
        Me.tlpAttrMat.Controls.Add(Me.ToolStrip1, 2, 0)
        Me.tlpAttrMat.Controls.Add(Me.Label3, 0, 0)
        Me.tlpAttrMat.Controls.Add(Me.txtformatName, 1, 0)
        Me.tlpAttrMat.Controls.Add(Me.cmbAccessible, 1, 5)
        Me.tlpAttrMat.Controls.Add(Me.Label4, 0, 1)
        Me.tlpAttrMat.Controls.Add(Me.Label1, 0, 5)
        Me.tlpAttrMat.Controls.Add(Me.txtsizeY, 1, 1)
        Me.tlpAttrMat.Controls.Add(Me.txtsizeX, 1, 2)
        Me.tlpAttrMat.Controls.Add(Me.chkDefault, 0, 6)
        Me.tlpAttrMat.Controls.Add(Me.Label2, 0, 7)
        Me.tlpAttrMat.Controls.Add(Me.txtnacFormat, 1, 7)
        Me.tlpAttrMat.Controls.Add(Me.txttotalDimX, 1, 3)
        Me.tlpAttrMat.Controls.Add(Me.txttotalDimY, 1, 4)
        Me.tlpAttrMat.Controls.Add(Me.Label5, 0, 3)
        Me.tlpAttrMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpAttrMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpAttrMat.Location = New System.Drawing.Point(0, 0)
        Me.tlpAttrMat.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpAttrMat.Name = "tlpAttrMat"
        Me.tlpAttrMat.RowCount = 8
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22!))
        Me.tlpAttrMat.Size = New System.Drawing.Size(724, 256)
        Me.tlpAttrMat.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNewMat, Me.tsbtnEditMat, Me.tsbtnSaveMat, Me.tsbtnDeleteMat, Me.tsbtnCancel, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(535, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.tlpAttrMat.SetRowSpan(Me.ToolStrip1, 8)
        Me.ToolStrip1.Size = New System.Drawing.Size(188, 254)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'tsbtnNewMat
        '
        Me.tsbtnNewMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewMat.Image = CType(resources.GetObject("tsbtnNewMat.Image"),System.Drawing.Image)
        Me.tsbtnNewMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewMat.Name = "tsbtnNewMat"
        Me.tsbtnNewMat.Size = New System.Drawing.Size(186, 22)
        Me.tsbtnNewMat.Text = "Создать"
        Me.tsbtnNewMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnEditMat
        '
        Me.tsbtnEditMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEditMat.Image = CType(resources.GetObject("tsbtnEditMat.Image"),System.Drawing.Image)
        Me.tsbtnEditMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditMat.Name = "tsbtnEditMat"
        Me.tsbtnEditMat.Size = New System.Drawing.Size(186, 22)
        Me.tsbtnEditMat.Text = "Изменить"
        Me.tsbtnEditMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnSaveMat
        '
        Me.tsbtnSaveMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSaveMat.Image = CType(resources.GetObject("tsbtnSaveMat.Image"),System.Drawing.Image)
        Me.tsbtnSaveMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSaveMat.Name = "tsbtnSaveMat"
        Me.tsbtnSaveMat.Size = New System.Drawing.Size(186, 22)
        Me.tsbtnSaveMat.Text = "Сохранить"
        Me.tsbtnSaveMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnDeleteMat
        '
        Me.tsbtnDeleteMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDeleteMat.Image = CType(resources.GetObject("tsbtnDeleteMat.Image"),System.Drawing.Image)
        Me.tsbtnDeleteMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDeleteMat.Name = "tsbtnDeleteMat"
        Me.tsbtnDeleteMat.Size = New System.Drawing.Size(186, 22)
        Me.tsbtnDeleteMat.Text = "Удалить"
        Me.tsbtnDeleteMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(186, 22)
        Me.tsbtnCancel.Text = "Отмена"
        Me.tsbtnCancel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        Me.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(186, 22)
        Me.tsbtnExit.Text = "Выход"
        Me.tsbtnExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(5, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 32)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Наименование"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtformatName
        '
        Me.txtformatName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtformatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtformatName.Location = New System.Drawing.Point(224, 5)
        Me.txtformatName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtformatName.MaxLength = 250
        Me.txtformatName.Name = "txtformatName"
        Me.txtformatName.Size = New System.Drawing.Size(306, 24)
        Me.txtformatName.TabIndex = 0
        Me.txtformatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbAccessible
        '
        Me.cmbAccessible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAccessible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccessible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAccessible.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbAccessible.FormattingEnabled = true
        Me.cmbAccessible.Items.AddRange(New Object() {"Не доступен", "Доступен"})
        Me.cmbAccessible.Location = New System.Drawing.Point(224, 166)
        Me.cmbAccessible.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAccessible.Name = "cmbAccessible"
        Me.cmbAccessible.Size = New System.Drawing.Size(306, 25)
        Me.cmbAccessible.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(5, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.tlpAttrMat.SetRowSpan(Me.Label4, 2)
        Me.Label4.Size = New System.Drawing.Size(210, 65)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Размер печатного поля (мм)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(5, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 33)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Доступность"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsizeY
        '
        Me.txtsizeY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsizeY.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtsizeY.Location = New System.Drawing.Point(224, 38)
        Me.txtsizeY.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsizeY.MaxLength = 12
        Me.txtsizeY.Name = "txtsizeY"
        Me.txtsizeY.Size = New System.Drawing.Size(306, 24)
        Me.txtsizeY.TabIndex = 4
        Me.txtsizeY.Text = "0"
        Me.txtsizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsizeX
        '
        Me.txtsizeX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsizeX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtsizeX.Location = New System.Drawing.Point(224, 71)
        Me.txtsizeX.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsizeX.MaxLength = 12
        Me.txtsizeX.Name = "txtsizeX"
        Me.txtsizeX.Size = New System.Drawing.Size(306, 24)
        Me.txtsizeX.TabIndex = 5
        Me.txtsizeX.Text = "0"
        Me.txtsizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkDefault
        '
        Me.chkDefault.AutoSize = true
        Me.tlpAttrMat.SetColumnSpan(Me.chkDefault, 2)
        Me.chkDefault.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkDefault.Location = New System.Drawing.Point(4, 199)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDefault.Size = New System.Drawing.Size(527, 22)
        Me.chkDefault.TabIndex = 36
        Me.chkDefault.Text = "Формат по умолчанию"
        Me.chkDefault.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDefault.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(4, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 30)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Наценка (%)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnacFormat
        '
        Me.txtnacFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtnacFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtnacFormat.Location = New System.Drawing.Point(223, 228)
        Me.txtnacFormat.Name = "txtnacFormat"
        Me.txtnacFormat.Size = New System.Drawing.Size(308, 24)
        Me.txtnacFormat.TabIndex = 38
        Me.txtnacFormat.Text = "0"
        Me.txtnacFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotalDimX
        '
        Me.txttotalDimX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttotalDimX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txttotalDimX.Location = New System.Drawing.Point(223, 103)
        Me.txttotalDimX.Name = "txttotalDimX"
        Me.txttotalDimX.Size = New System.Drawing.Size(308, 24)
        Me.txttotalDimX.TabIndex = 39
        Me.txttotalDimX.Text = "0"
        Me.txttotalDimX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotalDimY
        '
        Me.txttotalDimY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttotalDimY.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txttotalDimY.Location = New System.Drawing.Point(223, 134)
        Me.txttotalDimY.Name = "txttotalDimY"
        Me.txttotalDimY.Size = New System.Drawing.Size(308, 24)
        Me.txttotalDimY.TabIndex = 40
        Me.txttotalDimY.Text = "0"
        Me.txttotalDimY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(4, 100)
        Me.Label5.Name = "Label5"
        Me.tlpAttrMat.SetRowSpan(Me.Label5, 2)
        Me.Label5.Size = New System.Drawing.Size(212, 61)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Габаритные размеры (мм)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMatFormats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 295)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMatFormats"
        Me.Text = "Печатные форматы материалов"
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.tlpAttrMat.ResumeLayout(false)
        Me.tlpAttrMat.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstMaterials As System.Windows.Forms.ListBox
    Friend WithEvents tlpAttrMat As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtformatName As System.Windows.Forms.TextBox
    Friend WithEvents cmbAccessible As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsizeY As System.Windows.Forms.TextBox
    Friend WithEvents txtsizeX As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNewMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEditMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSaveMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDeleteMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkDefault As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnacFormat As System.Windows.Forms.TextBox
    Friend WithEvents txttotalDimX As System.Windows.Forms.TextBox
    Friend WithEvents txttotalDimY As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
