Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class frmKAgents
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
    Friend WithEvents lstPartners As System.Windows.Forms.ListBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DesCust As System.Windows.Forms.TabControl
    Friend WithEvents Parametr As System.Windows.Forms.TabPage
    Friend WithEvents cmbTypesKAgent As System.Windows.Forms.ComboBox
    Friend WithEvents Kontakt As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtdateCreate As System.Windows.Forms.TextBox
    Friend WithEvents tlpParam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpContact As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnFindCust As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnPerson As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTypeK As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOtvManager As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tsbtnOrganization As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Discount As System.Windows.Forms.TabPage
    Friend WithEvents dgDiscount As System.Windows.Forms.DataGridView
    Friend WithEvents tlpRow As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nudDiscount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Web As System.Windows.Forms.TabPage
    Friend WithEvents btnESC As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtWWW As System.Windows.Forms.TextBox
    Friend WithEvents cmbManager As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkAllMan As System.Windows.Forms.CheckBox
    Friend WithEvents chkType As System.Windows.Forms.CheckBox
    Friend WithEvents cmsCoordinate As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ОпределитьКоординатыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbtnWOorders As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnFindEmplKA As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSaveDisc As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbSort As System.Windows.Forms.ComboBox
    Friend WithEvents points As System.Windows.Forms.TabPage
    Friend WithEvents tlpGeoAdress As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtNamePoint As System.Windows.Forms.TextBox
    Friend WithEvents txtAdressGeoPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtGeoPoint As System.Windows.Forms.TextBox
    Friend WithEvents btnGeoSaveKA As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents cmsGeo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents РедактироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKam As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarketing As System.Windows.Forms.ComboBox
    Friend WithEvents txtTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbLoyaltyProgram As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnFindOrg As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgGeoPoints As System.Windows.Forms.DataGridView
    Friend WithEvents tlpAdres As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAddGeopoint As System.Windows.Forms.Button
    Friend WithEvents txtDom As System.Windows.Forms.TextBox
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GoogleMapControl As GMapControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKAgents))
        Me.lstPartners = New System.Windows.Forms.ListBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DesCust = New System.Windows.Forms.TabControl()
        Me.Kontakt = New System.Windows.Forms.TabPage()
        Me.tlpContact = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbTypeK = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWWW = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbMarketing = New System.Windows.Forms.ComboBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Parametr = New System.Windows.Forms.TabPage()
        Me.tlpParam = New System.Windows.Forms.TableLayoutPanel()
        Me.txtdateCreate = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmbOtvManager = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnESC = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbKam = New System.Windows.Forms.ComboBox()
        Me.cmbLoyaltyProgram = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Discount = New System.Windows.Forms.TabPage()
        Me.tlpRow = New System.Windows.Forms.TableLayoutPanel()
        Me.dgDiscount = New System.Windows.Forms.DataGridView()
        Me.nudDiscount = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSaveDisc = New System.Windows.Forms.Button()
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
        Me.points = New System.Windows.Forms.TabPage()
        Me.tlpGeoAdress = New System.Windows.Forms.TableLayoutPanel()
        Me.dgGeoPoints = New System.Windows.Forms.DataGridView()
        Me.cmsGeo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДобавитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpAdres = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnGeoSaveKA = New System.Windows.Forms.Button()
        Me.txtNamePoint = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtGeoPoint = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.txtDom = New System.Windows.Forms.TextBox()
        Me.cmsCoordinate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ОпределитьКоординатыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtAdressGeoPoint = New System.Windows.Forms.TextBox()
        Me.btnAddGeopoint = New System.Windows.Forms.Button()
        Me.Web = New System.Windows.Forms.TabPage()
        Me.GoogleMapControl = New GMap.NET.WindowsForms.GMapControl()
        Me.cmbTypesKAgent = New System.Windows.Forms.ComboBox()
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
        Me.tsbtnPerson = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnOrganization = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnWOorders = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnFindEmplKA = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnFindOrg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAllMan = New System.Windows.Forms.CheckBox()
        Me.chkType = New System.Windows.Forms.CheckBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DesCust.SuspendLayout
        Me.Kontakt.SuspendLayout
        Me.tlpContact.SuspendLayout
        Me.Parametr.SuspendLayout
        Me.tlpParam.SuspendLayout
        Me.Discount.SuspendLayout
        Me.tlpRow.SuspendLayout
        CType(Me.dgDiscount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudDiscount,System.ComponentModel.ISupportInitialize).BeginInit
        Me.points.SuspendLayout
        Me.tlpGeoAdress.SuspendLayout
        CType(Me.dgGeoPoints,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsGeo.SuspendLayout
        Me.tlpAdres.SuspendLayout
        Me.cmsCoordinate.SuspendLayout
        Me.Web.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.StatusStrip1.SuspendLayout
        Me.tsCompany.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.ToolStripContainer1.ContentPanel.SuspendLayout
        Me.ToolStripContainer1.RightToolStripPanel.SuspendLayout
        Me.ToolStripContainer1.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'lstPartners
        '
        Me.lstPartners.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel2.SetColumnSpan(Me.lstPartners, 2)
        Me.lstPartners.DisplayMember = "Name"
        Me.lstPartners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPartners.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstPartners.HorizontalScrollbar = true
        Me.lstPartners.ItemHeight = 17
        Me.lstPartners.Location = New System.Drawing.Point(4, 132)
        Me.lstPartners.Name = "lstPartners"
        Me.lstPartners.Size = New System.Drawing.Size(361, 541)
        Me.lstPartners.TabIndex = 9
        Me.lstPartners.TabStop = false
        Me.lstPartners.ValueMember = "ID"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.CausesValidation = false
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtDescription.Location = New System.Drawing.Point(167, 64)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Multiline = true
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(571, 119)
        Me.txtDescription.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(158, 125)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Описание"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DesCust
        '
        Me.DesCust.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.DesCust.Controls.Add(Me.Kontakt)
        Me.DesCust.Controls.Add(Me.Parametr)
        Me.DesCust.Controls.Add(Me.Discount)
        Me.DesCust.Controls.Add(Me.points)
        Me.DesCust.Controls.Add(Me.Web)
        Me.DesCust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DesCust.Location = New System.Drawing.Point(0, 0)
        Me.DesCust.Name = "DesCust"
        Me.DesCust.SelectedIndex = 0
        Me.DesCust.Size = New System.Drawing.Size(749, 652)
        Me.DesCust.TabIndex = 0
        Me.DesCust.TabStop = false
        '
        'Kontakt
        '
        Me.Kontakt.Controls.Add(Me.tlpContact)
        Me.Kontakt.Location = New System.Drawing.Point(4, 29)
        Me.Kontakt.Name = "Kontakt"
        Me.Kontakt.Size = New System.Drawing.Size(741, 619)
        Me.Kontakt.TabIndex = 5
        Me.Kontakt.Text = "Основное"
        Me.Kontakt.UseVisualStyleBackColor = true
        '
        'tlpContact
        '
        Me.tlpContact.AutoSize = true
        Me.tlpContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpContact.ColumnCount = 2
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164!))
        Me.tlpContact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpContact.Controls.Add(Me.Label1, 0, 0)
        Me.tlpContact.Controls.Add(Me.txtDescription, 1, 2)
        Me.tlpContact.Controls.Add(Me.Label17, 0, 2)
        Me.tlpContact.Controls.Add(Me.Label10, 0, 1)
        Me.tlpContact.Controls.Add(Me.txtName, 1, 1)
        Me.tlpContact.Controls.Add(Me.cmbTypeK, 1, 0)
        Me.tlpContact.Controls.Add(Me.Label5, 0, 3)
        Me.tlpContact.Controls.Add(Me.txtAdress, 1, 3)
        Me.tlpContact.Controls.Add(Me.Label7, 0, 5)
        Me.tlpContact.Controls.Add(Me.Label4, 0, 4)
        Me.tlpContact.Controls.Add(Me.txtWWW, 1, 4)
        Me.tlpContact.Controls.Add(Me.Label15, 0, 6)
        Me.tlpContact.Controls.Add(Me.cmbMarketing, 1, 6)
        Me.tlpContact.Controls.Add(Me.txtTel, 1, 5)
        Me.tlpContact.Controls.Add(Me.Label20, 0, 7)
        Me.tlpContact.Controls.Add(Me.txtEmail, 1, 7)
        Me.tlpContact.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpContact.Location = New System.Drawing.Point(0, 0)
        Me.tlpContact.Name = "tlpContact"
        Me.tlpContact.RowCount = 8
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpContact.Size = New System.Drawing.Size(741, 337)
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
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Тип контрагента"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(3, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 30)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Наименование"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtName.Location = New System.Drawing.Point(167, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(571, 24)
        Me.txtName.TabIndex = 1
        '
        'cmbTypeK
        '
        Me.cmbTypeK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypeK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTypeK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypeK.FormattingEnabled = true
        Me.cmbTypeK.Location = New System.Drawing.Point(167, 3)
        Me.cmbTypeK.Name = "cmbTypeK"
        Me.cmbTypeK.Size = New System.Drawing.Size(571, 25)
        Me.cmbTypeK.TabIndex = 0
        Me.cmbTypeK.TabStop = false
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 30)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Адрес"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdress
        '
        Me.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtAdress.Location = New System.Drawing.Point(167, 189)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(571, 24)
        Me.txtAdress.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(3, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 30)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Телефон"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 30)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Сайт"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWWW
        '
        Me.txtWWW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWWW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWWW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtWWW.Location = New System.Drawing.Point(167, 219)
        Me.txtWWW.Name = "txtWWW"
        Me.txtWWW.Size = New System.Drawing.Size(571, 24)
        Me.txtWWW.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(3, 276)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 31)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Источник"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMarketing
        '
        Me.cmbMarketing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMarketing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMarketing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMarketing.FormattingEnabled = true
        Me.cmbMarketing.Location = New System.Drawing.Point(167, 279)
        Me.cmbMarketing.Name = "cmbMarketing"
        Me.cmbMarketing.Size = New System.Drawing.Size(571, 25)
        Me.cmbMarketing.TabIndex = 6
        '
        'txtTel
        '
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtTel.Location = New System.Drawing.Point(167, 249)
        Me.txtTel.Mask = "(999) 000-00-00"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(571, 24)
        Me.txtTel.TabIndex = 5
        Me.txtTel.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Location = New System.Drawing.Point(3, 307)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(158, 30)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "email"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Location = New System.Drawing.Point(167, 310)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(571, 24)
        Me.txtEmail.TabIndex = 86
        '
        'Parametr
        '
        Me.Parametr.Controls.Add(Me.tlpParam)
        Me.Parametr.Location = New System.Drawing.Point(4, 29)
        Me.Parametr.Name = "Parametr"
        Me.Parametr.Size = New System.Drawing.Size(741, 619)
        Me.Parametr.TabIndex = 3
        Me.Parametr.Text = "Параметры"
        Me.Parametr.UseVisualStyleBackColor = true
        '
        'tlpParam
        '
        Me.tlpParam.ColumnCount = 2
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201!))
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.Controls.Add(Me.txtdateCreate, 1, 0)
        Me.tlpParam.Controls.Add(Me.Label28, 0, 0)
        Me.tlpParam.Controls.Add(Me.cmbOtvManager, 1, 1)
        Me.tlpParam.Controls.Add(Me.Label2, 0, 1)
        Me.tlpParam.Controls.Add(Me.Label8, 0, 2)
        Me.tlpParam.Controls.Add(Me.btnESC, 1, 6)
        Me.tlpParam.Controls.Add(Me.Label6, 0, 3)
        Me.tlpParam.Controls.Add(Me.Label14, 0, 4)
        Me.tlpParam.Controls.Add(Me.ComboBox1, 1, 2)
        Me.tlpParam.Controls.Add(Me.cmbKam, 1, 3)
        Me.tlpParam.Controls.Add(Me.cmbLoyaltyProgram, 1, 4)
        Me.tlpParam.Controls.Add(Me.txtID, 1, 5)
        Me.tlpParam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpParam.Location = New System.Drawing.Point(0, 0)
        Me.tlpParam.Name = "tlpParam"
        Me.tlpParam.RowCount = 7
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6!))
        Me.tlpParam.Size = New System.Drawing.Size(741, 619)
        Me.tlpParam.TabIndex = 0
        '
        'txtdateCreate
        '
        Me.txtdateCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdateCreate.CausesValidation = false
        Me.txtdateCreate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdateCreate.Enabled = false
        Me.txtdateCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtdateCreate.Location = New System.Drawing.Point(204, 3)
        Me.txtdateCreate.Name = "txtdateCreate"
        Me.txtdateCreate.ReadOnly = true
        Me.txtdateCreate.Size = New System.Drawing.Size(534, 24)
        Me.txtdateCreate.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(195, 30)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Дата создания"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOtvManager
        '
        Me.cmbOtvManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOtvManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOtvManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOtvManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOtvManager.FormattingEnabled = true
        Me.cmbOtvManager.Location = New System.Drawing.Point(204, 33)
        Me.cmbOtvManager.Name = "cmbOtvManager"
        Me.cmbOtvManager.Size = New System.Drawing.Size(534, 25)
        Me.cmbOtvManager.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 31)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Ответственный"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 31)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Отрасль"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnESC
        '
        Me.btnESC.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnESC.Location = New System.Drawing.Point(204, 187)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(231, 35)
        Me.btnESC.TabIndex = 75
        Me.btnESC.Text = "Button1"
        Me.btnESC.UseVisualStyleBackColor = true
        Me.btnESC.Visible = false
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(3, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 31)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "KAM"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(195, 31)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Программа лояльности"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(204, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(534, 25)
        Me.ComboBox1.TabIndex = 2
        '
        'cmbKam
        '
        Me.cmbKam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbKam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKam.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbKam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbKam.FormattingEnabled = true
        Me.cmbKam.Location = New System.Drawing.Point(204, 95)
        Me.cmbKam.Name = "cmbKam"
        Me.cmbKam.Size = New System.Drawing.Size(534, 25)
        Me.cmbKam.TabIndex = 3
        '
        'cmbLoyaltyProgram
        '
        Me.cmbLoyaltyProgram.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbLoyaltyProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoyaltyProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbLoyaltyProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbLoyaltyProgram.FormattingEnabled = true
        Me.cmbLoyaltyProgram.Location = New System.Drawing.Point(204, 126)
        Me.cmbLoyaltyProgram.Name = "cmbLoyaltyProgram"
        Me.cmbLoyaltyProgram.Size = New System.Drawing.Size(534, 25)
        Me.cmbLoyaltyProgram.TabIndex = 82
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtID.Location = New System.Drawing.Point(204, 157)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = true
        Me.txtID.Size = New System.Drawing.Size(534, 24)
        Me.txtID.TabIndex = 83
        '
        'Discount
        '
        Me.Discount.Controls.Add(Me.tlpRow)
        Me.Discount.Location = New System.Drawing.Point(4, 29)
        Me.Discount.Name = "Discount"
        Me.Discount.Padding = New System.Windows.Forms.Padding(3)
        Me.Discount.Size = New System.Drawing.Size(741, 619)
        Me.Discount.TabIndex = 6
        Me.Discount.Text = "Скидки и цены"
        Me.Discount.UseVisualStyleBackColor = true
        '
        'tlpRow
        '
        Me.tlpRow.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpRow.ColumnCount = 5
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRow.Controls.Add(Me.dgDiscount, 0, 0)
        Me.tlpRow.Controls.Add(Me.nudDiscount, 1, 1)
        Me.tlpRow.Controls.Add(Me.Label11, 0, 1)
        Me.tlpRow.Controls.Add(Me.btnSaveDisc, 4, 1)
        Me.tlpRow.Controls.Add(Me.dtpDateStart, 2, 1)
        Me.tlpRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpRow.Location = New System.Drawing.Point(3, 3)
        Me.tlpRow.Name = "tlpRow"
        Me.tlpRow.RowCount = 2
        Me.tlpRow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRow.Size = New System.Drawing.Size(735, 613)
        Me.tlpRow.TabIndex = 36
        '
        'dgDiscount
        '
        Me.dgDiscount.AllowUserToAddRows = false
        Me.dgDiscount.AllowUserToDeleteRows = false
        Me.dgDiscount.AllowUserToResizeRows = false
        Me.dgDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpRow.SetColumnSpan(Me.dgDiscount, 5)
        Me.dgDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDiscount.Location = New System.Drawing.Point(4, 4)
        Me.dgDiscount.MultiSelect = false
        Me.dgDiscount.Name = "dgDiscount"
        Me.dgDiscount.ReadOnly = true
        Me.dgDiscount.RowTemplate.Height = 24
        Me.dgDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDiscount.Size = New System.Drawing.Size(727, 568)
        Me.dgDiscount.TabIndex = 0
        '
        'nudDiscount
        '
        Me.nudDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudDiscount.Location = New System.Drawing.Point(85, 579)
        Me.nudDiscount.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudDiscount.Name = "nudDiscount"
        Me.nudDiscount.Size = New System.Drawing.Size(176, 24)
        Me.nudDiscount.TabIndex = 14
        Me.nudDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 576)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 36)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Значение"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSaveDisc
        '
        Me.btnSaveDisc.AutoSize = true
        Me.btnSaveDisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSaveDisc.Location = New System.Drawing.Point(621, 579)
        Me.btnSaveDisc.Name = "btnSaveDisc"
        Me.btnSaveDisc.Size = New System.Drawing.Size(109, 30)
        Me.btnSaveDisc.TabIndex = 16
        Me.btnSaveDisc.Text = "Применить"
        Me.btnSaveDisc.UseVisualStyleBackColor = true
        '
        'dtpDateStart
        '
        Me.dtpDateStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateStart.Location = New System.Drawing.Point(268, 579)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(103, 24)
        Me.dtpDateStart.TabIndex = 17
        '
        'points
        '
        Me.points.Controls.Add(Me.tlpGeoAdress)
        Me.points.Location = New System.Drawing.Point(4, 29)
        Me.points.Name = "points"
        Me.points.Size = New System.Drawing.Size(741, 619)
        Me.points.TabIndex = 8
        Me.points.Text = "Адреса доставки"
        Me.points.UseVisualStyleBackColor = true
        '
        'tlpGeoAdress
        '
        Me.tlpGeoAdress.ColumnCount = 1
        Me.tlpGeoAdress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpGeoAdress.Controls.Add(Me.dgGeoPoints, 0, 0)
        Me.tlpGeoAdress.Controls.Add(Me.tlpAdres, 0, 2)
        Me.tlpGeoAdress.Controls.Add(Me.btnAddGeopoint, 0, 1)
        Me.tlpGeoAdress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpGeoAdress.Location = New System.Drawing.Point(0, 0)
        Me.tlpGeoAdress.Name = "tlpGeoAdress"
        Me.tlpGeoAdress.RowCount = 3
        Me.tlpGeoAdress.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpGeoAdress.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpGeoAdress.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpGeoAdress.Size = New System.Drawing.Size(741, 619)
        Me.tlpGeoAdress.TabIndex = 0
        '
        'dgGeoPoints
        '
        Me.dgGeoPoints.AllowUserToAddRows = false
        Me.dgGeoPoints.AllowUserToDeleteRows = false
        Me.dgGeoPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgGeoPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGeoPoints.ContextMenuStrip = Me.cmsGeo
        Me.dgGeoPoints.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGeoPoints.Location = New System.Drawing.Point(3, 3)
        Me.dgGeoPoints.Name = "dgGeoPoints"
        Me.dgGeoPoints.ReadOnly = true
        Me.dgGeoPoints.RowTemplate.Height = 24
        Me.dgGeoPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGeoPoints.Size = New System.Drawing.Size(735, 315)
        Me.dgGeoPoints.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.dgGeoPoints, "Чтобы добавить точку доставки нажмите кнопку внизу Добавить точку доставки, внизу"& _ 
        "")
        '
        'cmsGeo
        '
        Me.cmsGeo.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsGeo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsGeo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem, Me.РедактироватьToolStripMenuItem, Me.УдалитьToolStripMenuItem})
        Me.cmsGeo.Name = "cmsGeo"
        Me.cmsGeo.Size = New System.Drawing.Size(288, 76)
        '
        'ДобавитьToolStripMenuItem
        '
        Me.ДобавитьToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ДобавитьToolStripMenuItem.Name = "ДобавитьToolStripMenuItem"
        Me.ДобавитьToolStripMenuItem.Size = New System.Drawing.Size(287, 24)
        Me.ДобавитьToolStripMenuItem.Text = "Добавить точку доставки"
        '
        'РедактироватьToolStripMenuItem
        '
        Me.РедактироватьToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.РедактироватьToolStripMenuItem.Name = "РедактироватьToolStripMenuItem"
        Me.РедактироватьToolStripMenuItem.Size = New System.Drawing.Size(287, 24)
        Me.РедактироватьToolStripMenuItem.Text = "Редактировать точку доставки"
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(287, 24)
        Me.УдалитьToolStripMenuItem.Text = "Удалить точку доставки"
        '
        'tlpAdres
        '
        Me.tlpAdres.AutoSize = true
        Me.tlpAdres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAdres.ColumnCount = 2
        Me.tlpAdres.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAdres.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAdres.Controls.Add(Me.Label9, 0, 0)
        Me.tlpAdres.Controls.Add(Me.btnGeoSaveKA, 1, 7)
        Me.tlpAdres.Controls.Add(Me.txtNamePoint, 1, 0)
        Me.tlpAdres.Controls.Add(Me.Label13, 0, 6)
        Me.tlpAdres.Controls.Add(Me.Label12, 0, 1)
        Me.tlpAdres.Controls.Add(Me.Label16, 0, 2)
        Me.tlpAdres.Controls.Add(Me.txtCity, 1, 2)
        Me.tlpAdres.Controls.Add(Me.Label18, 0, 3)
        Me.tlpAdres.Controls.Add(Me.Label19, 0, 4)
        Me.tlpAdres.Controls.Add(Me.txtStreet, 1, 3)
        Me.tlpAdres.Controls.Add(Me.btnCancel, 0, 7)
        Me.tlpAdres.Controls.Add(Me.txtGeoPoint, 1, 6)
        Me.tlpAdres.Controls.Add(Me.btnDetermine, 1, 5)
        Me.tlpAdres.Controls.Add(Me.txtDom, 1, 4)
        Me.tlpAdres.Controls.Add(Me.txtAdressGeoPoint, 1, 1)
        Me.tlpAdres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAdres.Location = New System.Drawing.Point(3, 360)
        Me.tlpAdres.Name = "tlpAdres"
        Me.tlpAdres.RowCount = 8
        Me.tlpAdres.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdres.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdres.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdres.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdres.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdres.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdres.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdres.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdres.Size = New System.Drawing.Size(735, 256)
        Me.tlpAdres.TabIndex = 8
        Me.tlpAdres.Visible = false
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(229, 30)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Название точки доставки"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGeoSaveKA
        '
        Me.btnGeoSaveKA.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGeoSaveKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeoSaveKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnGeoSaveKA.Location = New System.Drawing.Point(238, 219)
        Me.btnGeoSaveKA.Name = "btnGeoSaveKA"
        Me.btnGeoSaveKA.Size = New System.Drawing.Size(494, 34)
        Me.btnGeoSaveKA.TabIndex = 4
        Me.btnGeoSaveKA.Text = "Сохранить точку доставки"
        Me.btnGeoSaveKA.UseVisualStyleBackColor = true
        Me.btnGeoSaveKA.Visible = false
        '
        'txtNamePoint
        '
        Me.txtNamePoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamePoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNamePoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtNamePoint.ForeColor = System.Drawing.Color.Black
        Me.txtNamePoint.Location = New System.Drawing.Point(238, 3)
        Me.txtNamePoint.Name = "txtNamePoint"
        Me.txtNamePoint.Size = New System.Drawing.Size(494, 24)
        Me.txtNamePoint.TabIndex = 0
        Me.txtNamePoint.Text = " Например,_офис,_склад_и_т.п."
        Me.ToolTip1.SetToolTip(Me.txtNamePoint, "Двойным кликом выделится вся строка")
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(229, 30)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Координаты"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(229, 30)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Адрес точки"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(3, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(229, 30)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Город"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtCity.Location = New System.Drawing.Point(238, 63)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(494, 24)
        Me.txtCity.TabIndex = 1
        Me.txtCity.Text = "Москва"
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(3, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(229, 30)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Улица"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(3, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(229, 30)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Номер дома "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStreet
        '
        Me.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtStreet.Location = New System.Drawing.Point(238, 93)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(494, 24)
        Me.txtStreet.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnCancel.Location = New System.Drawing.Point(3, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(229, 34)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Отменить"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'txtGeoPoint
        '
        Me.txtGeoPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGeoPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGeoPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtGeoPoint.Location = New System.Drawing.Point(238, 189)
        Me.txtGeoPoint.Name = "txtGeoPoint"
        Me.txtGeoPoint.ReadOnly = true
        Me.txtGeoPoint.Size = New System.Drawing.Size(494, 24)
        Me.txtGeoPoint.TabIndex = 3
        Me.txtGeoPoint.TabStop = false
        '
        'btnDetermine
        '
        Me.btnDetermine.AutoSize = true
        Me.btnDetermine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDetermine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDetermine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetermine.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnDetermine.Location = New System.Drawing.Point(238, 153)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(494, 30)
        Me.btnDetermine.TabIndex = 4
        Me.btnDetermine.Text = "Определить координаты по адресу"
        Me.btnDetermine.UseVisualStyleBackColor = true
        '
        'txtDom
        '
        Me.txtDom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDom.ContextMenuStrip = Me.cmsCoordinate
        Me.txtDom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtDom.Location = New System.Drawing.Point(238, 123)
        Me.txtDom.Name = "txtDom"
        Me.txtDom.Size = New System.Drawing.Size(494, 24)
        Me.txtDom.TabIndex = 3
        '
        'cmsCoordinate
        '
        Me.cmsCoordinate.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsCoordinate.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCoordinate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОпределитьКоординатыToolStripMenuItem})
        Me.cmsCoordinate.Name = "ContextMenuStrip1"
        Me.cmsCoordinate.Size = New System.Drawing.Size(252, 28)
        '
        'ОпределитьКоординатыToolStripMenuItem
        '
        Me.ОпределитьКоординатыToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ОпределитьКоординатыToolStripMenuItem.Name = "ОпределитьКоординатыToolStripMenuItem"
        Me.ОпределитьКоординатыToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.ОпределитьКоординатыToolStripMenuItem.Text = "Определить координаты"
        '
        'txtAdressGeoPoint
        '
        Me.txtAdressGeoPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdressGeoPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAdressGeoPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtAdressGeoPoint.ForeColor = System.Drawing.Color.Black
        Me.txtAdressGeoPoint.Location = New System.Drawing.Point(238, 33)
        Me.txtAdressGeoPoint.Name = "txtAdressGeoPoint"
        Me.txtAdressGeoPoint.ReadOnly = true
        Me.txtAdressGeoPoint.Size = New System.Drawing.Size(494, 24)
        Me.txtAdressGeoPoint.TabIndex = 2
        Me.txtAdressGeoPoint.TabStop = false
        '
        'btnAddGeopoint
        '
        Me.btnAddGeopoint.AutoSize = true
        Me.btnAddGeopoint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddGeopoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddGeopoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddGeopoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnAddGeopoint.Location = New System.Drawing.Point(3, 324)
        Me.btnAddGeopoint.Name = "btnAddGeopoint"
        Me.btnAddGeopoint.Size = New System.Drawing.Size(735, 30)
        Me.btnAddGeopoint.TabIndex = 9
        Me.btnAddGeopoint.Text = "Добавить точку доставки"
        Me.btnAddGeopoint.UseVisualStyleBackColor = true
        '
        'Web
        '
        Me.Web.Controls.Add(Me.GoogleMapControl)
        Me.Web.Location = New System.Drawing.Point(4, 29)
        Me.Web.Name = "Web"
        Me.Web.Size = New System.Drawing.Size(741, 619)
        Me.Web.TabIndex = 7
        Me.Web.Text = "Определение координат"
        Me.Web.UseVisualStyleBackColor = true
        '
        'GoogleMapControl
        '
        Me.GoogleMapControl.Bearing = 0!
        Me.GoogleMapControl.CanDragMap = true
        Me.GoogleMapControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoogleMapControl.EmptyTileColor = System.Drawing.Color.Navy
        Me.GoogleMapControl.GrayScaleMode = false
        Me.GoogleMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GoogleMapControl.LevelsKeepInMemmory = 5
        Me.GoogleMapControl.Location = New System.Drawing.Point(0, 0)
        Me.GoogleMapControl.MarkersEnabled = true
        Me.GoogleMapControl.MaxZoom = 23
        Me.GoogleMapControl.MinZoom = 6
        Me.GoogleMapControl.MouseWheelZoomEnabled = true
        Me.GoogleMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter
        Me.GoogleMapControl.Name = "GoogleMapControl"
        Me.GoogleMapControl.NegativeMode = false
        Me.GoogleMapControl.PolygonsEnabled = true
        Me.GoogleMapControl.RetryLoadTile = 0
        Me.GoogleMapControl.RoutesEnabled = false
        Me.GoogleMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional
        Me.GoogleMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(65,Byte),Integer), CType(CType(105,Byte),Integer), CType(CType(225,Byte),Integer))
        Me.GoogleMapControl.ShowTileGridLines = false
        Me.GoogleMapControl.Size = New System.Drawing.Size(741, 619)
        Me.GoogleMapControl.TabIndex = 0
        Me.GoogleMapControl.Zoom = 16R
        '
        'cmbTypesKAgent
        '
        Me.cmbTypesKAgent.CausesValidation = false
        Me.cmbTypesKAgent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypesKAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypesKAgent.Enabled = false
        Me.cmbTypesKAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTypesKAgent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypesKAgent.FormattingEnabled = true
        Me.cmbTypesKAgent.Location = New System.Drawing.Point(180, 36)
        Me.cmbTypesKAgent.MaxDropDownItems = 16
        Me.cmbTypesKAgent.Name = "cmbTypesKAgent"
        Me.cmbTypesKAgent.Size = New System.Drawing.Size(185, 25)
        Me.cmbTypesKAgent.TabIndex = 46
        Me.cmbTypesKAgent.TabStop = false
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 679)
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
        Me.tsCompany.Dock = System.Windows.Forms.DockStyle.None
        Me.tsCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsCompany.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.tsbtnEdit, Me.tsbtnSave, Me.tsbtnCancel, Me.tsbtnDelete, Me.tsbtnFindCust, Me.tsbtnPerson, Me.tsbtnOrganization, Me.tsbtnWOorders, Me.tsbtnFindEmplKA, Me.tsbtnFindOrg, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.tsCompany.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsCompany.Location = New System.Drawing.Point(0, 3)
        Me.tsCompany.Name = "tsCompany"
        Me.tsCompany.Size = New System.Drawing.Size(150, 317)
        Me.tsCompany.TabIndex = 0
        Me.tsCompany.Text = "ToolStrip1"
        '
        'tsbtnNew
        '
        Me.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNew.Image = CType(resources.GetObject("tsbtnNew.Image"),System.Drawing.Image)
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnNew.Text = "Создать"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEdit.Image = CType(resources.GetObject("tsbtnEdit.Image"),System.Drawing.Image)
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnEdit.Text = "Изменить"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"),System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnSave.Text = "Сохранить"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"),System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnCancel.Text = "Отменить"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelete.Image = CType(resources.GetObject("tsbtnDelete.Image"),System.Drawing.Image)
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnDelete.Text = "Удалить"
        '
        'tsbtnFindCust
        '
        Me.tsbtnFindCust.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFindCust.Image = CType(resources.GetObject("tsbtnFindCust.Image"),System.Drawing.Image)
        Me.tsbtnFindCust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFindCust.Name = "tsbtnFindCust"
        Me.tsbtnFindCust.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnFindCust.Text = "Поиск"
        '
        'tsbtnPerson
        '
        Me.tsbtnPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnPerson.Image = CType(resources.GetObject("tsbtnPerson.Image"),System.Drawing.Image)
        Me.tsbtnPerson.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPerson.Name = "tsbtnPerson"
        Me.tsbtnPerson.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnPerson.Text = "Персоны"
        '
        'tsbtnOrganization
        '
        Me.tsbtnOrganization.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOrganization.Image = CType(resources.GetObject("tsbtnOrganization.Image"),System.Drawing.Image)
        Me.tsbtnOrganization.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOrganization.Name = "tsbtnOrganization"
        Me.tsbtnOrganization.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnOrganization.Text = "Юр.лица"
        '
        'tsbtnWOorders
        '
        Me.tsbtnWOorders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnWOorders.Image = CType(resources.GetObject("tsbtnWOorders.Image"),System.Drawing.Image)
        Me.tsbtnWOorders.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnWOorders.Name = "tsbtnWOorders"
        Me.tsbtnWOorders.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnWOorders.Text = "Без заказов"
        '
        'tsbtnFindEmplKA
        '
        Me.tsbtnFindEmplKA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFindEmplKA.Image = CType(resources.GetObject("tsbtnFindEmplKA.Image"),System.Drawing.Image)
        Me.tsbtnFindEmplKA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFindEmplKA.Name = "tsbtnFindEmplKA"
        Me.tsbtnFindEmplKA.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnFindEmplKA.Text = "Поиск по персонам"
        '
        'tsbtnFindOrg
        '
        Me.tsbtnFindOrg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFindOrg.Image = CType(resources.GetObject("tsbtnFindOrg.Image"),System.Drawing.Image)
        Me.tsbtnFindOrg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFindOrg.Name = "tsbtnFindOrg"
        Me.tsbtnFindOrg.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnFindOrg.Text = "Поиск по юр.лицам"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"),System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(148, 22)
        Me.tsbtnExit.Text = "Выход"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblSearch, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lstPartners, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbTypesKAgent, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbManager, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.chkAllMan, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkType, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbSort, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSearch, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(369, 677)
        Me.TableLayoutPanel2.TabIndex = 62
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = true
        Me.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblSearch.Location = New System.Drawing.Point(4, 97)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(169, 31)
        Me.lblSearch.TabIndex = 64
        Me.lblSearch.Text = "Поиск"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbManager
        '
        Me.cmbManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbManager.FormattingEnabled = true
        Me.cmbManager.Location = New System.Drawing.Point(180, 4)
        Me.cmbManager.MaxDropDownItems = 30
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(185, 25)
        Me.cmbManager.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 31)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Сортировка"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAllMan
        '
        Me.chkAllMan.AutoSize = true
        Me.chkAllMan.Checked = true
        Me.chkAllMan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAllMan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkAllMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAllMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkAllMan.Location = New System.Drawing.Point(4, 4)
        Me.chkAllMan.Name = "chkAllMan"
        Me.chkAllMan.Size = New System.Drawing.Size(169, 25)
        Me.chkAllMan.TabIndex = 61
        Me.chkAllMan.Text = "Автор контрагента"
        Me.chkAllMan.UseVisualStyleBackColor = true
        '
        'chkType
        '
        Me.chkType.AutoSize = true
        Me.chkType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkType.Location = New System.Drawing.Point(4, 36)
        Me.chkType.Name = "chkType"
        Me.chkType.Size = New System.Drawing.Size(169, 25)
        Me.chkType.TabIndex = 62
        Me.chkType.Text = "Тип контрагента"
        Me.chkType.UseVisualStyleBackColor = true
        '
        'cmbSort
        '
        Me.cmbSort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSort.FormattingEnabled = true
        Me.cmbSort.Items.AddRange(New Object() {"по алфавиту", "по дате создания"})
        Me.cmbSort.Location = New System.Drawing.Point(180, 68)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(185, 25)
        Me.cmbSort.TabIndex = 63
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.txtSearch.Location = New System.Drawing.Point(180, 100)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 3, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 24)
        Me.txtSearch.TabIndex = 65
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(627, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Сохранить"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.DesCust)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(749, 652)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.RightToolStripPanel.Controls.Add(Me.tsCompany)
        Me.ToolStripContainer1.Size = New System.Drawing.Size(899, 677)
        Me.ToolStripContainer1.TabIndex = 64
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 679)
        Me.SplitContainer1.SplitterDistance = 371
        Me.SplitContainer1.TabIndex = 65
        '
        'frmKAgents
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.CancelButton = Me.btnESC
        Me.ClientSize = New System.Drawing.Size(1276, 703)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(966, 415)
        Me.Name = "frmKAgents"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = false
        Me.Text = "Справочник Контрагентов"
        Me.DesCust.ResumeLayout(false)
        Me.Kontakt.ResumeLayout(false)
        Me.Kontakt.PerformLayout
        Me.tlpContact.ResumeLayout(false)
        Me.tlpContact.PerformLayout
        Me.Parametr.ResumeLayout(false)
        Me.tlpParam.ResumeLayout(false)
        Me.tlpParam.PerformLayout
        Me.Discount.ResumeLayout(false)
        Me.tlpRow.ResumeLayout(false)
        Me.tlpRow.PerformLayout
        CType(Me.dgDiscount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudDiscount,System.ComponentModel.ISupportInitialize).EndInit
        Me.points.ResumeLayout(false)
        Me.tlpGeoAdress.ResumeLayout(false)
        Me.tlpGeoAdress.PerformLayout
        CType(Me.dgGeoPoints,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsGeo.ResumeLayout(false)
        Me.tlpAdres.ResumeLayout(false)
        Me.tlpAdres.PerformLayout
        Me.cmsCoordinate.ResumeLayout(false)
        Me.Web.ResumeLayout(false)
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.tsCompany.ResumeLayout(false)
        Me.tsCompany.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(false)
        Me.ToolStripContainer1.RightToolStripPanel.ResumeLayout(false)
        Me.ToolStripContainer1.RightToolStripPanel.PerformLayout
        Me.ToolStripContainer1.ResumeLayout(false)
        Me.ToolStripContainer1.PerformLayout
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
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
    Dim ignoreLoading As Boolean = False

    Dim findCoord As Boolean = False
    Dim overlay As New GMapOverlay()
    Dim isDraggingMarker As Boolean = false

#Region " Загрузка, активация формы "
    Private Sub Partners_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActivateEditing(False)
        GoogleMapControl.MapProvider = GMapProviders.GoogleMap
        GoogleMapControl.DragButton = MouseButtons.Left
        GoogleMapControl.Overlays.Add(overlay)
        GoogleMapControl.ShowCenter = False

        Try
            ignoreLoading = True

            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_FilterAuthorKA]"  'Загружаем список менеджеров
            cmd.CommandType = CommandType.StoredProcedure

            Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
            Dim dtMan As New DataTable : odaMan.Fill(dtMan)
            
            Me.cmbManager.ValueMember = "emplID"
            Me.cmbManager.DisplayMember = "emplLastName"
            Me.cmbManager.DataSource = dtMan
            Me.cmbManager.SelectedValue = emplID

            Dim odaKam As New SqlClient.SqlDataAdapter(cmd)
            Dim dtKam As New DataTable : odaKam.Fill(dtKam)
            
            Me.cmbKam.DisplayMember = "emplLastName"
            Me.cmbKam.ValueMember = "emplID"
            Me.cmbKam.DataSource = dtKam

            Dim odaMarket As New SqlClient.SqlDataAdapter("SELECT ID, name FROM Reclama order by name", mcnnInt)
            Dim dtMarket As New DataTable : odaMarket.Fill(dtMarket)
            Me.cmbMarketing.DataSource = dtMarket
            Me.cmbMarketing.DisplayMember = "Name"
            Me.cmbMarketing.ValueMember = "ID"


            Dim odaTypesKAgent As New SqlClient.SqlDataAdapter("SELECT ID, name FROM TypesKAgent", mcnnInt)
            Dim dtTypesKAgent As New DataTable : odaTypesKAgent.Fill(dtTypesKAgent)

            Me.cmbTypeK.DataSource = dtTypesKAgent 'Связать данные со списком
            Me.cmbTypeK.DisplayMember = "name"
            Me.cmbTypeK.ValueMember = "ID"

            Dim odaTypesKAgent1 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM TypesKAgent", mcnnInt)
            Dim dtTypesKAgent1 As New DataTable : odaTypesKAgent1.Fill(dtTypesKAgent1)

            Me.cmbTypesKAgent.DataSource = dtTypesKAgent1 'Связать данные со списком
            Me.cmbTypesKAgent.DisplayMember = "name"
            Me.cmbTypesKAgent.ValueMember = "ID"

            Me.cmbTypesKAgent.SelectedIndex = 1

            Dim odaOtvManager As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName FROM Employees", mcnnInt)
            Dim dtOtvManager As New DataTable : odaOtvManager.Fill(dtOtvManager)

            Me.cmbOtvManager.DataSource = dtOtvManager 'Связать данные со списком
            Me.cmbOtvManager.DisplayMember = "emplLastName"
            Me.cmbOtvManager.ValueMember = "emplID"
            Me.cmbOtvManager.SelectedValue = emplID

        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        Finally
            ignoreLoading = False
        End Try

        If custID <> Nothing Then
            Me.chkType.Checked = False
            Me.chkAllMan.Checked = False
        End If

        LoadList()

        If custID <> Nothing Then
            Me.lstPartners.SelectedValue = custID
        End If

        If addsup = True Then
            Me.cmbTypeK.SelectedValue = 4
            mblnAdd = True
            ActivateEditing(True)
        End If

        If postPrioritet = 1 Then
            Me.tsbtnDelete.Visible = True
            Me.tsbtnWOorders.Visible = True
        Else
            Me.tsbtnDelete.Visible = False
            Me.tsbtnWOorders.Visible = False
        End If
    End Sub
#End Region

#Region " Загрузка лист партнеров "
    Private Sub LoadList()
        Dim odaPartList As SqlDataAdapter
        Dim cmd As New SqlCommand

        Try
            If (ignoreLoading) Then
                Exit Sub
            End If
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_KAgentsSearch"
            cmd.CommandType = CommandType.StoredProcedure
            
            If (cmbManager.SelectedIndex <> -1 And chkAllMan.Checked) Then
                cmd.Parameters.Add(New SqlParameter("@otvManagerID", SqlDbType.Int))
                cmd.Parameters("@otvManagerID").Value = cmbManager.SelectedValue
            End If

            If (cmbTypesKAgent.SelectedIndex <> -1 And chkType.Checked) Then
                cmd.Parameters.Add(New SqlParameter("@kAgentTypeID", SqlDbType.Int))
                cmd.Parameters("@kAgentTypeID").Value = cmbTypesKAgent.SelectedValue
            End If

            If (txtSearch.Text <> "") Then
                cmd.Parameters.Add(New SqlParameter("@text", SqlDbType.NVarChar))
                cmd.Parameters("@text").Value = txtSearch.Text
            End If

            If (cmbSort.SelectedIndex <> -1) Then
                Dim sortValue As String
                If (cmbSort.SelectedIndex = 0) Then
                    sortValue = "name"
                Else 
                    sortValue = "datecreate"
                End If
                cmd.Parameters.Add(New SqlParameter("@sort", SqlDbType.VarChar))
                cmd.Parameters("@sort").Value = sortValue
            End If

            dtPartList = New DataTable
            odaPartList = New SqlDataAdapter(cmd)
            odaPartList.Fill(dtPartList)
            
            Me.lstPartners.DataSource = dtPartList
        Catch oexpData As Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try

        Me.ToolStripStatusLabel1.Text = "В списке компаний: " & dtPartList.Rows.Count.ToString
    End Sub
#End Region

#Region " Загрузка персональных данных "
    Private Sub LoadIndividual()
        Dim strName$
        Dim oCtl, oCtl1, oCtl2 As Object
        Dim n% = 0

        mdsPartIndiv.Clear()

        If Me.lstPartners.SelectedIndex <> -1 Then
            Try
                modaPartIndiv = New SqlClient.SqlDataAdapter("SELECT * FROM KAgents WHERE ID = " & Me.lstPartners.SelectedItem(0) & "", mcnnInt)
                modaPartIndiv.Fill(mdsPartIndiv, "KAgents")
                mdrPartIndiv = mdsPartIndiv.Tables("KAgents").Rows(0)
            Catch oexpData As System.SystemException
                MessageBox.Show("Error loading individual data: " & oexpData.Message, appName)
                Exit Sub
            End Try

            For Each oCtl In Me.DesCust.TabPages
                For Each oCtl1 In Me.DesCust.TabPages(n).Controls
                    If TypeOf oCtl1 Is TableLayoutPanel Then
                        For Each oCtl2 In oCtl1.Controls
                            If TypeOf oCtl2 Is TextBox Or TypeOf oCtl2 Is MaskedTextBox Then
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

            Me.cmbTypeK.SelectedValue = mdrPartIndiv("type_ID")
            Me.cmbOtvManager.SelectedValue = mdrPartIndiv("otvManager_emplID")
            Me.cmbKam.SelectedValue = mdrPartIndiv("kamID")
            Me.cmbMarketing.SelectedValue = mdrPartIndiv("marketingID")

            LoadDiscount() 'Загрузка скидок
            LoadGeopoints(Me.lstPartners.SelectedItem(0))

            Try
                If Me.txtAdress.Text <> Nothing Then
                Else
                    Exit Sub
                End If

            Catch ex As System.Exception

            End Try
        End If
    End Sub
#End Region

#Region " Загрузка скидок партнера "
    Private Sub LoadDiscount()
        Dim odaDiscount As SqlClient.SqlDataAdapter
        Dim dtDisccount As New DataTable
        Dim strSQLdisc As String = "SELECT DISTINCT Services.ID, Services.name AS Направление, COALESCE(sdKA.Discount, 0) AS Скидка FROM Services "
        strSQLdisc &= "left JOIN KA_ServDisccount  ON Services.ID = KA_ServDisccount.ID_Service "
        strSQLdisc &= "left JOIN  (SELECT * FROM KA_ServDisccount WHERE ID_KA = " & Me.lstPartners.SelectedItem(0) & ") sdKA ON Services.ID = sdKA.ID_Service "
        strSQLdisc &= "WHERE active <> 0 order by name"

        Try
            odaDiscount = New SqlClient.SqlDataAdapter(strSQLdisc, mcnnInt)
            odaDiscount.Fill(dtDisccount)

            Me.dgDiscount.DataSource = dtDisccount
            Me.dgDiscount.Columns("ID").Visible = False 'скрываем первую колонку с ид
            Me.dgDiscount.ClearSelection()

        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Dim dtGeoPoints As DataTable

#Region " Загрузка геоточек "
    Private Sub LoadGeopoints(KAid As Integer)
        Me.txtAdressGeoPoint.Text = Nothing
        Me.txtNamePoint.Text = Nothing
        Me.txtGeoPoint.Text = Nothing

        Try
            Dim odaGeoPoints As New SqlClient.SqlDataAdapter("SELECT ID, name AS Наименование, adres AS Адрес, geopoint AS Координаты FROM KA_GeoPoints WHERE KA_ID=" & KAid & "", mcnnInt)
            dtGeoPoints = New DataTable : odaGeoPoints.Fill(dtGeoPoints)

            dtGeoPoints.Columns("ID").Unique = True
            dtGeoPoints.PrimaryKey = {dtGeoPoints.Columns("ID")}

            Me.dgGeoPoints.DataSource = dtGeoPoints
            Me.dgGeoPoints.Columns("ID").Visible = False 'скрываем первую колонку с ид
            Me.dgGeoPoints.ClearSelection()
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

#Region " Поиск "
    Private Sub FindList(ByVal fragment As String, strSPname As String)
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = strSPname
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@fragment", SqlDbType.NVarChar))
            cmd.Parameters("@fragment").Value = fragment

            Dim odaPartList As New SqlClient.SqlDataAdapter(cmd)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            '    'Связать данные со списком
            Me.lstPartners.DataSource = dtPartList
            Me.lstPartners.DisplayMember = "Name"
            Me.lstPartners.ValueMember = "ID"
        Catch oexpData As System.SystemException
            MessageBox.Show("Ошибка при поиске контрагента: " & oexpData.Message, appName)
        End Try
    End Sub
#End Region

#Region " Активация редактирования компании "
    Private Sub ActivateEditing(ByVal bEnable As Boolean)
        ' Если редактирование разрешено то перемещение по партнерам запрещено
        Me.lstPartners.Enabled = Not bEnable
        Me.tlpGeoAdress.Enabled = Not bEnable

        Dim oCtl, oCtl1, oCtl2 As Object
        Dim n As Integer = 0

        For Each oCtl In Me.DesCust.TabPages

            For Each oCtl1 In Me.DesCust.TabPages(n).Controls
                If Me.DesCust.TabPages(n).Name <> "points" Then
                    If TypeOf oCtl1 Is TableLayoutPanel Then
                        For Each oCtl2 In oCtl1.Controls
                            If TypeOf oCtl2 Is TextBox Or TypeOf oCtl2 Is MaskedTextBox Then
                                If bEnable Then
                                    oCtl2.BorderStyle() = System.Windows.Forms.BorderStyle.Fixed3D
                                    oCtl2.BackColor() = System.Drawing.Color.White
                                Else
                                    oCtl2.BorderStyle() = System.Windows.Forms.BorderStyle.FixedSingle
                                    oCtl2.BackColor() = System.Drawing.Color.White
                                End If
                                If mblnAdd = True Then
                                    oCtl2.text = ""
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
                        Next
                    End If
                End If
            Next
            n = n + 1
        Next

        Me.tlpContact.Controls("txtName").Focus()
        Me.tsbtnEdit.Enabled = Not bEnable
        Me.tsbtnNew.Enabled = Not bEnable
        Me.tsbtnSave.Enabled = bEnable
        Me.tsbtnCancel.Enabled = bEnable

        Me.dgGeoPoints.Enabled = Not bEnable
        Me.btnGeoSaveKA.Enabled = Not bEnable

        Me.tsbtnPerson.Enabled = Not bEnable
        Me.tsbtnOrganization.Enabled = Not bEnable
    End Sub
#End Region

#Region " Сохранить "
    Private Sub SaveRecord()
        Dim strName$
        Dim oCtl, oCtl1, oCtl2 As Object
        Dim n% = 0

        If mblnAdd = True Then
            mdrPartIndiv = mdsPartIndiv.Tables("KAgents").NewRow
        End If

        mdrPartIndiv.BeginEdit() 'приступить к редактированию строки

        For Each oCtl In Me.DesCust.TabPages
            For Each oCtl1 In Me.DesCust.TabPages(n).Controls
                If TypeOf oCtl1 Is TableLayoutPanel Then
                    For Each oCtl2 In oCtl1.Controls
                        If TypeOf oCtl2 Is TextBox And oCtl2.text <> Nothing Then
                            strName = Mid(oCtl2.name, 4)
                            mdrPartIndiv(strName) = oCtl2.text
                        End If

                        If TypeOf oCtl2 Is MaskedTextBox And oCtl2.text <> Nothing Then
                            strName = Mid(oCtl2.name, 4)
                            mdrPartIndiv(strName) = oCtl2.text
                        End If
                    Next
                End If
            Next
            n = n + 1
        Next

        mdrPartIndiv("otvManager_emplID") = Me.cmbOtvManager.SelectedItem(0)
        mdrPartIndiv("type_ID") = Me.cmbTypeK.SelectedItem(0)
        mdrPartIndiv("kamID") = Me.cmbKam.SelectedItem(0)
        mdrPartIndiv("marketingID") = Me.cmbMarketing.SelectedItem(0)

        mdrPartIndiv.EndEdit() 'Завершить редактирование строки данных


        Try
            If mblnAdd = True Then
                mdsPartIndiv.Tables("KAgents").Rows.Add(mdrPartIndiv)
            End If


            Dim ocbPartIndiv As SqlClient.SqlCommandBuilder 'создать экземпляр пострителя команды
            ocbPartIndiv = New SqlClient.SqlCommandBuilder(modaPartIndiv)

            If mblnAdd = True Then
                modaPartIndiv.InsertCommand = ocbPartIndiv.GetInsertCommand ' Обеспечить создание оператора Insert SQL
            Else
                modaPartIndiv.UpdateCommand = ocbPartIndiv.GetUpdateCommand
            End If

            modaPartIndiv.Update(mdsPartIndiv, "KAgents") 'выполнить команду SQL и закрыть соед.
            mdsPartIndiv.Tables("KAgents").AcceptChanges()

            If mblnAdd = True Then
                modaPartIndiv.InsertCommand.Connection.Close()
            Else
                modaPartIndiv.UpdateCommand.Connection.Close()
            End If

            If mblnAdd = True Then
                LoadList()

                Me.lstPartners.SelectedIndex = Me.lstPartners.Items.Count - 1 '
            Else
                LoadIndividual()
            End If

            mblnAdd = False
            ActivateEditing(False)
        Catch excData As System.Exception
            MsgBox("Обратитесь к администратору.-" + excData.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
            '  
        End Try
    End Sub
#End Region

#Region " Отмена "
    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        Me.ErrorProvider1.Clear()

        Dim current As Integer = Me.lstPartners.SelectedIndex

        mblnAdd = False

        ActivateEditing(False)

        LoadList()

        Me.lstPartners.SelectedIndex = current
    End Sub
#End Region

#Region " Перемещение "
    Private Sub lstPartners_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles lstPartners.SelectedValueChanged
        LoadIndividual()
    End Sub
#End Region

#Region " Удалить компанию "
    Private Sub tsbtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelete.Click
        ActivateEditing(False)

        If Me.lstPartners.SelectedIndex = -1 Then
            MsgBox("Выбери контрагента", MsgBoxStyle.Critical, appName)
            Me.lstPartners.Focus()
        Else
            If MessageBox.Show("Удалить " & mdrPartIndiv("Name") & "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim ocbPartIndiv As SqlClient.SqlCommandBuilder

                Try
                    mdrPartIndiv.Delete()
                    ocbPartIndiv = New SqlClient.SqlCommandBuilder(modaPartIndiv)
                    modaPartIndiv.DeleteCommand = ocbPartIndiv.GetDeleteCommand
                    modaPartIndiv.Update(mdsPartIndiv, "KAgents")
                    mdsPartIndiv.Tables("KAgents").AcceptChanges()
                    modaPartIndiv.DeleteCommand.Connection.Close()

                    LoadList()
                Catch excData As System.Exception
                    MessageBox.Show("Error Occured:" & excData.Message)
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region " Запрет нажатия ентера  "
    Private Sub txtAdressF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescription.KeyPress
        If Asc(e.KeyChar) = 13 Then e.Handled = True Else e.Handled = False
    End Sub
#End Region

    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        If Me.lstPartners.Items.Count = 0 Then
            Me.chkAllMan.Checked = False
            Me.chkType.Checked = False
        End If

        mblnAdd = True
        Me.cmbOtvManager.SelectedValue = emplID
        Me.cmbKam.SelectedValue = emplID
        Me.cmbTypeK.SelectedIndex = 1

        LoadGeopoints(0)

        ActivateEditing(True)
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        If Me.lstPartners.SelectedIndex = -1 Then
            MsgBox("Не выбран контрагент.", MsgBoxStyle.Critical, appName)
        Else
            mblnAdd = False
            ActivateEditing(True)
        End If
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        Me.ErrorProvider1.Clear()

        If Me.cmbTypeK.SelectedItem(0) = 1 Then
            If postPrioritet <> 1 Then
                MsgBox("Редактировать и создавать Нашу компанию может только администратор", MessageBoxIcon.Error, appName) : Exit Sub
            End If
        End If

        If Me.txtName.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtName, "Поле наименование должно быть заполнено")
            Me.DesCust.SelectedIndex = 0
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtTel.Text = "" Then ' tel
            Me.ErrorProvider1.SetError(Me.txtTel, "Поле телефон должно быть заполнено")
            Me.DesCust.SelectedIndex = 0
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.cmbOtvManager.SelectedIndex = -1 Then  '
            Me.ErrorProvider1.SetError(Me.cmbOtvManager, "Должнен быть выбран ответственный сотрудник")
            Me.DesCust.SelectedIndex = 0
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        Dim current As Integer = Me.lstPartners.SelectedIndex

        SaveRecord()
    End Sub

    Private Sub tsbtnFindCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnFindCust.Click
        mblnAdd = False
        ActivateEditing(False)
        FindList(InputBox("Введите часть названия, адреса, ФИО, телефона", "Поиск контрагента", ""), "[sp_Find_KA]")
    End Sub

    Private Sub tsbtnPerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnPerson.Click
        If Me.lstPartners.SelectedIndex <> -1 Then
            Dim frmSelect As New frmEmplKA

            custID = Me.lstPartners.SelectedItem(0)
            frmSelect.ShowDialog()
        Else
            MsgBox("Не выбран контрагент.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbTypesKAgent_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbTypesKAgent.SelectedValueChanged
        LoadList()
    End Sub

    Private Sub tsbtnOrganization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOrganization.Click
        openFromKA = True

        If Me.lstPartners.SelectedIndex <> -1 Then
            custID = Me.lstPartners.SelectedItem(0)

            Dim frmSelect As frmOrganizations
            frmSelect = New frmOrganizations
            frmSelect.ShowDialog()
        Else
            MsgBox("Не выбран контрагент.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub cmbManager_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbManager.SelectedValueChanged
        LoadList()
    End Sub

    Private Sub chkAllMan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAllMan.CheckedChanged
        Me.cmbManager.Enabled = sender.checked
        If Me.cmbManager.SelectedIndex <> -1 Then
            If Me.cmbTypesKAgent.SelectedIndex <> -1 Then
                LoadList()
            End If
        End If
    End Sub

    Private Sub chkType_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkType.CheckedChanged
        Me.cmbTypesKAgent.Enabled = sender.checked
        If Me.cmbManager.SelectedIndex <> -1 Then
            If Me.cmbTypesKAgent.SelectedIndex <> -1 Then
                LoadList()
            End If
        End If
    End Sub

    Private Sub ОпределитьКоординатыToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОпределитьКоординатыToolStripMenuItem.Click
        findCoord = True ' признак поиска координат активен
        Me.DesCust.SelectedTab = Me.DesCust.TabPages.Item("web")
    End Sub


    Private Sub tsbtnWOorders_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnWOorders.Click
        Try
            Dim strSQL$ = "SELECT ID, Name, coalesce(ccc, 0) FROM KAgents left join (SELECT custID,count(*) as ccc FROM costs group by custID) a on kagents.ID=a.custID where KAgents.type_ID not in (1,4,6) and ccc is null"
            '--order by ccc"
            Dim odaPartList As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            dtPartList = New DataTable : odaPartList.Fill(dtPartList)

            Me.lstPartners.DataSource = dtPartList
            Me.lstPartners.DisplayMember = "Name"
            Me.lstPartners.ValueMember = "ID"
            Me.ToolStripStatusLabel1.Text = "В списке компаний: " & dtPartList.Rows.Count.ToString
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub btnSaveDisc_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveDisc.Click
        Dim curInd% = Me.dgDiscount.CurrentRow.Index

        If postPrioritet <> 1 Then
            MsgBox("Недостаточно прав. Обратитесь к администратору.", MsgBoxStyle.Critical, appName)
        Else
            'удаляем предыдущие записи
            Module1.NonQuery1("DELETE FROM KA_ServDisccount WHERE ID_KA=" & Me.lstPartners.SelectedItem(0) & " AND ID_Service=" & Me.dgDiscount("ID", curInd).Value() & "")

            Dim strSQL$ = "INSERT INTO KA_ServDisccount (ID_KA, ID_Service, Discount) VALUES (" & Me.lstPartners.SelectedItem(0) & "," & Me.dgDiscount("ID", curInd).Value() & "," & Me.nudDiscount.Value & ")"

            Module1.NonQuery1(strSQL)

            LoadDiscount()
        End If
    End Sub

    Private Sub cmbSort_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSort.SelectedIndexChanged
        LoadList()
    End Sub
    
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = "'") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadList()
    End Sub

    Dim addGeoPoint As Boolean

    Private Sub РедактироватьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles РедактироватьToolStripMenuItem.Click
        If Me.dgGeoPoints.RowCount = 0 Then
            MsgBox("Нет точек доставки.", MsgBoxStyle.Critical, appName)
        Else
            Me.btnAddGeopoint.Visible = False
            Me.btnDetermine.Visible = True
            Me.tlpAdres.Visible = True
            addGeoPoint = False

            Me.txtAdressGeoPoint.Enabled = True
            Me.txtNamePoint.Enabled = True
            Me.txtGeoPoint.Enabled = True
            Me.btnGeoSaveKA.Enabled = True

            Try
                Dim ID% = Me.dgGeoPoints("ID", Me.dgGeoPoints.CurrentRow.Index).Value()

                Me.txtNamePoint.Text = dtGeoPoints.Rows.Find(ID)("Наименование")
                Me.txtAdressGeoPoint.Text = dtGeoPoints.Rows.Find(ID)("Адрес")
                Me.txtGeoPoint.Text = dtGeoPoints.Rows.Find(ID)("Координаты")
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub ДобавитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ДобавитьToolStripMenuItem.Click
        Me.tlpAdres.Visible = True
        Me.btnAddGeopoint.Visible = False

        Me.txtNamePoint.Focus()

        addGeoPoint = True
    End Sub

    Private Sub УдалитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles УдалитьToolStripMenuItem.Click
        Try
            Select Case MsgBox(Prompt:="Удалить строку?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM KA_GeoPoints WHERE ID=" & Me.dgGeoPoints("ID", Me.dgGeoPoints.CurrentRow.Index).Value() & "")

                    LoadGeopoints(Me.lstPartners.SelectedItem(0))
                Case Is = vbNo
                    Exit Sub
            End Select
        Catch ex As System.Exception
            MsgBox("Возможно не выбрана строка для удаления." & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub btnGeoSaveKA_Click(sender As System.Object, e As System.EventArgs) Handles btnGeoSaveKA.Click
        If Me.txtDom.Text = Nothing Then
            MsgBox("Не указан номер дома.", MsgBoxStyle.Critical, appName)
            Me.txtAdressGeoPoint.Focus() : Exit Sub
        End If

        If Me.txtStreet.Text = Nothing Then
            MsgBox("Не указан адрес.", MsgBoxStyle.Critical, appName)
            Me.txtStreet.Focus() : Exit Sub
        End If

        If Me.txtCity.Text = Nothing Then
            MsgBox("Не указан город.", MsgBoxStyle.Critical, appName)
            Me.txtCity.Focus() : Exit Sub
        End If

        If Me.txtNamePoint.Text = Nothing Then
            MsgBox("Не указано название точки доставки.", MsgBoxStyle.Critical, appName)
            Me.txtNamePoint.Focus() : Exit Sub
        End If

        If Me.txtGeoPoint.Text = Nothing Then
            MsgBox("Не указаны координаты точки доставки.", MsgBoxStyle.Critical, appName)
            Me.txtGeoPoint.Focus() : Exit Sub
        End If

        If addGeoPoint = True Then
            Module1.NonQuery1("INSERT INTO KA_GeoPoints (KA_ID,name,adres,geopoint) VALUES (" & Me.lstPartners.SelectedItem(0) & ",'" & Me.txtNamePoint.Text & "','" & Me.txtCity.Text + "," + Me.txtStreet.Text + "," + Me.txtDom.Text & "','" & Me.txtGeoPoint.Text & "')")
        Else
            Module1.NonQuery1("UPDATE KA_GeoPoints SET name='" & Me.txtNamePoint.Text & "',adres='" & Me.txtCity.Text + "," + Me.txtStreet.Text + "," + Me.txtDom.Text & "',geopoint='" & Me.txtGeoPoint.Text & "' WHERE ID=" & Me.dgGeoPoints("ID", Me.dgGeoPoints.CurrentRow.Index).Value() & "")
        End If

        findCoord = False

        LoadGeopoints(Me.lstPartners.SelectedItem(0))

        Me.tlpAdres.Visible = False

        Me.btnAddGeopoint.Visible = True
    End Sub

    Private Sub txtAdresPoint_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAdressGeoPoint.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            findCoord = True ' признак поиска координат активен
            Me.DesCust.SelectedTab = Me.DesCust.TabPages.Item("web")
        End If
        e.Handled = True
    End Sub

    Private Sub DesCust_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles DesCust.Selecting
        Me.tsCompany.Visible = False

        Select Case Me.DesCust.SelectedTab.Name
            Case Is = "Web"
                Me.tsCompany.Visible = False
                
                overlay.Markers.Clear()
                If findCoord = True Then
                    If MessageBox.Show("Определить координаты по адресу? ВНИМАНИЕ!!! откроется вкладка с картой, на которой проверьте правильность нахождения объекта и при необходимости уточните его местоположение передвинув балун мышкой. После чего вернитесь на предыдущую вкладку и нажмите кнопку Сохранить.", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Try
                            GoogleMapControl.SetPositionByKeywords(Me.txtAdressGeoPoint.Text)'"Выборг"
                            Dim marker As New GMarkerGoogle(GoogleMapControl.Position, GMarkerGoogleType.red)
                            overlay.Markers.Add(marker)
                        Catch ex As System.Exception
                            MsgBox(ex.Message, appName)
                        End Try
                    Else
                        findCoord = False
                        Me.DesCust.SelectedTab = Me.DesCust.TabPages.Item("points")
                        Exit Sub
                    End If
                End If

            Case Is = "points"
                Me.tsCompany.Visible = False
                If findCoord = True Then
                    if (overlay.Markers.Count = 1) Then
                        Me.txtGeoPoint.Text = Replace(CStr(overlay.Markers(0).Position.Lat), ",", ".") + "," + Replace(CStr(overlay.Markers(0).Position.Lng), ",", ".")
                    Else
                        Me.txtGeoPoint.Text = ""
                    End If
                    Me.btnGeoSaveKA.Focus()
                End If
            Case Else
                Me.tsCompany.Visible = True
        End Select
    End Sub

    Private Sub tsbtnFindOrg_Click(sender As Object, e As EventArgs) Handles tsbtnFindOrg.Click
        mblnAdd = False
        ActivateEditing(False)
        FindList(InputBox("Введите часть названия, адреса, ФИО, телефона", "Поиск контрагента", ""), "[sp_Find_Organizations]")
    End Sub

    Private Sub tsbtnFindEmplKA_Click(sender As Object, e As EventArgs) Handles tsbtnFindEmplKA.Click
        mblnAdd = False
        ActivateEditing(False)
        FindList(InputBox("Введите часть ФИО, телефона", "Поиск контрагента", ""), "[sp_Find_Persons]")
    End Sub

    Private Sub btnAddGeopoint_Click(sender As Object, e As EventArgs) Handles btnAddGeopoint.Click
        Me.tlpAdres.Visible = True
        Me.btnAddGeopoint.Visible = False
        Me.txtNamePoint.Focus()

        addGeoPoint = True

        Me.btnGeoSaveKA.Visible = False
        Me.btnDetermine.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.tlpAdres.Visible = False
        Me.btnAddGeopoint.Visible = True
    End Sub

   
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim strAdress As String = Replace(Replace(Me.txtCity.Text, "ё", "е"), "Ё", "Е") + ", " + Replace(Replace(Me.txtStreet.Text, "ё", "е"), "Ё", "Е") + ", " + Me.txtDom.Text

        Me.txtAdressGeoPoint.Text = strAdress

        findCoord = True ' признак поиска координат активен

        Me.DesCust.SelectedTab = Me.DesCust.TabPages.Item("web")

        Me.btnGeoSaveKA.Visible = True
        Me.btnDetermine.Visible = False
    End Sub

    Private Sub GoogleMapControl_MouseMove(sender As Object, e As MouseEventArgs) Handles GoogleMapControl.MouseMove
        If (isDraggingMarker) Then
            If (overlay.Markers.Count = 1) Then
                overlay.Markers(0).Position = GoogleMapControl.FromLocalToLatLng(e.X, e.Y)
            End If
        End If
    End Sub

    Private Sub GoogleMapControl_OnMarkerClick(item As GMapMarker, e As MouseEventArgs) Handles GoogleMapControl.OnMarkerClick
        If (isDraggingMarker) Then 
            isDraggingMarker = false
        Else
            isDraggingMarker = true
        End If
    End Sub

    Private Sub GoogleMapControl_MouseClick(sender As Object, e As MouseEventArgs) Handles GoogleMapControl.MouseClick
        'isDraggingMarker = false
    End Sub
End Class
