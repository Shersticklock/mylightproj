Public Class c_UniCostGM
    Dim ferstPrice@, ferstKolvo%
    Dim Itogo%, CostFromPrice@
    Dim ocmd As New SqlClient.SqlCommand
    '***********
    Dim colorStr$, prim$

#Region " Загрузка и очистка формы "
    Private Sub er_UniCost_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Me.tstxtSkidka.Text = Module1.NonQuery1Scalar("SELECT coalesce([Discount], 0) from [KA_ServDisccount] where [ID_KA]=" & custID & " and [ID_Service]=" & serviceID & "")

        Try 'Читаем наименования групп прайсов
            Dim odaGroupPrice As New SqlClient.SqlDataAdapter("SELECT ID, groupName FROM PriceGroup WHERE serviceID=" & serviceID & " order by groupName", mcnnInt)
            Dim dtGroupPrice As New DataTable : odaGroupPrice.Fill(dtGroupPrice)

            Me.cmbPriceGroup.DataSource = dtGroupPrice
            Me.cmbPriceGroup.DisplayMember = "groupName"
            Me.cmbPriceGroup.ValueMember = "ID"
            Me.Label4.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(description, 'Не задано') FROM Services WHERE ID=" & serviceID & ""))
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub NewCost()
        Me.tstxtItog.Text = Nothing
        Me.tstxtCostUnit.Text = Nothing
        ' Me.tstxtSkidka.Enabled = True
    End Sub
#End Region

#Region " Расчет цены "
    Private Sub tsbtnCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCost.Click
        If Me.cmbPriceGroup.SelectedIndex = -1 Then MsgBox("Не выбрана группа", MsgBoxStyle.Critical, appName) : Me.cmbPriceGroup.Focus() : Exit Sub
        If Me.cmbPriceName.SelectedIndex = -1 Then MsgBox("Не выбрана продукция", MsgBoxStyle.Critical, appName) : Me.cmbPriceName.Focus() : Exit Sub
        If Me.cmbParam2.SelectedIndex = -1 Then MsgBox("Не выбран параметр", MsgBoxStyle.Critical, appName) : Me.cmbParam2.Focus() : Exit Sub
        If Me.cmbMat.SelectedIndex = -1 Then MsgBox("Не выбран материал", MsgBoxStyle.Critical, appName) : Me.cmbMat.Focus() : Exit Sub

        Dim s As Integer
        '*******

        prim = ""

        For i As Integer = 0 To Me.clbOper.Items.Count - 1
            If Me.clbOper.GetItemChecked(i) = True Then
                Me.clbOper.SelectedIndex = i
                s += CInt(Me.clbOper.SelectedValue)
                prim += Me.clbOper.SelectedItem(1)
            End If
        Next

        Dim k_skidka@ = 1 '(100 - Val(Me.tstxtSkidka.Text)) / 100 'скидка
        Dim costMat As Decimal = Module1.NonQuery1Scalar("SELECT top 1 priceOut FROM SkladAccountingUnits WHERE matID=" & Me.cmbMat.SelectedItem(0) & "")

        Dim TirageID% = Me.cmbTirag.SelectedItem(0)
        If Me.cmbTirag.SelectedIndex = -1 Then MsgBox("Не выбран тираж", MsgBoxStyle.Critical, appName) : Me.cmbTirag.Focus() : Exit Sub

        Dim strSQL$ = "SELECT cost FROM PriceCost WHERE priceNameID=" & Me.cmbPriceName.SelectedItem(0) & " AND param1ID=" & TirageID & " AND param2ID=" & Me.cmbParam2.SelectedItem(0) & ""

        Itogo = Math.Round(Module1.NonQuery1Scalar(strSQL) * (100 + s) / 100 * k_skidka + Val(Me.cmbTirag.Text) * costMat / Module1.NonQuery1Scalar("SELECT kolvoSlista FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & ""), 0)

        ferstKolvo = CInt(Me.cmbTirag.Text)
        ferstPrice = Itogo

        Me.tstxtItog.Text = Itogo 'Format(Itogo, "0.####")
        Me.tstxtCostUnit.Text = Format(Math.Round(Itogo / (Module1.NonQuery1Scalar("SELECT name FROM PriceParam1 WHERE ID=" & Me.cmbTirag.SelectedItem(0) & " ")), 2), "C")

        colorStr = Me.cmbPriceGroup.Text + ", " + Me.cmbPriceName.Text + ", " + Me.cmbParam2.Text
    End Sub
#End Region

    Private Sub LoadTirages()
        Try
            Dim strSQL As String = "SELECT PriceParam1.ID, PriceParam1.name FROM PriceParam1 INNER JOIN PriceCost ON PriceParam1.ID=PriceCost.param1ID "
            strSQL &= "WHERE PriceCost.priceNameID=" & Me.cmbPriceName.SelectedItem(0) & " AND PriceCost.param2ID=" & Me.cmbParam2.SelectedItem(0) & " order by PriceParam1.name"
            Dim odaPrice As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtPrice As New DataTable : odaPrice.Fill(dtPrice)

            Me.cmbTirag.DataSource = dtPrice
            Me.cmbTirag.DisplayMember = "name"
            Me.cmbTirag.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub

#Region " Добавить расчет к заказу "
    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        SaveCost()

        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        SaveCost()
    End Sub

    Private Sub SaveCost()
        If costID = Nothing Then
            Select Case MsgBox(Prompt:="Закрыть расчет? ", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes : Me.Close()
                Case Is = vbNo : Exit Sub
            End Select
        Else
            If MessageBox.Show("Добавить расчет к заказу?", appName + " - Калькуляция", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Not IsNumeric(Me.tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub
                    If Not IsNumeric(Me.tstxtCostUnit.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub

                    Dim number$ = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString
                    Dim orderIDforTech% = InsertToOrders(Me.cmbPriceGroup.Text, Me.cmbMat.SelectedValue, CInt(Me.cmbTirag.Text), CDec(Me.tstxtItog.Text), Me.cmbPriceName.Text, "", number, CDec(Me.tstxtCostUnit.Text)) 'Пишем спецификацию

                    '*********Технологические операции
                    Dim costPPO%
                    Dim itemChecked As Object 'выборка по состоянию

                    For Each itemChecked In Me.clbOper.CheckedItems
                        costPPO += InsertTechOper(CInt(Me.Tag), Me.clbOper.Tag, itemChecked.item(0), CInt(Me.cmbTirag.Text), orderIDforTech)
                    Next

                    'получить ид операции
                    Dim techCost@ = InsertTechOper(CInt(Me.Tag), Me.cmbPriceName.Tag, Me.cmbPriceName.SelectedItem(0), CInt(Me.cmbTirag.Text), orderIDforTech)
                Catch excData As System.Exception
                    MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
                    Exit Sub
                End Try
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
            cmd.Parameters("@edIzm").Value = 1

            cmd.Parameters.Add(New SqlClient.SqlParameter("@technology", SqlDbType.NVarChar))
            cmd.Parameters("@technology").Value = colorStr

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costUnit", SqlDbType.Decimal))
            cmd.Parameters("@costUnit").Value = 1

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeCut", SqlDbType.NVarChar))
            cmd.Parameters("@sizeCut").Value = Me.cmbParam2.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@kolvo", SqlDbType.Int))
            cmd.Parameters("@kolvo").Value = CInt(Me.cmbTirag.Text)

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
#End Region

#Region " Выбор группы "
    Private Sub cmbPriceGroup_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbPriceGroup.SelectedValueChanged
        If Me.cmbPriceGroup.SelectedIndex <> -1 Then
            Me.lblMatTypes.Text = sender.text + "**"

            LoadOper()

            Try
                Dim odaPriceName As New SqlClient.SqlDataAdapter("select distinct rrr.ID, rrr.namePrice, rrr.groupID from [PriceCost] pc inner join (SELECT ID, namePrice, groupID FROM PriceName) rrr on pc.priceNameID=rrr.id inner join (SELECT [ID] FROM [PriceParam2]) p2 ON p2.ID=pc.param2ID where rrr.groupID=" & Me.cmbPriceGroup.SelectedItem(0) & " order by rrr.namePrice", mcnnInt)
                Dim dtPriceName As New DataTable : odaPriceName.Fill(dtPriceName)

                Me.cmbPriceName.DataSource = dtPriceName
                Me.cmbPriceName.DisplayMember = "namePrice"
                Me.cmbPriceName.ValueMember = "ID"

                Me.cmbPriceName.SelectedIndex = -1

                NewCost()

            Catch ex As System.Exception
            End Try
        End If
    End Sub
#End Region

#Region " Загрузка наценок "
    Private Sub LoadOper()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, name, (" & CInt(Me.cmbTirag.Text) & " * SaleK2 + SaleA) as cost FROM tech_Operations WHERE ID IN (SELECT techOperID FROM tech_OperControlTag WHERE controlItem0=" & Me.cmbPriceGroup.SelectedItem(0) & " AND controlTag='ppo' AND serviceID=" & serviceID & ")", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbOper.DataSource = dtNacenki
            Me.clbOper.DisplayMember = "name"
            Me.clbOper.ValueMember = "cost"

            Dim strSQL1$ = "SELECT listMatTypeID FROM CalcSettings WHERE serviceID = " & serviceID & " AND nameControl = '" & Me.lblMatTypes.Text & "'"
            Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN  (" & Module1.NonQuery1ScalarString(strSQL1) & ") order by Name", mcnnInt)
            Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

            Me.cmbMatTypes.DataSource = dtMatType 'Связать данные со списком
            Me.cmbMatTypes.DisplayMember = "Name"
            Me.cmbMatTypes.ValueMember = "ID"
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

    Private Sub cmbColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbParam2.SelectedIndexChanged
        LoadTirages()
        NewCost()
    End Sub

    Private Sub cmbPriceName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPriceName.SelectedIndexChanged
        Try 'Читаем наименования парметра-2
            Dim strSQL$ = "SELECT DISTINCT PriceParam2.ID, PriceParam2.name FROM PriceCost INNER JOIN PriceParam2 ON PriceCost.param2ID=PriceParam2.ID WHERE PriceParam2.serviceID=" & serviceID & " "
            strSQL &= "and PriceCost.priceNameID = " & Me.cmbPriceName.SelectedItem(0) & " order by name"
            Dim odaPriceParam2 As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtPriceParam2 As New DataTable : odaPriceParam2.Fill(dtPriceParam2)

            Me.cmbParam2.DataSource = dtPriceParam2
            Me.cmbParam2.DisplayMember = "name"
            Me.cmbParam2.ValueMember = "ID"

            NewCost()
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnClear.Click
        NewCost()
    End Sub

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsConfigMat.SourceControl)
    End Sub

    Private Sub ConfigCalc(ByRef ob As Object)
        Dim frmSelect As New frmConfigCalcMat
        Dim c As Control

        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
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

    '**************
    Private Sub cmbMatTypes_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbMatTypes.SelectedValueChanged
        Try
            If Me.cmbMatTypes.SelectedIndex <> -1 Then
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID = " & sender.SelectedItem(0) & " AND accessible = 1 order by matName", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMat.DataSource = dtMat1
                Me.cmbMat.DisplayMember = "matName"
                Me.cmbMat.ValueMember = "matID"
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(cmsConfigTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If emplID = Module1.NonQuery1Scalar("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
            ModCallForm.CallForm("Установка цен", 2, 2)
        Else
            MsgBox("Доступ запрещен", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub cmbPriceGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPriceGroup.SelectedIndexChanged

    End Sub
End Class