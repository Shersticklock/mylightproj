<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOnlinePaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddOnlinePaymentForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PersonLabel = New System.Windows.Forms.Label()
        Me.PersonComboBox = New System.Windows.Forms.ComboBox()
        Me.ActiveLabel = New System.Windows.Forms.Label()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
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
        Me.TableLayoutPanel1.Controls.Add(Me.NameLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NameTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PersonLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PersonComboBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ActiveLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ActiveCheckBox, 1, 2)
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(422, 120)
        Me.TableLayoutPanel1.TabIndex = 1
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
        'NameTextBox
        '
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(144, 3)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(274, 22)
        Me.NameTextBox.TabIndex = 8
        '
        'PersonLabel
        '
        Me.PersonLabel.AutoSize = true
        Me.PersonLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.PersonLabel.Location = New System.Drawing.Point(3, 40)
        Me.PersonLabel.Name = "PersonLabel"
        Me.PersonLabel.Size = New System.Drawing.Size(71, 16)
        Me.PersonLabel.TabIndex = 18
        Me.PersonLabel.Text = "Юр. Лицо"
        '
        'PersonComboBox
        '
        Me.PersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PersonComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.PersonComboBox.FormattingEnabled = true
        Me.PersonComboBox.Location = New System.Drawing.Point(144, 43)
        Me.PersonComboBox.Name = "PersonComboBox"
        Me.PersonComboBox.Size = New System.Drawing.Size(274, 24)
        Me.PersonComboBox.TabIndex = 11
        '
        'ActiveLabel
        '
        Me.ActiveLabel.AutoSize = true
        Me.ActiveLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ActiveLabel.Location = New System.Drawing.Point(3, 80)
        Me.ActiveLabel.Name = "ActiveLabel"
        Me.ActiveLabel.Size = New System.Drawing.Size(87, 16)
        Me.ActiveLabel.TabIndex = 7
        Me.ActiveLabel.Text = "Активность"
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = true
        Me.ActiveCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActiveCheckBox.Location = New System.Drawing.Point(144, 83)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(12, 11)
        Me.ActiveCheckBox.TabIndex = 17
        Me.ActiveCheckBox.UseVisualStyleBackColor = true
        '
        'SaveButton
        '
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.SaveButton.Location = New System.Drawing.Point(323, 148)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(111, 28)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Сохранить"
        Me.SaveButton.UseVisualStyleBackColor = true
        '
        'AddOnlinePaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 189)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "AddOnlinePaymentForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Параметры онлайн оплаты"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PersonComboBox As ComboBox
    Friend WithEvents PersonLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents ActiveLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents SaveButton As Button
End Class
