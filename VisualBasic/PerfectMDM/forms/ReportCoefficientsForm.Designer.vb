<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportCoefficientsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportCoefficientsForm))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpDutyManagerSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDutyManagerHeader = New System.Windows.Forms.Label()
        Me.lblK1DutyManager = New System.Windows.Forms.Label()
        Me.lblK2DutyManager = New System.Windows.Forms.Label()
        Me.lblK3DutyManager = New System.Windows.Forms.Label()
        Me.btnSaveDutyManagerSettings = New System.Windows.Forms.Button()
        Me.txtK3DutyManager = New System.Windows.Forms.TextBox()
        Me.txtK2DutyManager = New System.Windows.Forms.TextBox()
        Me.txtK1DutyManager = New System.Windows.Forms.TextBox()
        Me.tlpOperatorSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.txtK1Operator = New System.Windows.Forms.TextBox()
        Me.txtK2Operator = New System.Windows.Forms.TextBox()
        Me.txtK3Operator = New System.Windows.Forms.TextBox()
        Me.btnSaveOperatorSettings = New System.Windows.Forms.Button()
        Me.lblOperatorHeader = New System.Windows.Forms.Label()
        Me.lblK1Operator = New System.Windows.Forms.Label()
        Me.lblK2Operator = New System.Windows.Forms.Label()
        Me.lblK3Operator = New System.Windows.Forms.Label()
        Me.tlpMain.SuspendLayout
        Me.tlpDutyManagerSettings.SuspendLayout
        Me.tlpOperatorSettings.SuspendLayout
        Me.SuspendLayout
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpMain.Controls.Add(Me.tlpDutyManagerSettings, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpOperatorSettings, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(6)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpMain.Size = New System.Drawing.Size(430, 458)
        Me.tlpMain.TabIndex = 0
        '
        'tlpDutyManagerSettings
        '
        Me.tlpDutyManagerSettings.ColumnCount = 3
        Me.tlpDutyManagerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpDutyManagerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlpDutyManagerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlpDutyManagerSettings.Controls.Add(Me.lblDutyManagerHeader, 0, 0)
        Me.tlpDutyManagerSettings.Controls.Add(Me.lblK1DutyManager, 0, 1)
        Me.tlpDutyManagerSettings.Controls.Add(Me.lblK2DutyManager, 0, 2)
        Me.tlpDutyManagerSettings.Controls.Add(Me.lblK3DutyManager, 0, 3)
        Me.tlpDutyManagerSettings.Controls.Add(Me.btnSaveDutyManagerSettings, 2, 4)
        Me.tlpDutyManagerSettings.Controls.Add(Me.txtK3DutyManager, 1, 3)
        Me.tlpDutyManagerSettings.Controls.Add(Me.txtK2DutyManager, 1, 2)
        Me.tlpDutyManagerSettings.Controls.Add(Me.txtK1DutyManager, 1, 1)
        Me.tlpDutyManagerSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDutyManagerSettings.Location = New System.Drawing.Point(3, 3)
        Me.tlpDutyManagerSettings.Name = "tlpDutyManagerSettings"
        Me.tlpDutyManagerSettings.RowCount = 5
        Me.tlpDutyManagerSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpDutyManagerSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpDutyManagerSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpDutyManagerSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpDutyManagerSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpDutyManagerSettings.Size = New System.Drawing.Size(424, 223)
        Me.tlpDutyManagerSettings.TabIndex = 0
        '
        'lblDutyManagerHeader
        '
        Me.lblDutyManagerHeader.AutoSize = true
        Me.tlpDutyManagerSettings.SetColumnSpan(Me.lblDutyManagerHeader, 3)
        Me.lblDutyManagerHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDutyManagerHeader.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDutyManagerHeader.Location = New System.Drawing.Point(15, 0)
        Me.lblDutyManagerHeader.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblDutyManagerHeader.Name = "lblDutyManagerHeader"
        Me.lblDutyManagerHeader.Size = New System.Drawing.Size(406, 44)
        Me.lblDutyManagerHeader.TabIndex = 0
        Me.lblDutyManagerHeader.Text = "Отчет для дежурного менеджера"
        Me.lblDutyManagerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblK1DutyManager
        '
        Me.lblK1DutyManager.AutoSize = true
        Me.lblK1DutyManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblK1DutyManager.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblK1DutyManager.Location = New System.Drawing.Point(15, 44)
        Me.lblK1DutyManager.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblK1DutyManager.Name = "lblK1DutyManager"
        Me.lblK1DutyManager.Size = New System.Drawing.Size(123, 44)
        Me.lblK1DutyManager.TabIndex = 1
        Me.lblK1DutyManager.Text = "k1 (созд.)"
        Me.lblK1DutyManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblK2DutyManager
        '
        Me.lblK2DutyManager.AutoSize = true
        Me.lblK2DutyManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblK2DutyManager.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblK2DutyManager.Location = New System.Drawing.Point(15, 88)
        Me.lblK2DutyManager.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblK2DutyManager.Name = "lblK2DutyManager"
        Me.lblK2DutyManager.Size = New System.Drawing.Size(123, 44)
        Me.lblK2DutyManager.TabIndex = 2
        Me.lblK2DutyManager.Text = "k2 (менедж.) "
        Me.lblK2DutyManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblK3DutyManager
        '
        Me.lblK3DutyManager.AutoSize = true
        Me.lblK3DutyManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblK3DutyManager.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblK3DutyManager.Location = New System.Drawing.Point(15, 132)
        Me.lblK3DutyManager.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblK3DutyManager.Name = "lblK3DutyManager"
        Me.lblK3DutyManager.Size = New System.Drawing.Size(123, 44)
        Me.lblK3DutyManager.TabIndex = 3
        Me.lblK3DutyManager.Text = "k3 (БЗ)"
        Me.lblK3DutyManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSaveDutyManagerSettings
        '
        Me.btnSaveDutyManagerSettings.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSaveDutyManagerSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveDutyManagerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveDutyManagerSettings.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSaveDutyManagerSettings.Location = New System.Drawing.Point(288, 182)
        Me.btnSaveDutyManagerSettings.Margin = New System.Windows.Forms.Padding(6, 6, 6, 9)
        Me.btnSaveDutyManagerSettings.Name = "btnSaveDutyManagerSettings"
        Me.btnSaveDutyManagerSettings.Size = New System.Drawing.Size(130, 32)
        Me.btnSaveDutyManagerSettings.TabIndex = 4
        Me.btnSaveDutyManagerSettings.Text = "Сохранить"
        Me.btnSaveDutyManagerSettings.UseVisualStyleBackColor = false
        '
        'txtK3DutyManager
        '
        Me.txtK3DutyManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpDutyManagerSettings.SetColumnSpan(Me.txtK3DutyManager, 2)
        Me.txtK3DutyManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtK3DutyManager.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtK3DutyManager.Location = New System.Drawing.Point(144, 141)
        Me.txtK3DutyManager.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.txtK3DutyManager.Name = "txtK3DutyManager"
        Me.txtK3DutyManager.Size = New System.Drawing.Size(277, 27)
        Me.txtK3DutyManager.TabIndex = 5
        '
        'txtK2DutyManager
        '
        Me.txtK2DutyManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpDutyManagerSettings.SetColumnSpan(Me.txtK2DutyManager, 2)
        Me.txtK2DutyManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtK2DutyManager.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtK2DutyManager.Location = New System.Drawing.Point(144, 97)
        Me.txtK2DutyManager.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.txtK2DutyManager.Name = "txtK2DutyManager"
        Me.txtK2DutyManager.Size = New System.Drawing.Size(277, 27)
        Me.txtK2DutyManager.TabIndex = 6
        '
        'txtK1DutyManager
        '
        Me.txtK1DutyManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpDutyManagerSettings.SetColumnSpan(Me.txtK1DutyManager, 2)
        Me.txtK1DutyManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtK1DutyManager.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtK1DutyManager.Location = New System.Drawing.Point(144, 53)
        Me.txtK1DutyManager.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.txtK1DutyManager.Name = "txtK1DutyManager"
        Me.txtK1DutyManager.Size = New System.Drawing.Size(277, 27)
        Me.txtK1DutyManager.TabIndex = 7
        '
        'tlpOperatorSettings
        '
        Me.tlpOperatorSettings.ColumnCount = 3
        Me.tlpOperatorSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpOperatorSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpOperatorSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpOperatorSettings.Controls.Add(Me.txtK1Operator, 1, 1)
        Me.tlpOperatorSettings.Controls.Add(Me.txtK2Operator, 1, 2)
        Me.tlpOperatorSettings.Controls.Add(Me.txtK3Operator, 1, 3)
        Me.tlpOperatorSettings.Controls.Add(Me.btnSaveOperatorSettings, 2, 4)
        Me.tlpOperatorSettings.Controls.Add(Me.lblOperatorHeader, 0, 0)
        Me.tlpOperatorSettings.Controls.Add(Me.lblK1Operator, 0, 1)
        Me.tlpOperatorSettings.Controls.Add(Me.lblK2Operator, 0, 2)
        Me.tlpOperatorSettings.Controls.Add(Me.lblK3Operator, 0, 3)
        Me.tlpOperatorSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOperatorSettings.Location = New System.Drawing.Point(3, 232)
        Me.tlpOperatorSettings.Name = "tlpOperatorSettings"
        Me.tlpOperatorSettings.RowCount = 5
        Me.tlpOperatorSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpOperatorSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpOperatorSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpOperatorSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpOperatorSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpOperatorSettings.Size = New System.Drawing.Size(424, 223)
        Me.tlpOperatorSettings.TabIndex = 1
        '
        'txtK1Operator
        '
        Me.tlpOperatorSettings.SetColumnSpan(Me.txtK1Operator, 2)
        Me.txtK1Operator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtK1Operator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtK1Operator.Location = New System.Drawing.Point(144, 53)
        Me.txtK1Operator.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.txtK1Operator.Name = "txtK1Operator"
        Me.txtK1Operator.Size = New System.Drawing.Size(277, 27)
        Me.txtK1Operator.TabIndex = 0
        '
        'txtK2Operator
        '
        Me.tlpOperatorSettings.SetColumnSpan(Me.txtK2Operator, 2)
        Me.txtK2Operator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtK2Operator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtK2Operator.Location = New System.Drawing.Point(144, 97)
        Me.txtK2Operator.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.txtK2Operator.Name = "txtK2Operator"
        Me.txtK2Operator.Size = New System.Drawing.Size(277, 27)
        Me.txtK2Operator.TabIndex = 1
        '
        'txtK3Operator
        '
        Me.tlpOperatorSettings.SetColumnSpan(Me.txtK3Operator, 2)
        Me.txtK3Operator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtK3Operator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtK3Operator.Location = New System.Drawing.Point(144, 141)
        Me.txtK3Operator.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.txtK3Operator.Name = "txtK3Operator"
        Me.txtK3Operator.Size = New System.Drawing.Size(277, 27)
        Me.txtK3Operator.TabIndex = 2
        '
        'btnSaveOperatorSettings
        '
        Me.btnSaveOperatorSettings.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSaveOperatorSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveOperatorSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveOperatorSettings.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSaveOperatorSettings.Location = New System.Drawing.Point(288, 182)
        Me.btnSaveOperatorSettings.Margin = New System.Windows.Forms.Padding(6, 6, 6, 9)
        Me.btnSaveOperatorSettings.Name = "btnSaveOperatorSettings"
        Me.btnSaveOperatorSettings.Size = New System.Drawing.Size(130, 32)
        Me.btnSaveOperatorSettings.TabIndex = 3
        Me.btnSaveOperatorSettings.Text = "Сохранить"
        Me.btnSaveOperatorSettings.UseVisualStyleBackColor = false
        '
        'lblOperatorHeader
        '
        Me.lblOperatorHeader.AutoSize = true
        Me.tlpOperatorSettings.SetColumnSpan(Me.lblOperatorHeader, 3)
        Me.lblOperatorHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOperatorHeader.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblOperatorHeader.Location = New System.Drawing.Point(15, 0)
        Me.lblOperatorHeader.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblOperatorHeader.Name = "lblOperatorHeader"
        Me.lblOperatorHeader.Size = New System.Drawing.Size(406, 44)
        Me.lblOperatorHeader.TabIndex = 4
        Me.lblOperatorHeader.Text = "Отчет для операторов"
        Me.lblOperatorHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblK1Operator
        '
        Me.lblK1Operator.AutoSize = true
        Me.lblK1Operator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblK1Operator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblK1Operator.Location = New System.Drawing.Point(15, 44)
        Me.lblK1Operator.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblK1Operator.Name = "lblK1Operator"
        Me.lblK1Operator.Size = New System.Drawing.Size(123, 44)
        Me.lblK1Operator.TabIndex = 5
        Me.lblK1Operator.Text = "k1 (БЗ)"
        Me.lblK1Operator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblK2Operator
        '
        Me.lblK2Operator.AutoSize = true
        Me.lblK2Operator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblK2Operator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblK2Operator.Location = New System.Drawing.Point(15, 88)
        Me.lblK2Operator.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblK2Operator.Name = "lblK2Operator"
        Me.lblK2Operator.Size = New System.Drawing.Size(123, 44)
        Me.lblK2Operator.TabIndex = 6
        Me.lblK2Operator.Text = "k2 (выполнено)"
        Me.lblK2Operator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblK3Operator
        '
        Me.lblK3Operator.AutoSize = true
        Me.lblK3Operator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblK3Operator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblK3Operator.Location = New System.Drawing.Point(15, 132)
        Me.lblK3Operator.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblK3Operator.Name = "lblK3Operator"
        Me.lblK3Operator.Size = New System.Drawing.Size(123, 44)
        Me.lblK3Operator.TabIndex = 7
        Me.lblK3Operator.Text = "k3 (принято)"
        Me.lblK3Operator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReportCoefficientsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 458)
        Me.Controls.Add(Me.tlpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "ReportCoefficientsForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Задать коэффициенты для отчетов"
        Me.tlpMain.ResumeLayout(false)
        Me.tlpDutyManagerSettings.ResumeLayout(false)
        Me.tlpDutyManagerSettings.PerformLayout
        Me.tlpOperatorSettings.ResumeLayout(false)
        Me.tlpOperatorSettings.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpDutyManagerSettings As TableLayoutPanel
    Friend WithEvents lblDutyManagerHeader As Label
    Friend WithEvents lblK1DutyManager As Label
    Friend WithEvents lblK2DutyManager As Label
    Friend WithEvents lblK3DutyManager As Label
    Friend WithEvents btnSaveDutyManagerSettings As Button
    Friend WithEvents txtK3DutyManager As TextBox
    Friend WithEvents txtK2DutyManager As TextBox
    Friend WithEvents txtK1DutyManager As TextBox
    Friend WithEvents tlpOperatorSettings As TableLayoutPanel
    Friend WithEvents txtK1Operator As TextBox
    Friend WithEvents txtK2Operator As TextBox
    Friend WithEvents txtK3Operator As TextBox
    Friend WithEvents btnSaveOperatorSettings As Button
    Friend WithEvents lblOperatorHeader As Label
    Friend WithEvents lblK1Operator As Label
    Friend WithEvents lblK2Operator As Label
    Friend WithEvents lblK3Operator As Label
End Class
