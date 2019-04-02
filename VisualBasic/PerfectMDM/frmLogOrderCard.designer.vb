<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogOrderCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogOrderCard))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudTimeG2 = New System.Windows.Forms.NumericUpDown()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFindKA = New System.Windows.Forms.TextBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateG = New System.Windows.Forms.DateTimePicker()
        Me.cmbPersona = New System.Windows.Forms.ComboBox()
        Me.nudTimeG1 = New System.Windows.Forms.NumericUpDown()
        Me.cmbGeoPointName = New System.Windows.Forms.ComboBox()
        Me.cmsNewLogPoint = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьТочкуДоставкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbNazn = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrim = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.cmbIntDost = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudTimeG2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        CType(Me.nudTimeG1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsNewLogPoint.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.20362!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.79638!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.nudTimeG2, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFindKA, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCustomer, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateG, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPersona, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudTimeG1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbGeoPointName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbNazn, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrim, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTel, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbIntDost, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(859, 383)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'nudTimeG2
        '
        Me.nudTimeG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudTimeG2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudTimeG2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudTimeG2.Location = New System.Drawing.Point(555, 179)
        Me.nudTimeG2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudTimeG2.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudTimeG2.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudTimeG2.Name = "nudTimeG2"
        Me.nudTimeG2.Size = New System.Drawing.Size(239, 24)
        Me.nudTimeG2.TabIndex = 6
        Me.nudTimeG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTimeG2.Value = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudTimeG2.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOK, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(799, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TableLayoutPanel1.SetRowSpan(Me.ToolStrip1, 8)
        Me.ToolStrip1.Size = New System.Drawing.Size(60, 383)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnOK
        '
        Me.tsbtnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(58, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(58, 6)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton2.Text = "Выход"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 173)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 36)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Интервал времени (час.)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 32)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Телефон"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 37)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Персона"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 31)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Точка доставки"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindKA
        '
        Me.txtFindKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFindKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFindKA.Location = New System.Drawing.Point(5, 6)
        Me.txtFindKA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFindKA.Name = "txtFindKA"
        Me.txtFindKA.Size = New System.Drawing.Size(233, 24)
        Me.txtFindKA.TabIndex = 0
        Me.txtFindKA.Text = "Куда"
        Me.txtFindKA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFindKA.Visible = false
        '
        'cmbCustomer
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbCustomer, 2)
        Me.cmbCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.DropDownWidth = 333
        Me.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustomer.FormattingEnabled = true
        Me.cmbCustomer.Location = New System.Drawing.Point(248, 6)
        Me.cmbCustomer.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbCustomer.MaxDropDownItems = 25
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(546, 25)
        Me.cmbCustomer.TabIndex = 1
        Me.cmbCustomer.Visible = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Когда"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = false
        '
        'dtpDateG
        '
        Me.dtpDateG.CustomFormat = "dd.MM.yyyy 10:00"
        Me.dtpDateG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDateG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateG.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateG.Location = New System.Drawing.Point(555, 143)
        Me.dtpDateG.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDateG.Name = "dtpDateG"
        Me.dtpDateG.Size = New System.Drawing.Size(239, 24)
        Me.dtpDateG.TabIndex = 4
        '
        'cmbPersona
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbPersona, 2)
        Me.cmbPersona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPersona.FormattingEnabled = true
        Me.cmbPersona.Location = New System.Drawing.Point(248, 74)
        Me.cmbPersona.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbPersona.Name = "cmbPersona"
        Me.cmbPersona.Size = New System.Drawing.Size(546, 25)
        Me.cmbPersona.TabIndex = 2
        '
        'nudTimeG1
        '
        Me.nudTimeG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudTimeG1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudTimeG1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudTimeG1.Location = New System.Drawing.Point(248, 179)
        Me.nudTimeG1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudTimeG1.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudTimeG1.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudTimeG1.Name = "nudTimeG1"
        Me.nudTimeG1.Size = New System.Drawing.Size(297, 24)
        Me.nudTimeG1.TabIndex = 5
        Me.nudTimeG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTimeG1.Value = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudTimeG1.Visible = false
        '
        'cmbGeoPointName
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbGeoPointName, 2)
        Me.cmbGeoPointName.ContextMenuStrip = Me.cmsNewLogPoint
        Me.cmbGeoPointName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbGeoPointName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeoPointName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbGeoPointName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbGeoPointName.FormattingEnabled = true
        Me.cmbGeoPointName.Location = New System.Drawing.Point(247, 40)
        Me.cmbGeoPointName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbGeoPointName.Name = "cmbGeoPointName"
        Me.cmbGeoPointName.Size = New System.Drawing.Size(548, 25)
        Me.cmbGeoPointName.TabIndex = 37
        '
        'cmsNewLogPoint
        '
        Me.cmsNewLogPoint.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsNewLogPoint.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsNewLogPoint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьТочкуДоставкиToolStripMenuItem})
        Me.cmsNewLogPoint.Name = "cmsNewLogPoint"
        Me.cmsNewLogPoint.Size = New System.Drawing.Size(241, 28)
        '
        'ДобавитьТочкуДоставкиToolStripMenuItem
        '
        Me.ДобавитьТочкуДоставкиToolStripMenuItem.Name = "ДобавитьТочкуДоставкиToolStripMenuItem"
        Me.ДобавитьТочкуДоставкиToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.ДобавитьТочкуДоставкиToolStripMenuItem.Text = "Добавить точку доставки"
        '
        'cmbNazn
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbNazn, 2)
        Me.cmbNazn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbNazn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNazn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbNazn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbNazn.FormattingEnabled = true
        Me.cmbNazn.Items.AddRange(New Object() {"Доставка заказа клиенту", "Частичная доставка заказа клиенту", "Забрать продукцию у подрядчика", "Забрать товар у поставщика"})
        Me.cmbNazn.Location = New System.Drawing.Point(248, 215)
        Me.cmbNazn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbNazn.Name = "cmbNazn"
        Me.cmbNazn.Size = New System.Drawing.Size(546, 25)
        Me.cmbNazn.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 246)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 137)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Примечание"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrim
        '
        Me.txtPrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPrim, 2)
        Me.txtPrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPrim.Location = New System.Drawing.Point(247, 249)
        Me.txtPrim.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPrim.Multiline = true
        Me.txtPrim.Name = "txtPrim"
        Me.txtPrim.Size = New System.Drawing.Size(548, 131)
        Me.txtPrim.TabIndex = 41
        '
        'txtTel
        '
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTel, 2)
        Me.txtTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTel.Location = New System.Drawing.Point(247, 109)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTel.Mask = "(999) 000-00-00"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(548, 24)
        Me.txtTel.TabIndex = 42
        '
        'cmbIntDost
        '
        Me.cmbIntDost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbIntDost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIntDost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbIntDost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbIntDost.FormattingEnabled = true
        Me.cmbIntDost.Items.AddRange(New Object() {"Первая половина дня", "Вторая половина дня"})
        Me.cmbIntDost.Location = New System.Drawing.Point(247, 141)
        Me.cmbIntDost.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbIntDost.Name = "cmbIntDost"
        Me.cmbIntDost.Size = New System.Drawing.Size(299, 25)
        Me.cmbIntDost.TabIndex = 43
        Me.cmbIntDost.Visible = false
        '
        'frmLogOrderCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(859, 383)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmLogOrderCard"
        Me.Text = "Заявка на доставку"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudTimeG2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.nudTimeG1,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsNewLogPoint.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateG As System.Windows.Forms.DateTimePicker
    Friend WithEvents nudTimeG2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtFindKA As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPersona As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNazn As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudTimeG1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbGeoPointName As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrim As System.Windows.Forms.TextBox
    Friend WithEvents cmsNewLogPoint As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьТочкуДоставкиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbIntDost As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
