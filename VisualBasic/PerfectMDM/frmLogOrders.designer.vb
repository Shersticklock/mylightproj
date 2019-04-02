<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogOrders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogOrders))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tlpLogG = New System.Windows.Forms.TableLayoutPanel()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.cmsLogOrder = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.НазначитьДоставкуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НаКартеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbSelect = New System.Windows.Forms.ComboBox()
        Me.btnUpdateG = New System.Windows.Forms.Button()
        Me.btnAppoint = New System.Windows.Forms.Button()
        Me.dtpDateG = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnToMap = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnDn = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnUp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExportExcel = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnRevers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtTime = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnTimeApply = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDatePlan = New System.Windows.Forms.DateTimePicker()
        Me.cmbExampleEmpl = New System.Windows.Forms.ComboBox()
        Me.dgDataPlan = New System.Windows.Forms.DataGridView()
        Me.cmsLogPlan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ПерейтиКЗаказуToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.tlpLogG.SuspendLayout
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsLogOrder.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.dgDataPlan,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsLogPlan.SuspendLayout
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer2.Panel1.SuspendLayout
        Me.SplitContainer2.Panel2.SuspendLayout
        Me.SplitContainer2.SuspendLayout
        Me.SuspendLayout
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpLogG)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(476, 636)
        Me.SplitContainer1.SplitterDistance = 304
        Me.SplitContainer1.TabIndex = 65
        '
        'tlpLogG
        '
        Me.tlpLogG.ColumnCount = 1
        Me.tlpLogG.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpLogG.Controls.Add(Me.dgData, 0, 1)
        Me.tlpLogG.Controls.Add(Me.Panel2, 0, 0)
        Me.tlpLogG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLogG.Location = New System.Drawing.Point(0, 0)
        Me.tlpLogG.Name = "tlpLogG"
        Me.tlpLogG.RowCount = 2
        Me.tlpLogG.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31!))
        Me.tlpLogG.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75!))
        Me.tlpLogG.Size = New System.Drawing.Size(472, 300)
        Me.tlpLogG.TabIndex = 67
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = false
        Me.dgData.AllowUserToDeleteRows = false
        Me.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.ContextMenuStrip = Me.cmsLogOrder
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgData.Location = New System.Drawing.Point(3, 34)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = true
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle2.NullValue = "1"
        Me.dgData.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgData.RowTemplate.Height = 24
        Me.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgData.Size = New System.Drawing.Size(466, 263)
        Me.dgData.TabIndex = 0
        '
        'cmsLogOrder
        '
        Me.cmsLogOrder.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.cmsLogOrder.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsLogOrder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НазначитьДоставкуToolStripMenuItem, Me.ПерейтиКЗаказуToolStripMenuItem, Me.РедактироватьToolStripMenuItem, Me.НаКартеToolStripMenuItem, Me.УдалитьToolStripMenuItem})
        Me.cmsLogOrder.Name = "cmsLogOrder"
        Me.cmsLogOrder.Size = New System.Drawing.Size(195, 114)
        '
        'НазначитьДоставкуToolStripMenuItem
        '
        Me.НазначитьДоставкуToolStripMenuItem.Name = "НазначитьДоставкуToolStripMenuItem"
        Me.НазначитьДоставкуToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.НазначитьДоставкуToolStripMenuItem.Text = "Назначить доставку"
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'РедактироватьToolStripMenuItem
        '
        Me.РедактироватьToolStripMenuItem.Enabled = false
        Me.РедактироватьToolStripMenuItem.Name = "РедактироватьToolStripMenuItem"
        Me.РедактироватьToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.РедактироватьToolStripMenuItem.Text = "Редактировать"
        '
        'НаКартеToolStripMenuItem
        '
        Me.НаКартеToolStripMenuItem.Name = "НаКартеToolStripMenuItem"
        Me.НаКартеToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.НаКартеToolStripMenuItem.Text = "На карте"
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.УдалитьToolStripMenuItem.Text = "Удалить"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.cmbSelect)
        Me.Panel2.Controls.Add(Me.btnUpdateG)
        Me.Panel2.Controls.Add(Me.btnAppoint)
        Me.Panel2.Controls.Add(Me.dtpDateG)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(466, 25)
        Me.Panel2.TabIndex = 70
        '
        'Button1
        '
        Me.Button1.AutoSize = true
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(73, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 25)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Создать заявку"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'cmbSelect
        '
        Me.cmbSelect.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmbSelect.FormattingEnabled = true
        Me.cmbSelect.Items.AddRange(New Object() {"Заявки на", "Все заявки"})
        Me.cmbSelect.Location = New System.Drawing.Point(0, 0)
        Me.cmbSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(114, 25)
        Me.cmbSelect.TabIndex = 67
        '
        'btnUpdateG
        '
        Me.btnUpdateG.AutoSize = true
        Me.btnUpdateG.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUpdateG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnUpdateG.Location = New System.Drawing.Point(201, 0)
        Me.btnUpdateG.Name = "btnUpdateG"
        Me.btnUpdateG.Size = New System.Drawing.Size(131, 25)
        Me.btnUpdateG.TabIndex = 74
        Me.btnUpdateG.Text = "Обновить заявки"
        Me.btnUpdateG.UseVisualStyleBackColor = true
        '
        'btnAppoint
        '
        Me.btnAppoint.AutoSize = true
        Me.btnAppoint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAppoint.Location = New System.Drawing.Point(332, 0)
        Me.btnAppoint.Name = "btnAppoint"
        Me.btnAppoint.Size = New System.Drawing.Size(134, 25)
        Me.btnAppoint.TabIndex = 73
        Me.btnAppoint.Text = "Поставить в план"
        Me.btnAppoint.UseVisualStyleBackColor = true
        '
        'dtpDateG
        '
        Me.dtpDateG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpDateG.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateG.Location = New System.Drawing.Point(120, 1)
        Me.dtpDateG.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.dtpDateG.Name = "dtpDateG"
        Me.dtpDateG.Size = New System.Drawing.Size(100, 22)
        Me.dtpDateG.TabIndex = 3
        Me.dtpDateG.TabStop = false
        Me.dtpDateG.Value = New Date(2007, 1, 16, 0, 0, 0, 0)
        Me.dtpDateG.Visible = false
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgDataPlan, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(472, 324)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnUpdate, Me.tsbtnToMap, Me.ToolStripSeparator1, Me.tsbtnDn, Me.tsbtnUp, Me.ToolStripSeparator2, Me.tsbtnExportExcel, Me.tsbtnRevers, Me.ToolStripLabel1, Me.tstxtTime, Me.tsbtnTimeApply, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(368, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.TableLayoutPanel1.SetRowSpan(Me.ToolStrip1, 3)
        Me.ToolStrip1.Size = New System.Drawing.Size(104, 324)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnUpdate
        '
        Me.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdate.Image = CType(resources.GetObject("tsbtnUpdate.Image"),System.Drawing.Image)
        Me.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdate.Name = "tsbtnUpdate"
        Me.tsbtnUpdate.Size = New System.Drawing.Size(102, 20)
        Me.tsbtnUpdate.Text = "Обновить"
        '
        'tsbtnToMap
        '
        Me.tsbtnToMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnToMap.Image = CType(resources.GetObject("tsbtnToMap.Image"),System.Drawing.Image)
        Me.tsbtnToMap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnToMap.Name = "tsbtnToMap"
        Me.tsbtnToMap.Size = New System.Drawing.Size(102, 20)
        Me.tsbtnToMap.Text = "На карте"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(102, 6)
        '
        'tsbtnDn
        '
        Me.tsbtnDn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDn.Image = CType(resources.GetObject("tsbtnDn.Image"),System.Drawing.Image)
        Me.tsbtnDn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDn.Name = "tsbtnDn"
        Me.tsbtnDn.Size = New System.Drawing.Size(102, 20)
        Me.tsbtnDn.Text = "Вниз"
        Me.tsbtnDn.Visible = false
        '
        'tsbtnUp
        '
        Me.tsbtnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUp.Image = CType(resources.GetObject("tsbtnUp.Image"),System.Drawing.Image)
        Me.tsbtnUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUp.Name = "tsbtnUp"
        Me.tsbtnUp.Size = New System.Drawing.Size(102, 20)
        Me.tsbtnUp.Text = "Вверх"
        Me.tsbtnUp.Visible = false
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(102, 6)
        '
        'tsbtnExportExcel
        '
        Me.tsbtnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExportExcel.Image = CType(resources.GetObject("tsbtnExportExcel.Image"),System.Drawing.Image)
        Me.tsbtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExportExcel.Name = "tsbtnExportExcel"
        Me.tsbtnExportExcel.Size = New System.Drawing.Size(102, 20)
        Me.tsbtnExportExcel.Text = "Экспорт в Excel"
        '
        'tsbtnRevers
        '
        Me.tsbtnRevers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnRevers.Image = CType(resources.GetObject("tsbtnRevers.Image"),System.Drawing.Image)
        Me.tsbtnRevers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnRevers.Name = "tsbtnRevers"
        Me.tsbtnRevers.Size = New System.Drawing.Size(102, 20)
        Me.tsbtnRevers.Text = "Перевести"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(102, 16)
        Me.ToolStripLabel1.Text = "Время доставки"
        Me.ToolStripLabel1.Visible = false
        '
        'tstxtTime
        '
        Me.tstxtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtTime.Name = "tstxtTime"
        Me.tstxtTime.Size = New System.Drawing.Size(100, 23)
        Me.tstxtTime.Text = "Новое время"
        Me.tstxtTime.Visible = false
        '
        'tsbtnTimeApply
        '
        Me.tsbtnTimeApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnTimeApply.Image = CType(resources.GetObject("tsbtnTimeApply.Image"),System.Drawing.Image)
        Me.tsbtnTimeApply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnTimeApply.Name = "tsbtnTimeApply"
        Me.tsbtnTimeApply.Size = New System.Drawing.Size(102, 20)
        Me.tsbtnTimeApply.Text = "Применить"
        Me.tsbtnTimeApply.Visible = false
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(102, 20)
        Me.ToolStripButton1.Text = "Тест"
        Me.ToolStripButton1.Visible = false
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpDatePlan)
        Me.Panel1.Controls.Add(Me.cmbExampleEmpl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 23)
        Me.Panel1.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(231, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 17)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "на"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "План курьера"
        '
        'dtpDatePlan
        '
        Me.dtpDatePlan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dtpDatePlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtpDatePlan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePlan.Location = New System.Drawing.Point(263, 1)
        Me.dtpDatePlan.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.dtpDatePlan.Name = "dtpDatePlan"
        Me.dtpDatePlan.Size = New System.Drawing.Size(99, 23)
        Me.dtpDatePlan.TabIndex = 4
        Me.dtpDatePlan.TabStop = false
        Me.dtpDatePlan.Value = New Date(2007, 1, 16, 0, 0, 0, 0)
        '
        'cmbExampleEmpl
        '
        Me.cmbExampleEmpl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbExampleEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExampleEmpl.DropDownWidth = 200
        Me.cmbExampleEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmbExampleEmpl.Location = New System.Drawing.Point(104, 0)
        Me.cmbExampleEmpl.MaxDropDownItems = 50
        Me.cmbExampleEmpl.MaxLength = 5
        Me.cmbExampleEmpl.Name = "cmbExampleEmpl"
        Me.cmbExampleEmpl.Size = New System.Drawing.Size(123, 25)
        Me.cmbExampleEmpl.TabIndex = 66
        Me.cmbExampleEmpl.TabStop = false
        '
        'dgDataPlan
        '
        Me.dgDataPlan.AllowUserToAddRows = false
        Me.dgDataPlan.AllowUserToDeleteRows = false
        Me.dgDataPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDataPlan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgDataPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDataPlan.ContextMenuStrip = Me.cmsLogPlan
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDataPlan.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgDataPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDataPlan.Location = New System.Drawing.Point(3, 32)
        Me.dgDataPlan.Name = "dgDataPlan"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.NullValue = "1"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDataPlan.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDataPlan.RowTemplate.Height = 24
        Me.dgDataPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDataPlan.Size = New System.Drawing.Size(362, 289)
        Me.dgDataPlan.TabIndex = 68
        '
        'cmsLogPlan
        '
        Me.cmsLogPlan.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.cmsLogPlan.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsLogPlan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПерейтиКЗаказуToolStripMenuItem1})
        Me.cmsLogPlan.Name = "cmsLogPlan"
        Me.cmsLogPlan.Size = New System.Drawing.Size(188, 28)
        '
        'ПерейтиКЗаказуToolStripMenuItem1
        '
        Me.ПерейтиКЗаказуToolStripMenuItem1.Name = "ПерейтиКЗаказуToolStripMenuItem1"
        Me.ПерейтиКЗаказуToolStripMenuItem1.Size = New System.Drawing.Size(187, 24)
        Me.ПерейтиКЗаказуToolStripMenuItem1.Text = "Перейти к заказу"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer2.Size = New System.Drawing.Size(957, 636)
        Me.SplitContainer2.SplitterDistance = 476
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 66
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(15, 16)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(474, 632)
        Me.WebBrowser1.TabIndex = 0
        '
        'frmLogOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 636)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmLogOrders"
        Me.Text = "Логистика"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.tlpLogG.ResumeLayout(false)
        CType(Me.dgData,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsLogOrder.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.dgDataPlan,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsLogPlan.ResumeLayout(false)
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgData As System.Windows.Forms.DataGridView
    Friend WithEvents cmbExampleEmpl As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDatePlan As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmsLogOrder As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents НазначитьДоставкуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpDateG As System.Windows.Forms.DateTimePicker
    Friend WithEvents tlpLogG As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgDataPlan As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExportExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnRevers As System.Windows.Forms.ToolStripButton
    Friend WithEvents РедактироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtTime As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnTimeApply As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAppoint As System.Windows.Forms.Button
    Friend WithEvents btnUpdateG As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnDn As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnUp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents cmbSelect As System.Windows.Forms.ComboBox
    Friend WithEvents tsbtnToMap As System.Windows.Forms.ToolStripButton
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsLogPlan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents НаКартеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
