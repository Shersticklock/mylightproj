<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmplDeputy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmplDeputy))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbStatusEmpl = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.clbMatTypeID = New System.Windows.Forms.CheckedListBox()
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstEmployees = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.93649!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.06351!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 438!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmbStatusEmpl, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnApply, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.clbMatTypeID, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbService, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lstEmployees, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(826, 561)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'cmbStatusEmpl
        '
        Me.cmbStatusEmpl.DisplayMember = "0"
        Me.cmbStatusEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatusEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbStatusEmpl.FormattingEnabled = true
        Me.cmbStatusEmpl.Items.AddRange(New Object() {"Все", "Действительные", "Уволеные"})
        Me.cmbStatusEmpl.Location = New System.Drawing.Point(3, 3)
        Me.cmbStatusEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbStatusEmpl.Name = "cmbStatusEmpl"
        Me.cmbStatusEmpl.Size = New System.Drawing.Size(222, 24)
        Me.cmbStatusEmpl.TabIndex = 55
        Me.cmbStatusEmpl.TabStop = false
        Me.cmbStatusEmpl.ValueMember = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(231, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Контрагент"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = false
        '
        'btnApply
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btnApply, 2)
        Me.btnApply.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnApply.Location = New System.Drawing.Point(231, 498)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(591, 28)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "Применить"
        Me.btnApply.UseVisualStyleBackColor = true
        '
        'clbMatTypeID
        '
        Me.clbMatTypeID.CheckOnClick = true
        Me.TableLayoutPanel2.SetColumnSpan(Me.clbMatTypeID, 2)
        Me.clbMatTypeID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbMatTypeID.FormattingEnabled = true
        Me.clbMatTypeID.Location = New System.Drawing.Point(231, 33)
        Me.clbMatTypeID.Name = "clbMatTypeID"
        Me.clbMatTypeID.ScrollAlwaysVisible = true
        Me.clbMatTypeID.Size = New System.Drawing.Size(591, 458)
        Me.clbMatTypeID.TabIndex = 3
        '
        'cmbService
        '
        Me.cmbService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbService.FormattingEnabled = true
        Me.cmbService.IntegralHeight = false
        Me.cmbService.Location = New System.Drawing.Point(389, 4)
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(433, 24)
        Me.cmbService.TabIndex = 0
        Me.cmbService.Visible = false
        '
        'Button1
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.Button1, 2)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(231, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(591, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Выход"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'lstEmployees
        '
        Me.lstEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstEmployees.HorizontalScrollbar = true
        Me.lstEmployees.ItemHeight = 16
        Me.lstEmployees.Location = New System.Drawing.Point(3, 32)
        Me.lstEmployees.Margin = New System.Windows.Forms.Padding(2)
        Me.lstEmployees.Name = "lstEmployees"
        Me.lstEmployees.Size = New System.Drawing.Size(222, 452)
        Me.lstEmployees.TabIndex = 13
        Me.lstEmployees.TabStop = false
        '
        'frmEmplDeputy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 561)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEmplDeputy"
        Me.Text = "frmEmplDeputy"
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents clbMatTypeID As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmbService As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstEmployees As System.Windows.Forms.ListBox
    Friend WithEvents cmbStatusEmpl As System.Windows.Forms.ComboBox
End Class
