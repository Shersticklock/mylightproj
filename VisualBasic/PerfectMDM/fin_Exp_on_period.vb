Imports System.IO
Imports System.ComponentModel


Public Class fin_Exp_on_period
    Dim s As Boolean = False

    Private Sub tsbtnOrderClose_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOrderClose.Click
        Dim n As Integer = 0
        Dim d@ = 0

        For Each row As Object In Me.dgTableData.Rows
            If row.selected Then
                ' s = s + 1
                d += Me.dgTableData("Сумма", n).Value
            End If
            n += 1
        Next

        Me.nudSum.Value = d
        Me.tlpRaznos.Visible = True
    End Sub

    Private Sub tsbtnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnUpdate.Click
        ManyOut()
    End Sub

    Private Sub ManyOut()
        Dim dtData As New DataTable

        Try
            Dim objDA As SqlClient.SqlDataAdapter
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_FinExp1"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@numYear", SqlDbType.Int))
            cmd.Parameters("@numYear").Value = CInt(Me.tstxtYear.Text)

            objDA = New SqlClient.SqlDataAdapter(cmd)

            Dim dtItog As New DataTable

            objDA.Fill(dtData)
            If dtData.Rows.Count > 0 Then
                Me.dgTableData.DataSource = dtData

                '
                ColHideDG(Me.dgTableData)


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

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.tlpRaznos.Visible = False
    End Sub

    Private Sub fin_Exp_on_period_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim odaServices As SqlClient.SqlDataAdapter        'Заполняем список направлений
        Dim dtServices As New DataTable

        Try
            odaServices = New SqlClient.SqlDataAdapter("SELECT ID, name FROM fin_ArticlesExpenses order by name", mcnnInt)
            odaServices.Fill(dtServices)

            Me.cmbArticlesExpenses.DataSource = dtServices    'Связать данные со списком
            Me.cmbArticlesExpenses.DisplayMember = "name"
            Me.cmbArticlesExpenses.ValueMember = "ID"
        Catch ex As System.Exception
        End Try

        Me.tstxtYear.Text = Now.Year

    End Sub

    Private Sub tsbtnOK_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOK.Click
        If Me.nudSum.Value = 0 Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub

        Dim n As Integer = 0
        Dim summa As Decimal

        For Each row As Object In Me.dgTableData.Rows
            If row.selected Then
                Module1.NonQuery1("UPDATE fin_ManyOut SET raznos=1,dateRaznos='" & Now.Date & "' WHERE ID=" & Me.dgTableData("ID", n).Value & " ")
                summa += Me.dgTableData("Сумма", row.index).Value
            End If
            n += 1
        Next

        Me.nudSum.Value = summa

        Dim strSQL1$ = "INSERT INTO fin_Expenses (amount,dateExpens,SettlementPeriod,ID_ArtExpenses,description) "
        strSQL1 &= "VALUES (" & Replace(Me.nudSum.Value, ",", ".") & ",'" & Me.dtpYM.Value.Date & "'," & Me.nudSettlementPeriod.Value & "," & Me.cmbArticlesExpenses.SelectedItem(0) & ",'" & Trim(Me.txtPurpose.Text) & "') "

        Module1.NonQuery1(strSQL1)
        ManyOut()

        MsgBox("Затраты разнесены.", MessageBoxIcon.Information, appName)
        Me.tlpRaznos.Visible = False
        Me.nudSum.Value = 0
    End Sub

    Dim destinationPath As String
    Dim flagOpenFile As Boolean 'определяет режим работы ворк
    Dim sourcePath As String

    Private Sub ОткрытьФайлToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОткрытьФайлToolStripMenuItem.Click
        Dim sourcePath$ = Me.dgTableData("link", Me.dgTableData.CurrentRow.Index).Value().ToString

        If File.Exists(sourcePath) Then
            FileOpen(sourcePath)
        Else
            MsgBox("Файл- " & sourcePath & "  не существует", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub FileOpen(ByVal sourcePath As String)
        Try
            If File.Exists(sourcePath) Then
                destinationPath = paramLocalTempPath + Path.GetFileName(sourcePath) 'Path.GetFileName(dsFiles.Tables("Files").Rows(curIndex)("link").ToString)

                Try
                    Me.Enabled = False
                    Me.BackgroundWorker1.RunWorkerAsync(New Object() {sourcePath, destinationPath})
                    Me.Enabled = True
                Catch ex As System.Exception
                    MsgBox("Ошибка при открытии файла. " & ex.Message, MsgBoxStyle.Critical, appName)
                    Exit Sub
                End Try
            Else
                MsgBox("Файл " & sourcePath & "не найден.", MsgBoxStyle.Critical, appName)
                Exit Sub
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try
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
            Throw New FileNotFoundException(sourcePath)
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
                        Dim readedBytesCount As Integer = sourceStream.Read(bytes, 0, chunkBytesCount)
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

    Private Sub backgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' Завершение работы backgroundWorker
        ' Проверяем на ошибки и показываем сообщение о них, елси они возникли
        If e.[Error] Is Nothing Then
            Me.Enabled = True
            flagOpenFile = False
            Process.Start(destinationPath) 'здесь открываем
        Else
            MessageBox.Show(e.[Error].Message, appName)
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork_1(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As BackgroundWorker = DirectCast(sender, BackgroundWorker) ' Функция, которую выполняет backgroundWorker
        Copy(sourcePath, destinationPath, worker, 1024)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub tsbtnSelAll_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSelAll.Click
        If s = False Then
            Me.dgTableData.SelectAll()
            s = True
        Else
            Me.dgTableData.ClearSelection()
            s = False
        End If
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "signFopl" Or col.name = "link" Or col.name = "invID" Or col.name = "payID" Or col.name = "ID" Or col.name = "costID" Or col.name = "foplID" Then
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Private Sub dgTableData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTableData.CellContentClick

    End Sub
End Class