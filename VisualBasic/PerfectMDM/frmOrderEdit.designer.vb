<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderEdit))
        Me.cmsNewPerson = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.СоздатьПредставителяToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.txtFindCustomer = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOk = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbIssuePlace = New System.Windows.Forms.ComboBox()
        Me.lblIssuePlace = New System.Windows.Forms.Label()
        Me.lblDateOfLayoutReady = New System.Windows.Forms.Label()
        Me.lblManager = New System.Windows.Forms.Label()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.lblDateOfIssue = New System.Windows.Forms.Label()
        Me.lblContactPerson = New System.Windows.Forms.Label()
        Me.lblCommentForIssue = New System.Windows.Forms.Label()
        Me.cmbContactPerson = New System.Windows.Forms.ComboBox()
        Me.lblDateOfProductionReady = New System.Windows.Forms.Label()
        Me.cmbOurOrganization = New System.Windows.Forms.ComboBox()
        Me.lblOurOrganization = New System.Windows.Forms.Label()
        Me.dtpDateOfIssue = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateOfProductionReady = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateOfLayoutReady = New System.Windows.Forms.DateTimePicker()
        Me.cmbCommentForIssue = New System.Windows.Forms.ComboBox()
        Me.cmbCostType = New System.Windows.Forms.ComboBox()
        Me.lblCostType = New System.Windows.Forms.Label()
        Me.lblCustomerPerson = New System.Windows.Forms.Label()
        Me.cmbCustomerPerson = New System.Windows.Forms.ComboBox()
        Me.cmsNewOrganization = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.СоздатьЮрЛицоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbOrderSource = New System.Windows.Forms.ComboBox()
        Me.lblOrderSource = New System.Windows.Forms.Label()
        Me.chkExpressOrder = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAdditionalNumber = New System.Windows.Forms.Label()
        Me.txtAdditionalNumber = New System.Windows.Forms.TextBox()
        Me.cmsNewPerson.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.cmsNewOrganization.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'cmsNewPerson
        '
        Me.cmsNewPerson.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsNewPerson.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsNewPerson.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздатьПредставителяToolStripMenuItem})
        Me.cmsNewPerson.Name = "cmsNewPerson"
        Me.cmsNewPerson.Size = New System.Drawing.Size(217, 26)
        '
        'СоздатьПредставителяToolStripMenuItem
        '
        Me.СоздатьПредставителяToolStripMenuItem.Name = "СоздатьПредставителяToolStripMenuItem"
        Me.СоздатьПредставителяToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.СоздатьПредставителяToolStripMenuItem.Text = "Создать представителя"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustomer.FormattingEnabled = true
        Me.cmbCustomer.Location = New System.Drawing.Point(273, 202)
        Me.cmbCustomer.MaxDropDownItems = 25
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(361, 25)
        Me.cmbCustomer.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.cmbCustomer, "Начни вводить название заказчика")
        '
        'txtFindCustomer
        '
        Me.txtFindCustomer.BackColor = System.Drawing.SystemColors.Info
        Me.txtFindCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFindCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFindCustomer.Location = New System.Drawing.Point(3, 202)
        Me.txtFindCustomer.Name = "txtFindCustomer"
        Me.txtFindCustomer.Size = New System.Drawing.Size(264, 24)
        Me.txtFindCustomer.TabIndex = 47
        Me.txtFindCustomer.Text = "Заказчик"
        Me.ToolTip1.SetToolTip(Me.txtFindCustomer, "Введи фрогмент наименования и нажми ввод")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOk, Me.ToolStripSeparator1, Me.ToolStripButton3})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(643, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(160, 472)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnOk
        '
        Me.tsbtnOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOk.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOk.Image = CType(resources.GetObject("tsbtnOk.Image"),System.Drawing.Image)
        Me.tsbtnOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOk.Name = "tsbtnOk"
        Me.tsbtnOk.Size = New System.Drawing.Size(158, 41)
        Me.tsbtnOk.Text = "Сохранить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"),System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(158, 24)
        Me.ToolStripButton3.Text = "Выход"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblAdditionalNumber, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbIssuePlace, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.lblIssuePlace, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateOfLayoutReady, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblManager, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbManager, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateOfIssue, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblContactPerson, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCommentForIssue, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbContactPerson, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCustomer, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateOfProductionReady, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFindCustomer, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbOurOrganization, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOurOrganization, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateOfIssue, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateOfProductionReady, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateOfLayoutReady, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCommentForIssue, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCostType, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCostType, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCustomerPerson, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCustomerPerson, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbOrderSource, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOrderSource, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.chkExpressOrder, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAdditionalNumber, 1, 15)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 16
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(637, 466)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'cmbIssuePlace
        '
        Me.cmbIssuePlace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbIssuePlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIssuePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbIssuePlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbIssuePlace.FormattingEnabled = true
        Me.cmbIssuePlace.Location = New System.Drawing.Point(273, 408)
        Me.cmbIssuePlace.Name = "cmbIssuePlace"
        Me.cmbIssuePlace.Size = New System.Drawing.Size(361, 25)
        Me.cmbIssuePlace.TabIndex = 65
        '
        'lblIssuePlace
        '
        Me.lblIssuePlace.AutoSize = true
        Me.lblIssuePlace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIssuePlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblIssuePlace.Location = New System.Drawing.Point(3, 405)
        Me.lblIssuePlace.Name = "lblIssuePlace"
        Me.lblIssuePlace.Size = New System.Drawing.Size(264, 31)
        Me.lblIssuePlace.TabIndex = 64
        Me.lblIssuePlace.Text = "Выдача"
        Me.lblIssuePlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateOfLayoutReady
        '
        Me.lblDateOfLayoutReady.AutoSize = true
        Me.lblDateOfLayoutReady.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateOfLayoutReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDateOfLayoutReady.Location = New System.Drawing.Point(3, 27)
        Me.lblDateOfLayoutReady.Name = "lblDateOfLayoutReady"
        Me.lblDateOfLayoutReady.Size = New System.Drawing.Size(264, 30)
        Me.lblDateOfLayoutReady.TabIndex = 3
        Me.lblDateOfLayoutReady.Text = "Дата готовности макета / спуска"
        Me.lblDateOfLayoutReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblManager
        '
        Me.lblManager.AutoSize = true
        Me.lblManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblManager.Location = New System.Drawing.Point(3, 117)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(264, 31)
        Me.lblManager.TabIndex = 2
        Me.lblManager.Text = "Менеджер"
        Me.lblManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbManager
        '
        Me.cmbManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbManager.FormattingEnabled = true
        Me.cmbManager.Location = New System.Drawing.Point(273, 120)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(361, 25)
        Me.cmbManager.TabIndex = 0
        '
        'lblDateOfIssue
        '
        Me.lblDateOfIssue.AutoSize = true
        Me.lblDateOfIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateOfIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDateOfIssue.Location = New System.Drawing.Point(3, 87)
        Me.lblDateOfIssue.Name = "lblDateOfIssue"
        Me.lblDateOfIssue.Size = New System.Drawing.Size(264, 30)
        Me.lblDateOfIssue.TabIndex = 4
        Me.lblDateOfIssue.Text = "Дата выдачи / доставки"
        Me.lblDateOfIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContactPerson
        '
        Me.lblContactPerson.AutoSize = true
        Me.lblContactPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContactPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblContactPerson.Location = New System.Drawing.Point(3, 230)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(264, 31)
        Me.lblContactPerson.TabIndex = 40
        Me.lblContactPerson.Text = "Контактное лицо"
        Me.lblContactPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCommentForIssue
        '
        Me.lblCommentForIssue.AutoSize = true
        Me.lblCommentForIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCommentForIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblCommentForIssue.Location = New System.Drawing.Point(3, 374)
        Me.lblCommentForIssue.Name = "lblCommentForIssue"
        Me.lblCommentForIssue.Size = New System.Drawing.Size(264, 31)
        Me.lblCommentForIssue.TabIndex = 41
        Me.lblCommentForIssue.Text = "Комментарий к оплате"
        Me.lblCommentForIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbContactPerson
        '
        Me.cmbContactPerson.ContextMenuStrip = Me.cmsNewPerson
        Me.cmbContactPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbContactPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContactPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbContactPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbContactPerson.FormattingEnabled = true
        Me.cmbContactPerson.Location = New System.Drawing.Point(273, 233)
        Me.cmbContactPerson.Name = "cmbContactPerson"
        Me.cmbContactPerson.Size = New System.Drawing.Size(361, 25)
        Me.cmbContactPerson.TabIndex = 39
        '
        'lblDateOfProductionReady
        '
        Me.lblDateOfProductionReady.AutoSize = true
        Me.lblDateOfProductionReady.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateOfProductionReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDateOfProductionReady.Location = New System.Drawing.Point(3, 57)
        Me.lblDateOfProductionReady.Name = "lblDateOfProductionReady"
        Me.lblDateOfProductionReady.Size = New System.Drawing.Size(264, 30)
        Me.lblDateOfProductionReady.TabIndex = 46
        Me.lblDateOfProductionReady.Text = "Дата готовности на производстве"
        Me.lblDateOfProductionReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOurOrganization
        '
        Me.cmbOurOrganization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOurOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOurOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOurOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOurOrganization.FormattingEnabled = true
        Me.cmbOurOrganization.Location = New System.Drawing.Point(273, 151)
        Me.cmbOurOrganization.Name = "cmbOurOrganization"
        Me.cmbOurOrganization.Size = New System.Drawing.Size(361, 25)
        Me.cmbOurOrganization.TabIndex = 50
        '
        'lblOurOrganization
        '
        Me.lblOurOrganization.AutoSize = true
        Me.lblOurOrganization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOurOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblOurOrganization.Location = New System.Drawing.Point(3, 148)
        Me.lblOurOrganization.Name = "lblOurOrganization"
        Me.lblOurOrganization.Size = New System.Drawing.Size(264, 31)
        Me.lblOurOrganization.TabIndex = 52
        Me.lblOurOrganization.Text = "Наша организация"
        Me.lblOurOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDateOfIssue
        '
        Me.dtpDateOfIssue.CustomFormat = "dd MMMM yyyy HH:mm"
        Me.dtpDateOfIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfIssue.Location = New System.Drawing.Point(273, 90)
        Me.dtpDateOfIssue.Name = "dtpDateOfIssue"
        Me.dtpDateOfIssue.Size = New System.Drawing.Size(359, 24)
        Me.dtpDateOfIssue.TabIndex = 0
        '
        'dtpDateOfProductionReady
        '
        Me.dtpDateOfProductionReady.CustomFormat = "dd MMMM yyyy HH:mm"
        Me.dtpDateOfProductionReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateOfProductionReady.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfProductionReady.Location = New System.Drawing.Point(273, 60)
        Me.dtpDateOfProductionReady.Name = "dtpDateOfProductionReady"
        Me.dtpDateOfProductionReady.Size = New System.Drawing.Size(359, 24)
        Me.dtpDateOfProductionReady.TabIndex = 0
        '
        'dtpDateOfLayoutReady
        '
        Me.dtpDateOfLayoutReady.CustomFormat = "dd MMMM yyyy HH:mm"
        Me.dtpDateOfLayoutReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateOfLayoutReady.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfLayoutReady.Location = New System.Drawing.Point(273, 30)
        Me.dtpDateOfLayoutReady.Name = "dtpDateOfLayoutReady"
        Me.dtpDateOfLayoutReady.Size = New System.Drawing.Size(359, 24)
        Me.dtpDateOfLayoutReady.TabIndex = 0
        '
        'cmbCommentForIssue
        '
        Me.cmbCommentForIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCommentForIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCommentForIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCommentForIssue.FormattingEnabled = true
        Me.cmbCommentForIssue.Location = New System.Drawing.Point(273, 377)
        Me.cmbCommentForIssue.Name = "cmbCommentForIssue"
        Me.cmbCommentForIssue.Size = New System.Drawing.Size(361, 25)
        Me.cmbCommentForIssue.TabIndex = 55
        '
        'cmbCostType
        '
        Me.cmbCostType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCostType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCostType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCostType.FormattingEnabled = true
        Me.cmbCostType.Items.AddRange(New Object() {"Реальный заказ", "Виртуальный заказ", "Авансовая оплата"})
        Me.cmbCostType.Location = New System.Drawing.Point(273, 315)
        Me.cmbCostType.Name = "cmbCostType"
        Me.cmbCostType.Size = New System.Drawing.Size(361, 25)
        Me.cmbCostType.TabIndex = 56
        Me.cmbCostType.Visible = false
        '
        'lblCostType
        '
        Me.lblCostType.AutoSize = true
        Me.lblCostType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCostType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblCostType.Location = New System.Drawing.Point(3, 312)
        Me.lblCostType.Name = "lblCostType"
        Me.lblCostType.Size = New System.Drawing.Size(264, 31)
        Me.lblCostType.TabIndex = 57
        Me.lblCostType.Text = "Тип заказа"
        Me.lblCostType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCostType.Visible = false
        '
        'lblCustomerPerson
        '
        Me.lblCustomerPerson.AutoSize = true
        Me.lblCustomerPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCustomerPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblCustomerPerson.Location = New System.Drawing.Point(3, 261)
        Me.lblCustomerPerson.Name = "lblCustomerPerson"
        Me.lblCustomerPerson.Size = New System.Drawing.Size(264, 31)
        Me.lblCustomerPerson.TabIndex = 60
        Me.lblCustomerPerson.Text = "Юр.лицо заказчика"
        Me.lblCustomerPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCustomerPerson
        '
        Me.cmbCustomerPerson.ContextMenuStrip = Me.cmsNewOrganization
        Me.cmbCustomerPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustomerPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomerPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustomerPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustomerPerson.FormattingEnabled = true
        Me.cmbCustomerPerson.Location = New System.Drawing.Point(273, 264)
        Me.cmbCustomerPerson.Name = "cmbCustomerPerson"
        Me.cmbCustomerPerson.Size = New System.Drawing.Size(361, 25)
        Me.cmbCustomerPerson.TabIndex = 61
        '
        'cmsNewOrganization
        '
        Me.cmsNewOrganization.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.cmsNewOrganization.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздатьЮрЛицоToolStripMenuItem})
        Me.cmsNewOrganization.Name = "cmsNewOrganization"
        Me.cmsNewOrganization.Size = New System.Drawing.Size(184, 26)
        '
        'СоздатьЮрЛицоToolStripMenuItem
        '
        Me.СоздатьЮрЛицоToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.СоздатьЮрЛицоToolStripMenuItem.Name = "СоздатьЮрЛицоToolStripMenuItem"
        Me.СоздатьЮрЛицоToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.СоздатьЮрЛицоToolStripMenuItem.Text = "Создать юр. лицо"
        '
        'cmbOrderSource
        '
        Me.cmbOrderSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrderSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrderSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOrderSource.FormattingEnabled = true
        Me.cmbOrderSource.Location = New System.Drawing.Point(273, 346)
        Me.cmbOrderSource.MaxDropDownItems = 16
        Me.cmbOrderSource.Name = "cmbOrderSource"
        Me.cmbOrderSource.Size = New System.Drawing.Size(361, 25)
        Me.cmbOrderSource.TabIndex = 62
        '
        'lblOrderSource
        '
        Me.lblOrderSource.AutoSize = true
        Me.lblOrderSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOrderSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblOrderSource.Location = New System.Drawing.Point(3, 343)
        Me.lblOrderSource.Name = "lblOrderSource"
        Me.lblOrderSource.Size = New System.Drawing.Size(264, 31)
        Me.lblOrderSource.TabIndex = 63
        Me.lblOrderSource.Text = "Источник заказа"
        Me.lblOrderSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkExpressOrder
        '
        Me.chkExpressOrder.AutoSize = true
        Me.chkExpressOrder.Location = New System.Drawing.Point(3, 3)
        Me.chkExpressOrder.Name = "chkExpressOrder"
        Me.chkExpressOrder.Size = New System.Drawing.Size(127, 21)
        Me.chkExpressOrder.TabIndex = 66
        Me.chkExpressOrder.Text = "Срочный заказ"
        Me.chkExpressOrder.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStrip1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(803, 502)
        Me.TableLayoutPanel2.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(797, 30)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "..."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdditionalNumber
        '
        Me.lblAdditionalNumber.AutoSize = true
        Me.lblAdditionalNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAdditionalNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblAdditionalNumber.Location = New System.Drawing.Point(3, 436)
        Me.lblAdditionalNumber.Name = "lblAdditionalNumber"
        Me.lblAdditionalNumber.Size = New System.Drawing.Size(264, 30)
        Me.lblAdditionalNumber.TabIndex = 67
        Me.lblAdditionalNumber.Text = "Доп. номер"
        Me.lblAdditionalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdditionalNumber
        '
        Me.txtAdditionalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdditionalNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAdditionalNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.txtAdditionalNumber.Location = New System.Drawing.Point(273, 439)
        Me.txtAdditionalNumber.Name = "txtAdditionalNumber"
        Me.txtAdditionalNumber.Size = New System.Drawing.Size(361, 24)
        Me.txtAdditionalNumber.TabIndex = 68
        '
        'frmOrderEdit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(782, 638)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmOrderEdit"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.cmsNewPerson.ResumeLayout(false)
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.cmsNewOrganization.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmsNewPerson As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents СоздатьПредставителяToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtpDateOfProductionReady As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateOfIssue As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateOfLayoutReady As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateOfLayoutReady As System.Windows.Forms.Label
    Friend WithEvents lblManager As System.Windows.Forms.Label
    Friend WithEvents cmbManager As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateOfIssue As System.Windows.Forms.Label
    Friend WithEvents lblContactPerson As System.Windows.Forms.Label
    Friend WithEvents lblCommentForIssue As System.Windows.Forms.Label
    Friend WithEvents cmbContactPerson As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateOfProductionReady As System.Windows.Forms.Label
    Friend WithEvents txtFindCustomer As System.Windows.Forms.TextBox
    Friend WithEvents cmbOurOrganization As System.Windows.Forms.ComboBox
    Friend WithEvents lblOurOrganization As System.Windows.Forms.Label
    Friend WithEvents cmbCommentForIssue As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCostType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCostType As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCustomerPerson As System.Windows.Forms.Label
    Friend WithEvents cmbCustomerPerson As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbOrderSource As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrderSource As System.Windows.Forms.Label
    Friend WithEvents cmbIssuePlace As ComboBox
    Friend WithEvents lblIssuePlace As Label
    Friend WithEvents chkExpressOrder As CheckBox
    Friend WithEvents cmsNewOrganization As ContextMenuStrip
    Friend WithEvents СоздатьЮрЛицоToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAdditionalNumber As Label
    Friend WithEvents txtAdditionalNumber As TextBox
End Class
