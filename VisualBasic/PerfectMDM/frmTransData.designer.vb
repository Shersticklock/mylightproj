<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransData))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.grpDbName = New System.Windows.Forms.GroupBox()
        Me.btnFindFile = New System.Windows.Forms.Button()
        Me.grpFindFilePrice = New System.Windows.Forms.GroupBox()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grpRefreshFilePrice = New System.Windows.Forms.GroupBox()
        Me.txtSaveFile = New System.Windows.Forms.TextBox()
        Me.btnFileSave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        Me.grpDbName.SuspendLayout
        Me.grpFindFilePrice.SuspendLayout
        Me.grpRefreshFilePrice.SuspendLayout
        Me.SuspendLayout
        '
        'cmbService
        '
        Me.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbService.FormattingEnabled = true
        Me.cmbService.Location = New System.Drawing.Point(10, 35)
        Me.cmbService.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbService.MaxDropDownItems = 16
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(490, 25)
        Me.cmbService.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbLocation)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(515, 88)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Местоположение"
        '
        'cmbLocation
        '
        Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocation.FormattingEnabled = true
        Me.cmbLocation.Items.AddRange(New Object() {"Издатель", "Подписчик"})
        Me.cmbLocation.Location = New System.Drawing.Point(10, 32)
        Me.cmbLocation.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(490, 25)
        Me.cmbLocation.TabIndex = 0
        '
        'grpDbName
        '
        Me.grpDbName.Controls.Add(Me.cmbService)
        Me.grpDbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.grpDbName.Location = New System.Drawing.Point(14, 263)
        Me.grpDbName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.grpDbName.Name = "grpDbName"
        Me.grpDbName.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.grpDbName.Size = New System.Drawing.Size(515, 88)
        Me.grpDbName.TabIndex = 13
        Me.grpDbName.TabStop = false
        Me.grpDbName.Text = "Направление"
        '
        'btnFindFile
        '
        Me.btnFindFile.Location = New System.Drawing.Point(456, 32)
        Me.btnFindFile.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnFindFile.Name = "btnFindFile"
        Me.btnFindFile.Size = New System.Drawing.Size(46, 39)
        Me.btnFindFile.TabIndex = 14
        Me.btnFindFile.Text = "..."
        Me.btnFindFile.UseVisualStyleBackColor = true
        '
        'grpFindFilePrice
        '
        Me.grpFindFilePrice.Controls.Add(Me.txtFile)
        Me.grpFindFilePrice.Controls.Add(Me.btnFindFile)
        Me.grpFindFilePrice.Enabled = false
        Me.grpFindFilePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.grpFindFilePrice.Location = New System.Drawing.Point(24, 363)
        Me.grpFindFilePrice.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.grpFindFilePrice.Name = "grpFindFilePrice"
        Me.grpFindFilePrice.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.grpFindFilePrice.Size = New System.Drawing.Size(515, 94)
        Me.grpFindFilePrice.TabIndex = 15
        Me.grpFindFilePrice.TabStop = false
        Me.grpFindFilePrice.Text = "Найти и выбрать файл прайс-лист"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(10, 35)
        Me.txtFile.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(434, 24)
        Me.txtFile.TabIndex = 15
        '
        'grpRefreshFilePrice
        '
        Me.grpRefreshFilePrice.Controls.Add(Me.txtSaveFile)
        Me.grpRefreshFilePrice.Controls.Add(Me.btnFileSave)
        Me.grpRefreshFilePrice.Enabled = false
        Me.grpRefreshFilePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.grpRefreshFilePrice.Location = New System.Drawing.Point(34, 134)
        Me.grpRefreshFilePrice.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.grpRefreshFilePrice.Name = "grpRefreshFilePrice"
        Me.grpRefreshFilePrice.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.grpRefreshFilePrice.Size = New System.Drawing.Size(515, 94)
        Me.grpRefreshFilePrice.TabIndex = 16
        Me.grpRefreshFilePrice.TabStop = false
        Me.grpRefreshFilePrice.Text = "Обновить файл прайс-лист"
        '
        'txtSaveFile
        '
        Me.txtSaveFile.Location = New System.Drawing.Point(10, 37)
        Me.txtSaveFile.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSaveFile.Name = "txtSaveFile"
        Me.txtSaveFile.Size = New System.Drawing.Size(434, 24)
        Me.txtSaveFile.TabIndex = 1
        '
        'btnFileSave
        '
        Me.btnFileSave.Location = New System.Drawing.Point(456, 32)
        Me.btnFileSave.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnFileSave.Name = "btnFileSave"
        Me.btnFileSave.Size = New System.Drawing.Size(46, 39)
        Me.btnFileSave.TabIndex = 0
        Me.btnFileSave.Text = "..."
        Me.btnFileSave.UseVisualStyleBackColor = true
        '
        'btnStart
        '
        Me.btnStart.AutoSize = true
        Me.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnStart.Location = New System.Drawing.Point(562, 395)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(68, 30)
        Me.btnStart.TabIndex = 17
        Me.btnStart.Text = "СТАРТ"
        Me.btnStart.UseVisualStyleBackColor = true
        '
        'frmTransData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 469)
        Me.Controls.Add(Me.grpRefreshFilePrice)
        Me.Controls.Add(Me.grpFindFilePrice)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grpDbName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmTransData"
        Me.Text = "TransData"
        Me.GroupBox1.ResumeLayout(false)
        Me.grpDbName.ResumeLayout(false)
        Me.grpFindFilePrice.ResumeLayout(false)
        Me.grpFindFilePrice.PerformLayout
        Me.grpRefreshFilePrice.ResumeLayout(false)
        Me.grpRefreshFilePrice.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbService As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpDbName As System.Windows.Forms.GroupBox
    Friend WithEvents btnFindFile As System.Windows.Forms.Button
    Friend WithEvents grpFindFilePrice As System.Windows.Forms.GroupBox
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grpRefreshFilePrice As System.Windows.Forms.GroupBox
    Friend WithEvents txtSaveFile As System.Windows.Forms.TextBox
    Friend WithEvents btnFileSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents btnStart As System.Windows.Forms.Button

End Class
