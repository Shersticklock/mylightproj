<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_Exp_on_period
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_Exp_on_period))
        Me.tlpParam = New System.Windows.Forms.TableLayoutPanel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtYear = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnSelAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnOrderClose = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ОткрытьФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpRaznos = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.nudSum = New System.Windows.Forms.NumericUpDown()
        Me.cmbPaymentReferences = New System.Windows.Forms.ComboBox()
        Me.dtpYM = New System.Windows.Forms.DateTimePicker()
        Me.nudSettlementPeriod = New System.Windows.Forms.NumericUpDown()
        Me.cmbArticlesExpenses = New System.Windows.Forms.ComboBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tlpParam.SuspendLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.BindingNavigator1.SuspendLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsMenu.SuspendLayout
        Me.tlpRaznos.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        CType(Me.nudSum,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudSettlementPeriod,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'tlpParam
        '
        Me.tlpParam.ColumnCount = 2
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpParam.Controls.Add(Me.BindingNavigator1, 0, 2)
        Me.tlpParam.Controls.Add(Me.dgTableData, 0, 3)
        Me.tlpParam.Controls.Add(Me.tlpRaznos, 1, 3)
        Me.tlpParam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpParam.Location = New System.Drawing.Point(0, 0)
        Me.tlpParam.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.tlpParam.Name = "tlpParam"
        Me.tlpParam.RowCount = 4
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.Size = New System.Drawing.Size(1276, 705)
        Me.tlpParam.TabIndex = 2
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.tlpParam.SetColumnSpan(Me.BindingNavigator1, 2)
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BindingNavigator1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tstxtYear, Me.tsbtnUpdate, Me.BindingNavigatorSeparator2, Me.tsbtnSelAll, Me.ToolStripSeparator1, Me.tsbtnOrderClose, Me.tsbtnExportToExcel, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(1276, 25)
        Me.BindingNavigator1.TabIndex = 74
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "Год"
        '
        'tstxtYear
        '
        Me.tstxtYear.BackColor = System.Drawing.SystemColors.Info
        Me.tstxtYear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tstxtYear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtYear.Name = "tstxtYear"
        Me.tstxtYear.Size = New System.Drawing.Size(124, 25)
        Me.tstxtYear.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tsbtnUpdate
        '
        Me.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnUpdate.Image = CType(resources.GetObject("tsbtnUpdate.Image"),System.Drawing.Image)
        Me.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdate.Name = "tsbtnUpdate"
        Me.tsbtnUpdate.Size = New System.Drawing.Size(142, 22)
        Me.tsbtnUpdate.Text = "Обновить затраты"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnSelAll
        '
        Me.tsbtnSelAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSelAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnSelAll.Image = CType(resources.GetObject("tsbtnSelAll.Image"),System.Drawing.Image)
        Me.tsbtnSelAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSelAll.Name = "tsbtnSelAll"
        Me.tsbtnSelAll.Size = New System.Drawing.Size(110, 22)
        Me.tsbtnSelAll.Text = "Выделить все"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnOrderClose
        '
        Me.tsbtnOrderClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOrderClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOrderClose.Image = CType(resources.GetObject("tsbtnOrderClose.Image"),System.Drawing.Image)
        Me.tsbtnOrderClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOrderClose.Name = "tsbtnOrderClose"
        Me.tsbtnOrderClose.Size = New System.Drawing.Size(291, 22)
        Me.tsbtnOrderClose.Text = "Консолидировать выделенные затраты"
        '
        'tsbtnExportToExcel
        '
        Me.tsbtnExportToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnExportToExcel.Image = CType(resources.GetObject("tsbtnExportToExcel.Image"),System.Drawing.Image)
        Me.tsbtnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExportToExcel.Name = "tsbtnExportToExcel"
        Me.tsbtnExportToExcel.Size = New System.Drawing.Size(123, 22)
        Me.tsbtnExportToExcel.Text = "Экспорт в Excel"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton1.Text = "Выход"
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.AllowUserToResizeRows = false
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTableData.ContextMenuStrip = Me.cmsMenu
        Me.dgTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTableData.Location = New System.Drawing.Point(6, 32)
        Me.dgTableData.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.ReadOnly = true
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTableData.Size = New System.Drawing.Size(768, 666)
        Me.dgTableData.TabIndex = 0
        '
        'cmsMenu
        '
        Me.cmsMenu.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьФайлToolStripMenuItem})
        Me.cmsMenu.Name = "cmsMenu"
        Me.cmsMenu.Size = New System.Drawing.Size(176, 28)
        '
        'ОткрытьФайлToolStripMenuItem
        '
        Me.ОткрытьФайлToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ОткрытьФайлToolStripMenuItem.Name = "ОткрытьФайлToolStripMenuItem"
        Me.ОткрытьФайлToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.ОткрытьФайлToolStripMenuItem.Text = "Открыть файл"
        '
        'tlpRaznos
        '
        Me.tlpRaznos.ColumnCount = 2
        Me.tlpRaznos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRaznos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpRaznos.Controls.Add(Me.Label2, 0, 0)
        Me.tlpRaznos.Controls.Add(Me.Label3, 0, 1)
        Me.tlpRaznos.Controls.Add(Me.Label7, 0, 2)
        Me.tlpRaznos.Controls.Add(Me.Label6, 0, 3)
        Me.tlpRaznos.Controls.Add(Me.Label5, 0, 4)
        Me.tlpRaznos.Controls.Add(Me.Label1, 0, 5)
        Me.tlpRaznos.Controls.Add(Me.ToolStrip1, 0, 6)
        Me.tlpRaznos.Controls.Add(Me.nudSum, 1, 0)
        Me.tlpRaznos.Controls.Add(Me.cmbPaymentReferences, 1, 1)
        Me.tlpRaznos.Controls.Add(Me.dtpYM, 1, 2)
        Me.tlpRaznos.Controls.Add(Me.nudSettlementPeriod, 1, 3)
        Me.tlpRaznos.Controls.Add(Me.cmbArticlesExpenses, 1, 4)
        Me.tlpRaznos.Controls.Add(Me.txtPurpose, 1, 5)
        Me.tlpRaznos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRaznos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpRaznos.Location = New System.Drawing.Point(785, 31)
        Me.tlpRaznos.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tlpRaznos.Name = "tlpRaznos"
        Me.tlpRaznos.RowCount = 7
        Me.tlpRaznos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRaznos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRaznos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRaznos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRaznos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRaznos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRaznos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRaznos.Size = New System.Drawing.Size(486, 668)
        Me.tlpRaznos.TabIndex = 75
        Me.tlpRaznos.Visible = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Сумма"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 37)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Статья затрат"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = false
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(218, 36)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Месяц возникновения"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 38)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Период разнесения (месяцев)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 36)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Статья затрат"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 185)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 255)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Примечание"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.tlpRaznos.SetColumnSpan(Me.ToolStrip1, 2)
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOK, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 440)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(486, 228)
        Me.ToolStrip1.TabIndex = 34
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(484, 22)
        Me.tsbtnOK.Text = "Разнести затраты"
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(484, 22)
        Me.tsbtnExit.Text = "Cкрыть"
        '
        'nudSum
        '
        Me.nudSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSum.DecimalPlaces = 2
        Me.nudSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSum.Enabled = false
        Me.nudSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSum.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudSum.Location = New System.Drawing.Point(233, 6)
        Me.nudSum.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudSum.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudSum.Name = "nudSum"
        Me.nudSum.Size = New System.Drawing.Size(248, 26)
        Me.nudSum.TabIndex = 21
        Me.nudSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbPaymentReferences
        '
        Me.cmbPaymentReferences.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPaymentReferences.FormattingEnabled = true
        Me.cmbPaymentReferences.Items.AddRange(New Object() {"Договор", "Счет"})
        Me.cmbPaymentReferences.Location = New System.Drawing.Point(233, 44)
        Me.cmbPaymentReferences.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbPaymentReferences.Name = "cmbPaymentReferences"
        Me.cmbPaymentReferences.Size = New System.Drawing.Size(179, 25)
        Me.cmbPaymentReferences.TabIndex = 18
        Me.cmbPaymentReferences.Visible = false
        '
        'dtpYM
        '
        Me.dtpYM.CustomFormat = "yyyy/MMM"
        Me.dtpYM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpYM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYM.Location = New System.Drawing.Point(233, 81)
        Me.dtpYM.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpYM.Name = "dtpYM"
        Me.dtpYM.Size = New System.Drawing.Size(179, 24)
        Me.dtpYM.TabIndex = 13
        '
        'nudSettlementPeriod
        '
        Me.nudSettlementPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSettlementPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSettlementPeriod.Location = New System.Drawing.Point(233, 117)
        Me.nudSettlementPeriod.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudSettlementPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSettlementPeriod.Name = "nudSettlementPeriod"
        Me.nudSettlementPeriod.Size = New System.Drawing.Size(179, 26)
        Me.nudSettlementPeriod.TabIndex = 14
        Me.nudSettlementPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSettlementPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbArticlesExpenses
        '
        Me.cmbArticlesExpenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArticlesExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbArticlesExpenses.FormattingEnabled = true
        Me.cmbArticlesExpenses.Location = New System.Drawing.Point(233, 155)
        Me.cmbArticlesExpenses.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbArticlesExpenses.Name = "cmbArticlesExpenses"
        Me.cmbArticlesExpenses.Size = New System.Drawing.Size(179, 24)
        Me.cmbArticlesExpenses.TabIndex = 10
        '
        'txtPurpose
        '
        Me.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(233, 191)
        Me.txtPurpose.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPurpose.MaxLength = 250
        Me.txtPurpose.Multiline = true
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(179, 243)
        Me.txtPurpose.TabIndex = 0
        '
        'BackgroundWorker1
        '
        '
        'fin_Exp_on_period
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 705)
        Me.Controls.Add(Me.tlpParam)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fin_Exp_on_period"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fin_PayKA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlpParam.ResumeLayout(false)
        Me.tlpParam.PerformLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).EndInit
        Me.BindingNavigator1.ResumeLayout(false)
        Me.BindingNavigator1.PerformLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsMenu.ResumeLayout(false)
        Me.tlpRaznos.ResumeLayout(false)
        Me.tlpRaznos.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.nudSum,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudSettlementPeriod,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tlpParam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents tsbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnSelAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnOrderClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExportToExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents tlpRaznos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents cmbArticlesExpenses As System.Windows.Forms.ComboBox
    Friend WithEvents dtpYM As System.Windows.Forms.DateTimePicker
    Friend WithEvents nudSettlementPeriod As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbPaymentReferences As System.Windows.Forms.ComboBox
    Friend WithEvents nudSum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ОткрытьФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtYear As System.Windows.Forms.ToolStripTextBox
End Class
