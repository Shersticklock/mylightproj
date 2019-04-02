<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_UniCostWOColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_UniCostWOColor))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMatTypes = New System.Windows.Forms.Label()
        Me.cmbPriceGroup = New System.Windows.Forms.ComboBox()
        Me.cmsConfigTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.cmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.cmsConfigMat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clbNacenki = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbParam2 = New System.Windows.Forms.ComboBox()
        Me.cmbPriceName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSrok = New System.Windows.Forms.ComboBox()
        Me.clbOper = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.nudY = New System.Windows.Forms.NumericUpDown()
        Me.cmbTirag = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tscmbSkidka = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtCostUnit = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAddCost = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.tlpMain.SuspendLayout
        Me.cmsConfigTech.SuspendLayout
        Me.cmsConfigMat.SuspendLayout
        CType(Me.nudY,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpMain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1135, 592)
        Me.SplitContainer1.SplitterDistance = 957
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 56
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = true
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 3
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.75758!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.24242!))
        Me.tlpMain.Controls.Add(Me.lblMatTypes, 0, 4)
        Me.tlpMain.Controls.Add(Me.cmbPriceGroup, 1, 0)
        Me.tlpMain.Controls.Add(Me.Label2, 0, 0)
        Me.tlpMain.Controls.Add(Me.Label1, 0, 3)
        Me.tlpMain.Controls.Add(Me.cmbMat, 1, 5)
        Me.tlpMain.Controls.Add(Me.cmbMatTypes, 1, 4)
        Me.tlpMain.Controls.Add(Me.clbNacenki, 1, 7)
        Me.tlpMain.Controls.Add(Me.Label8, 0, 9)
        Me.tlpMain.Controls.Add(Me.Label7, 0, 7)
        Me.tlpMain.Controls.Add(Me.cmbParam2, 1, 2)
        Me.tlpMain.Controls.Add(Me.cmbPriceName, 1, 1)
        Me.tlpMain.Controls.Add(Me.Label4, 0, 2)
        Me.tlpMain.Controls.Add(Me.Label3, 0, 1)
        Me.tlpMain.Controls.Add(Me.cmbSrok, 1, 9)
        Me.tlpMain.Controls.Add(Me.clbOper, 1, 8)
        Me.tlpMain.Controls.Add(Me.Label6, 0, 8)
        Me.tlpMain.Controls.Add(Me.cmbUnit, 1, 6)
        Me.tlpMain.Controls.Add(Me.nudY, 1, 3)
        Me.tlpMain.Controls.Add(Me.cmbTirag, 2, 3)
        Me.tlpMain.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(5)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 10
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(955, 590)
        Me.tlpMain.TabIndex = 52
        '
        'lblMatTypes
        '
        Me.lblMatTypes.AutoSize = true
        Me.lblMatTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblMatTypes.Location = New System.Drawing.Point(5, 137)
        Me.lblMatTypes.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMatTypes.Name = "lblMatTypes"
        Me.tlpMain.SetRowSpan(Me.lblMatTypes, 3)
        Me.lblMatTypes.Size = New System.Drawing.Size(228, 104)
        Me.lblMatTypes.TabIndex = 31
        Me.lblMatTypes.Text = "Тип материала**"
        Me.lblMatTypes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbPriceGroup
        '
        Me.tlpMain.SetColumnSpan(Me.cmbPriceGroup, 2)
        Me.cmbPriceGroup.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbPriceGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPriceGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceGroup.Location = New System.Drawing.Point(243, 5)
        Me.cmbPriceGroup.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPriceGroup.MaxDropDownItems = 40
        Me.cmbPriceGroup.Name = "cmbPriceGroup"
        Me.cmbPriceGroup.Size = New System.Drawing.Size(707, 25)
        Me.cmbPriceGroup.TabIndex = 0
        Me.cmbPriceGroup.Tag = "Prod"
        '
        'cmsConfigTech
        '
        Me.cmsConfigTech.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigTech.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigTech.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗадатьТехнологическуюОперациюToolStripMenuItem})
        Me.cmsConfigTech.Name = "cmsCalcConfigTech"
        Me.cmsConfigTech.Size = New System.Drawing.Size(326, 28)
        '
        'ЗадатьТехнологическуюОперациюToolStripMenuItem
        '
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Name = "ЗадатьТехнологическуюОперациюToolStripMenuItem"
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Size = New System.Drawing.Size(325, 24)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Text = "Задать технологическую операцию"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Продукт"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Количество"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMat
        '
        Me.tlpMain.SetColumnSpan(Me.cmbMat, 2)
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(243, 177)
        Me.cmbMat.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(707, 25)
        Me.cmbMat.TabIndex = 6
        '
        'cmbMatTypes
        '
        Me.tlpMain.SetColumnSpan(Me.cmbMatTypes, 2)
        Me.cmbMatTypes.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatTypes.FormattingEnabled = true
        Me.cmbMatTypes.Location = New System.Drawing.Point(243, 142)
        Me.cmbMatTypes.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMatTypes.Name = "cmbMatTypes"
        Me.cmbMatTypes.Size = New System.Drawing.Size(707, 25)
        Me.cmbMatTypes.TabIndex = 5
        '
        'cmsConfigMat
        '
        Me.cmsConfigMat.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsConfigMat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsConfigMat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КофигураторToolStripMenuItem})
        Me.cmsConfigMat.Name = "cmsCalcConfig"
        Me.cmsConfigMat.Size = New System.Drawing.Size(255, 26)
        '
        'КофигураторToolStripMenuItem
        '
        Me.КофигураторToolStripMenuItem.Name = "КофигураторToolStripMenuItem"
        Me.КофигураторToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.КофигураторToolStripMenuItem.Text = "Конфигуратор материала"
        '
        'clbNacenki
        '
        Me.clbNacenki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbNacenki.CheckOnClick = true
        Me.tlpMain.SetColumnSpan(Me.clbNacenki, 2)
        Me.clbNacenki.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbNacenki.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbNacenki.FormattingEnabled = true
        Me.clbNacenki.Location = New System.Drawing.Point(243, 246)
        Me.clbNacenki.Margin = New System.Windows.Forms.Padding(5)
        Me.clbNacenki.Name = "clbNacenki"
        Me.clbNacenki.Size = New System.Drawing.Size(707, 147)
        Me.clbNacenki.TabIndex = 8
        Me.clbNacenki.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 555)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(228, 35)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Срочность"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 241)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 157)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Наценки"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbParam2
        '
        Me.tlpMain.SetColumnSpan(Me.cmbParam2, 2)
        Me.cmbParam2.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbParam2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbParam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParam2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbParam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbParam2.FormattingEnabled = true
        Me.cmbParam2.Location = New System.Drawing.Point(243, 75)
        Me.cmbParam2.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbParam2.MaxDropDownItems = 12
        Me.cmbParam2.Name = "cmbParam2"
        Me.cmbParam2.Size = New System.Drawing.Size(707, 25)
        Me.cmbParam2.TabIndex = 2
        Me.cmbParam2.Tag = "techParam2"
        '
        'cmbPriceName
        '
        Me.tlpMain.SetColumnSpan(Me.cmbPriceName, 2)
        Me.cmbPriceName.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbPriceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPriceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPriceName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPriceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPriceName.FormattingEnabled = true
        Me.cmbPriceName.Location = New System.Drawing.Point(243, 40)
        Me.cmbPriceName.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPriceName.MaxDropDownItems = 15
        Me.cmbPriceName.Name = "cmbPriceName"
        Me.cmbPriceName.Size = New System.Drawing.Size(707, 25)
        Me.cmbPriceName.TabIndex = 1
        Me.cmbPriceName.Tag = "PriceName"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 35)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Параметр-2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Наименование"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSrok
        '
        Me.tlpMain.SetColumnSpan(Me.cmbSrok, 2)
        Me.cmbSrok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSrok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSrok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSrok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSrok.FormattingEnabled = true
        Me.cmbSrok.Location = New System.Drawing.Point(242, 559)
        Me.cmbSrok.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSrok.Name = "cmbSrok"
        Me.cmbSrok.Size = New System.Drawing.Size(709, 25)
        Me.cmbSrok.TabIndex = 10
        '
        'clbOper
        '
        Me.clbOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbOper.CheckOnClick = true
        Me.tlpMain.SetColumnSpan(Me.clbOper, 2)
        Me.clbOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbOper.FormattingEnabled = true
        Me.clbOper.Location = New System.Drawing.Point(242, 402)
        Me.clbOper.Margin = New System.Windows.Forms.Padding(4)
        Me.clbOper.Name = "clbOper"
        Me.clbOper.Size = New System.Drawing.Size(709, 149)
        Me.clbOper.TabIndex = 9
        Me.clbOper.Tag = "techOper"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 398)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 157)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Операции"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbUnit
        '
        Me.tlpMain.SetColumnSpan(Me.cmbUnit, 2)
        Me.cmbUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbUnit.FormattingEnabled = true
        Me.cmbUnit.Location = New System.Drawing.Point(242, 211)
        Me.cmbUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(709, 25)
        Me.cmbUnit.TabIndex = 7
        '
        'nudY
        '
        Me.nudY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudY.DecimalPlaces = 2
        Me.nudY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudY.Location = New System.Drawing.Point(242, 107)
        Me.nudY.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.nudY.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudY.Name = "nudY"
        Me.nudY.Size = New System.Drawing.Size(237, 26)
        Me.nudY.TabIndex = 0
        Me.nudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudY.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudY.Visible = false
        '
        'cmbTirag
        '
        Me.cmbTirag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTirag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTirag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTirag.FormattingEnabled = true
        Me.cmbTirag.Location = New System.Drawing.Point(486, 108)
        Me.cmbTirag.Name = "cmbTirag"
        Me.cmbTirag.Size = New System.Drawing.Size(466, 25)
        Me.cmbTirag.TabIndex = 36
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tscmbSkidka, Me.tsbtnCost, Me.tstxtItog, Me.ToolStripLabel3, Me.tstxtCostUnit, Me.tsbtnOK, Me.tsbtnAddCost, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.tsbtnExit, Me.ToolStripButton2})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(170, 590)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(168, 18)
        Me.ToolStripLabel2.Text = "Скидка, %"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tscmbSkidka
        '
        Me.tscmbSkidka.Enabled = false
        Me.tscmbSkidka.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbSkidka.Name = "tscmbSkidka"
        Me.tscmbSkidka.Size = New System.Drawing.Size(166, 28)
        '
        'tsbtnCost
        '
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.Image = CType(resources.GetObject("tsbtnCost.Image"),System.Drawing.Image)
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(168, 30)
        Me.tsbtnCost.Text = "Считать"
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.ReadOnly = true
        Me.tstxtItog.Size = New System.Drawing.Size(166, 28)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(168, 18)
        Me.ToolStripLabel3.Text = "Стоимость за ед."
        '
        'tstxtCostUnit
        '
        Me.tstxtCostUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostUnit.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtCostUnit.Name = "tstxtCostUnit"
        Me.tstxtCostUnit.ReadOnly = true
        Me.tstxtCostUnit.Size = New System.Drawing.Size(166, 25)
        Me.tstxtCostUnit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Enabled = false
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(168, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'tsbtnAddCost
        '
        Me.tsbtnAddCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAddCost.Enabled = false
        Me.tsbtnAddCost.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnAddCost.Image = CType(resources.GetObject("tsbtnAddCost.Image"),System.Drawing.Image)
        Me.tsbtnAddCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddCost.Name = "tsbtnAddCost"
        Me.tsbtnAddCost.Size = New System.Drawing.Size(168, 31)
        Me.tsbtnAddCost.Text = "Ещё"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripButton1.Text = "Установка цен"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(168, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(168, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripButton2.Text = "52"
        '
        'c_UniCostWOColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 592)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "c_UniCostWOColor"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "52"
        Me.Text = "awc_UniCostWOColor"
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.tlpMain.ResumeLayout(false)
        Me.tlpMain.PerformLayout
        Me.cmsConfigTech.ResumeLayout(false)
        Me.cmsConfigMat.ResumeLayout(false)
        CType(Me.nudY,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmsConfigMat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbPriceGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPriceName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbParam2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents clbNacenki As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtCostUnit As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblMatTypes As System.Windows.Forms.Label
    Friend WithEvents nudY As System.Windows.Forms.NumericUpDown
    Friend WithEvents tsbtnAddCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsConfigTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tscmbSkidka As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmbSrok As System.Windows.Forms.ComboBox
    Friend WithEvents clbOper As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbTirag As System.Windows.Forms.ComboBox
End Class
