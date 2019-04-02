Imports System.IO

Public Class frmEmplKA
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lstPerson As System.Windows.Forms.ListBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tlpContact As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents txticq As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtemailEmpl As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttelEmpl As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tsCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPost As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtlastName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents НетЭлПочтыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTelMob As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSkype As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkSendSMS As System.Windows.Forms.CheckBox
    Friend WithEvents chkSendMail As System.Windows.Forms.CheckBox
    Friend WithEvents btnSendPass As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmplKA))
        Me.lstPerson = New System.Windows.Forms.ListBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tlpContact = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlastName = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txticq = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtemailEmpl = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.НетЭлПочтыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.txtTelMob = New System.Windows.Forms.MaskedTextBox()
        Me.txttelEmpl = New System.Windows.Forms.TextBox()
        Me.txtSkype = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkSendSMS = New System.Windows.Forms.CheckBox()
        Me.chkSendMail = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSendPass = New System.Windows.Forms.Button()
        Me.tsCompany = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tlpContact.SuspendLayout
        Me.ContextMenuStrip1.SuspendLayout
        Me.tsCompany.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'lstPerson
        '
        Me.lstPerson.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstPerson.HorizontalScrollbar = true
        Me.lstPerson.ItemHeight = 17
        Me.lstPerson.Location = New System.Drawing.Point(3, 3)
        Me.lstPerson.Name = "lstPerson"
        Me.lstPerson.Size = New System.Drawing.Size(404, 327)
        Me.lstPerson.TabIndex = 0
        Me.lstPerson.TabStop = false
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        '
        'tlpContact
        '
        Me.tlpContact.AutoSize = true
        Me.tlpContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpContact.ColumnCount = 2
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpContact.Controls.Add(Me.Label7, 0, 0)
        Me.tlpContact.Controls.Add(Me.txtlastName, 1, 0)
        Me.tlpContact.Controls.Add(Me.txtAdress, 1, 7)
        Me.tlpContact.Controls.Add(Me.txticq, 1, 5)
        Me.tlpContact.Controls.Add(Me.Label17, 0, 7)
        Me.tlpContact.Controls.Add(Me.txtemailEmpl, 1, 6)
        Me.tlpContact.Controls.Add(Me.Label22, 0, 5)
        Me.tlpContact.Controls.Add(Me.Label6, 0, 4)
        Me.tlpContact.Controls.Add(Me.Label2, 0, 2)
        Me.tlpContact.Controls.Add(Me.Label8, 0, 6)
        Me.tlpContact.Controls.Add(Me.Label5, 0, 1)
        Me.tlpContact.Controls.Add(Me.txtPost, 1, 1)
        Me.tlpContact.Controls.Add(Me.txtTelMob, 1, 3)
        Me.tlpContact.Controls.Add(Me.txttelEmpl, 1, 2)
        Me.tlpContact.Controls.Add(Me.txtSkype, 1, 4)
        Me.tlpContact.Controls.Add(Me.Label11, 0, 3)
        Me.tlpContact.Controls.Add(Me.chkSendSMS, 0, 8)
        Me.tlpContact.Controls.Add(Me.chkSendMail, 0, 9)
        Me.tlpContact.Controls.Add(Me.Button1, 1, 10)
        Me.tlpContact.Controls.Add(Me.btnSendPass, 0, 10)
        Me.tlpContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpContact.Location = New System.Drawing.Point(413, 3)
        Me.tlpContact.Name = "tlpContact"
        Me.tlpContact.RowCount = 11
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16!))
        Me.tlpContact.Size = New System.Drawing.Size(523, 357)
        Me.tlpContact.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 30)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "ФИО"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtlastName
        '
        Me.txtlastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtlastName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtlastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtlastName.Location = New System.Drawing.Point(212, 3)
        Me.txtlastName.Name = "txtlastName"
        Me.txtlastName.Size = New System.Drawing.Size(308, 24)
        Me.txtlastName.TabIndex = 0
        '
        'txtAdress
        '
        Me.txtAdress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdress.CausesValidation = false
        Me.txtAdress.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtAdress.Location = New System.Drawing.Point(212, 213)
        Me.txtAdress.MaxLength = 250
        Me.txtAdress.Multiline = true
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(308, 49)
        Me.txtAdress.TabIndex = 7
        '
        'txticq
        '
        Me.txticq.BackColor = System.Drawing.SystemColors.Window
        Me.txticq.CausesValidation = false
        Me.txticq.Dock = System.Windows.Forms.DockStyle.Top
        Me.txticq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txticq.Location = New System.Drawing.Point(212, 153)
        Me.txticq.MaxLength = 45
        Me.txticq.Name = "txticq"
        Me.txticq.Size = New System.Drawing.Size(308, 24)
        Me.txticq.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 210)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(203, 55)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Адрес"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtemailEmpl
        '
        Me.txtemailEmpl.BackColor = System.Drawing.SystemColors.Window
        Me.txtemailEmpl.CausesValidation = false
        Me.txtemailEmpl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtemailEmpl.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtemailEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtemailEmpl.Location = New System.Drawing.Point(212, 183)
        Me.txtemailEmpl.MaxLength = 50
        Me.txtemailEmpl.Name = "txtemailEmpl"
        Me.txtemailEmpl.Size = New System.Drawing.Size(308, 24)
        Me.txtemailEmpl.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtemailEmpl, "Если нет эл.почты оставить пустым")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НетЭлПочтыToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 26)
        '
        'НетЭлПочтыToolStripMenuItem
        '
        Me.НетЭлПочтыToolStripMenuItem.Name = "НетЭлПочтыToolStripMenuItem"
        Me.НетЭлПочтыToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.НетЭлПочтыToolStripMenuItem.Text = "Нет эл. почты"
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 150)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(203, 30)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "icq"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 30)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Skype"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Телефон"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(3, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 30)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "E-mail"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(3, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 30)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Должность"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPost
        '
        Me.txtPost.BackColor = System.Drawing.SystemColors.Window
        Me.txtPost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPost.Location = New System.Drawing.Point(212, 33)
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(308, 24)
        Me.txtPost.TabIndex = 1
        '
        'txtTelMob
        '
        Me.txtTelMob.BeepOnError = true
        Me.txtTelMob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTelMob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTelMob.Location = New System.Drawing.Point(212, 93)
        Me.txtTelMob.Mask = "(999) 000-00-00"
        Me.txtTelMob.Name = "txtTelMob"
        Me.txtTelMob.Size = New System.Drawing.Size(308, 24)
        Me.txtTelMob.TabIndex = 3
        '
        'txttelEmpl
        '
        Me.txttelEmpl.BackColor = System.Drawing.SystemColors.Window
        Me.txttelEmpl.CausesValidation = false
        Me.txttelEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttelEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txttelEmpl.Location = New System.Drawing.Point(212, 63)
        Me.txttelEmpl.MaxLength = 45
        Me.txttelEmpl.Name = "txttelEmpl"
        Me.txttelEmpl.Size = New System.Drawing.Size(308, 24)
        Me.txttelEmpl.TabIndex = 2
        '
        'txtSkype
        '
        Me.txtSkype.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSkype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtSkype.Location = New System.Drawing.Point(212, 123)
        Me.txtSkype.Name = "txtSkype"
        Me.txtSkype.Size = New System.Drawing.Size(308, 24)
        Me.txtSkype.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(3, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(203, 30)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Телефон мобильный"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSendSMS
        '
        Me.chkSendSMS.AutoSize = true
        Me.chkSendSMS.Checked = true
        Me.chkSendSMS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tlpContact.SetColumnSpan(Me.chkSendSMS, 2)
        Me.chkSendSMS.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkSendSMS.Enabled = false
        Me.chkSendSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSendSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkSendSMS.Location = New System.Drawing.Point(279, 268)
        Me.chkSendSMS.Name = "chkSendSMS"
        Me.chkSendSMS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSendSMS.Size = New System.Drawing.Size(241, 22)
        Me.chkSendSMS.TabIndex = 89
        Me.chkSendSMS.Text = "Отправлять SMS уведомления"
        Me.chkSendSMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSendSMS.UseVisualStyleBackColor = true
        '
        'chkSendMail
        '
        Me.chkSendMail.AutoSize = true
        Me.chkSendMail.Checked = true
        Me.chkSendMail.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tlpContact.SetColumnSpan(Me.chkSendMail, 2)
        Me.chkSendMail.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkSendMail.Enabled = false
        Me.chkSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSendMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkSendMail.Location = New System.Drawing.Point(272, 296)
        Me.chkSendMail.Name = "chkSendMail"
        Me.chkSendMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSendMail.Size = New System.Drawing.Size(248, 22)
        Me.chkSendMail.TabIndex = 90
        Me.chkSendMail.Text = "Отправлять e-mail уведомления"
        Me.chkSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSendMail.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.AutoSize = true
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button1.Location = New System.Drawing.Point(212, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 30)
        Me.Button1.TabIndex = 80
        Me.Button1.TabStop = false
        Me.Button1.Text = "Выслать пароль всем, у кого его нет"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnSendPass
        '
        Me.btnSendPass.AutoSize = true
        Me.btnSendPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSendPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSendPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSendPass.Location = New System.Drawing.Point(3, 324)
        Me.btnSendPass.Name = "btnSendPass"
        Me.btnSendPass.Size = New System.Drawing.Size(203, 30)
        Me.btnSendPass.TabIndex = 91
        Me.btnSendPass.Text = "Отправить пароль"
        Me.btnSendPass.UseVisualStyleBackColor = true
        '
        'tsCompany
        '
        Me.tsCompany.AutoSize = false
        Me.tsCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsCompany.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.tsbtnEdit, Me.tsbtnSave, Me.tsbtnCancel, Me.tsbtnDelete, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.tsCompany.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCompany.Location = New System.Drawing.Point(1025, 0)
        Me.tsCompany.Name = "tsCompany"
        Me.tsCompany.Size = New System.Drawing.Size(143, 434)
        Me.tsCompany.TabIndex = 0
        Me.tsCompany.TabStop = true
        Me.tsCompany.Text = "ToolStrip1"
        '
        'tsbtnNew
        '
        Me.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNew.Image = CType(resources.GetObject("tsbtnNew.Image"),System.Drawing.Image)
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(141, 22)
        Me.tsbtnNew.Text = "Создать"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEdit.Image = CType(resources.GetObject("tsbtnEdit.Image"),System.Drawing.Image)
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(141, 22)
        Me.tsbtnEdit.Text = "Изменить"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"),System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(141, 22)
        Me.tsbtnSave.Text = "Сохранить"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(141, 22)
        Me.tsbtnCancel.Text = "Отменить"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelete.Image = CType(resources.GetObject("tsbtnDelete.Image"),System.Drawing.Image)
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(141, 22)
        Me.tsbtnDelete.Text = "Удалить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(141, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = true
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143!))
        Me.TableLayoutPanel1.Controls.Add(Me.lstPerson, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpContact, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tsCompany, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1168, 419)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'frmEmplKA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1168, 419)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmEmplKA"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Персоны"
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpContact.ResumeLayout(false)
        Me.tlpContact.PerformLayout
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.tsCompany.ResumeLayout(false)
        Me.tsCompany.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

    Dim mdsPersonIndiv As New DataSet
    Dim modaPersonIndiv As SqlClient.SqlDataAdapter
    Dim mdrPersonIndiv As DataRow
    Dim mblnAdd As Boolean
    Dim currentPerson As Integer

#Region " Загрузка, активация формы "
    Private Sub Partners_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Персоны контрагента: " + Module1.NonQuery1ScalarString("SELECT  Name FROM KAgents WHERE ID = " & custID & " ")

        '' загружаем список компанию
        'Dim odaCustomers As SqlClient.SqlDataAdapter
        'Dim dtCustomers As New DataTable
        'Dim drCust As DataRow

        'Try
        '    odaCustomers = New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE ID = " & custID & " ", mcnnInt)
        '    odaCustomers.Fill(dtCustomers)
        '    drCust = dtCustomers.Rows(0)

        '    Me.Text = "Персоны контрагента: " + Module1.NonQuery1ScalarString("SELECT  Name FROM KAgents WHERE ID = " & custID & " ") '(drCust("Name"))
        'Catch oexpData As System.SystemException
        '    MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        'End Try

        '  Me.tsbtnSendPass.Visible = paramSendMail

        If postPrioritet = 1 Then
            Me.Button1.Visible = True
        End If

        LoadList()

        If createEmplKA = True Then
            NewEmlCust()
            createEmplKA = False
        Else
            ActivateEditing(False)
        End If

    End Sub
#End Region

#Region " Загрузка лист Персон "
    Private Sub LoadList()
        Try
            modaPersonIndiv = New SqlClient.SqlDataAdapter("SELECT * FROM EmplCust WHERE custID= " & custID & " order by lastName", mcnnInt)
            modaPersonIndiv.FillSchema(mdsPersonIndiv, 2, "EmplCust") 'загружаем схему для работы получения строки
            modaPersonIndiv.Fill(mdsPersonIndiv, "EmplCust")

            'Связать данные со списком
            Me.lstPerson.DataSource = mdsPersonIndiv.Tables("EmplCust")
            Me.lstPerson.DisplayMember = "lastName"
            Me.lstPerson.ValueMember = "emplCustID"
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " Перемещение по персонам "
    Private Sub lstPartners_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPerson.SelectedIndexChanged
        LoadIndividual()
    End Sub

    Private Sub LoadIndividual()
        Dim strName As String
        Dim oCtl2 As Object
        '  Dim emplCustID As Integer

        If Me.lstPerson.SelectedIndex <> -1 Then
            ' emplCustID = Me.lstPerson.SelectedItem(0)
            'Нахождение единственной строки в дата сете по идентификатору
            mdrPersonIndiv = mdsPersonIndiv.Tables("EmplCust").Rows.Find(Me.lstPerson.SelectedItem(0))

            For Each oCtl2 In Me.tlpContact.Controls
                If TypeOf oCtl2 Is TextBox Or TypeOf oCtl2 Is MaskedTextBox Then
                    strName = Mid(oCtl2.name, 4)
                    Try
                        oCtl2.text = mdrPersonIndiv(strName).ToString
                    Catch oexp As System.Exception
                    End Try
                End If

                If TypeOf oCtl2 Is CheckBox Then
                    strName = Mid(oCtl2.name, 4)
                    Try
                        oCtl2.checked = CBool(mdrPersonIndiv(strName))
                    Catch oexp As System.Exception
                    End Try
                End If
            Next
        End If
    End Sub
#End Region

#Region " Сохранить изменения "
    Private Sub SaveRecord()
        If IsValidEmailAddress(Me.txtemailEmpl.Text) = True Then

            currentPerson = Me.lstPerson.SelectedIndex
            If Me.txtTelMob.Text = "" Or Len(Me.txtTelMob.Text) < 15 Then
                Me.ErrorProvider1.SetError(Me.txtTelMob, "Поле Телефон мобильный должно быть заполнено") : Me.txtTelMob.Focus()
                Exit Sub
            Else : Me.ErrorProvider1.Clear() : End If

            If Me.txtlastName.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtlastName, "Поле ФИО должно быть заполнено") : Me.txtlastName.Focus()
                Exit Sub
            Else : Me.ErrorProvider1.Clear() : End If

            If Me.txtPost.Text = "" Then ' должность
                Me.ErrorProvider1.SetError(Me.txtPost, "Поле Должность должно быть заполнено") : Me.txtPost.Focus()
                Exit Sub
            Else : Me.ErrorProvider1.Clear() : End If

            Dim strName As String
            Dim oCtl As Object

            If mblnAdd = True Then
                mdrPersonIndiv = mdsPersonIndiv.Tables("EmplCust").NewRow
            End If

            mdrPersonIndiv.BeginEdit() 'приступить к редактированию строки

            For Each oCtl In Me.tlpContact.Controls
                If TypeOf oCtl Is TextBox Or TypeOf oCtl Is MaskedTextBox Then
                    strName = Mid(oCtl.name, 4)
                    Try
                        mdrPersonIndiv(strName) = oCtl.text
                    Catch oexp As System.Exception
                    End Try
                End If

                If TypeOf oCtl Is CheckBox Then
                    strName = Mid(oCtl.name, 4)
                    Try
                        mdrPersonIndiv(strName) = oCtl.checked
                    Catch oexp As System.Exception
                    End Try
                End If
            Next

            Try
                If mblnAdd = True Then
                    mdrPersonIndiv("custID") = custID
                    mdrPersonIndiv("password") = Module1.GenerateString(4, 6)
                    mdrPersonIndiv("date_cr") = Now()
                End If

                mdrPersonIndiv.EndEdit() 'Завершить редактирование строки данных

                Dim ocbPersonIndiv As SqlClient.SqlCommandBuilder 'создать экземпляр пострителя команды
                ocbPersonIndiv = New SqlClient.SqlCommandBuilder(modaPersonIndiv)

                If mblnAdd = True Then
                    mdsPersonIndiv.Tables("EmplCust").Rows.Add(mdrPersonIndiv)
                    modaPersonIndiv.InsertCommand = ocbPersonIndiv.GetInsertCommand  ' Обеспечить создание оператора Insert SQL
                Else
                    modaPersonIndiv.UpdateCommand = ocbPersonIndiv.GetUpdateCommand
                End If

                modaPersonIndiv.Update(mdsPersonIndiv, "EmplCust") 'выполнить команду SQL и закрыть соед.
                mdsPersonIndiv.Tables("EmplCust").AcceptChanges()

                If mblnAdd = True Then
                    modaPersonIndiv.InsertCommand.Connection.Close()
                Else
                    modaPersonIndiv.UpdateCommand.Connection.Close()
                End If
            Catch excData As System.Exception
                MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
            End Try

            ActivateEditing(False)
            mblnAdd = False

            If MessageBox.Show("Завершить работу с персонами?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Me.Close()
            Else
                Exit Sub
            End If

        Else
            MsgBox("Не корректный адрес эл. почты", MsgBoxStyle.Critical, appName)
            Me.txtemailEmpl.Focus()
        End If

    End Sub

    Public Function IsValidEmailAddress(str_email As String) As Boolean
        'проверяет e-mail на валидность
        Dim temp As String
        IsValidEmailAddress = False
        temp = str_email
        Dim I As Integer
        Dim N As Integer
        Dim strB As String

        Do While I < Len(str_email)
            I = I + 1
            strB = Mid(str_email, I, 1)
            If strB = "@" Then N = N + 1
        Loop

        If N <> 1 Then Exit Function
        If InStr(temp, " ") > 0 Then Exit Function
        If InStr(temp, ";") > 0 Then Exit Function
        If InStr(temp, ",") > 0 Then Exit Function
        If (InStr(temp, "<") > 0) Or (InStr(temp, ">") > 0) Then Exit Function
        If InStr(temp, Chr(34)) > 0 Then Exit Function

        IsValidEmailAddress = True
    End Function
#End Region

#Region " Меню "
    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        NewEmlCust()
    End Sub

    Private Sub NewEmlCust()
        mblnAdd = True

        Dim oCtl As Object

        For Each oCtl In Me.tlpContact.Controls
            If TypeOf oCtl Is TextBox Then
                oCtl.text = ""
            End If
            If TypeOf oCtl Is MaskedTextBox Then
                oCtl.text = ""
            End If
            If TypeOf oCtl Is CheckBox Then
                oCtl.checked = 0
            End If
        Next

        ActivateEditing(True)
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        SaveRecord()
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        If Me.lstPerson.SelectedItems.Count = 0 Then
            MsgBox("Не выбрана персона для редактирования.", MsgBoxStyle.Critical, appName) : Exit Sub
        Else
            ActivateEditing(True)
        End If
    End Sub

#Region " Активация редактирования  "
    Private Sub ActivateEditing(ByVal bEnable As Boolean)
        Dim oCtl As Object

        For Each oCtl In Me.tlpContact.Controls
            If TypeOf oCtl Is TextBox Or TypeOf oCtl Is MaskedTextBox Then
                If bEnable = True Then
                    oCtl.BorderStyle() = System.Windows.Forms.BorderStyle.Fixed3D
                    oCtl.BackColor() = System.Drawing.Color.White
                    Me.txtlastName.Focus()
                Else
                    oCtl.BorderStyle() = System.Windows.Forms.BorderStyle.FixedSingle
                    oCtl.BackColor() = System.Drawing.Color.White
                    'oCtl2.BackColor() = Me.BackColor
                End If
                oCtl.Enabled = bEnable
                '  oCtl.readOnly = Not bEnable
            End If
        Next

        Me.chkSendMail.Enabled = bEnable
        Me.chkSendSMS.Enabled = bEnable

        Me.tsbtnNew.Enabled = Not bEnable
        Me.tsbtnEdit.Enabled = Not bEnable
        Me.tsbtnSave.Enabled = bEnable
        Me.tsbtnCancel.Enabled = bEnable
    End Sub
#End Region

    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        Me.ErrorProvider1.Clear()
        Dim current As Integer = Me.lstPerson.SelectedIndex

        mblnAdd = False


        ActivateEditing(False)
        LoadIndividual()

        Me.lstPerson.SelectedIndex = current
    End Sub

    Private Sub tsbtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelete.Click

        Dim resp2% = MessageBox.Show("Удалить " & mdrPersonIndiv("lastName") & "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp2 = DialogResult.Yes Then
            'Try
            '    '   Module1.NonQuery1("DELETE FROM EmplCust WHERE emplCustID = " & Me.lstPerson.SelectedItem(0) & " ")
            '    '  LoadList()
            'Catch ex As System.Exception
            '    MsgBox("Возникла ошибка при удалении. " & Chr(13) & "Скорее всего с использованием этой персоны оформлен заказ.")
            'End Try



            Try
                Dim ocbPartIndiv As SqlClient.SqlCommandBuilder

                mdrPersonIndiv.Delete()
                ocbPartIndiv = New SqlClient.SqlCommandBuilder(modaPersonIndiv)
                modaPersonIndiv.DeleteCommand = ocbPartIndiv.GetDeleteCommand
                modaPersonIndiv.Update(mdsPersonIndiv, "EmplCust")
                mdsPersonIndiv.Tables("EmplCust").AcceptChanges()
                modaPersonIndiv.DeleteCommand.Connection.Close()
            Catch excData As System.Exception
                MessageBox.Show("Error Occured:" & excData.Message)
            End Try

            '  LoadList()
            ActivateEditing(False)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
#End Region

#Region " Запрет нажатия ентера  "
    'Private Sub txtAdressF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Integer
    '    KeyAscii = Asc(e.KeyChar)

    '    If KeyAscii = 13 Then KeyAscii = 0
    '    If KeyAscii = 0 Then e.Handled = True Else e.Handled = False
    'End Sub

#End Region


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'If Len(strName) = 0 Then
        '    MsgBox("Код не введен  ", MessageBoxIcon.Error) : Exit Sub
        'Else
        '    If strName = "197630" Then
        '        Dim c As Control

        '        For Each c In Me.tlpEmpl.Controls 'ob.Parent.Controls
        '            If c.Tag = "fzp" Then
        '                c.Visible = True
        '            End If
        '        Next
        '    End If
        'End If

        Try
            Dim odaCustomers As New SqlClient.SqlDataAdapter("SELECT emplCustID FROM EmplCust WHERE password is null  ", mcnnInt)
            Dim dtCustomers As New DataTable : odaCustomers.Fill(dtCustomers)
            Dim drCust As DataRow
            Dim pass As String
            Dim i%

            For i = 0 To dtCustomers.Rows.Count - 1
                Dim n As Integer

                pass = Module1.GenerateString(4, 6)
                For n = 1 To 10000000

                Next
                drCust = dtCustomers.Rows(i)

                Module1.NonQuery1("UPDATE EmplCust SET password = '" & pass & "' WHERE emplCustID = " & drCust("emplCustID") & " ")
            Next

            MsgBox(CStr(i))

        Catch oexpData As OleDb.OleDbException
            MsgBox(oexpData.Message)
        End Try
    End Sub

    Private Sub НетЭлПочтыToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles НетЭлПочтыToolStripMenuItem.Click
        Me.txtemailEmpl.Text = "net@net.ru"
    End Sub

    Private Sub btnSendPass_Click(sender As Object, e As EventArgs) Handles btnSendPass.Click
        ' MsgBox(Module1.GenerateString(8, 8))
        Dim pass As String = Module1.GenerateString(4, 6)

        '  Module1.NonQuery1("UPDATE EmplCust SET password = '" & pass & "' WHERE emplCustID = " & Me.lstPerson.SelectedItem(0) & " ")

        '  If paramSendMail = True Then
        '  mod_SendMail.Main(mdrPersonIndiv("emailEmpl"), pass, "Пароль к личному кабинету AwardsCraft")
        ' End If
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[dbo].[sp_Mail_send_pass]"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@pass", SqlDbType.NVarChar))
            cmd.Parameters("@pass").Value = pass
            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
            cmd.Parameters("@emplID").Value = Me.lstPerson.SelectedItem(0)

            '  MsgBox(pass + ", " + CStr(Me.lstPerson.SelectedItem(0)))

            mcnnInt.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Пароль отправлен.", MsgBoxStyle.Information, appName)
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        Finally
            mcnnInt.Close()
            Me.Close()
        End Try
    End Sub

End Class
