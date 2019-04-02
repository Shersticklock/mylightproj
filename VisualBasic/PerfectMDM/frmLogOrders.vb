
Imports System.Threading.Tasks


Public Class frmLogOrders

#Region " Экспорт в Excel "
    Private Sub tsbtnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExportExcel.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        ' Dim tmpDataSet As DataTable = CType(Me.dgDataPlan.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            .Range("B2").Value = "Заказы на доставку"

            For iCol = 0 To Me.dgDataPlan.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgDataPlan.Columns(iCol).HeaderText.ToString

                For iRow = 0 To Me.dgDataPlan.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(Me.dgDataPlan(iCol, iRow).Value), "", Me.dgDataPlan(iCol, iRow).Value)
                Next iRow
                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")
    End Sub
#End Region

    Private Sub frmOrderLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tlpLogG.Visible = False
        Me.SplitContainer1.Panel1Collapsed = True
        Me.SplitContainer2.Panel2Collapsed = True
        Me.cmbSelect.SelectedIndex = 0
        'Загрузка курьеров
        'Загружаем список менеджеров
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterLogistic]"
        cmd.CommandType = CommandType.StoredProcedure

        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)

        Me.cmbExampleEmpl.DataSource = dtMan
        Me.cmbExampleEmpl.DisplayMember = "emplLastName"
        Me.cmbExampleEmpl.ValueMember = "emplID"

        Me.dtpDateG.Value = Now().Date ' Now().AddDays(1)
        Me.dtpDatePlan.Value = Now.Date 'Now().AddDays(1)
    End Sub

#Region " Процедуры загрузки желаемых и плана "
    Private Sub UpdateOrderLog() 'желаемые доставки
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_Log_G"
            cmd.CommandType = CommandType.StoredProcedure

            'Описываем параметры
            If Me.cmbSelect.SelectedIndex = 0 Then 'на дату
                cmd.Parameters.Add(New SqlClient.SqlParameter("@data1", SqlDbType.DateTime))
                cmd.Parameters("@data1").Value = Format(Me.dtpDateG.Value.Date, "s")
            End If

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtData As New DataTable : objDA.Fill(dtData)

            Me.dgData.DataSource = dtData

            ColHideDG(dgData)

            If Me.dgData.RowCount > 0 Then
                РедактироватьToolStripMenuItem.Enabled = True
            End If

        Catch excp As System.Exception
            MessageBox.Show("tt " + excp.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub UpdatePlan() 'планируемые доставки
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt

            cmd.CommandText = "sp_Order_LogPlanEmpl"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.DateTime))  'Описываем параметры
            cmd.Parameters("@Data1").Value = Me.dtpDatePlan.Value.Date

            If Me.cmbExampleEmpl.SelectedIndex <> -1 Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
                cmd.Parameters("@emplID").Value = Me.cmbExampleEmpl.SelectedItem(0)
            Else
                MsgBox("Не выбран исполнитель.", MsgBoxStyle.Critical, appName)
                Me.cmbExampleEmpl.Focus()
                Exit Sub
            End If

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtData As New DataTable : objDA.Fill(dtData)

            Me.dgDataPlan.DataSource = dtData

            ColHideDG(dgDataPlan)

        Catch excp As System.Exception
            MessageBox.Show("UpdatePlan-" + excp.Message, appName)
            Exit Sub
        End Try
    End Sub
#End Region

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "ID" Or col.name = "orderID" Or col.name = "Lat" Or col.name = "Lng" Then
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Private Sub dtpDateG_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateG.ValueChanged
        UpdateOrderLog()
    End Sub

    Private Sub chkJustInTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateOrderLog()
    End Sub

    Private Sub tsbtnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnUpdate.Click
        UpdatePlan()
    End Sub

    Private Sub НазначитьДоставкуToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles НазначитьДоставкуToolStripMenuItem.Click
        Appoint()
    End Sub

    Private Sub btnAppoint_Click(sender As System.Object, e As System.EventArgs) Handles btnAppoint.Click
        Appoint()
    End Sub

    Private Sub Appoint()
        If Me.dgData.SelectedRows.Count = 0 Then
            MsgBox("Не выбрана заявка на доставку", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        If Me.cmbExampleEmpl.SelectedIndex = -1 Then
            MsgBox("Не выбран исполнитель доставки", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        Dim strSQL$ = "UPDATE Logistics SET datePlan='" & Format(Me.dtpDatePlan.Value, "s") & "', performing_emplID=" & Me.cmbExampleEmpl.SelectedItem(0) & ","
        strSQL &= "timePlan = ('C ' + CAST(timeG1 as char(2)) + ' до ' + CAST(timeG2 as char(2)) + ' час.') "
        strSQL &= " WHERE ID=" & Me.dgData("ID", Me.dgData.CurrentRow.Index).Value() & ""

        Module1.NonQuery1(strSQL)

        Dim googlemail$ = Module1.NonQuery1ScalarString("Select googlemail FROM Employees WHERE emplID=" & Me.cmbExampleEmpl.SelectedItem(0) & "")
        Dim curInd% = Me.dgData.CurrentRow.Index()

        UpdateOrderLog() 'обновляем грид с желаемыми доставками
        UpdatePlan() 'обновляем грид с запланированными доставками
    End Sub

    Private Sub УдалитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles УдалитьToolStripMenuItem.Click
        Dim curInd% = Me.dgData.CurrentRow.Index

        Select Case MsgBox(Prompt:="Удалить " & CStr(Me.dgData(2, curInd).Value()) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM Logistics WHERE ID = " & Me.dgData("ID", curInd).Value() & " ")

                UpdateOrderLog()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub РедактироватьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles РедактироватьToolStripMenuItem.Click
        Try
            Dim frmSelect As New frmLogEdit
            frmSelect.logID = Me.dgData("ID", Me.dgData.CurrentRow.Index).Value()
            frmSelect.ShowDialog()
        Catch ex As System.Exception
            '  MessageBox.Show("Edit-" + ex.Message)
            ' Exit Sub
        End Try
    End Sub

    Private Sub chkAllG_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Me.dtpDateG.Enabled = Not sender.checked
    End Sub

    Private Sub tsbtnRevers_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnRevers.Click
        Select Case MsgBox(Prompt:="Перевести из плана в желаемые заявку " & CStr(Me.dgDataPlan(1, Me.dgDataPlan.CurrentRow.Index).Value()) & "на дату " & Me.dtpDateG.Text & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("UPDATE Logistics SET datePlan= null, performing_emplID = null, dateG= '" & Format(Me.dtpDateG.Value, "s") & "' WHERE ID = " & Me.dgDataPlan("ID", Me.dgDataPlan.CurrentRow.Index).Value() & " ")

                Me.cmbSelect.SelectedIndex = 1

                UpdatePlan()
                UpdateOrderLog()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub dgData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgData.CellDoubleClick
        MsgBox(Me.dgData("Примечания", Me.dgData.CurrentRow.Index).Value(), MsgBoxStyle.Information, appName)
    End Sub

    Private Sub dgData_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgData.MouseDoubleClick
        Try
            Dim frmSelect As New frmLogEdit

            frmSelect.logID = Me.dgData("ID", Me.dgData.CurrentRow.Index).Value()
            frmSelect.ShowDialog()
        Catch ex As System.Exception
            '  MessageBox.Show("Edit-" + ex.Message)
            ' Exit Sub
        End Try
    End Sub

    Private Sub btnUpdateG_Click_1(sender As System.Object, e As System.EventArgs) Handles btnUpdateG.Click
        UpdateOrderLog()
    End Sub

    Private Sub tsbtnDn_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnDn.Click
        If Me.dgDataPlan.Rows.Count = 0 Then Exit Sub
        If Me.dgDataPlan.Rows.Count - Me.dgDataPlan.SelectedRows.Item(0).Index = 1 Then Exit Sub

        Me.dgDataPlan.SelectedRows.Item(0).Cells("ranger").Value() = Me.dgDataPlan.SelectedRows.Item(0).Cells("ranger").Value() + 1
        Me.dgDataPlan("ranger", Me.dgDataPlan.SelectedRows.Item(0).Index + 1).Value() = Me.dgDataPlan("ranger", Me.dgDataPlan.SelectedRows.Item(0).Index + 1).Value() - 1
        Me.dgDataPlan.ClearSelection()
        Me.dgDataPlan.Rows(Me.dgDataPlan.CurrentRow.Index).Selected = False
        Me.dgDataPlan.Rows(Me.dgDataPlan.CurrentRow.Index + 1).Selected = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim sss As String
      
        sss = WebBrowser1.Document.GetElementById("pole").OuterHtml
        MsgBox(sss)
        'http://stackoverflow.com/questions/15123910/vb-net-function-does-not-return-value-on-all-code-paths
        sss = WebBrowser1.Document.GetElementById("pole").GetAttribute("value").ToString

        MsgBox(sss)
    End Sub


    Private Sub tscmbSelect_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSelect.SelectedIndexChanged
        If sender.selectedindex = 0 Then
            Me.dtpDateG.Visible = True
        Else
            Me.dtpDateG.Visible = False
        End If
    End Sub

    'декларация переменной 
    Public WithEvents elmHTML As HtmlElement

    Dim coo As String

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.WebBrowser1.Document.InvokeScript("initialize", New String() {coo})
    End Sub

    Private Sub elmHTML_Click(ByVal sender As Object, ByVal e As HtmlElementEventArgs) 'Handles elmHTML.Click 
        MsgBox(WebBrowser1.Document.GetElementById("pole").GetAttribute("value").ToString)
    End Sub

    Private Sub ПерейтиКЗаказуToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem.Click
        Dim frmSelect As frmOrder

        Try
            frmSelect = New frmOrder
            costID = Me.dgData("orderID", Me.dgData.CurrentRow.Index).Value()
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

    Private Sub ПерейтиКЗаказуToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem1.Click
        Dim frmSelect As frmOrder

        Try
            frmSelect = New frmOrder
            costID = Me.dgDataPlan("orderID", Me.dgDataPlan.CurrentRow.Index).Value()
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

    Private Sub tsbtnToMap_Click(sender As Object, e As EventArgs) Handles tsbtnToMap.Click
        Try
            Me.WebBrowser1.Navigate(Application.StartupPath + "\map.html")
            coo$ = Replace(Me.dgData("Lng", Me.dgData.CurrentRow.Index).Value().ToString, ",", ".") + "," + Replace(Me.dgData("Lat", Me.dgData.CurrentRow.Index).Value().ToString, ",", ".")
        Catch ex As System.Exception
            MsgBox("загрузка-" & Application.StartupPath + "\map.html " & ex.Message, appName)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModCallForm.CallForm("Заявка на доставку", 17, 3)
    End Sub

End Class