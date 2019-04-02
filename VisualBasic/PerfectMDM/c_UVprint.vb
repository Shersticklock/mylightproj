Public Class c_UVprint
    Dim colorStr$, prim$, techStr$

    Dim x1, y1, sheets As Integer
    Dim CenaLista@, zakupList@, nacMat@
    Dim nacFormat% = 0
    Dim formatInOut@
    Dim discont As Integer
    Dim naliste, nl1, nl2 As Integer ' на листе

    Private Sub mdm_UVprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim odaTech As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE calcID=" & CInt(Me.Tag) & " AND controlTag='" & Me.cmbTech.Tag & "'", mcnnInt)
        Dim dtTech As New DataTable : odaTech.Fill(dtTech)
        Me.cmbTech.DataSource = dtTech 'Связать данные со списком
        Me.cmbTech.DisplayMember = "nameTech"
        Me.cmbTech.ValueMember = "ID"

        Dim odaTech1 As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE calcID=" & CInt(Me.Tag) & " AND controlTag='" & Me.cmbTech1.Tag & "'", mcnnInt)
        Dim dtTech1 As New DataTable : odaTech1.Fill(dtTech1)
        Me.cmbTech1.DataSource = dtTech1 'Связать данные со списком
        Me.cmbTech1.DisplayMember = "nameTech"
        Me.cmbTech1.ValueMember = "ID"

        'Читаем наименования срочности
        Dim odaSrok As New SqlClient.SqlDataAdapter("SELECT nac, Name FROM unicalcSrokNac", mcnnInt)
        Dim dtSrok As New DataTable : odaSrok.Fill(dtSrok)

        Me.cmbSrok.DataSource = dtSrok
        Me.cmbSrok.DisplayMember = "Name"
        Me.cmbSrok.ValueMember = "nac"
        Me.cmbSrok.SelectedIndex = 0

        Dim odaProd As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM awc_Polygraph WHERE serviceID=" & serviceID & " order by Name", mcnnInt)
        Dim dtProd As New DataTable : odaProd.Fill(dtProd)
        Me.tmbMatTypes.DataSource = dtProd 'Связать данные со списком
        Me.tmbMatTypes.DisplayMember = "Name"
        Me.tmbMatTypes.ValueMember = "ID"

        Me.cmbFillLico.SelectedIndex = 0
        Me.cmbFillOborot.SelectedIndex = 0
    End Sub

    Private Sub cmbTypeMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMatTypes.SelectedValueChanged
        Try
            If sender.SelectedIndex <> -1 Then
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID=" & sender.SelectedItem(0) & " AND accessible = 1 order by matName", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMat.DataSource = dtMat1 'Связать данные со списком
                Me.cmbMat.DisplayMember = "matName"
                Me.cmbMat.ValueMember = "matID"
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub tsbtnCost_Click(sender As Object, e As EventArgs) Handles tsbtnCost.Click
        If Me.tmbMatTypes.SelectedIndex = -1 Then MsgBox("Не выбран продукт.", MsgBoxStyle.Critical, appName) : Me.tmbMatTypes.Focus() : Exit Sub
        If Me.cmbTech.SelectedIndex = -1 Then MsgBox("Не выбрана красочность лица", MsgBoxStyle.Critical, appName) : Me.cmbTech.Focus() : Exit Sub
        If Me.cmbFillLico.SelectedIndex = -1 Then MsgBox("Не выбран % заливки лица", MsgBoxStyle.Critical, appName) : Me.cmbFillLico.Focus() : Exit Sub
        If Me.cmbTech1.SelectedIndex = -1 Then MsgBox("Не выбрана красочность оборота", MsgBoxStyle.Critical, appName) : Me.cmbTech1.Focus() : Exit Sub
        If Me.cmbFillOborot.SelectedIndex = -1 Then MsgBox("Не выбран % заливки оборота", MsgBoxStyle.Critical, appName) : Me.cmbFillOborot.Focus() : Exit Sub
        If Me.cmbMat.SelectedIndex = -1 Then MsgBox("Не выбран материал", MsgBoxStyle.Critical, appName) : Me.cmbMat.Focus() : Exit Sub

        Try
            Dim costPrint@
            Dim costMat As Decimal
            Dim k_skidka@ = (100 - Val(Me.tscmbSkidka.Text)) / 100 'скидка
            '   Dim sUVprint As Decimal

            'Select Case idConfig
            '    Case Is = 111 ' флай
            '        costMat = Me.nudKolvo.Value * CenaLista

            '        sUVprint = Me.nudKolvo.Value * Val(Me.txtX.Text) * Val(Me.txtY.Text) / 1000000 * Val(Me.cmbFillLico.Text) / 100 * Me.nudProhodLico.Value

            '        If Me.cmbTech1.SelectedIndex <> 0 Then
            '            sUVprint += Me.nudKolvo.Value * Val(Me.txtX.Text) * Val(Me.txtY.Text) / 1000000 * Val(Me.cmbFillOborot.Text) / 100 * Me.nudProhodOb.Value
            '        End If

            '        Dim techQuantity% = Me.nudKolvo.Value * (Me.nudProhodLico.Value + Me.nudProhodOb.Value)
            '        discont = 100 - Val(Me.cmbFillLico.Text)

            '        Dim costPrintFerst@ = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(sUVprint, ",", ".") & ", " & CInt(Me.Tag) & ", '" & Me.cmbTech.Tag & "', " & Me.cmbTech.SelectedItem(0) & ", " & serviceID & ", 1, " & techQuantity & ", " & discont & ")")
            '        Dim strOper$ = Nothing
            '        Dim signFerst As Boolean = True

            '        For Each itemChecked As Object In Me.clbOper.CheckedItems
            '            If signFerst = False Then
            '                strOper += "," + itemChecked.item(0).ToString
            '            Else
            '                strOper = itemChecked.item(0).ToString
            '                signFerst = False
            '            End If
            '        Next

            '        Dim costPPO@ = 0

            '        If signFerst = False Then
            '            costPPO = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCLB] (" & Replace(sUVprint, ",", ".") & ", '" & strOper & "', 1, " & Me.nudKolvo.Value & ", " & discont & ")")
            '        End If

            '    Case Is =  ' мдм
            nl1 = (x1 \ (Val(Me.txtX.Text) + 0)) * (y1 \ (Val(Me.txtY.Text) + 0))
            nl2 = (x1 \ (Val(Me.txtY.Text) + 0)) * (y1 \ (Val(Me.txtX.Text) + 0))

            If nl1 = 0 And nl2 = 0 Then MsgBox("На выбраном материале нет места такого размера.", MsgBoxStyle.Critical, appName) : Exit Sub
            If nl1 > nl2 Then naliste = nl1 Else naliste = nl2

            costMat = Me.nudKolvo.Value / naliste * CenaLista

            Dim costPrintFerst@ = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(Me.nudKolvo.Value / naliste, ",", ".") & "," & CInt(Me.Tag) & ",'" & Me.cmbTech.Tag & "'," & Me.cmbTech.SelectedItem(0) & "," & serviceID & ",1," & Me.nudKolvo.Value & "," & discont & ")")

            costPrint = costPrintFerst * Val(Me.cmbFillLico.Text) / 100 * Me.nudProhodLico.Value
            costPrint += costPrintFerst * Val(Me.cmbFillOborot.Text) / 100 * Me.nudProhodOb.Value

            Dim strOper$ = Nothing
            Dim signFerst As Boolean = True

            For Each itemChecked As Object In Me.clbOper.CheckedItems
                If signFerst = False Then
                    strOper += "," + itemChecked.item(0).ToString
                Else
                    strOper = itemChecked.item(0).ToString
                    signFerst = False
                End If
            Next

            Dim costPPO@ = 0

            If signFerst = False Then
                costPPO = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCLB] (" & Replace(Me.nudKolvo.Value / naliste, ",", ".") & ",'" & strOper & "',1," & Me.nudKolvo.Value & "," & discont & ")")
            End If


            'Расчет итога
            Dim newCost As Decimal = RoundUp((costPrint + costMat) / Me.nudKolvo.Value * 100) / 100 * Me.nudKolvo.Value * (100 - Val(Me.tscmbSkidka.Text)) / 100

            Me.tstxtItog.Text = newCost 'Format(newCost, "0.00")
            Me.tstxtCostUnit.Text = newCost / Me.nudKolvo.Value
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(cmsProd.SourceControl, CInt(Me.Tag))

        LoadOper()
    End Sub

#Region " Загрузка наценок "
    Private Sub LoadOper()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, name, (" & Me.nudKolvo.Value & " * KC + AC) as cost FROM tech_Operations WHERE ID IN (SELECT techOperID FROM tech_OperControlTag WHERE controlItem0 = " & Me.tmbMatTypes.SelectedItem(0) & " AND controlTag = 'UVprod' AND serviceID = " & serviceID & ") order by name ", mcnnInt)
            ' Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, nacName, nacValue FROM PriceNacenki WHERE groupID = " & Me.cmbPriceGroup.SelectedItem(0) & " ", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbOper.DataSource = dtNacenki
            Me.clbOper.DisplayMember = "name"
            Me.clbOper.ValueMember = "cost"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub cmbStandartSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStandartSize.SelectedIndexChanged
        Dim X() As Decimal = {297, 297, 148, 148, 74, 50, 55, 98}
        Dim Y() As Decimal = {420, 210, 210, 105, 105, 90, 85, 210}

        Me.txtX.Text = X(Me.cmbStandartSize.SelectedIndex)
        Me.txtY.Text = Y(Me.cmbStandartSize.SelectedIndex)
    End Sub

    Private Sub tsbtnOK_Click(sender As Object, e As EventArgs) Handles tsbtnOK.Click
        If costID = Nothing Then
            If MsgBox(Prompt:="Сохранить в буфер? ", Buttons:=vbYesNo, Title:=appName) = vbYes Then
                Me.Close()
            End If
        Else
            If MessageBox.Show("Добавить расчет к заказу", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                colorStr = Trim(Me.cmbFillLico.Text)

                '    MsgBox(Me.cmbPrintFormat.SelectedItem(0).ToString)

                If Not IsNumeric(Me.tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub

                Dim number$ = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString
                Dim nameProd$ = Me.tmbMatTypes.Text + ", " + Me.txtX.Text + "x" + Me.txtY.Text + ", " + Me.cmbTech.Text

                Dim orderIDforTech% = InsertToOrders(nameProd, Me.cmbMat.SelectedValue, Me.nudKolvo.Value, CDec(Me.tstxtItog.Text), Me.cmbTech.Text, "", number, CDec(Me.tstxtCostUnit.Text)) 'Пишем спецификацию
                '*********Технологические операции
                Dim techCost@

                techCost = InsertTechOper(CInt(Me.Tag), Me.cmbTech.Tag, Me.cmbTech.SelectedValue, Me.nudKolvo.Value, orderIDforTech)

                For Each itemChecked As Object In Me.clbOper.CheckedItems
                    'пишем непосредственно на основе тех операций загруж в клблист
                    techCost += InsertTechOperF(CInt(Me.Tag), Me.clbOper.Tag, 1, Me.nudKolvo.Value, orderIDforTech)
                Next

                Me.tsbtnOK.Enabled = False
                Me.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Function InsertToOrders(ByVal strName As String, matID As Integer, matCount As Decimal, cost As Decimal, tech As String, sizeXY As String, num As String, costUnit As Decimal) As Integer
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_CalcToOrders"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@serviceID", SqlDbType.Int))
            cmd.Parameters("@serviceID").Value = serviceID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@cost", SqlDbType.Decimal))
            cmd.Parameters("@cost").Value = cost

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@prim", SqlDbType.NVarChar))
            cmd.Parameters("@prim").Value = prim

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
            cmd.Parameters("@edIzm").Value = Me.cmbPrintFormat.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@technology", SqlDbType.NVarChar))
            cmd.Parameters("@technology").Value = "УФ печать"

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costUnit", SqlDbType.Decimal))
            cmd.Parameters("@costUnit").Value = Val(Me.tstxtCostUnit.Text)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeCut", SqlDbType.NVarChar))
            cmd.Parameters("@sizeCut").Value = Me.txtX.Text & "x" & Me.txtY.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@kolvo", SqlDbType.Int))
            cmd.Parameters("@kolvo").Value = Me.nudKolvo.Value

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

    Function InsertTechOperF(calcID As Integer, controlTag As String, controlItem0 As Integer, quantity As Integer, orderIDforTech As Integer) As Integer
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

    Private Sub КонфигураторToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КонфигураторToolStripMenuItem.Click
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

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub ДобавитьПродуктToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДобавитьПродуктToolStripMenuItem1.Click
        formTagNewProd = Me.Tag
        ModCallForm.CallForm("Продукт", 42, 3)
    End Sub


    Private Sub УдалитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьПродуктToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Удалить  " & Trim(Me.tmbMatTypes.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM awc_Polygraph WHERE ID=" & Me.tmbMatTypes.SelectedItem(0) & "")
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Dim dtMatFormats As DataTable

    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMat.SelectedValueChanged
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
        Me.cmbPrintFormat.ValueMember = "unitID"
    End Sub


    Private Sub cmbPrintFormat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPrintFormat.SelectedValueChanged
        Try
            If Me.cmbPrintFormat.SelectedIndex <> -1 Then
                Dim mdrMat As DataRow = dtMatFormats.Rows(Me.cmbPrintFormat.SelectedIndex) ' mdsMat.Tables("Materials").Rows(Me.cmbPrintFormat.SelectedIndex)

                CenaLista = mdrMat("priceOut")
                zakupList = mdrMat("costBay")
                x1 = mdrMat("sizeX")
                y1 = mdrMat("sizeY")
                nacMat = mdrMat("nacenka")
                nacFormat = mdrMat("nacFormat")
                formatInOut = mdrMat("kolvo")

                Me.Label17.Text = CStr(x1) + " x " + CStr(y1) + " мм" + ",  Цена листа: " + CStr(CenaLista) + " руб." ' Me.txtX1.Text = x1 : Me.txtY1.Text = y1
            Else
                CenaLista = Format(0, "C")
                zakupList = Format(0, "C")
                x1 = 0
                y1 = 0
                nacMat = 0
                Me.Label17.Text = ""
            End If
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub nudKolvo_MouseClick(sender As Object, e As MouseEventArgs) Handles nudKolvo.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudProhodLico_GotFocus(sender As Object, e As EventArgs) Handles nudProhodLico.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudProhodLico_MouseClick(sender As Object, e As MouseEventArgs) Handles nudProhodLico.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudProhodOb_GotFocus(sender As Object, e As EventArgs) Handles nudProhodOb.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudProhodOb_MouseClick(sender As Object, e As MouseEventArgs) Handles nudProhodOb.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Module1.ConfigTechOper(Me.cmsConfigTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub tmbTypeMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmbMatTypes.SelectedValueChanged
        LoadTypesMat()
        LoadOper()
    End Sub

    Private Sub LoadTypesMat()
        Dim list2 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.tmbMatTypes.Text & "'")

        If list2 = Nothing Then

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

    Private Sub nudKolvo_ValueChanged(sender As Object, e As EventArgs) Handles nudKolvo.ValueChanged
        Me.tscmbSkidka.ComboBox.DataSource = Nothing

        Try
            Dim odaDiscont As New SqlClient.SqlDataAdapter("SELECT awc_Discont.ID, awc_Discont.Name FROM awc_Discont INNER JOIN awc_DiscontServices ON awc_Discont.ID=awc_DiscontServices.discontID WHERE awc_DiscontServices.serviceID=" & serviceID & " AND quantity<=" & Me.nudKolvo.Value & " AND " & Me.nudKolvo.Value & "<=quantity2 order by awc_Discont.description", mcnnInt)
            Dim dtDiscont As New DataTable

            odaDiscont.Fill(dtDiscont)

            Me.tscmbSkidka.ComboBox.DataSource = dtDiscont 'Связать данные со списком
            Me.tscmbSkidka.ComboBox.DisplayMember = "Name"
            Me.tscmbSkidka.ComboBox.ValueMember = "ID"
        Catch ex As System.Exception
            '   MsgBox("Универсальный прайс, загрузка." & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
End Class