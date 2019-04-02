Public Class cu_UniPrice
    Private Sub SilkPrice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.cmbPriceName.ResetText()
    End Sub

    Private Sub ReadGroupPrice()
        Try
            Dim odaGroupPrice As New SqlClient.SqlDataAdapter("SELECT ID, groupName FROM PriceGroup WHERE serviceID=" & serviceID & " order by groupName", mcnnInt)
            Dim dtGroupPrice As New DataTable : odaGroupPrice.Fill(dtGroupPrice)

            Me.cmbPriceGroup.DataSource = dtGroupPrice
            Me.cmbPriceGroup.DisplayMember = "groupName"
            Me.cmbPriceGroup.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub ReadParam2()
        'Читаем наименования параметра2
        Dim odaPriceParam2 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM PriceParam2 WHERE serviceID=" & serviceID & " order by name", mcnnInt)
        Dim dtPriceParam2 As New DataTable : odaPriceParam2.Fill(dtPriceParam2)
        ' Dim strSQL$ = "SELECT ID, name FROM PriceParam2 WHERE serviceID = " & serviceID & ""

        Me.cmbParam2.DataSource = dtPriceParam2
        Me.cmbParam2.DisplayMember = "name"
        Me.cmbParam2.ValueMember = "ID"

        'Читаем наименования параметра2
        Dim odaClon1 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM PriceParam2 WHERE serviceID=" & serviceID & "", mcnnInt)
        Dim dtClon1 As New DataTable : odaClon1.Fill(dtClon1)

        Me.cmbClon1.DataSource = dtClon1
        Me.cmbClon1.DisplayMember = "name"
        Me.cmbClon1.ValueMember = "ID"

        'Читаем наименования параметра2
        Dim odaClon2 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM PriceParam2 WHERE serviceID=" & serviceID & "", mcnnInt)
        Dim dtClon2 As New DataTable : odaClon2.Fill(dtClon2)

        Me.cmbClon2.DataSource = dtClon2
        Me.cmbClon2.DisplayMember = "name"
        Me.cmbClon2.ValueMember = "ID"

        'Читаем наименования параметра2
        Dim odaClon3 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM PriceParam2 WHERE serviceID=" & serviceID & "", mcnnInt)
        Dim dtClon3 As New DataTable : odaClon3.Fill(dtClon3)

        Me.cmbClon3.DataSource = dtClon3
        Me.cmbClon3.DisplayMember = "name"
        Me.cmbClon3.ValueMember = "ID"
    End Sub

    Private Sub cmbPriceGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPriceGroup.SelectedIndexChanged
        Me.Label9.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(param2name, 'Наименование параметра не задано') FROM PriceGroup WHERE ID=" & Me.cmbPriceGroup.SelectedItem(0) & ""))
    End Sub

#Region " Загрузка наценок "
    Private Sub LoadNac()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, nacName AS Наименование, nacValue AS Значение FROM PriceNacenki WHERE groupID = " & Me.cmbPriceGroup.SelectedItem(0) & "", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.dgNacenki.DataSource = dtNacenki
            Me.dgNacenki.Columns(0).Visible = False
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

#Region " Загрузка имен прайсов "
    Private Sub LoadPrice()
        Try
            Dim odaPriceName As New SqlClient.SqlDataAdapter("SELECT ID, namePrice FROM PriceName WHERE PriceName.groupID = " & Me.cmbPriceGroup.SelectedItem(0) & " order by namePrice", mcnnInt)
            Dim dtPriceName As New DataTable : odaPriceName.Fill(dtPriceName)

            Me.cmbPriceName.DataSource = dtPriceName
            Me.cmbPriceName.DisplayMember = "namePrice"
            Me.cmbPriceName.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

#Region " Загрузка прайса и доступных тиражей "
    Private Sub LoadAccessibleTirages()
        Me.lstTirages.DataSource = Nothing

        'Читаем наименования типов услуг
        Dim odaPrice As SqlClient.SqlDataAdapter
        Dim dtPrice As New DataTable
        Dim strSQL As String

        If Me.cmbParam2.SelectedIndex <> -1 Then
            If Me.cmbPriceName.SelectedIndex <> -1 Then
                strSQL = " SELECT PriceCost.ID, PriceParam1.name AS Количество, str(PriceCost.cost, 14,2) AS [Цена за тираж], str(PriceCost.cost/PriceParam1.name, 12,2) as [Цена за единицу] FROM PriceCost "
                strSQL &= " INNER JOIN PriceParam1  ON PriceCost.param1ID = PriceParam1.ID "
                strSQL &= " WHERE PriceCost.priceNameID = " & Me.cmbPriceName.SelectedItem(0) & " "
                strSQL &= " AND PriceCost.param2ID = " & Me.cmbParam2.SelectedItem(0) & "  "

                Try
                    odaPrice = New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
                    odaPrice.Fill(dtPrice)
                Catch ex As System.Exception
                End Try

                Me.dgPrice.DataSource = dtPrice
                Me.dgPrice.Columns(0).Visible = False

                Try
                    'создаем представление чтобы получить доступные для выбр наим прайса  тиражи
                    ' Module1.NonQuery1("if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TempPriceParam1]') and OBJECTPROPERTY(id, N'IsView') = '1') drop view [dbo].[TempPriceParam1] ")
                    ' Module1.NonQuery1("CREATE VIEW dbo.TempPriceParam1 AS SELECT param1ID, param2ID, priceNameID FROM PriceCost WHERE PriceCost.priceNameID = " & Me.cmbPriceName.SelectedItem(0) & " AND PriceCost.param2ID = " & Me.cmbParam2.SelectedItem(0) & "   ")
                    Dim str1SQL$ = "SELECT PriceParam1.ID, PriceParam1.Name FROM PriceParam1 " 'INNER JOIN PriceCost ON PriceParam1.ID = PriceCost.param1ID WHERE PriceCost.groupID = " & Me.cmbPriceGroup.SelectedItem(0) & " AND   "
                    str1SQL &= " WHERE groupID = " & Me.cmbPriceGroup.SelectedItem(0) & " AND ID not in"
                    str1SQL &= " (SELECT param1ID FROM PriceCost WHERE priceNameID = " & Me.cmbPriceName.SelectedItem(0) & " AND param2ID = " & Me.cmbParam2.SelectedItem(0) & ") order by  PriceParam1.Name"
                    Dim odaTiragList As New SqlClient.SqlDataAdapter(str1SQL, mcnnInt)
                    Dim dtTiragList As New DataTable : odaTiragList.Fill(dtTiragList)
                
                    If dtTiragList.Rows.Count = 0 Then Me.tsbtnCostSave.Enabled = False Else Me.tsbtnCostSave.Enabled = True
                    'Связать данные со списком
                    Me.lstTirages.DataSource = dtTiragList
                    Me.lstTirages.DisplayMember = "name"
                    Me.lstTirages.ValueMember = "ID"

                    'Me.lstTirages.ClearSelected()
                Catch oexpData As System.Exception
                    MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
                End Try
            End If
        End If
    End Sub
#End Region

    Private Sub txtCostCD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then Me.tsbtnCostSave.Select()
        e.Handled = True
    End Sub

    Private Sub btnAddNacenku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNacenku.Click
        Me.Label1.Visible = False
        Me.txtNacName.Visible = False
        Me.nudNacValue.Visible = False
        Me.btnAddNacenku.Visible = False

        Module1.NonQuery1("INSERT INTO PriceNacenki (nacName, nacValue, groupID) VALUES ('" & Me.txtNacName.Text & "', " & Replace(Me.nudNacValue.Value, ",", ".") & ", " & Me.cmbPriceGroup.SelectedItem(0) & ")")

        LoadNac()
    End Sub

    Private Sub УдалитьНаценкуToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьНаценкуToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Удалить наценку? ", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM PriceNacenki WHERE ID=" & Me.dgNacenki(0, Me.dgNacenki.CurrentRow.Index).Value & "")

                LoadNac()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub txtCostCD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Integer

        KeyAscii = Asc(e.KeyChar)

        If KeyAscii = 13 Then
            Me.tsbtnCostSave.Select()
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmbPriceName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPriceName.SelectedIndexChanged
        If Me.cmbParam2.SelectedIndex <> -1 Then ' без проверки этого условия возникает ошибка при загрузке формы
            If Me.cmbPriceGroup.SelectedIndex <> -1 Then
                LoadAccessibleTirages()
            End If
        End If

        If Me.cmbPriceName.SelectedIndex = -1 Then
            Me.txtIDpriceName.Text = Nothing
        End If
    End Sub


#Region " Получение наменования параметра2 для подписи рамки "
    'Public Function strParametr2() As String
    '    Module1.NonQuery1ScalarString("SELECT description FROM Services WHERE ID = '" & serviceID & "' ")

    'End Function
#End Region

    Private Sub УдалитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Удалить параметр для направления " & Trim(Me.cmbParam2.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & " ")

                ReadParam2()
                LoadPrice()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim resp As Integer

        'If Me.dgPrice.Rows.Count <> 0 Then
        resp = MsgBox(Prompt:="Удалить прайс на продукцию для группы" + Me.cmbPriceGroup.Text + " на " & Trim(Me.cmbPriceName.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
        Select Case resp
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM PriceName WHERE ID=" & Me.cmbPriceName.SelectedItem(0) & "")
                LoadPrice()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub УдалитьГруппуПрайсовToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьГруппуПрайсовToolStripMenuItem.Click
        Dim resp As Integer = MsgBox(Prompt:="Удалить группу прайс-листов " & Trim(Me.cmbPriceGroup.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)

        Select Case resp
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM PriceGroup WHERE ID = " & Me.cmbPriceGroup.SelectedItem(0) & "")

                ReadGroupPrice()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub tsbtnCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCostSave.Click
        SaveCost()
    End Sub

    Private Sub SaveCost()
        If Me.lstTirages.SelectedIndex = -1 Then
            MsgBox("Не выбран тираж", MsgBoxStyle.Critical, appName) : Exit Sub
        End If
        'За(единицу)
        'За(тираж)
        Dim cost As Decimal

        If Me.tscmbTypeCost.SelectedIndex = -1 Then
            MsgBox("Не выбран тип цены", MsgBoxStyle.Critical, appName) : Me.tscmbTypeCost.Focus() : Exit Sub
        End If

        If IsNumeric(Me.tstxtCost.Text) = True Then
            If Me.tscmbTypeCost.SelectedIndex = 0 Then 'указана цена за единицу
                cost = Val(Replace(Me.tstxtCost.Text, ",", ".")) * Val(Me.lstTirages.Text)
            Else 'указана цена за тираж
                cost = Val(Replace(Me.tstxtCost.Text, ",", "."))
            End If

            Dim strSQL$ = " INSERT INTO PriceCost (priceNameID, param1ID, param2ID, cost) VALUES (" & Me.cmbPriceName.SelectedItem(0) & ", " & Me.lstTirages.SelectedItem(0) & ","
            strSQL &= " " & Me.cmbParam2.SelectedItem(0) & ", " & Replace(cost, ",", ".") & ")"

            Module1.NonQuery1(strSQL)

            LoadAccessibleTirages()

            Me.tstxtCost.SelectAll()
        Else
            MsgBox("Значение стоимости не является числом", appName)
        End If

        Me.tstxtCost.Focus()
    End Sub

    Private Sub tsbtnAddKolvo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAddKolvo.Click
        AddTirages()
    End Sub

    Private Sub AddTirages()
        Dim strName As String = InputBox("Добавить тираж в группе " & Trim(CStr(Me.cmbPriceGroup.Text)), appName)
        If Len(strName) = 0 Then
            MsgBox("Запись не произведена.", MessageBoxIcon.Error, appName) : Exit Sub
        End If

        Module1.NonQuery1("INSERT INTO PriceParam1 (name, groupID)  VALUES ('" & strName & "', " & Me.cmbPriceGroup.SelectedItem(0) & ") ")

        LoadAccessibleTirages()

        Me.lstTirages.Focus()
    End Sub

    Private Sub tsbtnDelKolvo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelKolvo.Click
        Select Case MsgBox(Prompt:="Удалить количество? ", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM PriceParam1 WHERE ID = " & Me.lstTirages.SelectedItem(0) & " ")
            Case Is = vbNo
                Exit Sub
        End Select

        LoadAccessibleTirages()
    End Sub

    Private Sub tsbtnDelCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelCost.Click
        DeleteCost()
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tstxtCost_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tstxtCost.KeyDown
        If e.KeyCode = Keys.Enter Then SaveCost()
        e.Handled = True
    End Sub

    Private Sub lstTirages_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lstTirages.KeyDown
        If e.KeyCode = Keys.Enter Then AddTirages()
        ' e.Handled = True
    End Sub

    Private Sub УдалитьЦенуToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles УдалитьЦенуToolStripMenuItem.Click
        DeleteCost()
    End Sub

    Private Sub DeleteCost()
        If Me.dgPrice.Rows.Count <> 0 Then
            Dim resp As Integer = MsgBox(Prompt:="Удалить цену " & CStr(Me.dgPrice(2, Me.dgPrice.CurrentRow.Index).Value) & " за " & CStr(Me.dgPrice(1, Me.dgPrice.CurrentRow.Index).Value) & "? ", Buttons:=vbYesNo, Title:=appName)

            Select Case resp
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM PriceCost WHERE ID=" & Me.dgPrice(0, Me.dgPrice.CurrentRow.Index).Value & " ")
                    LoadAccessibleTirages()
                Case Is = vbNo
                    Exit Sub
            End Select
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsbtnClon_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnClon.Click
        Dim oCtl As Object

        For Each oCtl In tsPriceSet.Controls
            If oCtl.name <> sender.name Then
                oCtl.enabled = Not sender.checked
            End If
        Next

        Me.tsbtnAddKolvo.Enabled = Not sender.checked
        Me.tsbtnCostSave.Enabled = Not sender.checked
        Me.tsbtnDelKolvo.Enabled = Not sender.checked
        Me.tsbtnDelCost.Enabled = Not sender.checked

        Me.lstTirages.Visible = Not sender.checked
        Me.pnClon.Visible = sender.checked
    End Sub

    Private Sub btnClon_Click(sender As System.Object, e As System.EventArgs) Handles btnClon.Click
        If Me.cmbClon1.SelectedIndex = -1 Then
            MsgBox("Выбери первое слагаемое", appName) : Exit Sub
        End If

        Dim TiragID%, cost1@, cost2@, cost3@
        Dim priceID% = Me.cmbPriceName.SelectedItem(0)

        For n As Integer = 0 To Me.lstTirages.Items.Count - 1
            TiragID = Me.lstTirages.Items(n)(0)

            cost1 = Module1.NonQuery1Scalar("SELECT cost FROM PriceCost WHERE priceNameID=" & priceID & " AND param1ID=" & TiragID & " AND param2ID=" & Me.cmbClon1.SelectedItem(0) & "")

            If Me.chkClon1.Checked = True Then
                cost2 = Module1.NonQuery1Scalar("SELECT cost FROM PriceCost WHERE priceNameID=" & priceID & " AND param1ID=" & TiragID & " AND param2ID=" & Me.cmbClon2.SelectedItem(0) & "")
            Else
                cost2 = 0
            End If

            If Me.chkClon2.Checked Then
                cost3 = Module1.NonQuery1Scalar("SELECT cost FROM PriceCost WHERE priceNameID=" & priceID & " AND param1ID = " & TiragID & " AND param2ID=" & Me.cmbClon3.SelectedItem(0) & "")
            Else
                cost3 = 0
            End If

            Dim strSQL$ = " INSERT INTO PriceCost (priceNameID, param1ID, param2ID, cost) VALUES (" & priceID & ", " & TiragID & ", " & Me.cmbParam2.SelectedItem(0) & ", " & Replace((cost1 + cost2 + cost3), ",", ".") & ")"
            Module1.NonQuery1(strSQL)
        Next

        LoadAccessibleTirages()
    End Sub

    Private Sub chkClon1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkClon1.CheckedChanged
        Me.cmbClon2.Visible = sender.checked
        Me.chkClon2.Visible = sender.checked
        Me.Label4.Visible = sender.checked
    End Sub

    Private Sub chkClon2_VisibleChanged(sender As Object, e As System.EventArgs) Handles chkClon2.VisibleChanged
        If Me.chkClon2.Visible = False Then
            Me.chkClon2.Checked = False
        End If
    End Sub

    Private Sub chkClon2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkClon2.CheckedChanged
        Me.Label5.Visible = sender.checked
        Me.cmbClon3.Visible = sender.checked
    End Sub

    Private Sub cmbPriceGroup_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbPriceGroup.SelectedValueChanged
        'Читаем наценки и прайс
        If Me.cmbPriceGroup.SelectedIndex <> -1 Then
            LoadNac()
            LoadPrice() 'Загрузка имен прайсов
            LoadAccessibleTirages()

            Me.txtID_GroupPrice.Text = sender.selecteditem(0)
        End If
    End Sub

    ' Private Sub КоличествоСЛистаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КоличествоСЛистаToolStripMenuItem.Click
    'Dim strName As String = InputBox("Для изготовления " & Trim(Me.cmbParam2.SelectedItem(1)) & " сколько требуется печатных форматов?", appName)

    'If Len(strName) = 0 Then
    '    MsgBox("Запись не произведена  ", MessageBoxIcon.Error, appName) : Exit Sub
    'Else
    '    Select Case MsgBox(Prompt:=" Для изготовления " & Trim(Me.cmbParam2.SelectedItem(1)) & " требуется - " & strName & " печатных форматов?", Buttons:=vbYesNo, Title:=appName)
    '        Case Is = vbYes
    '            Module1.NonQuery1("UPDATE PriceParam2 SET kolvoSlista=" & Replace(strName, ",", ".") & "WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "")

    '            ReadParam2()

    '        Case Is = vbNo
    '            Exit Sub
    '    End Select
    'End If

    'Else
    '    Dim strName As String = InputBox("Сколько " & Trim(Me.cmbParam2.SelectedItem(1)) & " получается с листа A3 (SRA3)?", appName)

    '    Select Case MsgBox(Prompt:="С листа A3 (SRA3) выход - " & strName & " штук " & Trim(Me.cmbParam2.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
    '        Case Is = vbYes
    '            Module1.NonQuery1("UPDATE PriceParam2 SET kolvoSlista=" & Replace(strName, ",", ".") & "WHERE ID=" & Me.cmbParam2.SelectedItem(0) & " ")

    '            ReadParam2()

    '        Case Is = vbNo
    '            Exit Sub
    '    End Select
    'End If
    ' End Sub

    Private Sub ТаблицаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ТаблицаToolStripMenuItem.Click
        MsgBox("Данные находятся в таблице PriceParam2", MsgBoxStyle.Critical, appName)

        ModCallForm.CallForm("Таблицы", 4, 3)
    End Sub

    Private Sub cu_UniPrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim odaMatList As New SqlClient.SqlDataAdapter("SELECT ID, formatName FROM MatFormats order by formatName", mcnnInt)
        Dim dtMatFormat As New DataTable : odaMatList.Fill(dtMatFormat)

        Me.cmbMatFormat.DataSource = dtMatFormat  'Связать данные со списком
        Me.cmbMatFormat.DisplayMember = "formatName"
        Me.cmbMatFormat.ValueMember = "ID"


        ReadGroupPrice()   'Читаем наименования групп прайсов
        ReadParam2() 'читаем и загружаем параметр2 и его название

        Me.Label8.Text = Trim(Module1.NonQuery1ScalarString("SELECT coalesce(description,'Не задан.') FROM Services WHERE ID=" & serviceID & ""))
        Me.tscmbTypeCost.SelectedIndex = 0
        Me.tstxtCost.Text = "Цена"
        Me.tstxtCost.SelectAll()
        Me.tsbtnClon.Visible = False

      
        Me.Label1.Text += " (%)"

     

        Me.tscmbTypeCost.SelectedIndex = -1
    End Sub

    Private Sub cmbParam2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbParam2.SelectedIndexChanged
        Dim mfID As Integer

        LoadAccessibleTirages() 'показать доступные тиражи

        '  If idConfig <> 18756 Then 'ER
        'Me.txtKolvoSlista.Text = Module1.NonQuery1ScalarString("SELECT cast(kolvoSlista as nvarchar) FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "")
        Me.nudMatFormat.Value = Module1.NonQuery1ScalarString("SELECT kolvoSlista FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "")
        mfID = Module1.NonQuery1ScalarString("SELECT coalesce(matFormatID, 0) FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "")

        If mfID = 0 Then
            Me.cmbMatFormat.SelectedIndex = -1
            Me.cmbMatFormat.DropDownStyle = ComboBoxStyle.DropDown
            Me.cmbMatFormat.Text = "Не задан"
        Else
            Me.cmbMatFormat.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbMatFormat.SelectedValue = mfID
        End If


        'Else
        '    Me.txtKolvoSlista.Text = "С листа " & Module1.NonQuery1ScalarString("SELECT cast(kolvoSlista as nvarchar) FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "")
        'End If
    End Sub

    Private Sub ДобавитьНаценкуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьНаценкуToolStripMenuItem.Click
        Me.Label1.Visible = True
        Me.txtNacName.Visible = True
        Me.nudNacValue.Visible = True
        Me.btnAddNacenku.Visible = True
    End Sub

    Private Sub ОтменаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОтменаToolStripMenuItem.Click
        Me.Label1.Visible = False
        Me.txtNacName.Visible = False
        Me.nudNacValue.Visible = False
        Me.btnAddNacenku.Visible = False
    End Sub

    Private Sub tstxtCost_MouseDown(sender As Object, e As MouseEventArgs) Handles tstxtCost.MouseDown
        sender.Select(0, Len(sender.Text))
    End Sub

    Private Sub ИзменитьНазваниеПараметраToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ИзменитьНазваниеПараметраToolStripMenuItem1.Click
        Dim strName As String = InputBox("Введи наименование параметра ", appName)

        If Len(strName) = 0 Then
            MsgBox("Запись не произведена  ", MessageBoxIcon.Error, appName)
        Else
            Module1.NonQuery1("UPDATE PriceGroup SET param2name='" & strName & "' WHERE ID=" & Me.cmbPriceGroup.SelectedItem(0) & "")

            Me.Label9.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(param2name, 'Наименование параметра не задано') FROM PriceGroup WHERE ID=" & Me.cmbPriceGroup.SelectedItem(0) & ""))
        End If
    End Sub

    Private Sub cmbPriceName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPriceName.SelectedValueChanged
        If Me.cmbPriceName.SelectedIndex <> -1 Then
            Me.txtIDpriceName.Text = Me.cmbPriceName.SelectedValue.ToString
        End If
    End Sub

    Private Sub ДобавитьГруппуПрайслистовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьГруппуПрайслистовToolStripMenuItem.Click
        Dim strName As String

        strName = InputBox("Новая группа", appName)

        If Len(strName) = 0 Then
            MsgBox("Запись не произведена  ", MessageBoxIcon.Error, appName) : Exit Sub
        End If

        Module1.NonQuery1("INSERT INTO PriceGroup (groupName, serviceID)  VALUES ('" & strName & "', " & serviceID & ")")

        ReadGroupPrice()
    End Sub

    Private Sub ДобавитьПараметрToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьПараметрToolStripMenuItem.Click
        Dim strName As String = InputBox("Новый параметр ")

        If Len(strName) = 0 Then
            MsgBox("Запись не произведена ", MessageBoxIcon.Error) : Exit Sub
        Else
            Module1.NonQuery1("INSERT INTO PriceParam2 (name, serviceID)  VALUES ('" & strName & "'," & serviceID & ")")

            ReadParam2()

            Me.cmbParam2.SelectedIndex = Me.cmbParam2.Items.Count - 1

            LoadPrice()
        End If
    End Sub

    Private Sub ДобавитьПрайслистToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьПрайслистToolStripMenuItem.Click
        Dim strName As String = InputBox("Новый " & Me.Label9.Text & " в группе " & Trim(CStr(Me.cmbPriceGroup.Text)), appName)

        If Len(strName) = 0 Then
            MsgBox("Запись не произведена  ", MessageBoxIcon.Error, appName) : Exit Sub
        End If

        Module1.NonQuery1("INSERT INTO PriceName (namePrice, groupID) VALUES ('" & strName & "', " & Me.cmbPriceGroup.SelectedItem(0) & ")")

        LoadPrice()
    End Sub


    Private Sub btnMatFormat_Click(sender As Object, e As EventArgs) Handles btnMatFormat.Click
        Select Case MsgBox(Prompt:=" Для изготовления " & Trim(Me.cmbParam2.SelectedItem(1)) & " требуется - " & Me.nudMatFormat.Value.ToString & " форматов?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Me.cmbPriceGroup.Enabled = True
                Me.btnMatFormat.Enabled = False
                Me.cmbMatFormat.Enabled = False
                Me.nudMatFormat.Enabled = False
                Me.btnMatFormat.Enabled = False

                Module1.NonQuery1("UPDATE PriceParam2 SET kolvoSlista=" & Replace(Me.nudMatFormat.Value, ",", ".") & ", matFormatID=" & Me.cmbMatFormat.SelectedItem(0) & " WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "")

                '  ReadParam2()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub


    Private Sub btnEditMatFormat_Click(sender As Object, e As EventArgs) Handles btnEditMatFormat.Click
        Me.cmbPriceGroup.Enabled = False
        Me.btnMatFormat.Enabled = True
        Me.cmbMatFormat.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbMatFormat.Enabled = True
        Me.nudMatFormat.Enabled = True

        Me.btnMatFormat.Enabled = True

        Me.cmbMatFormat.Focus()
    End Sub
End Class