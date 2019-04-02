<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tech_OperCost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tech_OperCost))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbNacName = New System.Windows.Forms.ComboBox()
        Me.btnSaveCost = New System.Windows.Forms.Button()
        Me.УдалитьToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbOperType = New System.Windows.Forms.ComboBox()
        Me.ИзменитьToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpNacenka = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNacK = New System.Windows.Forms.TextBox()
        Me.cmbOperationNac = New System.Windows.Forms.ComboBox()
        Me.btnSaveNac = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgPrice = New System.Windows.Forms.DataGridView()
        Me.cmsEquipFundCost = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзменитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpRow = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstOperations = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudProd = New System.Windows.Forms.NumericUpDown()
        Me.nudCost = New System.Windows.Forms.NumericUpDown()
        Me.cmbEquip = New System.Windows.Forms.ComboBox()
        Me.dgNac = New System.Windows.Forms.DataGridView()
        Me.cmsNacEquip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdImportXML = New System.Windows.Forms.OpenFileDialog()
        Me.sfdExportFileXML = New System.Windows.Forms.SaveFileDialog()
        Me.cmbEqip = New System.Windows.Forms.ComboBox()
        Me.tlpNacenka.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.dgPrice,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsEquipFundCost.SuspendLayout
        Me.tlpRow.SuspendLayout
        CType(Me.nudProd,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgNac,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsNacEquip.SuspendLayout
        Me.SuspendLayout
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Метрика"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(567, 1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Стомость, (руб.)"
        '
        'cmbNacName
        '
        Me.cmbNacName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbNacName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNacName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbNacName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbNacName.FormattingEnabled = true
        Me.cmbNacName.Location = New System.Drawing.Point(5, 24)
        Me.cmbNacName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNacName.Name = "cmbNacName"
        Me.cmbNacName.Size = New System.Drawing.Size(356, 25)
        Me.cmbNacName.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cmbNacName, "Наценки добавляются в справочнике главной формы Наценки на нанесение")
        Me.cmbNacName.Visible = false
        '
        'btnSaveCost
        '
        Me.btnSaveCost.AutoSize = true
        Me.btnSaveCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCost.Location = New System.Drawing.Point(1014, 5)
        Me.btnSaveCost.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveCost.Name = "btnSaveCost"
        Me.tlpRow.SetRowSpan(Me.btnSaveCost, 2)
        Me.btnSaveCost.Size = New System.Drawing.Size(231, 76)
        Me.btnSaveCost.TabIndex = 13
        Me.btnSaveCost.Text = "Сохранить"
        Me.btnSaveCost.UseVisualStyleBackColor = true
        '
        'УдалитьToolStripMenuItem1
        '
        Me.УдалитьToolStripMenuItem1.Name = "УдалитьToolStripMenuItem1"
        Me.УдалитьToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.УдалитьToolStripMenuItem1.Text = "Удалить"
        '
        'cmbOperType
        '
        Me.cmbOperType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOperType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOperType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOperType.FormattingEnabled = true
        Me.cmbOperType.Location = New System.Drawing.Point(369, 24)
        Me.cmbOperType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOperType.Name = "cmbOperType"
        Me.cmbOperType.Size = New System.Drawing.Size(189, 25)
        Me.cmbOperType.TabIndex = 6
        '
        'ИзменитьToolStripMenuItem1
        '
        Me.ИзменитьToolStripMenuItem1.Name = "ИзменитьToolStripMenuItem1"
        Me.ИзменитьToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.ИзменитьToolStripMenuItem1.Text = "Изменить"
        '
        'tlpNacenka
        '
        Me.tlpNacenka.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpNacenka.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpNacenka.ColumnCount = 4
        Me.tlpNacenka.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpNacenka.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpNacenka.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpNacenka.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357!))
        Me.tlpNacenka.Controls.Add(Me.Label10, 0, 0)
        Me.tlpNacenka.Controls.Add(Me.Label7, 1, 0)
        Me.tlpNacenka.Controls.Add(Me.Label8, 2, 0)
        Me.tlpNacenka.Controls.Add(Me.txtNacK, 2, 1)
        Me.tlpNacenka.Controls.Add(Me.cmbOperationNac, 1, 1)
        Me.tlpNacenka.Controls.Add(Me.cmbNacName, 0, 1)
        Me.tlpNacenka.Controls.Add(Me.btnSaveNac, 3, 1)
        Me.tlpNacenka.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpNacenka.Enabled = false
        Me.tlpNacenka.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpNacenka.Location = New System.Drawing.Point(4, 638)
        Me.tlpNacenka.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpNacenka.Name = "tlpNacenka"
        Me.tlpNacenka.RowCount = 2
        Me.tlpNacenka.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNacenka.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNacenka.Size = New System.Drawing.Size(1268, 78)
        Me.tlpNacenka.TabIndex = 38
        Me.tlpNacenka.Visible = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 1)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Наименование"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(370, 1)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Операция"
        Me.Label7.Visible = false
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(735, 1)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Наценка, (%)"
        Me.Label8.Visible = false
        '
        'txtNacK
        '
        Me.txtNacK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNacK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNacK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNacK.Location = New System.Drawing.Point(735, 24)
        Me.txtNacK.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNacK.Name = "txtNacK"
        Me.txtNacK.Size = New System.Drawing.Size(169, 24)
        Me.txtNacK.TabIndex = 8
        Me.txtNacK.Visible = false
        '
        'cmbOperationNac
        '
        Me.cmbOperationNac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOperationNac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperationNac.DropDownWidth = 400
        Me.cmbOperationNac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOperationNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOperationNac.FormattingEnabled = true
        Me.cmbOperationNac.Location = New System.Drawing.Point(370, 24)
        Me.cmbOperationNac.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOperationNac.Name = "cmbOperationNac"
        Me.cmbOperationNac.Size = New System.Drawing.Size(356, 25)
        Me.cmbOperationNac.TabIndex = 12
        Me.cmbOperationNac.Visible = false
        '
        'btnSaveNac
        '
        Me.btnSaveNac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveNac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveNac.Location = New System.Drawing.Point(913, 24)
        Me.btnSaveNac.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveNac.Name = "btnSaveNac"
        Me.btnSaveNac.Size = New System.Drawing.Size(350, 49)
        Me.btnSaveNac.TabIndex = 13
        Me.btnSaveNac.Text = "Сохранить"
        Me.btnSaveNac.UseVisualStyleBackColor = true
        Me.btnSaveNac.Visible = false
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgPrice, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpRow, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpNacenka, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbEquip, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgNac, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 720)
        Me.TableLayoutPanel1.TabIndex = 41
        '
        'dgPrice
        '
        Me.dgPrice.AllowUserToAddRows = false
        Me.dgPrice.AllowUserToDeleteRows = false
        Me.dgPrice.AllowUserToResizeRows = false
        Me.dgPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrice.ContextMenuStrip = Me.cmsEquipFundCost
        Me.dgPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPrice.Location = New System.Drawing.Point(4, 37)
        Me.dgPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPrice.Name = "dgPrice"
        Me.dgPrice.ReadOnly = true
        Me.dgPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPrice.Size = New System.Drawing.Size(1268, 286)
        Me.dgPrice.TabIndex = 34
        '
        'cmsEquipFundCost
        '
        Me.cmsEquipFundCost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsEquipFundCost.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsEquipFundCost.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem, Me.ИзменитьToolStripMenuItem, Me.УдалитьToolStripMenuItem})
        Me.cmsEquipFundCost.Name = "ContextMenuStrip1"
        Me.cmsEquipFundCost.Size = New System.Drawing.Size(134, 70)
        '
        'ДобавитьToolStripMenuItem
        '
        Me.ДобавитьToolStripMenuItem.Name = "ДобавитьToolStripMenuItem"
        Me.ДобавитьToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ДобавитьToolStripMenuItem.Text = "Добавить"
        '
        'ИзменитьToolStripMenuItem
        '
        Me.ИзменитьToolStripMenuItem.Name = "ИзменитьToolStripMenuItem"
        Me.ИзменитьToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ИзменитьToolStripMenuItem.Text = "Изменить"
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.УдалитьToolStripMenuItem.Text = "Удалить"
        '
        'tlpRow
        '
        Me.tlpRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRow.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpRow.ColumnCount = 5
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.84185!))
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.15815!))
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256!))
        Me.tlpRow.Controls.Add(Me.Label4, 2, 0)
        Me.tlpRow.Controls.Add(Me.btnSaveCost, 4, 0)
        Me.tlpRow.Controls.Add(Me.cmbOperType, 1, 1)
        Me.tlpRow.Controls.Add(Me.Label3, 0, 0)
        Me.tlpRow.Controls.Add(Me.Label2, 1, 0)
        Me.tlpRow.Controls.Add(Me.lstOperations, 0, 1)
        Me.tlpRow.Controls.Add(Me.Label5, 3, 0)
        Me.tlpRow.Controls.Add(Me.nudProd, 3, 1)
        Me.tlpRow.Controls.Add(Me.nudCost, 2, 1)
        Me.tlpRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRow.Enabled = false
        Me.tlpRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpRow.Location = New System.Drawing.Point(4, 331)
        Me.tlpRow.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpRow.Name = "tlpRow"
        Me.tlpRow.RowCount = 2
        Me.tlpRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRow.Size = New System.Drawing.Size(1268, 118)
        Me.tlpRow.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(355, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Операция"
        '
        'lstOperations
        '
        Me.lstOperations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstOperations.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstOperations.FormattingEnabled = true
        Me.lstOperations.ItemHeight = 17
        Me.lstOperations.Location = New System.Drawing.Point(5, 24)
        Me.lstOperations.Margin = New System.Windows.Forms.Padding(4)
        Me.lstOperations.Name = "lstOperations"
        Me.lstOperations.Size = New System.Drawing.Size(355, 89)
        Me.lstOperations.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(732, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(274, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Производительность (в час.)"
        '
        'nudProd
        '
        Me.nudProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudProd.DecimalPlaces = 2
        Me.nudProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudProd.Location = New System.Drawing.Point(732, 23)
        Me.nudProd.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudProd.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudProd.Name = "nudProd"
        Me.nudProd.Size = New System.Drawing.Size(274, 24)
        Me.nudProd.TabIndex = 16
        Me.nudProd.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'nudCost
        '
        Me.nudCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudCost.DecimalPlaces = 2
        Me.nudCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudCost.Location = New System.Drawing.Point(566, 23)
        Me.nudCost.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCost.Name = "nudCost"
        Me.nudCost.Size = New System.Drawing.Size(159, 24)
        Me.nudCost.TabIndex = 17
        '
        'cmbEquip
        '
        Me.cmbEquip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEquip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEquip.FormattingEnabled = true
        Me.cmbEquip.Location = New System.Drawing.Point(4, 4)
        Me.cmbEquip.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEquip.MaxDropDownItems = 16
        Me.cmbEquip.Name = "cmbEquip"
        Me.cmbEquip.Size = New System.Drawing.Size(1268, 25)
        Me.cmbEquip.TabIndex = 5
        '
        'dgNac
        '
        Me.dgNac.AllowUserToAddRows = false
        Me.dgNac.AllowUserToDeleteRows = false
        Me.dgNac.AllowUserToResizeRows = false
        Me.dgNac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgNac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgNac.ContextMenuStrip = Me.cmsNacEquip
        Me.dgNac.Location = New System.Drawing.Point(4, 475)
        Me.dgNac.Margin = New System.Windows.Forms.Padding(4)
        Me.dgNac.Name = "dgNac"
        Me.dgNac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgNac.Size = New System.Drawing.Size(1265, 155)
        Me.dgNac.TabIndex = 36
        Me.dgNac.Visible = false
        '
        'cmsNacEquip
        '
        Me.cmsNacEquip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsNacEquip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsNacEquip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem1, Me.ИзменитьToolStripMenuItem1, Me.УдалитьToolStripMenuItem1})
        Me.cmsNacEquip.Name = "cmsNacEquip"
        Me.cmsNacEquip.Size = New System.Drawing.Size(134, 70)
        '
        'ДобавитьToolStripMenuItem1
        '
        Me.ДобавитьToolStripMenuItem1.Name = "ДобавитьToolStripMenuItem1"
        Me.ДобавитьToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.ДобавитьToolStripMenuItem1.Text = "Добавить"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 453)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Наценки"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Visible = false
        '
        'ofdImportXML
        '
        Me.ofdImportXML.FileName = "OpenFileDialog1"
        '
        'cmbEqip
        '
        Me.cmbEqip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEqip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEqip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEqip.FormattingEnabled = true
        Me.cmbEqip.Location = New System.Drawing.Point(0, 0)
        Me.cmbEqip.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEqip.Name = "cmbEqip"
        Me.cmbEqip.Size = New System.Drawing.Size(1276, 24)
        Me.cmbEqip.TabIndex = 40
        '
        'tech_OperCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 720)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cmbEqip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "tech_OperCost"
        Me.Text = "Производительность и стоимость технологических операций"
        Me.tlpNacenka.ResumeLayout(false)
        Me.tlpNacenka.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.dgPrice,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsEquipFundCost.ResumeLayout(false)
        Me.tlpRow.ResumeLayout(false)
        Me.tlpRow.PerformLayout
        CType(Me.nudProd,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgNac,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsNacEquip.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbNacName As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveCost As System.Windows.Forms.Button
    Friend WithEvents УдалитьToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbOperType As System.Windows.Forms.ComboBox
    Friend WithEvents ИзменитьToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpNacenka As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNacK As System.Windows.Forms.TextBox
    Friend WithEvents cmbOperationNac As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveNac As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgPrice As System.Windows.Forms.DataGridView
    Friend WithEvents cmsEquipFundCost As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзменитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpRow As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEquip As System.Windows.Forms.ComboBox
    Friend WithEvents dgNac As System.Windows.Forms.DataGridView
    Friend WithEvents cmsNacEquip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ofdImportXML As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdExportFileXML As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmbEqip As System.Windows.Forms.ComboBox
    Friend WithEvents lstOperations As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudProd As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCost As System.Windows.Forms.NumericUpDown
End Class
