Public Class c_Polygraph
    Public OK As Boolean

    Dim x1, y1, totalDimX, totalDimY, sheets, SkladAccUnit As Integer
    Dim CenaLista@, zakupList@, nacMat@
    Dim nacFormat% = 0
    Dim formatInOut@
    Dim matLamCount%
    Dim vyletCifra%, vyletOfset%
    Dim nacMF1%, nacMF2%, nacMF3%
    Dim nacMF, sumnac As Decimal

    Dim parametr$ = Nothing
    Dim colorStr$, prim$, techStr$

    Dim allowSelectProd As Boolean

    Dim costPrint As Decimal = 0
    Dim costMat As Decimal = 0
    Dim costPPO As Decimal = 0
    Dim itogCostPMP As Decimal

    Dim costLam@ = 0 'стоимость ламинирования
    Dim itogCostL@
    Dim costBind@ = 0 'стоимость брошюровки
    Dim itogCostB@
    Dim discont As Integer

    Dim calcID As Integer

#Region " Загрузка и активация "
    Private Sub awc_Polygraph_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If addProdawcPoly = True Then
            '   addProdawcPoly = False
        End If
    End Sub

    Private Sub awc_Polygraph_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        calcID = 777
        serviceID = Module1.NonQuery1ScalarString("SELECT id FROM Services WHERE formCostNumber='777'")

        Dim odaDiscont As New SqlClient.SqlDataAdapter("SELECT awc_Discont.ID, awc_Discont.Name FROM awc_Discont INNER JOIN awc_DiscontServices ON awc_Discont.ID=awc_DiscontServices.discontID WHERE awc_DiscontServices.serviceID=" & serviceID & "", mcnnInt)
        Dim dtDiscont As New DataTable : odaDiscont.Fill(dtDiscont)

        Me.tscmbSkidka.ComboBox.DataSource = dtDiscont 'Связать данные со списком
        Me.tscmbSkidka.ComboBox.DisplayMember = "Name"
        Me.tscmbSkidka.ComboBox.ValueMember = "ID"

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

        FindProd("")

        Try
            'binding
            Dim odaBind As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM awc_Binding", mcnnInt)
            Dim dtBind As New DataTable : odaBind.Fill(dtBind)

            Me.tmbBinding.DataSource = dtBind 'Связать данные со списком
            Me.tmbBinding.DisplayMember = "Name"
            Me.tmbBinding.ValueMember = "ID"
            Me.tmbBinding.SelectedIndex = -1
            ' allowSelectBind = True

            'ламинирование
            Dim list2 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='Тип пленки*'")
            Dim odaMatType1 As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & list2 & ") ", mcnnInt)
            Dim dtMatType1 As New DataTable : odaMatType1.Fill(dtMatType1)

            Me.cmbTypesPlenka.DataSource = dtMatType1 'Связать данные со списком
            Me.cmbTypesPlenka.DisplayMember = "Name"
            Me.cmbTypesPlenka.ValueMember = "ID"
        Catch ex As System.Exception
            MsgBox("Возможно не сконфигурировано ламинирование или брошюровка.  " & ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try

        Me.nudVylet.Value = vyletCifra

        Me.cmbFormat.Items.Add("110*220")
        Me.cmbFormat.Items.Add("229*324")
        Me.cmbFormat.Items.Add("162*229")
        Me.nudVylet.Visible = False
        Me.lblVylet.Text = "Обрезной размер (мм)"
        Me.cmbFormat.Visible = True
        Me.Label17.Visible = True
        Me.lblFerstCostPrint.Visible = True

        ReadIni()
    End Sub
#End Region

#Region " Выбираем продукцию "
    Private Sub tmbMatTypes_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmbMatTypes.SelectedValueChanged
        If Me.tmbMatTypes.SelectedIndex = -1 Then
            Me.cmbMatTypes.SelectedIndex = -1
            Exit Sub
        Else
            If Me.tmbMatTypes.SelectedItem(2) <> 1 Then
                Me.nudPolos.Visible = True
                Me.Label30.Visible = True
                Me.chkBind.Visible = True
                Me.tmbBinding.Visible = True
                Me.cmbBinding.Visible = True
                Me.cmbBindSide.Visible = True
            Else
                Me.nudPolos.Visible = False
                Me.Label30.Visible = False
                Me.chkBind.Visible = False
                Me.tmbBinding.Visible = False
                Me.cmbBinding.Visible = False
                Me.cmbBindSide.Visible = False
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

            Me.tstxtCostUnit.Text = ""
            Me.tstxtItog.Text = ""
        End If
    End Sub
#End Region

#Region " Расчет "
    Private Sub tsbtnCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCost.Click
        If Me.tmbMatTypes.SelectedIndex = -1 Then MsgBox("Не выбрана продукция.", MsgBoxStyle.Critical, appName) : Me.tmbMatTypes.Focus() : Exit Sub
        If Me.cmbColor.Text = "" Then MsgBox("Введи красочность продукции.", MsgBoxStyle.Critical, appName) : Me.cmbColor.Focus() : Exit Sub
        If Me.cmbMat.SelectedIndex = -1 Then MsgBox("Не выбран материал.", MsgBoxStyle.Critical, appName) : Me.cmbMat.Focus() : Exit Sub
        If Me.txtX.Text = "" Or Me.txtY.Text = "" Then MsgBox("Введи размер.", MsgBoxStyle.Critical, appName) : Me.cmbFormat.Focus() : Exit Sub
        If Not IsNumeric(Me.txtX.Text) Then MsgBox("Не корректное значение размера.", MsgBoxStyle.Critical, appName) : Me.txtX.Focus() : Exit Sub
        If Not IsNumeric(Me.txtY.Text) Then MsgBox("Не корректное значение размера.", MsgBoxStyle.Critical, appName) : Me.txtY.Focus() : Exit Sub

        Dim tirag%
        Dim k As Decimal
        Dim zakupMat@ 'стоимость материала 
        Dim naliste, nl1, nl2 As Integer ' на листе
        Dim sheetsPrint%
        Dim costPlotCut@ = 0

        prim = ""
        nl2 = 0

        parametr = CStr(Me.txtX.Text) + "x" + CStr(Me.txtY.Text)


        If Me.tmbMatTypes.SelectedItem(2) <> 1 Then 'брошюруем
            If Me.cmbBindSide.SelectedIndex = -1 Then MsgBox("Не выбрана сторона брошюровки.", MsgBoxStyle.Critical, appName) : Me.tmbMatTypes.Focus() : Exit Sub

            If Me.cmbBindSide.SelectedIndex = 0 Then 'по кроткой
                If Val(Me.txtX.Text) > Val(Me.txtY.Text) Then
                    nl1 = (x1 \ 2 * (Val(Me.txtX.Text) + Me.nudVylet.Value)) * (y1 \ (Val(Me.txtY.Text) + Me.nudVylet.Value))
                    nl2 = (x1 \ (Val(Me.txtY.Text) + Me.nudVylet.Value)) * (y1 \ 2 * (Val(Me.txtX.Text) + Me.nudVylet.Value))
                Else
                    nl1 = (x1 \ (Val(Me.txtX.Text) + Me.nudVylet.Value)) * (y1 \ 2 * (Val(Me.txtY.Text) + Me.nudVylet.Value))
                    nl2 = (x1 \ 2 * (Val(Me.txtY.Text) + Me.nudVylet.Value)) * (y1 \ (Val(Me.txtX.Text) + Me.nudVylet.Value))
                End If
            Else
                nl1 = (x1 \ (Val(Me.txtX.Text) + Me.nudVylet.Value)) * (y1 \ (Val(Me.txtY.Text) + Me.nudVylet.Value))
                nl2 = (x1 \ (Val(Me.txtY.Text) + Me.nudVylet.Value)) * (y1 \ (Val(Me.txtX.Text) + Me.nudVylet.Value))
            End If
        Else
            nl1 = (x1 \ (Val(Me.txtX.Text) + Me.nudVylet.Value)) * (y1 \ (Val(Me.txtY.Text) + Me.nudVylet.Value))
            nl2 = (x1 \ (Val(Me.txtY.Text) + Me.nudVylet.Value)) * (y1 \ (Val(Me.txtX.Text) + Me.nudVylet.Value))
        End If

        If nl1 = 0 And nl2 = 0 Then MsgBox("На выбраном материале нет места такого размера.", MsgBoxStyle.Critical, appName) : Exit Sub
        If nl1 > nl2 Then naliste = nl1 Else naliste = nl2

        Select Case naliste
            Case Is >= 24 : sumnac = nacMF3 + nacMat + nacFormat
            Case Is > 15 : sumnac = nacMF2 + nacMat + nacFormat
            Case Is > 9 : sumnac = nacMF1 + nacMat + nacFormat
            Case Is > 4 : sumnac = nacMF + nacMat + nacFormat
            Case Else : sumnac = nacMat + nacFormat
        End Select

        tirag = Me.nudTirag.Value
        discont = -Val(Me.tscmbSkidka.Text) + sumnac

        If formatInOut = 0 Then MsgBox("Не задано соотношение форматов.", MsgBoxStyle.Critical, appName) : Exit Sub
        sheets = RoundUp(RoundUp(tirag / naliste * Me.nudPolos.Value / 2) / formatInOut) 'количество покупных листов
        sheetsPrint = RoundUp(tirag / naliste * Me.nudPolos.Value / 2) 'количество печатных листов

        k = (100 + -Val(Me.tscmbSkidka.Text) + sumnac) / 100 'скидка
        costMat = CenaLista * sheets 'стоимость материала
        zakupMat = zakupList * sheets

        Dim minPrint@ = Module1.NonQuery1Scalar("SELECT [dbo].[costTechOperCMBmin] (" & sheetsPrint & ",'" & calcID & "','" & Me.cmbColor.Tag & "'," & Me.cmbColor.SelectedItem(0) & "," & serviceID & ", 1," & Me.nudTirag.Value & "," & discont & ")")

        Me.Label18.Text = Format(minPrint, "C")

        costPrint = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & sheetsPrint & ",'" & calcID & "','" & Me.cmbColor.Tag & "'," & Me.cmbColor.SelectedItem(0) & "," & serviceID & ",1," & Me.nudTirag.Value & "," & discont & ")")
        costPlotCut = 0


        If Me.chkLam.Checked = True Then 'РАСЧЕТ ЛАМИНИРОВАНИЯ
            If Me.cmbMatLam.SelectedIndex <> -1 Then

                matLamCount = RoundUp(sheetsPrint * 0.5)

                'пересчитать печатные листы в погонные метры
                costLam = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(matLamCount, ",", ".") & ",'" & calcID & "','" & Me.cmbSideLam.Tag & "'," & Me.cmbSideLam.SelectedItem(0) & "," & serviceID & ",1," & Me.nudTirag.Value & "," & discont & ")")
                costLam += (Me.cmbSideLam.SelectedIndex + 1) * matLamCount * Module1.NonQuery1Scalar("SELECT TOP 1 priceOut FROM SkladAccountingUnits WHERE matID=" & Me.cmbMatLam.SelectedItem(0) & " ")
            Else
                MsgBox("Не выбрана ламинация.", MsgBoxStyle.Critical, appName) : Exit Sub
            End If
        Else
            costLam = 0
        End If

        If Me.chkBind.Checked = True Then 'РАСЧЕТ БРОШЮРОВКИ
            If Me.cmbBinding.SelectedIndex <> -1 Then
                matLamCount = RoundUp(sheetsPrint * 0.5)
                'пересчитать печатные листы в погонные метры
                costBind = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & sheetsPrint & ",'" & calcID & "','" & Me.tmbBinding.Tag & "'," & Me.tmbBinding.SelectedItem(0) & "," & serviceID & ",1," & Me.nudTirag.Value & "," & discont & ")")
                costBind += Me.nudTirag.Value * Module1.NonQuery1Scalar("SELECT TOP 1 priceOut FROM SkladAccountingUnits WHERE matID=" & Me.cmbBinding.SelectedItem(0) & "")
            Else
                MsgBox("Не выбрана брошюровка.", MsgBoxStyle.Critical, appName) : Exit Sub
            End If

        Else
            costBind = 0
        End If


        Dim signFerst As Boolean = True
        Dim strOper$ = ""

        For Each itemChecked As Object In Me.clbOper.CheckedItems
            If signFerst = False Then
                strOper += "," + itemChecked.item(0).ToString
                prim += "," + itemChecked.item(1).ToString
            Else
                strOper = itemChecked.item(0).ToString
                prim += itemChecked.item(1).ToString
                signFerst = False
            End If
        Next

        Dim costPPOmin@

        If signFerst = False Then
            costPPO = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCLB] (" & sheetsPrint & ",'" & strOper & "',1," & Me.nudTirag.Value & "," & discont & ")")
            costPPOmin = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCLBmin] (" & sheetsPrint & ",'" & strOper & "',1," & Me.nudTirag.Value & "," & discont & ")")
        Else
            costPPO = 0
            costPPOmin = 0
        End If

        'Расчет итога
        itogCostPMP = RoundUp((costPrint + costMat + costPPO + costLam + costPlotCut) / Me.nudTirag.Value * 100) / 100 * Me.nudTirag.Value
        itogCostL = RoundUp(costLam / Me.nudTirag.Value * 100) / 100 * Me.nudTirag.Value


        itogCostB = RoundUp(costBind / Me.nudTirag.Value * 100) / 100 * Me.nudTirag.Value

        Me.tstxtItog.Text = itogCostPMP + itogCostB + itogCostL  'Format(newCost, "0.00")
        Me.tstxtCostUnit.Text = (itogCostPMP + itogCostB + itogCostL) / Me.nudTirag.Value

        Me.tsbtnOK.Enabled = True

        Me.Label17.Text = CStr(x1) + " x " + CStr(y1) + ", " + CStr(Format(CenaLista, "C"))
        Me.Label69.Text = CStr(naliste)
        Me.Label74.Text = CStr(sheets)
        Me.Label19.Text = CStr(sheetsPrint)
        Me.Label20.Text = CStr(costPPOmin)

        Me.lblPPOall.Text = Format(costPPO, "C")
        Me.Label61.Text = Format(costPrint, "C")
        Me.Label72.Text = Format(costPrint / sheetsPrint, "0.0000") ' цена печати листа
        Me.Label62.Text = Format(costMat, "C") 'цена материала
        Me.lblFerstCostMat.Text = Format(zakupMat, "C")  'стоимость закупкиматериала
        Me.Label26.Text = Format(zakupMat, "C")  'стоимость закупкиматериала
        '  Me.Label3.Text = CStr(Val(Me.tstxtItog.Text) - Val(Me.lblFerstCostPrint.Text) - Val(Me.lblFerstCostMat.Text))  '0 CStr(sumnac + Val(tstxtNac.Text) - Val(tscmbSkidka.Text)) + "%"
        ' Me.Label24.Text = CStr(Format(costLam, "C")) 
        Me.Label24.Text = Format(costLam, "C") 'цена Ламинирование
        Me.Label28.Text = CStr(Format(costPPOmin + zakupMat * 1.1 + minPrint, "C")) ' общая мин цена

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_CalcOper777]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@Quantity", SqlDbType.Decimal))
        cmd.Parameters("@Quantity").Value = sheetsPrint

        cmd.Parameters.Add(New SqlClient.SqlParameter("@QuantityFiles", SqlDbType.Int))
        cmd.Parameters("@QuantityFiles").Value = 1

        cmd.Parameters.Add(New SqlClient.SqlParameter("@TotalСirc", SqlDbType.Int))
        cmd.Parameters("@TotalСirc").Value = Me.nudTirag.Value

        cmd.Parameters.Add(New SqlClient.SqlParameter("@Discont", SqlDbType.Int))
        cmd.Parameters("@Discont").Value = discont

        cmd.Parameters.Add(New SqlClient.SqlParameter("@OperStr", SqlDbType.VarChar))
        cmd.Parameters("@OperStr").Value = strOper

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtPay As New DataTable : objDA.Fill(dtPay)

        Me.dgDataTable.DataSource = dtPay

        Exit Sub
err:
        MsgBox("Если ошибка повториться обратитесь к разработчику.", MsgBoxStyle.Critical, appName)
    End Sub

#End Region

#Region " Выбор формата "
    Private Sub cmbFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormat.SelectedIndexChanged
        Dim X() As Decimal = {297, 297, 148, 148, 74, 220, 324, 229}
        Dim Y() As Decimal = {420, 210, 210, 105, 105, 110, 229, 162}

        Me.txtX.Text = X(Me.cmbFormat.SelectedIndex)
        Me.txtY.Text = Y(Me.cmbFormat.SelectedIndex)

    End Sub
#End Region

#Region " Читаем ини файл "
    Private Sub ReadIni()
        Try
            Dim odaMatList As New SqlClient.SqlDataAdapter("SELECT ParamName, ParamValue FROM PriceServices WHERE Section = 'Digital'", mcnnInt)
            Dim dtPrice As New DataTable : odaMatList.Fill(dtPrice)
            Dim dtWorkPrice As New DataTable

            dtWorkPrice.Columns.Add("Param", GetType(String))
            dtWorkPrice.Columns.Add("Value", GetType(Decimal))
            dtWorkPrice.Columns("Param").Unique = True
            dtWorkPrice.PrimaryKey = New DataColumn() {dtWorkPrice.Columns("Param")}

            For Each dr As DataRow In dtPrice.Rows
                dtWorkPrice.Rows.Add(New Object() {dr("ParamName"), dr("ParamValue")})
            Next

            nacMF = dtWorkPrice.Rows.Find("NacCifra")("Value")
            vyletCifra = dtWorkPrice.Rows.Find("CifraVylet")("Value")
            '   vyletOfset = dtWorkPrice.Rows.Find("OfsetVylet")("Value")
            nacMF1 = dtWorkPrice.Rows.Find("NacCifra1")("Value")
            nacMF2 = dtWorkPrice.Rows.Find("NacCifra2")("Value")
            nacMF3 = dtWorkPrice.Rows.Find("NacCifra3")("Value")
        Catch oexpData As System.Exception
            MsgBox("readini-" & oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " Добавляем строку к заказу "
    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        If costID = Nothing Then
            If MsgBox(Prompt:="Сохранить в буфер? ", Buttons:=vbYesNo, Title:=appName) = vbYes Then
                Me.Close()
            End If
        Else
            If MessageBox.Show("Добавить расчет к заказу", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                colorStr = Trim(Me.cmbColor.Text)

                If Not IsNumeric(Me.tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub

                Dim number$ = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString
                Dim nameProd$ = Me.tmbMatTypes.Text '+ ", формат " + Me.txtX.Text + "x" + Me.txtY.Text + ", " + Me.cmbColor.Text

                Dim orderIDforTech% = InsertToOrders(nameProd, Me.cmbMat.SelectedValue, sheets, CDec(itogCostPMP), Me.cmbColor.Text, parametr, number, CDec(itogCostPMP / Me.nudTirag.Value), SkladAccUnit, prim) 'Пишем спецификацию
                '*********Технологические операции
                Dim techCost@

                techCost = InsertTechOper(calcID, Me.cmbColor.Tag, Me.cmbColor.SelectedValue, sheets, orderIDforTech)
                'в цикле пройти контролы цветности, ламинирование, брошюровку
                ' techCost = InsertTechOper(55, Me.cmbColor.Tag, Me.cmbColor.SelectedValue, sheets, orderIDforTech)

                '***********************************

                Dim nextRow As String = ".1"

                If Me.chkLam.Checked = True Then
                    colorStr = ""
                    orderIDforTech = InsertToOrders((Me.chkLam.Text + Me.cmbSideLam.Text), Me.cmbMatLam.SelectedValue, sheets / 2, CDec(costLam), Me.cmbTypesPlenka.Text, parametr, (number + nextRow), CDec(costLam / Me.nudTirag.Value), 1, "") 'Пишем спецификацию
                    '*********Технологические операции
                    techCost += InsertTechOper(calcID, Me.cmbSideLam.Tag, 1, sheets, orderIDforTech)
                    Me.chkLam.Checked = False
                End If

                For Each itemChecked As Object In Me.clbOper.CheckedItems
                    'пишем непосредственно на основе тех операций загруж в клблист
                    techCost += InsertTechOperF(itemChecked.item(0), sheets, orderIDforTech) ' [dbo].[sp_TechOperOrderInsF]
                Next
                '***********************************
                If Me.chkBind.Checked = True = True Then
                    colorStr = ""
                    If Me.chkLam.Checked = True Then
                        nextRow = ".2"
                    Else
                        nextRow = ".1"
                    End If

                    orderIDforTech = InsertToOrders(Me.tmbBinding.Text, Me.cmbBinding.SelectedValue, sheets, CDec(costBind), Me.tmbBinding.Text, parametr, (number + nextRow), CDec(costBind / Me.nudTirag.Value), Me.cmbPrintFormat.SelectedItem(0), "") 'Пишем спецификацию
                    '*********Технологические операции
                    techCost += InsertTechOper(calcID, Me.tmbBinding.Tag, 1, Me.nudTirag.Value, orderIDforTech)

                    Me.chkBind.Checked = False
                End If

                For Each itemChecked As Object In Me.clbOper.CheckedItems
                    'пишем непосредственно на основе тех операций загруж в клблист
                    techCost += InsertTechOperF(itemChecked.item(0), Me.nudTirag.Value, orderIDforTech) ' [dbo].[sp_TechOperOrderInsF]
                Next


                Me.tsbtnOK.Enabled = False
                Me.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Function InsertToOrders(ByVal strName As String, matID As Integer, matCount As Integer, cost As Decimal, tech As String, sizeXY As String, num As String, costUnit As Decimal, AccUnit As Integer, strPrim As String) As Integer
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_CalcToOrders"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@serviceID", SqlDbType.Int))
            cmd.Parameters("@serviceID").Value = serviceID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@cost", SqlDbType.Decimal))
            cmd.Parameters("@cost").Value = cost 'Replace(CStr(cost), ",", ".")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@prim", SqlDbType.NVarChar))
            cmd.Parameters("@prim").Value = strPrim

            If matID = 0 Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Module1.NonQuery1Scalar("SELECT matID From materials where matzak=1")
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = matID
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@data", SqlDbType.DateTime))
            cmd.Parameters("@data").Value = Now()

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sostav", SqlDbType.NVarChar))
            cmd.Parameters("@sostav").Value = colorStr

            cmd.Parameters.Add(New SqlClient.SqlParameter("@edIzm", SqlDbType.Int))
            cmd.Parameters("@edIzm").Value = AccUnit

            cmd.Parameters.Add(New SqlClient.SqlParameter("@technology", SqlDbType.NVarChar))
            cmd.Parameters("@technology").Value = "Цифровая печать"

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costUnit", SqlDbType.Decimal))
            cmd.Parameters("@costUnit").Value = costUnit 'Replace(CStr(costUnit), ",", ".")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeCut", SqlDbType.NVarChar))
            cmd.Parameters("@sizeCut").Value = Me.txtX.Text & "x" & Me.txtY.Text + " мм"

            cmd.Parameters.Add(New SqlClient.SqlParameter("@kolvo", SqlDbType.Int))
            cmd.Parameters("@kolvo").Value = Me.nudTirag.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@matCount", SqlDbType.Int))
            cmd.Parameters("@matCount").Value = matCount

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nameForDoc", SqlDbType.NVarChar))
            cmd.Parameters("@nameForDoc").Value = strName

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nomer", SqlDbType.NVarChar))
            cmd.Parameters("@nomer").Value = num

            mcnnInt.Open()

            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Function InsertTechOper(calcID As Integer, controlTag As String, controlItem0 As Integer, quantity As Integer, orderIDforTech As Integer) As Integer
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_TechOperOrderIns"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@calcID", SqlDbType.Int))
            cmd.Parameters("@calcID").Value = calcID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@controlTag", SqlDbType.NVarChar))
            cmd.Parameters("@controlTag").Value = controlTag

            cmd.Parameters.Add(New SqlClient.SqlParameter("@controlItem0", SqlDbType.Int))
            cmd.Parameters("@controlItem0").Value = controlItem0

            cmd.Parameters.Add(New SqlClient.SqlParameter("@quantity", SqlDbType.Int))
            cmd.Parameters("@quantity").Value = quantity

            cmd.Parameters.Add(New SqlClient.SqlParameter("@orderID", SqlDbType.Int))
            cmd.Parameters("@orderID").Value = orderIDforTech

            mcnnInt.Open()

            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Function InsertTechOperF(controlOperID As Integer, quantity As Integer, orderIDforTech As Integer) As Integer
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_TechOperOrderInsF"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
            cmd.Parameters("@operID").Value = controlOperID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@quantity", SqlDbType.Int))
            cmd.Parameters("@quantity").Value = quantity

            cmd.Parameters.Add(New SqlClient.SqlParameter("@orderID", SqlDbType.Int))
            cmd.Parameters("@orderID").Value = orderIDforTech

            mcnnInt.Open()

            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function
#End Region

    Private Sub tsbtnToOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnToOrder.Click
        Me.tstxtItog.Clear()
        Me.cmbMat.SelectedIndex = -1
        Me.tscmbSkidka.SelectedIndex = 0
        Me.Label72.Text = ""
        Me.Label69.Text = ""
        Me.Label74.Text = ""
        Me.Label62.Text = ""
        Me.Label61.Text = ""
        Me.Label3.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnPodrobno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnPodrobno.Click
        Me.tlpDetail.Visible = Me.tsbtnPodrobno.Checked
    End Sub

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsConfigMat.SourceControl)

        LoadTypesMat()
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

    Private Sub cmbColor_TextChanged(sender As Object, e As System.EventArgs) Handles cmbColor.TextChanged
        Me.tstxtItog.Text = ""
    End Sub

#Region " Выбираем материал "
    Dim dtMatFormats As DataTable


    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbMat.SelectedValueChanged
        If Me.cmbMat.SelectedIndex <> -1 Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_MatPrintFormat]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
            cmd.Parameters("@matID").Value = Me.cmbMat.SelectedItem(0)

            Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
            dtMatFormats = New DataTable : odaMan.Fill(dtMatFormats)

            Me.cmbPrintFormat.DataSource = dtMatFormats 'Связать данные со списком
            Me.cmbPrintFormat.DisplayMember = "formatName"
            Me.cmbPrintFormat.ValueMember = "ID"
        End If

    End Sub
#End Region

#Region " Определяем печатные параметры "
    Private Sub cmbSelPar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Select Case Me.cmbSelPar.SelectedIndex
        '    Case Is = 0
        Me.nudNaformate.ResetText()
        Me.txtX.ResetText()
        Me.txtY.ResetText()
        Me.nudNaformate.Visible() = False : Me.nudNaformate.TabStop = False
        Me.cmbFormat.Visible() = True : Me.cmbFormat.TabStop = True
        Me.txtX.Visible() = False : Me.txtX.TabStop = False
        Me.txtY.Visible() = False : Me.txtY.TabStop = False
        Me.cmbFormat.SelectedIndex = 0
        Me.lblVylet.Text = "Вылет (мм), формат"
        Me.lblVylet.Visible = True

        Me.nudVylet.Visible = True

        '    Case Is = 1
        '        Me.txtX.ResetText()
        '        Me.txtY.ResetText()
        '        Me.nudNaformate.Visible() = True : Me.nudNaformate.TabStop = True
        '        Me.cmbFormat.Visible() = False : Me.cmbFormat.TabStop = False
        '        Me.txtX.Visible() = False : Me.txtX.TabStop = False
        '        Me.txtY.Visible() = False : Me.txtY.TabStop = False
        '        Me.lblVylet.Visible = False

        '        Me.nudVylet.Visible = False

        '    Case Is = 2
        '        '  Me.txtX.Text = "Ширина"
        '        ' Me.txtY.Text = "Высота"
        '        Me.nudNaformate.ResetText()
        '        Me.nudNaformate.Visible() = False : Me.nudNaformate.TabStop = False
        '        Me.cmbFormat.Visible() = False : Me.cmbFormat.TabStop = False
        '        Me.txtX.Visible() = True : Me.txtX.TabStop = True
        '        Me.txtY.Visible() = True : Me.txtY.TabStop = True
        '        Me.lblVylet.Text = "Вылет, размер (мм)"
        '        Me.lblVylet.Visible = True

        '        Me.nudVylet.Visible = True

        'End Select
    End Sub
#End Region

    Private Sub chkLam_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkLam.CheckedChanged
        For Each c As Control In Me.tlpParamForCost.Controls
            If c.Tag = "lam" Then 'ВНИМАНИЕ смотри тип элемента
                c.Visible = sender.checked
            End If
        Next

        Try
            Me.cmbSideLam.SelectedIndex = 1
        Catch ex As System.Exception

        End Try

    End Sub

    Private Sub chkLam_VisibleChanged(sender As Object, e As System.EventArgs) Handles chkLam.VisibleChanged
        If Me.chkLam.Visible = False Then
            Me.chkLam.Checked = False
        End If
    End Sub

    Private Sub chkVylet_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Me.nudVylet.Visible = sender.checked
    End Sub

    Private Sub chkVylet_VisibleChanged(sender As Object, e As System.EventArgs)
        Me.nudVylet.Visible = False
        Me.nudVylet.Value = 0
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        'If Me.tmbMatTypes.SelectedIndex = -1 Then
        'Else
        Module1.ConfigTechOper(Me.cmsConfigTech.SourceControl, calcID)
        'End If
    End Sub

    Private Sub txtProdFind_TextChanged(sender As Object, e As EventArgs) Handles txtProdFind.TextChanged
        FindProd(sender.text)
    End Sub

    Private Sub FindProd(ByVal strFind As String)
        Dim strSQL$ = Nothing

        If strFind = """" Or strFind = "'" Then
            Exit Sub
        Else
            Try
                strSQL = "SELECT ID, Name, typeProdID FROM awc_Polygraph WHERE Name LIKE '%" & strFind & "%' AND serviceID=" & serviceID & ""

                Dim odaProd As New SqlClient.SqlDataAdapter(strSQL, mcnnInt) 'не сортировать иначе не получим посл добавленного заказчика
                Dim dtProd As New DataTable : odaProd.Fill(dtProd)


                If dtProd.Rows.Count = 0 Then
                    Me.tmbMatTypes.SelectedIndex = -1
                    allowSelectProd = False
                    Exit Sub
                Else
                    Me.tmbMatTypes.DataSource = dtProd 'Связать данные со списком
                    Me.tmbMatTypes.DisplayMember = "Name"
                    Me.tmbMatTypes.ValueMember = "ID"

                    allowSelectProd = True
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
        End If
    End Sub

#Region " Загрузка операций "
    Private Sub LoadOper()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, name FROM tech_Operations WHERE ID IN (SELECT techOperID FROM tech_OperControlTag WHERE controlItem0 = " & Me.tmbMatTypes.SelectedItem(0) & " AND controlTag = 'ppo' AND serviceID = " & serviceID & ") order by name ", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbOper.DataSource = dtNacenki
            Me.clbOper.DisplayMember = "name"
            Me.clbOper.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub cmbSideLam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSideLam.SelectedIndexChanged
        Me.tstxtCostUnit.Text = ""
        Me.tstxtItog.Text = ""
    End Sub

    Private Sub cmbMatLam_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMatLam.SelectedValueChanged
        Me.tstxtCostUnit.Text = ""
        Me.tstxtItog.Text = ""
    End Sub

    Private Sub clbOper_SelectedValueChanged(sender As Object, e As EventArgs) Handles clbOper.SelectedValueChanged
        Me.tstxtCostUnit.Text = ""
        Me.tstxtItog.Text = ""
    End Sub

    Private Sub ДобавитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьПродуктToolStripMenuItem.Click
        formTagNewProd = calcID

        ModCallForm.CallForm("Продукт", 42, 3)

        FindProd("")

        ' Me.tmbMatTypes.SelectedIndex = Me.tmbMatTypes.Items.Count - 1

        ' ConfigCalc(cmsConfigMat.SourceControl)
    End Sub

    Private Sub УдалитьПродуктToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles УдалитьПродуктToolStripMenuItem1.Click
        Select Case MsgBox(Prompt:="Удалить  " & Trim(Me.tmbMatTypes.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM awc_Polygraph WHERE ID=" & Me.tmbMatTypes.SelectedItem(0) & "")

                FindProd("")

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
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID=" & sender.SelectedItem(0) & " AND accessible=1 order by matName", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMatLam.DataSource = dtMat1 'Связать данные со списком
                Me.cmbMatLam.DisplayMember = "matName"
                Me.cmbMatLam.ValueMember = "matID"
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub nudTirag_GotFocus(sender As Object, e As EventArgs) Handles nudTirag.GotFocus
        Me.nudTirag.Select(0, (Len(Me.nudTirag.Value.ToString)))
    End Sub

    Private Sub nudTirag_MouseClick(sender As Object, e As MouseEventArgs) Handles nudTirag.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudNaformate_MouseClick(sender As Object, e As MouseEventArgs) Handles nudNaformate.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub chkBinding_CheckedChanged(sender As Object, e As EventArgs) Handles chkBind.CheckedChanged
        For Each c As Control In tlpParamForCost.Controls
            If c.Tag = "bind" Then 'ВНИМАНИЕ смотри тип элемента
                c.Visible = sender.checked
            End If
        Next
    End Sub

    Private Sub tmbBinding_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmbBinding.SelectedValueChanged
        If Me.chkBind.Checked = True Then
            Dim strTypeMatID$ = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.tmbBinding.SelectedItem(1) & "'")

            If strTypeMatID = Nothing Then
                MsgBox("Не сконфигурирован материал для брошюровки.", MsgBoxStyle.Critical, appName)
                Me.cmbBinding.DataSource = Nothing
                Me.cmbBinding.Focus()
                Exit Sub
            Else
                Dim odaBind As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials where typeID IN (" & strTypeMatID & ") order by matName", mcnnInt)
                Dim dtBind As New DataTable : odaBind.Fill(dtBind)

                Me.cmbBinding.DataSource = dtBind 'Связать данные со списком
                Me.cmbBinding.DisplayMember = "matName"
                Me.cmbBinding.ValueMember = "matID"

                '  Me.tstxtCostUnit.Text = ""
                '  Me.tstxtItog.Text = ""
            End If
        End If
    End Sub

    Private Sub nudPolos_GotFocus(sender As Object, e As EventArgs) Handles nudPolos.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudPolos_MouseClick(sender As Object, e As MouseEventArgs) Handles nudPolos.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudPolos_VisibleChanged(sender As Object, e As EventArgs) Handles nudPolos.VisibleChanged
        Me.chkBind.Checked = sender.visible

        If sender.visible = False Then
            sender.value = 2
        End If
    End Sub

    Private Sub chkplotCut_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkplotCut.CheckedChanged
        Me.nudVylet.Visible = sender.checked
        Me.Label31.Visible = sender.checked
        Me.cmbPlotCut.Visible = sender.checked
        Me.cmbMatTypes.SelectedIndex = -1
    End Sub

    Private Sub cmbPrintFormat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPrintFormat.SelectedValueChanged
        Try
            If Me.cmbPrintFormat.SelectedIndex <> -1 Then
                Dim mdrMat As DataRow = dtMatFormats.Rows(Me.cmbPrintFormat.SelectedIndex) ' mdsMat.Tables("Materials").Rows(Me.cmbPrintFormat.SelectedIndex)

                CenaLista = mdrMat("priceOut")
                zakupList = mdrMat("costBay")
                x1 = mdrMat("sizeX")
                y1 = mdrMat("sizeY")

                totalDimX = mdrMat("totalDimX")
                totalDimY = mdrMat("totalDimY")

                nacMat = mdrMat("nacenka")
                nacFormat = mdrMat("nacFormat")

                formatInOut = mdrMat("kolvo")
                SkladAccUnit = mdrMat("unitID")

                If formatInOut = 0 Then
                    Me.Label17.Text = "Не задано соотношение форматов."
                Else
                    Me.Label17.Text = CStr(x1) + " x " + CStr(y1) + " мм" + ", Цена листа: " + CStr(Format(CenaLista, "C")) ' Me.txtX1.Text = x1 : Me.txtY1.Text = y1
                End If

                Me.Label17.Text = CStr(x1) + " x " + CStr(y1) + " мм" + ", Цена листа: " + CStr(Format(CenaLista, "C")) ' Me.txtX1.Text = x1 : Me.txtY1.Text = y1

            Else
                CenaLista = Format(0, "C")
                zakupList = Format(0, "C")
                x1 = 0
                y1 = 0
                nacMat = 0
                Me.Label17.Text = ""
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

End Class