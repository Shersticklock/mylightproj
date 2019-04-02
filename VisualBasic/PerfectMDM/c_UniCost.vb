Public Class c_UniCost

    Dim Itogo@, CostFromPrice@
    '***********
    Dim colorStr$
    Dim nacenkaStr$, dopOperstr$
    Dim matCount As Integer
    Dim strNacSrok$


#Region " Загрузка и очистка формы "
    '  Private Property cmbTirag As Object

    Private Sub awc_UniCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.tslSkidka.Text = Replace(Module1.NonQuery1ScalarString("SELECT coalesce(skidka, '') FROM Services where ID = " & serviceID & " "), ";", Chr(13))
        'Me.Text = Module1.NonQuery1ScalarString("SELECT Name FROM Services where ID = " & serviceID & " ")
        Me.tscmbSkidka.Text = Module1.NonQuery1Scalar("SELECT coalesce([Discount], 0) from [KA_ServDisccount] where [ID_KA]=" & custID & " and [ID_Service]=" & serviceID & " ")

        Try 'Читаем наименования групп прайсов
            Dim odaGroupPrice As New SqlClient.SqlDataAdapter("SELECT ID, groupName FROM PriceGroup WHERE serviceID = " & serviceID & " order by groupName ", mcnnInt)
            Dim dtGroupPrice As New DataTable : odaGroupPrice.Fill(dtGroupPrice)

            Me.cmbPriceGroup.DataSource = dtGroupPrice
            Me.cmbPriceGroup.DisplayMember = "groupName"
            Me.cmbPriceGroup.ValueMember = "ID"

            Me.Label4.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(description, 'Не задано') FROM Services WHERE ID = " & serviceID & " "))

            'Читаем наименования срочности
            Dim odaSrok As New SqlClient.SqlDataAdapter("SELECT nac, Name FROM unicalcSrokNac ", mcnnInt)
            Dim dtSrok As New DataTable : odaSrok.Fill(dtSrok)

            Me.cmbSrok.DataSource = dtSrok
            Me.cmbSrok.DisplayMember = "Name"
            Me.cmbSrok.ValueMember = "nac"
            Me.cmbSrok.SelectedIndex = 0
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub tsbtnExit_Click_1(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnClear_Click_1(sender As Object, e As EventArgs) Handles tsbtnClear.Click
        NewCost()
    End Sub

    Private Sub NewCost()
        Me.tstxtItog.Text = Nothing
        Me.tscmbSkidka.Enabled = True
    End Sub
#End Region


#Region " Выбор группы "
    Private Sub cmbPriceGroup_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPriceGroup.SelectedValueChanged
        If Me.cmbPriceGroup.SelectedIndex <> -1 Then
            Me.lblMatTypes.Text = sender.text + "**"

            NewCost()
            LoadNac()
            LoadOper()
            LoadMat(serviceID, Me.lblMatTypes.Text)

            Try
                Dim odaPriceName As New SqlClient.SqlDataAdapter("select distinct rrr.ID, rrr.namePrice, rrr.groupID from [PriceCost] pc inner join (SELECT ID, namePrice, groupID FROM PriceName) rrr on pc.priceNameID=rrr.id inner join (SELECT [ID] FROM [PriceParam2]) p2 ON p2.ID = pc.param2ID where rrr.groupID  = " & Me.cmbPriceGroup.SelectedItem(0) & " order by namePrice", mcnnInt)
                Dim dtPriceName As New DataTable : odaPriceName.Fill(dtPriceName)

                Me.cmbPriceName.DataSource = dtPriceName
                Me.cmbPriceName.DisplayMember = "namePrice"
                Me.cmbPriceName.ValueMember = "ID"
            Catch ex As System.Exception
            End Try
        End If
    End Sub

    Private Sub LoadMat(serID As Integer, strControlText As String)
        Try

            Dim strSQL1$ = "SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serID & " AND nameControl='" & strControlText & "' "
            Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & Module1.NonQuery1ScalarString(strSQL1) & ") order by Name", mcnnInt)
            Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

            Me.cmbMatTypes.DataSource = dtMatType 'Связать данные со списком
            Me.cmbMatTypes.DisplayMember = "Name"
            Me.cmbMatTypes.ValueMember = "ID"

        Catch ex As System.Exception
        End Try
    End Sub
#End Region


#Region " Загрузка наценок "
    Private Sub LoadNac()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, nacName, nacValue FROM PriceNacenki WHERE groupID = " & Me.cmbPriceGroup.SelectedItem(0) & " ", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbNacenki.DataSource = dtNacenki
            Me.clbNacenki.DisplayMember = "nacName"
            Me.clbNacenki.ValueMember = "nacValue"
        Catch ex As System.Exception
            MsgBox("Ош при загрузке наценок.", MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Private Sub cmbMatTypes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMatTypes.SelectedValueChanged
        Try
            If Me.cmbMatTypes.SelectedIndex <> -1 Then
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID = " & sender.SelectedItem(0) & " AND accessible = 1 order by matName", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMat.DataSource = dtMat1 'Связать данные со списком
                Me.cmbMat.DisplayMember = "matName"
                Me.cmbMat.ValueMember = "matID"
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub tmbMatColor_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmbMatColor.SelectedValueChanged
        Dim dtMat As New DataTable
        dtMat = Module1.List(serviceID, Trim(sender.Text))

        Me.cmbMatColor.DataSource = dtMat
        Me.cmbMatColor.DisplayMember = "matName"
        Me.cmbMatColor.ValueMember = "matID"
    End Sub

    Private Sub cmbPriceName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPriceName.SelectedValueChanged
        Try
            Dim strSQL$ = "SELECT DISTINCT PriceParam2.ID, PriceParam2.name FROM PriceCost "
            strSQL &= "INNER JOIN PriceParam2  ON PriceCost.param2ID = PriceParam2.ID WHERE PriceParam2.serviceID = " & serviceID & "  "
            strSQL &= "and PriceCost.priceNameID = " & Me.cmbPriceName.SelectedItem(0) & " order by name"

            'Читаем наименования парметра-2
            Dim odaPriceParam2 As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtPriceParam2 As New DataTable : odaPriceParam2.Fill(dtPriceParam2)
            Me.cmbParam2.DataSource = dtPriceParam2
            Me.cmbParam2.DisplayMember = "name"
            Me.cmbParam2.ValueMember = "ID"

            NewCost()
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub cmbParam2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbParam2.SelectedValueChanged
        '  LoadTirages()
        NewCost()

    End Sub


    Private Sub btnAddColor_Click(sender As Object, e As EventArgs) Handles btnAddColor.Click
        If Me.tmbMatColor.SelectedIndex = -1 Then MsgBox("Не выбран тип краски", MsgBoxStyle.Critical, appName) : Exit Sub
        If Me.cmbMatColor.SelectedIndex = -1 Then MsgBox("Не выбрана краска", MsgBoxStyle.Critical, appName) : Exit Sub

        Me.dgColor.Rows.Add()
        Me.dgColor.ClearSelection()

        Dim countRows As Integer = Me.dgColor.Rows.Count

        Me.dgColor.Item("range", countRows - 1).Value = CInt(countRows)
        Me.dgColor.Item("ID", countRows - 1).Value = Me.cmbMatColor.SelectedItem(0)
        Me.dgColor.Item("cost", countRows - 1).Value = Module1.NonQuery1Scalar("SELECT nacenka FROM Materials WHERE matID = " & Me.cmbMatColor.SelectedItem(0) & " ")
        Me.dgColor.Rows(countRows - 1).DefaultCellStyle.BackColor = Settings1.Default.colorStWork

        If Me.tmbMatColor.SelectedIndex = 0 Then 'Оракал
            Me.dgColor.Item("NameMat", countRows - 1).Value = Me.cmbMatColor.Text
        Else
            Dim newDescript$ = InputBox("Укажи номер пантона", appName, "pantone-")

            If newDescript = "pantone-" Then
                Me.dgColor.Rows.Remove(Me.dgColor.Rows(Me.dgColor.Rows.Count - 1))
            Else
                Me.dgColor.Item("NameMat", countRows - 1).Value = newDescript
            End If
        End If
    End Sub

    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMat.SelectedValueChanged
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_MatUnit]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
        cmd.Parameters("@matID").Value = Me.cmbMat.SelectedItem(0)

        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMatUnit As New DataTable : odaMan.Fill(dtMatUnit)

        Me.cmbUnit.DataSource = dtMatUnit 'Связать данные со списком
        Me.cmbUnit.DisplayMember = "Name"
        Me.cmbUnit.ValueMember = "unitID"
    End Sub

#Region " Загрузка операций "
    Private Sub LoadOper()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, name, (" & Me.nudQuantity.Value & " * KC + AC) as cost FROM tech_Operations WHERE ID IN (SELECT techOperID FROM tech_OperControlTag WHERE controlItem0 = " & Me.cmbPriceGroup.SelectedItem(0) & " AND controlTag = 'oper' AND serviceID = " & serviceID & ") order by name ", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbOper.DataSource = dtNacenki
            Me.clbOper.DisplayMember = "name"
            Me.clbOper.ValueMember = "cost"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub cmbSrok_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbSrok.SelectedValueChanged
        '    Me.tscmbNac.Text = Me.cmbSrok.SelectedItem(0)
    End Sub



    'Private Sub cmbTirag_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii% = Asc(e.KeyChar)

    '    Select Case KeyAscii
    '        Case 48 To 57, 8, 44, 46
    '        Case Else
    '            KeyAscii = 0
    '    End Select
    '    If KeyAscii = 0 Then
    '        e.Handled = True
    '    Else
    '        e.Handled = False
    '    End If
    'End Sub


#Region " Расчет цены "
    Private Sub tsbtnCost_Click(sender As Object, e As EventArgs) Handles tsbtnCost.Click
        CostCalc()
    End Sub

    Private Sub CostCalc()
        If Me.cmbPriceGroup.SelectedIndex = -1 Then MsgBox("Не выбрано значение1.", MsgBoxStyle.Critical, appName) : Me.cmbPriceGroup.Focus() : Exit Sub
        If Me.cmbPriceName.SelectedIndex = -1 Then MsgBox("Не выбрано значение2.", MsgBoxStyle.Critical, appName) : Me.cmbPriceName.Focus() : Exit Sub
        If Me.cmbParam2.SelectedIndex = -1 Then MsgBox("Не выбрано значение3.", MsgBoxStyle.Critical, appName) : Me.cmbParam2.Focus() : Exit Sub
        If Me.cmbMat.SelectedIndex = -1 Then MsgBox("Не выбран материал.", MsgBoxStyle.Critical, appName) : Me.cmbMat.Focus() : Exit Sub
        If Me.nudQuantity.Value = 0 Then MsgBox("Не указано количество.", MsgBoxStyle.Critical, appName) : Me.nudQuantity.Focus() : Exit Sub
        If Me.cmbSrok.SelectedIndex = -1 Then MsgBox("Не указан срок.", MsgBoxStyle.Critical, appName) : Me.cmbSrok.Focus() : Exit Sub

        If Me.cmbUnit.SelectedIndex = -1 Then MsgBox("Не выбрано значение формата.", MsgBoxStyle.Critical, appName) : Me.cmbUnit.Focus() : Exit Sub

        Dim s As Integer = 0
        Dim costColor@ = 0
        Dim signFerst As Boolean = True
        Dim strOper$ = Nothing
        Dim costPPO@, costPPOmin@

        nacenkaStr = ""
        colorStr = ""
        '*******

        For Each itemChecked1 As Object In Me.clbNacenki.CheckedItems
            s += itemChecked1.item(2)
            nacenkaStr += " * " + itemChecked1.item(1)
        Next

        'считаем стоимость операций
        For Each itemChecked As Object In Me.clbOper.CheckedItems
            If signFerst = False Then
                strOper += "," + itemChecked.item(0).ToString
                dopOperstr += "," + itemChecked.item(1).ToString
            Else
                strOper = itemChecked.item(0).ToString
                dopOperstr += itemChecked.item(1).ToString
                signFerst = False
            End If
        Next

        For n As Integer = 1 To Me.dgColor.Rows.Count
            Try
                colorStr += " * " + Me.dgColor("NameMat", n - 1).Value
                costColor += Me.dgColor("cost", n - 1).Value * Me.nudQuantity.Value
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName) : Exit For : Exit Sub
            End Try
        Next

        CostFromPrice = NonQuery1Scalar("Select dbo.[costUniCalcMatAdd](" & Me.cmbMat.SelectedItem(0) & ", " & Me.cmbPriceName.SelectedItem(0) & ", " & Me.cmbParam2.SelectedItem(0) & ", " & Me.nudQuantity.Value & ", " & Me.cmbUnit.SelectedItem(0) & ") ")
        ' matCount = RoundUp(Me.nudQuantity.Value * Module1.NonQuery1Scalar("SELECT kolvoSlista FROM PriceParam2 WHERE ID = " & Me.cmbParam2.SelectedItem(0) & " "))


        If signFerst = False Then
            costPPO = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCLB] (" & matCount & ", '" & strOper & "', 1, " & Me.nudQuantity.Value & " , 0)")
        Else
            costPPO = 0
            costPPOmin = 0
        End If

        '   Itogo = (CostFromPrice * (100 + Val(Me.tscmbNac.Text) + costPPO)) / 100 * k_skidka * (100 + nacenkaSrok) / 100
        Itogo = (CostFromPrice + costPPO) * (100 + s) / 100 * (100 + Me.cmbSrok.SelectedItem(0) - Val(Me.tscmbSkidka.Text)) / 100

        'Расчет итога
        Dim newCost As Decimal = RoundUp(Itogo / Me.nudQuantity.Value * 100) / 100 * Me.nudQuantity.Value

        Me.tstxtItog.Text = newCost 'Format(newCost, "0.00")
        Me.tstxtCostUnit.Text = newCost / Me.nudQuantity.Value
    End Sub
#End Region

#Region " Добавить расчет к заказу "
    Private Sub tsbtnOK_Click(sender As Object, e As EventArgs) Handles tsbtnOK.Click
        If costID = Nothing Then
            Select Case MsgBox(Prompt:="Закрыть расчет? ", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes : Me.Close()
                Case Is = vbNo : Exit Sub
            End Select
        Else
            If MessageBox.Show("Добавить расчет к заказу?", appName + " - Калькуляция", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Not IsNumeric(tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub
                Try
                    Dim orderIDforTech% = InsertToOrders(colorStr) 'Пишем спецификацию
                    '*********Технологические операции
                    Dim techCost@ = InsertTechOper(CInt(Me.Tag), Me.cmbPriceName.Tag, Me.cmbPriceName.SelectedItem(0), matCount, orderIDforTech)
                    techCost += InsertTechOper(CInt(Me.Tag), Me.cmbParam2.Tag, Me.cmbParam2.SelectedItem(0), matCount, orderIDforTech)

                    Dim itemChecked As Object 'выборка по состоянию

                    For Each itemChecked In Me.clbOper.CheckedItems
                        techCost += InsertTechOper(CInt(Me.Tag), Me.clbOper.Tag, itemChecked.item(0), Me.nudQuantity.Value, orderIDforTech)
                    Next


                    Me.Close()
                Catch excData As System.Exception
                    MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
                    Exit Sub
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub


    Function InsertToOrders(ByVal colorstr As String) As Integer
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_CalcToOrders"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@serviceID", SqlDbType.Int))
            cmd.Parameters("@serviceID").Value = serviceID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@cost", SqlDbType.Decimal))
            cmd.Parameters("@cost").Value = Itogo

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@prim", SqlDbType.NVarChar))
            cmd.Parameters("@prim").Value = nacenkaStr + " * " + dopOperstr + " * " + Me.cmbSrok.Text + "-" + strNacSrok + "%"

            If Me.cmbMat.SelectedIndex = -1 Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Module1.NonQuery1Scalar("SELECT matID From materials where matzak=1")
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Me.cmbMat.SelectedValue
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@data", SqlDbType.DateTime))
            cmd.Parameters("@data").Value = Now()

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sostav", SqlDbType.NVarChar))
            cmd.Parameters("@sostav").Value = Me.cmbParam2.Text + colorstr

            cmd.Parameters.Add(New SqlClient.SqlParameter("@edIzm", SqlDbType.Int))
            cmd.Parameters("@edIzm").Value = Me.cmbUnit.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@technology", SqlDbType.NVarChar))
            cmd.Parameters("@technology").Value = Me.cmbPriceName.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costUnit", SqlDbType.Decimal))
            cmd.Parameters("@costUnit").Value = Itogo / Me.nudQuantity.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeCut", SqlDbType.NVarChar))
            cmd.Parameters("@sizeCut").Value = ""

            cmd.Parameters.Add(New SqlClient.SqlParameter("@kolvo", SqlDbType.Int))
            cmd.Parameters("@kolvo").Value = Me.nudQuantity.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@matCount", SqlDbType.Int))
            cmd.Parameters("@matCount").Value = matCount

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nameForDoc", SqlDbType.NVarChar))
            cmd.Parameters("@nameForDoc").Value = Me.cmbPriceGroup.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nomer", SqlDbType.NVarChar))
            cmd.Parameters("@nomer").Value = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID = " & costID & " ").ToString

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
#End Region


    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub tsbtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewCost()
    End Sub

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsConfigMat.SourceControl)

        LoadMat(serviceID, Me.lblMatTypes.Text)
    End Sub

    Private Sub ConfigCalc(ByRef ob As Object)
        Dim frmSelect As New frmConfigCalcMat
        Dim c As Control
        'ob контрол к которому привязано меню

        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID = " & serviceID & "") Or postPrioritet = 1 Then
            For Each c In ob.Parent.Controls
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
            MsgBox("Нет прав на конфигурирование.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    '**************

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(cmsConfigTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub nudQuantity_GotFocus(sender As Object, e As EventArgs) Handles nudQuantity.GotFocus
        Me.nudQuantity.Select(0, (Len(Me.nudQuantity.Value.ToString)))
    End Sub

    Private Sub nudQuantity_MouseClick(sender As Object, e As MouseEventArgs) Handles nudQuantity.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged
        Me.tscmbSkidka.ComboBox.DataSource = Nothing

        Try
            Dim odaDiscont As New SqlClient.SqlDataAdapter("SELECT awc_Discont.ID, awc_Discont.Name FROM awc_Discont INNER JOIN awc_DiscontServices ON awc_Discont.ID=awc_DiscontServices.discontID WHERE awc_DiscontServices.serviceID=" & serviceID & " AND quantity<=" & Me.nudQuantity.Value & " AND " & Me.nudQuantity.Value & "<=quantity2 order by awc_Discont.description", mcnnInt)
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