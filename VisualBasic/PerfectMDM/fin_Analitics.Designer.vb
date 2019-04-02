<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_Analitics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_Analitics))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtYear = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РеализацияПоМенеджерамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РеализацияПоИсточникамЗаказаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗапасыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ЭкспортВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЭкспортВHTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgDataTable = New System.Windows.Forms.DataGridView()
        Me.РеализацияПоОфисамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout
        CType(Me.dgDataTable,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tstxtYear, Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1276, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(33, 24)
        Me.ToolStripLabel1.Text = "Год"
        '
        'tstxtYear
        '
        Me.tstxtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtYear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtYear.MaxLength = 4
        Me.tstxtYear.Name = "tstxtYear"
        Me.tstxtYear.Size = New System.Drawing.Size(124, 27)
        Me.tstxtYear.Text = "2014"
        Me.tstxtYear.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PLToolStripMenuItem, Me.РеализацияПоМенеджерамToolStripMenuItem, Me.РеализацияПоИсточникамЗаказаToolStripMenuItem, Me.РеализацияПоОфисамToolStripMenuItem, Me.CFToolStripMenuItem, Me.ЗапасыToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"),System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 24)
        Me.ToolStripDropDownButton1.Text = "Отчет"
        '
        'PLToolStripMenuItem
        '
        Me.PLToolStripMenuItem.Name = "PLToolStripMenuItem"
        Me.PLToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.PLToolStripMenuItem.Text = "Прибыли и убытки (PandL)"
        '
        'РеализацияПоМенеджерамToolStripMenuItem
        '
        Me.РеализацияПоМенеджерамToolStripMenuItem.Name = "РеализацияПоМенеджерамToolStripMenuItem"
        Me.РеализацияПоМенеджерамToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.РеализацияПоМенеджерамToolStripMenuItem.Text = "Реализация по менеджерам"
        '
        'РеализацияПоИсточникамЗаказаToolStripMenuItem
        '
        Me.РеализацияПоИсточникамЗаказаToolStripMenuItem.Name = "РеализацияПоИсточникамЗаказаToolStripMenuItem"
        Me.РеализацияПоИсточникамЗаказаToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.РеализацияПоИсточникамЗаказаToolStripMenuItem.Text = "Реализация по источникам заказа"
        '
        'CFToolStripMenuItem
        '
        Me.CFToolStripMenuItem.Name = "CFToolStripMenuItem"
        Me.CFToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.CFToolStripMenuItem.Text = "CF"
        '
        'ЗапасыToolStripMenuItem
        '
        Me.ЗапасыToolStripMenuItem.Name = "ЗапасыToolStripMenuItem"
        Me.ЗапасыToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.ЗапасыToolStripMenuItem.Text = "Запасы"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЭкспортВExcelToolStripMenuItem, Me.ЭкспортВHTMLToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"),System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(77, 24)
        Me.ToolStripDropDownButton2.Text = "Данные"
        '
        'ЭкспортВExcelToolStripMenuItem
        '
        Me.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem"
        Me.ЭкспортВExcelToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.ЭкспортВExcelToolStripMenuItem.Text = "Экспорт в Excel"
        '
        'ЭкспортВHTMLToolStripMenuItem
        '
        Me.ЭкспортВHTMLToolStripMenuItem.Name = "ЭкспортВHTMLToolStripMenuItem"
        Me.ЭкспортВHTMLToolStripMenuItem.Size = New System.Drawing.Size(189, 24)
        Me.ЭкспортВHTMLToolStripMenuItem.Text = "Экспорт в HTML"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(302, 24)
        Me.ToolStripButton1.Text = "О финансово-управленческой аналитике"
        '
        'dgDataTable
        '
        Me.dgDataTable.AllowUserToAddRows = false
        Me.dgDataTable.AllowUserToDeleteRows = false
        Me.dgDataTable.AllowUserToResizeRows = false
        Me.dgDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDataTable.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDataTable.Location = New System.Drawing.Point(0, 27)
        Me.dgDataTable.Margin = New System.Windows.Forms.Padding(4)
        Me.dgDataTable.MultiSelect = false
        Me.dgDataTable.Name = "dgDataTable"
        Me.dgDataTable.ReadOnly = true
        Me.dgDataTable.RowHeadersWidth = 40
        Me.dgDataTable.RowTemplate.Height = 24
        Me.dgDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDataTable.Size = New System.Drawing.Size(1276, 691)
        Me.dgDataTable.TabIndex = 1
        '
        'РеализацияПоОфисамToolStripMenuItem
        '
        Me.РеализацияПоОфисамToolStripMenuItem.Name = "РеализацияПоОфисамToolStripMenuItem"
        Me.РеализацияПоОфисамToolStripMenuItem.Size = New System.Drawing.Size(318, 24)
        Me.РеализацияПоОфисамToolStripMenuItem.Text = "Реализация по офисам"
        '
        'fin_Analitics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 718)
        Me.Controls.Add(Me.dgDataTable)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "fin_Analitics"
        Me.Text = "Аналитика"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.dgDataTable,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents dgDataTable As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtYear As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ЭкспортВExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЭкспортВHTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents РеализацияПоМенеджерамToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗапасыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РеализацияПоИсточникамЗаказаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РеализацияПоОфисамToolStripMenuItem As ToolStripMenuItem
End Class
