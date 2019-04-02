<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduktNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduktNew))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbTypeProd = New System.Windows.Forms.ComboBox()
        Me.cmbServices = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSaveProd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudParamCost = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudParamCost,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTypeProd, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbServices, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaveProd, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.nudParamCost, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(496, 317)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmbTypeProd
        '
        Me.cmbTypeProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTypeProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypeProd.FormattingEnabled = true
        Me.cmbTypeProd.Location = New System.Drawing.Point(4, 26)
        Me.cmbTypeProd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTypeProd.Name = "cmbTypeProd"
        Me.cmbTypeProd.Size = New System.Drawing.Size(488, 25)
        Me.cmbTypeProd.TabIndex = 0
        '
        'cmbServices
        '
        Me.cmbServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServices.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbServices.FormattingEnabled = true
        Me.cmbServices.Location = New System.Drawing.Point(4, 81)
        Me.cmbServices.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbServices.MaxDropDownItems = 24
        Me.cmbServices.Name = "cmbServices"
        Me.cmbServices.Size = New System.Drawing.Size(488, 25)
        Me.cmbServices.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtName.Location = New System.Drawing.Point(3, 135)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(490, 24)
        Me.txtName.TabIndex = 2
        '
        'btnSaveProd
        '
        Me.btnSaveProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveProd.Enabled = false
        Me.btnSaveProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSaveProd.Location = New System.Drawing.Point(3, 215)
        Me.btnSaveProd.Name = "btnSaveProd"
        Me.btnSaveProd.Size = New System.Drawing.Size(490, 99)
        Me.btnSaveProd.TabIndex = 3
        Me.btnSaveProd.Text = "Сохранить"
        Me.btnSaveProd.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Тип продукции"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Направление"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Наименование"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(490, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0-считаем полосами, 1-считаем листами"
        '
        'nudParamCost
        '
        Me.nudParamCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudParamCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudParamCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudParamCost.Location = New System.Drawing.Point(3, 183)
        Me.nudParamCost.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudParamCost.Name = "nudParamCost"
        Me.nudParamCost.Size = New System.Drawing.Size(490, 26)
        Me.nudParamCost.TabIndex = 8
        '
        'frmProduktNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 317)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmProduktNew"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProduktNew"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudParamCost,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbTypeProd As System.Windows.Forms.ComboBox
    Friend WithEvents cmbServices As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveProd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudParamCost As System.Windows.Forms.NumericUpDown
End Class
