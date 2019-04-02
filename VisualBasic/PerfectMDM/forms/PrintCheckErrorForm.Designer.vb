<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintCheckErrorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintCheckErrorForm))
        Me.ResumePrintButton = New System.Windows.Forms.Button()
        Me.CancelCheckButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResumePrintButton
        '
        Me.ResumePrintButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ResumePrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResumePrintButton.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ResumePrintButton.Location = New System.Drawing.Point(12, 65)
        Me.ResumePrintButton.Name = "ResumePrintButton"
        Me.ResumePrintButton.Size = New System.Drawing.Size(170, 30)
        Me.ResumePrintButton.TabIndex = 0
        Me.ResumePrintButton.Text = "Продолжить печать"
        Me.ResumePrintButton.UseVisualStyleBackColor = False
        '
        'CancelCheckButton
        '
        Me.CancelCheckButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelCheckButton.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CancelCheckButton.Location = New System.Drawing.Point(206, 65)
        Me.CancelCheckButton.Name = "CancelCheckButton"
        Me.CancelCheckButton.Size = New System.Drawing.Size(170, 30)
        Me.CancelCheckButton.TabIndex = 1
        Me.CancelCheckButton.Text = "Отмена чека"
        Me.CancelCheckButton.UseVisualStyleBackColor = False
        '
        'PrintCheckErrorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 180)
        Me.Controls.Add(Me.CancelCheckButton)
        Me.Controls.Add(Me.ResumePrintButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PrintCheckErrorForm"
        Me.ShowIcon = False
        Me.Text = "Ошибка печати чека"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ResumePrintButton As Button
    Friend WithEvents CancelCheckButton As Button
End Class
