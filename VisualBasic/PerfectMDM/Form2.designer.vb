<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.CrystalClearThemeContainer1 = New PerfectCRM.CrystalClearThemeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalClearProgressBar1 = New PerfectCRM.CrystalClearProgressBar()
        Me.CrystalClearButton1 = New PerfectCRM.CrystalClearButton()
        Me.CrystalClearThemeContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'CrystalClearThemeContainer1
        '
        Me.CrystalClearThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(230,Byte),Integer))
        Me.CrystalClearThemeContainer1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.CrystalClearThemeContainer1.Controls.Add(Me.Label1)
        Me.CrystalClearThemeContainer1.Controls.Add(Me.CrystalClearProgressBar1)
        Me.CrystalClearThemeContainer1.Controls.Add(Me.CrystalClearButton1)
        Me.CrystalClearThemeContainer1.Customization = "5ubm/9LS0v/m5ub/5ubm/6qqqv8="
        Me.CrystalClearThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalClearThemeContainer1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CrystalClearThemeContainer1.Image = Nothing
        Me.CrystalClearThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalClearThemeContainer1.MinimumSize = New System.Drawing.Size(175, 150)
        Me.CrystalClearThemeContainer1.Movable = true
        Me.CrystalClearThemeContainer1.Name = "CrystalClearThemeContainer1"
        Me.CrystalClearThemeContainer1.NoRounding = false
        Me.CrystalClearThemeContainer1.Rounding = PerfectCRM.CrystalClearThemeContainer.RoundingType.None
        Me.CrystalClearThemeContainer1.Sizable = true
        Me.CrystalClearThemeContainer1.Size = New System.Drawing.Size(271, 172)
        Me.CrystalClearThemeContainer1.SmartBounds = true
        Me.CrystalClearThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.CrystalClearThemeContainer1.TabIndex = 0
        Me.CrystalClearThemeContainer1.Text = "CrystalClearThemeContainer1"
        Me.CrystalClearThemeContainer1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CrystalClearThemeContainer1.Transparent = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(18, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Пример всплывающего окна"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"             PERFECT"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"             mediasoft.su"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CrystalClearProgressBar1
        '
        Me.CrystalClearProgressBar1.Animated = true
        Me.CrystalClearProgressBar1.Customization = "5ubm/9LS0v/m5ub/qqqq/w=="
        Me.CrystalClearProgressBar1.Font = New System.Drawing.Font("Verdana", 8!)
        Me.CrystalClearProgressBar1.Image = Nothing
        Me.CrystalClearProgressBar1.Location = New System.Drawing.Point(13, 103)
        Me.CrystalClearProgressBar1.Maximum = 100
        Me.CrystalClearProgressBar1.Minimum = 0
        Me.CrystalClearProgressBar1.Name = "CrystalClearProgressBar1"
        Me.CrystalClearProgressBar1.NoRounding = false
        Me.CrystalClearProgressBar1.Size = New System.Drawing.Size(245, 26)
        Me.CrystalClearProgressBar1.TabIndex = 1
        Me.CrystalClearProgressBar1.Text = "CrystalClearProgressBar1"
        Me.CrystalClearProgressBar1.Transparent = false
        Me.CrystalClearProgressBar1.Value = 100
        '
        'CrystalClearButton1
        '
        Me.CrystalClearButton1.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.CrystalClearButton1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CrystalClearButton1.Image = Nothing
        Me.CrystalClearButton1.Location = New System.Drawing.Point(13, 135)
        Me.CrystalClearButton1.Name = "CrystalClearButton1"
        Me.CrystalClearButton1.NoRounding = false
        Me.CrystalClearButton1.Size = New System.Drawing.Size(245, 25)
        Me.CrystalClearButton1.TabIndex = 0
        Me.CrystalClearButton1.Text = "Закрыть"
        Me.CrystalClearButton1.Transparent = false
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 172)
        Me.Controls.Add(Me.CrystalClearThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "Form2"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.Text = "Всплывающее окно!"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CrystalClearThemeContainer1.ResumeLayout(false)
        Me.CrystalClearThemeContainer1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents CrystalClearThemeContainer1 As CrystalClearThemeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalClearProgressBar1 As CrystalClearProgressBar
    Friend WithEvents CrystalClearButton1 As CrystalClearButton
End Class
