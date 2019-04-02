<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_SaleMatAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_SaleMatAll))
        Me.tvMat = New System.Windows.Forms.TreeView()
        Me.nudKolvo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbProd = New System.Windows.Forms.ComboBox()
        Me.cmsProd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьПродуктToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдадитьПродуктToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.tsSettings = New System.Windows.Forms.ToolStrip()
        Me.tsbtnSelectAll = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnResetAll = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnApply = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnHide = New System.Windows.Forms.ToolStripButton()
        Me.tsMainMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tscmbSkidka = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.clbMatGroup = New System.Windows.Forms.CheckedListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsSaleMatMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSet = New System.Windows.Forms.ToolStripButton()
        CType(Me.nudKolvo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel2.SuspendLayout
        Me.cmsProd.SuspendLayout
        Me.tsSettings.SuspendLayout
        Me.tsMainMenu.SuspendLayout
        Me.tsSaleMatMain.SuspendLayout
        Me.SuspendLayout
        '
        'tvMat
        '
        Me.tvMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel2.SetColumnSpan(Me.tvMat, 3)
        Me.tvMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMat.Location = New System.Drawing.Point(5, 44)
        Me.tvMat.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tvMat.Name = "tvMat"
        Me.tvMat.Size = New System.Drawing.Size(682, 531)
        Me.tvMat.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.tvMat, "Для настройки групп материалов вызвать контекстное меню.")
        '
        'nudKolvo
        '
        Me.nudKolvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudKolvo.DecimalPlaces = 2
        Me.nudKolvo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudKolvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudKolvo.Location = New System.Drawing.Point(597, 6)
        Me.nudKolvo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudKolvo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudKolvo.Name = "nudKolvo"
        Me.nudKolvo.Size = New System.Drawing.Size(90, 26)
        Me.nudKolvo.TabIndex = 4
        Me.nudKolvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudKolvo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Продукт, количество"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 581)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 38)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Наименование"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMat
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmbMat, 2)
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.DropDownWidth = 800
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(172, 587)
        Me.cmbMat.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbMat.MaxDropDownItems = 30
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(515, 25)
        Me.cmbMat.TabIndex = 19
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AllowDrop = true
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.nudKolvo, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tvMat, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbProd, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbMat, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbUnit, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tsSettings, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tsMainMenu, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.clbMatGroup, 3, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1276, 653)
        Me.TableLayoutPanel2.TabIndex = 49
        '
        'cmbProd
        '
        Me.cmbProd.ContextMenuStrip = Me.cmsProd
        Me.cmbProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbProd.FormattingEnabled = true
        Me.cmbProd.Location = New System.Drawing.Point(171, 4)
        Me.cmbProd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProd.MaxDropDownItems = 24
        Me.cmbProd.Name = "cmbProd"
        Me.cmbProd.Size = New System.Drawing.Size(417, 25)
        Me.cmbProd.TabIndex = 50
        Me.cmbProd.Tag = "saleMatProd"
        '
        'cmsProd
        '
        Me.cmsProd.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsProd.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsProd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьПродуктToolStripMenuItem, Me.УдадитьПродуктToolStripMenuItem, Me.ЗадатьТехнологическуюОперациюToolStripMenuItem})
        Me.cmsProd.Name = "cmsProd"
        Me.cmsProd.Size = New System.Drawing.Size(326, 76)
        '
        'ДобавитьПродуктToolStripMenuItem
        '
        Me.ДобавитьПродуктToolStripMenuItem.Name = "ДобавитьПродуктToolStripMenuItem"
        Me.ДобавитьПродуктToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.ДобавитьПродуктToolStripMenuItem.Text = "Добавить продукт"
        '
        'УдадитьПродуктToolStripMenuItem
        '
        Me.УдадитьПродуктToolStripMenuItem.Name = "УдадитьПродуктToolStripMenuItem"
        Me.УдадитьПродуктToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.УдадитьПродуктToolStripMenuItem.Text = "Удалить продукт"
        '
        'ЗадатьТехнологическуюОперациюToolStripMenuItem
        '
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Name = "ЗадатьТехнологическуюОперациюToolStripMenuItem"
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Text = "Задать технологическую операцию"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 619)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 34)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Единицы"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbUnit
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmbUnit, 2)
        Me.cmbUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbUnit.FormattingEnabled = true
        Me.cmbUnit.Location = New System.Drawing.Point(171, 623)
        Me.cmbUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(517, 25)
        Me.cmbUnit.TabIndex = 20
        '
        'tsSettings
        '
        Me.tsSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsSettings.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsSettings.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnSelectAll, Me.tsbtnResetAll, Me.tsbtnApply, Me.tsbtnHide})
        Me.tsSettings.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsSettings.Location = New System.Drawing.Point(742, 0)
        Me.tsSettings.Name = "tsSettings"
        Me.tsSettings.Size = New System.Drawing.Size(496, 42)
        Me.tsSettings.TabIndex = 49
        Me.tsSettings.Text = "ToolStrip3"
        Me.tsSettings.Visible = false
        '
        'tsbtnSelectAll
        '
        Me.tsbtnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSelectAll.Image = CType(resources.GetObject("tsbtnSelectAll.Image"),System.Drawing.Image)
        Me.tsbtnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSelectAll.Name = "tsbtnSelectAll"
        Me.tsbtnSelectAll.Size = New System.Drawing.Size(107, 39)
        Me.tsbtnSelectAll.Text = "Выделить все"
        '
        'tsbtnResetAll
        '
        Me.tsbtnResetAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnResetAll.Image = CType(resources.GetObject("tsbtnResetAll.Image"),System.Drawing.Image)
        Me.tsbtnResetAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnResetAll.Name = "tsbtnResetAll"
        Me.tsbtnResetAll.Size = New System.Drawing.Size(104, 39)
        Me.tsbtnResetAll.Text = "Сбросить все"
        '
        'tsbtnApply
        '
        Me.tsbtnApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnApply.Image = CType(resources.GetObject("tsbtnApply.Image"),System.Drawing.Image)
        Me.tsbtnApply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnApply.Name = "tsbtnApply"
        Me.tsbtnApply.Size = New System.Drawing.Size(88, 39)
        Me.tsbtnApply.Text = "Применить"
        '
        'tsbtnHide
        '
        Me.tsbtnHide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnHide.Image = CType(resources.GetObject("tsbtnHide.Image"),System.Drawing.Image)
        Me.tsbtnHide.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnHide.Name = "tsbtnHide"
        Me.tsbtnHide.Size = New System.Drawing.Size(55, 39)
        Me.tsbtnHide.Text = "Выход"
        '
        'tsMainMenu
        '
        Me.tsMainMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsMainMenu.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsMainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tscmbSkidka, Me.tsbtnCost, Me.tstxtItog, Me.tsbtnOK, Me.ToolStripSeparator1, Me.tsbtnExit, Me.ToolStripLabel2})
        Me.tsMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsMainMenu.Location = New System.Drawing.Point(1157, 0)
        Me.tsMainMenu.Name = "tsMainMenu"
        Me.TableLayoutPanel2.SetRowSpan(Me.tsMainMenu, 4)
        Me.tsMainMenu.Size = New System.Drawing.Size(119, 653)
        Me.tsMainMenu.TabIndex = 13
        Me.tsMainMenu.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(117, 18)
        Me.ToolStripLabel1.Text = "Скидка, %"
        '
        'tscmbSkidka
        '
        Me.tscmbSkidka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbSkidka.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbSkidka.Name = "tscmbSkidka"
        Me.tscmbSkidka.Size = New System.Drawing.Size(115, 28)
        '
        'tsbtnCost
        '
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.Image = CType(resources.GetObject("tsbtnCost.Image"),System.Drawing.Image)
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(117, 31)
        Me.tsbtnCost.Text = "Считать"
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.Size = New System.Drawing.Size(115, 30)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(117, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(117, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(117, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(117, 18)
        Me.ToolStripLabel2.Text = "16"
        '
        'clbMatGroup
        '
        Me.clbMatGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbMatGroup.CheckOnClick = true
        Me.clbMatGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbMatGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbMatGroup.FormattingEnabled = true
        Me.clbMatGroup.Location = New System.Drawing.Point(697, 44)
        Me.clbMatGroup.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.clbMatGroup.Name = "clbMatGroup"
        Me.TableLayoutPanel2.SetRowSpan(Me.clbMatGroup, 3)
        Me.clbMatGroup.ScrollAlwaysVisible = true
        Me.clbMatGroup.Size = New System.Drawing.Size(455, 603)
        Me.clbMatGroup.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.clbMatGroup, "Контекстное меню открывается правой кнопкой мыши")
        Me.clbMatGroup.Visible = false
        '
        'tsSaleMatMain
        '
        Me.tsSaleMatMain.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsSaleMatMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsSaleMatMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.tsbtnSet})
        Me.tsSaleMatMain.Location = New System.Drawing.Point(0, 0)
        Me.tsSaleMatMain.Name = "tsSaleMatMain"
        Me.tsSaleMatMain.Size = New System.Drawing.Size(1276, 25)
        Me.tsSaleMatMain.TabIndex = 50
        Me.tsSaleMatMain.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripButton1.Text = "Сортировать по алфавиту"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripButton2.Text = "Сортировать по цене"
        '
        'tsbtnSet
        '
        Me.tsbtnSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSet.Image = CType(resources.GetObject("tsbtnSet.Image"),System.Drawing.Image)
        Me.tsbtnSet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSet.Name = "tsbtnSet"
        Me.tsbtnSet.Size = New System.Drawing.Size(85, 22)
        Me.tsbtnSet.Text = "Настроить"
        '
        'c_SaleMatAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1276, 678)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.tsSaleMatMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "c_SaleMatAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "16"
        Me.Text = "c_MatSale"
        CType(Me.nudKolvo,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.cmsProd.ResumeLayout(false)
        Me.tsSettings.ResumeLayout(false)
        Me.tsSettings.PerformLayout
        Me.tsMainMenu.ResumeLayout(false)
        Me.tsMainMenu.PerformLayout
        Me.tsSaleMatMain.ResumeLayout(false)
        Me.tsSaleMatMain.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tvMat As System.Windows.Forms.TreeView
    Friend WithEvents nudKolvo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents clbMatGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tsSaleMatMain As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSettings As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSelectAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnResetAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnApply As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnHide As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbProd As System.Windows.Forms.ComboBox
    Friend WithEvents cmsProd As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьПродуктToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдадитьПродуктToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbtnSet As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMainMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tscmbSkidka As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
End Class
