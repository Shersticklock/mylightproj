<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_FastOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_FastOrder))
        Me.lblMatTypes = New System.Windows.Forms.Label()
        Me.cmbPriceGroup = New System.Windows.Forms.ComboBox()
        Me.cmbPriceName = New System.Windows.Forms.ComboBox()
        Me.cmsConfigTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbParam2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgDataTable = New System.Windows.Forms.DataGridView()
        Me.btnDelRow = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.cmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.cmsConfigMat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clbOper = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudQuantity2 = New System.Windows.Forms.NumericUpDown()
        Me.nudQuantity1 = New System.Windows.Forms.NumericUpDown()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtNac = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnCard = New System.Windows.Forms.ToolStripButton()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnSetPrice = New System.Windows.Forms.ToolStripButton()
        Me.tstxt = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.cmsConfigTech.SuspendLayout
        CType(Me.dgDataTable,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.cmsConfigMat.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.nudQuantity2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudQuantity1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'lblMatTypes
        '
        Me.lblMatTypes.AutoSize = true
        Me.lblMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblMatTypes.Location = New System.Drawing.Point(5, 152)
        Me.lblMatTypes.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMatTypes.Name = "lblMatTypes"
        Me.lblMatTypes.Size = New System.Drawing.Size(273, 38)
        Me.lblMatTypes.TabIndex = 31
        Me.lblMatTypes.Text = "Тип материала**"
        Me.lblMatTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPriceGroup
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbPriceGroup, 2)
        Me.cmbPriceGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPriceGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceGroup.Location = New System.Drawing.Point(5, 5)
        Me.cmbPriceGroup.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPriceGroup.MaxDropDownItems = 32
        Me.cmbPriceGroup.Name = "cmbPriceGroup"
        Me.cmbPriceGroup.Size = New System.Drawing.Size(556, 28)
        Me.cmbPriceGroup.TabIndex = 0
        '
        'cmbPriceName
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbPriceName, 2)
        Me.cmbPriceName.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbPriceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPriceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceName.FormattingEnabled = true
        Me.cmbPriceName.Location = New System.Drawing.Point(5, 43)
        Me.cmbPriceName.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPriceName.MaxDropDownItems = 15
        Me.cmbPriceName.Name = "cmbPriceName"
        Me.cmbPriceName.Size = New System.Drawing.Size(556, 28)
        Me.cmbPriceName.TabIndex = 1
        Me.cmbPriceName.Tag = "PriceName"
        '
        'cmsConfigTech
        '
        Me.cmsConfigTech.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigTech.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigTech.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗадатьТехнологическуюОперациюToolStripMenuItem})
        Me.cmsConfigTech.Name = "cmsCalcConfigTech"
        Me.cmsConfigTech.Size = New System.Drawing.Size(326, 28)
        '
        'ЗадатьТехнологическуюОперациюToolStripMenuItem
        '
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Name = "ЗадатьТехнологическуюОперациюToolStripMenuItem"
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Text = "Задать технологическую операцию"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(273, 38)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Параметр-2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Количество"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbParam2
        '
        Me.cmbParam2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbParam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbParam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbParam2.FormattingEnabled = true
        Me.cmbParam2.Location = New System.Drawing.Point(288, 81)
        Me.cmbParam2.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbParam2.MaxDropDownItems = 12
        Me.cmbParam2.Name = "cmbParam2"
        Me.cmbParam2.Size = New System.Drawing.Size(273, 28)
        Me.cmbParam2.TabIndex = 2
        Me.cmbParam2.Tag = "techParam2"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 228)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 381)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Операции"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgDataTable
        '
        Me.dgDataTable.AllowUserToAddRows = false
        Me.dgDataTable.AllowUserToDeleteRows = false
        Me.dgDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDataTable.ColumnHeadersVisible = false
        Me.dgDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDataTable.Location = New System.Drawing.Point(570, 4)
        Me.dgDataTable.Margin = New System.Windows.Forms.Padding(4)
        Me.dgDataTable.Name = "dgDataTable"
        Me.TableLayoutPanel1.SetRowSpan(Me.dgDataTable, 7)
        Me.dgDataTable.RowTemplate.Height = 24
        Me.dgDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDataTable.Size = New System.Drawing.Size(560, 601)
        Me.dgDataTable.TabIndex = 8
        '
        'btnDelRow
        '
        Me.btnDelRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.btnDelRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnDelRow.Location = New System.Drawing.Point(570, 613)
        Me.btnDelRow.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelRow.Name = "btnDelRow"
        Me.btnDelRow.Size = New System.Drawing.Size(560, 90)
        Me.btnDelRow.TabIndex = 9
        Me.btnDelRow.Text = "Удалить"
        Me.btnDelRow.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblMatTypes, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPriceGroup, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPriceName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMat, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMatTypes, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.clbOper, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.dgDataTable, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelRow, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbParam2, 1, 2)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1134, 707)
        Me.TableLayoutPanel1.TabIndex = 52
        '
        'cmbMat
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbMat, 2)
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(5, 195)
        Me.cmbMat.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(556, 28)
        Me.cmbMat.TabIndex = 5
        '
        'cmbMatTypes
        '
        Me.cmbMatTypes.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatTypes.FormattingEnabled = true
        Me.cmbMatTypes.Location = New System.Drawing.Point(288, 157)
        Me.cmbMatTypes.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMatTypes.Name = "cmbMatTypes"
        Me.cmbMatTypes.Size = New System.Drawing.Size(273, 28)
        Me.cmbMatTypes.TabIndex = 4
        '
        'cmsConfigMat
        '
        Me.cmsConfigMat.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigMat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigMat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КофигураторToolStripMenuItem})
        Me.cmsConfigMat.Name = "cmsCalcConfig"
        Me.cmsConfigMat.Size = New System.Drawing.Size(255, 26)
        '
        'КофигураторToolStripMenuItem
        '
        Me.КофигураторToolStripMenuItem.Name = "КофигураторToolStripMenuItem"
        Me.КофигураторToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.КофигураторToolStripMenuItem.Text = "Конфигуратор материала"
        '
        'clbOper
        '
        Me.clbOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbOper.CheckOnClick = true
        Me.clbOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbOper.FormattingEnabled = true
        Me.clbOper.Location = New System.Drawing.Point(288, 233)
        Me.clbOper.Margin = New System.Windows.Forms.Padding(5)
        Me.clbOper.Name = "clbOper"
        Me.clbOper.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.clbOper.Size = New System.Drawing.Size(273, 371)
        Me.clbOper.TabIndex = 6
        Me.clbOper.Tag = "operNac"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnAdd, 2)
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Enabled = false
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnAdd.Location = New System.Drawing.Point(4, 613)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(558, 90)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Добавить"
        Me.btnAdd.UseVisualStyleBackColor = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.nudQuantity2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.nudQuantity1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(286, 117)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(277, 32)
        Me.TableLayoutPanel2.TabIndex = 32
        '
        'nudQuantity2
        '
        Me.nudQuantity2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity2.DecimalPlaces = 2
        Me.nudQuantity2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity2.Location = New System.Drawing.Point(3, 3)
        Me.nudQuantity2.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudQuantity2.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudQuantity2.Name = "nudQuantity2"
        Me.nudQuantity2.Size = New System.Drawing.Size(120, 26)
        Me.nudQuantity2.TabIndex = 4
        Me.nudQuantity2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudQuantity2.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudQuantity2.Visible = false
        '
        'nudQuantity1
        '
        Me.nudQuantity1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudQuantity1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity1.Location = New System.Drawing.Point(129, 3)
        Me.nudQuantity1.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudQuantity1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity1.Name = "nudQuantity1"
        Me.nudQuantity1.Size = New System.Drawing.Size(145, 26)
        Me.nudQuantity1.TabIndex = 5
        Me.nudQuantity1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudQuantity1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 709)
        Me.SplitContainer1.SplitterDistance = 1136
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 58
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tstxtNac, Me.tsbtnCard, Me.tstxtItog, Me.tsbtnSetPrice, Me.tstxt, Me.ToolStripSeparator2, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(132, 707)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.TabStop = true
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(130, 18)
        Me.ToolStripLabel1.Text = "Скидка, %"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tstxtNac
        '
        Me.tstxtNac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtNac.MaxLength = 2
        Me.tstxtNac.Name = "tstxtNac"
        Me.tstxtNac.Size = New System.Drawing.Size(128, 24)
        Me.tstxtNac.Text = "0"
        Me.tstxtNac.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnCard
        '
        Me.tsbtnCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCard.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCard.Image = CType(resources.GetObject("tsbtnCard.Image"),System.Drawing.Image)
        Me.tsbtnCard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCard.Name = "tsbtnCard"
        Me.tsbtnCard.Size = New System.Drawing.Size(130, 37)
        Me.tsbtnCard.Text = "Ok"
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.Size = New System.Drawing.Size(128, 34)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnSetPrice
        '
        Me.tsbtnSetPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSetPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnSetPrice.Image = CType(resources.GetObject("tsbtnSetPrice.Image"),System.Drawing.Image)
        Me.tsbtnSetPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSetPrice.Name = "tsbtnSetPrice"
        Me.tsbtnSetPrice.Size = New System.Drawing.Size(130, 22)
        Me.tsbtnSetPrice.Text = "Установка цен"
        '
        'tstxt
        '
        Me.tstxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxt.Name = "tstxt"
        Me.tstxt.Size = New System.Drawing.Size(128, 24)
        Me.tstxt.Visible = false
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(130, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(130, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'c_FastOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 709)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "c_FastOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "77"
        Me.Text = "mdm_FastOrder"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmsConfigTech.ResumeLayout(false)
        CType(Me.dgDataTable,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.cmsConfigMat.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        CType(Me.nudQuantity2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudQuantity1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lblMatTypes As System.Windows.Forms.Label
    Friend WithEvents cmbPriceGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPriceName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbParam2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmsConfigTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgDataTable As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents cmsConfigMat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clbOper As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelRow As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtNac As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSetPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxt As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nudQuantity2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudQuantity1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents tsbtnCard As System.Windows.Forms.ToolStripButton
End Class
