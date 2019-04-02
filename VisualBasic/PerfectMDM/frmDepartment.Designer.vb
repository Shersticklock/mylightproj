<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartment))
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbDirDep = New System.Windows.Forms.ComboBox()
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tsCompany = New System.Windows.Forms.ToolStrip()
        Me.tsbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.tlpContact = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbManStyle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstDepEmpl = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tsCompany.SuspendLayout
        Me.tlpContact.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(168, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(168, 22)
        Me.tsbtnCancel.Text = "Отменить"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtName.Location = New System.Drawing.Point(148, 5)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtName.MaxLength = 245
        Me.txtName.Name = "txtName"
        Me.txtName.ShortcutsEnabled = false
        Me.txtName.Size = New System.Drawing.Size(534, 24)
        Me.txtName.TabIndex = 0
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"),System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(168, 22)
        Me.tsbtnSave.Text = "Сохранить"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(5, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 35)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Директор"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(5, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 34)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Наименование"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDirDep
        '
        Me.cmbDirDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDirDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDirDep.DropDownWidth = 480
        Me.cmbDirDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDirDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDirDep.FormattingEnabled = true
        Me.cmbDirDep.Location = New System.Drawing.Point(148, 71)
        Me.cmbDirDep.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbDirDep.MaxDropDownItems = 30
        Me.cmbDirDep.Name = "cmbDirDep"
        Me.cmbDirDep.Size = New System.Drawing.Size(534, 25)
        Me.cmbDirDep.TabIndex = 77
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEdit.Image = CType(resources.GetObject("tsbtnEdit.Image"),System.Drawing.Image)
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(168, 22)
        Me.tsbtnEdit.Text = "Изменить"
        '
        'tsbtnNew
        '
        Me.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNew.Image = CType(resources.GetObject("tsbtnNew.Image"),System.Drawing.Image)
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(168, 22)
        Me.tsbtnNew.Text = "Создать"
        '
        'tsCompany
        '
        Me.tsCompany.AutoSize = false
        Me.tsCompany.Dock = System.Windows.Forms.DockStyle.Right
        Me.tsCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsCompany.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.tsbtnEdit, Me.tsbtnSave, Me.tsbtnCancel, Me.tsbtnDelete, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.tsCompany.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCompany.Location = New System.Drawing.Point(1106, 0)
        Me.tsCompany.Name = "tsCompany"
        Me.tsCompany.Size = New System.Drawing.Size(170, 642)
        Me.tsCompany.TabIndex = 70
        Me.tsCompany.Text = "ToolStrip1"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelete.Image = CType(resources.GetObject("tsbtnDelete.Image"),System.Drawing.Image)
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(168, 22)
        Me.tsbtnDelete.Text = "Удалить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 32)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Описание"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdescription
        '
        Me.txtdescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtdescription.Location = New System.Drawing.Point(147, 38)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(536, 24)
        Me.txtdescription.TabIndex = 102
        '
        'lstData
        '
        Me.lstData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lstData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstData.HorizontalScrollbar = true
        Me.lstData.ItemHeight = 17
        Me.lstData.Location = New System.Drawing.Point(1, 5)
        Me.lstData.Margin = New System.Windows.Forms.Padding(5)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(523, 614)
        Me.lstData.TabIndex = 68
        Me.lstData.TabStop = false
        '
        'tlpContact
        '
        Me.tlpContact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tlpContact.ColumnCount = 2
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpContact.Controls.Add(Me.txtName, 1, 0)
        Me.tlpContact.Controls.Add(Me.Label6, 0, 2)
        Me.tlpContact.Controls.Add(Me.Label10, 0, 0)
        Me.tlpContact.Controls.Add(Me.cmbDirDep, 1, 2)
        Me.tlpContact.Controls.Add(Me.Label2, 0, 1)
        Me.tlpContact.Controls.Add(Me.txtdescription, 1, 1)
        Me.tlpContact.Controls.Add(Me.cmbManStyle, 1, 3)
        Me.tlpContact.Controls.Add(Me.Label1, 0, 3)
        Me.tlpContact.Controls.Add(Me.lstDepEmpl, 1, 4)
        Me.tlpContact.Controls.Add(Me.Label3, 0, 4)
        Me.tlpContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpContact.Location = New System.Drawing.Point(534, 5)
        Me.tlpContact.Margin = New System.Windows.Forms.Padding(5)
        Me.tlpContact.Name = "tlpContact"
        Me.tlpContact.RowCount = 5
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
        Me.tlpContact.Size = New System.Drawing.Size(687, 630)
        Me.tlpContact.TabIndex = 69
        '
        'cmbManStyle
        '
        Me.cmbManStyle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbManStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbManStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbManStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbManStyle.FormattingEnabled = true
        Me.cmbManStyle.Items.AddRange(New Object() {"Автократический", "Либеральный"})
        Me.cmbManStyle.Location = New System.Drawing.Point(147, 105)
        Me.cmbManStyle.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbManStyle.Name = "cmbManStyle"
        Me.cmbManStyle.Size = New System.Drawing.Size(536, 25)
        Me.cmbManStyle.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 33)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Стиль управления"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstDepEmpl
        '
        Me.lstDepEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDepEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstDepEmpl.FormattingEnabled = true
        Me.lstDepEmpl.ItemHeight = 17
        Me.lstDepEmpl.Location = New System.Drawing.Point(147, 138)
        Me.lstDepEmpl.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDepEmpl.Name = "lstDepEmpl"
        Me.lstDepEmpl.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstDepEmpl.Size = New System.Drawing.Size(536, 488)
        Me.lstDepEmpl.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 496)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Сотрудники"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 642)
        Me.Controls.Add(Me.tsCompany)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.tlpContact)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDepartment"
        Me.Text = "Департаменты"
        Me.tsCompany.ResumeLayout(false)
        Me.tsCompany.PerformLayout
        Me.tlpContact.ResumeLayout(false)
        Me.tlpContact.PerformLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbDirDep As System.Windows.Forms.ComboBox
    Friend WithEvents tsbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents tlpContact As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbManStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstDepEmpl As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
