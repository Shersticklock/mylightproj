Public Class tech_Equipment
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
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRow As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveCost As System.Windows.Forms.Button
    Friend WithEvents cmbDep As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmsEquip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ÄîáàâèòüToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÈçìåíèòüToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nudMhourCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgDataTable As System.Windows.Forms.DataGridView
    Friend WithEvents ÓäàëèòüToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tech_Equipment))
        Me.cmsEquip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ÄîáàâèòüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÈçìåíèòüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÓäàëèòüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpRow = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSaveCost = New System.Windows.Forms.Button()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudMhourCost = New System.Windows.Forms.NumericUpDown()
        Me.dgDataTable = New System.Windows.Forms.DataGridView()
        Me.cmsEquip.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.tlpRow.SuspendLayout
        CType(Me.nudMhourCost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgDataTable,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cmsEquip
        '
        Me.cmsEquip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmsEquip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsEquip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÄîáàâèòüToolStripMenuItem, Me.ÈçìåíèòüToolStripMenuItem, Me.ÓäàëèòüToolStripMenuItem})
        Me.cmsEquip.Name = "ContextMenuStrip1"
        Me.cmsEquip.Size = New System.Drawing.Size(134, 70)
        '
        'ÄîáàâèòüToolStripMenuItem
        '
        Me.ÄîáàâèòüToolStripMenuItem.Name = "ÄîáàâèòüToolStripMenuItem"
        Me.ÄîáàâèòüToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ÄîáàâèòüToolStripMenuItem.Text = "Äîáàâèòü"
        '
        'ÈçìåíèòüToolStripMenuItem
        '
        Me.ÈçìåíèòüToolStripMenuItem.Name = "ÈçìåíèòüToolStripMenuItem"
        Me.ÈçìåíèòüToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ÈçìåíèòüToolStripMenuItem.Text = "Èçìåíèòü"
        '
        'ÓäàëèòüToolStripMenuItem
        '
        Me.ÓäàëèòüToolStripMenuItem.Name = "ÓäàëèòüToolStripMenuItem"
        Me.ÓäàëèòüToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ÓäàëèòüToolStripMenuItem.Text = "Óäàëèòü"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.tlpRow, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgDataTable, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(953, 607)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'tlpRow
        '
        Me.tlpRow.AutoSize = true
        Me.tlpRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRow.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpRow.ColumnCount = 4
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272!))
        Me.tlpRow.Controls.Add(Me.Label2, 0, 0)
        Me.tlpRow.Controls.Add(Me.Label4, 2, 0)
        Me.tlpRow.Controls.Add(Me.txtName, 2, 1)
        Me.tlpRow.Controls.Add(Me.btnSaveCost, 3, 0)
        Me.tlpRow.Controls.Add(Me.cmbDep, 0, 1)
        Me.tlpRow.Controls.Add(Me.Label3, 1, 0)
        Me.tlpRow.Controls.Add(Me.nudMhourCost, 1, 1)
        Me.tlpRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRow.Enabled = false
        Me.tlpRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tlpRow.Location = New System.Drawing.Point(3, 551)
        Me.tlpRow.Name = "tlpRow"
        Me.tlpRow.RowCount = 2
        Me.tlpRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRow.Size = New System.Drawing.Size(947, 53)
        Me.tlpRow.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Äåïàğòàìåíò"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Îáîğóäîâàíèå"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtName.Location = New System.Drawing.Point(418, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(251, 24)
        Me.txtName.TabIndex = 8
        '
        'btnSaveCost
        '
        Me.btnSaveCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnSaveCost.Location = New System.Drawing.Point(676, 4)
        Me.btnSaveCost.Name = "btnSaveCost"
        Me.tlpRow.SetRowSpan(Me.btnSaveCost, 2)
        Me.btnSaveCost.Size = New System.Drawing.Size(267, 45)
        Me.btnSaveCost.TabIndex = 13
        Me.btnSaveCost.Text = "Ñîõğàíèòü"
        Me.btnSaveCost.UseVisualStyleBackColor = true
        '
        'cmbDep
        '
        Me.cmbDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.cmbDep.FormattingEnabled = true
        Me.cmbDep.Location = New System.Drawing.Point(4, 23)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(251, 25)
        Me.cmbDep.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ìàøèíî/÷àñ (ğóá.)"
        Me.Label3.Visible = false
        '
        'nudMhourCost
        '
        Me.nudMhourCost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudMhourCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.nudMhourCost.Location = New System.Drawing.Point(262, 23)
        Me.nudMhourCost.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudMhourCost.Name = "nudMhourCost"
        Me.nudMhourCost.Size = New System.Drawing.Size(149, 24)
        Me.nudMhourCost.TabIndex = 14
        Me.nudMhourCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgDataTable
        '
        Me.dgDataTable.AllowUserToAddRows = false
        Me.dgDataTable.AllowUserToDeleteRows = false
        Me.dgDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDataTable.ContextMenuStrip = Me.cmsEquip
        Me.dgDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDataTable.Location = New System.Drawing.Point(3, 3)
        Me.dgDataTable.Name = "dgDataTable"
        Me.dgDataTable.ReadOnly = true
        Me.dgDataTable.RowTemplate.Height = 24
        Me.dgDataTable.Size = New System.Drawing.Size(947, 542)
        Me.dgDataTable.TabIndex = 37
        '
        'tech_Equipment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(953, 607)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "tech_Equipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Îáîğóäîâàíèå "
        Me.cmsEquip.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.tlpRow.ResumeLayout(false)
        Me.tlpRow.PerformLayout
        CType(Me.nudMhourCost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgDataTable,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

#End Region

    Dim addFundCost As Boolean

    Dim modaLookupData As SqlClient.SqlDataAdapter
    Dim modaLookupData2 As SqlClient.SqlDataAdapter
    Dim objCB As SqlClient.SqlCommand

    Private Sub tech_Equipment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Çàãğóæàåì ñïèñîê äåïàğòàìåíòîâ
        Dim odaDep As SqlClient.SqlDataAdapter
        Dim dtDep As New DataTable

        odaDep = New SqlClient.SqlDataAdapter("SELECT ID, name FROM Departments order by name", mcnnInt) '("SELECT custID, Name FROM Organizations WHERE KAgent_ID  = (SELECT ID FROM KAgents WHERE type_ID = 1)", mcnnInt)
        odaDep.Fill(dtDep)

        Me.cmbDep.DataSource = dtDep
        Me.cmbDep.DisplayMember = "Name"
        Me.cmbDep.ValueMember = "ID"

        LoadData()
    End Sub

    Private Sub LoadData()
        Dim dtData As New DataTable

        Try
            modaLookupData = New SqlClient.SqlDataAdapter("SELECT tech_Equipment.ID, Departments.Name AS Äåïàğòàìåíò, tech_Equipment.Name as Îáîğóäîâàíèå FROM tech_Equipment INNER JOIN Departments ON tech_Equipment.dep_ID=Departments.ID", mcnnInt)
            modaLookupData.Fill(dtData)

            Me.dgDataTable.DataSource = dtData
            '      Me.dgDataTable.Columns(1).AutoSizeMode = True
        Catch excData As System.Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub ÄîáàâèòüToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÄîáàâèòüToolStripMenuItem.Click
        addFundCost = True
        Me.tlpRow.Enabled = True
    End Sub

    Private Sub btnSaveCost_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCost.Click
        If addFundCost = True Then
            Module1.NonQuery1("INSERT INTO tech_Equipment (Name, dep_ID) VALUES ('" & Me.txtName.Text & "', " & Me.cmbDep.SelectedItem(0) & ")")
        Else
            Module1.NonQuery1("UPDATE tech_Equipment SET dep_ID=" & Me.cmbDep.SelectedItem(0) & ", Name='" & Me.txtName.Text & "' WHERE ID=" & Me.dgDataTable("ID", Me.dgDataTable.CurrentRow.Index).Value() & "")
        End If
        Me.tlpRow.Enabled = False

        LoadData()
    End Sub


    Private Sub ÈçìåíèòüToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÈçìåíèòüToolStripMenuItem.Click
        addFundCost = False

        Try
            Dim ID% = Me.dgDataTable("ID", Me.dgDataTable.CurrentRow.Index).Value()

            Me.txtName.Text = Module1.NonQuery1ScalarString("SELECT name FROM tech_Equipment WHERE ID=" & ID & "")
            Me.cmbDep.SelectedValue = Module1.NonQuery1Scalar("SELECT dep_ID FROM tech_Equipment WHERE ID=" & ID & "")
            Me.tlpRow.Enabled = True
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub ÓäàëèòüToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÓäàëèòüToolStripMenuItem.Click
        Try
            Select Case MsgBox(Prompt:="Óäàëèòü ñòğîêó?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM tech_Equipment WHERE ID=" & Me.dgDataTable("ID", Me.dgDataTable.CurrentRow.Index).Value() & "")

                    LoadData()
                Case Is = vbNo
                    Exit Sub
            End Select
        Catch ex As System.Exception
            MsgBox("Âîçìîæíî íå âûáğàíà ñòğîêà äëÿ óäàëåíèÿ." & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
End Class
