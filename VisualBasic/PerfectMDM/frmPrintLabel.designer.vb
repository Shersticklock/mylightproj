<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintLabel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintLabel))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.nudSpace = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudInterval = New System.Windows.Forms.NumericUpDown()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnSettings = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnViewLabel = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnPrintLabel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbPrim = New System.Windows.Forms.ComboBox()
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudSpace,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudInterval,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Количество мест"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 36)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Отступ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Примечание"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(145, 6)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(333, 24)
        Me.nudQuantity.TabIndex = 0
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSpace
        '
        Me.nudSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSpace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSpace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudSpace.Location = New System.Drawing.Point(145, 73)
        Me.nudSpace.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudSpace.Name = "nudSpace"
        Me.nudSpace.Size = New System.Drawing.Size(333, 24)
        Me.nudSpace.TabIndex = 2
        Me.nudSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSpace.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 36)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Шаг"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudInterval
        '
        Me.nudInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudInterval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudInterval.Location = New System.Drawing.Point(145, 109)
        Me.nudInterval.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.nudInterval.Name = "nudInterval"
        Me.nudInterval.Size = New System.Drawing.Size(333, 24)
        Me.nudInterval.TabIndex = 3
        Me.nudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudInterval.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnSettings, Me.tsbtnViewLabel, Me.tsbtnPrintLabel, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(483, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.TableLayoutPanel1.SetRowSpan(Me.ToolStrip1, 4)
        Me.ToolStrip1.Size = New System.Drawing.Size(139, 139)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnSettings
        '
        Me.tsbtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSettings.Image = CType(resources.GetObject("tsbtnSettings.Image"),System.Drawing.Image)
        Me.tsbtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSettings.Name = "tsbtnSettings"
        Me.tsbtnSettings.Size = New System.Drawing.Size(136, 22)
        Me.tsbtnSettings.Text = "Установки"
        '
        'tsbtnViewLabel
        '
        Me.tsbtnViewLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnViewLabel.Image = CType(resources.GetObject("tsbtnViewLabel.Image"),System.Drawing.Image)
        Me.tsbtnViewLabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnViewLabel.Name = "tsbtnViewLabel"
        Me.tsbtnViewLabel.Size = New System.Drawing.Size(136, 22)
        Me.tsbtnViewLabel.Text = "Просмотр"
        '
        'tsbtnPrintLabel
        '
        Me.tsbtnPrintLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnPrintLabel.Image = CType(resources.GetObject("tsbtnPrintLabel.Image"),System.Drawing.Image)
        Me.tsbtnPrintLabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPrintLabel.Name = "tsbtnPrintLabel"
        Me.tsbtnPrintLabel.Size = New System.Drawing.Size(136, 22)
        Me.tsbtnPrintLabel.Text = "Печать"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(136, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudQuantity, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudInterval, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nudSpace, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPrim, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(622, 139)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'cmbPrim
        '
        Me.cmbPrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPrim.FormattingEnabled = true
        Me.cmbPrim.Location = New System.Drawing.Point(143, 39)
        Me.cmbPrim.Name = "cmbPrim"
        Me.cmbPrim.Size = New System.Drawing.Size(337, 25)
        Me.cmbPrim.TabIndex = 13
        '
        'frmPrintLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 160)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmPrintLabel"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Печать этикеток"
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudSpace,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudInterval,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSpace As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnViewLabel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnPrintLabel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbPrim As System.Windows.Forms.ComboBox

End Class
