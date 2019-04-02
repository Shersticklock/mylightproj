<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigParam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigParam))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSQLpasword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSQLlogin = New System.Windows.Forms.TextBox()
        Me.cmbSelectServer = New System.Windows.Forms.ComboBox()
        Me.cmbDataBase = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAutentification = New System.Windows.Forms.ComboBox()
        Me.btnNewPassSQL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkTerminal = New System.Windows.Forms.CheckBox()
        Me.btnNewLogin = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.txtSQLpasword, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSQLlogin, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSelectServer, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbDataBase, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbAutentification, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNewPassSQL, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkTerminal, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNewLogin, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(504, 232)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtSQLpasword
        '
        Me.txtSQLpasword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSQLpasword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQLpasword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtSQLpasword.Location = New System.Drawing.Point(112, 84)
        Me.txtSQLpasword.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSQLpasword.Name = "txtSQLpasword"
        Me.txtSQLpasword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQLpasword.Size = New System.Drawing.Size(225, 26)
        Me.txtSQLpasword.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 38)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Логин"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSQLlogin
        '
        Me.txtSQLlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSQLlogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQLlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtSQLlogin.Location = New System.Drawing.Point(112, 46)
        Me.txtSQLlogin.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSQLlogin.Name = "txtSQLlogin"
        Me.txtSQLlogin.Size = New System.Drawing.Size(225, 26)
        Me.txtSQLlogin.TabIndex = 3
        '
        'cmbSelectServer
        '
        Me.cmbSelectServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSelectServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSelectServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSelectServer.FormattingEnabled = true
        Me.cmbSelectServer.Location = New System.Drawing.Point(112, 126)
        Me.cmbSelectServer.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbSelectServer.Name = "cmbSelectServer"
        Me.cmbSelectServer.Size = New System.Drawing.Size(225, 28)
        Me.cmbSelectServer.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.cmbSelectServer, "Сервер")
        '
        'cmbDataBase
        '
        Me.cmbDataBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDataBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDataBase.FormattingEnabled = true
        Me.cmbDataBase.Items.AddRange(New Object() {"MDM"})
        Me.cmbDataBase.Location = New System.Drawing.Point(112, 168)
        Me.cmbDataBase.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbDataBase.Name = "cmbDataBase"
        Me.cmbDataBase.Size = New System.Drawing.Size(225, 28)
        Me.cmbDataBase.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Проверка"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbAutentification
        '
        Me.cmbAutentification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAutentification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAutentification.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbAutentification.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbAutentification.Items.AddRange(New Object() {"Windows", "SQL Server"})
        Me.cmbAutentification.Location = New System.Drawing.Point(112, 6)
        Me.cmbAutentification.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbAutentification.Name = "cmbAutentification"
        Me.cmbAutentification.Size = New System.Drawing.Size(225, 28)
        Me.cmbAutentification.TabIndex = 1
        '
        'btnNewPassSQL
        '
        Me.btnNewPassSQL.AutoSize = true
        Me.btnNewPassSQL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNewPassSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNewPassSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPassSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnNewPassSQL.Location = New System.Drawing.Point(347, 84)
        Me.btnNewPassSQL.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnNewPassSQL.Name = "btnNewPassSQL"
        Me.btnNewPassSQL.Size = New System.Drawing.Size(152, 30)
        Me.btnNewPassSQL.TabIndex = 4
        Me.btnNewPassSQL.Text = "Новый пароль"
        Me.btnNewPassSQL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNewPassSQL.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 42)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Пароль"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 42)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Сервер"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 70)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "База данных"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOK
        '
        Me.btnOK.AutoSize = true
        Me.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnOK.Location = New System.Drawing.Point(347, 168)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(152, 58)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "Сохранить и выйти"
        Me.btnOK.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.AutoSize = true
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnExit.Location = New System.Drawing.Point(347, 126)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Отмена"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'chkTerminal
        '
        Me.chkTerminal.AutoSize = true
        Me.chkTerminal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkTerminal.Location = New System.Drawing.Point(345, 3)
        Me.chkTerminal.Name = "chkTerminal"
        Me.chkTerminal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTerminal.Size = New System.Drawing.Size(156, 34)
        Me.chkTerminal.TabIndex = 0
        Me.chkTerminal.Text = "Режим ""Терминал"""
        Me.chkTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTerminal.UseVisualStyleBackColor = true
        '
        'btnNewLogin
        '
        Me.btnNewLogin.AutoSize = true
        Me.btnNewLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNewLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNewLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnNewLogin.Location = New System.Drawing.Point(345, 43)
        Me.btnNewLogin.Name = "btnNewLogin"
        Me.btnNewLogin.Size = New System.Drawing.Size(156, 32)
        Me.btnNewLogin.TabIndex = 2
        Me.btnNewLogin.Text = "Новый логин"
        Me.btnNewLogin.UseVisualStyleBackColor = true
        Me.btnNewLogin.Visible = false
        '
        'frmConfigParam
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(504, 232)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(520, 287)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(520, 0)
        Me.Name = "frmConfigParam"
        Me.ShowInTaskbar = false
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Параметры подключения"
        Me.TopMost = true
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbSelectServer As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDataBase As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSQLlogin As System.Windows.Forms.TextBox
    Friend WithEvents txtSQLpasword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAutentification As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewPassSQL As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkTerminal As System.Windows.Forms.CheckBox
    Friend WithEvents btnNewLogin As System.Windows.Forms.Button
End Class
