Public Class Calendar
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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgProd As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtUpdate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calendar))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUpdate = New System.Windows.Forms.Button()
        Me.dgProd = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.dgProd,System.ComponentModel.ISupportInitialize).BeginInit
        Me.FlowLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btnExit.Location = New System.Drawing.Point(3, 101)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 28)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Выход"
        '
        'txtUpdate
        '
        Me.txtUpdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.txtUpdate.Location = New System.Drawing.Point(3, 66)
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.Size = New System.Drawing.Size(161, 29)
        Me.txtUpdate.TabIndex = 13
        Me.txtUpdate.Text = "Сохранить"
        '
        'dgProd
        '
        Me.dgProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProd.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProd.Location = New System.Drawing.Point(3, 3)
        Me.dgProd.Name = "dgProd"
        Me.dgProd.Size = New System.Drawing.Size(677, 505)
        Me.dgProd.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = true
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.DateTimePicker1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtUpdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExit)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(686, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(167, 132)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = false
        Me.DateTimePicker1.Enabled = false
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(161, 24)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 27)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Расчитать"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.dgProd, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(856, 511)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'Calendar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(856, 511)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Календарь"
        CType(Me.dgProd,System.ComponentModel.ISupportInitialize).EndInit
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

#End Region

    Dim modaLookupData As SqlClient.SqlDataAdapter
    ' Dim modaLookupData2 As SqlClient.SqlDataAdapter
    Dim objCB As SqlClient.SqlCommand
    Dim dtData As New DataTable

    

#Region " Сохранить изменения "
    Private Sub txtUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUpdate.Click
        Module1.NonQuery1("DELETE FROM Calendar")

        Dim date1 As Date = Me.DateTimePicker1.Value.Date
        Dim kolVoDay As Integer = 0

        For m As Integer = 1 To 12
            kolVoDay += Date.DaysInMonth(Now.Year, m)
        Next

        For d As Integer = 0 To kolVoDay - 1

            dtData.Rows.Add()
            dtData.Rows(d)("date") = date1

            If date1.DayOfWeek = 0 Or date1.DayOfWeek = 6 Then
                dtData.Rows(d)("timeStart") = 0
                dtData.Rows(d)("timeEnd") = 24
                dtData.Rows(d)("duration") = 24
                dtData.Rows(d)("dayoff") = 1
            Else
                dtData.Rows(d)("timeStart") = 10
                dtData.Rows(d)("timeEnd") = 18
                dtData.Rows(d)("duration") = 8
                dtData.Rows(d)("dayoff") = 0
            End If

            date1 = date1.AddDays(1)
        Next

        Me.dgProd.DataSource = dtData


        Dim dtFromGrid As DataTable
        Dim custCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(modaLookupData)

        Try
            mcnnInt.Open()
            dtFromGrid = CType(Me.dgProd.DataSource, DataTable)
            modaLookupData.Update(dtFromGrid)
            dtFromGrid.AcceptChanges()
            mcnnInt.Close()

            MsgBox("Готово", MsgBoxStyle.Information, appName)
        Catch exData As System.Exception
            MsgBox(exData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim date1 As Date = Me.DateTimePicker1.Value.Date
        Dim kolVoDay As Integer = 0

        For m As Integer = 1 To 12
            kolVoDay += Date.DaysInMonth(Now.Year, m)
        Next

        For d As Integer = 0 To kolVoDay - 1

            dtData.Rows.Add()
            dtData.Rows(d)("date") = date1

            If date1.DayOfWeek = 0 Or date1.DayOfWeek = 6 Then
                dtData.Rows(d)("timeStart") = 0
                dtData.Rows(d)("timeEnd") = 24
                dtData.Rows(d)("duration") = 24
                dtData.Rows(d)("dayoff") = 1
            Else
                dtData.Rows(d)("timeStart") = 10
                dtData.Rows(d)("timeEnd") = 18
                dtData.Rows(d)("duration") = 8
                dtData.Rows(d)("dayoff") = 0
            End If

            date1 = date1.AddDays(1)
        Next

        Me.dgProd.DataSource = dtData

        'Me.DateTimePicker1.Value = Now().Date 'Date.Today.AddDays(-30)
    End Sub

    Private Sub Calendar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = "01.01." + Now().Year.ToString

        Try
            '  dtData = New DataTable
            modaLookupData = New SqlClient.SqlDataAdapter("SELECT * FROM Calendar", mcnnInt)
            modaLookupData.Fill(dtData)
            Me.dgProd.DataSource = dtData
        Catch excData As System.Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub
End Class
