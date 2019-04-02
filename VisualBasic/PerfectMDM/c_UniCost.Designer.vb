<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_UniCost
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_UniCost))
        Me.cmsConfigMat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsConfigTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.dgColor = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.range = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddColor = New System.Windows.Forms.Button()
        Me.lblMatTypes = New System.Windows.Forms.Label()
        Me.cmbMatColor = New System.Windows.Forms.ComboBox()
        Me.cmbPriceGroup = New System.Windows.Forms.ComboBox()
        Me.tmbMatColor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.cmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.clbNacenki = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbParam2 = New System.Windows.Forms.ComboBox()
        Me.cmbPriceName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSrok = New System.Windows.Forms.ComboBox()
        Me.clbOper = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tscmbSkidka = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtCostUnit = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmsConfigMat.SuspendLayout
        Me.cmsConfigTech.SuspendLayout
        Me.tlpMain.SuspendLayout
        CType(Me.dgColor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'cmsConfigMat
        '
        Me.cmsConfigMat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigMat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigMat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КофигураторToolStripMenuItem})
        Me.cmsConfigMat.Name = "cmsCalcConfig"
        Me.cmsConfigMat.Size = New System.Drawing.Size(227, 26)
        '
        'КофигураторToolStripMenuItem
        '
        Me.КофигураторToolStripMenuItem.Name = "КофигураторToolStripMenuItem"
        Me.КофигураторToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.КофигураторToolStripMenuItem.Text = "Конфигуратор материала"
        '
        'cmsConfigTech
        '
        Me.cmsConfigTech.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigTech.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigTech.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗадатьТехнологическуюОперациюToolStripMenuItem})
        Me.cmsConfigTech.Name = "cmsCalcConfigTech"
        Me.cmsConfigTech.Size = New System.Drawing.Size(304, 28)
        '
        'ЗадатьТехнологическуюОперациюToolStripMenuItem
        '
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Name = "ЗадатьТехнологическуюОперациюToolStripMenuItem"
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Text = "Задать технологическую операцию"
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = true
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 3
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.tlpMain.Controls.Add(Me.dgColor, 0, 8)
        Me.tlpMain.Controls.Add(Me.btnAddColor, 2, 7)
        Me.tlpMain.Controls.Add(Me.lblMatTypes, 0, 4)
        Me.tlpMain.Controls.Add(Me.cmbMatColor, 1, 7)
        Me.tlpMain.Controls.Add(Me.cmbPriceGroup, 1, 0)
        Me.tlpMain.Controls.Add(Me.tmbMatColor, 0, 7)
        Me.tlpMain.Controls.Add(Me.Label2, 0, 0)
        Me.tlpMain.Controls.Add(Me.Label1, 0, 3)
        Me.tlpMain.Controls.Add(Me.cmbMat, 0, 5)
        Me.tlpMain.Controls.Add(Me.cmbMatTypes, 1, 4)
        Me.tlpMain.Controls.Add(Me.clbNacenki, 1, 9)
        Me.tlpMain.Controls.Add(Me.Label8, 0, 11)
        Me.tlpMain.Controls.Add(Me.nudQuantity, 2, 3)
        Me.tlpMain.Controls.Add(Me.Label7, 0, 9)
        Me.tlpMain.Controls.Add(Me.cmbParam2, 1, 2)
        Me.tlpMain.Controls.Add(Me.cmbPriceName, 1, 1)
        Me.tlpMain.Controls.Add(Me.Label4, 0, 2)
        Me.tlpMain.Controls.Add(Me.Label3, 0, 1)
        Me.tlpMain.Controls.Add(Me.cmbSrok, 1, 11)
        Me.tlpMain.Controls.Add(Me.clbOper, 1, 10)
        Me.tlpMain.Controls.Add(Me.Label5, 0, 10)
        Me.tlpMain.Controls.Add(Me.Label6, 0, 6)
        Me.tlpMain.Controls.Add(Me.cmbUnit, 2, 5)
        Me.tlpMain.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(5, 5)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(5)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 12
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(1008, 700)
        Me.tlpMain.TabIndex = 53
        '
        'dgColor
        '
        Me.dgColor.AllowDrop = true
        Me.dgColor.AllowUserToAddRows = false
        Me.dgColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgColor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.cost, Me.range, Me.NameMat})
        Me.tlpMain.SetColumnSpan(Me.dgColor, 3)
        Me.dgColor.Location = New System.Drawing.Point(5, 281)
        Me.dgColor.Margin = New System.Windows.Forms.Padding(5)
        Me.dgColor.MultiSelect = false
        Me.dgColor.Name = "dgColor"
        Me.dgColor.ReadOnly = true
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dgColor.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgColor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgColor.Size = New System.Drawing.Size(998, 107)
        Me.dgColor.TabIndex = 7
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = true
        Me.ID.Visible = false
        '
        'cost
        '
        Me.cost.HeaderText = "цена"
        Me.cost.Name = "cost"
        Me.cost.ReadOnly = true
        Me.cost.Visible = false
        '
        'range
        '
        Me.range.FillWeight = 30.45685!
        Me.range.HeaderText = "Номер"
        Me.range.Name = "range"
        Me.range.ReadOnly = true
        '
        'NameMat
        '
        Me.NameMat.FillWeight = 169.5432!
        Me.NameMat.HeaderText = "Наименование"
        Me.NameMat.Name = "NameMat"
        Me.NameMat.ReadOnly = true
        '
        'btnAddColor
        '
        Me.btnAddColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnAddColor.Location = New System.Drawing.Point(710, 239)
        Me.btnAddColor.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddColor.Name = "btnAddColor"
        Me.btnAddColor.Size = New System.Drawing.Size(293, 32)
        Me.btnAddColor.TabIndex = 8
        Me.btnAddColor.Text = "Добавить"
        Me.btnAddColor.UseVisualStyleBackColor = true
        '
        'lblMatTypes
        '
        Me.lblMatTypes.AutoSize = true
        Me.lblMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblMatTypes.Location = New System.Drawing.Point(5, 139)
        Me.lblMatTypes.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMatTypes.Name = "lblMatTypes"
        Me.lblMatTypes.Size = New System.Drawing.Size(242, 35)
        Me.lblMatTypes.TabIndex = 31
        Me.lblMatTypes.Text = "Тип материала**"
        Me.lblMatTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMatColor
        '
        Me.cmbMatColor.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbMatColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatColor.DropDownWidth = 400
        Me.cmbMatColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMatColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatColor.FormattingEnabled = true
        Me.cmbMatColor.Location = New System.Drawing.Point(257, 239)
        Me.cmbMatColor.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMatColor.Name = "cmbMatColor"
        Me.cmbMatColor.Size = New System.Drawing.Size(443, 25)
        Me.cmbMatColor.TabIndex = 5
        '
        'cmbPriceGroup
        '
        Me.tlpMain.SetColumnSpan(Me.cmbPriceGroup, 2)
        Me.cmbPriceGroup.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbPriceGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPriceGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceGroup.Location = New System.Drawing.Point(257, 5)
        Me.cmbPriceGroup.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPriceGroup.MaxDropDownItems = 20
        Me.cmbPriceGroup.Name = "cmbPriceGroup"
        Me.cmbPriceGroup.Size = New System.Drawing.Size(746, 25)
        Me.cmbPriceGroup.TabIndex = 0
        Me.cmbPriceGroup.Tag = "oper"
        '
        'tmbMatColor
        '
        Me.tmbMatColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tmbMatColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tmbMatColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbMatColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tmbMatColor.FormattingEnabled = true
        Me.tmbMatColor.Items.AddRange(New Object() {"Стандартные цвета*", "Пантон*"})
        Me.tmbMatColor.Location = New System.Drawing.Point(5, 239)
        Me.tmbMatColor.Margin = New System.Windows.Forms.Padding(5)
        Me.tmbMatColor.Name = "tmbMatColor"
        Me.tmbMatColor.Size = New System.Drawing.Size(242, 25)
        Me.tmbMatColor.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Продукт"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Количество"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMat
        '
        Me.tlpMain.SetColumnSpan(Me.cmbMat, 2)
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(5, 179)
        Me.cmbMat.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(695, 25)
        Me.cmbMat.TabIndex = 11
        '
        'cmbMatTypes
        '
        Me.tlpMain.SetColumnSpan(Me.cmbMatTypes, 2)
        Me.cmbMatTypes.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatTypes.FormattingEnabled = true
        Me.cmbMatTypes.Location = New System.Drawing.Point(257, 144)
        Me.cmbMatTypes.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMatTypes.Name = "cmbMatTypes"
        Me.cmbMatTypes.Size = New System.Drawing.Size(746, 25)
        Me.cmbMatTypes.TabIndex = 12
        '
        'clbNacenki
        '
        Me.clbNacenki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbNacenki.CheckOnClick = true
        Me.tlpMain.SetColumnSpan(Me.clbNacenki, 2)
        Me.clbNacenki.ContextMenuStrip = Me.cmsConfigTech
        Me.clbNacenki.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbNacenki.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbNacenki.FormattingEnabled = true
        Me.clbNacenki.Location = New System.Drawing.Point(257, 398)
        Me.clbNacenki.Margin = New System.Windows.Forms.Padding(5)
        Me.clbNacenki.Name = "clbNacenki"
        Me.clbNacenki.Size = New System.Drawing.Size(746, 107)
        Me.clbNacenki.TabIndex = 0
        Me.clbNacenki.Tag = "techNacOper"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 666)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 34)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Срочность"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudQuantity.Location = New System.Drawing.Point(710, 110)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(5)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(293, 24)
        Me.nudQuantity.TabIndex = 30
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudQuantity.ThousandsSeparator = true
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 393)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 117)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Дополнительно"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbParam2
        '
        Me.tlpMain.SetColumnSpan(Me.cmbParam2, 2)
        Me.cmbParam2.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbParam2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbParam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbParam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbParam2.FormattingEnabled = true
        Me.cmbParam2.Location = New System.Drawing.Point(257, 75)
        Me.cmbParam2.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbParam2.MaxDropDownItems = 12
        Me.cmbParam2.Name = "cmbParam2"
        Me.cmbParam2.Size = New System.Drawing.Size(746, 25)
        Me.cmbParam2.TabIndex = 0
        Me.cmbParam2.Tag = "techParam2"
        '
        'cmbPriceName
        '
        Me.tlpMain.SetColumnSpan(Me.cmbPriceName, 2)
        Me.cmbPriceName.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbPriceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPriceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceName.FormattingEnabled = true
        Me.cmbPriceName.Location = New System.Drawing.Point(257, 40)
        Me.cmbPriceName.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPriceName.MaxDropDownItems = 15
        Me.cmbPriceName.Name = "cmbPriceName"
        Me.cmbPriceName.Size = New System.Drawing.Size(746, 25)
        Me.cmbPriceName.TabIndex = 0
        Me.cmbPriceName.Tag = "PriceName"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 35)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Параметр-2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Технология"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSrok
        '
        Me.tlpMain.SetColumnSpan(Me.cmbSrok, 2)
        Me.cmbSrok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSrok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSrok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSrok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSrok.FormattingEnabled = true
        Me.cmbSrok.Location = New System.Drawing.Point(256, 670)
        Me.cmbSrok.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSrok.Name = "cmbSrok"
        Me.cmbSrok.Size = New System.Drawing.Size(748, 25)
        Me.cmbSrok.TabIndex = 32
        '
        'clbOper
        '
        Me.tlpMain.SetColumnSpan(Me.clbOper, 2)
        Me.clbOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbOper.FormattingEnabled = true
        Me.clbOper.Location = New System.Drawing.Point(256, 514)
        Me.clbOper.Margin = New System.Windows.Forms.Padding(4)
        Me.clbOper.Name = "clbOper"
        Me.clbOper.Size = New System.Drawing.Size(748, 148)
        Me.clbOper.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 510)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 156)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Операции"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.tlpMain.SetColumnSpan(Me.Label6, 3)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 209)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1000, 25)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Нанесение изображения"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbUnit
        '
        Me.cmbUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbUnit.FormattingEnabled = true
        Me.cmbUnit.Location = New System.Drawing.Point(708, 177)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(297, 25)
        Me.cmbUnit.TabIndex = 36
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tscmbSkidka, Me.tsbtnCost, Me.tstxtItog, Me.ToolStripLabel3, Me.tstxtCostUnit, Me.tsbtnOK, Me.tsbtnClear, Me.ToolStripSeparator1, Me.tsbtnExit, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(1018, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(160, 710)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(158, 18)
        Me.ToolStripLabel2.Text = "Скидка, %"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tscmbSkidka
        '
        Me.tscmbSkidka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbSkidka.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbSkidka.Items.AddRange(New Object() {"0", "10"})
        Me.tscmbSkidka.Name = "tscmbSkidka"
        Me.tscmbSkidka.Size = New System.Drawing.Size(156, 27)
        '
        'tsbtnCost
        '
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.Image = CType(resources.GetObject("tsbtnCost.Image"),System.Drawing.Image)
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(158, 30)
        Me.tsbtnCost.Text = "Считать"
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.ReadOnly = true
        Me.tstxtItog.Size = New System.Drawing.Size(156, 32)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(158, 18)
        Me.ToolStripLabel3.Text = "Стоимость за ед."
        '
        'tstxtCostUnit
        '
        Me.tstxtCostUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostUnit.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtCostUnit.Name = "tstxtCostUnit"
        Me.tstxtCostUnit.ReadOnly = true
        Me.tstxtCostUnit.Size = New System.Drawing.Size(156, 25)
        Me.tstxtCostUnit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(158, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'tsbtnClear
        '
        Me.tsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnClear.Image = CType(resources.GetObject("tsbtnClear.Image"),System.Drawing.Image)
        Me.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnClear.Name = "tsbtnClear"
        Me.tsbtnClear.Size = New System.Drawing.Size(158, 22)
        Me.tsbtnClear.Text = "Очистить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(158, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripButton1.Text = "39"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpMain, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1178, 710)
        Me.TableLayoutPanel1.TabIndex = 54
        '
        'c_UniCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1178, 710)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimizeBox = false
        Me.Name = "c_UniCost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "39"
        Me.Text = "awc_UniCost"
        Me.cmsConfigMat.ResumeLayout(false)
        Me.cmsConfigTech.ResumeLayout(false)
        Me.tlpMain.ResumeLayout(false)
        Me.tlpMain.PerformLayout
        CType(Me.dgColor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmsConfigMat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsConfigTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tscmbSkidka As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtCostUnit As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblMatTypes As System.Windows.Forms.Label
    Friend WithEvents btnAddColor As System.Windows.Forms.Button
    Friend WithEvents dgColor As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents range As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbMatColor As System.Windows.Forms.ComboBox
    Friend WithEvents tmbMatColor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPriceGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents clbNacenki As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbParam2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPriceName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSrok As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents clbOper As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
