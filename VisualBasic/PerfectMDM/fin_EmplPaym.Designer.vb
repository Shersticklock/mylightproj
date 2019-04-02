<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_EmplPaym
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_EmplPaym))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmpl = New System.Windows.Forms.Label()
        Me.cmbEmpl = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.nudAmount = New System.Windows.Forms.NumericUpDown()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.chklbEmpl = New System.Windows.Forms.CheckedListBox()
        Me.cmsSettings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ВыделитьВсеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СброситьВсеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbFopl = New System.Windows.Forms.ComboBox()
        Me.cmbOrgOffice = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudAmount,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsSettings.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.13713!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.86287!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmpl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbEmpl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMonth, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudAmount, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLimit, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLimit, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescription, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDescription, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.chklbEmpl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbYear, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFopl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbOrgOffice, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(989, 708)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 491)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(377, 34)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Сумма, на сотрудника (руб.)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpl
        '
        Me.lblEmpl.AutoSize = true
        Me.lblEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblEmpl.Location = New System.Drawing.Point(5, 354)
        Me.lblEmpl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmpl.Name = "lblEmpl"
        Me.lblEmpl.Size = New System.Drawing.Size(377, 35)
        Me.lblEmpl.TabIndex = 1
        Me.lblEmpl.Text = "Сотрудник"
        Me.lblEmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEmpl
        '
        Me.cmbEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEmpl.FormattingEnabled = true
        Me.cmbEmpl.Location = New System.Drawing.Point(392, 359)
        Me.cmbEmpl.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbEmpl.MaxDropDownItems = 16
        Me.cmbEmpl.Name = "cmbEmpl"
        Me.cmbEmpl.Size = New System.Drawing.Size(592, 25)
        Me.cmbEmpl.TabIndex = 0
        '
        'cmbMonth
        '
        Me.cmbMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMonth.FormattingEnabled = true
        Me.cmbMonth.Items.AddRange(New Object() {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"})
        Me.cmbMonth.Location = New System.Drawing.Point(392, 394)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMonth.MaxDropDownItems = 12
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(592, 25)
        Me.cmbMonth.TabIndex = 1
        '
        'nudAmount
        '
        Me.nudAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudAmount.DecimalPlaces = 2
        Me.nudAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudAmount.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAmount.Location = New System.Drawing.Point(392, 496)
        Me.nudAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.nudAmount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(592, 24)
        Me.nudAmount.TabIndex = 2
        Me.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLimit
        '
        Me.lblLimit.AutoSize = true
        Me.lblLimit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblLimit.Location = New System.Drawing.Point(5, 457)
        Me.lblLimit.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(377, 34)
        Me.lblLimit.TabIndex = 4
        Me.lblLimit.Text = "Лимит, (руб.)"
        Me.lblLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLimit
        '
        Me.txtLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLimit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtLimit.Location = New System.Drawing.Point(392, 462)
        Me.txtLimit.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.ReadOnly = true
        Me.txtLimit.Size = New System.Drawing.Size(592, 24)
        Me.txtLimit.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtDescription.Location = New System.Drawing.Point(392, 530)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(592, 24)
        Me.txtDescription.TabIndex = 7
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = true
        Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDescription.Location = New System.Drawing.Point(5, 525)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(377, 34)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Основание"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chklbEmpl
        '
        Me.chklbEmpl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chklbEmpl.CheckOnClick = true
        Me.TableLayoutPanel1.SetColumnSpan(Me.chklbEmpl, 2)
        Me.chklbEmpl.ContextMenuStrip = Me.cmsSettings
        Me.chklbEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chklbEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chklbEmpl.FormattingEnabled = true
        Me.chklbEmpl.Location = New System.Drawing.Point(5, 5)
        Me.chklbEmpl.Margin = New System.Windows.Forms.Padding(5)
        Me.chklbEmpl.Name = "chklbEmpl"
        Me.chklbEmpl.Size = New System.Drawing.Size(979, 344)
        Me.chklbEmpl.TabIndex = 9
        '
        'cmsSettings
        '
        Me.cmsSettings.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsSettings.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВыделитьВсеToolStripMenuItem, Me.СброситьВсеToolStripMenuItem})
        Me.cmsSettings.Name = "cmsSettings"
        Me.cmsSettings.Size = New System.Drawing.Size(172, 48)
        '
        'ВыделитьВсеToolStripMenuItem
        '
        Me.ВыделитьВсеToolStripMenuItem.Name = "ВыделитьВсеToolStripMenuItem"
        Me.ВыделитьВсеToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ВыделитьВсеToolStripMenuItem.Text = "Выделить все"
        '
        'СброситьВсеToolStripMenuItem
        '
        Me.СброситьВсеToolStripMenuItem.Name = "СброситьВсеToolStripMenuItem"
        Me.СброситьВсеToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.СброситьВсеToolStripMenuItem.Text = "Сбросить все"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = true
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnSave, 2)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSave.Location = New System.Drawing.Point(5, 564)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(977, 93)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Провести выплату"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'cmbYear
        '
        Me.cmbYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbYear.Location = New System.Drawing.Point(5, 394)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(377, 25)
        Me.cmbYear.TabIndex = 0
        '
        'cmbFopl
        '
        Me.cmbFopl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFopl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFopl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFopl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbFopl.FormattingEnabled = true
        Me.cmbFopl.Items.AddRange(New Object() {"Наличные", "На карту"})
        Me.cmbFopl.Location = New System.Drawing.Point(4, 428)
        Me.cmbFopl.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFopl.Name = "cmbFopl"
        Me.cmbFopl.Size = New System.Drawing.Size(379, 25)
        Me.cmbFopl.TabIndex = 10
        '
        'cmbOrgOffice
        '
        Me.cmbOrgOffice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrgOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrgOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrgOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOrgOffice.FormattingEnabled = true
        Me.cmbOrgOffice.Location = New System.Drawing.Point(391, 428)
        Me.cmbOrgOffice.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOrgOffice.Name = "cmbOrgOffice"
        Me.cmbOrgOffice.Size = New System.Drawing.Size(594, 25)
        Me.cmbOrgOffice.TabIndex = 11
        '
        'fin_EmplPaym
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 708)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "fin_EmplPaym"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Выплаты сотрудникам"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudAmount,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsSettings.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblEmpl As System.Windows.Forms.Label
    Friend WithEvents cmbEmpl As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents nudAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLimit As System.Windows.Forms.Label
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents chklbEmpl As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmsSettings As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ВыделитьВсеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СброситьВсеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFopl As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOrgOffice As System.Windows.Forms.ComboBox
End Class
