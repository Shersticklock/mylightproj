Public Class frmOrganizations
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstPartners As System.Windows.Forms.ListBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtAdressF As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents txtBik As System.Windows.Forms.TextBox
    Friend WithEvents txtOkpo As System.Windows.Forms.TextBox
    Friend WithEvents txtOkonx As System.Windows.Forms.TextBox
    Friend WithEvents txtInn As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAdressUr As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtrShet As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtkShet As System.Windows.Forms.TextBox
    Friend WithEvents txtTel2 As System.Windows.Forms.TextBox
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DesCust As System.Windows.Forms.TabControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Parametr As System.Windows.Forms.TabPage
    Friend WithEvents Kontakt As System.Windows.Forms.TabPage
    Friend WithEvents Rekvizit As System.Windows.Forms.TabPage
    Friend WithEvents txtDoublName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtemplID As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtdataCreate As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtfio2 As System.Windows.Forms.TextBox
    Friend WithEvents txtfio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtpost1 As System.Windows.Forms.TextBox
    Friend WithEvents txtpost2 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents tlpParam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpContact As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRekvizit As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtkpp As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnFindCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKA As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbKAgent As System.Windows.Forms.ComboBox
    Friend WithEvents txtNDS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtshortName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcustID As System.Windows.Forms.TextBox
    Friend WithEvents dogovor As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpDogovor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtNomDog As System.Windows.Forms.TextBox
    Friend WithEvents cmbKAdog As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents dtpDateStartDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFinDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents chkСanceled As System.Windows.Forms.CheckBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents nudOtsrochka As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSaveDogovor As System.Windows.Forms.Button
    Friend WithEvents dgDogovor As System.Windows.Forms.DataGridView
    Friend WithEvents cmsDog As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДобавитьДоговорToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РедактироватьДоговорToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkClosed As System.Windows.Forms.CheckBox
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrganizations))
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lstPartners = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAdressF = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfax = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtrShet = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtkShet = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAdressUr = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.txtBik = New System.Windows.Forms.TextBox()
        Me.txtOkpo = New System.Windows.Forms.TextBox()
        Me.txtOkonx = New System.Windows.Forms.TextBox()
        Me.txtInn = New System.Windows.Forms.TextBox()
        Me.DesCust = New System.Windows.Forms.TabControl()
        Me.Kontakt = New System.Windows.Forms.TabPage()
        Me.tlpContact = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbKA = New System.Windows.Forms.ComboBox()
        Me.txtshortName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Parametr = New System.Windows.Forms.TabPage()
        Me.tlpParam = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNDS = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtemplID = New System.Windows.Forms.TextBox()
        Me.txtpost1 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtfio1 = New System.Windows.Forms.TextBox()
        Me.txtpost2 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtdataCreate = New System.Windows.Forms.TextBox()
        Me.txtfio2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtcustID = New System.Windows.Forms.TextBox()
        Me.chkClosed = New System.Windows.Forms.CheckBox()
        Me.Rekvizit = New System.Windows.Forms.TabPage()
        Me.tlpRekvizit = New System.Windows.Forms.TableLayoutPanel()
        Me.txtkpp = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dogovor = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgDogovor = New System.Windows.Forms.DataGridView()
        Me.cmsDog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьДоговорToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактироватьДоговорToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpDogovor = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNomDog = New System.Windows.Forms.TextBox()
        Me.cmbKAdog = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtpDateStartDog = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFinDog = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.chkСanceled = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.nudOtsrochka = New System.Windows.Forms.NumericUpDown()
        Me.btnSaveDogovor = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDoublName = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsCompany = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnFindCust = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbKAgent = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DesCust.SuspendLayout
        Me.Kontakt.SuspendLayout
        Me.tlpContact.SuspendLayout
        Me.Parametr.SuspendLayout
        Me.tlpParam.SuspendLayout
        Me.Rekvizit.SuspendLayout
        Me.tlpRekvizit.SuspendLayout
        Me.dogovor.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        CType(Me.dgDogovor,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsDog.SuspendLayout
        Me.tlpDogovor.SuspendLayout
        CType(Me.nudOtsrochka,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.StatusStrip1.SuspendLayout
        Me.tsCompany.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'txtTel
        '
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTel.Location = New System.Drawing.Point(231, 94)
        Me.txtTel.MaxLength = 45
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(411, 24)
        Me.txtTel.TabIndex = 1
        '
        'lstPartners
        '
        Me.lstPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPartners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPartners.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstPartners.HorizontalScrollbar = true
        Me.lstPartners.ItemHeight = 17
        Me.lstPartners.Location = New System.Drawing.Point(3, 68)
        Me.lstPartners.Name = "lstPartners"
        Me.lstPartners.Size = New System.Drawing.Size(469, 629)
        Me.lstPartners.TabIndex = 9
        Me.lstPartners.TabStop = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(3, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Телефон"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.CausesValidation = false
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtEmail.Location = New System.Drawing.Point(231, 214)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(411, 24)
        Me.txtEmail.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(222, 30)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Email"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdressF
        '
        Me.txtAdressF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdressF.CausesValidation = false
        Me.txtAdressF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAdressF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtAdressF.Location = New System.Drawing.Point(231, 244)
        Me.txtAdressF.MaxLength = 250
        Me.txtAdressF.Multiline = true
        Me.txtAdressF.Name = "txtAdressF"
        Me.txtAdressF.Size = New System.Drawing.Size(411, 349)
        Me.txtAdressF.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(145, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 30)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "ИНН"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtContact.Location = New System.Drawing.Point(231, 184)
        Me.txtContact.MaxLength = 250
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(411, 24)
        Me.txtContact.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(3, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(222, 30)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Контакт"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 30)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Телефон 2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtfax
        '
        Me.txtfax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfax.CausesValidation = false
        Me.txtfax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtfax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtfax.Location = New System.Drawing.Point(231, 154)
        Me.txtfax.MaxLength = 45
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(411, 24)
        Me.txtfax.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 151)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(222, 30)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Факс"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTel2
        '
        Me.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel2.CausesValidation = false
        Me.txtTel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTel2.Location = New System.Drawing.Point(231, 124)
        Me.txtTel2.MaxLength = 45
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(411, 24)
        Me.txtTel2.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(153, 202)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 30)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Р/С"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtrShet
        '
        Me.txtrShet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrShet.CausesValidation = false
        Me.txtrShet.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtrShet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtrShet.Location = New System.Drawing.Point(192, 205)
        Me.txtrShet.MaxLength = 50
        Me.txtrShet.Name = "txtrShet"
        Me.txtrShet.Size = New System.Drawing.Size(450, 24)
        Me.txtrShet.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(112, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 30)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "Кор. счет"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtkShet
        '
        Me.txtkShet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkShet.CausesValidation = false
        Me.txtkShet.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtkShet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtkShet.Location = New System.Drawing.Point(192, 175)
        Me.txtkShet.MaxLength = 50
        Me.txtkShet.Name = "txtkShet"
        Me.txtkShet.Size = New System.Drawing.Size(450, 24)
        Me.txtkShet.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(3, 262)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(183, 334)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Адрес юридический"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdressUr
        '
        Me.txtAdressUr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtAdressUr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdressUr.CausesValidation = false
        Me.txtAdressUr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtAdressUr.Location = New System.Drawing.Point(192, 265)
        Me.txtAdressUr.MaxLength = 250
        Me.txtAdressUr.Multiline = true
        Me.txtAdressUr.Name = "txtAdressUr"
        Me.txtAdressUr.Size = New System.Drawing.Size(450, 328)
        Me.txtAdressUr.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 241)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(222, 355)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Адрес фактический"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label16.Location = New System.Drawing.Point(136, 232)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 30)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "ОГРН"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label15.Location = New System.Drawing.Point(133, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 30)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "ОКПО"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(147, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 30)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "БИК"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(3, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(183, 52)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Наименование банка"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBank
        '
        Me.txtBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBank.CausesValidation = false
        Me.txtBank.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtBank.Location = New System.Drawing.Point(192, 123)
        Me.txtBank.MaxLength = 250
        Me.txtBank.Multiline = true
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(450, 46)
        Me.txtBank.TabIndex = 4
        '
        'txtBik
        '
        Me.txtBik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBik.CausesValidation = false
        Me.txtBik.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBik.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtBik.Location = New System.Drawing.Point(192, 93)
        Me.txtBik.MaxLength = 20
        Me.txtBik.Name = "txtBik"
        Me.txtBik.Size = New System.Drawing.Size(450, 24)
        Me.txtBik.TabIndex = 3
        '
        'txtOkpo
        '
        Me.txtOkpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOkpo.CausesValidation = false
        Me.txtOkpo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtOkpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtOkpo.Location = New System.Drawing.Point(192, 63)
        Me.txtOkpo.MaxLength = 50
        Me.txtOkpo.Name = "txtOkpo"
        Me.txtOkpo.Size = New System.Drawing.Size(450, 24)
        Me.txtOkpo.TabIndex = 2
        '
        'txtOkonx
        '
        Me.txtOkonx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOkonx.CausesValidation = false
        Me.txtOkonx.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtOkonx.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtOkonx.Location = New System.Drawing.Point(192, 235)
        Me.txtOkonx.MaxLength = 50
        Me.txtOkonx.Name = "txtOkonx"
        Me.txtOkonx.Size = New System.Drawing.Size(450, 24)
        Me.txtOkonx.TabIndex = 7
        '
        'txtInn
        '
        Me.txtInn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInn.CausesValidation = false
        Me.txtInn.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtInn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtInn.Location = New System.Drawing.Point(192, 3)
        Me.txtInn.MaxLength = 12
        Me.txtInn.Name = "txtInn"
        Me.txtInn.Size = New System.Drawing.Size(450, 24)
        Me.txtInn.TabIndex = 0
        '
        'DesCust
        '
        Me.DesCust.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.DesCust.Controls.Add(Me.Kontakt)
        Me.DesCust.Controls.Add(Me.Parametr)
        Me.DesCust.Controls.Add(Me.Rekvizit)
        Me.DesCust.Controls.Add(Me.dogovor)
        Me.DesCust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DesCust.Location = New System.Drawing.Point(478, 68)
        Me.DesCust.Name = "DesCust"
        Me.DesCust.SelectedIndex = 0
        Me.DesCust.Size = New System.Drawing.Size(653, 629)
        Me.DesCust.TabIndex = 0
        '
        'Kontakt
        '
        Me.Kontakt.Controls.Add(Me.tlpContact)
        Me.Kontakt.Location = New System.Drawing.Point(4, 29)
        Me.Kontakt.Name = "Kontakt"
        Me.Kontakt.Size = New System.Drawing.Size(645, 596)
        Me.Kontakt.TabIndex = 5
        Me.Kontakt.Text = "Контакт"
        Me.Kontakt.UseVisualStyleBackColor = true
        '
        'tlpContact
        '
        Me.tlpContact.ColumnCount = 2
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228!))
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpContact.Controls.Add(Me.Label1, 0, 0)
        Me.tlpContact.Controls.Add(Me.txtAdressF, 1, 8)
        Me.tlpContact.Controls.Add(Me.txtfax, 1, 5)
        Me.tlpContact.Controls.Add(Me.Label17, 0, 8)
        Me.tlpContact.Controls.Add(Me.txtEmail, 1, 7)
        Me.tlpContact.Controls.Add(Me.Label22, 0, 5)
        Me.tlpContact.Controls.Add(Me.Label6, 0, 4)
        Me.tlpContact.Controls.Add(Me.Label10, 0, 1)
        Me.tlpContact.Controls.Add(Me.txtContact, 1, 6)
        Me.tlpContact.Controls.Add(Me.txtTel, 1, 3)
        Me.tlpContact.Controls.Add(Me.Label2, 0, 3)
        Me.tlpContact.Controls.Add(Me.txtTel2, 1, 4)
        Me.tlpContact.Controls.Add(Me.Label12, 0, 6)
        Me.tlpContact.Controls.Add(Me.Label8, 0, 7)
        Me.tlpContact.Controls.Add(Me.txtName, 1, 1)
        Me.tlpContact.Controls.Add(Me.cmbKA, 1, 0)
        Me.tlpContact.Controls.Add(Me.txtshortName, 1, 2)
        Me.tlpContact.Controls.Add(Me.Label5, 0, 2)
        Me.tlpContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContact.Location = New System.Drawing.Point(0, 0)
        Me.tlpContact.Name = "tlpContact"
        Me.tlpContact.RowCount = 9
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.Size = New System.Drawing.Size(645, 596)
        Me.tlpContact.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 31)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Контрагент"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(3, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(222, 30)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Наименование в программе"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtName.Location = New System.Drawing.Point(231, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(411, 24)
        Me.txtName.TabIndex = 0
        '
        'cmbKA
        '
        Me.cmbKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbKA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbKA.FormattingEnabled = true
        Me.cmbKA.Location = New System.Drawing.Point(231, 3)
        Me.cmbKA.Name = "cmbKA"
        Me.cmbKA.Size = New System.Drawing.Size(411, 25)
        Me.cmbKA.TabIndex = 75
        Me.cmbKA.Visible = false
        '
        'txtshortName
        '
        Me.txtshortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtshortName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtshortName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtshortName.Location = New System.Drawing.Point(231, 64)
        Me.txtshortName.Name = "txtshortName"
        Me.txtshortName.Size = New System.Drawing.Size(411, 24)
        Me.txtshortName.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(3, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 30)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Наименование в документах"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Parametr
        '
        Me.Parametr.Controls.Add(Me.tlpParam)
        Me.Parametr.Location = New System.Drawing.Point(4, 29)
        Me.Parametr.Name = "Parametr"
        Me.Parametr.Size = New System.Drawing.Size(645, 596)
        Me.Parametr.TabIndex = 3
        Me.Parametr.Text = "Параметры"
        Me.Parametr.UseVisualStyleBackColor = true
        '
        'tlpParam
        '
        Me.tlpParam.AutoSize = true
        Me.tlpParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpParam.ColumnCount = 2
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.Controls.Add(Me.txtNDS, 1, 5)
        Me.tlpParam.Controls.Add(Me.Label27, 0, 2)
        Me.tlpParam.Controls.Add(Me.txtemplID, 1, 7)
        Me.tlpParam.Controls.Add(Me.txtpost1, 1, 1)
        Me.tlpParam.Controls.Add(Me.Label30, 0, 3)
        Me.tlpParam.Controls.Add(Me.txtfio1, 1, 2)
        Me.tlpParam.Controls.Add(Me.txtpost2, 1, 3)
        Me.tlpParam.Controls.Add(Me.Label29, 0, 7)
        Me.tlpParam.Controls.Add(Me.txtdataCreate, 1, 6)
        Me.tlpParam.Controls.Add(Me.txtfio2, 1, 4)
        Me.tlpParam.Controls.Add(Me.Label25, 0, 4)
        Me.tlpParam.Controls.Add(Me.Label28, 0, 6)
        Me.tlpParam.Controls.Add(Me.Label11, 0, 5)
        Me.tlpParam.Controls.Add(Me.Label26, 0, 1)
        Me.tlpParam.Controls.Add(Me.txtcustID, 1, 8)
        Me.tlpParam.Controls.Add(Me.chkClosed, 0, 0)
        Me.tlpParam.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpParam.Location = New System.Drawing.Point(0, 0)
        Me.tlpParam.Name = "tlpParam"
        Me.tlpParam.RowCount = 9
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.Size = New System.Drawing.Size(645, 268)
        Me.tlpParam.TabIndex = 0
        '
        'txtNDS
        '
        Me.txtNDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNDS.CausesValidation = false
        Me.txtNDS.Location = New System.Drawing.Point(200, 151)
        Me.txtNDS.MaxLength = 2
        Me.txtNDS.Name = "txtNDS"
        Me.txtNDS.Size = New System.Drawing.Size(82, 24)
        Me.txtNDS.TabIndex = 4
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label27.Location = New System.Drawing.Point(48, 58)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(146, 30)
        Me.Label27.TabIndex = 60
        Me.Label27.Text = "ФИО руководителя"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtemplID
        '
        Me.txtemplID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemplID.CausesValidation = false
        Me.txtemplID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtemplID.Enabled = false
        Me.txtemplID.Location = New System.Drawing.Point(200, 211)
        Me.txtemplID.Name = "txtemplID"
        Me.txtemplID.Size = New System.Drawing.Size(442, 24)
        Me.txtemplID.TabIndex = 7
        '
        'txtpost1
        '
        Me.txtpost1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpost1.CausesValidation = false
        Me.txtpost1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtpost1.Location = New System.Drawing.Point(200, 31)
        Me.txtpost1.MaxLength = 50
        Me.txtpost1.Name = "txtpost1"
        Me.txtpost1.Size = New System.Drawing.Size(442, 24)
        Me.txtpost1.TabIndex = 0
        '
        'Label30
        '
        Me.Label30.AutoSize = true
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label30.Location = New System.Drawing.Point(24, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(170, 30)
        Me.Label30.TabIndex = 61
        Me.Label30.Text = "Должность бухгалтера"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtfio1
        '
        Me.txtfio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfio1.CausesValidation = false
        Me.txtfio1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtfio1.Location = New System.Drawing.Point(200, 61)
        Me.txtfio1.MaxLength = 50
        Me.txtfio1.Name = "txtfio1"
        Me.txtfio1.Size = New System.Drawing.Size(442, 24)
        Me.txtfio1.TabIndex = 1
        '
        'txtpost2
        '
        Me.txtpost2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpost2.CausesValidation = false
        Me.txtpost2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtpost2.Location = New System.Drawing.Point(200, 91)
        Me.txtpost2.MaxLength = 50
        Me.txtpost2.Name = "txtpost2"
        Me.txtpost2.Size = New System.Drawing.Size(442, 24)
        Me.txtpost2.TabIndex = 2
        '
        'Label29
        '
        Me.Label29.AutoSize = true
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label29.Location = New System.Drawing.Point(93, 208)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(101, 30)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "Автор записи"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdataCreate
        '
        Me.txtdataCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdataCreate.CausesValidation = false
        Me.txtdataCreate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdataCreate.Enabled = false
        Me.txtdataCreate.Location = New System.Drawing.Point(200, 181)
        Me.txtdataCreate.Name = "txtdataCreate"
        Me.txtdataCreate.Size = New System.Drawing.Size(442, 24)
        Me.txtdataCreate.TabIndex = 6
        '
        'txtfio2
        '
        Me.txtfio2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfio2.CausesValidation = false
        Me.txtfio2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtfio2.Location = New System.Drawing.Point(200, 121)
        Me.txtfio2.MaxLength = 50
        Me.txtfio2.Name = "txtfio2"
        Me.txtfio2.Size = New System.Drawing.Size(442, 24)
        Me.txtfio2.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label25.Location = New System.Drawing.Point(69, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 30)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "ФИО бухгалтера"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label28.Location = New System.Drawing.Point(81, 178)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(113, 30)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Дата создания"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.Location = New System.Drawing.Point(77, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 30)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Ставка НДС, %"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label26.Location = New System.Drawing.Point(3, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(191, 30)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "Должность руководителя"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcustID
        '
        Me.txtcustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustID.Location = New System.Drawing.Point(200, 241)
        Me.txtcustID.Name = "txtcustID"
        Me.txtcustID.Size = New System.Drawing.Size(87, 24)
        Me.txtcustID.TabIndex = 64
        '
        'chkClosed
        '
        Me.chkClosed.AutoSize = true
        Me.tlpParam.SetColumnSpan(Me.chkClosed, 2)
        Me.chkClosed.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkClosed.Enabled = false
        Me.chkClosed.Location = New System.Drawing.Point(374, 3)
        Me.chkClosed.Name = "chkClosed"
        Me.chkClosed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkClosed.Size = New System.Drawing.Size(268, 22)
        Me.chkClosed.TabIndex = 65
        Me.chkClosed.Text = "Не используется (ликвидировано)"
        Me.chkClosed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkClosed.UseVisualStyleBackColor = true
        '
        'Rekvizit
        '
        Me.Rekvizit.Controls.Add(Me.tlpRekvizit)
        Me.Rekvizit.Location = New System.Drawing.Point(4, 29)
        Me.Rekvizit.Name = "Rekvizit"
        Me.Rekvizit.Size = New System.Drawing.Size(645, 596)
        Me.Rekvizit.TabIndex = 4
        Me.Rekvizit.Text = "Реквизиты"
        Me.Rekvizit.UseVisualStyleBackColor = true
        '
        'tlpRekvizit
        '
        Me.tlpRekvizit.ColumnCount = 2
        Me.tlpRekvizit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189!))
        Me.tlpRekvizit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpRekvizit.Controls.Add(Me.txtInn, 1, 0)
        Me.tlpRekvizit.Controls.Add(Me.txtrShet, 1, 6)
        Me.tlpRekvizit.Controls.Add(Me.Label20, 0, 6)
        Me.tlpRekvizit.Controls.Add(Me.Label9, 0, 0)
        Me.tlpRekvizit.Controls.Add(Me.txtOkonx, 1, 7)
        Me.tlpRekvizit.Controls.Add(Me.txtkShet, 1, 5)
        Me.tlpRekvizit.Controls.Add(Me.Label19, 0, 5)
        Me.tlpRekvizit.Controls.Add(Me.Label15, 0, 2)
        Me.tlpRekvizit.Controls.Add(Me.Label16, 0, 7)
        Me.tlpRekvizit.Controls.Add(Me.txtOkpo, 1, 2)
        Me.tlpRekvizit.Controls.Add(Me.txtBik, 1, 3)
        Me.tlpRekvizit.Controls.Add(Me.txtBank, 1, 4)
        Me.tlpRekvizit.Controls.Add(Me.Label14, 0, 3)
        Me.tlpRekvizit.Controls.Add(Me.Label13, 0, 4)
        Me.tlpRekvizit.Controls.Add(Me.Label18, 0, 8)
        Me.tlpRekvizit.Controls.Add(Me.txtkpp, 1, 1)
        Me.tlpRekvizit.Controls.Add(Me.Label21, 0, 1)
        Me.tlpRekvizit.Controls.Add(Me.txtAdressUr, 1, 8)
        Me.tlpRekvizit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRekvizit.Location = New System.Drawing.Point(0, 0)
        Me.tlpRekvizit.Name = "tlpRekvizit"
        Me.tlpRekvizit.RowCount = 9
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRekvizit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18!))
        Me.tlpRekvizit.Size = New System.Drawing.Size(645, 596)
        Me.tlpRekvizit.TabIndex = 0
        '
        'txtkpp
        '
        Me.txtkpp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkpp.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtkpp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtkpp.Location = New System.Drawing.Point(192, 33)
        Me.txtkpp.MaxLength = 10
        Me.txtkpp.Name = "txtkpp"
        Me.txtkpp.Size = New System.Drawing.Size(450, 24)
        Me.txtkpp.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(146, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 30)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "КПП"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dogovor
        '
        Me.dogovor.Controls.Add(Me.TableLayoutPanel4)
        Me.dogovor.Location = New System.Drawing.Point(4, 29)
        Me.dogovor.Name = "dogovor"
        Me.dogovor.Padding = New System.Windows.Forms.Padding(3)
        Me.dogovor.Size = New System.Drawing.Size(645, 596)
        Me.dogovor.TabIndex = 6
        Me.dogovor.Text = "Договоры"
        Me.dogovor.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgDogovor, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tlpDogovor, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(639, 590)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'dgDogovor
        '
        Me.dgDogovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDogovor.ContextMenuStrip = Me.cmsDog
        Me.dgDogovor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDogovor.Location = New System.Drawing.Point(3, 3)
        Me.dgDogovor.Name = "dgDogovor"
        Me.dgDogovor.RowTemplate.Height = 24
        Me.dgDogovor.Size = New System.Drawing.Size(633, 334)
        Me.dgDogovor.TabIndex = 2
        '
        'cmsDog
        '
        Me.cmsDog.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsDog.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьДоговорToolStripMenuItem, Me.РедактироватьДоговорToolStripMenuItem})
        Me.cmsDog.Name = "cmsDog"
        Me.cmsDog.Size = New System.Drawing.Size(233, 52)
        '
        'ДобавитьДоговорToolStripMenuItem
        '
        Me.ДобавитьДоговорToolStripMenuItem.Name = "ДобавитьДоговорToolStripMenuItem"
        Me.ДобавитьДоговорToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.ДобавитьДоговорToolStripMenuItem.Text = "Добавить договор"
        '
        'РедактироватьДоговорToolStripMenuItem
        '
        Me.РедактироватьДоговорToolStripMenuItem.Name = "РедактироватьДоговорToolStripMenuItem"
        Me.РедактироватьДоговорToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.РедактироватьДоговорToolStripMenuItem.Text = "Редактировать договор "
        '
        'tlpDogovor
        '
        Me.tlpDogovor.AutoSize = true
        Me.tlpDogovor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpDogovor.ColumnCount = 2
        Me.tlpDogovor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDogovor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpDogovor.Controls.Add(Me.Label7, 0, 0)
        Me.tlpDogovor.Controls.Add(Me.Label23, 0, 1)
        Me.tlpDogovor.Controls.Add(Me.txtNomDog, 1, 0)
        Me.tlpDogovor.Controls.Add(Me.cmbKAdog, 1, 1)
        Me.tlpDogovor.Controls.Add(Me.Label32, 0, 3)
        Me.tlpDogovor.Controls.Add(Me.dtpDateStartDog, 1, 3)
        Me.tlpDogovor.Controls.Add(Me.dtpDateFinDog, 1, 4)
        Me.tlpDogovor.Controls.Add(Me.Label33, 0, 4)
        Me.tlpDogovor.Controls.Add(Me.chkСanceled, 0, 5)
        Me.tlpDogovor.Controls.Add(Me.Label34, 0, 2)
        Me.tlpDogovor.Controls.Add(Me.DateTimePicker1, 1, 2)
        Me.tlpDogovor.Controls.Add(Me.Label35, 0, 6)
        Me.tlpDogovor.Controls.Add(Me.nudOtsrochka, 1, 6)
        Me.tlpDogovor.Controls.Add(Me.btnSaveDogovor, 1, 7)
        Me.tlpDogovor.Controls.Add(Me.btnCancel, 0, 7)
        Me.tlpDogovor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDogovor.Location = New System.Drawing.Point(3, 343)
        Me.tlpDogovor.Name = "tlpDogovor"
        Me.tlpDogovor.RowCount = 8
        Me.tlpDogovor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDogovor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDogovor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDogovor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDogovor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDogovor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDogovor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDogovor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDogovor.Size = New System.Drawing.Size(633, 244)
        Me.tlpDogovor.TabIndex = 1
        Me.tlpDogovor.Visible = false
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Номер договора"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.Location = New System.Drawing.Point(3, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(225, 31)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Контрагент-наша компания"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNomDog
        '
        Me.txtNomDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomDog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNomDog.Location = New System.Drawing.Point(234, 3)
        Me.txtNomDog.Name = "txtNomDog"
        Me.txtNomDog.Size = New System.Drawing.Size(396, 24)
        Me.txtNomDog.TabIndex = 2
        '
        'cmbKAdog
        '
        Me.cmbKAdog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbKAdog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKAdog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbKAdog.FormattingEnabled = true
        Me.cmbKAdog.Location = New System.Drawing.Point(234, 33)
        Me.cmbKAdog.Name = "cmbKAdog"
        Me.cmbKAdog.Size = New System.Drawing.Size(396, 25)
        Me.cmbKAdog.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.AutoSize = true
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label32.Location = New System.Drawing.Point(3, 91)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(225, 30)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Дата вступления в силу"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDateStartDog
        '
        Me.dtpDateStartDog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDateStartDog.Location = New System.Drawing.Point(234, 94)
        Me.dtpDateStartDog.Name = "dtpDateStartDog"
        Me.dtpDateStartDog.Size = New System.Drawing.Size(396, 24)
        Me.dtpDateStartDog.TabIndex = 5
        '
        'dtpDateFinDog
        '
        Me.dtpDateFinDog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDateFinDog.Location = New System.Drawing.Point(234, 124)
        Me.dtpDateFinDog.Name = "dtpDateFinDog"
        Me.dtpDateFinDog.Size = New System.Drawing.Size(396, 24)
        Me.dtpDateFinDog.TabIndex = 6
        '
        'Label33
        '
        Me.Label33.AutoSize = true
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label33.Location = New System.Drawing.Point(3, 121)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(225, 30)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Дата завершения"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkСanceled
        '
        Me.chkСanceled.AutoSize = true
        Me.tlpDogovor.SetColumnSpan(Me.chkСanceled, 2)
        Me.chkСanceled.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkСanceled.Location = New System.Drawing.Point(525, 154)
        Me.chkСanceled.Name = "chkСanceled"
        Me.chkСanceled.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkСanceled.Size = New System.Drawing.Size(105, 22)
        Me.chkСanceled.TabIndex = 9
        Me.chkСanceled.Text = "Расторгнут"
        Me.chkСanceled.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkСanceled.UseVisualStyleBackColor = true
        '
        'Label34
        '
        Me.Label34.AutoSize = true
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label34.Location = New System.Drawing.Point(3, 61)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(225, 30)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "Дата"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Location = New System.Drawing.Point(234, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(396, 24)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label35
        '
        Me.Label35.AutoSize = true
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label35.Location = New System.Drawing.Point(3, 179)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(225, 32)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "Дней отсрочки"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudOtsrochka
        '
        Me.nudOtsrochka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudOtsrochka.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudOtsrochka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudOtsrochka.Location = New System.Drawing.Point(234, 182)
        Me.nudOtsrochka.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nudOtsrochka.Name = "nudOtsrochka"
        Me.nudOtsrochka.Size = New System.Drawing.Size(396, 26)
        Me.nudOtsrochka.TabIndex = 13
        Me.nudOtsrochka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSaveDogovor
        '
        Me.btnSaveDogovor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveDogovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveDogovor.Location = New System.Drawing.Point(234, 214)
        Me.btnSaveDogovor.Name = "btnSaveDogovor"
        Me.btnSaveDogovor.Size = New System.Drawing.Size(396, 27)
        Me.btnSaveDogovor.TabIndex = 14
        Me.btnSaveDogovor.Text = "Сохранить"
        Me.btnSaveDogovor.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(3, 214)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(225, 27)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'txtDoublName
        '
        Me.txtDoublName.BackColor = System.Drawing.SystemColors.Window
        Me.txtDoublName.CausesValidation = false
        Me.txtDoublName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDoublName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtDoublName.Location = New System.Drawing.Point(478, 3)
        Me.txtDoublName.Multiline = true
        Me.txtDoublName.Name = "txtDoublName"
        Me.txtDoublName.ReadOnly = true
        Me.txtDoublName.Size = New System.Drawing.Size(653, 59)
        Me.txtDoublName.TabIndex = 55
        Me.txtDoublName.TabStop = false
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 706)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.StatusStrip1.TabIndex = 59
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(141, 19)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'tsCompany
        '
        Me.tsCompany.AutoSize = false
        Me.tsCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsCompany.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.tsbtnEdit, Me.tsbtnSave, Me.tsbtnCancel, Me.tsbtnDelete, Me.tsbtnFindCust, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.tsCompany.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCompany.Location = New System.Drawing.Point(1140, 0)
        Me.tsCompany.Name = "tsCompany"
        Me.tsCompany.Size = New System.Drawing.Size(136, 706)
        Me.tsCompany.TabIndex = 60
        Me.tsCompany.Text = "ToolStrip1"
        '
        'tsbtnNew
        '
        Me.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNew.Image = CType(resources.GetObject("tsbtnNew.Image"),System.Drawing.Image)
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(134, 22)
        Me.tsbtnNew.Text = "Создать"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEdit.Image = CType(resources.GetObject("tsbtnEdit.Image"),System.Drawing.Image)
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(134, 22)
        Me.tsbtnEdit.Text = "Изменить"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"),System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(134, 22)
        Me.tsbtnSave.Text = "Сохранить"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(134, 22)
        Me.tsbtnCancel.Text = "Отменить"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelete.Image = CType(resources.GetObject("tsbtnDelete.Image"),System.Drawing.Image)
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(134, 22)
        Me.tsbtnDelete.Text = "Удалить"
        '
        'tsbtnFindCust
        '
        Me.tsbtnFindCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFindCust.Image = CType(resources.GetObject("tsbtnFindCust.Image"),System.Drawing.Image)
        Me.tsbtnFindCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFindCust.Name = "tsbtnFindCust"
        Me.tsbtnFindCust.Size = New System.Drawing.Size(134, 22)
        Me.tsbtnFindCust.Text = "Поиск"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(134, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.90083!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.09917!))
        Me.TableLayoutPanel2.Controls.Add(Me.lstPartners, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DesCust, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDoublName, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1134, 700)
        Me.TableLayoutPanel2.TabIndex = 62
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbKAgent, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(469, 59)
        Me.TableLayoutPanel3.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 31)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Контрагент"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbKAgent
        '
        Me.cmbKAgent.CausesValidation = false
        Me.cmbKAgent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbKAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKAgent.Enabled = false
        Me.cmbKAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKAgent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbKAgent.FormattingEnabled = true
        Me.cmbKAgent.Location = New System.Drawing.Point(117, 3)
        Me.cmbKAgent.Name = "cmbKAgent"
        Me.cmbKAgent.Size = New System.Drawing.Size(349, 25)
        Me.cmbKAgent.TabIndex = 46
        Me.cmbKAgent.TabStop = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(463, 28)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Юридические лица"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tsCompany, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 706)
        Me.TableLayoutPanel1.TabIndex = 63
        '
        'frmOrganizations
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(1276, 730)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(966, 415)
        Me.Name = "frmOrganizations"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Юридические лица"
        Me.DesCust.ResumeLayout(false)
        Me.Kontakt.ResumeLayout(false)
        Me.tlpContact.ResumeLayout(false)
        Me.tlpContact.PerformLayout
        Me.Parametr.ResumeLayout(false)
        Me.Parametr.PerformLayout
        Me.tlpParam.ResumeLayout(false)
        Me.tlpParam.PerformLayout
        Me.Rekvizit.ResumeLayout(false)
        Me.tlpRekvizit.ResumeLayout(false)
        Me.tlpRekvizit.PerformLayout
        Me.dogovor.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        CType(Me.dgDogovor,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsDog.ResumeLayout(false)
        Me.tlpDogovor.ResumeLayout(false)
        Me.tlpDogovor.PerformLayout
        CType(Me.nudOtsrochka,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.tsCompany.ResumeLayout(false)
        Me.tsCompany.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

    Dim mdsPartIndiv As New DataSet
    Dim modaPartIndiv As SqlClient.SqlDataAdapter
    Dim mdrPartIndiv As DataRow
    Dim mblnAdd As Boolean
    Dim currentID% ' текущее местонахождение в списке
    Dim dtPartList As DataTable

#Region " Загрузка, активация формы "
    Private Sub frmOrganizations_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ActivateEditing(False)

        Try
            Dim odaKAgent As SqlClient.SqlDataAdapter
            Dim dtKAgents As New DataTable

            If openFromKA = True Then
                odaKAgent = New SqlClient.SqlDataAdapter("SELECT ID, name FROM KAgents WHERE ID=" & custID & "", mcnnInt)
            Else
                odaKAgent = New SqlClient.SqlDataAdapter("SELECT ID, name FROM KAgents", mcnnInt)
            End If

            odaKAgent.Fill(dtKAgents)

            Me.cmbKAgent.DataSource = dtKAgents 'Связать данные со списком
            Me.cmbKAgent.DisplayMember = "name"
            Me.cmbKAgent.ValueMember = "ID"
            openFromKA = False

            LoadList()
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " Загрузка лист партнеров "
    Private Sub LoadList()
        Dim strSQL$ = "SELECT custID, (Name + ' ('+coalesce(shortName, 'нет') +')') as Name FROM Organizations WHERE KAgent_ID=" & Me.cmbKAgent.SelectedItem(0) & " order by Name"
        Dim odaPartList As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)

        Try
            dtPartList = New DataTable
            odaPartList.Fill(dtPartList)


            Me.lstPartners.DataSource = dtPartList 'Связать данные со списком
            Me.lstPartners.DisplayMember = "Name"
            Me.lstPartners.ValueMember = "custID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try

        Me.ToolStripStatusLabel1.Text = "В списке организаций: " & dtPartList.Rows.Count.ToString
    End Sub
#End Region

#Region " Поиск партнеров "
    Private Sub FindList(ByVal fragment)
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_Find_Organizations]"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@fragment", SqlDbType.NVarChar))
            cmd.Parameters("@fragment").Value = fragment

            Dim odaPartList As New SqlClient.SqlDataAdapter(cmd)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            '    'Связать данные со списком
            Me.lstPartners.DataSource = dtPartList
            Me.lstPartners.DisplayMember = "Name"
            Me.lstPartners.ValueMember = "custID"
        Catch oexpData As System.SystemException
            MessageBox.Show("Расход материала: " & oexpData.Message, appName)
        End Try
    End Sub
#End Region

#Region " Загрузка персональных данных "
    Private Sub LoadIndividual()
        Dim strName$, strSQL$
        Dim oCtl, oCtl1, oCtl2 As Object
        Dim n% = 0

        mdsPartIndiv.Clear()

        If mblnAdd = True Then
            strSQL = "SELECT * FROM Organizations"
        Else
            strSQL = "SELECT * FROM Organizations WHERE custID='" & Me.lstPartners.SelectedItem(0) & "'"
        End If

        Try
            modaPartIndiv = New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            modaPartIndiv.Fill(mdsPartIndiv, "Organizations")
            mdrPartIndiv = mdsPartIndiv.Tables("Organizations").Rows(0)
        Catch oexpData As OleDb.OleDbException
            MessageBox.Show("Error loading individual data: " & oexpData.Message)
            Exit Sub
        End Try

        For Each oCtl In Me.DesCust.TabPages
            For Each oCtl1 In Me.DesCust.TabPages(n).Controls
                If TypeOf oCtl1 Is TableLayoutPanel Then
                    For Each oCtl2 In oCtl1.Controls
                        If TypeOf oCtl2 Is TextBox Then
                            strName = Mid(oCtl2.name, 4)
                            Try
                                oCtl2.text = mdrPartIndiv(strName).ToString
                            Catch oexp As System.Exception
                            End Try
                        End If
                    Next
                End If
            Next
            n = n + 1
        Next

        Me.txtDoublName.Text = mdrPartIndiv("Name").ToString
        Me.cmbKA.SelectedValue = CInt(mdrPartIndiv("KAgent_ID"))
        Me.chkClosed.Checked = mdrPartIndiv("closed")
        ' End If
    End Sub
#End Region

#Region " Активация редактирования компании "
    Private Sub ActivateEditing(ByVal bEnable As Boolean)
        ' Если редактирование разрешено то перемещение по партнерам запрещено
        If bEnable = False Then Me.lstPartners.Enabled = True Else Me.lstPartners.Enabled = False

        Dim oCtl, oCtl1, oCtl2 As Object
        Dim n As Integer = 0

        For Each oCtl In Me.DesCust.TabPages
            For Each oCtl1 In Me.DesCust.TabPages(n).Controls
                If TypeOf oCtl1 Is TableLayoutPanel Then
                    For Each oCtl2 In oCtl1.Controls
                        If TypeOf oCtl2 Is TextBox Then
                            If bEnable Then
                                oCtl2.BorderStyle() = System.Windows.Forms.BorderStyle.Fixed3D
                                oCtl2.BackColor() = System.Drawing.Color.White
                            Else
                                oCtl2.BorderStyle() = System.Windows.Forms.BorderStyle.FixedSingle
                                oCtl2.BackColor() = System.Drawing.Color.White
                            End If

                            oCtl2.Enabled = bEnable
                        End If

                        If TypeOf oCtl2 Is ComboBox Then
                            If bEnable Then
                                oCtl2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
                                oCtl2.BackColor() = System.Drawing.Color.White
                            Else
                                oCtl2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                                oCtl2.BackColor() = System.Drawing.Color.White
                            End If
                            oCtl2.Enabled = bEnable
                        End If

                        If TypeOf oCtl2 Is CheckBox Then
                            If bEnable Then
                                '  oCtl2.BorderStyle() = System.Windows.Forms.BorderStyle.Fixed3D
                                oCtl2.BackColor() = System.Drawing.Color.White
                            Else
                                '  oCtl2.BorderStyle() = System.Windows.Forms.BorderStyle.FixedSingle
                                oCtl2.BackColor() = System.Drawing.Color.White
                            End If

                            oCtl2.Enabled = bEnable
                        End If
                    Next
                End If
            Next
            n = n + 1
        Next
        'Me.btnSelect.Enabled = Not (bEnable)
        Me.tlpContact.Controls("txtName").Focus()
        Me.tsbtnNew.Visible = True
        Me.tsbtnDelete.Visible = True
        Me.tsbtnEdit.Visible = True
        Me.tsbtnFindCust.Visible = True

        Me.tsbtnSave.Enabled = bEnable


        If mblnAdd = True Then
            mblnAdd = True
            n = 0
            For Each oCtl In Me.DesCust.TabPages
                For Each oCtl1 In Me.DesCust.TabPages(n).Controls
                    If TypeOf oCtl1 Is TableLayoutPanel Then
                        For Each oCtl2 In oCtl1.Controls
                            If TypeOf oCtl2 Is TextBox Then
                                oCtl2.text = ""
                            End If
                        Next
                    End If
                Next
                n = n + 1
            Next

            Me.txtDoublName.Text = Nothing
            Me.tsbtnNew.Visible = False
            Me.tsbtnDelete.Visible = False
            Me.tsbtnEdit.Visible = False
            Me.tsbtnFindCust.Visible = False
        End If

        Me.tsbtnEdit.Enabled = Not bEnable
        Me.tsbtnNew.Enabled = Not bEnable
    End Sub
#End Region

#Region " Сохранить изменения компании "
    Private Sub SaveRecord()
        If Me.txtName.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtName, "Поле наименование должно быть заполнено")
            Me.DesCust.SelectTab(Kontakt)
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtshortName.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtshortName, "Поле Короткое наименование должно быть заполнено")
            Me.DesCust.SelectTab(Kontakt)
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtInn.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtInn, "Не указан ИНН")
            Me.DesCust.SelectTab(Rekvizit)
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.cmbKA.SelectedValue = 1 Then 'наша компания
            If Me.txtNDS.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtNDS, "Не введена ставка НДС")
                Me.DesCust.SelectTab(Parametr)
                Exit Sub
            Else : Me.ErrorProvider1.Clear() : End If

            If Me.txtfio1.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtfio1, "Не введена фамилия руководителя")
                Me.DesCust.SelectTab(Parametr)
                Exit Sub
            Else : Me.ErrorProvider1.Clear() : End If

            If Me.txtfio2.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtfio2, "Не введена фамилия бухгалтера")
                Me.DesCust.SelectTab(Parametr)
                Exit Sub
            Else : Me.ErrorProvider1.Clear() : End If

            If Me.txtpost1.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtpost1, "Не введена должность руководителя")
                Me.DesCust.SelectTab(Parametr)
                Exit Sub
            Else : Me.ErrorProvider1.Clear() : End If

            If Me.txtpost2.Text = "" Then
                Me.ErrorProvider1.SetError(Me.txtpost2, "Не введена должность бухгалтера")
                Me.DesCust.SelectTab(Parametr)
                Exit Sub
            Else : Me.ErrorProvider1.Clear() : End If
        Else ' компания клиент


        End If

        Dim strName$
        Dim oCtl, oCtl1, oCtl2 As Object
        Dim n% = 0

        If mblnAdd = True Then
            mdrPartIndiv = mdsPartIndiv.Tables("Organizations").NewRow
        End If

        mdrPartIndiv.BeginEdit() 'приступить к редактированию строки

        For Each oCtl In Me.DesCust.TabPages
            For Each oCtl1 In Me.DesCust.TabPages(n).Controls
                If TypeOf oCtl1 Is TableLayoutPanel Then
                    For Each oCtl2 In oCtl1.Controls
                        If TypeOf oCtl2 Is TextBox Then
                            strName = Mid(oCtl2.name, 4)
                            Try
                                mdrPartIndiv(strName) = oCtl2.text
                            Catch oexp As System.Exception
                            End Try
                        End If
                    Next
                End If
            Next
            n = n + 1
        Next

        mdrPartIndiv("emplID") = emplID
        mdrPartIndiv("KAgent_ID") = Me.cmbKAgent.SelectedItem(0)
        mdrPartIndiv("closed") = CBool(Me.chkClosed.Checked)

        mdrPartIndiv.EndEdit() 'Завершить редактирование строки данных

        Try
            If mblnAdd = True Then
                Dim k%
                Dim strpp$ = Nothing

                For k = 0 To dtPartList.Rows.Count - 1
                    If Trim(CStr(mdrPartIndiv("Name"))) = Trim(CStr(dtPartList.Rows(k)("Name"))) Then
                        strpp = CStr(strpp) & Trim(CStr(dtPartList.Rows(k)("Name"))) + ", "
                        MsgBox("Нйдены дубли", MessageBoxIcon.Error, appName) : Exit Sub
                    End If
                Next
                mdsPartIndiv.Tables("Organizations").Rows.Add(mdrPartIndiv)
            End If

            Dim ocbPartIndiv As SqlClient.SqlCommandBuilder 'создать экземпляр пострителя команды

            ocbPartIndiv = New SqlClient.SqlCommandBuilder(modaPartIndiv)

            If mblnAdd = True Then
                modaPartIndiv.InsertCommand = ocbPartIndiv.GetInsertCommand ' Обеспечить создание оператора Insert SQL
            Else
                modaPartIndiv.UpdateCommand = ocbPartIndiv.GetUpdateCommand
            End If

            modaPartIndiv.Update(mdsPartIndiv, "Organizations") 'выполнить команду SQL и закрыть соед.
            mdsPartIndiv.Tables("Organizations").AcceptChanges()

            If mblnAdd = True Then
                modaPartIndiv.InsertCommand.Connection.Close()
                mblnAdd = False

                LoadList()
            Else
                modaPartIndiv.UpdateCommand.Connection.Close()
                Me.lstPartners.SelectedIndex = currentID ' Если редактировали компанию то возвращаемся к ней
            End If

            ActivateEditing(False)

            If addcust = True Then
                Me.Close()
            End If
        Catch excData As System.Exception
            MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " Отмена "
    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        Me.ErrorProvider1.Clear()
        mblnAdd = False
        ActivateEditing(False)
        LoadList()
    End Sub
#End Region

#Region " Перемещение по компаниям "
    Private Sub lstPartners_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPartners.SelectedIndexChanged
        LoadIndividual()
    End Sub
#End Region

#Region " Удалить компанию "
    Private Sub tsbtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelete.Click
        ActivateEditing(False)

        If MessageBox.Show("Удалить " & mdrPartIndiv("Name") & "?", appName, MessageBoxButtons.YesNo, _
        MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim ocbPartIndiv As SqlClient.SqlCommandBuilder

            Try
                mdrPartIndiv.Delete()
                ocbPartIndiv = New SqlClient.SqlCommandBuilder(modaPartIndiv)
                modaPartIndiv.DeleteCommand = ocbPartIndiv.GetDeleteCommand
                modaPartIndiv.Update(mdsPartIndiv, "Organizations")
                mdsPartIndiv.Tables("Organizations").AcceptChanges()
                modaPartIndiv.DeleteCommand.Connection.Close()

            Catch excData As System.Exception
                MessageBox.Show("Error Occured:" & excData.Message)
            End Try

            LoadList()
        Else
            Exit Sub
        End If
    End Sub
#End Region

    Private Sub txtCustName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtDoublName.Text = Me.txtName.Text
    End Sub

    Private Sub txtdataCreate_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtdataCreate.Enabled = True Then Me.txtdataCreate.Enabled = False ' запрет редактирования даты
    End Sub

    Private Sub txtemplID_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtemplID.Enabled = True Then Me.txtemplID.Enabled = False ' запрет редактирования автора
    End Sub

#Region " Запрет нажатия ентера  "
    Private Sub txtAdressF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdressF.KeyPress
        If Asc(e.KeyChar) = 13 Then e.Handled = True Else e.Handled = False
    End Sub

    Private Sub txtBank_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBank.KeyPress
        If Asc(e.KeyChar) = 13 Then e.Handled = True Else e.Handled = False
    End Sub

    Private Sub txtAdressUr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdressUr.KeyPress
        If Asc(e.KeyChar) = 13 Then e.Handled = True Else e.Handled = False
    End Sub
#End Region

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadList()
    End Sub

    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        mblnAdd = True
        LoadIndividual()

        ActivateEditing(True)
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        If Me.lstPartners.SelectedIndex = -1 Then
            MsgBox("Не выбрана организация.", MsgBoxStyle.Critical, appName)
        Else
            currentID = Me.lstPartners.SelectedIndex
            mblnAdd = False

            ActivateEditing(True)
        End If
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        Me.ErrorProvider1.Clear()

        If Me.txtInn.Text <> "0" Then
            If CheckINN(Me.txtInn.Text) = True Then
                Dim sql As String = "SELECT COUNT(*) FROM Organizations WHERE inn='" & Me.txtInn.Text & "'"
                Dim countOfSameInn As Integer = Module1.NonQueryScalarInt(sql)
                if (countOfSameInn > 0) Then
                    If (MessageBox.Show(Me, "Юридическое лицо с данным ИНН уже зарегистрировано в программе." +
                        "Вы уверены, что хотите зарегистрировать новое юр. лицо?", appName,
                                         MessageBoxButtons.YesNo) = DialogResult.No) Then
                        Exit Sub
                    End If
                End If

                Dim current As Integer = Me.lstPartners.SelectedIndex

                SaveRecord()
            Else
                MsgBox("Не правильный ИНН.", MsgBoxStyle.Critical, appName)

                Me.DesCust.SelectTab(Rekvizit)
                Me.txtInn.Focus()

                Exit Sub
            End If
        Else
            SaveRecord()
        End If
    End Sub

    Public Function CheckINN(ByVal str As String) As Boolean
        Dim xStep1 As Decimal
        Dim xStep2 As Decimal
        Dim xCnt As Long
        Dim xIs_ok As Long
        If IsNumeric(str) = False Then
            Return False
        End If
        If Val(str) = 0 Then
            Return False
        End If
        xCnt = Len(str)
        xIs_ok = 0
        If xCnt = 10 Then
            xStep1 = Mid(str, 1, 1) * 2 + Mid(str, 2, 1) * 4 + Mid(str, 3, 1) * 10 + Mid(str, 4, 1) * 3 + Mid(str, 5, 1) * 5 + Mid(str, 6, 1) * 9 + Mid(str, 7, 1) * 4 + Mid(str, 8, 1) * 6 + Mid(str, 9, 1) * 8
            xStep2 = xStep1 - Fix((xStep1 / 11)) * 11
            If Val(Mid(str, 10, 1)) = IIf(xStep2 = 10, 0, xStep2) Then
                Return True
            Else
                Return False
            End If
        ElseIf xCnt = 12 Then
            xStep1 = Val(Mid(str, 1, 1)) * 7 + Val(Mid(str, 2, 1)) * 2 + Val(Mid(str, 3, 1)) * 4 + Val(Mid(str, 4, 1)) * 10 + Val(Mid(str, 5, 1)) * 3 + Val(Mid(str, 6, 1)) * 5 + Val(Mid(str, 7, 1)) * 9 + Val(Mid(str, 8, 1)) * 4 + Val(Mid(str, 9, 1)) * 6 + Val(Mid(str, 10, 1)) * 8
            xStep2 = xStep1 - Fix((xStep1 / 11)) * 11
            If Val(Mid(str, 11, 1)) = IIf(xStep2 = 10, 0, xStep2) Then
                xIs_ok = 1
            Else
                Return False
            End If
            'проверка второго контрольного числа
            xStep1 = Val(Mid(str, 1, 1)) * 3 + Val(Mid(str, 2, 1)) * 7 + Val(Mid(str, 3, 1)) * 2 + Val(Mid(str, 4, 1)) * 4 + Val(Mid(str, 5, 1)) * 10 + Val(Mid(str, 6, 1)) * 3 + Val(Mid(str, 7, 1)) * 5 + Val(Mid(str, 8, 1)) * 9 + Val(Mid(str, 9, 1)) * 4 + Val(Mid(str, 10, 1)) * 6 + Val(Mid(str, 11, 1)) * 8
            xStep2 = xStep1 - Fix((xStep1 / 11)) * 11
            If Val(Mid(str, 12, 1)) = IIf(xStep2 = 10, 0, xStep2) And xIs_ok = 1 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub tsbtnFindCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnFindCust.Click
        mblnAdd = False
        ActivateEditing(False)
        FindList(InputBox("Введите часть названия, адреса, телефона", "Поиск контрагента", ""))
    End Sub

    Private Sub tsbtnPerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        custID = Me.lstPartners.SelectedItem(0)

        Dim frmSelect As New frmEmplKA
        frmSelect.ShowDialog()
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbTypesKAgent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKAgent.SelectedIndexChanged
        LoadList()
    End Sub

    Private Sub btnSaveDogovor_Click(sender As Object, e As EventArgs) Handles btnSaveDogovor.Click
        Me.tlpDogovor.Visible = False
    End Sub

    Private Sub ДобавитьДоговорToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьДоговорToolStripMenuItem.Click
        Me.tlpDogovor.Visible = True
    End Sub

    Private Sub РедактироватьДоговорToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РедактироватьДоговорToolStripMenuItem.Click
        Me.tlpDogovor.Visible = True
    End Sub
End Class
