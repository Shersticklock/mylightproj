<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FastReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FastReportForm))
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.OfficeDataGrid = New System.Windows.Forms.DataGridView()
        Me.OfficeGridLabel = New System.Windows.Forms.Label()
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.TimeTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.TimeFrom = New System.Windows.Forms.DateTimePicker()
        Me.DateFrom = New System.Windows.Forms.DateTimePicker()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.CassaGridLabel = New System.Windows.Forms.Label()
        Me.CassaDataGrid = New System.Windows.Forms.DataGridView()
        Me.MainTableLayoutPanel.SuspendLayout
        CType(Me.OfficeDataGrid,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ControlPanel.SuspendLayout
        CType(Me.CassaDataGrid,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 1
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.MainTableLayoutPanel.Controls.Add(Me.OfficeDataGrid, 0, 4)
        Me.MainTableLayoutPanel.Controls.Add(Me.OfficeGridLabel, 0, 3)
        Me.MainTableLayoutPanel.Controls.Add(Me.ControlPanel, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.CassaGridLabel, 0, 1)
        Me.MainTableLayoutPanel.Controls.Add(Me.CassaDataGrid, 0, 2)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTableLayoutPanel.RowCount = 5
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(584, 562)
        Me.MainTableLayoutPanel.TabIndex = 0
        '
        'OfficeDataGrid
        '
        Me.OfficeDataGrid.AllowUserToAddRows = false
        Me.OfficeDataGrid.AllowUserToDeleteRows = false
        Me.OfficeDataGrid.AllowUserToOrderColumns = true
        Me.OfficeDataGrid.AllowUserToResizeRows = false
        Me.OfficeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OfficeDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.OfficeDataGrid.ColumnHeadersHeight = 44
        Me.OfficeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OfficeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OfficeDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.OfficeDataGrid.Location = New System.Drawing.Point(6, 329)
        Me.OfficeDataGrid.MultiSelect = false
        Me.OfficeDataGrid.Name = "OfficeDataGrid"
        Me.OfficeDataGrid.RowHeadersVisible = false
        Me.OfficeDataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.OfficeDataGrid.RowTemplate.Height = 36
        Me.OfficeDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OfficeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OfficeDataGrid.Size = New System.Drawing.Size(572, 227)
        Me.OfficeDataGrid.TabIndex = 4
        '
        'OfficeGridLabel
        '
        Me.OfficeGridLabel.AutoSize = true
        Me.OfficeGridLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OfficeGridLabel.Font = New System.Drawing.Font("Georgia", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.OfficeGridLabel.Location = New System.Drawing.Point(6, 302)
        Me.OfficeGridLabel.Name = "OfficeGridLabel"
        Me.OfficeGridLabel.Size = New System.Drawing.Size(572, 24)
        Me.OfficeGridLabel.TabIndex = 3
        Me.OfficeGridLabel.Text = "Выручка по офисам:"
        Me.OfficeGridLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ControlPanel
        '
        Me.ControlPanel.Controls.Add(Me.TimeTo)
        Me.ControlPanel.Controls.Add(Me.DateTo)
        Me.ControlPanel.Controls.Add(Me.TimeFrom)
        Me.ControlPanel.Controls.Add(Me.DateFrom)
        Me.ControlPanel.Controls.Add(Me.RefreshButton)
        Me.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlPanel.Location = New System.Drawing.Point(6, 6)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(572, 36)
        Me.ControlPanel.TabIndex = 0
        '
        'TimeTo
        '
        Me.TimeTo.CustomFormat = "HH:mm"
        Me.TimeTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeTo.Location = New System.Drawing.Point(507, 3)
        Me.TimeTo.Name = "TimeTo"
        Me.TimeTo.ShowUpDown = true
        Me.TimeTo.Size = New System.Drawing.Size(65, 26)
        Me.TimeTo.TabIndex = 4
        Me.TimeTo.Value = New Date(2017, 7, 17, 23, 59, 0, 0)
        '
        'DateTo
        '
        Me.DateTo.Font = New System.Drawing.Font("Georgia", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTo.Location = New System.Drawing.Point(382, 3)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(128, 26)
        Me.DateTo.TabIndex = 3
        '
        'TimeFrom
        '
        Me.TimeFrom.CustomFormat = "HH:mm"
        Me.TimeFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeFrom.Location = New System.Drawing.Point(284, 3)
        Me.TimeFrom.Name = "TimeFrom"
        Me.TimeFrom.ShowUpDown = true
        Me.TimeFrom.Size = New System.Drawing.Size(65, 26)
        Me.TimeFrom.TabIndex = 2
        Me.TimeFrom.Value = New Date(2017, 7, 17, 0, 0, 0, 0)
        '
        'DateFrom
        '
        Me.DateFrom.Font = New System.Drawing.Font("Georgia", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFrom.Location = New System.Drawing.Point(159, 3)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(128, 26)
        Me.DateFrom.TabIndex = 1
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(3, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(113, 30)
        Me.RefreshButton.TabIndex = 0
        Me.RefreshButton.Text = "Обновить"
        Me.RefreshButton.UseVisualStyleBackColor = false
        '
        'CassaGridLabel
        '
        Me.CassaGridLabel.AutoSize = true
        Me.CassaGridLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CassaGridLabel.Font = New System.Drawing.Font("Georgia", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CassaGridLabel.Location = New System.Drawing.Point(6, 45)
        Me.CassaGridLabel.Name = "CassaGridLabel"
        Me.CassaGridLabel.Size = New System.Drawing.Size(572, 24)
        Me.CassaGridLabel.TabIndex = 1
        Me.CassaGridLabel.Text = "Выручка по кассам:"
        Me.CassaGridLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'CassaDataGrid
        '
        Me.CassaDataGrid.AllowUserToAddRows = false
        Me.CassaDataGrid.AllowUserToDeleteRows = false
        Me.CassaDataGrid.AllowUserToOrderColumns = true
        Me.CassaDataGrid.AllowUserToResizeRows = false
        Me.CassaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CassaDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CassaDataGrid.ColumnHeadersHeight = 44
        Me.CassaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CassaDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CassaDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.CassaDataGrid.Location = New System.Drawing.Point(6, 72)
        Me.CassaDataGrid.MultiSelect = false
        Me.CassaDataGrid.Name = "CassaDataGrid"
        Me.CassaDataGrid.RowHeadersVisible = false
        Me.CassaDataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Garamond", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CassaDataGrid.RowTemplate.Height = 36
        Me.CassaDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CassaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CassaDataGrid.Size = New System.Drawing.Size(572, 227)
        Me.CassaDataGrid.TabIndex = 2
        '
        'FastReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "FastReportForm"
        Me.Text = "Обзор"
        Me.MainTableLayoutPanel.ResumeLayout(false)
        Me.MainTableLayoutPanel.PerformLayout
        CType(Me.OfficeDataGrid,System.ComponentModel.ISupportInitialize).EndInit
        Me.ControlPanel.ResumeLayout(false)
        CType(Me.CassaDataGrid,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents OfficeDataGrid As DataGridView
    Friend WithEvents OfficeGridLabel As Label
    Friend WithEvents ControlPanel As Panel
    Friend WithEvents TimeTo As DateTimePicker
    Friend WithEvents DateTo As DateTimePicker
    Friend WithEvents TimeFrom As DateTimePicker
    Friend WithEvents DateFrom As DateTimePicker
    Friend WithEvents RefreshButton As Button
    Friend WithEvents CassaGridLabel As Label
    Friend WithEvents CassaDataGrid As DataGridView
End Class
