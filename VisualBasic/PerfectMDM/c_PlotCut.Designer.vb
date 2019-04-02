<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_PlotCut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_PlotCut))
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.tstxtCostUnit = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tscmbSkidka = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmsConfigMat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudKolvo = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgMat = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.range = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSrok = New System.Windows.Forms.ComboBox()
        Me.chkVyborka = New System.Windows.Forms.CheckBox()
        Me.chkMatMont = New System.Windows.Forms.CheckBox()
        Me.cmbMatMont = New System.Windows.Forms.ComboBox()
        Me.cmbVyborka = New System.Windows.Forms.ComboBox()
        Me.cmsConfigTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudY = New System.Windows.Forms.NumericUpDown()
        Me.nudX = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.cmsProdTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьПродуктToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдадитьПродуктToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbSelect = New System.Windows.Forms.ComboBox()
        Me.nudKolSloev = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1.SuspendLayout
        Me.cmsConfigMat.SuspendLayout
        CType(Me.nudKolvo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsConfigTech.SuspendLayout
        CType(Me.nudY,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudX,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsProdTech.SuspendLayout
        CType(Me.nudKolSloev,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
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
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(158, 19)
        Me.ToolStripLabel3.Text = "Цена за изделие"
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
        'tstxtCostUnit
        '
        Me.tstxtCostUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostUnit.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtCostUnit.Name = "tstxtCostUnit"
        Me.tstxtCostUnit.ReadOnly = true
        Me.tstxtCostUnit.Size = New System.Drawing.Size(156, 27)
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
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tscmbSkidka, Me.tsbtnCost, Me.tstxtItog, Me.ToolStripLabel3, Me.tstxtCostUnit, Me.tsbtnOK, Me.ToolStripSeparator1, Me.tsbtnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(981, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(160, 658)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(158, 18)
        Me.ToolStripLabel2.Text = "Скидка, %"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tscmbSkidka
        '
        Me.tscmbSkidka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbSkidka.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tscmbSkidka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbSkidka.Name = "tscmbSkidka"
        Me.tscmbSkidka.Size = New System.Drawing.Size(156, 26)
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
        Me.tsbtnExit.Size = New System.Drawing.Size(158, 23)
        Me.tsbtnExit.Text = "Выход"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(158, 19)
        Me.ToolStripLabel1.Text = "30"
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
        'nudKolvo
        '
        Me.nudKolvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudKolvo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudKolvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudKolvo.Location = New System.Drawing.Point(734, 6)
        Me.nudKolvo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudKolvo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudKolvo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudKolvo.Name = "nudKolvo"
        Me.nudKolvo.Size = New System.Drawing.Size(232, 26)
        Me.nudKolvo.TabIndex = 1
        Me.nudKolvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudKolvo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgMat, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSrok, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.chkVyborka, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chkMatMont, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMatMont, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbVyborka, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudY, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudKolvo, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudX, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tmbMatTypes, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMatTypes, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMat, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSelect, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nudKolSloev, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 6)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(971, 646)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dgMat
        '
        Me.dgMat.AllowDrop = true
        Me.dgMat.AllowUserToAddRows = false
        Me.dgMat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.matID, Me.cost, Me.range, Me.NameMat})
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgMat, 3)
        Me.dgMat.Location = New System.Drawing.Point(5, 222)
        Me.dgMat.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgMat.MultiSelect = false
        Me.dgMat.Name = "dgMat"
        Me.dgMat.ReadOnly = true
        Me.dgMat.RowTemplate.Height = 24
        Me.dgMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMat.Size = New System.Drawing.Size(961, 381)
        Me.dgMat.TabIndex = 34
        Me.dgMat.Visible = false
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = true
        Me.ID.Visible = false
        '
        'matID
        '
        Me.matID.HeaderText = "matID"
        Me.matID.Name = "matID"
        Me.matID.ReadOnly = true
        Me.matID.Visible = false
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
        Me.range.HeaderText = "Номер"
        Me.range.Name = "range"
        Me.range.ReadOnly = true
        '
        'NameMat
        '
        Me.NameMat.HeaderText = "Наименование"
        Me.NameMat.Name = "NameMat"
        Me.NameMat.ReadOnly = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 609)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(297, 37)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Срочность"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSrok
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbSrok, 2)
        Me.cmbSrok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSrok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSrok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSrok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSrok.FormattingEnabled = true
        Me.cmbSrok.Location = New System.Drawing.Point(312, 615)
        Me.cmbSrok.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbSrok.Name = "cmbSrok"
        Me.cmbSrok.Size = New System.Drawing.Size(654, 25)
        Me.cmbSrok.TabIndex = 8
        '
        'chkVyborka
        '
        Me.chkVyborka.AutoSize = true
        Me.chkVyborka.Checked = true
        Me.chkVyborka.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVyborka.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkVyborka.Enabled = false
        Me.chkVyborka.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVyborka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkVyborka.Location = New System.Drawing.Point(215, 78)
        Me.chkVyborka.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkVyborka.Name = "chkVyborka"
        Me.chkVyborka.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkVyborka.Size = New System.Drawing.Size(87, 22)
        Me.chkVyborka.TabIndex = 18
        Me.chkVyborka.Text = "Выборка"
        Me.chkVyborka.UseVisualStyleBackColor = true
        '
        'chkMatMont
        '
        Me.chkMatMont.AutoSize = true
        Me.chkMatMont.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkMatMont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMatMont.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkMatMont.Location = New System.Drawing.Point(200, 112)
        Me.chkMatMont.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkMatMont.Name = "chkMatMont"
        Me.chkMatMont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMatMont.Size = New System.Drawing.Size(102, 25)
        Me.chkMatMont.TabIndex = 19
        Me.chkMatMont.Text = "Монтажка*"
        Me.chkMatMont.UseVisualStyleBackColor = true
        '
        'cmbMatMont
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbMatMont, 2)
        Me.cmbMatMont.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbMatMont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatMont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatMont.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMatMont.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatMont.FormattingEnabled = true
        Me.cmbMatMont.Location = New System.Drawing.Point(312, 112)
        Me.cmbMatMont.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbMatMont.MaxDropDownItems = 20
        Me.cmbMatMont.Name = "cmbMatMont"
        Me.cmbMatMont.Size = New System.Drawing.Size(654, 25)
        Me.cmbMatMont.TabIndex = 7
        Me.cmbMatMont.Visible = false
        '
        'cmbVyborka
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbVyborka, 2)
        Me.cmbVyborka.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbVyborka.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbVyborka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVyborka.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbVyborka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbVyborka.FormattingEnabled = true
        Me.cmbVyborka.Location = New System.Drawing.Point(311, 76)
        Me.cmbVyborka.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbVyborka.Name = "cmbVyborka"
        Me.cmbVyborka.Size = New System.Drawing.Size(656, 25)
        Me.cmbVyborka.TabIndex = 6
        Me.cmbVyborka.Tag = "pcVyborka"
        '
        'cmsConfigTech
        '
        Me.cmsConfigTech.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigTech.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigTech.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmsConfigTech.Name = "cmsCalcConfigTech"
        Me.cmsConfigTech.Size = New System.Drawing.Size(304, 28)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(303, 24)
        Me.ToolStripMenuItem1.Text = "Задать технологическую операцию"
        '
        'nudY
        '
        Me.nudY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudY.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudY.Location = New System.Drawing.Point(733, 42)
        Me.nudY.Margin = New System.Windows.Forms.Padding(4)
        Me.nudY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudY.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudY.Name = "nudY"
        Me.nudY.Size = New System.Drawing.Size(234, 26)
        Me.nudY.TabIndex = 3
        Me.nudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudY.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudX
        '
        Me.nudX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudX.Dock = System.Windows.Forms.DockStyle.Right
        Me.nudX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudX.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudX.Location = New System.Drawing.Point(537, 42)
        Me.nudX.Margin = New System.Windows.Forms.Padding(4)
        Me.nudX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudX.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudX.Name = "nudX"
        Me.nudX.Size = New System.Drawing.Size(188, 26)
        Me.nudX.TabIndex = 2
        Me.nudX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudX.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 34)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Размер (мм)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 38)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Продукт, количество"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmbMatTypes
        '
        Me.tmbMatTypes.ContextMenuStrip = Me.cmsProdTech
        Me.tmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tmbMatTypes.FormattingEnabled = true
        Me.tmbMatTypes.Location = New System.Drawing.Point(311, 4)
        Me.tmbMatTypes.Margin = New System.Windows.Forms.Padding(4)
        Me.tmbMatTypes.Name = "tmbMatTypes"
        Me.tmbMatTypes.Size = New System.Drawing.Size(414, 25)
        Me.tmbMatTypes.TabIndex = 0
        Me.tmbMatTypes.Tag = "plCutProd"
        '
        'cmsProdTech
        '
        Me.cmsProdTech.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsProdTech.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsProdTech.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьПродуктToolStripMenuItem, Me.УдадитьПродуктToolStripMenuItem, Me.ЗадатьТехнологическуюОперациюToolStripMenuItem})
        Me.cmsProdTech.Name = "cmsProd"
        Me.cmsProdTech.Size = New System.Drawing.Size(326, 76)
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
        'cmbMatTypes
        '
        Me.cmbMatTypes.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatTypes.FormattingEnabled = true
        Me.cmbMatTypes.Location = New System.Drawing.Point(3, 183)
        Me.cmbMatTypes.Name = "cmbMatTypes"
        Me.cmbMatTypes.Size = New System.Drawing.Size(301, 25)
        Me.cmbMatTypes.TabIndex = 29
        Me.cmbMatTypes.Visible = false
        '
        'cmbMat
        '
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(310, 183)
        Me.cmbMat.MaxDropDownItems = 24
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(416, 25)
        Me.cmbMat.TabIndex = 30
        Me.cmbMat.Visible = false
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = true
        Me.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnAdd.Location = New System.Drawing.Point(732, 183)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(236, 30)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Добавить"
        Me.btnAdd.UseVisualStyleBackColor = true
        Me.btnAdd.Visible = false
        '
        'cmbSelect
        '
        Me.cmbSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSelect.FormattingEnabled = true
        Me.cmbSelect.Items.AddRange(New Object() {"Материал заказчика", "Выбрать материал*"})
        Me.cmbSelect.Location = New System.Drawing.Point(5, 149)
        Me.cmbSelect.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(297, 25)
        Me.cmbSelect.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cmbSelect, "Если режем из нашего материала, то выбираем матриал фона, а остальные цвета указы"& _ 
        "ваем в элементах.")
        '
        'nudKolSloev
        '
        Me.nudKolSloev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudKolSloev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudKolSloev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudKolSloev.Location = New System.Drawing.Point(732, 146)
        Me.nudKolSloev.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudKolSloev.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudKolSloev.Name = "nudKolSloev"
        Me.nudKolSloev.Size = New System.Drawing.Size(236, 26)
        Me.nudKolSloev.TabIndex = 36
        Me.nudKolSloev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudKolSloev.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudKolSloev.Visible = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 37)
        Me.Label1.TabIndex = 35
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStrip1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1141, 658)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'c_PlotCut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1141, 658)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "c_PlotCut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "30"
        Me.Text = "awc_PlotCut"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.cmsConfigMat.ResumeLayout(false)
        CType(Me.nudKolvo,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsConfigTech.ResumeLayout(false)
        CType(Me.nudY,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudX,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsProdTech.ResumeLayout(false)
        CType(Me.nudKolSloev,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tstxtCostUnit As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents nudKolvo As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbSrok As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbSelect As System.Windows.Forms.ComboBox
    Friend WithEvents chkVyborka As System.Windows.Forms.CheckBox
    Friend WithEvents chkMatMont As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMatMont As System.Windows.Forms.ComboBox
    Friend WithEvents cmsConfigMat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudX As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudY As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbVyborka As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents cmsProdTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьПродуктToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдадитьПродуктToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tscmbSkidka As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cmsConfigTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgMat As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents matID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents range As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameMat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudKolSloev As System.Windows.Forms.NumericUpDown
End Class
