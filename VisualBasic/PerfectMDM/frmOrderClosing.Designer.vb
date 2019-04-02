<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderClosing
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderClosing))
        Me.tlpParam = New System.Windows.Forms.TableLayoutPanel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tsbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnSelAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnOrderClose = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.cmsOrderClocing = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpOrderClosing = New System.Windows.Forms.DateTimePicker()
        Me.tlpParam.SuspendLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.BindingNavigator1.SuspendLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsOrderClocing.SuspendLayout
        Me.SuspendLayout
        '
        'tlpParam
        '
        Me.tlpParam.ColumnCount = 1
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpParam.Controls.Add(Me.BindingNavigator1, 0, 0)
        Me.tlpParam.Controls.Add(Me.dgTableData, 0, 2)
        Me.tlpParam.Controls.Add(Me.dtpOrderClosing, 0, 1)
        Me.tlpParam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpParam.Location = New System.Drawing.Point(0, 0)
        Me.tlpParam.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tlpParam.Name = "tlpParam"
        Me.tlpParam.RowCount = 3
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.Size = New System.Drawing.Size(1276, 663)
        Me.tlpParam.TabIndex = 1
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BindingNavigator1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnUpdate, Me.BindingNavigatorSeparator2, Me.tsbtnSelAll, Me.ToolStripSeparator1, Me.tsbtnOrderClose, Me.tsbtnExportToExcel, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(1373, 25)
        Me.BindingNavigator1.TabIndex = 74
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'tsbtnUpdate
        '
        Me.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnUpdate.Image = CType(resources.GetObject("tsbtnUpdate.Image"),System.Drawing.Image)
        Me.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdate.Name = "tsbtnUpdate"
        Me.tsbtnUpdate.Size = New System.Drawing.Size(229, 22)
        Me.tsbtnUpdate.Text = "Обновить не закрытые заказы"
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
        Me.tsbtnSelAll.Visible = false
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnOrderClose
        '
        Me.tsbtnOrderClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOrderClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOrderClose.Image = CType(resources.GetObject("tsbtnOrderClose.Image"),System.Drawing.Image)
        Me.tsbtnOrderClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOrderClose.Name = "tsbtnOrderClose"
        Me.tsbtnOrderClose.Size = New System.Drawing.Size(219, 22)
        Me.tsbtnOrderClose.Text = "Закрыть выделенные заказы"
        Me.tsbtnOrderClose.Visible = false
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
        Me.tsbtnExportToExcel.Visible = false
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
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.AllowUserToResizeRows = false
        Me.dgTableData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTableData.ContextMenuStrip = Me.cmsOrderClocing
        Me.dgTableData.Location = New System.Drawing.Point(5, 61)
        Me.dgTableData.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.ReadOnly = true
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTableData.Size = New System.Drawing.Size(1363, 596)
        Me.dgTableData.TabIndex = 0
        '
        'cmsOrderClocing
        '
        Me.cmsOrderClocing.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsOrderClocing.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПерейтиКЗаказуToolStripMenuItem})
        Me.cmsOrderClocing.Name = "ContextMenuStrip1"
        Me.cmsOrderClocing.Size = New System.Drawing.Size(168, 26)
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'dtpOrderClosing
        '
        Me.dtpOrderClosing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpOrderClosing.Location = New System.Drawing.Point(3, 28)
        Me.dtpOrderClosing.Name = "dtpOrderClosing"
        Me.dtpOrderClosing.Size = New System.Drawing.Size(200, 24)
        Me.dtpOrderClosing.TabIndex = 75
        '
        'frmOrderClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 663)
        Me.Controls.Add(Me.tlpParam)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmOrderClosing"
        Me.Text = "Закрытие заказов"
        Me.tlpParam.ResumeLayout(false)
        Me.tlpParam.PerformLayout
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).EndInit
        Me.BindingNavigator1.ResumeLayout(false)
        Me.BindingNavigator1.PerformLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsOrderClocing.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tlpParam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents tsbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnSelAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnOrderClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExportToExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents cmsOrderClocing As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpOrderClosing As System.Windows.Forms.DateTimePicker
End Class
