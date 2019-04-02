<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_InvoiceCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_InvoiceCard))
        Me.cmbKAgent = New System.Windows.Forms.ComboBox()
        Me.cmsAddOrganization = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьЮрлицоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbTypeCompany = New System.Windows.Forms.ComboBox()
        Me.cmsSuplayer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьПоставщикаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudAccount = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpdateInvoice = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbPayers = New System.Windows.Forms.ComboBox()
        Me.lblPayer = New System.Windows.Forms.Label()
        Me.btnAddFile = New System.Windows.Forms.Button()
        Me.lblDatePlanPay = New System.Windows.Forms.Label()
        Me.dtpDatePlanPay = New System.Windows.Forms.DateTimePicker()
        Me.cmbPrognoz = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDescription = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTypeInvoice = New System.Windows.Forms.ComboBox()
        Me.cmbOrganizations = New System.Windows.Forms.ComboBox()
        Me.txtnumberInvoice = New System.Windows.Forms.TextBox()
        Me.cmbFopl = New System.Windows.Forms.ComboBox()
        Me.lblFopl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNDS1 = New System.Windows.Forms.Label()
        Me.LabelNDS2 = New System.Windows.Forms.Label()
        Me.nudNDSsumma = New System.Windows.Forms.NumericUpDown()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtFindKA = New System.Windows.Forms.TextBox()
        Me.txtFIle = New System.Windows.Forms.TextBox()
        Me.cmbStavkaNDS = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmsAddOrganization.SuspendLayout
        Me.cmsSuplayer.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudAccount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudNDSsumma,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'cmbKAgent
        '
        Me.cmbKAgent.ContextMenuStrip = Me.cmsAddOrganization
        Me.cmbKAgent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbKAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKAgent.DropDownWidth = 350
        Me.cmbKAgent.Enabled = false
        Me.cmbKAgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbKAgent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbKAgent.FormattingEnabled = true
        Me.cmbKAgent.Location = New System.Drawing.Point(330, 80)
        Me.cmbKAgent.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbKAgent.MaxDropDownItems = 24
        Me.cmbKAgent.Name = "cmbKAgent"
        Me.cmbKAgent.Size = New System.Drawing.Size(620, 25)
        Me.cmbKAgent.TabIndex = 1
        '
        'cmsAddOrganization
        '
        Me.cmsAddOrganization.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsAddOrganization.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsAddOrganization.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьЮрлицоToolStripMenuItem})
        Me.cmsAddOrganization.Name = "cmsAddOrganization"
        Me.cmsAddOrganization.Size = New System.Drawing.Size(209, 28)
        '
        'ДобавитьЮрлицоToolStripMenuItem
        '
        Me.ДобавитьЮрлицоToolStripMenuItem.Name = "ДобавитьЮрлицоToolStripMenuItem"
        Me.ДобавитьЮрлицоToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.ДобавитьЮрлицоToolStripMenuItem.Text = "Добавить юр.лицо"
        '
        'cmbTypeCompany
        '
        Me.cmbTypeCompany.ContextMenuStrip = Me.cmsSuplayer
        Me.cmbTypeCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTypeCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypeCompany.FormattingEnabled = true
        Me.cmbTypeCompany.Location = New System.Drawing.Point(330, 43)
        Me.cmbTypeCompany.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbTypeCompany.Name = "cmbTypeCompany"
        Me.cmbTypeCompany.Size = New System.Drawing.Size(620, 25)
        Me.cmbTypeCompany.TabIndex = 0
        '
        'cmsSuplayer
        '
        Me.cmsSuplayer.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsSuplayer.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsSuplayer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьПоставщикаToolStripMenuItem})
        Me.cmsSuplayer.Name = "cmsSuplayer"
        Me.cmsSuplayer.Size = New System.Drawing.Size(233, 28)
        '
        'ДобавитьПоставщикаToolStripMenuItem
        '
        Me.ДобавитьПоставщикаToolStripMenuItem.Name = "ДобавитьПоставщикаToolStripMenuItem"
        Me.ДобавитьПоставщикаToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.ДобавитьПоставщикаToolStripMenuItem.Text = "Добавить поставщика"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204!))
        Me.TableLayoutPanel1.Controls.Add(Me.nudAccount, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbKAgent, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpdateInvoice, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPayers, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPayer, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddFile, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDatePlanPay, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDatePlanPay, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPrognoz, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbDescription, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTypeInvoice, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbOrganizations, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtnumberInvoice, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFopl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFopl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTypeCompany, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelNDS1, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelNDS2, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.nudNDSsumma, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFindKA, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFIle, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbStavkaNDS, 1, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1159, 577)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'nudAccount
        '
        Me.nudAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudAccount.DecimalPlaces = 2
        Me.nudAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudAccount.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAccount.Location = New System.Drawing.Point(330, 228)
        Me.nudAccount.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudAccount.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudAccount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAccount.Name = "nudAccount"
        Me.nudAccount.Size = New System.Drawing.Size(620, 24)
        Me.nudAccount.TabIndex = 10
        Me.nudAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudAccount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(315, 36)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Сумма (руб.)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 319)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 31)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Примечания"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpdateInvoice
        '
        Me.dtpdateInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpdateInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpdateInvoice.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateInvoice.Location = New System.Drawing.Point(330, 192)
        Me.dtpdateInvoice.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpdateInvoice.Name = "dtpdateInvoice"
        Me.dtpdateInvoice.Size = New System.Drawing.Size(620, 24)
        Me.dtpdateInvoice.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 186)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(315, 36)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Дата счета"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPayers
        '
        Me.cmbPayers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPayers.FormattingEnabled = true
        Me.cmbPayers.Location = New System.Drawing.Point(329, 353)
        Me.cmbPayers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbPayers.Name = "cmbPayers"
        Me.cmbPayers.Size = New System.Drawing.Size(622, 25)
        Me.cmbPayers.TabIndex = 45
        Me.cmbPayers.Visible = false
        '
        'lblPayer
        '
        Me.lblPayer.AutoSize = true
        Me.lblPayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblPayer.Location = New System.Drawing.Point(4, 350)
        Me.lblPayer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPayer.Name = "lblPayer"
        Me.lblPayer.Size = New System.Drawing.Size(317, 31)
        Me.lblPayer.TabIndex = 46
        Me.lblPayer.Text = "Плательщик"
        Me.lblPayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPayer.Visible = false
        '
        'btnAddFile
        '
        Me.btnAddFile.AutoSize = true
        Me.btnAddFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnAddFile.Location = New System.Drawing.Point(329, 445)
        Me.btnAddFile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(622, 129)
        Me.btnAddFile.TabIndex = 47
        Me.btnAddFile.Text = "Приложить файл"
        Me.btnAddFile.UseVisualStyleBackColor = true
        '
        'lblDatePlanPay
        '
        Me.lblDatePlanPay.AutoSize = true
        Me.lblDatePlanPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDatePlanPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDatePlanPay.Location = New System.Drawing.Point(4, 412)
        Me.lblDatePlanPay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatePlanPay.Name = "lblDatePlanPay"
        Me.lblDatePlanPay.Size = New System.Drawing.Size(317, 30)
        Me.lblDatePlanPay.TabIndex = 49
        Me.lblDatePlanPay.Text = "Плановая дата оплаты"
        Me.lblDatePlanPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDatePlanPay.Visible = false
        '
        'dtpDatePlanPay
        '
        Me.dtpDatePlanPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDatePlanPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDatePlanPay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePlanPay.Location = New System.Drawing.Point(329, 415)
        Me.dtpDatePlanPay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpDatePlanPay.Name = "dtpDatePlanPay"
        Me.dtpDatePlanPay.Size = New System.Drawing.Size(622, 24)
        Me.dtpDatePlanPay.TabIndex = 50
        Me.dtpDatePlanPay.Visible = false
        '
        'cmbPrognoz
        '
        Me.cmbPrognoz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPrognoz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrognoz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPrognoz.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPrognoz.FormattingEnabled = true
        Me.cmbPrognoz.Location = New System.Drawing.Point(329, 384)
        Me.cmbPrognoz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbPrognoz.Name = "cmbPrognoz"
        Me.cmbPrognoz.Size = New System.Drawing.Size(622, 25)
        Me.cmbPrognoz.TabIndex = 51
        Me.cmbPrognoz.Visible = false
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 381)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(317, 31)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Прогноз"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = false
        '
        'cmbDescription
        '
        Me.cmbDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDescription.FormattingEnabled = true
        Me.cmbDescription.Items.AddRange(New Object() {"Доставка", "Полное изготовление", "Доработка макета", "Офсетная печать", "Материал", "Постпечатная обработка"})
        Me.cmbDescription.Location = New System.Drawing.Point(329, 322)
        Me.cmbDescription.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbDescription.Name = "cmbDescription"
        Me.cmbDescription.Size = New System.Drawing.Size(622, 25)
        Me.cmbDescription.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 37)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Организация (юридическое лицо)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTypeInvoice
        '
        Me.cmbTypeInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTypeInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypeInvoice.FormattingEnabled = true
        Me.cmbTypeInvoice.Location = New System.Drawing.Point(5, 117)
        Me.cmbTypeInvoice.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbTypeInvoice.Name = "cmbTypeInvoice"
        Me.cmbTypeInvoice.Size = New System.Drawing.Size(315, 25)
        Me.cmbTypeInvoice.TabIndex = 44
        '
        'cmbOrganizations
        '
        Me.cmbOrganizations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrganizations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrganizations.DropDownWidth = 400
        Me.cmbOrganizations.Enabled = false
        Me.cmbOrganizations.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOrganizations.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOrganizations.FormattingEnabled = true
        Me.cmbOrganizations.Location = New System.Drawing.Point(330, 155)
        Me.cmbOrganizations.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbOrganizations.Name = "cmbOrganizations"
        Me.cmbOrganizations.Size = New System.Drawing.Size(620, 25)
        Me.cmbOrganizations.TabIndex = 2
        '
        'txtnumberInvoice
        '
        Me.txtnumberInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumberInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtnumberInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtnumberInvoice.Location = New System.Drawing.Point(330, 117)
        Me.txtnumberInvoice.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtnumberInvoice.Name = "txtnumberInvoice"
        Me.txtnumberInvoice.Size = New System.Drawing.Size(620, 26)
        Me.txtnumberInvoice.TabIndex = 3
        Me.txtnumberInvoice.Visible = false
        '
        'cmbFopl
        '
        Me.cmbFopl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFopl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFopl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbFopl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbFopl.FormattingEnabled = true
        Me.cmbFopl.Location = New System.Drawing.Point(330, 6)
        Me.cmbFopl.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbFopl.Name = "cmbFopl"
        Me.cmbFopl.Size = New System.Drawing.Size(620, 25)
        Me.cmbFopl.TabIndex = 43
        '
        'lblFopl
        '
        Me.lblFopl.AutoSize = true
        Me.lblFopl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFopl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblFopl.ForeColor = System.Drawing.Color.Red
        Me.lblFopl.Location = New System.Drawing.Point(5, 0)
        Me.lblFopl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFopl.Name = "lblFopl"
        Me.lblFopl.Size = New System.Drawing.Size(315, 37)
        Me.lblFopl.TabIndex = 42
        Me.lblFopl.Text = "Форма оплаты"
        Me.lblFopl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(5, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Тип контрагента"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelNDS1
        '
        Me.LabelNDS1.AutoSize = true
        Me.LabelNDS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNDS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.LabelNDS1.Location = New System.Drawing.Point(3, 258)
        Me.LabelNDS1.Name = "LabelNDS1"
        Me.LabelNDS1.Size = New System.Drawing.Size(319, 31)
        Me.LabelNDS1.TabIndex = 55
        Me.LabelNDS1.Text = "Ставка НДС, (%)"
        Me.LabelNDS1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelNDS1.Visible = false
        '
        'LabelNDS2
        '
        Me.LabelNDS2.AutoSize = true
        Me.LabelNDS2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNDS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.LabelNDS2.Location = New System.Drawing.Point(3, 289)
        Me.LabelNDS2.Name = "LabelNDS2"
        Me.LabelNDS2.Size = New System.Drawing.Size(319, 30)
        Me.LabelNDS2.TabIndex = 56
        Me.LabelNDS2.Text = "Сумма НДС, (руб.)"
        Me.LabelNDS2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelNDS2.Visible = false
        '
        'nudNDSsumma
        '
        Me.nudNDSsumma.DecimalPlaces = 2
        Me.nudNDSsumma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudNDSsumma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudNDSsumma.Location = New System.Drawing.Point(328, 292)
        Me.nudNDSsumma.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudNDSsumma.Name = "nudNDSsumma"
        Me.nudNDSsumma.Size = New System.Drawing.Size(624, 24)
        Me.nudNDSsumma.TabIndex = 58
        Me.nudNDSsumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudNDSsumma.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOK, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(955, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.TableLayoutPanel1.SetRowSpan(Me.ToolStrip1, 14)
        Me.ToolStrip1.Size = New System.Drawing.Size(204, 577)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(202, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(202, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'txtFindKA
        '
        Me.txtFindKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFindKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFindKA.Location = New System.Drawing.Point(3, 77)
        Me.txtFindKA.MaxLength = 10
        Me.txtFindKA.Name = "txtFindKA"
        Me.txtFindKA.Size = New System.Drawing.Size(319, 26)
        Me.txtFindKA.TabIndex = 59
        '
        'txtFIle
        '
        Me.txtFIle.BackColor = System.Drawing.SystemColors.Control
        Me.txtFIle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFIle.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFIle.Location = New System.Drawing.Point(3, 445)
        Me.txtFIle.Name = "txtFIle"
        Me.txtFIle.Size = New System.Drawing.Size(319, 15)
        Me.txtFIle.TabIndex = 60
        '
        'cmbStavkaNDS
        '
        Me.cmbStavkaNDS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStavkaNDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStavkaNDS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbStavkaNDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbStavkaNDS.FormattingEnabled = true
        Me.cmbStavkaNDS.Items.AddRange(New Object() {"без НДС", "0", "10", "18"})
        Me.cmbStavkaNDS.Location = New System.Drawing.Point(328, 261)
        Me.cmbStavkaNDS.Name = "cmbStavkaNDS"
        Me.cmbStavkaNDS.Size = New System.Drawing.Size(624, 25)
        Me.cmbStavkaNDS.TabIndex = 61
        Me.cmbStavkaNDS.Visible = false
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'fin_InvoiceCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1159, 577)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = false
        Me.MinimumSize = New System.Drawing.Size(782, 304)
        Me.Name = "fin_InvoiceCard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Счет на оплату"
        Me.cmsAddOrganization.ResumeLayout(false)
        Me.cmsSuplayer.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudAccount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudNDSsumma,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmbKAgent As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTypeCompany As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbOrganizations As System.Windows.Forms.ComboBox
    Friend WithEvents txtnumberInvoice As System.Windows.Forms.TextBox
    Friend WithEvents dtpdateInvoice As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents nudAccount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFopl As System.Windows.Forms.Label
    Friend WithEvents cmbFopl As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTypeInvoice As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayers As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayer As System.Windows.Forms.Label
    Friend WithEvents btnAddFile As System.Windows.Forms.Button
    Friend WithEvents cmsSuplayer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьПоставщикаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDatePlanPay As System.Windows.Forms.Label
    Friend WithEvents dtpDatePlanPay As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPrognoz As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbDescription As System.Windows.Forms.ComboBox
    Friend WithEvents cmsAddOrganization As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьЮрлицоToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LabelNDS1 As System.Windows.Forms.Label
    Friend WithEvents LabelNDS2 As System.Windows.Forms.Label
    Friend WithEvents nudNDSsumma As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtFindKA As System.Windows.Forms.TextBox
    Friend WithEvents txtFIle As System.Windows.Forms.TextBox
    Friend WithEvents cmbStavkaNDS As System.Windows.Forms.ComboBox
End Class
