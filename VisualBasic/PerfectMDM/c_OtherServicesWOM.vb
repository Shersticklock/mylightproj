'Imports Microsoft.SqlServer.Types
Imports System.Data.SqlClient

Public Class c_OtherServicesWOM
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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tvData As System.Windows.Forms.TreeView
    Friend WithEvents iml1 As System.Windows.Forms.ImageList

    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip



    Friend WithEvents nudKolvo As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStripMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnCost As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstxtItog As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtCostUnit As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbtnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmHierarchyid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ƒÓ·‡‚ËÚ¸ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtPrim As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmsAddInterest As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nudCostUnit As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPriceIN As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtSkidka As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tstxtNac As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ”‰‡ÎËÚ¸ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(c_OtherServicesWOM))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvData = New System.Windows.Forms.TreeView()
        Me.cmHierarchyid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ƒÓ·‡‚ËÚ¸ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.”‰‡ÎËÚ¸ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudKolvo = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrim = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.nudCostUnit = New System.Windows.Forms.NumericUpDown()
        Me.nudPriceIN = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iml1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtSkidka = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtNac = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnCost = New System.Windows.Forms.ToolStripButton()
        Me.tstxtItog = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtCostUnit = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnOK = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.cmsAddInterest = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.cmHierarchyid.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        CType(Me.nudKolvo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudCostUnit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nudPriceIN,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStripMenu.SuspendLayout
        Me.cmsAddInterest.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvData)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1126, 508)
        Me.SplitContainer1.SplitterDistance = 428
        Me.SplitContainer1.TabIndex = 43
        '
        'tvData
        '
        Me.tvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvData.ContextMenuStrip = Me.cmHierarchyid
        Me.tvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tvData.Location = New System.Drawing.Point(0, 0)
        Me.tvData.Name = "tvData"
        Me.tvData.Size = New System.Drawing.Size(426, 506)
        Me.tvData.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tvData, "œÂ‚˚È ÛÓ‚ÂÌ¸ - Í‡ÚÂ„ÓËË, ‚ÚÓÓÈ ÛÓ‚ÂÌ¸ - ÚËÔ˚ Ï‡ÚÂË‡ÎÓ‚")
        '
        'cmHierarchyid
        '
        Me.cmHierarchyid.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmHierarchyid.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmHierarchyid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2, Me.ƒÓ·‡‚ËÚ¸ToolStripMenuItem, Me.”‰‡ÎËÚ¸ToolStripMenuItem})
        Me.cmHierarchyid.Name = "cmHierarchyid"
        Me.cmHierarchyid.Size = New System.Drawing.Size(144, 70)
        '
        'Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2
        '
        Me.Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2.Name = "Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2"
        Me.Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
        Me.Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2.Text = "Œ·ÌÓ‚ËÚ¸"
        '
        'ƒÓ·‡‚ËÚ¸ToolStripMenuItem
        '
        Me.ƒÓ·‡‚ËÚ¸ToolStripMenuItem.Name = "ƒÓ·‡‚ËÚ¸ToolStripMenuItem"
        Me.ƒÓ·‡‚ËÚ¸ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ƒÓ·‡‚ËÚ¸ToolStripMenuItem.Text = "ƒÓ·‡‚ËÚ¸"
        '
        '”‰‡ÎËÚ¸ToolStripMenuItem
        '
        Me.”‰‡ÎËÚ¸ToolStripMenuItem.Name = "”‰‡ÎËÚ¸ToolStripMenuItem"
        Me.”‰‡ÎËÚ¸ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.”‰‡ÎËÚ¸ToolStripMenuItem.Text = "”‰‡ÎËÚ¸"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudKolvo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrim, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nudCostUnit, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudPriceIN, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(692, 506)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(267, 32)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = " ÓÎË˜ÂÒÚ‚Ó"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudKolvo
        '
        Me.nudKolvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudKolvo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudKolvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudKolvo.Location = New System.Drawing.Point(276, 3)
        Me.nudKolvo.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudKolvo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudKolvo.Name = "nudKolvo"
        Me.nudKolvo.Size = New System.Drawing.Size(413, 26)
        Me.nudKolvo.TabIndex = 80
        Me.nudKolvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudKolvo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 32)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "÷ÂÌ‡ Á‡ÍÛÔÍË Á‡ Ó‰ÌÛ Â‰ËÌËˆÛ (Û·.)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 32)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "÷ÂÌ‡ ÔÓ‰‡ÊË Á‡ Ó‰ÌÛ Â‰ËÌËˆÛ (Û·.)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrim
        '
        Me.txtPrim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPrim, 2)
        Me.txtPrim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPrim.Location = New System.Drawing.Point(3, 135)
        Me.txtPrim.Multiline = true
        Me.txtPrim.Name = "txtPrim"
        Me.txtPrim.Size = New System.Drawing.Size(686, 368)
        Me.txtPrim.TabIndex = 93
        '
        'btnSave
        '
        Me.btnSave.AutoSize = true
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSave.Location = New System.Drawing.Point(276, 99)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(413, 30)
        Me.btnSave.TabIndex = 90
        Me.btnSave.Text = "œËÏÂÌËÚ¸"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'nudCostUnit
        '
        Me.nudCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudCostUnit.DecimalPlaces = 2
        Me.nudCostUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudCostUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudCostUnit.Location = New System.Drawing.Point(276, 67)
        Me.nudCostUnit.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudCostUnit.Name = "nudCostUnit"
        Me.nudCostUnit.Size = New System.Drawing.Size(413, 26)
        Me.nudCostUnit.TabIndex = 94
        Me.nudCostUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudPriceIN
        '
        Me.nudPriceIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudPriceIN.DecimalPlaces = 2
        Me.nudPriceIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudPriceIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudPriceIN.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPriceIN.Location = New System.Drawing.Point(276, 35)
        Me.nudPriceIN.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPriceIN.Name = "nudPriceIN"
        Me.nudPriceIN.Size = New System.Drawing.Size(413, 26)
        Me.nudPriceIN.TabIndex = 95
        Me.nudPriceIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 36)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "œËÏÂ˜‡ÌËÂ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'iml1
        '
        Me.iml1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iml1.ImageSize = New System.Drawing.Size(16, 16)
        Me.iml1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStripMenu
        '
        Me.ToolStripMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripMenu.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tstxtSkidka, Me.ToolStripLabel1, Me.tstxtNac, Me.tsbtnCost, Me.tstxtItog, Me.ToolStripLabel3, Me.tstxtCostUnit, Me.tsbtnOK, Me.ToolStripSeparator1, Me.tsbtnExit})
        Me.ToolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripMenu.Location = New System.Drawing.Point(1132, 0)
        Me.ToolStripMenu.Name = "ToolStripMenu"
        Me.ToolStripMenu.Size = New System.Drawing.Size(144, 514)
        Me.ToolStripMenu.TabIndex = 44
        Me.ToolStripMenu.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(142, 18)
        Me.ToolStripLabel2.Text = "Õ‡ˆÂÌÍ‡, Û·."
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tstxtSkidka
        '
        Me.tstxtSkidka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtSkidka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtSkidka.Name = "tstxtSkidka"
        Me.tstxtSkidka.Size = New System.Drawing.Size(140, 24)
        Me.tstxtSkidka.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(142, 18)
        Me.ToolStripLabel1.Text = "Õ‡ˆÂÌÍ‡, %"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tstxtNac
        '
        Me.tstxtNac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtNac.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtNac.Name = "tstxtNac"
        Me.tstxtNac.Size = New System.Drawing.Size(140, 25)
        Me.tstxtNac.Text = "0"
        Me.tstxtNac.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnCost
        '
        Me.tsbtnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.tsbtnCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCost.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnCost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCost.Name = "tsbtnCost"
        Me.tsbtnCost.Size = New System.Drawing.Size(142, 31)
        Me.tsbtnCost.Text = "—˜ËÚ‡Ú¸"
        '
        'tstxtItog
        '
        Me.tstxtItog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtItog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtItog.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtItog.Name = "tstxtItog"
        Me.tstxtItog.ReadOnly = true
        Me.tstxtItog.Size = New System.Drawing.Size(140, 34)
        Me.tstxtItog.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(142, 18)
        Me.ToolStripLabel3.Text = "÷ÂÌ‡ Á‡ Â‰ËÌËˆÛ"
        '
        'tstxtCostUnit
        '
        Me.tstxtCostUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.tstxtCostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtCostUnit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tstxtCostUnit.Name = "tstxtCostUnit"
        Me.tstxtCostUnit.ReadOnly = true
        Me.tstxtCostUnit.Size = New System.Drawing.Size(140, 23)
        Me.tstxtCostUnit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsbtnOK
        '
        Me.tsbtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOK.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOK.Name = "tsbtnOK"
        Me.tsbtnOK.Size = New System.Drawing.Size(142, 37)
        Me.tsbtnOK.Text = "Œ "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
        '
        'tsbtnExit
        '
        Me.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(142, 22)
        Me.tsbtnExit.Text = "¬˚ıÓ‰"
        '
        'cmsAddInterest
        '
        Me.cmsAddInterest.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsAddInterest.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsAddInterest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem})
        Me.cmsAddInterest.Name = "cmsAddInterest"
        Me.cmsAddInterest.Size = New System.Drawing.Size(206, 28)
        '
        'ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem
        '
        Me.ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem.Name = "ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem"
        Me.ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem.Text = "ƒÓ·‡‚ËÚ¸ ËÌÚÂÂÒ"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144!))
        Me.TableLayoutPanel2.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ToolStripMenu, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1276, 514)
        Me.TableLayoutPanel2.TabIndex = 45
        '
        'c_OtherServicesWOM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(1276, 514)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimizeBox = false
        Me.Name = "c_OtherServicesWOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "///"
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.cmHierarchyid.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        CType(Me.nudKolvo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudCostUnit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nudPriceIN,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStripMenu.ResumeLayout(false)
        Me.ToolStripMenu.PerformLayout
        Me.cmsAddInterest.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

#End Region

    Dim Itogo@ '
    Dim matQuantity As Decimal
    Dim vidService As String

#Region " «‡„ÛÁÍ‡ ÙÓÏ˚ "
    Private Sub c_OtherServices_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Text = Module1.NonQuery1ScalarString("SELECT Name FROM Services where ID = " & serviceID & " ")
        ' Me.tslSkidka.Text = Replace(Module1.NonQuery1ScalarString("SELECT coalesce(skidka, '') FROM Services where ID = " & serviceID & " "), ";", Chr(13))
        skidkaCust = Module1.NonQuery1Scalar("Select coalesce(Discount, 0) From KA_ServDisccount Where ID_KA=" & custID & " AND ID_Service=" & serviceID & "")

        Me.tstxtSkidka.Text = skidkaCust

        If postPrioritet <= 2 Then
            Me.Label2.Visible = True
            Me.btnSave.Visible = True
            Me.nudPriceIN.Visible = True

        Else
            Me.Label2.Visible = False
            Me.btnSave.Visible = False
            Me.nudPriceIN.Visible = False
        End If

        LoadHierarchyid()

        ' Me.cmbSelect.SelectedIndex = 0
    End Sub

    Class ClassInfo
        Public Id As String
        Public NodeID As String
    End Class

    Private Sub LoadHierarchyid()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "SELECT NodeID.GetAncestor(1) as Root, NodeID, NodeLevel, Id, Name, Title FROM ServicesOther"
            ' Using mcnnInt
            mcnnInt.Open()

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim n As TreeNode
            Dim key As String
            Dim p As TreeNode

            Me.tvData.Nodes.Clear()

            While reader.Read()
                n = New TreeNode()
                n.Text = reader.GetString(4)

                Dim i As New ClassInfo
                i.NodeID = BitConverter.ToString(reader.GetSqlBytes(1).Value)
                i.Id = reader.GetInt32(3)

                If (Not reader.IsDBNull(0)) Then
                    key = BitConverter.ToString(reader.GetSqlBytes(0).Value)
                    n.Tag = i
                    '   n.Text = n.Text + " (" + n.Tag.NodeID + ")"
                    p = FindParentNode(key, Me.tvData.Nodes)

                    If p Is Nothing Then
                        MessageBox.Show(key + " - ÌÂ Ì‡¯ÂÎ123 Ó‰ËÚÂÎˇ", appName)
                        mcnnInt.Close()
                        Exit Sub
                    Else
                        p.Nodes.Add(n)
                    End If
                Else
                    n.Tag = i
                    Me.tvData.Nodes.Add(n)
                End If
            End While


            ' End Using
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        Finally

            mcnnInt.Close()
        End Try

    End Sub

    Private Function FindParentNode(ByVal key As String, ByVal nodes As TreeNodeCollection) As TreeNode
        Dim n As TreeNode = Nothing

        Try
            For Each node As TreeNode In nodes
                If (node.Tag.NodeID = key) Then
                    n = node
                    Continue For
                Else
                    n = FindParentNode(key, node.Nodes)
                    If (Not n Is Nothing) Then
                        Continue For
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message + "222", MsgBoxStyle.Critical, appName)
            mcnnInt.Close()
        End Try

        Return n

    End Function
#End Region

#Region " ¬˚ıÓ‰ "
    Private Sub tsbtnExit_Click_1(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
#End Region

#Region " »Â‡ıËˇ "
    Private Sub ƒÓ·‡‚ËÚ¸ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ƒÓ·‡‚ËÚ¸ToolStripMenuItem.Click
        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID = " & serviceID & "") Or postPrioritet = 1 Then
            Dim strName As String = Nothing
            Dim myValue As Object

            Try
                myValue = InputBox("—ÓÁ‰‡Ú¸ ÌÓ‚Û˛ ÛÒÎÛ„Û ‚ - '" & Me.tvData.SelectedNode.Text & "'?", appName)

                If myValue = "" Then
                    MsgBox("«‡ÔËÒ¸ ÌÂ ÔÓËÁ‚Â‰ÂÌ‡", MessageBoxIcon.Information, appName) : Exit Sub
                Else
                    strName = myValue

                    Dim cmd As New SqlClient.SqlCommand

                    cmd.Connection = mcnnInt
                    cmd.CommandText = "uspAddNode"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@ParentID", SqlDbType.Int))
                    cmd.Parameters("@ParentID").Value = Me.tvData.SelectedNode.Tag.Id
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@ServicesOtherName", SqlDbType.NText))
                    cmd.Parameters("@ServicesOtherName").Value = strName
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@Title", SqlDbType.NText))
                    cmd.Parameters("@Title").Value = "new"
                    mcnnInt.Open()
                    cmd.ExecuteNonQuery()
                    mcnnInt.Close()

                    LoadHierarchyid()
                End If
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                MsgBox("ÕÂÓ·ıÓ‰ËÏÓ ‚˚‰ÂÎËÚ¸ ÛÁÂÎ.", MsgBoxStyle.Critical, appName)
            End Try
        Else
            MsgBox("ÕÂÚ Ô‡‚ Ì‡ ÍÓÌÙË„ÛËÓ‚‡ÌËÂ", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles Œ·ÌÓ‚ËÚ¸ToolStripMenuItem2.Click
        LoadHierarchyid()
    End Sub

    Private Sub tvData_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvData.AfterSelect
        vidService = Me.tvData.SelectedNode.Text

        Me.nudPriceIN.Value = NonQuery1Scalar("SELECT COALESCE(priceIN, 0) FROM ServicesOther WHERE Id = " & Me.tvData.SelectedNode.Tag.Id & " ")
        Me.nudCostUnit.Value = NonQuery1Scalar("SELECT COALESCE(priceOUT, 0) FROM ServicesOther WHERE Id = " & Me.tvData.SelectedNode.Tag.Id & " ")
    End Sub
#End Region

    Private Sub tsbtnCost_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnCost.Click
        Dim k@ = (100 + Val(Me.tstxtNac.Text - Val(Me.tstxtSkidka.Text))) / 100

        matQuantity = Me.nudKolvo.Value
        Itogo = Me.nudKolvo.Value * NonQuery1Scalar("SELECT COALESCE(priceOUT, 0) FROM ServicesOther WHERE Id = " & Me.tvData.SelectedNode.Tag.Id & " ") * k
        matQuantity = 0
        Me.tstxtItog.Text = Itogo
        Me.tstxtCostUnit.Text = Math.Round(Itogo / Me.nudKolvo.Value, 2)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet <= 2 Then
            Dim strSQL$ = "UPDATE ServicesOther SET priceIN=" & Replace(Me.nudPriceIN.Value, ",", ".") & ", priceOut=" & Replace(Me.nudCostUnit.Value, ",", ".") & " WHERE Id=" & Me.tvData.SelectedNode.Tag.Id & ""

            Module1.NonQuery1(strSQL)
        Else
            MsgBox("ÕÂÚ Ô‡‚ Ì‡ ÍÓÌÙË„ÛËÓ‚‡ÌËÂ.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

#Region " ƒÓ·‡‚ËÚ¸ Í Á‡Í‡ÁÛ "
    Private Sub tsbtnOK_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOK.Click
        SaveCost()

        Me.Close()
    End Sub


    Private Sub SaveCost()
        If costID = Nothing Then
            Exit Sub
        Else
            If MessageBox.Show("ƒÓ·‡‚ËÚ¸ ‡Ò˜ÂÚ Í Á‡Í‡ÁÛ", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Not IsNumeric(Me.tstxtItog.Text) Then MsgBox("ÕÂ ÍÓÂÍÚÌÓÂ ÁÌ‡˜ÂÌËÂ ÒÚÓËÏÓÒÚË", MsgBoxStyle.Critical, appName) : Exit Sub

                Dim number$ = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString
                Dim IDmat As Integer = Module1.NonQuery1Scalar("SELECT matID FROM Materials WHERE matZak= 1")  'ID Ï‡ÚÂË‡Î‡ Á‡Í‡Á˜ËÍ‡
                Dim strSQL$ = "INSERT INTO Orders (kolvo, matID, serviceID, costID, matCount, prim, cost, edIzm, sostav, number, sizeCut, costUnit, nameForDoc) "
                strSQL &= " VALUES (" & Me.nudKolvo.Value & ", " & IDmat & ", " & serviceID & ", " & costID & ", 0, "
                strSQL &= " '" & vidService & "," & Me.txtPrim.Text & "', " & Replace(Me.tstxtItog.Text, ",", ".") & ", 1, '', " & number & ", 'ÌÂÚ', " & Replace(Me.tstxtCostUnit.Text, ",", ".") & ", '" & Me.tvData.SelectedNode.Text & "') "

                Module1.NonQuery1(strSQL)
            Else
                Exit Sub
            End If
        End If
    End Sub
#End Region

    Private Sub tstxtItog_TextChanged(sender As Object, e As System.EventArgs) Handles tstxtItog.TextChanged
        Me.tstxtCostUnit.Text = Val(sender.text) / Me.nudKolvo.Value
    End Sub


    Private Sub ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ƒÓ·‡‚ËÚ¸»ÌÚÂÂÒToolStripMenuItem.Click
        Me.tstxtItog.Text = Val(Me.tstxtItog.Text) + InputBox(appName, "ƒÓ·‡‚ËÚ¸ ËÌÚÂÂÒ", 0)
    End Sub

    Private Sub nudKolvo_GotFocus(sender As Object, e As EventArgs) Handles nudKolvo.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudKolvo_MouseClick(sender As Object, e As MouseEventArgs) Handles nudKolvo.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudKolvo_ValueChanged(sender As Object, e As EventArgs) Handles nudKolvo.ValueChanged

    End Sub

    Private Sub nudPriceIN_GotFocus(sender As Object, e As EventArgs) Handles nudPriceIN.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudPriceIN_MouseClick(sender As Object, e As MouseEventArgs) Handles nudPriceIN.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudPriceIN_ValueChanged(sender As Object, e As EventArgs) Handles nudPriceIN.ValueChanged

    End Sub

    Private Sub nudCostUnit_GotFocus(sender As Object, e As EventArgs) Handles nudCostUnit.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudCostUnit_MouseClick(sender As Object, e As MouseEventArgs) Handles nudCostUnit.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub


    Private Sub ”‰‡ÎËÚ¸ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ”‰‡ÎËÚ¸ToolStripMenuItem.Click
        If Me.tvData.SelectedNode Is Nothing Then
            MsgBox("¬˚·ÂË ÛÁÂÎ", MsgBoxStyle.Information, appName)
        Else
            If Me.tvData.SelectedNode.Nodes.Count > 0 Then
                MsgBox("—Ì‡˜‡Î‡ ÌÂÓ·ıÓ‰ËÏÓ Û‰‡ÎËÚ¸ ÔÓÚÓÏÍÓ‚", MsgBoxStyle.Information, appName)
            Else

                Try
                    Dim cmd As New SqlClient.SqlCommand

                    cmd.Connection = mcnnInt
                    cmd.CommandText = "uspDelNode"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@ServicesOtherID", SqlDbType.Int))

                    cmd.Parameters("@ServicesOtherID").Value = Me.tvData.SelectedNode.Tag.ID
                    mcnnInt.Open()
                    cmd.ExecuteNonQuery()
                    mcnnInt.Close()

                    LoadHierarchyid()
                Catch ex As System.Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                End Try
            End If
        End If
    End Sub
End Class
