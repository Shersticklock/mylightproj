<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_Kassa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_Kassa))
        Me.cmbOffice = New System.Windows.Forms.ComboBox()
        Me.lblOffice = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgCashless = New System.Windows.Forms.DataGridView()
        Me.btnUpdateCashless = New System.Windows.Forms.Button()
        Me.tlpKassa = New System.Windows.Forms.TableLayoutPanel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.txtDescriptionCashless = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudCashless = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnApplyCashless = New System.Windows.Forms.Button()
        Me.btnUpdateCash = New System.Windows.Forms.Button()
        Me.dgCash = New System.Windows.Forms.DataGridView()
        Me.nudCash = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescriptionCash = New System.Windows.Forms.TextBox()
        Me.btnApplyCash = New System.Windows.Forms.Button()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.cmbModeCashless = New System.Windows.Forms.ComboBox()
        Me.cmbOrganization = New System.Windows.Forms.ComboBox()
        Me.cmbModeCash = New System.Windows.Forms.ComboBox()
        Me.txtPwdCash = New System.Windows.Forms.TextBox()
        Me.cmbFounder = New System.Windows.Forms.ComboBox()
        Me.cmbFounder1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgCashless,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tlpKassa.SuspendLayout
        Me.ContextMenuStrip1.SuspendLayout
        CType(Me.nudCashless,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgCash,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudCash,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cmbOffice
        '
        Me.tlpKassa.SetColumnSpan(Me.cmbOffice, 2)
        Me.cmbOffice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOffice.FormattingEnabled = true
        Me.cmbOffice.Location = New System.Drawing.Point(884, 63)
        Me.cmbOffice.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbOffice.Name = "cmbOffice"
        Me.cmbOffice.Size = New System.Drawing.Size(386, 28)
        Me.cmbOffice.TabIndex = 71
        '
        'lblOffice
        '
        Me.lblOffice.AutoSize = true
        Me.tlpKassa.SetColumnSpan(Me.lblOffice, 2)
        Me.lblOffice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblOffice.Location = New System.Drawing.Point(884, 38)
        Me.lblOffice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(386, 18)
        Me.lblOffice.TabIndex = 73
        Me.lblOffice.Text = "Выбери офис"
        Me.lblOffice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgCashless
        '
        Me.dgCashless.AllowUserToAddRows = false
        Me.dgCashless.AllowUserToDeleteRows = false
        Me.dgCashless.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCashless.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCashless.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCashless.Location = New System.Drawing.Point(5, 41)
        Me.dgCashless.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgCashless.MultiSelect = false
        Me.dgCashless.Name = "dgCashless"
        Me.dgCashless.ReadOnly = true
        Me.dgCashless.RowHeadersVisible = false
        Me.tlpKassa.SetRowSpan(Me.dgCashless, 6)
        Me.dgCashless.RowTemplate.Height = 24
        Me.dgCashless.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCashless.Size = New System.Drawing.Size(237, 359)
        Me.dgCashless.TabIndex = 71
        '
        'btnUpdateCashless
        '
        Me.btnUpdateCashless.AutoSize = true
        Me.btnUpdateCashless.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdateCashless.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdateCashless.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateCashless.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnUpdateCashless.Location = New System.Drawing.Point(5, 4)
        Me.btnUpdateCashless.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnUpdateCashless.Name = "btnUpdateCashless"
        Me.btnUpdateCashless.Size = New System.Drawing.Size(237, 30)
        Me.btnUpdateCashless.TabIndex = 74
        Me.btnUpdateCashless.Text = "Обновить"
        Me.btnUpdateCashless.UseVisualStyleBackColor = true
        '
        'tlpKassa
        '
        Me.tlpKassa.AutoSize = true
        Me.tlpKassa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpKassa.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpKassa.ColumnCount = 6
        Me.tlpKassa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpKassa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpKassa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpKassa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpKassa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpKassa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpKassa.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tlpKassa.Controls.Add(Me.dgCashless, 0, 1)
        Me.tlpKassa.Controls.Add(Me.lblOffice, 4, 1)
        Me.tlpKassa.Controls.Add(Me.txtDescriptionCashless, 2, 4)
        Me.tlpKassa.Controls.Add(Me.Label5, 1, 4)
        Me.tlpKassa.Controls.Add(Me.Label4, 1, 3)
        Me.tlpKassa.Controls.Add(Me.nudCashless, 2, 3)
        Me.tlpKassa.Controls.Add(Me.Label6, 1, 1)
        Me.tlpKassa.Controls.Add(Me.btnApplyCashless, 2, 6)
        Me.tlpKassa.Controls.Add(Me.btnUpdateCashless, 0, 0)
        Me.tlpKassa.Controls.Add(Me.btnUpdateCash, 3, 0)
        Me.tlpKassa.Controls.Add(Me.dgCash, 3, 1)
        Me.tlpKassa.Controls.Add(Me.nudCash, 5, 3)
        Me.tlpKassa.Controls.Add(Me.Label8, 4, 3)
        Me.tlpKassa.Controls.Add(Me.Label9, 4, 4)
        Me.tlpKassa.Controls.Add(Me.txtDescriptionCash, 5, 4)
        Me.tlpKassa.Controls.Add(Me.btnApplyCash, 5, 6)
        Me.tlpKassa.Controls.Add(Me.txtPwd, 1, 6)
        Me.tlpKassa.Controls.Add(Me.cmbModeCashless, 1, 0)
        Me.tlpKassa.Controls.Add(Me.cmbOrganization, 1, 2)
        Me.tlpKassa.Controls.Add(Me.cmbOffice, 4, 2)
        Me.tlpKassa.Controls.Add(Me.cmbModeCash, 4, 0)
        Me.tlpKassa.Controls.Add(Me.txtPwdCash, 4, 6)
        Me.tlpKassa.Controls.Add(Me.cmbFounder, 1, 5)
        Me.tlpKassa.Controls.Add(Me.cmbFounder1, 4, 5)
        Me.tlpKassa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpKassa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpKassa.Location = New System.Drawing.Point(0, 0)
        Me.tlpKassa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tlpKassa.Name = "tlpKassa"
        Me.tlpKassa.RowCount = 7
        Me.tlpKassa.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpKassa.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpKassa.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpKassa.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpKassa.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpKassa.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpKassa.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpKassa.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28!))
        Me.tlpKassa.Size = New System.Drawing.Size(1276, 404)
        Me.tlpKassa.TabIndex = 75
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 29)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'txtDescriptionCashless
        '
        Me.txtDescriptionCashless.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescriptionCashless.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescriptionCashless.Location = New System.Drawing.Point(448, 134)
        Me.txtDescriptionCashless.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDescriptionCashless.Multiline = true
        Me.txtDescriptionCashless.Name = "txtDescriptionCashless"
        Me.txtDescriptionCashless.Size = New System.Drawing.Size(180, 58)
        Me.txtDescriptionCashless.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Примечание"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 32)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Сумма (руб.)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudCashless
        '
        Me.nudCashless.DecimalPlaces = 2
        Me.nudCashless.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCashless.Location = New System.Drawing.Point(448, 101)
        Me.nudCashless.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudCashless.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudCashless.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCashless.Name = "nudCashless"
        Me.nudCashless.Size = New System.Drawing.Size(180, 26)
        Me.nudCashless.TabIndex = 78
        Me.nudCashless.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCashless.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.tlpKassa.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(251, 38)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(377, 18)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Выбери организацию"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnApplyCashless
        '
        Me.btnApplyCashless.AutoSize = true
        Me.btnApplyCashless.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnApplyCashless.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApplyCashless.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyCashless.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnApplyCashless.Location = New System.Drawing.Point(448, 234)
        Me.btnApplyCashless.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnApplyCashless.Name = "btnApplyCashless"
        Me.btnApplyCashless.Size = New System.Drawing.Size(180, 30)
        Me.btnApplyCashless.TabIndex = 81
        Me.btnApplyCashless.Text = "Применить"
        Me.btnApplyCashless.UseVisualStyleBackColor = true
        '
        'btnUpdateCash
        '
        Me.btnUpdateCash.AutoSize = true
        Me.btnUpdateCash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdateCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdateCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnUpdateCash.Location = New System.Drawing.Point(637, 4)
        Me.btnUpdateCash.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnUpdateCash.Name = "btnUpdateCash"
        Me.btnUpdateCash.Size = New System.Drawing.Size(237, 30)
        Me.btnUpdateCash.TabIndex = 87
        Me.btnUpdateCash.Text = "Обновить"
        Me.btnUpdateCash.UseVisualStyleBackColor = true
        '
        'dgCash
        '
        Me.dgCash.AllowUserToAddRows = false
        Me.dgCash.AllowUserToDeleteRows = false
        Me.dgCash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCash.Location = New System.Drawing.Point(637, 41)
        Me.dgCash.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgCash.MultiSelect = false
        Me.dgCash.Name = "dgCash"
        Me.dgCash.ReadOnly = true
        Me.dgCash.RowHeadersVisible = false
        Me.tlpKassa.SetRowSpan(Me.dgCash, 6)
        Me.dgCash.RowTemplate.Height = 24
        Me.dgCash.Size = New System.Drawing.Size(237, 359)
        Me.dgCash.TabIndex = 84
        '
        'nudCash
        '
        Me.nudCash.DecimalPlaces = 2
        Me.nudCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCash.Location = New System.Drawing.Point(1080, 101)
        Me.nudCash.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudCash.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudCash.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCash.Name = "nudCash"
        Me.nudCash.Size = New System.Drawing.Size(191, 26)
        Me.nudCash.TabIndex = 90
        Me.nudCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCash.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(883, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 32)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Сумма (руб.)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label9.Location = New System.Drawing.Point(883, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 18)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Примечание"
        '
        'txtDescriptionCash
        '
        Me.txtDescriptionCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescriptionCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescriptionCash.Location = New System.Drawing.Point(1080, 134)
        Me.txtDescriptionCash.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDescriptionCash.Multiline = true
        Me.txtDescriptionCash.Name = "txtDescriptionCash"
        Me.txtDescriptionCash.Size = New System.Drawing.Size(191, 58)
        Me.txtDescriptionCash.TabIndex = 93
        '
        'btnApplyCash
        '
        Me.btnApplyCash.AutoSize = true
        Me.btnApplyCash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnApplyCash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApplyCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnApplyCash.Location = New System.Drawing.Point(1080, 234)
        Me.btnApplyCash.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnApplyCash.Name = "btnApplyCash"
        Me.btnApplyCash.Size = New System.Drawing.Size(191, 30)
        Me.btnApplyCash.TabIndex = 89
        Me.btnApplyCash.Text = "Применить"
        Me.btnApplyCash.UseVisualStyleBackColor = true
        '
        'txtPwd
        '
        Me.txtPwd.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPwd.Location = New System.Drawing.Point(251, 234)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(188, 26)
        Me.txtPwd.TabIndex = 96
        '
        'cmbModeCashless
        '
        Me.tlpKassa.SetColumnSpan(Me.cmbModeCashless, 2)
        Me.cmbModeCashless.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbModeCashless.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeCashless.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbModeCashless.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbModeCashless.FormattingEnabled = true
        Me.cmbModeCashless.Items.AddRange(New Object() {"Снять со счета", "Внести на счет"})
        Me.cmbModeCashless.Location = New System.Drawing.Point(251, 4)
        Me.cmbModeCashless.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbModeCashless.Name = "cmbModeCashless"
        Me.cmbModeCashless.Size = New System.Drawing.Size(377, 28)
        Me.cmbModeCashless.TabIndex = 83
        '
        'cmbOrganization
        '
        Me.tlpKassa.SetColumnSpan(Me.cmbOrganization, 2)
        Me.cmbOrganization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrganization.FormattingEnabled = true
        Me.cmbOrganization.Location = New System.Drawing.Point(251, 60)
        Me.cmbOrganization.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbOrganization.Name = "cmbOrganization"
        Me.cmbOrganization.Size = New System.Drawing.Size(377, 28)
        Me.cmbOrganization.TabIndex = 95
        '
        'cmbModeCash
        '
        Me.tlpKassa.SetColumnSpan(Me.cmbModeCash, 2)
        Me.cmbModeCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbModeCash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbModeCash.FormattingEnabled = true
        Me.cmbModeCash.Items.AddRange(New Object() {"Инкассирование", "Внести в кассу"})
        Me.cmbModeCash.Location = New System.Drawing.Point(883, 4)
        Me.cmbModeCash.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbModeCash.Name = "cmbModeCash"
        Me.cmbModeCash.Size = New System.Drawing.Size(388, 28)
        Me.cmbModeCash.TabIndex = 97
        '
        'txtPwdCash
        '
        Me.txtPwdCash.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPwdCash.Location = New System.Drawing.Point(883, 234)
        Me.txtPwdCash.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPwdCash.Name = "txtPwdCash"
        Me.txtPwdCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwdCash.Size = New System.Drawing.Size(188, 26)
        Me.txtPwdCash.TabIndex = 98
        '
        'cmbFounder
        '
        Me.tlpKassa.SetColumnSpan(Me.cmbFounder, 2)
        Me.cmbFounder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFounder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFounder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFounder.FormattingEnabled = true
        Me.cmbFounder.Location = New System.Drawing.Point(251, 199)
        Me.cmbFounder.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbFounder.Name = "cmbFounder"
        Me.cmbFounder.Size = New System.Drawing.Size(377, 28)
        Me.cmbFounder.TabIndex = 99
        '
        'cmbFounder1
        '
        Me.tlpKassa.SetColumnSpan(Me.cmbFounder1, 2)
        Me.cmbFounder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFounder1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFounder1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFounder1.FormattingEnabled = true
        Me.cmbFounder1.Location = New System.Drawing.Point(883, 199)
        Me.cmbFounder1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbFounder1.Name = "cmbFounder1"
        Me.cmbFounder1.Size = New System.Drawing.Size(388, 28)
        Me.cmbFounder1.TabIndex = 100
        '
        'fin_Kassa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1276, 404)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.tlpKassa)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MinimizeBox = false
        Me.Name = "fin_Kassa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Касса"
        CType(Me.dgCashless,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpKassa.ResumeLayout(false)
        Me.tlpKassa.PerformLayout
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.ContextMenuStrip1.PerformLayout
        CType(Me.nudCashless,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgCash,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudCash,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmbOffice As System.Windows.Forms.ComboBox
    Friend WithEvents lblOffice As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dgCashless As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdateCashless As System.Windows.Forms.Button
    Friend WithEvents tlpKassa As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtDescriptionCashless As System.Windows.Forms.TextBox
    Friend WithEvents btnApplyCashless As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudCashless As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbModeCashless As System.Windows.Forms.ComboBox
    Friend WithEvents btnApplyCash As System.Windows.Forms.Button
    Friend WithEvents nudCash As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescriptionCash As System.Windows.Forms.TextBox
    Friend WithEvents cmbOrganization As System.Windows.Forms.ComboBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents cmbModeCash As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnUpdateCash As System.Windows.Forms.Button
    Friend WithEvents dgCash As System.Windows.Forms.DataGridView
    Friend WithEvents txtPwdCash As System.Windows.Forms.TextBox
    Friend WithEvents cmbFounder As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFounder1 As System.Windows.Forms.ComboBox
End Class
