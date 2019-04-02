<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaskCard))
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.СоздатьПредставителяToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpdata_Performance = New System.Windows.Forms.DateTimePicker()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbExecutor = New System.Windows.Forms.ComboBox()
        Me.lblDate_Start = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.lblTypeTask = New System.Windows.Forms.Label()
        Me.cmbTypeTask = New System.Windows.Forms.ComboBox()
        Me.lbldata_Performance = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTaskContent = New System.Windows.Forms.Label()
        Me.txtTaskContent = New System.Windows.Forms.TextBox()
        Me.cmbPriority = New System.Windows.Forms.ComboBox()
        Me.cmbKA = New System.Windows.Forms.ComboBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.txtCustForSearh = New System.Windows.Forms.TextBox()
        Me.lblPersons = New System.Windows.Forms.Label()
        Me.dgPersons = New System.Windows.Forms.DataGridView()
        Me.dtpDateFinish = New System.Windows.Forms.DateTimePicker()
        Me.lblDateFinish = New System.Windows.Forms.Label()
        Me.txtDate_Start = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTaskComment = New System.Windows.Forms.TextBox()
        Me.lblTaskComment = New System.Windows.Forms.Label()
        Me.cmsNewPerson = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsNewKA = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьКонтрагентаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        CType(Me.dgPersons,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsNewPerson.SuspendLayout
        Me.cmsNewKA.SuspendLayout
        Me.SuspendLayout
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = true
        Me.lblPriority.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblPriority.Location = New System.Drawing.Point(6, 253)
        Me.lblPriority.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(394, 37)
        Me.lblPriority.TabIndex = 34
        Me.lblPriority.Text = "Приоритет"
        Me.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'СоздатьПредставителяToolStripMenuItem
        '
        Me.СоздатьПредставителяToolStripMenuItem.Name = "СоздатьПредставителяToolStripMenuItem"
        Me.СоздатьПредставителяToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.СоздатьПредставителяToolStripMenuItem.Text = "Создать представителя"
        '
        'dtpdata_Performance
        '
        Me.dtpdata_Performance.CustomFormat = "dd MMMM yyyy HH:mm"
        Me.dtpdata_Performance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpdata_Performance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpdata_Performance.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdata_Performance.Location = New System.Drawing.Point(411, 36)
        Me.dtpdata_Performance.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpdata_Performance.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.dtpdata_Performance.Name = "dtpdata_Performance"
        Me.dtpdata_Performance.Size = New System.Drawing.Size(404, 24)
        Me.dtpdata_Performance.TabIndex = 0
        Me.dtpdata_Performance.Value = New Date(2014, 6, 10, 0, 0, 0, 0)
        '
        'cmbStatus
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbStatus, 2)
        Me.cmbStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbStatus.FormattingEnabled = true
        Me.cmbStatus.Location = New System.Drawing.Point(411, 221)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(626, 25)
        Me.cmbStatus.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Исполняющий"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbExecutor
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbExecutor, 2)
        Me.cmbExecutor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExecutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExecutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbExecutor.FormattingEnabled = true
        Me.cmbExecutor.Location = New System.Drawing.Point(411, 145)
        Me.cmbExecutor.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbExecutor.MaxDropDownItems = 25
        Me.cmbExecutor.Name = "cmbExecutor"
        Me.cmbExecutor.Size = New System.Drawing.Size(626, 25)
        Me.cmbExecutor.TabIndex = 0
        '
        'lblDate_Start
        '
        Me.lblDate_Start.AutoSize = true
        Me.lblDate_Start.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDate_Start.Location = New System.Drawing.Point(6, 1)
        Me.lblDate_Start.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDate_Start.Name = "lblDate_Start"
        Me.lblDate_Start.Size = New System.Drawing.Size(394, 28)
        Me.lblDate_Start.TabIndex = 3
        Me.lblDate_Start.Text = "Дата постановки"
        Me.lblDate_Start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1053, 750)
        Me.TableLayoutPanel2.TabIndex = 35
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblPriority, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbStatus, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbExecutor, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDate_Start, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTypeTask, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTypeTask, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbldata_Performance, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatus, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTaskContent, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTaskContent, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPriority, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbKA, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbDepartment, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCustForSearh, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPersons, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.dgPersons, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateFinish, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateFinish, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDate_Start, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpdata_Performance, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTaskComment, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTaskComment, 0, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 6)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1043, 738)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOK, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(821, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.TableLayoutPanel1.SetRowSpan(Me.ToolStrip1, 4)
        Me.ToolStrip1.Size = New System.Drawing.Size(221, 137)
        Me.ToolStrip1.TabIndex = 33
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(219, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(219, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(219, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'lblTypeTask
        '
        Me.lblTypeTask.AutoSize = true
        Me.lblTypeTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTypeTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblTypeTask.Location = New System.Drawing.Point(6, 177)
        Me.lblTypeTask.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTypeTask.Name = "lblTypeTask"
        Me.lblTypeTask.Size = New System.Drawing.Size(394, 37)
        Me.lblTypeTask.TabIndex = 2
        Me.lblTypeTask.Text = "Тип"
        Me.lblTypeTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTypeTask
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbTypeTask, 2)
        Me.cmbTypeTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTypeTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypeTask.FormattingEnabled = true
        Me.cmbTypeTask.Location = New System.Drawing.Point(411, 183)
        Me.cmbTypeTask.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbTypeTask.Name = "cmbTypeTask"
        Me.cmbTypeTask.Size = New System.Drawing.Size(626, 25)
        Me.cmbTypeTask.TabIndex = 0
        '
        'lbldata_Performance
        '
        Me.lbldata_Performance.AutoSize = true
        Me.lbldata_Performance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbldata_Performance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lbldata_Performance.Location = New System.Drawing.Point(6, 30)
        Me.lbldata_Performance.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbldata_Performance.Name = "lbldata_Performance"
        Me.lbldata_Performance.Size = New System.Drawing.Size(394, 36)
        Me.lbldata_Performance.TabIndex = 4
        Me.lbldata_Performance.Text = "Выполнить до"
        Me.lbldata_Performance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = true
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblStatus.Location = New System.Drawing.Point(6, 215)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(394, 37)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Состояние"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTaskContent
        '
        Me.lblTaskContent.AutoSize = true
        Me.lblTaskContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblTaskContent.Location = New System.Drawing.Point(6, 448)
        Me.lblTaskContent.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTaskContent.Name = "lblTaskContent"
        Me.lblTaskContent.Size = New System.Drawing.Size(96, 18)
        Me.lblTaskContent.TabIndex = 41
        Me.lblTaskContent.Text = "Содержание"
        Me.lblTaskContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTaskContent
        '
        Me.txtTaskContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTaskContent, 2)
        Me.txtTaskContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTaskContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTaskContent.Location = New System.Drawing.Point(411, 454)
        Me.txtTaskContent.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtTaskContent.Multiline = true
        Me.txtTaskContent.Name = "txtTaskContent"
        Me.txtTaskContent.Size = New System.Drawing.Size(626, 202)
        Me.txtTaskContent.TabIndex = 42
        '
        'cmbPriority
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbPriority, 2)
        Me.cmbPriority.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriority.FormattingEnabled = true
        Me.cmbPriority.Items.AddRange(New Object() {"Высокий", "Средний", "Низкий"})
        Me.cmbPriority.Location = New System.Drawing.Point(411, 259)
        Me.cmbPriority.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Size = New System.Drawing.Size(626, 25)
        Me.cmbPriority.TabIndex = 43
        '
        'cmbKA
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbKA, 2)
        Me.cmbKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbKA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbKA.FormattingEnabled = true
        Me.cmbKA.Location = New System.Drawing.Point(411, 297)
        Me.cmbKA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbKA.MaxDropDownItems = 30
        Me.cmbKA.Name = "cmbKA"
        Me.cmbKA.Size = New System.Drawing.Size(626, 25)
        Me.cmbKA.TabIndex = 44
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.DropDownWidth = 333
        Me.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepartment.FormattingEnabled = true
        Me.cmbDepartment.Location = New System.Drawing.Point(411, 102)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbDepartment.MaxDropDownItems = 25
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(404, 25)
        Me.cmbDepartment.TabIndex = 46
        '
        'txtCustForSearh
        '
        Me.txtCustForSearh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustForSearh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustForSearh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtCustForSearh.Location = New System.Drawing.Point(6, 297)
        Me.txtCustForSearh.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtCustForSearh.Name = "txtCustForSearh"
        Me.txtCustForSearh.Size = New System.Drawing.Size(394, 24)
        Me.txtCustForSearh.TabIndex = 47
        Me.txtCustForSearh.Text = "Контрагент"
        Me.ToolTip1.SetToolTip(Me.txtCustForSearh, "Ввести часть названия и нажать ВВОД")
        '
        'lblPersons
        '
        Me.lblPersons.AutoSize = true
        Me.lblPersons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblPersons.Location = New System.Drawing.Point(5, 329)
        Me.lblPersons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPersons.Name = "lblPersons"
        Me.lblPersons.Size = New System.Drawing.Size(71, 18)
        Me.lblPersons.TabIndex = 49
        Me.lblPersons.Text = "Персоны"
        Me.lblPersons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgPersons
        '
        Me.dgPersons.AllowUserToAddRows = false
        Me.dgPersons.AllowUserToDeleteRows = false
        Me.dgPersons.AllowUserToResizeRows = false
        Me.dgPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgPersons, 2)
        Me.dgPersons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPersons.Location = New System.Drawing.Point(410, 331)
        Me.dgPersons.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgPersons.Name = "dgPersons"
        Me.dgPersons.ReadOnly = true
        Me.dgPersons.RowTemplate.Height = 24
        Me.dgPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPersons.Size = New System.Drawing.Size(628, 114)
        Me.dgPersons.TabIndex = 50
        '
        'dtpDateFinish
        '
        Me.dtpDateFinish.CustomFormat = "dd MMMM yyyy hh:mm"
        Me.dtpDateFinish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDateFinish.Enabled = false
        Me.dtpDateFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFinish.Location = New System.Drawing.Point(410, 69)
        Me.dtpDateFinish.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtpDateFinish.Name = "dtpDateFinish"
        Me.dtpDateFinish.Size = New System.Drawing.Size(406, 24)
        Me.dtpDateFinish.TabIndex = 51
        '
        'lblDateFinish
        '
        Me.lblDateFinish.AutoSize = true
        Me.lblDateFinish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDateFinish.Location = New System.Drawing.Point(5, 67)
        Me.lblDateFinish.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateFinish.Name = "lblDateFinish"
        Me.lblDateFinish.Size = New System.Drawing.Size(396, 28)
        Me.lblDateFinish.TabIndex = 52
        Me.lblDateFinish.Text = "Выполнена"
        Me.lblDateFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDate_Start
        '
        Me.txtDate_Start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate_Start.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDate_Start.Enabled = false
        Me.txtDate_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtDate_Start.Location = New System.Drawing.Point(410, 3)
        Me.txtDate_Start.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtDate_Start.Name = "txtDate_Start"
        Me.txtDate_Start.Size = New System.Drawing.Size(406, 24)
        Me.txtDate_Start.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button1.Location = New System.Drawing.Point(5, 98)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(396, 38)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Фильтр по департаменту"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'txtTaskComment
        '
        Me.txtTaskComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTaskComment, 2)
        Me.txtTaskComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTaskComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTaskComment.Location = New System.Drawing.Point(410, 665)
        Me.txtTaskComment.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtTaskComment.Multiline = true
        Me.txtTaskComment.Name = "txtTaskComment"
        Me.txtTaskComment.Size = New System.Drawing.Size(628, 70)
        Me.txtTaskComment.TabIndex = 55
        '
        'lblTaskComment
        '
        Me.lblTaskComment.AutoSize = true
        Me.lblTaskComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblTaskComment.Location = New System.Drawing.Point(5, 663)
        Me.lblTaskComment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskComment.Name = "lblTaskComment"
        Me.lblTaskComment.Size = New System.Drawing.Size(198, 18)
        Me.lblTaskComment.TabIndex = 56
        Me.lblTaskComment.Text = "Комментарии исполнителя"
        Me.lblTaskComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmsNewPerson
        '
        Me.cmsNewPerson.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsNewPerson.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsNewPerson.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздатьПредставителяToolStripMenuItem})
        Me.cmsNewPerson.Name = "cmsNewPerson"
        Me.cmsNewPerson.Size = New System.Drawing.Size(217, 26)
        '
        'cmsNewKA
        '
        Me.cmsNewKA.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsNewKA.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьКонтрагентаToolStripMenuItem})
        Me.cmsNewKA.Name = "cmsNewKA"
        Me.cmsNewKA.Size = New System.Drawing.Size(210, 26)
        '
        'ДобавитьКонтрагентаToolStripMenuItem
        '
        Me.ДобавитьКонтрагентаToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ДобавитьКонтрагентаToolStripMenuItem.Name = "ДобавитьКонтрагентаToolStripMenuItem"
        Me.ДобавитьКонтрагентаToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ДобавитьКонтрагентаToolStripMenuItem.Text = "Добавить контрагента"
        '
        'frmTaskCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1053, 750)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MinimizeBox = false
        Me.Name = "frmTaskCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Задача"
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.dgPersons,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsNewPerson.ResumeLayout(false)
        Me.cmsNewKA.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents СоздатьПредставителяToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpdata_Performance As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbExecutor As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate_Start As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTypeTask As System.Windows.Forms.Label
    Friend WithEvents cmbTypeTask As System.Windows.Forms.ComboBox
    Friend WithEvents lbldata_Performance As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblTaskContent As System.Windows.Forms.Label
    Friend WithEvents txtTaskContent As System.Windows.Forms.TextBox
    Friend WithEvents cmbPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cmsNewPerson As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmbKA As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustForSearh As System.Windows.Forms.TextBox
    Friend WithEvents lblPersons As System.Windows.Forms.Label
    Friend WithEvents dgPersons As System.Windows.Forms.DataGridView
    Friend WithEvents cmsNewKA As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьКонтрагентаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpDateFinish As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateFinish As System.Windows.Forms.Label
    Friend WithEvents txtDate_Start As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtTaskComment As System.Windows.Forms.TextBox
    Friend WithEvents lblTaskComment As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
