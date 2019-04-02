<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocOut))
        Me.dtpDocOut = New System.Windows.Forms.DateTimePicker()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.cmsAddDelPos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьПозициюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsAllInvoices = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.НапечататьДокументToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СоздатьНаОснованииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактироватьСоставToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsDelDoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НайтиДокументToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьВсеПозицииВДокументеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыгрузитьВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgDoc = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNewCost = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCreateNaOsn = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnNewWOutOrder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnVIntervale = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnClosedPeriod = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSSS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clbDocTypes = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDate2 = New System.Windows.Forms.DateTimePicker()
        Me.txtKA_find = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbGruzPol = New System.Windows.Forms.ComboBox()
        Me.txtGrounds = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAddressee = New System.Windows.Forms.ComboBox()
        Me.cmbOrganization = New System.Windows.Forms.ComboBox()
        Me.cmb_KA = New System.Windows.Forms.ComboBox()
        Me.cmsNewUrLico = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьЮрЛицоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsEditOrg = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.РедактироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбновитьСписокToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgAllInvoices = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgHistory = New System.Windows.Forms.DataGridView()
        Me.btnRefreshHistory = New System.Windows.Forms.Button()
        Me.cmsAddDelPos.SuspendLayout
        Me.cmsAllInvoices.SuspendLayout
        CType(Me.dgDoc,System.ComponentModel.ISupportInitialize).BeginInit
        Me.StatusStrip1.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.cmsNewUrLico.SuspendLayout
        Me.cmsEditOrg.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.dgAllInvoices,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        CType(Me.dgHistory,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dtpDocOut
        '
        Me.dtpDocOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDocOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDocOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocOut.Location = New System.Drawing.Point(176, 132)
        Me.dtpDocOut.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpDocOut.Name = "dtpDocOut"
        Me.dtpDocOut.Size = New System.Drawing.Size(280, 26)
        Me.dtpDocOut.TabIndex = 2
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = true
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = true
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"),System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = false
        '
        'cmsAddDelPos
        '
        Me.cmsAddDelPos.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsAddDelPos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsAddDelPos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьПозициюToolStripMenuItem, Me.УдалитьToolStripMenuItem})
        Me.cmsAddDelPos.Name = "ContextMenuStrip1"
        Me.cmsAddDelPos.Size = New System.Drawing.Size(207, 48)
        '
        'ДобавитьПозициюToolStripMenuItem
        '
        Me.ДобавитьПозициюToolStripMenuItem.Name = "ДобавитьПозициюToolStripMenuItem"
        Me.ДобавитьПозициюToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ДобавитьПозициюToolStripMenuItem.Text = "Добавить позицию"
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.УдалитьToolStripMenuItem.Text = "Удалить позицию"
        '
        'cmsAllInvoices
        '
        Me.cmsAllInvoices.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsAllInvoices.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsAllInvoices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НапечататьДокументToolStripMenuItem, Me.СоздатьНаОснованииToolStripMenuItem, Me.РедактироватьСоставToolStripMenuItem, Me.tsDelDoc, Me.ПерейтиКЗаказуToolStripMenuItem, Me.НайтиДокументToolStripMenuItem, Me.УдалитьВсеПозицииВДокументеToolStripMenuItem, Me.ВыгрузитьВExcelToolStripMenuItem})
        Me.cmsAllInvoices.Name = "ContextMenuStrip2"
        Me.cmsAllInvoices.Size = New System.Drawing.Size(250, 180)
        '
        'НапечататьДокументToolStripMenuItem
        '
        Me.НапечататьДокументToolStripMenuItem.Name = "НапечататьДокументToolStripMenuItem"
        Me.НапечататьДокументToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.НапечататьДокументToolStripMenuItem.Text = "Сформировать документ"
        '
        'СоздатьНаОснованииToolStripMenuItem
        '
        Me.СоздатьНаОснованииToolStripMenuItem.Name = "СоздатьНаОснованииToolStripMenuItem"
        Me.СоздатьНаОснованииToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.СоздатьНаОснованииToolStripMenuItem.Text = "Создать на основании"
        '
        'РедактироватьСоставToolStripMenuItem
        '
        Me.РедактироватьСоставToolStripMenuItem.Name = "РедактироватьСоставToolStripMenuItem"
        Me.РедактироватьСоставToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.РедактироватьСоставToolStripMenuItem.Text = "Редактировать состав"
        '
        'tsDelDoc
        '
        Me.tsDelDoc.Name = "tsDelDoc"
        Me.tsDelDoc.Size = New System.Drawing.Size(249, 22)
        Me.tsDelDoc.Text = "Удалить документ"
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'НайтиДокументToolStripMenuItem
        '
        Me.НайтиДокументToolStripMenuItem.Name = "НайтиДокументToolStripMenuItem"
        Me.НайтиДокументToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.НайтиДокументToolStripMenuItem.Text = "Найти документ"
        '
        'УдалитьВсеПозицииВДокументеToolStripMenuItem
        '
        Me.УдалитьВсеПозицииВДокументеToolStripMenuItem.Name = "УдалитьВсеПозицииВДокументеToolStripMenuItem"
        Me.УдалитьВсеПозицииВДокументеToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.УдалитьВсеПозицииВДокументеToolStripMenuItem.Text = "Удалить все позиции"
        '
        'ВыгрузитьВExcelToolStripMenuItem
        '
        Me.ВыгрузитьВExcelToolStripMenuItem.Name = "ВыгрузитьВExcelToolStripMenuItem"
        Me.ВыгрузитьВExcelToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ВыгрузитьВExcelToolStripMenuItem.Text = "Выгрузить в Excel"
        '
        'dgDoc
        '
        Me.dgDoc.AllowUserToAddRows = false
        Me.dgDoc.AllowUserToDeleteRows = false
        Me.dgDoc.AllowUserToResizeRows = false
        Me.dgDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDoc.ContextMenuStrip = Me.cmsAddDelPos
        Me.dgDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDoc.Location = New System.Drawing.Point(0, 0)
        Me.dgDoc.Margin = New System.Windows.Forms.Padding(5)
        Me.dgDoc.MultiSelect = false
        Me.dgDoc.Name = "dgDoc"
        Me.dgDoc.ReadOnly = true
        Me.dgDoc.RowTemplate.Height = 24
        Me.dgDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDoc.Size = New System.Drawing.Size(1260, 212)
        Me.dgDoc.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 212)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 24, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1260, 22)
        Me.StatusStrip1.SizingGrip = false
        Me.StatusStrip1.TabIndex = 100
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(141, 19)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNewCost, Me.tsbtnCreateNaOsn, Me.tsbtnNewWOutOrder, Me.ToolStripSeparator1, Me.tsbtnVIntervale, Me.tsbtnClosedPeriod, Me.tsbtnSSS, Me.ToolStripSeparator2, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(1082, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(172, 271)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnNewCost
        '
        Me.tsbtnNewCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewCost.Image = CType(resources.GetObject("tsbtnNewCost.Image"),System.Drawing.Image)
        Me.tsbtnNewCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewCost.Name = "tsbtnNewCost"
        Me.tsbtnNewCost.Size = New System.Drawing.Size(170, 24)
        Me.tsbtnNewCost.Text = "Создать новый"
        '
        'tsbtnCreateNaOsn
        '
        Me.tsbtnCreateNaOsn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCreateNaOsn.Image = CType(resources.GetObject("tsbtnCreateNaOsn.Image"),System.Drawing.Image)
        Me.tsbtnCreateNaOsn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCreateNaOsn.Name = "tsbtnCreateNaOsn"
        Me.tsbtnCreateNaOsn.Size = New System.Drawing.Size(170, 24)
        Me.tsbtnCreateNaOsn.Text = "Создать на основании"
        '
        'tsbtnNewWOutOrder
        '
        Me.tsbtnNewWOutOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewWOutOrder.Image = CType(resources.GetObject("tsbtnNewWOutOrder.Image"),System.Drawing.Image)
        Me.tsbtnNewWOutOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewWOutOrder.Name = "tsbtnNewWOutOrder"
        Me.tsbtnNewWOutOrder.Size = New System.Drawing.Size(170, 24)
        Me.tsbtnNewWOutOrder.Text = "Создать без заказа"
        Me.tsbtnNewWOutOrder.Visible = false
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'tsbtnVIntervale
        '
        Me.tsbtnVIntervale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnVIntervale.Image = CType(resources.GetObject("tsbtnVIntervale.Image"),System.Drawing.Image)
        Me.tsbtnVIntervale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnVIntervale.Name = "tsbtnVIntervale"
        Me.tsbtnVIntervale.Size = New System.Drawing.Size(170, 24)
        Me.tsbtnVIntervale.Text = "Найти"
        Me.tsbtnVIntervale.Visible = false
        '
        'tsbtnClosedPeriod
        '
        Me.tsbtnClosedPeriod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnClosedPeriod.Image = CType(resources.GetObject("tsbtnClosedPeriod.Image"),System.Drawing.Image)
        Me.tsbtnClosedPeriod.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnClosedPeriod.Name = "tsbtnClosedPeriod"
        Me.tsbtnClosedPeriod.Size = New System.Drawing.Size(170, 24)
        Me.tsbtnClosedPeriod.Text = "Закрыть период"
        Me.tsbtnClosedPeriod.Visible = false
        '
        'tsbtnSSS
        '
        Me.tsbtnSSS.CheckOnClick = true
        Me.tsbtnSSS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSSS.Image = CType(resources.GetObject("tsbtnSSS.Image"),System.Drawing.Image)
        Me.tsbtnSSS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSSS.Name = "tsbtnSSS"
        Me.tsbtnSSS.Size = New System.Drawing.Size(170, 24)
        Me.tsbtnSSS.Text = "Старт/стоп"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(170, 24)
        Me.tsbtnExit.Text = "Выход"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(161, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Покупатель"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'clbDocTypes
        '
        Me.clbDocTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbDocTypes.CheckOnClick = true
        Me.clbDocTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbDocTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbDocTypes.FormattingEnabled = true
        Me.clbDocTypes.Location = New System.Drawing.Point(4, 4)
        Me.clbDocTypes.Margin = New System.Windows.Forms.Padding(4)
        Me.clbDocTypes.Name = "clbDocTypes"
        Me.clbDocTypes.Size = New System.Drawing.Size(316, 263)
        Me.clbDocTypes.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Поставщик"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Дата документа"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDate2
        '
        Me.dtpDate2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate2.Location = New System.Drawing.Point(466, 132)
        Me.dtpDate2.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(281, 26)
        Me.dtpDate2.TabIndex = 4
        Me.dtpDate2.Visible = false
        '
        'txtKA_find
        '
        Me.txtKA_find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKA_find.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKA_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtKA_find.Location = New System.Drawing.Point(5, 5)
        Me.txtKA_find.Margin = New System.Windows.Forms.Padding(5)
        Me.txtKA_find.Name = "txtKA_find"
        Me.txtKA_find.Size = New System.Drawing.Size(161, 24)
        Me.txtKA_find.TabIndex = 7
        Me.txtKA_find.Visible = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Грузополучатель"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGruzPol
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.cmbGruzPol, 2)
        Me.cmbGruzPol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbGruzPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGruzPol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbGruzPol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbGruzPol.FormattingEnabled = true
        Me.cmbGruzPol.Location = New System.Drawing.Point(174, 68)
        Me.cmbGruzPol.Name = "cmbGruzPol"
        Me.cmbGruzPol.Size = New System.Drawing.Size(575, 25)
        Me.cmbGruzPol.TabIndex = 10
        '
        'txtGrounds
        '
        Me.txtGrounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtGrounds, 2)
        Me.txtGrounds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtGrounds.Location = New System.Drawing.Point(174, 166)
        Me.txtGrounds.Name = "txtGrounds"
        Me.txtGrounds.Size = New System.Drawing.Size(575, 24)
        Me.txtGrounds.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 30)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Основание"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbAddressee
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.cmbAddressee, 2)
        Me.cmbAddressee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAddressee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAddressee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbAddressee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbAddressee.FormattingEnabled = true
        Me.cmbAddressee.Location = New System.Drawing.Point(174, 99)
        Me.cmbAddressee.Name = "cmbAddressee"
        Me.cmbAddressee.Size = New System.Drawing.Size(575, 25)
        Me.cmbAddressee.TabIndex = 13
        '
        'cmbOrganization
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.cmbOrganization, 2)
        Me.cmbOrganization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOrganization.FormattingEnabled = true
        Me.cmbOrganization.Location = New System.Drawing.Point(174, 37)
        Me.cmbOrganization.Name = "cmbOrganization"
        Me.cmbOrganization.Size = New System.Drawing.Size(575, 25)
        Me.cmbOrganization.TabIndex = 14
        '
        'cmb_KA
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.cmb_KA, 2)
        Me.cmb_KA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_KA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_KA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_KA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmb_KA.FormattingEnabled = true
        Me.cmb_KA.Location = New System.Drawing.Point(174, 3)
        Me.cmb_KA.Name = "cmb_KA"
        Me.cmb_KA.Size = New System.Drawing.Size(575, 25)
        Me.cmb_KA.TabIndex = 15
        Me.cmb_KA.Visible = false
        '
        'cmsNewUrLico
        '
        Me.cmsNewUrLico.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsNewUrLico.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsNewUrLico.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьЮрЛицоToolStripMenuItem})
        Me.cmsNewUrLico.Name = "cmsNewUrLico"
        Me.cmsNewUrLico.Size = New System.Drawing.Size(291, 28)
        '
        'ДобавитьЮрЛицоToolStripMenuItem
        '
        Me.ДобавитьЮрЛицоToolStripMenuItem.Name = "ДобавитьЮрЛицоToolStripMenuItem"
        Me.ДобавитьЮрЛицоToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.ДобавитьЮрЛицоToolStripMenuItem.Text = "Справочник юридических лиц"
        '
        'cmsEditOrg
        '
        Me.cmsEditOrg.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsEditOrg.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsEditOrg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РедактироватьToolStripMenuItem, Me.ОбновитьСписокToolStripMenuItem})
        Me.cmsEditOrg.Name = "cmsEditOrg"
        Me.cmsEditOrg.Size = New System.Drawing.Size(194, 48)
        '
        'РедактироватьToolStripMenuItem
        '
        Me.РедактироватьToolStripMenuItem.Name = "РедактироватьToolStripMenuItem"
        Me.РедактироватьToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.РедактироватьToolStripMenuItem.Text = "Редактировать"
        '
        'ОбновитьСписокToolStripMenuItem
        '
        Me.ОбновитьСписокToolStripMenuItem.Name = "ОбновитьСписокToolStripMenuItem"
        Me.ОбновитьСписокToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ОбновитьСписокToolStripMenuItem.Text = "Обновить список"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgDoc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1262, 664)
        Me.SplitContainer1.SplitterDistance = 422
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgAllInvoices, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1260, 420)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'dgAllInvoices
        '
        Me.dgAllInvoices.AllowUserToAddRows = false
        Me.dgAllInvoices.AllowUserToDeleteRows = false
        Me.dgAllInvoices.AllowUserToResizeRows = false
        Me.dgAllInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAllInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAllInvoices.ContextMenuStrip = Me.cmsAllInvoices
        Me.dgAllInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAllInvoices.Location = New System.Drawing.Point(5, 276)
        Me.dgAllInvoices.Margin = New System.Windows.Forms.Padding(5)
        Me.dgAllInvoices.MultiSelect = false
        Me.dgAllInvoices.Name = "dgAllInvoices"
        Me.dgAllInvoices.ReadOnly = true
        Me.dgAllInvoices.RowTemplate.Height = 24
        Me.dgAllInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAllInvoices.Size = New System.Drawing.Size(1250, 139)
        Me.dgAllInvoices.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.clbDocTypes, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1254, 265)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = true
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.Controls.Add(Me.cmbOrganization, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpDocOut, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbGruzPol, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbAddressee, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpDate2, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.txtGrounds, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.txtKA_find, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmb_KA, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(327, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(752, 193)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1276, 700)
        Me.TabControl1.TabIndex = 101
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1268, 670)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Создание документов"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgHistory)
        Me.TabPage2.Controls.Add(Me.btnRefreshHistory)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1268, 670)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "История"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'dgHistory
        '
        Me.dgHistory.AllowUserToAddRows = false
        Me.dgHistory.AllowUserToDeleteRows = false
        Me.dgHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHistory.Location = New System.Drawing.Point(8, 6)
        Me.dgHistory.Name = "dgHistory"
        Me.dgHistory.MultiSelect = false
        Me.dgHistory.ReadOnly = true
        Me.dgHistory.RowTemplate.Height = 24
        Me.dgHistory.Size = New System.Drawing.Size(1252, 605)
        Me.dgHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgHistory.TabIndex = 0
        '
        'btnRefreshHistory
        '
        Me.btnRefreshHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRefreshHistory.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRefreshHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnRefreshHistory.Location = New System.Drawing.Point(1046, 627)
        Me.btnRefreshHistory.Name = "btnRefreshHistory"
        Me.btnRefreshHistory.Size = New System.Drawing.Size(214, 35)
        Me.btnRefreshHistory.TabIndex = 1
        Me.btnRefreshHistory.Text = "Обновить историю"
        Me.btnRefreshHistory.UseVisualStyleBackColor = false
        '
        'frmDocOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 700)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.HelpButton = true
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "")
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmDocOut"
        Me.HelpProvider1.SetShowHelp(Me, true)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Документы"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmsAddDelPos.ResumeLayout(false)
        Me.cmsAllInvoices.ResumeLayout(false)
        CType(Me.dgDoc,System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.cmsNewUrLico.ResumeLayout(false)
        Me.cmsEditOrg.ResumeLayout(false)
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        CType(Me.dgAllInvoices,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage2.ResumeLayout(false)
        CType(Me.dgHistory,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents dtpDocOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cmsAddDelPos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьПозициюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsAllInvoices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgDoc As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tsDelDoc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents НапечататьДокументToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СоздатьНаОснованииToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РедактироватьСоставToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsEditOrg As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents РедактироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОбновитьСписокToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtKA_find As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents НайтиДокументToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьВсеПозицииВДокументеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыгрузитьВExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsNewUrLico As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьЮрЛицоToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clbDocTypes As System.Windows.Forms.CheckedListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNewCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCreateNaOsn As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnNewWOutOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnVIntervale As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnClosedPeriod As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbGruzPol As System.Windows.Forms.ComboBox
    Friend WithEvents txtGrounds As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAddressee As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOrganization As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_KA As System.Windows.Forms.ComboBox
    Friend WithEvents dgAllInvoices As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tsbtnSSS As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgHistory As DataGridView
    Friend WithEvents btnRefreshHistory As Button
End Class
