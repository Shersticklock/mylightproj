<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fzp_EmplPlan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fzp_EmplPlan))
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.cmsSettings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ВыделитьВсеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СброситьВсеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tscmbYear = New System.Windows.Forms.ToolStripComboBox()
        Me.tscmbMonth = New System.Windows.Forms.ToolStripComboBox()
        Me.ДанныеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтобразитьПоказателиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПлановыеПоказателиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФактическаяОтработкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЭкспортВEXCELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tscmbWageSystem = New System.Windows.Forms.ToolStripComboBox()
        Me.РасчетToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslItogo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsSettings.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTableData.Location = New System.Drawing.Point(0, 39)
        Me.dgTableData.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgTableData.MultiSelect = false
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dgTableData.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTableData.Size = New System.Drawing.Size(1292, 642)
        Me.dgTableData.TabIndex = 12
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
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbYear, Me.tscmbMonth, Me.ДанныеToolStripMenuItem, Me.СохранитьToolStripMenuItem, Me.tscmbWageSystem, Me.РасчетToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 32)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tscmbYear
        '
        Me.tscmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tscmbYear.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbYear.Name = "tscmbYear"
        Me.tscmbYear.Size = New System.Drawing.Size(199, 28)
        '
        'tscmbMonth
        '
        Me.tscmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tscmbMonth.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbMonth.Items.AddRange(New Object() {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"})
        Me.tscmbMonth.MaxDropDownItems = 12
        Me.tscmbMonth.Name = "tscmbMonth"
        Me.tscmbMonth.Size = New System.Drawing.Size(199, 28)
        '
        'ДанныеToolStripMenuItem
        '
        Me.ДанныеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОтобразитьПоказателиToolStripMenuItem, Me.ПлановыеПоказателиToolStripMenuItem, Me.ФактическаяОтработкаToolStripMenuItem, Me.ЭкспортВEXCELToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.ДанныеToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ДанныеToolStripMenuItem.Name = "ДанныеToolStripMenuItem"
        Me.ДанныеToolStripMenuItem.Size = New System.Drawing.Size(76, 28)
        Me.ДанныеToolStripMenuItem.Text = "Данные"
        '
        'ОтобразитьПоказателиToolStripMenuItem
        '
        Me.ОтобразитьПоказателиToolStripMenuItem.Name = "ОтобразитьПоказателиToolStripMenuItem"
        Me.ОтобразитьПоказателиToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.ОтобразитьПоказателиToolStripMenuItem.Text = "Отобразить показатели"
        '
        'ПлановыеПоказателиToolStripMenuItem
        '
        Me.ПлановыеПоказателиToolStripMenuItem.Name = "ПлановыеПоказателиToolStripMenuItem"
        Me.ПлановыеПоказателиToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.ПлановыеПоказателиToolStripMenuItem.Text = "Плановые показатели"
        '
        'ФактическаяОтработкаToolStripMenuItem
        '
        Me.ФактическаяОтработкаToolStripMenuItem.Name = "ФактическаяОтработкаToolStripMenuItem"
        Me.ФактическаяОтработкаToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.ФактическаяОтработкаToolStripMenuItem.Text = "Фактическая отработка"
        '
        'ЭкспортВEXCELToolStripMenuItem
        '
        Me.ЭкспортВEXCELToolStripMenuItem.Name = "ЭкспортВEXCELToolStripMenuItem"
        Me.ЭкспортВEXCELToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.ЭкспортВEXCELToolStripMenuItem.Text = "Экспорт в Excel"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'СохранитьToolStripMenuItem
        '
        Me.СохранитьToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem"
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(95, 28)
        Me.СохранитьToolStripMenuItem.Text = "Сохранить"
        '
        'tscmbWageSystem
        '
        Me.tscmbWageSystem.DropDownWidth = 300
        Me.tscmbWageSystem.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tscmbWageSystem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbWageSystem.Name = "tscmbWageSystem"
        Me.tscmbWageSystem.Size = New System.Drawing.Size(312, 28)
        '
        'РасчетToolStripMenuItem
        '
        Me.РасчетToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.РасчетToolStripMenuItem.Name = "РасчетToolStripMenuItem"
        Me.РасчетToolStripMenuItem.Size = New System.Drawing.Size(66, 28)
        Me.РасчетToolStripMenuItem.Text = "Расчет"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslItogo, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 689)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslItogo
        '
        Me.tsslItogo.Name = "tsslItogo"
        Me.tsslItogo.Size = New System.Drawing.Size(18, 19)
        Me.tsslItogo.Text = "..."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(18, 19)
        Me.ToolStripStatusLabel2.Text = "..."
        '
        'fzp_EmplPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 713)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgTableData)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "fzp_EmplPlan"
        Me.Opacity = 0R
        Me.Text = "План факт по выручке и отработке"
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsSettings.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmsSettings As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ВыделитьВсеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СброситьВсеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tscmbYear As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tscmbMonth As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ДанныеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтобразитьПоказателиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РасчетToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЭкспортВEXCELToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslItogo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ФактическаяОтработкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПлановыеПоказателиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents tscmbWageSystem As System.Windows.Forms.ToolStripComboBox
End Class
