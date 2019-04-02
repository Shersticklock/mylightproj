<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatFormatInOut
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatFormatInOut))
        Me.lstFormatOut = New System.Windows.Forms.ListBox()
        Me.dgFormatInOut = New System.Windows.Forms.DataGridView()
        Me.cmbFormatIN = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgFormatInOut,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'lstFormatOut
        '
        Me.lstFormatOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstFormatOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFormatOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstFormatOut.FormattingEnabled = true
        Me.lstFormatOut.ItemHeight = 17
        Me.lstFormatOut.Location = New System.Drawing.Point(5, 79)
        Me.lstFormatOut.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstFormatOut.Name = "lstFormatOut"
        Me.lstFormatOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.SetRowSpan(Me.lstFormatOut, 2)
        Me.lstFormatOut.Size = New System.Drawing.Size(315, 321)
        Me.lstFormatOut.TabIndex = 0
        '
        'dgFormatInOut
        '
        Me.dgFormatInOut.AllowUserToAddRows = false
        Me.dgFormatInOut.AllowUserToDeleteRows = false
        Me.dgFormatInOut.AllowUserToResizeRows = false
        Me.dgFormatInOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFormatInOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFormatInOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFormatInOut.Location = New System.Drawing.Point(459, 24)
        Me.dgFormatInOut.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgFormatInOut.MultiSelect = false
        Me.dgFormatInOut.Name = "dgFormatInOut"
        Me.dgFormatInOut.ReadOnly = true
        Me.dgFormatInOut.RowHeadersVisible = false
        Me.TableLayoutPanel1.SetRowSpan(Me.dgFormatInOut, 4)
        Me.dgFormatInOut.RowTemplate.Height = 24
        Me.dgFormatInOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFormatInOut.Size = New System.Drawing.Size(367, 376)
        Me.dgFormatInOut.TabIndex = 1
        '
        'cmbFormatIN
        '
        Me.cmbFormatIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFormatIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormatIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbFormatIN.FormattingEnabled = true
        Me.cmbFormatIN.Location = New System.Drawing.Point(5, 24)
        Me.cmbFormatIN.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbFormatIN.MaxDropDownItems = 24
        Me.cmbFormatIN.Name = "cmbFormatIN"
        Me.cmbFormatIN.Size = New System.Drawing.Size(315, 25)
        Me.cmbFormatIN.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(330, 79)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = ">>>"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(330, 130)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(119, 39)
        Me.btnDel.TabIndex = 6
        Me.btnDel.Text = "<<<"
        Me.btnDel.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Печатные форматы"
        '
        'nudQuantity
        '
        Me.nudQuantity.DecimalPlaces = 4
        Me.nudQuantity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(328, 26)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(123, 26)
        Me.nudQuantity.TabIndex = 8
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFormatIN, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudQuantity, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dgFormatInOut, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lstFormatOut, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(831, 406)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Единица учета (формат покупной)"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(328, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(500, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Печатных с покупного"
        '
        'frmMatFormatInOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 406)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmMatFormatInOut"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Отношения форматов"
        CType(Me.dgFormatInOut,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudQuantity,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lstFormatOut As System.Windows.Forms.ListBox
    Friend WithEvents dgFormatInOut As System.Windows.Forms.DataGridView
    Friend WithEvents cmbFormatIN As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
