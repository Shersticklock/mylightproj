<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tech_DressOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tech_DressOrders))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgSpec = New System.Windows.Forms.DataGridView()
        Me.cmsSpec = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ФормироватьТехнологическуюКартуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstCosts = New System.Windows.Forms.ListBox()
        Me.cmsDressOrders = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ПечатьНарядЗаказаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgTechOperFromOrder = New System.Windows.Forms.DataGridView()
        Me.cmsTechOper = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КалькуляцияМатериалаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СписатьМатериалToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbParamTechOper = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOper = New System.Windows.Forms.ComboBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnToPlan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.cmbDirDep = New System.Windows.Forms.ComboBox()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpCalcMat = New System.Windows.Forms.TabPage()
        Me.dgMatForOper = New System.Windows.Forms.DataGridView()
        Me.matCalcForOper = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.УдалитьСтрокуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpTechTasks = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        Me.cmbEmplExec = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.dgTechTask = New System.Windows.Forms.DataGridView()
        Me.tpSpisMat = New System.Windows.Forms.TabPage()
        Me.dgMatExpens = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.dgSpec,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsSpec.SuspendLayout
        Me.cmsDressOrders.SuspendLayout
        CType(Me.dgTechOperFromOrder,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsTechOper.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NumericUpDown2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.tpCalcMat.SuspendLayout
        CType(Me.dgMatForOper,System.ComponentModel.ISupportInitialize).BeginInit
        Me.matCalcForOper.SuspendLayout
        Me.tpTechTasks.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        CType(Me.dgTechTask,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpSpisMat.SuspendLayout
        CType(Me.dgMatExpens,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 461!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.84089!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.15911!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgSpec, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstCosts, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgTechOperFromOrder, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbDirDep, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMode, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1272, 465)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgSpec
        '
        Me.dgSpec.AllowUserToAddRows = false
        Me.dgSpec.AllowUserToDeleteRows = false
        Me.dgSpec.AllowUserToResizeRows = false
        Me.dgSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgSpec, 2)
        Me.dgSpec.ContextMenuStrip = Me.cmsSpec
        Me.dgSpec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSpec.Location = New System.Drawing.Point(465, 4)
        Me.dgSpec.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSpec.Name = "dgSpec"
        Me.dgSpec.ReadOnly = true
        Me.TableLayoutPanel1.SetRowSpan(Me.dgSpec, 3)
        Me.dgSpec.RowTemplate.Height = 24
        Me.dgSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSpec.Size = New System.Drawing.Size(803, 173)
        Me.dgSpec.TabIndex = 4
        '
        'cmsSpec
        '
        Me.cmsSpec.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsSpec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФормироватьТехнологическуюКартуToolStripMenuItem})
        Me.cmsSpec.Name = "cmsSpec"
        Me.cmsSpec.Size = New System.Drawing.Size(339, 28)
        '
        'ФормироватьТехнологическуюКартуToolStripMenuItem
        '
        Me.ФормироватьТехнологическуюКартуToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ФормироватьТехнологическуюКартуToolStripMenuItem.Name = "ФормироватьТехнологическуюКартуToolStripMenuItem"
        Me.ФормироватьТехнологическуюКартуToolStripMenuItem.Size = New System.Drawing.Size(338, 24)
        Me.ФормироватьТехнологическуюКартуToolStripMenuItem.Text = "Формировать технологическую карту"
        '
        'lstCosts
        '
        Me.lstCosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCosts.ContextMenuStrip = Me.cmsDressOrders
        Me.lstCosts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstCosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstCosts.FormattingEnabled = true
        Me.lstCosts.ItemHeight = 17
        Me.lstCosts.Location = New System.Drawing.Point(4, 68)
        Me.lstCosts.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCosts.Name = "lstCosts"
        Me.lstCosts.Size = New System.Drawing.Size(453, 109)
        Me.lstCosts.TabIndex = 5
        '
        'cmsDressOrders
        '
        Me.cmsDressOrders.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsDressOrders.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDressOrders.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПечатьНарядЗаказаToolStripMenuItem, Me.ПерейтиКЗаказуToolStripMenuItem})
        Me.cmsDressOrders.Name = "cmsDressOrders"
        Me.cmsDressOrders.Size = New System.Drawing.Size(225, 52)
        '
        'ПечатьНарядЗаказаToolStripMenuItem
        '
        Me.ПечатьНарядЗаказаToolStripMenuItem.Name = "ПечатьНарядЗаказаToolStripMenuItem"
        Me.ПечатьНарядЗаказаToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.ПечатьНарядЗаказаToolStripMenuItem.Text = "Печать наряд-заказа"
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'dgTechOperFromOrder
        '
        Me.dgTechOperFromOrder.AllowUserToAddRows = false
        Me.dgTechOperFromOrder.AllowUserToDeleteRows = false
        Me.dgTechOperFromOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTechOperFromOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgTechOperFromOrder, 2)
        Me.dgTechOperFromOrder.ContextMenuStrip = Me.cmsTechOper
        Me.dgTechOperFromOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTechOperFromOrder.Location = New System.Drawing.Point(4, 207)
        Me.dgTechOperFromOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.dgTechOperFromOrder.Name = "dgTechOperFromOrder"
        Me.dgTechOperFromOrder.ReadOnly = true
        Me.dgTechOperFromOrder.RowTemplate.Height = 24
        Me.dgTechOperFromOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTechOperFromOrder.Size = New System.Drawing.Size(816, 254)
        Me.dgTechOperFromOrder.TabIndex = 6
        '
        'cmsTechOper
        '
        Me.cmsTechOper.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsTechOper.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTechOper.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КалькуляцияМатериалаToolStripMenuItem, Me.СписатьМатериалToolStripMenuItem, Me.УдалитьToolStripMenuItem})
        Me.cmsTechOper.Name = "cmsTechOper"
        Me.cmsTechOper.Size = New System.Drawing.Size(247, 76)
        '
        'КалькуляцияМатериалаToolStripMenuItem
        '
        Me.КалькуляцияМатериалаToolStripMenuItem.Name = "КалькуляцияМатериалаToolStripMenuItem"
        Me.КалькуляцияМатериалаToolStripMenuItem.Size = New System.Drawing.Size(246, 24)
        Me.КалькуляцияМатериалаToolStripMenuItem.Text = "Калькуляция материала"
        '
        'СписатьМатериалToolStripMenuItem
        '
        Me.СписатьМатериалToolStripMenuItem.Name = "СписатьМатериалToolStripMenuItem"
        Me.СписатьМатериалToolStripMenuItem.Size = New System.Drawing.Size(246, 24)
        Me.СписатьМатериалToolStripMenuItem.Text = "Списать материал"
        Me.СписатьМатериалToolStripMenuItem.Visible = false
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(246, 24)
        Me.УдалитьToolStripMenuItem.Text = "Удалить операцию"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbParamTechOper, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbOper, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.nudQuantity, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnToPlan, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDown1, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.NumericUpDown2, 1, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(828, 207)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(440, 215)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Департамент(участок)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbParamTechOper
        '
        Me.cmbParamTechOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbParamTechOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParamTechOper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbParamTechOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbParamTechOper.FormattingEnabled = true
        Me.cmbParamTechOper.Location = New System.Drawing.Point(180, 5)
        Me.cmbParamTechOper.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbParamTechOper.MaxDropDownItems = 16
        Me.cmbParamTechOper.Name = "cmbParamTechOper"
        Me.cmbParamTechOper.Size = New System.Drawing.Size(255, 25)
        Me.cmbParamTechOper.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Операция"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOper
        '
        Me.cmbOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOper.FormattingEnabled = true
        Me.cmbOper.Location = New System.Drawing.Point(180, 39)
        Me.cmbOper.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOper.MaxDropDownItems = 16
        Me.cmbOper.Name = "cmbOper"
        Me.cmbOper.Size = New System.Drawing.Size(255, 25)
        Me.cmbOper.TabIndex = 12
        '
        'nudQuantity
        '
        Me.nudQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(180, 73)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(255, 24)
        Me.nudQuantity.TabIndex = 10
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Количество"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnToPlan
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btnToPlan, 2)
        Me.btnToPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnToPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnToPlan.Location = New System.Drawing.Point(5, 168)
        Me.btnToPlan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnToPlan.Name = "btnToPlan"
        Me.btnToPlan.Size = New System.Drawing.Size(430, 42)
        Me.btnToPlan.TabIndex = 8
        Me.btnToPlan.Text = "Добавить в технологическую карту"
        Me.btnToPlan.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 30)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Длительность (с)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 30)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Стоимость (руб.)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = false
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(179, 105)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(257, 24)
        Me.NumericUpDown1.TabIndex = 15
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1.Visible = false
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(179, 136)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(257, 24)
        Me.NumericUpDown2.TabIndex = 16
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown2.Visible = false
        '
        'cmbDirDep
        '
        Me.cmbDirDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDirDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDirDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDirDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDirDep.FormattingEnabled = true
        Me.cmbDirDep.Location = New System.Drawing.Point(4, 4)
        Me.cmbDirDep.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDirDep.MaxDropDownItems = 24
        Me.cmbDirDep.Name = "cmbDirDep"
        Me.cmbDirDep.Size = New System.Drawing.Size(453, 25)
        Me.cmbDirDep.TabIndex = 8
        '
        'cmbMode
        '
        Me.cmbMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMode.FormattingEnabled = true
        Me.cmbMode.Items.AddRange(New Object() {"Планирование", "Производство", "Готов", "ВыдаН"})
        Me.cmbMode.Location = New System.Drawing.Point(3, 36)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(455, 25)
        Me.cmbMode.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(818, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Технологическая карта"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(827, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(397, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Формирование/ корректировка технологической карты"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 731)
        Me.SplitContainer1.SplitterDistance = 469
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpCalcMat)
        Me.TabControl1.Controls.Add(Me.tpTechTasks)
        Me.TabControl1.Controls.Add(Me.tpSpisMat)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1272, 252)
        Me.TabControl1.TabIndex = 0
        '
        'tpCalcMat
        '
        Me.tpCalcMat.Controls.Add(Me.dgMatForOper)
        Me.tpCalcMat.Location = New System.Drawing.Point(4, 26)
        Me.tpCalcMat.Margin = New System.Windows.Forms.Padding(4)
        Me.tpCalcMat.Name = "tpCalcMat"
        Me.tpCalcMat.Padding = New System.Windows.Forms.Padding(4)
        Me.tpCalcMat.Size = New System.Drawing.Size(1264, 222)
        Me.tpCalcMat.TabIndex = 1
        Me.tpCalcMat.Text = "Калькуляция материала на технологическую операцию"
        Me.tpCalcMat.UseVisualStyleBackColor = true
        '
        'dgMatForOper
        '
        Me.dgMatForOper.AllowUserToAddRows = false
        Me.dgMatForOper.AllowUserToDeleteRows = false
        Me.dgMatForOper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMatForOper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMatForOper.ContextMenuStrip = Me.matCalcForOper
        Me.dgMatForOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMatForOper.Location = New System.Drawing.Point(4, 4)
        Me.dgMatForOper.Name = "dgMatForOper"
        Me.dgMatForOper.RowTemplate.Height = 24
        Me.dgMatForOper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMatForOper.Size = New System.Drawing.Size(1256, 214)
        Me.dgMatForOper.TabIndex = 0
        '
        'matCalcForOper
        '
        Me.matCalcForOper.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.matCalcForOper.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.matCalcForOper.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УдалитьСтрокуToolStripMenuItem})
        Me.matCalcForOper.Name = "matCalcForOper"
        Me.matCalcForOper.Size = New System.Drawing.Size(184, 28)
        '
        'УдалитьСтрокуToolStripMenuItem
        '
        Me.УдалитьСтрокуToolStripMenuItem.Name = "УдалитьСтрокуToolStripMenuItem"
        Me.УдалитьСтрокуToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.УдалитьСтрокуToolStripMenuItem.Text = "Удалить строку"
        '
        'tpTechTasks
        '
        Me.tpTechTasks.Controls.Add(Me.TableLayoutPanel3)
        Me.tpTechTasks.Location = New System.Drawing.Point(4, 26)
        Me.tpTechTasks.Margin = New System.Windows.Forms.Padding(4)
        Me.tpTechTasks.Name = "tpTechTasks"
        Me.tpTechTasks.Padding = New System.Windows.Forms.Padding(4)
        Me.tpTechTasks.Size = New System.Drawing.Size(1264, 222)
        Me.tpTechTasks.TabIndex = 0
        Me.tpTechTasks.Text = "Производственный план"
        Me.tpTechTasks.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0108!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.9892!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dgTechTask, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1256, 214)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = true
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cmbDep, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cmbEmplExec, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.DateTimePicker1, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Button1, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBox1, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.DateTimePicker2, 1, 3)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(782, 4)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(470, 178)
        Me.TableLayoutPanel4.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 1)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 33)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Департамент(участок)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDep
        '
        Me.cmbDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDep.FormattingEnabled = true
        Me.cmbDep.Location = New System.Drawing.Point(227, 5)
        Me.cmbDep.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDep.MaxDropDownItems = 16
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(238, 25)
        Me.cmbDep.TabIndex = 1
        '
        'cmbEmplExec
        '
        Me.cmbEmplExec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEmplExec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmplExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEmplExec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEmplExec.FormattingEnabled = true
        Me.cmbEmplExec.Location = New System.Drawing.Point(227, 39)
        Me.cmbEmplExec.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEmplExec.Name = "cmbEmplExec"
        Me.cmbEmplExec.Size = New System.Drawing.Size(238, 25)
        Me.cmbEmplExec.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(213, 33)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Исполнитель"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 69)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(213, 32)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Старт"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd.MM.yyyy hh.mm"
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(227, 73)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 24)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.AutoSize = true
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button1.Location = New System.Drawing.Point(227, 137)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(238, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Поставить в план"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(4, 136)
        Me.TextBox1.Multiline = true
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 38)
        Me.TextBox1.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 30)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Финиш"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd.MM.yyyy hh.mm"
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(226, 105)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(240, 24)
        Me.DateTimePicker2.TabIndex = 15
        '
        'dgTechTask
        '
        Me.dgTechTask.AllowUserToAddRows = false
        Me.dgTechTask.AllowUserToDeleteRows = false
        Me.dgTechTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTechTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTechTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTechTask.Location = New System.Drawing.Point(4, 4)
        Me.dgTechTask.Margin = New System.Windows.Forms.Padding(4)
        Me.dgTechTask.Name = "dgTechTask"
        Me.dgTechTask.ReadOnly = true
        Me.dgTechTask.RowTemplate.Height = 24
        Me.dgTechTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTechTask.Size = New System.Drawing.Size(770, 206)
        Me.dgTechTask.TabIndex = 3
        '
        'tpSpisMat
        '
        Me.tpSpisMat.Controls.Add(Me.dgMatExpens)
        Me.tpSpisMat.Location = New System.Drawing.Point(4, 26)
        Me.tpSpisMat.Name = "tpSpisMat"
        Me.tpSpisMat.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSpisMat.Size = New System.Drawing.Size(1264, 222)
        Me.tpSpisMat.TabIndex = 2
        Me.tpSpisMat.Text = "Списанный материал на весь заказ"
        Me.tpSpisMat.UseVisualStyleBackColor = true
        '
        'dgMatExpens
        '
        Me.dgMatExpens.AllowUserToAddRows = false
        Me.dgMatExpens.AllowUserToDeleteRows = false
        Me.dgMatExpens.AllowUserToResizeRows = false
        Me.dgMatExpens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMatExpens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMatExpens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMatExpens.Location = New System.Drawing.Point(3, 3)
        Me.dgMatExpens.Name = "dgMatExpens"
        Me.dgMatExpens.ReadOnly = true
        Me.dgMatExpens.RowTemplate.Height = 24
        Me.dgMatExpens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMatExpens.Size = New System.Drawing.Size(1258, 216)
        Me.dgMatExpens.TabIndex = 4
        '
        'tech_DressOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 731)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "tech_DressOrders"
        Me.Text = "Наряд заказы"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.dgSpec,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsSpec.ResumeLayout(false)
        Me.cmsDressOrders.ResumeLayout(false)
        CType(Me.dgTechOperFromOrder,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsTechOper.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NumericUpDown2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TabControl1.ResumeLayout(false)
        Me.tpCalcMat.ResumeLayout(false)
        CType(Me.dgMatForOper,System.ComponentModel.ISupportInitialize).EndInit
        Me.matCalcForOper.ResumeLayout(false)
        Me.tpTechTasks.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        CType(Me.dgTechTask,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpSpisMat.ResumeLayout(false)
        CType(Me.dgMatExpens,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgSpec As System.Windows.Forms.DataGridView
    Friend WithEvents lstCosts As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgTechOperFromOrder As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbParamTechOper As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnToPlan As System.Windows.Forms.Button
    Friend WithEvents cmsDressOrders As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ПечатьНарядЗаказаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbDirDep As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbOper As System.Windows.Forms.ComboBox
    Friend WithEvents cmsTechOper As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents УдалитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КалькуляцияМатериалаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СписатьМатериалToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbMode As System.Windows.Forms.ComboBox
    Friend WithEvents matCalcForOper As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents УдалитьСтрокуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpCalcMat As System.Windows.Forms.TabPage
    Friend WithEvents dgMatForOper As System.Windows.Forms.DataGridView
    Friend WithEvents tpTechTasks As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbDep As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEmplExec As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgTechTask As System.Windows.Forms.DataGridView
    Friend WithEvents tpSpisMat As System.Windows.Forms.TabPage
    Friend WithEvents dgMatExpens As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmsSpec As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ФормироватьТехнологическуюКартуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
