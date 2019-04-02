<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderPayment))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudPay = New System.Windows.Forms.TextBox()
        Me.PersonComboBox = New System.Windows.Forms.ComboBox()
        Me.PersonLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFoplName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDataPay = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomerDoc = New System.Windows.Forms.TextBox()
        Me.CassaLabel = New System.Windows.Forms.Label()
        Me.CassaComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ShortChangePanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ShortChangeValueLabel = New System.Windows.Forms.Label()
        Me.ShortChangeLabel = New System.Windows.Forms.Label()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.CashInputTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.OnlinePaymentTypeLabel = New System.Windows.Forms.Label()
        Me.OnlinePaymentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.ShortChangePanel.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.87129!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.12871!))
        Me.TableLayoutPanel1.Controls.Add(Me.OnlinePaymentTypeComboBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.OnlinePaymentTypeLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudPay, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PersonComboBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PersonLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFoplName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDataPay, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNomerDoc, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CassaLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CassaComboBox, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 12)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 261)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'nudPay
        '
        Me.nudPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudPay.Location = New System.Drawing.Point(160, 154)
        Me.nudPay.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudPay.Name = "nudPay"
        Me.nudPay.Size = New System.Drawing.Size(245, 27)
        Me.nudPay.TabIndex = 15
        Me.nudPay.Text = "0,00"
        Me.nudPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PersonComboBox
        '
        Me.PersonComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PersonComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.PersonComboBox.FormattingEnabled = true
        Me.PersonComboBox.Location = New System.Drawing.Point(160, 117)
        Me.PersonComboBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.PersonComboBox.Name = "PersonComboBox"
        Me.PersonComboBox.Size = New System.Drawing.Size(245, 25)
        Me.PersonComboBox.TabIndex = 14
        '
        'PersonLabel
        '
        Me.PersonLabel.AutoSize = true
        Me.PersonLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.PersonLabel.Location = New System.Drawing.Point(5, 111)
        Me.PersonLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PersonLabel.Name = "PersonLabel"
        Me.PersonLabel.Size = New System.Drawing.Size(145, 37)
        Me.PersonLabel.TabIndex = 13
        Me.PersonLabel.Text = "Юр. Лицо"
        Me.PersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Сумма, (руб.)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbFoplName
        '
        Me.cmbFoplName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFoplName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFoplName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFoplName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbFoplName.FormattingEnabled = true
        Me.cmbFoplName.Location = New System.Drawing.Point(160, 6)
        Me.cmbFoplName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbFoplName.Name = "cmbFoplName"
        Me.cmbFoplName.Size = New System.Drawing.Size(245, 25)
        Me.cmbFoplName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Форма оплаты"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDataPay
        '
        Me.dtpDataPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDataPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDataPay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataPay.Location = New System.Drawing.Point(160, 193)
        Me.dtpDataPay.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtpDataPay.Name = "dtpDataPay"
        Me.dtpDataPay.Size = New System.Drawing.Size(245, 26)
        Me.dtpDataPay.TabIndex = 6
        Me.dtpDataPay.Visible = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Дата платежа"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 225)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 36)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Номер"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = false
        '
        'txtNomerDoc
        '
        Me.txtNomerDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomerDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNomerDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNomerDoc.Location = New System.Drawing.Point(160, 231)
        Me.txtNomerDoc.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtNomerDoc.Name = "txtNomerDoc"
        Me.txtNomerDoc.Size = New System.Drawing.Size(245, 24)
        Me.txtNomerDoc.TabIndex = 9
        Me.txtNomerDoc.Visible = false
        '
        'CassaLabel
        '
        Me.CassaLabel.AutoSize = true
        Me.CassaLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CassaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CassaLabel.Location = New System.Drawing.Point(5, 74)
        Me.CassaLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.CassaLabel.Name = "CassaLabel"
        Me.CassaLabel.Size = New System.Drawing.Size(145, 37)
        Me.CassaLabel.TabIndex = 11
        Me.CassaLabel.Text = "Касса"
        Me.CassaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CassaComboBox
        '
        Me.CassaComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CassaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CassaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CassaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CassaComboBox.FormattingEnabled = true
        Me.CassaComboBox.Location = New System.Drawing.Point(160, 80)
        Me.CassaComboBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CassaComboBox.Name = "CassaComboBox"
        Me.CassaComboBox.Size = New System.Drawing.Size(245, 25)
        Me.CassaComboBox.TabIndex = 12
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ShortChangePanel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 3)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(583, 402)
        Me.TableLayoutPanel2.TabIndex = 34
        '
        'ShortChangePanel
        '
        Me.ShortChangePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ShortChangePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShortChangePanel.Controls.Add(Me.TableLayoutPanel3)
        Me.ShortChangePanel.Controls.Add(Me.Label5)
        Me.ShortChangePanel.Location = New System.Drawing.Point(9, 282)
        Me.ShortChangePanel.Name = "ShortChangePanel"
        Me.ShortChangePanel.Size = New System.Drawing.Size(412, 111)
        Me.ShortChangePanel.TabIndex = 35
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.80488!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.19512!))
        Me.TableLayoutPanel3.Controls.Add(Me.ShortChangeValueLabel, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ShortChangeLabel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.InputLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CashInputTextBox, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 35)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(410, 74)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'ShortChangeValueLabel
        '
        Me.ShortChangeValueLabel.AutoSize = true
        Me.ShortChangeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShortChangeValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ShortChangeValueLabel.Location = New System.Drawing.Point(160, 37)
        Me.ShortChangeValueLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ShortChangeValueLabel.Name = "ShortChangeValueLabel"
        Me.ShortChangeValueLabel.Size = New System.Drawing.Size(245, 37)
        Me.ShortChangeValueLabel.TabIndex = 13
        Me.ShortChangeValueLabel.Text = "0,00 руб."
        Me.ShortChangeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShortChangeLabel
        '
        Me.ShortChangeLabel.AutoSize = true
        Me.ShortChangeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShortChangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ShortChangeLabel.Location = New System.Drawing.Point(5, 37)
        Me.ShortChangeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ShortChangeLabel.Name = "ShortChangeLabel"
        Me.ShortChangeLabel.Size = New System.Drawing.Size(145, 37)
        Me.ShortChangeLabel.TabIndex = 12
        Me.ShortChangeLabel.Text = "Сдача"
        Me.ShortChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InputLabel
        '
        Me.InputLabel.AutoSize = true
        Me.InputLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.InputLabel.Location = New System.Drawing.Point(5, 0)
        Me.InputLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(145, 37)
        Me.InputLabel.TabIndex = 11
        Me.InputLabel.Text = "Внесено"
        Me.InputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CashInputTextBox
        '
        Me.CashInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CashInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CashInputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CashInputTextBox.Location = New System.Drawing.Point(160, 6)
        Me.CashInputTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CashInputTextBox.Name = "CashInputTextBox"
        Me.CashInputTextBox.Size = New System.Drawing.Size(245, 24)
        Me.CashInputTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(410, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Расчет сдачи"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = true
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.CancelButton, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.OkButton, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(429, 9)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel2.SetRowSpan(Me.TableLayoutPanel4, 2)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(145, 164)
        Me.TableLayoutPanel4.TabIndex = 36
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Location = New System.Drawing.Point(10, 92)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(10)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(125, 62)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "ОТМЕНА"
        Me.CancelButton.UseVisualStyleBackColor = false
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.OkButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkButton.Location = New System.Drawing.Point(10, 10)
        Me.OkButton.Margin = New System.Windows.Forms.Padding(10)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(125, 62)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "ОК"
        Me.OkButton.UseVisualStyleBackColor = false
        '
        'OnlinePaymentTypeLabel
        '
        Me.OnlinePaymentTypeLabel.AutoSize = true
        Me.OnlinePaymentTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OnlinePaymentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.OnlinePaymentTypeLabel.Location = New System.Drawing.Point(5, 37)
        Me.OnlinePaymentTypeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.OnlinePaymentTypeLabel.Name = "OnlinePaymentTypeLabel"
        Me.OnlinePaymentTypeLabel.Size = New System.Drawing.Size(145, 37)
        Me.OnlinePaymentTypeLabel.TabIndex = 16
        Me.OnlinePaymentTypeLabel.Text = "Название"
        Me.OnlinePaymentTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OnlinePaymentTypeComboBox
        '
        Me.OnlinePaymentTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OnlinePaymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OnlinePaymentTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OnlinePaymentTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.OnlinePaymentTypeComboBox.FormattingEnabled = true
        Me.OnlinePaymentTypeComboBox.Location = New System.Drawing.Point(160, 43)
        Me.OnlinePaymentTypeComboBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.OnlinePaymentTypeComboBox.Name = "OnlinePaymentTypeComboBox"
        Me.OnlinePaymentTypeComboBox.Size = New System.Drawing.Size(245, 25)
        Me.OnlinePaymentTypeComboBox.TabIndex = 17
        '
        'frmOrderPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(568, 366)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(372, 48)
        Me.Name = "frmOrderPayment"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Оплата заказа"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ShortChangePanel.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFoplName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataPay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNomerDoc As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CassaLabel As Label
    Friend WithEvents CassaComboBox As ComboBox
    Friend WithEvents PersonComboBox As ComboBox
    Friend WithEvents PersonLabel As Label
    Friend WithEvents ShortChangePanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ShortChangeValueLabel As Label
    Friend WithEvents ShortChangeLabel As Label
    Friend WithEvents InputLabel As Label
    Friend WithEvents CashInputTextBox As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents OkButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents nudPay As TextBox
    Friend WithEvents OnlinePaymentTypeLabel As Label
    Friend WithEvents OnlinePaymentTypeComboBox As ComboBox
End Class
