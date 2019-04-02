<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTasks))
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCustForSearh = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbExecutor = New System.Windows.Forms.ComboBox()
        Me.chkDataPeriod = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.chkExecutor = New System.Windows.Forms.CheckBox()
        Me.chkCustForSearh = New System.Windows.Forms.CheckBox()
        Me.cmbCustForSearh = New System.Windows.Forms.ComboBox()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.chkAuthor = New System.Windows.Forms.CheckBox()
        Me.cmbAuthor = New System.Windows.Forms.ComboBox()
        Me.btnNow = New System.Windows.Forms.Button()
        Me.btnWeek = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.chkDateCreate = New System.Windows.Forms.CheckBox()
        Me.dtpDateCreate1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateCreate2 = New System.Windows.Forms.DateTimePicker()
        Me.txtTaskContent = New System.Windows.Forms.TextBox()
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.cmsTasks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ВыполненаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПовторЗадачиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.tsbtnAddTask = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnAllTasks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnProsrok = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnMyTasks = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer2.Panel1.SuspendLayout
        Me.SplitContainer2.Panel2.SuspendLayout
        Me.SplitContainer2.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsTasks.SuspendLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.BindingNavigator1.SuspendLayout
        Me.SuspendLayout
        '
        'SplitContainer2
        '
        Me.SplitContainer2.AllowDrop = true
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer2.Panel1MinSize = 0
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgTableData)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.SplitContainer2.Panel2MinSize = 0
        Me.SplitContainer2.Size = New System.Drawing.Size(1276, 698)
        Me.SplitContainer2.SplitterDistance = 505
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = true
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.4812!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(501, 694)
        Me.TableLayoutPanel2.TabIndex = 20
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = true
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtCustForSearh, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbExecutor, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDataPeriod, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chkExecutor, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.chkCustForSearh, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCustForSearh, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.chkStatus, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbStatus, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAuthor, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbAuthor, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNow, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnWeek, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAll, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDateCreate, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateCreate1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateCreate2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTaskContent, 0, 8)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 6)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(491, 682)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'txtCustForSearh
        '
        Me.txtCustForSearh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustForSearh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustForSearh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtCustForSearh.Location = New System.Drawing.Point(318, 171)
        Me.txtCustForSearh.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtCustForSearh.Name = "txtCustForSearh"
        Me.txtCustForSearh.Size = New System.Drawing.Size(78, 24)
        Me.txtCustForSearh.TabIndex = 0
        Me.txtCustForSearh.Visible = false
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 1)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(301, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Параметр"
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label17, 2)
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label17.Location = New System.Drawing.Point(318, 1)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(167, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Значение"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(318, 53)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DateTimePicker1.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(78, 24)
        Me.DateTimePicker1.TabIndex = 3
        Me.DateTimePicker1.TabStop = false
        Me.DateTimePicker1.Value = New Date(2007, 1, 16, 0, 0, 0, 0)
        '
        'cmbExecutor
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbExecutor, 2)
        Me.cmbExecutor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExecutor.DropDownWidth = 200
        Me.cmbExecutor.Enabled = false
        Me.cmbExecutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExecutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbExecutor.Location = New System.Drawing.Point(318, 133)
        Me.cmbExecutor.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbExecutor.MaxDropDownItems = 20
        Me.cmbExecutor.MaxLength = 5
        Me.cmbExecutor.Name = "cmbExecutor"
        Me.cmbExecutor.Size = New System.Drawing.Size(167, 25)
        Me.cmbExecutor.TabIndex = 66
        Me.cmbExecutor.TabStop = false
        '
        'chkDataPeriod
        '
        Me.chkDataPeriod.AutoSize = true
        Me.chkDataPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDataPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkDataPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkDataPeriod.Location = New System.Drawing.Point(6, 53)
        Me.chkDataPeriod.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkDataPeriod.Name = "chkDataPeriod"
        Me.chkDataPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDataPeriod.Size = New System.Drawing.Size(145, 22)
        Me.chkDataPeriod.TabIndex = 57
        Me.chkDataPeriod.TabStop = false
        Me.chkDataPeriod.Text = "Дата исполнения"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(407, 53)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DateTimePicker2.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(78, 24)
        Me.DateTimePicker2.TabIndex = 4
        Me.DateTimePicker2.TabStop = false
        Me.DateTimePicker2.Value = New Date(2007, 1, 16, 0, 0, 0, 0)
        '
        'chkExecutor
        '
        Me.chkExecutor.AutoSize = true
        Me.chkExecutor.Checked = true
        Me.chkExecutor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExecutor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkExecutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkExecutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkExecutor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkExecutor.Location = New System.Drawing.Point(6, 133)
        Me.chkExecutor.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkExecutor.Name = "chkExecutor"
        Me.chkExecutor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkExecutor.Size = New System.Drawing.Size(301, 25)
        Me.chkExecutor.TabIndex = 67
        Me.chkExecutor.TabStop = false
        Me.chkExecutor.Text = "Исполнитель"
        '
        'chkCustForSearh
        '
        Me.chkCustForSearh.AutoSize = true
        Me.chkCustForSearh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCustForSearh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCustForSearh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkCustForSearh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkCustForSearh.Location = New System.Drawing.Point(6, 171)
        Me.chkCustForSearh.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkCustForSearh.Name = "chkCustForSearh"
        Me.chkCustForSearh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCustForSearh.Size = New System.Drawing.Size(301, 26)
        Me.chkCustForSearh.TabIndex = 73
        Me.chkCustForSearh.TabStop = false
        Me.chkCustForSearh.Text = "Контрагент"
        '
        'cmbCustForSearh
        '
        Me.cmbCustForSearh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustForSearh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustForSearh.DropDownWidth = 300
        Me.cmbCustForSearh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustForSearh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustForSearh.FormattingEnabled = true
        Me.cmbCustForSearh.Location = New System.Drawing.Point(407, 171)
        Me.cmbCustForSearh.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbCustForSearh.MaxDropDownItems = 12
        Me.cmbCustForSearh.Name = "cmbCustForSearh"
        Me.cmbCustForSearh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCustForSearh.Size = New System.Drawing.Size(78, 25)
        Me.cmbCustForSearh.TabIndex = 1
        Me.cmbCustForSearh.Visible = false
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = true
        Me.chkStatus.Checked = true
        Me.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkStatus.Location = New System.Drawing.Point(6, 210)
        Me.chkStatus.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(301, 26)
        Me.chkStatus.TabIndex = 75
        Me.chkStatus.Text = "Состояние"
        Me.chkStatus.UseVisualStyleBackColor = true
        '
        'cmbStatus
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbStatus, 2)
        Me.cmbStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.DropDownWidth = 300
        Me.cmbStatus.Enabled = false
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbStatus.FormattingEnabled = true
        Me.cmbStatus.Location = New System.Drawing.Point(318, 210)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(167, 25)
        Me.cmbStatus.TabIndex = 76
        '
        'chkAuthor
        '
        Me.chkAuthor.AutoSize = true
        Me.chkAuthor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkAuthor.Location = New System.Drawing.Point(6, 249)
        Me.chkAuthor.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkAuthor.Name = "chkAuthor"
        Me.chkAuthor.Size = New System.Drawing.Size(301, 26)
        Me.chkAuthor.TabIndex = 78
        Me.chkAuthor.Text = "Автор задачи"
        Me.chkAuthor.UseVisualStyleBackColor = true
        '
        'cmbAuthor
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbAuthor, 2)
        Me.cmbAuthor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAuthor.Enabled = false
        Me.cmbAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbAuthor.FormattingEnabled = true
        Me.cmbAuthor.Location = New System.Drawing.Point(318, 249)
        Me.cmbAuthor.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbAuthor.Name = "cmbAuthor"
        Me.cmbAuthor.Size = New System.Drawing.Size(167, 25)
        Me.cmbAuthor.TabIndex = 79
        '
        'btnNow
        '
        Me.btnNow.AutoSize = true
        Me.btnNow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnNow.Location = New System.Drawing.Point(6, 90)
        Me.btnNow.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnNow.Name = "btnNow"
        Me.btnNow.Size = New System.Drawing.Size(301, 30)
        Me.btnNow.TabIndex = 80
        Me.btnNow.Text = "Сегодня"
        Me.btnNow.UseVisualStyleBackColor = true
        '
        'btnWeek
        '
        Me.btnWeek.AutoSize = true
        Me.btnWeek.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnWeek.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnWeek.Location = New System.Drawing.Point(318, 90)
        Me.btnWeek.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnWeek.Name = "btnWeek"
        Me.btnWeek.Size = New System.Drawing.Size(78, 30)
        Me.btnWeek.TabIndex = 81
        Me.btnWeek.Text = "Неделя"
        Me.btnWeek.UseVisualStyleBackColor = true
        '
        'btnAll
        '
        Me.btnAll.AutoSize = true
        Me.btnAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnAll.Location = New System.Drawing.Point(407, 90)
        Me.btnAll.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(78, 30)
        Me.btnAll.TabIndex = 82
        Me.btnAll.Text = "Все"
        Me.btnAll.UseVisualStyleBackColor = true
        '
        'chkDateCreate
        '
        Me.chkDateCreate.AutoSize = true
        Me.chkDateCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDateCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkDateCreate.Location = New System.Drawing.Point(5, 20)
        Me.chkDateCreate.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.chkDateCreate.Name = "chkDateCreate"
        Me.chkDateCreate.Size = New System.Drawing.Size(129, 22)
        Me.chkDateCreate.TabIndex = 83
        Me.chkDateCreate.Text = "Дата создания"
        Me.chkDateCreate.UseVisualStyleBackColor = true
        '
        'dtpDateCreate1
        '
        Me.dtpDateCreate1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDateCreate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateCreate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateCreate1.Location = New System.Drawing.Point(317, 20)
        Me.dtpDateCreate1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtpDateCreate1.Name = "dtpDateCreate1"
        Me.dtpDateCreate1.Size = New System.Drawing.Size(80, 24)
        Me.dtpDateCreate1.TabIndex = 84
        '
        'dtpDateCreate2
        '
        Me.dtpDateCreate2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDateCreate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateCreate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateCreate2.Location = New System.Drawing.Point(406, 20)
        Me.dtpDateCreate2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtpDateCreate2.Name = "dtpDateCreate2"
        Me.dtpDateCreate2.Size = New System.Drawing.Size(80, 24)
        Me.dtpDateCreate2.TabIndex = 85
        '
        'txtTaskContent
        '
        Me.txtTaskContent.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTaskContent, 3)
        Me.txtTaskContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTaskContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTaskContent.Location = New System.Drawing.Point(5, 286)
        Me.txtTaskContent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTaskContent.Multiline = true
        Me.txtTaskContent.Name = "txtTaskContent"
        Me.txtTaskContent.ReadOnly = true
        Me.txtTaskContent.Size = New System.Drawing.Size(481, 391)
        Me.txtTaskContent.TabIndex = 86
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.AllowUserToResizeRows = false
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTableData.ContextMenuStrip = Me.cmsTasks
        Me.dgTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTableData.Location = New System.Drawing.Point(0, 27)
        Me.dgTableData.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgTableData.MultiSelect = false
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.ReadOnly = true
        Me.dgTableData.RowHeadersVisible = false
        Me.dgTableData.RowHeadersWidth = 15
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTableData.Size = New System.Drawing.Size(761, 667)
        Me.dgTableData.TabIndex = 0
        '
        'cmsTasks
        '
        Me.cmsTasks.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsTasks.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTasks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВыполненаToolStripMenuItem, Me.ПовторЗадачиToolStripMenuItem, Me.ПерейтиКЗаказуToolStripMenuItem})
        Me.cmsTasks.Name = "cmsTasks"
        Me.cmsTasks.Size = New System.Drawing.Size(179, 70)
        '
        'ВыполненаToolStripMenuItem
        '
        Me.ВыполненаToolStripMenuItem.Name = "ВыполненаToolStripMenuItem"
        Me.ВыполненаToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ВыполненаToolStripMenuItem.Text = "Выполнена"
        '
        'ПовторЗадачиToolStripMenuItem
        '
        Me.ПовторЗадачиToolStripMenuItem.Name = "ПовторЗадачиToolStripMenuItem"
        Me.ПовторЗадачиToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ПовторЗадачиToolStripMenuItem.Text = "Повтор задачи"
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnAddTask, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsbtnAllTasks, Me.ToolStripSeparator3, Me.tsbtnProsrok, Me.tsbtnMyTasks})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(761, 27)
        Me.BindingNavigator1.TabIndex = 10
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(46, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'tsbtnAddTask
        '
        Me.tsbtnAddTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAddTask.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnAddTask.Image = CType(resources.GetObject("tsbtnAddTask.Image"),System.Drawing.Image)
        Me.tsbtnAddTask.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddTask.Name = "tsbtnAddTask"
        Me.tsbtnAddTask.Size = New System.Drawing.Size(68, 24)
        Me.tsbtnAddTask.Text = "Создать"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = false
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(80, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsbtnAllTasks
        '
        Me.tsbtnAllTasks.BackColor = System.Drawing.Color.Pink
        Me.tsbtnAllTasks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAllTasks.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnAllTasks.Image = CType(resources.GetObject("tsbtnAllTasks.Image"),System.Drawing.Image)
        Me.tsbtnAllTasks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAllTasks.Name = "tsbtnAllTasks"
        Me.tsbtnAllTasks.Size = New System.Drawing.Size(79, 24)
        Me.tsbtnAllTasks.Text = "Обновить"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'tsbtnProsrok
        '
        Me.tsbtnProsrok.BackColor = System.Drawing.Color.Pink
        Me.tsbtnProsrok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnProsrok.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnProsrok.Image = CType(resources.GetObject("tsbtnProsrok.Image"),System.Drawing.Image)
        Me.tsbtnProsrok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnProsrok.Name = "tsbtnProsrok"
        Me.tsbtnProsrok.Size = New System.Drawing.Size(103, 24)
        Me.tsbtnProsrok.Text = "Просроченые"
        '
        'tsbtnMyTasks
        '
        Me.tsbtnMyTasks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnMyTasks.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnMyTasks.Image = CType(resources.GetObject("tsbtnMyTasks.Image"),System.Drawing.Image)
        Me.tsbtnMyTasks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMyTasks.Name = "tsbtnMyTasks"
        Me.tsbtnMyTasks.Size = New System.Drawing.Size(92, 24)
        Me.tsbtnMyTasks.Text = "Мои задачи"
        Me.tsbtnMyTasks.Visible = false
        '
        'frmTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 698)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmTasks"
        Me.Text = "Задачи"
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        Me.SplitContainer2.Panel2.PerformLayout
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsTasks.ResumeLayout(false)
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).EndInit
        Me.BindingNavigator1.ResumeLayout(false)
        Me.BindingNavigator1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtCustForSearh As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbExecutor As System.Windows.Forms.ComboBox
    Friend WithEvents chkDataPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkExecutor As System.Windows.Forms.CheckBox
    Friend WithEvents chkCustForSearh As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCustForSearh As System.Windows.Forms.ComboBox
    Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents chkAuthor As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAuthor As System.Windows.Forms.ComboBox
    Friend WithEvents btnNow As System.Windows.Forms.Button
    Friend WithEvents btnWeek As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbtnAddTask As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnAllTasks As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnMyTasks As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnProsrok As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkDateCreate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDateCreate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateCreate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmsTasks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ВыполненаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПовторЗадачиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTaskContent As System.Windows.Forms.TextBox
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
