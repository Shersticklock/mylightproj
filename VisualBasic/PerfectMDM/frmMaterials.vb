Public Class frmMaterials
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstMaterials As System.Windows.Forms.ListBox
    Friend WithEvents txtmatName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tlpAttrMat As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbMatType As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNewMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEditMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSaveMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDeleteMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNacenka As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCatMat As System.Windows.Forms.ComboBox
    Friend WithEvents tsOperations As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnUnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstSelect As System.Windows.Forms.ListBox
    Friend WithEvents tstxtBayCost As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tvMat As System.Windows.Forms.TreeView
    Friend WithEvents iml1 As System.Windows.Forms.ImageList
    Friend WithEvents cmsTV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmAddCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAddTypeInCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtPriceOut As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmbTech As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents КопироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВставитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtmatID As System.Windows.Forms.TextBox
    Friend WithEvents tlpMat As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ЕдиницыУчетаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КопироватьToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nudCoefficient As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbAcces As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMatGroup As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tscmbUnit As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tscmbSelectMode As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbtnDelSklad As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsMat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents СоздатьЕдиницыУчетаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents clbUnits As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnCreateCostUnits As System.Windows.Forms.Button
    Friend WithEvents tsmDelType As System.Windows.Forms.ToolStripMenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterials))
        Me.lstMaterials = New System.Windows.Forms.ListBox()
        Me.cmsMat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.СоздатьЕдиницыУчетаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtmatName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.clbUnits = New System.Windows.Forms.CheckedListBox()
        Me.btnCreateCostUnits = New System.Windows.Forms.Button()
        Me.tlpAttrMat = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNewMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEditMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSaveMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDeleteMat = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMatType = New System.Windows.Forms.ComboBox()
        Me.txtNacenka = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCatMat = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudCoefficient = New System.Windows.Forms.NumericUpDown()
        Me.cmbAcces = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMatGroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmatID = New System.Windows.Forms.TextBox()
        Me.lstSelect = New System.Windows.Forms.ListBox()
        Me.tsOperations = New System.Windows.Forms.ToolStrip()
        Me.tscmbSelectMode = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tscmbUnit = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtBayCost = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtPriceOut = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnUnSelect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnDelSklad = New System.Windows.Forms.ToolStripButton()
        Me.tvMat = New System.Windows.Forms.TreeView()
        Me.cmsTV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmAddCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAddTypeInCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDelCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDelType = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЕдиницыУчетаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопироватьToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.iml1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmbTech = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlpMat = New System.Windows.Forms.TableLayoutPanel()
        Me.cmsMat.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.tlpAttrMat.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        CType(Me.nudCoefficient,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tsOperations.SuspendLayout
        Me.cmsTV.SuspendLayout
        Me.tlpMat.SuspendLayout
        Me.SuspendLayout
        '
        'lstMaterials
        '
        Me.lstMaterials.ContextMenuStrip = Me.cmsMat
        Me.lstMaterials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMaterials.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstMaterials.HorizontalScrollbar = true
        Me.lstMaterials.ItemHeight = 17
        Me.lstMaterials.Location = New System.Drawing.Point(3, 3)
        Me.lstMaterials.Name = "lstMaterials"
        Me.lstMaterials.Size = New System.Drawing.Size(414, 534)
        Me.lstMaterials.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstMaterials, "Перечень материалов выбранного типа")
        '
        'cmsMat
        '
        Me.cmsMat.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsMat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsMat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздатьЕдиницыУчетаToolStripMenuItem})
        Me.cmsMat.Name = "cmsMat"
        Me.cmsMat.Size = New System.Drawing.Size(242, 28)
        '
        'СоздатьЕдиницыУчетаToolStripMenuItem
        '
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.CheckOnClick = true
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.Name = "СоздатьЕдиницыУчетаToolStripMenuItem"
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.СоздатьЕдиницыУчетаToolStripMenuItem.Text = "Создать единицы учета"
        '
        'txtmatName
        '
        Me.txtmatName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtmatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtmatName.Location = New System.Drawing.Point(165, 67)
        Me.txtmatName.MaxLength = 250
        Me.txtmatName.Name = "txtmatName"
        Me.txtmatName.Size = New System.Drawing.Size(156, 24)
        Me.txtmatName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Наименование"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(3, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 30)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Наценка/ бонус (%)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(322, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tlpAttrMat)
        Me.SplitContainer1.Size = New System.Drawing.Size(951, 699)
        Me.SplitContainer1.SplitterDistance = 428
        Me.SplitContainer1.TabIndex = 43
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 697!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(426, 697)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.clbUnits, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lstMaterials, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCreateCostUnits, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(420, 691)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'clbUnits
        '
        Me.clbUnits.CheckOnClick = true
        Me.clbUnits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbUnits.FormattingEnabled = true
        Me.clbUnits.Location = New System.Drawing.Point(3, 543)
        Me.clbUnits.Name = "clbUnits"
        Me.clbUnits.Size = New System.Drawing.Size(414, 109)
        Me.clbUnits.TabIndex = 10
        Me.clbUnits.Visible = false
        '
        'btnCreateCostUnits
        '
        Me.btnCreateCostUnits.AutoSize = true
        Me.btnCreateCostUnits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCreateCostUnits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreateCostUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateCostUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnCreateCostUnits.Location = New System.Drawing.Point(3, 658)
        Me.btnCreateCostUnits.Name = "btnCreateCostUnits"
        Me.btnCreateCostUnits.Size = New System.Drawing.Size(414, 30)
        Me.btnCreateCostUnits.TabIndex = 11
        Me.btnCreateCostUnits.Text = "Создать"
        Me.btnCreateCostUnits.UseVisualStyleBackColor = true
        Me.btnCreateCostUnits.Visible = false
        '
        'tlpAttrMat
        '
        Me.tlpAttrMat.ColumnCount = 3
        Me.tlpAttrMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAttrMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAttrMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAttrMat.Controls.Add(Me.Label13, 0, 1)
        Me.tlpAttrMat.Controls.Add(Me.ToolStrip1, 2, 0)
        Me.tlpAttrMat.Controls.Add(Me.Label3, 0, 2)
        Me.tlpAttrMat.Controls.Add(Me.txtmatName, 1, 2)
        Me.tlpAttrMat.Controls.Add(Me.Label6, 0, 4)
        Me.tlpAttrMat.Controls.Add(Me.Label4, 0, 5)
        Me.tlpAttrMat.Controls.Add(Me.cmbMatType, 1, 1)
        Me.tlpAttrMat.Controls.Add(Me.txtNacenka, 1, 4)
        Me.tlpAttrMat.Controls.Add(Me.Label8, 0, 0)
        Me.tlpAttrMat.Controls.Add(Me.cmbCatMat, 1, 0)
        Me.tlpAttrMat.Controls.Add(Me.Label10, 0, 6)
        Me.tlpAttrMat.Controls.Add(Me.nudCoefficient, 1, 6)
        Me.tlpAttrMat.Controls.Add(Me.cmbAcces, 1, 5)
        Me.tlpAttrMat.Controls.Add(Me.Label1, 0, 3)
        Me.tlpAttrMat.Controls.Add(Me.cmbMatGroup, 1, 3)
        Me.tlpAttrMat.Controls.Add(Me.Label2, 0, 8)
        Me.tlpAttrMat.Controls.Add(Me.txtmatID, 0, 7)
        Me.tlpAttrMat.Controls.Add(Me.lstSelect, 0, 9)
        Me.tlpAttrMat.Controls.Add(Me.tsOperations, 2, 9)
        Me.tlpAttrMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAttrMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpAttrMat.Location = New System.Drawing.Point(0, 0)
        Me.tlpAttrMat.Name = "tlpAttrMat"
        Me.tlpAttrMat.RowCount = 10
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32!))
        Me.tlpAttrMat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18!))
        Me.tlpAttrMat.Size = New System.Drawing.Size(517, 697)
        Me.tlpAttrMat.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(3, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 32)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Тип материала"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNewMat, Me.tsbtnEditMat, Me.tsbtnSaveMat, Me.tsbtnDeleteMat, Me.tsbtnCancel, Me.ToolStripSeparator2, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(324, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.tlpAttrMat.SetRowSpan(Me.ToolStrip1, 8)
        Me.ToolStrip1.Size = New System.Drawing.Size(193, 250)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'tsbtnNewMat
        '
        Me.tsbtnNewMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewMat.Enabled = false
        Me.tsbtnNewMat.Image = CType(resources.GetObject("tsbtnNewMat.Image"),System.Drawing.Image)
        Me.tsbtnNewMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewMat.Name = "tsbtnNewMat"
        Me.tsbtnNewMat.Size = New System.Drawing.Size(191, 22)
        Me.tsbtnNewMat.Text = "Создать"
        Me.tsbtnNewMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnEditMat
        '
        Me.tsbtnEditMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEditMat.Image = CType(resources.GetObject("tsbtnEditMat.Image"),System.Drawing.Image)
        Me.tsbtnEditMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditMat.Name = "tsbtnEditMat"
        Me.tsbtnEditMat.Size = New System.Drawing.Size(191, 22)
        Me.tsbtnEditMat.Text = "Изменить"
        Me.tsbtnEditMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnSaveMat
        '
        Me.tsbtnSaveMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSaveMat.Image = CType(resources.GetObject("tsbtnSaveMat.Image"),System.Drawing.Image)
        Me.tsbtnSaveMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSaveMat.Name = "tsbtnSaveMat"
        Me.tsbtnSaveMat.Size = New System.Drawing.Size(191, 22)
        Me.tsbtnSaveMat.Text = "Сохранить"
        Me.tsbtnSaveMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnDeleteMat
        '
        Me.tsbtnDeleteMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDeleteMat.Image = CType(resources.GetObject("tsbtnDeleteMat.Image"),System.Drawing.Image)
        Me.tsbtnDeleteMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDeleteMat.Name = "tsbtnDeleteMat"
        Me.tsbtnDeleteMat.Size = New System.Drawing.Size(191, 22)
        Me.tsbtnDeleteMat.Text = "Удалить"
        Me.tsbtnDeleteMat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(191, 22)
        Me.tsbtnCancel.Text = "Отмена"
        Me.tsbtnCancel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(191, 6)
        Me.ToolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(191, 22)
        Me.tsbtnExit.Text = "Выход"
        Me.tsbtnExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(3, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Доступность"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMatType
        '
        Me.cmbMatType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMatType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatType.FormattingEnabled = true
        Me.cmbMatType.Location = New System.Drawing.Point(165, 35)
        Me.cmbMatType.Name = "cmbMatType"
        Me.cmbMatType.Size = New System.Drawing.Size(156, 25)
        Me.cmbMatType.TabIndex = 1
        Me.cmbMatType.TabStop = false
        '
        'txtNacenka
        '
        Me.txtNacenka.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNacenka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNacenka.Location = New System.Drawing.Point(165, 129)
        Me.txtNacenka.Name = "txtNacenka"
        Me.txtNacenka.Size = New System.Drawing.Size(156, 24)
        Me.txtNacenka.TabIndex = 3
        Me.txtNacenka.Text = "0"
        Me.txtNacenka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 32)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Категория"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCatMat
        '
        Me.cmbCatMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCatMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCatMat.Enabled = false
        Me.cmbCatMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCatMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCatMat.FormattingEnabled = true
        Me.cmbCatMat.Location = New System.Drawing.Point(165, 3)
        Me.cmbCatMat.Name = "cmbCatMat"
        Me.cmbCatMat.Size = New System.Drawing.Size(156, 25)
        Me.cmbCatMat.TabIndex = 0
        Me.cmbCatMat.TabStop = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 32)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Коэфициент"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudCoefficient
        '
        Me.nudCoefficient.DecimalPlaces = 2
        Me.nudCoefficient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCoefficient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudCoefficient.Location = New System.Drawing.Point(165, 191)
        Me.nudCoefficient.Name = "nudCoefficient"
        Me.nudCoefficient.Size = New System.Drawing.Size(156, 26)
        Me.nudCoefficient.TabIndex = 9
        Me.nudCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbAcces
        '
        Me.cmbAcces.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAcces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAcces.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbAcces.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbAcces.FormattingEnabled = true
        Me.cmbAcces.Items.AddRange(New Object() {"Не доступен", "Доступен"})
        Me.cmbAcces.Location = New System.Drawing.Point(165, 159)
        Me.cmbAcces.Name = "cmbAcces"
        Me.cmbAcces.Size = New System.Drawing.Size(156, 25)
        Me.cmbAcces.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(3, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 32)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Адрес хранения"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMatGroup
        '
        Me.cmbMatGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMatGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatGroup.FormattingEnabled = true
        Me.cmbMatGroup.Location = New System.Drawing.Point(165, 97)
        Me.cmbMatGroup.Name = "cmbMatGroup"
        Me.cmbMatGroup.Size = New System.Drawing.Size(156, 25)
        Me.cmbMatGroup.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.tlpAttrMat.SetColumnSpan(Me.Label2, 3)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(511, 32)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Установки закупочной и продажной стоимости единиц учета"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtmatID
        '
        Me.txtmatID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtmatID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtmatID.Location = New System.Drawing.Point(3, 223)
        Me.txtmatID.Name = "txtmatID"
        Me.txtmatID.ReadOnly = true
        Me.txtmatID.Size = New System.Drawing.Size(156, 24)
        Me.txtmatID.TabIndex = 10
        Me.txtmatID.TabStop = false
        '
        'lstSelect
        '
        Me.tlpAttrMat.SetColumnSpan(Me.lstSelect, 2)
        Me.lstSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstSelect.FormattingEnabled = true
        Me.lstSelect.ItemHeight = 17
        Me.lstSelect.Location = New System.Drawing.Point(3, 285)
        Me.lstSelect.MultiColumn = true
        Me.lstSelect.Name = "lstSelect"
        Me.lstSelect.Size = New System.Drawing.Size(318, 409)
        Me.lstSelect.TabIndex = 72
        '
        'tsOperations
        '
        Me.tsOperations.Dock = System.Windows.Forms.DockStyle.None
        Me.tsOperations.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsOperations.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbSelectMode, Me.ToolStripLabel3, Me.tscmbUnit, Me.ToolStripLabel1, Me.tstxtBayCost, Me.ToolStripLabel2, Me.tstxtPriceOut, Me.tsbtnSelect, Me.tsbtnUnSelect, Me.ToolStripSeparator1, Me.tsbtnDelSklad})
        Me.tsOperations.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsOperations.Location = New System.Drawing.Point(324, 282)
        Me.tsOperations.Name = "tsOperations"
        Me.tsOperations.Size = New System.Drawing.Size(193, 259)
        Me.tsOperations.TabIndex = 71
        Me.tsOperations.Text = "ToolStrip2"
        '
        'tscmbSelectMode
        '
        Me.tscmbSelectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbSelectMode.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbSelectMode.Items.AddRange(New Object() {"Все", "Внутренние", "Покупные"})
        Me.tscmbSelectMode.Name = "tscmbSelectMode"
        Me.tscmbSelectMode.Size = New System.Drawing.Size(189, 28)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(191, 18)
        Me.ToolStripLabel3.Text = "Выбрать ед. измерения"
        '
        'tscmbUnit
        '
        Me.tscmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbUnit.MaxDropDownItems = 24
        Me.tscmbUnit.Name = "tscmbUnit"
        Me.tscmbUnit.Size = New System.Drawing.Size(189, 26)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(191, 18)
        Me.ToolStripLabel1.Text = "Закупочная стоимость"
        '
        'tstxtBayCost
        '
        Me.tstxtBayCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtBayCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtBayCost.Name = "tstxtBayCost"
        Me.tstxtBayCost.Size = New System.Drawing.Size(189, 24)
        Me.tstxtBayCost.Text = "0"
        Me.tstxtBayCost.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(191, 18)
        Me.ToolStripLabel2.Text = "Стоимость продажи"
        '
        'tstxtPriceOut
        '
        Me.tstxtPriceOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtPriceOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtPriceOut.Name = "tstxtPriceOut"
        Me.tstxtPriceOut.Size = New System.Drawing.Size(189, 24)
        Me.tstxtPriceOut.Text = "0"
        Me.tstxtPriceOut.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnSelect
        '
        Me.tsbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnSelect.Image = CType(resources.GetObject("tsbtnSelect.Image"),System.Drawing.Image)
        Me.tsbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSelect.Name = "tsbtnSelect"
        Me.tsbtnSelect.Size = New System.Drawing.Size(191, 22)
        Me.tsbtnSelect.Text = "Применить >>>"
        '
        'tsbtnUnSelect
        '
        Me.tsbtnUnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnUnSelect.Image = CType(resources.GetObject("tsbtnUnSelect.Image"),System.Drawing.Image)
        Me.tsbtnUnSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUnSelect.Name = "tsbtnUnSelect"
        Me.tsbtnUnSelect.Size = New System.Drawing.Size(191, 22)
        Me.tsbtnUnSelect.Text = "Удалить <<<"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'tsbtnDelSklad
        '
        Me.tsbtnDelSklad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelSklad.Image = CType(resources.GetObject("tsbtnDelSklad.Image"),System.Drawing.Image)
        Me.tsbtnDelSklad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelSklad.Name = "tsbtnDelSklad"
        Me.tsbtnDelSklad.Size = New System.Drawing.Size(191, 24)
        Me.tsbtnDelSklad.Text = "Удалить со склада"
        '
        'tvMat
        '
        Me.tvMat.ContextMenuStrip = Me.cmsTV
        Me.tvMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMat.Location = New System.Drawing.Point(3, 3)
        Me.tvMat.Name = "tvMat"
        Me.tvMat.Size = New System.Drawing.Size(313, 699)
        Me.tvMat.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tvMat, "Первый уровень - категории, второй уровень - типы материалов")
        '
        'cmsTV
        '
        Me.cmsTV.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsTV.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAddCat, Me.tsmAddTypeInCat, Me.tsmDelCat, Me.tsmDelType, Me.КопироватьToolStripMenuItem, Me.ВставитьToolStripMenuItem, Me.ЕдиницыУчетаToolStripMenuItem, Me.КопироватьToolStripMenuItem1})
        Me.cmsTV.Name = "cmsTV"
        Me.cmsTV.Size = New System.Drawing.Size(220, 180)
        '
        'tsmAddCat
        '
        Me.tsmAddCat.Name = "tsmAddCat"
        Me.tsmAddCat.Size = New System.Drawing.Size(219, 22)
        Me.tsmAddCat.Text = "Добавить категорию"
        '
        'tsmAddTypeInCat
        '
        Me.tsmAddTypeInCat.Name = "tsmAddTypeInCat"
        Me.tsmAddTypeInCat.Size = New System.Drawing.Size(219, 22)
        Me.tsmAddTypeInCat.Text = "Добавить тип"
        '
        'tsmDelCat
        '
        Me.tsmDelCat.Name = "tsmDelCat"
        Me.tsmDelCat.Size = New System.Drawing.Size(219, 22)
        Me.tsmDelCat.Text = "Удалить категорию"
        '
        'tsmDelType
        '
        Me.tsmDelType.Name = "tsmDelType"
        Me.tsmDelType.Size = New System.Drawing.Size(219, 22)
        Me.tsmDelType.Text = "Удалить тип"
        '
        'КопироватьToolStripMenuItem
        '
        Me.КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        Me.КопироватьToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.КопироватьToolStripMenuItem.Text = "Вырезать"
        '
        'ВставитьToolStripMenuItem
        '
        Me.ВставитьToolStripMenuItem.Name = "ВставитьToolStripMenuItem"
        Me.ВставитьToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ВставитьToolStripMenuItem.Text = "Вставить"
        '
        'ЕдиницыУчетаToolStripMenuItem
        '
        Me.ЕдиницыУчетаToolStripMenuItem.Name = "ЕдиницыУчетаToolStripMenuItem"
        Me.ЕдиницыУчетаToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ЕдиницыУчетаToolStripMenuItem.Text = "Единицы учета"
        '
        'КопироватьToolStripMenuItem1
        '
        Me.КопироватьToolStripMenuItem1.Name = "КопироватьToolStripMenuItem1"
        Me.КопироватьToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.КопироватьToolStripMenuItem1.Text = "Копировать"
        '
        'iml1
        '
        Me.iml1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iml1.ImageSize = New System.Drawing.Size(16, 16)
        Me.iml1.TransparentColor = System.Drawing.Color.Transparent
        '
        'cmbTech
        '
        Me.cmbTech.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTech.FormattingEnabled = true
        Me.cmbTech.Location = New System.Drawing.Point(184, 3)
        Me.cmbTech.Name = "cmbTech"
        Me.cmbTech.Size = New System.Drawing.Size(207, 21)
        Me.cmbTech.TabIndex = 47
        '
        'tlpMat
        '
        Me.tlpMat.ColumnCount = 3
        Me.tlpMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.tlpMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75!))
        Me.tlpMat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMat.Controls.Add(Me.tvMat, 0, 0)
        Me.tlpMat.Controls.Add(Me.SplitContainer1, 1, 0)
        Me.tlpMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMat.Location = New System.Drawing.Point(0, 0)
        Me.tlpMat.Name = "tlpMat"
        Me.tlpMat.RowCount = 1
        Me.tlpMat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpMat.Size = New System.Drawing.Size(1276, 705)
        Me.tlpMat.TabIndex = 44
        '
        'frmMaterials
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(1276, 705)
        Me.Controls.Add(Me.tlpMat)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimizeBox = false
        Me.Name = "frmMaterials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Номенклатура материалов"
        Me.cmsMat.ResumeLayout(false)
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.tlpAttrMat.ResumeLayout(false)
        Me.tlpAttrMat.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.nudCoefficient,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsOperations.ResumeLayout(false)
        Me.tsOperations.PerformLayout
        Me.cmsTV.ResumeLayout(false)
        Me.tlpMat.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

#End Region

    Dim mblnAdd As Boolean
    Dim currentID%
    Dim copy As Boolean = False

#Region " Загрузка формы "
    Private Sub frmMaterials_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim odaGroup As New SqlClient.SqlDataAdapter("SELECT ID, name From MatGroups order by name", mcnnInt)
            Dim dtGroup As New DataTable : odaGroup.Fill(dtGroup)

            Me.cmbMatGroup.DataSource = dtGroup
            Me.cmbMatGroup.DisplayMember = "name"
            Me.cmbMatGroup.ValueMember = "ID"
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try

        PopulateCategories()

        ActivateEditing(False)

        Me.cmsMat.Visible = False
        Me.tsbtnDelSklad.Visible = False
        Me.btnCreateCostUnits.Visible = False
        Me.clbUnits.Visible = False

    End Sub
#End Region

    Sub PopulateCategories()
        Me.tvMat.Nodes.Clear()

        Dim pNode As TreeNode ' parent
        Dim cNode As TreeNode ' child
        Dim odaMat1 As New SqlClient.SqlDataAdapter("Select ID, Name From MatCategories order by name", mcnnInt)
        Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)


        For Each row As DataRow In dtMat1.Rows
            pNode = Me.tvMat.Nodes.Add(row("Name")) ' add parent
            pNode.Tag = row("ID").ToString()

            Dim odaMat2 As New SqlClient.SqlDataAdapter("Select ID, Name From MatTypes WHERE matCatID= " & row("ID") & " order by name", mcnnInt)
            Dim dtMat2 As New DataTable : odaMat2.Fill(dtMat2)

            For Each row1 As DataRow In dtMat2.Rows 'ResultSet1.Tables(0).Rows
                cNode = New TreeNode ' another way to add controls - create before adding
                cNode.Text = row1("Name") '.ToString()
                cNode.Tag = row1("ID").ToString()
                pNode.Nodes.Add(cNode) ' add child
            Next
        Next
    End Sub

    Private Sub tvMat_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMat.AfterSelect
        LoadList()

        Me.tsbtnNewMat.Enabled = True
    End Sub

#Region " Загрузка лист материлов "
    Private Sub LoadList()
        Select Case Me.tvMat.SelectedNode.Level
            Case Is = 0
                Me.lstMaterials.DataSource = Nothing
                Exit Sub
            Case Is = 1
                Try
                    Dim odaMatList As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE Materials.matCatID=" & Me.tvMat.SelectedNode.Parent.Tag & " AND Materials.typeID=" & Me.tvMat.SelectedNode.Tag & " order by matName", mcnnInt)
                    Dim dtMatList As New DataTable : odaMatList.Fill(dtMatList)

                    '  Dim viewMat As New DataView(dtMatList)

                    'If Me.rbSortAlfavit.Checked = True Then
                    '    viewMat.Sort = "matName"
                    'Else
                    '    viewMat.Sort = "priceOut"
                    'End If

                    Me.lstMaterials.DataSource = dtMatList  'Связать данные со списком
                    Me.lstMaterials.DisplayMember = "matName"
                    Me.lstMaterials.ValueMember = "matID"
                Catch oexpData As System.Exception
                    MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
                End Try
        End Select
    End Sub
#End Region

    Dim mdrMatIndiv As DataRow

#Region " Загрузка параметров материала "
    Private Sub LoadIndividual()
        Dim strName As String
        Dim oCtl As Object
        Dim dtMat As New DataTable
        Dim modaMatIndiv As SqlClient.SqlDataAdapter

        If Me.lstMaterials.SelectedIndex <> -1 Then
            Try
                modaMatIndiv = New SqlClient.SqlDataAdapter("SELECT * FROM Materials WHERE matID=" & Me.lstMaterials.SelectedItem(0) & "", mcnnInt)
                modaMatIndiv.Fill(dtMat)
                mdrMatIndiv = dtMat.Rows(0)

                For Each oCtl In Me.tlpAttrMat.Controls
                    If TypeOf oCtl Is TextBox Then
                        strName = Mid(oCtl.name, 4)
                        Try
                            oCtl.text = mdrMatIndiv(strName).ToString
                        Catch oexp As System.Exception
                        End Try
                    End If
                Next

                Me.cmbMatGroup.SelectedValue = mdrMatIndiv("groupID")

                If mdrMatIndiv("accessible") = True Then
                    Me.cmbAcces.SelectedIndex = 1
                Else
                    Me.cmbAcces.SelectedIndex = 0
                End If

                Me.nudCoefficient.Value = mdrMatIndiv("coefficient")

            Catch oexpData As System.Exception
                MessageBox.Show("Error загрузки данных материала: " & oexpData.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub
#End Region

#Region " Добавить материал "
    Private Sub tsbtnNewMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNewMat.Click
        'If Me.cmbCatMat.SelectedIndex = -1 Or Me.cmbMatType.SelectedIndex = -1 Then
        'gBox("Выбери категорию и тип материала в иерархическом списке.", MsgBoxStyle.Information, appName) : Exit Sub
        ' End If
        '    If Me.tvMat.SelectedNode.Level < 1 Then
        ' MsgBox("Выбери категорию и тип материала в иерархическом списке.") : Exit Sub
        ' End If

        '  For Each oCtl As Object In Me.TableLayoutPanel1.Controls
        'If TypeOf oCtl Is TextBox Then oCtl.text = Nothing
        'Next
        Me.tsOperations.Enabled = False
        Me.lstSelect.Enabled = False
        Me.lstSelect.DataSource = Nothing

        Try
            If Me.tvMat.SelectedNode.Level = 0 Then
                MsgBox("Не выбра тип материала", MsgBoxStyle.Critical, appName)
                Exit Sub
            Else
                mblnAdd = True
                ActivateEditing(True)

                Me.cmbCatMat.SelectedItem(0) = Me.tvMat.SelectedNode.Parent.Tag
                Me.cmbMatType.SelectedItem(0) = Me.tvMat.SelectedNode.Tag

                Me.cmbCatMat.Enabled = False
                Me.cmbMatType.Enabled = False
            End If
        Catch ex As System.Exception
            MessageBox.Show("Error Occured:" & ex.Message, appName)
            Exit Sub
        End Try
    End Sub
#End Region

#Region " Активация редактирования материала "
    Private Sub ActivateEditing(ByVal bEnable As Boolean)
        ' Если редактирование разрешено то перемещение по запрещено

        Me.lstMaterials.Enabled = Not bEnable
        Me.tvMat.Enabled = Not bEnable

        Dim oCurr As Object

        For Each oCurr In Me.tlpAttrMat.Controls() 'обработать в цикле каждый элемент в форме
            If TypeOf oCurr Is ComboBox Then
                oCurr.Enabled = bEnable
                If oCurr.Enabled = False Then
                    oCurr.BackColor() = System.Drawing.Color.White
                End If
            End If

            If TypeOf oCurr Is TextBox Then
                oCurr.Enabled = bEnable
                If oCurr.Enabled = False Then
                    oCurr.BackColor() = System.Drawing.Color.White
                End If
                If mblnAdd = True Then
                    oCurr.text = Nothing
                End If
            End If
        Next

        Me.tsbtnNewMat.Enabled = Not bEnable
        Me.tsbtnEditMat.Enabled = Not bEnable
        Me.tsbtnDeleteMat.Enabled = Not bEnable
        Me.cmbCatMat.Visible = bEnable
        Me.cmbMatType.Visible = bEnable
        Me.Label8.Visible = bEnable
        Me.Label13.Visible = bEnable
        Me.nudCoefficient.Enabled = bEnable


        If bEnable = True Then
            Dim odaType1 As New SqlClient.SqlDataAdapter("SELECT ID, name From MatCategories order by Name", mcnnInt)
            Dim dtType1 As New DataTable : odaType1.Fill(dtType1)

            Me.cmbCatMat.DataSource = dtType1
            Me.cmbCatMat.DisplayMember = "name"
            Me.cmbCatMat.ValueMember = "ID"

            Me.cmbCatMat.SelectedValue = Me.tvMat.SelectedNode.Parent.Tag
            Me.cmbMatType.SelectedValue = Me.tvMat.SelectedNode.Tag
        End If

        Me.txtmatName.Focus()
    End Sub
#End Region

#Region " Удалить материал "
    Private Sub tsbtnDeleteMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDeleteMat.Click
        If Me.lstMaterials.SelectedItems.Count = 0 Then
            MsgBox("Не выбран материал для удаления.", MsgBoxStyle.Critical, appName)
        Else
            If MessageBox.Show("Удалить " & Me.lstMaterials.SelectedItem(1) & "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Module1.NonQuery1("DELETE FROM Materials WHERE matID=" & Me.lstMaterials.SelectedItem(0) & "")
                    LoadList()
                Catch ex As System.Exception
                    MsgBox("Возникла ошибка при удалении материала. " & Chr(13) & "Скорее всего с использованием этого материала оформлен заказ." & Chr(13) & "Рекомендуется изменить реквизит материала Доступность", MsgBoxStyle.Critical, appName)
                End Try
            End If
        End If
    End Sub
#End Region

#Region " Сохранить изменения "
    Private Sub SaveRecord()
        If Me.txtmatName.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtmatName, "Поле наименование должно быть заполнено")
            Me.txtmatName.Focus()
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        'If Me.txtPriceout.Text = "" Or IsNumeric(Replace(Me.txtPriceout.Text, ".", ",")) = False Then ' наименование
        '    Me.ErrorProvider1.SetError(Me.txtPriceout, "Цена продажи материала должна быть указана")
        '    Me.txtPriceout.Focus()
        '    Exit Sub
        'Else : Me.ErrorProvider1.Clear() : End If

        'If Me.txtCostBay.Text = "" Or IsNumeric(Replace(Me.txtCostBay.Text, ".", ",")) = False Then ' наименование
        '    Me.ErrorProvider1.SetError(Me.txtCostBay, "Цена закупки материала должна быть указана")
        '    Me.txtCostBay.Focus()
        '    Exit Sub
        'Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtNacenka.Text = "" Or IsNumeric(Replace(Me.txtNacenka.Text, ".", ",")) = False Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtNacenka, "Не указана наценка к стоимости работ с данным материалом")
            Me.txtNacenka.Focus()
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.cmbCatMat.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.cmbCatMat, "Не указана категория материала")
            Me.cmbCatMat.Focus()
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        'If Me.txtsizeX.Text = Nothing Or Me.txtsizeY.Text = Nothing Then ' наименование
        '    Me.ErrorProvider1.SetError(Me.txtsizeX, "Не правильно указан размер печатного поля")
        '    Me.ErrorProvider1.SetError(Me.txtsizeY, "Не правильно указан размер печатного поля")
        '    Me.txtsizeY.Focus()
        '    Exit Sub
        'Else : Me.ErrorProvider1.Clear() : End If

        Dim current As Integer

        Try
            Dim strSQL$
            'If mblnAdd = True Then
            '    strSQL = "INSERT INTO Materials (matCatID, matName, sizeX, sizeY, Nacenka, priceOut, accessible, unitID, typeID) VALUES (" & Me.cmbCatMat.SelectedItem(0) & ", "
            '    strSQL &= " '" & Trim(Me.txtmatName.Text) & "', " & CInt(Me.txtsizeX.Text) & ", " & CInt(Me.txtsizeY.Text) & ", " & CInt(Me.txtNacenka.Text) & ", "
            '    strSQL &= " " & Replace(Me.txtPriceout.Text, ",", ".") & ", " & (Me.cmbAccessible.SelectedIndex - 1) & ", " & Me.cmbUnit.SelectedItem(0) & ", " & Me.cmbMatType.SelectedItem(0) & ") "
            'Else
            '    current = Me.lstMaterials.SelectedIndex ' текущее местонахождение в списке
            '    strSQL = "UPDATE Materials SET matCatID = " & Me.cmbCatMat.SelectedItem(0) & ",   matName= '" & Trim(Me.txtmatName.Text) & "', sizeX =" & CInt(Me.txtsizeX.Text) & ","
            '    strSQL &= " sizeY = " & CInt(Me.txtsizeY.Text) & ",  Nacenka =" & CInt(Me.txtNacenka.Text) & ", priceOut = " & Replace(Me.txtPriceout.Text, ",", ".") & ", "
            '    strSQL &= " accessible = " & (Me.cmbAccessible.SelectedIndex - 1) & ", unitID= " & Me.cmbUnit.SelectedItem(0) & ", typeID= " & Me.cmbMatType.SelectedItem(0) & " "
            '    strSQL &= "WHERE matID = " & Me.lstMaterials.SelectedItem(0) & ""
            'End If

            If mblnAdd = True Then
                strSQL = "INSERT INTO Materials (matCatID, matName, Nacenka, typeID, coefficient, accessible, groupID) VALUES (" & Me.cmbCatMat.SelectedItem(0) & ""
                strSQL &= ", '" & Trim(Me.txtmatName.Text) & "', " & CInt(Me.txtNacenka.Text) & ""
                strSQL &= ", " & Me.cmbMatType.SelectedItem(0) & ", " & Replace(Me.nudCoefficient.Value, ",", ".") & ", " & Me.cmbAcces.SelectedIndex & ", " & Me.cmbMatGroup.SelectedItem(0) & ") "
            Else
                current = Me.lstMaterials.SelectedIndex ' текущее местонахождение в списке
                strSQL = "UPDATE Materials SET matCatID = " & Me.cmbCatMat.SelectedItem(0) & ", matName= '" & Trim(Me.txtmatName.Text) & "'"
                strSQL &= ",  Nacenka =" & CInt(Me.txtNacenka.Text) & ", typeID= " & Me.cmbMatType.SelectedItem(0) & " "
                strSQL &= ", coefficient = " & Replace(Me.nudCoefficient.Value, ",", ".") & ", accessible= " & Me.cmbAcces.SelectedIndex & ", groupID = " & Me.cmbMatGroup.SelectedItem(0) & " WHERE matID = " & Me.lstMaterials.SelectedItem(0) & " "
            End If

            Module1.NonQuery1(strSQL)

            LoadList()

            If mblnAdd = True Then
                Me.lstMaterials.SelectedIndex = Me.lstMaterials.Items.Count - 1 ' Если добавили то перемещаемся в конец
            End If

            ActivateEditing(False)
        Catch excData As System.Exception
            MessageBox.Show("Error Occured:" & excData.Message, appName)
            Exit Sub
        End Try
    End Sub
#End Region

#Region " Выход "
    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
#End Region

    Private Sub txtmatName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmatName.KeyPress
        If Asc(e.KeyChar) = 13 Then e.Handled = True Else e.Handled = False
    End Sub

    Private Sub tsbtnEditMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditMat.Click
        If Me.lstMaterials.SelectedIndex = -1 Then
            MsgBox("Не выбран материал.", MsgBoxStyle.Critical, appName)
            Me.lstMaterials.Focus()
        Else
            currentID = Me.lstMaterials.SelectedIndex
            mblnAdd = False

            ActivateEditing(True)
        End If
    End Sub

    Private Sub tsbtnSaveMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSaveMat.Click
        Me.tsOperations.Enabled = True
        Me.lstSelect.Enabled = True

        Dim current As Integer = Me.lstMaterials.SelectedIndex

        SaveRecord()

        If mblnAdd = True Then
          
        Else
            Me.lstMaterials.Focus()
        End If

        LoadIndividual()
    End Sub

    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        Me.tsOperations.Enabled = True
        Me.lstSelect.Enabled = True

        Me.ErrorProvider1.Clear()

        Dim current As Integer = Me.lstMaterials.SelectedIndex

        If mblnAdd = True Then mblnAdd = False
        ActivateEditing(False)
        Me.lstMaterials.SelectedIndex = current

        If Me.lstMaterials.SelectedIndex <> -1 Then
            LoadIndividual()
            LoadUnitsHave()
        End If
    End Sub

    Private Sub rbSortCost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadList()
    End Sub

#Region " Загрузка лист операций материала "
    Private Sub LoadUnitsHave()
        If Me.lstMaterials.SelectedIndex <> -1 Then
            Try
                Me.tscmbSelectMode.SelectedIndex = 0

                LoadUnits(0)

                Dim strSQL$ = "SELECT ID, (name +', int-'+cast(internal as char(1))+', p-'+ cast(purchase as char(1))) as name FROM Units WHERE ID IN (SELECT DISTINCT unitID FROM SkladAccountingUnits WHERE matID=" & Me.lstMaterials.SelectedItem(0) & ")"
                '   Dim strSQL$ = "SELECT ID, name FROM Units WHERE ID IN (SELECT DISTINCT unitID FROM SkladAccountingUnits WHERE matID=" & Me.lstMaterials.SelectedItem(0) & ")"

                Dim odaServListH As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
                Dim dtServListH As New DataTable : odaServListH.Fill(dtServListH)

                Me.lstSelect.DataSource = dtServListH
                Me.lstSelect.DisplayMember = "Name"
                Me.lstSelect.ValueMember = "ID"
                Me.lstSelect.ClearSelected()

            Catch oexpData As System.Exception
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        Else
            Me.tscmbUnit.ComboBox.DataSource = Nothing
            ' MsgBox("Не выбран материал-1.", MessageBoxIcon.Error, appName)
        End If
    End Sub

    Private Sub LoadUnits(selectMode As Integer)
        Dim strSQL As String = Nothing

        Select Case selectMode
            Case Is = 0
                strSQL = "SELECT ID, name FROM Units WHERE ID NOT IN (SELECT DISTINCT unitID FROM SkladAccountingUnits WHERE matID=" & Me.lstMaterials.SelectedItem(0) & ") order by name"
            Case Is = 1
                strSQL = "SELECT ID, name FROM Units WHERE ID NOT IN (SELECT DISTINCT unitID FROM SkladAccountingUnits WHERE matID=" & Me.lstMaterials.SelectedItem(0) & ") AND internal=1 order by name"
            Case Is = 2
                strSQL = "SELECT ID, name FROM Units WHERE ID NOT IN (SELECT DISTINCT unitID FROM SkladAccountingUnits WHERE matID=" & Me.lstMaterials.SelectedItem(0) & ") AND purchase=1 order by name"
        End Select

        Dim odaServList As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)


        Dim dtServList As New DataTable : odaServList.Fill(dtServList)

        Me.tscmbUnit.ComboBox.DataSource = dtServList
        Me.tscmbUnit.ComboBox.DisplayMember = "name"
        Me.tscmbUnit.ComboBox.ValueMember = "ID"
    End Sub
#End Region

#Region " DeleteService >>, <<"
    Private Sub tsbtnUnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnUnSelect.Click
        Dim selectUnit As Integer = Me.lstSelect.SelectedItem(0)

        Select Case MsgBox(Prompt:="Удалить   " & CStr(Me.lstSelect.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM SkladAccountingUnits WHERE unitID=" & selectUnit & " AND matID = " & Me.lstMaterials.SelectedItem(0) & "")

                LoadUnitsHave()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub tsbtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSelect.Click
        Dim strSQL$ = "INSERT INTO SkladAccountingUnits (matID, unitID, costBay, priceOut) VALUES (" & Me.lstMaterials.SelectedItem(0) & ", "
        strSQL &= " " & Me.tscmbUnit.ComboBox.SelectedItem(0) & ", " & Replace(Me.tstxtBayCost.Text, ",", ".") & ", " & Replace(Me.tstxtPriceOut.Text, ",", ".") & ")"

        Module1.NonQuery1(strSQL)

        LoadUnitsHave()
    End Sub
#End Region

    Private Sub tsmAddCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAddCat.Click
        Dim strName As String = InputBox("Новая категория", appName)

        If Len(strName) = 0 Then
            MsgBox("Запись не произведена.", MessageBoxIcon.Error, appName)
            Exit Sub
        End If

        Module1.NonQuery1("INSERT INTO MatCategories (Name)  VALUES ('" & strName & "')")

        PopulateCategories()
    End Sub

    Private Sub tsmAddTypeInCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAddTypeInCat.Click
        Dim strName As String = InputBox("Создать новый тип в категории - '" & Me.tvMat.SelectedNode.Text & "'?", appName)

        Try
            If Me.tvMat.SelectedNode.Level = 0 Then
                If Len(strName) = 0 Then
                    MsgBox("Запись не произведена", MessageBoxIcon.Error, appName)
                Else
                    Module1.NonQuery1("INSERT INTO MatTypes (Name, matCatID)  VALUES ('" & strName & "', " & Me.tvMat.SelectedNode.Tag & ")")

                    PopulateCategories()
                End If
            Else : MsgBox("Необходимо выделиить категорию в которой будет создан тип материала.", MsgBoxStyle.Information, appName)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
            MsgBox("Необходимо выделиить категорию в которой будет создан тип материала.", MsgBoxStyle.Information, appName)
        End Try
    End Sub

    Private Sub tsmDelCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelCat.Click

        If Me.tvMat.SelectedNode.Level = 0 Then
            Select Case MsgBox(Prompt:="Удалить категорию '" & Trim(Me.tvMat.SelectedNode.Text) & "' и все типы и материалы в ней?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM MatCategories WHERE ID=" & Me.tvMat.SelectedNode.Tag & "")

                    PopulateCategories()

                Case Is = vbNo : Exit Sub
            End Select
        Else : MsgBox("Необходимо выделиить категорию, которую необходимо удалить.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub tsmDelType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelType.Click
        If Me.tvMat.SelectedNode.Level = 1 Then
            Select Case MsgBox(Prompt:="Удалить тип '" & Trim(Me.tvMat.SelectedNode.Text) & "' и все материалы этого типа?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM MatTypes WHERE ID=" & Me.tvMat.SelectedNode.Tag & "")

                    PopulateCategories()
                Case Is = vbNo : Exit Sub
            End Select
        Else : MsgBox("Необходимо выделиить тип материала, который необходимо удалить.", MsgBoxStyle.Information, appName)
        End If
    End Sub
    '*****************
    'Читаем стоимость операций для выбранного материала
    Private Sub lstSelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstSelect.SelectedValueChanged
        If Me.lstSelect.SelectedIndex <> -1 Then
            Try
                Me.tstxtPriceOut.Text = Module1.NonQuery1Scalar("SELECT coalesce(priceOut,0) FROM SkladAccountingUnits WHERE unitID=" & Me.lstSelect.SelectedItem(0) & " AND matID=" & Me.lstMaterials.SelectedItem(0) & "")
                Me.tstxtBayCost.Text = Module1.NonQuery1Scalar("SELECT coalesce(costBay,0) FROM SkladAccountingUnits WHERE unitID=" & Me.lstSelect.SelectedItem(0) & " AND matID=" & Me.lstMaterials.SelectedItem(0) & "")

            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                MsgBox("Проверь цены закупки и продажи единицы учета.", MsgBoxStyle.Information, appName)
            End Try
        End If
    End Sub

    Dim typeMat As Integer

    Private Sub КопироватьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КопироватьToolStripMenuItem.Click
        If Me.tvMat.SelectedNode.Level = 1 Then
            Select Case MsgBox(Prompt:="Вырезать все материлы типа '" & Trim(Me.tvMat.SelectedNode.Text) & "'?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    copy = False
                    typeMat = Me.tvMat.SelectedNode.Tag
                Case Is = vbNo : Exit Sub
            End Select
        Else : MsgBox("Необходимо выделиить тип материала, который необходимо вырезать.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub ВставитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ВставитьToolStripMenuItem.Click
        If Me.tvMat.SelectedNode.Level = 1 Then
            Dim strSQL$ = ""

            If copy = False Then
                strSQL = "Update Materials SET matCatID=" & Me.tvMat.SelectedNode.Parent.Tag & ", typeID=" & Me.tvMat.SelectedNode.Tag & " FROM Materials where typeId=" & typeMat & ""
            Else
                strSQL = "INSERT Materials (matCatID,groupID,typeID,matName,nacenka,accessible,matZak,date_cr,coefficient,virtMat) SELECT " & Me.tvMat.SelectedNode.Parent.Tag & ",groupID," & Me.tvMat.SelectedNode.Tag & ",matName,nacenka,accessible,matZak,date_cr,coefficient,virtMat FROM Materials WHERE typeID=" & typeMat & ""
            End If

            Select Case MsgBox(Prompt:="Вставить материалы в категорию -" + Me.tvMat.SelectedNode.Parent.Text + ", и тип " + Me.tvMat.SelectedNode.Text + "?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    typeMat = Me.tvMat.SelectedNode.Tag

                    Module1.NonQuery1(strSQL)

                    LoadList()
                Case Is = vbNo : Exit Sub
            End Select
        Else : MsgBox("Необходимо выделить тип материала, в который надо вставить вырезанный материал.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub lstMaterials_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles lstMaterials.SelectedValueChanged
        If Me.lstMaterials.Items.Count > 0 Then
            LoadIndividual()
            LoadUnitsHave()
            LoadUnits2()
        End If
    End Sub


    Private Sub cmbCatMat_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbCatMat.SelectedValueChanged
        Dim odaTypeMat As New SqlClient.SqlDataAdapter("SELECT ID, Name From MatTypes WHERE matCatID=" & Me.cmbCatMat.SelectedItem(0) & " order by Name", mcnnInt)
        Dim dtTypeMat As New DataTable : odaTypeMat.Fill(dtTypeMat)

        Me.cmbMatType.DataSource = dtTypeMat
        Me.cmbMatType.DisplayMember = "Name"
        Me.cmbMatType.ValueMember = "ID"
    End Sub

    Private Sub ЕдиницыУчетаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ЕдиницыУчетаToolStripMenuItem.Click
        ModCallForm.CallForm("Стандартные единицы учета", 26, 3)
    End Sub

    Private Sub КопироватьToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles КопироватьToolStripMenuItem1.Click
        If Me.tvMat.SelectedNode.Level = 1 Then
            Select Case MsgBox(Prompt:="Копировать все материлы типа '" & Trim(Me.tvMat.SelectedNode.Text) & "' ?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    copy = True
                    typeMat = Me.tvMat.SelectedNode.Tag
                Case Is = vbNo
                    Exit Sub
            End Select
        Else
            MsgBox("Необходимо выделиить тип материала, который необходимо вырезать.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub txtNacenka_GotFocus(sender As Object, e As EventArgs) Handles txtNacenka.GotFocus
        sender.Select(0, Len(sender.text))
    End Sub

    Private Sub txtNacenka_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNacenka.MouseClick
        sender.Select(0, Len(sender.text))
    End Sub

    Private Sub tstxtBayCost_MouseDown(sender As Object, e As MouseEventArgs) Handles tstxtBayCost.MouseDown
        sender.Select(0, Len(sender.text))
    End Sub

    Private Sub tstxtPriceOut_MouseDown(sender As Object, e As MouseEventArgs) Handles tstxtPriceOut.MouseDown
        sender.Select(0, Len(sender.text))
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbtnDelSklad.Click
        Select Case MsgBox(Prompt:="Вы действительно хотите удалить позицию со склада?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                If postPrioritet = 1 Then
                    Module1.NonQuery1("DELETE FROM SkladInventar WHERE matID=" & Me.lstMaterials.SelectedItem(0) & " AND unitID=" & Me.lstSelect.SelectedItem(0) & "")
                Else
                    MsgBox("Нет прав.", MsgBoxStyle.Critical, appName)
                End If
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub tscmbSelectMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscmbSelectMode.SelectedIndexChanged
        LoadUnits(Me.tscmbSelectMode.SelectedIndex)
    End Sub

    Private Sub СоздатьЕдиницыУчетаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СоздатьЕдиницыУчетаToolStripMenuItem.Click
        Me.clbUnits.Visible = sender.checked
        Me.btnCreateCostUnits.Visible = sender.checked
    End Sub

    Private Sub btnCreateCostUnits_Click(sender As Object, e As EventArgs) Handles btnCreateCostUnits.Click
        MsgBox("Созданные единицы учета будут иметь нулевую стоимость.", MsgBoxStyle.Information, appName)

        Try
            For Each itemChecked As Object In Me.clbUnits.CheckedItems
                Module1.NonQuery1("INSERT INTO SkladAccountingUnits (unitID, matID, costBay, priceOut, accessible) VALUES (" & itemChecked.item(0) & "," & Me.lstMaterials.SelectedItem(0) & ",0,0,1)")
                Module1.NonQuery1("INSERT INTO SkladInventar (unitID, matID, quantity, depID) VALUES (" & itemChecked.item(0) & "," & Me.lstMaterials.SelectedItem(0) & ",0,5)")
            Next

            MsgBox("Создал", MsgBoxStyle.Information, appName)

            LoadUnitsHave()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
        '  Next
    End Sub

    Private Sub LoadUnits2()
        Try
            If Me.lstMaterials.SelectedItems.Count = 1 Then
                Dim odaUnits As New SqlClient.SqlDataAdapter("SELECT ID,name From Units WHERE internal=1 and ID NOT IN (SELECT DISTINCT unitID FROM SkladAccountingUnits WHERE matID=" & Me.lstMaterials.SelectedItem(0) & ") order by name", mcnnInt)
                Dim dtUnits As New DataTable : odaUnits.Fill(dtUnits)

                Me.clbUnits.DataSource = dtUnits
                Me.clbUnits.DisplayMember = "name"
                Me.clbUnits.ValueMember = "ID"

                LoadUnits(0)
            Else
                Me.clbUnits.DataSource = Nothing
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub tscmbSelectMode_Click(sender As Object, e As EventArgs) Handles tscmbSelectMode.Click

    End Sub

    Private Sub lstSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSelect.SelectedIndexChanged

    End Sub
End Class
