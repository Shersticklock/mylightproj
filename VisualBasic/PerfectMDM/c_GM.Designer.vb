<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class c_GM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_GM))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.УдалитьПродуктToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьПродуктToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCalcConfigTech = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КофигураторToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCalcConfig = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TableLayoutPanel4.SuspendLayout
        Me.tsMenu.SuspendLayout
        Me.cmsCalcConfigTech.SuspendLayout
        Me.cmsCalcConfig.SuspendLayout
        Me.SuspendLayout
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(118, 22)
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
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(957, 522)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'tsMenu
        '
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsMenu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOK, Me.tsbtnExit})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsMenu.Location = New System.Drawing.Point(837, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(120, 522)
        Me.tsMenu.TabIndex = 1
        Me.tsMenu.Text = "ToolStrip1"
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
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 2)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(15, 16)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(833, 518)
        Me.WebBrowser1.TabIndex = 2
        '
        'УдалитьПродуктToolStripMenuItem
        '
        Me.УдалитьПродуктToolStripMenuItem.Name = "УдалитьПродуктToolStripMenuItem"
        Me.УдалитьПродуктToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
        Me.УдалитьПродуктToolStripMenuItem.Text = "Удалить продукт"
        '
        'ДобавитьПродуктToolStripMenuItem1
        '
        Me.ДобавитьПродуктToolStripMenuItem1.Name = "ДобавитьПродуктToolStripMenuItem1"
        Me.ДобавитьПродуктToolStripMenuItem1.Size = New System.Drawing.Size(303, 24)
        Me.ДобавитьПродуктToolStripMenuItem1.Text = "Добавить продукт"
        '
        'ЗадатьТехнологическуюОперациюToolStripMenuItem
        '
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Name = "ЗадатьТехнологическуюОперациюToolStripMenuItem"
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Size = New System.Drawing.Size(303, 24)
        Me.ЗадатьТехнологическуюОперациюToolStripMenuItem.Text = "Задать технологическую операцию"
        '
        'cmsCalcConfigTech
        '
        Me.cmsCalcConfigTech.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsCalcConfigTech.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCalcConfigTech.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗадатьТехнологическуюОперациюToolStripMenuItem, Me.ДобавитьПродуктToolStripMenuItem1, Me.УдалитьПродуктToolStripMenuItem})
        Me.cmsCalcConfigTech.Name = "cmsCalcConfigTech"
        Me.cmsCalcConfigTech.Size = New System.Drawing.Size(304, 76)
        '
        'КофигураторToolStripMenuItem
        '
        Me.КофигураторToolStripMenuItem.Name = "КофигураторToolStripMenuItem"
        Me.КофигураторToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.КофигураторToolStripMenuItem.Text = "Конфигуратор"
        '
        'cmsCalcConfig
        '
        Me.cmsCalcConfig.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsCalcConfig.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCalcConfig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КофигураторToolStripMenuItem})
        Me.cmsCalcConfig.Name = "cmsCalcConfig"
        Me.cmsCalcConfig.Size = New System.Drawing.Size(160, 26)
        '
        'c_GM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 522)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "c_GM"
        Me.Text = "mdm_GM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        Me.tsMenu.ResumeLayout(false)
        Me.tsMenu.PerformLayout
        Me.cmsCalcConfigTech.ResumeLayout(false)
        Me.cmsCalcConfig.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents УдалитьПродуктToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДобавитьПродуктToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗадатьТехнологическуюОперациюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCalcConfigTech As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КофигураторToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCalcConfig As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
