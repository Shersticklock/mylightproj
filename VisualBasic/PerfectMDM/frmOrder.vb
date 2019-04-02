Imports System.Math
Imports System.Data.SqlClient
Imports System.IO
Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader
Imports System.Net
Imports System.Security.AccessControl

Public Class frmOrder
    Inherits System.Windows.Forms.Form

    Dim modaLookupData As SqlClient.SqlDataAdapter
    Dim currentStatus%, emplIDcurrent%, emplIDexecute% ' долг, статус, менеджер и исполнитель текущего заказа
    Dim dsTZ As New DSTZ
    Dim dsFiles As New DS_FilesOrder

    Dim modaTZ As SqlClient.SqlDataAdapter
    Dim mdrOrderIndiv As DataRow
    Dim dtCost As DataTable 'содержание заказа

    Dim allowStatusChange As Boolean 'разрешение реакции на событие изменения состояния
    Dim dsServices As New DataSet 'набор данных для вызова расчетных форм                     
    Dim allow As Boolean 'определяет реагировать ли на активацию
    'Dim onlyCostOrder As Boolean 'переменная, отвечающая за возможность выписки документов

    Dim NehvatkaMat$
    Dim modeAddFile As Integer ' 1- доб файл в файлах заказа, 2- добавляется счет
    Dim savePathTTT As String
    Dim avarExit As Boolean = False
    Dim avansRealOrder As Integer

    Dim orderClosed As Boolean
    Dim orderCancelled As Boolean

    Private Const BlockSize = 32768

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ЗаказToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РедактироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tscmbServices As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tlpCommonParam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslOrderCost As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslOplacheno As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsSLDolgi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tsControl As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnPrintTZ As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDocuments As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnInputPay As System.Windows.Forms.ToolStripButton
    Friend WithEvents tscmbStatus As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsSpec As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents УдалитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmsTasks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents НоваяЗадачаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьЗадачиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tscmbDoc As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslOpenClose As System.Windows.Forms.ToolStripLabel
    Public WithEvents dsEmplWork As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents percent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tpMaterial As System.Windows.Forms.TabPage
    Friend WithEvents tpDelivery As System.Windows.Forms.TabPage
    Friend WithEvents tlpDelivery As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip6 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnUpdateDostavka As System.Windows.Forms.ToolStripButton
    Friend WithEvents tpRout As System.Windows.Forms.TabPage
    Friend WithEvents tlpRouting As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEmplRout As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnRoutApply As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelRout As System.Windows.Forms.ToolStripButton
    Friend WithEvents tpTasks As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgTasks As System.Windows.Forms.DataGridView
    Friend WithEvents tsTasks As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNewTask As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnTask As System.Windows.Forms.ToolStripButton
    Friend WithEvents tscmbDep As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tscmbExecutor As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbtnNewExec As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnTaskFinish As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnTaskDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tpExpenses As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgExpensesOrder As System.Windows.Forms.DataGridView
    Friend WithEvents tsExpenses As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnAddExpens As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnDelExpens As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnAddFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnOpenFileInv As System.Windows.Forms.ToolStripButton
    Friend WithEvents tpPayments As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlsPayment As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnDelPay As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgPay As System.Windows.Forms.DataGridView
    Friend WithEvents tpPurpose As System.Windows.Forms.TabPage
    Friend WithEvents tlpDescription As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtprim As System.Windows.Forms.TextBox
    Friend WithEvents tsPrim As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tpFiles As System.Windows.Forms.TabPage
    Friend WithEvents tlpFiles As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgFiles As System.Windows.Forms.DataGridView
    Friend WithEvents tlsFiles As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnAddFileWork As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tscmbFileDescript As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbtnOpenFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnFileDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPbarCopyFiles As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tsbtnSaveFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents tpSpec As System.Windows.Forms.TabPage
    Friend WithEvents dgSpec As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents dgDostavka As System.Windows.Forms.DataGridView
    Friend WithEvents cmsFiles As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tscmbFiles As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents СохранитьОписаниеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ПовторитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbRoutDescription As System.Windows.Forms.ComboBox
    Friend WithEvents txtPurposeRout As System.Windows.Forms.TextBox
    Friend WithEvents КопироватьОписаниеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СкидкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tpDir As System.Windows.Forms.TabPage
    Friend WithEvents tlpPath As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents УдалитьВсеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPath1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPath1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPath2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPath3 As System.Windows.Forms.TextBox
    Friend WithEvents btnPath2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnPath3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog3 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents tsbtnSendSMS As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPrepress As System.Windows.Forms.TextBox
    Friend WithEvents tslblStatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Отсрочка1ДеньToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgMatExpens As System.Windows.Forms.DataGridView
    Friend WithEvents tsbtnRobokassa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsslKogdaVydan As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslBalansKA As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents РедактироватьToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents БракToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтказОтЗаказаToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПеределкаЗаказаToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РеализацияСПроизвольнойСкидкойToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgOrderRout As System.Windows.Forms.DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsbtnRobokassa1 As ToolStripButton
    Friend WithEvents cmbTemplateDes As System.Windows.Forms.ComboBox
    Friend WithEvents tpDocumentErrorReports As TabPage
    Friend WithEvents DocumentErrorRecords As DataGridView
    Friend WithEvents mdmprintPayButton As ToolStripButton
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents tslblAdditionalNumber As ToolStripTextBox
    Friend WithEvents tstxtAdditionalNumber As ToolStripTextBox
    Friend WithEvents tsbtnPrintLabel As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tslCanceledOrder As ToolStripLabel
    Friend WithEvents OrderClosedContextMenuStrip As ContextMenuStrip
    Friend WithEvents RevertCloseItem As ToolStripMenuItem
    Friend WithEvents OrderCancelledContextMenuStrip As ContextMenuStrip
    Friend WithEvents TimeGroupBox As GroupBox
    Friend WithEvents TimeTableLayoutPanel As TableLayoutPanel
    Friend WithEvents lblDateOfLayoutReady As Label
    Friend WithEvents lblDateOfProductionReady As Label
    Friend WithEvents lblDateOfIssue As Label
    Friend WithEvents lblPlannedExecutionDate As Label
    Friend WithEvents lblOrderIsExpress As Label
    Friend WithEvents dtpDateOfLayoutReady As DateTimePicker
    Friend WithEvents dtpDateOfProductionReady As DateTimePicker
    Friend WithEvents dtpDateOfIssue As DateTimePicker
    Friend WithEvents CustomerGroupBox As GroupBox
    Friend WithEvents CustomerTableLayoutPanel As TableLayoutPanel
    Friend WithEvents lblContractor As Label
    Friend WithEvents lblContactPerson As Label
    Friend WithEvents lblCustomerPhone1 As Label
    Friend WithEvents lblCustomerPhone2 As Label
    Friend WithEvents lblCustomerEmail As Label
    Friend WithEvents lblCustomerPerson As Label
    Friend WithEvents txtContractor As TextBox
    Friend WithEvents txtContactPerson As TextBox
    Friend WithEvents txtCustomerPhone1 As TextBox
    Friend WithEvents txtCustomerPhone2 As TextBox
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents txtCustomerPerson As TextBox
    Friend WithEvents ExecutorGroupBox As GroupBox
    Friend WithEvents ExecutorTableLayoutPanel As TableLayoutPanel
    Friend WithEvents lblManager As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblInternalNumber As Label
    Friend WithEvents lblExecutorEmail As Label
    Friend WithEvents lblExecutor As Label
    Friend WithEvents lblExecutorPerson As Label
    Friend WithEvents txtManager As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtInternalNumber As TextBox
    Friend WithEvents txtExecutorEmail As TextBox
    Friend WithEvents txtExecutor As TextBox
    Friend WithEvents txtExecutorPerson As TextBox
    Friend WithEvents ParametersGroupBox As GroupBox
    Friend WithEvents ParametersTableLayoutPanel As TableLayoutPanel
    Friend WithEvents lblOrderType As Label
    Friend WithEvents lblOrderSource As Label
    Friend WithEvents lblPaymentMethods As Label
    Friend WithEvents lblCommentForIssue As Label
    Friend WithEvents lblIssuePlace As Label
    Friend WithEvents chkDocumentHasError As CheckBox
    Friend WithEvents lblDocumentHasError As Label
    Friend WithEvents PaymentMethodsFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents chkNotDonePaymentMethod As CheckBox
    Friend WithEvents chkNonCashPaymentMethod As CheckBox
    Friend WithEvents chkCashPaymentMethod As CheckBox
    Friend WithEvents chkOnlinePaymentMethod As CheckBox
    Friend WithEvents lblIssuePlaceValue As Label
    Friend WithEvents txtCommentForIssue As TextBox
    Friend WithEvents txtOrderSource As TextBox
    Friend WithEvents txtOrderType As TextBox
    Friend WithEvents txtPlannedExecutionDate As TextBox
    Friend WithEvents CancelCostItem As ToolStripMenuItem
    Friend WithEvents tslblCostNumber As ToolStripTextBox
    Friend WithEvents tstxtCostNumber As ToolStripTextBox
    Friend WithEvents tsslLastRout As ToolStripStatusLabel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents RevertCancelledItem As ToolStripMenuItem

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tscmbServices = New System.Windows.Forms.ToolStripComboBox()
        Me.РедактироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.БракToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтказОтЗаказаToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПеределкаЗаказаToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.РеализацияСПроизвольнойСкидкойToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаказToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПовторитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СкидкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelCostItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tlpCommonParam = New System.Windows.Forms.TableLayoutPanel()
        Me.TimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.TimeTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDateOfLayoutReady = New System.Windows.Forms.Label()
        Me.lblDateOfProductionReady = New System.Windows.Forms.Label()
        Me.lblDateOfIssue = New System.Windows.Forms.Label()
        Me.lblPlannedExecutionDate = New System.Windows.Forms.Label()
        Me.lblOrderIsExpress = New System.Windows.Forms.Label()
        Me.dtpDateOfLayoutReady = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateOfProductionReady = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateOfIssue = New System.Windows.Forms.DateTimePicker()
        Me.txtPlannedExecutionDate = New System.Windows.Forms.TextBox()
        Me.CustomerGroupBox = New System.Windows.Forms.GroupBox()
        Me.CustomerTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblContractor = New System.Windows.Forms.Label()
        Me.lblContactPerson = New System.Windows.Forms.Label()
        Me.lblCustomerPhone1 = New System.Windows.Forms.Label()
        Me.lblCustomerPhone2 = New System.Windows.Forms.Label()
        Me.lblCustomerEmail = New System.Windows.Forms.Label()
        Me.lblCustomerPerson = New System.Windows.Forms.Label()
        Me.txtContractor = New System.Windows.Forms.TextBox()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhone1 = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhone2 = New System.Windows.Forms.TextBox()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.txtCustomerPerson = New System.Windows.Forms.TextBox()
        Me.ExecutorGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExecutorTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblManager = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblInternalNumber = New System.Windows.Forms.Label()
        Me.lblExecutorEmail = New System.Windows.Forms.Label()
        Me.lblExecutor = New System.Windows.Forms.Label()
        Me.lblExecutorPerson = New System.Windows.Forms.Label()
        Me.txtManager = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtInternalNumber = New System.Windows.Forms.TextBox()
        Me.txtExecutorEmail = New System.Windows.Forms.TextBox()
        Me.txtExecutor = New System.Windows.Forms.TextBox()
        Me.txtExecutorPerson = New System.Windows.Forms.TextBox()
        Me.ParametersGroupBox = New System.Windows.Forms.GroupBox()
        Me.ParametersTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOrderType = New System.Windows.Forms.Label()
        Me.lblOrderSource = New System.Windows.Forms.Label()
        Me.lblPaymentMethods = New System.Windows.Forms.Label()
        Me.lblCommentForIssue = New System.Windows.Forms.Label()
        Me.lblIssuePlace = New System.Windows.Forms.Label()
        Me.chkDocumentHasError = New System.Windows.Forms.CheckBox()
        Me.lblDocumentHasError = New System.Windows.Forms.Label()
        Me.PaymentMethodsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkNotDonePaymentMethod = New System.Windows.Forms.CheckBox()
        Me.chkNonCashPaymentMethod = New System.Windows.Forms.CheckBox()
        Me.chkCashPaymentMethod = New System.Windows.Forms.CheckBox()
        Me.chkOnlinePaymentMethod = New System.Windows.Forms.CheckBox()
        Me.lblIssuePlaceValue = New System.Windows.Forms.Label()
        Me.txtCommentForIssue = New System.Windows.Forms.TextBox()
        Me.txtOrderSource = New System.Windows.Forms.TextBox()
        Me.txtOrderType = New System.Windows.Forms.TextBox()
        Me.tsControl = New System.Windows.Forms.ToolStrip()
        Me.tscmbStatus = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tscmbDoc = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnPrintTZ = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnPrintLabel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnDocuments = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mdmprintPayButton = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnRobokassa = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnRobokassa1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnInputPay = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSendSMS = New System.Windows.Forms.ToolStripButton()
        Me.tslOpenClose = New System.Windows.Forms.ToolStripLabel()
        Me.tslCanceledOrder = New System.Windows.Forms.ToolStripLabel()
        Me.tsbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslOrderCost = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslOplacheno = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsSLDolgi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslKogdaVydan = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslBalansKA = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslLastRout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmsSpec = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.РедактироватьToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьВсеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTasks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.НоваяЗадачаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьЗадачиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопироватьОписаниеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Отсрочка1ДеньToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dsEmplWork = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.tpMaterial = New System.Windows.Forms.TabPage()
        Me.dgMatExpens = New System.Windows.Forms.DataGridView()
        Me.tpDelivery = New System.Windows.Forms.TabPage()
        Me.tlpDelivery = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip6 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnUpdateDostavka = New System.Windows.Forms.ToolStripButton()
        Me.dgDostavka = New System.Windows.Forms.DataGridView()
        Me.tpRout = New System.Windows.Forms.TabPage()
        Me.tlpRouting = New System.Windows.Forms.TableLayoutPanel()
        Me.dgOrderRout = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbEmplRout = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnRoutApply = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelRout = New System.Windows.Forms.ToolStripButton()
        Me.cmbRoutDescription = New System.Windows.Forms.ComboBox()
        Me.txtPurposeRout = New System.Windows.Forms.TextBox()
        Me.tpTasks = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgTasks = New System.Windows.Forms.DataGridView()
        Me.tsTasks = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNewTask = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnTask = New System.Windows.Forms.ToolStripButton()
        Me.tscmbDep = New System.Windows.Forms.ToolStripComboBox()
        Me.tscmbExecutor = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnNewExec = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnTaskFinish = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnTaskDel = New System.Windows.Forms.ToolStripButton()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.tpExpenses = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgExpensesOrder = New System.Windows.Forms.DataGridView()
        Me.tsExpenses = New System.Windows.Forms.ToolStrip()
        Me.tsbtnAddExpens = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAddFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnOpenFileInv = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelExpens = New System.Windows.Forms.ToolStripButton()
        Me.tpPayments = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlsPayment = New System.Windows.Forms.ToolStrip()
        Me.tsbtnDelPay = New System.Windows.Forms.ToolStripButton()
        Me.dgPay = New System.Windows.Forms.DataGridView()
        Me.tpPurpose = New System.Windows.Forms.TabPage()
        Me.tlpDescription = New System.Windows.Forms.TableLayoutPanel()
        Me.txtprim = New System.Windows.Forms.TextBox()
        Me.tsPrim = New System.Windows.Forms.ToolStrip()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tslblStatus = New System.Windows.Forms.ToolStripLabel()
        Me.txtPrepress = New System.Windows.Forms.TextBox()
        Me.cmbTemplateDes = New System.Windows.Forms.ComboBox()
        Me.tpFiles = New System.Windows.Forms.TabPage()
        Me.tlpFiles = New System.Windows.Forms.TableLayoutPanel()
        Me.dgFiles = New System.Windows.Forms.DataGridView()
        Me.cmsFiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tscmbFiles = New System.Windows.Forms.ToolStripComboBox()
        Me.СохранитьОписаниеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsFiles = New System.Windows.Forms.ToolStrip()
        Me.tscmbFileDescript = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtnAddFileWork = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnOpenFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnFileDel = New System.Windows.Forms.ToolStripButton()
        Me.tsPbarCopyFiles = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsbtnSaveFile = New System.Windows.Forms.ToolStripButton()
        Me.tpSpec = New System.Windows.Forms.TabPage()
        Me.dgSpec = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpDocumentErrorReports = New System.Windows.Forms.TabPage()
        Me.DocumentErrorRecords = New System.Windows.Forms.DataGridView()
        Me.tpDir = New System.Windows.Forms.TabPage()
        Me.tlpPath = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPath1 = New System.Windows.Forms.TextBox()
        Me.btnPath1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPath2 = New System.Windows.Forms.TextBox()
        Me.txtPath3 = New System.Windows.Forms.TextBox()
        Me.btnPath2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnPath3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog3 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.tslblCostNumber = New System.Windows.Forms.ToolStripTextBox()
        Me.tstxtCostNumber = New System.Windows.Forms.ToolStripTextBox()
        Me.tslblAdditionalNumber = New System.Windows.Forms.ToolStripTextBox()
        Me.tstxtAdditionalNumber = New System.Windows.Forms.ToolStripTextBox()
        Me.OrderClosedContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RevertCloseItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderCancelledContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RevertCancelledItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.tlpCommonParam.SuspendLayout
        Me.TimeGroupBox.SuspendLayout
        Me.TimeTableLayoutPanel.SuspendLayout
        Me.CustomerGroupBox.SuspendLayout
        Me.CustomerTableLayoutPanel.SuspendLayout
        Me.ExecutorGroupBox.SuspendLayout
        Me.ExecutorTableLayoutPanel.SuspendLayout
        Me.ParametersGroupBox.SuspendLayout
        Me.ParametersTableLayoutPanel.SuspendLayout
        Me.PaymentMethodsFlowLayoutPanel.SuspendLayout
        Me.tsControl.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.cmsSpec.SuspendLayout
        Me.cmsTasks.SuspendLayout
        CType(Me.dsEmplWork,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataTable1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpMaterial.SuspendLayout
        CType(Me.dgMatExpens,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpDelivery.SuspendLayout
        Me.tlpDelivery.SuspendLayout
        Me.ToolStrip6.SuspendLayout
        CType(Me.dgDostavka,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpRout.SuspendLayout
        Me.tlpRouting.SuspendLayout
        CType(Me.dgOrderRout,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip4.SuspendLayout
        Me.tpTasks.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        CType(Me.dgTasks,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tsTasks.SuspendLayout
        Me.tpExpenses.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        CType(Me.dgExpensesOrder,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tsExpenses.SuspendLayout
        Me.tpPayments.SuspendLayout
        Me.TableLayoutPanel7.SuspendLayout
        Me.tlsPayment.SuspendLayout
        CType(Me.dgPay,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpPurpose.SuspendLayout
        Me.tlpDescription.SuspendLayout
        Me.tsPrim.SuspendLayout
        Me.tpFiles.SuspendLayout
        Me.tlpFiles.SuspendLayout
        CType(Me.dgFiles,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsFiles.SuspendLayout
        Me.tlsFiles.SuspendLayout
        Me.tpSpec.SuspendLayout
        CType(Me.dgSpec,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabControl1.SuspendLayout
        Me.tpDocumentErrorReports.SuspendLayout
        CType(Me.DocumentErrorRecords,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpDir.SuspendLayout
        Me.tlpPath.SuspendLayout
        Me.MenuStrip2.SuspendLayout
        Me.OrderClosedContextMenuStrip.SuspendLayout
        Me.OrderCancelledContextMenuStrip.SuspendLayout
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer2.Panel1.SuspendLayout
        Me.SplitContainer2.Panel2.SuspendLayout
        Me.SplitContainer2.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbServices, Me.РедактироватьToolStripMenuItem, Me.БракToolStripMenuItem1, Me.ЗаказToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1086, 31)
        Me.MenuStrip1.TabIndex = 67
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tscmbServices
        '
        Me.tscmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbServices.DropDownWidth = 500
        Me.tscmbServices.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbServices.MaxDropDownItems = 40
        Me.tscmbServices.Name = "tscmbServices"
        Me.tscmbServices.Size = New System.Drawing.Size(361, 27)
        Me.tscmbServices.ToolTipText = "Выбери технологию"
        '
        'РедактироватьToolStripMenuItem
        '
        Me.РедактироватьToolStripMenuItem.Name = "РедактироватьToolStripMenuItem"
        Me.РедактироватьToolStripMenuItem.Size = New System.Drawing.Size(123, 27)
        Me.РедактироватьToolStripMenuItem.Text = "Редактировать"
        '
        'БракToolStripMenuItem1
        '
        Me.БракToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОтказОтЗаказаToolStripMenuItem1, Me.ПеределкаЗаказаToolStripMenuItem1, Me.РеализацияСПроизвольнойСкидкойToolStripMenuItem1})
        Me.БракToolStripMenuItem1.Name = "БракToolStripMenuItem1"
        Me.БракToolStripMenuItem1.Size = New System.Drawing.Size(52, 27)
        Me.БракToolStripMenuItem1.Text = "Брак"
        '
        'ОтказОтЗаказаToolStripMenuItem1
        '
        Me.ОтказОтЗаказаToolStripMenuItem1.Name = "ОтказОтЗаказаToolStripMenuItem1"
        Me.ОтказОтЗаказаToolStripMenuItem1.Size = New System.Drawing.Size(326, 22)
        Me.ОтказОтЗаказаToolStripMenuItem1.Text = "Отказ от заказа"
        '
        'ПеределкаЗаказаToolStripMenuItem1
        '
        Me.ПеределкаЗаказаToolStripMenuItem1.Name = "ПеределкаЗаказаToolStripMenuItem1"
        Me.ПеределкаЗаказаToolStripMenuItem1.Size = New System.Drawing.Size(326, 22)
        Me.ПеределкаЗаказаToolStripMenuItem1.Text = "Переделка заказа"
        '
        'РеализацияСПроизвольнойСкидкойToolStripMenuItem1
        '
        Me.РеализацияСПроизвольнойСкидкойToolStripMenuItem1.Name = "РеализацияСПроизвольнойСкидкойToolStripMenuItem1"
        Me.РеализацияСПроизвольнойСкидкойToolStripMenuItem1.Size = New System.Drawing.Size(326, 22)
        Me.РеализацияСПроизвольнойСкидкойToolStripMenuItem1.Text = "Реализация с произвольной скидкой"
        '
        'ЗаказToolStripMenuItem
        '
        Me.ЗаказToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПовторитьToolStripMenuItem, Me.СкидкаToolStripMenuItem, Me.CancelCostItem})
        Me.ЗаказToolStripMenuItem.Name = "ЗаказToolStripMenuItem"
        Me.ЗаказToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1),System.Windows.Forms.Keys)
        Me.ЗаказToolStripMenuItem.Size = New System.Drawing.Size(49, 27)
        Me.ЗаказToolStripMenuItem.Text = "Еще"
        Me.ЗаказToolStripMenuItem.ToolTipText = "Обработка заказа"
        '
        'ПовторитьToolStripMenuItem
        '
        Me.ПовторитьToolStripMenuItem.Name = "ПовторитьToolStripMenuItem"
        Me.ПовторитьToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ПовторитьToolStripMenuItem.Text = "Повторить заказ"
        '
        'СкидкаToolStripMenuItem
        '
        Me.СкидкаToolStripMenuItem.Name = "СкидкаToolStripMenuItem"
        Me.СкидкаToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.СкидкаToolStripMenuItem.Text = "Сделать скидку"
        Me.СкидкаToolStripMenuItem.Visible = false
        '
        'CancelCostItem
        '
        Me.CancelCostItem.Name = "CancelCostItem"
        Me.CancelCostItem.Size = New System.Drawing.Size(215, 22)
        Me.CancelCostItem.Text = "Аннулировать заказ"
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
        Me.SplitContainer1.Panel1.AutoScroll = true
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpCommonParam)
        Me.SplitContainer1.Panel1MinSize = 828
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsControl)
        Me.SplitContainer1.Panel2MinSize = 220
        Me.SplitContainer1.Size = New System.Drawing.Size(1086, 466)
        Me.SplitContainer1.SplitterDistance = 860
        Me.SplitContainer1.TabIndex = 119
        '
        'tlpCommonParam
        '
        Me.tlpCommonParam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tlpCommonParam.AutoSize = true
        Me.tlpCommonParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpCommonParam.BackColor = System.Drawing.SystemColors.Window
        Me.tlpCommonParam.ColumnCount = 2
        Me.tlpCommonParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpCommonParam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpCommonParam.Controls.Add(Me.TimeGroupBox, 0, 0)
        Me.tlpCommonParam.Controls.Add(Me.CustomerGroupBox, 0, 1)
        Me.tlpCommonParam.Controls.Add(Me.ExecutorGroupBox, 1, 1)
        Me.tlpCommonParam.Controls.Add(Me.ParametersGroupBox, 1, 0)
        Me.tlpCommonParam.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpCommonParam.Location = New System.Drawing.Point(0, 0)
        Me.tlpCommonParam.Name = "tlpCommonParam"
        Me.tlpCommonParam.RowCount = 2
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpCommonParam.Size = New System.Drawing.Size(854, 462)
        Me.tlpCommonParam.TabIndex = 121
        '
        'TimeGroupBox
        '
        Me.TimeGroupBox.Controls.Add(Me.TimeTableLayoutPanel)
        Me.TimeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeGroupBox.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.TimeGroupBox.Location = New System.Drawing.Point(10, 0)
        Me.TimeGroupBox.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.TimeGroupBox.Name = "TimeGroupBox"
        Me.TimeGroupBox.Size = New System.Drawing.Size(407, 231)
        Me.TimeGroupBox.TabIndex = 1
        Me.TimeGroupBox.TabStop = false
        Me.TimeGroupBox.Text = "СРОКИ"
        '
        'TimeTableLayoutPanel
        '
        Me.TimeTableLayoutPanel.ColumnCount = 2
        Me.TimeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250!))
        Me.TimeTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TimeTableLayoutPanel.Controls.Add(Me.lblDateOfLayoutReady, 0, 0)
        Me.TimeTableLayoutPanel.Controls.Add(Me.lblDateOfProductionReady, 0, 1)
        Me.TimeTableLayoutPanel.Controls.Add(Me.lblDateOfIssue, 0, 2)
        Me.TimeTableLayoutPanel.Controls.Add(Me.lblPlannedExecutionDate, 0, 3)
        Me.TimeTableLayoutPanel.Controls.Add(Me.lblOrderIsExpress, 0, 4)
        Me.TimeTableLayoutPanel.Controls.Add(Me.dtpDateOfLayoutReady, 1, 0)
        Me.TimeTableLayoutPanel.Controls.Add(Me.dtpDateOfProductionReady, 1, 1)
        Me.TimeTableLayoutPanel.Controls.Add(Me.dtpDateOfIssue, 1, 2)
        Me.TimeTableLayoutPanel.Controls.Add(Me.txtPlannedExecutionDate, 1, 3)
        Me.TimeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeTableLayoutPanel.Location = New System.Drawing.Point(3, 19)
        Me.TimeTableLayoutPanel.Name = "TimeTableLayoutPanel"
        Me.TimeTableLayoutPanel.RowCount = 5
        Me.TimeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33!))
        Me.TimeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33!))
        Me.TimeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33!))
        Me.TimeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33!))
        Me.TimeTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TimeTableLayoutPanel.Size = New System.Drawing.Size(401, 209)
        Me.TimeTableLayoutPanel.TabIndex = 0
        '
        'lblDateOfLayoutReady
        '
        Me.lblDateOfLayoutReady.AutoSize = true
        Me.lblDateOfLayoutReady.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateOfLayoutReady.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblDateOfLayoutReady.Location = New System.Drawing.Point(15, 0)
        Me.lblDateOfLayoutReady.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblDateOfLayoutReady.Name = "lblDateOfLayoutReady"
        Me.lblDateOfLayoutReady.Size = New System.Drawing.Size(232, 33)
        Me.lblDateOfLayoutReady.TabIndex = 0
        Me.lblDateOfLayoutReady.Text = "Дата готовности макета / спуска"
        Me.lblDateOfLayoutReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateOfProductionReady
        '
        Me.lblDateOfProductionReady.AutoSize = true
        Me.lblDateOfProductionReady.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateOfProductionReady.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblDateOfProductionReady.Location = New System.Drawing.Point(15, 33)
        Me.lblDateOfProductionReady.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblDateOfProductionReady.Name = "lblDateOfProductionReady"
        Me.lblDateOfProductionReady.Size = New System.Drawing.Size(232, 33)
        Me.lblDateOfProductionReady.TabIndex = 2
        Me.lblDateOfProductionReady.Text = "Дата готовности на производстве"
        Me.lblDateOfProductionReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateOfIssue
        '
        Me.lblDateOfIssue.AutoSize = true
        Me.lblDateOfIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateOfIssue.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblDateOfIssue.Location = New System.Drawing.Point(15, 66)
        Me.lblDateOfIssue.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblDateOfIssue.Name = "lblDateOfIssue"
        Me.lblDateOfIssue.Size = New System.Drawing.Size(232, 33)
        Me.lblDateOfIssue.TabIndex = 3
        Me.lblDateOfIssue.Text = "Дата выдачи / доставки"
        Me.lblDateOfIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlannedExecutionDate
        '
        Me.lblPlannedExecutionDate.AutoSize = true
        Me.lblPlannedExecutionDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlannedExecutionDate.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblPlannedExecutionDate.Location = New System.Drawing.Point(15, 99)
        Me.lblPlannedExecutionDate.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblPlannedExecutionDate.Name = "lblPlannedExecutionDate"
        Me.lblPlannedExecutionDate.Size = New System.Drawing.Size(232, 33)
        Me.lblPlannedExecutionDate.TabIndex = 4
        Me.lblPlannedExecutionDate.Text = "Планируемое время выполнения"
        Me.lblPlannedExecutionDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderIsExpress
        '
        Me.lblOrderIsExpress.AutoSize = true
        Me.lblOrderIsExpress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(204,Byte),Integer), CType(CType(204,Byte),Integer))
        Me.lblOrderIsExpress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeTableLayoutPanel.SetColumnSpan(Me.lblOrderIsExpress, 2)
        Me.lblOrderIsExpress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOrderIsExpress.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblOrderIsExpress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrderIsExpress.Location = New System.Drawing.Point(15, 147)
        Me.lblOrderIsExpress.Margin = New System.Windows.Forms.Padding(15)
        Me.lblOrderIsExpress.Name = "lblOrderIsExpress"
        Me.lblOrderIsExpress.Size = New System.Drawing.Size(371, 47)
        Me.lblOrderIsExpress.TabIndex = 5
        Me.lblOrderIsExpress.Text = "Срочный заказ"
        Me.lblOrderIsExpress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDateOfLayoutReady
        '
        Me.dtpDateOfLayoutReady.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dtpDateOfLayoutReady.CustomFormat = "dd:MM:yyyy HH:mm"
        Me.dtpDateOfLayoutReady.Enabled = false
        Me.dtpDateOfLayoutReady.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.dtpDateOfLayoutReady.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfLayoutReady.Location = New System.Drawing.Point(253, 3)
        Me.dtpDateOfLayoutReady.Name = "dtpDateOfLayoutReady"
        Me.dtpDateOfLayoutReady.Size = New System.Drawing.Size(145, 23)
        Me.dtpDateOfLayoutReady.TabIndex = 9
        '
        'dtpDateOfProductionReady
        '
        Me.dtpDateOfProductionReady.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dtpDateOfProductionReady.CustomFormat = "dd:MM:yyyy HH:mm"
        Me.dtpDateOfProductionReady.Enabled = false
        Me.dtpDateOfProductionReady.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.dtpDateOfProductionReady.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfProductionReady.Location = New System.Drawing.Point(253, 36)
        Me.dtpDateOfProductionReady.Name = "dtpDateOfProductionReady"
        Me.dtpDateOfProductionReady.Size = New System.Drawing.Size(145, 23)
        Me.dtpDateOfProductionReady.TabIndex = 10
        '
        'dtpDateOfIssue
        '
        Me.dtpDateOfIssue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dtpDateOfIssue.CustomFormat = "dd:MM:yyyy HH:mm"
        Me.dtpDateOfIssue.Enabled = false
        Me.dtpDateOfIssue.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.dtpDateOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfIssue.Location = New System.Drawing.Point(253, 69)
        Me.dtpDateOfIssue.Name = "dtpDateOfIssue"
        Me.dtpDateOfIssue.Size = New System.Drawing.Size(145, 23)
        Me.dtpDateOfIssue.TabIndex = 11
        '
        'txtPlannedExecutionDate
        '
        Me.txtPlannedExecutionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlannedExecutionDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPlannedExecutionDate.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtPlannedExecutionDate.Location = New System.Drawing.Point(253, 102)
        Me.txtPlannedExecutionDate.Name = "txtPlannedExecutionDate"
        Me.txtPlannedExecutionDate.ReadOnly = true
        Me.txtPlannedExecutionDate.Size = New System.Drawing.Size(145, 23)
        Me.txtPlannedExecutionDate.TabIndex = 12
        '
        'CustomerGroupBox
        '
        Me.CustomerGroupBox.Controls.Add(Me.CustomerTableLayoutPanel)
        Me.CustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerGroupBox.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.CustomerGroupBox.Location = New System.Drawing.Point(10, 241)
        Me.CustomerGroupBox.Margin = New System.Windows.Forms.Padding(10)
        Me.CustomerGroupBox.Name = "CustomerGroupBox"
        Me.CustomerGroupBox.Size = New System.Drawing.Size(407, 211)
        Me.CustomerGroupBox.TabIndex = 2
        Me.CustomerGroupBox.TabStop = false
        Me.CustomerGroupBox.Text = "ЗАКАЗЧИК"
        '
        'CustomerTableLayoutPanel
        '
        Me.CustomerTableLayoutPanel.ColumnCount = 2
        Me.CustomerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180!))
        Me.CustomerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.CustomerTableLayoutPanel.Controls.Add(Me.lblContractor, 0, 0)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.lblContactPerson, 0, 1)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.lblCustomerPhone1, 0, 2)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.lblCustomerPhone2, 0, 3)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.lblCustomerEmail, 0, 4)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.lblCustomerPerson, 0, 5)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.txtContractor, 1, 0)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.txtContactPerson, 1, 1)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.txtCustomerPhone1, 1, 2)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.txtCustomerPhone2, 1, 3)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.txtCustomerEmail, 1, 4)
        Me.CustomerTableLayoutPanel.Controls.Add(Me.txtCustomerPerson, 1, 5)
        Me.CustomerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerTableLayoutPanel.Location = New System.Drawing.Point(3, 19)
        Me.CustomerTableLayoutPanel.Name = "CustomerTableLayoutPanel"
        Me.CustomerTableLayoutPanel.RowCount = 6
        Me.CustomerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomerTableLayoutPanel.Size = New System.Drawing.Size(401, 189)
        Me.CustomerTableLayoutPanel.TabIndex = 0
        '
        'lblContractor
        '
        Me.lblContractor.AutoSize = true
        Me.lblContractor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContractor.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblContractor.Location = New System.Drawing.Point(15, 0)
        Me.lblContractor.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblContractor.Name = "lblContractor"
        Me.lblContractor.Size = New System.Drawing.Size(162, 31)
        Me.lblContractor.TabIndex = 0
        Me.lblContractor.Text = "Контрагент"
        Me.lblContractor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContactPerson
        '
        Me.lblContactPerson.AutoSize = true
        Me.lblContactPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContactPerson.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblContactPerson.Location = New System.Drawing.Point(15, 31)
        Me.lblContactPerson.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(162, 31)
        Me.lblContactPerson.TabIndex = 1
        Me.lblContactPerson.Text = "Контактное лицо"
        Me.lblContactPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustomerPhone1
        '
        Me.lblCustomerPhone1.AutoSize = true
        Me.lblCustomerPhone1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCustomerPhone1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblCustomerPhone1.Location = New System.Drawing.Point(15, 62)
        Me.lblCustomerPhone1.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblCustomerPhone1.Name = "lblCustomerPhone1"
        Me.lblCustomerPhone1.Size = New System.Drawing.Size(162, 31)
        Me.lblCustomerPhone1.TabIndex = 2
        Me.lblCustomerPhone1.Text = "Телефон 1"
        Me.lblCustomerPhone1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustomerPhone2
        '
        Me.lblCustomerPhone2.AutoSize = true
        Me.lblCustomerPhone2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCustomerPhone2.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblCustomerPhone2.Location = New System.Drawing.Point(15, 93)
        Me.lblCustomerPhone2.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblCustomerPhone2.Name = "lblCustomerPhone2"
        Me.lblCustomerPhone2.Size = New System.Drawing.Size(162, 31)
        Me.lblCustomerPhone2.TabIndex = 3
        Me.lblCustomerPhone2.Text = "Телефон 2"
        Me.lblCustomerPhone2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustomerEmail
        '
        Me.lblCustomerEmail.AutoSize = true
        Me.lblCustomerEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCustomerEmail.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblCustomerEmail.Location = New System.Drawing.Point(15, 124)
        Me.lblCustomerEmail.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblCustomerEmail.Name = "lblCustomerEmail"
        Me.lblCustomerEmail.Size = New System.Drawing.Size(162, 31)
        Me.lblCustomerEmail.TabIndex = 4
        Me.lblCustomerEmail.Text = "Эл. почта"
        Me.lblCustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustomerPerson
        '
        Me.lblCustomerPerson.AutoSize = true
        Me.lblCustomerPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCustomerPerson.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblCustomerPerson.Location = New System.Drawing.Point(15, 160)
        Me.lblCustomerPerson.Margin = New System.Windows.Forms.Padding(15, 5, 3, 0)
        Me.lblCustomerPerson.Name = "lblCustomerPerson"
        Me.lblCustomerPerson.Size = New System.Drawing.Size(162, 29)
        Me.lblCustomerPerson.TabIndex = 5
        Me.lblCustomerPerson.Text = "ЮР. ЛИЦО"
        '
        'txtContractor
        '
        Me.txtContractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContractor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContractor.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtContractor.Location = New System.Drawing.Point(183, 5)
        Me.txtContractor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtContractor.Name = "txtContractor"
        Me.txtContractor.ReadOnly = true
        Me.txtContractor.Size = New System.Drawing.Size(215, 23)
        Me.txtContractor.TabIndex = 6
        '
        'txtContactPerson
        '
        Me.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContactPerson.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtContactPerson.Location = New System.Drawing.Point(183, 36)
        Me.txtContactPerson.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.ReadOnly = true
        Me.txtContactPerson.Size = New System.Drawing.Size(215, 23)
        Me.txtContactPerson.TabIndex = 7
        '
        'txtCustomerPhone1
        '
        Me.txtCustomerPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerPhone1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustomerPhone1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtCustomerPhone1.Location = New System.Drawing.Point(183, 67)
        Me.txtCustomerPhone1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtCustomerPhone1.Name = "txtCustomerPhone1"
        Me.txtCustomerPhone1.ReadOnly = true
        Me.txtCustomerPhone1.Size = New System.Drawing.Size(215, 23)
        Me.txtCustomerPhone1.TabIndex = 8
        '
        'txtCustomerPhone2
        '
        Me.txtCustomerPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerPhone2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustomerPhone2.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtCustomerPhone2.Location = New System.Drawing.Point(183, 98)
        Me.txtCustomerPhone2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtCustomerPhone2.Name = "txtCustomerPhone2"
        Me.txtCustomerPhone2.ReadOnly = true
        Me.txtCustomerPhone2.Size = New System.Drawing.Size(215, 23)
        Me.txtCustomerPhone2.TabIndex = 9
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustomerEmail.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtCustomerEmail.Location = New System.Drawing.Point(183, 129)
        Me.txtCustomerEmail.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.ReadOnly = true
        Me.txtCustomerEmail.Size = New System.Drawing.Size(215, 23)
        Me.txtCustomerEmail.TabIndex = 10
        '
        'txtCustomerPerson
        '
        Me.txtCustomerPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustomerPerson.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtCustomerPerson.Location = New System.Drawing.Point(183, 160)
        Me.txtCustomerPerson.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtCustomerPerson.Name = "txtCustomerPerson"
        Me.txtCustomerPerson.ReadOnly = true
        Me.txtCustomerPerson.Size = New System.Drawing.Size(215, 23)
        Me.txtCustomerPerson.TabIndex = 11
        '
        'ExecutorGroupBox
        '
        Me.ExecutorGroupBox.Controls.Add(Me.ExecutorTableLayoutPanel)
        Me.ExecutorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExecutorGroupBox.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ExecutorGroupBox.Location = New System.Drawing.Point(437, 241)
        Me.ExecutorGroupBox.Margin = New System.Windows.Forms.Padding(10)
        Me.ExecutorGroupBox.Name = "ExecutorGroupBox"
        Me.ExecutorGroupBox.Size = New System.Drawing.Size(407, 211)
        Me.ExecutorGroupBox.TabIndex = 3
        Me.ExecutorGroupBox.TabStop = false
        Me.ExecutorGroupBox.Text = "ИСПОЛНЯЮЩИЙ"
        '
        'ExecutorTableLayoutPanel
        '
        Me.ExecutorTableLayoutPanel.ColumnCount = 2
        Me.ExecutorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180!))
        Me.ExecutorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.lblManager, 0, 0)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.lblContactNumber, 0, 1)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.lblInternalNumber, 0, 2)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.lblExecutorEmail, 0, 3)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.lblExecutor, 0, 4)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.lblExecutorPerson, 0, 5)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.txtManager, 1, 0)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.txtContactNumber, 1, 1)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.txtInternalNumber, 1, 2)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.txtExecutorEmail, 1, 3)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.txtExecutor, 1, 4)
        Me.ExecutorTableLayoutPanel.Controls.Add(Me.txtExecutorPerson, 1, 5)
        Me.ExecutorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExecutorTableLayoutPanel.Location = New System.Drawing.Point(3, 19)
        Me.ExecutorTableLayoutPanel.Name = "ExecutorTableLayoutPanel"
        Me.ExecutorTableLayoutPanel.RowCount = 6
        Me.ExecutorTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32!))
        Me.ExecutorTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32!))
        Me.ExecutorTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32!))
        Me.ExecutorTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32!))
        Me.ExecutorTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32!))
        Me.ExecutorTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32!))
        Me.ExecutorTableLayoutPanel.Size = New System.Drawing.Size(401, 189)
        Me.ExecutorTableLayoutPanel.TabIndex = 0
        '
        'lblManager
        '
        Me.lblManager.AutoSize = true
        Me.lblManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblManager.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblManager.Location = New System.Drawing.Point(15, 0)
        Me.lblManager.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(162, 32)
        Me.lblManager.TabIndex = 0
        Me.lblManager.Text = "МЕНЕДЖЕР"
        Me.lblManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = true
        Me.lblContactNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContactNumber.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblContactNumber.Location = New System.Drawing.Point(15, 32)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(162, 32)
        Me.lblContactNumber.TabIndex = 1
        Me.lblContactNumber.Text = "Конт. телефон"
        Me.lblContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInternalNumber
        '
        Me.lblInternalNumber.AutoSize = true
        Me.lblInternalNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInternalNumber.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblInternalNumber.Location = New System.Drawing.Point(15, 64)
        Me.lblInternalNumber.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblInternalNumber.Name = "lblInternalNumber"
        Me.lblInternalNumber.Size = New System.Drawing.Size(162, 32)
        Me.lblInternalNumber.TabIndex = 2
        Me.lblInternalNumber.Text = "Внутр. телефон"
        Me.lblInternalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExecutorEmail
        '
        Me.lblExecutorEmail.AutoSize = true
        Me.lblExecutorEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExecutorEmail.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblExecutorEmail.Location = New System.Drawing.Point(15, 96)
        Me.lblExecutorEmail.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblExecutorEmail.Name = "lblExecutorEmail"
        Me.lblExecutorEmail.Size = New System.Drawing.Size(162, 32)
        Me.lblExecutorEmail.TabIndex = 3
        Me.lblExecutorEmail.Text = "Эл. почта"
        Me.lblExecutorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExecutor
        '
        Me.lblExecutor.AutoSize = true
        Me.lblExecutor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExecutor.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblExecutor.Location = New System.Drawing.Point(15, 128)
        Me.lblExecutor.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblExecutor.Name = "lblExecutor"
        Me.lblExecutor.Size = New System.Drawing.Size(162, 32)
        Me.lblExecutor.TabIndex = 4
        Me.lblExecutor.Text = "ИСПОЛНЯЮЩИЙ"
        Me.lblExecutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExecutorPerson
        '
        Me.lblExecutorPerson.AutoSize = true
        Me.lblExecutorPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExecutorPerson.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblExecutorPerson.Location = New System.Drawing.Point(15, 160)
        Me.lblExecutorPerson.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblExecutorPerson.Name = "lblExecutorPerson"
        Me.lblExecutorPerson.Size = New System.Drawing.Size(162, 32)
        Me.lblExecutorPerson.TabIndex = 5
        Me.lblExecutorPerson.Text = "ЮР. ЛИЦО"
        Me.lblExecutorPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtManager
        '
        Me.txtManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtManager.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtManager.Location = New System.Drawing.Point(183, 3)
        Me.txtManager.Name = "txtManager"
        Me.txtManager.ReadOnly = true
        Me.txtManager.Size = New System.Drawing.Size(215, 23)
        Me.txtManager.TabIndex = 6
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContactNumber.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtContactNumber.Location = New System.Drawing.Point(183, 35)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.ReadOnly = true
        Me.txtContactNumber.Size = New System.Drawing.Size(215, 23)
        Me.txtContactNumber.TabIndex = 7
        '
        'txtInternalNumber
        '
        Me.txtInternalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInternalNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInternalNumber.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtInternalNumber.Location = New System.Drawing.Point(183, 67)
        Me.txtInternalNumber.Name = "txtInternalNumber"
        Me.txtInternalNumber.ReadOnly = true
        Me.txtInternalNumber.Size = New System.Drawing.Size(215, 23)
        Me.txtInternalNumber.TabIndex = 8
        '
        'txtExecutorEmail
        '
        Me.txtExecutorEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExecutorEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExecutorEmail.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtExecutorEmail.Location = New System.Drawing.Point(183, 99)
        Me.txtExecutorEmail.Name = "txtExecutorEmail"
        Me.txtExecutorEmail.ReadOnly = true
        Me.txtExecutorEmail.Size = New System.Drawing.Size(215, 23)
        Me.txtExecutorEmail.TabIndex = 9
        '
        'txtExecutor
        '
        Me.txtExecutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExecutor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExecutor.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtExecutor.Location = New System.Drawing.Point(183, 131)
        Me.txtExecutor.Name = "txtExecutor"
        Me.txtExecutor.ReadOnly = true
        Me.txtExecutor.Size = New System.Drawing.Size(215, 23)
        Me.txtExecutor.TabIndex = 10
        '
        'txtExecutorPerson
        '
        Me.txtExecutorPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExecutorPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExecutorPerson.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtExecutorPerson.Location = New System.Drawing.Point(183, 163)
        Me.txtExecutorPerson.Name = "txtExecutorPerson"
        Me.txtExecutorPerson.ReadOnly = true
        Me.txtExecutorPerson.Size = New System.Drawing.Size(215, 23)
        Me.txtExecutorPerson.TabIndex = 11
        '
        'ParametersGroupBox
        '
        Me.ParametersGroupBox.Controls.Add(Me.ParametersTableLayoutPanel)
        Me.ParametersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParametersGroupBox.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ParametersGroupBox.Location = New System.Drawing.Point(437, 0)
        Me.ParametersGroupBox.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ParametersGroupBox.Name = "ParametersGroupBox"
        Me.ParametersGroupBox.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.ParametersGroupBox.Size = New System.Drawing.Size(407, 231)
        Me.ParametersGroupBox.TabIndex = 4
        Me.ParametersGroupBox.TabStop = false
        Me.ParametersGroupBox.Text = "ПАРАМЕТРЫ"
        '
        'ParametersTableLayoutPanel
        '
        Me.ParametersTableLayoutPanel.ColumnCount = 2
        Me.ParametersTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190!))
        Me.ParametersTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.ParametersTableLayoutPanel.Controls.Add(Me.lblOrderType, 0, 0)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.lblOrderSource, 0, 1)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.lblPaymentMethods, 0, 2)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.lblCommentForIssue, 0, 3)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.lblIssuePlace, 0, 4)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.chkDocumentHasError, 0, 5)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.lblDocumentHasError, 1, 5)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.PaymentMethodsFlowLayoutPanel, 1, 2)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.lblIssuePlaceValue, 1, 4)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.txtCommentForIssue, 1, 3)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.txtOrderSource, 1, 1)
        Me.ParametersTableLayoutPanel.Controls.Add(Me.txtOrderType, 1, 0)
        Me.ParametersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParametersTableLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.ParametersTableLayoutPanel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.ParametersTableLayoutPanel.Name = "ParametersTableLayoutPanel"
        Me.ParametersTableLayoutPanel.RowCount = 6
        Me.ParametersTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
        Me.ParametersTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
        Me.ParametersTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.ParametersTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
        Me.ParametersTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
        Me.ParametersTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
        Me.ParametersTableLayoutPanel.Size = New System.Drawing.Size(401, 212)
        Me.ParametersTableLayoutPanel.TabIndex = 0
        '
        'lblOrderType
        '
        Me.lblOrderType.AutoSize = true
        Me.lblOrderType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOrderType.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblOrderType.Location = New System.Drawing.Point(15, 0)
        Me.lblOrderType.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblOrderType.Name = "lblOrderType"
        Me.lblOrderType.Size = New System.Drawing.Size(172, 26)
        Me.lblOrderType.TabIndex = 0
        Me.lblOrderType.Text = "Тип заказа"
        Me.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderSource
        '
        Me.lblOrderSource.AutoSize = true
        Me.lblOrderSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOrderSource.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblOrderSource.Location = New System.Drawing.Point(15, 26)
        Me.lblOrderSource.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblOrderSource.Name = "lblOrderSource"
        Me.lblOrderSource.Size = New System.Drawing.Size(172, 26)
        Me.lblOrderSource.TabIndex = 1
        Me.lblOrderSource.Text = "Источник"
        Me.lblOrderSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaymentMethods
        '
        Me.lblPaymentMethods.AutoSize = true
        Me.lblPaymentMethods.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPaymentMethods.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblPaymentMethods.Location = New System.Drawing.Point(15, 62)
        Me.lblPaymentMethods.Margin = New System.Windows.Forms.Padding(15, 10, 3, 0)
        Me.lblPaymentMethods.Name = "lblPaymentMethods"
        Me.lblPaymentMethods.Size = New System.Drawing.Size(172, 72)
        Me.lblPaymentMethods.TabIndex = 2
        Me.lblPaymentMethods.Text = "Способы оплаты"
        '
        'lblCommentForIssue
        '
        Me.lblCommentForIssue.AutoSize = true
        Me.lblCommentForIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCommentForIssue.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblCommentForIssue.Location = New System.Drawing.Point(15, 134)
        Me.lblCommentForIssue.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblCommentForIssue.Name = "lblCommentForIssue"
        Me.lblCommentForIssue.Size = New System.Drawing.Size(172, 26)
        Me.lblCommentForIssue.TabIndex = 3
        Me.lblCommentForIssue.Text = "Комментарий к выдаче"
        Me.lblCommentForIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIssuePlace
        '
        Me.lblIssuePlace.AutoSize = true
        Me.lblIssuePlace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIssuePlace.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblIssuePlace.Location = New System.Drawing.Point(15, 160)
        Me.lblIssuePlace.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.lblIssuePlace.Name = "lblIssuePlace"
        Me.lblIssuePlace.Size = New System.Drawing.Size(172, 26)
        Me.lblIssuePlace.TabIndex = 4
        Me.lblIssuePlace.Text = "ВЫДАЧА"
        Me.lblIssuePlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkDocumentHasError
        '
        Me.chkDocumentHasError.AutoCheck = false
        Me.chkDocumentHasError.AutoSize = true
        Me.chkDocumentHasError.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDocumentHasError.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkDocumentHasError.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDocumentHasError.Location = New System.Drawing.Point(175, 189)
        Me.chkDocumentHasError.Name = "chkDocumentHasError"
        Me.chkDocumentHasError.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDocumentHasError.Size = New System.Drawing.Size(12, 20)
        Me.chkDocumentHasError.TabIndex = 5
        Me.chkDocumentHasError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDocumentHasError.UseVisualStyleBackColor = true
        '
        'lblDocumentHasError
        '
        Me.lblDocumentHasError.AutoSize = true
        Me.lblDocumentHasError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDocumentHasError.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lblDocumentHasError.Location = New System.Drawing.Point(193, 186)
        Me.lblDocumentHasError.Name = "lblDocumentHasError"
        Me.lblDocumentHasError.Size = New System.Drawing.Size(205, 26)
        Me.lblDocumentHasError.TabIndex = 6
        Me.lblDocumentHasError.Text = "Проблема с документами"
        Me.lblDocumentHasError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PaymentMethodsFlowLayoutPanel
        '
        Me.PaymentMethodsFlowLayoutPanel.Controls.Add(Me.chkNotDonePaymentMethod)
        Me.PaymentMethodsFlowLayoutPanel.Controls.Add(Me.chkNonCashPaymentMethod)
        Me.PaymentMethodsFlowLayoutPanel.Controls.Add(Me.chkCashPaymentMethod)
        Me.PaymentMethodsFlowLayoutPanel.Controls.Add(Me.chkOnlinePaymentMethod)
        Me.PaymentMethodsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaymentMethodsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PaymentMethodsFlowLayoutPanel.Location = New System.Drawing.Point(190, 52)
        Me.PaymentMethodsFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.PaymentMethodsFlowLayoutPanel.Name = "PaymentMethodsFlowLayoutPanel"
        Me.PaymentMethodsFlowLayoutPanel.Size = New System.Drawing.Size(211, 82)
        Me.PaymentMethodsFlowLayoutPanel.TabIndex = 7
        Me.PaymentMethodsFlowLayoutPanel.WrapContents = false
        '
        'chkNotDonePaymentMethod
        '
        Me.chkNotDonePaymentMethod.AutoCheck = false
        Me.chkNotDonePaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNotDonePaymentMethod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkNotDonePaymentMethod.Location = New System.Drawing.Point(3, 0)
        Me.chkNotDonePaymentMethod.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkNotDonePaymentMethod.Name = "chkNotDonePaymentMethod"
        Me.chkNotDonePaymentMethod.Size = New System.Drawing.Size(293, 20)
        Me.chkNotDonePaymentMethod.TabIndex = 0
        Me.chkNotDonePaymentMethod.Text = "не проводилась"
        Me.chkNotDonePaymentMethod.UseVisualStyleBackColor = true
        '
        'chkNonCashPaymentMethod
        '
        Me.chkNonCashPaymentMethod.AutoCheck = false
        Me.chkNonCashPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNonCashPaymentMethod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkNonCashPaymentMethod.Location = New System.Drawing.Point(3, 20)
        Me.chkNonCashPaymentMethod.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkNonCashPaymentMethod.Name = "chkNonCashPaymentMethod"
        Me.chkNonCashPaymentMethod.Size = New System.Drawing.Size(293, 20)
        Me.chkNonCashPaymentMethod.TabIndex = 1
        Me.chkNonCashPaymentMethod.Text = "по юр. лицу (безнал)"
        Me.chkNonCashPaymentMethod.UseVisualStyleBackColor = true
        '
        'chkCashPaymentMethod
        '
        Me.chkCashPaymentMethod.AutoCheck = false
        Me.chkCashPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCashPaymentMethod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkCashPaymentMethod.Location = New System.Drawing.Point(3, 40)
        Me.chkCashPaymentMethod.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkCashPaymentMethod.Name = "chkCashPaymentMethod"
        Me.chkCashPaymentMethod.Size = New System.Drawing.Size(293, 20)
        Me.chkCashPaymentMethod.TabIndex = 2
        Me.chkCashPaymentMethod.Text = "по кассе (нал)"
        Me.chkCashPaymentMethod.UseVisualStyleBackColor = true
        '
        'chkOnlinePaymentMethod
        '
        Me.chkOnlinePaymentMethod.AutoCheck = false
        Me.chkOnlinePaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOnlinePaymentMethod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.chkOnlinePaymentMethod.Location = New System.Drawing.Point(3, 60)
        Me.chkOnlinePaymentMethod.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkOnlinePaymentMethod.Name = "chkOnlinePaymentMethod"
        Me.chkOnlinePaymentMethod.Size = New System.Drawing.Size(293, 20)
        Me.chkOnlinePaymentMethod.TabIndex = 3
        Me.chkOnlinePaymentMethod.Text = "онлайн (эл. платежи)"
        Me.chkOnlinePaymentMethod.UseVisualStyleBackColor = true
        '
        'lblIssuePlaceValue
        '
        Me.lblIssuePlaceValue.AutoSize = true
        Me.lblIssuePlaceValue.BackColor = System.Drawing.Color.Gold
        Me.lblIssuePlaceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssuePlaceValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIssuePlaceValue.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblIssuePlaceValue.Location = New System.Drawing.Point(193, 163)
        Me.lblIssuePlaceValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblIssuePlaceValue.Name = "lblIssuePlaceValue"
        Me.lblIssuePlaceValue.Size = New System.Drawing.Size(205, 20)
        Me.lblIssuePlaceValue.TabIndex = 8
        Me.lblIssuePlaceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCommentForIssue
        '
        Me.txtCommentForIssue.BackColor = System.Drawing.Color.Salmon
        Me.txtCommentForIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommentForIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCommentForIssue.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtCommentForIssue.Location = New System.Drawing.Point(193, 137)
        Me.txtCommentForIssue.Name = "txtCommentForIssue"
        Me.txtCommentForIssue.ReadOnly = true
        Me.txtCommentForIssue.Size = New System.Drawing.Size(205, 23)
        Me.txtCommentForIssue.TabIndex = 9
        '
        'txtOrderSource
        '
        Me.txtOrderSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOrderSource.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtOrderSource.Location = New System.Drawing.Point(193, 29)
        Me.txtOrderSource.Name = "txtOrderSource"
        Me.txtOrderSource.ReadOnly = true
        Me.txtOrderSource.Size = New System.Drawing.Size(205, 23)
        Me.txtOrderSource.TabIndex = 10
        '
        'txtOrderType
        '
        Me.txtOrderType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOrderType.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.txtOrderType.Location = New System.Drawing.Point(193, 3)
        Me.txtOrderType.Name = "txtOrderType"
        Me.txtOrderType.ReadOnly = true
        Me.txtOrderType.Size = New System.Drawing.Size(205, 23)
        Me.txtOrderType.TabIndex = 11
        '
        'tsControl
        '
        Me.tsControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsControl.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsControl.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbStatus, Me.ToolStripSeparator4, Me.tscmbDoc, Me.tsbtnPrintTZ, Me.tsbtnPrintLabel, Me.ToolStripSeparator2, Me.tsbtnDocuments, Me.ToolStripSeparator1, Me.mdmprintPayButton, Me.tsbtnRobokassa, Me.tsbtnRobokassa1, Me.ToolStripSeparator5, Me.tsbtnInputPay, Me.tsbtnSendSMS, Me.tslOpenClose, Me.tslCanceledOrder, Me.tsbtnUpdate})
        Me.tsControl.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsControl.Location = New System.Drawing.Point(0, 0)
        Me.tsControl.Name = "tsControl"
        Me.tsControl.Size = New System.Drawing.Size(220, 464)
        Me.tsControl.TabIndex = 122
        Me.tsControl.Text = "ToolStrip1"
        '
        'tscmbStatus
        '
        Me.tscmbStatus.BackColor = System.Drawing.SystemColors.Window
        Me.tscmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbStatus.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbStatus.Name = "tscmbStatus"
        Me.tscmbStatus.Size = New System.Drawing.Size(216, 26)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(218, 6)
        '
        'tscmbDoc
        '
        Me.tscmbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbDoc.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbDoc.Name = "tscmbDoc"
        Me.tscmbDoc.Size = New System.Drawing.Size(216, 26)
        '
        'tsbtnPrintTZ
        '
        Me.tsbtnPrintTZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnPrintTZ.Image = CType(resources.GetObject("tsbtnPrintTZ.Image"),System.Drawing.Image)
        Me.tsbtnPrintTZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbtnPrintTZ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPrintTZ.Name = "tsbtnPrintTZ"
        Me.tsbtnPrintTZ.Size = New System.Drawing.Size(218, 24)
        Me.tsbtnPrintTZ.Text = "Сформировать"
        '
        'tsbtnPrintLabel
        '
        Me.tsbtnPrintLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnPrintLabel.Image = CType(resources.GetObject("tsbtnPrintLabel.Image"),System.Drawing.Image)
        Me.tsbtnPrintLabel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPrintLabel.Name = "tsbtnPrintLabel"
        Me.tsbtnPrintLabel.Size = New System.Drawing.Size(218, 24)
        Me.tsbtnPrintLabel.Text = "Печать этикетки"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(218, 6)
        '
        'tsbtnDocuments
        '
        Me.tsbtnDocuments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDocuments.Image = CType(resources.GetObject("tsbtnDocuments.Image"),System.Drawing.Image)
        Me.tsbtnDocuments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDocuments.Name = "tsbtnDocuments"
        Me.tsbtnDocuments.Size = New System.Drawing.Size(218, 24)
        Me.tsbtnDocuments.Tag = "doc"
        Me.tsbtnDocuments.Text = "Документы"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(218, 6)
        '
        'mdmprintPayButton
        '
        Me.mdmprintPayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mdmprintPayButton.Image = CType(resources.GetObject("mdmprintPayButton.Image"),System.Drawing.Image)
        Me.mdmprintPayButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mdmprintPayButton.Name = "mdmprintPayButton"
        Me.mdmprintPayButton.Size = New System.Drawing.Size(218, 24)
        Me.mdmprintPayButton.Text = "Онлайн оплата МДМ (YK)"
        '
        'tsbtnRobokassa
        '
        Me.tsbtnRobokassa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnRobokassa.Image = CType(resources.GetObject("tsbtnRobokassa.Image"),System.Drawing.Image)
        Me.tsbtnRobokassa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnRobokassa.Margin = New System.Windows.Forms.Padding(0, 1, 0, 12)
        Me.tsbtnRobokassa.Name = "tsbtnRobokassa"
        Me.tsbtnRobokassa.Size = New System.Drawing.Size(218, 24)
        Me.tsbtnRobokassa.Text = "Онлайн оплата Энджой (YK)"
        '
        'tsbtnRobokassa1
        '
        Me.tsbtnRobokassa1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnRobokassa1.Image = CType(resources.GetObject("tsbtnRobokassa1.Image"),System.Drawing.Image)
        Me.tsbtnRobokassa1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnRobokassa1.Name = "tsbtnRobokassa1"
        Me.tsbtnRobokassa1.Size = New System.Drawing.Size(218, 24)
        Me.tsbtnRobokassa1.Text = "Доп. оплата МДМ (RK)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(218, 6)
        '
        'tsbtnInputPay
        '
        Me.tsbtnInputPay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnInputPay.Image = CType(resources.GetObject("tsbtnInputPay.Image"),System.Drawing.Image)
        Me.tsbtnInputPay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnInputPay.Name = "tsbtnInputPay"
        Me.tsbtnInputPay.Size = New System.Drawing.Size(218, 24)
        Me.tsbtnInputPay.Text = "Провести оплату"
        '
        'tsbtnSendSMS
        '
        Me.tsbtnSendSMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSendSMS.Image = CType(resources.GetObject("tsbtnSendSMS.Image"),System.Drawing.Image)
        Me.tsbtnSendSMS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSendSMS.Margin = New System.Windows.Forms.Padding(0, 1, 0, 6)
        Me.tsbtnSendSMS.Name = "tsbtnSendSMS"
        Me.tsbtnSendSMS.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.tsbtnSendSMS.Size = New System.Drawing.Size(218, 24)
        Me.tsbtnSendSMS.Text = "Отправить SMS"
        '
        'tslOpenClose
        '
        Me.tslOpenClose.ActiveLinkColor = System.Drawing.Color.Red
        Me.tslOpenClose.BackColor = System.Drawing.Color.Transparent
        Me.tslOpenClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tslOpenClose.ImageTransparentColor = System.Drawing.Color.White
        Me.tslOpenClose.Name = "tslOpenClose"
        Me.tslOpenClose.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.tslOpenClose.Size = New System.Drawing.Size(218, 28)
        Me.tslOpenClose.Text = "Закрыт/Открыт"
        '
        'tslCanceledOrder
        '
        Me.tslCanceledOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tslCanceledOrder.Name = "tslCanceledOrder"
        Me.tslCanceledOrder.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.tslCanceledOrder.Size = New System.Drawing.Size(218, 28)
        Me.tslCanceledOrder.Text = "Аннулирован/ не аннулирован"
        '
        'tsbtnUpdate
        '
        Me.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdate.Image = CType(resources.GetObject("tsbtnUpdate.Image"),System.Drawing.Image)
        Me.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdate.Name = "tsbtnUpdate"
        Me.tsbtnUpdate.Size = New System.Drawing.Size(218, 24)
        Me.tsbtnUpdate.Text = "Обновить"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslOrderCost, Me.tsslOplacheno, Me.tsSLDolgi, Me.ToolStripStatusLabel4, Me.tsslKogdaVydan, Me.tsslBalansKA, Me.tsslLastRout})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 737)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1086, 24)
        Me.StatusStrip1.TabIndex = 120
        '
        'tsslOrderCost
        '
        Me.tsslOrderCost.Name = "tsslOrderCost"
        Me.tsslOrderCost.Size = New System.Drawing.Size(141, 19)
        Me.tsslOrderCost.Text = "ToolStripStatusLabel1"
        '
        'tsslOplacheno
        '
        Me.tsslOplacheno.Name = "tsslOplacheno"
        Me.tsslOplacheno.Size = New System.Drawing.Size(75, 19)
        Me.tsslOplacheno.Text = "OPlacheno"
        '
        'tsSLDolgi
        '
        Me.tsSLDolgi.Name = "tsSLDolgi"
        Me.tsSLDolgi.Size = New System.Drawing.Size(39, 19)
        Me.tsSLDolgi.Text = "Долг"
        Me.tsSLDolgi.Visible = false
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(61, 19)
        Me.ToolStripStatusLabel4.Text = "Затраты"
        '
        'tsslKogdaVydan
        '
        Me.tsslKogdaVydan.Name = "tsslKogdaVydan"
        Me.tsslKogdaVydan.Size = New System.Drawing.Size(55, 19)
        Me.tsslKogdaVydan.Text = "Выдал-"
        Me.tsslKogdaVydan.Visible = false
        '
        'tsslBalansKA
        '
        Me.tsslBalansKA.Name = "tsslBalansKA"
        Me.tsslBalansKA.Size = New System.Drawing.Size(58, 19)
        Me.tsslBalansKA.Text = "Баланс-"
        Me.tsslBalansKA.Visible = false
        '
        'tsslLastRout
        '
        Me.tsslLastRout.AutoSize = false
        Me.tsslLastRout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslLastRout.Margin = New System.Windows.Forms.Padding(10, 3, 0, 2)
        Me.tsslLastRout.Name = "tsslLastRout"
        Me.tsslLastRout.Size = New System.Drawing.Size(201, 19)
        Me.tsslLastRout.Text = "Последний_маршрут"
        Me.tsslLastRout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmsSpec
        '
        Me.cmsSpec.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsSpec.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsSpec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РедактироватьToolStripMenuItem1, Me.УдалитьToolStripMenuItem, Me.УдалитьВсеToolStripMenuItem})
        Me.cmsSpec.Name = "cmsSpec"
        Me.cmsSpec.Size = New System.Drawing.Size(223, 70)
        '
        'РедактироватьToolStripMenuItem1
        '
        Me.РедактироватьToolStripMenuItem1.Name = "РедактироватьToolStripMenuItem1"
        Me.РедактироватьToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
        Me.РедактироватьToolStripMenuItem1.Text = "Редактировать"
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.УдалитьToolStripMenuItem.Text = "Удалить строку"
        '
        'УдалитьВсеToolStripMenuItem
        '
        Me.УдалитьВсеToolStripMenuItem.Name = "УдалитьВсеToolStripMenuItem"
        Me.УдалитьВсеToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.УдалитьВсеToolStripMenuItem.Text = "Удалить все позиции"
        '
        'cmsTasks
        '
        Me.cmsTasks.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsTasks.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTasks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НоваяЗадачаToolStripMenuItem, Me.УдалитьЗадачиToolStripMenuItem, Me.КопироватьОписаниеToolStripMenuItem, Me.Отсрочка1ДеньToolStripMenuItem})
        Me.cmsTasks.Name = "cmsTasks"
        Me.cmsTasks.Size = New System.Drawing.Size(226, 92)
        '
        'НоваяЗадачаToolStripMenuItem
        '
        Me.НоваяЗадачаToolStripMenuItem.Name = "НоваяЗадачаToolStripMenuItem"
        Me.НоваяЗадачаToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.НоваяЗадачаToolStripMenuItem.Text = "Новая задача"
        '
        'УдалитьЗадачиToolStripMenuItem
        '
        Me.УдалитьЗадачиToolStripMenuItem.Name = "УдалитьЗадачиToolStripMenuItem"
        Me.УдалитьЗадачиToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.УдалитьЗадачиToolStripMenuItem.Text = "Удалить задачу"
        '
        'КопироватьОписаниеToolStripMenuItem
        '
        Me.КопироватьОписаниеToolStripMenuItem.Name = "КопироватьОписаниеToolStripMenuItem"
        Me.КопироватьОписаниеToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.КопироватьОписаниеToolStripMenuItem.Text = "Копировать описание"
        '
        'Отсрочка1ДеньToolStripMenuItem
        '
        Me.Отсрочка1ДеньToolStripMenuItem.Name = "Отсрочка1ДеньToolStripMenuItem"
        Me.Отсрочка1ДеньToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.Отсрочка1ДеньToolStripMenuItem.Text = "Отсрочка 1 день"
        '
        'dsEmplWork
        '
        Me.dsEmplWork.DataSetName = "dsEmplWork"
        Me.dsEmplWork.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Column1"
        '
        'percent
        '
        Me.percent.FillWeight = 50.76142!
        Me.percent.HeaderText = "Процент участия"
        Me.percent.Name = "percent"
        Me.percent.Width = 70
        '
        'tpMaterial
        '
        Me.tpMaterial.Controls.Add(Me.dgMatExpens)
        Me.tpMaterial.Location = New System.Drawing.Point(4, 29)
        Me.tpMaterial.Name = "tpMaterial"
        Me.tpMaterial.Size = New System.Drawing.Size(1078, 173)
        Me.tpMaterial.TabIndex = 10
        Me.tpMaterial.Text = "Материал"
        Me.tpMaterial.UseVisualStyleBackColor = true
        '
        'dgMatExpens
        '
        Me.dgMatExpens.AllowUserToAddRows = false
        Me.dgMatExpens.AllowUserToDeleteRows = false
        Me.dgMatExpens.AllowUserToResizeRows = false
        Me.dgMatExpens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMatExpens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMatExpens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMatExpens.Location = New System.Drawing.Point(0, 0)
        Me.dgMatExpens.Name = "dgMatExpens"
        Me.dgMatExpens.ReadOnly = true
        Me.dgMatExpens.RowTemplate.Height = 24
        Me.dgMatExpens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMatExpens.Size = New System.Drawing.Size(1078, 173)
        Me.dgMatExpens.TabIndex = 3
        '
        'tpDelivery
        '
        Me.tpDelivery.Controls.Add(Me.tlpDelivery)
        Me.tpDelivery.Location = New System.Drawing.Point(4, 29)
        Me.tpDelivery.Name = "tpDelivery"
        Me.tpDelivery.Size = New System.Drawing.Size(1078, 173)
        Me.tpDelivery.TabIndex = 9
        Me.tpDelivery.Text = "Доставка"
        Me.tpDelivery.UseVisualStyleBackColor = true
        '
        'tlpDelivery
        '
        Me.tlpDelivery.ColumnCount = 2
        Me.tlpDelivery.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpDelivery.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149!))
        Me.tlpDelivery.Controls.Add(Me.ToolStrip6, 1, 0)
        Me.tlpDelivery.Controls.Add(Me.dgDostavka, 0, 0)
        Me.tlpDelivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDelivery.Location = New System.Drawing.Point(0, 0)
        Me.tlpDelivery.Name = "tlpDelivery"
        Me.tlpDelivery.RowCount = 1
        Me.tlpDelivery.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpDelivery.Size = New System.Drawing.Size(1078, 173)
        Me.tlpDelivery.TabIndex = 107
        '
        'ToolStrip6
        '
        Me.ToolStrip6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip6.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip6.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.tsbtnUpdateDostavka})
        Me.ToolStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip6.Location = New System.Drawing.Point(929, 0)
        Me.ToolStrip6.Name = "ToolStrip6"
        Me.ToolStrip6.Size = New System.Drawing.Size(149, 173)
        Me.ToolStrip6.TabIndex = 106
        Me.ToolStrip6.Text = "ToolStrip6"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"),System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripButton3.Text = "Оформить доставку"
        '
        'tsbtnUpdateDostavka
        '
        Me.tsbtnUpdateDostavka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpdateDostavka.Image = CType(resources.GetObject("tsbtnUpdateDostavka.Image"),System.Drawing.Image)
        Me.tsbtnUpdateDostavka.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpdateDostavka.Name = "tsbtnUpdateDostavka"
        Me.tsbtnUpdateDostavka.Size = New System.Drawing.Size(147, 22)
        Me.tsbtnUpdateDostavka.Text = "Обновить"
        '
        'dgDostavka
        '
        Me.dgDostavka.AllowUserToAddRows = false
        Me.dgDostavka.AllowUserToDeleteRows = false
        Me.dgDostavka.AllowUserToResizeRows = false
        Me.dgDostavka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDostavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDostavka.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDostavka.Location = New System.Drawing.Point(3, 3)
        Me.dgDostavka.Name = "dgDostavka"
        Me.dgDostavka.ReadOnly = true
        Me.dgDostavka.RowTemplate.Height = 24
        Me.dgDostavka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDostavka.Size = New System.Drawing.Size(923, 167)
        Me.dgDostavka.TabIndex = 107
        '
        'tpRout
        '
        Me.tpRout.Controls.Add(Me.tlpRouting)
        Me.tpRout.Location = New System.Drawing.Point(4, 29)
        Me.tpRout.Name = "tpRout"
        Me.tpRout.Size = New System.Drawing.Size(1078, 173)
        Me.tpRout.TabIndex = 8
        Me.tpRout.Text = "Маршрут"
        Me.tpRout.UseVisualStyleBackColor = true
        '
        'tlpRouting
        '
        Me.tlpRouting.ColumnCount = 3
        Me.tlpRouting.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpRouting.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRouting.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRouting.Controls.Add(Me.dgOrderRout, 0, 0)
        Me.tlpRouting.Controls.Add(Me.Label5, 1, 1)
        Me.tlpRouting.Controls.Add(Me.cmbDepartment, 2, 0)
        Me.tlpRouting.Controls.Add(Me.cmbEmplRout, 2, 1)
        Me.tlpRouting.Controls.Add(Me.Label9, 1, 0)
        Me.tlpRouting.Controls.Add(Me.Label1, 1, 2)
        Me.tlpRouting.Controls.Add(Me.ToolStrip4, 1, 4)
        Me.tlpRouting.Controls.Add(Me.cmbRoutDescription, 2, 2)
        Me.tlpRouting.Controls.Add(Me.txtPurposeRout, 1, 3)
        Me.tlpRouting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRouting.Location = New System.Drawing.Point(0, 0)
        Me.tlpRouting.Name = "tlpRouting"
        Me.tlpRouting.RowCount = 5
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpRouting.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRouting.Size = New System.Drawing.Size(1078, 173)
        Me.tlpRouting.TabIndex = 0
        '
        'dgOrderRout
        '
        Me.dgOrderRout.AllowUserToAddRows = false
        Me.dgOrderRout.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgOrderRout.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgOrderRout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgOrderRout.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgOrderRout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgOrderRout.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgOrderRout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrderRout.Location = New System.Drawing.Point(3, 3)
        Me.dgOrderRout.MultiSelect = false
        Me.dgOrderRout.Name = "dgOrderRout"
        Me.dgOrderRout.ReadOnly = true
        Me.dgOrderRout.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dgOrderRout.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.tlpRouting.SetRowSpan(Me.dgOrderRout, 5)
        Me.dgOrderRout.RowTemplate.Height = 24
        Me.dgOrderRout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrderRout.Size = New System.Drawing.Size(633, 167)
        Me.dgOrderRout.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(642, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 31)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Сотрудник"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDepartment.FormattingEnabled = true
        Me.cmbDepartment.Location = New System.Drawing.Point(749, 3)
        Me.cmbDepartment.MaxDropDownItems = 20
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(326, 25)
        Me.cmbDepartment.TabIndex = 7
        '
        'cmbEmplRout
        '
        Me.cmbEmplRout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEmplRout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmplRout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEmplRout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbEmplRout.FormattingEnabled = true
        Me.cmbEmplRout.Location = New System.Drawing.Point(749, 34)
        Me.cmbEmplRout.MaxDropDownItems = 30
        Me.cmbEmplRout.Name = "cmbEmplRout"
        Me.cmbEmplRout.Size = New System.Drawing.Size(326, 25)
        Me.cmbEmplRout.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(642, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 31)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Департамент"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(642, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Описание"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip4
        '
        Me.tlpRouting.SetColumnSpan(Me.ToolStrip4, 2)
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnRoutApply, Me.tsbtnDelRout})
        Me.ToolStrip4.Location = New System.Drawing.Point(639, 148)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(439, 25)
        Me.ToolStrip4.TabIndex = 10
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'tsbtnRoutApply
        '
        Me.tsbtnRoutApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnRoutApply.Image = CType(resources.GetObject("tsbtnRoutApply.Image"),System.Drawing.Image)
        Me.tsbtnRoutApply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnRoutApply.Name = "tsbtnRoutApply"
        Me.tsbtnRoutApply.Size = New System.Drawing.Size(89, 22)
        Me.tsbtnRoutApply.Text = "Применить"
        '
        'tsbtnDelRout
        '
        Me.tsbtnDelRout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelRout.Image = CType(resources.GetObject("tsbtnDelRout.Image"),System.Drawing.Image)
        Me.tsbtnDelRout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelRout.Name = "tsbtnDelRout"
        Me.tsbtnDelRout.Size = New System.Drawing.Size(71, 22)
        Me.tsbtnDelRout.Text = "Удалить"
        '
        'cmbRoutDescription
        '
        Me.cmbRoutDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbRoutDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoutDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRoutDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbRoutDescription.FormattingEnabled = true
        Me.cmbRoutDescription.Items.AddRange(New Object() {"Запустить в производство,", "Полка №  Кол-во мест:,", "Кол-во мест:", "Ожидать ответа клиента,", "Заказ проверен,", "Макет на утверждение готов,", "Спуск готов,", "Печать завершена,", "Послепечатные работы завершены,", "Задание отклонено по причине:,", "Направлен в КЦ,", "Направлен в ГМ,", "Направлен на доставку"})
        Me.cmbRoutDescription.Location = New System.Drawing.Point(749, 65)
        Me.cmbRoutDescription.MaxDropDownItems = 16
        Me.cmbRoutDescription.Name = "cmbRoutDescription"
        Me.cmbRoutDescription.Size = New System.Drawing.Size(326, 25)
        Me.cmbRoutDescription.TabIndex = 11
        '
        'txtPurposeRout
        '
        Me.txtPurposeRout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpRouting.SetColumnSpan(Me.txtPurposeRout, 2)
        Me.txtPurposeRout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPurposeRout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPurposeRout.Location = New System.Drawing.Point(642, 96)
        Me.txtPurposeRout.Multiline = true
        Me.txtPurposeRout.Name = "txtPurposeRout"
        Me.txtPurposeRout.Size = New System.Drawing.Size(433, 49)
        Me.txtPurposeRout.TabIndex = 12
        '
        'tpTasks
        '
        Me.tpTasks.Controls.Add(Me.TableLayoutPanel4)
        Me.tpTasks.Location = New System.Drawing.Point(4, 29)
        Me.tpTasks.Name = "tpTasks"
        Me.tpTasks.Size = New System.Drawing.Size(1078, 173)
        Me.tpTasks.TabIndex = 6
        Me.tpTasks.Text = "Задачи"
        Me.tpTasks.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgTasks, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tsTasks, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTask, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1078, 173)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'dgTasks
        '
        Me.dgTasks.AllowUserToAddRows = false
        Me.dgTasks.AllowUserToDeleteRows = false
        Me.dgTasks.AllowUserToResizeRows = false
        Me.dgTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTasks.ContextMenuStrip = Me.cmsTasks
        Me.dgTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTasks.Location = New System.Drawing.Point(3, 3)
        Me.dgTasks.MultiSelect = false
        Me.dgTasks.Name = "dgTasks"
        Me.dgTasks.ReadOnly = true
        Me.dgTasks.RowTemplate.Height = 24
        Me.dgTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTasks.Size = New System.Drawing.Size(634, 167)
        Me.dgTasks.TabIndex = 0
        '
        'tsTasks
        '
        Me.tsTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsTasks.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsTasks.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsTasks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNewTask, Me.tsbtnTask, Me.tscmbDep, Me.tscmbExecutor, Me.tsbtnNewExec, Me.tsbtnTaskFinish, Me.tsbtnTaskDel})
        Me.tsTasks.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsTasks.Location = New System.Drawing.Point(914, 0)
        Me.tsTasks.Name = "tsTasks"
        Me.tsTasks.Size = New System.Drawing.Size(164, 173)
        Me.tsTasks.TabIndex = 1
        Me.tsTasks.Text = "ToolStrip3"
        '
        'tsbtnNewTask
        '
        Me.tsbtnNewTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewTask.Image = CType(resources.GetObject("tsbtnNewTask.Image"),System.Drawing.Image)
        Me.tsbtnNewTask.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewTask.Name = "tsbtnNewTask"
        Me.tsbtnNewTask.Size = New System.Drawing.Size(162, 22)
        Me.tsbtnNewTask.Text = "Новая задача"
        '
        'tsbtnTask
        '
        Me.tsbtnTask.CheckOnClick = true
        Me.tsbtnTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnTask.Image = CType(resources.GetObject("tsbtnTask.Image"),System.Drawing.Image)
        Me.tsbtnTask.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnTask.Name = "tsbtnTask"
        Me.tsbtnTask.Size = New System.Drawing.Size(162, 22)
        Me.tsbtnTask.Text = "Переназначить"
        '
        'tscmbDep
        '
        Me.tscmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbDep.DropDownWidth = 300
        Me.tscmbDep.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbDep.Name = "tscmbDep"
        Me.tscmbDep.Size = New System.Drawing.Size(159, 27)
        Me.tscmbDep.Visible = false
        '
        'tscmbExecutor
        '
        Me.tscmbExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbExecutor.DropDownWidth = 300
        Me.tscmbExecutor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbExecutor.Name = "tscmbExecutor"
        Me.tscmbExecutor.Size = New System.Drawing.Size(159, 27)
        Me.tscmbExecutor.Visible = false
        '
        'tsbtnNewExec
        '
        Me.tsbtnNewExec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnNewExec.Image = CType(resources.GetObject("tsbtnNewExec.Image"),System.Drawing.Image)
        Me.tsbtnNewExec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewExec.Name = "tsbtnNewExec"
        Me.tsbtnNewExec.Size = New System.Drawing.Size(161, 22)
        Me.tsbtnNewExec.Text = "Применить"
        Me.tsbtnNewExec.Visible = false
        '
        'tsbtnTaskFinish
        '
        Me.tsbtnTaskFinish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnTaskFinish.Image = CType(resources.GetObject("tsbtnTaskFinish.Image"),System.Drawing.Image)
        Me.tsbtnTaskFinish.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnTaskFinish.Name = "tsbtnTaskFinish"
        Me.tsbtnTaskFinish.Size = New System.Drawing.Size(162, 22)
        Me.tsbtnTaskFinish.Text = "Завершить"
        '
        'tsbtnTaskDel
        '
        Me.tsbtnTaskDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnTaskDel.Image = CType(resources.GetObject("tsbtnTaskDel.Image"),System.Drawing.Image)
        Me.tsbtnTaskDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnTaskDel.Name = "tsbtnTaskDel"
        Me.tsbtnTaskDel.Size = New System.Drawing.Size(162, 22)
        Me.tsbtnTaskDel.Text = "Удалить"
        '
        'txtTask
        '
        Me.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTask.Location = New System.Drawing.Point(643, 3)
        Me.txtTask.Multiline = true
        Me.txtTask.Name = "txtTask"
        Me.txtTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTask.Size = New System.Drawing.Size(268, 167)
        Me.txtTask.TabIndex = 2
        '
        'tpExpenses
        '
        Me.tpExpenses.Controls.Add(Me.TableLayoutPanel3)
        Me.tpExpenses.Location = New System.Drawing.Point(4, 29)
        Me.tpExpenses.Name = "tpExpenses"
        Me.tpExpenses.Size = New System.Drawing.Size(1078, 173)
        Me.tpExpenses.TabIndex = 5
        Me.tpExpenses.Text = "Затраты"
        Me.tpExpenses.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149!))
        Me.TableLayoutPanel3.Controls.Add(Me.dgExpensesOrder, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.tsExpenses, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1078, 173)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'dgExpensesOrder
        '
        Me.dgExpensesOrder.AllowUserToAddRows = false
        Me.dgExpensesOrder.AllowUserToDeleteRows = false
        Me.dgExpensesOrder.AllowUserToOrderColumns = true
        Me.dgExpensesOrder.AllowUserToResizeRows = false
        Me.dgExpensesOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgExpensesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExpensesOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgExpensesOrder.Location = New System.Drawing.Point(3, 3)
        Me.dgExpensesOrder.Name = "dgExpensesOrder"
        Me.dgExpensesOrder.ReadOnly = true
        Me.dgExpensesOrder.RowTemplate.Height = 24
        Me.dgExpensesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgExpensesOrder.Size = New System.Drawing.Size(923, 167)
        Me.dgExpensesOrder.TabIndex = 0
        '
        'tsExpenses
        '
        Me.tsExpenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsExpenses.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsExpenses.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsExpenses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnAddExpens, Me.tsbtnAddFile, Me.tsbtnOpenFileInv, Me.tsbtnDelExpens})
        Me.tsExpenses.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsExpenses.Location = New System.Drawing.Point(929, 0)
        Me.tsExpenses.Name = "tsExpenses"
        Me.tsExpenses.Size = New System.Drawing.Size(149, 173)
        Me.tsExpenses.TabIndex = 1
        Me.tsExpenses.Text = "ToolStrip4"
        '
        'tsbtnAddExpens
        '
        Me.tsbtnAddExpens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAddExpens.Image = CType(resources.GetObject("tsbtnAddExpens.Image"),System.Drawing.Image)
        Me.tsbtnAddExpens.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddExpens.Name = "tsbtnAddExpens"
        Me.tsbtnAddExpens.Size = New System.Drawing.Size(147, 22)
        Me.tsbtnAddExpens.Text = "Добавить затраты"
        '
        'tsbtnAddFile
        '
        Me.tsbtnAddFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAddFile.Image = CType(resources.GetObject("tsbtnAddFile.Image"),System.Drawing.Image)
        Me.tsbtnAddFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddFile.Name = "tsbtnAddFile"
        Me.tsbtnAddFile.Size = New System.Drawing.Size(147, 22)
        Me.tsbtnAddFile.Text = "Прикрепить файл"
        '
        'tsbtnOpenFileInv
        '
        Me.tsbtnOpenFileInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOpenFileInv.Image = CType(resources.GetObject("tsbtnOpenFileInv.Image"),System.Drawing.Image)
        Me.tsbtnOpenFileInv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOpenFileInv.Name = "tsbtnOpenFileInv"
        Me.tsbtnOpenFileInv.Size = New System.Drawing.Size(147, 22)
        Me.tsbtnOpenFileInv.Text = "Открыть файл"
        '
        'tsbtnDelExpens
        '
        Me.tsbtnDelExpens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelExpens.Image = CType(resources.GetObject("tsbtnDelExpens.Image"),System.Drawing.Image)
        Me.tsbtnDelExpens.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelExpens.Name = "tsbtnDelExpens"
        Me.tsbtnDelExpens.Size = New System.Drawing.Size(147, 22)
        Me.tsbtnDelExpens.Text = "Удалить "
        '
        'tpPayments
        '
        Me.tpPayments.Controls.Add(Me.TableLayoutPanel7)
        Me.tpPayments.Location = New System.Drawing.Point(4, 29)
        Me.tpPayments.Name = "tpPayments"
        Me.tpPayments.Size = New System.Drawing.Size(1078, 173)
        Me.tpPayments.TabIndex = 3
        Me.tpPayments.Text = "Оплата"
        Me.tpPayments.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149!))
        Me.TableLayoutPanel7.Controls.Add(Me.tlsPayment, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.dgPay, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1078, 173)
        Me.TableLayoutPanel7.TabIndex = 111
        '
        'tlsPayment
        '
        Me.tlsPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlsPayment.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlsPayment.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsPayment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnDelPay})
        Me.tlsPayment.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tlsPayment.Location = New System.Drawing.Point(929, 0)
        Me.tlsPayment.Name = "tlsPayment"
        Me.tlsPayment.Size = New System.Drawing.Size(149, 173)
        Me.tlsPayment.TabIndex = 110
        Me.tlsPayment.Text = "ToolStrip7"
        '
        'tsbtnDelPay
        '
        Me.tsbtnDelPay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDelPay.Image = CType(resources.GetObject("tsbtnDelPay.Image"),System.Drawing.Image)
        Me.tsbtnDelPay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelPay.Name = "tsbtnDelPay"
        Me.tsbtnDelPay.Size = New System.Drawing.Size(147, 22)
        Me.tsbtnDelPay.Text = "Откатить оплату"
        '
        'dgPay
        '
        Me.dgPay.AllowUserToAddRows = false
        Me.dgPay.AllowUserToDeleteRows = false
        Me.dgPay.AllowUserToResizeRows = false
        Me.dgPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgPay.Location = New System.Drawing.Point(3, 3)
        Me.dgPay.Name = "dgPay"
        Me.dgPay.ReadOnly = true
        Me.dgPay.RowTemplate.Height = 24
        Me.dgPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPay.Size = New System.Drawing.Size(923, 167)
        Me.dgPay.TabIndex = 111
        '
        'tpPurpose
        '
        Me.tpPurpose.Controls.Add(Me.tlpDescription)
        Me.tpPurpose.Location = New System.Drawing.Point(4, 29)
        Me.tpPurpose.Name = "tpPurpose"
        Me.tpPurpose.Size = New System.Drawing.Size(1078, 173)
        Me.tpPurpose.TabIndex = 2
        Me.tpPurpose.Text = "Описание"
        Me.tpPurpose.UseVisualStyleBackColor = true
        '
        'tlpDescription
        '
        Me.tlpDescription.ColumnCount = 2
        Me.tlpDescription.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpDescription.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149!))
        Me.tlpDescription.Controls.Add(Me.txtprim, 0, 1)
        Me.tlpDescription.Controls.Add(Me.tsPrim, 1, 0)
        Me.tlpDescription.Controls.Add(Me.txtPrepress, 0, 2)
        Me.tlpDescription.Controls.Add(Me.cmbTemplateDes, 0, 0)
        Me.tlpDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDescription.Location = New System.Drawing.Point(0, 0)
        Me.tlpDescription.Name = "tlpDescription"
        Me.tlpDescription.RowCount = 3
        Me.tlpDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDescription.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDescription.Size = New System.Drawing.Size(1078, 173)
        Me.tlpDescription.TabIndex = 106
        '
        'txtprim
        '
        Me.txtprim.BackColor = System.Drawing.SystemColors.Window
        Me.txtprim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtprim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtprim.Location = New System.Drawing.Point(3, 34)
        Me.txtprim.Multiline = true
        Me.txtprim.Name = "txtprim"
        Me.txtprim.ReadOnly = true
        Me.txtprim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtprim.Size = New System.Drawing.Size(923, 88)
        Me.txtprim.TabIndex = 105
        '
        'tsPrim
        '
        Me.tsPrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsPrim.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsPrim.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsPrim.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnSave, Me.tsbtnEdit, Me.tslblStatus})
        Me.tsPrim.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsPrim.Location = New System.Drawing.Point(929, 0)
        Me.tsPrim.Name = "tsPrim"
        Me.tlpDescription.SetRowSpan(Me.tsPrim, 2)
        Me.tsPrim.Size = New System.Drawing.Size(149, 125)
        Me.tsPrim.TabIndex = 106
        Me.tsPrim.Text = "ToolStrip5"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"),System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(147, 22)
        Me.tsbtnSave.Text = "Сохранить"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnEdit.Image = CType(resources.GetObject("tsbtnEdit.Image"),System.Drawing.Image)
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(147, 22)
        Me.tsbtnEdit.Text = "Изменить"
        '
        'tslblStatus
        '
        Me.tslblStatus.Name = "tslblStatus"
        Me.tslblStatus.Size = New System.Drawing.Size(147, 18)
        Me.tslblStatus.Text = "..."
        '
        'txtPrepress
        '
        Me.tlpDescription.SetColumnSpan(Me.txtPrepress, 2)
        Me.txtPrepress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrepress.Location = New System.Drawing.Point(3, 128)
        Me.txtPrepress.Multiline = true
        Me.txtPrepress.Name = "txtPrepress"
        Me.txtPrepress.ReadOnly = true
        Me.txtPrepress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPrepress.Size = New System.Drawing.Size(1072, 42)
        Me.txtPrepress.TabIndex = 107
        Me.txtPrepress.Visible = false
        '
        'cmbTemplateDes
        '
        Me.cmbTemplateDes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTemplateDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTemplateDes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTemplateDes.FormattingEnabled = true
        Me.cmbTemplateDes.Location = New System.Drawing.Point(3, 3)
        Me.cmbTemplateDes.Name = "cmbTemplateDes"
        Me.cmbTemplateDes.Size = New System.Drawing.Size(923, 25)
        Me.cmbTemplateDes.TabIndex = 108
        '
        'tpFiles
        '
        Me.tpFiles.Controls.Add(Me.tlpFiles)
        Me.tpFiles.Location = New System.Drawing.Point(4, 29)
        Me.tpFiles.Name = "tpFiles"
        Me.tpFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFiles.Size = New System.Drawing.Size(1078, 173)
        Me.tpFiles.TabIndex = 1
        Me.tpFiles.Text = "Файлы"
        Me.tpFiles.UseVisualStyleBackColor = true
        '
        'tlpFiles
        '
        Me.tlpFiles.ColumnCount = 2
        Me.tlpFiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpFiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpFiles.Controls.Add(Me.dgFiles, 0, 0)
        Me.tlpFiles.Controls.Add(Me.tlsFiles, 1, 0)
        Me.tlpFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFiles.Location = New System.Drawing.Point(3, 3)
        Me.tlpFiles.Name = "tlpFiles"
        Me.tlpFiles.RowCount = 1
        Me.tlpFiles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpFiles.Size = New System.Drawing.Size(1072, 167)
        Me.tlpFiles.TabIndex = 124
        '
        'dgFiles
        '
        Me.dgFiles.AllowUserToAddRows = false
        Me.dgFiles.AllowUserToDeleteRows = false
        Me.dgFiles.AllowUserToResizeRows = false
        Me.dgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFiles.ContextMenuStrip = Me.cmsFiles
        Me.dgFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFiles.Location = New System.Drawing.Point(3, 3)
        Me.dgFiles.MultiSelect = false
        Me.dgFiles.Name = "dgFiles"
        Me.dgFiles.ReadOnly = true
        Me.dgFiles.RowTemplate.Height = 24
        Me.dgFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFiles.Size = New System.Drawing.Size(904, 161)
        Me.dgFiles.TabIndex = 0
        '
        'cmsFiles
        '
        Me.cmsFiles.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsFiles.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbFiles, Me.СохранитьОписаниеToolStripMenuItem})
        Me.cmsFiles.Name = "cmsFiles"
        Me.cmsFiles.Size = New System.Drawing.Size(311, 60)
        '
        'tscmbFiles
        '
        Me.tscmbFiles.DropDownWidth = 200
        Me.tscmbFiles.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbFiles.Items.AddRange(New Object() {"Preview", "Файл заказчика", "На утверждение", "Рабочий макет", "Макет в печать", "Вывод", "Резка", "Клише"})
        Me.tscmbFiles.MaxDropDownItems = 16
        Me.tscmbFiles.Name = "tscmbFiles"
        Me.tscmbFiles.Size = New System.Drawing.Size(250, 28)
        '
        'СохранитьОписаниеToolStripMenuItem
        '
        Me.СохранитьОписаниеToolStripMenuItem.Name = "СохранитьОписаниеToolStripMenuItem"
        Me.СохранитьОписаниеToolStripMenuItem.Size = New System.Drawing.Size(310, 24)
        Me.СохранитьОписаниеToolStripMenuItem.Text = "Сохранить описание"
        '
        'tlsFiles
        '
        Me.tlsFiles.AutoSize = false
        Me.tlsFiles.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsFiles.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlsFiles.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmbFileDescript, Me.tsbtnAddFileWork, Me.ToolStripSeparator3, Me.tsbtnOpenFile, Me.tsbtnFileDel, Me.tsPbarCopyFiles, Me.tsbtnSaveFile})
        Me.tlsFiles.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tlsFiles.Location = New System.Drawing.Point(910, 0)
        Me.tlsFiles.Name = "tlsFiles"
        Me.tlsFiles.Size = New System.Drawing.Size(162, 121)
        Me.tlsFiles.TabIndex = 123
        Me.tlsFiles.Text = "ToolStrip8"
        '
        'tscmbFileDescript
        '
        Me.tscmbFileDescript.DropDownWidth = 220
        Me.tscmbFileDescript.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tscmbFileDescript.Items.AddRange(New Object() {"Preview", "Расчет", "Файл заказчика", "На утверждение", "Рабочий макет", "Макет в печать", "Вывод", "Резка", "Клише", "Смета"})
        Me.tscmbFileDescript.MaxDropDownItems = 16
        Me.tscmbFileDescript.Name = "tscmbFileDescript"
        Me.tscmbFileDescript.Size = New System.Drawing.Size(158, 24)
        '
        'tsbtnAddFileWork
        '
        Me.tsbtnAddFileWork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAddFileWork.Image = CType(resources.GetObject("tsbtnAddFileWork.Image"),System.Drawing.Image)
        Me.tsbtnAddFileWork.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddFileWork.Name = "tsbtnAddFileWork"
        Me.tsbtnAddFileWork.Size = New System.Drawing.Size(160, 22)
        Me.tsbtnAddFileWork.Text = "Добавить"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(160, 6)
        '
        'tsbtnOpenFile
        '
        Me.tsbtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOpenFile.Image = CType(resources.GetObject("tsbtnOpenFile.Image"),System.Drawing.Image)
        Me.tsbtnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOpenFile.Name = "tsbtnOpenFile"
        Me.tsbtnOpenFile.Size = New System.Drawing.Size(160, 22)
        Me.tsbtnOpenFile.Text = "Открыть файл"
        '
        'tsbtnFileDel
        '
        Me.tsbtnFileDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnFileDel.Image = CType(resources.GetObject("tsbtnFileDel.Image"),System.Drawing.Image)
        Me.tsbtnFileDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFileDel.Name = "tsbtnFileDel"
        Me.tsbtnFileDel.Size = New System.Drawing.Size(69, 22)
        Me.tsbtnFileDel.Text = "Удалить"
        '
        'tsPbarCopyFiles
        '
        Me.tsPbarCopyFiles.Name = "tsPbarCopyFiles"
        Me.tsPbarCopyFiles.Size = New System.Drawing.Size(204, 18)
        '
        'tsbtnSaveFile
        '
        Me.tsbtnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSaveFile.Image = CType(resources.GetObject("tsbtnSaveFile.Image"),System.Drawing.Image)
        Me.tsbtnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSaveFile.Name = "tsbtnSaveFile"
        Me.tsbtnSaveFile.Size = New System.Drawing.Size(112, 22)
        Me.tsbtnSaveFile.Text = "Сохранить как"
        '
        'tpSpec
        '
        Me.tpSpec.Controls.Add(Me.dgSpec)
        Me.tpSpec.Location = New System.Drawing.Point(4, 29)
        Me.tpSpec.Name = "tpSpec"
        Me.tpSpec.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSpec.Size = New System.Drawing.Size(1078, 173)
        Me.tpSpec.TabIndex = 0
        Me.tpSpec.Text = "Спецификация"
        Me.tpSpec.UseVisualStyleBackColor = true
        '
        'dgSpec
        '
        Me.dgSpec.AllowUserToAddRows = false
        Me.dgSpec.AllowUserToDeleteRows = false
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSpec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSpec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgSpec.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSpec.ContextMenuStrip = Me.cmsSpec
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSpec.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgSpec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSpec.Location = New System.Drawing.Point(3, 3)
        Me.dgSpec.MultiSelect = false
        Me.dgSpec.Name = "dgSpec"
        Me.dgSpec.ReadOnly = true
        Me.dgSpec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle6.NullValue = Nothing
        Me.dgSpec.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgSpec.RowTemplate.Height = 24
        Me.dgSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSpec.Size = New System.Drawing.Size(1072, 167)
        Me.dgSpec.TabIndex = 121
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tpSpec)
        Me.TabControl1.Controls.Add(Me.tpFiles)
        Me.TabControl1.Controls.Add(Me.tpPurpose)
        Me.TabControl1.Controls.Add(Me.tpPayments)
        Me.TabControl1.Controls.Add(Me.tpExpenses)
        Me.TabControl1.Controls.Add(Me.tpTasks)
        Me.TabControl1.Controls.Add(Me.tpRout)
        Me.TabControl1.Controls.Add(Me.tpDelivery)
        Me.TabControl1.Controls.Add(Me.tpMaterial)
        Me.TabControl1.Controls.Add(Me.tpDocumentErrorReports)
        Me.TabControl1.Controls.Add(Me.tpDir)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1086, 206)
        Me.TabControl1.TabIndex = 122
        '
        'tpDocumentErrorReports
        '
        Me.tpDocumentErrorReports.Controls.Add(Me.DocumentErrorRecords)
        Me.tpDocumentErrorReports.Location = New System.Drawing.Point(4, 29)
        Me.tpDocumentErrorReports.Name = "tpDocumentErrorReports"
        Me.tpDocumentErrorReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDocumentErrorReports.Size = New System.Drawing.Size(1078, 173)
        Me.tpDocumentErrorReports.TabIndex = 13
        Me.tpDocumentErrorReports.Text = "Проблемы с документами"
        Me.tpDocumentErrorReports.UseVisualStyleBackColor = true
        '
        'DocumentErrorRecords
        '
        Me.DocumentErrorRecords.AllowUserToAddRows = false
        Me.DocumentErrorRecords.AllowUserToDeleteRows = false
        Me.DocumentErrorRecords.AllowUserToResizeRows = false
        Me.DocumentErrorRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DocumentErrorRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocumentErrorRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentErrorRecords.Location = New System.Drawing.Point(3, 3)
        Me.DocumentErrorRecords.Name = "DocumentErrorRecords"
        Me.DocumentErrorRecords.ReadOnly = true
        Me.DocumentErrorRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DocumentErrorRecords.Size = New System.Drawing.Size(1072, 167)
        Me.DocumentErrorRecords.TabIndex = 0
        '
        'tpDir
        '
        Me.tpDir.Controls.Add(Me.tlpPath)
        Me.tpDir.Location = New System.Drawing.Point(4, 29)
        Me.tpDir.Name = "tpDir"
        Me.tpDir.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDir.Size = New System.Drawing.Size(1078, 173)
        Me.tpDir.TabIndex = 12
        Me.tpDir.Text = "Папки"
        Me.tpDir.UseVisualStyleBackColor = true
        '
        'tlpPath
        '
        Me.tlpPath.AutoSize = true
        Me.tlpPath.ColumnCount = 5
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPath.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpPath.Controls.Add(Me.txtPath1, 1, 0)
        Me.tlpPath.Controls.Add(Me.btnPath1, 2, 0)
        Me.tlpPath.Controls.Add(Me.Label11, 0, 0)
        Me.tlpPath.Controls.Add(Me.Button1, 3, 0)
        Me.tlpPath.Controls.Add(Me.Label14, 0, 1)
        Me.tlpPath.Controls.Add(Me.Label17, 0, 2)
        Me.tlpPath.Controls.Add(Me.txtPath2, 1, 1)
        Me.tlpPath.Controls.Add(Me.txtPath3, 1, 2)
        Me.tlpPath.Controls.Add(Me.btnPath2, 2, 1)
        Me.tlpPath.Controls.Add(Me.Button3, 3, 1)
        Me.tlpPath.Controls.Add(Me.btnPath3, 2, 2)
        Me.tlpPath.Controls.Add(Me.Button5, 3, 2)
        Me.tlpPath.Controls.Add(Me.Button2, 4, 0)
        Me.tlpPath.Controls.Add(Me.Button4, 4, 1)
        Me.tlpPath.Controls.Add(Me.Button6, 4, 2)
        Me.tlpPath.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPath.Location = New System.Drawing.Point(3, 3)
        Me.tlpPath.Name = "tlpPath"
        Me.tlpPath.RowCount = 3
        Me.tlpPath.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPath.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPath.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPath.Size = New System.Drawing.Size(1072, 97)
        Me.tlpPath.TabIndex = 0
        '
        'txtPath1
        '
        Me.txtPath1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPath1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPath1.Location = New System.Drawing.Point(199, 8)
        Me.txtPath1.Name = "txtPath1"
        Me.txtPath1.Size = New System.Drawing.Size(557, 21)
        Me.txtPath1.TabIndex = 0
        '
        'btnPath1
        '
        Me.btnPath1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPath1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnPath1.Location = New System.Drawing.Point(762, 3)
        Me.btnPath1.Name = "btnPath1"
        Me.btnPath1.Size = New System.Drawing.Size(111, 26)
        Me.btnPath1.TabIndex = 1
        Me.btnPath1.Text = "Задать папку"
        Me.btnPath1.UseVisualStyleBackColor = true
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 32)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Исходная папка"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button1.Location = New System.Drawing.Point(879, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Открыть"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(190, 32)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Финальная папка клиента"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(190, 33)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Папка спуска"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPath2
        '
        Me.txtPath2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPath2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPath2.Location = New System.Drawing.Point(199, 40)
        Me.txtPath2.Name = "txtPath2"
        Me.txtPath2.Size = New System.Drawing.Size(557, 21)
        Me.txtPath2.TabIndex = 7
        '
        'txtPath3
        '
        Me.txtPath3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPath3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPath3.Location = New System.Drawing.Point(199, 73)
        Me.txtPath3.Name = "txtPath3"
        Me.txtPath3.Size = New System.Drawing.Size(557, 21)
        Me.txtPath3.TabIndex = 8
        '
        'btnPath2
        '
        Me.btnPath2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPath2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnPath2.Location = New System.Drawing.Point(762, 35)
        Me.btnPath2.Name = "btnPath2"
        Me.btnPath2.Size = New System.Drawing.Size(111, 26)
        Me.btnPath2.TabIndex = 9
        Me.btnPath2.Text = "Задать папку"
        Me.btnPath2.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button3.Location = New System.Drawing.Point(879, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 26)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Открыть"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'btnPath3
        '
        Me.btnPath3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPath3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnPath3.Location = New System.Drawing.Point(762, 67)
        Me.btnPath3.Name = "btnPath3"
        Me.btnPath3.Size = New System.Drawing.Size(111, 27)
        Me.btnPath3.TabIndex = 11
        Me.btnPath3.Text = "Задать папку"
        Me.btnPath3.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button5.Location = New System.Drawing.Point(879, 67)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 27)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Открыть"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button2.Location = New System.Drawing.Point(977, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 26)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Сохранить"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button4.Location = New System.Drawing.Point(977, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 26)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Сохранить"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button6.Location = New System.Drawing.Point(977, 67)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 27)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Сохранить"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Выберите папку исходных файлов"
        '
        'FolderBrowserDialog2
        '
        Me.FolderBrowserDialog2.Description = "Выберите финальную папку"
        '
        'FolderBrowserDialog3
        '
        Me.FolderBrowserDialog3.Description = "Выберите папку спуска полос"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = true
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblCostNumber, Me.tstxtCostNumber, Me.tslblAdditionalNumber, Me.tstxtAdditionalNumber})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 31)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1086, 30)
        Me.MenuStrip2.TabIndex = 124
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'tslblCostNumber
        '
        Me.tslblCostNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tslblCostNumber.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tslblCostNumber.Name = "tslblCostNumber"
        Me.tslblCostNumber.ReadOnly = true
        Me.tslblCostNumber.Size = New System.Drawing.Size(116, 26)
        Me.tslblCostNumber.Text = "НОМЕР ЗАКАЗА"
        '
        'tstxtCostNumber
        '
        Me.tstxtCostNumber.AutoSize = false
        Me.tstxtCostNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tstxtCostNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostNumber.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtCostNumber.Name = "tstxtCostNumber"
        Me.tstxtCostNumber.ReadOnly = true
        Me.tstxtCostNumber.Size = New System.Drawing.Size(230, 26)
        '
        'tslblAdditionalNumber
        '
        Me.tslblAdditionalNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tslblAdditionalNumber.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tslblAdditionalNumber.Margin = New System.Windows.Forms.Padding(25, 0, 1, 0)
        Me.tslblAdditionalNumber.Name = "tslblAdditionalNumber"
        Me.tslblAdditionalNumber.ReadOnly = true
        Me.tslblAdditionalNumber.Size = New System.Drawing.Size(110, 26)
        Me.tslblAdditionalNumber.Text = "ДОП. НОМЕРА"
        '
        'tstxtAdditionalNumber
        '
        Me.tstxtAdditionalNumber.AutoSize = false
        Me.tstxtAdditionalNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tstxtAdditionalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtAdditionalNumber.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtAdditionalNumber.Name = "tstxtAdditionalNumber"
        Me.tstxtAdditionalNumber.ReadOnly = true
        Me.tstxtAdditionalNumber.Size = New System.Drawing.Size(230, 26)
        '
        'OrderClosedContextMenuStrip
        '
        Me.OrderClosedContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RevertCloseItem})
        Me.OrderClosedContextMenuStrip.Name = "OrderClosedContextMenuStrip"
        Me.OrderClosedContextMenuStrip.Size = New System.Drawing.Size(214, 28)
        '
        'RevertCloseItem
        '
        Me.RevertCloseItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RevertCloseItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.RevertCloseItem.Name = "RevertCloseItem"
        Me.RevertCloseItem.Size = New System.Drawing.Size(213, 24)
        Me.RevertCloseItem.Text = "Отменить закрытие"
        '
        'OrderCancelledContextMenuStrip
        '
        Me.OrderCancelledContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RevertCancelledItem})
        Me.OrderCancelledContextMenuStrip.Name = "OrderCancelledContextMenuStrip"
        Me.OrderCancelledContextMenuStrip.Size = New System.Drawing.Size(259, 28)
        '
        'RevertCancelledItem
        '
        Me.RevertCancelledItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.RevertCancelledItem.Name = "RevertCancelledItem"
        Me.RevertCancelledItem.Size = New System.Drawing.Size(258, 24)
        Me.RevertCancelledItem.Text = "Отменить аннулирование"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 61)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1086, 676)
        Me.SplitContainer2.SplitterDistance = 466
        Me.SplitContainer2.TabIndex = 0
        '
        'frmOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(1086, 761)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1074, 740)
        Me.Name = "frmOrder"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.tlpCommonParam.ResumeLayout(false)
        Me.TimeGroupBox.ResumeLayout(false)
        Me.TimeTableLayoutPanel.ResumeLayout(false)
        Me.TimeTableLayoutPanel.PerformLayout
        Me.CustomerGroupBox.ResumeLayout(false)
        Me.CustomerTableLayoutPanel.ResumeLayout(false)
        Me.CustomerTableLayoutPanel.PerformLayout
        Me.ExecutorGroupBox.ResumeLayout(false)
        Me.ExecutorTableLayoutPanel.ResumeLayout(false)
        Me.ExecutorTableLayoutPanel.PerformLayout
        Me.ParametersGroupBox.ResumeLayout(false)
        Me.ParametersTableLayoutPanel.ResumeLayout(false)
        Me.ParametersTableLayoutPanel.PerformLayout
        Me.PaymentMethodsFlowLayoutPanel.ResumeLayout(false)
        Me.tsControl.ResumeLayout(false)
        Me.tsControl.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.cmsSpec.ResumeLayout(false)
        Me.cmsTasks.ResumeLayout(false)
        CType(Me.dsEmplWork,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataTable1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpMaterial.ResumeLayout(false)
        CType(Me.dgMatExpens,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpDelivery.ResumeLayout(false)
        Me.tlpDelivery.ResumeLayout(false)
        Me.tlpDelivery.PerformLayout
        Me.ToolStrip6.ResumeLayout(false)
        Me.ToolStrip6.PerformLayout
        CType(Me.dgDostavka,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpRout.ResumeLayout(false)
        Me.tlpRouting.ResumeLayout(false)
        Me.tlpRouting.PerformLayout
        CType(Me.dgOrderRout,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip4.ResumeLayout(false)
        Me.ToolStrip4.PerformLayout
        Me.tpTasks.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.TableLayoutPanel4.PerformLayout
        CType(Me.dgTasks,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsTasks.ResumeLayout(false)
        Me.tsTasks.PerformLayout
        Me.tpExpenses.ResumeLayout(false)
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.TableLayoutPanel3.PerformLayout
        CType(Me.dgExpensesOrder,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsExpenses.ResumeLayout(false)
        Me.tsExpenses.PerformLayout
        Me.tpPayments.ResumeLayout(false)
        Me.TableLayoutPanel7.ResumeLayout(false)
        Me.TableLayoutPanel7.PerformLayout
        Me.tlsPayment.ResumeLayout(false)
        Me.tlsPayment.PerformLayout
        CType(Me.dgPay,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpPurpose.ResumeLayout(false)
        Me.tlpDescription.ResumeLayout(false)
        Me.tlpDescription.PerformLayout
        Me.tsPrim.ResumeLayout(false)
        Me.tsPrim.PerformLayout
        Me.tpFiles.ResumeLayout(false)
        Me.tlpFiles.ResumeLayout(false)
        CType(Me.dgFiles,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsFiles.ResumeLayout(false)
        Me.tlsFiles.ResumeLayout(false)
        Me.tlsFiles.PerformLayout
        Me.tpSpec.ResumeLayout(false)
        CType(Me.dgSpec,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl1.ResumeLayout(false)
        Me.tpDocumentErrorReports.ResumeLayout(false)
        CType(Me.DocumentErrorRecords,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpDir.ResumeLayout(false)
        Me.tpDir.PerformLayout
        Me.tlpPath.ResumeLayout(false)
        Me.tlpPath.PerformLayout
        Me.MenuStrip2.ResumeLayout(false)
        Me.MenuStrip2.PerformLayout
        Me.OrderClosedContextMenuStrip.ResumeLayout(false)
        Me.OrderCancelledContextMenuStrip.ResumeLayout(false)
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

#Region " Загрузка, закрытие и активация формы "
    Private Sub frmOrder_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If avarExit = False Then
            LoadOrder() 'загрузка общих параметров
            LoadTechParametr() 'загрузка спецификации
            PayOrder()
            LoadOrderRout()
            RasxodMat()
            LoadExpensesOrder()
            LoadDostavka()
            LoadDocumentErrorRecords()

            Select Case avansRealOrder
                Case Is = 0
                    Me.tsslBalansKA.Visible = False
                Case Is = 1
                    Me.tsslBalansKA.Visible = False
                Case Is = 2
                    Me.tsslBalansKA.Visible = True
                    Me.tsslBalansKA.Text = "Кредитный лимит: " + CStr(Format(NonQuery1Scalar("Select dbo.[kreditVirtMDM](" & custID & ", " & costID & ")"), "C"))
            End Select

            Me.txtPlannedExecutionDate.Text = Module1.NonQuery1ScalarString("SELECT [dbo].[costDuration](" & costID & ")") '"d"'кто когда выдал заказ

            allow = True

            Me.Opacity = 1
            RefreshLastRoutWidth()
        End If
    End Sub

    Private Sub frmOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.tsControl.Renderer = New CustomProfessionalRenderer()

        Me.StatusStrip1.Visible = visibleCostOrder
        Me.lblCustomerPhone1.Visible = visibleContact
        Me.txtCustomerPhone1.Visible = visibleContact
        Me.lblCustomerPhone2.Visible = visibleContact
        Me.txtCustomerPhone2.Visible = visibleContact
        Me.lblCustomerEmail.Visible = visibleContact
        Me.txtCustomerEmail.Visible = visibleContact
        Me.СкидкаToolStripMenuItem.Visible = True
        Me.ОтказОтЗаказаToolStripMenuItem1.Enabled = CanceledOrder
        Me.CancelCostItem.Enabled = CanceledOrder

        Dim curPar As Boolean

        If postPrioritet = 1 Then
            Me.tlsPayment.Visible = True
        Else
            Me.tlsPayment.Visible = rulesPayments
        End If

        Select Case prava
            Case Is = 0 'Видит все заказы, редактирует все
                curPar = True
            Case Is = 1 'Видит все заказы, редактирует свои
                If emplIDcurrent = emplID Then curPar = True Else curPar = False
            Case Is = 2 'Видит и редактирует только свои заказы
                curPar = True
            Case Is = 3 'Видит но не редактирует свои заказы
                curPar = False
            Case Is = 4 ' видит все заказы всех офисов
                curPar = True
        End Select

        Me.tsbtnDelRout.Enabled = CanDeleteRouts

        Me.tscmbStatus.Enabled = curPar
        If (tscmbStatus.Enabled) Then
            tscmbStatus.BackColor = SystemColors.Window
        Else
            tscmbStatus.BackColor = SystemColors.Control
        End If

        Try
            Dim odaStatus As New SqlClient.SqlDataAdapter("SELECT statusID, status FROM Statuses", mcnnInt)
            Dim dtStatus As New DataTable
            odaStatus.Fill(dtStatus)

            Me.tscmbStatus.ComboBox.DataSource = dtStatus
            Me.tscmbStatus.ComboBox.DisplayMember = Trim("status")
            Me.tscmbStatus.ComboBox.ValueMember = "statusID"
            allowStatusChange = False
            Me.tscmbStatus.ComboBox.SelectedValue = Module1.NonQuery1Scalar("SELECT StatusID FROM Costs WHERE costID=" & costID & "")

            Dim odaServices As New SqlClient.SqlDataAdapter("SELECT ID, name FROM Services WHERE active<>0 order by name", mcnnInt)
            Dim dtServices As New DataTable : odaServices.Fill(dtServices)
            Me.tscmbServices.ComboBox.DataSource = dtServices    'Связать данные со списком
            Me.tscmbServices.ComboBox.DisplayMember = "name"
            Me.tscmbServices.ComboBox.ValueMember = "ID"
            Me.tscmbServices.ComboBox.SelectedIndex = -1

            allowStatusChange = True

            Dim odaDoc As New SqlClient.SqlDataAdapter("SELECT ID, name FROM TypesDocument WHERE active=1 AND TZ=1 order by name", mcnnInt)
            Dim dtDoc As New DataTable : odaDoc.Fill(dtDoc)
            Me.tscmbDoc.ComboBox.DataSource = dtDoc
            Me.tscmbDoc.ComboBox.DisplayMember = "name"
            Me.tscmbDoc.ComboBox.ValueMember = "ID"
            Me.tscmbDoc.ComboBox.SelectedIndex = -1

            Dim odaDepartment As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Departments order by name", mcnnInt)
            Dim dtDepartments As New DataTable : odaDepartment.Fill(dtDepartments)
            Me.cmbDepartment.DataSource = dtDepartments 'Связать данные со списком
            Me.cmbDepartment.DisplayMember = "Name"
            Me.cmbDepartment.ValueMember = "ID"

            Dim odaDepartment1 As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Departments order by name", mcnnInt)
            Dim dtDepartments1 As New DataTable : odaDepartment1.Fill(dtDepartments1)
            Me.tscmbDep.ComboBox.DataSource = dtDepartments1 'Связать данные со списком
            Me.tscmbDep.ComboBox.DisplayMember = "Name"
            Me.tscmbDep.ComboBox.ValueMember = "ID"

            Dim odaProd As New SqlClient.SqlDataAdapter("SELECT ID,desTemplName FROM DescriptionTemlate order by desTemplName", mcnnInt)
            Dim dtProd As New DataTable : odaProd.Fill(dtProd)

            Me.cmbTemplateDes.DataSource = dtProd 'Связать данные со списком
            Me.cmbTemplateDes.DisplayMember = "desTemplName"
            Me.cmbTemplateDes.ValueMember = "ID"
        Catch oexpData As System.Exception
            MessageBox.Show("Ошибка при загрузке списка: " & oexpData.Message, appName)
        End Try

        Me.tsslKogdaVydan.Visible = True
        Me.tsslKogdaVydan.Text = Module1.NonQuery1ScalarString("SELECT coalesce(prepress,'н/д') FROM Costs WHERE costID=" & costID & "") '"d"'кто когда выдал заказ

        Select Case avansRealOrder
            Case Is = 0
                Me.tsslBalansKA.Visible = False
            Case Is = 1
                Me.tsslBalansKA.Visible = False
            Case Is = 2
                Me.tsslBalansKA.Visible = True
                Me.tsslBalansKA.Text = "Кредитный лимит: " + CStr(Format(NonQuery1Scalar("Select dbo.[kreditVirtMDM](" & custID & ", " & costID & ")"), "C"))
        End Select

        SetEnabledForOnlinePaymentButtons()
        LoadDostavka()
        LoadFiles()
        LoadTasks()
        Open_Order() ' запись о том кто и когда открывал заказ
    End Sub

    Private Sub SetEnabledForOnlinePaymentButtons()
        mdmprintPayButton.Enabled = CanUseMdmOnlinePayments
        tsbtnRobokassa.Enabled = CanUseEnjoyOnlinePayments
        tsbtnRobokassa1.Enabled = CanUseAdditionalMdmOnlinePayments
    End Sub

    Private Sub frmOrder_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If avarExit = True Then
            costID = Nothing
            custID = Nothing
            skidkaCust = 0
            e.Cancel = False
        Else
            ' Блокируем закрытие формы, если происходит копирование
            If BackgroundWorker1.IsBusy Then
                MessageBox.Show("Выполняется копирование файла.", appName)
                e.Cancel = True
            End If
            
            If Me.txtprim.ReadOnly = False Then
                SavePrim("")
            End If

            If Me.tscmbStatus.ComboBox.SelectedItem(0) <> 4 Then
                If MsgBox(Prompt:="Состояние заказа- " & Trim(Me.tscmbStatus.ComboBox.Text) & "?", Buttons:=vbYesNo, Title:=appName) = vbYes Then
                    costID = Nothing
                    custID = Nothing
                    skidkaCust = 0
                Else
                    allow = False 'игнорируем активацию
                    e.Cancel = True ' чтоб предотвратить закрытие формы
                End If
            End If
        End If
    End Sub
#End Region

#Region " Спецификация "
    Private Sub LoadTechParametr() 'Загружаем спецификацию по данному заказу
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_FillSpec"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)

            dsTZ.Cost.Clear()
            objDA.Fill(dsTZ, "Cost")

            If dsTZ.Cost.Rows.Count > 0 Then
                Me.dgSpec.DataSource = dsTZ.Cost
                cost = dsTZ.Cost.Compute("SUM(Стоимость)", "")

                Me.tscmbStatus.ComboBox.Enabled = IsEnabledForEditingWithCancelledOrder()
                tscmbStatus.BackColor = SystemColors.Window

                If currentStatus <= 2 Then
                    Me.cmsSpec.Enabled = True
                Else
                    If postPrioritet = 1 Or EditSpec = True Then
                        Me.cmsSpec.Enabled = True
                        Me.tscmbServices.Enabled = True
                    Else
                        Me.cmsSpec.Enabled = False
                        Me.tscmbServices.Enabled = False
                    End If
                End If

            Else
                cost = 0
                Me.tscmbStatus.ComboBox.Enabled = False
                Me.tscmbStatus.BackColor = SystemColors.Control
                Me.cmsSpec.Enabled = False
            End If

            ColHideDG(dgSpec)

            Me.tsslOrderCost.Text = "Сумма заказа: " + Format(cost, "C")
        Catch excp As System.Exception
            MessageBox.Show("Спецификация-" + excp.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub УдалитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьToolStripMenuItem.Click
        If currentStatus > 2 Then
            If EditSpec = True Or postPrioritet = 1 Then
                DelRowSpec()
            Else
                MsgBox("Для удаления строки спецификации заказ необходимо перевести в состояние Расчет.", MsgBoxStyle.Critical, appName) : Exit Sub
            End If
        Else
            DelRowSpec()
        End If
    End Sub

    Private Sub DelRowSpec()
        Dim curInd% = Me.dgSpec.CurrentRow.Index

        Select Case MsgBox(Prompt:="Удалить " & CStr(Me.dgSpec(2, curInd).Value()) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM Orders WHERE ordID=" & Me.dgSpec("ordID", curInd).Value() & " ")

                LoadTechParametr()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub РедактироватьToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles РедактироватьToolStripMenuItem1.Click
        EditSpecBegin()
    End Sub

    Private Sub EditSpecBegin()
        If currentStatus <= 2 Then
            Dim str As String = ""
            Dim frmSelect As New frmOrderSpecEdit

            frmSelect.strID = str
            frmSelect.ShowDialog()
        Else
            If postPrioritet = 1 Then
                Dim str As String = ""
                Dim frmSelect As New frmOrderSpecEdit

                frmSelect.strID = str
                frmSelect.ShowDialog()
            Else
                MsgBox("Редактирование спецификации запрещено.", MsgBoxStyle.Critical, appName)
            End If

        End If
    End Sub
#End Region

    Private Sub LoadDocumentErrorRecords()
        Dim strSQL$ = "SELECT emp.emplLastName Сотрудник, der.dateAndTime Дата, der.description Описание FROM DocumentErrorRecords der INNER JOIN Employees emp ON der.employeeID = emp.emplID WHERE der.costID = " & costID & ";"
        Dim odaMat As New SqlDataAdapter(strSQL, mcnnInt)
        Dim dtR As New DataTable : odaMat.Fill(dtR)
        DocumentErrorRecords.DataSource = dtR
        DocumentErrorRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        AddHandler DocumentErrorRecords.CellMouseEnter, AddressOf DocumentErrorRecords_CellMouseEnter
        AddHandler DocumentErrorRecords.CellMouseLeave, AddressOf DocumentErrorRecords_CellMouseLeave
    End Sub

    Private Sub DocumentErrorRecords_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs)
        ToolTip1.Hide(DocumentErrorRecords)
    End Sub

    Private Sub DocumentErrorRecords_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
        If (e.ColumnIndex >= 0 And e.RowIndex >= 0) Then
            Dim cell As DataGridViewCell = DocumentErrorRecords(e.ColumnIndex, e.RowIndex)
            If (cell.ContentBounds.Size.Width + 1 < cell.PreferredSize.Width) Then
                Dim cellDisplayRect = DocumentErrorRecords.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
                ToolTip1.Show(String.Format(DocumentErrorRecords.Rows(e.RowIndex).Cells(e.ColumnIndex).Value),
                        DocumentErrorRecords,
                        cellDisplayRect.X + cell.Size.Width / 2,
                        cellDisplayRect.Y + cell.Size.Height / 2
                        )
                DocumentErrorRecords.ShowCellToolTips = False
            End If
        End If
    End Sub

#Region "Доступность к контролам в заказе"
    Private Sub SetEnabledForOrder()
        Dim allowCancelled As Boolean = IsEnabledForEditingWithCancelledOrder()
        Dim allowClosed As Boolean = IsEnabledForEditingWithClosedOrder()
        Dim allowCancelledAndClosed As Boolean = (allowCancelled And allowClosed)

        tscmbServices.Enabled = allowCancelledAndClosed
        РедактироватьToolStripMenuItem.Enabled = allowCancelled
        БракToolStripMenuItem1.Enabled = allowCancelled
        ЗаказToolStripMenuItem.Enabled = allowCancelledAndClosed

        dgSpec.ReadOnly = Not allowClosed
        cmsSpec.Enabled = allowClosed
        Me.tsPrim.Enabled = allowClosed
        Me.tlsPayment.Enabled = allowClosed
        Me.tsExpenses.Enabled = allowClosed
        Me.tsTasks.Enabled = allowClosed
        Me.tlpDelivery.Enabled = allowClosed

        tscmbStatus.Visible = allowClosed
        tscmbStatus.ComboBox.Enabled = allowCancelled
        ToolStripSeparator4.Visible = allowClosed
        tscmbDoc.Enabled = allowCancelledAndClosed
        tsbtnPrintTZ.Enabled = allowCancelledAndClosed
        tsbtnPrintLabel.Enabled = allowCancelledAndClosed
        tsbtnDocuments.Enabled = allowCancelled
        mdmprintPayButton.Enabled = allowCancelledAndClosed
        tsbtnRobokassa.Enabled = allowCancelledAndClosed
        tsbtnRobokassa1.Enabled = allowCancelledAndClosed
        tsbtnInputPay.Enabled = allowCancelledAndClosed
        tsbtnSendSMS.Enabled = allowCancelledAndClosed

        РедактироватьToolStripMenuItem1.Enabled = allowCancelled
        УдалитьToolStripMenuItem.Enabled = allowCancelled
        УдалитьВсеToolStripMenuItem.Enabled = allowCancelled

        tscmbFiles.ComboBox.Enabled = allowCancelled
        СохранитьОписаниеToolStripMenuItem.Enabled = allowCancelled

        НоваяЗадачаToolStripMenuItem.Enabled = allowCancelled
        УдалитьЗадачиToolStripMenuItem.Enabled = allowCancelled
        КопироватьОписаниеToolStripMenuItem.Enabled = allowCancelled
        Отсрочка1ДеньToolStripMenuItem.Enabled = allowCancelled

        tscmbFileDescript.ComboBox.Enabled = allowCancelled
        tsbtnAddFileWork.Enabled = allowCancelled
        tsbtnOpenFile.Enabled = allowCancelled
        tsbtnFileDel.Enabled = allowCancelled
        tsPbarCopyFiles.ProgressBar.Enabled = allowCancelled
        tsbtnSaveFile.Enabled = allowCancelled

        tsbtnSave.Enabled = allowCancelled
        tsbtnEdit.Enabled = allowCancelled
        tslblStatus.Enabled = allowCancelled

        tsbtnDelPay.Enabled = allowCancelled

        tsbtnAddExpens.Enabled = allowCancelled
        tsbtnAddFile.Enabled = allowCancelled
        tsbtnOpenFileInv.Enabled = allowCancelled
        tsbtnDelExpens.Enabled = allowCancelled

        tsbtnNewTask.Enabled = allowCancelled
        tsbtnTask.Enabled = allowCancelled
        tscmbDep.ComboBox.Enabled = allowCancelled
        tscmbExecutor.Enabled = allowCancelled
        tsbtnNewExec.Enabled = allowCancelled
        tsbtnTaskFinish.Enabled = allowCancelled
        tsbtnTaskDel.Enabled = allowCancelled

        tsbtnRoutApply.Enabled = allowCancelled
        tsbtnDelRout.Enabled = (CanDeleteRouts And allowCancelled)

        ToolStripButton3.Enabled = allowCancelled
        tsbtnUpdateDostavka.Enabled = allowCancelled

        btnPath1.Enabled = allowCancelled
        btnPath2.Enabled = allowCancelled
        btnPath3.Enabled = allowCancelled
        Button1.Enabled = allowCancelled
        Button2.Enabled = allowCancelled
        Button3.Enabled = allowCancelled
        Button4.Enabled = allowCancelled
        Button5.Enabled = allowCancelled
        Button6.Enabled = allowCancelled
    End Sub

    Private Function IsEnabledForEditingWithCancelledOrder() As Boolean
        Return ((Not orderCancelled) OR CanEditCancelledOrders)
    End Function

    Private Function IsEnabledForEditingWithClosedOrder() As Boolean
        Return ((Not orderClosed) Or editClosedOrders)
    End Function
#End Region


#Region " Общие параметры заказа "
    Private Sub LoadOrder()
        If Me.txtprim.ReadOnly = False Then
            SavePrim("")
        End If

        Try
            dsTZ.Order.Clear()

            FillFromSP("sp_Order_FillComParam", "Order")

            If dsTZ.Tables("Order").Rows.Count > 0 Then
                mdrOrderIndiv = dsTZ.Order.Rows(0)   'Получить отдельную строку данных
            Else
                MsgBox("Идентификатор заказа не определен или заказ не существует. Обратитесь в техническую поддержку.", MsgBoxStyle.Critical, appName)
                avarExit = True

                Me.Close()
            End If

            Me.dtpDateOfLayoutReady.Value = mdrOrderIndiv("UtvMaket")
            Me.dtpDateOfProductionReady.Value = mdrOrderIndiv("productionDate")
            Me.dtpDateOfIssue.Value = mdrOrderIndiv("Vydaha")
            If (mdrOrderIndiv("isExpress")) Then
                lblOrderIsExpress.Visible = True
            Else
                lblOrderIsExpress.Visible = False
            End If

            Me.txtContractor.Text = mdrOrderIndiv("custname")
            Me.txtContactPerson.Text = mdrOrderIndiv("emplcust")
            Me.txtCustomerPhone1.Text = mdrOrderIndiv("TelEmplCust1")
            Me.txtCustomerPhone2.Text = mdrOrderIndiv("TelEmplCust2")
            Me.txtCustomerEmail.Text = mdrOrderIndiv("emailEmpl")
            Try
                Me.txtCustomerPerson.Text = mdrOrderIndiv("custPerson")
            Catch orxp As Exception
                Me.txtCustomerPerson.Text = "Нет"
            End Try

            Me.txtManager.Text = mdrOrderIndiv("emplLastName")
            Me.txtContactNumber.Text = mdrOrderIndiv("managerPhone")
            Me.txtInternalNumber.Text = mdrOrderIndiv("managerInternalPhone")
            Me.txtExecutorEmail.Text = mdrOrderIndiv("managerEmail")
            Me.txtExecutor.Text = mdrOrderIndiv("executor")
            Me.txtExecutorPerson.Text = mdrOrderIndiv("org")

            'Реальный заказ(0), Виртуальный заказ(1), Авансовая оплата(2)
            If (mdrOrderIndiv("typeCostIndex") = 0) Then
                txtOrderType.Text = "Реальный заказ"
            ElseIf(mdrOrderIndiv("typeCostIndex") = 1) Then
                txtOrderType.Text = "Виртуальный заказ"
            Else
                txtOrderType.Text = "Авансовая оплата"
            End If
            Me.txtOrderSource.Text = mdrOrderIndiv("SourseOrder")
            Me.txtCommentForIssue.Text = mdrOrderIndiv("nomVN2")
            
            If (Not IsDBNull(mdrOrderIndiv("issueName"))) Then
                Me.lblIssuePlaceValue.Text = mdrOrderIndiv("issueName")
            Else
                Me.lblIssuePlaceValue.Text = ""
            End If

            If (mdrOrderIndiv("countOfCashPayments") > 0) Then
                chkCashPaymentMethod.Checked = True
            Else
                chkCashPaymentMethod.Checked = False
            End If

            If (mdrOrderIndiv("countOfNonCashPayments") > 0) Then
                chkNonCashPaymentMethod.Checked = True
            Else
                chkNonCashPaymentMethod.Checked = False
            End If

            If (mdrOrderIndiv("countOfOnlinePayments") > 0) Then
                chkOnlinePaymentMethod.Checked = True
            Else
                chkOnlinePaymentMethod.Checked = False
            End If

            If (chkCashPaymentMethod.Checked = False And
                chkNonCashPaymentMethod.Checked = False And
                chkOnlinePaymentMethod.Checked = False) Then
                chkNotDonePaymentMethod.Checked = True
            Else
                chkNotDonePaymentMethod.Checked = False
            End If

            If Not IsDBNull(mdrOrderIndiv("isDocumentHasError")) Then
                chkDocumentHasError.Checked = mdrOrderIndiv("isDocumentHasError")
            End If

            nomVn = mdrOrderIndiv("nomerVN")

            If mdrOrderIndiv("MinCost") = "поставщик" Then
                MinCost = 0
            Else
                MinCost = mdrOrderIndiv("MinCost")
            End If

            custID = mdrOrderIndiv("ID")
            emplIDcurrent = mdrOrderIndiv("emplID") ' ID менеджера
            emplIDexecute = mdrOrderIndiv("emplDesignerID") ' ID исполнителя
            currentStatus = mdrOrderIndiv("statusID") 'запоминаем текущее состояние заказа
            avansRealOrder = mdrOrderIndiv("typeCostIndex")

            ChangeRoutApplyEnabled()

            Me.txtprim.Text = mdrOrderIndiv("Purpose")
            Me.txtPrepress.Text = mdrOrderIndiv("prepress")

            If (Not IsDBNull(mdrOrderIndiv("nomVN3"))) Then
                Me.tstxtAdditionalNumber.Text = mdrOrderIndiv("nomVN3")
            End If

            If (Not IsDBNull(mdrOrderIndiv("nomerVN"))) Then
                Me.tstxtCostNumber.Text = mdrOrderIndiv("nomerVN")
            End If

            orderClosed = mdrOrderIndiv("orderClosed")
            If orderClosed = True Then
                Me.tslOpenClose.Text = "Закрыт"
                Me.tslOpenClose.ForeColor = Color.Green

                'возможность редактирования закрытый заказ
                'If editClosedOrders <> True Then
                '    OpenClose(True)
                'End If
            Else
                Me.tslOpenClose.Text = "Не закрыт"
                Me.tslOpenClose.ForeColor = Color.Red

                If mdrOrderIndiv("statusID") = 1 Then
                    Me.tscmbServices.Enabled = True
                Else
                    Me.tsSLDolgi.Visible = True
                End If
            End If

            orderCancelled = mdrOrderIndiv("cancelled")
            If orderCancelled = True Then
                Me.tslCanceledOrder.Text = "Аннулирован"
                Me.tslCanceledOrder.BackColor = Color.FromArgb(245,227,227)
                Me.tslCanceledOrder.Enabled = True

                'If (Not CanEditCancelledOrders) Then
                '    SetEnabledForCancelledOrder()
                'End If
            Else
                Me.tslCanceledOrder.Text = "Не аннулирован"
                Me.tslCanceledOrder.BackColor = Color.Transparent
                Me.tslCanceledOrder.Enabled = False
            End If

            SetEnabledForOrder()

            '*********************************txtexecutor
            Me.Text = "Заказ №  " + nomVn + " от " + CStr(Format(mdrOrderIndiv("date_cr"), "dd.MM.yyyy HH:mm"))
        Catch excData As System.Exception
            MessageBox.Show("Загрузка основных параметров.  " + excData.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub ChangeRoutApplyEnabled()

        If (currentStatus = 3) Then
            tsbtnRoutApply.Enabled = CanChangeRoutsInReadyOrder
        ElseIf (currentStatus = 4) Then
            tsbtnRoutApply.Enabled = CanChangeRoutsInIssuedOrder
        Else
            tsbtnRoutApply.Enabled = True
        End If
    End Sub
#End Region

#Region " Платежи и долги заказа "
    Private Sub PayOrder()
        Try
            Dim sql As String
            sql = "SELECT "
            sql &= "Payments.payID AS ID, "
            sql &= "Fopl.name As [Тип оплаты], "
            sql &= "FiscalRegistrar.shortName AS [Сокр. Назв. ФР], "
            sql &= "OnlinePaymentsType.name As [Онлайн платеж], "
            sql &= "Organizations.Name As [Юр. лицо], "
            sql &= "Payments.summa As [Сумма оплаты], "
            sql &= "Payments.date_cr AS [Дата проведения], "
            sql &= "COALESCE(numberPayDoc, '') AS [Номер п.п.], "
            sql &= "Payments.date_PayDoc AS [Дата п.п.], "
            sql &= "Employees.emplLastName As Менеджер, "
            sql &= "Costs.nomerVN As [Номер заказа] "
            sql &= "FROM Payments "
            sql &= "INNER JOIN Fopl ON Payments.foplID = Fopl.ID "
            sql &= "LEFT JOIN FiscalRegistrar ON Payments.fiscalRegistrarID = FiscalRegistrar.ID "
            sql &= "LEFT JOIN OnlinePaymentsType ON Payments.onlinePaymentTypeID = OnlinePaymentsType.ID "
            sql &= "LEFT JOIN Organizations ON Payments.organizationID = Organizations.custID "
            sql &= "INNER JOIN Employees ON Payments.emplID = Employees.emplID "
            sql &= "INNER JOIN Costs ON Payments.costID = Costs.costID "
            sql &= "WHERE Payments.stateID = 2 AND Payments.costID = " & costID

            Dim paymentsSqlDataAdapter As SqlDataAdapter
            paymentsSqlDataAdapter = New SqlDataAdapter(sql, mcnnInt)
            Dim dtPay As New DataTable : paymentsSqlDataAdapter.Fill(dtPay)

            Dim oplSum@

            Me.dgPay.DataSource = dtPay

            If dtPay.Rows.Count > 0 Then
                oplSum = dtPay.Compute("SUM([Сумма оплаты])", "")
                dolgi = cost - oplSum

                ColHideDG(dgPay)
            Else
                oplSum = 0
                dolgi = cost
            End If

            Me.tsslOplacheno.Text = "Оплачено: " + CStr(Format(oplSum, "C"))
            Me.tsSLDolgi.Text = "Долг: " & CStr(Format(dolgi, "C"))

            If avansRealOrder = 2 Then
                Me.tsSLDolgi.Visible = False
                Me.tsslOplacheno.Visible = False
            End If

            If dolgi <= 0 Then
                Me.tsbtnInputPay.Enabled = False
            ElseIf kassaAllow = True Then 'Then
                Me.tsbtnInputPay.Enabled = IsEnabledForEditingWithCancelledOrder()
            Else
                Me.tsbtnInputPay.Enabled = False
            End If
        Catch excp As System.Exception
            MessageBox.Show("Платежи - " & excp.Message, appName)
            avarExit = True
            Exit Sub
        End Try
    End Sub

    Private Sub tsbtnInputPay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbtnInputPay.Click
        If cost = 0 Then
            MsgBox("Стоимость заказа не определена", MsgBoxStyle.Critical, appName) : Exit Sub
        Else
            ModCallForm.CallForm("Оплата заказа", 29, 3)
        End If
    End Sub

    Private Sub tsbtnDelPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelPay.Click
        Dim curPayID% = Me.dgPay("ID", Me.dgPay.CurrentRow.Index).Value()

        If MsgBox(Prompt:="Отменить оплату? ", Buttons:=vbYesNo, Title:=appName) = MsgBoxResult.Yes Then

            Module1.NonQuery1("UPDATE Payments SET stateID = 3 WHERE payID=" & curPayID & "")

            PayOrder()
            LoadOrder()
        End If
    End Sub
#End Region

#Region " Меню, редактирование и формирование документов заказа "
    Private Sub tsbtnPrintTZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnPrintTZ.Click
        If Me.tscmbDoc.SelectedIndex = -1 Then MsgBox("Не выбран тип формируемого документа.", MsgBoxStyle.Critical, appName) : Exit Sub

        If Me.tscmbDoc.Text = "ТЗ" And currentStatus = 1 Then
            MessageBox.Show("В состоянии 'Расчет'  формирование ТЗ запрещено.", appName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            PrintTZ()
        End If
    End Sub

    Private Sub tsbtnDocuments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDocuments.Click
        Document()
    End Sub

    Private Sub РедактироватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РедактироватьToolStripMenuItem.Click
        EditOrders()
    End Sub

    Private Sub EditOrders()
        Select Case prava
            Case Is = 0 'видит все, редактирует все
                EditOrder()
            Case Is = 1 'видит все редактирует свои
                EditOrder()
            Case Is = 2 'видит свои, редактирует свои
                EditOrder()
            Case Is = 3 'видит свои но не редактирует
                EditOrder()
            Case Is = 4 'видит все, редактирует все если админ
                EditOrder()
        End Select
    End Sub

    Private Sub EditOrder()
        Try
            Dim frmSelect As frmOrderEdit

            frmSelect = New frmOrderEdit
            frmSelect.orderEdit_statusCurr = currentStatus
            frmSelect.ShowDialog()
        Catch ex As System.Exception
            MessageBox.Show("Спецификация-" + ex.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub Document()
        If dsTZ.Tables("Cost").Rows.Count = 0 Then
            MsgBox("Для этого заказа не произведен ни один расчет", MsgBoxStyle.Critical, appName)
        Else
            nomVn = Trim(CStr(Module1.NonQuery1ScalarString("SELECT nomerVN FROM Costs WHERE costID=" & costID)))

            Dim frmSelect As New frmDocOut

            frmSelect.cmbAddressee.Enabled = False
            Dim sqlDataAdapter As New SqlDataAdapter("SELECT custOrgID FROM Costs WHERE costID=" & costID, mcnnInt)
            Dim dataTable As New DataTable()
            sqlDataAdapter.Fill(dataTable)

            If (Not IsDBNull(dataTable.Rows(0)("custOrgID")))
                frmSelect.CostOrganization = dataTable.Rows(0)("custOrgID")
            End If
            
            frmSelect.ShowDialog()
        End If
    End Sub
#End Region

#Region " Изменение состояния заказа "

    Private Sub tscmbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tscmbStatus.SelectedIndexChanged
        If allowStatusChange = False Then
            Exit Sub
        End If
        If Me.tscmbStatus.SelectedItem(0) = currentStatus Then
            Exit Sub
        End If

        Dim interFraza$

        If currentStatus = 1 Then
            If Me.tscmbStatus.SelectedIndex <> 0 Then
                If Me.dgSpec.RowCount = 0 Then
                    MsgBox("Заказ с пустой спецификацией может быть только в состоянии Расчет", MsgBoxStyle.Critical,
                           appName)
                    Me.tscmbStatus.SelectedIndex = 0
                    Exit Sub
                Else
                    Me.Opacity = 0.7
                    Dim frmSelect As New frmOrderEdit

                    frmSelect.lblManager.Visible = False
                    frmSelect.cmbManager.Visible = False
                    frmSelect.orderEdit_statusCurr = 2
                    frmSelect.ShowDialog() ' запускаем редактирование заказа чтобы указать кому передать заказ в работу

                    
                    ChangeRoutApplyEnabled()

                    If NehvatkaMat <> Nothing Then
                        MsgBox("В запасах не хватает:" + Chr(13) + NehvatkaMat, MsgBoxStyle.Information, appName)
                        NehvatkaMat = Nothing
                    End If

                    Me.cmsSpec.Enabled = True

                    Exit Sub
                End If
            Else
                interFraza = "Сохранить состояние- " + Trim(Me.tscmbStatus.Text) + "?"
            End If
        Else
            interFraza = "Сохранить состояние- " + Trim(Me.tscmbStatus.Text) + "?"
        End If

        Select Case MessageBox.Show(interFraza, appName + " - Управление заказом", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case Is = DialogResult.Yes
                Try
                    allow = False 'игнорируем активацию

                    If currentStatus <> 1 Then
                        Select Case Me.tscmbStatus.ComboBox.SelectedItem(0)
                            Case Is = 4
                                If paramIssuesOrders = True Then
                                    saveStatus()

                                    Module1.NonQuery1(
                                        "insert into dbo.OrderRout (costID,empl_ID,next_empl_ID,description,dateRout) VALUES (" &
                                        costID & "," & emplID & ",3196,'выдан','" & Now() & "')")
                                    Module1.NonQuery1(
                                        "UPDATE Costs SET emplDesignerID=3196, prepress='Выдал-'+ (SELECT emplLastName FROM Employees where emplID=" & emplID &
                                        ")+' '+CONVERT(nvarchar(30), GETDATE(), 104) +' в '+ CONVERT(nvarchar(30), GETDATE(), 108) WHERE costID=" & costID & "")
                                Else
                                    MsgBox("Нет полномочий выдавать заказ.", MsgBoxStyle.Critical, appName)
                                    Exit Sub
                                End If

                            Case Is = 3
                                If otmGotovnost = True Then
                                    saveStatus()
                                Else
                                    MsgBox("Нет полномочий отмечать готовность заказа.", MsgBoxStyle.Critical, appName)
                                    Exit Sub
                                End If

                            Case Is = 2
                                saveStatus()

                            Case Is = 1
                                allow = False 'игнорируем активацию
                                If currentStatus <> 2 Then
                                    If postPrioritet = 1 Then
                                        Me.tscmbServices.Enabled = True
                                        currentStatus = 1
                                        saveStatus()
                                    Else
                                        MsgBox("Нет полномочий.", MsgBoxStyle.Critical, appName)
                                        Exit Sub
                                    End If
                                Else
                                    currentStatus = 1
                                    saveStatus()
                                End If
                        End Select
                    End If
                Catch excData As System.Exception
                    MsgBox("error" & excData.Message, MsgBoxStyle.Critical, appName)
                    Exit Sub
                End Try
            Case Is = DialogResult.No
                Me.tscmbStatus.ComboBox.SelectedValue = currentStatus
                
                ChangeRoutApplyEnabled()
        End Select
    End Sub

    Private Sub saveStatus()
        Module1.NonQuery1("UPDATE Costs SET statusID=" & Me.tscmbStatus.ComboBox.SelectedItem(0) & " WHERE costID=" & costID & "")
        currentStatus = tscmbStatus.ComboBox.SelectedItem(0)

        ChangeRoutApplyEnabled()
    End Sub
#End Region

#Region " Анулировать заказ "
    Private Sub CancelledOrder(brak As Integer)
        Select Case brak
            Case Is = 1 '•	Отказ от заказа
                Dim fragment As String = InputBox("Причина:", "Отказ от заказа", "")

                If Len(fragment) > 0 Then
                    Try
                        '  If CanceledOrder = False Then
                        'MsgBox("Нет полномочий!", MessageBoxIcon.Stop, appName)
                        '    Else
                        SavePrim("Отказ от заказа по причине: " + fragment)

                        Module1.NonQuery1("UPDATE Costs SET cancelled=1, modifiedOn='" & Now() & "', nomerVN=nomerVN+'-Б', emplDesignerID=" & emplID & " WHERE costID=" & costID & "")
                        Module1.NonQuery1("insert into Rejection (costID,emplID,description,summa) VALUES (" & costID & "," & emplID & ",'" & fragment & "'," & Replace(cost, ",", ".") & ")")
                        '  End If

                    Catch oexpData As System.Exception
                        MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
                    End Try
                End If

            Case Is = 2 '•	Переделка заказа
                Dim fragment As String = InputBox("Причина:", "Переделка заказа", "")

                If Len(fragment) > 0 Then
                    Try
                        '  If CanceledOrder = False Then
                        '    MsgBox("Нет полномочий!", MessageBoxIcon.Stop, appName)
                        '  Else
                        '  Module1.NonQuery1("UPDATE Costs SET statusID=1,modifiedOn='" & Now() & "',nomerVN=nomerVN+'-Б',emplDesignerID=emplID WHERE costID=" & costID & "")
                        Dim oldCostID% = costID
                        'Создается новый заказ
                        costID = retryOrderBrak()

                        Dim emplIDold% = Module1.NonQuery1ScalarString("SELECT emplID FROM Costs WHERE costID=" & oldCostID & "")
                        Dim nomNewOrder$ = Module1.NonQuery1ScalarString("SELECT nomerVN FROM Costs WHERE costID=" & costID & "")
                        Dim nomOrderOld$ = Module1.NonQuery1ScalarString("SELECT nomerVN FROM Costs WHERE costID=" & oldCostID & "")

                        Module1.NonQuery1("INSERT INTO OrderRout (empl_ID, next_empl_ID, description, costID) VALUES (" & emplID & ", 1028, 'Переделка брака в заказе + " & nomNewOrder & "', " & oldCostID & ")")
                        Module1.NonQuery1("INSERT INTO OrderRout (empl_ID, next_empl_ID, description, costID) VALUES (" & emplID & ", " & emplIDold & ", 'Переделка брака из заказа + " & nomOrderOld & "', " & costID & ")")

                        Module1.NonQuery1("insert into Rejection (costID, emplID, description, summa) VALUES (" & costID & ", " & emplID & ", '" & fragment & "', " & Replace(cost, ",", ".") & ")")

                        costID = oldCostID

                        MsgBox("Повтор заказа выполнен. Новый заказ сохранен в состоянии расчет.", MsgBoxStyle.Information, appName)

                        ' MsgBox("Повтор заказа выполнен. Новый заказ сохранен в состоянии расчет. Для работы с ним необходимо в фильтре состояния установит галочку Расчет.", MsgBoxStyle.Information, appName)
                        'Select Case MsgBox(Prompt:="Новый заказ создан." + nomVn + "-Б", Buttons:=vbYesNo, Title:=appName)
                        '    Case Is = vbYes
                        '        Exit Sub
                        '     ModCallForm.CallForm("", 11, 3)

                        '    Case Is = vbNo
                        '        Exit Sub
                        'End Select


                        '  Module1.NonQuery1("insert into Rejection (costID,emplID,description,summa) VALUES (" & costID & "," & emplID & ",'" & fragment & "'," & Replace(cost, ",", ".") & ")")
                        '  End If
                    Catch oexpData As System.Exception
                        MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
                    End Try
                End If

            Case Is = 3 '•	Реализация с произвольной скидкой
                Dim fragment As String = InputBox("Причина:", "Реализация с произвольной скидкой", "")

                If Len(fragment) > 0 Then
                    Try
                        '  If CanceledOrder = False Then
                        MsgBox("Нет полномочий!", MessageBoxIcon.Stop, appName)
                        '   Else
                        SavePrim("Реализация с произвольной скидкой по причине: " + fragment)

                        Module1.NonQuery1("UPDATE Costs SET modifiedOn='" & Now() & "',nomerVN=nomerVN+'-Б' WHERE costID=" & costID & "")
                        Module1.NonQuery1("insert into Rejection (costID,emplID,description,summa) VALUES (" & costID & "," & emplID & ",'" & fragment & "'," & Replace(cost, ",", ".") & ")")

                        Dim skidka = InputBox("Введи скидку на весь заказ", "Скидка, операция необратима", "0")

                        If Len(skidka) = 0 Then
                            Exit Sub
                        Else
                            SkidkaTotal(skidka)
                        End If
                        ' End If
                    Catch oexpData As System.Exception
                        MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
                    End Try
                End If
        End Select
    End Sub

    Private Function retryOrderBrak() As Integer
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_RetryBrak"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int)) 'Описываем параметры
            cmd.Parameters("@costID").Value = costID ' этот заказ

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
#End Region

#Region " РАСПЕЧАТКА ТЕХ ЗАДАНИЯ "
    Private Sub PrintTZ()
        ' files = ""
        '  Dim dr As DataRow

        If dsTZ.Cost.Rows.Count = 0 Then 'Or currentStatus = 1
            ' MessageBox.Show("В состоянии 'Расчет' или с пустой спецификацией" + Chr(13) + "формирование ТЗ запрещено" + _
            MessageBox.Show("С пустой спецификацией формирование документа невозможно", appName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            Try
                'удаляем старый файл если он есть
                Dim strFileName As String = paramLocalTempPath & "DSTZ.xml" 'Path.GetTempPath & "\DSTZ.xml"
                Dim rrr As New FileInfo(strFileName)

                rrr.Delete()
                'пишем содержимое датасета в XML
                'dsTZ.Tables("order").WriteXml(strFileName, XmlWriteMode.WriteSchema) 'не пишем таб файлы чтоб в случае файла большого объема не обрывалась связь по таймоуту
                'dsTZ.Tables("cost").WriteXml(strFileName, XmlWriteMode.)
                dsTZ.WriteXml(strFileName, XmlWriteMode.WriteSchema)

                '  dsTZ.WriteXml(Path.GetTempFileName("DSTZ.xml"), XmlWriteMode.WriteSchema)

                frmDocPrint.InitReport(Me.tscmbDoc.SelectedItem(0))
                '  frmDocPrint.InitReport(0)
            Catch ex As System.Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            '   Else
            '   MsgBox("Формирование недоступно.")
            '  End If
        End If
    End Sub
#End Region

#Region " Файлы "
    Private Sub СохранитьОписаниеToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СохранитьОписаниеToolStripMenuItem.Click
        Module1.NonQuery1("UPDATE Files SET description='" & Me.tscmbFiles.Text & "' WHERE ID=" & Me.dgFiles("ID", Me.dgFiles.SelectedRows.Item(0).Index).Value() & "")
        LoadFiles()
    End Sub

    Private Sub tsbtnAddFileWork_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnAddFileWork.Click

        If Me.tscmbFileDescript.Text = Nothing Then
            MsgBox("Укажите описание к файлу. ", MsgBoxStyle.Critical, appName)
            Me.tscmbFileDescript.Focus()
        Else
            modeAddFile = 1

            FileAdd()

            Me.tscmbFileDescript.SelectedIndex = -1
            Me.tscmbFileDescript.Text = ""

            LoadFiles()
        End If
    End Sub

    Private Sub dgFiles_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFiles.CellContentDoubleClick
        FileOpen()
    End Sub

    Private Sub LoadFiles()
        Try
            dsFiles.Tables("Files").Clear()
            FillFilesSP("sp_Order_FillFiles", "Files")

            Me.dgFiles.DataSource = dsFiles.Tables("Files")

            For n As Integer = 0 To Me.dgFiles.ColumnCount - 1
                If Me.dgFiles.Columns(n).Name = "ID" Then
                    Me.dgFiles.Columns("ID").Visible = False
                End If
                If Me.dgFiles.Columns(n).Name = "dataFile" Then
                    Me.dgFiles.Columns("dataFile").Visible = False
                End If
                If Me.dgFiles.Columns(n).Name = "link" Then
                    Me.dgFiles.Columns("link").Visible = False
                End If
                If Me.dgFiles.Columns(n).Name = "inDB" Then
                    Me.dgFiles.Columns("inDB").Visible = False
                End If
            Next

            If dgFiles.RowCount > 0 Then
                If modeAddFile = 1 Then
                    Me.dgFiles.Rows(dgFiles.Rows.Count - 1).Selected = True 'выделяем последний добавленнный файл
                    Me.modeAddFile = 0
                End If
            End If

            Me.txtPath1.Text = Module1.NonQuery1ScalarString("Select coalesce(path1,'') FROM costs WHERE costID=" & costID & "")
            Me.txtPath2.Text = Module1.NonQuery1ScalarString("Select coalesce(path2,'') FROM costs WHERE costID=" & costID & "")
            Me.txtPath3.Text = Module1.NonQuery1ScalarString("Select coalesce(path3,'') FROM costs WHERE costID=" & costID & "")
        Catch excp As System.Exception
            MessageBox.Show("Загрузка файлов " & excp.Message, appName)
            Exit Sub
        End Try
    End Sub

    Dim destinationPath As String ' Путь источника и назначения
    Dim sourcePath As String

    Private Sub FileAdd()
        'Проблема не производится копирование если файл открыт и не выдает сообщение а при исп трим не переносит большие файлы
        Dim sFilePath1 As String = ""
        Dim fileNameUser As String = ""
        Dim fileID As Integer
        Dim fileNameSys As String

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            sFilePath1 = OpenFileDialog1.FileName
            fileNameUser = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
        Else
            Exit Sub
        End If

        Select Case modeAddFile
            Case Is = 1 'добавляем рабочий файл
                Dim fileName As String = OpenFileDialog1.FileName
                Dim sqlCommand As New SqlCommand("INSERT INTO Files (fileData, costID, typeFile, inDB, fileName, description, emplID)  VALUES ('" & Format(Now(), "s") & "', " & costID & ", '" & System.IO.Path.GetExtension(OpenFileDialog1.FileName) & "', '0', '" & fileNameUser & "', '" & Me.tscmbFileDescript.Text & "', " & emplID & ")", mcnnInt)

                mcnnInt.Open()

                If sqlCommand.ExecuteNonQuery > 0 Then 'cmd.ExecuteNonQuery > 0 = True Then
                    Dim objIdentifier As New SqlClient.SqlCommand("Select @@Identity", mcnnInt)

                    fileID = objIdentifier.ExecuteScalar
                Else
                    MsgBox("qqq", MsgBoxStyle.Critical, appName) : Exit Sub
                End If

                mcnnInt.Close()

                fileNameSys = fileID.ToString

                destinationPath = paramFileStoragePath + fileNameSys + System.IO.Path.GetExtension(OpenFileDialog1.FileName)

                If Not String.IsNullOrEmpty(sFilePath1) Then
                    Try
                        Dim mForm As New Form
                        Dim elLabel As New Label

                        mForm.Text = "Работа с файлом"
                        ' и т.д. создаем элементы и добавляем их на форму
                        elLabel.Text = "Сохраняю файл в заказ." & Chr(13) & "Ничего не нажимайте пока не закроется это окно." & Chr(13) & "Окно закроется автоматически."
                        elLabel.AutoSize = True
                        mForm.Controls.Add(elLabel)
                        mForm.MaximizeBox = False
                        mForm.Show()

                        System.IO.File.Copy(sFilePath1, destinationPath, True) 'копируем файл. Если есть, переписываем - True
                        '****************** закрываем
                        mForm.Close()
                    Catch ex As System.Exception
                        MsgBox("Загрузка файла " + ex.Message, MsgBoxStyle.Critical, appName)
                        Exit Sub
                    End Try
                End If
            Case Is = 2 'добавляем счет
                destinationPath = paramFileStoragePath + "\a-" + Me.dgExpensesOrder("ID", Me.dgExpensesOrder.CurrentRow.Index).Value().ToString + "-" + System.IO.Path.GetFileName(OpenFileDialog1.FileName)

                If Not String.IsNullOrEmpty(sFilePath1) Then
                    Try
                        File.Copy(sFilePath1, destinationPath, True) 'копируем файл. Если есть, переписываем - True
                    Catch ex As System.Exception
                        MsgBox("Ошибка добавления файла счета- " + ex.Message, MsgBoxStyle.Critical, appName)
                        Exit Sub
                    End Try
                End If

                Module1.NonQuery1("UPDATE Invoices_KA SET  linkToFile = '" & destinationPath & "' WHERE ID = " & Me.dgExpensesOrder("ID", Me.dgExpensesOrder.CurrentRow.Index).Value() & " ")
        End Select
    End Sub

    Private Sub tsbtnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOpenFile.Click
        FileOpen()
    End Sub

    Private Sub FileOpen()

        Dim file As String

        file = dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(0).Index)("link").ToString

        If file.StartsWith("http") Then
            Process.Start(file)
            Exit Sub
        End If

        Dim ext$ = Trim(Me.dgFiles("Расширение", Me.dgFiles.SelectedRows.Item(0).Index).Value().ToString)

        Try
            Me.Enabled = False

            For n As Integer = 0 To Me.dgFiles.SelectedRows.Count - 1
                sourcePath = dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(n).Index)("link").ToString
                destinationPath = paramLocalTempPath + Path.GetFileName(sourcePath)
                flagOpenFile = True
                'операция выполняется в ФОНЕ!!!
                Me.BackgroundWorker1.RunWorkerAsync(New Object() {sourcePath, destinationPath})
            Next
            Me.Enabled = True
        Catch ex As System.Exception
            MsgBox("Ошибка при открытии файла. " & ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub tsbtnFileDel_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnFileDel.Click
        If Me.dgFiles.RowCount = 0 Then
            Exit Sub
        Else
            FileDel(Me.dgFiles.SelectedRows.Item(0).Index)
        End If
    End Sub

    Private Sub tsbtnSaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSaveFile.Click
        ' sourcePath = dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(0).Index)("link").ToString
        ' Здесь все аналогично
        Me.SaveFileDialog1.AddExtension = True

        If savePathTTT = Nothing Then
            Me.SaveFileDialog1.InitialDirectory = "C:"
        Else
            Me.SaveFileDialog1.InitialDirectory = savePathTTT
        End If

        Me.SaveFileDialog1.Title = "Сохраняем файл"

        Me.SaveFileDialog1.Filter = "*" + System.IO.Path.GetExtension(dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(0).Index)("link").ToString).ToString + " |*" + System.IO.Path.GetExtension(dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(0).Index)("link").ToString).ToString

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim file$ = dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(0).Index)("link").ToString

            If file.StartsWith("http") Then
                wc.DownloadFileAsync(New Uri(dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(0).Index)("link").ToString), SaveFileDialog1.FileName)
            Else
                System.IO.File.Copy(dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(0).Index)("link").ToString, SaveFileDialog1.FileName, True) 'копируем файл. Если есть, переписываем - True
            End If

            savePathTTT = SaveFileDialog1.InitialDirectory.ToString
        End If
    End Sub

    Dim WithEvents wc As New System.Net.WebClient 'Создаем событие, вызываемое WebClient

    Private Sub wc_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles wc.DownloadFileCompleted
        tsPbarCopyFiles.Value = 0 'Загрузки завершены
    End Sub

    Private Sub wc_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles wc.DownloadProgressChanged
        tsPbarCopyFiles.Value = e.ProgressPercentage 'Показываем прогресс скачивания
    End Sub

    Private Sub tsbtnFilesDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FileDel(Me.dgFiles.SelectedRows.Item(0).Index)
    End Sub

    Private Sub FileDel(rowIndex As Integer)
        If allowDelFiles = True Then
            Select Case MsgBox(Prompt:="Удалить файл: " & Me.dgFiles("Описание", rowIndex).Value.ToString, Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM Files WHERE ID = " & Me.dgFiles(0, rowIndex).Value & " ")

                    If Me.dgFiles("inDB", rowIndex).Value = 0 Then 'dsFiles.Tables("Files").Rows(Me.dgFiles.CurrentRow.Index)("inDB") = 0 Then 'признак файлы храним в папке
                        If File.Exists(Me.dgFiles("link", rowIndex).Value.ToString) Then
                            Try
                                System.IO.File.Delete(Me.dgFiles("link", rowIndex).Value.ToString)
                            Catch ex As System.Exception

                            End Try

                        Else
                            MsgBox("Ссылка на файл удалена. Файл не найден.", MsgBoxStyle.Information, appName)
                            LoadFiles()
                            Exit Sub
                        End If
                    Else
                        'файлы храним в бд
                    End If

                    LoadFiles()

                Case Is = vbNo
                    Exit Sub
            End Select
        Else
            MsgBox("Нет прав для удаления файлов. Для удаления обратитесь к администратору системы.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub tsbtnAddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAddFile.Click
        If Me.dgExpensesOrder.SelectedRows.Count = 0 Then
            MsgBox("Выбери счет.", MsgBoxStyle.Information, appName) : Exit Sub
        Else
            modeAddFile = 2

            FileAdd()
        End If
    End Sub

    Private Sub OpenFileExpens()
        If Me.dgExpensesOrder.RowCount = 0 Then
            MsgBox("Файл " & sourcePath & " не найден.", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If

        Dim curIndex As Integer = Me.dgExpensesOrder.CurrentRow.Index

        Try
            For n As Integer = 0 To Me.dgExpensesOrder.SelectedRows.Count - 1

                sourcePath = Me.dgExpensesOrder("linkToFile", curIndex).Value().ToString

                If File.Exists(sourcePath) Then
                    destinationPath = paramLocalTempPath + Path.GetFileName(sourcePath)
                    flagOpenFile = True
                    'операция выполняется в ФОНЕ!!!

                    Me.BackgroundWorker1.RunWorkerAsync(New Object() {sourcePath, destinationPath})
                Else
                    MsgBox("Файл " & sourcePath & " не найден.", MsgBoxStyle.Critical, appName)
                    Exit Sub
                End If
            Next

            Me.Enabled = True
        Catch ex As System.Exception
            MsgBox("Ошибка при открытии файла счета. " & ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub tsbtnOpenFileInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOpenFileInv.Click
        OpenFileExpens()
    End Sub
#End Region

#Region " File CopyBackgraund "
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        '    ' Функция, которую выполняет backgroundWorker
        Dim worker As BackgroundWorker = DirectCast(sender, BackgroundWorker)

        Copy(sourcePath, destinationPath, worker, 1024)
    End Sub

    Private Sub backgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Изменение прогресса копирования
        Me.tsPbarCopyFiles.Value = e.ProgressPercentage
    End Sub

    Dim flagOpenFile As Boolean 'определяет режим работы ворк

    Private Sub backgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' Завершение работы backgroundWorker
        ' Проверяем на ошибки и показываем сообщение о них, елси они возникли
        If e.[Error] Is Nothing Then
            Me.tsPbarCopyFiles.Value = 0
            Me.Enabled = True
            'If flagOpenFile = True Then 
            flagOpenFile = False

            Process.Start(destinationPath) 'здесь открываем
            ' End If
        Else
            MessageBox.Show(e.[Error].Message)
        End If
    End Sub

    Public Shared Sub Copy(ByVal sourcePath As String, ByVal destinationPath As String, ByVal worker As BackgroundWorker, ByVal chunkBytesCount As Integer)
        ' Проверки на заданность путей
        If String.IsNullOrEmpty(sourcePath) Then
            Throw New ArgumentNullException(sourcePath)
        End If

        If String.IsNullOrEmpty(destinationPath) Then
            Throw New ArgumentNullException(destinationPath)
        End If

        ' Проверка существования исходного файла
        If Not File.Exists(sourcePath) Then
            Try
                Throw New FileNotFoundException(sourcePath)
            Catch ex As System.Exception
                MsgBox("Файл не существует", MsgBoxStyle.Critical, appName) : Exit Sub
            End Try
        End If

        ' Проверка кратности степени 2
        If chunkBytesCount <= 0 OrElse chunkBytesCount Mod 2 <> 0 Then
            Throw New ArgumentException("chunkBytesCount must be degree of 2")
        End If

        ' Удаляем файл назначения, если он существует
        If File.Exists(destinationPath) Then
            File.Delete(destinationPath)
        End If

        Dim copyedBytes As Long = 0
        Dim notify As Boolean = worker IsNot Nothing
        '****************************************88

        ' Поток исходного файла
        Using sourceStream As New FileStream(sourcePath, FileMode.Open)
            Try
                sourceStream.Lock(1, sourceStream.Length)

                Dim totalSize As Long = sourceStream.Length
                Dim bytes = New Byte(If(chunkBytesCount <= totalSize \ 8, chunkBytesCount, totalSize \ 8) - 1) {}

                ' Поток файла назначения
                Using destinationStream As New FileStream(destinationPath, FileMode.CreateNew)

                    ' Копируем данные порциями размера chunkBytesCount, пока не достигнем конца файла
                    While totalSize <> copyedBytes AndAlso sourceStream.CanRead AndAlso destinationStream.CanWrite
                        Dim readedBytesCount As Long = sourceStream.Read(bytes, 0, chunkBytesCount)
                        destinationStream.Write(bytes, 0, readedBytesCount)
                        copyedBytes += readedBytesCount

                        ' Докладываем о прогрессе копирования
                        If notify Then
                            worker.ReportProgress((100 * copyedBytes) / totalSize)
                        End If
                    End While
                End Using
            Catch e As IOException
                MsgBox(e.Message, MsgBoxStyle.Critical, appName)
            Finally
                sourceStream.Unlock(1, sourceStream.Length)
            End Try
        End Using
    End Sub
#End Region

#Region " Описания "
    Private Sub SavePrim(annulir As String)
        Try
            Module1.NonQuery1("DELETE FROM PurposeCost WHERE costID=" & costID & "")

            Dim modaIndiv As New SqlClient.SqlDataAdapter("SELECT * FROM PurposeCost WHERE costID=" & costID & "", mcnnInt) 'запись в таблицу
            Dim mdsIndiv As New DataSet : modaIndiv.Fill(mdsIndiv, "PurposeCost")
            Dim mdrIndiv As DataRow = mdsIndiv.Tables("PurposeCost").NewRow

            mdrIndiv.BeginEdit()

            mdrIndiv("costID") = costID
            mdrIndiv("Purpose") = Me.txtprim.Text + annulir
            mdrIndiv("data") = Now() ' Format(data, "dd.MM.yy")

            mdrIndiv.EndEdit()         'Завершить редактировать строку данных
            mdsIndiv.Tables("PurposeCost").Rows.Add(mdrIndiv)

            Dim ocbIndiv As SqlClient.SqlCommandBuilder

            ocbIndiv = New SqlClient.SqlCommandBuilder(modaIndiv)
            modaIndiv.InsertCommand = ocbIndiv.GetInsertCommand
            modaIndiv.Update(mdsIndiv, "PurposeCost")
            mdsIndiv.Tables("PurposeCost").AcceptChanges()
            modaIndiv.InsertCommand.Connection.Close()
            Me.txtprim.ReadOnly = True

            Me.tslblStatus.Text = "Описание сохранено."
        Catch oexp As System.Exception
            MsgBox("error" & oexp.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub txtprim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprim.KeyPress
        Dim KeyAscii As Integer = Asc(e.KeyChar)
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        SavePrim("")
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        Me.txtprim.Enabled = True
        Me.txtprim.ReadOnly = False
        Me.tslblStatus.Text = "Описание редактируется"
        Me.txtprim.Focus()
    End Sub
#End Region

#Region " Затраты заказа "
    Private Sub LoadExpensesOrder()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_Order_Expenses]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtExpenses As New DataTable : objDA.Fill(dtExpenses)

            If dtExpenses.Rows.Count > 0 Then
                Me.dgExpensesOrder.DataSource = dtExpenses
                Me.ToolStripStatusLabel4.Text = "Затраты по всем счетам " & CStr(Format(dtExpenses.Compute("SUM(Сумма)", ""), "C"))

                ColHideDG(Me.dgExpensesOrder)
            Else
                Me.dgExpensesOrder.DataSource = Nothing
                Me.ToolStripStatusLabel4.Visible = False
            End If

        Catch oexpData As System.SystemException
            MessageBox.Show("Загрузка затрат: " & oexpData.Message, appName) : Exit Sub
        End Try
    End Sub

    Private Sub tsbtnDelExpens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelExpens.Click
        DelCost(Me.dgExpensesOrder("ID", Me.dgExpensesOrder.CurrentRow.Index).Value(), Me.dgExpensesOrder("Оплачено", Me.dgExpensesOrder.CurrentRow.Index).Value(), Me.dgExpensesOrder("LinkToFile", Me.dgExpensesOrder.CurrentRow.Index).ToString)

        LoadExpensesOrder()
    End Sub

    Private Sub DelCost(curID As Integer, oplaheno As Decimal, link As String)
        If oplaheno > 0 Then
            MsgBox("Счет был оплачен. Предварительно нужно отменить его оплату.", MsgBoxStyle.Critical, appName)
            Exit Sub
        Else
            If MsgBox(Prompt:="Удалить выбранную строку? ", Buttons:=vbYesNo, Title:=appName) = MsgBoxResult.Yes Then

                Module1.NonQuery1("DELETE FROM Invoices_KA  WHERE ID = " & curID & " ")

                If File.Exists(link) Then
                    System.IO.File.Delete(link)
                End If
            End If
        End If
    End Sub

    Private Sub tsbtnAddMatExpens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModCallForm.CallForm("Расход материала", 26, 1)
    End Sub

    Private Sub tsbtnAddExpens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAddExpens.Click
        ModCallForm.CallForm("Счет к заказу", 28, 3)
    End Sub
#End Region

#Region " Расход материала "
    Private Sub RasxodMat()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_Sklad_DeliveryForOrder]"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@orderID", SqlDbType.Int))
            cmd.Parameters("@orderID").Value = costID

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

            Me.dgMatExpens.DataSource = dtSklad

            ColHideDG(Me.dgMatExpens)
        Catch oexpData As System.SystemException
            MessageBox.Show("Расход материала: " & oexpData.Message, appName)
        End Try
    End Sub
#End Region

    Private Sub FillFromSP(ByVal nameSP As String, ByVal nameTable As String)

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = nameSP
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
        cmd.Parameters("@costID").Value = costID
        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        objDA.Fill(dsTZ, nameTable)
    End Sub

    Private Sub FillFilesSP(ByVal nameSP As String, ByVal nameTable As String)

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = nameSP
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
        cmd.Parameters("@costID").Value = costID
        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        objDA.Fill(dsFiles, nameTable)
    End Sub

    Function spScalar(ByVal nameSP As String) As Decimal
        Try
            Dim ocmd As New SqlClient.SqlCommand

            ocmd.Connection = mcnnInt
            ocmd.CommandText = nameSP
            ocmd.CommandType = CommandType.StoredProcedure
            ocmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            ocmd.Parameters("@costID").Value = costID
            mcnnInt.Open()
            Return ocmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

#Region " Задачи "
    Private Sub LoadTasks()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_Order_Tasks"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
        cmd.Parameters("@costID").Value = costID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtItog As New DataTable : objDA.Fill(dtItog)

        Me.dgTasks.DataSource = dtItog

        ColHideDG(dgTasks)
    End Sub

    Private Sub НоваяЗадачаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles НоваяЗадачаToolStripMenuItem.Click
        ModCallForm.CallForm("Задача", 15, 3)

        LoadTasks()
    End Sub

    Private Sub УдалитьЗадачиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьЗадачиToolStripMenuItem.Click
        TaskDel()
    End Sub

    Private Sub tsbtnNewTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNewTask.Click
        ModCallForm.CallForm("Задача", 15, 3) 'по просьбе Фурсова закоммент 09.07.2014

        LoadTasks()
    End Sub

    Private Sub tsbtnTaskDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnTaskDel.Click
        TaskDel()
    End Sub

    Private Sub TaskDel()
        Dim curTaskID% = Me.dgTasks("ID", Me.dgTasks.CurrentRow.Index).Value()

        Select Case MsgBox(Prompt:="Удалить выбранную задачу?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM Tasks WHERE ID=" & curTaskID & "")
                LoadTasks()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub
#End Region

#Region " Доставка "
    Private Sub LoadDostavka()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_Order_Dostavka"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
        cmd.Parameters("@costID").Value = costID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtDostavka As New DataTable : objDA.Fill(dtDostavka)

        Me.dgDostavka.DataSource = dtDostavka

        ColHideDG(Me.dgDostavka)
    End Sub
#End Region

#Region " Маршрут заказа "
    Private Sub LoadOrderRout()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_Rout"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtRout As New DataTable : objDA.Fill(dtRout)

            If (dtRout.Rows.Count > 0) Then
                Dim dataRow As DataRow = dtRout.Rows(0)
                Dim routDate As Date = dataRow.Item("Дата")
                Dim routTo As String = dataRow.Item("Передано")
                Dim routDescription As String = dataRow.Item("Описание")
                tsslLastRout.Text = String.Format("{0} | {1} | {2}", routDate, routTo, routDescription)
            Else
                tsslLastRout.Text = ""
            End If

            Me.dgOrderRout.DataSource = dtRout

            ColHideDG(dgOrderRout)
            'Me.dgOrderRout.Columns("ID").Visible = False 'скрываем первую колонку с ид
            'Me.dgOrderRout.ClearSelection()
        Catch excp As System.Exception
            MessageBox.Show("Загрузка маршрута " + excp.Message, appName)
            Exit Sub
        End Try
    End Sub
#End Region

    Private Sub txtprim_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtprim.MouseClick
        Me.txtprim.Enabled = True
        Me.txtprim.ReadOnly = False
    End Sub

    Private Sub cmbDepartment_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedValueChanged
        Dim cmd1 As New SqlClient.SqlCommand

        cmd1.Connection = mcnnInt
        cmd1.CommandText = "[sp_FilterExecutorDep]"
        cmd1.CommandType = CommandType.StoredProcedure

        cmd1.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
        cmd1.Parameters("@depID").Value = Me.cmbDepartment.SelectedItem(0)

        Dim odaDesignerFind As New SqlClient.SqlDataAdapter(cmd1)
        Dim dtDesigner As New DataTable : odaDesignerFind.Fill(dtDesigner)

        Me.cmbEmplRout.DataSource = dtDesigner
        Me.cmbEmplRout.DisplayMember = "emplLastName"
        Me.cmbEmplRout.ValueMember = "emplID"
    End Sub

    Private Sub tsbtnRoutApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnRoutApply.Click
        If Me.txtPurposeRout.Text = Nothing Then
            MsgBox("Поле описание должно быть заполнено", MsgBoxStyle.Critical, appName)
        Else
            Module1.NonQuery1("UPDATE Costs SET emplDesignerID=" & Me.cmbEmplRout.SelectedItem(0) & " WHERE costID=" & costID & "")
            Module1.NonQuery1("INSERT INTO OrderRout (empl_ID,next_empl_ID,description,costID) VALUES (" & emplID & "," & Me.cmbEmplRout.SelectedItem(0) & ",'" & Me.txtPurposeRout.Text & "'," & costID & ")")

            LoadOrderRout() 'загрузка маршрута заказа

            Me.tsbtnRoutApply.Checked = True
        End If
    End Sub

    Private Sub tsbtnTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnTask.Click
        Me.tscmbDep.Visible = sender.checked
        Me.tscmbDep.SelectedIndex = -1
        Me.tscmbExecutor.Visible = sender.checked
        Me.tsbtnNewExec.Visible = sender.checked
    End Sub

    Private Sub tsbtnNewExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNewExec.Click
        If Me.tscmbExecutor.Visible = False Then
            MsgBox("Выбери исполнителя", MsgBoxStyle.Critical, appName)
        Else
            Module1.NonQuery1("UPDATE Tasks SET empID_executor=" & Me.tscmbExecutor.SelectedItem(0) & " WHERE ID=" & Me.dgTasks("ID", Me.dgTasks.CurrentRow.Index).Value() & "")

            LoadTasks()
        End If
    End Sub

    Private Sub tsbtnTaskFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnTaskFinish.Click
        Module1.NonQuery1("UPDATE Tasks SET statusID=4, dateFinish='" & Now() & "' WHERE ID=" & Me.dgTasks("ID", Me.dgTasks.CurrentRow.Index).Value() & "")

        LoadTasks()
    End Sub

    Private Sub dgTasks_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTasks.CurrentCellChanged
        Try
            If Me.dgTasks.CurrentRow Is Nothing Then
                Exit Sub
            Else
                Me.txtTask.Text = Me.dgTasks("Описание", Me.dgTasks.CurrentRow.Index).Value() + Chr(13) +
               "                            Комментариий исполнителя: " + Me.dgTasks("Комментарии", Me.dgTasks.CurrentRow.Index).Value()
            End If
        Catch ex As System.Exception
            '   MsgBox("комментарии задач" + ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub Open_Order()
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_Order_Open"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
        cmd.Parameters("@costID").Value = costID
        cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
        cmd.Parameters("@emplID").Value = emplID

        mcnnInt.Open()
        cmd.ExecuteNonQuery()
        mcnnInt.Close()
    End Sub

    Private Sub tscmbServices_DropDownClosed(sender As Object, e As System.EventArgs) Handles tscmbServices.DropDownClosed
        If allowStatusChange = True Then ' =true после первой активации
            If Me.tscmbServices.SelectedIndex <> -1 Then
                serviceID = Me.tscmbServices.ComboBox.SelectedItem(0)
                Try 'вызов форм
                    ModCallForm.CallForm(Me.tscmbServices.ComboBox.Text, Module1.NonQuery1Scalar("SELECT formCostNumber FROM Services WHERE ID=" & serviceID & ""), 1)
                Catch ex As System.Exception
                    MsgBox(ex.Message + " - Ошибка при вызове формы расчета стоимости. Проверь указан ли номер формы в таблице Services и цены на услуги.", MsgBoxStyle.Critical, appName)
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub tsbtnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnUpdate.Click
        UpdateAllOrder()
    End Sub

    Private Sub UpdateAllOrder()
        If avarExit = False Then
            LoadOrder() 'загрузка общих параметров
            LoadTechParametr() 'загрузка спецификации
            PayOrder()
            LoadOrderRout()
            RasxodMat()
            LoadDostavka()
            LoadFiles()
            LoadExpensesOrder()
            LoadTasks()

            allow = True
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        ModCallForm.CallForm("Заявка на доставку", 17, 3)

        LoadDostavka()
    End Sub

    Private Sub ПовторитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПовторитьToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Повторить заказ?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                RetryOrder()

                MsgBox("Повтор заказа выполнен. Новый заказ сохранен в состоянии расчет. Для работы с ним необходимо в фильтре состояния установит галочку Расчет.", MsgBoxStyle.Information, appName)

                Me.Close()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub RetryOrder()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_Retry"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int)) 'Описываем параметры
            cmd.Parameters("@costID").Value = costID
            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
            cmd.Parameters("@emplID").Value = emplID
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ofID", SqlDbType.Int))
            cmd.Parameters("@ofID").Value = ofID

            mcnnInt.Open()
            cmd.ExecuteNonQuery()
            '  mcnnInt.Close()
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Sub
        Finally
            mcnnInt.Close()
        End Try
    End Sub


    Private Sub tsbtnUpdateDostavka_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnUpdateDostavka.Click
        LoadDostavka()
    End Sub

    Private Sub tscmbDep_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tscmbDep.SelectedIndexChanged
        Try
            If Me.tscmbDep.SelectedIndex <> -1 Then
                Dim odaEmplRout As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName FROM Departments INNER JOIN Employees ON Departments.dirDepEmplID=Employees.emplID order by emplLastName ", mcnnInt)
                Dim dtEmplRout As New DataTable : odaEmplRout.Fill(dtEmplRout)

                Me.tscmbExecutor.ComboBox.DataSource = dtEmplRout
                Me.tscmbExecutor.ComboBox.DisplayMember = "emplLastName"
                Me.tscmbExecutor.ComboBox.ValueMember = "emplID"
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub tscmbServices_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tscmbServices.KeyDown
        If e.KeyCode = Keys.Enter And Me.tscmbServices.DroppedDown = False Then
            If allowStatusChange = True Then ' =true после первой активации
                serviceID = Me.tscmbServices.ComboBox.SelectedItem(0)

                Try 'вызов форм
                    ModCallForm.CallForm(Me.tscmbServices.ComboBox.Text, Module1.NonQuery1Scalar("SELECT formCostNumber FROM Services WHERE ID=" & serviceID & " "), 1)
                Catch ex As System.Exception
                    MsgBox(ex.Message + " - Ошибка при вызове формы расчета стоимости. Проверь указан ли номер формы в таблице Services и цены на услуги.", MsgBoxStyle.Critical, appName)
                End Try
            End If
        End If
    End Sub

    Private Sub cmbRoutDescription_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRoutDescription.SelectedIndexChanged
        Me.txtPurposeRout.Text = sender.text
    End Sub

    Private Sub КопироватьОписаниеToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КопироватьОписаниеToolStripMenuItem.Click
        Clipboard.Clear()
        Clipboard.SetText(Me.dgTasks("Описание", Me.dgTasks.CurrentRow.Index).Value())
    End Sub

    Private Sub СкидкаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СкидкаToolStripMenuItem.Click
        Dim skidka = InputBox("Введи скидку на весь заказ", "Скидка, операция необратима", "0")

        If CInt(skidka) > 15 Then
            MsgBox("Скидка не может быть более 15%.", MsgBoxStyle.Critical, appName)
            Exit Sub
        Else
            SkidkaTotal(skidka)
        End If
    End Sub

    Private Sub SkidkaTotal(skidka As Integer)
        If skidka = Nothing Then
            Exit Sub
        Else
            If IsNumeric(skidka) = False Then
                MsgBox("Скидка должна быть числом.", MsgBoxStyle.Critical, appName)
                Exit Sub
            Else

                Dim strNac$

                If skidka < 0 Then
                    strNac = "Применить общую наценку к заказу +"
                Else
                    If skidka > 100 Then
                        MsgBox("Скидка не может быть больше 100%.", MsgBoxStyle.Critical, appName)
                        Exit Sub
                    Else
                        If skidka = 0 Then
                            MsgBox("Скидка не может быть равна 0%.", MsgBoxStyle.Critical, appName)
                            Exit Sub
                        Else
                            strNac = "Применить общую скидку к заказу -"
                        End If

                    End If
                End If

                If MsgBox(Prompt:=strNac + CStr(skidka) + "% ? ", Buttons:=vbYesNo, Title:=appName) = MsgBoxResult.Yes Then

                    Module1.NonQuery1("UPDATE Orders set cost=cost*" & Replace((100 - skidka) / 100, ",", ".") & " WHERE costID=" & costID & "")
                    Module1.NonQuery1("UPDATE Costs set skidka=" & skidka & " WHERE costID=" & costID & "")

                    LoadTechParametr()
                    PayOrder()
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub УдалитьВсеToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles УдалитьВсеToolStripMenuItem.Click
        If currentStatus > 1 Then
            If EditSpec = True Then
                Select Case MsgBox(Prompt:="Удалить все позиции спецификации?", Buttons:=vbYesNo, Title:=appName)
                    Case Is = vbYes
                        Module1.NonQuery1("DELETE FROM Orders WHERE costID=" & costID & "")
                        Me.dgSpec.DataSource = Nothing
                    Case Is = vbNo
                        Exit Sub
                End Select
            Else
                MsgBox("Для удаления строки спецификации заказ необходимо перевести в состояние Расчет.", MsgBoxStyle.Critical, appName) : Exit Sub
            End If
        Else
            Select Case MsgBox(Prompt:="Удалить все позиции спецификации?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM Orders WHERE costID=" & costID & "")
                    Me.dgSpec.DataSource = Nothing
                Case Is = vbNo
                    Exit Sub
            End Select
        End If
    End Sub

    Private Sub btnPath1_Click(sender As System.Object, e As System.EventArgs) Handles btnPath1.Click
        If Me.FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Me.txtPath1.Text = FolderBrowserDialog1.SelectedPath
            Module1.NonQuery1("UPDATE Costs set path1 = '" & Me.txtPath1.Text & "' WHERE costID=" & costID & "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnPath2_Click(sender As System.Object, e As System.EventArgs) Handles btnPath2.Click
        If Me.FolderBrowserDialog2.ShowDialog() = DialogResult.OK Then
            Me.txtPath2.Text = FolderBrowserDialog2.SelectedPath
            Module1.NonQuery1("UPDATE Costs set path2='" & Me.txtPath2.Text & "' WHERE costID=" & costID & "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnPath3_Click(sender As System.Object, e As System.EventArgs) Handles btnPath3.Click
        If Me.FolderBrowserDialog3.ShowDialog() = DialogResult.OK Then
            Me.txtPath3.Text = FolderBrowserDialog3.SelectedPath

            Module1.NonQuery1("UPDATE Costs set path3='" & Me.txtPath3.Text & "' WHERE costID=" & costID & "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.txtPath1.Text <> Nothing Then procNotepad = Process.Start("explorer.exe", Me.txtPath1.Text)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.txtPath2.Text <> Nothing Then procNotepad = Process.Start("explorer.exe", Me.txtPath2.Text)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Me.txtPath3.Text <> Nothing Then procNotepad = Process.Start("explorer.exe", Me.txtPath3.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Module1.NonQuery1("UPDATE Costs set path1='" & Me.txtPath1.Text & "' WHERE costID=" & costID & "")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Module1.NonQuery1("UPDATE Costs set path2='" & Me.txtPath2.Text & "' WHERE costID=" & costID & "")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Module1.NonQuery1("UPDATE Costs set path3='" & Me.txtPath3.Text & "' WHERE costID=" & costID & "")
    End Sub

    Private Sub tsbtnSendSMS_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSendSMS.Click
        Dim frmSelect As New frmSMSsender : frmSelect.ShowDialog()
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "invoiceKA_ID" Or col.name = "typeFile" Or col.name = "linkToFile" Or col.name = "emplID" Or col.name = "prim2" Or col.name = "KAgentID" Or col.name = "ordID" Or col.name = "payID" Or col.name = "matCatID" Or col.name = "ID" Or col.name = "typeID" Or col.name = "matID" Or col.name = "costID" Or col.name = "foplID" Then
                col.visible = False
            End If

            If col.name = "Стоимость" Or col.name = "Стоимость за ед." Or col.name = "Закупка" Then
                col.visible = visibleCostOrder
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Private Sub cmbTemplateDes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTemplateDes.SelectedValueChanged
        If Me.cmbTemplateDes.SelectedIndex <> -1 Then
            Me.txtprim.Text += Module1.NonQuery1ScalarString("SELECT desText FROM DescriptionTemlate WHERE ID=" & Me.cmbTemplateDes.SelectedItem(0) & "")
        End If
    End Sub

    Private Sub Отсрочка1ДеньToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Отсрочка1ДеньToolStripMenuItem.Click
        Module1.NonQuery1("UPDATE Tasks SET data_Plan=DATEADD(day, 1, data_Plan) WHERE ID=" & Me.dgTasks("ID", Me.dgTasks.CurrentRow.Index).Value() & "")

        LoadTasks()
    End Sub

    Private Sub tsbtnRobokassa_Click(sender As Object, e As EventArgs) Handles tsbtnRobokassa.Click
        Dim strSumma As String = InputBox("Сумма к оплате", appName, dolgi)

        If Len(strSumma) = 0 Or IsNumeric(strSumma) = False Then
            MsgBox("Значение суммы к оплате должно быть числом, отличным от нуля.", MessageBoxIcon.Error, appName)
            Exit Sub
        Else
            Dim sql As String = "insert into Payments (foplID, costID, summa, custID, emplID, date_PayDoc, onlinePaymentTypeID, organizationID, stateID) " +
                                "values(3, " + CStr(costID) + ", " + strSumma.Replace(",", ".") + ", (select custID from Costs where costID =  " + CStr(costID) + "), 3, GETDATE(), 3, (SELECT opt.orgID FROM OnlinePaymentsType opt WHERE opt.ID = 3), 1) " +
                                "SELECT  @@Identity as payID"
            Dim invId As Integer = Module1.NonQueryScalarInt(sql)

            Clipboard.SetText("http://my.enjoyprint.ru/YandexPayment.aspx?invId=" & CStr(invId) & "&orgId=15892&isNew=1")
            MsgBox("Скопировал в буфер обмена ссылку для оплаты.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub mdmprintPayButton_Click(sender As Object, e As EventArgs) Handles mdmprintPayButton.Click
        Dim strSumma As String = InputBox("Сумма к оплате", appName, dolgi)

        If Len(strSumma) = 0 Or IsNumeric(strSumma) = False Then
            MsgBox("Значение суммы к оплате должно быть числом, отличным от нуля.", MessageBoxIcon.Error, appName)
            Exit Sub
        Else
            Dim sql As String = "insert into Payments (foplID, costID, summa, custID, emplID, date_PayDoc, onlinePaymentTypeID, organizationID, stateID) " +
                                "values(3, " + CStr(costID) + ", " + strSumma.Replace(",", ".") + ", (select custID from Costs where costID =  " + CStr(costID) + "), 3, GETDATE(), 2, (SELECT opt.orgID FROM OnlinePaymentsType opt WHERE opt.ID = 2), 1) " +
                                "SELECT  @@Identity as payID"
            Dim invId As Integer = Module1.NonQueryScalarInt(sql)

            Clipboard.SetText("http://my.mdmprint.ru/YandexPayment.aspx?invId=" & CStr(invId) & "&orgId=195&isNew=1")
            MsgBox("Скопировал в буфер обмена ссылку для оплаты.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub ОтказОтЗаказаToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ОтказОтЗаказаToolStripMenuItem1.Click
        CancelledOrder(1)
    End Sub

    Private Sub tsbtnRobokassa1_Click(sender As Object, e As EventArgs) Handles tsbtnRobokassa1.Click
        Dim strSumma As String = InputBox("Сумма к оплате", appName, dolgi)

        If Len(strSumma) = 0 Or IsNumeric(strSumma) = False Then
            MsgBox("Значение суммы к оплате должно быть числом, отличным от нуля.", MessageBoxIcon.Error, appName)
            Exit Sub
        Else
            Dim sql As String = "insert into Payments (foplID, costID, summa, custID, emplID, date_PayDoc, onlinePaymentTypeID, organizationID, stateID) " +
	            "values(3, " + CStr(costID) + ", " + strSumma.Replace(",", ".") + ", (select custID from Costs where costID =  " + CStr(costID) + "), 3, GETDATE(), 1, (SELECT opt.orgID FROM OnlinePaymentsType opt WHERE opt.ID = 1), 1) " +
                "SELECT  @@Identity as payID"
            Dim invId As Integer = Module1.NonQueryScalarInt(sql)

            Clipboard.SetText("http://my.mdmprint.ru/RobokassaPayment.aspx?invId=" & CStr(invId) & "&isNew=1")
            MsgBox("Скопировал в буфер обмена ссылку для оплаты.", MsgBoxStyle.Information, appName)
        End If
    End Sub
    
    Private Sub documentHasErrorCheckBox_Click(sender As Object, e As EventArgs) Handles chkDocumentHasError.Click
        If (Not IsEnabledForEditingWithCancelledOrder()) Then
            Exit Sub
        End If

        Dim postId As Integer = Module1.NonQueryScalarInt("SELECT postID FROM Employees WHERE emplID=" & emplID & "")
        if (postId <> 9 AND postId <> 1016 AND chkDocumentHasError.Checked) Then
            MessageBox.Show(Me, "Только бухгалтер или руководитель отдела продаж имеет право редактировать это свойство!", appName)
            Exit Sub
        End If

        Dim documentHasErrorForm As DocumentHasErrorForm = New DocumentHasErrorForm()
        If chkDocumentHasError.Checked Then
            documentHasErrorForm.Text = "Проблема решена"
        Else
            documentHasErrorForm.Text = "Проблема с документами"
        End If
        AddHandler documentHasErrorForm.Closing, AddressOf DocumentHasErrorForm_Closing
        documentHasErrorForm.ShowDialog(Me)
    End Sub

    Private Sub DocumentHasErrorForm_Closing(sender As Object, cancelEventArgs As CancelEventArgs)
        Dim documentHasErrorForm As DocumentHasErrorForm = sender
        If documentHasErrorForm.IsOkButtonClicked Then
            Dim message As String = documentHasErrorForm.MessageTextBox.Text
            Dim isDocumentHasError As Boolean = Not chkDocumentHasError.Checked

            Dim dbIsDocumentHasError As Integer
            If isDocumentHasError Then
                dbIsDocumentHasError = 1
            Else
                dbIsDocumentHasError = 0
            End If
            NonQuery1("UPDATE Costs SET isDocumentHasError=" & dbIsDocumentHasError & " WHERE costID=" & costID & "")

            NonQuery1("INSERT INTO DocumentErrorRecords (costID, employeeID, dateAndTime, description) VALUES (" & costID & ", " & emplID & ", GETDATE(), '" & message & "');")

            chkDocumentHasError.Checked = isDocumentHasError
        End If
        RemoveHandler documentHasErrorForm.Closing, AddressOf DocumentHasErrorForm_Closing
    End Sub

    Private Sub tsbtnPrintLabel_Click(sender As Object, e As EventArgs) Handles tsbtnPrintLabel.Click
        Dim frmSelect As New frmPrintLabel
        frmSelect.ShowDialog()
    End Sub

    Private Sub tslOpenClose_MouseDown(sender As Object, e As MouseEventArgs) Handles tslOpenClose.MouseDown
        If (e.Button = MouseButtons.Right And orderClosed) Then
            Dim p As Point = e.Location
            p.Offset(tslOpenClose.Bounds.Location)
            OrderClosedContextMenuStrip.Show(tsControl.PointToScreen(p))
        End If
    End Sub

    Private Sub RevertCloseItem_Click(sender As Object, e As EventArgs) Handles RevertCloseItem.Click
        Dim sql As String = "UPDATE Costs SET orderClosed=0, dateClosing=NULL WHERE costID=" & costID
        Module1.NonQuery1(sql)
        LoadOrder()
    End Sub
    
    Private Sub tslCanceledOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles tslCanceledOrder.MouseDown
        If (Not CanceledOrder) Then
            Exit Sub
        End If

        If (e.Button = MouseButtons.Right And orderCancelled) Then
            Dim p As Point = e.Location
            p.Offset(tslOpenClose.Bounds.Location)
            OrderCancelledContextMenuStrip.Show(tsControl.PointToScreen(p))
        End If
    End Sub

    Private Sub RevertCancelledItem_Click(sender As Object, e As EventArgs) Handles RevertCancelledItem.Click
        Dim sql As String = "UPDATE Costs SET cancelled=0 WHERE costID=" & costID
        Module1.NonQuery1(sql)
        LoadOrder()
        LoadTechParametr()
    End Sub

    Private Sub CancelCostItem_Click(sender As Object, e As EventArgs) Handles CancelCostItem.Click
        Dim fragment As String = InputBox("Причина:", "Ануллирование заказа", "")

        If Len(fragment) > 0 Then
            Try
                SavePrim("Заказ ануллирован по причине: " + fragment)

                Module1.NonQuery1("UPDATE Costs SET cancelled=1,modifiedOn='" & Now().Date & "' WHERE costID=" & costID & "")
                Module1.NonQuery1("insert into Rejection (costID,emplID,description,summa,onlyCancelled) VALUES (" & costID & "," & emplID & ",'" & fragment & "'," & Replace(cost, ",", ".") & ",1)")
                MsgBox("Заказ успешно аннулирован.", MessageBoxIcon.Information, appName)
            Catch oexpData As System.Exception
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub tsbtnDelRout_Click(sender As Object, e As EventArgs) Handles tsbtnDelRout.Click
        If (dgOrderRout.SelectedRows.Count = 0) Then
            MessageBox.Show(Me, "Не выбрана запись для удаления!", appName)
            Exit Sub
        End If

        Dim id As Integer = CInt(dgOrderRout.SelectedRows.Item(0).Cells("ID").Value)
        Module1.NonQuery1("DELETE FROM OrderRout WHERE ID=" & id)
        LoadOrderRout()
    End Sub

    Private Sub StatusStrip1_SizeChanged(sender As Object, e As EventArgs) Handles StatusStrip1.SizeChanged
        RefreshLastRoutWidth()
    End Sub

    Private Sub RefreshLastRoutWidth()
        Dim otherWidth = 0
        If (tsslOrderCost.Visible) Then otherWidth += tsslOrderCost.Width
        If (tsslOplacheno.Visible) Then otherWidth += tsslOplacheno.Width
        If (tsSLDolgi.Visible) Then otherWidth += tsSLDolgi.Width
        If (ToolStripStatusLabel4.Visible) Then otherWidth += ToolStripStatusLabel4.Width
        If (tsslKogdaVydan.Visible) Then otherWidth += tsslKogdaVydan.Width
        If (tsslBalansKA.Visible) Then otherWidth += tsslBalansKA.Width
        tsslLastRout.Width = StatusStrip1.ClientSize.Width - otherWidth - 40
    End Sub

    Private Sub SplitContainer2_SizeChanged(sender As Object, e As EventArgs) Handles SplitContainer2.SizeChanged
        RefreshMainSplitterContainerConstrains()
    End Sub

    Private Sub RefreshMainSplitterContainerConstrains()
        Dim minSize = SplitContainer2.ClientSize.Height - 472
        If (minSize < 0) Then minSize = 0
        SplitContainer2.Panel2MinSize = minSize
    End Sub

    Private Sub ПеределкаЗаказаToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ПеределкаЗаказаToolStripMenuItem1.Click
        CancelledOrder(2)
    End Sub

    Private Sub РеализацияСПроизвольнойСкидкойToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles РеализацияСПроизвольнойСкидкойToolStripMenuItem1.Click
        CancelledOrder(3)
    End Sub

End Class
