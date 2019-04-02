'Imports Microsoft.SqlServer.Types
Imports System.Data.SqlClient

Public Class c_OtherServices
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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tvData As System.Windows.Forms.TreeView
    Friend WithEvents iml1 As System.Windows.Forms.ImageList

    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    Friend WithEvents nudKolvo As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbSelect As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents nudDiscMat As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtSkidka As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtNac As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtCostUnit As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmHierarchyid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ОбновитьToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmsCalcConfig As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbTypeCost As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrim As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nudCostUnit As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudExpens As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_OtherServices))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvData = New System.Windows.Forms.TreeView()
        Me.cmHierarchyid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ОбновитьToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudDiscMat = New System.Windows.Forms.NumericUpDown()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.cmsCalcConfig = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbSelect = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudKolvo = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrim = New System.Windows.Forms.TextBox()
        Me.cmbTypeCost = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.nudCostUnit = New System.Windows.Forms.NumericUpDown()
        Me.nudExpens = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.iml1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtSkidka = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtNac = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtCostUnit = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.cmHierarchyid.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudDiscMat,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsCalcConfig.SuspendLayout
        CType(Me.nudKolvo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudCostUnit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudExpens,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStripMenu.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvData)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1142, 506)
        Me.SplitContainer1.SplitterDistance = 430
        Me.SplitContainer1.TabIndex = 43
        '
        'tvData
        '
        Me.tvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvData.ContextMenuStrip = Me.cmHierarchyid
        Me.tvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvData.Location = New System.Drawing.Point(0, 0)
        Me.tvData.Name = "tvData"
        Me.tvData.Size = New System.Drawing.Size(428, 504)
        Me.tvData.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tvData, "Первый уровень - категории, второй уровень - типы материалов")
        '
        'cmHierarchyid
        '
        Me.cmHierarchyid.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmHierarchyid.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmHierarchyid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОбновитьToolStripMenuItem2, Me.tsDelete, Me.ДобавитьToolStripMenuItem})
        Me.cmHierarchyid.Name = "cmHierarchyid"
        Me.cmHierarchyid.Size = New System.Drawing.Size(144, 70)
        '
        'ОбновитьToolStripMenuItem2
        '
        Me.ОбновитьToolStripMenuItem2.Name = "ОбновитьToolStripMenuItem2"
        Me.ОбновитьToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
        Me.ОбновитьToolStripMenuItem2.Text = "Обновить"
        '
        'tsDelete
        '
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(143, 22)
        Me.tsDelete.Text = "Удалить"
        '
        'ДобавитьToolStripMenuItem
        '
        Me.ДобавитьToolStripMenuItem.Name = "ДобавитьToolStripMenuItem"
        Me.ДобавитьToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ДобавитьToolStripMenuItem.Text = "Добавить"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudDiscMat, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMat, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSelect, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudKolvo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrim, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTypeCost, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.nudCostUnit, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.nudExpens, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(706, 504)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(269, 32)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Скидка на материал (%)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = false
        '
        'nudDiscMat
        '
        Me.nudDiscMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDiscMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudDiscMat.Location = New System.Drawing.Point(278, 66)
        Me.nudDiscMat.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudDiscMat.Name = "nudDiscMat"
        Me.nudDiscMat.Size = New System.Drawing.Size(425, 26)
        Me.nudDiscMat.TabIndex = 83
        Me.nudDiscMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbMat
        '
        Me.cmbMat.ContextMenuStrip = Me.cmsCalcConfig
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.DropDownWidth = 400
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(278, 35)
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(425, 25)
        Me.cmbMat.TabIndex = 82
        '
        'cmsCalcConfig
        '
        Me.cmsCalcConfig.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsCalcConfig.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCalcConfig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КофигураторToolStripMenuItem})
        Me.cmsCalcConfig.Name = "cmsCalcConfig"
        Me.cmsCalcConfig.Size = New System.Drawing.Size(176, 26)
        '
        'КофигураторToolStripMenuItem
        '
        Me.КофигураторToolStripMenuItem.Name = "КофигураторToolStripMenuItem"
        Me.КофигураторToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.КофигураторToolStripMenuItem.Text = "Конфигуратор"
        '
        'cmbSelect
        '
        Me.cmbSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSelect.FormattingEnabled = true
        Me.cmbSelect.Items.AddRange(New Object() {"Материал заказчика", "Выбрать материал*", "Без материала"})
        Me.cmbSelect.Location = New System.Drawing.Point(3, 35)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(269, 25)
        Me.cmbSelect.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 32)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Количество"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudKolvo
        '
        Me.nudKolvo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudKolvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudKolvo.Location = New System.Drawing.Point(278, 3)
        Me.nudKolvo.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudKolvo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudKolvo.Name = "nudKolvo"
        Me.nudKolvo.Size = New System.Drawing.Size(425, 26)
        Me.nudKolvo.TabIndex = 80
        Me.nudKolvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudKolvo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 32)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Цена закупки за одну единицу (руб.)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 31)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Цены на услугу"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrim
        '
        Me.txtPrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPrim, 2)
        Me.txtPrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPrim.Location = New System.Drawing.Point(3, 229)
        Me.txtPrim.Multiline = true
        Me.txtPrim.Name = "txtPrim"
        Me.txtPrim.Size = New System.Drawing.Size(700, 272)
        Me.txtPrim.TabIndex = 94
        '
        'cmbTypeCost
        '
        Me.cmbTypeCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTypeCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypeCost.FormattingEnabled = true
        Me.cmbTypeCost.Items.AddRange(New Object() {"Цена за единицу", "Цена за количество"})
        Me.cmbTypeCost.Location = New System.Drawing.Point(278, 98)
        Me.cmbTypeCost.Name = "cmbTypeCost"
        Me.cmbTypeCost.Size = New System.Drawing.Size(425, 25)
        Me.cmbTypeCost.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 32)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Цена продажи за одну единицу (руб.)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.AutoSize = true
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSave.Location = New System.Drawing.Point(278, 193)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(425, 30)
        Me.btnSave.TabIndex = 90
        Me.btnSave.Text = "Применить"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'nudCostUnit
        '
        Me.nudCostUnit.DecimalPlaces = 2
        Me.nudCostUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCostUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudCostUnit.Location = New System.Drawing.Point(278, 161)
        Me.nudCostUnit.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudCostUnit.Name = "nudCostUnit"
        Me.nudCostUnit.Size = New System.Drawing.Size(425, 26)
        Me.nudCostUnit.TabIndex = 96
        Me.nudCostUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudExpens
        '
        Me.nudExpens.DecimalPlaces = 2
        Me.nudExpens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudExpens.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudExpens.Location = New System.Drawing.Point(278, 129)
        Me.nudExpens.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudExpens.Name = "nudExpens"
        Me.nudExpens.Size = New System.Drawing.Size(425, 26)
        Me.nudExpens.TabIndex = 97
        Me.nudExpens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 36)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Примечание"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'iml1
        '
        Me.iml1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iml1.ImageSize = New System.Drawing.Size(16, 16)
        Me.iml1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStripMenu
        '
        Me.ToolStripMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripMenu.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tstxtSkidka, Me.ToolStripLabel1, Me.tstxtNac, Me.tsbtnCost, Me.tstxtItog, Me.ToolStripLabel3, Me.tstxtCostUnit, Me.tsbtnOK, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripMenu.Location = New System.Drawing.Point(1148, 0)
        Me.ToolStripMenu.Name = "ToolStripMenu"
        Me.ToolStripMenu.Size = New System.Drawing.Size(128, 512)
        Me.ToolStripMenu.TabIndex = 44
        Me.ToolStripMenu.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(126, 18)
        Me.ToolStripLabel2.Text = "Скидка, %"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tstxtSkidka
        '
        Me.tstxtSkidka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtSkidka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtSkidka.Name = "tstxtSkidka"
        Me.tstxtSkidka.Size = New System.Drawing.Size(124, 24)
        Me.tstxtSkidka.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(126, 18)
        Me.ToolStripLabel1.Text = "Наценка, %"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tstxtNac
        '
        Me.tstxtNac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtNac.Name = "tstxtNac"
        Me.tstxtNac.Size = New System.Drawing.Size(124, 24)
        Me.tstxtNac.Text = "0"
        Me.tstxtNac.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnCost
        '
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.Image = CType(resources.GetObject("tsbtnCost.Image"),System.Drawing.Image)
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(126, 30)
        Me.tsbtnCost.Text = "Считать"
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.ReadOnly = true
        Me.tstxtItog.Size = New System.Drawing.Size(124, 34)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(126, 18)
        Me.ToolStripLabel3.Text = "Цена за единицу"
        '
        'tstxtCostUnit
        '
        Me.tstxtCostUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtCostUnit.Name = "tstxtCostUnit"
        Me.tstxtCostUnit.ReadOnly = true
        Me.tstxtCostUnit.Size = New System.Drawing.Size(124, 24)
        Me.tstxtCostUnit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(126, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(126, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(126, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128!))
        Me.TableLayoutPanel2.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStripMenu, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1276, 512)
        Me.TableLayoutPanel2.TabIndex = 45
        '
        'c_OtherServices
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(1276, 512)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimizeBox = false
        Me.Name = "c_OtherServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "///"
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.cmHierarchyid.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudDiscMat,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsCalcConfig.ResumeLayout(false)
        CType(Me.nudKolvo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudCostUnit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudExpens,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStripMenu.ResumeLayout(false)
        Me.ToolStripMenu.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

#End Region

    Dim Itogo% '
    Dim matQuantity As Decimal
    Dim vidService As String

#Region " Загрузка формы "
    Private Sub c_OtherServices_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Text = Module1.NonQuery1ScalarString("SELECT Name FROM Services where ID = " & serviceID & " ")
        ' Me.tslSkidka.Text = Replace(Module1.NonQuery1ScalarString("SELECT coalesce(skidka, '') FROM Services where ID = " & serviceID & " "), ";", Chr(13))
        skidkaCust = Module1.NonQuery1Scalar("Select coalesce(Discount, 0) From KA_ServDisccount Where ID_KA=" & custID & " AND ID_Service=" & serviceID & "")
        Me.tstxtSkidka.Text = skidkaCust

        If postPrioritet = 1 Then
            Me.Label2.Visible = True
            Me.btnSave.Visible = True
            Me.nudExpens.Visible = True
        Else
            Me.Label2.Visible = False
            Me.btnSave.Visible = False
            Me.nudExpens.Visible = False
        End If

        Me.cmbSelect.SelectedIndex = 0

        LoadHierarchyid()
    End Sub

    Class ClassInfo
        Public Id As String
        Public NodeID As String
    End Class

    Private Sub LoadHierarchyid()
        'Try
        '    Dim cmd As New SqlClient.SqlCommand

        '    cmd.Connection = mcnnInt
        '    cmd.CommandText = "SELECT NodeID.GetAncestor(1) as Root, NodeID, NodeLevel, Id, Name, Title FROM ServicesOther"
        '    ' Using mcnnInt
        '    mcnnInt.Open()

        '    Dim reader As SqlDataReader = cmd.ExecuteReader()
        '    Dim n As TreeNode
        '    Dim key As String
        '    Dim p As TreeNode

        '    Me.tvData.Nodes.Clear()

        '    While reader.Read()
        '        n = New TreeNode()
        '        n.Text = reader.GetString(4)

        '        Dim i As New ClassInfo
        '        i.NodeID = BitConverter.ToString(reader.GetSqlBytes(1).Value)
        '        i.Id = reader.GetInt32(3)

        '        If (Not reader.IsDBNull(0)) Then
        '            key = BitConverter.ToString(reader.GetSqlBytes(0).Value)
        '            n.Tag = i
        '            '   n.Text = n.Text + " (" + n.Tag.NodeID + ")"
        '            p = FindParentNode(key, Me.tvData.Nodes)

        '            If p Is Nothing Then
        '                MessageBox.Show(key + " - не нашел родителя", appName)
        '                mcnnInt.Close()
        '                Exit Sub
        '            Else
        '                p.Nodes.Add(n)
        '            End If
        '        Else
        '            n.Tag = i
        '            Me.tvData.Nodes.Add(n)
        '        End If
        '    End While
        '    ' End Using
        'Catch ex As System.Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        'Finally
        '    mcnnInt.Close()
        'End Try
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "SELECT NodeID.GetAncestor(1) as Root, NodeID, NodeLevel, Id, Name, Title FROM ServicesOther"
            ' Using mcnnInt
            mcnnInt.Open()

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim n As TreeNode
            Dim key As String
            Dim p As TreeNode

            Me.tvData.Nodes.Clear()

            While reader.Read()
                n = New TreeNode()
                n.Text = reader.GetString(4)

                Dim i As New ClassInfo
                i.NodeID = BitConverter.ToString(reader.GetSqlBytes(1).Value)
                i.Id = reader.GetInt32(3)

                If (Not reader.IsDBNull(0)) Then
                    key = BitConverter.ToString(reader.GetSqlBytes(0).Value)
                    n.Tag = i
                    '   n.Text = n.Text + " (" + n.Tag.NodeID + ")"
                    p = FindParentNode(key, Me.tvData.Nodes)

                    If p Is Nothing Then
                        MessageBox.Show(key + " - не нашел555 родителя", appName)
                        mcnnInt.Close()
                        Exit Sub
                    Else
                        p.Nodes.Add(n)
                    End If
                Else
                    n.Tag = i
                    Me.tvData.Nodes.Add(n)
                End If
            End While
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        Finally

            mcnnInt.Close()
        End Try
    End Sub

    Private Function FindParentNode(ByVal key As String, ByVal nodes As TreeNodeCollection) As TreeNode
        Dim n As TreeNode = Nothing

        For Each node As TreeNode In nodes
            If (node.Tag.NodeID = key) Then
                n = node
                Continue For
            Else
                n = FindParentNode(key, node.Nodes)
                If (Not n Is Nothing) Then
                    Continue For
                End If
            End If
        Next

        Return n
    End Function
#End Region

#Region " Выход "
    Private Sub tsbtnExit_Click_1(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
#End Region

#Region " Материал "
    Private Sub cmbSelect_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSelect.SelectedIndexChanged
        If Me.cmbSelect.SelectedIndex = 0 Then
            Me.cmbMat.Visible = False
            Me.nudDiscMat.Visible = False
            Me.Label10.Visible = False

        Else
            Me.cmbMat.Visible = True
            Me.nudDiscMat.Visible = True
            Me.Label10.Visible = True

            Dim dtMat As New DataTable

            dtMat = Module1.List(serviceID, Trim(sender.Text))
            Me.cmbMat.DataSource = dtMat
            Me.cmbMat.DisplayMember = "matName"
            Me.cmbMat.ValueMember = "matID"
        End If
    End Sub


#End Region

#Region " Иерархия "
    Private Sub ДобавитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ДобавитьToolStripMenuItem.Click

        'If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID = " & serviceID & "") Or postPrioritet = 1 Then
        Dim strName As String = Nothing
        Dim myValue As Object

        Try
            myValue = InputBox("Создать новую услугу в - '" & Me.tvData.SelectedNode.Text & "'?", appName)

            If myValue Is "" Then
                MsgBox("Запись не произведена", MsgBoxStyle.Critical, appName) : Exit Sub
            Else
                strName = myValue

                Dim cmd As New SqlClient.SqlCommand

                cmd.Connection = mcnnInt
                cmd.CommandText = "uspAddNode"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlClient.SqlParameter("@ParentID", SqlDbType.Int))
                cmd.Parameters("@ParentID").Value = Me.tvData.SelectedNode.Tag.Id
                cmd.Parameters.Add(New SqlClient.SqlParameter("@ServicesOtherName", SqlDbType.NText))
                cmd.Parameters("@ServicesOtherName").Value = strName
                cmd.Parameters.Add(New SqlClient.SqlParameter("@Title", SqlDbType.NText))
                cmd.Parameters("@Title").Value = "new"
                mcnnInt.Open()
                cmd.ExecuteNonQuery()
                mcnnInt.Close()

                LoadHierarchyid()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            MsgBox("Необходимо выделить узел.", MsgBoxStyle.Critical, appName) : Exit Sub
        End Try
        '  Else
        ' MsgBox("Нет прав на конфигурирование.", MsgBoxStyle.Critical, appName)
        'End If
    End Sub

   

    Private Sub ОбновитьToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ОбновитьToolStripMenuItem2.Click
        LoadHierarchyid()
    End Sub

    Private Sub tvData_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvData.AfterSelect
        vidService = Me.tvData.SelectedNode.Text

        Me.nudExpens.Value = NonQuery1Scalar("SELECT COALESCE(priceIN, 0) FROM ServicesOther WHERE Id = " & Me.tvData.SelectedNode.Tag.Id & " ")
        Me.nudCostUnit.Value = NonQuery1Scalar("SELECT COALESCE(priceOUT, 0) FROM ServicesOther WHERE Id = " & Me.tvData.SelectedNode.Tag.Id & " ")
    End Sub
#End Region

    Private Sub tsbtnCost_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnCost.Click
        Dim k@ = (100 + Val(Me.tstxtNac.Text - Me.tstxtSkidka.Text)) / 100
        matQuantity = Me.nudKolvo.Value
        ' Me.txtpriceOut.Text = NonQuery1Scalar("SELECT COALESCE(priceOUT, 0) FROM ServicesOther WHERE Id = " & Me.tvData.SelectedNode.Tag.Id & " ")
        'Цена за единицу
        'Цена за количество
        If Me.cmbTypeCost.SelectedIndex = 0 Then
            Itogo = Me.nudKolvo.Value * Me.nudCostUnit.Value  ' NonQuery1Scalar("SELECT COALESCE(priceOUT, 0) FROM ServicesOther WHERE Id = " & Me.tvData.SelectedNode.Tag.Id & " ")
        Else
            Itogo = Me.nudCostUnit.Value  
        End If

        If Me.cmbSelect.SelectedIndex = 0 Then
            matQuantity = 0 ' наш материал
        Else
            If Me.cmbMat.SelectedIndex = -1 Then
                MsgBox("Не выбран материал", MsgBoxStyle.Critical, appName)
            Else
                Itogo += matQuantity * Module1.NonQuery1Scalar("SELECT TOP 1 priceOut FROM SkladAccountingUnits FROM Materials WHERE matID = " & Me.cmbMat.SelectedItem(0) & " ")
            End If
        End If

        Itogo = Me.nudKolvo.Value * Me.nudCostUnit.Value * k

        Me.tstxtItog.Text = Itogo
        Me.tstxtCostUnit.Text = Math.Round(Itogo / Me.nudKolvo.Value, 2)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
            Dim strSQL$ = "UPDATE ServicesOther SET priceIN = " & Replace(Me.nudExpens.Value, ",", ".") & ", priceOut=" & Replace(Me.nudCostUnit.Value, ",", ".") & " WHERE Id=" & Me.tvData.SelectedNode.Tag.Id & " "
            Module1.NonQuery1(strSQL)
        Else
            MsgBox("Нет прав на конфигурирование", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        Dim frmSelect As New frmConfigCalcMat

        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
            frmSelect.fff = Trim(Me.cmbSelect.Text)
            frmSelect.ShowDialog()
        Else
            MsgBox("Нет прав на конфигурирование", MsgBoxStyle.Critical, appName)
        End If
    End Sub

#Region " Добавить к заказу "
    Private Sub tsbtnOK_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOK.Click
        If costID = Nothing Then
            Exit Sub
        Else
            If MessageBox.Show("Добавить расчет к заказу", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Not IsNumeric(tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub

                Dim IDmat As Integer  'ID материала заказчика

                If Me.cmbSelect.SelectedIndex = 0 Then
                    IDmat = Module1.NonQuery1Scalar("SELECT matID FROM Materials WHERE virtMat= 1")
                    matQuantity = 0
                Else
                    IDmat = Me.cmbMat.SelectedItem(0)
                End If

                Dim number$ = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID = " & costID & " ").ToString
                Dim strSQL$ = " INSERT INTO Orders (kolvo, matID, serviceID, costID, matCount, prim, cost, edIzm, sostav, number, sizeCut, costUnit, nameForDoc) "
                strSQL &= " VALUES (" & Me.nudKolvo.Value & ", " & IDmat & ", " & serviceID & ", " & costID & ", " & Replace(matQuantity, ",", ".") & ", "
                strSQL &= "'" & vidService & "," & Me.txtPrim.Text & "', " & Replace(Me.tstxtItog.Text, ",", ".") & ", 1, '', " & number & ", 'нет', " & Replace(Me.tstxtCostUnit.Text, ",", ".") & ", '" & Me.tvData.SelectedNode.Text & "') "

                Module1.NonQuery1(strSQL)
                Me.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub
#End Region

    Private Sub tstxtItog_TextChanged(sender As Object, e As System.EventArgs) Handles tstxtItog.TextChanged
        Me.tstxtCostUnit.Text = Val(sender.text) / Me.nudKolvo.Value
    End Sub

    Private Sub tsDelete_Click(sender As System.Object, e As System.EventArgs) Handles tsDelete.Click
        If Me.tvData.SelectedNode Is Nothing Then
            MsgBox("Выбери узел", MsgBoxStyle.Information, appName)
        Else
            If Me.tvData.SelectedNode.Nodes.Count > 0 Then
                MsgBox("Сначала необходимо удалить потомков", MsgBoxStyle.Information, appName)
            Else
                Try
                    Dim cmd As New SqlClient.SqlCommand

                    cmd.Connection = mcnnInt
                    cmd.CommandText = "uspDelNode"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@ServicesOtherID", SqlDbType.Int))

                    cmd.Parameters("@ServicesOtherID").Value = Me.tvData.SelectedNode.Tag.ID
                    mcnnInt.Open()
                    cmd.ExecuteNonQuery()

                Catch ex As System.Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                Finally
                    mcnnInt.Close()
                End Try

                LoadHierarchyid()
            End If
        End If
    End Sub

    Private Sub nudKolvo_GotFocus(sender As Object, e As EventArgs) Handles nudKolvo.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudKolvo_MouseClick(sender As Object, e As MouseEventArgs) Handles nudKolvo.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudDiscMat_GotFocus(sender As Object, e As EventArgs) Handles nudDiscMat.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudDiscMat_MouseClick(sender As Object, e As MouseEventArgs) Handles nudDiscMat.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudDiscMat_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscMat.ValueChanged

    End Sub

    Private Sub nudExpens_GotFocus(sender As Object, e As EventArgs) Handles nudExpens.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudExpens_MouseClick(sender As Object, e As MouseEventArgs) Handles nudExpens.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudExpens_ValueChanged(sender As Object, e As EventArgs) Handles nudExpens.ValueChanged

    End Sub

    Private Sub nudCostUnit_GotFocus(sender As Object, e As EventArgs) Handles nudCostUnit.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudCostUnit_MouseClick(sender As Object, e As MouseEventArgs) Handles nudCostUnit.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudCostUnit_ValueChanged(sender As Object, e As EventArgs) Handles nudCostUnit.ValueChanged

    End Sub
End Class
