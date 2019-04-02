<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkladInventar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkladInventar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbModeInventar = New System.Windows.Forms.ComboBox()
        Me.cmbDepartments = New System.Windows.Forms.ComboBox()
        Me.cmbMatGroups = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tvMat = New System.Windows.Forms.TreeView()
        Me.cmsTv = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.СоздатьЕдиницыУчетаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tsFind = New System.Windows.Forms.ToolStrip()
        Me.tsbtnFindForward = New System.Windows.Forms.ToolStripButton()
        Me.tstxtstrFind = New System.Windows.Forms.ToolStripTextBox()
        Me.dgMat = New System.Windows.Forms.DataGridView()
        Me.cmsInventory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЭкспортВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КорректировкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоискToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudCorr = New System.Windows.Forms.NumericUpDown()
        Me.txtCorr = New System.Windows.Forms.TextBox()
        Me.btnSaveCorr = New System.Windows.Forms.Button()
        Me.dgUnits = New System.Windows.Forms.DataGridView()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.btnCancelCorr = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.cmsTv.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.tsFind.SuspendLayout
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsInventory.SuspendLayout
        CType(Me.nudCorr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgUnits,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 697)
        Me.SplitContainer1.SplitterDistance = 258
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 16
        Me.SplitContainer1.TabStop = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmbModeInventar, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbDepartments, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbMatGroups, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tvMat, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(254, 693)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'cmbModeInventar
        '
        Me.cmbModeInventar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbModeInventar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeInventar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbModeInventar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbModeInventar.FormattingEnabled = true
        Me.cmbModeInventar.Items.AddRange(New Object() {"По категориям и типам материалов", "По группам (адресам хранения)", "Общая инвентаризация"})
        Me.cmbModeInventar.Location = New System.Drawing.Point(4, 35)
        Me.cmbModeInventar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbModeInventar.Name = "cmbModeInventar"
        Me.cmbModeInventar.Size = New System.Drawing.Size(246, 25)
        Me.cmbModeInventar.TabIndex = 0
        '
        'cmbDepartments
        '
        Me.cmbDepartments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDepartments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepartments.FormattingEnabled = true
        Me.cmbDepartments.Location = New System.Drawing.Point(4, 4)
        Me.cmbDepartments.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDepartments.MaxDropDownItems = 24
        Me.cmbDepartments.Name = "cmbDepartments"
        Me.cmbDepartments.Size = New System.Drawing.Size(246, 25)
        Me.cmbDepartments.TabIndex = 2
        '
        'cmbMatGroups
        '
        Me.cmbMatGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMatGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatGroups.FormattingEnabled = true
        Me.cmbMatGroups.Location = New System.Drawing.Point(4, 64)
        Me.cmbMatGroups.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbMatGroups.MaxDropDownItems = 35
        Me.cmbMatGroups.Name = "cmbMatGroups"
        Me.cmbMatGroups.Size = New System.Drawing.Size(246, 25)
        Me.cmbMatGroups.TabIndex = 1
        Me.cmbMatGroups.Visible = false
        '
        'Button2
        '
        Me.Button2.AutoSize = true
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(248, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Обновить"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'tvMat
        '
        Me.tvMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvMat.ContextMenuStrip = Me.cmsTv
        Me.tvMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMat.Location = New System.Drawing.Point(5, 139)
        Me.tvMat.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tvMat.Name = "tvMat"
        Me.tvMat.Size = New System.Drawing.Size(244, 548)
        Me.tvMat.TabIndex = 0
        Me.tvMat.Visible = false
        '
        'cmsTv
        '
        Me.cmsTv.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsTv.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздатьЕдиницыУчетаToolStripMenuItem})
        Me.cmsTv.Name = "cmsTv"
        Me.cmsTv.Size = New System.Drawing.Size(242, 28)
        '
        'СоздатьЕдиницыУчетаToolStripMenuItem
        '
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.CheckOnClick = true
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.Name = "СоздатьЕдиницыУчетаToolStripMenuItem"
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.Text = "Создать единицы учета"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 693)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1000, 663)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Инвентаризация"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.tsFind, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgMat, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudCorr, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCorr, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaveCorr, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgUnits, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPwd, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelCorr, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(994, 657)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tsFind
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tsFind, 4)
        Me.tsFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsFind.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsFind.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsFind.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnFindForward, Me.tstxtstrFind})
        Me.tsFind.Location = New System.Drawing.Point(1, 1)
        Me.tsFind.Name = "tsFind"
        Me.tsFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tsFind.Size = New System.Drawing.Size(638, 27)
        Me.tsFind.TabIndex = 68
        Me.tsFind.Text = "ToolStrip1"
        '
        'tsbtnFindForward
        '
        Me.tsbtnFindForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFindForward.Image = CType(resources.GetObject("tsbtnFindForward.Image"),System.Drawing.Image)
        Me.tsbtnFindForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFindForward.Name = "tsbtnFindForward"
        Me.tsbtnFindForward.Size = New System.Drawing.Size(60, 24)
        Me.tsbtnFindForward.Text = "Искать"
        '
        'tstxtstrFind
        '
        Me.tstxtstrFind.BackColor = System.Drawing.SystemColors.Info
        Me.tstxtstrFind.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtstrFind.Name = "tstxtstrFind"
        Me.tstxtstrFind.Size = New System.Drawing.Size(300, 27)
        '
        'dgMat
        '
        Me.dgMat.AllowUserToAddRows = false
        Me.dgMat.AllowUserToDeleteRows = false
        Me.dgMat.AllowUserToResizeRows = false
        Me.dgMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgMat, 4)
        Me.dgMat.ContextMenuStrip = Me.cmsInventory
        Me.dgMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMat.Location = New System.Drawing.Point(6, 35)
        Me.dgMat.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgMat.MultiSelect = false
        Me.dgMat.Name = "dgMat"
        Me.dgMat.ReadOnly = true
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dgMat.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMat.RowTemplate.Height = 24
        Me.dgMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMat.Size = New System.Drawing.Size(628, 578)
        Me.dgMat.TabIndex = 0
        '
        'cmsInventory
        '
        Me.cmsInventory.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsInventory.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsInventory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЭкспортВExcelToolStripMenuItem, Me.КорректировкаToolStripMenuItem, Me.ПоискToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.cmsInventory.Name = "cmsInventory"
        Me.cmsInventory.Size = New System.Drawing.Size(186, 100)
        '
        'ЭкспортВExcelToolStripMenuItem
        '
        Me.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem"
        Me.ЭкспортВExcelToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.ЭкспортВExcelToolStripMenuItem.Text = "Экспорт в Excel"
        '
        'КорректировкаToolStripMenuItem
        '
        Me.КорректировкаToolStripMenuItem.CheckOnClick = true
        Me.КорректировкаToolStripMenuItem.Name = "КорректировкаToolStripMenuItem"
        Me.КорректировкаToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.КорректировкаToolStripMenuItem.Text = "Корректировка"
        '
        'ПоискToolStripMenuItem
        '
        Me.ПоискToolStripMenuItem.Name = "ПоискToolStripMenuItem"
        Me.ПоискToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.ПоискToolStripMenuItem.Text = "Поиск"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'nudCorr
        '
        Me.nudCorr.DecimalPlaces = 4
        Me.nudCorr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudCorr.Location = New System.Drawing.Point(4, 623)
        Me.nudCorr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nudCorr.Name = "nudCorr"
        Me.nudCorr.Size = New System.Drawing.Size(111, 26)
        Me.nudCorr.TabIndex = 3
        Me.nudCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCorr.Visible = false
        '
        'txtCorr
        '
        Me.txtCorr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtCorr.Location = New System.Drawing.Point(122, 623)
        Me.txtCorr.Name = "txtCorr"
        Me.txtCorr.Size = New System.Drawing.Size(329, 24)
        Me.txtCorr.TabIndex = 4
        Me.txtCorr.Text = "причина"
        Me.txtCorr.Visible = false
        '
        'btnSaveCorr
        '
        Me.btnSaveCorr.AutoSize = true
        Me.btnSaveCorr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveCorr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSaveCorr.Location = New System.Drawing.Point(539, 623)
        Me.btnSaveCorr.Name = "btnSaveCorr"
        Me.btnSaveCorr.Size = New System.Drawing.Size(97, 30)
        Me.btnSaveCorr.TabIndex = 5
        Me.btnSaveCorr.Text = "Применить"
        Me.btnSaveCorr.UseVisualStyleBackColor = true
        Me.btnSaveCorr.Visible = false
        '
        'dgUnits
        '
        Me.dgUnits.AllowUserToAddRows = false
        Me.dgUnits.AllowUserToDeleteRows = false
        Me.dgUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUnits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUnits.Location = New System.Drawing.Point(643, 32)
        Me.dgUnits.Name = "dgUnits"
        Me.dgUnits.RowTemplate.Height = 24
        Me.dgUnits.Size = New System.Drawing.Size(347, 584)
        Me.dgUnits.TabIndex = 6
        Me.dgUnits.Visible = false
        '
        'txtPwd
        '
        Me.txtPwd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPwd.ForeColor = System.Drawing.Color.Silver
        Me.txtPwd.Location = New System.Drawing.Point(643, 623)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(347, 24)
        Me.txtPwd.TabIndex = 8
        Me.txtPwd.Text = "Введи_пароль"
        Me.txtPwd.Visible = false
        '
        'btnCancelCorr
        '
        Me.btnCancelCorr.AutoSize = true
        Me.btnCancelCorr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelCorr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelCorr.Location = New System.Drawing.Point(458, 623)
        Me.btnCancelCorr.Name = "btnCancelCorr"
        Me.btnCancelCorr.Size = New System.Drawing.Size(74, 30)
        Me.btnCancelCorr.TabIndex = 12
        Me.btnCancelCorr.Text = "Отмена"
        Me.btnCancelCorr.UseVisualStyleBackColor = true
        Me.btnCancelCorr.Visible = false
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSkladInventar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 697)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "frmSkladInventar"
        Me.Text = "Инвентаризация"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.cmsTv.ResumeLayout(false)
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.tsFind.ResumeLayout(false)
        Me.tsFind.PerformLayout
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsInventory.ResumeLayout(false)
        CType(Me.nudCorr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgUnits,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvMat As System.Windows.Forms.TreeView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgMat As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbModeInventar As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMatGroups As System.Windows.Forms.ComboBox
    Friend WithEvents cmsInventory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЭкспортВExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbDepartments As System.Windows.Forms.ComboBox
    Friend WithEvents КорректировкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nudCorr As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCorr As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveCorr As System.Windows.Forms.Button
    Friend WithEvents dgUnits As System.Windows.Forms.DataGridView
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmsTv As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents СоздатьЕдиницыУчетаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCancelCorr As System.Windows.Forms.Button
    Friend WithEvents tsFind As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnFindForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxtstrFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ПоискToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
