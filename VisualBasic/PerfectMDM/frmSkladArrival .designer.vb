<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkladArrival
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkladArrival))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvMat = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnInvoices = New System.Windows.Forms.ToolStripButton()
        Me.tscmbDep = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnArrival = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.dgMat = New System.Windows.Forms.DataGridView()
        Me.cmsArrivall = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbOrganizations = New System.Windows.Forms.ComboBox()
        Me.lblSuplayer = New System.Windows.Forms.Label()
        Me.txtKA_find = New System.Windows.Forms.TextBox()
        Me.cmbKA = New System.Windows.Forms.ComboBox()
        Me.cmbNumber = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.nudPrice = New System.Windows.Forms.NumericUpDown()
        Me.btnArrivall = New System.Windows.Forms.Button()
        Me.dtpDate2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNakl = New System.Windows.Forms.TextBox()
        Me.txtFindNumInv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsArrivall.SuspendLayout
        CType(Me.nudPrice,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvMat)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 707)
        Me.SplitContainer1.SplitterDistance = 394
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 16
        Me.SplitContainer1.TabStop = false
        '
        'tvMat
        '
        Me.tvMat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMat.Location = New System.Drawing.Point(0, 0)
        Me.tvMat.Margin = New System.Windows.Forms.Padding(5)
        Me.tvMat.Name = "tvMat"
        Me.tvMat.Size = New System.Drawing.Size(392, 705)
        Me.tvMat.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrice, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lblQuantity, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.nudQuantity, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgMat, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbOrganizations, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSuplayer, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtKA_find, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbKA, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbNumber, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbUnit, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.nudPrice, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.btnArrivall, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDate2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDate1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNakl, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFindNumInv, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(874, 705)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = true
        Me.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblPrice.Location = New System.Drawing.Point(311, 616)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(296, 36)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.Text = "Стоимость"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = true
        Me.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(311, 580)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(296, 36)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Количество единиц учета"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.DecimalPlaces = 4
        Me.nudQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(617, 585)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(5)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(252, 26)
        Me.nudQuantity.TabIndex = 1
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = false
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnMat, Me.tsbtnInvoices, Me.tscmbDep, Me.tsbtnArrival, Me.tsbtnExport, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(612, 56)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(262, 356)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnMat
        '
        Me.tsbtnMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnMat.Image = CType(resources.GetObject("tsbtnMat.Image"),System.Drawing.Image)
        Me.tsbtnMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMat.Name = "tsbtnMat"
        Me.tsbtnMat.Size = New System.Drawing.Size(260, 22)
        Me.tsbtnMat.Text = "Справочник материалов"
        '
        'tsbtnInvoices
        '
        Me.tsbtnInvoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnInvoices.Image = CType(resources.GetObject("tsbtnInvoices.Image"),System.Drawing.Image)
        Me.tsbtnInvoices.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnInvoices.Name = "tsbtnInvoices"
        Me.tsbtnInvoices.Size = New System.Drawing.Size(260, 22)
        Me.tsbtnInvoices.Text = "Управление счетами"
        '
        'tscmbDep
        '
        Me.tscmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbDep.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbDep.Name = "tscmbDep"
        Me.tscmbDep.Size = New System.Drawing.Size(258, 27)
        '
        'tsbtnArrival
        '
        Me.tsbtnArrival.CheckOnClick = true
        Me.tsbtnArrival.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnArrival.Image = CType(resources.GetObject("tsbtnArrival.Image"),System.Drawing.Image)
        Me.tsbtnArrival.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnArrival.Name = "tsbtnArrival"
        Me.tsbtnArrival.Size = New System.Drawing.Size(260, 22)
        Me.tsbtnArrival.Text = "Показать приходы"
        '
        'tsbtnExport
        '
        Me.tsbtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExport.Image = CType(resources.GetObject("tsbtnExport.Image"),System.Drawing.Image)
        Me.tsbtnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExport.Name = "tsbtnExport"
        Me.tsbtnExport.Size = New System.Drawing.Size(260, 22)
        Me.tsbtnExport.Text = "Экспорт в Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(260, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(260, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'dgMat
        '
        Me.dgMat.AllowUserToAddRows = false
        Me.dgMat.AllowUserToDeleteRows = false
        Me.dgMat.AllowUserToResizeRows = false
        Me.dgMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgMat, 2)
        Me.dgMat.ContextMenuStrip = Me.cmsArrivall
        Me.dgMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMat.Location = New System.Drawing.Point(5, 5)
        Me.dgMat.Margin = New System.Windows.Forms.Padding(5)
        Me.dgMat.MultiSelect = false
        Me.dgMat.Name = "dgMat"
        Me.dgMat.ReadOnly = true
        Me.TableLayoutPanel1.SetRowSpan(Me.dgMat, 3)
        Me.dgMat.RowTemplate.Height = 24
        Me.dgMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMat.Size = New System.Drawing.Size(602, 402)
        Me.dgMat.TabIndex = 0
        '
        'cmsArrivall
        '
        Me.cmsArrivall.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsArrivall.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsArrivall.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УдалитьToolStripMenuItem})
        Me.cmsArrivall.Name = "cmsArrivall"
        Me.cmsArrivall.Size = New System.Drawing.Size(195, 28)
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.УдалитьToolStripMenuItem.Text = "Откатить приход"
        '
        'cmbOrganizations
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbOrganizations, 2)
        Me.cmbOrganizations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrganizations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrganizations.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOrganizations.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOrganizations.FormattingEnabled = true
        Me.cmbOrganizations.Location = New System.Drawing.Point(311, 452)
        Me.cmbOrganizations.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbOrganizations.MaxDropDownItems = 12
        Me.cmbOrganizations.Name = "cmbOrganizations"
        Me.cmbOrganizations.Size = New System.Drawing.Size(558, 25)
        Me.cmbOrganizations.TabIndex = 2
        Me.cmbOrganizations.Visible = false
        '
        'lblSuplayer
        '
        Me.lblSuplayer.AutoSize = true
        Me.lblSuplayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSuplayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblSuplayer.Location = New System.Drawing.Point(5, 447)
        Me.lblSuplayer.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSuplayer.Name = "lblSuplayer"
        Me.lblSuplayer.Size = New System.Drawing.Size(296, 35)
        Me.lblSuplayer.TabIndex = 14
        Me.lblSuplayer.Text = "Организация (Юридическое лицо)"
        Me.lblSuplayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSuplayer.Visible = false
        '
        'txtKA_find
        '
        Me.txtKA_find.BackColor = System.Drawing.SystemColors.Info
        Me.txtKA_find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKA_find.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKA_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtKA_find.Location = New System.Drawing.Point(5, 417)
        Me.txtKA_find.Margin = New System.Windows.Forms.Padding(5)
        Me.txtKA_find.Name = "txtKA_find"
        Me.txtKA_find.Size = New System.Drawing.Size(296, 24)
        Me.txtKA_find.TabIndex = 21
        Me.txtKA_find.Text = "Поставщик"
        Me.txtKA_find.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtKA_find, "Введи фрагмент названия и нажми ввод")
        '
        'cmbKA
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbKA, 2)
        Me.cmbKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbKA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbKA.FormattingEnabled = true
        Me.cmbKA.Location = New System.Drawing.Point(311, 417)
        Me.cmbKA.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbKA.MaxDropDownItems = 15
        Me.cmbKA.Name = "cmbKA"
        Me.cmbKA.Size = New System.Drawing.Size(558, 25)
        Me.cmbKA.TabIndex = 22
        '
        'cmbNumber
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbNumber, 2)
        Me.cmbNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbNumber.FormattingEnabled = true
        Me.cmbNumber.Location = New System.Drawing.Point(311, 487)
        Me.cmbNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbNumber.Name = "cmbNumber"
        Me.cmbNumber.Size = New System.Drawing.Size(558, 25)
        Me.cmbNumber.TabIndex = 0
        Me.cmbNumber.Visible = false
        '
        'cmbUnit
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbUnit, 2)
        Me.cmbUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbUnit.FormattingEnabled = true
        Me.cmbUnit.Location = New System.Drawing.Point(311, 522)
        Me.cmbUnit.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(558, 25)
        Me.cmbUnit.TabIndex = 19
        '
        'nudPrice
        '
        Me.nudPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudPrice.DecimalPlaces = 2
        Me.nudPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudPrice.Location = New System.Drawing.Point(617, 621)
        Me.nudPrice.Margin = New System.Windows.Forms.Padding(5)
        Me.nudPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(252, 26)
        Me.nudPrice.TabIndex = 3
        Me.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnArrivall
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnArrivall, 3)
        Me.btnArrivall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnArrivall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArrivall.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnArrivall.Location = New System.Drawing.Point(4, 654)
        Me.btnArrivall.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnArrivall.Name = "btnArrivall"
        Me.btnArrivall.Size = New System.Drawing.Size(866, 49)
        Me.btnArrivall.TabIndex = 27
        Me.btnArrivall.Text = "Принять на склад"
        Me.btnArrivall.UseVisualStyleBackColor = true
        '
        'dtpDate2
        '
        Me.dtpDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDate2.Location = New System.Drawing.Point(616, 30)
        Me.dtpDate2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(249, 24)
        Me.dtpDate2.TabIndex = 4
        '
        'dtpDate1
        '
        Me.dtpDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDate1.Location = New System.Drawing.Point(616, 2)
        Me.dtpDate1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(249, 24)
        Me.dtpDate1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 552)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 28)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Накладная №"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNakl
        '
        Me.txtNakl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNakl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNakl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNakl.Location = New System.Drawing.Point(616, 554)
        Me.txtNakl.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtNakl.Name = "txtNakl"
        Me.txtNakl.Size = New System.Drawing.Size(254, 24)
        Me.txtNakl.TabIndex = 29
        '
        'txtFindNumInv
        '
        Me.txtFindNumInv.BackColor = System.Drawing.SystemColors.Info
        Me.txtFindNumInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindNumInv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFindNumInv.Enabled = false
        Me.txtFindNumInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFindNumInv.Location = New System.Drawing.Point(4, 486)
        Me.txtFindNumInv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFindNumInv.Name = "txtFindNumInv"
        Me.txtFindNumInv.Size = New System.Drawing.Size(298, 24)
        Me.txtFindNumInv.TabIndex = 30
        Me.txtFindNumInv.Text = "Номер_счета"
        Me.txtFindNumInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFindNumInv.Visible = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 517)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 35)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Единицы учета"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSkladArrival
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 707)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "frmSkladArrival"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Приходование"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsArrivall.ResumeLayout(false)
        CType(Me.nudPrice,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvMat As System.Windows.Forms.TreeView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnExport As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgMat As System.Windows.Forms.DataGridView
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents cmbOrganizations As System.Windows.Forms.ComboBox
    Friend WithEvents lblSuplayer As System.Windows.Forms.Label
    Friend WithEvents cmbNumber As System.Windows.Forms.ComboBox
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtKA_find As System.Windows.Forms.TextBox
    Friend WithEvents cmbKA As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnArrivall As System.Windows.Forms.Button
    Friend WithEvents tsbtnArrival As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsArrivall As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents УдалитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNakl As System.Windows.Forms.TextBox
    Friend WithEvents tsbtnMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnInvoices As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtFindNumInv As System.Windows.Forms.TextBox
    Friend WithEvents tscmbDep As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
