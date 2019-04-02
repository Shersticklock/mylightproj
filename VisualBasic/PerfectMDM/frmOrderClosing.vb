Public Class frmOrderClosing
    Dim s As Boolean = False
    Dim d As Integer = 0

    Private Sub dgTableData_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTableData.SelectionChanged
        'Dim s% = 0
        'Dim n As Integer = 0

        'd = 0
        'costIDstr = Nothing

        'For Each row As Object In Me.dgTableData.Rows
        '    If row.selected Then
        '        s = s + 1
        '        d += Me.dgTableData("Стоимость", n).Value
        '        If s > 1 Then costIDstr += ","
        '        ' costIDstr += Me.dgTableData("costID", n).Value.ToString
        '    End If
        '    n += 1
        'Next
    End Sub

    Private Sub tsbtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnUpdate.Click

        UpdateOrders()

        Me.tsbtnSelAll.Visible = True
        Me.tsbtnOrderClose.Visible = True
        Me.tsbtnOrderClose.Visible = True
        Me.tsbtnExportToExcel.Visible = True
    End Sub

    Private Sub UpdateOrders()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_Closing"
            cmd.CommandType = CommandType.StoredProcedure

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtData As New DataTable : objDA.Fill(dtData)

            If dtData.Rows.Count > 0 Then
                Me.dgTableData.DataSource = dtData
                Me.dgTableData.Columns(0).Visible = False 'скрываем первую колонку с ид
                ' Me.dgTableData.Columns("Стоимость").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                ' Me.ToolStripStatusLabel1.Visible = True
            Else
                Me.dgTableData.DataSource = Nothing
            End If
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub tsbtnSelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSelAll.Click
        If s = False Then
            Me.dgTableData.SelectAll()
            s = True
        Else
            Me.dgTableData.ClearSelection()
            s = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub tsbtnExportToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExportToExcel.Click

        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        Dim tmpDataSet As DataTable = CType(Me.dgTableData.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add

        Try
            With oBook.ActiveSheet
                .Range("A2:H2").Font.Size = 12
                .Range("A2:H2").Font.Bold = True
                .Range("B2").Value = "Не закрытые "

                For iCol = 0 To Me.dgTableData.Columns.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & 3).Value = Me.dgTableData.Columns(iCol).HeaderText.ToString

                    For iRow = 0 To tmpDataSet.Rows.Count - 1
                        ch = Chr(65 + iCol)
                        .Range(ch & iRow + 4).Value = IIf(IsDBNull(Me.dgTableData(iCol, iRow).Value), "", Me.dgTableData(iCol, iRow).Value)
                    Next iRow
                    .columns(iCol + 1).EntireColumn.AutoFit()
                Next iCol
            End With
        Catch ex As System.Exception

        End Try
      
    End Sub

    Private Sub ПерейтиКЗаказуToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem.Click

        Try

            costID = Me.dgTableData("costID", Me.dgTableData.CurrentRow.Index).Value()

            ModCallForm.CallForm("", 11, 3)
        Catch excp As System.Exception
            If costID = 0 Then
                MessageBox.Show("Заказ не выбран.", appName)
            Else
                MessageBox.Show(excp.Message + " Переход к заказу невозможен.  " & CStr(costID), appName)
            End If

            Exit Sub
        End Try
    End Sub

    Private Sub tsbtnOrderClose_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOrderClose.Click
        If Me.dtpOrderClosing.Value.Date > Now.Date Then
            MsgBox("Нельзя установить дату закрытия заказа больше текущей", MsgBoxStyle.Critical, appName)
            ' sender.value = Now().Date
            Exit Sub
        Else
            Dim dateClosed As Date
            Dim n As Integer = 0

            dateClosed = Me.dtpOrderClosing.Value.Date

            For Each row As Object In Me.dgTableData.Rows
                If row.selected Then
                    'If Module1.NonQuery1Scalar("SELECT coalesce(SUM(summa), 0) FROM  Payments WHERE costID = " & Me.dgTableData("costID", n).Value & " ") - _
                    '    Module1.NonQuery1Scalar("SELECT coalesce(SUM(cost), 0) FROM  Orders WHERE costID = " & Me.dgTableData("costID", n).Value & " ") >= 0 _
                    '    And _
                    '    Module1.NonQuery1Scalar("SELECT statusID FROM  Costs WHERE costID = " & Me.dgTableData("costID", n).Value & " ") = 4 Then
                    '    'если оба услови выполнены

                    Module1.NonQuery1("UPDATE Costs SET orderClosed = 1, dateClosing = '" & dateClosed & "' WHERE costID = " & Me.dgTableData("costID", n).Value & " ")
                    'Else
                    '    MsgBox("Закрыть заказ нельзя так как по нему есть долг или он не выдан.", MessageBoxIcon.Error, appName) : Exit Sub
                    'End If
                    's = s + 1
                    'd += Me.dgTableData("Стоимость", n).Value
                    'If s > 1 Then costIDstr += ","
                    'costIDstr += Me.dgTableData("costID", n).Value.ToString
                End If
                n += 1
            Next

            UpdateOrders()
            'Me.ToolStripStatusLabel1.Text = "Выбрано заказов: " & CStr(s)
            '  Me.ToolStripStatusLabel2.Text = "на сумму " + CStr(Format(d, "C"))
        End If
    End Sub

    Private Sub frmOrderClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class