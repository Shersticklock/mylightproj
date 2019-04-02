Public Class c_UniCostWOColor

    Dim Itogo@, CostFromPrice@
    Dim ocmd As New SqlClient.SqlCommand
    Dim dopOperStr$, nacStr$
    Dim matCount As Decimal
    Dim printFormatCount As Decimal
    Dim tech$
    Dim strNameProd$

    Dim serviceIDvn As Integer ' для моста кбз и внутр заказа флая

#Region " Загрузка и очистка формы "
    Private Sub awc_UniCostWOColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        serviceIDvn = serviceID
        tscmbSkidka.DropDownStyle = ComboBoxStyle.DropDownList

        'Читаем наименования групп прайсов
        Dim odaGroupPrice As New SqlClient.SqlDataAdapter("SELECT ID, groupName FROM PriceGroup WHERE serviceID=" & serviceIDvn & " order by groupName", mcnnInt)
        Dim dtGroupPrice As New DataTable : odaGroupPrice.Fill(dtGroupPrice)

        Me.cmbPriceGroup.DataSource = dtGroupPrice
        Me.cmbPriceGroup.DisplayMember = "groupName"
        Me.cmbPriceGroup.ValueMember = "ID"

        Me.Label4.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(description, 'Не задано') FROM Services WHERE ID=" & serviceIDvn & ""))

        'Читаем наименования срочности
        Dim odaSrok As New SqlClient.SqlDataAdapter("SELECT nac, Name FROM unicalcSrokNac", mcnnInt)
        Dim dtSrok As New DataTable : odaSrok.Fill(dtSrok)

        Me.cmbSrok.DataSource = dtSrok
        Me.cmbSrok.DisplayMember = "Name"
        Me.cmbSrok.ValueMember = "nac"
        Me.cmbSrok.SelectedIndex = 0
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

            Try
                Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, nacName, nacValue FROM PriceNacenki WHERE groupID=" & Me.cmbPriceGroup.SelectedItem(0) & "", mcnnInt)
                Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

                Me.clbNacenki.DataSource = dtNacenki
                Me.clbNacenki.DisplayMember = "nacName"
                Me.clbNacenki.ValueMember = "nacValue"
            Catch ex As System.Exception
            End Try

            LoadPrice()
            NewCost()
            LoadOper()
            LoadTypesMat()

            LoadTirages()
        End If
    End Sub
#End Region

    Private Sub LoadTypesMat()
        Try
            Dim strSQL1$ = "SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceIDvn & " AND nameControl='" & Me.lblMatTypes.Text & "'"
            Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & Module1.NonQuery1ScalarString(strSQL1) & ") order by Name", mcnnInt)
            Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

            Me.cmbMatTypes.DataSource = dtMatType 'Связать данные со списком
            Me.cmbMatTypes.DisplayMember = "Name"
            Me.cmbMatTypes.ValueMember = "ID"

            Me.Label3.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(param2name, 'Не задан') FROM PriceGroup WHERE ID=" & Me.cmbPriceGroup.SelectedItem(0) & ""))
        Catch ex As System.Exception
        End Try
    End Sub

#Region " Загрузка наценок "
    Private Sub LoadOper()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, name FROM tech_Operations WHERE ID IN (SELECT techOperID FROM tech_OperControlTag WHERE controlItem0=" & Me.cmbPriceGroup.SelectedItem(0) & " AND controlTag='Prod' AND serviceID=" & serviceIDvn & ") order by name", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbOper.DataSource = dtNacenki
            Me.clbOper.DisplayMember = "name"
            Me.clbOper.ValueMember = "ID"

        Catch ex As System.Exception
        End Try
    End Sub
#End Region

#Region " Расчет цены "
    Private Sub tsbtnCost_Click(sender As Object, e As EventArgs) Handles tsbtnCost.Click
        'CostCalc(Me.nudQuantity.Value)
        CostCalc(CInt(Me.cmbTirag.Text))
    End Sub

    Private Sub CostCalc(quantity As Integer)
        If Me.nudY.Visible = True Then
            quantity *= 100 * Me.nudY.Value
        End If

        If Me.cmbPriceGroup.SelectedIndex = -1 Then MsgBox("Не выбрано значение1.", MsgBoxStyle.Critical, appName) : Me.cmbPriceGroup.Focus() : Exit Sub
        If Me.cmbPriceName.SelectedIndex = -1 Then MsgBox("Не выбрано значение2.", MsgBoxStyle.Critical, appName) : Me.cmbPriceName.Focus() : Exit Sub
        If Me.cmbParam2.SelectedIndex = -1 Then MsgBox("Не выбрано значение3.", MsgBoxStyle.Critical, appName) : Me.cmbParam2.Focus() : Exit Sub
        If Me.cmbMat.SelectedIndex = -1 Then MsgBox("Не выбран материал.", MsgBoxStyle.Critical, appName) : Me.cmbMat.Focus() : Exit Sub
        '  If Me.nudQuantity.Value = 0 Then MsgBox("Не указано количество.", MsgBoxStyle.Critical, appName) : Me.nudQuantity.Focus() : Exit Sub
        If IsNumeric(Me.cmbTirag.Text) = False Then
            MsgBox("Не указано количество.", MsgBoxStyle.Critical, appName) : Me.cmbTirag.Focus() : Exit Sub
        End If


        If Me.cmbSrok.SelectedIndex = -1 Then MsgBox("Не указан срок.", MsgBoxStyle.Critical, appName) : Me.cmbSrok.Focus() : Exit Sub
        If Me.cmbUnit.SelectedIndex = -1 Then MsgBox("Не выбрано значение.", MsgBoxStyle.Critical, appName) : Me.cmbUnit.Focus() : Exit Sub

        Dim s As Integer = 0
        Dim signFerst As Boolean = True
        Dim strOper$ = Nothing
        Dim costPPO@ = 0
        Dim strNacForFly As String = Nothing

        dopOperStr = ""
        nacStr = ""

        'Требуется расчет времени выполнения основной опреации

        'считаем наценку
        For Each itemChecked1 As Object In Me.clbNacenki.CheckedItems
            s += itemChecked1.item(2)
            nacStr += " * " + itemChecked1.item(1)
        Next

        'считаем стоимость операций
        For Each itemChecked As Object In Me.clbOper.CheckedItems
            If signFerst = False Then
                strOper += "," + itemChecked.item(0).ToString
                dopOperStr += "," + itemChecked.item(1).ToString
            Else
                strOper = itemChecked.item(0).ToString
                dopOperStr += itemChecked.item(1).ToString
                signFerst = False
            End If
        Next

        strNameProd = Me.cmbPriceGroup.Text + ", " + Me.cmbPriceName.Text + ", " + Me.cmbParam2.Text
        tech = Me.cmbPriceName.Text + ", " + Me.cmbParam2.Text

        ' CostFromPrice = NonQuery1Scalar("Select dbo.[costUniCalcWOMat](" & Me.cmbPriceName.SelectedItem(0) & "," & Me.cmbParam2.SelectedItem(0) & "," & Replace(Me.nudQuantity.Value, ",", ".") & ")")
        CostFromPrice = NonQuery1Scalar("Select dbo.[costUniCalcWOMat](" & Me.cmbPriceName.SelectedItem(0) & "," & Me.cmbParam2.SelectedItem(0) & "," & Replace(CInt(Me.cmbTirag.Text), ",", ".") & ")")

        printFormatCount = RoundUp(Val(Me.cmbTirag.Text) * Module1.NonQuery1Scalar("SELECT kolvoSlista FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & ""))

        'как вариант пересечение множеств
        matCount = printFormatCount / Module1.NonQuery1Scalar("SELECT kolvo FROM MatFormatINOUT INNER JOIN (SELECT unitID FROM SkladAccountingUnits WHERE matID=" & Me.cmbMat.SelectedItem(0) & ") sss ON MatFormatINOUT.unitID=sss.unitID WHERE formatPrintID=(SELECT ID FROM MatFormats WHERE formatDefault=1)")
        matCount = RoundUp(matCount)

        If signFerst = False Then ' хотя бы один отмечен
            '  @quantity decimal(18,4)
            ', @nacenka ntext=null
            ', @quantityFiles int
            ', @totalСirc int
            ', @discont int
            '    costPPO = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCLB] (" & Replace(matCount, ",", ".") & ", '" & strOper & "', 1, " & Me.nudQuantity.Value & ", 0)")
            costPPO = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCLB] (" & Replace(matCount, ",", ".") & ", '" & strOper & "', 1, " & CInt(Me.cmbTirag.Text) & ", 0)")
        End If

        Itogo = (CostFromPrice + costPPO) * (100 + s) / 100 * (100 + Me.cmbSrok.SelectedItem(0) - Val(Me.tscmbSkidka.Text)) / 100

        'Расчет итога
        '    Dim newCost As Decimal = RoundUp(Itogo / Me.nudQuantity.Value * 100) / 100 * Me.nudQuantity.Value

        Me.tstxtItog.Text = Format(Itogo, "C") 'Format(newCost, "0.00")
        ' Me.tstxtCostUnit.Text = Format(Math.Round(Itogo / Me.nudQuantity.Value, 2), "C")
        Me.tstxtCostUnit.Text = Format(Math.Round(Itogo / CInt(Me.cmbTirag.Text), 2), "C")

        If Not IsNumeric(tstxtItog.Text) Then
            Me.tsbtnOK.Enabled = False
            Me.tsbtnAddCost.Enabled = False
        Else
            Me.tsbtnOK.Enabled = True
            Me.tsbtnAddCost.Enabled = True
        End If
    End Sub
#End Region

#Region " Добавить расчет к заказу "
    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        Save()

        Me.Close()
    End Sub

    Private Sub Save()
        If costID = Nothing Then
            Select Case MsgBox(Prompt:="Закрыть расчет? ", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes : Me.Close()
                Case Is = vbNo : Exit Sub
            End Select
        Else
            If MessageBox.Show("Добавить расчет к заказу?", appName + " - Калькуляция", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Dim orderIDforTech% = InsertToOrders("") 'Пишем спецификацию

                    '*********Технологические операции
                    Dim techCost@ = InsertTechOper(CInt(Me.Tag), Me.cmbPriceName.Tag, Me.cmbPriceName.SelectedItem(0), matCount, orderIDforTech)
                    techCost += InsertTechOper(CInt(Me.Tag), Me.cmbParam2.Tag, Me.cmbParam2.SelectedItem(0), matCount, orderIDforTech)

                    Dim costPPO%
                    '   Dim itemChecked As Object 'выборка по состоянию

                    For Each itemChecked As Object In Me.clbOper.CheckedItems
                        '  costPPO = InsertTechOperF(itemChecked.item(0), Me.nudQuantity.Value, orderIDforTech)
                        costPPO = InsertTechOperF(itemChecked.item(0), CInt(Me.cmbTirag.Text), orderIDforTech)
                    Next

                    'For Each itemChecked As Object In Me.clbOper.CheckedItems
                    '    'пишем непосредственно на основе тех операций загруж в клблист
                    '    techCost += InsertTechOperF(itemChecked.item(0), Me.nudTirag.Value, orderIDforTech) ' [dbo].[sp_TechOperOrderInsF]
                    'Next


                Catch excData As System.Exception
                    MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
                    Exit Sub
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Function InsertToOrders(ByVal strPrim As String) As Integer
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_CalcToOrdersNew"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@serviceID", SqlDbType.Int))
            cmd.Parameters("@serviceID").Value = serviceID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@cost", SqlDbType.Decimal))
            cmd.Parameters("@cost").Value = Itogo ' Replace(Me.tstxtItog.Text, ",", ".")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@prim", SqlDbType.NVarChar))
            cmd.Parameters("@prim").Value = dopOperStr + " * " + Me.cmbSrok.Text

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
            cmd.Parameters("@sostav").Value = nacStr

            cmd.Parameters.Add(New SqlClient.SqlParameter("@edIzm", SqlDbType.Int))
            cmd.Parameters("@edIzm").Value = Me.cmbUnit.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@technology", SqlDbType.NVarChar))
            cmd.Parameters("@technology").Value = Me.cmbPriceName.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costUnit", SqlDbType.Decimal))
            cmd.Parameters("@costUnit").Value = Itogo / Val(Me.cmbTirag.Text)  'Replace(Me.tstxtItog.Text / Me.nudQuantity.Value, ",", ".")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeCut", SqlDbType.NVarChar))
            cmd.Parameters("@sizeCut").Value = Me.cmbParam2.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@kolvo", SqlDbType.Int))
            cmd.Parameters("@kolvo").Value = Val(Me.cmbTirag.Text)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@matCount", SqlDbType.Int))
            cmd.Parameters("@matCount").Value = matCount

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nameForDoc", SqlDbType.NVarChar))
            cmd.Parameters("@nameForDoc").Value = strNameProd

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nomer", SqlDbType.NVarChar))
            cmd.Parameters("@nomer").Value = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString

            cmd.Parameters.Add(New SqlClient.SqlParameter("@AccUnitID", SqlDbType.Int))
            cmd.Parameters("@AccUnitID").Value = Me.cmbUnit.SelectedItem(0) 'Module1.NonQuery1Scalar("SELECT TOP 1 unitID FROM SkladAccountingUnits WHERE matID=" & Me.cmbMat.SelectedItem(0) & "")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@printFormatID", SqlDbType.Int))
            cmd.Parameters("@printFormatID").Value = Me.cmbUnit.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@printFormatCount", SqlDbType.Int))
            cmd.Parameters("@printFormatCount").Value = printFormatCount

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

#Region " Загрузка прайсов "
    Private Sub LoadPrice()
        Try
            Dim odaPriceName As New SqlClient.SqlDataAdapter("select distinct rrr.ID, rrr.namePrice, rrr.groupID from [PriceCost] pc inner join (SELECT ID, namePrice, groupID FROM PriceName) rrr on pc.priceNameID=rrr.id inner join (SELECT [ID] FROM [PriceParam2]) p2 ON p2.ID=pc.param2ID where rrr.groupID=" & Me.cmbPriceGroup.SelectedItem(0) & " order by namePrice", mcnnInt)
            Dim dtPriceName As New DataTable : odaPriceName.Fill(dtPriceName)

            Me.cmbPriceName.DataSource = dtPriceName
            Me.cmbPriceName.DisplayMember = "namePrice"
            Me.cmbPriceName.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub cmbTirag_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii% = Asc(e.KeyChar)

        Select Case KeyAscii
            Case 48 To 57, 8, 44, 46
            Case Else
                KeyAscii = 0
        End Select

        If KeyAscii = 0 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmbParam2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbParam2.SelectedValueChanged
        If Module1.NonQuery1ScalarString("SELECT coalesce(description,'') FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "") = "wda" Then
            Me.nudY.Visible = True
            Me.nudY.Select(0, (Len(Me.nudY.Value.ToString)))
        Else
            Me.nudY.Visible = False
            '  Me.nudQuantity.Select(0, (Len(Me.nudQuantity.Value.ToString)))
        End If

        '  NewCost()
        ' LoadTirages()
    End Sub

    Private Sub LoadTirages()
        Try
            Dim strSQL As String = "SELECT PriceParam1.ID, PriceParam1.name FROM PriceParam1 INNER JOIN PriceCost ON PriceParam1.ID=PriceCost.param1ID "
            strSQL &= "WHERE PriceCost.priceNameID=" & Me.cmbPriceName.SelectedItem(0) & " AND PriceCost.param2ID=" & Me.cmbParam2.SelectedItem(0) & " order by PriceParam1.name"
            Dim odaPrice As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtTir As New DataTable : odaPrice.Fill(dtTir)

            Me.cmbTirag.DataSource = dtTir
            Me.cmbTirag.DisplayMember = "name"
            Me.cmbTirag.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub cmbPriceName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPriceName.SelectedValueChanged
        Try
            Dim strSQL$ = "SELECT DISTINCT PriceParam2.ID,PriceParam2.name FROM PriceCost INNER JOIN PriceParam2 ON PriceCost.param2ID=PriceParam2.ID"
            strSQL &= " WHERE PriceParam2.serviceID=" & serviceIDvn & " and PriceCost.priceNameID=" & Me.cmbPriceName.SelectedItem(0) & " order by name"

            'Читаем наименования парметра-2
            Dim odaPriceParam2 As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtPriceParam2 As New DataTable : odaPriceParam2.Fill(dtPriceParam2)

            Me.cmbParam2.DataSource = dtPriceParam2
            Me.cmbParam2.DisplayMember = "name"
            Me.cmbParam2.ValueMember = "ID"

            '  NewCost()
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsConfigMat.SourceControl)

        LoadTypesMat()
    End Sub

    Private Sub ConfigCalc(ByRef ob As Object)
        Dim frmSelect As New frmConfigCalcMat
        Dim c As Control
        'ob контрол к которому привязано меню

        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID=" & serviceIDvn & "") Or postPrioritet = 1 Then
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
            MsgBox("Нет прав на конфигурирование", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbMatTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMatTypes.SelectedIndexChanged
        Try
            If Me.cmbMatTypes.SelectedIndex <> -1 Then
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID=" & sender.SelectedItem(0) & " AND accessible=1 order by matName", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMat.DataSource = dtMat1 'Связать данные со списком
                Me.cmbMat.DisplayMember = "matName"
                Me.cmbMat.ValueMember = "matID"
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub tstxtItog_TextChanged(sender As Object, e As EventArgs) Handles tstxtItog.TextChanged
        If Not IsNumeric(tstxtItog.Text) Then
            Me.tsbtnOK.Enabled = False
        Else
            Me.tsbtnOK.Enabled = True
        End If
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(cmsConfigTech.SourceControl, CInt(Me.Tag))

        LoadOper()
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
        Me.cmbUnit.ValueMember = "ID"
    End Sub

    Private Sub nudQuantity_GotFocus(sender As Object, e As EventArgs)
        '  Me.nudQuantity.Select(0, (Len(Me.nudQuantity.Value.ToString)))
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbtnAddCost.Click
        Save()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If emplID = Module1.NonQuery1Scalar("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
            ModCallForm.CallForm("Быстрый заказ", 2, 2)
        Else
            MsgBox("Доступ запрещен", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub cmbTirag_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTirag.SelectedValueChanged

    End Sub

    'Private Sub cmbTirag_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTirag.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '      SkidkaLoad()
    '    End If

    '    e.Handled = True
    'End Sub

    Private Sub cmbTirag_TextChanged(sender As Object, e As EventArgs) Handles cmbTirag.TextChanged
        SkidkaLoad()
    End Sub

    Private Sub SkidkaLoad()
        If Me.cmbTirag.Text <> Nothing Then
            Try
                Dim odaDiscont As New SqlClient.SqlDataAdapter("SELECT awc_Discont.ID, awc_Discont.Name FROM awc_Discont INNER JOIN awc_DiscontServices ON awc_Discont.ID=awc_DiscontServices.discontID WHERE awc_DiscontServices.serviceID=" & serviceID & " AND quantity<=" & CInt(Me.cmbTirag.Text) & " AND " & CInt(Me.cmbTirag.Text) & "<=quantity2 order by awc_Discont.description", mcnnInt)

                Dim dtDiscont As New DataTable

                odaDiscont.Fill(dtDiscont)

                Me.tscmbSkidka.ComboBox.DataSource = dtDiscont 'Связать данные со списком
                Me.tscmbSkidka.ComboBox.DisplayMember = "Name"
                Me.tscmbSkidka.ComboBox.ValueMember = "ID"
            Catch ex As System.Exception
                '   MsgBox("Универсальный прайс, загрузка." & ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub cmbTirag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTirag.SelectedIndexChanged

    End Sub

    Private Sub cmbPriceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPriceName.SelectedIndexChanged

    End Sub

    Private Sub cmbParam2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbParam2.SelectedIndexChanged

    End Sub

    Private Sub cmbPriceGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPriceGroup.SelectedIndexChanged

    End Sub
End Class