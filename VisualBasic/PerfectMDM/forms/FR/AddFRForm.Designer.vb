<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFRForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddFRForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PersonComboBox = New System.Windows.Forms.ComboBox()
        Me.PersonLabel = New System.Windows.Forms.Label()
        Me.RnKktTextBox = New System.Windows.Forms.TextBox()
        Me.RnKktLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ShortNameLabel = New System.Windows.Forms.Label()
        Me.IpAddressLabel = New System.Windows.Forms.Label()
        Me.ComPortLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.OfficeLabel = New System.Windows.Forms.Label()
        Me.VirtualLabel = New System.Windows.Forms.Label()
        Me.ActiveLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ShortNameTextBox = New System.Windows.Forms.TextBox()
        Me.IpAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ComPortTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OfficeComboBox = New System.Windows.Forms.ComboBox()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.VirtualCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.64269!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.35731!))
        Me.TableLayoutPanel1.Controls.Add(Me.PersonComboBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PersonLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.RnKktTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RnKktLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NameLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ShortNameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.IpAddressLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ComPortLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.PasswordLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.OfficeLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.VirtualLabel, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.ActiveLabel, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.NameTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ShortNameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.IpAddressTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ComPortTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.PasswordTextBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.OfficeComboBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.ActiveCheckBox, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.VirtualCheckBox, 1, 8)
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(422, 400)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PersonComboBox
        '
        Me.PersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PersonComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.PersonComboBox.FormattingEnabled = true
        Me.PersonComboBox.Location = New System.Drawing.Point(144, 123)
        Me.PersonComboBox.Name = "PersonComboBox"
        Me.PersonComboBox.Size = New System.Drawing.Size(274, 24)
        Me.PersonComboBox.TabIndex = 11
        '
        'PersonLabel
        '
        Me.PersonLabel.AutoSize = true
        Me.PersonLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.PersonLabel.Location = New System.Drawing.Point(3, 120)
        Me.PersonLabel.Name = "PersonLabel"
        Me.PersonLabel.Size = New System.Drawing.Size(71, 16)
        Me.PersonLabel.TabIndex = 18
        Me.PersonLabel.Text = "Юр. Лицо"
        '
        'RnKktTextBox
        '
        Me.RnKktTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RnKktTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.RnKktTextBox.Location = New System.Drawing.Point(144, 83)
        Me.RnKktTextBox.Name = "RnKktTextBox"
        Me.RnKktTextBox.Size = New System.Drawing.Size(274, 22)
        Me.RnKktTextBox.TabIndex = 10
        '
        'RnKktLabel
        '
        Me.RnKktLabel.AutoSize = true
        Me.RnKktLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.RnKktLabel.Location = New System.Drawing.Point(3, 80)
        Me.RnKktLabel.Name = "RnKktLabel"
        Me.RnKktLabel.Size = New System.Drawing.Size(55, 16)
        Me.RnKktLabel.TabIndex = 16
        Me.RnKktLabel.Text = "РН ККТ"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = true
        Me.NameLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.NameLabel.Location = New System.Drawing.Point(3, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(68, 16)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Название"
        '
        'ShortNameLabel
        '
        Me.ShortNameLabel.AutoSize = true
        Me.ShortNameLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ShortNameLabel.Location = New System.Drawing.Point(3, 40)
        Me.ShortNameLabel.Name = "ShortNameLabel"
        Me.ShortNameLabel.Size = New System.Drawing.Size(105, 16)
        Me.ShortNameLabel.TabIndex = 1
        Me.ShortNameLabel.Text = "Сокр. название"
        '
        'IpAddressLabel
        '
        Me.IpAddressLabel.AutoSize = true
        Me.IpAddressLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.IpAddressLabel.Location = New System.Drawing.Point(3, 160)
        Me.IpAddressLabel.Name = "IpAddressLabel"
        Me.IpAddressLabel.Size = New System.Drawing.Size(64, 16)
        Me.IpAddressLabel.TabIndex = 2
        Me.IpAddressLabel.Text = "IP-адрес"
        '
        'ComPortLabel
        '
        Me.ComPortLabel.AutoSize = true
        Me.ComPortLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ComPortLabel.Location = New System.Drawing.Point(3, 200)
        Me.ComPortLabel.Name = "ComPortLabel"
        Me.ComPortLabel.Size = New System.Drawing.Size(72, 16)
        Me.ComPortLabel.TabIndex = 3
        Me.ComPortLabel.Text = "COM порт"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = true
        Me.PasswordLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(3, 240)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(57, 16)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Пароль"
        '
        'OfficeLabel
        '
        Me.OfficeLabel.AutoSize = true
        Me.OfficeLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.OfficeLabel.Location = New System.Drawing.Point(3, 280)
        Me.OfficeLabel.Name = "OfficeLabel"
        Me.OfficeLabel.Size = New System.Drawing.Size(42, 16)
        Me.OfficeLabel.TabIndex = 5
        Me.OfficeLabel.Text = "Офис"
        '
        'VirtualLabel
        '
        Me.VirtualLabel.AutoSize = true
        Me.VirtualLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.VirtualLabel.Location = New System.Drawing.Point(3, 320)
        Me.VirtualLabel.Name = "VirtualLabel"
        Me.VirtualLabel.Size = New System.Drawing.Size(133, 16)
        Me.VirtualLabel.TabIndex = 6
        Me.VirtualLabel.Text = "Виртуальная касса"
        '
        'ActiveLabel
        '
        Me.ActiveLabel.AutoSize = true
        Me.ActiveLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ActiveLabel.Location = New System.Drawing.Point(3, 360)
        Me.ActiveLabel.Name = "ActiveLabel"
        Me.ActiveLabel.Size = New System.Drawing.Size(87, 16)
        Me.ActiveLabel.TabIndex = 7
        Me.ActiveLabel.Text = "Активность"
        '
        'NameTextBox
        '
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(144, 3)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(274, 22)
        Me.NameTextBox.TabIndex = 8
        '
        'ShortNameTextBox
        '
        Me.ShortNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShortNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ShortNameTextBox.Location = New System.Drawing.Point(144, 43)
        Me.ShortNameTextBox.Name = "ShortNameTextBox"
        Me.ShortNameTextBox.Size = New System.Drawing.Size(274, 22)
        Me.ShortNameTextBox.TabIndex = 9
        '
        'IpAddressTextBox
        '
        Me.IpAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IpAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.IpAddressTextBox.Location = New System.Drawing.Point(144, 163)
        Me.IpAddressTextBox.Name = "IpAddressTextBox"
        Me.IpAddressTextBox.Size = New System.Drawing.Size(274, 22)
        Me.IpAddressTextBox.TabIndex = 12
        '
        'ComPortTextBox
        '
        Me.ComPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ComPortTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ComPortTextBox.Location = New System.Drawing.Point(144, 203)
        Me.ComPortTextBox.Name = "ComPortTextBox"
        Me.ComPortTextBox.Size = New System.Drawing.Size(274, 22)
        Me.ComPortTextBox.TabIndex = 13
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(144, 243)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(274, 22)
        Me.PasswordTextBox.TabIndex = 14
        '
        'OfficeComboBox
        '
        Me.OfficeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OfficeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OfficeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.OfficeComboBox.FormattingEnabled = true
        Me.OfficeComboBox.Location = New System.Drawing.Point(144, 283)
        Me.OfficeComboBox.Name = "OfficeComboBox"
        Me.OfficeComboBox.Size = New System.Drawing.Size(274, 24)
        Me.OfficeComboBox.TabIndex = 15
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = true
        Me.ActiveCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActiveCheckBox.Location = New System.Drawing.Point(144, 363)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(12, 11)
        Me.ActiveCheckBox.TabIndex = 17
        Me.ActiveCheckBox.UseVisualStyleBackColor = true
        '
        'VirtualCheckBox
        '
        Me.VirtualCheckBox.AutoSize = true
        Me.VirtualCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VirtualCheckBox.Location = New System.Drawing.Point(144, 323)
        Me.VirtualCheckBox.Name = "VirtualCheckBox"
        Me.VirtualCheckBox.Size = New System.Drawing.Size(12, 11)
        Me.VirtualCheckBox.TabIndex = 16
        Me.VirtualCheckBox.UseVisualStyleBackColor = true
        '
        'SaveButton
        '
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.SaveButton.Location = New System.Drawing.Point(323, 429)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(111, 28)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "Сохранить"
        Me.SaveButton.UseVisualStyleBackColor = true
        '
        'AddFRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 467)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "AddFRForm"
        Me.ShowIcon = false
        Me.Text = "Параметры ФР"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NameLabel As Label
    Friend WithEvents ShortNameLabel As Label
    Friend WithEvents IpAddressLabel As Label
    Friend WithEvents ComPortLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents OfficeLabel As Label
    Friend WithEvents VirtualLabel As Label
    Friend WithEvents ActiveLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ShortNameTextBox As TextBox
    Friend WithEvents IpAddressTextBox As TextBox
    Friend WithEvents ComPortTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents OfficeComboBox As ComboBox
    Friend WithEvents VirtualCheckBox As CheckBox
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents PersonComboBox As ComboBox
    Friend WithEvents PersonLabel As Label
    Friend WithEvents RnKktTextBox As TextBox
    Friend WithEvents RnKktLabel As Label
End Class
