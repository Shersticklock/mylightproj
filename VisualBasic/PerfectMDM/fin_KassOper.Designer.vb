<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin_KassOper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fin_KassOper))
        Me.CancelCheckButton = New System.Windows.Forms.Button()
        Me.PrintZReportButton = New System.Windows.Forms.Button()
        Me.PrintXReportButton = New System.Windows.Forms.Button()
        Me.PuncheredButton = New System.Windows.Forms.Button()
        Me.PuncheredTextBox = New System.Windows.Forms.TextBox()
        Me.RequestStateButton = New System.Windows.Forms.Button()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CancelCheckButton
        '
        Me.CancelCheckButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelCheckButton.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CancelCheckButton.Location = New System.Drawing.Point(13, 69)
        Me.CancelCheckButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelCheckButton.Name = "CancelCheckButton"
        Me.CancelCheckButton.Size = New System.Drawing.Size(144, 79)
        Me.CancelCheckButton.TabIndex = 8
        Me.CancelCheckButton.Text = "Отменить чек"
        Me.CancelCheckButton.UseVisualStyleBackColor = False
        '
        'PrintZReportButton
        '
        Me.PrintZReportButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PrintZReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintZReportButton.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PrintZReportButton.Location = New System.Drawing.Point(355, 69)
        Me.PrintZReportButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintZReportButton.Name = "PrintZReportButton"
        Me.PrintZReportButton.Size = New System.Drawing.Size(144, 79)
        Me.PrintZReportButton.TabIndex = 7
        Me.PrintZReportButton.Text = "Закрыть смену"
        Me.PrintZReportButton.UseVisualStyleBackColor = False
        '
        'PrintXReportButton
        '
        Me.PrintXReportButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PrintXReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintXReportButton.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PrintXReportButton.Location = New System.Drawing.Point(183, 69)
        Me.PrintXReportButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintXReportButton.Name = "PrintXReportButton"
        Me.PrintXReportButton.Size = New System.Drawing.Size(144, 79)
        Me.PrintXReportButton.TabIndex = 1
        Me.PrintXReportButton.Text = "Печатать Х-отчет"
        Me.PrintXReportButton.UseVisualStyleBackColor = False
        '
        'PuncheredButton
        '
        Me.PuncheredButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PuncheredButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PuncheredButton.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PuncheredButton.Location = New System.Drawing.Point(13, 13)
        Me.PuncheredButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PuncheredButton.Name = "PuncheredButton"
        Me.PuncheredButton.Size = New System.Drawing.Size(172, 31)
        Me.PuncheredButton.TabIndex = 0
        Me.PuncheredButton.Text = "Пробито за смену"
        Me.PuncheredButton.UseVisualStyleBackColor = False
        '
        'PuncheredTextBox
        '
        Me.PuncheredTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PuncheredTextBox.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PuncheredTextBox.Location = New System.Drawing.Point(211, 13)
        Me.PuncheredTextBox.Name = "PuncheredTextBox"
        Me.PuncheredTextBox.Size = New System.Drawing.Size(288, 29)
        Me.PuncheredTextBox.TabIndex = 9
        Me.PuncheredTextBox.Text = "0.0"
        '
        'RequestStateButton
        '
        Me.RequestStateButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RequestStateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RequestStateButton.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RequestStateButton.Location = New System.Drawing.Point(13, 174)
        Me.RequestStateButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RequestStateButton.Name = "RequestStateButton"
        Me.RequestStateButton.Size = New System.Drawing.Size(172, 31)
        Me.RequestStateButton.TabIndex = 10
        Me.RequestStateButton.Text = "Запрос состояния"
        Me.RequestStateButton.UseVisualStyleBackColor = False
        '
        'StateTextBox
        '
        Me.StateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StateTextBox.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(211, 174)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(288, 29)
        Me.StateTextBox.TabIndex = 11
        '
        'ResultTextBox
        '
        Me.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultTextBox.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ResultTextBox.Location = New System.Drawing.Point(13, 225)
        Me.ResultTextBox.Multiline = True
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ResultTextBox.Size = New System.Drawing.Size(486, 195)
        Me.ResultTextBox.TabIndex = 12
        '
        'fin_KassOper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 432)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.RequestStateButton)
        Me.Controls.Add(Me.PuncheredTextBox)
        Me.Controls.Add(Me.PrintXReportButton)
        Me.Controls.Add(Me.PuncheredButton)
        Me.Controls.Add(Me.PrintZReportButton)
        Me.Controls.Add(Me.CancelCheckButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "fin_KassOper"
        Me.Text = "Работа с ФР"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintZReportButton As System.Windows.Forms.Button
    Friend WithEvents PrintXReportButton As System.Windows.Forms.Button
    Friend WithEvents PuncheredButton As System.Windows.Forms.Button
    Friend WithEvents CancelCheckButton As System.Windows.Forms.Button
    Friend WithEvents PuncheredTextBox As TextBox
    Friend WithEvents RequestStateButton As Button
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ResultTextBox As TextBox
End Class
