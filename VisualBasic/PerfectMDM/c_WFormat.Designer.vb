<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_WFormat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_WFormat))
        Me.lblMatTypes = New System.Windows.Forms.Label()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.txtPrim = New System.Windows.Forms.TextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbPriceGroup = New System.Windows.Forms.ComboBox()
        Me.cmsCalcConfigTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPriceName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tstxtCostUnit = New System.Windows.Forms.ToolStripTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbParam2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.cmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.cmsCalcConfig = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clbNacenki = New System.Windows.Forms.CheckedListBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tscmbSkidka = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnClear = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrim2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbProd = New System.Windows.Forms.ComboBox()
        Me.cmsProd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьПродуктToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдадитьПродуктToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudY = New System.Windows.Forms.NumericUpDown()
        Me.cmbPrintFormat = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmsCalcConfigTech.SuspendLayout
        Me.cmsCalcConfig.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsProd.SuspendLayout
        CType(Me.nudY,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'lblMatTypes
        '
        Me.lblMatTypes.AutoSize = true
        Me.lblMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblMatTypes.Location = New System.Drawing.Point(5, 182)
        Me.lblMatTypes.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMatTypes.Name = "lblMatTypes"
        Me.TableLayoutPanel1.SetRowSpan(Me.lblMatTypes, 2)
        Me.lblMatTypes.Size = New System.Drawing.Size(305, 74)
        Me.lblMatTypes.TabIndex = 31
        Me.lblMatTypes.Text = "Тип материала**"
        Me.lblMatTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.Size = New System.Drawing.Size(252, 32)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrim
        '
        Me.txtPrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPrim, 4)
        Me.txtPrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPrim.Location = New System.Drawing.Point(320, 612)
        Me.txtPrim.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPrim.Multiline = true
        Me.txtPrim.Name = "txtPrim"
        Me.txtPrim.Size = New System.Drawing.Size(643, 83)
        Me.txtPrim.TabIndex = 0
        Me.txtPrim.Visible = false
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(254, 18)
        Me.ToolStripLabel3.Text = "Стоимость за ед."
        '
        'cmbPriceGroup
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbPriceGroup, 4)
        Me.cmbPriceGroup.ContextMenuStrip = Me.cmsCalcConfigTech
        Me.cmbPriceGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPriceGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceGroup.Location = New System.Drawing.Point(320, 39)
        Me.cmbPriceGroup.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbPriceGroup.MaxDropDownItems = 20
        Me.cmbPriceGroup.Name = "cmbPriceGroup"
        Me.cmbPriceGroup.Size = New System.Drawing.Size(643, 25)
        Me.cmbPriceGroup.TabIndex = 0
        Me.cmbPriceGroup.Tag = "mdmWFgroup"
        '
        'cmsCalcConfigTech
        '
        Me.cmsCalcConfigTech.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsCalcConfigTech.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCalcConfigTech.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗадатьТехнологическуюОперациюToolStripMenuItem})
        Me.cmsCalcConfigTech.Name = "cmsCalcConfigTech"
        Me.cmsCalcConfigTech.Size = New System.Drawing.Size(304, 28)
        '
        'ЗадатьТехнологическуюОперациюToolStripMenuItem
        '
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Name = "ЗадатьТехнологическуюОперациюToolStripMenuItem"
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Text = "Задать технологическую операцию"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Группа"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPriceName
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbPriceName, 4)
        Me.cmbPriceName.ContextMenuStrip = Me.cmsCalcConfigTech
        Me.cmbPriceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPriceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceName.FormattingEnabled = true
        Me.cmbPriceName.Location = New System.Drawing.Point(320, 76)
        Me.cmbPriceName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbPriceName.MaxDropDownItems = 15
        Me.cmbPriceName.Name = "cmbPriceName"
        Me.cmbPriceName.Size = New System.Drawing.Size(643, 25)
        Me.cmbPriceName.TabIndex = 0
        Me.cmbPriceName.Tag = "mdmWFprName"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 37)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Параметр-2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tstxtCostUnit
        '
        Me.tstxtCostUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostUnit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtCostUnit.Name = "tstxtCostUnit"
        Me.tstxtCostUnit.Size = New System.Drawing.Size(252, 23)
        Me.tstxtCostUnit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Количество"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbParam2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbParam2, 4)
        Me.cmbParam2.ContextMenuStrip = Me.cmsCalcConfigTech
        Me.cmbParam2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbParam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParam2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbParam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbParam2.FormattingEnabled = true
        Me.cmbParam2.Location = New System.Drawing.Point(320, 113)
        Me.cmbParam2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbParam2.MaxDropDownItems = 12
        Me.cmbParam2.Name = "cmbParam2"
        Me.cmbParam2.Size = New System.Drawing.Size(643, 25)
        Me.cmbParam2.TabIndex = 0
        Me.cmbParam2.Tag = "mdmWFparam2"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 37)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Наименование"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMat
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbMat, 3)
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(320, 225)
        Me.cmbMat.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(479, 25)
        Me.cmbMat.TabIndex = 11
        '
        'cmbMatTypes
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbMatTypes, 4)
        Me.cmbMatTypes.ContextMenuStrip = Me.cmsCalcConfig
        Me.cmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatTypes.FormattingEnabled = true
        Me.cmbMatTypes.Location = New System.Drawing.Point(320, 188)
        Me.cmbMatTypes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbMatTypes.Name = "cmbMatTypes"
        Me.cmbMatTypes.Size = New System.Drawing.Size(643, 25)
        Me.cmbMatTypes.TabIndex = 12
        '
        'cmsCalcConfig
        '
        Me.cmsCalcConfig.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsCalcConfig.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCalcConfig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КофигураторToolStripMenuItem})
        Me.cmsCalcConfig.Name = "cmsCalcConfig"
        Me.cmsCalcConfig.Size = New System.Drawing.Size(153, 26)
        '
        'КофигураторToolStripMenuItem
        '
        Me.КофигураторToolStripMenuItem.Name = "КофигураторToolStripMenuItem"
        Me.КофигураторToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.КофигураторToolStripMenuItem.Text = "Кофигуратор"
        '
        'clbNacenki
        '
        Me.clbNacenki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbNacenki.CheckOnClick = true
        Me.TableLayoutPanel1.SetColumnSpan(Me.clbNacenki, 4)
        Me.clbNacenki.ContextMenuStrip = Me.cmsCalcConfigTech
        Me.clbNacenki.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbNacenki.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbNacenki.FormattingEnabled = true
        Me.clbNacenki.Location = New System.Drawing.Point(320, 262)
        Me.clbNacenki.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.clbNacenki.Name = "clbNacenki"
        Me.clbNacenki.Size = New System.Drawing.Size(643, 302)
        Me.clbNacenki.TabIndex = 0
        Me.clbNacenki.Tag = "mdmWFdopOp"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(254, 18)
        Me.ToolStripLabel2.Text = "Скидка, %"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 606)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(305, 95)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Примечание"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = false
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tscmbSkidka, Me.tsbtnCost, Me.tstxtItog, Me.ToolStripLabel3, Me.tstxtCostUnit, Me.ToolStripButton1, Me.ToolStripButton2, Me.tsbtnOK, Me.ToolStripSeparator1, Me.tsbtnClear, Me.tsbtnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(256, 701)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tscmbSkidka
        '
        Me.tscmbSkidka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbSkidka.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbSkidka.Name = "tscmbSkidka"
        Me.tscmbSkidka.Size = New System.Drawing.Size(252, 28)
        '
        'tsbtnCost
        '
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.Image = CType(resources.GetObject("tsbtnCost.Image"),System.Drawing.Image)
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(254, 30)
        Me.tsbtnCost.Text = "Считать"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(254, 22)
        Me.ToolStripButton1.Text = "Еще расчет"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(254, 22)
        Me.ToolStripButton2.Text = "Установка цен"
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(254, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(254, 6)
        '
        'tsbtnClear
        '
        Me.tsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnClear.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnClear.Image = CType(resources.GetObject("tsbtnClear.Image"),System.Drawing.Image)
        Me.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnClear.Name = "tsbtnClear"
        Me.tsbtnClear.Size = New System.Drawing.Size(254, 22)
        Me.tsbtnClear.Text = "Очистить"
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(254, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(254, 16)
        Me.ToolStripLabel1.Text = "58"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMatTypes, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrim, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPriceGroup, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudQuantity, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPriceName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbParam2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMat, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMatTypes, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.clbNacenki, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrim2, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbProd, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nudY, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPrintFormat, 4, 6)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(968, 701)
        Me.TableLayoutPanel1.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(645, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 38)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Количество"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudQuantity
        '
        Me.nudQuantity.AutoSize = true
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(809, 150)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(154, 26)
        Me.nudQuantity.TabIndex = 30
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 256)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(305, 314)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Наценки"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrim2
        '
        Me.txtPrim2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPrim2, 4)
        Me.txtPrim2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrim2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPrim2.Location = New System.Drawing.Point(320, 576)
        Me.txtPrim2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPrim2.Name = "txtPrim2"
        Me.txtPrim2.Size = New System.Drawing.Size(643, 24)
        Me.txtPrim2.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(5, 570)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(305, 36)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Обрезной формат"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbProd
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbProd, 4)
        Me.cmbProd.ContextMenuStrip = Me.cmsProd
        Me.cmbProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbProd.FormattingEnabled = true
        Me.cmbProd.Location = New System.Drawing.Point(319, 4)
        Me.cmbProd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProd.Name = "cmbProd"
        Me.cmbProd.Size = New System.Drawing.Size(645, 25)
        Me.cmbProd.TabIndex = 35
        Me.cmbProd.Tag = "wFormatProd"
        '
        'cmsProd
        '
        Me.cmsProd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsProd.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsProd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьПродуктToolStripMenuItem, Me.УдадитьПродуктToolStripMenuItem, Me.ЗадатьТехнологическуюОперациюToolStripMenuItem1})
        Me.cmsProd.Name = "cmsProd"
        Me.cmsProd.Size = New System.Drawing.Size(304, 76)
        '
        'ДобавитьПродуктToolStripMenuItem
        '
        Me.ДобавитьПродуктToolStripMenuItem.Name = "ДобавитьПродуктToolStripMenuItem"
        Me.ДобавитьПродуктToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
        Me.ДобавитьПродуктToolStripMenuItem.Text = "Добавить продукт"
        '
        'УдадитьПродуктToolStripMenuItem
        '
        Me.УдадитьПродуктToolStripMenuItem.Name = "УдадитьПродуктToolStripMenuItem"
        Me.УдадитьПродуктToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
        Me.УдадитьПродуктToolStripMenuItem.Text = "Удалить продукт"
        '
        'ЗадатьТехнологическуюОперациюToolStripMenuItem1
        '
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem1.Name = "ЗадатьТехнологическуюОперациюToolStripMenuItem1"
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem1.Size = New System.Drawing.Size(303, 24)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem1.Text = "Задать технологическую операцию"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(307, 33)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Продукт"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 38)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Длина"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudY
        '
        Me.nudY.AutoSize = true
        Me.nudY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudY.Location = New System.Drawing.Point(482, 146)
        Me.nudY.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.nudY.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudY.Name = "nudY"
        Me.nudY.Size = New System.Drawing.Size(155, 26)
        Me.nudY.TabIndex = 32
        Me.nudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbPrintFormat
        '
        Me.cmbPrintFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPrintFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrintFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPrintFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPrintFormat.FormattingEnabled = true
        Me.cmbPrintFormat.Location = New System.Drawing.Point(807, 222)
        Me.cmbPrintFormat.Name = "cmbPrintFormat"
        Me.cmbPrintFormat.Size = New System.Drawing.Size(158, 25)
        Me.cmbPrintFormat.TabIndex = 38
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 703)
        Me.SplitContainer1.SplitterDistance = 970
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 57
        '
        'c_WFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 703)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "c_WFormat"
        Me.Tag = "58"
        Me.Text = "mdmWFormat"
        Me.cmsCalcConfigTech.ResumeLayout(false)
        Me.cmsCalcConfig.ResumeLayout(false)
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsProd.ResumeLayout(false)
        CType(Me.nudY,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lblMatTypes As System.Windows.Forms.Label
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtPrim As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbPriceGroup As System.Windows.Forms.ComboBox
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPriceName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tstxtCostUnit As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbParam2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents cmsCalcConfig As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clbNacenki As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudY As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents tsbtnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrim2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbProd As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmsProd As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьПродуктToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдадитьПродуктToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCalcConfigTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbPrintFormat As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tscmbSkidka As System.Windows.Forms.ToolStripComboBox
End Class
