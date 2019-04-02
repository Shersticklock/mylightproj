<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServices))
        Me.tsCompany = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.tlpContact = New System.Windows.Forms.TableLayoutPanel()
        Me.lstSelect = New System.Windows.Forms.ListBox()
        Me.tsOperations = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tscmbDiscont = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtQuantity = New System.Windows.Forms.ToolStripTextBox()
        Me.tstxtQuantity2 = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnUnSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtformCostNumber = New System.Windows.Forms.TextBox()
        Me.txtformPriceNumber = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkWebCalc = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEmploees = New System.Windows.Forms.ComboBox()
        Me.txtweb_caption = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tsCompany.SuspendLayout
        Me.tlpContact.SuspendLayout
        Me.tsOperations.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'tsCompany
        '
        Me.tsCompany.AutoSize = false
        Me.tsCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsCompany.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.tsbtnNew, Me.tsbtnEdit, Me.tsbtnSave, Me.tsbtnCancel, Me.tsbtnDelete, Me.ToolStripSeparator2, Me.tsbtnExit})
        Me.tsCompany.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCompany.Location = New System.Drawing.Point(1115, 0)
        Me.tsCompany.Name = "tsCompany"
        Me.tsCompany.Size = New System.Drawing.Size(161, 666)
        Me.tsCompany.TabIndex = 64
        Me.tsCompany.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripButton1.Text = "Калькулятор"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripButton2.Text = "Установка цен"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(159, 6)
        '
        'tsbtnNew
        '
        Me.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNew.Image = CType(resources.GetObject("tsbtnNew.Image"),System.Drawing.Image)
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(159, 22)
        Me.tsbtnNew.Text = "Создать"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEdit.Image = CType(resources.GetObject("tsbtnEdit.Image"),System.Drawing.Image)
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(159, 22)
        Me.tsbtnEdit.Text = "Изменить"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"),System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(159, 22)
        Me.tsbtnSave.Text = "Сохранить"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(159, 22)
        Me.tsbtnCancel.Text = "Отменить"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelete.Image = CType(resources.GetObject("tsbtnDelete.Image"),System.Drawing.Image)
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(159, 22)
        Me.tsbtnDelete.Text = "Удалить"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(159, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'tlpContact
        '
        Me.tlpContact.ColumnCount = 2
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.85714!))
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.14286!))
        Me.tlpContact.Controls.Add(Me.lstSelect, 1, 9)
        Me.tlpContact.Controls.Add(Me.tsOperations, 0, 9)
        Me.tlpContact.Controls.Add(Me.txtName, 1, 0)
        Me.tlpContact.Controls.Add(Me.txtformCostNumber, 1, 4)
        Me.tlpContact.Controls.Add(Me.txtformPriceNumber, 1, 5)
        Me.tlpContact.Controls.Add(Me.Label22, 0, 4)
        Me.tlpContact.Controls.Add(Me.Label10, 0, 0)
        Me.tlpContact.Controls.Add(Me.Label8, 0, 5)
        Me.tlpContact.Controls.Add(Me.txtdescription, 1, 6)
        Me.tlpContact.Controls.Add(Me.Label7, 0, 6)
        Me.tlpContact.Controls.Add(Me.txtID, 1, 8)
        Me.tlpContact.Controls.Add(Me.Label9, 0, 8)
        Me.tlpContact.Controls.Add(Me.chkWebCalc, 0, 2)
        Me.tlpContact.Controls.Add(Me.Label6, 0, 7)
        Me.tlpContact.Controls.Add(Me.Label3, 0, 3)
        Me.tlpContact.Controls.Add(Me.cmbEmploees, 1, 7)
        Me.tlpContact.Controls.Add(Me.txtweb_caption, 1, 3)
        Me.tlpContact.Controls.Add(Me.chkActive, 0, 1)
        Me.tlpContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpContact.Location = New System.Drawing.Point(451, 6)
        Me.tlpContact.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tlpContact.Name = "tlpContact"
        Me.tlpContact.RowCount = 10
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9!))
        Me.tlpContact.Size = New System.Drawing.Size(659, 654)
        Me.tlpContact.TabIndex = 63
        '
        'lstSelect
        '
        Me.lstSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstSelect.FormattingEnabled = true
        Me.lstSelect.ItemHeight = 17
        Me.lstSelect.Location = New System.Drawing.Point(272, 316)
        Me.lstSelect.Name = "lstSelect"
        Me.lstSelect.Size = New System.Drawing.Size(384, 335)
        Me.lstSelect.TabIndex = 103
        '
        'tsOperations
        '
        Me.tsOperations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsOperations.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsOperations.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.tscmbDiscont, Me.ToolStripLabel1, Me.tstxtQuantity, Me.tstxtQuantity2, Me.tsbtnSelect, Me.tsbtnUnSelect, Me.ToolStripSeparator1})
        Me.tsOperations.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsOperations.Location = New System.Drawing.Point(0, 313)
        Me.tsOperations.Name = "tsOperations"
        Me.tsOperations.Size = New System.Drawing.Size(269, 341)
        Me.tsOperations.TabIndex = 102
        Me.tsOperations.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(267, 20)
        Me.ToolStripLabel3.Text = "Выбрать скидку"
        '
        'tscmbDiscont
        '
        Me.tscmbDiscont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbDiscont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tscmbDiscont.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbDiscont.MaxDropDownItems = 24
        Me.tscmbDiscont.Name = "tscmbDiscont"
        Me.tscmbDiscont.Size = New System.Drawing.Size(265, 26)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(267, 18)
        Me.ToolStripLabel1.Text = "Интервал"
        '
        'tstxtQuantity
        '
        Me.tstxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtQuantity.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtQuantity.Name = "tstxtQuantity"
        Me.tstxtQuantity.Size = New System.Drawing.Size(265, 27)
        Me.tstxtQuantity.Text = "0"
        Me.tstxtQuantity.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tstxtQuantity2
        '
        Me.tstxtQuantity2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtQuantity2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtQuantity2.Name = "tstxtQuantity2"
        Me.tstxtQuantity2.Size = New System.Drawing.Size(265, 27)
        Me.tstxtQuantity2.Text = "1"
        Me.tstxtQuantity2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnSelect
        '
        Me.tsbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSelect.Image = CType(resources.GetObject("tsbtnSelect.Image"),System.Drawing.Image)
        Me.tsbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSelect.Name = "tsbtnSelect"
        Me.tsbtnSelect.Size = New System.Drawing.Size(267, 24)
        Me.tsbtnSelect.Text = "Применить >>>"
        '
        'tsbtnUnSelect
        '
        Me.tsbtnUnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUnSelect.Image = CType(resources.GetObject("tsbtnUnSelect.Image"),System.Drawing.Image)
        Me.tsbtnUnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUnSelect.Name = "tsbtnUnSelect"
        Me.tsbtnUnSelect.Size = New System.Drawing.Size(267, 24)
        Me.tsbtnUnSelect.Text = "Удалить <<<"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(267, 6)
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtName.Location = New System.Drawing.Point(274, 6)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtName.MaxLength = 245
        Me.txtName.Name = "txtName"
        Me.txtName.ShortcutsEnabled = false
        Me.txtName.Size = New System.Drawing.Size(380, 24)
        Me.txtName.TabIndex = 0
        '
        'txtformCostNumber
        '
        Me.txtformCostNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtformCostNumber.CausesValidation = false
        Me.txtformCostNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtformCostNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtformCostNumber.Location = New System.Drawing.Point(274, 138)
        Me.txtformCostNumber.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtformCostNumber.MaxLength = 45
        Me.txtformCostNumber.Name = "txtformCostNumber"
        Me.txtformCostNumber.Size = New System.Drawing.Size(380, 24)
        Me.txtformCostNumber.TabIndex = 3
        '
        'txtformPriceNumber
        '
        Me.txtformPriceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtformPriceNumber.CausesValidation = false
        Me.txtformPriceNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtformPriceNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtformPriceNumber.Location = New System.Drawing.Point(274, 174)
        Me.txtformPriceNumber.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtformPriceNumber.MaxLength = 50
        Me.txtformPriceNumber.Name = "txtformPriceNumber"
        Me.txtformPriceNumber.Size = New System.Drawing.Size(380, 24)
        Me.txtformPriceNumber.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(5, 132)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(259, 36)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Форма калькулятора"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(5, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(259, 36)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Наименование"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(5, 168)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(259, 36)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Форма прайса"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdescription
        '
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtdescription.Location = New System.Drawing.Point(274, 210)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(380, 24)
        Me.txtdescription.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(5, 204)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(259, 36)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Описание/параметр для универсального калькулятора"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtID.Location = New System.Drawing.Point(274, 283)
        Me.txtID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = true
        Me.txtID.Size = New System.Drawing.Size(380, 24)
        Me.txtID.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 277)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(259, 36)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "serviceID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkWebCalc
        '
        Me.chkWebCalc.AutoSize = true
        Me.tlpContact.SetColumnSpan(Me.chkWebCalc, 2)
        Me.chkWebCalc.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkWebCalc.Enabled = false
        Me.chkWebCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkWebCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkWebCalc.Location = New System.Drawing.Point(511, 74)
        Me.chkWebCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.chkWebCalc.Name = "chkWebCalc"
        Me.chkWebCalc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkWebCalc.Size = New System.Drawing.Size(144, 22)
        Me.chkWebCalc.TabIndex = 97
        Me.chkWebCalc.Text = "Веб калькулятор"
        Me.chkWebCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkWebCalc.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 240)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 37)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Куратор"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 32)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Web подпись"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = false
        '
        'cmbEmploees
        '
        Me.cmbEmploees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEmploees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmploees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEmploees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEmploees.FormattingEnabled = true
        Me.cmbEmploees.Location = New System.Drawing.Point(274, 246)
        Me.cmbEmploees.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbEmploees.MaxDropDownItems = 30
        Me.cmbEmploees.Name = "cmbEmploees"
        Me.cmbEmploees.Size = New System.Drawing.Size(380, 25)
        Me.cmbEmploees.TabIndex = 77
        '
        'txtweb_caption
        '
        Me.txtweb_caption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtweb_caption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtweb_caption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtweb_caption.Location = New System.Drawing.Point(273, 104)
        Me.txtweb_caption.Margin = New System.Windows.Forms.Padding(4)
        Me.txtweb_caption.Name = "txtweb_caption"
        Me.txtweb_caption.Size = New System.Drawing.Size(382, 24)
        Me.txtweb_caption.TabIndex = 101
        Me.txtweb_caption.Text = "нет"
        Me.txtweb_caption.Visible = false
        '
        'chkActive
        '
        Me.chkActive.AutoSize = true
        Me.tlpContact.SetColumnSpan(Me.chkActive, 2)
        Me.chkActive.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkActive.Location = New System.Drawing.Point(554, 42)
        Me.chkActive.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkActive.Size = New System.Drawing.Size(100, 22)
        Me.chkActive.TabIndex = 75
        Me.chkActive.Text = "Состояние"
        Me.chkActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActive.UseVisualStyleBackColor = true
        '
        'lstData
        '
        Me.lstData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstData.HorizontalScrollbar = true
        Me.lstData.ItemHeight = 17
        Me.lstData.Location = New System.Drawing.Point(5, 6)
        Me.lstData.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(436, 654)
        Me.lstData.TabIndex = 62
        Me.lstData.TabStop = false
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161!))
        Me.TableLayoutPanel1.Controls.Add(Me.tsCompany, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstData, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpContact, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 666)
        Me.TableLayoutPanel1.TabIndex = 65
        '
        'frmServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 666)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Направления"
        Me.tsCompany.ResumeLayout(false)
        Me.tsCompany.PerformLayout
        Me.tlpContact.ResumeLayout(false)
        Me.tlpContact.PerformLayout
        Me.tsOperations.ResumeLayout(false)
        Me.tsOperations.PerformLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tsCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlpContact As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtformCostNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtformPriceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents cmbEmploees As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkWebCalc As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtweb_caption As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tsOperations As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tscmbDiscont As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtQuantity As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnUnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lstSelect As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstxtQuantity2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
