<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSklad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSklad))
        Me.dgMatOut = New System.Windows.Forms.DataGridView()
        Me.cmsDetailMat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.МатериалЗакупленToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаказатьМатериалToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтменитьСписаниеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЭкспортВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tvMat = New System.Windows.Forms.TreeView()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.tlp1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbSelectMode = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tlp2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgUnit = New System.Windows.Forms.DataGridView()
        Me.dgMat = New System.Windows.Forms.DataGridView()
        Me.cms1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ИнвентаризацияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbUnit = New System.Windows.Forms.Label()
        Me.tsUnit = New System.Windows.Forms.ToolStrip()
        Me.cmbDepAssignment = New System.Windows.Forms.ToolStripComboBox()
        Me.tsunitsQuant = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtQuantity = New System.Windows.Forms.ToolStripTextBox()
        Me.tslbReason = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtReason = New System.Windows.Forms.ToolStripTextBox()
        Me.btnExecute = New System.Windows.Forms.ToolStripButton()
        Me.tlp3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtpDateMatOut = New System.Windows.Forms.DateTimePicker()
        Me.lbMatOut = New System.Windows.Forms.Label()
        Me.tsMatOut = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOrderMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnMatOutOnDate = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAllMatOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgMatOut,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsDetailMat.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.tlp1.SuspendLayout
        Me.tlp2.SuspendLayout
        CType(Me.dgUnit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cms1.SuspendLayout
        Me.tsUnit.SuspendLayout
        Me.tlp3.SuspendLayout
        Me.tsMatOut.SuspendLayout
        Me.SuspendLayout
        '
        'dgMatOut
        '
        Me.dgMatOut.AllowUserToAddRows = false
        Me.dgMatOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMatOut.ContextMenuStrip = Me.cmsDetailMat
        Me.dgMatOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMatOut.Location = New System.Drawing.Point(5, 33)
        Me.dgMatOut.Margin = New System.Windows.Forms.Padding(5)
        Me.dgMatOut.MultiSelect = false
        Me.dgMatOut.Name = "dgMatOut"
        Me.dgMatOut.ReadOnly = true
        Me.dgMatOut.RowTemplate.Height = 24
        Me.dgMatOut.RowTemplate.ReadOnly = true
        Me.dgMatOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgMatOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMatOut.Size = New System.Drawing.Size(679, 78)
        Me.dgMatOut.TabIndex = 27
        '
        'cmsDetailMat
        '
        Me.cmsDetailMat.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsDetailMat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDetailMat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.МатериалЗакупленToolStripMenuItem, Me.ЗаказатьМатериалToolStripMenuItem, Me.ОтменитьСписаниеToolStripMenuItem, Me.ПерейтиКЗаказуToolStripMenuItem, Me.ЭкспортВExcelToolStripMenuItem})
        Me.cmsDetailMat.Name = "cmsDetailMat"
        Me.cmsDetailMat.Size = New System.Drawing.Size(217, 124)
        '
        'МатериалЗакупленToolStripMenuItem
        '
        Me.МатериалЗакупленToolStripMenuItem.Name = "МатериалЗакупленToolStripMenuItem"
        Me.МатериалЗакупленToolStripMenuItem.Size = New System.Drawing.Size(216, 24)
        Me.МатериалЗакупленToolStripMenuItem.Text = "Материал закуплен"
        '
        'ЗаказатьМатериалToolStripMenuItem
        '
        Me.ЗаказатьМатериалToolStripMenuItem.Name = "ЗаказатьМатериалToolStripMenuItem"
        Me.ЗаказатьМатериалToolStripMenuItem.Size = New System.Drawing.Size(216, 24)
        Me.ЗаказатьМатериалToolStripMenuItem.Text = "Заказать материал"
        '
        'ОтменитьСписаниеToolStripMenuItem
        '
        Me.ОтменитьСписаниеToolStripMenuItem.Name = "ОтменитьСписаниеToolStripMenuItem"
        Me.ОтменитьСписаниеToolStripMenuItem.Size = New System.Drawing.Size(216, 24)
        Me.ОтменитьСписаниеToolStripMenuItem.Text = "Отменить списание"
        Me.ОтменитьСписаниеToolStripMenuItem.Visible = false
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(216, 24)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'ЭкспортВExcelToolStripMenuItem
        '
        Me.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem"
        Me.ЭкспортВExcelToolStripMenuItem.Size = New System.Drawing.Size(216, 24)
        Me.ЭкспортВExcelToolStripMenuItem.Text = "Экспорт в Excel"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tlp1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 783)
        Me.SplitContainer1.SplitterDistance = 326
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 15
        Me.SplitContainer1.TabStop = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.tvMat, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbDepartment, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(324, 781)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'tvMat
        '
        Me.tvMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMat.Enabled = false
        Me.tvMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMat.Location = New System.Drawing.Point(5, 38)
        Me.tvMat.Margin = New System.Windows.Forms.Padding(5)
        Me.tvMat.Name = "tvMat"
        Me.tvMat.Size = New System.Drawing.Size(314, 738)
        Me.tvMat.TabIndex = 0
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.Enabled = false
        Me.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepartment.FormattingEnabled = true
        Me.cmbDepartment.Location = New System.Drawing.Point(4, 4)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(316, 25)
        Me.cmbDepartment.TabIndex = 1
        '
        'tlp1
        '
        Me.tlp1.ColumnCount = 2
        Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp1.Controls.Add(Me.cmbSelectMode, 0, 0)
        Me.tlp1.Controls.Add(Me.Button1, 1, 0)
        Me.tlp1.Controls.Add(Me.tlp2, 0, 1)
        Me.tlp1.Controls.Add(Me.tlp3, 0, 2)
        Me.tlp1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp1.Location = New System.Drawing.Point(0, 0)
        Me.tlp1.Margin = New System.Windows.Forms.Padding(5)
        Me.tlp1.Name = "tlp1"
        Me.tlp1.RowCount = 3
        Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlp1.Size = New System.Drawing.Size(942, 781)
        Me.tlp1.TabIndex = 0
        '
        'cmbSelectMode
        '
        Me.cmbSelectMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSelectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelectMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSelectMode.FormattingEnabled = true
        Me.cmbSelectMode.Items.AddRange(New Object() {"Выдача по требованию", "Выдача на департамент", "Выданный и заказанный материал"})
        Me.cmbSelectMode.Location = New System.Drawing.Point(3, 3)
        Me.cmbSelectMode.Name = "cmbSelectMode"
        Me.cmbSelectMode.Size = New System.Drawing.Size(665, 25)
        Me.cmbSelectMode.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button1.Location = New System.Drawing.Point(674, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 30)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Выход"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'tlp2
        '
        Me.tlp2.ColumnCount = 2
        Me.tlp1.SetColumnSpan(Me.tlp2, 2)
        Me.tlp2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlp2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp2.Controls.Add(Me.dgUnit, 0, 2)
        Me.tlp2.Controls.Add(Me.dgMat, 0, 0)
        Me.tlp2.Controls.Add(Me.lbUnit, 0, 1)
        Me.tlp2.Controls.Add(Me.tsUnit, 1, 2)
        Me.tlp2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp2.Location = New System.Drawing.Point(3, 39)
        Me.tlp2.Name = "tlp2"
        Me.tlp2.RowCount = 3
        Me.tlp2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70!))
        Me.tlp2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.tlp2.Size = New System.Drawing.Size(936, 617)
        Me.tlp2.TabIndex = 35
        Me.tlp2.Visible = false
        '
        'dgUnit
        '
        Me.dgUnit.AllowUserToAddRows = false
        Me.dgUnit.AllowUserToDeleteRows = false
        Me.dgUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUnit.Location = New System.Drawing.Point(5, 442)
        Me.dgUnit.Margin = New System.Windows.Forms.Padding(5)
        Me.dgUnit.MultiSelect = false
        Me.dgUnit.Name = "dgUnit"
        Me.dgUnit.ReadOnly = true
        Me.dgUnit.RowTemplate.Height = 24
        Me.dgUnit.RowTemplate.ReadOnly = true
        Me.dgUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUnit.Size = New System.Drawing.Size(631, 170)
        Me.dgUnit.TabIndex = 2
        Me.dgUnit.Visible = false
        '
        'dgMat
        '
        Me.dgMat.AllowUserToAddRows = false
        Me.dgMat.AllowUserToDeleteRows = false
        Me.dgMat.AllowUserToResizeRows = false
        Me.dgMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlp2.SetColumnSpan(Me.dgMat, 2)
        Me.dgMat.ContextMenuStrip = Me.cms1
        Me.dgMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMat.Location = New System.Drawing.Point(5, 5)
        Me.dgMat.Margin = New System.Windows.Forms.Padding(5)
        Me.dgMat.MultiSelect = false
        Me.dgMat.Name = "dgMat"
        Me.dgMat.ReadOnly = true
        Me.dgMat.RowTemplate.Height = 24
        Me.dgMat.RowTemplate.ReadOnly = true
        Me.dgMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMat.Size = New System.Drawing.Size(926, 409)
        Me.dgMat.TabIndex = 0
        Me.dgMat.Visible = false
        '
        'cms1
        '
        Me.cms1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cms1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИнвентаризацияToolStripMenuItem})
        Me.cms1.Name = "cms1"
        Me.cms1.Size = New System.Drawing.Size(197, 28)
        '
        'ИнвентаризацияToolStripMenuItem
        '
        Me.ИнвентаризацияToolStripMenuItem.Name = "ИнвентаризацияToolStripMenuItem"
        Me.ИнвентаризацияToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.ИнвентаризацияToolStripMenuItem.Text = "Инвентаризация"
        '
        'lbUnit
        '
        Me.lbUnit.AutoSize = true
        Me.lbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lbUnit.Location = New System.Drawing.Point(4, 419)
        Me.lbUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUnit.Name = "lbUnit"
        Me.lbUnit.Size = New System.Drawing.Size(279, 18)
        Me.lbUnit.TabIndex = 30
        Me.lbUnit.Text = "Доступный материал в единицах учета"
        Me.lbUnit.Visible = false
        '
        'tsUnit
        '
        Me.tsUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsUnit.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsUnit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbDepAssignment, Me.tsunitsQuant, Me.tstxtQuantity, Me.tslbReason, Me.tstxtReason, Me.btnExecute})
        Me.tsUnit.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsUnit.Location = New System.Drawing.Point(641, 437)
        Me.tsUnit.Name = "tsUnit"
        Me.tsUnit.Size = New System.Drawing.Size(295, 158)
        Me.tsUnit.TabIndex = 32
        Me.tsUnit.Text = "ToolStrip2"
        '
        'cmbDepAssignment
        '
        Me.cmbDepAssignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepAssignment.DropDownWidth = 275
        Me.cmbDepAssignment.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepAssignment.MaxDropDownItems = 12
        Me.cmbDepAssignment.Name = "cmbDepAssignment"
        Me.cmbDepAssignment.Size = New System.Drawing.Size(291, 28)
        '
        'tsunitsQuant
        '
        Me.tsunitsQuant.Name = "tsunitsQuant"
        Me.tsunitsQuant.Size = New System.Drawing.Size(293, 18)
        Me.tsunitsQuant.Text = "Количество"
        '
        'tstxtQuantity
        '
        Me.tstxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtQuantity.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtQuantity.Name = "tstxtQuantity"
        Me.tstxtQuantity.Size = New System.Drawing.Size(291, 26)
        Me.tstxtQuantity.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tslbReason
        '
        Me.tslbReason.Name = "tslbReason"
        Me.tslbReason.Size = New System.Drawing.Size(293, 18)
        Me.tslbReason.Text = "Кому/причина"
        '
        'tstxtReason
        '
        Me.tstxtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtReason.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtReason.Name = "tstxtReason"
        Me.tstxtReason.Size = New System.Drawing.Size(291, 26)
        '
        'btnExecute
        '
        Me.btnExecute.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.btnExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExecute.Image = CType(resources.GetObject("btnExecute.Image"),System.Drawing.Image)
        Me.btnExecute.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(293, 22)
        Me.btnExecute.Text = "Выдать"
        '
        'tlp3
        '
        Me.tlp3.AutoSize = true
        Me.tlp3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlp3.ColumnCount = 2
        Me.tlp1.SetColumnSpan(Me.tlp3, 2)
        Me.tlp3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.71134!))
        Me.tlp3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.28866!))
        Me.tlp3.Controls.Add(Me.dtpDateMatOut, 1, 0)
        Me.tlp3.Controls.Add(Me.dgMatOut, 0, 1)
        Me.tlp3.Controls.Add(Me.lbMatOut, 0, 0)
        Me.tlp3.Controls.Add(Me.tsMatOut, 1, 1)
        Me.tlp3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp3.Location = New System.Drawing.Point(3, 662)
        Me.tlp3.Name = "tlp3"
        Me.tlp3.RowCount = 2
        Me.tlp3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlp3.Size = New System.Drawing.Size(936, 116)
        Me.tlp3.TabIndex = 36
        Me.tlp3.Visible = false
        '
        'dtpDateMatOut
        '
        Me.dtpDateMatOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDateMatOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateMatOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateMatOut.Location = New System.Drawing.Point(693, 2)
        Me.dtpDateMatOut.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtpDateMatOut.Name = "dtpDateMatOut"
        Me.dtpDateMatOut.Size = New System.Drawing.Size(239, 24)
        Me.dtpDateMatOut.TabIndex = 29
        '
        'lbMatOut
        '
        Me.lbMatOut.AutoSize = true
        Me.lbMatOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMatOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lbMatOut.Location = New System.Drawing.Point(4, 0)
        Me.lbMatOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMatOut.Name = "lbMatOut"
        Me.lbMatOut.Size = New System.Drawing.Size(681, 28)
        Me.lbMatOut.TabIndex = 28
        Me.lbMatOut.Text = "Материалы выданные на департамент/ списаные дата "
        Me.lbMatOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsMatOut
        '
        Me.tsMatOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsMatOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsMatOut.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMatOut.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOrderMat, Me.tsbtnMatOutOnDate, Me.tsbtnAllMatOut, Me.ToolStripSeparator1})
        Me.tsMatOut.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsMatOut.Location = New System.Drawing.Point(689, 28)
        Me.tsMatOut.Name = "tsMatOut"
        Me.tsMatOut.Size = New System.Drawing.Size(247, 88)
        Me.tsMatOut.TabIndex = 31
        Me.tsMatOut.Text = "ToolStrip1"
        '
        'tsbtnOrderMat
        '
        Me.tsbtnOrderMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOrderMat.Image = CType(resources.GetObject("tsbtnOrderMat.Image"),System.Drawing.Image)
        Me.tsbtnOrderMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOrderMat.Name = "tsbtnOrderMat"
        Me.tsbtnOrderMat.Size = New System.Drawing.Size(245, 22)
        Me.tsbtnOrderMat.Text = "Заказанный материал"
        '
        'tsbtnMatOutOnDate
        '
        Me.tsbtnMatOutOnDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnMatOutOnDate.Image = CType(resources.GetObject("tsbtnMatOutOnDate.Image"),System.Drawing.Image)
        Me.tsbtnMatOutOnDate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMatOutOnDate.Name = "tsbtnMatOutOnDate"
        Me.tsbtnMatOutOnDate.Size = New System.Drawing.Size(245, 22)
        Me.tsbtnMatOutOnDate.Text = "Выдано на дату"
        '
        'tsbtnAllMatOut
        '
        Me.tsbtnAllMatOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAllMatOut.Image = CType(resources.GetObject("tsbtnAllMatOut.Image"),System.Drawing.Image)
        Me.tsbtnAllMatOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAllMatOut.Name = "tsbtnAllMatOut"
        Me.tsbtnAllMatOut.Size = New System.Drawing.Size(94, 22)
        Me.tsbtnAllMatOut.Text = "Все выдачи"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(304, 6)
        '
        'frmSklad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 783)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmSklad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSklad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgMatOut,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsDetailMat.ResumeLayout(false)
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.tlp1.ResumeLayout(false)
        Me.tlp1.PerformLayout
        Me.tlp2.ResumeLayout(false)
        Me.tlp2.PerformLayout
        CType(Me.dgUnit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).EndInit
        Me.cms1.ResumeLayout(false)
        Me.tsUnit.ResumeLayout(false)
        Me.tsUnit.PerformLayout
        Me.tlp3.ResumeLayout(false)
        Me.tlp3.PerformLayout
        Me.tsMatOut.ResumeLayout(false)
        Me.tsMatOut.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvMat As System.Windows.Forms.TreeView
    Friend WithEvents tlp1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgMat As System.Windows.Forms.DataGridView
    Friend WithEvents dgUnit As System.Windows.Forms.DataGridView
    Friend WithEvents dgMatOut As System.Windows.Forms.DataGridView
    Friend WithEvents lbMatOut As System.Windows.Forms.Label
    Friend WithEvents dtpDateMatOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbUnit As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents tsUnit As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbDepAssignment As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsunitsQuant As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtQuantity As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tslbReason As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtReason As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnExecute As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsDetailMat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents МатериалЗакупленToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗаказатьМатериалToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтменитьСписаниеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbSelectMode As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tlp2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlp3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tsMatOut As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnOrderMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnMatOutOnDate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnAllMatOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cms1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ИнвентаризацияToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЭкспортВExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
