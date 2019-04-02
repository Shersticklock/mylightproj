Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.CompilerServices
Imports Cassa

Public Class frmMainForm
    Inherits System.Windows.Forms.Form
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OrderGo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents �������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tscmbServices As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������������������ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ��������Excel��������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ��������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbtnMyOplOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbtnMyZavtraSdavat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents �����������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpProdMan As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgTasks As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Countdown1 As PerfectCRM.Countdown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tsslDolgItog As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnUpdateTask As System.Windows.Forms.Button
    Friend WithEvents cmsTasks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ��������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents scCommonFindNew As System.Windows.Forms.SplitContainer
    Friend WithEvents tlpFind As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtpOrderClosed2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpOrderClosed1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPerson As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProdukt As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCustForSearh As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPredoplata As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustForSearh As System.Windows.Forms.TextBox
    Friend WithEvents cmbManager As System.Windows.Forms.ComboBox
    Friend WithEvents chkProdukt As System.Windows.Forms.CheckBox
    Friend WithEvents chkCustForSearh As System.Windows.Forms.CheckBox
    Friend WithEvents chkPerson As System.Windows.Forms.CheckBox
    Friend WithEvents chkOrderClosed As System.Windows.Forms.CheckBox
    Friend WithEvents cmbDesignerFind As System.Windows.Forms.ComboBox
    Friend WithEvents dtpMaket As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDataPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDataVydahi As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkMaketOut As System.Windows.Forms.CheckBox
    Friend WithEvents dtpOrder2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents chkMan As System.Windows.Forms.CheckBox
    Friend WithEvents dtpOrder1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFindNomer As System.Windows.Forms.CheckBox
    Friend WithEvents chkDataOut As System.Windows.Forms.CheckBox
    Friend WithEvents chkDesignerFind As System.Windows.Forms.CheckBox
    Friend WithEvents chkPredoplata As System.Windows.Forms.CheckBox
    Friend WithEvents tlpNewOrder As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbOrganization As System.Windows.Forms.ComboBox
    Private WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents txtFindCust As System.Windows.Forms.TextBox
    Friend WithEvents txtFindProd As System.Windows.Forms.TextBox
    Friend WithEvents lbReclama As System.Windows.Forms.Label
    Friend WithEvents cmbMarketing As System.Windows.Forms.ComboBox
    Friend WithEvents lbOrganization As System.Windows.Forms.Label
    Friend WithEvents btnSaveOrder As System.Windows.Forms.Button
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsKA As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ���������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtKAname As System.Windows.Forms.TextBox
    Friend WithEvents btnKAsave As System.Windows.Forms.Button
    Friend WithEvents btnKAcancel As System.Windows.Forms.Button
    Friend WithEvents ����������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgTasks1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmsTask1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents �������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbProd As System.Windows.Forms.ComboBox
    Friend WithEvents �������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clbCondition As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GanterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkReclama As System.Windows.Forms.CheckBox
    Friend WithEvents cmbReclama As System.Windows.Forms.ComboBox
    Friend WithEvents ��������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsslAWC As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkOrg As System.Windows.Forms.CheckBox
    Friend WithEvents cmbOrg As System.Windows.Forms.ComboBox
    Public WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ����������������SMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbSelectRel As System.Windows.Forms.ComboBox
    Friend WithEvents �������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������������ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtKAtel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents �����������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstxtContextFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TransDataToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbDataVydahi As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMaket As System.Windows.Forms.ComboBox
    Friend WithEvents �������������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ������������777ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �����ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ShowOrdersWithProblem As ToolStripButton
    Friend WithEvents FRDirectoryMenuItem As ToolStripMenuItem
    Friend WithEvents FRSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsslTotalCost As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rightTableLayoutPanel As TableLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtnNewOrder As ToolStripButton
    Friend WithEvents tsbtnFindOrder As ToolStripButton
    Friend WithEvents tsbtnFastOrder As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbtnKassa As ToolStripButton
    Friend WithEvents tsbtnDocuments As ToolStripButton
    Friend WithEvents tsbtnRegInvoice As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbtnTasks As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ShowMoneyInCassaButton As ToolStripButton
    Friend WithEvents tsbtnKassa2 As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents OfficeDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperatorsPerformanceReportButton As ToolStripButton
    Friend WithEvents ������������������������ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkShowDismissedManagers As CheckBox
    Friend WithEvents chkShowDismissedExecutors As CheckBox
    Friend WithEvents chkCostType As CheckBox
    Friend WithEvents clbCostType As CheckedListBox
    Friend WithEvents ����������������������ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbCostActivity As ComboBox
    Friend WithEvents chkContextSearch As CheckBox
    Friend WithEvents ManagersPerformanceReportButton As ToolStripButton
    Friend WithEvents tsbtnClaimAndOffers As ToolStripButton


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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.cmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OrderGo = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������������ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtCustForSearh = New System.Windows.Forms.TextBox()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.cmbDesignerFind = New System.Windows.Forms.ComboBox()
        Me.txtFindProd = New System.Windows.Forms.TextBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.cmsKA = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.�����������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbProd = New System.Windows.Forms.ComboBox()
        Me.cmbProdukt = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tscmbServices = New System.Windows.Forms.ToolStripComboBox()
        Me.�����ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������Excel��������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.�����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������777ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������SMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransDataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FRDirectoryMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfficeDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GanterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.����������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FRSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�����ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslTotalCost = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslDolgItog = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAWC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rightTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNewOrder = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnFindOrder = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnFastOrder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnKassa = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDocuments = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnRegInvoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnTasks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowMoneyInCassaButton = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnKassa2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.OperatorsPerformanceReportButton = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnClaimAndOffers = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.scCommonFindNew = New System.Windows.Forms.SplitContainer()
        Me.tlpFind = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbCostActivity = New System.Windows.Forms.ComboBox()
        Me.dtpOrderClosed2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpOrderClosed1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbPerson = New System.Windows.Forms.ComboBox()
        Me.cmbCustForSearh = New System.Windows.Forms.ComboBox()
        Me.cmbPredoplata = New System.Windows.Forms.ComboBox()
        Me.chkProdukt = New System.Windows.Forms.CheckBox()
        Me.chkCustForSearh = New System.Windows.Forms.CheckBox()
        Me.chkPerson = New System.Windows.Forms.CheckBox()
        Me.chkOrderClosed = New System.Windows.Forms.CheckBox()
        Me.dtpMaket = New System.Windows.Forms.DateTimePicker()
        Me.chkDataPeriod = New System.Windows.Forms.CheckBox()
        Me.dtpDataVydahi = New System.Windows.Forms.DateTimePicker()
        Me.chkMaketOut = New System.Windows.Forms.CheckBox()
        Me.dtpOrder2 = New System.Windows.Forms.DateTimePicker()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.chkMan = New System.Windows.Forms.CheckBox()
        Me.dtpOrder1 = New System.Windows.Forms.DateTimePicker()
        Me.chkFindNomer = New System.Windows.Forms.CheckBox()
        Me.chkDataOut = New System.Windows.Forms.CheckBox()
        Me.chkDesignerFind = New System.Windows.Forms.CheckBox()
        Me.chkPredoplata = New System.Windows.Forms.CheckBox()
        Me.clbCondition = New System.Windows.Forms.CheckedListBox()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.chkReclama = New System.Windows.Forms.CheckBox()
        Me.cmbReclama = New System.Windows.Forms.ComboBox()
        Me.chkOrg = New System.Windows.Forms.CheckBox()
        Me.cmbOrg = New System.Windows.Forms.ComboBox()
        Me.cmbSelectRel = New System.Windows.Forms.ComboBox()
        Me.cmbDataVydahi = New System.Windows.Forms.ComboBox()
        Me.cmbMaket = New System.Windows.Forms.ComboBox()
        Me.chkShowDismissedManagers = New System.Windows.Forms.CheckBox()
        Me.chkShowDismissedExecutors = New System.Windows.Forms.CheckBox()
        Me.chkCostType = New System.Windows.Forms.CheckBox()
        Me.clbCostType = New System.Windows.Forms.CheckedListBox()
        Me.tlpNewOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbOrganization = New System.Windows.Forms.ComboBox()
        Me.txtFindCust = New System.Windows.Forms.TextBox()
        Me.lbReclama = New System.Windows.Forms.Label()
        Me.cmbMarketing = New System.Windows.Forms.ComboBox()
        Me.lbOrganization = New System.Windows.Forms.Label()
        Me.txtKAname = New System.Windows.Forms.TextBox()
        Me.btnKAcancel = New System.Windows.Forms.Button()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.btnKAsave = New System.Windows.Forms.Button()
        Me.txtKAtel = New System.Windows.Forms.MaskedTextBox()
        Me.tlpProdMan = New System.Windows.Forms.TableLayoutPanel()
        Me.dgTasks = New System.Windows.Forms.DataGridView()
        Me.cmsTasks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.��������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateTask = New System.Windows.Forms.Button()
        Me.dgTasks1 = New System.Windows.Forms.DataGridView()
        Me.cmsTask1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.�������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.���������������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.�������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.��������������ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkContextSearch = New System.Windows.Forms.CheckBox()
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tsbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowOrdersWithProblem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnMyOplOrder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnMyZavtraSdavat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstxtContextFind = New System.Windows.Forms.ToolStripTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ManagersPerformanceReportButton = New System.Windows.Forms.ToolStripButton()
        Me.cmsMain.SuspendLayout
        Me.cmsKA.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.rightTableLayoutPanel.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer2.Panel1.SuspendLayout
        Me.SplitContainer2.Panel2.SuspendLayout
        Me.SplitContainer2.SuspendLayout
        CType(Me.scCommonFindNew,System.ComponentModel.ISupportInitialize).BeginInit
        Me.scCommonFindNew.Panel1.SuspendLayout
        Me.scCommonFindNew.Panel2.SuspendLayout
        Me.scCommonFindNew.SuspendLayout
        Me.tlpFind.SuspendLayout
        Me.tlpNewOrder.SuspendLayout
        Me.tlpProdMan.SuspendLayout
        CType(Me.dgTasks,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsTasks.SuspendLayout
        CType(Me.dgTasks1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsTask1.SuspendLayout
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.BindingNavigator1.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Timer3
        '
        Me.Timer3.Enabled = true
        Me.Timer3.Interval = 360000
        '
        'cmsMain
        '
        Me.cmsMain.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderGo, Me.����������������������ExcelToolStripMenuItem, Me.��������ToolStripMenuItem, Me.����������������ToolStripMenuItem, Me.��������������ToolStripMenuItem, Me.��������������ToolStripMenuItem, Me.�������������ToolStripMenuItem1})
        Me.cmsMain.Name = "ContextMenuOrder"
        Me.cmsMain.ShowImageMargin = false
        Me.cmsMain.ShowItemToolTips = false
        Me.cmsMain.Size = New System.Drawing.Size(246, 158)
        '
        'OrderGo
        '
        Me.OrderGo.Name = "OrderGo"
        Me.OrderGo.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Space),System.Windows.Forms.Keys)
        Me.OrderGo.Size = New System.Drawing.Size(245, 22)
        Me.OrderGo.Text = "������� � ������"
        '
        '����������������������ExcelToolStripMenuItem
        '
        Me.����������������������ExcelToolStripMenuItem.Name = "����������������������ExcelToolStripMenuItem"
        Me.����������������������ExcelToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.����������������������ExcelToolStripMenuItem.Text = "������� � Excel"
        '
        '��������ToolStripMenuItem
        '
        Me.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem"
        Me.��������ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.��������ToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.��������ToolStripMenuItem.Text = "��������"
        '
        '����������������ToolStripMenuItem
        '
        Me.����������������ToolStripMenuItem.Name = "����������������ToolStripMenuItem"
        Me.����������������ToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.����������������ToolStripMenuItem.Text = "������ �� ��������"
        '
        '��������������ToolStripMenuItem
        '
        Me.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem"
        Me.��������������ToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.��������������ToolStripMenuItem.Text = "��������� ����� "
        '
        '��������������ToolStripMenuItem
        '
        Me.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem"
        Me.��������������ToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.��������������ToolStripMenuItem.Text = "�������� ������"
        '
        '�������������ToolStripMenuItem1
        '
        Me.�������������ToolStripMenuItem1.Name = "�������������ToolStripMenuItem1"
        Me.�������������ToolStripMenuItem1.Size = New System.Drawing.Size(245, 22)
        Me.�������������ToolStripMenuItem1.Text = "������� ������"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Enabled = false
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(302, 328)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.TextBox1, "��� ������ ��������� ����� ��������")
        '
        'txtCustForSearh
        '
        Me.txtCustForSearh.BackColor = System.Drawing.SystemColors.Info
        Me.txtCustForSearh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustForSearh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustForSearh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtCustForSearh.Location = New System.Drawing.Point(203, 323)
        Me.txtCustForSearh.Name = "txtCustForSearh"
        Me.txtCustForSearh.ReadOnly = true
        Me.txtCustForSearh.Size = New System.Drawing.Size(91, 22)
        Me.txtCustForSearh.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtCustForSearh, "��� ������ ��������� ����� ��������")
        '
        'cmbManager
        '
        Me.cmbManager.BackColor = System.Drawing.SystemColors.Control
        Me.tlpFind.SetColumnSpan(Me.cmbManager, 2)
        Me.cmbManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbManager.DropDownWidth = 200
        Me.cmbManager.Enabled = false
        Me.cmbManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbManager.Location = New System.Drawing.Point(203, 89)
        Me.cmbManager.MaxDropDownItems = 20
        Me.cmbManager.MaxLength = 5
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(188, 24)
        Me.cmbManager.TabIndex = 0
        Me.cmbManager.TabStop = false
        Me.ToolTip1.SetToolTip(Me.cmbManager, "�������� ������")
        '
        'cmbDesignerFind
        '
        Me.tlpFind.SetColumnSpan(Me.cmbDesignerFind, 2)
        Me.cmbDesignerFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDesignerFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDesignerFind.DropDownWidth = 200
        Me.cmbDesignerFind.Enabled = false
        Me.cmbDesignerFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDesignerFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbDesignerFind.Location = New System.Drawing.Point(203, 176)
        Me.cmbDesignerFind.MaxDropDownItems = 20
        Me.cmbDesignerFind.MaxLength = 5
        Me.cmbDesignerFind.Name = "cmbDesignerFind"
        Me.cmbDesignerFind.Size = New System.Drawing.Size(188, 24)
        Me.cmbDesignerFind.TabIndex = 66
        Me.cmbDesignerFind.TabStop = false
        Me.ToolTip1.SetToolTip(Me.cmbDesignerFind, "�������� ������")
        '
        'txtFindProd
        '
        Me.txtFindProd.BackColor = System.Drawing.SystemColors.Info
        Me.txtFindProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFindProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFindProd.Location = New System.Drawing.Point(3, 96)
        Me.txtFindProd.MaxLength = 10
        Me.txtFindProd.Name = "txtFindProd"
        Me.txtFindProd.Size = New System.Drawing.Size(181, 24)
        Me.txtFindProd.TabIndex = 2
        Me.txtFindProd.Tag = "777"
        Me.txtFindProd.Text = "�������"
        Me.txtFindProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFindProd, "����� ����������� �� ���������. ����� ����� ������������.")
        Me.txtFindProd.Visible = false
        '
        'cmbCustomer
        '
        Me.cmbCustomer.ContextMenuStrip = Me.cmsKA
        Me.cmbCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustomer.Location = New System.Drawing.Point(190, 65)
        Me.cmbCustomer.MaxDropDownItems = 25
        Me.cmbCustomer.MaxLength = 5
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(1, 25)
        Me.cmbCustomer.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbCustomer, "����������")
        '
        'cmsKA
        '
        Me.cmsKA.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsKA.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsKA.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.�����������������������ToolStripMenuItem, Me.���������������ToolStripMenuItem})
        Me.cmsKA.Name = "cmsKA"
        Me.cmsKA.Size = New System.Drawing.Size(278, 52)
        '
        '�����������������������ToolStripMenuItem
        '
        Me.�����������������������ToolStripMenuItem.Name = "�����������������������ToolStripMenuItem"
        Me.�����������������������ToolStripMenuItem.Size = New System.Drawing.Size(277, 24)
        Me.�����������������������ToolStripMenuItem.Text = "������� ���������� (������)"
        '
        '���������������ToolStripMenuItem
        '
        Me.���������������ToolStripMenuItem.Name = "���������������ToolStripMenuItem"
        Me.���������������ToolStripMenuItem.Size = New System.Drawing.Size(277, 24)
        Me.���������������ToolStripMenuItem.Text = "�������� �������"
        '
        'cmbProd
        '
        Me.cmbProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbProd.FormattingEnabled = true
        Me.cmbProd.Location = New System.Drawing.Point(190, 96)
        Me.cmbProd.MaxDropDownItems = 16
        Me.cmbProd.Name = "cmbProd"
        Me.cmbProd.Size = New System.Drawing.Size(1, 25)
        Me.cmbProd.TabIndex = 3
        Me.cmbProd.Tag = "777"
        Me.ToolTip1.SetToolTip(Me.cmbProd, "������������ ���������")
        Me.cmbProd.Visible = false
        '
        'cmbProdukt
        '
        Me.cmbProdukt.BackColor = System.Drawing.SystemColors.Control
        Me.tlpFind.SetColumnSpan(Me.cmbProdukt, 2)
        Me.cmbProdukt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbProdukt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdukt.DropDownWidth = 300
        Me.cmbProdukt.Enabled = false
        Me.cmbProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbProdukt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbProdukt.FormattingEnabled = true
        Me.cmbProdukt.Location = New System.Drawing.Point(203, 383)
        Me.cmbProdukt.MaxDropDownItems = 22
        Me.cmbProdukt.Name = "cmbProdukt"
        Me.cmbProdukt.Size = New System.Drawing.Size(188, 24)
        Me.cmbProdukt.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.cmbProdukt, "������������ ��������")
        Me.cmbProdukt.Visible = false
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbServices, Me.�����ToolStripMenuItem, Me.�����������ToolStripMenuItem1, Me.�����������ToolStripMenuItem, Me.�������ToolStripMenuItem, Me.�����ToolStripMenuItem, Me.�������ToolStripMenuItem, Me.������������ToolStripMenuItem, Me.���������ToolStripMenuItem, Me.���ToolStripMenuItem, Me.�����ToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 54)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.TabStop = true
        '
        'tscmbServices
        '
        Me.tscmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbServices.DropDownWidth = 500
        Me.tscmbServices.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbServices.MaxDropDownItems = 50
        Me.tscmbServices.Name = "tscmbServices"
        Me.tscmbServices.Size = New System.Drawing.Size(405, 26)
        '
        '�����ToolStripMenuItem
        '
        Me.�����ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.����������ToolStripMenuItem, Me.��������������ToolStripMenuItem1, Me.����������ToolStripMenuItem, Me.��������Excel��������������ToolStripMenuItem, Me.��������ToolStripMenuItem1, Me.�����ToolStripMenuItem})
        Me.�����ToolStripMenuItem.Name = "�����ToolStripMenuItem"
        Me.�����ToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.�����ToolStripMenuItem.Text = "������"
        '
        '����������ToolStripMenuItem
        '
        Me.����������ToolStripMenuItem.Name = "����������ToolStripMenuItem"
        Me.����������ToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.����������ToolStripMenuItem.Text = "����� �����"
        '
        '��������������ToolStripMenuItem1
        '
        Me.��������������ToolStripMenuItem1.Name = "��������������ToolStripMenuItem1"
        Me.��������������ToolStripMenuItem1.Size = New System.Drawing.Size(184, 24)
        Me.��������������ToolStripMenuItem1.Text = "���������"
        '
        '����������ToolStripMenuItem
        '
        Me.����������ToolStripMenuItem.Name = "����������ToolStripMenuItem"
        Me.����������ToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.����������ToolStripMenuItem.Text = "����� �������"
        '
        '��������Excel��������������ToolStripMenuItem
        '
        Me.��������Excel��������������ToolStripMenuItem.Name = "��������Excel��������������ToolStripMenuItem"
        Me.��������Excel��������������ToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.��������Excel��������������ToolStripMenuItem.Text = "������� � Excel"
        '
        '��������ToolStripMenuItem1
        '
        Me.��������ToolStripMenuItem1.Name = "��������ToolStripMenuItem1"
        Me.��������ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.��������ToolStripMenuItem1.Size = New System.Drawing.Size(184, 24)
        Me.��������ToolStripMenuItem1.Text = "��������"
        '
        '�����ToolStripMenuItem
        '
        Me.�����ToolStripMenuItem.Name = "�����ToolStripMenuItem"
        Me.�����ToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.�����ToolStripMenuItem.Text = "�����"
        '
        '�����������ToolStripMenuItem1
        '
        Me.�����������ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.������������ToolStripMenuItem, Me.��������ToolStripMenuItem1, Me.�����������ToolStripMenuItem, Me.����������������ToolStripMenuItem1, Me.�����������ToolStripMenuItem, Me.�������������������ToolStripMenuItem, Me.ToolStripComboBox1})
        Me.�����������ToolStripMenuItem1.Name = "�����������ToolStripMenuItem1"
        Me.�����������ToolStripMenuItem1.Size = New System.Drawing.Size(115, 24)
        Me.�����������ToolStripMenuItem1.Text = "�����������"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.������������ToolStripMenuItem.Text = "���� ������������"
        '
        '��������ToolStripMenuItem1
        '
        Me.��������ToolStripMenuItem1.Name = "��������ToolStripMenuItem1"
        Me.��������ToolStripMenuItem1.Size = New System.Drawing.Size(248, 24)
        Me.��������ToolStripMenuItem1.Text = "�����������"
        '
        '�����������ToolStripMenuItem
        '
        Me.�����������ToolStripMenuItem.Name = "�����������ToolStripMenuItem"
        Me.�����������ToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.�����������ToolStripMenuItem.Text = "����� ������"
        '
        '����������������ToolStripMenuItem1
        '
        Me.����������������ToolStripMenuItem1.Name = "����������������ToolStripMenuItem1"
        Me.����������������ToolStripMenuItem1.Size = New System.Drawing.Size(248, 24)
        Me.����������������ToolStripMenuItem1.Text = "������� ���������"
        '
        '�����������ToolStripMenuItem
        '
        Me.�����������ToolStripMenuItem.Name = "�����������ToolStripMenuItem"
        Me.�����������ToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.�����������ToolStripMenuItem.Text = "�����������"
        Me.�����������ToolStripMenuItem.Visible = false
        '
        '�������������������ToolStripMenuItem
        '
        Me.�������������������ToolStripMenuItem.Name = "�������������������ToolStripMenuItem"
        Me.�������������������ToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.�������������������ToolStripMenuItem.Text = "��������� ����������"
        Me.�������������������ToolStripMenuItem.Visible = false
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ToolStripComboBox1.Visible = false
        '
        '�����������ToolStripMenuItem
        '
        Me.�����������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.������������ToolStripMenuItem, Me.�������������ToolStripMenuItem1, Me.���������������ToolStripMenuItem1, Me.����������������SMSToolStripMenuItem, Me.����������������������ToolStripMenuItem, Me.���������������ToolStripMenuItem, Me.TransDataToolStripMenuItem1, Me.FRDirectoryMenuItem, Me.OfficeDirectoryToolStripMenuItem, Me.������������������������ToolStripMenuItem, Me.����������������������ToolStripMenuItem})
        Me.�����������ToolStripMenuItem.Name = "�����������ToolStripMenuItem"
        Me.�����������ToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.�����������ToolStripMenuItem.Text = "�����������"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.��������������������������ToolStripMenuItem, Me.������������777ToolStripMenuItem, Me.���������������ToolStripMenuItem})
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.������������ToolStripMenuItem.Text = "������������"
        '
        '��������������������������ToolStripMenuItem
        '
        Me.��������������������������ToolStripMenuItem.Name = "��������������������������ToolStripMenuItem"
        Me.��������������������������ToolStripMenuItem.Size = New System.Drawing.Size(300, 24)
        Me.��������������������������ToolStripMenuItem.Text = "��������� ������� ����������"
        '
        '������������777ToolStripMenuItem
        '
        Me.������������777ToolStripMenuItem.Name = "������������777ToolStripMenuItem"
        Me.������������777ToolStripMenuItem.Size = New System.Drawing.Size(300, 24)
        Me.������������777ToolStripMenuItem.Text = "������������ 777"
        '
        '���������������ToolStripMenuItem
        '
        Me.���������������ToolStripMenuItem.Name = "���������������ToolStripMenuItem"
        Me.���������������ToolStripMenuItem.Size = New System.Drawing.Size(300, 24)
        Me.���������������ToolStripMenuItem.Text = "������������ ���"
        '
        '�������������ToolStripMenuItem1
        '
        Me.�������������ToolStripMenuItem1.Name = "�������������ToolStripMenuItem1"
        Me.�������������ToolStripMenuItem1.Size = New System.Drawing.Size(290, 24)
        Me.�������������ToolStripMenuItem1.Text = "������ � ������"
        '
        '���������������ToolStripMenuItem1
        '
        Me.���������������ToolStripMenuItem1.Name = "���������������ToolStripMenuItem1"
        Me.���������������ToolStripMenuItem1.Size = New System.Drawing.Size(290, 24)
        Me.���������������ToolStripMenuItem1.Text = "�������� �������"
        '
        '����������������SMSToolStripMenuItem
        '
        Me.����������������SMSToolStripMenuItem.Name = "����������������SMSToolStripMenuItem"
        Me.����������������SMSToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.����������������SMSToolStripMenuItem.Text = "�������� �������� SMS"
        '
        '����������������������ToolStripMenuItem
        '
        Me.����������������������ToolStripMenuItem.Name = "����������������������ToolStripMenuItem"
        Me.����������������������ToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.����������������������ToolStripMenuItem.Text = "��������� ��� �� ��������"
        '
        '���������������ToolStripMenuItem
        '
        Me.���������������ToolStripMenuItem.Name = "���������������ToolStripMenuItem"
        Me.���������������ToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.���������������ToolStripMenuItem.Text = "������� ��������"
        '
        'TransDataToolStripMenuItem1
        '
        Me.TransDataToolStripMenuItem1.Name = "TransDataToolStripMenuItem1"
        Me.TransDataToolStripMenuItem1.Size = New System.Drawing.Size(290, 24)
        Me.TransDataToolStripMenuItem1.Text = "TransData"
        '
        'FRDirectoryMenuItem
        '
        Me.FRDirectoryMenuItem.Name = "FRDirectoryMenuItem"
        Me.FRDirectoryMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.FRDirectoryMenuItem.Text = "���������� ��"
        '
        'OfficeDirectoryToolStripMenuItem
        '
        Me.OfficeDirectoryToolStripMenuItem.Name = "OfficeDirectoryToolStripMenuItem"
        Me.OfficeDirectoryToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.OfficeDirectoryToolStripMenuItem.Text = "���������� ������"
        '
        '������������������������ToolStripMenuItem
        '
        Me.������������������������ToolStripMenuItem.Name = "������������������������ToolStripMenuItem"
        Me.������������������������ToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.������������������������ToolStripMenuItem.Text = "���������� ������ ��������"
        '
        '����������������������ToolStripMenuItem
        '
        Me.����������������������ToolStripMenuItem.Name = "����������������������ToolStripMenuItem"
        Me.����������������������ToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.����������������������ToolStripMenuItem.Text = "������������ ��� �������"
        '
        '�������ToolStripMenuItem
        '
        Me.�������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.��������ToolStripMenuItem1, Me.���������ToolStripMenuItem, Me.���������ToolStripMenuItem, Me.���������ToolStripMenuItem})
        Me.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem"
        Me.�������ToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.�������ToolStripMenuItem.Text = "�������"
        '
        '��������ToolStripMenuItem1
        '
        Me.��������ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.����������ToolStripMenuItem, Me.����ToolStripMenuItem, Me.������������ToolStripMenuItem, Me.�������ToolStripMenuItem, Me.���������ToolStripMenuItem})
        Me.��������ToolStripMenuItem1.Name = "��������ToolStripMenuItem1"
        Me.��������ToolStripMenuItem1.Size = New System.Drawing.Size(159, 24)
        Me.��������ToolStripMenuItem1.Text = "��������"
        '
        '����������ToolStripMenuItem
        '
        Me.����������ToolStripMenuItem.Name = "����������ToolStripMenuItem"
        Me.����������ToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.����������ToolStripMenuItem.Text = "����������"
        '
        '����ToolStripMenuItem
        '
        Me.����ToolStripMenuItem.Name = "����ToolStripMenuItem"
        Me.����ToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.����ToolStripMenuItem.Text = "����"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.������������ToolStripMenuItem.Text = "������������"
        '
        '�������ToolStripMenuItem
        '
        Me.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem"
        Me.�������ToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.�������ToolStripMenuItem.Text = "�������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.���������ToolStripMenuItem.Text = "���������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.����������ToolStripMenuItem, Me.��������������������ToolStripMenuItem})
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.���������ToolStripMenuItem.Text = "���������"
        '
        '����������ToolStripMenuItem
        '
        Me.����������ToolStripMenuItem.Name = "����������ToolStripMenuItem"
        Me.����������ToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.����������ToolStripMenuItem.Text = "���������� �������"
        '
        '��������������������ToolStripMenuItem
        '
        Me.��������������������ToolStripMenuItem.Name = "��������������������ToolStripMenuItem"
        Me.��������������������ToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.��������������������ToolStripMenuItem.Text = "��������� �����������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.�������������������ToolStripMenuItem, Me.�����������������ToolStripMenuItem})
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.���������ToolStripMenuItem.Text = "���������"
        '
        '�������������������ToolStripMenuItem
        '
        Me.�������������������ToolStripMenuItem.Name = "�������������������ToolStripMenuItem"
        Me.�������������������ToolStripMenuItem.Size = New System.Drawing.Size(245, 24)
        Me.�������������������ToolStripMenuItem.Text = "��������� ����������"
        Me.�������������������ToolStripMenuItem.Visible = false
        '
        '�����������������ToolStripMenuItem
        '
        Me.�����������������ToolStripMenuItem.Name = "�����������������ToolStripMenuItem"
        Me.�����������������ToolStripMenuItem.Size = New System.Drawing.Size(245, 24)
        Me.�����������������ToolStripMenuItem.Text = "������� ����������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.�����������ToolStripMenuItem1, Me.���������ToolStripMenuItem, Me.���������ToolStripMenuItem, Me.��������������ToolStripMenuItem})
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.���������ToolStripMenuItem.Text = "���������"
        '
        '�����������ToolStripMenuItem1
        '
        Me.�����������ToolStripMenuItem1.Name = "�����������ToolStripMenuItem1"
        Me.�����������ToolStripMenuItem1.Size = New System.Drawing.Size(209, 24)
        Me.�����������ToolStripMenuItem1.Text = "�����������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.���������ToolStripMenuItem.Text = "���������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.���������ToolStripMenuItem.Text = "������� ��"
        '
        '��������������ToolStripMenuItem
        '
        Me.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem"
        Me.��������������ToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.��������������ToolStripMenuItem.Text = "����������� � ��"
        '
        '�����ToolStripMenuItem
        '
        Me.�����ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.������������ToolStripMenuItem, Me.������������ToolStripMenuItem, Me.��������������ToolStripMenuItem, Me.��������ToolStripMenuItem, Me.��������������ToolStripMenuItem})
        Me.�����ToolStripMenuItem.Name = "�����ToolStripMenuItem"
        Me.�����ToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.�����ToolStripMenuItem.Text = "��������"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.������������ToolStripMenuItem.Text = "������� �� �����"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.������������ToolStripMenuItem.Text = "������ �� ������"
        '
        '��������������ToolStripMenuItem
        '
        Me.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem"
        Me.��������������ToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.��������������ToolStripMenuItem.Text = "��������������"
        '
        '��������ToolStripMenuItem
        '
        Me.��������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.�����������ToolStripMenuItem, Me.���������������ToolStripMenuItem1, Me.������������ToolStripMenuItem, Me.�����������������ToolStripMenuItem})
        Me.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem"
        Me.��������ToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.��������ToolStripMenuItem.Text = "�����������"
        '
        '�����������ToolStripMenuItem
        '
        Me.�����������ToolStripMenuItem.Name = "�����������ToolStripMenuItem"
        Me.�����������ToolStripMenuItem.Size = New System.Drawing.Size(233, 24)
        Me.�����������ToolStripMenuItem.Text = "������������"
        '
        '���������������ToolStripMenuItem1
        '
        Me.���������������ToolStripMenuItem1.Name = "���������������ToolStripMenuItem1"
        Me.���������������ToolStripMenuItem1.Size = New System.Drawing.Size(233, 24)
        Me.���������������ToolStripMenuItem1.Text = "�������� �������"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(233, 24)
        Me.������������ToolStripMenuItem.Text = "������� �����"
        '
        '�����������������ToolStripMenuItem
        '
        Me.�����������������ToolStripMenuItem.Name = "�����������������ToolStripMenuItem"
        Me.�����������������ToolStripMenuItem.Size = New System.Drawing.Size(233, 24)
        Me.�����������������ToolStripMenuItem.Text = "��������� ��������"
        '
        '��������������ToolStripMenuItem
        '
        Me.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem"
        Me.��������������ToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.��������������ToolStripMenuItem.Text = "������ ��������"
        '
        '�������ToolStripMenuItem
        '
        Me.�������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.������ToolStripMenuItem1, Me.��������������ToolStripMenuItem, Me.���������ToolStripMenuItem, Me.���ToolStripMenuItem, Me.�����������������ToolStripMenuItem, Me.���������ToolStripMenuItem1})
        Me.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem"
        Me.�������ToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.�������ToolStripMenuItem.Text = "�������"
        '
        '������ToolStripMenuItem1
        '
        Me.������ToolStripMenuItem1.Name = "������ToolStripMenuItem1"
        Me.������ToolStripMenuItem1.Size = New System.Drawing.Size(224, 24)
        Me.������ToolStripMenuItem1.Text = "������"
        '
        '��������������ToolStripMenuItem
        '
        Me.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem"
        Me.��������������ToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.��������������ToolStripMenuItem.Text = "�������� ������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.����������������ToolStripMenuItem, Me.������������ToolStripMenuItem1, Me.�������������������ToolStripMenuItem})
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.���������ToolStripMenuItem.Text = "�������"
        '
        '����������������ToolStripMenuItem
        '
        Me.����������������ToolStripMenuItem.Name = "����������������ToolStripMenuItem"
        Me.����������������ToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.����������������ToolStripMenuItem.Text = "���������� ������"
        '
        '������������ToolStripMenuItem1
        '
        Me.������������ToolStripMenuItem1.Name = "������������ToolStripMenuItem1"
        Me.������������ToolStripMenuItem1.Size = New System.Drawing.Size(232, 24)
        Me.������������ToolStripMenuItem1.Text = "������ ������"
        '
        '�������������������ToolStripMenuItem
        '
        Me.�������������������ToolStripMenuItem.Name = "�������������������ToolStripMenuItem"
        Me.�������������������ToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.�������������������ToolStripMenuItem.Text = "������������� ������"
        '
        '���ToolStripMenuItem
        '
        Me.���ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.�����������������ToolStripMenuItem, Me.������������������ToolStripMenuItem1, Me.�������������ToolStripMenuItem, Me.���������ToolStripMenuItem, Me.�������ToolStripMenuItem, Me.������������������ToolStripMenuItem})
        Me.���ToolStripMenuItem.Name = "���ToolStripMenuItem"
        Me.���ToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.���ToolStripMenuItem.Text = "���"
        '
        '�����������������ToolStripMenuItem
        '
        Me.�����������������ToolStripMenuItem.Name = "�����������������ToolStripMenuItem"
        Me.�����������������ToolStripMenuItem.Size = New System.Drawing.Size(292, 24)
        Me.�����������������ToolStripMenuItem.Text = "���� � ����������� ���������"
        '
        '������������������ToolStripMenuItem1
        '
        Me.������������������ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.����������������������ToolStripMenuItem, Me.����������������������ToolStripMenuItem})
        Me.������������������ToolStripMenuItem1.Name = "������������������ToolStripMenuItem1"
        Me.������������������ToolStripMenuItem1.Size = New System.Drawing.Size(292, 24)
        Me.������������������ToolStripMenuItem1.Text = "������� �����������"
        '
        '����������������������ToolStripMenuItem
        '
        Me.����������������������ToolStripMenuItem.Name = "����������������������ToolStripMenuItem"
        Me.����������������������ToolStripMenuItem.Size = New System.Drawing.Size(266, 24)
        Me.����������������������ToolStripMenuItem.Text = "�������� ��������������"
        '
        '����������������������ToolStripMenuItem
        '
        Me.����������������������ToolStripMenuItem.Name = "����������������������ToolStripMenuItem"
        Me.����������������������ToolStripMenuItem.Size = New System.Drawing.Size(266, 24)
        Me.����������������������ToolStripMenuItem.Text = "�������� ��������������"
        '
        '�������������ToolStripMenuItem
        '
        Me.�������������ToolStripMenuItem.Name = "�������������ToolStripMenuItem"
        Me.�������������ToolStripMenuItem.Size = New System.Drawing.Size(292, 24)
        Me.�������������ToolStripMenuItem.Text = "������ � ������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(292, 24)
        Me.���������ToolStripMenuItem.Text = "���������"
        '
        '�������ToolStripMenuItem
        '
        Me.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem"
        Me.�������ToolStripMenuItem.Size = New System.Drawing.Size(292, 24)
        Me.�������ToolStripMenuItem.Text = "��� ������� �� ��������"
        '
        '������������������ToolStripMenuItem
        '
        Me.������������������ToolStripMenuItem.Name = "������������������ToolStripMenuItem"
        Me.������������������ToolStripMenuItem.Size = New System.Drawing.Size(292, 24)
        Me.������������������ToolStripMenuItem.Text = "������� ������ �����"
        '
        '�����������������ToolStripMenuItem
        '
        Me.�����������������ToolStripMenuItem.Name = "�����������������ToolStripMenuItem"
        Me.�����������������ToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.�����������������ToolStripMenuItem.Text = "���������� �������"
        '
        '���������ToolStripMenuItem1
        '
        Me.���������ToolStripMenuItem1.Name = "���������ToolStripMenuItem1"
        Me.���������ToolStripMenuItem1.Size = New System.Drawing.Size(224, 24)
        Me.���������ToolStripMenuItem1.Text = "���������"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.��ToolStripMenuItem, Me.������������ToolStripMenuItem, Me.����������ToolStripMenuItem})
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.������������ToolStripMenuItem.Text = "������������"
        '
        '��ToolStripMenuItem
        '
        Me.��ToolStripMenuItem.Name = "��ToolStripMenuItem"
        Me.��ToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.��ToolStripMenuItem.Text = "��"
        Me.��ToolStripMenuItem.Visible = false
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GanterToolStripMenuItem, Me.�����������ToolStripMenuItem})
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.������������ToolStripMenuItem.Text = "������������"
        '
        'GanterToolStripMenuItem
        '
        Me.GanterToolStripMenuItem.Name = "GanterToolStripMenuItem"
        Me.GanterToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.GanterToolStripMenuItem.Text = "Ganter"
        '
        '�����������ToolStripMenuItem
        '
        Me.�����������ToolStripMenuItem.Name = "�����������ToolStripMenuItem"
        Me.�����������ToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.�����������ToolStripMenuItem.Text = "����� ������"
        '
        '����������ToolStripMenuItem
        '
        Me.����������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.������������ToolStripMenuItem, Me.��������ToolStripMenuItem, Me.������������ToolStripMenuItem1})
        Me.����������ToolStripMenuItem.Name = "����������ToolStripMenuItem"
        Me.����������ToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.����������ToolStripMenuItem.Text = "����������"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.������������ToolStripMenuItem.Text = "������������"
        '
        '��������ToolStripMenuItem
        '
        Me.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem"
        Me.��������ToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.��������ToolStripMenuItem.Text = "��������"
        '
        '������������ToolStripMenuItem1
        '
        Me.������������ToolStripMenuItem1.Name = "������������ToolStripMenuItem1"
        Me.������������ToolStripMenuItem1.Size = New System.Drawing.Size(257, 24)
        Me.������������ToolStripMenuItem1.Text = "������������-��������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.���������ToolStripMenuItem, Me.�������������������ToolStripMenuItem, Me.�����������������������ToolStripMenuItem})
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.���������ToolStripMenuItem.Text = "���������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(267, 24)
        Me.���������ToolStripMenuItem.Text = "��"
        '
        '�������������������ToolStripMenuItem
        '
        Me.�������������������ToolStripMenuItem.Name = "�������������������ToolStripMenuItem"
        Me.�������������������ToolStripMenuItem.Size = New System.Drawing.Size(267, 24)
        Me.�������������������ToolStripMenuItem.Text = "���� ���������������"
        '
        '�����������������������ToolStripMenuItem
        '
        Me.�����������������������ToolStripMenuItem.Name = "�����������������������ToolStripMenuItem"
        Me.�����������������������ToolStripMenuItem.Size = New System.Drawing.Size(267, 24)
        Me.�����������������������ToolStripMenuItem.Text = "������� ������ �� ��������"
        '
        '���ToolStripMenuItem
        '
        Me.���ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.������������ToolStripMenuItem1, Me.FRSetupToolStripMenuItem})
        Me.���ToolStripMenuItem.Name = "���ToolStripMenuItem"
        Me.���ToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.���ToolStripMenuItem.Text = "���"
        '
        '������������ToolStripMenuItem1
        '
        Me.������������ToolStripMenuItem1.Name = "������������ToolStripMenuItem1"
        Me.������������ToolStripMenuItem1.Size = New System.Drawing.Size(185, 24)
        Me.������������ToolStripMenuItem1.Text = "���� � �������"
        '
        'FRSetupToolStripMenuItem
        '
        Me.FRSetupToolStripMenuItem.Name = "FRSetupToolStripMenuItem"
        Me.FRSetupToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.FRSetupToolStripMenuItem.Text = "��������� ��"
        '
        '�����ToolStripMenuItem1
        '
        Me.�����ToolStripMenuItem1.Name = "�����ToolStripMenuItem1"
        Me.�����ToolStripMenuItem1.Size = New System.Drawing.Size(65, 24)
        Me.�����ToolStripMenuItem1.Text = "�����"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslTotalCost, Me.tsslDolgItog, Me.ToolStripStatusLabel2, Me.tsslAWC})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 796)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslTotalCost
        '
        Me.tsslTotalCost.Name = "tsslTotalCost"
        Me.tsslTotalCost.Size = New System.Drawing.Size(65, 19)
        Me.tsslTotalCost.Text = "totalCost"
        Me.tsslTotalCost.Visible = false
        '
        'tsslDolgItog
        '
        Me.tsslDolgItog.Name = "tsslDolgItog"
        Me.tsslDolgItog.Size = New System.Drawing.Size(36, 19)
        Me.tsslDolgItog.Text = "dolg"
        Me.tsslDolgItog.Visible = false
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(18, 19)
        Me.ToolStripStatusLabel2.Text = "..."
        '
        'tsslAWC
        '
        Me.tsslAWC.Name = "tsslAWC"
        Me.tsslAWC.Size = New System.Drawing.Size(18, 19)
        Me.tsslAWC.Text = "..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AllowDrop = true
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 54)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkContextSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgTableData)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1276, 742)
        Me.SplitContainer1.SplitterDistance = 697
        Me.SplitContainer1.TabIndex = 8
        Me.SplitContainer1.TabStop = false
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.rightTableLayoutPanel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1274, 695)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'rightTableLayoutPanel
        '
        Me.rightTableLayoutPanel.ColumnCount = 1
        Me.rightTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.rightTableLayoutPanel.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.rightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightTableLayoutPanel.Location = New System.Drawing.Point(1086, 3)
        Me.rightTableLayoutPanel.Name = "rightTableLayoutPanel"
        Me.rightTableLayoutPanel.RowCount = 1
        Me.rightTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.rightTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 689!))
        Me.rightTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 689!))
        Me.rightTableLayoutPanel.Size = New System.Drawing.Size(185, 689)
        Me.rightTableLayoutPanel.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNewOrder, Me.tsbtnFindOrder, Me.tsbtnFastOrder, Me.ToolStripSeparator1, Me.tsbtnKassa, Me.tsbtnDocuments, Me.tsbtnRegInvoice, Me.ToolStripSeparator4, Me.tsbtnTasks, Me.ToolStripSeparator2, Me.ShowMoneyInCassaButton, Me.tsbtnKassa2, Me.ToolStripSeparator8, Me.OperatorsPerformanceReportButton, Me.ManagersPerformanceReportButton, Me.tsbtnClaimAndOffers})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(185, 689)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnNewOrder
        '
        Me.tsbtnNewOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewOrder.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnNewOrder.Image = CType(resources.GetObject("tsbtnNewOrder.Image"),System.Drawing.Image)
        Me.tsbtnNewOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewOrder.Name = "tsbtnNewOrder"
        Me.tsbtnNewOrder.Size = New System.Drawing.Size(183, 24)
        Me.tsbtnNewOrder.Text = "����� �����"
        '
        'tsbtnFindOrder
        '
        Me.tsbtnFindOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFindOrder.Enabled = false
        Me.tsbtnFindOrder.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnFindOrder.Image = CType(resources.GetObject("tsbtnFindOrder.Image"),System.Drawing.Image)
        Me.tsbtnFindOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFindOrder.Name = "tsbtnFindOrder"
        Me.tsbtnFindOrder.Size = New System.Drawing.Size(183, 24)
        Me.tsbtnFindOrder.Text = "����� �������"
        '
        'tsbtnFastOrder
        '
        Me.tsbtnFastOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFastOrder.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnFastOrder.Image = CType(resources.GetObject("tsbtnFastOrder.Image"),System.Drawing.Image)
        Me.tsbtnFastOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFastOrder.Name = "tsbtnFastOrder"
        Me.tsbtnFastOrder.Size = New System.Drawing.Size(183, 24)
        Me.tsbtnFastOrder.Text = "������� �����"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'tsbtnKassa
        '
        Me.tsbtnKassa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnKassa.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnKassa.Image = CType(resources.GetObject("tsbtnKassa.Image"),System.Drawing.Image)
        Me.tsbtnKassa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnKassa.Name = "tsbtnKassa"
        Me.tsbtnKassa.Size = New System.Drawing.Size(183, 24)
        Me.tsbtnKassa.Text = "�����"
        '
        'tsbtnDocuments
        '
        Me.tsbtnDocuments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDocuments.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnDocuments.Image = CType(resources.GetObject("tsbtnDocuments.Image"),System.Drawing.Image)
        Me.tsbtnDocuments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDocuments.Name = "tsbtnDocuments"
        Me.tsbtnDocuments.Size = New System.Drawing.Size(183, 24)
        Me.tsbtnDocuments.Text = "���������"
        '
        'tsbtnRegInvoice
        '
        Me.tsbtnRegInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnRegInvoice.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnRegInvoice.Image = CType(resources.GetObject("tsbtnRegInvoice.Image"),System.Drawing.Image)
        Me.tsbtnRegInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnRegInvoice.Name = "tsbtnRegInvoice"
        Me.tsbtnRegInvoice.Size = New System.Drawing.Size(183, 24)
        Me.tsbtnRegInvoice.Text = "�������������� ����"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(183, 6)
        '
        'tsbtnTasks
        '
        Me.tsbtnTasks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnTasks.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnTasks.Image = CType(resources.GetObject("tsbtnTasks.Image"),System.Drawing.Image)
        Me.tsbtnTasks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnTasks.Name = "tsbtnTasks"
        Me.tsbtnTasks.Size = New System.Drawing.Size(183, 24)
        Me.tsbtnTasks.Text = "������"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'ShowMoneyInCassaButton
        '
        Me.ShowMoneyInCassaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowMoneyInCassaButton.Image = CType(resources.GetObject("ShowMoneyInCassaButton.Image"),System.Drawing.Image)
        Me.ShowMoneyInCassaButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowMoneyInCassaButton.Name = "ShowMoneyInCassaButton"
        Me.ShowMoneyInCassaButton.Size = New System.Drawing.Size(183, 24)
        Me.ShowMoneyInCassaButton.Text = "������ � �����"
        '
        'tsbtnKassa2
        '
        Me.tsbtnKassa2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnKassa2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnKassa2.Image = CType(resources.GetObject("tsbtnKassa2.Image"),System.Drawing.Image)
        Me.tsbtnKassa2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnKassa2.Name = "tsbtnKassa2"
        Me.tsbtnKassa2.Size = New System.Drawing.Size(183, 24)
        Me.tsbtnKassa2.Text = "������ � ��"
        Me.tsbtnKassa2.Visible = false
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(183, 6)
        '
        'OperatorsPerformanceReportButton
        '
        Me.OperatorsPerformanceReportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OperatorsPerformanceReportButton.Image = CType(resources.GetObject("OperatorsPerformanceReportButton.Image"),System.Drawing.Image)
        Me.OperatorsPerformanceReportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OperatorsPerformanceReportButton.Name = "OperatorsPerformanceReportButton"
        Me.OperatorsPerformanceReportButton.Size = New System.Drawing.Size(183, 24)
        Me.OperatorsPerformanceReportButton.Text = "���������. ����������"
        Me.OperatorsPerformanceReportButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsbtnClaimAndOffers
        '
        Me.tsbtnClaimAndOffers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnClaimAndOffers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnClaimAndOffers.ForeColor = System.Drawing.Color.Brown
        Me.tsbtnClaimAndOffers.Image = CType(resources.GetObject("tsbtnClaimAndOffers.Image"),System.Drawing.Image)
        Me.tsbtnClaimAndOffers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnClaimAndOffers.Name = "tsbtnClaimAndOffers"
        Me.tsbtnClaimAndOffers.Size = New System.Drawing.Size(183, 21)
        Me.tsbtnClaimAndOffers.Text = "������ � �����������"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.AllowDrop = true
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = true
        Me.SplitContainer2.Panel1.Controls.Add(Me.scCommonFindNew)
        Me.SplitContainer2.Panel1MinSize = 0
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.tlpProdMan)
        Me.SplitContainer2.Panel2MinSize = 0
        Me.SplitContainer2.Size = New System.Drawing.Size(1077, 689)
        Me.SplitContainer2.SplitterDistance = 582
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = false
        '
        'scCommonFindNew
        '
        Me.scCommonFindNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scCommonFindNew.Location = New System.Drawing.Point(0, 0)
        Me.scCommonFindNew.Name = "scCommonFindNew"
        '
        'scCommonFindNew.Panel1
        '
        Me.scCommonFindNew.Panel1.AutoScroll = true
        Me.scCommonFindNew.Panel1.Controls.Add(Me.tlpFind)
        '
        'scCommonFindNew.Panel2
        '
        Me.scCommonFindNew.Panel2.Controls.Add(Me.tlpNewOrder)
        Me.scCommonFindNew.Size = New System.Drawing.Size(580, 687)
        Me.scCommonFindNew.SplitterDistance = 394
        Me.scCommonFindNew.TabIndex = 0
        '
        'tlpFind
        '
        Me.tlpFind.AutoSize = true
        Me.tlpFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpFind.BackColor = System.Drawing.SystemColors.Window
        Me.tlpFind.ColumnCount = 3
        Me.tlpFind.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200!))
        Me.tlpFind.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpFind.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpFind.Controls.Add(Me.cmbCostActivity, 0, 17)
        Me.tlpFind.Controls.Add(Me.dtpOrderClosed2, 2, 13)
        Me.tlpFind.Controls.Add(Me.dtpOrderClosed1, 1, 13)
        Me.tlpFind.Controls.Add(Me.cmbPerson, 2, 10)
        Me.tlpFind.Controls.Add(Me.cmbProdukt, 1, 11)
        Me.tlpFind.Controls.Add(Me.cmbCustForSearh, 2, 9)
        Me.tlpFind.Controls.Add(Me.cmbPredoplata, 1, 12)
        Me.tlpFind.Controls.Add(Me.txtCustForSearh, 1, 9)
        Me.tlpFind.Controls.Add(Me.cmbManager, 1, 3)
        Me.tlpFind.Controls.Add(Me.chkProdukt, 0, 11)
        Me.tlpFind.Controls.Add(Me.chkCustForSearh, 0, 9)
        Me.tlpFind.Controls.Add(Me.chkPerson, 0, 10)
        Me.tlpFind.Controls.Add(Me.chkOrderClosed, 0, 13)
        Me.tlpFind.Controls.Add(Me.cmbDesignerFind, 1, 6)
        Me.tlpFind.Controls.Add(Me.dtpMaket, 2, 5)
        Me.tlpFind.Controls.Add(Me.chkDataPeriod, 0, 0)
        Me.tlpFind.Controls.Add(Me.dtpDataVydahi, 2, 2)
        Me.tlpFind.Controls.Add(Me.chkMaketOut, 0, 5)
        Me.tlpFind.Controls.Add(Me.dtpOrder2, 2, 0)
        Me.tlpFind.Controls.Add(Me.txtFind, 1, 1)
        Me.tlpFind.Controls.Add(Me.chkMan, 0, 3)
        Me.tlpFind.Controls.Add(Me.dtpOrder1, 1, 0)
        Me.tlpFind.Controls.Add(Me.chkFindNomer, 0, 1)
        Me.tlpFind.Controls.Add(Me.chkDataOut, 0, 2)
        Me.tlpFind.Controls.Add(Me.chkDesignerFind, 0, 6)
        Me.tlpFind.Controls.Add(Me.chkPredoplata, 0, 12)
        Me.tlpFind.Controls.Add(Me.clbCondition, 1, 8)
        Me.tlpFind.Controls.Add(Me.chkStatus, 0, 8)
        Me.tlpFind.Controls.Add(Me.chkReclama, 0, 14)
        Me.tlpFind.Controls.Add(Me.cmbReclama, 1, 14)
        Me.tlpFind.Controls.Add(Me.chkOrg, 0, 15)
        Me.tlpFind.Controls.Add(Me.cmbOrg, 1, 15)
        Me.tlpFind.Controls.Add(Me.cmbSelectRel, 1, 10)
        Me.tlpFind.Controls.Add(Me.cmbDataVydahi, 1, 2)
        Me.tlpFind.Controls.Add(Me.cmbMaket, 1, 5)
        Me.tlpFind.Controls.Add(Me.chkShowDismissedManagers, 1, 4)
        Me.tlpFind.Controls.Add(Me.chkShowDismissedExecutors, 1, 7)
        Me.tlpFind.Controls.Add(Me.chkCostType, 0, 16)
        Me.tlpFind.Controls.Add(Me.clbCostType, 1, 16)
        Me.tlpFind.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpFind.Location = New System.Drawing.Point(0, 0)
        Me.tlpFind.Name = "tlpFind"
        Me.tlpFind.RowCount = 18
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFind.Size = New System.Drawing.Size(394, 626)
        Me.tlpFind.TabIndex = 25
        '
        'cmbCostActivity
        '
        Me.cmbCostActivity.BackColor = System.Drawing.SystemColors.Control
        Me.tlpFind.SetColumnSpan(Me.cmbCostActivity, 3)
        Me.cmbCostActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCostActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCostActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCostActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCostActivity.FormattingEnabled = true
        Me.cmbCostActivity.IntegralHeight = false
        Me.cmbCostActivity.Items.AddRange(New Object() {"����������� ������", "�������������� ������", "����������� � ��������������"})
        Me.cmbCostActivity.Location = New System.Drawing.Point(3, 599)
        Me.cmbCostActivity.Name = "cmbCostActivity"
        Me.cmbCostActivity.Size = New System.Drawing.Size(388, 24)
        Me.cmbCostActivity.TabIndex = 99
        '
        'dtpOrderClosed2
        '
        Me.dtpOrderClosed2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpOrderClosed2.Enabled = false
        Me.dtpOrderClosed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpOrderClosed2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderClosed2.Location = New System.Drawing.Point(300, 443)
        Me.dtpOrderClosed2.Name = "dtpOrderClosed2"
        Me.dtpOrderClosed2.Size = New System.Drawing.Size(91, 22)
        Me.dtpOrderClosed2.TabIndex = 82
        Me.dtpOrderClosed2.Visible = false
        '
        'dtpOrderClosed1
        '
        Me.dtpOrderClosed1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpOrderClosed1.Enabled = false
        Me.dtpOrderClosed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.dtpOrderClosed1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderClosed1.Location = New System.Drawing.Point(203, 443)
        Me.dtpOrderClosed1.Name = "dtpOrderClosed1"
        Me.dtpOrderClosed1.Size = New System.Drawing.Size(91, 22)
        Me.dtpOrderClosed1.TabIndex = 81
        Me.dtpOrderClosed1.Visible = false
        '
        'cmbPerson
        '
        Me.cmbPerson.BackColor = System.Drawing.SystemColors.Control
        Me.cmbPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPerson.DropDownWidth = 300
        Me.cmbPerson.Enabled = false
        Me.cmbPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPerson.FormattingEnabled = true
        Me.cmbPerson.Location = New System.Drawing.Point(300, 353)
        Me.cmbPerson.MaxDropDownItems = 24
        Me.cmbPerson.Name = "cmbPerson"
        Me.cmbPerson.Size = New System.Drawing.Size(91, 24)
        Me.cmbPerson.TabIndex = 79
        '
        'cmbCustForSearh
        '
        Me.cmbCustForSearh.BackColor = System.Drawing.SystemColors.Control
        Me.cmbCustForSearh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCustForSearh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustForSearh.DropDownWidth = 300
        Me.cmbCustForSearh.Enabled = false
        Me.cmbCustForSearh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustForSearh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbCustForSearh.FormattingEnabled = true
        Me.cmbCustForSearh.Location = New System.Drawing.Point(300, 323)
        Me.cmbCustForSearh.MaxDropDownItems = 24
        Me.cmbCustForSearh.Name = "cmbCustForSearh"
        Me.cmbCustForSearh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCustForSearh.Size = New System.Drawing.Size(91, 24)
        Me.cmbCustForSearh.TabIndex = 1
        '
        'cmbPredoplata
        '
        Me.cmbPredoplata.BackColor = System.Drawing.SystemColors.Control
        Me.tlpFind.SetColumnSpan(Me.cmbPredoplata, 2)
        Me.cmbPredoplata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPredoplata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPredoplata.Enabled = false
        Me.cmbPredoplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPredoplata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbPredoplata.FormattingEnabled = true
        Me.cmbPredoplata.IntegralHeight = false
        Me.cmbPredoplata.Items.AddRange(New Object() {"��� ������", "�������� � ���������", "������ ��������", "������ ������"})
        Me.cmbPredoplata.Location = New System.Drawing.Point(203, 413)
        Me.cmbPredoplata.Name = "cmbPredoplata"
        Me.cmbPredoplata.Size = New System.Drawing.Size(188, 24)
        Me.cmbPredoplata.TabIndex = 77
        Me.cmbPredoplata.Visible = false
        '
        'chkProdukt
        '
        Me.chkProdukt.AutoSize = true
        Me.chkProdukt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkProdukt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkProdukt.Location = New System.Drawing.Point(3, 383)
        Me.chkProdukt.Name = "chkProdukt"
        Me.chkProdukt.Size = New System.Drawing.Size(194, 24)
        Me.chkProdukt.TabIndex = 75
        Me.chkProdukt.Text = "�������"
        Me.chkProdukt.UseVisualStyleBackColor = true
        Me.chkProdukt.Visible = false
        '
        'chkCustForSearh
        '
        Me.chkCustForSearh.AutoSize = true
        Me.chkCustForSearh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCustForSearh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCustForSearh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkCustForSearh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkCustForSearh.Location = New System.Drawing.Point(3, 323)
        Me.chkCustForSearh.Name = "chkCustForSearh"
        Me.chkCustForSearh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCustForSearh.Size = New System.Drawing.Size(194, 24)
        Me.chkCustForSearh.TabIndex = 73
        Me.chkCustForSearh.TabStop = false
        Me.chkCustForSearh.Text = "��������"
        '
        'chkPerson
        '
        Me.chkPerson.AutoSize = true
        Me.chkPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkPerson.Enabled = false
        Me.chkPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPerson.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkPerson.Location = New System.Drawing.Point(3, 353)
        Me.chkPerson.Name = "chkPerson"
        Me.chkPerson.Size = New System.Drawing.Size(194, 24)
        Me.chkPerson.TabIndex = 78
        Me.chkPerson.Text = "�����"
        Me.chkPerson.UseVisualStyleBackColor = true
        '
        'chkOrderClosed
        '
        Me.chkOrderClosed.AutoSize = true
        Me.chkOrderClosed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkOrderClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOrderClosed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkOrderClosed.Location = New System.Drawing.Point(3, 443)
        Me.chkOrderClosed.Name = "chkOrderClosed"
        Me.chkOrderClosed.Size = New System.Drawing.Size(194, 22)
        Me.chkOrderClosed.TabIndex = 80
        Me.chkOrderClosed.Text = "����� ������"
        Me.chkOrderClosed.UseVisualStyleBackColor = true
        Me.chkOrderClosed.Visible = false
        '
        'dtpMaket
        '
        Me.dtpMaket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpMaket.Enabled = false
        Me.dtpMaket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpMaket.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMaket.Location = New System.Drawing.Point(300, 146)
        Me.dtpMaket.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.dtpMaket.Name = "dtpMaket"
        Me.dtpMaket.Size = New System.Drawing.Size(91, 22)
        Me.dtpMaket.TabIndex = 63
        Me.dtpMaket.TabStop = false
        Me.dtpMaket.Value = New Date(2007, 1, 16, 0, 0, 0, 0)
        '
        'chkDataPeriod
        '
        Me.chkDataPeriod.AutoSize = true
        Me.chkDataPeriod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDataPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDataPeriod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkDataPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkDataPeriod.Location = New System.Drawing.Point(3, 3)
        Me.chkDataPeriod.Name = "chkDataPeriod"
        Me.chkDataPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDataPeriod.Size = New System.Drawing.Size(194, 22)
        Me.chkDataPeriod.TabIndex = 57
        Me.chkDataPeriod.TabStop = false
        Me.chkDataPeriod.Text = "�������� ���� ������"
        '
        'dtpDataVydahi
        '
        Me.dtpDataVydahi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDataVydahi.Enabled = false
        Me.dtpDataVydahi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpDataVydahi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataVydahi.Location = New System.Drawing.Point(300, 59)
        Me.dtpDataVydahi.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.dtpDataVydahi.Name = "dtpDataVydahi"
        Me.dtpDataVydahi.Size = New System.Drawing.Size(91, 22)
        Me.dtpDataVydahi.TabIndex = 58
        Me.dtpDataVydahi.TabStop = false
        Me.dtpDataVydahi.Value = New Date(2007, 1, 16, 0, 0, 0, 0)
        '
        'chkMaketOut
        '
        Me.chkMaketOut.AutoSize = true
        Me.chkMaketOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkMaketOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMaketOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkMaketOut.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkMaketOut.Location = New System.Drawing.Point(3, 146)
        Me.chkMaketOut.Name = "chkMaketOut"
        Me.chkMaketOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMaketOut.Size = New System.Drawing.Size(194, 24)
        Me.chkMaketOut.TabIndex = 64
        Me.chkMaketOut.TabStop = false
        Me.chkMaketOut.Text = "����������� ������"
        '
        'dtpOrder2
        '
        Me.dtpOrder2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpOrder2.Enabled = false
        Me.dtpOrder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpOrder2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrder2.Location = New System.Drawing.Point(300, 3)
        Me.dtpOrder2.MinDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.dtpOrder2.Name = "dtpOrder2"
        Me.dtpOrder2.Size = New System.Drawing.Size(91, 22)
        Me.dtpOrder2.TabIndex = 4
        Me.dtpOrder2.TabStop = false
        Me.dtpOrder2.Value = New Date(2007, 1, 16, 0, 0, 0, 0)
        '
        'txtFind
        '
        Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpFind.SetColumnSpan(Me.txtFind, 2)
        Me.txtFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtFind.Location = New System.Drawing.Point(203, 31)
        Me.txtFind.MaxLength = 12
        Me.txtFind.Name = "txtFind"
        Me.txtFind.ReadOnly = true
        Me.txtFind.Size = New System.Drawing.Size(188, 22)
        Me.txtFind.TabIndex = 5
        Me.txtFind.TabStop = false
        '
        'chkMan
        '
        Me.chkMan.AutoSize = true
        Me.chkMan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkMan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkMan.Location = New System.Drawing.Point(3, 89)
        Me.chkMan.Name = "chkMan"
        Me.chkMan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMan.Size = New System.Drawing.Size(194, 24)
        Me.chkMan.TabIndex = 8
        Me.chkMan.TabStop = false
        Me.chkMan.Text = "�������� ������"
        '
        'dtpOrder1
        '
        Me.dtpOrder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpOrder1.Enabled = false
        Me.dtpOrder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dtpOrder1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrder1.Location = New System.Drawing.Point(203, 3)
        Me.dtpOrder1.MinDate = New Date(2004, 1, 7, 0, 0, 0, 0)
        Me.dtpOrder1.Name = "dtpOrder1"
        Me.dtpOrder1.Size = New System.Drawing.Size(91, 22)
        Me.dtpOrder1.TabIndex = 3
        Me.dtpOrder1.TabStop = false
        Me.dtpOrder1.Value = New Date(2004, 1, 7, 0, 0, 0, 0)
        '
        'chkFindNomer
        '
        Me.chkFindNomer.AutoSize = true
        Me.chkFindNomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkFindNomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFindNomer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkFindNomer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkFindNomer.Location = New System.Drawing.Point(3, 31)
        Me.chkFindNomer.Name = "chkFindNomer"
        Me.chkFindNomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFindNomer.Size = New System.Drawing.Size(194, 22)
        Me.chkFindNomer.TabIndex = 7
        Me.chkFindNomer.TabStop = false
        Me.chkFindNomer.Text = "����� ������"
        '
        'chkDataOut
        '
        Me.chkDataOut.AutoSize = true
        Me.chkDataOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDataOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDataOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkDataOut.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkDataOut.Location = New System.Drawing.Point(3, 59)
        Me.chkDataOut.Name = "chkDataOut"
        Me.chkDataOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDataOut.Size = New System.Drawing.Size(194, 24)
        Me.chkDataOut.TabIndex = 60
        Me.chkDataOut.TabStop = false
        Me.chkDataOut.Text = "���� ������ ������"
        '
        'chkDesignerFind
        '
        Me.chkDesignerFind.AutoSize = true
        Me.chkDesignerFind.Checked = true
        Me.chkDesignerFind.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDesignerFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDesignerFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDesignerFind.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkDesignerFind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkDesignerFind.Location = New System.Drawing.Point(3, 176)
        Me.chkDesignerFind.Name = "chkDesignerFind"
        Me.chkDesignerFind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDesignerFind.Size = New System.Drawing.Size(194, 24)
        Me.chkDesignerFind.TabIndex = 67
        Me.chkDesignerFind.TabStop = false
        Me.chkDesignerFind.Text = "�����������"
        '
        'chkPredoplata
        '
        Me.chkPredoplata.AutoSize = true
        Me.chkPredoplata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkPredoplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPredoplata.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkPredoplata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkPredoplata.Location = New System.Drawing.Point(3, 413)
        Me.chkPredoplata.Name = "chkPredoplata"
        Me.chkPredoplata.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPredoplata.Size = New System.Drawing.Size(194, 24)
        Me.chkPredoplata.TabIndex = 74
        Me.chkPredoplata.TabStop = false
        Me.chkPredoplata.Text = "����������� ������"
        '
        'clbCondition
        '
        Me.clbCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbCondition.CheckOnClick = true
        Me.tlpFind.SetColumnSpan(Me.clbCondition, 2)
        Me.clbCondition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbCondition.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.clbCondition.FormattingEnabled = true
        Me.clbCondition.Location = New System.Drawing.Point(203, 233)
        Me.clbCondition.MinimumSize = New System.Drawing.Size(0, 84)
        Me.clbCondition.Name = "clbCondition"
        Me.clbCondition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clbCondition.Size = New System.Drawing.Size(188, 84)
        Me.clbCondition.TabIndex = 83
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = true
        Me.chkStatus.Checked = true
        Me.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkStatus.Location = New System.Drawing.Point(3, 233)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(194, 84)
        Me.chkStatus.TabIndex = 84
        Me.chkStatus.Text = "���������"
        Me.chkStatus.UseVisualStyleBackColor = true
        '
        'chkReclama
        '
        Me.chkReclama.AutoSize = true
        Me.chkReclama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkReclama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkReclama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkReclama.Location = New System.Drawing.Point(3, 471)
        Me.chkReclama.Name = "chkReclama"
        Me.chkReclama.Size = New System.Drawing.Size(194, 24)
        Me.chkReclama.TabIndex = 85
        Me.chkReclama.Text = "�������� ������"
        Me.chkReclama.UseVisualStyleBackColor = true
        '
        'cmbReclama
        '
        Me.cmbReclama.BackColor = System.Drawing.SystemColors.Control
        Me.tlpFind.SetColumnSpan(Me.cmbReclama, 2)
        Me.cmbReclama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbReclama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReclama.Enabled = false
        Me.cmbReclama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbReclama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbReclama.FormattingEnabled = true
        Me.cmbReclama.Location = New System.Drawing.Point(203, 471)
        Me.cmbReclama.Name = "cmbReclama"
        Me.cmbReclama.Size = New System.Drawing.Size(188, 24)
        Me.cmbReclama.TabIndex = 86
        '
        'chkOrg
        '
        Me.chkOrg.AutoSize = true
        Me.chkOrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOrg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkOrg.Location = New System.Drawing.Point(3, 501)
        Me.chkOrg.Name = "chkOrg"
        Me.chkOrg.Size = New System.Drawing.Size(194, 24)
        Me.chkOrg.TabIndex = 87
        Me.chkOrg.Text = "�����������"
        Me.chkOrg.UseVisualStyleBackColor = true
        Me.chkOrg.Visible = false
        '
        'cmbOrg
        '
        Me.cmbOrg.BackColor = System.Drawing.SystemColors.Control
        Me.tlpFind.SetColumnSpan(Me.cmbOrg, 2)
        Me.cmbOrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrg.Enabled = false
        Me.cmbOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOrg.Location = New System.Drawing.Point(203, 501)
        Me.cmbOrg.Name = "cmbOrg"
        Me.cmbOrg.Size = New System.Drawing.Size(188, 24)
        Me.cmbOrg.TabIndex = 88
        Me.cmbOrg.Visible = false
        '
        'cmbSelectRel
        '
        Me.cmbSelectRel.BackColor = System.Drawing.SystemColors.Control
        Me.cmbSelectRel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSelectRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectRel.Enabled = false
        Me.cmbSelectRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelectRel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbSelectRel.FormattingEnabled = true
        Me.cmbSelectRel.IntegralHeight = false
        Me.cmbSelectRel.Items.AddRange(New Object() {"�������������", "��. ����"})
        Me.cmbSelectRel.Location = New System.Drawing.Point(203, 353)
        Me.cmbSelectRel.Name = "cmbSelectRel"
        Me.cmbSelectRel.Size = New System.Drawing.Size(91, 24)
        Me.cmbSelectRel.TabIndex = 89
        '
        'cmbDataVydahi
        '
        Me.cmbDataVydahi.BackColor = System.Drawing.SystemColors.Control
        Me.cmbDataVydahi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDataVydahi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDataVydahi.Enabled = false
        Me.cmbDataVydahi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDataVydahi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbDataVydahi.FormattingEnabled = true
        Me.cmbDataVydahi.Items.AddRange(New Object() {"������", "�����", "������"})
        Me.cmbDataVydahi.Location = New System.Drawing.Point(203, 59)
        Me.cmbDataVydahi.Name = "cmbDataVydahi"
        Me.cmbDataVydahi.Size = New System.Drawing.Size(91, 24)
        Me.cmbDataVydahi.TabIndex = 91
        '
        'cmbMaket
        '
        Me.cmbMaket.BackColor = System.Drawing.SystemColors.Control
        Me.cmbMaket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMaket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaket.Enabled = false
        Me.cmbMaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMaket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbMaket.FormattingEnabled = true
        Me.cmbMaket.Items.AddRange(New Object() {"������", "�����", "������"})
        Me.cmbMaket.Location = New System.Drawing.Point(203, 146)
        Me.cmbMaket.Name = "cmbMaket"
        Me.cmbMaket.Size = New System.Drawing.Size(91, 24)
        Me.cmbMaket.TabIndex = 92
        '
        'chkShowDismissedManagers
        '
        Me.chkShowDismissedManagers.AutoSize = true
        Me.tlpFind.SetColumnSpan(Me.chkShowDismissedManagers, 2)
        Me.chkShowDismissedManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowDismissedManagers.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.chkShowDismissedManagers.Location = New System.Drawing.Point(203, 119)
        Me.chkShowDismissedManagers.Name = "chkShowDismissedManagers"
        Me.chkShowDismissedManagers.Size = New System.Drawing.Size(163, 21)
        Me.chkShowDismissedManagers.TabIndex = 93
        Me.chkShowDismissedManagers.Text = "���������� ���������"
        Me.chkShowDismissedManagers.UseVisualStyleBackColor = true
        '
        'chkShowDismissedExecutors
        '
        Me.chkShowDismissedExecutors.AutoSize = true
        Me.tlpFind.SetColumnSpan(Me.chkShowDismissedExecutors, 2)
        Me.chkShowDismissedExecutors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowDismissedExecutors.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.chkShowDismissedExecutors.Location = New System.Drawing.Point(203, 206)
        Me.chkShowDismissedExecutors.Name = "chkShowDismissedExecutors"
        Me.chkShowDismissedExecutors.Size = New System.Drawing.Size(163, 21)
        Me.chkShowDismissedExecutors.TabIndex = 94
        Me.chkShowDismissedExecutors.Text = "���������� ���������"
        Me.chkShowDismissedExecutors.UseVisualStyleBackColor = true
        '
        'chkCostType
        '
        Me.chkCostType.AutoSize = true
        Me.chkCostType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCostType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCostType.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.chkCostType.Location = New System.Drawing.Point(3, 531)
        Me.chkCostType.Name = "chkCostType"
        Me.chkCostType.Size = New System.Drawing.Size(194, 62)
        Me.chkCostType.TabIndex = 95
        Me.chkCostType.Text = "��� ������"
        Me.chkCostType.UseVisualStyleBackColor = true
        '
        'clbCostType
        '
        Me.clbCostType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbCostType.CheckOnClick = true
        Me.tlpFind.SetColumnSpan(Me.clbCostType, 2)
        Me.clbCostType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbCostType.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.clbCostType.FormattingEnabled = true
        Me.clbCostType.Items.AddRange(New Object() {"��������", "�����������", "���������"})
        Me.clbCostType.Location = New System.Drawing.Point(203, 531)
        Me.clbCostType.Name = "clbCostType"
        Me.clbCostType.Size = New System.Drawing.Size(188, 62)
        Me.clbCostType.TabIndex = 96
        '
        'tlpNewOrder
        '
        Me.tlpNewOrder.AutoSize = true
        Me.tlpNewOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpNewOrder.ColumnCount = 2
        Me.tlpNewOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpNewOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpNewOrder.Controls.Add(Me.cmbOrganization, 1, 5)
        Me.tlpNewOrder.Controls.Add(Me.cmbCustomer, 1, 2)
        Me.tlpNewOrder.Controls.Add(Me.txtFindCust, 0, 2)
        Me.tlpNewOrder.Controls.Add(Me.txtFindProd, 0, 3)
        Me.tlpNewOrder.Controls.Add(Me.lbReclama, 0, 4)
        Me.tlpNewOrder.Controls.Add(Me.cmbMarketing, 1, 4)
        Me.tlpNewOrder.Controls.Add(Me.lbOrganization, 0, 5)
        Me.tlpNewOrder.Controls.Add(Me.txtKAname, 0, 0)
        Me.tlpNewOrder.Controls.Add(Me.btnKAcancel, 1, 1)
        Me.tlpNewOrder.Controls.Add(Me.cmbProd, 1, 3)
        Me.tlpNewOrder.Controls.Add(Me.btnSaveOrder, 1, 6)
        Me.tlpNewOrder.Controls.Add(Me.btnKAsave, 1, 0)
        Me.tlpNewOrder.Controls.Add(Me.txtKAtel, 0, 1)
        Me.tlpNewOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpNewOrder.Location = New System.Drawing.Point(0, 0)
        Me.tlpNewOrder.Name = "tlpNewOrder"
        Me.tlpNewOrder.RowCount = 7
        Me.tlpNewOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNewOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNewOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNewOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNewOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNewOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNewOrder.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpNewOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16!))
        Me.tlpNewOrder.Size = New System.Drawing.Size(182, 224)
        Me.tlpNewOrder.TabIndex = 24
        '
        'cmbOrganization
        '
        Me.cmbOrganization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbOrganization.FormattingEnabled = true
        Me.cmbOrganization.Location = New System.Drawing.Point(190, 158)
        Me.cmbOrganization.MaxDropDownItems = 16
        Me.cmbOrganization.Name = "cmbOrganization"
        Me.cmbOrganization.Size = New System.Drawing.Size(1, 25)
        Me.cmbOrganization.TabIndex = 5
        '
        'txtFindCust
        '
        Me.txtFindCust.BackColor = System.Drawing.SystemColors.Info
        Me.txtFindCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindCust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFindCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtFindCust.Location = New System.Drawing.Point(3, 65)
        Me.txtFindCust.MaxLength = 10
        Me.txtFindCust.Name = "txtFindCust"
        Me.txtFindCust.Size = New System.Drawing.Size(181, 24)
        Me.txtFindCust.TabIndex = 0
        Me.txtFindCust.TabStop = false
        Me.txtFindCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbReclama
        '
        Me.lbReclama.AutoSize = true
        Me.lbReclama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbReclama.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lbReclama.Location = New System.Drawing.Point(3, 124)
        Me.lbReclama.Name = "lbReclama"
        Me.lbReclama.Size = New System.Drawing.Size(181, 31)
        Me.lbReclama.TabIndex = 84
        Me.lbReclama.Text = "�������� ������"
        Me.lbReclama.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMarketing
        '
        Me.cmbMarketing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMarketing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMarketing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbMarketing.FormattingEnabled = true
        Me.cmbMarketing.Location = New System.Drawing.Point(190, 127)
        Me.cmbMarketing.MaxDropDownItems = 16
        Me.cmbMarketing.Name = "cmbMarketing"
        Me.cmbMarketing.Size = New System.Drawing.Size(1, 25)
        Me.cmbMarketing.TabIndex = 4
        '
        'lbOrganization
        '
        Me.lbOrganization.AutoSize = true
        Me.lbOrganization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbOrganization.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lbOrganization.Location = New System.Drawing.Point(3, 155)
        Me.lbOrganization.Name = "lbOrganization"
        Me.lbOrganization.Size = New System.Drawing.Size(181, 31)
        Me.lbOrganization.TabIndex = 85
        Me.lbOrganization.Text = "�����������"
        Me.lbOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKAname
        '
        Me.txtKAname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKAname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKAname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtKAname.ForeColor = System.Drawing.Color.Red
        Me.txtKAname.Location = New System.Drawing.Point(3, 3)
        Me.txtKAname.Name = "txtKAname"
        Me.txtKAname.Size = New System.Drawing.Size(181, 24)
        Me.txtKAname.TabIndex = 0
        Me.txtKAname.Tag = "newKA"
        Me.txtKAname.Text = "������������"
        Me.txtKAname.Visible = false
        '
        'btnKAcancel
        '
        Me.btnKAcancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKAcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKAcancel.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnKAcancel.Location = New System.Drawing.Point(190, 34)
        Me.btnKAcancel.Name = "btnKAcancel"
        Me.btnKAcancel.Size = New System.Drawing.Size(1, 25)
        Me.btnKAcancel.TabIndex = 3
        Me.btnKAcancel.Tag = "newKA"
        Me.btnKAcancel.Text = "������"
        Me.btnKAcancel.UseVisualStyleBackColor = true
        Me.btnKAcancel.Visible = false
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveOrder.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSaveOrder.Location = New System.Drawing.Point(190, 189)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(1, 32)
        Me.btnSaveOrder.TabIndex = 8
        Me.btnSaveOrder.Text = "��������� �����"
        Me.btnSaveOrder.UseVisualStyleBackColor = true
        '
        'btnKAsave
        '
        Me.btnKAsave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKAsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKAsave.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnKAsave.Location = New System.Drawing.Point(190, 3)
        Me.btnKAsave.Name = "btnKAsave"
        Me.btnKAsave.Size = New System.Drawing.Size(1, 25)
        Me.btnKAsave.TabIndex = 2
        Me.btnKAsave.Tag = "newKA"
        Me.btnKAsave.Text = "���������"
        Me.btnKAsave.UseVisualStyleBackColor = true
        Me.btnKAsave.Visible = false
        '
        'txtKAtel
        '
        Me.txtKAtel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKAtel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtKAtel.ForeColor = System.Drawing.Color.Red
        Me.txtKAtel.Location = New System.Drawing.Point(3, 34)
        Me.txtKAtel.Mask = "(999) 000-00-00"
        Me.txtKAtel.Name = "txtKAtel"
        Me.txtKAtel.Size = New System.Drawing.Size(181, 24)
        Me.txtKAtel.TabIndex = 105
        Me.txtKAtel.Tag = "newKA"
        Me.txtKAtel.Visible = false
        '
        'tlpProdMan
        '
        Me.tlpProdMan.BackColor = System.Drawing.SystemColors.Window
        Me.tlpProdMan.ColumnCount = 2
        Me.tlpProdMan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpProdMan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpProdMan.Controls.Add(Me.dgTasks, 0, 1)
        Me.tlpProdMan.Controls.Add(Me.Label1, 0, 0)
        Me.tlpProdMan.Controls.Add(Me.btnUpdateTask, 1, 0)
        Me.tlpProdMan.Controls.Add(Me.dgTasks1, 0, 3)
        Me.tlpProdMan.Controls.Add(Me.Label4, 0, 2)
        Me.tlpProdMan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpProdMan.Location = New System.Drawing.Point(0, 0)
        Me.tlpProdMan.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpProdMan.Name = "tlpProdMan"
        Me.tlpProdMan.RowCount = 4
        Me.tlpProdMan.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpProdMan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpProdMan.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpProdMan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpProdMan.Size = New System.Drawing.Size(489, 687)
        Me.tlpProdMan.TabIndex = 1
        '
        'dgTasks
        '
        Me.dgTasks.AllowUserToAddRows = false
        Me.dgTasks.AllowUserToDeleteRows = false
        Me.dgTasks.AllowUserToResizeRows = false
        Me.dgTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTasks.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgTasks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpProdMan.SetColumnSpan(Me.dgTasks, 2)
        Me.dgTasks.ContextMenuStrip = Me.cmsTasks
        Me.dgTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTasks.Location = New System.Drawing.Point(4, 39)
        Me.dgTasks.Margin = New System.Windows.Forms.Padding(4)
        Me.dgTasks.MultiSelect = false
        Me.dgTasks.Name = "dgTasks"
        Me.dgTasks.ReadOnly = true
        Me.dgTasks.RowHeadersVisible = false
        Me.dgTasks.RowTemplate.Height = 24
        Me.dgTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTasks.Size = New System.Drawing.Size(481, 309)
        Me.dgTasks.TabIndex = 1
        '
        'cmsTasks
        '
        Me.cmsTasks.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsTasks.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTasks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.��������������ToolStripMenuItem, Me.�������������ToolStripMenuItem1, Me.���������ToolStripMenuItem})
        Me.cmsTasks.Name = "cmsTasks"
        Me.cmsTasks.Size = New System.Drawing.Size(198, 76)
        '
        '��������������ToolStripMenuItem
        '
        Me.��������������ToolStripMenuItem.Name = "��������������ToolStripMenuItem"
        Me.��������������ToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.��������������ToolStripMenuItem.Text = "������� � ������"
        '
        '�������������ToolStripMenuItem1
        '
        Me.�������������ToolStripMenuItem1.Name = "�������������ToolStripMenuItem1"
        Me.�������������ToolStripMenuItem1.Size = New System.Drawing.Size(197, 24)
        Me.�������������ToolStripMenuItem1.Text = "������� ������"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.���������ToolStripMenuItem.Text = "���������"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "������ ��� �� ����������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnUpdateTask
        '
        Me.btnUpdateTask.AutoSize = true
        Me.btnUpdateTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdateTask.BackColor = System.Drawing.Color.PaleGreen
        Me.btnUpdateTask.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUpdateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateTask.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnUpdateTask.Location = New System.Drawing.Point(354, 3)
        Me.btnUpdateTask.Name = "btnUpdateTask"
        Me.btnUpdateTask.Size = New System.Drawing.Size(132, 29)
        Me.btnUpdateTask.TabIndex = 4
        Me.btnUpdateTask.Text = "�������� ������"
        Me.btnUpdateTask.UseVisualStyleBackColor = false
        '
        'dgTasks1
        '
        Me.dgTasks1.AllowUserToAddRows = false
        Me.dgTasks1.AllowUserToDeleteRows = false
        Me.dgTasks1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTasks1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgTasks1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTasks1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpProdMan.SetColumnSpan(Me.dgTasks1, 2)
        Me.dgTasks1.ContextMenuStrip = Me.cmsTask1
        Me.dgTasks1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTasks1.Location = New System.Drawing.Point(3, 373)
        Me.dgTasks1.MultiSelect = false
        Me.dgTasks1.Name = "dgTasks1"
        Me.dgTasks1.ReadOnly = true
        Me.dgTasks1.RowHeadersVisible = false
        Me.dgTasks1.RowTemplate.Height = 24
        Me.dgTasks1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTasks1.Size = New System.Drawing.Size(483, 311)
        Me.dgTasks1.TabIndex = 5
        '
        'cmsTask1
        '
        Me.cmsTask1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsTask1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTask1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.�������������ToolStripMenuItem, Me.���������������������ToolStripMenuItem, Me.�������������ToolStripMenuItem, Me.��������������ToolStripMenuItem1})
        Me.cmsTask1.Name = "cmsTask1"
        Me.cmsTask1.Size = New System.Drawing.Size(258, 100)
        '
        '�������������ToolStripMenuItem
        '
        Me.�������������ToolStripMenuItem.Name = "�������������ToolStripMenuItem"
        Me.�������������ToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.�������������ToolStripMenuItem.Text = "������� ������"
        '
        '���������������������ToolStripMenuItem
        '
        Me.���������������������ToolStripMenuItem.Name = "���������������������ToolStripMenuItem"
        Me.���������������������ToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.���������������������ToolStripMenuItem.Text = "����������� ����������"
        '
        '�������������ToolStripMenuItem
        '
        Me.�������������ToolStripMenuItem.Name = "�������������ToolStripMenuItem"
        Me.�������������ToolStripMenuItem.Size = New System.Drawing.Size(257, 24)
        Me.�������������ToolStripMenuItem.Text = "������� ������"
        '
        '��������������ToolStripMenuItem1
        '
        Me.��������������ToolStripMenuItem1.Name = "��������������ToolStripMenuItem1"
        Me.��������������ToolStripMenuItem1.Size = New System.Drawing.Size(257, 24)
        Me.��������������ToolStripMenuItem1.Text = "������� � ������"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "������ ��� �� ��������"
        '
        'chkContextSearch
        '
        Me.chkContextSearch.AutoSize = true
        Me.chkContextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkContextSearch.Location = New System.Drawing.Point(1026, 6)
        Me.chkContextSearch.Name = "chkContextSearch"
        Me.chkContextSearch.Size = New System.Drawing.Size(12, 11)
        Me.chkContextSearch.TabIndex = 11
        Me.chkContextSearch.UseVisualStyleBackColor = true
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToAddRows = false
        Me.dgTableData.AllowUserToDeleteRows = false
        Me.dgTableData.AllowUserToResizeRows = false
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTableData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgTableData.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgTableData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTableData.ContextMenuStrip = Me.cmsMain
        Me.dgTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTableData.Location = New System.Drawing.Point(0, 27)
        Me.dgTableData.MultiSelect = false
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.ReadOnly = true
        Me.dgTableData.RowHeadersVisible = false
        Me.dgTableData.RowHeadersWidth = 15
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTableData.Size = New System.Drawing.Size(1274, 12)
        Me.dgTableData.TabIndex = 0
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnUpdate, Me.ToolStripSeparator7, Me.ShowOrdersWithProblem, Me.ToolStripSeparator5, Me.tsbtnMyOplOrder, Me.ToolStripSeparator3, Me.tsbtnMyZavtraSdavat, Me.ToolStripSeparator6, Me.tstxtContextFind})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(1274, 27)
        Me.BindingNavigator1.TabIndex = 10
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'tsbtnUpdate
        '
        Me.tsbtnUpdate.BackColor = System.Drawing.Color.PaleGreen
        Me.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdate.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnUpdate.Image = CType(resources.GetObject("tsbtnUpdate.Image"),System.Drawing.Image)
        Me.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdate.Name = "tsbtnUpdate"
        Me.tsbtnUpdate.Size = New System.Drawing.Size(131, 24)
        Me.tsbtnUpdate.Text = "�������� ������"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'ShowOrdersWithProblem
        '
        Me.ShowOrdersWithProblem.BackColor = System.Drawing.Color.Pink
        Me.ShowOrdersWithProblem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowOrdersWithProblem.Image = CType(resources.GetObject("ShowOrdersWithProblem.Image"),System.Drawing.Image)
        Me.ShowOrdersWithProblem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowOrdersWithProblem.Name = "ShowOrdersWithProblem"
        Me.ShowOrdersWithProblem.Size = New System.Drawing.Size(191, 24)
        Me.ShowOrdersWithProblem.Text = "��� ���������� ������"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'tsbtnMyOplOrder
        '
        Me.tsbtnMyOplOrder.BackColor = System.Drawing.Color.Pink
        Me.tsbtnMyOplOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnMyOplOrder.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnMyOplOrder.Image = CType(resources.GetObject("tsbtnMyOplOrder.Image"),System.Drawing.Image)
        Me.tsbtnMyOplOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMyOplOrder.Name = "tsbtnMyOplOrder"
        Me.tsbtnMyOplOrder.Size = New System.Drawing.Size(181, 24)
        Me.tsbtnMyOplOrder.Text = "��� ��������� �������"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'tsbtnMyZavtraSdavat
        '
        Me.tsbtnMyZavtraSdavat.BackColor = System.Drawing.Color.Pink
        Me.tsbtnMyZavtraSdavat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnMyZavtraSdavat.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnMyZavtraSdavat.Image = CType(resources.GetObject("tsbtnMyZavtraSdavat.Image"),System.Drawing.Image)
        Me.tsbtnMyZavtraSdavat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMyZavtraSdavat.Name = "tsbtnMyZavtraSdavat"
        Me.tsbtnMyZavtraSdavat.Size = New System.Drawing.Size(223, 24)
        Me.tsbtnMyZavtraSdavat.Text = "��� ������ �������, � ������"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'tstxtContextFind
        '
        Me.tstxtContextFind.BackColor = System.Drawing.SystemColors.Info
        Me.tstxtContextFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtContextFind.Enabled = false
        Me.tstxtContextFind.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtContextFind.Margin = New System.Windows.Forms.Padding(1, 0, 20, 0)
        Me.tstxtContextFind.Name = "tstxtContextFind"
        Me.tstxtContextFind.Size = New System.Drawing.Size(262, 27)
        Me.tstxtContextFind.Text = "�����������_�����"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'ManagersPerformanceReportButton
        '
        Me.ManagersPerformanceReportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ManagersPerformanceReportButton.Image = CType(resources.GetObject("ManagersPerformanceReportButton.Image"),System.Drawing.Image)
        Me.ManagersPerformanceReportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ManagersPerformanceReportButton.Name = "ManagersPerformanceReportButton"
        Me.ManagersPerformanceReportButton.Size = New System.Drawing.Size(183, 24)
        Me.ManagersPerformanceReportButton.Text = "���������. ����������"
        Me.ManagersPerformanceReportButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'frmMainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(1276, 820)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(976, 666)
        Me.Name = "frmMainForm"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmsMain.ResumeLayout(false)
        Me.cmsKA.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.rightTableLayoutPanel.ResumeLayout(false)
        Me.rightTableLayoutPanel.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        Me.scCommonFindNew.Panel1.ResumeLayout(false)
        Me.scCommonFindNew.Panel1.PerformLayout
        Me.scCommonFindNew.Panel2.ResumeLayout(false)
        Me.scCommonFindNew.Panel2.PerformLayout
        CType(Me.scCommonFindNew,System.ComponentModel.ISupportInitialize).EndInit
        Me.scCommonFindNew.ResumeLayout(false)
        Me.tlpFind.ResumeLayout(false)
        Me.tlpFind.PerformLayout
        Me.tlpNewOrder.ResumeLayout(false)
        Me.tlpNewOrder.PerformLayout
        Me.tlpProdMan.ResumeLayout(false)
        Me.tlpProdMan.PerformLayout
        CType(Me.dgTasks,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsTasks.ResumeLayout(false)
        CType(Me.dgTasks1,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsTask1.ResumeLayout(false)
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BindingNavigator1,System.ComponentModel.ISupportInitialize).EndInit
        Me.BindingNavigator1.ResumeLayout(false)
        Me.BindingNavigator1.PerformLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

    Dim allowQueryUpdate As Boolean = False ' ���������� ��� �� ���������� ������� ������� �� 2 ��������� �����
    Dim dsServices As New DataSet '����� ������ ��� ������ ��������� ����
    Dim serviceLoading As Boolean = False
    Dim forExcelcaption As String
    Dim TopA As Integer
    Dim ScreenH As Integer
    Dim ScreenW As Integer
    Dim organizationVisible As Boolean = True
    Dim split1Moved As Boolean = False

#Region " ��������, ���������, �������� � ����� "
    Private Sub frmMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ScreenH = My.Computer.Screen.WorkingArea.Height
        ScreenW = My.Computer.Screen.WorkingArea.Width '� ����������� ����

        Try
            Me.tsbtnKassa.Visible = kassaAllow

            '    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("ru-RU")) '������ ���� ����� �� �������

            Dim odaServices As New SqlClient.SqlDataAdapter("SELECT * FROM Services WHERE active <> 0 order by name", mcnnInt)
            odaServices.FillSchema(dsServices, 2, "Services")
            odaServices.Fill(dsServices, "Services")
            Me.tscmbServices.ComboBox.DataSource = dsServices.Tables("Services")
            Me.tscmbServices.ComboBox.DisplayMember = "name"
            Me.tscmbServices.ComboBox.ValueMember = "ID"
            Me.tscmbServices.ComboBox.SelectedIndex = -1

            serviceLoading = True

            LoadManagers()
            LoadExecutors()

            Dim odaMarket1 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM Reclama order by description", mcnnInt)
            Dim dtMarket1 As New DataTable : odaMarket1.Fill(dtMarket1)
            Me.cmbReclama.DataSource = dtMarket1
            Me.cmbReclama.DisplayMember = "Name"
            Me.cmbReclama.ValueMember = "ID"

            '  If oprosOnOff = True Then
            Dim odaMarket As New SqlClient.SqlDataAdapter("SELECT ID, name FROM Reclama order by description", mcnnInt)
            Dim dtMarket As New DataTable : odaMarket.Fill(dtMarket)

            Me.cmbMarketing.DataSource = dtMarket
            Me.cmbMarketing.DisplayMember = "Name"
            Me.cmbMarketing.ValueMember = "ID"
            Me.cmbMarketing.SelectedIndex = -1
            '   End If

            'Me.cmbMarketing.Visible = oprosOnOff
            '  Me.lbReclama.Visible = oprosOnOff

            Dim odaOrg1 As New SqlClient.SqlDataAdapter("SELECT custID, shortName FROM Organizations WHERE KAgent_ID=(select ID from KAgents where type_ID=1) AND closed<>1 order by name", mcnnInt)
            Dim dtOrg1 As New DataTable : odaOrg1.Fill(dtOrg1)
            Me.cmbOrg.DataSource = dtOrg1
            Me.cmbOrg.DisplayMember = "shortName"
            Me.cmbOrg.ValueMember = "custID"

            '��������� ������ ���������
            Dim odaConditionFind1 As New SqlClient.SqlDataAdapter("SELECT statusID, status  FROM Statuses", mcnnInt)
            Dim dtCondition1 As New DataTable : odaConditionFind1.Fill(dtCondition1)
            Me.clbCondition.DataSource = dtCondition1
            Me.clbCondition.DisplayMember = "status"
            Me.clbCondition.ValueMember = "statusID"

            For i As Integer = 0 To clbCondition.Items.Count - 1
                Me.clbCondition.SetItemCheckState(i, CheckState.Checked)
            Next

            Me.clbCondition.SetItemChecked(2, False)
            Me.clbCondition.SetItemChecked(3, False)

            Me.dtpOrder2.Value = Now().Date
            Me.dtpDataVydahi.Value = Now().Date
            Me.dtpMaket.Value = Now().Date
            Me.Text = appName + " 1.5.6 ����� ����������, " & Module1.NonQuery1ScalarString("SELECT rtrim(emplLastName) From Employees WHERE emplID=" & emplID & "")

            '��������� ���������� � ����� ������
            idSup = CInt(Module1.NonQuery1Scalar("SELECT ID From TypesKAgent WHERE description='���������'"))

            Dim odaEmplPost = New SqlClient.SqlDataAdapter("SELECT * From Employees INNER JOIN Posts ON Employees.postID=Posts.postID WHERE employees.emplID=" & emplID & "", mcnnInt)
            Dim dtEmplPost As New DataTable : odaEmplPost.Fill(dtEmplPost)
            Dim mdrEmplPost As DataRow = dtEmplPost.Rows(0)

            visibleResurs = mdrEmplPost("b0")
            visibleSklad = mdrEmplPost("b1")
            visibleFinans = mdrEmplPost("b2")
            visibleContact = mdrEmplPost("b3")
            visibleCostOrder = mdrEmplPost("b4")
            allowDelFiles = mdrEmplPost("b5")
            viewOnlyWhereImExecut = mdrEmplPost("b6")
            visibleSpravochnik = mdrEmplPost("b7")
            rulesPayments = mdrEmplPost("b8")
            WorkplaceHead = mdrEmplPost("b9")
            ProductionDate = mdrEmplPost("b10")
            editClosedOrders = mdrEmplPost("b13")
            OrdTakOfMan = mdrEmplPost("b14") '������������ ������ ��� �� ������
            FZPno = mdrEmplPost("b12")
            CanceledOrder = mdrEmplPost("b19")
            otmGotovnost = mdrEmplPost("b18")
            CanUseMdmOnlinePayments = mdrEmplPost("b20")
            CanUseEnjoyOnlinePayments = mdrEmplPost("b21")
            CanUseAdditionalMdmOnlinePayments = mdrEmplPost("b22")
            CanMakeOnlinePaymentsInProgram = mdrEmplPost("b23")
            CanChangeRoutsInReadyOrder = mdrEmplPost("b25")
            CanChangeRoutsInIssuedOrder = mdrEmplPost("b26")
            CanDeleteRouts = mdrEmplPost("b27")
            CanEditCancelledOrders = mdrEmplPost("b28")
            CanAddDocumentOfSameType = mdrEmplPost("b29")

            Me.chkDesignerFind.Checked = viewOnlyWhereImExecut
            Me.cmbDesignerFind.Enabled = viewOnlyWhereImExecut
            Me.chkDesignerFind.Enabled = Not viewOnlyWhereImExecut
            Me.tsbtnKassa.Visible = kassaAllow

            Select Case prava '��������� ����������� ������ ������
                Case Is = 0 '����� ��� ������, ����������� ���
                    Me.chkMan.Enabled = True
                Case Is = 1 '����� ��� ������, ����������� ����
                    Me.chkMan.Enabled = True
                Case Is = 2  '����� � ����������� ���� ������
                    Me.chkMan.Enabled = False
                    Me.chkMan.Checked = True
                    Me.cmbManager.Enabled = False
                    Me.chkShowDismissedManagers.Enabled = False
                    Me.cmbManager.SelectedValue = emplID
                Case Is = 3 '����� �� �� ����������� ���� ������
                    Me.cmbManager.SelectedValue = emplID
                    Me.chkMan.Enabled = False
                    Me.chkMan.Checked = True
                    Me.cmbManager.Enabled = False
                    Me.chkShowDismissedManagers.Enabled = False
                Case Is = 4
                    Me.chkMan.Enabled = True
                Case Else
                    Me.chkMan.Checked = True
            End Select

            Me.�������ToolStripMenuItem.Visible = visibleResurs
            Me.���ToolStripMenuItem.Visible = visibleResurs
            Me.�������ToolStripMenuItem.Visible = visibleFinans
            Me.tsbtnKassa.Visible = visibleFinans

            Dim odaParam As New SqlClient.SqlDataAdapter("SELECT name, description FROM Parameters", mcnnInt)
            Dim dtParam As New DataTable : odaParam.Fill(dtParam)

            dtParam.Columns("name").Unique = True
            dtParam.PrimaryKey = New DataColumn() {dtParam.Columns("name")}

            Try
                '����������� ����������
                '�� ���������
                paramNumbering = 1 ': paramNumbering = dtParam.Rows.Find("Numbering")("description") ' CInt(Module1.NonQuery1Scalar("SELECT coalesce(description, 0) FROM Parameters WHERE name=  'Numbering' "))
                'paramFinAnalytics = False : paramFinAnalytics = dtParam.Rows.Find("FinAnalytics")("description") ' Module1.NonQuery1ScalarBool("SELECT coalesce(description, 'false') FROM Parameters WHERE name=  'FinAnalytics' ")
                paramFileStoragePath = "" : paramFileStoragePath = dtParam.Rows.Find("FileStoragePath")("description") 'Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'FileStoragePath' ")
                paramLocalTempPath = "" : paramLocalTempPath = dtParam.Rows.Find("LocalTempPath")("description") ' Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'LocalTempPath' ")
                '  �� �����--- paramSklad = False : paramSklad = dtParam.Rows.Find("Sklad")("description") ' Module1.NonQuery1ScalarBool("SELECT coalesce(description, 'false') FROM Parameters WHERE name=  'Sklad' ")
                paramUrlGanter = dtParam.Rows.Find("UrlGanter")("description").ToString  ' Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'UrlGanter' ")
                paramUrlMaper = dtParam.Rows.Find("UrlMaper")("description").ToString  '  Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'UrlMaper' ")
                '  paramUrlMaper = "" : paramUrlMaper = dtParam.Rows.Find("UrlMaper")("description").ToString  '  Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'UrlMaper' ")
                paramOrdTakOfMan = False : paramOrdTakOfMan = dtParam.Rows.Find("OrdTakOfMan")("description") ' Module1.NonQuery1ScalarBool("SELECT coalesce(description, 'false') FROM Parameters WHERE name=  'OrdTakOfMan' ")
                '   paramGoogleCoordinateLogin = "" : paramGoogleCoordinateLogin = dtParam.Rows.Find("GoogleCoordinateLogin")("description") ' Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'GoogleCoordinateLogin' ")
                '   paramGoogleCoordinatePass = "" : paramGoogleCoordinatePass = dtParam.Rows.Find("GoogleCoordinatePass")("description") 'Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'GoogleCoordinatePass' ")
                '  paramGoogleTeamID = "" : paramGoogleTeamID = dtParam.Rows.Find("GoogleTeamID")("description") 'Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'GoogleTeamID' ")
                paramRoutAWC = False ': paramRoutAWC = dtParam.Rows.Find("RoutAWC")("description") ' Module1.NonQuery1ScalarBool("SELECT coalesce(description, 'false') FROM Parameters WHERE name=  'RoutAWC' ")
                '    paramGlobalNac = 0 : paramGlobalNac = KeySettings.GetValue("GlobalNac") 'CInt(dtParam.Rows.Find("KassaPort")("description"))
                '  paramKassaPass = "" : paramKassaPass = KeySettings.GetValue("passKassa") 'dtParam.Rows.Find("KassaPass")("description")
                paramUrlCalcPolygraph = dtParam.Rows.Find("UrlCalcPolygraph")("description") 'Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'GoogleTeamID' ")
                paramUrlCalcFastorder = dtParam.Rows.Find("UrlCalcFastorder")("description") 'Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Parameters WHERE name=  'GoogleTeamID' ")

            Catch ex As System.Exception
                MsgBox("�������� ��������� � ������ �����������. ���������� � ������������.")
                '  MsgBox(ex.Message)
            End Try

            Dim odaOrg As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE KAgent_ID=(SELECT ID FROM KAgents WHERE type_ID=1) AND closed<>1 order by Name ASC", mcnnInt)
            Dim dtOrg As New DataTable : odaOrg.Fill(dtOrg)

            Me.cmbOrganization.DataSource = dtOrg
            Me.cmbOrganization.DisplayMember = "Name"
            Me.cmbOrganization.ValueMember = "custID"

            Me.tsbtnFastOrder.Visible = True

            Me.chkPredoplata.Visible = True
            Me.cmbPredoplata.Visible = True
            Me.tsbtnMyZavtraSdavat.Visible = False
            Me.tsbtnMyOplOrder.Visible = True

            paramManInvoicesPayment = True ' ������ ���������� �������
            autoAccount = True
            paramSklad = True
            paramFZP = True

            paramFinAnalytics = True
            f_paramProductionDate = True

            Me.tsbtnRegInvoice.Visible = True
            paramLogistic = True
            neRedDoc = mdrEmplPost("b15")
            ' neRedDoc = CBool(Module1.NonQuery1Scalar("SELECT coalesce(Posts.b15, 0) From Employees INNER JOIN Posts ON Employees.postID = Posts.postID WHERE employees.emplID = " & emplID & ""))
            nePrinBeznal = mdrEmplPost("b16")
            ' nePrinBeznal = CBool(Module1.NonQuery1Scalar("SELECT coalesce(Posts.b16, 0) From Employees INNER JOIN Posts ON Employees.postID = Posts.postID WHERE employees.emplID = " & emplID & ""))
            EditSpec = mdrEmplPost("b17")
            paramIssuesOrders = mdrEmplPost("b11")
            'EditSpec = CBool(Module1.NonQuery1Scalar("SELECT coalesce(Posts.b17, 0) From Employees INNER JOIN Posts ON Employees.postID = Posts.postID WHERE employees.emplID = " & emplID & "")) '��� ������ � ����� ��������� ������

            Me.chkOrderClosed.Visible = True
            Me.dtpOrderClosed1.Visible = True
            Me.dtpOrderClosed2.Visible = True

            Me.�������������������ToolStripMenuItem.Visible = False

            '�������� ��� ������� �������
            Me.���������ToolStripMenuItem.Visible = True

            Me.tsbtnKassa2.Visible = True

            Timer1.Enabled = True

            If depID = 1017 Or postPrioritet = 1 Then
                Me.�����ToolStripMenuItem.Visible = True
            Else
                Me.�����ToolStripMenuItem.Visible = False 'visibleSklad
            End If

            '���������� ��������� �������� �������
            Me.���������ToolStripMenuItem.Visible = paramLogistic
            Me.����������������ToolStripMenuItem.Visible = paramLogistic
            Me.�����������ToolStripMenuItem1.Visible = visibleSpravochnik
            Me.�����������ToolStripMenuItem.Visible = WorkplaceHead
            Me.�����������������ToolStripMenuItem.Visible = paramManInvoicesPayment

            If paramFZP = True Then
                Me.���ToolStripMenuItem.Visible = Not FZPno
                Me.�������������ToolStripMenuItem1.Visible = Not FZPno
            Else
                Me.���ToolStripMenuItem.Visible = False
                Me.�������������ToolStripMenuItem1.Visible = False
            End If

            '  Me.������������ToolStripMenuItem.Visible = production_man
            '  Me.��ToolStripMenuItem.Visible = production_man

            Me.���������ToolStripMenuItem1.Visible = paramFinAnalytics
            Me.cmbOrganization.Visible = organizationVisible

            LoadMeTasks()

            Me.WindowState = FormWindowState.Maximized

            ModeOrder(True) '������������ ������ ������� �������

            cmbCostActivity.SelectedIndex = 0

            Dim path As String = Dir("c:\333.mp3")

            If path = vbNullString Then
                'Exit Sub 'Label1 = "� ����� �� ����!"
            Else
                procNotepad = Process.Start("c:\333.mp3")
            End If

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName) : Me.Close()
        End Try

        Try
            Dim File, Files() As FileInfo   '�������� ��������� �����
            Dim Dir1 As New DirectoryInfo("C:\tmp")

            If Dir1.Exists Then
                Files = Dir1.GetFiles("*.*")
                For Each File In Files
                    File.Delete() '�������� ������
                Next
            Else
                Dir1.Create()
            End If
        Catch ex As System.Exception
            MessageBox.Show("��� ������� � " + paramLocalTempPath + "  " & ex.Message) : Exit Sub
        End Try
    End Sub

    Private Sub LoadExecutors()
        Dim sql As String = "SELECT emplID, emplLastName FROM Employees "
        If (Not chkShowDismissedExecutors.Checked) Then
            sql &= " WHERE dismissed<>1 "
        End If
        sql &= " ORDER BY emplLastName"

        Dim odaDesignerFind As New SqlClient.SqlDataAdapter(sql, mcnnInt)
        Dim dtDesigner As New DataTable : odaDesignerFind.Fill(dtDesigner)
        Me.cmbDesignerFind.DataSource = dtDesigner
        Me.cmbDesignerFind.DisplayMember = "emplLastName"
        Me.cmbDesignerFind.ValueMember = "emplID"
        Me.cmbDesignerFind.SelectedValue = emplID
    End Sub

    Private Sub LoadManagers()
        Dim sql As String = "SELECT emplID, emplLastName FROM Employees "
        If (Not chkShowDismissedManagers.Checked) Then
            sql &= " WHERE dismissed<>1 "
        End If
        sql &=" ORDER BY emplLastName"

        Dim odaMan As New SqlClient.SqlDataAdapter(sql, mcnnInt)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)
        Me.cmbManager.DataSource = dtMan
        Me.cmbManager.DisplayMember = "emplLastName"
        Me.cmbManager.ValueMember = "emplID"
    End Sub

    Private Sub Orders_FormClosing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        e.Cancel = True ' ���� ������������� �������� �����

        Module1.vixod()
    End Sub

    Private Sub ExitPerfect()
        allowQueryUpdate = False

        Module1.vixod()
    End Sub

    Private Sub frmMainForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.tscmbServices.SelectedIndex = -1

        MyOplOrder()
        MyZavtraSdavat()
    End Sub
#End Region

#Region " ��������� ����� "
    Private Sub SaveOrder()
        If Me.cmbCustomer.SelectedIndex = -1 Then
            Me.txtFindCust.Focus()
            Me.ErrorProvider1.SetError(Me.cmbCustomer, "�� ������ ��������")
            Exit Sub
        End If

        If Me.cmbOrganization.SelectedIndex = -1 Then
            Me.cmbOrganization.Focus()
            Me.ErrorProvider1.SetError(Me.cmbOrganization, "�� ������� �����������")
            Exit Sub
        End If


        If Me.cmbMarketing.Visible = True Then
            If Me.cmbMarketing.SelectedIndex = -1 Then ' ������������
                Me.cmbMarketing.Focus()
                Me.ErrorProvider1.SetError(Me.cmbMarketing, "�� ������ ��� ������")
                Exit Sub
            End If
        End If

        Select Case MsgBox(Prompt:="��������� �����?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                costID = createOrder()

                Me.txtCustForSearh.Clear()
                Me.txtFindProd.Clear()
                Me.cmbMarketing.SelectedIndex = -1

                Select Case MsgBox(Prompt:="���������� � ������� ������?", Buttons:=vbYesNo, Title:=appName)
                    Case Is = vbYes
                        ModCallForm.CallForm("", 11, 3)
                    Case Is = vbNo
                        Query()
                        ModeOrder(True)
                End Select

            Case Is = vbNo : Exit Sub
        End Select
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedIndexChanged
        If Me.cmbCustomer.SelectedIndex <> -1 Then
            Me.ErrorProvider1.SetError(Me.cmbCustomer, "")
        End If
    End Sub

    Private Sub cmbOrganization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrganization.SelectedIndexChanged
        If Me.cmbOrganization.SelectedIndex <> -1 Then
            Me.ErrorProvider1.SetError(Me.cmbOrganization, "")
        End If
    End Sub

    Private Function createOrder() As Integer
        '  MsgBox(ofID.ToString)
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_Create"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@cmbCustomer", SqlDbType.Int))
            cmd.Parameters("@cmbCustomer").Value = Me.cmbCustomer.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
            cmd.Parameters("@emplID").Value = emplID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@ofID", SqlDbType.Int))
            cmd.Parameters("@ofID").Value = ofID

            If Me.cmbOrganization.Visible = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
                cmd.Parameters("@orgID").Value = Me.cmbOrganization.SelectedItem(0)
            End If

            If Me.cmbMarketing.Visible = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@cmbMarketing", SqlDbType.Int))
                cmd.Parameters("@cmbMarketing").Value = Me.cmbMarketing.SelectedItem(0)
            End If

            mcnnInt.Open()

            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function
#End Region

#Region " ������� � ������ "
    Private Sub dgTableData_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTableData.CellDoubleClick
        OrderGo1()
    End Sub

    Private Sub OrderGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderGo.Click
        OrderGo1()
    End Sub

    Private Sub OrderGo1()
        costID = Me.dgTableData(0, Me.dgTableData.CurrentRow.Index).Value()
        ModCallForm.CallForm("", 11, 3)
    End Sub
#End Region

#Region " ��������� ������ � ���������� - ������������ � ������  "
    Private Sub LoadCustomers(ByVal selectSerh As Integer, ByVal strFind As String)
        If strFind = """" Or strFind = "'" Then
            Exit Sub
        Else
            Try
                '�� ������ ���������� �� ��������
                Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE Name LIKE '%" & strFind & "%'", mcnnInt) '�� ����������� ����� �� ������� ���� ������������ ���������
                Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

                If dtPartList.Rows.Count = 0 Then
                    Exit Sub
                Else
                    Select Case selectSerh  '������� ������ �� �������
                        Case Is = 1 '��������� ���������� � ���� ���������� �������
                            Me.cmbCustomer.DataSource = dtPartList
                            Me.cmbCustomer.DisplayMember = "Name"
                            Me.cmbCustomer.ValueMember = "ID"
                        Case Is = 2 '��������� ���������� � ���� ������
                            Me.cmbCustForSearh.DataSource = dtPartList
                            Me.cmbCustForSearh.DisplayMember = "Name"
                            Me.cmbCustForSearh.ValueMember = "ID"
                        Case Is = 3
                            Me.cmbCustomer.DataSource = dtPartList
                            Me.cmbCustomer.DisplayMember = "Name"
                            Me.cmbCustomer.ValueMember = "ID"
                            Me.cmbCustomer.SelectedValue = dtPartList.Rows(dtPartList.Rows.Count - 1)("ID")
                            addcust = False
                    End Select
                End If
            Catch oexpData As System.Exception
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub
    '**************************************************************
#End Region

#Region " ������ ������� � ��. ������� "
    Public Sub Query()
        Me.Cursor = Cursors.WaitCursor
        '������� ����� �����
        Dim strQuery As String = Nothing
        Dim currentRow%

        allowQueryUpdate = True

        Try
            If Me.dgTableData.Rows.Count > 0 Then currentRow = Me.dgTableData.CurrentRow.Index() ' ���������� ������� ������ �����
        Catch ex As System.Exception

        End Try

        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_MainForm1"
            cmd.CommandType = CommandType.StoredProcedure

            '��������� ���������
            If Me.chkDataPeriod.Checked = True Then
                strQuery += " AND Costs.data BETWEEN '" & Me.dtpOrder1.Value.Date & "' AND '" & Me.dtpOrder2.Value.Date & "' "
                forExcelcaption = "������ � " & Me.dtpOrder1.Value.Date.ToString & " �� " & Me.dtpOrder2.Value.Date.ToString
            Else
                forExcelcaption = "������ �� ���� ������" '������� ������� ���
                'strQuery += " AND Costs.data BETWEEN '07.01.2004' AND '" & Now.Date.ToString & "' "
            End If
            '***********************

            If Me.chkOrderClosed.Checked = True Then
                strQuery += " AND Costs.dateClosing BETWEEN '" & Me.dtpOrderClosed1.Value.Date & "' AND '" & Me.dtpOrderClosed2.Value.Date & "' "
                forExcelcaption = "������ �������� � " & Me.dtpOrderClosed1.Value.Date.ToString & " �� " & Me.dtpOrderClosed2.Value.Date.ToString
            End If

            If Me.chkCustForSearh.Checked = True Then '���� �� ������ ���������
                If Me.cmbCustForSearh.SelectedIndex = -1 Then
                    MsgBox("�� ������ ����������", MsgBoxStyle.Critical, appName) : Exit Sub
                Else
                    forExcelcaption = "������ " & Me.cmbCustForSearh.Text
                    '**
                    strQuery += " AND Costs.custID=" & Me.cmbCustForSearh.SelectedItem(0) & " "
                End If
            End If
            '***********************
            If Me.chkMan.Checked = True Then
                strQuery += " AND Costs.emplID=" & Me.cmbManager.SelectedItem(0) & " "
            End If

            If Me.chkDesignerFind.Checked = True Then
                strQuery += " AND Costs.emplDesignerID=" & Me.cmbDesignerFind.SelectedItem(0) & " "
            End If

            Dim findID As String = Nothing

            If Me.chkStatus.Checked = True Then
                Dim itemChecked As Object '������� �� ���������

                For Each itemChecked In Me.clbCondition.CheckedItems
                    If findID <> Nothing Then findID += ", "
                    findID += CStr(itemChecked.item(0))
                Next

                If findID = Nothing Then
                    MsgBox("�� ������� �� ���� ��������� ������.", MsgBoxStyle.Critical, appName)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                strQuery += " AND Costs.statusID in (" & findID & ") "
            End If

            If Me.chkFindNomer.Checked = True Then
                strQuery += " AND (Costs.nomerVn LIKE '%" & Trim(Me.txtFind.Text) & "%' OR Costs.nomVN3 LIKE '%" & Trim(Me.txtFind.Text) & "%')"
            End If

            If Me.chkDataOut.Checked = True Then
                Select Case Me.cmbDataVydahi.SelectedIndex
                    Case Is = 0
                        forExcelcaption = forExcelcaption & " ����� ��- " & Me.dtpDataVydahi.Value.Date
                        strQuery += " AND cast(costs.dataOut as date)<'" & Me.dtpDataVydahi.Value.Date & "'"
                    Case Is = 1
                        forExcelcaption = forExcelcaption & " �����- " & Me.dtpDataVydahi.Value.Date
                        strQuery += " AND cast(costs.dataOut as date)='" & Me.dtpDataVydahi.Value.Date & "'"
                    Case Is = 2
                        forExcelcaption = forExcelcaption & " ����� �����- " & Me.dtpDataVydahi.Value.Date
                        strQuery += " AND cast(costs.dataOut as date)>'" & Me.dtpDataVydahi.Value.Date & "'"
                End Select
            End If

            If Me.chkMaketOut.Checked = True Then
                Select Case Me.cmbMaket.SelectedIndex
                    Case Is = 0
                        forExcelcaption = forExcelcaption & " ����� ������ ��- " & Me.dtpMaket.Value.Date
                        strQuery += " AND cast(costs.dataMaketOut as date)<'" & Me.dtpDataVydahi.Value.Date & "'"
                    Case Is = 1
                        forExcelcaption = forExcelcaption & " ����� ������- " & Me.dtpMaket.Value.Date
                        strQuery += " AND cast(costs.dataMaketOut as date)='" & Me.dtpDataVydahi.Value.Date & "'"
                    Case Is = 2
                        forExcelcaption = forExcelcaption & " ����� ������ �����- " & Me.dtpMaket.Value.Date
                        strQuery += " AND cast(costs.dataMaketOut as date)>'" & Me.dtpDataVydahi.Value.Date & "'"
                End Select
            End If

            If Me.chkPerson.Checked = True Then
                If Me.cmbSelectRel.SelectedIndex = 0 Then
                    strQuery += " AND costs.emplCust = " & Me.cmbPerson.SelectedItem(0) & " "
                Else
                    strQuery += " AND costs.costID IN (SELECT DISTINCT costID FROM Invoices WHERE custID=" & Me.cmbPerson.SelectedItem(0) & ")"
                End If
            End If

            If Me.chkReclama.Checked = True Then
                strQuery += " AND Costs.marketingID=" & Me.cmbReclama.SelectedItem(0) & ""
            End If

            If Me.chkProdukt.Checked = True Then
                strQuery += " AND Costs.costID IN (SELECT costID FROM Orders WHERE nameForDoc LIKE '%" & Trim(Me.cmbProdukt.Text) & "%')"
            End If

            If Me.chkOrg.Checked = True Then
                strQuery += " AND Costs.orgID=" & Me.cmbOrg.SelectedItem(0) & ""
            End If

            If Me.chkPredoplata.Checked = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@Predoplata", SqlDbType.Int))

                Select Case Me.cmbPredoplata.SelectedIndex
                    Case Is = 0 '���
                        cmd.Parameters("@Predoplata").Value = 0 '
                    Case Is = 1 '�������� � ����
                        cmd.Parameters("@Predoplata").Value = 1 'Me.cmbPredoplata.SelectedIndex
                    Case Is = 2 '���������
                        cmd.Parameters("@Predoplata").Value = 2 'Me.cmbPredoplata.SelectedIndex
                    Case Is = 3 ' ������ ������
                        cmd.Parameters("@Predoplata").Value = 3
                End Select
            End If

            If (Me.chkCostType.Checked) Then
                Dim costTypes As String = ""
                For Each itemChecked As Integer In Me.clbCostType.CheckedIndices
                    If (costTypes <> Nothing) Then costTypes += ", "
                    costTypes += CStr(itemChecked)
                Next

                If (costTypes = Nothing) Then
                    MsgBox("�� ������ �� ���� ��� ������.", MsgBoxStyle.Critical, appName)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                strQuery += " AND Costs.typeCostIndex IN (" & costTypes & ") "
            End If

            If (cmbCostActivity.SelectedIndex = 0) Then
                strQuery += " AND Costs.cancelled<>1 "
            ElseIf (cmbCostActivity.SelectedIndex = 1) Then
                strQuery += " AND Costs.cancelled=1 "
            End If

            If chkContextSearch.Checked Then
                strQuery += "  OR Costs.nomVN2 LIKE '%" & Trim(Me.tstxtContextFind.Text) & "%' OR Costs.costID IN (SELECT costID FROM Orders WHERE nameForDoc LIKE '%" & Trim(Me.tstxtContextFind.Text) & "%')"
            End If

            If strQuery <> Nothing Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@strQuery", SqlDbType.NVarChar))
                cmd.Parameters("@strQuery").Value = strQuery
            End If


            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtData As New DataTable : objDA.Fill(dtData)

            If dtData.Rows.Count > 0 Then
                ' ********** ������������ ��������� �������� ����� �������
                Dim colC As DataColumn   '��������� ������ ��� ��������� ��������
                Dim setString As String = Nothing '��������� �������� 

                columnNameMF.Clear()

                For Each colC In dtData.Columns   '��������� ��� �������� ����� ��� �� ������ ��������
                    If setString <> Nothing Then setString = setString & "/"
                    setString = setString & colC.ColumnName.ToString

                    columnNameMF.Add(colC.ColumnName.ToString)
                Next

                If KeySettings Is Nothing Then
                    KeySettings = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\MS\Perfect", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree) '��� ����
                    KeySettings.SetValue("order1", setString)
                    KeySettings.SetValue("order2", setString)
                End If

                Me.dgTableData.DataSource = dtData
                Me.dgTableData.Enabled = True

                Me.ToolStripStatusLabel2.Text = "���������� �������: " & CStr(dtData.Rows.Count)

                Castomize(dtData)

                For n As Integer = 0 To Me.dgTableData.ColumnCount - 1
                    Me.dgTableData.Columns("costID").Visible = False '�������� ������ ������� � ��
                    'If (Me.dgTableData.Columns(n).Name = "isExpress") Then Me.dgTableData.Columns("isExpress").Visible = False 
                    If Me.dgTableData.Columns(n).Name = "���������" Then Me.dgTableData.Columns("���������").Visible = visibleCostOrder
                    If Me.dgTableData.Columns(n).Name = "������" Then Me.dgTableData.Columns("������").Visible = visibleCostOrder
                    If Me.dgTableData.Columns(n).Name = "costID" Then Me.dgTableData.Columns("costID").Visible = False '�������� ������� � ��
                    If Me.dgTableData.Columns(n).Name = "������" Then Me.dgTableData.Columns("������").Visible = Not ProductionDate '�������� ������� � ��
                Next

                Try '��������� ������ ���������� ���������� �����
                    Me.dgTableData.CurrentCell = Me.dgTableData(1, currentRow) ' ������� � ������ � ������� ����
                Catch ex As System.Exception

                End Try
                '**************************
                RowColor() '��������� �����

                Me.tsslTotalCost.Visible = visibleCostOrder
                Me.tsslTotalCost.Text = "����� �� ����� " + CStr(Format(dtData.Compute("SUM(���������)", ""), "C"))
                
                Me.tsslDolgItog.Visible = visibleCostOrder
                Me.tsslDolgItog.Text = "������������� " + CStr(Format((dtData.Compute("SUM(���������)", "") - dtData.Compute("SUM(������)", "")), "C"))
            Else
                Me.tsslDolgItog.Visible = False
                Me.tsslTotalCost.Visible = False
                Me.dgTableData.DataSource = Nothing
                Me.dgTableData.Enabled = False
            End If

            Me.Cursor = Cursors.Default
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

    End Sub
#End Region

    Private Sub ShowOrdersWithProblem_Click(sender As Object, e As EventArgs) Handles ShowOrdersWithProblem.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim cmd As New SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Orders_With_Problem"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@Employee_Id", SqlDbType.Int))
            cmd.Parameters("@Employee_Id").Value = emplID

            Dim objDA As New SqlDataAdapter(cmd)
            Dim dtData As New DataTable : objDA.Fill(dtData)

            If dtData.Rows.Count > 0 Then
                ' ********** ������������ ��������� �������� ����� �������
                Dim colC As DataColumn   '��������� ������ ��� ��������� ��������
                Dim setString As String = Nothing '��������� �������� 

                columnNameMF.Clear()

                For Each colC In dtData.Columns   '��������� ��� �������� ����� ��� �� ������ ��������
                    If setString <> Nothing Then setString = setString & "/"
                    setString = setString & colC.ColumnName.ToString

                    columnNameMF.Add(colC.ColumnName.ToString)
                Next

                If KeySettings Is Nothing Then
                    KeySettings = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\MS\Perfect", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree) '��� ����
                    KeySettings.SetValue("order1", setString)
                    KeySettings.SetValue("order2", setString)
                End If

                Me.dgTableData.DataSource = dtData
                Me.dgTableData.Enabled = True

                Me.ToolStripStatusLabel2.Text = "���������� �������: " & CStr(dtData.Rows.Count)

                Castomize(dtData)

                For n As Integer = 0 To Me.dgTableData.ColumnCount - 1
                    Me.dgTableData.Columns("costID").Visible = False '�������� ������ ������� � ��
                    'If (Me.dgTableData.Columns(n).Name = "isExpress") Then Me.dgTableData.Columns("isExpress").Visible = False 
                    If Me.dgTableData.Columns(n).Name = "���������" Then Me.dgTableData.Columns("���������").Visible = visibleCostOrder
                    If Me.dgTableData.Columns(n).Name = "������" Then Me.dgTableData.Columns("������").Visible = visibleCostOrder
                    If Me.dgTableData.Columns(n).Name = "costID" Then Me.dgTableData.Columns("costID").Visible = False '�������� ������� � ��
                    If Me.dgTableData.Columns(n).Name = "������" Then Me.dgTableData.Columns("������").Visible = Not ProductionDate '�������� ������� � ��
                Next

                '**************************
                RowColor()

                Me.tsslTotalCost.Visible = visibleCostOrder
                Me.tsslTotalCost.Text = "����� �� ����� " + CStr(Format(dtData.Compute("SUM(���������)", ""), "C"))

                Me.tsslDolgItog.Visible = visibleCostOrder
                Me.tsslDolgItog.Text = "������������� " + CStr(Format((dtData.Compute("SUM(���������)", "") - dtData.Compute("SUM(������)", "")), "C"))
            Else
                Me.tsslDolgItog.Visible = False
                Me.tsslTotalCost.Visible = False
                Me.dgTableData.DataSource = Nothing
                Me.dgTableData.Enabled = False
            End If

            Me.Cursor = Cursors.Default
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try
    End Sub
    
    Private Sub Castomize(dtData As Object)
        Try
            For Each colC As Object In Me.dgTableData.Columns   '��������� ��� �������� �� ������ ��������
                colC.visible = False
            Next

            For Each str As String In CType(KeySettings.GetValue("order1"), String).Split("/"c)
                Try
                    Me.dgTableData.Columns(str).Visible = True
                Catch ex As System.Exception
                End Try
            Next

            Me.dgTableData.Columns("costID").Visible = False '�������� ������ ������� � ��
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub

    Private Sub MyOplOrder() ' ������� ���������� ���� ��� ��� ���������� �������
        If NonQuery1ScalarString("Select dbo.[MyOrder](" & emplID & ") ") = True Then
            Me.tsbtnMyOplOrder.BackColor = Color.Red
        Else
            Me.tsbtnMyOplOrder.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub MyZavtraSdavat() ' ������� ���������� ���� ��� ��� � ������ ������ �������
        If NonQuery1ScalarString("Select dbo.[MyOrderNeGotov](" & emplID & ")") = True Then
            Me.tsbtnMyZavtraSdavat.BackColor = Color.Red
        Else
            Me.tsbtnMyZavtraSdavat.BackColor = Color.PaleGreen
        End If
    End Sub

#Region " ��������� ����� "
    Private Sub RowColor()
        Dim n%

        For n = 0 To (Me.dgTableData.Rows.Count - 1)
            Select Case Trim(Me.dgTableData("���������", n).Value.ToString)
                Case Is = "������"
                    Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Settings1.Default.colorStCost
                Case Is = "� ������"
                    Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Settings1.Default.colorStWork
                Case Is = "�����"
                    Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Settings1.Default.colorStGotov
                Case Is = "�����"
                    Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Settings1.Default.colorStVydan
            End Select

            Dim isExpress As String = dgTableData("���������", n).Value
            If (isExpress = "�������") Then
                Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Color.Coral
            End If

            Dim isDocumentHasError As Boolean = False
            If Not IsDBNull(dgTableData("������_�_���������", n).Value) Then
                isDocumentHasError = dgTableData("������_�_���������", n).Value
            End If
            If (isDocumentHasError) Then
                Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Color.IndianRed
            End If
        Next
    End Sub
#End Region

#Region " ������� ���� "
    Private Sub ����������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����������ToolStripMenuItem.Click
        ModeOrder(False)
    End Sub

    Private Sub ��������������ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������������ToolStripMenuItem1.Click
        SaveOrder()
    End Sub

    Private Sub ����������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����������ToolStripMenuItem.Click
        ModeOrder(True)
    End Sub

    Private Sub ��������Excel��������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������Excel��������������ToolStripMenuItem.Click
        ExportExcel()
    End Sub

    Private Sub ��������ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������ToolStripMenuItem1.Click
        Query()
    End Sub

    Private Sub �����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �����ToolStripMenuItem.Click
        ExitPerfect()
    End Sub

    Private Sub �������������ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles �������������ToolStripMenuItem1.Click
        modeEmplPayPen = 0
        ModCallForm.CallForm("������ � ������", 25, 3)
    End Sub

    Private Sub ����������������������ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����������������������ExcelToolStripMenuItem.Click
        ExportExcel()
    End Sub

    Private Sub ��������ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������ToolStripMenuItem1.Click
        ModCallForm.CallForm("�����������", 9, 3)
    End Sub

    Private Sub ������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ������������ToolStripMenuItem.Click
        ModCallForm.CallForm("������������ ���������", 34, 3)
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������������ToolStripMenuItem.Click
        ModCallForm.CallForm("�������������� �� ���� " & CStr(Now().Date), 33, 3)
    End Sub

    Private Sub tscmbServices_DropDownClosed(sender As Object, e As System.EventArgs) Handles tscmbServices.DropDownClosed
        CallCalc()
    End Sub

    Private Sub ���������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���������ToolStripMenuItem.Click
        ModCallForm.CallForm("Maper", 18, 3)
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������������ToolStripMenuItem.Click
        ModCallForm.CallForm("�������� ������ �������", 20, 3)
    End Sub

    Private Sub �����������ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �����������ToolStripMenuItem1.Click
        ModCallForm.CallForm("�����������", 19, 3)
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������������ToolStripMenuItem.Click
        CallConfigParam()
    End Sub

    Private Sub ���������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���������ToolStripMenuItem.Click
        ModCallForm.CallForm("�������", 4, 3)
    End Sub

    Private Sub ����������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����������ToolStripMenuItem.Click
        ModCallForm.CallForm("��������", 5, 3)
    End Sub

    Private Sub ����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����ToolStripMenuItem.Click
        ModCallForm.CallForm("����", 13, 3)
    End Sub

    Private Sub ��������������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������������������ToolStripMenuItem.Click
        spravSQL = "SELECT * FROM Reclama"
        ModCallForm.CallForm("�������", 1, 3)
    End Sub

    Private Sub ����������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����������ToolStripMenuItem.Click
        ModCallForm.CallForm("���������", 10, 3)
    End Sub

    Private Sub �����������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �����������������ToolStripMenuItem.Click
        Dim frmSelect As New frmDocFile

        frmSelect.ShowDialog()
    End Sub

    Private Sub tsbtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnUpdate.Click
        Me.Timer3.Stop()
        Me.Timer3.Interval = 180000
        Me.Timer3.Start()

        Query()
    End Sub

    Private Sub ���������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModCallForm.CallForm("", 4, 2)
    End Sub

    Private Sub �������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������ToolStripMenuItem.Click
        modeEmplPayPen = 1
        ModCallForm.CallForm("��� ������� �� ��������", 25, 3)
    End Sub

    Private Sub ���������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ���������ToolStripMenuItem.Click
        mode_deduction = True
        ModCallForm.CallForm("���������", 24, 3)
    End Sub

    Private Sub ������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ������������ToolStripMenuItem.Click
        Dim frmSelect As New frmDepartment
        frmSelect.ShowDialog()
    End Sub

    Private Sub �����������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �����������������ToolStripMenuItem.Click
        ModCallForm.CallForm("���������� �������", 27, 3)
    End Sub

    Private Sub ��ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ��ToolStripMenuItem.Click
        ModCallForm.CallForm("��� ������", 30, 3)
    End Sub

    Private Sub ���������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���������ToolStripMenuItem.Click
        spravSQL = "SELECT ID, name, description FROM Parameters"
        ModCallForm.CallForm("��������� � ���������", 1, 3)
    End Sub

    Private Sub �������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������������ToolStripMenuItem.Click
        modeEmplPayPen = 0

        ModCallForm.CallForm("������ � ������", 25, 3)
    End Sub
#End Region

    Private Sub dgTableData_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTableData.Sorted
        RowColor()
    End Sub

#Region " ����������� "
    Private Sub ����������������ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����������������ToolStripMenuItem1.Click
        spravSQL = "SELECT * FROM Units"
        ModCallForm.CallForm("������� ���������", 1, 3)
    End Sub

    Private Sub ������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ������������ToolStripMenuItem.Click
        spravSQL = "SELECT * FROM TypesKAgent"

        ModCallForm.CallForm("���� ������������", 1, 3)
    End Sub

    Private Sub �����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        spravSQL = "SELECT * FROM Offices"
        ModCallForm.CallForm("�����", 1, 3)
    End Sub
#End Region

#Region " ������� � Excel "
    Private Sub ExportExcel()
        If Me.dgTableData.RowCount = 0 Then
            Exit Sub
        End If
        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        Dim tmpDataSet As DataTable

        'Dim tmpDoc As frmDoc = Me.ActiveMdiChild
        tmpDataSet = CType(Me.dgTableData.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add

        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            .Range("B2").Value = forExcelcaption

            For iCol = 0 To tmpDataSet.Columns.Count - 1

                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgTableData.Columns(iCol).HeaderText.ToString

                For iRow = 0 To tmpDataSet.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    '.range.G=String 
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(dgTableData(iCol, iRow).Value), "", dgTableData(iCol, iRow).Value)
                Next iRow
                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")
    End Sub
#End Region

#Region " ������ ���� "
    Private Sub tsbtnNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNewOrder.Click
        Me.Timer3.Stop()
        Me.Timer3.Interval = 420000
        Me.Timer3.Start()
        Me.cmbOrganization.SelectedIndex = -1
        ModeOrder(False)
    End Sub

    Private Sub ModeOrder(mode As Boolean)

        Me.tsbtnNewOrder.Enabled = mode      'false - ������� ����� �����
        Me.����������ToolStripMenuItem.Enabled = mode
        Me.tsbtnFindOrder.Enabled = Not mode
        Me.����������ToolStripMenuItem.Enabled = Not mode

        Me.scCommonFindNew.Panel1Collapsed = Not mode
        Me.scCommonFindNew.Panel2Collapsed = mode

        '����18112014
        If Me.tlpFind.Visible = True Then '������������ ������ ������� �������
            Dim distance As Integer = Me.tlpFind.Size.Height + 14
            If (distance < 400) Then distance = 400
            SplitContainer1.SplitterDistance = distance
        Else
            Dim distance As Integer = Me.tlpNewOrder.Size.Height + 14
            If (distance < 400) Then distance = 400
            SplitContainer1.SplitterDistance = distance
            
        End If

        '   Me.cmbProd.DataSource = Nothing
        Me.txtFindCust.Focus()

        If mode = True Then
            Me.txtFindCust.Text = "��������"
        End If
    End Sub

    Private Sub tsbtnFindOrder_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnFindOrder.Click
        ModeOrder(True)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnKassa.Click
        Dim frmSelect As New FastReportForm()
        frmSelect.ShowDialog(Me)
    End Sub

    Private Sub tsbtnDocuments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDocuments.Click
        Me.Timer3.Stop()
        Me.Timer3.Interval = 180000
        Me.Timer3.Start()

        Dim frmSelect As frmDocOut = New frmDocOut
        frmSelect.cmbAddressee.Enabled = True

        frmSelect.tsbtnNewCost.Visible = False
        frmSelect.cmbOrganization.Visible = False
        frmSelect.cmbGruzPol.Visible = False
        frmSelect.Label4.Visible = False
        frmSelect.Label5.Visible = False
        frmSelect.txtGrounds.Visible = False
        '***
        frmSelect.tsbtnNewWOutOrder.Visible = True
        frmSelect.txtKA_find.Visible = True
        frmSelect.cmb_KA.Visible = True

        'frmSelect.cmsAllInvoices.Enabled = False
        frmSelect.Label1.Visible = False
        frmSelect.tsbtnVIntervale.Visible = True
        frmSelect.dtpDate2.Visible = True


        If emplID = 3 Or emplID = 1096 Then '1096
            frmSelect.tsbtnClosedPeriod.Visible = True
        Else
            frmSelect.tsbtnClosedPeriod.Visible = False
        End If


        frmSelect.ShowDialog()
    End Sub

    Private Sub tsbtnTasks_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnTasks.Click
        Dim frmSelect As New frmTasks : frmSelect.Show()
    End Sub

    Private Function Getinstalledsoftware() As String
        Dim Software As String = Nothing
        Dim SoftwareKey As String = "SOFTWARE\MICROSOFT\Windows\CurrentVersion\Uninstall"
        Using rk As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(SoftwareKey)

            For Each skName As String In rk.GetSubKeyNames
                Using sk As Microsoft.Win32.RegistryKey = rk.OpenSubKey(skName)
                    Try

                        ' If Not (sk.GetValue("DisplayName") Is Nothing) Then
                        If sk.GetValue("DisplayName") = "Perfect-ERP" Then
                            If sk.GetValue("InstallLocation") Is Nothing Then
                                Software += sk.GetValue("DisplayName") & " - Install path not know" & vbLf
                            Else
                                Software += sk.GetValue("DisplayName") & "-" + sk.GetValue("InstallLocation") + sk.GetValue("DisplayVersion") '& Environment.NewLine
                            End If

                            'Software += (sk.GetValue("DisplayName") & "-") '+ sk.GetValue("Version")) ' & Environment.NewLine
                        End If
                        ' End If
                    Catch ex As System.Exception
                    End Try
                End Using
            Next
        End Using
        Return Software
    End Function
#End Region

    '************************************************************************** 

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)
    'bVk - ����������� ��� ������� ��� �������� ������� � ���������� �������.
    'bScan - ��������������� -- ����������� � 0.
    'dwFlags - ���������� ��������� ������ ���������� ��������� ������� ��������:
    'KEYEVENTF_EXTENDEDKEY - ������� ����-���� � ���������� ������, ������� �������� &HE0.
    'KEYEVENTF_KEYUP - �������, ��������� � bVk ����� ��������. ���� ���� ������ �� ���������, ������� ����� ������.
    'dwExtraInfo - �������������� 32-��������� ��������, ��������� � �������� ����������.

    ' KEYEVENTF_KEYUP = &H2 '������� ���������� �������
    ' VK_ADD = &H6B  '������� +
    ' VK_CONTROL = &H11 '������� Ctrl
    ' VK_TAB = &H9 '������� Tab
    ' VK_MENU = &H12  '������� Alt
    Dim VK_ESCAPE As Byte = &H1B '������� Escape

    'VK_LWIN = &H5B '����� �������, ����������� ������� ������ ����

    Private Sub ShowStartMenu()
        '������� ��������� �������  Esc
        'Call keybd_event(VK_CONTROL, 0, 0, 0) 'H������� Ctrl
        Call keybd_event(VK_ESCAPE, 0, 0, 0) 'H������� Esc
        ' Call keybd_event(VK_ESCAPE, 0, KEYEVENTF_KEYUP, 0) '��������� Esc
        ' Call keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0) '��������� Ctrl
    End Sub

    Private Sub ������ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ������ToolStripMenuItem1.Click
        ModCallForm.CallForm("������", 2, 3)
    End Sub

    Private Sub tsbtnMyOplOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnMyOplOrder.Click
        Me.chkDataPeriod.Checked = False
        Me.chkFindNomer.Checked = False
        Me.chkDataOut.Checked = False
        Me.chkMan.Checked = True
        Me.cmbManager.SelectedValue = emplID

        Me.chkMaketOut.Checked = False
        Me.chkDesignerFind.Checked = False

        Me.chkCustForSearh.Checked = False
        Me.chkPredoplata.Checked = True
        Me.chkPredoplata.Visible = True
        Me.cmbPredoplata.SelectedIndex = 1

        Dim i%

        For i = 0 To Me.clbCondition.Items.Count - 1
            If i = 0 Then
                Me.clbCondition.SetItemChecked(i, 1)
            Else
                Me.clbCondition.SetItemChecked(i, 0)
            End If
        Next
        Me.chkStatus.Checked = True

        Query()
        MyOplOrder()
    End Sub

    Private Sub tsbtnMyZavtraSdavat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnMyZavtraSdavat.Click
        Me.chkDataPeriod.Checked = False
        Me.chkFindNomer.Checked = False
        Me.chkDataOut.Checked = True
        Me.dtpDataVydahi.Value = Now().AddDays(1)
        Me.chkMan.Checked = True
        Me.cmbManager.SelectedValue = emplID
        Me.chkMaketOut.Checked = False

        If Me.chkDesignerFind.Enabled = False Then
            Me.chkDesignerFind.Checked = True
        Else
            Me.chkDesignerFind.Checked = False
        End If


        Me.chkCustForSearh.Checked = False
        Me.chkPredoplata.Checked = False

        Dim i%

        For i = 0 To Me.clbCondition.Items.Count - 1
            If i = 1 Then
                Me.clbCondition.SetItemChecked(i, 1)
            Else
                Me.clbCondition.SetItemChecked(i, 0)
            End If
        Next

        Query()
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��������������ToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="��������� �����?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                costID = retryOrder()

                ' MsgBox("������ ������ ��������. ����� ����� �������� � ��������� ������. ��� ������ � ��� ���������� � ������� ��������� ��������� ������� ������.", MsgBoxStyle.Information, appName)
                Select Case MsgBox(Prompt:="������ ������ ��������. ����� ����� �������� � ��������� ������. ���������� � ������ � �������?", Buttons:=vbYesNo, Title:=appName)
                    Case Is = vbYes

                        ModCallForm.CallForm("", 11, 3)

                    Case Is = vbNo
                        Exit Sub
                End Select
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Function retryOrder() As Integer
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_Retry"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int)) '��������� ���������
            cmd.Parameters("@costID").Value = Me.dgTableData(0, Me.dgTableData.CurrentRow.Index).Value()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
            cmd.Parameters("@emplID").Value = emplID
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ofID", SqlDbType.Int))
            cmd.Parameters("@ofID").Value = ofID

            mcnnInt.Open()

            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Private Sub �����������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �����������������ToolStripMenuItem.Click
        ModCallForm.CallForm("���� � ����������� ���������", 31, 3)
    End Sub

    Dim allowTask As Boolean = False

#Region " �������� ����� "
    Private Sub LoadMeTasks()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_Tasks_My"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
        cmd.Parameters("@emplID").Value = emplID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtTasks As New DataTable : objDA.Fill(dtTasks)

        Me.dgTasks.DataSource = dtTasks
        Me.dgTasks.ClearSelection()

        Try
            For n As Integer = 0 To Me.dgTasks.ColumnCount - 1
                If Me.dgTasks.Columns(n).Name = "ID" Then
                    Me.dgTasks.Columns("ID").Visible = False
                End If

                If Me.dgTasks.Columns(n).Name = "costID" Then
                    Me.dgTasks.Columns("costID").Visible = False '�������� ������� � ��
                End If

                If Me.dgTasks.Columns(n).Name = "�����������" Then
                    Me.dgTasks.Columns("�����������").Visible = False '�������� ������� � ��
                End If
            Next
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try

        allowTask = True
        '������ ���� �������� �����
        Dim objDA1 As SqlClient.SqlDataAdapter
        Dim cmd1 As New SqlClient.SqlCommand

        cmd1.Connection = mcnnInt
        cmd1.CommandText = "sp_Tasks_My1"
        cmd1.CommandType = CommandType.StoredProcedure

        cmd1.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
        cmd1.Parameters("@emplID").Value = emplID

        objDA1 = New SqlClient.SqlDataAdapter(cmd1)

        Dim dtTasks1 As New DataTable : objDA1.Fill(dtTasks1)

        Me.dgTasks1.DataSource = dtTasks1
        Me.dgTasks1.ClearSelection()

        Try
            For n As Integer = 0 To Me.dgTasks1.ColumnCount - 1
                If Me.dgTasks1.Columns(n).Name = "ID" Then
                    Me.dgTasks1.Columns("ID").Visible = False
                End If

                If Me.dgTasks1.Columns(n).Name = "costID" Then
                    Me.dgTasks1.Columns("costID").Visible = False '�������� ������� � ��
                End If

                If Me.dgTasks1.Columns(n).Name = "�����" Then
                    Me.dgTasks1.Columns("�����").Visible = False '�������� ������� � ��
                End If
            Next
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try
    End Sub
#End Region

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LoadMeTasks()
    End Sub

    Dim TopN As Integer

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        '����������� ���������
        TopN = Form2.Top
        If TopN > TopA Then
            Form2.Top -= 4
        End If
    End Sub

    Private Sub tsbtnRegInvoice_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnRegInvoice.Click
        costID = Nothing

        ModCallForm.CallForm("���� �� ������", 28, 3)
    End Sub

    Private Sub btnUpdateTask_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateTask.Click
        LoadMeTasks()
    End Sub

    Private Sub ���������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ���������ToolStripMenuItem.Click
        Module1.NonQuery1("UPDATE Tasks SET statusID=4, dateFinish=getdate() WHERE ID=" & Me.dgTasks("ID", Me.dgTasks.CurrentRow.Index).Value() & "")
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ��������������ToolStripMenuItem.Click
        Try
            If Me.dgTasks.SelectedRows.Count <> 1 Then
                MsgBox("�� ������� ������", MsgBoxStyle.Critical, appName)
            Else
                costID = Me.dgTasks("costID", Me.dgTasks.CurrentRow.Index).Value()

                ModCallForm.CallForm("", 11, 3)
            End If
        Catch ex As System.Exception
            MsgBox("��� ������ �� ����� ����� � �������.", MsgBoxStyle.Critical, appName) : Exit Sub
        End Try
    End Sub

    Private Sub �������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������������������ToolStripMenuItem.Click
        spravSQL = "SELECT * FROM TypesTransport"

        ModCallForm.CallForm("���� ���������������", 1, 3)
    End Sub

#Region " ��������� ������ "
    Private Sub txtFindCust_DoubleClick(sender As Object, e As System.EventArgs) Handles txtFindCust.DoubleClick
        Me.txtFindCust.Text = ""
        LoadCustomers(1, "")
    End Sub

    Private Sub txtFindCust_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFindCust.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadCustomers(1, Me.txtFindCust.Text)
            Me.cmbCustomer.Focus()
        End If

        e.Handled = True
    End Sub

    Private Sub txtFindCust_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFindCust.TextChanged
        If Me.txtFindCust.Visible = True Then
            LoadCustomers(1, Me.txtFindCust.Text)
        End If
    End Sub
#End Region

#Region " �������� ������� "
    Private Sub chkCustForSearh_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCustForSearh.CheckedChanged
        Me.txtCustForSearh.ReadOnly = Not sender.Checked
        Me.cmbCustForSearh.Enabled = sender.Checked
        Me.chkPerson.Enabled = sender.Checked

        If Me.chkCustForSearh.Checked = False Then
            Me.chkPerson.Checked = False
            Me.cmbCustForSearh.SelectedIndex = -1
        Else
            Me.txtCustForSearh.Focus()
        End If
    End Sub

    Private Sub cmbCustForSearh_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbCustForSearh.SelectedValueChanged
        If Me.cmbCustForSearh.SelectedIndex <> -1 Then
            Try
                Select Case Me.cmbSelectRel.SelectedIndex
                    Case Is = 0 '������������
                        Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT emplCustID, lastName FROM EmplCust WHERE custID=" & Me.cmbCustForSearh.SelectedItem(0) & " order by lastName", mcnnInt)
                        Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

                        Me.cmbPerson.DataSource = dtPartList
                        Me.cmbPerson.DisplayMember = "lastName"
                        Me.cmbPerson.ValueMember = "emplCustID"

                    Case Is = 1 '��.����
                        Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE custID=" & Me.cmbCustForSearh.SelectedItem(0) & " order by shortName", mcnnInt)
                        Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

                        Me.cmbPerson.DataSource = dtPartList
                        Me.cmbPerson.DisplayMember = "Name"
                        Me.cmbPerson.ValueMember = "custID"
                End Select

            Catch oexpData As System.Exception
                MsgBox("�������� ������������-" + oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub cmbSelectRel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectRel.SelectedIndexChanged
        If Me.cmbCustForSearh.SelectedIndex <> -1 Then
            Try
                Select Case Me.cmbSelectRel.SelectedIndex
                    Case Is = 0 '������������
                        Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT emplCustID, lastName FROM EmplCust WHERE custID = " & Me.cmbCustForSearh.SelectedItem(0) & " order by lastName", mcnnInt)
                        Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

                        Me.cmbPerson.DataSource = dtPartList
                        Me.cmbPerson.DisplayMember = "lastName"
                        Me.cmbPerson.ValueMember = "emplCustID"

                    Case Is = 1 '��.����
                        Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE KAgent_ID = " & Me.cmbCustForSearh.SelectedItem(0) & " order by Name", mcnnInt)
                        Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

                        Me.cmbPerson.DataSource = dtPartList
                        Me.cmbPerson.DisplayMember = "Name"
                        Me.cmbPerson.ValueMember = "custID"
                End Select
            Catch oexpData As System.Exception
                MsgBox("�������� ������������-" + oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub chkPredoplata_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPredoplata.CheckedChanged
        Me.cmbPredoplata.Enabled = Me.chkPredoplata.Checked

        If Me.cmbPredoplata.SelectedIndex = -1 Then
            Me.cmbPredoplata.SelectedIndex = 0
        End If
    End Sub

    Private Sub chkMan_EnabledChanged(sender As Object, e As System.EventArgs) Handles chkMan.EnabledChanged
        Me.cmbManager.Enabled = Me.chkMan.Enabled
    End Sub

    Private Sub chkPerson_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPerson.CheckedChanged
        Me.cmbPerson.Enabled = Me.chkPerson.Checked
        Me.cmbSelectRel.Enabled = Me.chkPerson.Checked
    End Sub

    Private Sub chkDataPeriod_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDataPeriod.CheckedChanged
        Me.dtpOrder1.Enabled = sender.checked
        Me.dtpOrder2.Enabled = sender.checked

        If sender.checked = True Then
            Me.dtpOrder1.Value = CDate("01.01." & Now.Year.ToString)
            Me.dtpOrder2.Value = Now().Date
        End If
    End Sub

    Private Sub chkMan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMan.CheckedChanged
        Me.cmbManager.Enabled = Me.chkMan.Checked
    End Sub

    Private Sub txtCustForSearh_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustForSearh.KeyDown
        If e.KeyCode = Keys.Enter Then Query()
        e.Handled = True
    End Sub

    Private Sub txtCustForSearh_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCustForSearh.MouseClick
        Me.chkCustForSearh.Checked = True
    End Sub

    Private Sub txtCustForSearh_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCustForSearh.TextChanged
        LoadCustomers(2, Me.txtCustForSearh.Text)
    End Sub

    Private Sub chkDataOut_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDataOut.CheckedChanged
        Me.dtpDataVydahi.Enabled = Me.chkDataOut.Checked
        Me.cmbDataVydahi.Enabled = Me.chkDataOut.Checked
    End Sub

    Private Sub chkMaketOut_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMaketOut.CheckedChanged
        Me.dtpMaket.Enabled = Me.chkMaketOut.Checked
        Me.cmbMaket.Enabled = Me.chkMaketOut.Checked
    End Sub

    Private Sub chkFindNomer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFindNomer.CheckedChanged
        Me.txtFind.ReadOnly = Not Me.chkFindNomer.Checked

        If sender.checked = True Then
            Me.txtFind.Focus()

            Dim c As Object

            For Each c In Me.tlpFind.Controls
                If TypeOf c Is CheckBox Then '�������� ������ ��� ��������
                    If c.Name <> sender.name And c.Name <> "chkDataPeriod" Then '��� ������ ���� ������� ����������
                        If c.Name <> "chkDesignerFind" And c.enabled <> False Then '��� ������ ���� ������� ����������
                            If c.Name <> "chkMan" And c.enabled <> False Then '��� ������ ���� ������� ����������
                                c.checked = False
                            End If
                        End If
                    End If
                End If
            Next

            For i As Integer = 0 To Me.clbCondition.Items.Count - 1
                Me.clbCondition.SetItemChecked(i, True)
            Next
        Else
            For i As Integer = 0 To Me.clbCondition.Items.Count - 1
                Me.clbCondition.SetItemChecked(i, False)
            Next
        End If

        Me.txtFind.Clear()
    End Sub

    Private Sub chkDesignerFind_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDesignerFind.CheckedChanged
        Me.cmbDesignerFind.Enabled = sender.Checked
    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then Query()
        e.Handled = True
    End Sub

    Private Sub chkOrderClosed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOrderClosed.CheckedChanged
        Me.dtpOrderClosed1.Enabled = sender.checked
        Me.dtpOrderClosed2.Enabled = sender.checked
    End Sub
#End Region

    Private Sub btnSaveOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveOrder.Click


        SaveOrder()
    End Sub

    Private Sub CallCalc()
        If serviceLoading = True Then
            If Me.tscmbServices.SelectedIndex = -1 Then
                Exit Sub
            Else
                serviceID = Me.tscmbServices.ComboBox.SelectedItem(0) ' ����� ������� -�� ��������!!!
                costID = 0
                ModCallForm.CallForm(Me.tscmbServices.ComboBox.Text, CInt(dsServices.Tables("Services").Rows.Find(serviceID)("formCostNumber")), 1)
            End If
        End If
    End Sub

    Private Sub cmbOrganization_VisibleChanged(sender As Object, e As System.EventArgs) Handles cmbOrganization.VisibleChanged
        Me.lbOrganization.Visible = sender.visible
    End Sub

    Private Sub �������������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If sender.Checked = True Then
            sender.Checked = False
            sender.text = "�������� ����� ��������� ���"
        Else
            sender.Checked = True
            sender.text = "��������� ����� ��������� ���"
        End If
    End Sub

    Private Sub ��������������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ��������������������������ToolStripMenuItem.Click
        ModCallForm.CallForm("", 16, 3)
    End Sub

    Private Sub ���������������ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ���������������ToolStripMenuItem1.Click
        ModCallForm.CallForm("�������� �������", 21, 3)
    End Sub

    Private Sub btnKAsave_Click(sender As System.Object, e As System.EventArgs) Handles btnKAsave.Click
        Module1.NonQuery1("INSERT INTO KAgents (otvManager_emplID, type_ID, name, tel, kamID) VALUES (" & emplID & ",2,'" & Replace(Me.txtKAname.Text, "'", " ` ") & "','" & Me.txtKAtel.Text & "'," & emplID & ")")

        newKA(False)

        LoadCustomers(3, "") '��������� ����� � ������������ ���������
    End Sub

    Private Sub btnKAcancel_Click(sender As System.Object, e As System.EventArgs) Handles btnKAcancel.Click
        newKA(False)

        Me.txtFindCust.Focus()
    End Sub

    Private Sub ���������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ���������������ToolStripMenuItem.Click
        If Me.cmbCustomer.SelectedIndex <> -1 Then

            Dim frmSelect As frmEmplKA

            custID = Me.cmbCustomer.SelectedItem(0)
            frmSelect = New frmEmplKA
            frmSelect.ShowDialog()
        Else
            MsgBox("�� ������ ����������.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub ����������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ����������������������ToolStripMenuItem.Click
        mode_deduction = False
        ModCallForm.CallForm("������� �����������", 24, 3)
    End Sub

    Private Sub ����������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ����������������������ToolStripMenuItem.Click
        ModCallForm.CallForm("�������������� ����������", 35, 3)
    End Sub

    Private Sub ����������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ����������������ToolStripMenuItem.Click
        ModCallForm.CallForm("���������� ������", 36, 3)
    End Sub

    Private Sub �������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������������������ToolStripMenuItem.Click
        spravSQL = "SELECT * FROM fin_ClassifierExpenses"
        ModCallForm.CallForm("������������� ������", 1, 3)
    End Sub

    Private Sub ������������ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ������������ToolStripMenuItem1.Click
        ModCallForm.CallForm("������ ������", 23, 3)
    End Sub

    Private Sub dgTasks1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTasks1.CellContentDoubleClick
        Try
            taskID = Me.dgTasks1("ID", Me.dgTasks1.SelectedRows.Item(0).Index).Value()  'Me.dgTasks1(1, Me.dgTasks1.SelectedRows.Index).Value()

            Dim frmSelect As New frmTaskCard

            frmSelect.ShowDialog()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName) : Exit Sub
        End Try
    End Sub

    Private Sub ��������������ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ��������������ToolStripMenuItem1.Click
        If Me.dgTasks1.SelectedRows.Count = 0 Then
            MsgBox("�� ������� ������", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        Try
            costID = Me.dgTasks1("costID", Me.dgTasks1.CurrentRow.Index).Value()
        Catch ex As System.Exception
            MsgBox("��� ������ �� ����� ����� � �������.", MsgBoxStyle.Critical, appName) : Exit Sub
        End Try

        ModCallForm.CallForm("", 11, 3)
    End Sub

    Private Sub �������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������������ToolStripMenuItem.Click
        If Me.dgTasks1.SelectedRows.Count = 0 Then
            MsgBox("�� ������� ������", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        createTask = False

        Try
            taskID = Me.dgTasks1("ID", Me.dgTasks1.CurrentRow.Index).Value()

            Dim frmSelect As New frmTaskCard
            frmSelect.ShowDialog()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName) : Exit Sub
        End Try
    End Sub

    Private Sub ������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ������������������ToolStripMenuItem.Click
        spravSQL = "SELECT * FROM fin_WageSystem"

        ModCallForm.CallForm("������� ������ �����", 1, 3)
    End Sub

    Private Sub ���������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ���������������������ToolStripMenuItem.Click
        If Me.dgTasks1.SelectedRows.Count = 0 Then
            MsgBox("�� ������� ������", MsgBoxStyle.Critical, appName) : Exit Sub
        Else
            Module1.NonQuery1("UPDATE Tasks SET valid=1 WHERE ID=" & Me.dgTasks1("ID", Me.dgTasks1.CurrentRow.Index).Value() & "")
        End If
    End Sub

    Private Sub �������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������������ToolStripMenuItem.Click
        createTask = True

        Dim frmSelect As New frmTaskCard
        frmSelect.ShowDialog()
    End Sub

    Private Sub �������������ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles �������������ToolStripMenuItem1.Click
        If Me.dgTasks.SelectedRows.Count = 0 Then
            MsgBox("�� ������� ������", MsgBoxStyle.Critical, appName)
        Else
            createTask = False

            Try
                taskID = Me.dgTasks("ID", Me.dgTasks.CurrentRow.Index).Value()

                Dim frmSelect As New frmTaskCard
                frmSelect.ShowDialog()
            Catch ex As System.Exception
                MessageBox.Show(ex.Message, appName) : Exit Sub
            End Try
        End If
    End Sub

    Private Sub �������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������ToolStripMenuItem.Click
        Dim frmSelect As New tech_EmplEquip
        frmSelect.ShowDialog()
    End Sub

    Private Sub chkStatus_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkStatus.CheckedChanged
        Me.clbCondition.Enabled = sender.checked
    End Sub

    Private Sub ������������ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ������������ToolStripMenuItem1.Click
        Dim frmSelect As New frmConfigTechOper
        frmSelect.ShowDialog()
    End Sub

    Private Sub GanterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GanterToolStripMenuItem.Click
        Process.Start(paramUrlGanter)
    End Sub

    Private Sub �����������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �����������ToolStripMenuItem.Click
        Dim frmSelect As New tech_DressOrders
        frmSelect.ShowDialog()
    End Sub

    Private Sub ���������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ���������ToolStripMenuItem.Click
        Dim frmSelect As New Calendar
        frmSelect.ShowDialog()
    End Sub

    Private Sub �����������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �����������������������ToolStripMenuItem.Click
        newKA(True)
    End Sub

    Private Sub newKA(ByVal allow As Boolean)
        For Each c As Control In Me.tlpNewOrder.Controls
            If TypeOf c Is LinkLabel Then
            Else
                If c.Tag = "newKA" Then
                    c.Visible = allow
                Else
                    c.Visible = Not allow '���������� ��� ���� ����� ���, ��� ��� ����� ������ ��
                End If
            End If

            If c.Tag = "777" Then
                c.Visible = False
            End If
        Next

        If allow = False Then


            '   Me.cmbMarketing.Visible = oprosOnOff
            '   Me.lbReclama.Visible = oprosOnOff
            Me.cmbOrganization.Visible = organizationVisible
        End If
    End Sub

    Private Sub chkReclama_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkReclama.CheckedChanged
        Me.cmbReclama.Enabled = Me.chkReclama.Checked
    End Sub

    Private Sub tscmbServices_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tscmbServices.KeyDown
        If e.KeyCode = Keys.Enter And Me.tscmbServices.DroppedDown = False Then
            CallCalc()
        End If
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ��������������ToolStripMenuItem.Click
        If kassaAllow = True Then
            If Me.dgTableData("���������", Me.dgTableData.CurrentRow.Index).Value() = 0 Then
                MsgBox("��������� ������ �� ����������", MsgBoxStyle.Critical, appName) : Exit Sub
            Else
                costID = Me.dgTableData(0, Me.dgTableData.CurrentRow.Index).Value()
                custID = Module1.NonQueryScalarInt("SELECT custID FROM Costs WHERE costID=" & Me.dgTableData(0, Me.dgTableData.CurrentRow.Index).Value() & "")

                ModCallForm.CallForm("������ ������", 29, 3)

                Query()
            End If
        Else
            MsgBox("���������� ����� ������ �� ���������.", MsgBoxStyle.Critical, appName) : Exit Sub
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If depID = 5 Or depID = 12 Then
            Dim frmSelect As New frmTimerExit

            frmSelect.ShowDialog()
        End If
    End Sub

    Private Sub chkOrg_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOrg.CheckedChanged
        Me.cmbOrg.Enabled = sender.checked
    End Sub

    Private Sub tlpFind_SizeChanged(sender As Object, e As EventArgs) Handles tlpFind.SizeChanged
        If split1Moved = False Then
            Me.SplitContainer1.SplitterDistance = Me.tlpFind.Size.Height + 14
        End If
    End Sub

    Private Sub ����������������SMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ����������������SMSToolStripMenuItem.Click
        Dim frmSelect As New frmSMSsender
        frmSelect.ShowDialog()
    End Sub

    Private Sub chkDesignerFind_EnabledChanged(sender As Object, e As EventArgs) Handles chkDesignerFind.EnabledChanged
        Me.cmbDesignerFind.Enabled = sender.enabled
    End Sub

    Private Sub �������������ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles �������������ToolStripMenuItem1.Click
        ModCallForm.CallForm("������", 15, 3)
    End Sub

    Private Sub ����������������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ����������������������ToolStripMenuItem.Click
        ModCallForm.CallForm("��������� ��������� ��� �� ��������", 40, 3)
    End Sub

    Private Sub ���������ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ���������ToolStripMenuItem1.Click
        Dim frmSelect As New fin_Analitics
        frmSelect.ShowDialog()
    End Sub

    Private Sub �����������������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles �����������������������ToolStripMenuItem.Click
        costID = Nothing

        ModCallForm.CallForm("������ �� ��������", 17, 3)
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        split1Moved = True
    End Sub

    Private Sub ���������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ���������������ToolStripMenuItem.Click
        Dim frmSelect As New frmDesTemp
        frmSelect.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles tsbtnKassa2.Click
        Dim frmSelect As New fin_KassOper
        frmSelect.ShowDialog()
    End Sub

    Private Sub �����������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles �����������ToolStripMenuItem.Click
        ModCallForm.CallForm("��������", 7, 3)
    End Sub

    Private Sub ���������������ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ���������������ToolStripMenuItem1.Click
        Dim frmSelect As New frmMatFormats
        frmSelect.ShowDialog()
    End Sub

    Private Sub ������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ������������ToolStripMenuItem.Click
        spravSQL = "SELECT * FROM Units"
        ModCallForm.CallForm("������� ���������", 1, 3)
    End Sub

    Private Sub �����������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles �����������������ToolStripMenuItem.Click
        Dim frmSelect As New frmMatFormatInOut
        frmSelect.ShowDialog()
    End Sub

    Private Sub ������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ������������ToolStripMenuItem.Click
        Dim frmSelect As New tech_Equipment

        frmSelect.ShowDialog()
    End Sub

    Private Sub ��������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ��������ToolStripMenuItem.Click
        Dim frmSelect As New tech_OperParam

        frmSelect.ShowDialog()
    End Sub

    Private Sub ������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ������������ToolStripMenuItem.Click
        Dim form As New frmSklad

        form.ShowDialog()
    End Sub

    Private Sub txtFind_MouseClick(sender As Object, e As MouseEventArgs) Handles txtFind.MouseClick
        Me.chkFindNomer.Checked = True
    End Sub

    Private Sub �����������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles �����������ToolStripMenuItem.Click
        spravSQL = "SELECT * FROM awc_Discont"

        ModCallForm.CallForm("����� ������", 1, 3)
    End Sub
    
    Private Sub tstxtContextFind_KeyDown(sender As Object, e As KeyEventArgs) Handles tstxtContextFind.KeyDown
        If e.KeyCode = Keys.Enter And Me.tstxtContextFind.Text <> Nothing Then
            Query()
        End If
    End Sub

    Private Sub ������������ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ������������ToolStripMenuItem1.Click
        Dim frmSelect As New frmCustomize
        frmSelect.ShowDialog()
    End Sub

    Private Sub TransDataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransDataToolStripMenuItem1.Click
        ModCallForm.CallForm("���������", 37, 3)
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ��������������ToolStripMenuItem.Click
        spravSQL = "SELECT * FROM MatGroups"
        ModCallForm.CallForm("������ ����������", 1, 3)
    End Sub

    Private Sub cmbDataVydahi_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbDataVydahi.MouseClick
        Me.chkDataOut.Checked = True
    End Sub

    Private Sub ������������777ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ������������777ToolStripMenuItem.Click
        serviceID = 1144

        Dim frmSelect As New c_777config
        frmSelect.ShowDialog()
    End Sub

    Private Sub ���������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ���������������ToolStripMenuItem.Click
        serviceID = 1166

        ModCallForm.CallForm("������� �����", 77, 1)
    End Sub

    Private Sub tsbtnFastOrder_Click(sender As Object, e As EventArgs) Handles tsbtnFastOrder.Click
        serviceID = 1166

        ModCallForm.CallForm("������� �����", 178, 1)
    End Sub

    Private Sub �����ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles �����ToolStripMenuItem1.Click
        ExitPerfect()
    End Sub

    Private Sub tsbtnClaimAndOffers_Click(sender As Object, e As EventArgs) Handles tsbtnClaimAndOffers.Click
        ModCallForm.CallForm("https://goo.gl/forms/aAIni9KLgiYvc7Ho1", 39, 3)
    End Sub

    Private Sub FRDirectoryMenuItem_Click(sender As Object, e As EventArgs) Handles FRDirectoryMenuItem.Click
        Dim frDirectoryForm As FRDirectoryForm
        frDirectoryForm = New FRDirectoryForm()
        frDirectoryForm.ShowDialog(Me)
    End Sub

    Private Sub FRSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FRSetupToolStripMenuItem.Click
        Dim frSetupForm As FRSetupForm
        frSetupForm = New FRSetupForm()
        frSetupForm.ShowDialog(Me)
    End Sub

    Private Sub ShowMoneyInCassaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMoneyInCassaButton.Click
        TopA = (ScreenH - Form2.Height)
        Form2.Left = (ScreenW - Form2.Width)
        Form2.Top = ScreenH
        Form2.Show()
        Timer2.Start()

        Dim cassa As CassaHelper = Nothing
        Dim cash As Decimal
        Try
            Dim connectToFr As Boolean = KeySettings.GetValue("connectToFR")
            If (Not connectToFr) Then
                cash = 0
            Else
                cassa = New CassaHelper()
                Dim port As Integer = CInt(KeySettings.GetValue("portKassa"))
                Dim password As Integer = CInt(KeySettings.GetValue("passKassa"))
                Dim ip As String = KeySettings.GetValue("IPkassa")
                Dim tcpCassa As Boolean = KeySettings.GetValue("tcpKassa")
                If (tcpCassa) Then
                    cassa.Connect(port,password, ip)
                Else 
                    cassa.Connect(port, password)
                End If
                cash = cassa.GetCash()
            End If
        Catch ex As Exception
            cash = 0
        Finally
            If (Not cassa Is Nothing) Then
                cassa.Disconnect()
            End If
        End Try
        
        Form2.Label1.Text = "������� ��������� �����: " & Chr(13) & cash
    End Sub

    Private Sub OfficeDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfficeDirectoryToolStripMenuItem.Click
        Dim officeDirectoryForm As OfficeDirectoryForm
        officeDirectoryForm = New OfficeDirectoryForm()
        officeDirectoryForm.ShowDialog(Me)
    End Sub

    Private Sub OperatorsPerformanceReportButton_Click(sender As Object, e As EventArgs) Handles OperatorsPerformanceReportButton.Click
        Dim operatorsPerformanceReportForm As OperatorsPerformanceReportForm
        operatorsPerformanceReportForm = New OperatorsPerformanceReportForm()
        operatorsPerformanceReportForm.Show()
    End Sub

    Private Sub ������������������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ������������������������ToolStripMenuItem.Click
        Dim onlinePaymentDirectoryForm As OnlinePaymentDirectoryForm
        onlinePaymentDirectoryForm = New OnlinePaymentDirectoryForm()
        onlinePaymentDirectoryForm.ShowDialog(Me)
    End Sub

    Private Sub chkShowDismissedManagers_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowDismissedManagers.CheckedChanged
        LoadManagers()
    End Sub

    Private Sub chkShowDismissedExecutors_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowDismissedExecutors.CheckedChanged
        LoadExecutors()
    End Sub

    Private Sub ����������������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ����������������������ToolStripMenuItem.Click
        Dim frm As ReportCoefficientsForm
        frm = New ReportCoefficientsForm()
        frm.ShowDialog(Me)
    End Sub

    Private Sub tstxtContextFind_LocationChanged(sender As Object, e As EventArgs) Handles tstxtContextFind.LocationChanged
        chkContextSearch.Location = New Point(tstxtContextFind.TextBox.Location.X + tstxtContextFind.Width + 6, chkContextSearch.Location.Y)
    End Sub

    Private Sub chkContextSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkContextSearch.CheckedChanged
        tstxtContextFind.Enabled = chkContextSearch.Checked
    End Sub

    Private Sub ManagersPerformanceReportButton_Click(sender As Object, e As EventArgs) Handles ManagersPerformanceReportButton.Click
        Dim managersPerformanceReportForm As ManagerPerformanceReportForm
        managersPerformanceReportForm = New ManagerPerformanceReportForm()
        managersPerformanceReportForm.Show()
    End Sub
End Class
