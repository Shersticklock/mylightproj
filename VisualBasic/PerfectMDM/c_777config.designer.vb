<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_777config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_777config))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpParamForCost = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblMat = New System.Windows.Forms.Label()
        Me.cmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.cmsConfigMat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.cmsConfigTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clbOper = New System.Windows.Forms.CheckedListBox()
        Me.tmbBinding = New System.Windows.Forms.ComboBox()
        Me.cmbBinding = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tmbMatTypes = New System.Windows.Forms.ComboBox()
        Me.cmsProd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьПродуктToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьПродуктToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTypesPlenka = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbTypesPlenka = New System.Windows.Forms.ComboBox()
        Me.cmbMatLam = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSideLam = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgMatFormat = New System.Windows.Forms.DataGridView()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlpMain.SuspendLayout
        Me.tlpParamForCost.SuspendLayout
        Me.cmsConfigMat.SuspendLayout
        Me.cmsConfigTech.SuspendLayout
        Me.cmsProd.SuspendLayout
        CType(Me.dgMatFormat,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tsMenu.SuspendLayout
        Me.SuspendLayout
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = true
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 3
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.Controls.Add(Me.tlpParamForCost, 0, 0)
        Me.tlpMain.Controls.Add(Me.tsMenu, 1, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpMain.Size = New System.Drawing.Size(1276, 610)
        Me.tlpMain.TabIndex = 0
        '
        'tlpParamForCost
        '
        Me.tlpParamForCost.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpParamForCost.ColumnCount = 3
        Me.tlpParamForCost.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpParamForCost.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpParamForCost.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpParamForCost.Controls.Add(Me.cmbMat, 2, 6)
        Me.tlpParamForCost.Controls.Add(Me.Label14, 1, 0)
        Me.tlpParamForCost.Controls.Add(Me.lblMat, 1, 5)
        Me.tlpParamForCost.Controls.Add(Me.cmbMatTypes, 2, 5)
        Me.tlpParamForCost.Controls.Add(Me.Label2, 1, 7)
        Me.tlpParamForCost.Controls.Add(Me.cmbColor, 2, 0)
        Me.tlpParamForCost.Controls.Add(Me.clbOper, 2, 7)
        Me.tlpParamForCost.Controls.Add(Me.tmbBinding, 2, 1)
        Me.tlpParamForCost.Controls.Add(Me.cmbBinding, 2, 2)
        Me.tlpParamForCost.Controls.Add(Me.Label1, 1, 1)
        Me.tlpParamForCost.Controls.Add(Me.Label21, 0, 5)
        Me.tlpParamForCost.Controls.Add(Me.tmbMatTypes, 0, 6)
        Me.tlpParamForCost.Controls.Add(Me.lblTypesPlenka, 1, 3)
        Me.tlpParamForCost.Controls.Add(Me.Label22, 1, 4)
        Me.tlpParamForCost.Controls.Add(Me.cmbTypesPlenka, 2, 3)
        Me.tlpParamForCost.Controls.Add(Me.cmbMatLam, 2, 4)
        Me.tlpParamForCost.Controls.Add(Me.Label4, 0, 0)
        Me.tlpParamForCost.Controls.Add(Me.cmbSideLam, 0, 4)
        Me.tlpParamForCost.Controls.Add(Me.Label3, 0, 3)
        Me.tlpParamForCost.Controls.Add(Me.dgMatFormat, 0, 7)
        Me.tlpParamForCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpParamForCost.Location = New System.Drawing.Point(4, 2)
        Me.tlpParamForCost.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.tlpParamForCost.Name = "tlpParamForCost"
        Me.tlpParamForCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tlpParamForCost.RowCount = 8
        Me.tlpParamForCost.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParamForCost.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParamForCost.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParamForCost.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParamForCost.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParamForCost.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParamForCost.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParamForCost.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParamForCost.Size = New System.Drawing.Size(1176, 606)
        Me.tlpParamForCost.TabIndex = 0
        '
        'cmbMat
        '
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.DropDownWidth = 500
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.Location = New System.Drawing.Point(698, 213)
        Me.cmbMat.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbMat.MaxDropDownItems = 20
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(473, 28)
        Me.cmbMat.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label14.Location = New System.Drawing.Point(486, 1)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 32)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Красочность"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMat
        '
        Me.lblMat.AutoSize = true
        Me.lblMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.lblMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblMat.Location = New System.Drawing.Point(486, 178)
        Me.lblMat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMat.Name = "lblMat"
        Me.tlpParamForCost.SetRowSpan(Me.lblMat, 2)
        Me.lblMat.Size = New System.Drawing.Size(203, 65)
        Me.lblMat.TabIndex = 39
        Me.lblMat.Text = "Материал"
        Me.lblMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMatTypes
        '
        Me.cmbMatTypes.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatTypes.DropDownWidth = 333
        Me.cmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatTypes.FormattingEnabled = true
        Me.cmbMatTypes.Location = New System.Drawing.Point(698, 180)
        Me.cmbMatTypes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbMatTypes.Name = "cmbMatTypes"
        Me.cmbMatTypes.Size = New System.Drawing.Size(473, 28)
        Me.cmbMatTypes.TabIndex = 13
        Me.cmbMatTypes.Tag = "mainMat"
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(486, 244)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 361)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Дополнительные операции"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbColor
        '
        Me.cmbColor.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbColor.Location = New System.Drawing.Point(698, 3)
        Me.cmbColor.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbColor.MaxDropDownItems = 24
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(473, 28)
        Me.cmbColor.TabIndex = 11
        Me.cmbColor.Tag = "color"
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
        'clbOper
        '
        Me.clbOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbOper.CheckOnClick = true
        Me.clbOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbOper.FormattingEnabled = true
        Me.clbOper.Location = New System.Drawing.Point(698, 248)
        Me.clbOper.Margin = New System.Windows.Forms.Padding(4)
        Me.clbOper.Name = "clbOper"
        Me.clbOper.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.clbOper.Size = New System.Drawing.Size(473, 353)
        Me.clbOper.TabIndex = 20
        Me.clbOper.Tag = "ppo"
        '
        'tmbBinding
        '
        Me.tmbBinding.ContextMenuStrip = Me.cmsConfigTech
        Me.tmbBinding.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tmbBinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tmbBinding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbBinding.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tmbBinding.FormattingEnabled = true
        Me.tmbBinding.Location = New System.Drawing.Point(697, 37)
        Me.tmbBinding.Name = "tmbBinding"
        Me.tmbBinding.Size = New System.Drawing.Size(475, 25)
        Me.tmbBinding.TabIndex = 61
        Me.tmbBinding.Tag = "bind"
        Me.ToolTip1.SetToolTip(Me.tmbBinding, "На каждый тип брошюровки задется по одной операции брошюровки ")
        '
        'cmbBinding
        '
        Me.cmbBinding.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbBinding.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbBinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBinding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBinding.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbBinding.FormattingEnabled = true
        Me.cmbBinding.Location = New System.Drawing.Point(697, 69)
        Me.cmbBinding.Name = "cmbBinding"
        Me.cmbBinding.Size = New System.Drawing.Size(475, 25)
        Me.cmbBinding.TabIndex = 62
        Me.cmbBinding.Tag = "bind"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(485, 34)
        Me.Label1.Name = "Label1"
        Me.tlpParamForCost.SetRowSpan(Me.Label1, 2)
        Me.Label1.Size = New System.Drawing.Size(205, 77)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Переплет (только для многостраничной продукции)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 178)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(472, 32)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Продукция (конфигурируются материал и доп. операции)"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmbMatTypes
        '
        Me.tmbMatTypes.ContextMenuStrip = Me.cmsProd
        Me.tmbMatTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tmbMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tmbMatTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbMatTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tmbMatTypes.Location = New System.Drawing.Point(5, 213)
        Me.tmbMatTypes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.tmbMatTypes.MaxDropDownItems = 24
        Me.tmbMatTypes.Name = "tmbMatTypes"
        Me.tmbMatTypes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tmbMatTypes.Size = New System.Drawing.Size(472, 28)
        Me.tmbMatTypes.TabIndex = 0
        Me.tmbMatTypes.Tag = "ppo"
        Me.ToolTip1.SetToolTip(Me.tmbMatTypes, "На продукцию определяются операции кроме печати, брошюровки и ламинирования.")
        '
        'cmsProd
        '
        Me.cmsProd.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsProd.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsProd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьПродуктToolStripMenuItem, Me.УдалитьПродуктToolStripMenuItem1, Me.ДобавитьТехнологическуюОперациюToolStripMenuItem})
        Me.cmsProd.Name = "cmsProd"
        Me.cmsProd.Size = New System.Drawing.Size(321, 76)
        '
        'ДобавитьПродуктToolStripMenuItem
        '
        Me.ДобавитьПродуктToolStripMenuItem.Name = "ДобавитьПродуктToolStripMenuItem"
        Me.ДобавитьПродуктToolStripMenuItem.Size = New System.Drawing.Size(320, 24)
        Me.ДобавитьПродуктToolStripMenuItem.Text = "Добавить продукт"
        '
        'УдалитьПродуктToolStripMenuItem1
        '
        Me.УдалитьПродуктToolStripMenuItem1.Name = "УдалитьПродуктToolStripMenuItem1"
        Me.УдалитьПродуктToolStripMenuItem1.Size = New System.Drawing.Size(320, 24)
        Me.УдалитьПродуктToolStripMenuItem1.Text = "Удалить продукт"
        '
        'ДобавитьТехнологическуюОперациюToolStripMenuItem
        '
        Me.ДобавитьТехнологическуюОперациюToolStripMenuItem.Name = "ДобавитьТехнологическуюОперациюToolStripMenuItem"
        Me.ДобавитьТехнологическуюОперациюToolStripMenuItem.Size = New System.Drawing.Size(320, 24)
        Me.ДобавитьТехнологическуюОперациюToolStripMenuItem.Text = "Задать технологические операции"
        '
        'lblTypesPlenka
        '
        Me.lblTypesPlenka.AutoSize = true
        Me.lblTypesPlenka.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.lblTypesPlenka.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTypesPlenka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblTypesPlenka.Location = New System.Drawing.Point(486, 112)
        Me.lblTypesPlenka.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTypesPlenka.Name = "lblTypesPlenka"
        Me.lblTypesPlenka.Size = New System.Drawing.Size(203, 32)
        Me.lblTypesPlenka.TabIndex = 2
        Me.lblTypesPlenka.Tag = "lam"
        Me.lblTypesPlenka.Text = "Тип пленки*"
        Me.lblTypesPlenka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTypesPlenka.Visible = false
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label22.Location = New System.Drawing.Point(486, 145)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(203, 32)
        Me.Label22.TabIndex = 3
        Me.Label22.Tag = "lam"
        Me.Label22.Text = "Пленка"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Visible = false
        '
        'cmbTypesPlenka
        '
        Me.cmbTypesPlenka.ContextMenuStrip = Me.cmsConfigMat
        Me.cmbTypesPlenka.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypesPlenka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypesPlenka.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTypesPlenka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypesPlenka.FormattingEnabled = true
        Me.cmbTypesPlenka.Location = New System.Drawing.Point(698, 114)
        Me.cmbTypesPlenka.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbTypesPlenka.Name = "cmbTypesPlenka"
        Me.cmbTypesPlenka.Size = New System.Drawing.Size(473, 28)
        Me.cmbTypesPlenka.TabIndex = 18
        Me.cmbTypesPlenka.Tag = "lam"
        '
        'cmbMatLam
        '
        Me.cmbMatLam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMatLam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMatLam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMatLam.FormattingEnabled = true
        Me.cmbMatLam.Location = New System.Drawing.Point(698, 147)
        Me.cmbMatLam.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbMatLam.Name = "cmbMatLam"
        Me.cmbMatLam.Size = New System.Drawing.Size(473, 28)
        Me.cmbMatLam.TabIndex = 19
        Me.cmbMatLam.Tag = "lam"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 1)
        Me.Label4.Name = "Label4"
        Me.tlpParamForCost.SetRowSpan(Me.Label4, 3)
        Me.Label4.Size = New System.Drawing.Size(474, 110)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Конфигурируется ко всему калькулятору"
        '
        'cmbSideLam
        '
        Me.cmbSideLam.ContextMenuStrip = Me.cmsConfigTech
        Me.cmbSideLam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSideLam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSideLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSideLam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSideLam.FormattingEnabled = true
        Me.cmbSideLam.Location = New System.Drawing.Point(5, 147)
        Me.cmbSideLam.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.cmbSideLam.Name = "cmbSideLam"
        Me.cmbSideLam.Size = New System.Drawing.Size(472, 28)
        Me.cmbSideLam.TabIndex = 17
        Me.cmbSideLam.Tag = "lam"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(474, 32)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Ламинирование (конфигурируются операция и материал пленки)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgMatFormat
        '
        Me.dgMatFormat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMatFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMatFormat.Location = New System.Drawing.Point(4, 247)
        Me.dgMatFormat.Name = "dgMatFormat"
        Me.dgMatFormat.RowTemplate.Height = 24
        Me.dgMatFormat.Size = New System.Drawing.Size(474, 355)
        Me.dgMatFormat.TabIndex = 60
        Me.dgMatFormat.Visible = false
        '
        'tsMenu
        '
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsMenu.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnExit})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsMenu.Location = New System.Drawing.Point(1184, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(92, 610)
        Me.tsMenu.TabIndex = 1
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(90, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'c_777config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1276, 610)
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "c_777config"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "55"
        Me.Text = "awc_Polygraph"
        Me.tlpMain.ResumeLayout(false)
        Me.tlpMain.PerformLayout
        Me.tlpParamForCost.ResumeLayout(false)
        Me.tlpParamForCost.PerformLayout
        Me.cmsConfigMat.ResumeLayout(false)
        Me.cmsConfigTech.ResumeLayout(false)
        Me.cmsProd.ResumeLayout(false)
        CType(Me.dgMatFormat,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsMenu.ResumeLayout(false)
        Me.tsMenu.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpParamForCost As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTypesPlenka As System.Windows.Forms.ComboBox
    Friend WithEvents cmsConfigMat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbMatLam As System.Windows.Forms.ComboBox
    Friend WithEvents lblTypesPlenka As System.Windows.Forms.Label
    Friend WithEvents tmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMat As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbSideLam As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMatTypes As System.Windows.Forms.ComboBox
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsConfigTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clbOper As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmsProd As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьПродуктToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьПродуктToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДобавитьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbColor As System.Windows.Forms.ComboBox
    Friend WithEvents dgMatFormat As System.Windows.Forms.DataGridView
    Friend WithEvents tmbBinding As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBinding As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
