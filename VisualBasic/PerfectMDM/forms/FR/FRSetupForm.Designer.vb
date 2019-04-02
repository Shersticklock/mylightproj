<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRSetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRSetupForm))
        Me.ConnectToFRCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectFRLabel = New System.Windows.Forms.Label()
        Me.SelectFRComboBox = New System.Windows.Forms.ComboBox()
        Me.TCPConnectionCheckBox = New System.Windows.Forms.CheckBox()
        Me.CheckConnectionButton = New System.Windows.Forms.Button()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'ConnectToFRCheckBox
        '
        Me.ConnectToFRCheckBox.AutoSize = true
        Me.ConnectToFRCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectToFRCheckBox.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ConnectToFRCheckBox.Location = New System.Drawing.Point(13, 13)
        Me.ConnectToFRCheckBox.Name = "ConnectToFRCheckBox"
        Me.ConnectToFRCheckBox.Size = New System.Drawing.Size(137, 20)
        Me.ConnectToFRCheckBox.TabIndex = 0
        Me.ConnectToFRCheckBox.Text = "Подключение ФР"
        Me.ConnectToFRCheckBox.UseVisualStyleBackColor = true
        '
        'SelectFRLabel
        '
        Me.SelectFRLabel.AutoSize = true
        Me.SelectFRLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.SelectFRLabel.Location = New System.Drawing.Point(9, 53)
        Me.SelectFRLabel.Name = "SelectFRLabel"
        Me.SelectFRLabel.Size = New System.Drawing.Size(97, 16)
        Me.SelectFRLabel.TabIndex = 1
        Me.SelectFRLabel.Text = "Выберите ФР:"
        '
        'SelectFRComboBox
        '
        Me.SelectFRComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectFRComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectFRComboBox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.SelectFRComboBox.FormattingEnabled = true
        Me.SelectFRComboBox.Location = New System.Drawing.Point(12, 81)
        Me.SelectFRComboBox.Name = "SelectFRComboBox"
        Me.SelectFRComboBox.Size = New System.Drawing.Size(298, 25)
        Me.SelectFRComboBox.TabIndex = 2
        '
        'TCPConnectionCheckBox
        '
        Me.TCPConnectionCheckBox.AutoSize = true
        Me.TCPConnectionCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TCPConnectionCheckBox.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TCPConnectionCheckBox.Location = New System.Drawing.Point(13, 127)
        Me.TCPConnectionCheckBox.Name = "TCPConnectionCheckBox"
        Me.TCPConnectionCheckBox.Size = New System.Drawing.Size(162, 20)
        Me.TCPConnectionCheckBox.TabIndex = 3
        Me.TCPConnectionCheckBox.Text = "Подключение по TCP"
        Me.TCPConnectionCheckBox.UseVisualStyleBackColor = true
        '
        'CheckConnectionButton
        '
        Me.CheckConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckConnectionButton.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CheckConnectionButton.Location = New System.Drawing.Point(13, 173)
        Me.CheckConnectionButton.Name = "CheckConnectionButton"
        Me.CheckConnectionButton.Size = New System.Drawing.Size(245, 30)
        Me.CheckConnectionButton.TabIndex = 4
        Me.CheckConnectionButton.Text = "Проверить подключение"
        Me.CheckConnectionButton.UseVisualStyleBackColor = true
        '
        'MessageTextBox
        '
        Me.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageTextBox.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.MessageTextBox.Location = New System.Drawing.Point(12, 219)
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.ReadOnly = true
        Me.MessageTextBox.Size = New System.Drawing.Size(298, 22)
        Me.MessageTextBox.TabIndex = 5
        '
        'FRSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 255)
        Me.Controls.Add(Me.MessageTextBox)
        Me.Controls.Add(Me.CheckConnectionButton)
        Me.Controls.Add(Me.TCPConnectionCheckBox)
        Me.Controls.Add(Me.SelectFRComboBox)
        Me.Controls.Add(Me.SelectFRLabel)
        Me.Controls.Add(Me.ConnectToFRCheckBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FRSetupForm"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Настройка ФР"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ConnectToFRCheckBox As CheckBox
    Friend WithEvents SelectFRLabel As Label
    Friend WithEvents SelectFRComboBox As ComboBox
    Friend WithEvents TCPConnectionCheckBox As CheckBox
    Friend WithEvents CheckConnectionButton As Button
    Friend WithEvents MessageTextBox As TextBox
End Class
