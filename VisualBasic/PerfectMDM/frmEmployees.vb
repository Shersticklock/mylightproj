Imports HashHelper

Public Class frmEmployees
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbOffice As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstEmployees As System.Windows.Forms.ListBox
    Friend WithEvents txtEmplLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbPost As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPrava As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkKassa As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents chkDismissed As System.Windows.Forms.CheckBox
    Friend WithEvents txtPercentEmpl As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNewEmpl As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEditEmpl As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSaveEmpl As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnNewPassword As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbStatusEmpl As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tlpEmpl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPercentManager As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOnCard As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtgooglemail As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tsbtnDostupFZP As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents chkInternet As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtemplTelVN As System.Windows.Forms.TextBox
    Friend WithEvents cmbWageSystem As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbSorting As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDeputy As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbPostFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmplTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chkPost As System.Windows.Forms.CheckBox
    Friend WithEvents txtNewPasword As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        Me.lstEmployees = New System.Windows.Forms.ListBox()
        Me.txtEmplLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbOffice = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewPasword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbPost = New System.Windows.Forms.ComboBox()
        Me.cmbPrava = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbStatusEmpl = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkKassa = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.chkDismissed = New System.Windows.Forms.CheckBox()
        Me.txtPercentEmpl = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNewEmpl = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEditEmpl = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSaveEmpl = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnNewPassword = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDostupFZP = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbSorting = New System.Windows.Forms.ComboBox()
        Me.cmbPostFilter = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkPost = New System.Windows.Forms.CheckBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tlpEmpl = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPercentManager = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOnCard = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtgooglemail = New System.Windows.Forms.TextBox()
        Me.chkInternet = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtemplTelVN = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbDeputy = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbWageSystem = New System.Windows.Forms.ComboBox()
        Me.txtEmplTel = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer2.Panel1.SuspendLayout
        Me.SplitContainer2.Panel2.SuspendLayout
        Me.SplitContainer2.SuspendLayout
        Me.tlpEmpl.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lstEmployees
        '
        Me.lstEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel2.SetColumnSpan(Me.lstEmployees, 2)
        Me.lstEmployees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstEmployees.HorizontalScrollbar = true
        Me.lstEmployees.ItemHeight = 17
        Me.lstEmployees.Location = New System.Drawing.Point(3, 96)
        Me.lstEmployees.Name = "lstEmployees"
        Me.lstEmployees.Size = New System.Drawing.Size(473, 584)
        Me.lstEmployees.TabIndex = 0
        '
        'txtEmplLastName
        '
        Me.txtEmplLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmplLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmplLastName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmplLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtEmplLastName.Location = New System.Drawing.Point(236, 3)
        Me.txtEmplLastName.MaxLength = 250
        Me.txtEmplLastName.Name = "txtEmplLastName"
        Me.txtEmplLastName.Size = New System.Drawing.Size(363, 24)
        Me.txtEmplLastName.TabIndex = 0
        Me.ToolTip2.SetToolTip(Me.txtEmplLastName, "Фамилия Имя Отчество сотрудника")
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ФИО"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(3, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 30)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Пароль"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOffice
        '
        Me.cmbOffice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOffice.Location = New System.Drawing.Point(236, 304)
        Me.cmbOffice.Name = "cmbOffice"
        Me.cmbOffice.Size = New System.Drawing.Size(363, 25)
        Me.cmbOffice.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(3, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 31)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Офис"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtLogin.Location = New System.Drawing.Point(236, 244)
        Me.txtLogin.MaxLength = 250
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(363, 24)
        Me.txtLogin.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(3, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 30)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Логин"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 30)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Телефон мобильный"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewPasword
        '
        Me.txtNewPasword.BackColor = System.Drawing.SystemColors.Control
        Me.txtNewPasword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPasword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNewPasword.Enabled = false
        Me.txtNewPasword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNewPasword.Location = New System.Drawing.Point(236, 274)
        Me.txtNewPasword.MaxLength = 10
        Me.txtNewPasword.Name = "txtNewPasword"
        Me.txtNewPasword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPasword.Size = New System.Drawing.Size(363, 24)
        Me.txtNewPasword.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(3, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 31)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Роль"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPost
        '
        Me.cmbPost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPost.Location = New System.Drawing.Point(236, 33)
        Me.cmbPost.MaxDropDownItems = 20
        Me.cmbPost.Name = "cmbPost"
        Me.cmbPost.Size = New System.Drawing.Size(363, 25)
        Me.cmbPost.TabIndex = 1
        '
        'cmbPrava
        '
        Me.cmbPrava.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPrava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrava.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPrava.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPrava.Items.AddRange(New Object() {"Видит все заказы, редактирует все", "Видит все заказы, редактирует только свои", "Видит и редактирует только свои заказы", "Видит, но не редактирует свои заказы", "Видит заказы всех офисов"})
        Me.cmbPrava.Location = New System.Drawing.Point(236, 335)
        Me.cmbPrava.Name = "cmbPrava"
        Me.cmbPrava.Size = New System.Drawing.Size(363, 25)
        Me.cmbPrava.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(3, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(227, 31)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Права"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(227, 28)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Статус"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 31)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Состояние"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbStatusEmpl
        '
        Me.cmbStatusEmpl.DisplayMember = "0"
        Me.cmbStatusEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatusEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatusEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbStatusEmpl.FormattingEnabled = true
        Me.cmbStatusEmpl.Items.AddRange(New Object() {"Все", "Действительные", "Уволеные"})
        Me.cmbStatusEmpl.Location = New System.Drawing.Point(101, 3)
        Me.cmbStatusEmpl.Name = "cmbStatusEmpl"
        Me.cmbStatusEmpl.Size = New System.Drawing.Size(375, 25)
        Me.cmbStatusEmpl.TabIndex = 54
        Me.cmbStatusEmpl.TabStop = false
        Me.cmbStatusEmpl.ValueMember = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(3, 570)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Tag = "fzp"
        Me.Label1.Text = "Процент менеджера (%)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkKassa
        '
        Me.chkKassa.AutoSize = true
        Me.chkKassa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkKassa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkKassa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkKassa.Location = New System.Drawing.Point(236, 424)
        Me.chkKassa.Name = "chkKassa"
        Me.chkKassa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkKassa.Size = New System.Drawing.Size(363, 22)
        Me.chkKassa.TabIndex = 14
        Me.chkKassa.TabStop = false
        Me.chkKassa.Tag = "fzp"
        Me.chkKassa.Text = "Принимает оплату заказов"
        Me.ToolTip2.SetToolTip(Me.chkKassa, "Установить флаг у сотрудников, принимающих или проводящих оплату заказов")
        Me.chkKassa.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 540)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 30)
        Me.Label2.TabIndex = 62
        Me.Label2.Tag = "fzp"
        Me.Label2.Text = "Процент специалиста (%)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSalary
        '
        Me.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtSalary.Location = New System.Drawing.Point(236, 483)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(363, 24)
        Me.txtSalary.TabIndex = 16
        Me.txtSalary.Tag = "fzp"
        Me.txtSalary.Text = "0"
        Me.ToolTip2.SetToolTip(Me.txtSalary, "Полная сумма фиксированного финансового вознаграждения сотрудника")
        '
        'chkDismissed
        '
        Me.chkDismissed.AutoSize = true
        Me.chkDismissed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDismissed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDismissed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkDismissed.Location = New System.Drawing.Point(236, 216)
        Me.chkDismissed.Name = "chkDismissed"
        Me.chkDismissed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDismissed.Size = New System.Drawing.Size(363, 22)
        Me.chkDismissed.TabIndex = 7
        Me.chkDismissed.TabStop = false
        Me.chkDismissed.Text = "Уволен"
        Me.chkDismissed.UseVisualStyleBackColor = true
        '
        'txtPercentEmpl
        '
        Me.txtPercentEmpl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPercentEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPercentEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPercentEmpl.Location = New System.Drawing.Point(236, 543)
        Me.txtPercentEmpl.Name = "txtPercentEmpl"
        Me.txtPercentEmpl.Size = New System.Drawing.Size(363, 24)
        Me.txtPercentEmpl.TabIndex = 18
        Me.txtPercentEmpl.Tag = "fzp"
        Me.txtPercentEmpl.Text = "0"
        Me.ToolTip2.SetToolTip(Me.txtPercentEmpl, "Процент вознаграждения специалистам имеющим сдельную оплату труда")
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(3, 480)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(227, 30)
        Me.Label15.TabIndex = 67
        Me.Label15.Tag = "fzp"
        Me.Label15.Text = "Оклад, (руб.)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = false
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNewEmpl, Me.tsbtnEditEmpl, Me.tsbtnSaveEmpl, Me.tsbtnNewPassword, Me.tsbtnDostupFZP, Me.tsbtnCancel, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(180, 700)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnNewEmpl
        '
        Me.tsbtnNewEmpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewEmpl.Image = CType(resources.GetObject("tsbtnNewEmpl.Image"),System.Drawing.Image)
        Me.tsbtnNewEmpl.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewEmpl.Name = "tsbtnNewEmpl"
        Me.tsbtnNewEmpl.Size = New System.Drawing.Size(178, 22)
        Me.tsbtnNewEmpl.Text = "Создать"
        '
        'tsbtnEditEmpl
        '
        Me.tsbtnEditEmpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEditEmpl.Image = CType(resources.GetObject("tsbtnEditEmpl.Image"),System.Drawing.Image)
        Me.tsbtnEditEmpl.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditEmpl.Name = "tsbtnEditEmpl"
        Me.tsbtnEditEmpl.Size = New System.Drawing.Size(178, 22)
        Me.tsbtnEditEmpl.Text = "Изменить"
        '
        'tsbtnSaveEmpl
        '
        Me.tsbtnSaveEmpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSaveEmpl.Image = CType(resources.GetObject("tsbtnSaveEmpl.Image"),System.Drawing.Image)
        Me.tsbtnSaveEmpl.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSaveEmpl.Name = "tsbtnSaveEmpl"
        Me.tsbtnSaveEmpl.Size = New System.Drawing.Size(178, 22)
        Me.tsbtnSaveEmpl.Text = "Сохранить"
        '
        'tsbtnNewPassword
        '
        Me.tsbtnNewPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewPassword.Enabled = false
        Me.tsbtnNewPassword.Image = CType(resources.GetObject("tsbtnNewPassword.Image"),System.Drawing.Image)
        Me.tsbtnNewPassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewPassword.Name = "tsbtnNewPassword"
        Me.tsbtnNewPassword.Size = New System.Drawing.Size(178, 22)
        Me.tsbtnNewPassword.Text = "Новый пароль"
        '
        'tsbtnDostupFZP
        '
        Me.tsbtnDostupFZP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDostupFZP.Image = CType(resources.GetObject("tsbtnDostupFZP.Image"),System.Drawing.Image)
        Me.tsbtnDostupFZP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDostupFZP.Name = "tsbtnDostupFZP"
        Me.tsbtnDostupFZP.Size = New System.Drawing.Size(178, 22)
        Me.tsbtnDostupFZP.Text = "Код доступа"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(178, 22)
        Me.tsbtnCancel.Text = "Отмена"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(178, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 702)
        Me.SplitContainer1.SplitterDistance = 481
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = false
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lstEmployees, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbStatusEmpl, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbSorting, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbPostFilter, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.chkPost, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(479, 700)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label11, 2)
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 683)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(473, 17)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSorting
        '
        Me.cmbSorting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSorting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSorting.FormattingEnabled = true
        Me.cmbSorting.Items.AddRange(New Object() {"Сортировать по алфавиту", "Сортировать по дате создания"})
        Me.cmbSorting.Location = New System.Drawing.Point(101, 65)
        Me.cmbSorting.Name = "cmbSorting"
        Me.cmbSorting.Size = New System.Drawing.Size(375, 25)
        Me.cmbSorting.TabIndex = 60
        Me.cmbSorting.TabStop = false
        '
        'cmbPostFilter
        '
        Me.cmbPostFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPostFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPostFilter.Enabled = false
        Me.cmbPostFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPostFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPostFilter.FormattingEnabled = true
        Me.cmbPostFilter.Location = New System.Drawing.Point(101, 34)
        Me.cmbPostFilter.MaxDropDownItems = 24
        Me.cmbPostFilter.Name = "cmbPostFilter"
        Me.cmbPostFilter.Size = New System.Drawing.Size(375, 25)
        Me.cmbPostFilter.TabIndex = 62
        Me.cmbPostFilter.TabStop = false
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 31)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "Сортировка"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPost
        '
        Me.chkPost.AutoSize = true
        Me.chkPost.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkPost.Location = New System.Drawing.Point(35, 34)
        Me.chkPost.Name = "chkPost"
        Me.chkPost.Size = New System.Drawing.Size(60, 25)
        Me.chkPost.TabIndex = 63
        Me.chkPost.TabStop = false
        Me.chkPost.Text = "Роль"
        Me.chkPost.UseVisualStyleBackColor = true
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.tlpEmpl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Size = New System.Drawing.Size(791, 702)
        Me.SplitContainer2.SplitterDistance = 605
        Me.SplitContainer2.TabIndex = 1
        '
        'tlpEmpl
        '
        Me.tlpEmpl.AutoSize = true
        Me.tlpEmpl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpEmpl.ColumnCount = 2
        Me.tlpEmpl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71682!))
        Me.tlpEmpl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28318!))
        Me.tlpEmpl.Controls.Add(Me.Label2, 0, 18)
        Me.tlpEmpl.Controls.Add(Me.txtSalary, 1, 16)
        Me.tlpEmpl.Controls.Add(Me.Label15, 0, 16)
        Me.tlpEmpl.Controls.Add(Me.Label7, 0, 5)
        Me.tlpEmpl.Controls.Add(Me.chkDismissed, 1, 7)
        Me.tlpEmpl.Controls.Add(Me.Label10, 0, 7)
        Me.tlpEmpl.Controls.Add(Me.Label6, 0, 8)
        Me.tlpEmpl.Controls.Add(Me.txtLogin, 1, 8)
        Me.tlpEmpl.Controls.Add(Me.Label4, 0, 9)
        Me.tlpEmpl.Controls.Add(Me.txtNewPasword, 1, 9)
        Me.tlpEmpl.Controls.Add(Me.cmbPrava, 1, 11)
        Me.tlpEmpl.Controls.Add(Me.Label5, 0, 10)
        Me.tlpEmpl.Controls.Add(Me.cmbOffice, 1, 10)
        Me.tlpEmpl.Controls.Add(Me.Label9, 0, 11)
        Me.tlpEmpl.Controls.Add(Me.txtPercentEmpl, 1, 18)
        Me.tlpEmpl.Controls.Add(Me.txtPercentManager, 1, 19)
        Me.tlpEmpl.Controls.Add(Me.Label1, 0, 19)
        Me.tlpEmpl.Controls.Add(Me.Label13, 0, 2)
        Me.tlpEmpl.Controls.Add(Me.cmbDepartment, 1, 2)
        Me.tlpEmpl.Controls.Add(Me.Label14, 0, 17)
        Me.tlpEmpl.Controls.Add(Me.txtOnCard, 1, 17)
        Me.tlpEmpl.Controls.Add(Me.Label16, 0, 6)
        Me.tlpEmpl.Controls.Add(Me.txtEmail, 1, 6)
        Me.tlpEmpl.Controls.Add(Me.Label18, 0, 12)
        Me.tlpEmpl.Controls.Add(Me.txtgooglemail, 1, 12)
        Me.tlpEmpl.Controls.Add(Me.chkInternet, 1, 13)
        Me.tlpEmpl.Controls.Add(Me.Label19, 0, 4)
        Me.tlpEmpl.Controls.Add(Me.txtemplTelVN, 1, 4)
        Me.tlpEmpl.Controls.Add(Me.Label20, 0, 15)
        Me.tlpEmpl.Controls.Add(Me.cmbDeputy, 1, 3)
        Me.tlpEmpl.Controls.Add(Me.Label12, 0, 3)
        Me.tlpEmpl.Controls.Add(Me.cmbPost, 1, 1)
        Me.tlpEmpl.Controls.Add(Me.txtEmplLastName, 1, 0)
        Me.tlpEmpl.Controls.Add(Me.Label8, 0, 1)
        Me.tlpEmpl.Controls.Add(Me.Label3, 0, 0)
        Me.tlpEmpl.Controls.Add(Me.chkKassa, 1, 14)
        Me.tlpEmpl.Controls.Add(Me.cmbWageSystem, 1, 15)
        Me.tlpEmpl.Controls.Add(Me.txtEmplTel, 1, 5)
        Me.tlpEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpEmpl.Location = New System.Drawing.Point(0, 0)
        Me.tlpEmpl.Name = "tlpEmpl"
        Me.tlpEmpl.RowCount = 20
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16!))
        Me.tlpEmpl.Size = New System.Drawing.Size(602, 600)
        Me.tlpEmpl.TabIndex = 0
        '
        'txtPercentManager
        '
        Me.txtPercentManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPercentManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPercentManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPercentManager.Location = New System.Drawing.Point(236, 573)
        Me.txtPercentManager.Name = "txtPercentManager"
        Me.txtPercentManager.Size = New System.Drawing.Size(363, 24)
        Me.txtPercentManager.TabIndex = 19
        Me.txtPercentManager.Tag = "fzp"
        Me.txtPercentManager.Text = "0"
        Me.ToolTip2.SetToolTip(Me.txtPercentManager, "Процент вознаграждения менеджеров от суммы реализации")
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(3, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(227, 31)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Департамент"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepartment.FormattingEnabled = true
        Me.cmbDepartment.Location = New System.Drawing.Point(236, 64)
        Me.cmbDepartment.MaxDropDownItems = 20
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(363, 25)
        Me.cmbDepartment.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(3, 510)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(227, 30)
        Me.Label14.TabIndex = 73
        Me.Label14.Tag = "fzp"
        Me.Label14.Text = "На карту, (руб.)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOnCard
        '
        Me.txtOnCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOnCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOnCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtOnCard.Location = New System.Drawing.Point(236, 513)
        Me.txtOnCard.Name = "txtOnCard"
        Me.txtOnCard.Size = New System.Drawing.Size(363, 24)
        Me.txtOnCard.TabIndex = 17
        Me.txtOnCard.Tag = "fzp"
        Me.txtOnCard.Text = "0"
        Me.ToolTip2.SetToolTip(Me.txtOnCard, "Часть вознаграждения, которая перичисляется официально или на карту")
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 183)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(227, 30)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "E-mail"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtEmail.Location = New System.Drawing.Point(236, 186)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(363, 24)
        Me.txtEmail.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 363)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(227, 30)
        Me.Label18.TabIndex = 77
        Me.Label18.Tag = ""
        Me.Label18.Text = "test"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Visible = false
        '
        'txtgooglemail
        '
        Me.txtgooglemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgooglemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtgooglemail.Location = New System.Drawing.Point(236, 366)
        Me.txtgooglemail.Name = "txtgooglemail"
        Me.txtgooglemail.Size = New System.Drawing.Size(363, 24)
        Me.txtgooglemail.TabIndex = 12
        Me.ToolTip2.SetToolTip(Me.txtgooglemail, "Идентификатор Android устройства для обеспечения доступа  сотрудника к своим зада"& _ 
        "чам через гаджет")
        Me.txtgooglemail.Visible = false
        '
        'chkInternet
        '
        Me.chkInternet.AutoSize = true
        Me.chkInternet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkInternet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkInternet.Location = New System.Drawing.Point(236, 396)
        Me.chkInternet.Name = "chkInternet"
        Me.chkInternet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkInternet.Size = New System.Drawing.Size(363, 22)
        Me.chkInternet.TabIndex = 13
        Me.chkInternet.TabStop = false
        Me.chkInternet.Text = "Принимает Интернет заказы"
        Me.chkInternet.UseVisualStyleBackColor = true
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 123)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(227, 30)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Телефон внутренний"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtemplTelVN
        '
        Me.txtemplTelVN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemplTelVN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtemplTelVN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtemplTelVN.Location = New System.Drawing.Point(236, 126)
        Me.txtemplTelVN.Name = "txtemplTelVN"
        Me.txtemplTelVN.Size = New System.Drawing.Size(363, 24)
        Me.txtemplTelVN.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(3, 449)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(227, 31)
        Me.Label20.TabIndex = 86
        Me.Label20.Tag = "fzp"
        Me.Label20.Text = "Система оплаты труда"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDeputy
        '
        Me.cmbDeputy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDeputy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeputy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDeputy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDeputy.FormattingEnabled = true
        Me.cmbDeputy.Location = New System.Drawing.Point(236, 95)
        Me.cmbDeputy.Name = "cmbDeputy"
        Me.cmbDeputy.Size = New System.Drawing.Size(363, 25)
        Me.cmbDeputy.TabIndex = 3
        Me.cmbDeputy.Visible = false
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(227, 31)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Является заместителем"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = false
        '
        'cmbWageSystem
        '
        Me.cmbWageSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbWageSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWageSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbWageSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbWageSystem.FormattingEnabled = true
        Me.cmbWageSystem.Location = New System.Drawing.Point(236, 452)
        Me.cmbWageSystem.Name = "cmbWageSystem"
        Me.cmbWageSystem.Size = New System.Drawing.Size(363, 25)
        Me.cmbWageSystem.TabIndex = 15
        Me.cmbWageSystem.Tag = "fzp"
        '
        'txtEmplTel
        '
        Me.txtEmplTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmplTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtEmplTel.Location = New System.Drawing.Point(236, 156)
        Me.txtEmplTel.Mask = "(999) 000-00-00"
        Me.txtEmplTel.Name = "txtEmplTel"
        Me.txtEmplTel.Size = New System.Drawing.Size(363, 24)
        Me.txtEmplTel.TabIndex = 5
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        '
        'frmEmployees
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.AutoSize = true
        Me.ClientSize = New System.Drawing.Size(1276, 702)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(865, 458)
        Me.Name = "frmEmployees"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Сотрудники"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel1.PerformLayout
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        Me.tlpEmpl.ResumeLayout(false)
        Me.tlpEmpl.PerformLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

#End Region

    Dim mdsEmplIndiv As New DataSet
    Dim modaEmplIndiv As SqlClient.SqlDataAdapter
    Dim mdrEmplIndiv As DataRow
    Dim mblnAdd, mbNewPassword As Boolean

#Region " Загрузка формы "
    Private Sub Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbStatusEmpl.SelectedIndex = 0
        Me.cmbSorting.SelectedIndex = 1

        'Заполнение списка
        Try
            Dim odaPost As New SqlClient.SqlDataAdapter("SELECT postID, postName FROM Posts", mcnnInt)
            Dim dtPost As New DataTable : odaPost.Fill(dtPost)
            Me.cmbPost.DataSource = dtPost
            Me.cmbPost.DisplayMember = "postName"
            Me.cmbPost.ValueMember = "postID"

            Dim odaPost1 As New SqlClient.SqlDataAdapter("SELECT postID, postName FROM Posts", mcnnInt)
            Dim dtPost1 As New DataTable : odaPost.Fill(dtPost1)
            Me.cmbPostFilter.DataSource = dtPost1
            Me.cmbPostFilter.DisplayMember = "postName"
            Me.cmbPostFilter.ValueMember = "postID"
            Me.cmbPostFilter.SelectedIndex = -1


            Me.cmbPostFilter.Text = "Все"

            Dim odaOffices As New SqlClient.SqlDataAdapter("SELECT id, name FROM Offices", mcnnInt)
            Dim dtOffices As New DataTable : odaOffices.Fill(dtOffices)
            Me.cmbOffice.DataSource = dtOffices
            Me.cmbOffice.DisplayMember = "name"
            Me.cmbOffice.ValueMember = "ID"

            Dim odaCur As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Departments order by Name", mcnnInt)
            Dim dtCur As New DataTable : odaCur.Fill(dtCur)
            Me.cmbDepartment.DataSource = dtCur 'Связать данные со списком
            Me.cmbDepartment.DisplayMember = "Name"
            Me.cmbDepartment.ValueMember = "ID"

            Dim odaWageSystem As New SqlClient.SqlDataAdapter("SELECT id, name FROM fin_WageSystem", mcnnInt)
            Dim dtWageSystem As New DataTable : odaWageSystem.Fill(dtWageSystem)
            Me.cmbWageSystem.DataSource = dtWageSystem
            Me.cmbWageSystem.DisplayMember = "Name"
            Me.cmbWageSystem.ValueMember = "ID"
        Catch ex As System.Exception
            MessageBox.Show("Ошибка 345 " & ex.Message, appName)
        End Try

        ActivateEditing(False)

        Dim c As Control

        For Each c In Me.tlpEmpl.Controls 'ob.Parent.Controls
            If c.Tag = "fzp" Then
                c.Visible = False
            End If
        Next
    End Sub
#End Region

#Region " Загрузка лист сотрудников "
    Private Sub LoadList()
        Try
            Dim strSQL As String = Nothing ' "SELECT emplID, emplLastName FROM Employees WHERE dismissed <> 1"

            Select Case Me.cmbStatusEmpl.SelectedIndex()
                Case Is = 0 : strSQL = "SELECT emplID, emplLastName FROM Employees WHERE dismissed is not null" ' Where MatName Like '" & Me.txtEmplTel.Text & "%'"
                Case Is = 1 : strSQL = "SELECT emplID, emplLastName FROM Employees WHERE dismissed<>1" ' Where MatName Like '" & Me.txtEmplTel.Text & "%'"
                Case Is = 2 : strSQL = "SELECT emplID, emplLastName FROM Employees WHERE dismissed=1" ' Where MatName Like '" & Me.txtEmplTel.Text & "%'"
            End Select

            Select Case Me.cmbPostFilter.SelectedIndex
                Case Is <> -1
                    strSQL += " AND postID=" & Me.cmbPostFilter.SelectedItem(0) & "" 'viewCust.Sort = "emplLastName"
                Case Else
            End Select

            Select Case Me.cmbSorting.SelectedIndex
                Case Is = 0
                    strSQL += " ORDER BY emplLastName" 'viewCust.Sort = "emplLastName"
                Case Is = 1
                    strSQL += " ORDER BY emplID" 'viewCust.Sort = "emplID"
            End Select

            Dim odaEmpl As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtEmpl As New DataTable : odaEmpl.Fill(dtEmpl)

            '    Dim viewCust As New DataView(dtEmpl)
            'Связать данные со списком
            Me.lstEmployees.DataSource = dtEmpl
            Me.lstEmployees.DisplayMember = "emplLastName"
            Me.lstEmployees.ValueMember = "emplID"

            Me.Label11.Text = "Всего - " & CStr(Me.lstEmployees.Items.Count)

        Catch oexpData As System.Exception
            MessageBox.Show("Ошибка при загрузке списка сотрудников: " & oexpData.Message, appName)
        End Try
    End Sub
#End Region

#Region " Загрузка индивидуальных параметров "
    Private Sub LoadIndividual()
        Dim strName As String
        Dim oCtl As Object

        mdsEmplIndiv.Clear()

        If Me.lstEmployees.SelectedIndex <> -1 Then
            Try
                modaEmplIndiv = New SqlClient.SqlDataAdapter("SELECT*FROM Employees WHERE emplID=" & Me.lstEmployees.SelectedItem(0) & "", mcnnInt)
                modaEmplIndiv.Fill(mdsEmplIndiv, "Employees")
                mdrEmplIndiv = mdsEmplIndiv.Tables("Employees").Rows(0)

                For Each oCtl In Me.tlpEmpl.Controls
                    If TypeOf oCtl Is TextBox Or TypeOf oCtl Is MaskedTextBox Then
                        strName = Mid(oCtl.name, 4)
                        Try
                            oCtl.text = Trim(mdrEmplIndiv(strName).ToString)
                        Catch oexp As System.Exception
                        End Try
                    End If
                Next

                Me.cmbOffice.SelectedValue = mdrEmplIndiv("ofID")
                Me.cmbPost.SelectedValue = mdrEmplIndiv("postID")
                Me.cmbPrava.SelectedIndex = mdrEmplIndiv("prava")
                Me.chkKassa.Checked = mdrEmplIndiv("kassa")
                Me.chkDismissed.Checked = mdrEmplIndiv("dismissed")
                '   Me.chkDirDep.Checked = mdrEmplIndiv("dirdep")
                '   Me.lblID.Text = mdrEmplIndiv("emplID")
                Me.cmbDepartment.SelectedValue = mdrEmplIndiv("departmentID")
            Catch oexpData As System.Exception
                MessageBox.Show("Ошибка при загрузке персональных данных. " & oexpData.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub
#End Region

    Private Sub ActivateEditing(ByRef bEnable As Boolean)
        ' Если редактирование разрешено то перемещение запрещено
        Me.lstEmployees.Enabled = Not bEnable
        Me.cmbSorting.Enabled = Not bEnable
        Me.cmbStatusEmpl.Enabled = Not bEnable

        Dim oCurr As Object 'обработать в цикле каждый элемент в форме

        For Each oCurr In Me.tlpEmpl.Controls
            If TypeOf oCurr Is ComboBox Then
                If bEnable Then
                    oCurr.BackColor() = System.Drawing.Color.White
                Else
                    oCurr.BackColor() = System.Drawing.Color.White
                End If

                oCurr.Enabled = bEnable
            End If

            If TypeOf oCurr Is TextBox Or TypeOf oCurr Is MaskedTextBox Then
                If oCurr.name <> "txtNewPasword" Then
                    If bEnable Then
                        'oCurr.BorderStyle() = System.Windows.Forms.BorderStyle.Fixed3D
                        oCurr.BackColor() = System.Drawing.Color.White
                    Else
                        'oCurr.BorderStyle() = System.Windows.Forms.BorderStyle.FixedSingle
                        oCurr.BackColor() = System.Drawing.Color.White
                        '   oCurr.BackColor() = Me.BackColor
                    End If
                    oCurr.Enabled = bEnable
                End If
            End If
        Next

        Me.tsbtnNewPassword.Enabled = bEnable
        Me.tsbtnEditEmpl.Enabled = Not bEnable
        Me.tsbtnNewEmpl.Enabled = Not bEnable
        Me.tsbtnSaveEmpl.Enabled = bEnable
        Me.chkDismissed.Enabled = bEnable
        Me.chkPost.Enabled = Not bEnable
        Me.chkKassa.Enabled = bEnable
        Me.chkInternet.Enabled = bEnable
    End Sub

#Region " Сохранить изменения "
    Private Sub SaveRecord()
        Dim current As Integer = Me.lstEmployees.SelectedIndex ' текущее местонахождение в списке
        Dim oCtl As Object
        Dim strName$

        Me.ErrorProvider1.Clear()

        If Me.txtEmplLastName.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtEmplLastName, "Поле ФИО должно быть заполнено") : Me.txtEmplLastName.Focus() : Exit Sub
        End If

        If Me.txtLogin.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtLogin, "Поле Логин должно быть заполнено") : Me.txtLogin.Focus() : Exit Sub
        End If

        If Me.txtSalary.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtSalary, "Поле оклад должно быть заполнено") : Me.txtSalary.Focus() : Exit Sub
        End If

        If Me.txtOnCard.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtOnCard, "Поле На карту") : Me.txtOnCard.Focus() : Exit Sub
        End If

        If Me.txtPercentEmpl.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtPercentEmpl, "Процент специалиста") : Me.txtPercentEmpl.Focus() : Exit Sub
        End If

        If Me.txtPercentManager.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtPercentManager, "Процент менеджера") : Me.txtPercentManager.Focus() : Exit Sub
        End If

        If Me.cmbOffice.SelectedIndex = -1 Then
            Me.ErrorProvider1.SetError(Me.cmbOffice, "Офис должен быть выбран") : Me.cmbOffice.Focus() : Exit Sub
            ' MsgBox("Офис работы должен быть указан", MsgBoxStyle.Information, appName) : Exit Sub
        End If

        If Me.cmbPrava.SelectedIndex = -1 Then
            Me.ErrorProvider1.SetError(Me.cmbPrava, "Права должны быть определены") : Me.cmbPrava.Focus() : Exit Sub
            '   MsgBox("Права доступа должны быть назначены", MsgBoxStyle.Information, appName) : Exit Sub
        End If

        If Me.cmbDepartment.SelectedIndex = -1 Then
            Me.ErrorProvider1.SetError(Me.cmbDepartment, "Поле Департамент должно быть заполнено") : Me.cmbDepartment.Focus() : Exit Sub
            ' MsgBox("Не задан департамент для сотрудника", MsgBoxStyle.Information, appName) : Exit Sub
        End If

        If mblnAdd = True Then
            'If Me.txtNewPasword.Enabled = False Then
            '    MsgBox("Необходимо задать пароль для нового сотрудника", MsgBoxStyle.Critical, appName) : Exit Sub
            'End If

            mdrEmplIndiv = mdsEmplIndiv.Tables("Employees").NewRow
        End If

        mdrEmplIndiv.BeginEdit() 'приступить к редактированию строки

        Try
            For Each oCtl In Me.tlpEmpl.Controls 'Проверить текстовые поля
                If TypeOf oCtl Is TextBox Or TypeOf oCtl Is MaskedTextBox Then
                    strName = Mid(oCtl.Name, 4)

                    Try 'ошибки игнорируются
                        mdrEmplIndiv(strName) = Trim(oCtl.text)
                    Catch oexp As System.Exception
                    End Try
                End If
            Next

            If mbNewPassword = True Then 'хэшируем пароль
                If Trim(Me.txtNewPasword.Text) = "" Then MsgBox("Поле Пароль должно быть заполнено", MsgBoxStyle.Critical, appName) : Me.txtNewPasword.Focus() : Exit Sub

                Dim Hashhelper As New HashHelper.HashHelper()
                Dim SaltedPasswordHash As Byte()

                SaltedPasswordHash = Hashhelper.CreateDBPassword(Trim(Me.txtNewPasword.Text))
                mdrEmplIndiv("password") = SaltedPasswordHash
            End If

            mdrEmplIndiv("ofID") = Me.cmbOffice.SelectedItem(0)
            mdrEmplIndiv("postID") = Me.cmbPost.SelectedItem(0)
            mdrEmplIndiv("wageSystemID") = Me.cmbWageSystem.SelectedItem(0)
            mdrEmplIndiv("prava") = Me.cmbPrava.SelectedIndex
            mdrEmplIndiv("kassa") = Me.chkKassa.Checked
            mdrEmplIndiv("dismissed") = Me.chkDismissed.Checked
            mdrEmplIndiv("departmentID") = Me.cmbDepartment.SelectedItem(0)
            mdrEmplIndiv("inetOrders") = Me.chkInternet.Checked
            'Catch oexp As System.Exception
            '    MessageBox.Show("Error Occured:" & oexp.Message)
            'End Try

            mdrEmplIndiv.EndEdit() 'Завершить редактирование строки данных

            '  Try

            If mblnAdd = True Then
                mdsEmplIndiv.Tables("Employees").Rows.Add(mdrEmplIndiv)
            End If

            Dim ocbMatIndiv As SqlClient.SqlCommandBuilder  'создать экземпляр пострителя команды

            ocbMatIndiv = New SqlClient.SqlCommandBuilder(modaEmplIndiv)

            If mblnAdd = True Then
                modaEmplIndiv.InsertCommand = ocbMatIndiv.GetInsertCommand  ' Обеспечить создание оператора Insert SQL
            Else
                modaEmplIndiv.UpdateCommand = ocbMatIndiv.GetUpdateCommand
            End If

            modaEmplIndiv.Update(mdsEmplIndiv, "Employees") 'выполнить команду SQL и закрыть соед.
            mdsEmplIndiv.Tables("Employees").AcceptChanges()

            ActivateEditing(False)
            NewPassword(False)

            'LoadList()

            If mblnAdd = True Then
                modaEmplIndiv.InsertCommand.Connection.Close() 'закрыть соединение

                LoadList()
                Me.lstEmployees.SelectedIndex = Me.lstEmployees.Items.Count - 1 ' Если добавили компанию то перемещаемся в конец
            Else
                modaEmplIndiv.UpdateCommand.Connection.Close()
                LoadList()
                If Me.chkDismissed.Checked = False Then
                    Me.lstEmployees.SelectedIndex = current ' Если редактировали то возвращаемся к ней
                End If
            End If
        Catch excData As System.Exception
            MessageBox.Show("Персонал:" & excData.Message, appName)
        End Try
    End Sub
#End Region

    Private Sub lstEmployees_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmployees.SelectedIndexChanged
        LoadIndividual()
    End Sub
    '
    '
    '********************************************
    '
    '
    ' Структура
    Dim mdsPartIndiv As New DataSet
    Dim mdsServiceIndiv As New DataSet
    Dim modaServiceIndiv As SqlClient.SqlDataAdapter

    Dim modaPartIndiv As SqlClient.SqlDataAdapter
    Dim mdrPartIndiv, mdrServiceIndiv As DataRow
    Dim fragment$, selectedType%

    ' Dim ocnn As New OleDb.OleDbConnection(mcnnInt)
    Dim ocmd As New SqlClient.SqlCommand
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip


    Private Sub NewPassword(ByVal npEnabled As Boolean)
        If npEnabled Then
            Me.txtNewPasword.Enabled = True
            Me.txtNewPasword.BackColor() = System.Drawing.Color.White
            Me.txtNewPasword.Focus()
            mbNewPassword = True
        Else
            Me.txtNewPasword.Text = ""
            Me.txtNewPasword.Enabled = False
            Me.txtNewPasword.BackColor() = Me.BackColor
            mbNewPassword = False
        End If
    End Sub

#Region " Правое меню "
    Private Sub tsbtnNewEmpl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNewEmpl.Click
        Me.cmbStatusEmpl.SelectedIndex = 0
        Me.cmbSorting.SelectedIndex = 1

        Dim oCtl As Object
        Dim strName$

        mblnAdd = True

        For Each oCtl In Me.tlpEmpl.Controls
            If TypeOf oCtl Is TextBox Then
                strName = Mid(oCtl.Name, 4)
                Try
                    oCtl.text = ""
                Catch oexp As System.Exception
                End Try
            End If
        Next

        Me.cmbOffice.SelectedIndex = -1

        ActivateEditing(True)
        NewPassword(True) 'разрешаем ввести пароль

        Me.txtEmplLastName.Focus()

        kodDostupa()
    End Sub

    Private Sub tsbtnEditEmpl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditEmpl.Click
        mblnAdd = False

        ActivateEditing(True)
    End Sub

    Private Sub tsbtnSaveEmpl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSaveEmpl.Click
        SaveRecord()
    End Sub

    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        'Скрыть фин данные
        For Each c As Object In Me.tlpEmpl.Controls 'ob.Parent.Controls
            If c.Tag = "fzp" Then
                c.Visible = False
            End If
        Next
        Me.tsbtnDostupFZP.Enabled = True

        '***********

        NewPassword(False)

        mblnAdd = False

        LoadIndividual()
        ActivateEditing(False)
        NewPassword(False)


    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click

        'Select Case MsgBox(Prompt:="Закрыть справочник? ", Buttons:=vbYesNo, Title:="Perfect")
        '    Case Is = vbYes
        Me.Close()
        '    Case Is = vbNo
        '        Exit Sub
        'End Select
    End Sub

    Private Sub tsbtnNewPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNewPassword.Click
        NewPassword(True)
    End Sub
#End Region

    Private Sub cmbStatusEmpl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatusEmpl.SelectedIndexChanged
        If Me.cmbSorting.SelectedIndex <> -1 Then
            LoadList()
        End If
    End Sub

    Friend eBtn As System.Windows.Forms.Button ' Дружественная кнопка, тоесть она будет доступна всей сборке, где она была объявлена
    Friend eTxt As System.Windows.Forms.TextBox
    Friend mForm As System.Windows.Forms.Form
    '  Public Event KeyDown As KeyEventHandler

    Private Sub tsbtnDostupFZP_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnDostupFZP.Click
        kodDostupa()
    End Sub

    Private Sub kodDostupa()
        mForm = New System.Windows.Forms.Form

        mForm.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        mForm.Icon = Me.Icon
        mForm.Text = "Код доступа"

        eTxt = New TextBox 'System.Windows.Forms.TextBox
        Dim elLabel As New Label
        eBtn = New Button

        ' и т.д. создаем элементы и добавляем их на форму
        eBtn.Text = "Ok"
        eBtn.Visible = True
        eBtn.Dock = DockStyle.Top
        AddHandler eBtn.Click, AddressOf eBtn_Click ' Обработка события Click
        mForm.Controls.Add(eBtn)

        eTxt.AutoSize = True
        eTxt.PasswordChar = "*"
        'eTxt.Text = ""
        eTxt.Dock = DockStyle.Top
        eTxt.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        AddHandler eTxt.KeyDown, AddressOf eTxt_KeyDown ' Обработка события 

        mForm.Controls.Add(eTxt)

        elLabel.AutoSize = True
        elLabel.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        elLabel.Text = "Пароль"
        mForm.Controls.Add(elLabel)
        elLabel.Dock = DockStyle.Top

        mForm.MaximizeBox = False
        mForm.AutoSize = True
        mForm.Show()
        eTxt.Focus()
    End Sub

    '  Private Shell As IWshRuntimeLibrary.WshShell

    'Private Sub SendKeys(ByVal key As String)
    '    Shell.SendKeys(key)
    '    If key = Keys.Enter Then
    '        Proverka(eTxt.Text)
    '    End If
    'End Sub

    Private Sub eTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Proverka(eTxt.Text)
        End If
        '  e.Handled = True
    End Sub

    'Private Sub eTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then   Proverka(eTxt.Text)
    '    e.Handled = True
    'End Sub


    Private Sub eBtn_Click(sender As System.Object, e As System.EventArgs)
        Proverka(eTxt.Text)
    End Sub

    Private Sub Proverka(ttt As String)
        'If Len(ttt) = 0 Then
        '    MsgBox("Доступ запрещен.", MessageBoxIcon.Error, appName) : Exit Sub
        'Else
        If ttt = "197630" Then
            Dim c As Control

            For Each c In Me.tlpEmpl.Controls 'ob.Parent.Controls
                If c.Tag = "fzp" Then
                    c.Visible = True
                End If
            Next
            Me.tsbtnDostupFZP.Enabled = False
        Else
            MsgBox("Доступ запрещен.", MessageBoxIcon.Error, appName)
        End If

        mForm.Close()

        'End If
    End Sub


    Private Sub cmbWageSystem_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbWageSystem.SelectedIndexChanged
        Me.Label15.Text = Module1.NonQuery1ScalarString("SELECT description FROM  fin_WageSystem WHERE ID = " & Me.cmbWageSystem.SelectedItem(0) & "")
    End Sub

    Private Sub cmbSorting_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSorting.SelectedIndexChanged
        If Me.cmbSorting.SelectedIndex <> -1 Then
            LoadList()
        End If
    End Sub


    Private Sub cmbPostFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPostFilter.SelectedIndexChanged
        LoadList()
    End Sub

   
    Private Sub chkPost_CheckedChanged(sender As Object, e As EventArgs) Handles chkPost.CheckedChanged
        If Me.chkPost.Checked = True Then
            Me.cmbPostFilter.Enabled = True
            Me.cmbPostFilter.Focus()
        Else
            Me.cmbPostFilter.SelectedIndex = -1
            Me.cmbPostFilter.Enabled = False
        End If
    End Sub
End Class
