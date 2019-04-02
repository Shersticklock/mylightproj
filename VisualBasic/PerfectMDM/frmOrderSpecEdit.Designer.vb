<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderSpecEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderSpecEdit))
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.cmsEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.РедактироватьМатериалToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НоваяЦенаЗаЕдиницуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НовоеКоличествоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьСтрокуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НоваяСуммаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbtnBtnMat = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtItogo = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtAsWillBe = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslblKolvo = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtKolvo = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnMat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.tvMat = New System.Windows.Forms.TreeView()
        Me.cmbAccUnits = New System.Windows.Forms.ComboBox()
        Me.btnMatApply = New System.Windows.Forms.Button()
        Me.btnMatCancel = New System.Windows.Forms.Button()
        Me.dgTechOper = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsEdit.SuspendLayout
        Me.tsbtnBtnMat.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.dgTechOper,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.AllowUserToOrderColumns = true
        Me.dgTableData.AllowUserToResizeRows = false
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTableData.ContextMenuStrip = Me.cmsEdit
        Me.dgTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTableData.Location = New System.Drawing.Point(5, 5)
        Me.dgTableData.Margin = New System.Windows.Forms.Padding(5)
        Me.dgTableData.MultiSelect = false
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.RowHeadersVisible = false
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.Size = New System.Drawing.Size(776, 202)
        Me.dgTableData.TabIndex = 0
        '
        'cmsEdit
        '
        Me.cmsEdit.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsEdit.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РедактироватьМатериалToolStripMenuItem, Me.НоваяЦенаЗаЕдиницуToolStripMenuItem, Me.НовоеКоличествоToolStripMenuItem, Me.УдалитьСтрокуToolStripMenuItem, Me.НоваяСуммаToolStripMenuItem})
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.Size = New System.Drawing.Size(255, 124)
        '
        'РедактироватьМатериалToolStripMenuItem
        '
        Me.РедактироватьМатериалToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.РедактироватьМатериалToolStripMenuItem.Name = "РедактироватьМатериалToolStripMenuItem"
        Me.РедактироватьМатериалToolStripMenuItem.Size = New System.Drawing.Size(254, 24)
        Me.РедактироватьМатериалToolStripMenuItem.Text = "Редактировать материал"
        '
        'НоваяЦенаЗаЕдиницуToolStripMenuItem
        '
        Me.НоваяЦенаЗаЕдиницуToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.НоваяЦенаЗаЕдиницуToolStripMenuItem.Name = "НоваяЦенаЗаЕдиницуToolStripMenuItem"
        Me.НоваяЦенаЗаЕдиницуToolStripMenuItem.Size = New System.Drawing.Size(254, 24)
        Me.НоваяЦенаЗаЕдиницуToolStripMenuItem.Text = "Новая цена за единицу"
        '
        'НовоеКоличествоToolStripMenuItem
        '
        Me.НовоеКоличествоToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.НовоеКоличествоToolStripMenuItem.Name = "НовоеКоличествоToolStripMenuItem"
        Me.НовоеКоличествоToolStripMenuItem.Size = New System.Drawing.Size(254, 24)
        Me.НовоеКоличествоToolStripMenuItem.Text = "Новое количество"
        '
        'УдалитьСтрокуToolStripMenuItem
        '
        Me.УдалитьСтрокуToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.УдалитьСтрокуToolStripMenuItem.Name = "УдалитьСтрокуToolStripMenuItem"
        Me.УдалитьСтрокуToolStripMenuItem.Size = New System.Drawing.Size(254, 24)
        Me.УдалитьСтрокуToolStripMenuItem.Text = "Удалить строку"
        Me.УдалитьСтрокуToolStripMenuItem.Visible = false
        '
        'НоваяСуммаToolStripMenuItem
        '
        Me.НоваяСуммаToolStripMenuItem.Name = "НоваяСуммаToolStripMenuItem"
        Me.НоваяСуммаToolStripMenuItem.Size = New System.Drawing.Size(254, 24)
        Me.НоваяСуммаToolStripMenuItem.Text = "Новая сумма"
        '
        'tsbtnBtnMat
        '
        Me.tsbtnBtnMat.Dock = System.Windows.Forms.DockStyle.Right
        Me.tsbtnBtnMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnBtnMat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsbtnBtnMat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel3, Me.tstxtItogo, Me.ToolStripLabel2, Me.tstxtAsWillBe, Me.ToolStripSeparator1, Me.tslblKolvo, Me.tstxtKolvo, Me.tsbtnCancel, Me.tsbtnSave, Me.tsbtnMat, Me.ToolStripSeparator2, Me.tsbtnExit})
        Me.tsbtnBtnMat.Location = New System.Drawing.Point(1120, 0)
        Me.tsbtnBtnMat.Name = "tsbtnBtnMat"
        Me.tsbtnBtnMat.Size = New System.Drawing.Size(156, 669)
        Me.tsbtnBtnMat.TabIndex = 2
        Me.tsbtnBtnMat.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(153, 18)
        Me.ToolStripLabel1.Text = "Стоимость (руб.)"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(153, 18)
        Me.ToolStripLabel3.Text = "Было"
        '
        'tstxtItogo
        '
        Me.tstxtItogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItogo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItogo.Name = "tstxtItogo"
        Me.tstxtItogo.ReadOnly = true
        Me.tstxtItogo.Size = New System.Drawing.Size(151, 26)
        Me.tstxtItogo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(153, 18)
        Me.ToolStripLabel2.Text = "Будет"
        '
        'tstxtAsWillBe
        '
        Me.tstxtAsWillBe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtAsWillBe.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtAsWillBe.Name = "tstxtAsWillBe"
        Me.tstxtAsWillBe.ReadOnly = true
        Me.tstxtAsWillBe.Size = New System.Drawing.Size(151, 26)
        Me.tstxtAsWillBe.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'tslblKolvo
        '
        Me.tslblKolvo.Name = "tslblKolvo"
        Me.tslblKolvo.Size = New System.Drawing.Size(153, 18)
        Me.tslblKolvo.Text = "Количество"
        '
        'tstxtKolvo
        '
        Me.tstxtKolvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtKolvo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtKolvo.Name = "tstxtKolvo"
        Me.tstxtKolvo.Size = New System.Drawing.Size(151, 26)
        Me.tstxtKolvo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tstxtKolvo.ToolTipText = "После ввода количества нажмите Enter для расчета"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(153, 22)
        Me.tsbtnCancel.Text = "Отменить"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSave.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"),System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(153, 22)
        Me.tsbtnSave.Text = "Сохранить"
        '
        'tsbtnMat
        '
        Me.tsbtnMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnMat.Image = CType(resources.GetObject("tsbtnMat.Image"),System.Drawing.Image)
        Me.tsbtnMat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMat.Name = "tsbtnMat"
        Me.tsbtnMat.Size = New System.Drawing.Size(153, 22)
        Me.tsbtnMat.Text = "Материал"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(153, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.tsbtnBtnMat, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 669)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgTechOper)
        Me.SplitContainer1.Size = New System.Drawing.Size(1112, 661)
        Me.SplitContainer1.SplitterDistance = 790
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 51
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = true
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgTableData, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbMat, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tvMat, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbAccUnits, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnMatApply, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnMatCancel, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(786, 657)
        Me.TableLayoutPanel2.TabIndex = 53
        '
        'cmbMat
        '
        Me.cmbMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMat.DropDownWidth = 400
        Me.cmbMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMat.FormattingEnabled = true
        Me.cmbMat.Location = New System.Drawing.Point(5, 510)
        Me.cmbMat.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMat.MaxDropDownItems = 30
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(776, 25)
        Me.cmbMat.TabIndex = 49
        Me.cmbMat.Visible = false
        '
        'tvMat
        '
        Me.tvMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMat.Location = New System.Drawing.Point(5, 217)
        Me.tvMat.Margin = New System.Windows.Forms.Padding(5)
        Me.tvMat.Name = "tvMat"
        Me.tvMat.Size = New System.Drawing.Size(776, 283)
        Me.tvMat.TabIndex = 48
        Me.tvMat.Visible = false
        '
        'cmbAccUnits
        '
        Me.cmbAccUnits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAccUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAccUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbAccUnits.FormattingEnabled = true
        Me.cmbAccUnits.Location = New System.Drawing.Point(3, 543)
        Me.cmbAccUnits.Name = "cmbAccUnits"
        Me.cmbAccUnits.Size = New System.Drawing.Size(780, 25)
        Me.cmbAccUnits.TabIndex = 50
        Me.cmbAccUnits.Visible = false
        '
        'btnMatApply
        '
        Me.btnMatApply.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMatApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnMatApply.Location = New System.Drawing.Point(3, 617)
        Me.btnMatApply.Name = "btnMatApply"
        Me.btnMatApply.Size = New System.Drawing.Size(780, 37)
        Me.btnMatApply.TabIndex = 51
        Me.btnMatApply.Text = "Применить"
        Me.btnMatApply.UseVisualStyleBackColor = true
        Me.btnMatApply.Visible = false
        '
        'btnMatCancel
        '
        Me.btnMatCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMatCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnMatCancel.Location = New System.Drawing.Point(3, 574)
        Me.btnMatCancel.Name = "btnMatCancel"
        Me.btnMatCancel.Size = New System.Drawing.Size(780, 37)
        Me.btnMatCancel.TabIndex = 52
        Me.btnMatCancel.Text = "Отменить"
        Me.btnMatCancel.UseVisualStyleBackColor = true
        Me.btnMatCancel.Visible = false
        '
        'dgTechOper
        '
        Me.dgTechOper.AllowUserToAddRows = false
        Me.dgTechOper.AllowUserToDeleteRows = false
        Me.dgTechOper.AllowUserToResizeRows = false
        Me.dgTechOper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTechOper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTechOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTechOper.Location = New System.Drawing.Point(0, 0)
        Me.dgTechOper.Margin = New System.Windows.Forms.Padding(4)
        Me.dgTechOper.Name = "dgTechOper"
        Me.dgTechOper.ReadOnly = true
        Me.dgTechOper.RowTemplate.Height = 24
        Me.dgTechOper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTechOper.Size = New System.Drawing.Size(313, 657)
        Me.dgTechOper.TabIndex = 50
        '
        'frmOrderSpecEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 669)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmOrderSpecEdit"
        Me.Text = "Редактирование"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsEdit.ResumeLayout(false)
        Me.tsbtnBtnMat.ResumeLayout(false)
        Me.tsbtnBtnMat.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        CType(Me.dgTechOper,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents tsbtnBtnMat As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmsEdit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents РедактироватьМатериалToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tvMat As System.Windows.Forms.TreeView
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents tsbtnMat As System.Windows.Forms.ToolStripButton
    Friend WithEvents НовоеКоличествоToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьСтрокуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgTechOper As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbAccUnits As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtItogo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtAsWillBe As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tstxtKolvo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tslblKolvo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnMatApply As System.Windows.Forms.Button
    Friend WithEvents btnMatCancel As System.Windows.Forms.Button
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents НоваяЦенаЗаЕдиницуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents НоваяСуммаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
