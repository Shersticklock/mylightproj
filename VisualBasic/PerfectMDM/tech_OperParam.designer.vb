<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tech_OperParam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tech_OperParam))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tlpParam = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbParamTechOper = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.nudKC = New System.Windows.Forms.NumericUpDown()
        Me.nudAC = New System.Windows.Forms.NumericUpDown()
        Me.nudKT = New System.Windows.Forms.NumericUpDown()
        Me.nudAT = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudSaleK1 = New System.Windows.Forms.NumericUpDown()
        Me.nudSaleK2 = New System.Windows.Forms.NumericUpDown()
        Me.nudSaleA = New System.Windows.Forms.NumericUpDown()
        Me.nudSaleMin = New System.Windows.Forms.NumericUpDown()
        Me.nudSaleMax = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbTypeOper = New System.Windows.Forms.ComboBox()
        Me.chkDefaultState = New System.Windows.Forms.CheckBox()
        Me.clbPrintFormat = New System.Windows.Forms.CheckedListBox()
        Me.clbDouble = New System.Windows.Forms.CheckedListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkMatForOper = New System.Windows.Forms.CheckBox()
        Me.tsCompany = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tlpParam.SuspendLayout
        CType(Me.nudKC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudAC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudKT,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudAT,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudSaleK1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudSaleK2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudSaleA,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudSaleMin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudSaleMax,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tsCompany.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        '
        'lstData
        '
        Me.lstData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstData.HorizontalScrollbar = true
        Me.lstData.ItemHeight = 17
        Me.lstData.Location = New System.Drawing.Point(5, 39)
        Me.lstData.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(434, 755)
        Me.lstData.TabIndex = 65
        Me.lstData.TabStop = false
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtName.Location = New System.Drawing.Point(312, 6)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtName.MaxLength = 245
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(339, 24)
        Me.txtName.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 105)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(297, 32)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Производство стоимость (руб.)"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlpParam
        '
        Me.tlpParam.AutoSize = true
        Me.tlpParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpParam.ColumnCount = 2
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.Controls.Add(Me.txtName, 1, 0)
        Me.tlpParam.Controls.Add(Me.Label22, 0, 3)
        Me.tlpParam.Controls.Add(Me.Label6, 0, 2)
        Me.tlpParam.Controls.Add(Me.Label10, 0, 0)
        Me.tlpParam.Controls.Add(Me.Label8, 0, 4)
        Me.tlpParam.Controls.Add(Me.cmbParamTechOper, 1, 2)
        Me.tlpParam.Controls.Add(Me.Label7, 0, 5)
        Me.tlpParam.Controls.Add(Me.Label1, 0, 6)
        Me.tlpParam.Controls.Add(Me.Label2, 0, 1)
        Me.tlpParam.Controls.Add(Me.txtdescription, 1, 1)
        Me.tlpParam.Controls.Add(Me.nudKC, 1, 3)
        Me.tlpParam.Controls.Add(Me.nudAC, 1, 4)
        Me.tlpParam.Controls.Add(Me.nudKT, 1, 5)
        Me.tlpParam.Controls.Add(Me.nudAT, 1, 6)
        Me.tlpParam.Controls.Add(Me.Label3, 0, 7)
        Me.tlpParam.Controls.Add(Me.Label4, 0, 8)
        Me.tlpParam.Controls.Add(Me.Label5, 0, 9)
        Me.tlpParam.Controls.Add(Me.Label9, 0, 10)
        Me.tlpParam.Controls.Add(Me.Label11, 0, 11)
        Me.tlpParam.Controls.Add(Me.nudSaleK1, 1, 7)
        Me.tlpParam.Controls.Add(Me.nudSaleK2, 1, 8)
        Me.tlpParam.Controls.Add(Me.nudSaleA, 1, 9)
        Me.tlpParam.Controls.Add(Me.nudSaleMin, 1, 10)
        Me.tlpParam.Controls.Add(Me.nudSaleMax, 1, 11)
        Me.tlpParam.Controls.Add(Me.Label13, 0, 13)
        Me.tlpParam.Controls.Add(Me.cmbTypeOper, 1, 13)
        Me.tlpParam.Controls.Add(Me.chkDefaultState, 1, 14)
        Me.tlpParam.Controls.Add(Me.clbPrintFormat, 0, 15)
        Me.tlpParam.Controls.Add(Me.clbDouble, 1, 15)
        Me.tlpParam.Controls.Add(Me.Label12, 0, 14)
        Me.tlpParam.Controls.Add(Me.chkMatForOper, 1, 12)
        Me.tlpParam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpParam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpParam.Location = New System.Drawing.Point(449, 6)
        Me.tlpParam.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tlpParam.Name = "tlpParam"
        Me.tlpParam.RowCount = 16
        Me.TableLayoutPanel1.SetRowSpan(Me.tlpParam, 2)
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.Size = New System.Drawing.Size(656, 788)
        Me.tlpParam.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(5, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(297, 37)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Департамент"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label10.Size = New System.Drawing.Size(297, 36)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Наименование"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 137)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(297, 32)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Наладка стоимость (руб.)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbParamTechOper
        '
        Me.cmbParamTechOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbParamTechOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParamTechOper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbParamTechOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbParamTechOper.FormattingEnabled = true
        Me.cmbParamTechOper.Location = New System.Drawing.Point(312, 74)
        Me.cmbParamTechOper.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbParamTechOper.MaxDropDownItems = 30
        Me.cmbParamTechOper.Name = "cmbParamTechOper"
        Me.cmbParamTechOper.Size = New System.Drawing.Size(339, 25)
        Me.cmbParamTechOper.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 169)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 32)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Производство время (с)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 32)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Производство наладка (с)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 32)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Описание"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdescription
        '
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtdescription.Location = New System.Drawing.Point(311, 40)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(341, 24)
        Me.txtdescription.TabIndex = 102
        '
        'nudKC
        '
        Me.nudKC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudKC.DecimalPlaces = 2
        Me.nudKC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudKC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudKC.Location = New System.Drawing.Point(311, 109)
        Me.nudKC.Margin = New System.Windows.Forms.Padding(4)
        Me.nudKC.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudKC.Name = "nudKC"
        Me.nudKC.Size = New System.Drawing.Size(341, 24)
        Me.nudKC.TabIndex = 103
        Me.nudKC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudAC
        '
        Me.nudAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudAC.DecimalPlaces = 2
        Me.nudAC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudAC.Location = New System.Drawing.Point(311, 141)
        Me.nudAC.Margin = New System.Windows.Forms.Padding(4)
        Me.nudAC.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudAC.Name = "nudAC"
        Me.nudAC.Size = New System.Drawing.Size(341, 24)
        Me.nudAC.TabIndex = 104
        Me.nudAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudKT
        '
        Me.nudKT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudKT.DecimalPlaces = 2
        Me.nudKT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudKT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudKT.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudKT.Location = New System.Drawing.Point(311, 173)
        Me.nudKT.Margin = New System.Windows.Forms.Padding(4)
        Me.nudKT.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudKT.Name = "nudKT"
        Me.nudKT.Size = New System.Drawing.Size(341, 24)
        Me.nudKT.TabIndex = 105
        Me.nudKT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudKT.ThousandsSeparator = true
        Me.nudKT.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'nudAT
        '
        Me.nudAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudAT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudAT.Location = New System.Drawing.Point(311, 205)
        Me.nudAT.Margin = New System.Windows.Forms.Padding(4)
        Me.nudAT.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nudAT.Name = "nudAT"
        Me.nudAT.Size = New System.Drawing.Size(341, 24)
        Me.nudAT.TabIndex = 106
        Me.nudAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 233)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 32)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Продажа K1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 265)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 32)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Продажа К2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 297)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(299, 32)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Продажа А"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 329)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(299, 32)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Продажа min"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 361)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(299, 32)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "Продажа max"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudSaleK1
        '
        Me.nudSaleK1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSaleK1.DecimalPlaces = 6
        Me.nudSaleK1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSaleK1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSaleK1.Location = New System.Drawing.Point(311, 237)
        Me.nudSaleK1.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSaleK1.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSaleK1.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.nudSaleK1.Name = "nudSaleK1"
        Me.nudSaleK1.Size = New System.Drawing.Size(341, 24)
        Me.nudSaleK1.TabIndex = 112
        Me.nudSaleK1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudSaleK2
        '
        Me.nudSaleK2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSaleK2.DecimalPlaces = 4
        Me.nudSaleK2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSaleK2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSaleK2.Location = New System.Drawing.Point(311, 269)
        Me.nudSaleK2.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSaleK2.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSaleK2.Name = "nudSaleK2"
        Me.nudSaleK2.Size = New System.Drawing.Size(341, 24)
        Me.nudSaleK2.TabIndex = 113
        Me.nudSaleK2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudSaleA
        '
        Me.nudSaleA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSaleA.DecimalPlaces = 2
        Me.nudSaleA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSaleA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSaleA.Location = New System.Drawing.Point(311, 301)
        Me.nudSaleA.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSaleA.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSaleA.Name = "nudSaleA"
        Me.nudSaleA.Size = New System.Drawing.Size(341, 24)
        Me.nudSaleA.TabIndex = 114
        Me.nudSaleA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudSaleMin
        '
        Me.nudSaleMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSaleMin.DecimalPlaces = 2
        Me.nudSaleMin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSaleMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSaleMin.Location = New System.Drawing.Point(311, 333)
        Me.nudSaleMin.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSaleMin.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSaleMin.Name = "nudSaleMin"
        Me.nudSaleMin.Size = New System.Drawing.Size(341, 24)
        Me.nudSaleMin.TabIndex = 115
        Me.nudSaleMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudSaleMax
        '
        Me.nudSaleMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSaleMax.DecimalPlaces = 2
        Me.nudSaleMax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSaleMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSaleMax.Location = New System.Drawing.Point(311, 365)
        Me.nudSaleMax.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSaleMax.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSaleMax.Name = "nudSaleMax"
        Me.nudSaleMax.Size = New System.Drawing.Size(341, 24)
        Me.nudSaleMax.TabIndex = 116
        Me.nudSaleMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(3, 421)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(301, 31)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "Над чем выполняется"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTypeOper
        '
        Me.cmbTypeOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeOper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTypeOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypeOper.FormattingEnabled = true
        Me.cmbTypeOper.Location = New System.Drawing.Point(310, 424)
        Me.cmbTypeOper.Name = "cmbTypeOper"
        Me.cmbTypeOper.Size = New System.Drawing.Size(343, 25)
        Me.cmbTypeOper.TabIndex = 121
        '
        'chkDefaultState
        '
        Me.chkDefaultState.AutoSize = true
        Me.chkDefaultState.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkDefaultState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDefaultState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkDefaultState.Location = New System.Drawing.Point(449, 455)
        Me.chkDefaultState.Name = "chkDefaultState"
        Me.chkDefaultState.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDefaultState.Size = New System.Drawing.Size(204, 22)
        Me.chkDefaultState.TabIndex = 122
        Me.chkDefaultState.Text = "Состояние по умолчанию"
        Me.chkDefaultState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDefaultState.UseVisualStyleBackColor = true
        '
        'clbPrintFormat
        '
        Me.clbPrintFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbPrintFormat.CheckOnClick = true
        Me.clbPrintFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbPrintFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbPrintFormat.FormattingEnabled = true
        Me.clbPrintFormat.Location = New System.Drawing.Point(3, 483)
        Me.clbPrintFormat.Name = "clbPrintFormat"
        Me.clbPrintFormat.Size = New System.Drawing.Size(301, 302)
        Me.clbPrintFormat.TabIndex = 125
        '
        'clbDouble
        '
        Me.clbDouble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbDouble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbDouble.Enabled = false
        Me.clbDouble.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbDouble.FormattingEnabled = true
        Me.clbDouble.Location = New System.Drawing.Point(310, 483)
        Me.clbDouble.MultiColumn = true
        Me.clbDouble.Name = "clbDouble"
        Me.clbDouble.Size = New System.Drawing.Size(343, 302)
        Me.clbDouble.TabIndex = 126
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 452)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(301, 28)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "Установка форматов"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'chkMatForOper
        '
        Me.chkMatForOper.AutoSize = true
        Me.chkMatForOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkMatForOper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMatForOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkMatForOper.Location = New System.Drawing.Point(310, 396)
        Me.chkMatForOper.Name = "chkMatForOper"
        Me.chkMatForOper.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkMatForOper.Size = New System.Drawing.Size(343, 22)
        Me.chkMatForOper.TabIndex = 128
        Me.chkMatForOper.Text = "Требует списания материала"
        Me.chkMatForOper.UseVisualStyleBackColor = true
        '
        'tsCompany
        '
        Me.tsCompany.AutoSize = false
        Me.tsCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsCompany.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.tsbtnEdit, Me.tsbtnSave, Me.tsbtnCancel, Me.tsbtnDelete, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.tsCompany.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCompany.Location = New System.Drawing.Point(1110, 0)
        Me.tsCompany.Name = "tsCompany"
        Me.TableLayoutPanel1.SetRowSpan(Me.tsCompany, 2)
        Me.tsCompany.Size = New System.Drawing.Size(166, 800)
        Me.tsCompany.TabIndex = 67
        Me.tsCompany.Text = "ToolStrip1"
        '
        'tsbtnNew
        '
        Me.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNew.Image = CType(resources.GetObject("tsbtnNew.Image"),System.Drawing.Image)
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(164, 22)
        Me.tsbtnNew.Text = "Создать"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEdit.Image = CType(resources.GetObject("tsbtnEdit.Image"),System.Drawing.Image)
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(164, 22)
        Me.tsbtnEdit.Text = "Изменить"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"),System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(164, 22)
        Me.tsbtnSave.Text = "Сохранить"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(164, 22)
        Me.tsbtnCancel.Text = "Отменить"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelete.Image = CType(resources.GetObject("tsbtnDelete.Image"),System.Drawing.Image)
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(164, 22)
        Me.tsbtnDelete.Text = "Удалить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(164, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166!))
        Me.TableLayoutPanel1.Controls.Add(Me.lstData, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tsCompany, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpParam, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbDep, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 800)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'cmbDep
        '
        Me.cmbDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDep.FormattingEnabled = true
        Me.cmbDep.Location = New System.Drawing.Point(4, 4)
        Me.cmbDep.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDep.MaxDropDownItems = 25
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(436, 25)
        Me.cmbDep.TabIndex = 68
        '
        'tech_OperParam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1276, 800)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "tech_OperParam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Технологические операции - параметры"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpParam.ResumeLayout(false)
        Me.tlpParam.PerformLayout
        CType(Me.nudKC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudAC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudKT,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudAT,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudSaleK1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudSaleK2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudSaleA,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudSaleMin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudSaleMax,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsCompany.ResumeLayout(false)
        Me.tsCompany.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents tlpParam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbParamTechOper As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents tsCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents nudKC As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAC As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudKT As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAT As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nudSaleK1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSaleK2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSaleA As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSaleMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSaleMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbDep As System.Windows.Forms.ComboBox
    Friend WithEvents chkDefaultState As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbTypeOper As System.Windows.Forms.ComboBox
    Friend WithEvents clbPrintFormat As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbDouble As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkMatForOper As System.Windows.Forms.CheckBox
End Class
