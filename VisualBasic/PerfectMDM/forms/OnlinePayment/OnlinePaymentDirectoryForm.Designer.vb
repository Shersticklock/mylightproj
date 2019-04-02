<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnlinePaymentDirectoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OnlinePaymentDirectoryForm))
        Me.DeleteOnlinePaymentsTypeButton = New System.Windows.Forms.Button()
        Me.EditOnlinePaymentsTypeButton = New System.Windows.Forms.Button()
        Me.AddOnlinePaymentsTypeButton = New System.Windows.Forms.Button()
        Me.OnlinePaymentsTypeDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.OnlinePaymentsTypeDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DeleteOnlinePaymentsTypeButton
        '
        Me.DeleteOnlinePaymentsTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteOnlinePaymentsTypeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DeleteOnlinePaymentsTypeButton.Location = New System.Drawing.Point(366, 12)
        Me.DeleteOnlinePaymentsTypeButton.Name = "DeleteOnlinePaymentsTypeButton"
        Me.DeleteOnlinePaymentsTypeButton.Size = New System.Drawing.Size(127, 30)
        Me.DeleteOnlinePaymentsTypeButton.TabIndex = 5
        Me.DeleteOnlinePaymentsTypeButton.Text = "Удалить"
        Me.DeleteOnlinePaymentsTypeButton.UseVisualStyleBackColor = true
        '
        'EditOnlinePaymentsTypeButton
        '
        Me.EditOnlinePaymentsTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditOnlinePaymentsTypeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.EditOnlinePaymentsTypeButton.Location = New System.Drawing.Point(175, 12)
        Me.EditOnlinePaymentsTypeButton.Name = "EditOnlinePaymentsTypeButton"
        Me.EditOnlinePaymentsTypeButton.Size = New System.Drawing.Size(127, 30)
        Me.EditOnlinePaymentsTypeButton.TabIndex = 4
        Me.EditOnlinePaymentsTypeButton.Text = "Изменить"
        Me.EditOnlinePaymentsTypeButton.UseVisualStyleBackColor = true
        '
        'AddOnlinePaymentsTypeButton
        '
        Me.AddOnlinePaymentsTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddOnlinePaymentsTypeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.AddOnlinePaymentsTypeButton.Location = New System.Drawing.Point(24, 12)
        Me.AddOnlinePaymentsTypeButton.Name = "AddOnlinePaymentsTypeButton"
        Me.AddOnlinePaymentsTypeButton.Size = New System.Drawing.Size(127, 30)
        Me.AddOnlinePaymentsTypeButton.TabIndex = 3
        Me.AddOnlinePaymentsTypeButton.Text = "Добавить"
        Me.AddOnlinePaymentsTypeButton.UseVisualStyleBackColor = true
        '
        'OnlinePaymentsTypeDataGridView
        '
        Me.OnlinePaymentsTypeDataGridView.AllowUserToAddRows = false
        Me.OnlinePaymentsTypeDataGridView.AllowUserToDeleteRows = false
        Me.OnlinePaymentsTypeDataGridView.AllowUserToResizeRows = false
        Me.OnlinePaymentsTypeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.OnlinePaymentsTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OnlinePaymentsTypeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.OnlinePaymentsTypeDataGridView.ColumnHeadersHeight = 40
        Me.OnlinePaymentsTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OnlinePaymentsTypeDataGridView.Location = New System.Drawing.Point(12, 59)
        Me.OnlinePaymentsTypeDataGridView.MultiSelect = false
        Me.OnlinePaymentsTypeDataGridView.Name = "OnlinePaymentsTypeDataGridView"
        Me.OnlinePaymentsTypeDataGridView.ReadOnly = true
        Me.OnlinePaymentsTypeDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.OnlinePaymentsTypeDataGridView.RowTemplate.Height = 40
        Me.OnlinePaymentsTypeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OnlinePaymentsTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OnlinePaymentsTypeDataGridView.Size = New System.Drawing.Size(500, 326)
        Me.OnlinePaymentsTypeDataGridView.TabIndex = 6
        '
        'OnlinePaymentDirectoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 397)
        Me.Controls.Add(Me.OnlinePaymentsTypeDataGridView)
        Me.Controls.Add(Me.DeleteOnlinePaymentsTypeButton)
        Me.Controls.Add(Me.EditOnlinePaymentsTypeButton)
        Me.Controls.Add(Me.AddOnlinePaymentsTypeButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(540, 400)
        Me.Name = "OnlinePaymentDirectoryForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Справочник онлайн оплат"
        CType(Me.OnlinePaymentsTypeDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents DeleteOnlinePaymentsTypeButton As Button
    Friend WithEvents EditOnlinePaymentsTypeButton As Button
    Friend WithEvents AddOnlinePaymentsTypeButton As Button
    Friend WithEvents OnlinePaymentsTypeDataGridView As DataGridView
End Class
