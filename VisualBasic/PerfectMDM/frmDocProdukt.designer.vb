<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocProdukt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocProdukt))
        Me.txtFindPr = New System.Windows.Forms.TextBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.cmbEdIz1 = New System.Windows.Forms.ComboBox()
        Me.lstProd = New System.Windows.Forms.ListBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGTD = New NumericTextBox.NumericTextbox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnNewProd = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEdIzm = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCalc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTypeCost = New System.Windows.Forms.ComboBox()
        Me.nudCost = New System.Windows.Forms.NumericUpDown()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'txtFindPr
        '
        Me.txtFindPr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindPr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFindPr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFindPr.Location = New System.Drawing.Point(309, 141)
        Me.txtFindPr.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFindPr.Name = "txtFindPr"
        Me.txtFindPr.Size = New System.Drawing.Size(566, 24)
        Me.txtFindPr.TabIndex = 65
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(309, 278)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(5)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(566, 26)
        Me.nudQuantity.TabIndex = 52
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbEdIz1
        '
        Me.cmbEdIz1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEdIz1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEdIz1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEdIz1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEdIz1.FormattingEnabled = true
        Me.cmbEdIz1.Location = New System.Drawing.Point(309, 243)
        Me.cmbEdIz1.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbEdIz1.Name = "cmbEdIz1"
        Me.cmbEdIz1.Size = New System.Drawing.Size(566, 25)
        Me.cmbEdIz1.TabIndex = 64
        '
        'lstProd
        '
        Me.lstProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstProd.FormattingEnabled = true
        Me.lstProd.ItemHeight = 17
        Me.lstProd.Location = New System.Drawing.Point(309, 5)
        Me.lstProd.Margin = New System.Windows.Forms.Padding(5)
        Me.lstProd.Name = "lstProd"
        Me.lstProd.Size = New System.Drawing.Size(566, 126)
        Me.lstProd.TabIndex = 66
        '
        'txtCountry
        '
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtCountry.Location = New System.Drawing.Point(309, 175)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(566, 24)
        Me.txtCountry.TabIndex = 93
        Me.txtCountry.Text = "Россия"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(5, 170)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 34)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Страна изготовитель"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 204)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 34)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Номер ГТД"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(5, 238)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 35)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Единицы измерения"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(5, 273)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(294, 36)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Количество"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGTD
        '
        Me.txtGTD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGTD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtGTD.Location = New System.Drawing.Point(309, 209)
        Me.txtGTD.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGTD.MaxLength = 10
        Me.txtGTD.Name = "txtGTD"
        Me.txtGTD.Size = New System.Drawing.Size(566, 24)
        Me.txtGTD.TabIndex = 99
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = false
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOK, Me.tsbtnNewProd, Me.tsbtnEdIzm, Me.tsbtnCalc, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(234, 369)
        Me.ToolStrip1.TabIndex = 104
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(232, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'tsbtnNewProd
        '
        Me.tsbtnNewProd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewProd.Image = CType(resources.GetObject("tsbtnNewProd.Image"),System.Drawing.Image)
        Me.tsbtnNewProd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewProd.Name = "tsbtnNewProd"
        Me.tsbtnNewProd.Size = New System.Drawing.Size(232, 22)
        Me.tsbtnNewProd.Text = "Добавить продукт"
        '
        'tsbtnEdIzm
        '
        Me.tsbtnEdIzm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEdIzm.Image = CType(resources.GetObject("tsbtnEdIzm.Image"),System.Drawing.Image)
        Me.tsbtnEdIzm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdIzm.Name = "tsbtnEdIzm"
        Me.tsbtnEdIzm.Size = New System.Drawing.Size(232, 22)
        Me.tsbtnEdIzm.Text = "Добавить ед. изм."
        '
        'tsbtnCalc
        '
        Me.tsbtnCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCalc.Image = CType(resources.GetObject("tsbtnCalc.Image"),System.Drawing.Image)
        Me.tsbtnCalc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCalc.Name = "tsbtnCalc"
        Me.tsbtnCalc.Size = New System.Drawing.Size(232, 22)
        Me.tsbtnCalc.Text = "Калькулятор"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(232, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(232, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtFindPr, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lstProd, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudQuantity, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGTD, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCountry, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbEdIz1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTypeCost, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.nudCost, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(880, 369)
        Me.TableLayoutPanel1.TabIndex = 105
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(294, 136)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Наименование"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(5, 136)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(294, 34)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Наименование в документе"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTypeCost
        '
        Me.cmbTypeCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTypeCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypeCost.FormattingEnabled = true
        Me.cmbTypeCost.Items.AddRange(New Object() {"Цена за единицу, с НДС (руб.)", "Цена за количество, с НДС (руб.)"})
        Me.cmbTypeCost.Location = New System.Drawing.Point(5, 314)
        Me.cmbTypeCost.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbTypeCost.Name = "cmbTypeCost"
        Me.cmbTypeCost.Size = New System.Drawing.Size(294, 25)
        Me.cmbTypeCost.TabIndex = 103
        '
        'nudCost
        '
        Me.nudCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudCost.DecimalPlaces = 4
        Me.nudCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudCost.Location = New System.Drawing.Point(309, 314)
        Me.nudCost.Margin = New System.Windows.Forms.Padding(5)
        Me.nudCost.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudCost.Name = "nudCost"
        Me.nudCost.Size = New System.Drawing.Size(566, 26)
        Me.nudCost.TabIndex = 104
        Me.nudCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1124, 371)
        Me.SplitContainer1.SplitterDistance = 882
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 106
        '
        'frmDocProdukt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 371)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmDocProdukt"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Добавить в документ"
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudCost,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents txtFindPr As System.Windows.Forms.TextBox
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbEdIz1 As System.Windows.Forms.ComboBox
    Friend WithEvents lstProd As System.Windows.Forms.ListBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGTD As NumericTextBox.NumericTextbox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEdIzm As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnNewProd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCalc As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmbTypeCost As System.Windows.Forms.ComboBox
    Friend WithEvents nudCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
