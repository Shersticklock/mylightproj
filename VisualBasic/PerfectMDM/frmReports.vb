Imports System.Data.SqlClient
Imports System.Text

Public Class frmReports
    Inherits System.Windows.Forms.Form
    Dim checkPost As Boolean 'проверка должности для скрытия отчетов которые могут смотреть только руководители
    Dim drSelectReport As DataRow 'строка где все параметры выбранного отчета вкл имя хранимой процедуры


    Friend WithEvents cmbFormaOpl As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpParam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ПерейтиКЗаказуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДанныеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЭкспортВExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgItog As System.Windows.Forms.DataGridView
    Friend WithEvents cmbEmpl As System.Windows.Forms.ComboBox
    Friend WithEvents btnSelectCust As System.Windows.Forms.Button
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents ПечатьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFounder As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstReports As System.Windows.Forms.ListBox
    Friend WithEvents ОбновитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSelectOrg As System.Windows.Forms.Button
    Friend WithEvents tlpSelectDate As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbOffice As System.Windows.Forms.ComboBox
    Friend WithEvents tlpKA As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbTypesKA As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOrg As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblIntDat As System.Windows.Forms.Label
    Friend WithEvents НайтиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstxtstrFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TimeFrom As DateTimePicker
    Friend WithEvents TimeTo As DateTimePicker
    Friend WithEvents FrComboBox As ComboBox
    Friend WithEvents FrLabel As Label
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel

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
    Friend WithEvents cmbKA As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.cmbKA = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.cmbFormaOpl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lstReports = New System.Windows.Forms.ListBox()
        Me.tlpParam = New System.Windows.Forms.TableLayoutPanel()
        Me.FrComboBox = New System.Windows.Forms.ComboBox()
        Me.FrLabel = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbEmpl = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFounder = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbOrg = New System.Windows.Forms.ComboBox()
        Me.btnSelectOrg = New System.Windows.Forms.Button()
        Me.tlpSelectDate = New System.Windows.Forms.TableLayoutPanel()
        Me.TimeFrom = New System.Windows.Forms.DateTimePicker()
        Me.TimeTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOffice = New System.Windows.Forms.ComboBox()
        Me.tlpKA = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSelectCust = New System.Windows.Forms.Button()
        Me.cmbTypesKA = New System.Windows.Forms.ComboBox()
        Me.lblIntDat = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgItog = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ПерейтиКЗаказуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НайтиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ОбновитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДанныеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЭкспортВExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПечатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstxtstrFind = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer2.Panel1.SuspendLayout
        Me.SplitContainer2.Panel2.SuspendLayout
        Me.SplitContainer2.SuspendLayout
        Me.tlpParam.SuspendLayout
        Me.tlpSelectDate.SuspendLayout
        Me.tlpKA.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        CType(Me.dgItog,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ContextMenuStrip1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'cmbKA
        '
        Me.tlpKA.SetColumnSpan(Me.cmbKA, 2)
        Me.cmbKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbKA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbKA.Location = New System.Drawing.Point(3, 38)
        Me.cmbKA.MaxDropDownItems = 16
        Me.cmbKA.Name = "cmbKA"
        Me.cmbKA.Size = New System.Drawing.Size(475, 25)
        Me.cmbKA.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd.MM.yyyy"
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 24)
        Me.DateTimePicker1.TabIndex = 31
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd.MM.yyyy"
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(183, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(102, 24)
        Me.DateTimePicker2.TabIndex = 38
        '
        'cmbFormaOpl
        '
        Me.cmbFormaOpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFormaOpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaOpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbFormaOpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbFormaOpl.FormattingEnabled = true
        Me.cmbFormaOpl.Location = New System.Drawing.Point(122, 111)
        Me.cmbFormaOpl.Name = "cmbFormaOpl"
        Me.cmbFormaOpl.Size = New System.Drawing.Size(362, 25)
        Me.cmbFormaOpl.TabIndex = 45
        Me.cmbFormaOpl.Visible = false
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 31)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Форма оплаты"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = false
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = true
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 678)
        Me.SplitContainer1.SplitterDistance = 489
        Me.SplitContainer1.TabIndex = 64
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lstReports)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = true
        Me.SplitContainer2.Panel2.Controls.Add(Me.tlpParam)
        Me.SplitContainer2.Size = New System.Drawing.Size(489, 678)
        Me.SplitContainer2.SplitterDistance = 236
        Me.SplitContainer2.TabIndex = 0
        '
        'lstReports
        '
        Me.lstReports.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstReports.FormattingEnabled = true
        Me.lstReports.ItemHeight = 17
        Me.lstReports.Location = New System.Drawing.Point(0, 0)
        Me.lstReports.Name = "lstReports"
        Me.lstReports.Size = New System.Drawing.Size(487, 234)
        Me.lstReports.TabIndex = 0
        '
        'tlpParam
        '
        Me.tlpParam.AutoSize = true
        Me.tlpParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpParam.ColumnCount = 2
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpParam.Controls.Add(Me.FrComboBox, 1, 9)
        Me.tlpParam.Controls.Add(Me.FrLabel, 0, 9)
        Me.tlpParam.Controls.Add(Me.Label5, 0, 2)
        Me.tlpParam.Controls.Add(Me.cmbDepartment, 1, 4)
        Me.tlpParam.Controls.Add(Me.Label4, 0, 4)
        Me.tlpParam.Controls.Add(Me.Label6, 0, 3)
        Me.tlpParam.Controls.Add(Me.cmbFormaOpl, 1, 2)
        Me.tlpParam.Controls.Add(Me.cmbEmpl, 1, 3)
        Me.tlpParam.Controls.Add(Me.Label3, 0, 5)
        Me.tlpParam.Controls.Add(Me.cmbFounder, 1, 5)
        Me.tlpParam.Controls.Add(Me.Label7, 0, 6)
        Me.tlpParam.Controls.Add(Me.cmbOrg, 0, 7)
        Me.tlpParam.Controls.Add(Me.btnSelectOrg, 1, 6)
        Me.tlpParam.Controls.Add(Me.tlpSelectDate, 1, 0)
        Me.tlpParam.Controls.Add(Me.Label1, 0, 8)
        Me.tlpParam.Controls.Add(Me.cmbOffice, 1, 8)
        Me.tlpParam.Controls.Add(Me.tlpKA, 0, 1)
        Me.tlpParam.Controls.Add(Me.lblIntDat, 0, 0)
        Me.tlpParam.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpParam.Location = New System.Drawing.Point(0, 0)
        Me.tlpParam.Name = "tlpParam"
        Me.tlpParam.RowCount = 10
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpParam.Size = New System.Drawing.Size(487, 360)
        Me.tlpParam.TabIndex = 68
        '
        'FrComboBox
        '
        Me.FrComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FrComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FrComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.FrComboBox.FormattingEnabled = true
        Me.FrComboBox.Location = New System.Drawing.Point(122, 332)
        Me.FrComboBox.Name = "FrComboBox"
        Me.FrComboBox.Size = New System.Drawing.Size(362, 25)
        Me.FrComboBox.TabIndex = 90
        '
        'FrLabel
        '
        Me.FrLabel.AutoSize = true
        Me.FrLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.FrLabel.Location = New System.Drawing.Point(3, 329)
        Me.FrLabel.Name = "FrLabel"
        Me.FrLabel.Size = New System.Drawing.Size(113, 31)
        Me.FrLabel.TabIndex = 89
        Me.FrLabel.Text = "ФР"
        Me.FrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepartment.FormattingEnabled = true
        Me.cmbDepartment.Location = New System.Drawing.Point(122, 173)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(362, 25)
        Me.cmbDepartment.TabIndex = 74
        Me.cmbDepartment.Visible = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 31)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Департамент"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = false
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 31)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Сотрудник"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = false
        '
        'cmbEmpl
        '
        Me.cmbEmpl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEmpl.Location = New System.Drawing.Point(122, 142)
        Me.cmbEmpl.MaxDropDownItems = 16
        Me.cmbEmpl.Name = "cmbEmpl"
        Me.cmbEmpl.Size = New System.Drawing.Size(362, 25)
        Me.cmbEmpl.TabIndex = 70
        Me.cmbEmpl.Visible = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 31)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Источник"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFounder
        '
        Me.cmbFounder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFounder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFounder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbFounder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbFounder.FormattingEnabled = true
        Me.cmbFounder.Location = New System.Drawing.Point(122, 204)
        Me.cmbFounder.Name = "cmbFounder"
        Me.cmbFounder.Size = New System.Drawing.Size(362, 25)
        Me.cmbFounder.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 35)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Организация"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = false
        '
        'cmbOrg
        '
        Me.tlpParam.SetColumnSpan(Me.cmbOrg, 2)
        Me.cmbOrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOrg.FormattingEnabled = true
        Me.cmbOrg.Location = New System.Drawing.Point(3, 270)
        Me.cmbOrg.Name = "cmbOrg"
        Me.cmbOrg.Size = New System.Drawing.Size(481, 25)
        Me.cmbOrg.TabIndex = 81
        '
        'btnSelectOrg
        '
        Me.btnSelectOrg.AutoSize = true
        Me.btnSelectOrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelectOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSelectOrg.Location = New System.Drawing.Point(122, 235)
        Me.btnSelectOrg.Name = "btnSelectOrg"
        Me.btnSelectOrg.Size = New System.Drawing.Size(362, 29)
        Me.btnSelectOrg.TabIndex = 82
        Me.btnSelectOrg.Text = "Выбрать организацию"
        Me.btnSelectOrg.UseVisualStyleBackColor = true
        Me.btnSelectOrg.Visible = false
        '
        'tlpSelectDate
        '
        Me.tlpSelectDate.AutoSize = true
        Me.tlpSelectDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpSelectDate.ColumnCount = 4
        Me.tlpSelectDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.tlpSelectDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpSelectDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.tlpSelectDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20!))
        Me.tlpSelectDate.Controls.Add(Me.DateTimePicker1, 0, 0)
        Me.tlpSelectDate.Controls.Add(Me.DateTimePicker2, 2, 0)
        Me.tlpSelectDate.Controls.Add(Me.TimeFrom, 1, 0)
        Me.tlpSelectDate.Controls.Add(Me.TimeTo, 3, 0)
        Me.tlpSelectDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSelectDate.Location = New System.Drawing.Point(122, 3)
        Me.tlpSelectDate.Name = "tlpSelectDate"
        Me.tlpSelectDate.RowCount = 1
        Me.tlpSelectDate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSelectDate.Size = New System.Drawing.Size(362, 30)
        Me.tlpSelectDate.TabIndex = 83
        '
        'TimeFrom
        '
        Me.TimeFrom.CustomFormat = "HH:mm"
        Me.TimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeFrom.Location = New System.Drawing.Point(111, 3)
        Me.TimeFrom.Name = "TimeFrom"
        Me.TimeFrom.ShowUpDown = true
        Me.TimeFrom.Size = New System.Drawing.Size(66, 24)
        Me.TimeFrom.TabIndex = 39
        Me.TimeFrom.Value = New Date(2017, 7, 11, 0, 0, 0, 0)
        '
        'TimeTo
        '
        Me.TimeTo.CustomFormat = "HH:mm"
        Me.TimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeTo.Location = New System.Drawing.Point(291, 3)
        Me.TimeTo.Name = "TimeTo"
        Me.TimeTo.ShowUpDown = true
        Me.TimeTo.Size = New System.Drawing.Size(68, 24)
        Me.TimeTo.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 31)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Офис"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOffice
        '
        Me.cmbOffice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOffice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOffice.FormattingEnabled = true
        Me.cmbOffice.Location = New System.Drawing.Point(122, 301)
        Me.cmbOffice.Name = "cmbOffice"
        Me.cmbOffice.Size = New System.Drawing.Size(362, 25)
        Me.cmbOffice.TabIndex = 85
        '
        'tlpKA
        '
        Me.tlpKA.AutoSize = true
        Me.tlpKA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpKA.ColumnCount = 2
        Me.tlpParam.SetColumnSpan(Me.tlpKA, 2)
        Me.tlpKA.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.8871!))
        Me.tlpKA.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.1129!))
        Me.tlpKA.Controls.Add(Me.btnSelectCust, 1, 0)
        Me.tlpKA.Controls.Add(Me.cmbTypesKA, 0, 0)
        Me.tlpKA.Controls.Add(Me.cmbKA, 0, 1)
        Me.tlpKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpKA.Location = New System.Drawing.Point(3, 39)
        Me.tlpKA.Name = "tlpKA"
        Me.tlpKA.RowCount = 2
        Me.tlpKA.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpKA.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpKA.Size = New System.Drawing.Size(481, 66)
        Me.tlpKA.TabIndex = 87
        '
        'btnSelectCust
        '
        Me.btnSelectCust.AutoSize = true
        Me.btnSelectCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSelectCust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelectCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSelectCust.Location = New System.Drawing.Point(295, 3)
        Me.btnSelectCust.Name = "btnSelectCust"
        Me.btnSelectCust.Size = New System.Drawing.Size(183, 29)
        Me.btnSelectCust.TabIndex = 72
        Me.btnSelectCust.Text = "Выбрать"
        Me.btnSelectCust.UseVisualStyleBackColor = true
        '
        'cmbTypesKA
        '
        Me.cmbTypesKA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTypesKA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypesKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTypesKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbTypesKA.FormattingEnabled = true
        Me.cmbTypesKA.Location = New System.Drawing.Point(3, 3)
        Me.cmbTypesKA.Name = "cmbTypesKA"
        Me.cmbTypesKA.Size = New System.Drawing.Size(286, 25)
        Me.cmbTypesKA.TabIndex = 73
        '
        'lblIntDat
        '
        Me.lblIntDat.AutoSize = true
        Me.lblIntDat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIntDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblIntDat.Location = New System.Drawing.Point(3, 0)
        Me.lblIntDat.Name = "lblIntDat"
        Me.lblIntDat.Size = New System.Drawing.Size(113, 36)
        Me.lblIntDat.TabIndex = 88
        Me.lblIntDat.Text = "Интервал"
        Me.lblIntDat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgItog, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(781, 676)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'dgItog
        '
        Me.dgItog.AllowUserToAddRows = false
        Me.dgItog.AllowUserToDeleteRows = false
        Me.dgItog.AllowUserToResizeRows = false
        Me.dgItog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgItog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItog.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgItog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItog.Location = New System.Drawing.Point(3, 30)
        Me.dgItog.Name = "dgItog"
        Me.dgItog.ReadOnly = true
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dgItog.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgItog.RowTemplate.Height = 24
        Me.dgItog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItog.Size = New System.Drawing.Size(775, 643)
        Me.dgItog.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПерейтиКЗаказуToolStripMenuItem, Me.НайтиToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(197, 48)
        '
        'ПерейтиКЗаказуToolStripMenuItem
        '
        Me.ПерейтиКЗаказуToolStripMenuItem.Name = "ПерейтиКЗаказуToolStripMenuItem"
        Me.ПерейтиКЗаказуToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ПерейтиКЗаказуToolStripMenuItem.Text = "Перейти к заказу"
        '
        'НайтиToolStripMenuItem
        '
        Me.НайтиToolStripMenuItem.Name = "НайтиToolStripMenuItem"
        Me.НайтиToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.НайтиToolStripMenuItem.Text = "Найти"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОбновитьToolStripMenuItem, Me.ДанныеToolStripMenuItem, Me.tstxtstrFind, Me.ToolStripMenuItem1, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(781, 27)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ОбновитьToolStripMenuItem
        '
        Me.ОбновитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.ОбновитьToolStripMenuItem.Name = "ОбновитьToolStripMenuItem"
        Me.ОбновитьToolStripMenuItem.Size = New System.Drawing.Size(89, 23)
        Me.ОбновитьToolStripMenuItem.Text = "Обновить"
        '
        'ДанныеToolStripMenuItem
        '
        Me.ДанныеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЭкспортВExcelToolStripMenuItem, Me.ПечатьToolStripMenuItem})
        Me.ДанныеToolStripMenuItem.Name = "ДанныеToolStripMenuItem"
        Me.ДанныеToolStripMenuItem.Size = New System.Drawing.Size(75, 23)
        Me.ДанныеToolStripMenuItem.Text = "Данные"
        '
        'ЭкспортВExcelToolStripMenuItem
        '
        Me.ЭкспортВExcelToolStripMenuItem.Name = "ЭкспортВExcelToolStripMenuItem"
        Me.ЭкспортВExcelToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ЭкспортВExcelToolStripMenuItem.Text = "Экспорт в Excel"
        '
        'ПечатьToolStripMenuItem
        '
        Me.ПечатьToolStripMenuItem.Name = "ПечатьToolStripMenuItem"
        Me.ПечатьToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ПечатьToolStripMenuItem.Text = "Экспорт в HTML"
        '
        'tstxtstrFind
        '
        Me.tstxtstrFind.BackColor = System.Drawing.SystemColors.Info
        Me.tstxtstrFind.Name = "tstxtstrFind"
        Me.tstxtstrFind.Size = New System.Drawing.Size(156, 23)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(70, 23)
        Me.ToolStripMenuItem1.Text = "Искать"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(66, 23)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 676)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1276, 22)
        Me.StatusStrip1.TabIndex = 69
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(163, 19)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Visible = false
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(190, 19)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Visible = false
        '
        'frmReports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(1276, 698)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Отчеты"
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        Me.SplitContainer2.Panel2.PerformLayout
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        Me.tlpParam.ResumeLayout(false)
        Me.tlpParam.PerformLayout
        Me.tlpSelectDate.ResumeLayout(false)
        Me.tlpKA.ResumeLayout(false)
        Me.tlpKA.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        CType(Me.dgItog,System.ComponentModel.ISupportInitialize).EndInit
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

#Region " Загрузка формы "
    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim odaFopl As New SqlClient.SqlDataAdapter("SELECT * FROM Fopl", mcnnInt)
            Dim dtFopl As New DataTable

            odaFopl.Fill(dtFopl)
            Me.cmbFormaOpl.DataSource = dtFopl
            Me.cmbFormaOpl.DisplayMember = "name"
            Me.cmbFormaOpl.ValueMember = "ID"

            Dim odaTypesKAgent As New SqlClient.SqlDataAdapter("SELECT ID, name FROM TypesKAgent", mcnnInt)
            Dim dtTypesKAgent As New DataTable

            odaTypesKAgent.Fill(dtTypesKAgent)
            Me.cmbTypesKA.DataSource = dtTypesKAgent 'Связать данные со списком
            Me.cmbTypesKA.DisplayMember = "name"
            Me.cmbTypesKA.ValueMember = "ID"

            'Загрузка отчетов
            Dim odaReports1 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM ReportsSettings WHERE active=1 order by name", mcnnInt)
            Dim dtReports1 As New DataTable

            odaReports1.Fill(dtReports1)
            Me.lstReports.DataSource = dtReports1
            Me.lstReports.DisplayMember = "name"
            Me.lstReports.ValueMember = "ID"

            'Загрузка фисов
            Dim odaOffice As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Offices", mcnnInt)
            Dim dtOffices As New DataTable

            odaOffice.Fill(dtOffices)
            Me.cmbOffice.DataSource = dtOffices
            Me.cmbOffice.DisplayMember = "name"
            Me.cmbOffice.ValueMember = "ID"

            Dim odaOrg As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Services where active=1 order by name", mcnnInt)
            Dim dtOrg As New DataTable

            odaOrg.Fill(dtOrg)
            Me.cmbOrg.DataSource = dtOrg
            Me.cmbOrg.DisplayMember = "name"
            Me.cmbOrg.ValueMember = "ID"

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_FilterManager]"
            cmd.CommandType = CommandType.StoredProcedure
            Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
            Dim dtMan As New DataTable

            odaMan.Fill(dtMan)
            Me.cmbEmpl.DataSource = dtMan
            Me.cmbEmpl.DisplayMember = "emplLastName"
            Me.cmbEmpl.ValueMember = "emplID"

            Dim cmd1 As New SqlClient.SqlCommand
            cmd1.Connection = mcnnInt
            cmd1.CommandText = "[sp_FilterFounders]"
            cmd1.CommandType = CommandType.StoredProcedure
            Dim odaFounder As New SqlClient.SqlDataAdapter(cmd1)
            Dim dtFounders As New DataTable

            odaFounder.Fill(dtFounders)
            Me.cmbFounder.DataSource = dtFounders
            Me.cmbFounder.DisplayMember = "Name"
            Me.cmbFounder.ValueMember = "ID"

            'Загружаем список департаментов
            Dim odaDep As New SqlClient.SqlDataAdapter("SELECT ID, name FROM Departments order by name", mcnnInt) '("SELECT custID, Name FROM Organizations WHERE KAgent_ID  = (SELECT ID FROM KAgents WHERE type_ID = 1)", mcnnInt)
            Dim dtDep As New DataTable

            odaDep.Fill(dtDep)
            Me.cmbDepartment.DataSource = dtDep
            Me.cmbDepartment.DisplayMember = "Name"
            Me.cmbDepartment.ValueMember = "ID"

            Dim frSql As String = "Select ID, name FROM FiscalRegistrar"
            Dim frSqlDataAdapter As New SqlDataAdapter(frSql, mcnnInt)
            Dim frDataTable As New DataTable
            frSqlDataAdapter.Fill(frDataTable)
            Me.FrComboBox.DataSource = frDataTable
            Me.FrComboBox.DisplayMember = "name"
            Me.FrComboBox.ValueMember = "ID"

        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " Выбор отчета "
    Private Sub lstReports_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstReports.SelectedIndexChanged
        Try
            Dim modaRepSet As New SqlClient.SqlDataAdapter("SELECT * FROM ReportsSettings WHERE ReportsSettings.ID =  " & Me.lstReports.SelectedItem(0) & " ", mcnnInt)
            Dim dtRepSet As New DataTable : modaRepSet.Fill(dtRepSet)

            drSelectReport = dtRepSet.Rows(0)

            Me.tlpSelectDate.Visible = drSelectReport("intervalData")
            Me.lblIntDat.Visible = drSelectReport("intervalData")

            TimeVisible(drSelectReport("time"))
            SetTimeValue(drSelectReport("setFullDayTime"))
            SetMonthNumber(drSelectReport("firstMonthNumber"), drSelectReport("lastMonthNumber"))
            FrVisible(drSelectReport("fiscalRegistrar"))
            CustomerVisible(drSelectReport("customer"))
            EmplVisible(drSelectReport("manager"))
            FormPay(drSelectReport("formPay"))
            DepVisible(drSelectReport("department"))
            founder(drSelectReport("Founder"))
            org(drSelectReport("Organization"))
            office(drSelectReport("office"))

            Me.SplitContainer2.SplitterDistance = Me.SplitContainer2.Height - Me.tlpParam.Size.Height - 10
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Sub
        End Try
    End Sub
#End Region

#Region " Переход к заказу "
    Private Sub ПерейтиКЗаказуToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem.Click
        Dim frmSelect As frmOrder

        Try
            frmSelect = New frmOrder
            costID = Me.dgItog("costID", Me.dgItog.CurrentRow.Index).Value()
            frmSelect.ShowDialog()
        Catch excp As System.Exception
            If costID = 0 Then
                MessageBox.Show("Заказ не выбран.", appName)
            Else
                MessageBox.Show("Переход к заказу невозможен.  " & CStr(costID), appName)
            End If

            Exit Sub
        End Try
    End Sub
#End Region

#Region " Экспорт в Excel "
    Private Sub ЭкспортВExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЭкспортВExcelToolStripMenuItem.Click

        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        Dim tmpDataSet As DataTable = CType(dgItog.DataSource, DataTable)
        Dim hiderText As String = Me.lstReports.SelectedItem(1)
        ' Dim nnn As Integer = 0

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True

            If Me.cmbKA.Visible = True Then
                hiderText += ", Контрагент- " + Me.cmbKA.Text
            End If
            If Me.cmbEmpl.Visible = True Then
                hiderText += ", Сотрудник- " + Me.cmbEmpl.Text
            End If
            If Me.cmbFormaOpl.Visible = True Then
                hiderText += ", Форма оплаты- " + Me.cmbFormaOpl.Text
            End If
            If Me.cmbDepartment.Visible = True Then
                hiderText += ", Департамент- " + Me.cmbDepartment.Text
            End If
            If Me.cmbFounder.Visible = True Then
                hiderText += ", Учредитель- " + Me.cmbFounder.Text
            End If
            If Me.cmbOrg.Visible = True Then
                hiderText += ", Организация- " + Me.cmbOrg.Text
            End If
            If Me.cmbOffice.Visible = True Then
                hiderText += ", Офис- " + Me.cmbOffice.Text
            End If
            If Me.DateTimePicker1.Visible = True Then 'Описываем параметры
                hiderText += ", Период- " + Me.DateTimePicker1.Text + " - " + Me.DateTimePicker2.Text
            End If

            .Range("B2").Value = "Отчет " & hiderText

            For iCol = 0 To dgItog.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgItog.Columns(iCol).HeaderText.ToString

                For iRow = 0 To tmpDataSet.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(dgItog(iCol, iRow).Value), "", dgItog(iCol, iRow).Value)
                Next iRow

                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol
        End With
    End Sub
#End Region

#Region " Выход "
    Private Sub ВыходToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВыходToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Закрыть отчет? ", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes : Me.Close()
            Case Is = vbNo : Exit Sub
        End Select
    End Sub
#End Region

    Private Sub btnSelectCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectCust.Click
        Try
            Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE Name LIKE '" & InputBox("Введите часть названия", "Поиск контрагента", "") & "%' AND type_ID = " & Me.cmbTypesKA.SelectedItem(0) & " order by Name", mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmbKA.DataSource = dtPartList
            Me.cmbKA.DisplayMember = "Name"
            Me.cmbKA.ValueMember = "ID"
            Me.cmbKA.Visible = True
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

#Region " Управляем видимостью элементов управления "
    Private Sub TimeVisible(ByVal visible As Boolean)
        If (visible) Then
            TimeTo.Visible = True
            TimeFrom.Visible = True
            tlpSelectDate.SetColumnSpan(DateTimePicker1, 1)
            tlpSelectDate.SetColumnSpan(DateTimePicker2, 1)
        Else
            TimeTo.Visible = False
            TimeFrom.Visible = False
            tlpSelectDate.SetColumnSpan(DateTimePicker1, 2)
            tlpSelectDate.SetColumnSpan(DateTimePicker2, 2)
        End If
    End Sub

    Private Sub SetTimeValue(ByVal visible As Boolean)
        if (visible) Then
            Me.TimeFrom.Value = New Date(2017, 7, 11, 0, 0, 0, 0)
            Me.TimeTo.Value = New Date(2017, 7, 11, 23, 59, 59, 0)
        End If
    End Sub

    Private Sub SetMonthNumber(ByVal firstDay As Boolean, ByVal lastDay As Boolean)
        If (Not firstDay And Not lastDay) Then
            Exit Sub
        End If

        Dim dateFrom As DateTime = Now()
        Dim dateTo As DateTime = Now()

        If (firstDay) Then
            dateFrom = dateFrom.AddDays(-(Now().Day) + 1)
        End If
        If (lastDay) Then
            dateTo = dateTo.AddMonths(1).AddDays(-(Now().Day))
        End If

        DateTimePicker1.Value = dateFrom
        DateTimePicker2.Value = dateTo
    End Sub

    Private Sub FrVisible(ByVal visible As Boolean)
        FrComboBox.Visible = visible
        FrLabel.Visible = visible
    End Sub

    Private Sub CustomerVisible(ByVal visible As Boolean)
        Me.tlpKA.Visible = visible
    End Sub

    Private Sub FormPay(ByVal visible As Boolean)
        Me.Label5.Visible = visible
        Me.cmbFormaOpl.Visible = visible
    End Sub

    Private Sub EmplVisible(ByVal visible As Boolean)
        Me.cmbEmpl.Visible = visible
        Me.Label6.Visible = visible
    End Sub

    Private Sub DepVisible(ByVal visible As Boolean)
        Me.cmbDepartment.Visible = visible
        Me.Label4.Visible = visible
    End Sub

    Private Sub founder(ByVal visible As Boolean)
        Me.cmbFounder.Visible = visible
        Me.Label3.Visible = visible
    End Sub

    Private Sub org(ByVal visible As Boolean)
        Me.cmbOrg.Visible = visible
        ' Me.btnSelectOrg.Visible = False
        ' Me.Label7.Visible = False
    End Sub

    Private Sub office(ByVal visible As Boolean)
        Me.cmbOffice.Visible = visible
        Me.Label1.Visible = visible
    End Sub
#End Region

    Public Function GenerateHTML(ByVal dgv As DataGridView) As String
        Dim xml As New StringBuilder()
        xml.Append("<HTML>")
        xml.Append("<HEAD></HEAD>")
        xml.Append("<BODY>")
        xml.Append("<table width='100%' border='1'>")
        xml.Append("<tr>")
        'xml.Append("<td>").Append("Direct").Append("</td>")
        ' xml.Append("<td>").Append("Reverse").Append("</td>")
        'xml.Append("<td>").Append("Volume").Append("</td>")
        ' xml.Append("<td>").Append("Instrument Type").Append("</td>")
        'xml.Append("<td>").Append("Book").Append("</td>")
        xml.Append("<td>").Append("Page").Append("</td>")
        'xml.Append("<td>").Append("Filing Date").Append("</td>")
        'xml.Append("<td>").Append("Instrument Date").Append("</td>")
        xml.Append("</tr>")

        For Each dr As DataGridViewRow In dgv.Rows
            xml.Append("<tr>")
            For Each cell As DataGridViewCell In dr.Cells
                xml.Append("<td>").Append(cell.Value).Append("</td>")
            Next
            xml.Append("</tr>")
        Next

        xml.Append("</table>")
        xml.Append("</BODY>")
        xml.Append("</HTML>")
        Return xml.ToString
    End Function

    Public Sub SaveHTML(ByVal strHTML As String)
        Dim htmlFile As New IO.FileInfo("C:\tmp\report.html")
        Dim sw As New IO.StreamWriter("C:\tmp\report.html", False, System.Text.Encoding.GetEncoding(1251)) ' = htmlFile.CreateText()
        'Если поставить не False а True, то запись будет в конец файла. Т.е. если в файле уже есть текст, то этот текст стераться не будет, а новый будет добавляться в конец. Если файла не существует, то он создаваться не будет. А если же поставить False, то если в файле был текст, то он стерается, и запись идет в пустой файл. Если файла не существует, то он создается. Дальше идет тип кодировки, в нашем случае это стандартная 1251 
        sw.WriteLine(strHTML)
        sw.Close()
        Process.Start("C:\tmp\report.html")
    End Sub

    Public Sub PrintHTML()
        Try
            Dim MyProcess As New Process
            MyProcess.StartInfo.CreateNoWindow = False
            MyProcess.StartInfo.Verb = "print"
            MyProcess.StartInfo.FileName = "C:\report.html"
            MyProcess.Start()
            MyProcess.WaitForExit()
        Catch ex As System.Exception
            MessageBox.Show("Printing error", appName)
        End Try
    End Sub

    Private Sub ПечатьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПечатьToolStripMenuItem.Click
        SaveHTML(GenerateHTML(Me.dgItog))
    End Sub

    Private Sub ОбновитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОбновитьToolStripMenuItem.Click

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_R" + drSelectReport("ID").ToString
        cmd.CommandType = CommandType.StoredProcedure

        If Me.DateTimePicker1.Visible = True Then 'Описываем параметры
            Dim dateTimeFrom As Date = DateTimePicker1.Value.Date
            Dim dateTimeTo As Date = DateTimePicker2.Value.Date

            If (TimeFrom.Visible) Then
                dateTimeFrom = dateTimeFrom.Add(TimeFrom.Value.TimeOfDay)
            End If

            If (TimeTo.Visible) Then
                dateTimeTo = dateTimeTo.Add(TimeTo.Value.TimeOfDay)
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.DateTime))
            cmd.Parameters("@Data1").Value = dateTimeFrom
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Data2", SqlDbType.DateTime))
            cmd.Parameters("@Data2").Value = dateTimeTo
        End If

        If Me.cmbKA.Visible = True Then
            If Me.cmbKA.SelectedIndex = -1 Then
                MsgBox("Не выбрано значение", MsgBoxStyle.Critical, appName) : Me.cmbKA.Focus() : Exit Sub
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@custID", SqlDbType.Int))
                cmd.Parameters("@custID").Value = Me.cmbKA.SelectedItem(0)
            End If
        End If

        If Me.cmbEmpl.Visible = True Then
            If Me.cmbEmpl.SelectedIndex = -1 Then
                MsgBox("Не выбрано значение", MsgBoxStyle.Critical, appName) : Me.cmbEmpl.Focus() : Exit Sub
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@manID", SqlDbType.Int))
                cmd.Parameters("@ManID").Value = Me.cmbEmpl.SelectedItem(0)
            End If
        End If

        If Me.cmbFormaOpl.Visible = True Then
            If Me.cmbFormaOpl.SelectedIndex = -1 Then
                MsgBox("Не выбрано значение", MsgBoxStyle.Critical, appName) : Me.cmbFormaOpl.Focus() : Exit Sub
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@FPID", SqlDbType.Int))
                cmd.Parameters("@FPID").Value = Me.cmbFormaOpl.SelectedItem(0)
            End If
        End If

        If Me.cmbDepartment.Visible = True Then
            If Me.cmbDepartment.SelectedIndex = -1 Then
                MsgBox("Не выбрано значение", MsgBoxStyle.Critical, appName) : Me.cmbDepartment.Focus() : Exit Sub
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
                cmd.Parameters("@depID").Value = Me.cmbDepartment.SelectedItem(0)
            End If
        End If

        If Me.cmbFounder.Visible = True Then
            If Me.cmbFounder.SelectedIndex = -1 Then
                MsgBox("Не выбрано значение", MsgBoxStyle.Critical, appName) : Me.cmbFounder.Focus() : Exit Sub
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@founderID", SqlDbType.Int))
                cmd.Parameters("@founderID").Value = Me.cmbFounder.SelectedItem(0)
            End If
        End If

        If Me.cmbOrg.Visible = True Then
            If Me.cmbOrg.SelectedIndex = -1 Then
                MsgBox("Не выбрано значение", MsgBoxStyle.Critical, appName) : Me.cmbOrg.Focus() : Exit Sub
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
                cmd.Parameters("@orgID").Value = Me.cmbOrg.SelectedItem(0)
            End If
        End If

        If Me.cmbOffice.Visible = True Then
            cmd.Parameters.Add(New SqlClient.SqlParameter("@officeID", SqlDbType.Int))
            cmd.Parameters("@officeID").Value = Me.cmbOffice.SelectedItem(0)
        End If

        If Me.FrComboBox.Visible = True Then
            If FrComboBox.SelectedIndex = -1 Then
                MsgBox("Не выбран ФР!", MsgBoxStyle.Critical, appName)
                FrComboBox.Focus()
                Exit Sub
            Else
                cmd.Parameters.Add(New SqlParameter("@fr", SqlDbType.Int))
                cmd.Parameters("@fr").Value = Me.FrComboBox.SelectedItem(0)
            End If
        End If

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtItog As New DataTable

        objDA.Fill(dtItog)

        dtItog.Rows.Add()

        If (Not IsDBNull(drSelectReport("resultColumns"))) Then
            Dim columns As String() = drSelectReport("resultColumns").ToString().Split(";")
            For Each columnName As String In columns
                Try
                    dtItog.Rows(dtItog.Rows.Count - 1)(columnName) = dtItog.Compute("SUM([" & columnName & "])", "")
                Catch ex As Exception
                End Try
            Next
        End If

        Me.dgItog.Columns.Clear()
        Me.dgItog.DataSource = dtItog

        ColHideDG()
    End Sub

    Private Sub ColHideDG()
        For Each col As Object In Me.dgItog.Columns
            If col.name = "costID" Then
                col.visible = False
            End If

            If col.name = "ID" Then
                col.visible = False
            End If
        Next

        Me.dgItog.ClearSelection()
    End Sub

    'Private Sub btnSelectOrg_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectOrg.Click
    '    Try
    '        Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE Name LIKE '%" & InputBox("Введите часть названия", "Поиск организации", "") & "%'", mcnnInt)
    '        Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

    '        Me.cmbOrg.DataSource = dtPartList
    '        Me.cmbOrg.DisplayMember = "Name"
    '        Me.cmbOrg.ValueMember = "custID"
    '    Catch oexpData As System.Exception
    '        MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
    '    End Try
    'End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Find()
    End Sub

    Private Sub Find()
        Me.dgItog.ClearSelection()

        Dim Row As DataGridViewRow

        Dim str_find As String = Me.tstxtstrFind.Text
        Dim a As Boolean = False

        For Each Row In Me.dgItog.Rows
            For Each cell As DataGridViewCell In Row.Cells
                If (cell.FormattedValue).ToUpper.Contains(str_find.ToUpper) Then
                    Me.dgItog.Rows(Row.Index).Selected = True
                    a = True
                End If
            Next
        Next

        If a = False Then MsgBox(str_find & " не найден", 32, "Поиск")
    End Sub

    Private Sub tstxtstrFind_KeyDown(sender As Object, e As KeyEventArgs) Handles tstxtstrFind.KeyDown
        If e.KeyCode = Keys.Enter Then Find()
        e.Handled = True
    End Sub
End Class
