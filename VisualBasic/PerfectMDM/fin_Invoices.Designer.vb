<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_Invoices
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_Invoices))
        Me.dgInvoices = New System.Windows.Forms.DataGridView()
        Me.cmsInvoices = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ОткрытьФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПрикрепитьФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьСчетToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткатитьОплатуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЭкспортВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbSelectQ = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbOrg = New System.Windows.Forms.ComboBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.txtCustForSearh = New System.Windows.Forms.TextBox()
        Me.cmbVisa = New System.Windows.Forms.ComboBox()
        Me.dtpDate1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbFopl = New System.Windows.Forms.ComboBox()
        Me.cmbPP = New System.Windows.Forms.ComboBox()
        Me.dtpDate2 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNewCost = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnKassa = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkPlat = New System.Windows.Forms.CheckBox()
        Me.nudSettlementPeriod = New System.Windows.Forms.NumericUpDown()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.chkItIsPaid = New System.Windows.Forms.CheckBox()
        Me.dtpBankClient = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbExp = New System.Windows.Forms.ComboBox()
        Me.txtNomPP = New System.Windows.Forms.TextBox()
        Me.nudSumma = New System.Windows.Forms.NumericUpDown()
        Me.cmsOplInv = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ПолностьюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.txtDescription = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnApply = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslItogo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslOpl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslDolg = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgInvoices,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsInvoices.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        CType(Me.nudSettlementPeriod,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudSumma,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsOplInv.SuspendLayout
        Me.ToolStrip2.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'dgInvoices
        '
        Me.dgInvoices.AllowUserToAddRows = false
        Me.dgInvoices.AllowUserToDeleteRows = false
        Me.dgInvoices.AllowUserToResizeRows = false
        Me.dgInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgInvoices, 4)
        Me.dgInvoices.ContextMenuStrip = Me.cmsInvoices
        Me.dgInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgInvoices.Location = New System.Drawing.Point(6, 115)
        Me.dgInvoices.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgInvoices.MultiSelect = false
        Me.dgInvoices.Name = "dgInvoices"
        Me.dgInvoices.ReadOnly = true
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dgInvoices.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInvoices.RowTemplate.Height = 24
        Me.dgInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInvoices.Size = New System.Drawing.Size(1254, 414)
        Me.dgInvoices.TabIndex = 2
        '
        'cmsInvoices
        '
        Me.cmsInvoices.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsInvoices.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsInvoices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьФайлToolStripMenuItem, Me.ПрикрепитьФайлToolStripMenuItem, Me.УдалитьСчетToolStripMenuItem, Me.ПерейтиКЗаказуToolStripMenuItem, Me.ОткатитьОплатуToolStripMenuItem, Me.ЭкспортВExcelToolStripMenuItem})
        Me.cmsInvoices.Name = "cmsToExcel"
        Me.cmsInvoices.Size = New System.Drawing.Size(199, 136)
        '
        'ОткрытьФайлToolStripMenuItem
        '
        Me.ОткрытьФайлToolStripMenuItem.Name = "ОткрытьФайлToolStripMenuItem"
        Me.ОткрытьФайлToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ОткрытьФайлToolStripMenuItem.Text = "Открыть файл"
        '
        'ПрикрепитьФайлToolStripMenuItem
        '
        Me.ПрикрепитьФайлToolStripMenuItem.Name = "ПрикрепитьФайлToolStripMenuItem"
        Me.ПрикрепитьФайлToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ПрикрепитьФайлToolStripMenuItem.Text = "Прикрепить файл"
        '
        'УдалитьСчетToolStripMenuItem
        '
        Me.УдалитьСчетToolStripMenuItem.Name = "УдалитьСчетToolStripMenuItem"
        Me.УдалитьСчетToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.УдалитьСчетToolStripMenuItem.Text = "Удалить счет"
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'ОткатитьОплатуToolStripMenuItem
        '
        Me.ОткатитьОплатуToolStripMenuItem.Name = "ОткатитьОплатуToolStripMenuItem"
        Me.ОткатитьОплатуToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ОткатитьОплатуToolStripMenuItem.Text = "Откатить оплату"
        '
        'ЭкспортВExcelToolStripMenuItem
        '
        Me.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem"
        Me.ЭкспортВExcelToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ЭкспортВExcelToolStripMenuItem.Text = "Экспорт в Excel"
        '
        'cmbSelectQ
        '
        Me.cmbSelectQ.DisplayMember = "0"
        Me.cmbSelectQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSelectQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSelectQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSelectQ.FormattingEnabled = true
        Me.cmbSelectQ.Items.AddRange(New Object() {"Не оплачен", "Оплаченные в текущем месяце", "Оплачен в произвольный период", "Все мои счета за период"})
        Me.cmbSelectQ.Location = New System.Drawing.Point(5, 6)
        Me.cmbSelectQ.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbSelectQ.MaxDropDownItems = 12
        Me.cmbSelectQ.Name = "cmbSelectQ"
        Me.cmbSelectQ.Size = New System.Drawing.Size(288, 25)
        Me.cmbSelectQ.TabIndex = 7
        Me.cmbSelectQ.ValueMember = "0"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 444!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgInvoices, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 3, 2)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 6)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1266, 655)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmbSelectQ, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbOrg, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbCustomer, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCustForSearh, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbVisa, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpDate1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbFopl, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbPP, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpDate2, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(996, 101)
        Me.TableLayoutPanel2.TabIndex = 40
        '
        'cmbOrg
        '
        Me.cmbOrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOrg.FormattingEnabled = true
        Me.cmbOrg.Location = New System.Drawing.Point(650, 41)
        Me.cmbOrg.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOrg.Name = "cmbOrg"
        Me.cmbOrg.Size = New System.Drawing.Size(342, 25)
        Me.cmbOrg.TabIndex = 28
        '
        'cmbCustomer
        '
        Me.cmbCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustomer.FormattingEnabled = true
        Me.cmbCustomer.Location = New System.Drawing.Point(302, 41)
        Me.cmbCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(340, 25)
        Me.cmbCustomer.TabIndex = 27
        '
        'txtCustForSearh
        '
        Me.txtCustForSearh.BackColor = System.Drawing.SystemColors.Info
        Me.txtCustForSearh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustForSearh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustForSearh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtCustForSearh.Location = New System.Drawing.Point(4, 41)
        Me.txtCustForSearh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustForSearh.Name = "txtCustForSearh"
        Me.txtCustForSearh.Size = New System.Drawing.Size(290, 26)
        Me.txtCustForSearh.TabIndex = 28
        '
        'cmbVisa
        '
        Me.cmbVisa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbVisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbVisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbVisa.FormattingEnabled = true
        Me.cmbVisa.Items.AddRange(New Object() {"Без визы", "С визой"})
        Me.cmbVisa.Location = New System.Drawing.Point(4, 73)
        Me.cmbVisa.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbVisa.Name = "cmbVisa"
        Me.cmbVisa.Size = New System.Drawing.Size(290, 25)
        Me.cmbVisa.TabIndex = 2
        '
        'dtpDate1
        '
        Me.dtpDate1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDate1.Location = New System.Drawing.Point(302, 9)
        Me.dtpDate1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(340, 26)
        Me.dtpDate1.TabIndex = 26
        '
        'cmbFopl
        '
        Me.cmbFopl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFopl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFopl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbFopl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbFopl.FormattingEnabled = true
        Me.cmbFopl.Items.AddRange(New Object() {"Наличная оплата", "Безналичная оплата"})
        Me.cmbFopl.Location = New System.Drawing.Point(302, 73)
        Me.cmbFopl.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbFopl.Name = "cmbFopl"
        Me.cmbFopl.Size = New System.Drawing.Size(340, 25)
        Me.cmbFopl.TabIndex = 3
        '
        'cmbPP
        '
        Me.cmbPP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPP.FormattingEnabled = true
        Me.cmbPP.Items.AddRange(New Object() {"Есть ПП", "Нет ПП"})
        Me.cmbPP.Location = New System.Drawing.Point(650, 73)
        Me.cmbPP.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbPP.Name = "cmbPP"
        Me.cmbPP.Size = New System.Drawing.Size(342, 25)
        Me.cmbPP.TabIndex = 30
        Me.cmbPP.Visible = false
        '
        'dtpDate2
        '
        Me.dtpDate2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDate2.Location = New System.Drawing.Point(650, 9)
        Me.dtpDate2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(342, 26)
        Me.dtpDate2.TabIndex = 27
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNewCost, Me.tsbtnUpdate, Me.ToolStripSeparator1, Me.tsbtnKassa})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(1004, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(261, 107)
        Me.ToolStrip1.TabIndex = 38
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnNewCost
        '
        Me.tsbtnNewCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewCost.Image = CType(resources.GetObject("tsbtnNewCost.Image"),System.Drawing.Image)
        Me.tsbtnNewCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewCost.Name = "tsbtnNewCost"
        Me.tsbtnNewCost.Size = New System.Drawing.Size(259, 24)
        Me.tsbtnNewCost.Text = "Создать счет"
        '
        'tsbtnUpdate
        '
        Me.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdate.Image = CType(resources.GetObject("tsbtnUpdate.Image"),System.Drawing.Image)
        Me.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdate.Name = "tsbtnUpdate"
        Me.tsbtnUpdate.Size = New System.Drawing.Size(259, 24)
        Me.tsbtnUpdate.Text = "Обновить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(259, 6)
        '
        'tsbtnKassa
        '
        Me.tsbtnKassa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnKassa.Image = CType(resources.GetObject("tsbtnKassa.Image"),System.Drawing.Image)
        Me.tsbtnKassa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnKassa.Name = "tsbtnKassa"
        Me.tsbtnKassa.Size = New System.Drawing.Size(259, 24)
        Me.tsbtnKassa.Text = "Касса"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = true
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 3)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.Controls.Add(Me.chkPlat, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.nudSettlementPeriod, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpPaymentDate, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.chkItIsPaid, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpBankClient, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbExp, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtNomPP, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.nudSumma, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 539)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(996, 112)
        Me.TableLayoutPanel3.TabIndex = 41
        '
        'chkPlat
        '
        Me.chkPlat.AutoSize = true
        Me.chkPlat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkPlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkPlat.Location = New System.Drawing.Point(4, 2)
        Me.chkPlat.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.chkPlat.Name = "chkPlat"
        Me.chkPlat.Size = New System.Drawing.Size(414, 34)
        Me.chkPlat.TabIndex = 22
        Me.chkPlat.Text = "Создано платежное поручение №"
        Me.chkPlat.UseVisualStyleBackColor = true
        '
        'nudSettlementPeriod
        '
        Me.nudSettlementPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSettlementPeriod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSettlementPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSettlementPeriod.Location = New System.Drawing.Point(713, 82)
        Me.nudSettlementPeriod.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.nudSettlementPeriod.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSettlementPeriod.Name = "nudSettlementPeriod"
        Me.nudSettlementPeriod.Size = New System.Drawing.Size(279, 26)
        Me.nudSettlementPeriod.TabIndex = 32
        Me.nudSettlementPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.nudSettlementPeriod, "Период разнесения затрат")
        Me.nudSettlementPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSettlementPeriod.Visible = false
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpPaymentDate.Location = New System.Drawing.Point(714, 44)
        Me.dtpPaymentDate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(277, 26)
        Me.dtpPaymentDate.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.dtpPaymentDate, "Дата оплаты")
        Me.dtpPaymentDate.Visible = false
        '
        'chkItIsPaid
        '
        Me.chkItIsPaid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkItIsPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkItIsPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkItIsPaid.Location = New System.Drawing.Point(5, 44)
        Me.chkItIsPaid.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkItIsPaid.Name = "chkItIsPaid"
        Me.chkItIsPaid.Size = New System.Drawing.Size(412, 30)
        Me.chkItIsPaid.TabIndex = 17
        Me.chkItIsPaid.Text = "Регистрация оплаты счета"
        Me.chkItIsPaid.UseVisualStyleBackColor = true
        '
        'dtpBankClient
        '
        Me.dtpBankClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpBankClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpBankClient.Location = New System.Drawing.Point(714, 6)
        Me.dtpBankClient.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpBankClient.Name = "dtpBankClient"
        Me.dtpBankClient.Size = New System.Drawing.Size(277, 26)
        Me.dtpBankClient.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.dtpBankClient, "Дата платежного поручения")
        Me.dtpBankClient.Visible = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 32)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Статья затрат и период разнесения (мес.)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = false
        '
        'cmbExp
        '
        Me.cmbExp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbExp.FormattingEnabled = true
        Me.cmbExp.Location = New System.Drawing.Point(426, 82)
        Me.cmbExp.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbExp.MaxDropDownItems = 24
        Me.cmbExp.Name = "cmbExp"
        Me.cmbExp.Size = New System.Drawing.Size(279, 28)
        Me.cmbExp.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.cmbExp, "Статья затрат")
        Me.cmbExp.Visible = false
        '
        'txtNomPP
        '
        Me.txtNomPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomPP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtNomPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNomPP.Location = New System.Drawing.Point(426, 12)
        Me.txtNomPP.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtNomPP.Name = "txtNomPP"
        Me.txtNomPP.Size = New System.Drawing.Size(279, 24)
        Me.txtNomPP.TabIndex = 31
        Me.txtNomPP.Visible = false
        '
        'nudSumma
        '
        Me.nudSumma.AutoSize = true
        Me.nudSumma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSumma.ContextMenuStrip = Me.cmsOplInv
        Me.nudSumma.DecimalPlaces = 2
        Me.nudSumma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSumma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSumma.Location = New System.Drawing.Point(425, 41)
        Me.nudSumma.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudSumma.Name = "nudSumma"
        Me.nudSumma.Size = New System.Drawing.Size(281, 26)
        Me.nudSumma.TabIndex = 37
        Me.nudSumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSumma.Visible = false
        '
        'cmsOplInv
        '
        Me.cmsOplInv.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsOplInv.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsOplInv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПолностьюToolStripMenuItem})
        Me.cmsOplInv.Name = "cmsOplInv"
        Me.cmsOplInv.Size = New System.Drawing.Size(158, 28)
        '
        'ПолностьюToolStripMenuItem
        '
        Me.ПолностьюToolStripMenuItem.Name = "ПолностьюToolStripMenuItem"
        Me.ПолностьюToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.ПолностьюToolStripMenuItem.Text = "Полностью"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtDescription, Me.tsbtnApply, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(1004, 536)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(261, 118)
        Me.ToolStrip2.TabIndex = 39
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(257, 26)
        Me.txtDescription.Text = "Примечания"
        '
        'tsbtnApply
        '
        Me.tsbtnApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnApply.Image = CType(resources.GetObject("tsbtnApply.Image"),System.Drawing.Image)
        Me.tsbtnApply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnApply.Name = "tsbtnApply"
        Me.tsbtnApply.Size = New System.Drawing.Size(259, 24)
        Me.tsbtnApply.Text = "Применить"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(259, 6)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(259, 24)
        Me.ToolStripButton2.Text = "Выход"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = true
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslItogo, Me.tsslOpl, Me.tsslDolg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 671)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslItogo
        '
        Me.tsslItogo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsslItogo.Name = "tsslItogo"
        Me.tsslItogo.Size = New System.Drawing.Size(18, 19)
        Me.tsslItogo.Text = "..."
        '
        'tsslOpl
        '
        Me.tsslOpl.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsslOpl.Name = "tsslOpl"
        Me.tsslOpl.Size = New System.Drawing.Size(18, 19)
        Me.tsslOpl.Text = "..."
        '
        'tsslDolg
        '
        Me.tsslDolg.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsslDolg.Name = "tsslDolg"
        Me.tsslDolg.Size = New System.Drawing.Size(18, 19)
        Me.tsslDolg.Text = "..."
        '
        'fin_Invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 695)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "fin_Invoices"
        Me.Text = "Счета к оплате"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgInvoices,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsInvoices.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        CType(Me.nudSettlementPeriod,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudSumma,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsOplInv.ResumeLayout(false)
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgInvoices As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbSelectQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmsInvoices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents dtpBankClient As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkItIsPaid As System.Windows.Forms.CheckBox
    Friend WithEvents ОткрытьФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ПрикрепитьФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents УдалитьСчетToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbFopl As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVisa As System.Windows.Forms.ComboBox
    Friend WithEvents chkPlat As System.Windows.Forms.CheckBox
    Friend WithEvents ОткатитьОплатуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbExp As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPP As System.Windows.Forms.ComboBox
    Friend WithEvents txtNomPP As System.Windows.Forms.TextBox
    Friend WithEvents cmsOplInv As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ПолностьюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nudSettlementPeriod As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslItogo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslOpl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslDolg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOrg As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustForSearh As System.Windows.Forms.TextBox
    Friend WithEvents nudSumma As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNewCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ЭкспортВExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbtnKassa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtDescription As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnApply As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
End Class
