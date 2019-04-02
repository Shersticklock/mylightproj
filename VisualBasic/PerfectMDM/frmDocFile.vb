Imports System.IO
Imports System.Text

Public Class frmDocFile
    Dim mdsDocuments As New DataSet
    Dim modaDocuments As SqlClient.SqlDataAdapter
    Dim mdrDocuments As DataRow
    Dim mblnAdd As Boolean = False

    Private Sub frmDocFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFile()

        NewFile(False)
    End Sub

    Private Sub NewFile(ByVal en As Boolean)
        Me.tsbtnNew.Enabled = Not en
        Me.lstDocuments.Enabled = Not en
        Me.tsbtnDownloadFile.Enabled = Not en
        Me.tsbtnDel.Enabled = Not en
        Me.tsbtnEditFile.Enabled = Not en
        Me.txtName.Enabled = en
        Me.txtFileName.Enabled = en
        Me.txtDescription.Enabled = en
        Me.btnDownload.Enabled = en
        ' Me.tsbtnSave.Enabled = en
        Me.chkActive.Enabled = en
        Me.cmbTypeDoc.Enabled = en
    End Sub

    Private Sub LoadFile()
        Try 'Загрузка списка наименований документов
            mdsDocuments.Clear()
            modaDocuments = New SqlClient.SqlDataAdapter("SELECT ID, description, docField, name, typeFile, active, TZ FROM TypesDocument", mcnnInt)
            modaDocuments.FillSchema(mdsDocuments, 2, "TypesDocument")
            modaDocuments.Fill(mdsDocuments, "TypesDocument")
            Me.lstDocuments.DataSource = mdsDocuments.Tables("TypesDocument")    'Связать данные со списком
            Me.lstDocuments.DisplayMember = "Name"
            Me.lstDocuments.ValueMember = "ID"
        Catch oexpData As System.Exception
            MessageBox.Show("Ошибка при загрузке данных. " & oexpData.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub lstDocuments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDocuments.SelectedIndexChanged
        LoadParam()
    End Sub

    Private Sub LoadParam()
        If Me.lstDocuments.SelectedIndex > -1 Then
            Try
                mdrDocuments = mdsDocuments.Tables("TypesDocument").Rows.Find(Me.lstDocuments.SelectedItem(0))

                Me.txtName.Text = mdrDocuments("name")
                Me.txtDescription.Text = mdrDocuments("description")
                Me.chkActive.Checked = mdrDocuments("Active")
                Me.cmbTypeDoc.SelectedIndex = CInt(mdrDocuments("TZ"))
            Catch oexpData As System.Exception
                MessageBox.Show("Ошибка при загрузке шаблона. " & oexpData.Message)
                Exit Sub
        End Try
        End If
    End Sub

    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        For Each oCtl As Object In Me.TableLayoutPanel1.Controls
            If TypeOf oCtl Is TextBox Then
                Dim strName$ = Mid(oCtl.Name, 4)
                oCtl.text = ""
            End If
        Next

        mblnAdd = True
        NewFile(True)
        Me.chkActive.Checked = True
        Me.cmbTypeDoc.SelectedIndex = -1
        Me.txtName.Focus()
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        SaveRecord()

        NewFile(False)
    End Sub

#Region "  Сохранение "
    Private Sub SaveRecord()
        If Me.txtName.Text = Nothing Then MsgBox("Поле Наименование должно быть заполнено") : Exit Sub

        Try
            If Me.txtFileName.Text = Nothing Then
                Select Case MessageBox.Show("Выбрать файл шаблона?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case Is = Windows.Forms.DialogResult.Cancel
                        Exit Sub
                    Case Is = Windows.Forms.DialogResult.No
                        'не выбирать файл шаблона сохранить только текстовые поля
                        mdrDocuments.BeginEdit()
                    Case Is = Windows.Forms.DialogResult.Yes
                        OpenFileDialog1.ShowDialog()
                        Me.txtFileName.Text = OpenFileDialog1.FileName

                        '***
                        Dim fs As New IO.FileStream(Me.txtFileName.Text, FileMode.OpenOrCreate, FileAccess.Read)
                        Dim MyData(fs.Length) As Byte

                        fs.Read(MyData, 0, fs.Length)
                        fs.Close()

                        If mblnAdd = True Then
                            mdrDocuments = mdsDocuments.Tables("TypesDocument").NewRow
                        End If
                        mdrDocuments.BeginEdit()

                        mdrDocuments("docField") = MyData
                        mdrDocuments("typeFile") = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
                End Select
                ' If MessageBox.Show("Выбрать файл шаблона?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Else 'Файл шаблона выбран
                If mblnAdd = True Then
                    mdrDocuments = mdsDocuments.Tables("TypesDocument").NewRow
                End If
                ' OpenFileDialog1.ShowDialog()
                'Me.txtFileName.Text = OpenFileDialog1.FileName
                mdrDocuments.BeginEdit()
                '***
                Dim fs As New IO.FileStream(Me.txtFileName.Text, FileMode.OpenOrCreate, FileAccess.Read)
                Dim MyData(fs.Length) As Byte

                fs.Read(MyData, 0, fs.Length)
                fs.Close()

                mdrDocuments("docField") = MyData
                mdrDocuments("typeFile") = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
            End If

            '***
            mdrDocuments("description") = Me.txtDescription.Text
            mdrDocuments("name") = Me.txtName.Text
            mdrDocuments("active") = Me.chkActive.Checked
            mdrDocuments("TZ") = Me.cmbTypeDoc.SelectedIndex
            '  mdrDocuments("docField") = Nothing
            mdrDocuments.EndEdit()

            If mblnAdd = True Then
                mdsDocuments.Tables("TypesDocument").Rows.Add(mdrDocuments)
            End If

            Dim ocbMatIndiv As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(modaDocuments)

            If mblnAdd = True Then
                modaDocuments.InsertCommand = ocbMatIndiv.GetInsertCommand  ' Обеспечить создание оператора Insert SQL
            Else
                modaDocuments.UpdateCommand = ocbMatIndiv.GetUpdateCommand
            End If

            modaDocuments.Update(mdsDocuments, "TypesDocument") 'выполнить команду SQL и закрыть соед.
            mdsDocuments.Tables("TypesDocument").AcceptChanges()

            If mblnAdd = True Then
                modaDocuments.InsertCommand.Connection.Close()
            Else
                modaDocuments.UpdateCommand.Connection.Close()
            End If

            Me.txtFileName.Text = Nothing
            Me.lstDocuments.SelectedIndex = Me.lstDocuments.Items.Count - 1
        Catch excData As System.Exception
            MessageBox.Show("Error Occured:" & excData.Message, appName)
        End Try

        ' Dim fs As New IO.FileStream(OpenFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Read)
        'Dim ocbPersonIndiv As SqlClient.SqlCommandBuilder 'создать экземпляр пострителя команды
        'ocbPersonIndiv = New SqlClient.SqlCommandBuilder(modaPersonIndiv)

        'If mblnAdd = True Then
        '    modaPersonIndiv.InsertCommand = ocbPersonIndiv.GetInsertCommand  ' Обеспечить создание оператора Insert SQL
        'Else
        '    modaPersonIndiv.UpdateCommand = ocbPersonIndiv.GetUpdateCommand
        'End If

        'modaPersonIndiv.Update(mdsPersonIndiv, "EmplCust") 'выполнить команду SQL и закрыть соед.
        'mdsPersonIndiv.Tables("EmplCust").AcceptChanges()

        'If mblnAdd = True Then
        '    modaPersonIndiv.InsertCommand.Connection.Close()
        'Else
        '    modaPersonIndiv.UpdateCommand.Connection.Close()
        'End If
    End Sub
#End Region

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnDownloadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDownloadFile.Click
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM TypesDocument WHERE ID = '" & Me.lstDocuments.SelectedItem(0) & "' ", mcnnInt)
        Dim ds As New DataSet()

        Try
            da.Fill(ds, "TypesDocument")

            Dim MyData() As Byte = ds.Tables("TypesDocument").Rows(0)("docField")
            Dim K As Long = UBound(MyData)

            With SaveFileDialog1
                .InitialDirectory = "c:\"
                .Filter = "(*.rpt)|*.rpt"
                .FileName = ds.Tables("TypesDocument").Rows(0)("name")
                .ShowDialog()
            End With

            Dim fs As New FileStream(SaveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write)

            fs.Write(MyData, 0, K)
            fs.Close()

            fs = Nothing
            ds = Nothing
            da = Nothing

            NewFile(False)
            mblnAdd = False
        Catch ex As System.Exception
            MsgBox("error " & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub tsbtnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        NewFile(False)
        mblnAdd = False
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        Me.OpenFileDialog1.ShowDialog()
        Me.txtFileName.Text = Me.OpenFileDialog1.FileName
    End Sub

    Private Function IsDBNull() As Object
        Throw New NotImplementedException
    End Function

    Private Sub lstDocuments_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDocuments.SelectedValueChanged
        LoadParam()
    End Sub

    Private Sub tsbtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDel.Click
        If MessageBox.Show("Удалить шаблон документа-" & Me.lstDocuments.SelectedItem(1) & "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Module1.NonQuery1("DELETE FROM TypesDocument WHERE ID = " & Me.lstDocuments.SelectedItem(0) & " ")
            LoadFile()
            LoadParam()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsbtnEditFile_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnEditFile.Click
        NewFile(True)
    
    End Sub

    Dim dsFiles As New DS_FilesOrder

    Private Sub FillFilesSP(ByVal nameSP As String, ByVal nameTable As String)
        Dim objDA As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = nameSP
        cmd.CommandType = CommandType.StoredProcedure
        objDA = New SqlClient.SqlDataAdapter(cmd)
        objDA.Fill(dsFiles, nameTable)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Try
            dsFiles.Tables("Files").Clear()
            FillFilesSP("sp_Order_FillFiles_All", "Files")

            MsgBox("Прочитал " & dsFiles.Tables("Files").Rows.Count.ToString & "  файлов. Для продолжения нажмите Экспорт в хранилище.")
        Catch excp As System.Exception
            MessageBox.Show("Загрузка файлов " & excp.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        For iRow As Integer = 0 To dsFiles.Tables("Files").Rows.Count - 1 'перемещаемся по 
            Try
                Dim MyData() As Byte = dsFiles.Tables("Files").Rows(iRow)("dataFile")
                Dim K As Long = UBound(MyData)
                Dim fs As New FileStream(dsFiles.Tables("Files").Rows(iRow)("link").ToString, FileMode.OpenOrCreate, FileAccess.Write)

                fs.Write(MyData, 0, K)
                Me.dgFiles.Rows.Add()
                Me.dgFiles("numOrder", iRow).Value = dsFiles.Tables("Files").Rows(iRow)("NumOrder").ToString
                Me.dgFiles("nameFile", iRow).Value = dsFiles.Tables("Files").Rows(iRow)("link").ToString
                fs.Close()
                Module1.NonQuery1("UPDATE [Files] SET dataFile = null WHERE id = " & dsFiles.Tables("Files").Rows(iRow)("ID") & " ")
                Module1.NonQuery1("UPDATE [Files] SET inDB = 0 WHERE id = " & dsFiles.Tables("Files").Rows(iRow)("ID") & " ")
                '  fs = Nothing
                ' Process.Start("C:\TMP\" & strName & dsFiles.Tables("Files").Rows(curIndex)("typeFile").ToString)
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                Exit Sub
            End Try
        Next iRow
    End Sub

#Region " Экспорт в Excel "
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        '  Dim tmpDataSet As DataTable

        ' tmpDataSet = CType(dgFiles.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            ' .Range("A2:H2").Font.Size = 12
            '  .Range("A2:H2").Font.Bold = True


            For iCol = 0 To dgFiles.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgFiles.Columns(iCol).HeaderText.ToString

                For iRow = 0 To dgFiles.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = dgFiles(iCol, iRow).Value 'IIf(IsDBNull(dgFiles(iCol, iRow).Value), "", dgFiles(iCol, iRow).Value)
                Next iRow
            Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")
    End Sub
#End Region

    
    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.txtDescription.Text = Me.OpenFileDialog1.FileName.ToString
    End Sub
End Class