Public Class c_777config
    Dim calcID As Integer

#Region " Загрузка и активация "
    Private Sub awc_Polygraph_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        calcID = 777

        Dim odaTech As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE calcID=" & calcID & " AND controlTag='" & Me.cmbColor.Tag & "' AND serviceID=" & serviceID & "", mcnnInt)
        Dim dtTech As New DataTable : odaTech.Fill(dtTech)

        If dtTech.Rows.Count = 0 Then
            MsgBox("Необходимо цветность печати в таблицу [awc_CalcTech]. ", MsgBoxStyle.Information, appName)
            Exit Sub
        End If

        Me.cmbColor.DataSource = dtTech 'Связать данные со списком
        Me.cmbColor.DisplayMember = "nameTech"
        Me.cmbColor.ValueMember = "ID"

        Me.tmbMatTypes.Enabled = True

        Dim odaTech1 As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE calcID=" & calcID & " AND controlTag='" & Me.cmbSideLam.Tag & "' AND serviceID=" & serviceID & "", mcnnInt)
        Dim dtTech1 As New DataTable : odaTech1.Fill(dtTech1)

        If dtTech1.Rows.Count = 0 Then
            MsgBox("Необходимо добавить варианты ламинирования в таблицу [awc_CalcTech]. ", MsgBoxStyle.Information, appName)
            Exit Sub
        End If

        Me.cmbSideLam.DataSource = dtTech1 'Связать данные со списком
        Me.cmbSideLam.DisplayMember = "nameTech"
        Me.cmbSideLam.ValueMember = "ID"

        FindProd()

        Try
            'binding
            Dim odaBind As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM awc_Binding", mcnnInt)
            Dim dtBind As New DataTable : odaBind.Fill(dtBind)

            Me.tmbBinding.DataSource = dtBind 'Связать данные со списком
            Me.tmbBinding.DisplayMember = "Name"
            Me.tmbBinding.ValueMember = "ID"

            'ламинирование
            Dim list2 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='Тип пленки*'")
            Dim odaMatType1 As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & list2 & ")", mcnnInt)
            Dim dtMatType1 As New DataTable : odaMatType1.Fill(dtMatType1)

            Me.cmbTypesPlenka.DataSource = dtMatType1 'Связать данные со списком
            Me.cmbTypesPlenka.DisplayMember = "Name"
            Me.cmbTypesPlenka.ValueMember = "ID"
        Catch ex As System.Exception
            MsgBox("Возможно не сконфигурировано ламинирование или переплет. " & ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try

        '  ReadIni()
    End Sub
#End Region

#Region " Выбираем продукцию "
    Private Sub tmbMatTypes_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmbMatTypes.SelectedValueChanged
        If Me.tmbMatTypes.SelectedIndex = -1 Then
            Me.cmbMatTypes.SelectedIndex = -1
            Exit Sub
        Else
            If Me.tmbMatTypes.SelectedItem(2) <> 1 Then

            Else

            End If

            LoadTypesMat()
            LoadOper()
        End If

        'Try

        '    If allowSelectProd = True Then
        '        Dim strSQL1$ = " "
        '        Dim strTypeMatID$ = Module1.NonQuery1ScalarString(strSQL1)

        '        If strTypeMatID = Nothing Then

        '            ' MsgBox("Не сконфигурирован материал для продукта.", MsgBoxStyle.Critical, appName)
        '            '  ConfigCalc(Me.tmbMatTypes)
        '            ' Me.cmbMatTypes.SelectedIndex = -1
        '            '  Me.cmbMatTypes.Focus()

        '            'Exit Sub
        '        Else
        '            LoadTypesMat()
        '            LoadOper()
        '        End If
        '    Else

        '    End If


        'Catch ex As System.Exception
        '    MsgBox("error1-Возможно не сконфигурирован материал или технологические операции для продукта." & ex.Message, MsgBoxStyle.Critical, appName)

        '    '  ConfigCalc(cmsConfigMat.SourceControl)

        '    ' Exit Sub
        'End Try
    End Sub

    Private Sub LoadTypesMat()
        Dim list2 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.tmbMatTypes.Text & "'")

        If list2 = Nothing Then
            Me.cmbMatTypes.DataSource = Nothing
        Else
            Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & list2 & ") order by Name", mcnnInt)
            Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

            Me.cmbMatTypes.DataSource = dtMatType 'Связать данные со списком
            Me.cmbMatTypes.DisplayMember = "Name"
            Me.cmbMatTypes.ValueMember = "ID"
        End If
    End Sub
#End Region

    '#Region " Читаем ини файл "
    '    Private Sub ReadIni()
    '        Try
    '            Dim odaMatList As New SqlClient.SqlDataAdapter("SELECT ParamName, ParamValue FROM PriceServices WHERE Section='Digital'", mcnnInt)
    '            Dim dtPrice As New DataTable : odaMatList.Fill(dtPrice)
    '            Dim dtWorkPrice As New DataTable

    '            dtWorkPrice.Columns.Add("Param", GetType(String))
    '            dtWorkPrice.Columns.Add("Value", GetType(Decimal))
    '            dtWorkPrice.Columns("Param").Unique = True
    '            dtWorkPrice.PrimaryKey = New DataColumn() {dtWorkPrice.Columns("Param")}

    '            For Each dr As DataRow In dtPrice.Rows
    '                dtWorkPrice.Rows.Add(New Object() {dr("ParamName"), dr("ParamValue")})
    '            Next

    '            nacMF = dtWorkPrice.Rows.Find("NacCifra")("Value")
    '            vyletCifra = dtWorkPrice.Rows.Find("CifraVylet")("Value")
    '            '   vyletOfset = dtWorkPrice.Rows.Find("OfsetVylet")("Value")
    '            nacMF1 = dtWorkPrice.Rows.Find("NacCifra1")("Value")
    '            nacMF2 = dtWorkPrice.Rows.Find("NacCifra2")("Value")
    '            nacMF3 = dtWorkPrice.Rows.Find("NacCifra3")("Value")
    '        Catch oexpData As System.Exception
    '            MsgBox("readini-" & oexpData.Message, MsgBoxStyle.Critical, appName)
    '        End Try
    '    End Sub
    '#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsConfigMat.SourceControl)
        LoadTypesMat()
        LoadMatBinding()
    End Sub

    Private Sub ConfigCalc(ByRef ob As Object)
        Dim frmSelect As New frmConfigCalcMat
        Dim c As Control

        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
            For Each c In ob.Parent.Controls  'ob контрол к которому привязано меню
                If TypeOf c Is CheckBox Or TypeOf c Is Label Then 'ВНИМАНИЕ смотри тип элемента
                    If Mid(c.Name, 4) = Mid(ob.Name, 4) Then 'кто вызвал этот элемент управления
                        frmSelect.fff = c.Text
                        frmSelect.ShowDialog()
                        Exit For
                    End If
                End If

                If TypeOf c Is ComboBox Then 'ВНИМАНИЕ смотри тип элемента
                    If Mid(c.Name, 4) = Mid(ob.Name, 4) And c.Text <> ob.text Then 'кто вызвал этот элемент управления
                        frmSelect.fff = c.Text
                        frmSelect.ShowDialog()
                        Exit For
                    End If
                End If
            Next
        Else
            MsgBox("Нет прав на конфигурирование", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub cmbMatTypes_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbMatTypes.SelectedValueChanged
        Try
            If sender.SelectedIndex <> -1 Then
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID=" & sender.SelectedItem(0) & " AND accessible=1 order by matName", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMat.DataSource = dtMat1 'Связать данные со списком
                Me.cmbMat.DisplayMember = "matName"
                Me.cmbMat.ValueMember = "matID"
            Else
                Me.cmbMat.DataSource = Nothing
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

#Region " Выбираем материал "
    Dim dtMatFormats As DataTable


    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbMat.SelectedValueChanged
        'If Me.cmbMat.SelectedIndex <> -1 Then
        '    Dim cmd As New SqlClient.SqlCommand
        '    cmd.Connection = mcnnInt
        '    cmd.CommandText = "[sp_MatPrintFormat]"
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
        '    cmd.Parameters("@matID").Value = Me.cmbMat.SelectedItem(0)

        '    cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeX", SqlDbType.Int))
        '    cmd.Parameters("@sizeX").Value = 1

        '    cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeY", SqlDbType.Int))
        '    cmd.Parameters("@sizeY").Value = 1

        '    cmd.Parameters.Add(New SqlClient.SqlParameter("@tirag", SqlDbType.Int))
        '    cmd.Parameters("@tirag").Value = 1

        '    cmd.Parameters.Add(New SqlClient.SqlParameter("@colorOperID", SqlDbType.Int))
        '    cmd.Parameters("@colorOperID").Value = 1

        '    Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        '    dtMatFormats = New DataTable : odaMan.Fill(dtMatFormats)
        'End If
    End Sub
#End Region

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        'If Me.tmbMatTypes.SelectedIndex = -1 Then
        'Else
        Module1.ConfigTechOper(Me.cmsConfigTech.SourceControl, calcID)
        'End If
    End Sub

    Private Sub FindProd()
        Dim strSQL$ = "SELECT ID, Name, typeProdID FROM awc_Polygraph WHERE tagCalc='" & calcID & "' AND serviceID=" & serviceID & ""

        Try
            Dim odaProd As New SqlClient.SqlDataAdapter(strSQL, mcnnInt) 'не сортировать иначе не получим посл добавленного заказчика
            Dim dtProd As New DataTable : odaProd.Fill(dtProd)

            If dtProd.Rows.Count = 0 Then
                Me.tmbMatTypes.SelectedIndex = -1
                Exit Sub
            Else
                Me.tmbMatTypes.DataSource = dtProd 'Связать данные со списком
                Me.tmbMatTypes.DisplayMember = "Name"
                Me.tmbMatTypes.ValueMember = "ID"
            End If

            If addProdawcPoly = True Then
                Me.tmbMatTypes.SelectedIndex = Me.tmbMatTypes.Items.Count - 1

                ConfigCalc(Me.cmbMatTypes)
                LoadTypesMat()

                addProdawcPoly = False
            End If
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

#Region " Загрузка операций "
    Private Sub LoadOper()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID,name FROM tech_Operations WHERE ID IN (SELECT techOperID FROM tech_OperControlTag WHERE controlItem0=" & Me.tmbMatTypes.SelectedItem(0) & " AND controlTag='ppo' AND serviceID=" & serviceID & ") order by name", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbOper.DataSource = dtNacenki
            Me.clbOper.DisplayMember = "name"
            Me.clbOper.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub ДобавитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьПродуктToolStripMenuItem.Click
        formTagNewProd = calcID

        ModCallForm.CallForm("Продукт", 42, 3)

        FindProd()
    End Sub

    Private Sub УдалитьПродуктToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles УдалитьПродуктToolStripMenuItem1.Click
        Select Case MsgBox(Prompt:="Удалить  " & Trim(Me.tmbMatTypes.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM awc_Polygraph WHERE ID=" & Me.tmbMatTypes.SelectedItem(0) & "")

                FindProd()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub ДобавитьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(Me.tmbMatTypes, calcID)

        LoadOper()
    End Sub

    Private Sub cmbTypesPlenka_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTypesPlenka.SelectedValueChanged
        Try
            If sender.SelectedIndex <> -1 Then
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID=" & sender.SelectedItem(0) & " AND accessible=1 order by matName ", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMatLam.DataSource = dtMat1 'Связать данные со списком
                Me.cmbMatLam.DisplayMember = "matName"
                Me.cmbMatLam.ValueMember = "matID"
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub


    Private Sub cmbPrintFormat_SelectedValueChanged(sender As Object, e As EventArgs)
        'Try
        '    If Me.cmbPrintFormat.SelectedIndex <> -1 Then
        '        Dim mdrMat As DataRow = dtMatFormats.Rows(Me.cmbPrintFormat.SelectedIndex) ' mdsMat.Tables("Materials").Rows(Me.cmbPrintFormat.SelectedIndex)

        '        CenaLista = mdrMat("priceOut")
        '        zakupList = mdrMat("costBay")
        '        x1 = mdrMat("sizeX")
        '        y1 = mdrMat("sizeY")

        '        totalDimX = mdrMat("totalDimX")
        '        totalDimY = mdrMat("totalDimY")

        '        nacMat = mdrMat("nacenka")
        '        nacFormat = mdrMat("nacFormat")

        '        formatInOut = mdrMat("kolvo")
        '        SkladAccUnit = mdrMat("unitID")
        '    Else
        '        CenaLista = Format(0, "C")
        '        zakupList = Format(0, "C")
        '        x1 = 0
        '        y1 = 0
        '        nacMat = 0
        '    End If
        'Catch ex As System.Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        'End Try
    End Sub

    Private Sub tmbBinding_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmbBinding.SelectedValueChanged
        LoadMatBinding()
    End Sub

    Private Sub LoadMatBinding()
        If Me.tmbBinding.SelectedIndex <> -1 Then
            Dim strTypeMatID$ = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.tmbBinding.SelectedItem(1) & "'")

            If strTypeMatID = Nothing Then
                MsgBox("Не сконфигурирован материал для перплета.", MsgBoxStyle.Critical, appName)
                '    
                Me.cmbBinding.DataSource = Nothing

                ConfigCalc(Me.tmbBinding)
                '  Me.cmbBinding.Focus()
                Exit Sub
            Else
                Dim odaBind As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials where typeID IN (" & strTypeMatID & ") order by matName", mcnnInt)
                Dim dtBind As New DataTable : odaBind.Fill(dtBind)

                Me.cmbBinding.DataSource = dtBind 'Связать данные со списком
                Me.cmbBinding.DisplayMember = "matName"
                Me.cmbBinding.ValueMember = "matID"
            End If
        Else
            MsgBox("Нет видов переплета.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub tmbBinding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tmbBinding.SelectedIndexChanged

    End Sub
End Class