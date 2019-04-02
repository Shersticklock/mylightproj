<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_SalaryEmpl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_SalaryEmpl))
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.cmsDataTable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ПерейтиКВыплатамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tscmbMonth = New System.Windows.Forms.ToolStripComboBox()
        Me.tscmbYear = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ВсеСотрудникиToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tscmbEmpl = New System.Windows.Forms.ToolStripComboBox()
        Me.ОбновитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsDataTable.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTableData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTableData.ContextMenuStrip = Me.cmsDataTable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTableData.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTableData.Location = New System.Drawing.Point(0, 32)
        Me.dgTableData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgTableData.Name = "dgTableData"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dgTableData.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTableData.Size = New System.Drawing.Size(897, 508)
        Me.dgTableData.TabIndex = 15
        '
        'cmsDataTable
        '
        Me.cmsDataTable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsDataTable.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDataTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПерейтиКВыплатамToolStripMenuItem})
        Me.cmsDataTable.Name = "cmsDataTable"
        Me.cmsDataTable.Size = New System.Drawing.Size(199, 26)
        '
        'ПерейтиКВыплатамToolStripMenuItem
        '
        Me.ПерейтиКВыплатамToolStripMenuItem.Name = "ПерейтиКВыплатамToolStripMenuItem"
        Me.ПерейтиКВыплатамToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ПерейтиКВыплатамToolStripMenuItem.Text = "Перейти к выплатам"
        '
        'tscmbMonth
        '
        Me.tscmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tscmbMonth.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbMonth.Items.AddRange(New Object() {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"})
        Me.tscmbMonth.MaxDropDownItems = 12
        Me.tscmbMonth.Name = "tscmbMonth"
        Me.tscmbMonth.Size = New System.Drawing.Size(121, 28)
        '
        'tscmbYear
        '
        Me.tscmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tscmbYear.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbYear.Name = "tscmbYear"
        Me.tscmbYear.Size = New System.Drawing.Size(121, 28)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbYear, Me.tscmbMonth, Me.ВсеСотрудникиToolStripMenuItem1, Me.tscmbEmpl, Me.ОбновитьToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(897, 32)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ВсеСотрудникиToolStripMenuItem1
        '
        Me.ВсеСотрудникиToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ВсеСотрудникиToolStripMenuItem1.Name = "ВсеСотрудникиToolStripMenuItem1"
        Me.ВсеСотрудникиToolStripMenuItem1.Size = New System.Drawing.Size(129, 28)
        Me.ВсеСотрудникиToolStripMenuItem1.Text = "Все сотрудники"
        '
        'tscmbEmpl
        '
        Me.tscmbEmpl.AutoToolTip = true
        Me.tscmbEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbEmpl.DropDownWidth = 500
        Me.tscmbEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tscmbEmpl.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbEmpl.MaxDropDownItems = 30
        Me.tscmbEmpl.Name = "tscmbEmpl"
        Me.tscmbEmpl.Size = New System.Drawing.Size(376, 28)
        '
        'ОбновитьToolStripMenuItem
        '
        Me.ОбновитьToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ОбновитьToolStripMenuItem.Name = "ОбновитьToolStripMenuItem"
        Me.ОбновитьToolStripMenuItem.Size = New System.Drawing.Size(90, 28)
        Me.ОбновитьToolStripMenuItem.Text = "Обновить"
        '
        'fin_SalaryEmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 540)
        Me.Controls.Add(Me.dgTableData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "fin_SalaryEmpl"
        Me.Text = "fin_SalaryEmpl"
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsDataTable.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents cmsDataTable As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ПерейтиКВыплатамToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tscmbMonth As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tscmbYear As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ВсеСотрудникиToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tscmbEmpl As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ОбновитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
