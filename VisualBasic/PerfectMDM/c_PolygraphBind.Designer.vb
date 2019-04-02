<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_PolygraphBind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_PolygraphBind))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.DiscountComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAddCost = New System.Windows.Forms.ToolStripButton()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtCostUnit = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.tsMenu.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.SuspendLayout
        '
        'tsMenu
        '
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsMenu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.DiscountComboBox, Me.ToolStripSeparator3, Me.tsbtnCost, Me.tsbtnOK, Me.tsbtnAddCost, Me.tstxtItog, Me.ToolStripLabel3, Me.tstxtCostUnit, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.tsbtnExit})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsMenu.Location = New System.Drawing.Point(837, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(120, 615)
        Me.tsMenu.TabIndex = 1
        Me.tsMenu.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(118, 16)
        Me.ToolStripLabel1.Text = "Скидка, %"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiscountComboBox
        '
        Me.DiscountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiscountComboBox.Name = "DiscountComboBox"
        Me.DiscountComboBox.Size = New System.Drawing.Size(116, 23)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(118, 6)
        '
        'tsbtnCost
        '
        Me.tsbtnCost.AutoSize = false
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.Image = CType(resources.GetObject("tsbtnCost.Image"),System.Drawing.Image)
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(156, 45)
        Me.tsbtnCost.Text = "Считать"
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Enabled = false
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(118, 37)
        Me.tsbtnOK.Text = "ОК"
        '
        'tsbtnAddCost
        '
        Me.tsbtnAddCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAddCost.Enabled = false
        Me.tsbtnAddCost.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnAddCost.Image = CType(resources.GetObject("tsbtnAddCost.Image"),System.Drawing.Image)
        Me.tsbtnAddCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddCost.Name = "tsbtnAddCost"
        Me.tsbtnAddCost.Size = New System.Drawing.Size(118, 31)
        Me.tsbtnAddCost.Text = "Ещё"
        Me.tsbtnAddCost.Visible = false
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.ReadOnly = true
        Me.tstxtItog.Size = New System.Drawing.Size(116, 34)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tstxtItog.Visible = false
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(118, 18)
        Me.ToolStripLabel3.Text = "За изделие"
        Me.ToolStripLabel3.Visible = false
        '
        'tstxtCostUnit
        '
        Me.tstxtCostUnit.BackColor = System.Drawing.SystemColors.Info
        Me.tstxtCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostUnit.Name = "tstxtCostUnit"
        Me.tstxtCostUnit.ReadOnly = true
        Me.tstxtCostUnit.Size = New System.Drawing.Size(116, 23)
        Me.tstxtCostUnit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tstxtCostUnit.Visible = false
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(118, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripButton1.Tag = "http://www.megarif.ru/support/calc/koreshok.php"
        Me.ToolStripButton1.Text = "КБС, пружина  "
        Me.ToolStripButton1.ToolTipText = "Подсказка"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripButton2.Tag = "http://www.megarif.ru/support/calc/tv_pereplet.php"
        Me.ToolStripButton2.Text = "7БЦ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(118, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(118, 23)
        Me.tsbtnExit.Text = "Выход"
        Me.tsbtnExit.ToolTipText = "Подсказка"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = true
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15!))
        Me.TableLayoutPanel4.Controls.Add(Me.tsMenu, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.WebBrowser1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(957, 615)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 2)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(15, 16)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(833, 611)
        Me.WebBrowser1.TabIndex = 28
        Me.WebBrowser1.Url = New System.Uri("http://calculator.mediasoft.su/Default.aspx", System.UriKind.Absolute)
        '
        'c_PolygraphBind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 615)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "c_PolygraphBind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "777"
        Me.Text = "mdm_PolygraphBind"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsMenu.ResumeLayout(false)
        Me.tsMenu.PerformLayout
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtCostUnit As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents tsbtnAddCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents DiscountComboBox As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
