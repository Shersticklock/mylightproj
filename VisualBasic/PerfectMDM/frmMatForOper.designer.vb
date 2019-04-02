<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatForOper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatForOper))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMat = New System.Windows.Forms.DataGridView()
        Me.dgAvailableMaterial = New System.Windows.Forms.DataGridView()
        Me.tsMaterialDelivery = New System.Windows.Forms.ToolStrip()
        Me.tsbtnMatFromSpec = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnMatFromNom = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgMatOut = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtQuantity = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtPrim = New System.Windows.Forms.ToolStripTextBox()
        Me.btnExecMatForOper = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tvMat = New System.Windows.Forms.TreeView()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgAvailableMaterial,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tsMaterialDelivery.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.dgMatOut,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip2.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 575)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Калькуляция материала на операцию "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgMat
        '
        Me.dgMat.AllowUserToAddRows = false
        Me.dgMat.AllowUserToDeleteRows = false
        Me.dgMat.AllowUserToResizeRows = false
        Me.dgMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgMat, 2)
        Me.dgMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMat.Location = New System.Drawing.Point(5, 5)
        Me.dgMat.Margin = New System.Windows.Forms.Padding(5)
        Me.dgMat.MultiSelect = false
        Me.dgMat.Name = "dgMat"
        Me.dgMat.ReadOnly = true
        Me.dgMat.RowTemplate.Height = 24
        Me.dgMat.RowTemplate.ReadOnly = true
        Me.dgMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMat.Size = New System.Drawing.Size(585, 350)
        Me.dgMat.TabIndex = 0
        '
        'dgAvailableMaterial
        '
        Me.dgAvailableMaterial.AllowUserToAddRows = false
        Me.dgAvailableMaterial.AllowUserToDeleteRows = false
        Me.dgAvailableMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAvailableMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgAvailableMaterial, 2)
        Me.dgAvailableMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAvailableMaterial.Location = New System.Drawing.Point(5, 383)
        Me.dgAvailableMaterial.Margin = New System.Windows.Forms.Padding(5)
        Me.dgAvailableMaterial.MultiSelect = false
        Me.dgAvailableMaterial.Name = "dgAvailableMaterial"
        Me.dgAvailableMaterial.ReadOnly = true
        Me.dgAvailableMaterial.RowTemplate.Height = 24
        Me.dgAvailableMaterial.RowTemplate.ReadOnly = true
        Me.dgAvailableMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAvailableMaterial.Size = New System.Drawing.Size(585, 187)
        Me.dgAvailableMaterial.TabIndex = 2
        '
        'tsMaterialDelivery
        '
        Me.tsMaterialDelivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsMaterialDelivery.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsMaterialDelivery.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMaterialDelivery.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnMatFromSpec, Me.tsbtnMatFromNom})
        Me.tsMaterialDelivery.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsMaterialDelivery.Location = New System.Drawing.Point(595, 0)
        Me.tsMaterialDelivery.Name = "tsMaterialDelivery"
        Me.tsMaterialDelivery.Size = New System.Drawing.Size(281, 360)
        Me.tsMaterialDelivery.TabIndex = 3
        Me.tsMaterialDelivery.Text = "ToolStrip2"
        '
        'tsbtnMatFromSpec
        '
        Me.tsbtnMatFromSpec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnMatFromSpec.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnMatFromSpec.Image = CType(resources.GetObject("tsbtnMatFromSpec.Image"),System.Drawing.Image)
        Me.tsbtnMatFromSpec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMatFromSpec.Name = "tsbtnMatFromSpec"
        Me.tsbtnMatFromSpec.Size = New System.Drawing.Size(279, 22)
        Me.tsbtnMatFromSpec.Text = "Из спецификации"
        '
        'tsbtnMatFromNom
        '
        Me.tsbtnMatFromNom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnMatFromNom.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnMatFromNom.Image = CType(resources.GetObject("tsbtnMatFromNom.Image"),System.Drawing.Image)
        Me.tsbtnMatFromNom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMatFromNom.Name = "tsbtnMatFromNom"
        Me.tsbtnMatFromNom.Size = New System.Drawing.Size(279, 22)
        Me.tsbtnMatFromNom.Text = "Из номенклатуры"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 452!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgMat, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgAvailableMaterial, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgMatOut, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tsMaterialDelivery, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(876, 704)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgMatOut
        '
        Me.dgMatOut.AllowUserToAddRows = false
        Me.dgMatOut.AllowUserToDeleteRows = false
        Me.dgMatOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMatOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgMatOut, 2)
        Me.dgMatOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMatOut.Location = New System.Drawing.Point(5, 598)
        Me.dgMatOut.Margin = New System.Windows.Forms.Padding(5)
        Me.dgMatOut.MultiSelect = false
        Me.dgMatOut.Name = "dgMatOut"
        Me.dgMatOut.ReadOnly = true
        Me.dgMatOut.RowTemplate.Height = 24
        Me.dgMatOut.RowTemplate.ReadOnly = true
        Me.dgMatOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgMatOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMatOut.Size = New System.Drawing.Size(585, 101)
        Me.dgMatOut.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 360)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(444, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Доступный материал в единицах учета"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = false
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tstxtQuantity, Me.ToolStripLabel1, Me.tstxtPrim, Me.btnExecMatForOper})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(595, 378)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(281, 197)
        Me.ToolStrip2.TabIndex = 35
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(279, 18)
        Me.ToolStripLabel2.Text = "Количество"
        '
        'tstxtQuantity
        '
        Me.tstxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtQuantity.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtQuantity.Name = "tstxtQuantity"
        Me.tstxtQuantity.Size = New System.Drawing.Size(277, 25)
        Me.tstxtQuantity.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(279, 18)
        Me.ToolStripLabel1.Text = "Примечание"
        '
        'tstxtPrim
        '
        Me.tstxtPrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtPrim.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtPrim.Name = "tstxtPrim"
        Me.tstxtPrim.Size = New System.Drawing.Size(277, 25)
        '
        'btnExecMatForOper
        '
        Me.btnExecMatForOper.AutoSize = false
        Me.btnExecMatForOper.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.btnExecMatForOper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExecMatForOper.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnExecMatForOper.Image = CType(resources.GetObject("btnExecMatForOper.Image"),System.Drawing.Image)
        Me.btnExecMatForOper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExecMatForOper.Name = "btnExecMatForOper"
        Me.btnExecMatForOper.Size = New System.Drawing.Size(275, 45)
        Me.btnExecMatForOper.Text = "Калькуляция/ Списать"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(595, 593)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(281, 111)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(279, 24)
        Me.ToolStripButton1.Text = "Отменить списание"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(279, 6)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(279, 24)
        Me.ToolStripButton2.Text = "Выход"
        '
        'tvMat
        '
        Me.tvMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMat.Location = New System.Drawing.Point(5, 38)
        Me.tvMat.Margin = New System.Windows.Forms.Padding(5)
        Me.tvMat.Name = "tvMat"
        Me.tvMat.Size = New System.Drawing.Size(380, 661)
        Me.tvMat.TabIndex = 0
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.Enabled = false
        Me.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepartment.FormattingEnabled = true
        Me.cmbDepartment.Location = New System.Drawing.Point(4, 4)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(382, 25)
        Me.cmbDepartment.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.tvMat, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbDepartment, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(390, 704)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 706)
        Me.SplitContainer1.SplitterDistance = 392
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 16
        Me.SplitContainer1.TabStop = false
        '
        'frmMatForOper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 706)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMatForOper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMatForOper"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgMat,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgAvailableMaterial,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsMaterialDelivery.ResumeLayout(false)
        Me.tsMaterialDelivery.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.dgMatOut,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsbtnMatFromNom As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnMatFromSpec As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgMat As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgAvailableMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents tsMaterialDelivery As System.Windows.Forms.ToolStrip
    Friend WithEvents dgMatOut As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tvMat As System.Windows.Forms.TreeView
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtQuantity As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnExecMatForOper As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtPrim As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
