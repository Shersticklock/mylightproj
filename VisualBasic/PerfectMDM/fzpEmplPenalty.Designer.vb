<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fzpEmplPenalty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fzpEmplPenalty))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudPenalty = New System.Windows.Forms.NumericUpDown()
        Me.nudAward = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgAwards = New System.Windows.Forms.DataGridView()
        Me.cmsToExcel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ЭкспортВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnToExcel = New System.Windows.Forms.Button()
        Me.dgDetails = New System.Windows.Forms.DataGridView()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.lbldescriptionA = New System.Windows.Forms.Label()
        Me.txtdescriptionA = New System.Windows.Forms.TextBox()
        Me.btnToCarryOnExpenses = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudPenalty,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudAward,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgAwards,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsToExcel.SuspendLayout
        CType(Me.dgDetails,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.nudPenalty, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nudAward, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.dgAwards, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescription, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMonth, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnUpdate, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnApply, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnToExcel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.dgDetails, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnHide, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbldescriptionA, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdescriptionA, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnToCarryOnExpenses, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 674)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'nudPenalty
        '
        Me.nudPenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudPenalty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudPenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudPenalty.Location = New System.Drawing.Point(59, 488)
        Me.nudPenalty.Margin = New System.Windows.Forms.Padding(5)
        Me.nudPenalty.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPenalty.Name = "nudPenalty"
        Me.nudPenalty.Size = New System.Drawing.Size(569, 24)
        Me.nudPenalty.TabIndex = 1
        Me.nudPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudAward
        '
        Me.nudAward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudAward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudAward.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudAward.Location = New System.Drawing.Point(59, 396)
        Me.nudAward.Margin = New System.Windows.Forms.Padding(5)
        Me.nudAward.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudAward.Name = "nudAward"
        Me.nudAward.Size = New System.Drawing.Size(569, 24)
        Me.nudAward.TabIndex = 1
        Me.nudAward.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 483)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Штраф"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgAwards
        '
        Me.dgAwards.AllowUserToAddRows = false
        Me.dgAwards.AllowUserToDeleteRows = false
        Me.dgAwards.AllowUserToResizeRows = false
        Me.dgAwards.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgAwards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgAwards, 2)
        Me.dgAwards.ContextMenuStrip = Me.cmsToExcel
        Me.dgAwards.Location = New System.Drawing.Point(6, 47)
        Me.dgAwards.Margin = New System.Windows.Forms.Padding(5)
        Me.dgAwards.Name = "dgAwards"
        Me.dgAwards.ReadOnly = true
        Me.dgAwards.RowTemplate.Height = 24
        Me.dgAwards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAwards.Size = New System.Drawing.Size(622, 338)
        Me.dgAwards.TabIndex = 2
        '
        'cmsToExcel
        '
        Me.cmsToExcel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsToExcel.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsToExcel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЭкспортВExcelToolStripMenuItem})
        Me.cmsToExcel.Name = "cmsToExcel"
        Me.cmsToExcel.Size = New System.Drawing.Size(154, 26)
        '
        'ЭкспортВExcelToolStripMenuItem
        '
        Me.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem"
        Me.ЭкспортВExcelToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ЭкспортВExcelToolStripMenuItem.Text = "Детализация"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 391)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Премия"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 520)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 54)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Примечания"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtDescription.Location = New System.Drawing.Point(59, 525)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(569, 24)
        Me.txtDescription.TabIndex = 5
        '
        'cmbMonth
        '
        Me.cmbMonth.DisplayMember = "0"
        Me.cmbMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMonth.FormattingEnabled = true
        Me.cmbMonth.Items.AddRange(New Object() {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"})
        Me.cmbMonth.Location = New System.Drawing.Point(59, 6)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMonth.MaxDropDownItems = 12
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(569, 25)
        Me.cmbMonth.TabIndex = 7
        Me.cmbMonth.ValueMember = "0"
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = true
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(6, 6)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(42, 30)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Обновить"
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'btnApply
        '
        Me.btnApply.AutoSize = true
        Me.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnApply.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnApply.Location = New System.Drawing.Point(59, 580)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(5)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(569, 36)
        Me.btnApply.TabIndex = 3
        Me.btnApply.Text = "Применить"
        Me.btnApply.UseVisualStyleBackColor = true
        '
        'btnToExcel
        '
        Me.btnToExcel.AutoSize = true
        Me.btnToExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnToExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnToExcel.Location = New System.Drawing.Point(6, 580)
        Me.btnToExcel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnToExcel.Name = "btnToExcel"
        Me.btnToExcel.Size = New System.Drawing.Size(42, 36)
        Me.btnToExcel.TabIndex = 9
        Me.btnToExcel.Text = "Экспорт в Excel"
        Me.btnToExcel.UseVisualStyleBackColor = true
        '
        'dgDetails
        '
        Me.dgDetails.AllowUserToAddRows = false
        Me.dgDetails.AllowUserToDeleteRows = false
        Me.dgDetails.AllowUserToResizeRows = false
        Me.dgDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetails.Location = New System.Drawing.Point(639, 47)
        Me.dgDetails.Margin = New System.Windows.Forms.Padding(5)
        Me.dgDetails.MultiSelect = false
        Me.dgDetails.Name = "dgDetails"
        Me.dgDetails.ReadOnly = true
        Me.dgDetails.RowHeadersVisible = false
        Me.dgDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetails.Size = New System.Drawing.Size(631, 338)
        Me.dgDetails.TabIndex = 10
        Me.dgDetails.Visible = false
        '
        'btnHide
        '
        Me.btnHide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnHide.Location = New System.Drawing.Point(639, 580)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(5)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(631, 36)
        Me.btnHide.TabIndex = 11
        Me.btnHide.Text = "Скрыть"
        Me.btnHide.UseVisualStyleBackColor = true
        Me.btnHide.Visible = false
        '
        'lbldescriptionA
        '
        Me.lbldescriptionA.AutoSize = true
        Me.lbldescriptionA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbldescriptionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lbldescriptionA.Location = New System.Drawing.Point(6, 428)
        Me.lbldescriptionA.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbldescriptionA.Name = "lbldescriptionA"
        Me.lbldescriptionA.Size = New System.Drawing.Size(42, 54)
        Me.lbldescriptionA.TabIndex = 12
        Me.lbldescriptionA.Text = "Примечания"
        Me.lbldescriptionA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdescriptionA
        '
        Me.txtdescriptionA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdescriptionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtdescriptionA.Location = New System.Drawing.Point(59, 433)
        Me.txtdescriptionA.Margin = New System.Windows.Forms.Padding(5)
        Me.txtdescriptionA.Name = "txtdescriptionA"
        Me.txtdescriptionA.Size = New System.Drawing.Size(569, 24)
        Me.txtdescriptionA.TabIndex = 13
        '
        'btnToCarryOnExpenses
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnToCarryOnExpenses, 2)
        Me.btnToCarryOnExpenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnToCarryOnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToCarryOnExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnToCarryOnExpenses.Location = New System.Drawing.Point(6, 627)
        Me.btnToCarryOnExpenses.Margin = New System.Windows.Forms.Padding(5)
        Me.btnToCarryOnExpenses.Name = "btnToCarryOnExpenses"
        Me.btnToCarryOnExpenses.Size = New System.Drawing.Size(622, 41)
        Me.btnToCarryOnExpenses.TabIndex = 14
        Me.btnToCarryOnExpenses.Text = "Отнести на затраты сумму с налогами"
        Me.btnToCarryOnExpenses.UseVisualStyleBackColor = true
        '
        'fzpEmplPenalty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1276, 674)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "fzpEmplPenalty"
        Me.Text = "Премии и штрафы"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudPenalty,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudAward,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgAwards,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsToExcel.ResumeLayout(false)
        CType(Me.dgDetails,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nudPenalty As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAward As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgAwards As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cmsToExcel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ЭкспортВExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnToExcel As System.Windows.Forms.Button
    Friend WithEvents dgDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents lbldescriptionA As System.Windows.Forms.Label
    Friend WithEvents txtdescriptionA As System.Windows.Forms.TextBox
    Friend WithEvents btnToCarryOnExpenses As System.Windows.Forms.Button
End Class
