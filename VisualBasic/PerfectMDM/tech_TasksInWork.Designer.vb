<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tech_TasksInWork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tech_TasksInWork))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgMatExpens = New System.Windows.Forms.DataGridView()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.tscmbEmpl = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnStopTask = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEndTask = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.dgSpec = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpFiles = New System.Windows.Forms.TableLayoutPanel()
        Me.dgFiles = New System.Windows.Forms.DataGridView()
        Me.tlsFiles = New System.Windows.Forms.ToolStrip()
        Me.tscmbFileDescript = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnAddFileWork = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnOpenFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnFileDel = New System.Windows.Forms.ToolStripButton()
        Me.tsPbarCopyFiles = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsbtnSaveFile = New System.Windows.Forms.ToolStripButton()
        Me.tlpPath = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPath1 = New System.Windows.Forms.TextBox()
        Me.btnPath1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPath2 = New System.Windows.Forms.TextBox()
        Me.txtPath3 = New System.Windows.Forms.TextBox()
        Me.btnPath2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnPath3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tlpRouting = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbEmplRout = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnRoutApply = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelRout = New System.Windows.Forms.ToolStripButton()
        Me.cmbRoutDescription = New System.Windows.Forms.ComboBox()
        Me.txtPurposeRout = New System.Windows.Forms.TextBox()
        Me.dgOrderRout = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog3 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip2.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        CType(Me.dgMatExpens,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        CType(Me.dgSpec,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage2.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.tlpFiles.SuspendLayout
        CType(Me.dgFiles,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tlsFiles.SuspendLayout
        Me.tlpPath.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.tlpRouting.SuspendLayout
        Me.ToolStrip4.SuspendLayout
        CType(Me.dgOrderRout,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 691)
        Me.SplitContainer1.SplitterDistance = 586
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgTableData, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(584, 689)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTableData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgTableData, 3)
        Me.dgTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTableData.Location = New System.Drawing.Point(4, 31)
        Me.dgTableData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgTableData.MultiSelect = false
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTableData.Size = New System.Drawing.Size(576, 654)
        Me.dgTableData.TabIndex = 7
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton11, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(512, 27)
        Me.ToolStrip2.TabIndex = 8
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"),System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(82, 24)
        Me.ToolStripButton11.Text = "Обновить"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"),System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(204, 24)
        Me.ToolStripButton4.Text = "Группировка по матераилу"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"),System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(174, 24)
        Me.ToolStripButton5.Text = "Группировка по заказу"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"),System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(40, 24)
        Me.ToolStripButton6.Text = "ннн"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Номер заказа"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(682, 689)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(674, 659)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Спецификация"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.dgMatExpens, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtContent, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ToolStrip1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dgSpec, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 253!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(668, 653)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'dgMatExpens
        '
        Me.dgMatExpens.AllowUserToAddRows = false
        Me.dgMatExpens.AllowUserToDeleteRows = false
        Me.dgMatExpens.AllowUserToResizeRows = false
        Me.dgMatExpens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMatExpens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel4.SetColumnSpan(Me.dgMatExpens, 2)
        Me.dgMatExpens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMatExpens.Location = New System.Drawing.Point(3, 403)
        Me.dgMatExpens.Name = "dgMatExpens"
        Me.dgMatExpens.ReadOnly = true
        Me.dgMatExpens.RowTemplate.Height = 24
        Me.dgMatExpens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMatExpens.Size = New System.Drawing.Size(662, 247)
        Me.dgMatExpens.TabIndex = 15
        '
        'txtContent
        '
        Me.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtContent.Location = New System.Drawing.Point(5, 5)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContent.Multiline = true
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(517, 190)
        Me.txtContent.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.tscmbEmpl, Me.tsbtnStopTask, Me.tsbtnUpdate, Me.ToolStripButton7, Me.tsbtnEndTask, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(527, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(141, 179)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(139, 24)
        Me.ToolStripButton2.Text = "Открыть заказ"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"),System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(139, 24)
        Me.ToolStripButton3.Text = "Переназначить"
        '
        'tscmbEmpl
        '
        Me.tscmbEmpl.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbEmpl.Name = "tscmbEmpl"
        Me.tscmbEmpl.Size = New System.Drawing.Size(168, 27)
        Me.tscmbEmpl.Visible = false
        '
        'tsbtnStopTask
        '
        Me.tsbtnStopTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnStopTask.Image = CType(resources.GetObject("tsbtnStopTask.Image"),System.Drawing.Image)
        Me.tsbtnStopTask.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnStopTask.Name = "tsbtnStopTask"
        Me.tsbtnStopTask.Size = New System.Drawing.Size(139, 24)
        Me.tsbtnStopTask.Text = "Остановить"
        '
        'tsbtnUpdate
        '
        Me.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdate.Image = CType(resources.GetObject("tsbtnUpdate.Image"),System.Drawing.Image)
        Me.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdate.Name = "tsbtnUpdate"
        Me.tsbtnUpdate.Size = New System.Drawing.Size(139, 24)
        Me.tsbtnUpdate.Text = "Применить"
        Me.tsbtnUpdate.Visible = false
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"),System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(139, 24)
        Me.ToolStripButton7.Text = "Списать материал"
        '
        'tsbtnEndTask
        '
        Me.tsbtnEndTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEndTask.Image = CType(resources.GetObject("tsbtnEndTask.Image"),System.Drawing.Image)
        Me.tsbtnEndTask.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEndTask.Name = "tsbtnEndTask"
        Me.tsbtnEndTask.Size = New System.Drawing.Size(139, 24)
        Me.tsbtnEndTask.Text = "Завершить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(139, 24)
        Me.tsbtnExit.Text = "Выход"
        '
        'dgSpec
        '
        Me.dgSpec.AllowUserToAddRows = false
        Me.dgSpec.AllowUserToDeleteRows = false
        Me.dgSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel4.SetColumnSpan(Me.dgSpec, 2)
        Me.dgSpec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSpec.Location = New System.Drawing.Point(4, 204)
        Me.dgSpec.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSpec.Name = "dgSpec"
        Me.dgSpec.RowTemplate.Height = 24
        Me.dgSpec.Size = New System.Drawing.Size(660, 192)
        Me.dgSpec.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(674, 663)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Файлы"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Controls.Add(Me.tlpFiles, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.tlpPath, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(668, 657)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'tlpFiles
        '
        Me.tlpFiles.ColumnCount = 2
        Me.tlpFiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpFiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpFiles.Controls.Add(Me.dgFiles, 0, 0)
        Me.tlpFiles.Controls.Add(Me.tlsFiles, 1, 0)
        Me.tlpFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFiles.Location = New System.Drawing.Point(3, 128)
        Me.tlpFiles.Name = "tlpFiles"
        Me.tlpFiles.RowCount = 1
        Me.tlpFiles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpFiles.Size = New System.Drawing.Size(662, 526)
        Me.tlpFiles.TabIndex = 125
        '
        'dgFiles
        '
        Me.dgFiles.AllowUserToAddRows = false
        Me.dgFiles.AllowUserToDeleteRows = false
        Me.dgFiles.AllowUserToResizeRows = false
        Me.dgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFiles.Location = New System.Drawing.Point(3, 3)
        Me.dgFiles.MultiSelect = false
        Me.dgFiles.Name = "dgFiles"
        Me.dgFiles.ReadOnly = true
        Me.dgFiles.RowTemplate.Height = 24
        Me.dgFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFiles.Size = New System.Drawing.Size(448, 520)
        Me.dgFiles.TabIndex = 0
        '
        'tlsFiles
        '
        Me.tlsFiles.AutoSize = false
        Me.tlsFiles.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsFiles.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlsFiles.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbFileDescript, Me.tsbtnAddFileWork, Me.ToolStripSeparator3, Me.tsbtnOpenFile, Me.tsbtnFileDel, Me.tsPbarCopyFiles, Me.tsbtnSaveFile})
        Me.tlsFiles.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tlsFiles.Location = New System.Drawing.Point(454, 0)
        Me.tlsFiles.Name = "tlsFiles"
        Me.tlsFiles.Size = New System.Drawing.Size(208, 149)
        Me.tlsFiles.TabIndex = 123
        Me.tlsFiles.Text = "ToolStrip8"
        '
        'tscmbFileDescript
        '
        Me.tscmbFileDescript.DropDownWidth = 220
        Me.tscmbFileDescript.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbFileDescript.Items.AddRange(New Object() {"Preview", "Расчет", "Файл заказчика", "На утверждение", "Рабочий макет", "Макет в печать", "Вывод", "Резка", "Клише", "Смета"})
        Me.tscmbFileDescript.MaxDropDownItems = 16
        Me.tscmbFileDescript.Name = "tscmbFileDescript"
        Me.tscmbFileDescript.Size = New System.Drawing.Size(204, 24)
        '
        'tsbtnAddFileWork
        '
        Me.tsbtnAddFileWork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAddFileWork.Image = CType(resources.GetObject("tsbtnAddFileWork.Image"),System.Drawing.Image)
        Me.tsbtnAddFileWork.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddFileWork.Name = "tsbtnAddFileWork"
        Me.tsbtnAddFileWork.Size = New System.Drawing.Size(206, 22)
        Me.tsbtnAddFileWork.Text = "Добавить"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(206, 6)
        '
        'tsbtnOpenFile
        '
        Me.tsbtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOpenFile.Image = CType(resources.GetObject("tsbtnOpenFile.Image"),System.Drawing.Image)
        Me.tsbtnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOpenFile.Name = "tsbtnOpenFile"
        Me.tsbtnOpenFile.Size = New System.Drawing.Size(206, 22)
        Me.tsbtnOpenFile.Text = "Открыть файл"
        '
        'tsbtnFileDel
        '
        Me.tsbtnFileDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFileDel.Image = CType(resources.GetObject("tsbtnFileDel.Image"),System.Drawing.Image)
        Me.tsbtnFileDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFileDel.Name = "tsbtnFileDel"
        Me.tsbtnFileDel.Size = New System.Drawing.Size(206, 22)
        Me.tsbtnFileDel.Text = "Удалить"
        '
        'tsPbarCopyFiles
        '
        Me.tsPbarCopyFiles.Name = "tsPbarCopyFiles"
        Me.tsPbarCopyFiles.Size = New System.Drawing.Size(204, 18)
        '
        'tsbtnSaveFile
        '
        Me.tsbtnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSaveFile.Image = CType(resources.GetObject("tsbtnSaveFile.Image"),System.Drawing.Image)
        Me.tsbtnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSaveFile.Name = "tsbtnSaveFile"
        Me.tsbtnSaveFile.Size = New System.Drawing.Size(112, 22)
        Me.tsbtnSaveFile.Text = "Сохранить как"
        '
        'tlpPath
        '
        Me.tlpPath.AutoSize = true
        Me.tlpPath.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpPath.ColumnCount = 5
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPath.Controls.Add(Me.txtPath1, 1, 0)
        Me.tlpPath.Controls.Add(Me.btnPath1, 2, 0)
        Me.tlpPath.Controls.Add(Me.Label11, 0, 0)
        Me.tlpPath.Controls.Add(Me.Button1, 3, 0)
        Me.tlpPath.Controls.Add(Me.Label14, 0, 1)
        Me.tlpPath.Controls.Add(Me.Label17, 0, 2)
        Me.tlpPath.Controls.Add(Me.txtPath2, 1, 1)
        Me.tlpPath.Controls.Add(Me.txtPath3, 1, 2)
        Me.tlpPath.Controls.Add(Me.btnPath2, 2, 1)
        Me.tlpPath.Controls.Add(Me.Button3, 3, 1)
        Me.tlpPath.Controls.Add(Me.btnPath3, 2, 2)
        Me.tlpPath.Controls.Add(Me.Button5, 3, 2)
        Me.tlpPath.Controls.Add(Me.Button2, 4, 0)
        Me.tlpPath.Controls.Add(Me.Button4, 4, 1)
        Me.tlpPath.Controls.Add(Me.Button6, 4, 2)
        Me.tlpPath.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPath.Location = New System.Drawing.Point(3, 3)
        Me.tlpPath.Name = "tlpPath"
        Me.tlpPath.RowCount = 3
        Me.tlpPath.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPath.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPath.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPath.Size = New System.Drawing.Size(662, 119)
        Me.tlpPath.TabIndex = 1
        '
        'txtPath1
        '
        Me.txtPath1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPath1.Location = New System.Drawing.Point(201, 20)
        Me.txtPath1.Name = "txtPath1"
        Me.txtPath1.Size = New System.Drawing.Size(58, 16)
        Me.txtPath1.TabIndex = 0
        '
        'btnPath1
        '
        Me.btnPath1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnPath1.Location = New System.Drawing.Point(266, 4)
        Me.btnPath1.Name = "btnPath1"
        Me.btnPath1.Size = New System.Drawing.Size(142, 32)
        Me.btnPath1.TabIndex = 1
        Me.btnPath1.Text = "Задать папку"
        Me.btnPath1.UseVisualStyleBackColor = true
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 38)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Исходная папка"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button1.Location = New System.Drawing.Point(415, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Открыть"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(190, 38)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Финальная папка клиента"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(190, 39)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Папка спуска"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPath2
        '
        Me.txtPath2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPath2.Location = New System.Drawing.Point(201, 59)
        Me.txtPath2.Name = "txtPath2"
        Me.txtPath2.Size = New System.Drawing.Size(58, 16)
        Me.txtPath2.TabIndex = 7
        '
        'txtPath3
        '
        Me.txtPath3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPath3.Location = New System.Drawing.Point(201, 99)
        Me.txtPath3.Name = "txtPath3"
        Me.txtPath3.Size = New System.Drawing.Size(58, 16)
        Me.txtPath3.TabIndex = 8
        '
        'btnPath2
        '
        Me.btnPath2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnPath2.Location = New System.Drawing.Point(266, 43)
        Me.btnPath2.Name = "btnPath2"
        Me.btnPath2.Size = New System.Drawing.Size(142, 32)
        Me.btnPath2.TabIndex = 9
        Me.btnPath2.Text = "Задать папку"
        Me.btnPath2.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button3.Location = New System.Drawing.Point(415, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Открыть"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'btnPath3
        '
        Me.btnPath3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnPath3.Location = New System.Drawing.Point(266, 82)
        Me.btnPath3.Name = "btnPath3"
        Me.btnPath3.Size = New System.Drawing.Size(142, 33)
        Me.btnPath3.TabIndex = 11
        Me.btnPath3.Text = "Задать папку"
        Me.btnPath3.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button5.Location = New System.Drawing.Point(415, 82)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 33)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Открыть"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button2.Location = New System.Drawing.Point(540, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Сохранить"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button4.Location = New System.Drawing.Point(540, 43)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 32)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Сохранить"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button6.Location = New System.Drawing.Point(540, 82)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(118, 33)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Сохранить"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.tlpRouting)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(674, 663)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Маршрут"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'tlpRouting
        '
        Me.tlpRouting.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpRouting.ColumnCount = 2
        Me.tlpRouting.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRouting.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRouting.Controls.Add(Me.Label5, 0, 2)
        Me.tlpRouting.Controls.Add(Me.cmbDepartment, 1, 1)
        Me.tlpRouting.Controls.Add(Me.cmbEmplRout, 1, 2)
        Me.tlpRouting.Controls.Add(Me.Label9, 0, 1)
        Me.tlpRouting.Controls.Add(Me.Label1, 0, 3)
        Me.tlpRouting.Controls.Add(Me.ToolStrip4, 0, 5)
        Me.tlpRouting.Controls.Add(Me.cmbRoutDescription, 1, 3)
        Me.tlpRouting.Controls.Add(Me.txtPurposeRout, 0, 4)
        Me.tlpRouting.Controls.Add(Me.dgOrderRout, 0, 0)
        Me.tlpRouting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRouting.Location = New System.Drawing.Point(0, 0)
        Me.tlpRouting.Name = "tlpRouting"
        Me.tlpRouting.RowCount = 6
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.Size = New System.Drawing.Size(674, 663)
        Me.tlpRouting.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(4, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 31)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Сотрудник"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepartment.FormattingEnabled = true
        Me.cmbDepartment.Location = New System.Drawing.Point(109, 301)
        Me.cmbDepartment.MaxDropDownItems = 20
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(722, 25)
        Me.cmbDepartment.TabIndex = 7
        '
        'cmbEmplRout
        '
        Me.cmbEmplRout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEmplRout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmplRout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEmplRout.FormattingEnabled = true
        Me.cmbEmplRout.Location = New System.Drawing.Point(109, 333)
        Me.cmbEmplRout.MaxDropDownItems = 30
        Me.cmbEmplRout.Name = "cmbEmplRout"
        Me.cmbEmplRout.Size = New System.Drawing.Size(722, 25)
        Me.cmbEmplRout.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(4, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 31)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Департамент"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(4, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Описание"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip4
        '
        Me.tlpRouting.SetColumnSpan(Me.ToolStrip4, 2)
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnRoutApply, Me.tsbtnDelRout})
        Me.ToolStrip4.Location = New System.Drawing.Point(1, 637)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(833, 25)
        Me.ToolStrip4.TabIndex = 10
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'tsbtnRoutApply
        '
        Me.tsbtnRoutApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnRoutApply.Image = CType(resources.GetObject("tsbtnRoutApply.Image"),System.Drawing.Image)
        Me.tsbtnRoutApply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnRoutApply.Name = "tsbtnRoutApply"
        Me.tsbtnRoutApply.Size = New System.Drawing.Size(89, 22)
        Me.tsbtnRoutApply.Text = "Применить"
        '
        'tsbtnDelRout
        '
        Me.tsbtnDelRout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelRout.Image = CType(resources.GetObject("tsbtnDelRout.Image"),System.Drawing.Image)
        Me.tsbtnDelRout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelRout.Name = "tsbtnDelRout"
        Me.tsbtnDelRout.Size = New System.Drawing.Size(71, 22)
        Me.tsbtnDelRout.Text = "Удалить"
        Me.tsbtnDelRout.Visible = false
        '
        'cmbRoutDescription
        '
        Me.cmbRoutDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbRoutDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoutDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbRoutDescription.FormattingEnabled = true
        Me.cmbRoutDescription.Items.AddRange(New Object() {"Запустить в производство", "Полка №     Кол-во мест:", "Склад №", "Заказ из копи-центра", "Файл на утверждение готов", "Рабочий макет готов", "Сделать спуск, отправить на печать", "Задание отклонено по причине:", "Печать завершена", "Из после-печатной обработки сделано:", "Складировано на ЗИЛ1, кол-во мест:", "Складировано на ЗИЛ3, кол-во мест:"})
        Me.cmbRoutDescription.Location = New System.Drawing.Point(109, 365)
        Me.cmbRoutDescription.Name = "cmbRoutDescription"
        Me.cmbRoutDescription.Size = New System.Drawing.Size(722, 25)
        Me.cmbRoutDescription.TabIndex = 11
        '
        'txtPurposeRout
        '
        Me.tlpRouting.SetColumnSpan(Me.txtPurposeRout, 2)
        Me.txtPurposeRout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPurposeRout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPurposeRout.Location = New System.Drawing.Point(4, 397)
        Me.txtPurposeRout.Multiline = true
        Me.txtPurposeRout.Name = "txtPurposeRout"
        Me.txtPurposeRout.Size = New System.Drawing.Size(827, 236)
        Me.txtPurposeRout.TabIndex = 12
        '
        'dgOrderRout
        '
        Me.dgOrderRout.AllowUserToAddRows = false
        Me.dgOrderRout.AllowUserToDeleteRows = false
        Me.dgOrderRout.AllowUserToResizeRows = false
        Me.dgOrderRout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgOrderRout.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgOrderRout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpRouting.SetColumnSpan(Me.dgOrderRout, 2)
        Me.dgOrderRout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrderRout.Location = New System.Drawing.Point(4, 4)
        Me.dgOrderRout.MultiSelect = false
        Me.dgOrderRout.Name = "dgOrderRout"
        Me.dgOrderRout.ReadOnly = true
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dgOrderRout.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgOrderRout.RowTemplate.Height = 24
        Me.dgOrderRout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrderRout.Size = New System.Drawing.Size(827, 290)
        Me.dgOrderRout.TabIndex = 4
        '
        'Timer1
        '
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = true
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Выберите папку исходных файлов"
        '
        'FolderBrowserDialog2
        '
        Me.FolderBrowserDialog2.Description = "Выберите финальную папку"
        '
        'FolderBrowserDialog3
        '
        Me.FolderBrowserDialog3.Description = "Выберите папку спуска полос"
        '
        'tech_TasksInWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 691)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimizeBox = false
        Me.Name = "tech_TasksInWork"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_TasksInWork"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        CType(Me.dgMatExpens,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.dgSpec,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage2.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.tlpFiles.ResumeLayout(false)
        CType(Me.dgFiles,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlsFiles.ResumeLayout(false)
        Me.tlsFiles.PerformLayout
        Me.tlpPath.ResumeLayout(false)
        Me.tlpPath.PerformLayout
        Me.TabPage3.ResumeLayout(false)
        Me.tlpRouting.ResumeLayout(false)
        Me.tlpRouting.PerformLayout
        Me.ToolStrip4.ResumeLayout(false)
        Me.ToolStrip4.PerformLayout
        CType(Me.dgOrderRout,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    ' Friend WithEvents Countdown1 As PerfectCRM.Countdown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    '   Friend WithEvents Countdown2 As PerfectCRM.Countdown
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tscmbEmpl As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnStopTask As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEndTask As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgSpec As System.Windows.Forms.DataGridView
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgMatExpens As System.Windows.Forms.DataGridView
    Friend WithEvents tlpPath As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPath1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPath1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPath2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPath3 As System.Windows.Forms.TextBox
    Friend WithEvents btnPath2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnPath3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents tlpRouting As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEmplRout As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnRoutApply As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelRout As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbRoutDescription As System.Windows.Forms.ComboBox
    Friend WithEvents txtPurposeRout As System.Windows.Forms.TextBox
    Friend WithEvents dgOrderRout As System.Windows.Forms.DataGridView
    Friend WithEvents tlpFiles As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgFiles As System.Windows.Forms.DataGridView
    Friend WithEvents tlsFiles As System.Windows.Forms.ToolStrip
    Friend WithEvents tscmbFileDescript As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbtnAddFileWork As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnOpenFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnFileDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPbarCopyFiles As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tsbtnSaveFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog3 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
