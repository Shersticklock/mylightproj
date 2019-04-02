<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperatorsPerformanceReportForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OperatorsPerformanceReportForm))
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.Result1DataGridView = New System.Windows.Forms.DataGridView()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Result2DataGridView = New System.Windows.Forms.DataGridView()
        Me.Result3DataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.Result1DataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.TabPage3.SuspendLayout
        CType(Me.Result2DataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Result3DataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = true
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateLabel.Location = New System.Drawing.Point(12, 9)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Padding = New System.Windows.Forms.Padding(6)
        Me.DateLabel.Size = New System.Drawing.Size(87, 30)
        Me.DateLabel.TabIndex = 89
        Me.DateLabel.Text = "Интервал"
        Me.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd.MM.yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(115, 15)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(102, 24)
        Me.DateFrom.TabIndex = 91
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd.MM.yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(238, 15)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(102, 24)
        Me.DateTo.TabIndex = 92
        '
        'Result1DataGridView
        '
        Me.Result1DataGridView.AllowUserToAddRows = false
        Me.Result1DataGridView.AllowUserToDeleteRows = false
        Me.Result1DataGridView.AllowUserToResizeRows = false
        Me.Result1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Result1DataGridView.ColumnHeadersHeight = 40
        Me.Result1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Result1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Result1DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Result1DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Result1DataGridView.Name = "Result1DataGridView"
        Me.Result1DataGridView.ReadOnly = true
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Result1DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Result1DataGridView.RowTemplate.Height = 24
        Me.Result1DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Result1DataGridView.Size = New System.Drawing.Size(899, 323)
        Me.Result1DataGridView.TabIndex = 93
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(782, 9)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(143, 35)
        Me.RefreshButton.TabIndex = 94
        Me.RefreshButton.Text = "Обновить"
        Me.RefreshButton.UseVisualStyleBackColor = false
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(913, 362)
        Me.TabControl1.TabIndex = 95
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Result1DataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(905, 329)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Быстрые заказы"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Result2DataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(905, 329)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Выполнено заказов"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Result3DataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(905, 329)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Принято заказов"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'Result2DataGridView
        '
        Me.Result2DataGridView.AllowUserToAddRows = false
        Me.Result2DataGridView.AllowUserToDeleteRows = false
        Me.Result2DataGridView.AllowUserToResizeRows = false
        Me.Result2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Result2DataGridView.ColumnHeadersHeight = 60
        Me.Result2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Result2DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Result2DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Result2DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Result2DataGridView.Name = "Result2DataGridView"
        Me.Result2DataGridView.ReadOnly = true
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Result2DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Result2DataGridView.RowTemplate.Height = 24
        Me.Result2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Result2DataGridView.Size = New System.Drawing.Size(899, 323)
        Me.Result2DataGridView.TabIndex = 95
        '
        'Result3DataGridView
        '
        Me.Result3DataGridView.AllowUserToAddRows = false
        Me.Result3DataGridView.AllowUserToDeleteRows = false
        Me.Result3DataGridView.AllowUserToResizeRows = false
        Me.Result3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Result3DataGridView.ColumnHeadersHeight = 40
        Me.Result3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Result3DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Result3DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Result3DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Result3DataGridView.Name = "Result3DataGridView"
        Me.Result3DataGridView.ReadOnly = true
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Result3DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Result3DataGridView.RowTemplate.Height = 24
        Me.Result3DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Result3DataGridView.Size = New System.Drawing.Size(899, 323)
        Me.Result3DataGridView.TabIndex = 95
        '
        'OperatorsPerformanceReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 424)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DateFrom)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.DateLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 350)
        Me.Name = "OperatorsPerformanceReportForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Отчет ""Эффективность операторов"""
        CType(Me.Result1DataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage3.ResumeLayout(false)
        CType(Me.Result2DataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Result3DataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents DateLabel As Label
    Friend WithEvents DateFrom As DateTimePicker
    Friend WithEvents DateTo As DateTimePicker
    Friend WithEvents Result1DataGridView As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Result2DataGridView As DataGridView
    Friend WithEvents Result3DataGridView As DataGridView
End Class
