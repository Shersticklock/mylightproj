<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficeDirectoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficeDirectoryForm))
        Me.OfficeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DeleteOfficeButton = New System.Windows.Forms.Button()
        Me.EditOfficeButton = New System.Windows.Forms.Button()
        Me.AddOfficeButton = New System.Windows.Forms.Button()
        CType(Me.OfficeDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'OfficeDataGridView
        '
        Me.OfficeDataGridView.AllowUserToAddRows = false
        Me.OfficeDataGridView.AllowUserToDeleteRows = false
        Me.OfficeDataGridView.AllowUserToResizeRows = false
        Me.OfficeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.OfficeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OfficeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.OfficeDataGridView.ColumnHeadersHeight = 40
        Me.OfficeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OfficeDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.OfficeDataGridView.MultiSelect = false
        Me.OfficeDataGridView.Name = "OfficeDataGridView"
        Me.OfficeDataGridView.ReadOnly = true
        Me.OfficeDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.OfficeDataGridView.RowTemplate.Height = 40
        Me.OfficeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OfficeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OfficeDataGridView.Size = New System.Drawing.Size(485, 211)
        Me.OfficeDataGridView.TabIndex = 7
        '
        'DeleteOfficeButton
        '
        Me.DeleteOfficeButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DeleteOfficeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteOfficeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DeleteOfficeButton.Location = New System.Drawing.Point(351, 19)
        Me.DeleteOfficeButton.Name = "DeleteOfficeButton"
        Me.DeleteOfficeButton.Size = New System.Drawing.Size(146, 30)
        Me.DeleteOfficeButton.TabIndex = 6
        Me.DeleteOfficeButton.Text = "Удалить"
        Me.DeleteOfficeButton.UseVisualStyleBackColor = false
        '
        'EditOfficeButton
        '
        Me.EditOfficeButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EditOfficeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditOfficeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.EditOfficeButton.Location = New System.Drawing.Point(173, 19)
        Me.EditOfficeButton.Name = "EditOfficeButton"
        Me.EditOfficeButton.Size = New System.Drawing.Size(146, 30)
        Me.EditOfficeButton.TabIndex = 5
        Me.EditOfficeButton.Text = "Изменить"
        Me.EditOfficeButton.UseVisualStyleBackColor = false
        '
        'AddOfficeButton
        '
        Me.AddOfficeButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AddOfficeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddOfficeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.AddOfficeButton.Location = New System.Drawing.Point(12, 19)
        Me.AddOfficeButton.Name = "AddOfficeButton"
        Me.AddOfficeButton.Size = New System.Drawing.Size(146, 30)
        Me.AddOfficeButton.TabIndex = 4
        Me.AddOfficeButton.Text = "Добавить"
        Me.AddOfficeButton.UseVisualStyleBackColor = false
        '
        'OfficeDirectoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 291)
        Me.Controls.Add(Me.OfficeDataGridView)
        Me.Controls.Add(Me.DeleteOfficeButton)
        Me.Controls.Add(Me.EditOfficeButton)
        Me.Controls.Add(Me.AddOfficeButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(525, 300)
        Me.Name = "OfficeDirectoryForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Офисы"
        CType(Me.OfficeDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents OfficeDataGridView As DataGridView
    Friend WithEvents DeleteOfficeButton As Button
    Friend WithEvents EditOfficeButton As Button
    Friend WithEvents AddOfficeButton As Button
End Class
