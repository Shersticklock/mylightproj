<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRDirectoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRDirectoryForm))
        Me.AddFRButton = New System.Windows.Forms.Button()
        Me.EditFRButton = New System.Windows.Forms.Button()
        Me.DeleteFRButton = New System.Windows.Forms.Button()
        Me.FRDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.FRDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'AddFRButton
        '
        Me.AddFRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddFRButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.AddFRButton.Location = New System.Drawing.Point(30, 12)
        Me.AddFRButton.Name = "AddFRButton"
        Me.AddFRButton.Size = New System.Drawing.Size(127, 30)
        Me.AddFRButton.TabIndex = 0
        Me.AddFRButton.Text = "Добавить"
        Me.AddFRButton.UseVisualStyleBackColor = true
        '
        'EditFRButton
        '
        Me.EditFRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditFRButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.EditFRButton.Location = New System.Drawing.Point(181, 12)
        Me.EditFRButton.Name = "EditFRButton"
        Me.EditFRButton.Size = New System.Drawing.Size(127, 30)
        Me.EditFRButton.TabIndex = 1
        Me.EditFRButton.Text = "Изменить"
        Me.EditFRButton.UseVisualStyleBackColor = true
        '
        'DeleteFRButton
        '
        Me.DeleteFRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteFRButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DeleteFRButton.Location = New System.Drawing.Point(372, 12)
        Me.DeleteFRButton.Name = "DeleteFRButton"
        Me.DeleteFRButton.Size = New System.Drawing.Size(127, 30)
        Me.DeleteFRButton.TabIndex = 2
        Me.DeleteFRButton.Text = "Удалить"
        Me.DeleteFRButton.UseVisualStyleBackColor = true
        '
        'FRDataGridView
        '
        Me.FRDataGridView.AllowUserToAddRows = false
        Me.FRDataGridView.AllowUserToDeleteRows = false
        Me.FRDataGridView.AllowUserToResizeRows = false
        Me.FRDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.FRDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FRDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.FRDataGridView.ColumnHeadersHeight = 40
        Me.FRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.FRDataGridView.Location = New System.Drawing.Point(12, 61)
        Me.FRDataGridView.MultiSelect = false
        Me.FRDataGridView.Name = "FRDataGridView"
        Me.FRDataGridView.ReadOnly = true
        Me.FRDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.FRDataGridView.RowTemplate.Height = 40
        Me.FRDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FRDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FRDataGridView.Size = New System.Drawing.Size(862, 301)
        Me.FRDataGridView.TabIndex = 3
        '
        'FRDirectoryForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(886, 374)
        Me.Controls.Add(Me.FRDataGridView)
        Me.Controls.Add(Me.DeleteFRButton)
        Me.Controls.Add(Me.EditFRButton)
        Me.Controls.Add(Me.AddFRButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 300)
        Me.Name = "FRDirectoryForm"
        Me.ShowIcon = false
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Справочник ФР"
        CType(Me.FRDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents AddFRButton As Button
    Friend WithEvents EditFRButton As Button
    Friend WithEvents DeleteFRButton As Button
    Friend WithEvents FRDataGridView As DataGridView
End Class
