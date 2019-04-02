<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSsender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSsender))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtxtMobTel = New System.Windows.Forms.MaskedTextBox()
        Me.cmbTemplateSMS = New System.Windows.Forms.ComboBox()
        Me.txtNewTemplareSMS = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnSend = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSaveTemplate = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSendAll = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgDataTable = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        CType(Me.dgDataTable,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.35439!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.64561!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.mtxtMobTel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTemplateSMS, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNewTemplareSMS, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMessage, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.dgDataTable, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnUpdate, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1125, 646)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 266)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Телефон"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 296)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Выбор шаблона"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 327)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Название шаблона"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mtxtMobTel
        '
        Me.mtxtMobTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtxtMobTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtxtMobTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.mtxtMobTel.Location = New System.Drawing.Point(345, 269)
        Me.mtxtMobTel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mtxtMobTel.Name = "mtxtMobTel"
        Me.mtxtMobTel.Size = New System.Drawing.Size(776, 24)
        Me.mtxtMobTel.TabIndex = 3
        '
        'cmbTemplateSMS
        '
        Me.cmbTemplateSMS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTemplateSMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTemplateSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTemplateSMS.FormattingEnabled = true
        Me.cmbTemplateSMS.Location = New System.Drawing.Point(345, 299)
        Me.cmbTemplateSMS.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbTemplateSMS.Name = "cmbTemplateSMS"
        Me.cmbTemplateSMS.Size = New System.Drawing.Size(776, 25)
        Me.cmbTemplateSMS.TabIndex = 4
        '
        'txtNewTemplareSMS
        '
        Me.txtNewTemplareSMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewTemplareSMS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNewTemplareSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNewTemplareSMS.Location = New System.Drawing.Point(345, 330)
        Me.txtNewTemplareSMS.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNewTemplareSMS.Name = "txtNewTemplareSMS"
        Me.txtNewTemplareSMS.Size = New System.Drawing.Size(776, 24)
        Me.txtNewTemplareSMS.TabIndex = 5
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtMessage.Location = New System.Drawing.Point(345, 360)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMessage.Multiline = true
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(776, 258)
        Me.txtMessage.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 357)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(333, 264)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Текст SMS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnSend, Me.tsbtnSaveTemplate, Me.tsbtnSendAll})
        Me.ToolStrip1.Location = New System.Drawing.Point(341, 621)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnSend
        '
        Me.tsbtnSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSend.Image = CType(resources.GetObject("tsbtnSend.Image"),System.Drawing.Image)
        Me.tsbtnSend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSend.Name = "tsbtnSend"
        Me.tsbtnSend.Size = New System.Drawing.Size(86, 22)
        Me.tsbtnSend.Text = "Отправить"
        '
        'tsbtnSaveTemplate
        '
        Me.tsbtnSaveTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSaveTemplate.Image = CType(resources.GetObject("tsbtnSaveTemplate.Image"),System.Drawing.Image)
        Me.tsbtnSaveTemplate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSaveTemplate.Name = "tsbtnSaveTemplate"
        Me.tsbtnSaveTemplate.Size = New System.Drawing.Size(144, 22)
        Me.tsbtnSaveTemplate.Text = "Сохранить шаблон"
        '
        'tsbtnSendAll
        '
        Me.tsbtnSendAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSendAll.Image = CType(resources.GetObject("tsbtnSendAll.Image"),System.Drawing.Image)
        Me.tsbtnSendAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSendAll.Name = "tsbtnSendAll"
        Me.tsbtnSendAll.Size = New System.Drawing.Size(197, 22)
        Me.tsbtnSendAll.Text = "Отправить всем из списка"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 621)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(333, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Кол-во SMS-"
        '
        'dgDataTable
        '
        Me.dgDataTable.AllowUserToAddRows = false
        Me.dgDataTable.AllowUserToResizeRows = false
        Me.dgDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDataTable.Location = New System.Drawing.Point(346, 6)
        Me.dgDataTable.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgDataTable.Name = "dgDataTable"
        Me.dgDataTable.Size = New System.Drawing.Size(774, 254)
        Me.dgDataTable.TabIndex = 10
        '
        'btnUpdate
        '
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(5, 6)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(331, 254)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Отобразить не оплаченные готовые заказы"
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'frmSMSsender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 646)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmSMSsender"
        Me.Text = "frmSMSsender"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.dgDataTable,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mtxtMobTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbTemplateSMS As System.Windows.Forms.ComboBox
    Friend WithEvents txtNewTemplareSMS As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSend As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSaveTemplate As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tsbtnSendAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgDataTable As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
