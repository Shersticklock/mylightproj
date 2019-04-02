Public Class fin_Analitics

    Private Sub fin_Analitics_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.tstxtYear.Text = Now.Year.ToString

        Try
            Dim odaAExp As New SqlClient.SqlDataAdapter("SELECT ID, name FROM fin_ArticlesExpenses ", mcnnInt)
            Dim dtAExp As New DataTable : odaAExp.Fill(dtAExp)
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try

        'For Each row As DataRow In dtAExp.Rows
        '    Try
        '        '    Me.dgDataTable.Rows.Add(row(1))


        '        '     MsgBox(col.ColumnName, MsgBoxStyle.Information, appName)
        '        '   dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Compute("SUM(" & col.ColumnName & ")", "")
        '    Catch ex As System.Exception
        '        ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        '    End Try
        'Next
    End Sub

    Private Sub ЭкспортВExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортВExcelToolStripMenuItem.Click

        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        ' Dim tmpDataSet As DataTable = CType(dgDataTable.DataSource, DataTable)
        '   Dim hiderText As String = Me.lstReports.SelectedItem(1)
        ' Dim nnn As Integer = 0

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True

            ' .Range("B2").Value = "Отчет " & hiderText

            For iCol = 0 To Me.dgDataTable.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgDataTable.Columns(iCol).HeaderText.ToString

                For iRow = 0 To Me.dgDataTable.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    '  .Range(ch & iRow + 4).NumberFormat = "@"
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(Me.dgDataTable(iCol, iRow).Value), "", Me.dgDataTable(iCol, iRow).Value.ToString)
                Next iRow

                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol

            'For iCol = 0 To dgItog.Columns.Count - 1
            '    ch = Chr(65 + iCol)
            '    .Range(ch & 3).Value = Me.dgItog.Columns(iCol).HeaderText.ToString

            '    For iRow = 0 To tmpDataSet.Rows.Count - 1
            '        ch = Chr(65 + iCol)
            '        .Range(ch & iRow + 4).Value = IIf(IsDBNull(dgItog(iCol, iRow).Value), "", dgItog(iCol, iRow).Value)
            '    Next iRow
            '    .columns(iCol + 1).EntireColumn.AutoFit()
            'Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")

    End Sub


    Private Sub PLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLToolStripMenuItem.Click
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_FinPL1" 'P&L
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numYear", SqlDbType.Int))
        cmd.Parameters("@numYear").Value = CInt(Me.tstxtYear.Text)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtItog As New DataTable : objDA.Fill(dtItog)

        dtItog.Rows.Add()
        dtItog.Rows(dtItog.Rows.Count - 1)(0) = "Маржа"

        For Each col As DataColumn In dtItog.Columns
            If col.ColumnName <> "Статья" Then
                dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Rows(0)(col.ColumnName) - dtItog.Rows(1)(col.ColumnName) - dtItog.Rows(2)(col.ColumnName)
            End If
        Next

        Dim rowIndex As Integer = 0
        Dim colIndex As Integer = 0
        Dim cmd2 As New SqlClient.SqlCommand

        cmd2.Connection = mcnnInt
        cmd2.CommandText = "sp_FinPL2"
        cmd2.CommandType = CommandType.StoredProcedure

        cmd2.Parameters.Add(New SqlClient.SqlParameter("@numYear", SqlDbType.Int))
        cmd2.Parameters("@numYear").Value = CInt(Me.tstxtYear.Text)

        Dim objDA2 As New SqlClient.SqlDataAdapter(cmd2)
        Dim dtItog2 As New DataTable : objDA2.Fill(dtItog2)

        dtItog.Rows.Add()
        dtItog.Rows(dtItog.Rows.Count - 1)(0) = "Всего накладных расходов (подробно)"

        For Each row As DataRow In dtItog2.Rows
            colIndex = 0
            dtItog.Rows.Add() 'для записи подробных затрат

            For Each col As DataColumn In dtItog2.Columns
                Try
                    If colIndex <> 0 And rowIndex = 0 Then 'только на первой строке вычисляем и не первом столбце
                        dtItog.Rows(dtItog.Rows.Count - 2)(col.ColumnName) = dtItog2.Compute("SUM(" & col.ColumnName & ")", "")
                    End If
                    'пишем все расходы подробно
                    dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = row(colIndex)
                Catch ex As System.Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                End Try

                colIndex += 1
            Next

            rowIndex += 1
        Next

        dtItog.Rows.Add()
        dtItog.Rows(dtItog.Rows.Count - 1)("Статья") = "Операционная прибыль"

        For Each col As DataColumn In dtItog.Columns
            If col.ColumnName <> "Статья" Then
                dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Rows(3)(col.ColumnName) - dtItog.Rows(4)(col.ColumnName)
            End If
        Next

        Me.dgDataTable.DataSource = dtItog
        Me.dgDataTable.Rows(3).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
        Me.dgDataTable.Rows(4).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
        Me.dgDataTable.Rows(Me.dgDataTable.Rows.Count - 1).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)


        Me.dgDataTable.ClearSelection()
        Me.dgDataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgDataTable.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
    End Sub

    Private Sub CFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFToolStripMenuItem.Click
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_FinPL3"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numYear", SqlDbType.Int))
        cmd.Parameters("@numYear").Value = CInt(Me.tstxtYear.Text)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtItog As New DataTable : objDA.Fill(dtItog)

        dtItog.Rows.Add()
        dtItog.Rows(dtItog.Rows.Count - 1)(0) = "Всего поступлений"

        For Each col As DataColumn In dtItog.Columns
            Try
                dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Compute("SUM(" & col.ColumnName & ")", "")
            Catch ex As System.Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        Next
        'подитог

        Dim rowIndex As Integer = 0
        Dim colIndex As Integer = 0
        Dim cmd2 As New SqlClient.SqlCommand

        cmd2.Connection = mcnnInt
        cmd2.CommandText = "sp_FinPL5"
        cmd2.CommandType = CommandType.StoredProcedure

        cmd2.Parameters.Add(New SqlClient.SqlParameter("@numYear", SqlDbType.Int))
        cmd2.Parameters("@numYear").Value = CInt(Me.tstxtYear.Text)

        Dim objDA2 As New SqlClient.SqlDataAdapter(cmd2)
        Dim dtItog2 As New DataTable : objDA2.Fill(dtItog2)

        '   dtItog2.Rows.Add()
        dtItog.Rows.Add()
        dtItog.Rows(dtItog.Rows.Count - 1)(0) = "Всего расход (Платежи подробно)"


        For Each row As DataRow In dtItog2.Rows
            colIndex = 0
            dtItog.Rows.Add()
            For Each col As DataColumn In dtItog2.Columns
                Try
                    'If colIndex <> 0 And rowIndex = 0 Then
                    '    dtItog2.Rows(dtItog2.Rows.Count - 1)(col.ColumnName) = dtItog2.Compute("SUM(" & col.ColumnName & ")", "")
                    'End If
                    If colIndex <> 0 And rowIndex = 0 Then 'только на первой строке вычисляем и не первом столбце
                        dtItog.Rows(dtItog.Rows.Count - 2)(col.ColumnName) = dtItog2.Compute("SUM(" & col.ColumnName & ")", "")
                    End If

                    dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = row(colIndex)
                Catch ex As System.Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                End Try
                colIndex += 1
            Next
            rowIndex += 1
        Next

        '   dtItog.Rows(dtItog.Rows.Count - 1)("Форма") = "Всего платежей"

        dtItog.Rows.Add()
        dtItog.Rows(dtItog.Rows.Count - 1)("Форма") = "Сальдо"

        'For Each col As DataColumn In dtItog.Columns
        '    If col.ColumnName <> "Форма" Then
        '        dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Rows(2)(col.ColumnName) - dtItog.Rows(dtItog.Rows.Count - 2)(col.ColumnName)
        '    End If
        'Next

        For Each col As DataColumn In dtItog.Columns
            If col.ColumnName <> "Форма" Then
                dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Rows(2)(col.ColumnName) - dtItog.Rows(3)(col.ColumnName)
            End If
        Next

        Me.dgDataTable.DataSource = dtItog
        Me.dgDataTable.Rows(2).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
        Me.dgDataTable.Rows(3).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)

        Me.dgDataTable.Rows(Me.dgDataTable.Rows.Count - 1).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 10, FontStyle.Bold)
        Me.dgDataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgDataTable.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
    End Sub

    Private Sub РеализацияПоМенеджерамToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РеализацияПоМенеджерамToolStripMenuItem.Click
        Me.dgDataTable.Columns.Clear()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_FinMen"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numYear", SqlDbType.Int))
        cmd.Parameters("@numYear").Value = CInt(Me.tstxtYear.Text)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtItog As New DataTable : objDA.Fill(dtItog)

        dtItog.Columns.Add("Итого", GetType(Decimal))
        dtItog.Rows.Add("Итого")

        For Each row As DataRow In dtItog.Rows

            Dim s As Decimal = 0

            For n As Integer = 1 To 12
                Try
                    s += row(n)
                    row("Итого") = s
                Catch ex As System.Exception
                    ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                End Try
            Next
        Next

        For Each col As DataColumn In dtItog.Columns
            Try
                dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Compute("SUM(" & col.ColumnName & ")", "")
            Catch ex As System.Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        Next

        Me.dgDataTable.DataSource = dtItog

        Me.dgDataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgDataTable.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
    End Sub

    Private Sub РеализацияПоИсточникамЗаказаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РеализацияПоИсточникамЗаказаToolStripMenuItem.Click
        Me.dgDataTable.Columns.Clear()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_FinReclama"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numYear", SqlDbType.Int))
        cmd.Parameters("@numYear").Value = CInt(Me.tstxtYear.Text)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtItog As New DataTable : objDA.Fill(dtItog)

        dtItog.Columns.Add("Итого", GetType(Decimal))
        dtItog.Rows.Add("Итого")

        For Each row As DataRow In dtItog.Rows

            Dim s As Decimal = 0

            For n As Integer = 1 To 12
                Try
                    s += row(n)
                    row("Итого") = s
                Catch ex As System.Exception
                    ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                End Try
            Next
        Next

        For Each col As DataColumn In dtItog.Columns
            Try
                dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Compute("SUM(" & col.ColumnName & ")", "")
            Catch ex As System.Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        Next

        Me.dgDataTable.DataSource = dtItog

        Me.dgDataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgDataTable.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
    End Sub

    Private Sub РеализацияПоОфисамToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РеализацияПоОфисамToolStripMenuItem.Click
        Me.dgDataTable.Columns.Clear()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_FinOffice"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numYear", SqlDbType.Int))
        cmd.Parameters("@numYear").Value = CInt(Me.tstxtYear.Text)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtItog As New DataTable : objDA.Fill(dtItog)

        dtItog.Columns.Add("Итого", GetType(Decimal))
        dtItog.Rows.Add("Итого")

        For Each row As DataRow In dtItog.Rows

            Dim s As Decimal = 0

            For n As Integer = 1 To 12
                Try
                    s += row(n)
                    row("Итого") = s
                Catch ex As System.Exception
                    ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                End Try
            Next
        Next

        For Each col As DataColumn In dtItog.Columns
            Try
                dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Compute("SUM(" & col.ColumnName & ")", "")
            Catch ex As System.Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        Next

        Me.dgDataTable.DataSource = dtItog

        Me.dgDataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgDataTable.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
    End Sub

    Private Sub ЗапасыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗапасыToolStripMenuItem.Click
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_FinSklad"
        cmd.CommandType = CommandType.StoredProcedure

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtItog As New DataTable : objDA.Fill(dtItog)

        dtItog.Rows.Add("Итого")

        For Each col As DataColumn In dtItog.Columns
            Try
                dtItog.Rows(dtItog.Rows.Count - 1)(col.ColumnName) = dtItog.Compute("SUM(" & col.ColumnName & ")", "")
            Catch ex As System.Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        Next

        Me.dgDataTable.DataSource = dtItog

        Me.dgDataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Me.dgDataTable.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
    End Sub
End Class