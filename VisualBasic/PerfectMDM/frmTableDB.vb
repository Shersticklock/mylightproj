Imports System.Data.SqlClient

Public Class frmTableDB
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
    Friend WithEvents lstLookupTables As System.Windows.Forms.ListBox
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents dgTableData As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Dstz1 As PerfectCRM.DSTZ
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnReturnData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExecSQL As System.Windows.Forms.ToolStripButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableDB))
        Me.lstLookupTables = New System.Windows.Forms.ListBox()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.dgTableData = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnReturnData = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExecSQL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Dstz1 = New PerfectCRM.DSTZ()
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Dstz1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lstLookupTables
        '
        Me.lstLookupTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstLookupTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstLookupTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.lstLookupTables.ItemHeight = 17
        Me.lstLookupTables.Location = New System.Drawing.Point(1024, 3)
        Me.lstLookupTables.Name = "lstLookupTables"
        Me.lstLookupTables.Size = New System.Drawing.Size(249, 482)
        Me.lstLookupTables.TabIndex = 0
        '
        'txtSQL
        '
        Me.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtSQL.Location = New System.Drawing.Point(3, 557)
        Me.txtSQL.Multiline = true
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSQL.Size = New System.Drawing.Size(1015, 122)
        Me.txtSQL.TabIndex = 12
        '
        'dgTableData
        '
        Me.dgTableData.AllowUserToResizeRows = false
        Me.dgTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTableData.Location = New System.Drawing.Point(3, 3)
        Me.dgTableData.Name = "dgTableData"
        Me.dgTableData.RowHeadersWidth = 21
        Me.dgTableData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TableLayoutPanel1.SetRowSpan(Me.dgTableData, 3)
        Me.dgTableData.RowTemplate.Height = 24
        Me.dgTableData.ShowCellToolTips = false
        Me.dgTableData.ShowEditingIcon = false
        Me.dgTableData.Size = New System.Drawing.Size(1015, 548)
        Me.dgTableData.TabIndex = 14
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.03972!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.96028!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtSQL, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lstLookupTables, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dgTableData, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnUpdate, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPwd, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 682)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnReturnData, Me.tsbtnExecSQL, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(1021, 554)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(255, 128)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnReturnData
        '
        Me.tsbtnReturnData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnReturnData.Image = CType(resources.GetObject("tsbtnReturnData.Image"),System.Drawing.Image)
        Me.tsbtnReturnData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnReturnData.Name = "tsbtnReturnData"
        Me.tsbtnReturnData.Size = New System.Drawing.Size(253, 24)
        Me.tsbtnReturnData.Text = "Вернуть данные"
        '
        'tsbtnExecSQL
        '
        Me.tsbtnExecSQL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnExecSQL.Image = CType(resources.GetObject("tsbtnExecSQL.Image"),System.Drawing.Image)
        Me.tsbtnExecSQL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExecSQL.Name = "tsbtnExecSQL"
        Me.tsbtnExecSQL.Size = New System.Drawing.Size(253, 24)
        Me.tsbtnExecSQL.Text = "Выполнить запрос"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(253, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(253, 24)
        Me.ToolStripButton1.Text = "Выход"
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = true
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1024, 521)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(249, 30)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Сохранить изменения"
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'txtPwd
        '
        Me.txtPwd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtPwd.Location = New System.Drawing.Point(1024, 491)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(249, 24)
        Me.txtPwd.TabIndex = 17
        Me.txtPwd.Text = "Введи пароль"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = true
        Me.ErrorProvider1.Tag = "Неправильный пароль"
        '
        'Dstz1
        '
        Me.Dstz1.DataSetName = "dsTZ"
        Me.Dstz1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmTableDB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(1276, 682)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmTableDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Таблицы базы данных"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgTableData,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Dstz1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
#End Region

    Dim modaLookupData As SqlClient.SqlDataAdapter

    Private Sub lstLookupTables_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstLookupTables.DoubleClick
        LoadTable()
    End Sub

    Private Sub LoadTable()
        If Me.lstLookupTables.SelectedItem = "Offices" Then
            Me.dgTableData.AllowUserToAddRows = False
        Else
            Me.dgTableData.AllowUserToAddRows = True
        End If

        Dim dtData As New DataTable

        Try
            modaLookupData = New SqlClient.SqlDataAdapter("Select * From " & Me.lstLookupTables.Text, mcnnInt)
            modaLookupData.Fill(dtData)
            Me.dgTableData.DataSource = dtData
            ' Me.dgTableData.EditMode = DataGridViewEditMode.EditOnEnter
        Catch excData As System.Exception
            MessageBox.Show(excData.Message)
        End Try
    End Sub

    Function CheckedPass(ByVal pass As String) As Boolean
        If pass = "197630" Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub UpdateDate()
        Dim dtFromGrid As DataTable
        Dim custCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(modaLookupData)

        If CheckedPass(Me.txtPwd.Text) = True Then
            Try
                dtFromGrid = CType(Me.dgTableData.DataSource, DataTable)
                modaLookupData.Update(dtFromGrid)
                dtFromGrid.AcceptChanges()
                MessageBox.Show("Сохранил", appName)
            Catch ex As System.Exception
                MessageBox.Show(ex.Message, appName)
            End Try
        Else
            MsgBox("Неправильный пароль.", MessageBoxIcon.Error, appName)
            Me.txtPwd.Text = "Введи пароль"
            Me.ErrorProvider1.SetError(Me.txtPwd, "Неправильный пароль")
        End If
    End Sub

    Private Sub txtPwd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPwd.GotFocus
        Me.txtPwd.Text = Nothing
        Me.txtPwd.PasswordChar = "*"
    End Sub

    Private Sub frmTableDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mcnnInt.Open()
        Dim oCommand As New SqlClient.SqlCommand("SELECT name FROM sysobjects WHERE xtype='U' ORDER BY name", mcnnInt)
        Dim oDataReader As SqlClient.SqlDataReader = oCommand.ExecuteReader(CommandBehavior.CloseConnection)

        While oDataReader.Read
            Me.lstLookupTables.Items.Add(oDataReader("name").ToString)
        End While

        mcnnInt.Close()


        'Dim odaMatList As SqlClient.SqlDataAdapter
        'Dim dtMatList As DataTable = New DataTable
        'Dim strSQL$

        '' If Me.chkAllMat.Checked = False Then
        ''strSQL = " SELECT ID, matName FROM MatNames WHERE MatNames.matTypeID = '" & Me.cmbTypeMatTop.SelectedItem(0) & "' "
        ''Else
        'strSQL = " SELECT id, Name FROM TableDbName"
        ''End If
        'dtMatList.Clear()

        'Try
        '    odaMatList = New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
        '    odaMatList.Fill(dtMatList)
        '    Dim viewMat As New DataView(dtMatList)

        '    viewMat.Sort = "Name"


        '    'Связать данные со списком
        '    Me.lstLookupTables.DataSource = viewMat
        '    Me.lstLookupTables.DisplayMember = "Name"
        '    Me.lstLookupTables.ValueMember = "ID"
        'Catch oexpData As OleDb.OleDbException
        '    MsgBox(oexpData.Message)
        'End Try
        Me.lstLookupTables.Focus()
    End Sub

    Private Sub lstLookupTables_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lstLookupTables.KeyDown
        If e.KeyCode = Keys.Enter Then LoadTable()
        e.Handled = True
    End Sub

    Private Sub txtPwd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then UpdateDate()
        e.Handled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        UpdateDate()
    End Sub

    Private Sub tsbtnReturnData_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnReturnData.Click
        ' str5SQL = "UPDATE Customers SET typeKAgentID = '2'"
        Dim modaLookupData As SqlClient.SqlDataAdapter
        Dim dtData As New DataTable

        If CheckedPass(Trim(Me.txtPwd.Text)) = True Then
            Try
                modaLookupData = New SqlClient.SqlDataAdapter(Me.txtSQL.Text, mcnnInt)
                modaLookupData.Fill(dtData)

                Me.dgTableData.DataSource = dtData

            Catch ex As System.Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Неправильный пароль.", MessageBoxIcon.Error, appName)
            Me.txtPwd.Text = "Введи пароль"
            Me.ErrorProvider1.SetError(Me.txtPwd, "Неправильный пароль")
        End If
    End Sub

    Private Sub tsbtnExecSQL_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExecSQL.Click
        Dim ocmd As New SqlClient.SqlCommand

        Try
            ocmd.CommandText = Me.txtSQL.Text
            ocmd.Connection = mcnnInt
            mcnnInt.Open()
            ocmd.ExecuteNonQuery()
            '  mcnnInt.Close()
            Me.txtSQL.Text = "Запрос выполнен"
            mcnnInt.Close()
        Catch excp As System.Exception

            Clipboard.Clear()
            Clipboard.SetText(Me.txtSQL.Text)
            MsgBox("Ошибка при выполнении запроса. Скопировал запрос в буфер обмена. Подробности в следующем сообщении.", MsgBoxStyle.Information, appName)

            MessageBox.Show(excp.Message, appName) : Exit Sub
            '   MsgBox(strSQL, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
