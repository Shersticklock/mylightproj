Imports System.IO
Imports System.ComponentModel

Public Class fin_Invoices

    Dim allowLoadDetalis As Boolean

    Private Sub frmInvoices_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Загружаем список 
        Dim odaExp As New SqlClient.SqlDataAdapter("SELECT ID, name FROM fin_ArticlesExpenses order by name", mcnnInt)
        Dim dtExp As New DataTable : odaExp.Fill(dtExp)

        Me.cmbExp.DataSource = dtExp
        Me.cmbExp.DisplayMember = "name"
        Me.cmbExp.ValueMember = "ID"
        Me.cmbExp.SelectedIndex = -1
        Me.cmbSelectQ.SelectedIndex = 0
        Me.cmbFopl.SelectedIndex = 1
        Me.cmbVisa.SelectedIndex = 0
        Me.cmbPP.SelectedIndex = 1
    End Sub

    Private Sub cmbSelectQ_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSelectQ.SelectedIndexChanged
        allowLoadDetalis = True

        Select Case Me.cmbSelectQ.SelectedIndex
            Case Is = 0 'Не оплачен
                Me.chkPlat.Visible = True
                Me.chkItIsPaid.Visible = True
                Me.dtpDate1.Visible = False
                Me.dtpDate2.Visible = False
                Me.cmbPP.Visible = True

                Me.cmbVisa.Visible = True
                Me.cmbFopl.Visible = True

            Case Is = 1 'Оплаченные в текущем месяце
                Me.chkPlat.Visible = False
                Me.chkItIsPaid.Visible = False
                Me.dtpDate1.Visible = False
                Me.dtpDate2.Visible = False
                Me.cmbPP.Visible = False

                Me.cmbVisa.Visible = True
                Me.cmbFopl.Visible = True

            Case Is = 2 'по интервалу дат
                Me.chkItIsPaid.Visible = False
                Me.dtpDate1.Visible = True
                Me.dtpDate2.Visible = True
                Me.cmbPP.Visible = False

                Me.cmbVisa.Visible = True
                Me.cmbFopl.Visible = True

            Case Is = 3 'мои по интервалу дат
                Me.chkItIsPaid.Visible = False
                Me.dtpDate1.Visible = True
                Me.dtpDate2.Visible = True
                Me.cmbPP.Visible = False
                Me.cmbVisa.Visible = False
                Me.cmbFopl.Visible = False
        End Select
    End Sub

    Private Sub chkItIsPaid_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkItIsPaid.CheckedChanged
        Me.nudSumma.Visible = sender.checked
        Me.dtpPaymentDate.Visible = sender.checked
        Me.txtDescription.Visible = sender.checked
        Me.tsbtnApply.Enabled = sender.checked Or Me.chkPlat.Checked

        If sender.checked = True Then
            Me.nudSumma.Focus()
        End If

        Me.Label1.Visible = sender.checked
        Me.cmbExp.Visible = sender.checked
        Me.nudSettlementPeriod.Visible = sender.checked
    End Sub

    Dim dtExpenses As New DataTable

    Private Sub LoadInvoices()
        Try
            Me.dgInvoices.Columns.Remove("btn")
        Catch ex As System.Exception
        End Try

        allowLoadDetalis = False

        Dim strSP As String = Nothing
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandType = CommandType.StoredProcedure

        Try
            Select Case Me.cmbSelectQ.SelectedIndex
                Case Is = 0 'Не оплачен
                    If Me.cmbOrg.Visible = True Then
                        If Me.cmbOrg.SelectedIndex = -1 Then
                            '   MsgBox("На.", MsgBoxStyle.Critical, appName) : Me.cmbOrg.Focus() : Exit Sub

                            If Me.cmbPP.Visible = True Then
                                If Me.cmbPP.SelectedIndex = 0 Then 'c пп
                                    strSP = "sp_Invoice00"
                                    Me.chkPlat.Visible = False
                                Else
                                    strSP = "sp_Invoice1"
                                End If
                            Else ' наличка
                                strSP = "sp_Invoice1"
                                Me.chkPlat.Visible = False
                            End If
                        Else
                            If Me.cmbPP.Visible = True Then
                                If Me.cmbPP.SelectedIndex = 0 Then 'c пп
                                    strSP = "sp_Invoice0"
                                    Me.chkPlat.Visible = False
                                Else
                                    strSP = "sp_Invoice11"
                                End If
                            Else ' наличка
                                strSP = "sp_Invoice11"
                                Me.chkPlat.Visible = False
                            End If
                            ' MsgBox("Не выбрано юридическое лицо контрагента.", MsgBoxStyle.Critical, appName) : Me.cmbOrg.Focus() : Exit Sub
                        End If
                    Else
                        If Me.cmbPP.Visible = True Then
                            If Me.cmbPP.SelectedIndex = 0 Then 'c пп
                                strSP = "sp_Invoice0"
                                Me.chkPlat.Visible = False
                            Else
                                strSP = "sp_Invoice1"
                            End If
                        Else ' наличка
                            strSP = "sp_Invoice1"
                            Me.chkPlat.Visible = False
                        End If
                    End If
                   
                Case Is = 1 'Оплаченные в текущем месяце
                    If Me.cmbOrg.Visible = True Then
                        If Me.cmbOrg.SelectedIndex = -1 Then
                            strSP = "sp_Invoice2"
                        Else
                            strSP = "sp_Invoice22"
                        End If
                    Else
                        strSP = "sp_Invoice2"
                    End If

                    Me.chkPlat.Visible = False

                Case Is = 2 'Оплачен в произвольный период
                    If Me.cmbOrg.Visible = True Then
                        If Me.cmbOrg.SelectedIndex = -1 Then
                            strSP = "sp_Invoice3"
                        Else
                            strSP = "sp_Invoice33"
                        End If
                    Else
                        strSP = "sp_Invoice3"
                    End If

                    Me.chkPlat.Visible = False

                Case Is = 3 'все мои
                    If Me.cmbOrg.Visible = True Then
                        If Me.cmbOrg.SelectedIndex = -1 Then
                            strSP = "sp_Invoice5"
                        Else
                            strSP = "sp_Invoice55"
                        End If
                    Else
                        strSP = "sp_Invoice5"
                    End If

                    Me.chkPlat.Visible = False
                    Me.cmbFopl.Visible = False
                    Me.cmbPP.Visible = False

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
                    cmd.Parameters("@emplID").Value = emplID
            End Select

            If Me.cmbFopl.Visible = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@signFopl", SqlDbType.Int))
                cmd.Parameters("@signFopl").Value = Me.cmbFopl.SelectedIndex + 1
            End If

            If Me.cmbVisa.Visible = True Then
                Select Case Me.cmbVisa.SelectedIndex
                    Case Is = 0
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@visa", SqlDbType.Bit))
                        cmd.Parameters("@visa").Value = 0
                    Case Is = 1
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@visa", SqlDbType.Bit))
                        cmd.Parameters("@visa").Value = 1
                End Select
            End If

            If Me.dtpDate1.Visible = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@date1", SqlDbType.Date))
                cmd.Parameters("@date1").Value = Me.dtpDate1.Value.Date
                cmd.Parameters.Add(New SqlClient.SqlParameter("@date2", SqlDbType.Date))
                cmd.Parameters("@date2").Value = Me.dtpDate2.Value.Date
            End If

            If Me.cmbOrg.Visible = True Then
                If Me.cmbOrg.SelectedIndex <> -1 Then
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
                    cmd.Parameters("@orgID").Value = Me.cmbOrg.SelectedItem(0)
                End If
            End If

            cmd.Connection = mcnnInt
            cmd.CommandText = strSP

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtExpenses As New DataTable : objDA.Fill(dtExpenses)

            If dtExpenses.Rows.Count > 0 Then
                Me.tsslItogo.Text = "Сумма по всем счетам " & CStr(Format(dtExpenses.Compute("SUM(Сумма)", ""), "C"))
                Me.tsslOpl.Text = "Оплачено " & CStr(Format(dtExpenses.Compute("SUM(Оплачено)", ""), "C"))
                Me.tsslDolg.Text = "Кредиторская задолженность " & CStr(Format(dtExpenses.Compute("SUM(Сумма)", "") - dtExpenses.Compute("SUM(Оплачено)", ""), "C"))

                Me.dgInvoices.DataSource = dtExpenses

                ColHideDG(Me.dgInvoices)

                If Me.cmbVisa.SelectedIndex = 0 And Me.cmbSelectQ.SelectedIndex = 0 Then
                    Dim btn As New DataGridViewButtonColumn()

                    Me.dgInvoices.Columns.Add(btn)
                    btn.HeaderText = "Визирование"
                    btn.Text = "Виза"
                    btn.Name = "btn"
                    btn.UseColumnTextForButtonValue = True
                End If
            Else
                Me.dgInvoices.DataSource = Nothing
            End If
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Sub
        Finally
            mcnnInt.Close()
        End Try
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "ID" Or col.name = "costID" Or col.name = "KAgentID" Or col.name = "prim2" Or col.name = "signFopl" Or col.name = "Org_ID" Or col.name = "link" Or col.name = "payer" Or col.name = "visa" Then
                col.visible = False
            End If
        Next

        NameGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        NameGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
        NameGrid.ClearSelection()
    End Sub

    Private Sub OpenFile()
        sourcePath = Me.dgInvoices("link", Me.dgInvoices.CurrentRow.Index).Value().ToString 'dtExpenses.Rows(Me.dgInvoices.SelectedRows.Item(0).Index)("link").ToString

        If File.Exists(sourcePath) Then
            FileOpen(sourcePath)
        Else
            MsgBox("Файл- " & sourcePath & "  не существует", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub ОткрытьФайлToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОткрытьФайлToolStripMenuItem.Click
        OpenFile()
    End Sub

    Private Sub dgInvoices_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvoices.CellClick
        If Me.cmbVisa.SelectedIndex = 0 And Me.cmbSelectQ.SelectedIndex = 0 Then

            If e.ColumnIndex = Me.dgInvoices.Columns("btn").Index Then
                '  If MessageBox.Show("Визировать?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                mForm = New System.Windows.Forms.Form
                eTxt = New System.Windows.Forms.TextBox
                ' Friend mForm As New System.Windows.Forms.Form

                mForm.Text = "Визирование счета"
                Dim elLabel As New Label
                Dim eBtn As New Button

                ' и т.д. создаем элементы и добавляем их на форму
                eBtn.Text = "Ok"
                eBtn.Visible = True
                eBtn.Dock = DockStyle.Top
                AddHandler eBtn.Click, AddressOf eBtn_Click ' Обработка события Click
                mForm.Controls.Add(eBtn)

                eTxt.AutoSize = True
                eTxt.PasswordChar = "*"
                'eTxt.Text = ""
                eTxt.Dock = DockStyle.Top
                eTxt.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
                AddHandler eTxt.KeyDown, AddressOf eTxt_KeyDown ' Обработка события 

                mForm.Controls.Add(eTxt)

                elLabel.AutoSize = True
                elLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
                elLabel.Text = "Пароль"
                mForm.Controls.Add(elLabel)
                elLabel.Dock = DockStyle.Top

                mForm.MaximizeBox = False
                mForm.AutoSize = True
                mForm.Show()
                eTxt.Focus()
                'End If
            End If
        End If
    End Sub

    Private Sub eTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            VisaCost()
        End If
        '  e.Handled = True
    End Sub

    Private Sub dgInvoices_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvoices.CellDoubleClick
        OpenFile()
    End Sub

    Private Sub dgInvoices_CurrentCellChanged(sender As Object, e As System.EventArgs) Handles dgInvoices.CurrentCellChanged

        'If dtExpenses.Rows.Count > 0 Then
        '    If Me.dgInvoices("signFopl", Me.dgInvoices.SelectedRows.Item(0).Index).Value() = 1 Then
        '        Me.chkPlat.Visible = False
        '    Else
        '        Me.chkPlat.Visible = True
        '    End If
        'End If
     
        'If allowLoadDetalis = True Then
        '    If IsDBNull(Me.dgInvoices("ID", Me.dgInvoices.CurrentRow.Index).Value()) = False Then
        '        LoadDetails(Me.dgInvoices("ID", Me.dgInvoices.CurrentRow.Index).Value())
        '    Else
        '        '     Me.dgDetails.Visible = False
        '        '   Me.btnHide.Visible = False
        '    End If
        'End If
    End Sub

    Private Sub LoadDetails(ID As Integer)
        'Dim str1SQL$ = Nothing
        'Dim dtAwards As New DataTable
        'Dim odaAwards As SqlClient.SqlDataAdapter

        'Try 'создаем таблицу
        '    odaAwards = New SqlClient.SqlDataAdapter(str1SQL, mcnnInt)
        '    odaAwards.Fill(dtAwards)
        '    If dtAwards.Rows.Count > 0 Then
        '        dtAwards.Rows.Add()
        '        dtAwards.Rows(dtAwards.Rows.Count - 1)("Сумма") = dtAwards.Compute("SUM(Сумма)", "")
        '    End If
        '    '  Me.dgDetails.DataSource = dtAwards
        '    ' Me.dgDetails.ClearSelection()
        'Catch excp As System.Exception
        '    MessageBox.Show(excp.Message)
        'End Try
    End Sub

    ' Путь источника и назначения
    Dim destinationPath As String
    Dim sourcePath As String
    Dim flagOpenFile As Boolean 'определяет режим работы ворк

    Private Sub FileOpen(ByVal sourcePath As String)
        Try
            If File.Exists(sourcePath) Then
                'flagOpenFile = True
                destinationPath = paramLocalTempPath + Path.GetFileName(sourcePath) 'Path.GetFileName(dsFiles.Tables("Files").Rows(curIndex)("link").ToString)
                '   destinationPath = paramLocalTempPath + Path.GetFileName(sourcePath)
                ' destinationPath = Path.GetFileName(sourcePath)
                '     MsgBox("Открываем из файлового хранилища " & destinationPath)
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

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As BackgroundWorker = DirectCast(sender, BackgroundWorker) ' Функция, которую выполняет backgroundWorker
        Copy(sourcePath, destinationPath, worker, 1024)
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

    Private Sub ПрикрепитьФайлToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПрикрепитьФайлToolStripMenuItem.Click
        Dim curIndex As Integer
        Dim sFilePath1 As String = ""
        Dim nameFile As String = Nothing


        If Me.dgInvoices.SelectedRows.Count = 0 Then
            MsgBox("Выбери счет.", MsgBoxStyle.Information, appName) : Exit Sub
        Else
            curIndex = Me.dgInvoices.CurrentRow.Index
        End If

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            sFilePath1 = OpenFileDialog1.FileName
            nameFile = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If

        destinationPath = paramFileStoragePath + "a-" + Me.dgInvoices("ID", curIndex).Value().ToString + "-" + nameFile 'System.IO.Path.GetFileName(OpenFileDialog1.FileName)

        MsgBox(destinationPath)

        If Not String.IsNullOrEmpty(sFilePath1) Then
            System.IO.File.Copy(sFilePath1, destinationPath, True) 'копируем файл. Если есть, переписываем - True
        End If

        Dim fileName As String = OpenFileDialog1.FileName
        Dim strSQL$ = " UPDATE Invoices_KA SET linkToFile='" & destinationPath & " ', typeFile='" & System.IO.Path.GetExtension(OpenFileDialog1.FileName) & "'"
        strSQL &= " WHERE ID = " & Me.dgInvoices("ID", curIndex).Value() & " "

        Dim sqlCommand As New SqlClient.SqlCommand(strSQL, mcnnInt)

        mcnnInt.Open()
        sqlCommand.ExecuteNonQuery()
        mcnnInt.Close()

        LoadInvoices()
    End Sub

#Region " Экспорт в Excel "
    

    Private Sub ExportToExcel()
        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        Dim tmpDataSet As DataTable = CType(Me.dgInvoices.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add

        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            '  .Range("B2").Value = "Отчет " & ToolStripComboBox1.Text

            For iCol = 0 To Me.dgInvoices.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgInvoices.Columns(iCol).HeaderText.ToString

                For iRow = 0 To tmpDataSet.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(Me.dgInvoices(iCol, iRow).Value), "", Me.dgInvoices(iCol, iRow).Value)
                Next iRow
            Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")
    End Sub
#End Region

    Private Sub УдалитьСчетToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles УдалитьСчетToolStripMenuItem.Click
        If MsgBox(Prompt:="Удалить выбранную строку? ", Buttons:=vbYesNo, Title:=appName) = MsgBoxResult.Yes Then
            Module1.NonQuery1("DELETE FROM Invoices_KA  WHERE ID=" & Me.dgInvoices("ID", Me.dgInvoices.CurrentRow.Index).Value() & " ")

            LoadInvoices()
        End If
    End Sub

#Region " Переход к заказу "
    Private Sub ПерейтиКЗаказуToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem.Click
        costID = Me.dgInvoices("costID", Me.dgInvoices.CurrentRow.Index).Value()
        ' MsgBox(CStr(costID))

        If costID = 0 Then
            MessageBox.Show("Переход к заказу невозможен.  " & CStr(costID), appName)
        Else
            Dim frmSelect As frmOrder

            frmSelect = New frmOrder
            frmSelect.ShowDialog()
        End If


        Try

        Catch excp As System.Exception
        End Try
    End Sub
#End Region

    Friend eBtn As System.Windows.Forms.Button ' Дружественная кнопка, тоесть она будет доступна всей сборке, где она была объявлена
    Friend eTxt As System.Windows.Forms.TextBox
    Friend mForm As System.Windows.Forms.Form

    Private Sub VisaCost()
        If eTxt.Text = "197630" Then

            Me.chkItIsPaid.Checked = False

            If MessageBox.Show("Счет " & Me.dgInvoices("Номер счета", Me.dgInvoices.SelectedRows.Item(0).Index).Value() & " подлежит оплате?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Dim cmd As New SqlClient.SqlCommand

                    cmd.Connection = mcnnInt
                    cmd.CommandText = "sp_InvoiceVisa"
                    cmd.CommandType = CommandType.StoredProcedure
                    'Описываем параметры

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@ID", SqlDbType.Int))
                    cmd.Parameters("@ID").Value = Me.dgInvoices("ID", Me.dgInvoices.SelectedRows.Item(0).Index).Value

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@visa", SqlDbType.Bit))
                    cmd.Parameters("@visa").Value = 1

                    mcnnInt.Open()
                    cmd.ExecuteNonQuery()
                    mcnnInt.Close()

                Catch excp As System.Exception
                    mForm.Close()
                    MessageBox.Show(excp.Message, appName)
                    Exit Sub
                Finally
                    mcnnInt.Close()
                End Try
            End If

            LoadInvoices()
        Else
            MsgBox("Доступ запрещен  ", MessageBoxIcon.Error, appName) : Exit Sub
        End If

        mForm.Close()
    End Sub

    Private Sub eBtn_Click(sender As System.Object, e As System.EventArgs)
        VisaCost()
    End Sub

    Private Sub ОткатитьОплатуToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОткатитьОплатуToolStripMenuItem.Click
        If Me.dgInvoices.SelectedRows.Count = 0 Then
            MsgBox("Не выбран счет.", MsgBoxStyle.Information, appName)
        Else

            Dim summaOtkat@ = InputBox("Введи сумму отката оплаты по счету", appName, Me.dgInvoices("Оплачено", Me.dgInvoices.SelectedRows.Item(0).Index).Value())

            If summaOtkat > Me.dgInvoices("Оплачено", Me.dgInvoices.SelectedRows.Item(0).Index).Value() Then
                MsgBox("Сумма откаты оплаты не может быть больше оплаченной суммы", MsgBoxStyle.Critical, appName)
            Else
                Me.chkItIsPaid.Checked = False

                If MessageBox.Show("Откатить оплату счета " & Me.dgInvoices("Номер счета", Me.dgInvoices.SelectedRows.Item(0).Index).Value() & " на сумму " + CStr(summaOtkat) + " руб.?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        Dim cmd As New SqlClient.SqlCommand

                        cmd.Connection = mcnnInt
                        cmd.CommandText = "sp_InvoiceOtkatPay"
                        cmd.CommandType = CommandType.StoredProcedure
                        'Описываем параметры

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@ID", SqlDbType.Int))
                        cmd.Parameters("@ID").Value = Me.dgInvoices("ID", Me.dgInvoices.SelectedRows.Item(0).Index).Value

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@summa", SqlDbType.Decimal))
                        cmd.Parameters("@summa").Value = summaOtkat

                        mcnnInt.Open()
                        cmd.ExecuteNonQuery()
                    Catch excp As System.Exception
                        MessageBox.Show(excp.Message, appName)
                        Exit Sub
                    Finally
                        mcnnInt.Close()
                    End Try
                End If

                LoadInvoices()
            End If
        End If
    End Sub

    Private Sub eBtn_Click()
        Throw New NotImplementedException
    End Sub

    Private Sub chkPlat_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPlat.CheckedChanged
        Me.txtNomPP.Visible = sender.checked
        Me.dtpBankClient.Visible = sender.checked
        '  Me.Label4.Visible = sender.checked
        Me.txtDescription.Visible = sender.checked
        Me.tsbtnApply.Enabled = sender.checked Or Me.chkItIsPaid.Checked

        If sender.checked = True Then
            Me.txtNomPP.Focus()
        End If
    End Sub

    Private Sub btnFull_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub chkPlat_VisibleChanged(sender As Object, e As System.EventArgs) Handles chkPlat.VisibleChanged
        Me.txtNomPP.Visible = sender.visible
        Me.dtpBankClient.Visible = sender.visible
    End Sub

    Private Sub cmbFopl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFopl.SelectedIndexChanged
        If Me.cmbFopl.SelectedIndex = 0 Then
            Me.cmbPP.Visible = False
        Else
            Me.cmbPP.Visible = True
        End If
    End Sub

    Private Sub ПолностьюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПолностьюToolStripMenuItem.Click
        If Me.dgInvoices.SelectedRows.Count <> 1 Then
            MsgBox("Не выбран счет", MsgBoxStyle.Critical, appName)
        Else
            If Me.dgInvoices("Остаток", Me.dgInvoices.SelectedRows.Item(0).Index).Value() = 0 Then
                MsgBox("Счет полностью оплачен", MsgBoxStyle.Critical, appName)
            Else
                Me.nudSumma.Value = Me.dgInvoices("Остаток", Me.dgInvoices.SelectedRows.Item(0).Index).Value()
            End If
        End If
    End Sub

    Private Sub LoadCustomers(ByVal selectSerh As Integer, ByVal strFind As String)
        If strFind = """" Or strFind = "'" Then
            Exit Sub
        Else
            Try
                Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE Name LIKE '%" & strFind & "%' order by name", mcnnInt) 'не сортировать иначе не получим посл добавленного заказчика
                Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

                If dtPartList.Rows.Count = 0 Then
                    Exit Sub
                Else
                    Me.cmbCustomer.DataSource = dtPartList
                    Me.cmbCustomer.DisplayMember = "Name"
                    Me.cmbCustomer.ValueMember = "ID"
                End If
            Catch oexpData As System.Exception
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub txtCustForSearh_TextChanged(sender As Object, e As EventArgs) Handles txtCustForSearh.TextChanged
        LoadCustomers(2, Me.txtCustForSearh.Text)
    End Sub

    Private Sub cmbCustomer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedValueChanged
        Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE KAgent_ID= " & Me.cmbCustomer.SelectedItem(0) & " order by Name", mcnnInt)
        Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

        Me.cmbOrg.DataSource = dtPartList
        Me.cmbOrg.DisplayMember = "Name"
        Me.cmbOrg.ValueMember = "custID"
    End Sub

    Private Sub tsbtnNewCost_Click(sender As Object, e As EventArgs) Handles tsbtnNewCost.Click
        costID = Nothing

        ModCallForm.CallForm("Счет на оплату", 28, 3)
    End Sub

    Private Sub tsbtnUpdate_Click(sender As Object, e As EventArgs) Handles tsbtnUpdate.Click
        LoadInvoices()
    End Sub

    Private Sub ЭкспортВExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортВExcelToolStripMenuItem.Click
        ExportToExcel()
    End Sub

    Private Sub tsbtnKassa_Click(sender As Object, e As EventArgs) Handles tsbtnKassa.Click
        ModCallForm.CallForm("Касса", 3, 3)
    End Sub


    Private Sub tsbtnApply_Click(sender As Object, e As EventArgs) Handles tsbtnApply.Click
        If Me.dgInvoices.SelectedRows.Count <> 1 Then
            MsgBox("Не выбран счет.", MsgBoxStyle.Critical, appName) : Exit Sub
        Else
            If Me.chkPlat.Checked = True Then
                If Me.txtNomPP.Text = "" Then
                    MsgBox("Не указан номер платежного поручения.", MsgBoxStyle.Critical, appName)

                    Me.txtNomPP.Focus()
                    Exit Sub
                Else
                    Try
                        Dim cmd As New SqlClient.SqlCommand

                        cmd.Connection = mcnnInt
                        cmd.CommandText = "sp_InvoicePlat"
                        cmd.CommandType = CommandType.StoredProcedure
                        'Описываем параметры

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@ID", SqlDbType.Int))
                        cmd.Parameters("@ID").Value = Me.dgInvoices("ID", Me.dgInvoices.SelectedRows.Item(0).Index).Value

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@dateBankClient", SqlDbType.Date))
                        cmd.Parameters("@dateBankClient").Value = Me.dtpBankClient.Value.Date

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@paymentOrder", SqlDbType.NVarChar))
                        cmd.Parameters("@paymentOrder").Value = Me.txtNomPP.Text

                        mcnnInt.Open()
                        cmd.ExecuteNonQuery()
                        Me.chkPlat.Checked = False
                    Catch excp As System.Exception
                        Me.chkPlat.Checked = False
                        MessageBox.Show(excp.Message, appName)
                        Exit Sub
                    Finally
                        mcnnInt.Close()
                    End Try
                End If
            End If

            If Me.chkItIsPaid.Checked = True Then
                If Me.nudSumma.Value > Me.dgInvoices("Остаток", Me.dgInvoices.SelectedRows.Item(0).Index).Value() Then
                    MsgBox("Сумма платежа превышает сумму остаточного платежа или сумму счета ", MsgBoxStyle.Information, appName)
                    Me.nudSumma.Focus()
                    Exit Sub
                Else
                    If Me.dgInvoices("visa", Me.dgInvoices.SelectedRows.Item(0).Index).Value = 0 Then
                        MsgBox("Счет не имеет визы. Оплата невозможна", MsgBoxStyle.Information, appName)
                        Exit Sub
                    End If

                    Try
                        Dim selInd% = Me.dgInvoices.SelectedRows.Item(0).Index
                        Dim invID% = Me.dgInvoices("ID", selInd).Value()
                        Dim desc$ = Me.txtDescription.Text
                        Dim SettlementPeriod% = Me.nudSettlementPeriod.Value
                        Dim expID As Integer = 0

                        If Me.cmbExp.SelectedIndex <> -1 Then
                            expID = Me.cmbExp.SelectedValue
                        End If

                        If Me.dgInvoices("signFopl", Me.dgInvoices.SelectedRows.Item(0).Index).Value = 1 Then 'передать инфу что это счет его номер  manyOut и сумму
                            Module1.NonQuery1("INSERT INTO fin_ManyOut (amount,office_ID,description,fopl_ID,invoiceKA_ID,raznos,org_ID,datetrans) VALUES (" & Replace(Me.nudSumma.Value, ",", ".") & "," & ofID & ",'" & desc & "',1," & invID & ",1," & Me.dgInvoices("Org_ID", selInd).Value & ", '" & Me.dtpPaymentDate.Value.Date & "')")
                        Else 'безнал
                            Module1.NonQuery1("INSERT INTO fin_ManyOut (amount,org_ID,description,fopl_ID,invoiceKA_ID,raznos,payer,datetrans) VALUES (" & Replace(Me.nudSumma.Value, ",", ".") & "," & Me.dgInvoices("Org_ID", selInd).Value & ",'" & desc & "',2," & invID & "," & expID & "," & Me.dgInvoices("payer", selInd).Value & ",'" & Me.dtpPaymentDate.Value.Date & "')")
                        End If

                        If Me.cmbExp.SelectedIndex <> -1 Then 'статья затрат определена
                            Module1.NonQuery1("INSERT INTO fin_Expenses (amount,dateExpens,SettlementPeriod,ID_ArtExpenses,description,invKAID) VALUES (" & Replace(Me.nudSumma.Value, ",", ".") & ",'" & Me.dtpPaymentDate.Value.Date & "'," & SettlementPeriod & "," & expID & ",'" & desc & "'," & invID & ")")
                        End If

                        Dim cmd As New SqlClient.SqlCommand
                        cmd.Connection = mcnnInt
                        cmd.CommandText = "sp_InvoicePay"
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@ID", SqlDbType.Int))
                        cmd.Parameters("@ID").Value = Me.dgInvoices("ID", Me.dgInvoices.SelectedRows.Item(0).Index).Value

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@datePay", SqlDbType.Date))
                        cmd.Parameters("@datePay").Value = Format(Me.dtpPaymentDate.Value.Date, "s") 'Format(Now().Date, "s")

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@summa", SqlDbType.Decimal))
                        cmd.Parameters("@summa").Value = Me.nudSumma.Value

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@description", SqlDbType.NVarChar))
                        cmd.Parameters("@description").Value = Trim(Me.txtDescription.Text)

                        mcnnInt.Open()
                        cmd.ExecuteNonQuery()
                    Catch excp As System.Exception
                        MessageBox.Show(excp.Message, appName)
                    Finally
                        mcnnInt.Close()
                    End Try

                    Me.chkItIsPaid.Checked = False
                End If
            End If

            LoadInvoices()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()

    End Sub

    Private Sub dgInvoices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInvoices.CellContentClick

    End Sub
End Class