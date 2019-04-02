<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_UniCostGM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_UniCostGM))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtCostUnit = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.clbOper = New System.Windows.Forms.CheckedListBox()
        Me.cmsConfigTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMatTypes = New System.Windows.Forms.Label()
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbPriceGroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPriceName = New System.Windows.Forms.ComboBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbParam2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.cmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.cmsConfigMat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmbTirag = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1.SuspendLayout
        Me.cmsConfigTech.SuspendLayout
        Me.tlpMain.SuspendLayout
        Me.cmsConfigMat.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnCost, Me.tstxtItog, Me.ToolStripLabel3, Me.tstxtCostUnit, Me.ToolStripButton2, Me.tsbtnOK, Me.ToolStripButton1, Me.tsbtnClear, Me.ToolStripSeparator1, Me.tsbtnExit, Me.ToolStripLabel4})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(128, 529)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnCost
        '
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.Image = CType(resources.GetObject("tsbtnCost.Image"),System.Drawing.Image)
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(126, 31)
        Me.tsbtnCost.Text = "Считать"
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.Size = New System.Drawing.Size(124, 34)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(126, 18)
        Me.ToolStripLabel3.Text = "Стоимость за ед."
        '
        'tstxtCostUnit
        '
        Me.tstxtCostUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostUnit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtCostUnit.Name = "tstxtCostUnit"
        Me.tstxtCostUnit.Size = New System.Drawing.Size(124, 23)
        Me.tstxtCostUnit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripButton2.Text = "Установка цен"
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(126, 31)
        Me.tsbtnOK.Text = "ОК"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(126, 31)
        Me.ToolStripButton1.Text = "Ещё"
        '
        'tsbtnClear
        '
        Me.tsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnClear.Image = CType(resources.GetObject("tsbtnClear.Image"),System.Drawing.Image)
        Me.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnClear.Name = "tsbtnClear"
        Me.tsbtnClear.Size = New System.Drawing.Size(126, 22)
        Me.tsbtnClear.Text = "Очистить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(126, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(126, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(126, 18)
        Me.ToolStripLabel4.Text = "53"
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 345)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "ППО"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'clbOper
        '
        Me.clbOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbOper.CheckOnClick = true
        Me.clbOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbOper.FormattingEnabled = true
        Me.clbOper.Location = New System.Drawing.Point(215, 187)
        Me.clbOper.Name = "clbOper"
        Me.clbOper.Size = New System.Drawing.Size(484, 339)
        Me.clbOper.TabIndex = 0
        Me.clbOper.Tag = "ppo"
        '
        'cmsConfigTech
        '
        Me.cmsConfigTech.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigTech.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigTech.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗадатьТехнологическуюОперациюToolStripMenuItem})
        Me.cmsConfigTech.Name = "cmsCalcConfigTech"
        Me.cmsConfigTech.Size = New System.Drawing.Size(326, 28)
        '
        'ЗадатьТехнологическуюОперациюToolStripMenuItem
        '
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Name = "ЗадатьТехнологическуюОперациюToolStripMenuItem"
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Text = "Задать технологическую операцию"
        '
        'lblMatTypes
        '
        Me.lblMatTypes.AutoSize = true
        Me.lblMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblMatTypes.Location = New System.Drawing.Point(3, 122)
        Me.lblMatTypes.Name = "lblMatTypes"
        Me.lblMatTypes.Size = New System.Drawing.Size(206, 31)
        Me.lblMatTypes.TabIndex = 31
        Me.lblMatTypes.Tag = "mat"
        Me.lblMatTypes.Text = "Тип материала**"
        Me.lblMatTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'КофигураторToolStripMenuItem
        '
        Me.КофигураторToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.КофигураторToolStripMenuItem.Name = "КофигураторToolStripMenuItem"
        Me.КофигураторToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.КофигураторToolStripMenuItem.Text = "Конфигуратор материала"
        '
        'cmbPriceGroup
        '
        Me.cmbPriceGroup.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbPriceGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPriceGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceGroup.Location = New System.Drawing.Point(215, 3)
        Me.cmbPriceGroup.MaxDropDownItems = 20
        Me.cmbPriceGroup.Name = "cmbPriceGroup"
        Me.cmbPriceGroup.Size = New System.Drawing.Size(484, 25)
        Me.cmbPriceGroup.TabIndex = 0
        Me.cmbPriceGroup.Tag = "ppo"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Группа"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPriceName
        '
        Me.cmbPriceName.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbPriceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPriceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceName.FormattingEnabled = true
        Me.cmbPriceName.Location = New System.Drawing.Point(215, 34)
        Me.cmbPriceName.MaxDropDownItems = 15
        Me.cmbPriceName.Name = "cmbPriceName"
        Me.cmbPriceName.Size = New System.Drawing.Size(484, 25)
        Me.cmbPriceName.TabIndex = 0
        Me.cmbPriceName.Tag = "techPriceName"
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = true
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpMain.Controls.Add(Me.lblMatTypes, 0, 4)
        Me.tlpMain.Controls.Add(Me.cmbPriceGroup, 1, 0)
        Me.tlpMain.Controls.Add(Me.Label2, 0, 0)
        Me.tlpMain.Controls.Add(Me.cmbPriceName, 1, 1)
        Me.tlpMain.Controls.Add(Me.Label4, 0, 2)
        Me.tlpMain.Controls.Add(Me.Label1, 0, 3)
        Me.tlpMain.Controls.Add(Me.cmbParam2, 1, 2)
        Me.tlpMain.Controls.Add(Me.Label3, 0, 1)
        Me.tlpMain.Controls.Add(Me.cmbMat, 0, 5)
        Me.tlpMain.Controls.Add(Me.cmbMatTypes, 1, 4)
        Me.tlpMain.Controls.Add(Me.clbOper, 1, 6)
        Me.tlpMain.Controls.Add(Me.Label7, 0, 6)
        Me.tlpMain.Controls.Add(Me.cmbTirag, 1, 3)
        Me.tlpMain.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 7
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16!))
        Me.tlpMain.Size = New System.Drawing.Size(702, 529)
        Me.tlpMain.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Параметр-2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Количество"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbParam2
        '
        Me.cmbParam2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbParam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParam2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbParam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbParam2.FormattingEnabled = true
        Me.cmbParam2.Location = New System.Drawing.Point(215, 65)
        Me.cmbParam2.MaxDropDownItems = 12
        Me.cmbParam2.Name = "cmbParam2"
        Me.cmbParam2.Size = New System.Drawing.Size(484, 25)
        Me.cmbParam2.TabIndex = 0
        Me.cmbParam2.Tag = "techParam2"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Наименование"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMat
        '
        Me.tlpMain.SetColumnSpan(Me.cmbMat, 2)
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(3, 156)
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(696, 25)
        Me.cmbMat.TabIndex = 11
        '
        'cmbMatTypes
        '
        Me.cmbMatTypes.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatTypes.FormattingEnabled = true
        Me.cmbMatTypes.Location = New System.Drawing.Point(215, 125)
        Me.cmbMatTypes.Name = "cmbMatTypes"
        Me.cmbMatTypes.Size = New System.Drawing.Size(484, 25)
        Me.cmbMatTypes.TabIndex = 12
        Me.cmbMatTypes.Tag = "mat"
        '
        'cmsConfigMat
        '
        Me.cmsConfigMat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigMat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigMat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КофигураторToolStripMenuItem})
        Me.cmsConfigMat.Name = "cmsCalcConfig"
        Me.cmsConfigMat.Size = New System.Drawing.Size(255, 26)
        '
        'cmbTirag
        '
        Me.cmbTirag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTirag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTirag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTirag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTirag.FormattingEnabled = true
        Me.cmbTirag.Location = New System.Drawing.Point(214, 95)
        Me.cmbTirag.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTirag.MaxDropDownItems = 24
        Me.cmbTirag.Name = "cmbTirag"
        Me.cmbTirag.Size = New System.Drawing.Size(486, 25)
        Me.cmbTirag.TabIndex = 32
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpMain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(838, 531)
        Me.SplitContainer1.SplitterDistance = 704
        Me.SplitContainer1.TabIndex = 57
        '
        'c_UniCostGM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 531)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "c_UniCostGM"
        Me.Tag = "53"
        Me.Text = "er_UniCost"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.cmsConfigTech.ResumeLayout(false)
        Me.tlpMain.ResumeLayout(false)
        Me.tlpMain.PerformLayout
        Me.cmsConfigMat.ResumeLayout(false)
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtCostUnit As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents clbOper As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblMatTypes As System.Windows.Forms.Label
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbPriceGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPriceName As System.Windows.Forms.ComboBox
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbParam2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents cmsConfigMat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmbTirag As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsConfigTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
End Class
