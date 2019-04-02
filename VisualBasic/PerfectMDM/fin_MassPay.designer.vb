<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_MassPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_MassPay))
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.cmsDataTable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.tlpParam = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbCustOrg = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tsbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnSelAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnPaySel = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFindKA = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsDataTable.SuspendLayout
        Me.tlpParam.SuspendLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.BindingNavigator1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.AllowUserToResizeRows = false
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpParam.SetColumnSpan(Me.dgTableData, 3)
        Me.dgTableData.ContextMenuStrip = Me.cmsDataTable
        Me.dgTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTableData.Location = New System.Drawing.Point(5, 104)
        Me.dgTableData.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.ReadOnly = true
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTableData.Size = New System.Drawing.Size(1387, 546)
        Me.dgTableData.TabIndex = 6
        '
        'cmsDataTable
        '
        Me.cmsDataTable.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDataTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПерейтиКЗаказуToolStripMenuItem})
        Me.cmsDataTable.Name = "cmsDataTable"
        Me.cmsDataTable.Size = New System.Drawing.Size(196, 28)
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustomer.Location = New System.Drawing.Point(299, 42)
        Me.cmbCustomer.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbCustomer.MaxDropDownItems = 25
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(541, 25)
        Me.cmbCustomer.TabIndex = 1
        Me.cmbCustomer.TabStop = false
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(299, 6)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(541, 24)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(850, 6)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(542, 24)
        Me.DateTimePicker2.TabIndex = 3
        '
        'tlpParam
        '
        Me.tlpParam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tlpParam.ColumnCount = 3
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpParam.Controls.Add(Me.cmbCustOrg, 2, 1)
        Me.tlpParam.Controls.Add(Me.DateTimePicker1, 1, 0)
        Me.tlpParam.Controls.Add(Me.cmbCustomer, 1, 1)
        Me.tlpParam.Controls.Add(Me.BindingNavigator1, 0, 2)
        Me.tlpParam.Controls.Add(Me.dgTableData, 0, 3)
        Me.tlpParam.Controls.Add(Me.DateTimePicker2, 2, 0)
        Me.tlpParam.Controls.Add(Me.Label1, 0, 0)
        Me.tlpParam.Controls.Add(Me.txtFindKA, 0, 1)
        Me.tlpParam.Location = New System.Drawing.Point(0, 0)
        Me.tlpParam.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tlpParam.Name = "tlpParam"
        Me.tlpParam.RowCount = 4
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.Size = New System.Drawing.Size(1397, 656)
        Me.tlpParam.TabIndex = 0
        '
        'cmbCustOrg
        '
        Me.cmbCustOrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustOrg.Location = New System.Drawing.Point(850, 42)
        Me.cmbCustOrg.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbCustOrg.MaxDropDownItems = 25
        Me.cmbCustOrg.Name = "cmbCustOrg"
        Me.cmbCustOrg.Size = New System.Drawing.Size(542, 25)
        Me.cmbCustOrg.TabIndex = 4
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.tlpParam.SetColumnSpan(Me.BindingNavigator1, 3)
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BindingNavigator1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnUpdate, Me.BindingNavigatorSeparator2, Me.tsbtnSelAll, Me.ToolStripSeparator1, Me.tsbtnPaySel, Me.tsbtnExportToExcel, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 73)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(1397, 25)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'tsbtnUpdate
        '
        Me.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnUpdate.Image = CType(resources.GetObject("tsbtnUpdate.Image"),System.Drawing.Image)
        Me.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdate.Name = "tsbtnUpdate"
        Me.tsbtnUpdate.Size = New System.Drawing.Size(245, 22)
        Me.tsbtnUpdate.Text = "Обновить не оплаченные заказы"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnSelAll
        '
        Me.tsbtnSelAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSelAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnSelAll.Image = CType(resources.GetObject("tsbtnSelAll.Image"),System.Drawing.Image)
        Me.tsbtnSelAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSelAll.Name = "tsbtnSelAll"
        Me.tsbtnSelAll.Size = New System.Drawing.Size(110, 22)
        Me.tsbtnSelAll.Text = "Выделить все"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnPaySel
        '
        Me.tsbtnPaySel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnPaySel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnPaySel.Image = CType(resources.GetObject("tsbtnPaySel.Image"),System.Drawing.Image)
        Me.tsbtnPaySel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPaySel.Name = "tsbtnPaySel"
        Me.tsbtnPaySel.Size = New System.Drawing.Size(226, 22)
        Me.tsbtnPaySel.Text = "Оплатить выделенные заказы"
        '
        'tsbtnExportToExcel
        '
        Me.tsbtnExportToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnExportToExcel.Image = CType(resources.GetObject("tsbtnExportToExcel.Image"),System.Drawing.Image)
        Me.tsbtnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExportToExcel.Name = "tsbtnExportToExcel"
        Me.tsbtnExportToExcel.Size = New System.Drawing.Size(123, 22)
        Me.tsbtnExportToExcel.Text = "Экспорт в Excel"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton1.Text = "Выход"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 36)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Интервал дат создания заказа"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFindKA
        '
        Me.txtFindKA.BackColor = System.Drawing.SystemColors.Info
        Me.txtFindKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFindKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFindKA.Location = New System.Drawing.Point(5, 42)
        Me.txtFindKA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFindKA.Name = "txtFindKA"
        Me.txtFindKA.Size = New System.Drawing.Size(284, 24)
        Me.txtFindKA.TabIndex = 0
        Me.txtFindKA.Text = "Заказчик"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 666)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 24, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.StatusStrip1.TabIndex = 70
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(18, 19)
        Me.ToolStripStatusLabel1.Text = "..."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(18, 19)
        Me.ToolStripStatusLabel2.Text = "..."
        '
        'fin_MassPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 690)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tlpParam)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.HelpButton = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "fin_MassPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Массовая оплата заказов"
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsDataTable.ResumeLayout(false)
        Me.tlpParam.ResumeLayout(false)
        Me.tlpParam.PerformLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).EndInit
        Me.BindingNavigator1.ResumeLayout(false)
        Me.BindingNavigator1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tlpParam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtFindKA As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents tsbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnPaySel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSelAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnExportToExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCustOrg As System.Windows.Forms.ComboBox
    Friend WithEvents cmsDataTable As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
