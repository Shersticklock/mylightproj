<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigCalcMat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigCalcMat))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clbMatTypeID = New System.Windows.Forms.CheckedListBox()
        Me.tvMat = New System.Windows.Forms.TreeView()
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.txtNameControl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtControlTag = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel2.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.clbMatTypeID, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tvMat, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbService, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label132, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNameControl, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtControlTag, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStrip1, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1276, 701)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Калькулятор (направление)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'clbMatTypeID
        '
        Me.clbMatTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbMatTypeID.CheckOnClick = true
        Me.TableLayoutPanel2.SetColumnSpan(Me.clbMatTypeID, 2)
        Me.clbMatTypeID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbMatTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbMatTypeID.FormattingEnabled = true
        Me.clbMatTypeID.Location = New System.Drawing.Point(453, 106)
        Me.clbMatTypeID.Margin = New System.Windows.Forms.Padding(5)
        Me.clbMatTypeID.Name = "clbMatTypeID"
        Me.clbMatTypeID.ScrollAlwaysVisible = true
        Me.clbMatTypeID.Size = New System.Drawing.Size(650, 590)
        Me.clbMatTypeID.TabIndex = 3
        '
        'tvMat
        '
        Me.tvMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvMat.Location = New System.Drawing.Point(5, 5)
        Me.tvMat.Margin = New System.Windows.Forms.Padding(5)
        Me.tvMat.Name = "tvMat"
        Me.TableLayoutPanel2.SetRowSpan(Me.tvMat, 4)
        Me.tvMat.Size = New System.Drawing.Size(438, 691)
        Me.tvMat.TabIndex = 48
        '
        'cmbService
        '
        Me.cmbService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbService.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbService.FormattingEnabled = true
        Me.cmbService.IntegralHeight = false
        Me.cmbService.Location = New System.Drawing.Point(665, 5)
        Me.cmbService.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(438, 25)
        Me.cmbService.TabIndex = 0
        '
        'Label132
        '
        Me.Label132.AutoSize = true
        Me.Label132.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label132.Location = New System.Drawing.Point(453, 35)
        Me.Label132.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(202, 34)
        Me.Label132.TabIndex = 10
        Me.Label132.Text = "Выпадающий список*"
        Me.Label132.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNameControl
        '
        Me.txtNameControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNameControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNameControl.Location = New System.Drawing.Point(665, 40)
        Me.txtNameControl.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNameControl.Name = "txtNameControl"
        Me.txtNameControl.Size = New System.Drawing.Size(438, 24)
        Me.txtNameControl.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtNameControl, resources.GetString("txtNameControl.ToolTip"))
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(452, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 32)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "ControlTag"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtControlTag
        '
        Me.txtControlTag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtControlTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtControlTag.Location = New System.Drawing.Point(664, 73)
        Me.txtControlTag.Margin = New System.Windows.Forms.Padding(4)
        Me.txtControlTag.Name = "txtControlTag"
        Me.txtControlTag.Size = New System.Drawing.Size(440, 24)
        Me.txtControlTag.TabIndex = 50
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnCost, Me.ToolStripSeparator1, Me.tsbtnOK})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(1108, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.TableLayoutPanel2.SetRowSpan(Me.ToolStrip1, 4)
        Me.ToolStrip1.Size = New System.Drawing.Size(168, 701)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnCost
        '
        Me.tsbtnCost.AutoSize = false
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.Image = CType(resources.GetObject("tsbtnCost.Image"),System.Drawing.Image)
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(156, 45)
        Me.tsbtnCost.Text = "Ok"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.Image = CType(resources.GetObject("tsbtnOK.Image"),System.Drawing.Image)
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(166, 22)
        Me.tsbtnOK.Text = "Выход"
        '
        'frmConfigCalcMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 701)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmConfigCalcMat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Конфигуратор материала"
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents clbMatTypeID As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtNameControl As System.Windows.Forms.TextBox
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbService As System.Windows.Forms.ComboBox
    Friend WithEvents tvMat As System.Windows.Forms.TreeView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtControlTag As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
