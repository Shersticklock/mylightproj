Public Class c_FastOrder
    Dim Itogo@, cost@, prim$
    Dim ocmd As New SqlClient.SqlCommand
    '***********
    Dim colorStr$
    Dim matCount As Integer
    ' Dim tech$
    'для записи в специю
    Dim modaLookupData As SqlClient.SqlDataAdapter
    Dim objCB As SqlClient.SqlCommand
    Dim dtData As New DataTable
    Dim startRank As Integer

    '   Private Property nudQuantity As Object


    Private Sub mdm_FastOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Быстрые заказы"

        Me.tstxtNac.Enabled = False

        Try 'Читаем наименования групп прайсов
            Dim odaGroupPrice As New SqlClient.SqlDataAdapter("SELECT ID, groupName FROM PriceGroup WHERE serviceID=" & serviceID & " order by description", mcnnInt)
            Dim dtGroupPrice As New DataTable : odaGroupPrice.Fill(dtGroupPrice)

            Me.cmbPriceGroup.DataSource = dtGroupPrice
            Me.cmbPriceGroup.DisplayMember = "groupName"
            Me.cmbPriceGroup.ValueMember = "ID"
            Me.cmbPriceGroup.SelectedIndex = 0
            Me.Label4.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(description, 'Не задано') FROM Services WHERE ID=" & serviceID & ""))
        Catch ex As System.Exception
        End Try

        'специя
        startRank = 1

        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_MDM_FastOrder"
            cmd.CommandType = CommandType.StoredProcedure

            modaLookupData = New SqlClient.SqlDataAdapter(cmd)
            modaLookupData.Fill(dtData)
            dtData.Rows.Clear()
        Catch excData As System.Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub ColHideDG()
        For Each col As Object In Me.dgDataTable.Columns
            If col.name = "ordID" Or col.name = "serviceID" Or col.name = "matID" Or col.name = "costID" Or col.name = "sostav" Or col.name = "sizeCut" Or col.name = "technology" Or col.name = "prim" Or col.name = "costUnit" Or col.name = "data" Or col.name = "edIzm" Or col.name = "matCount" Or col.name = "IndexSrok" Or col.name = "primeCostTotal" Or col.name = "supplier" Or col.name = "AccUnitID" Then
                col.visible = False
            End If
        Next
    End Sub

#Region " Выбор группы "
    Private Sub cmbPriceGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPriceGroup.SelectedIndexChanged
        If Me.cmbPriceGroup.SelectedIndex <> -1 Then
            Me.lblMatTypes.Text = sender.text + "**"


            LoadPrice()
            LoadMat(Me.lblMatTypes.Text)

            Try
                '     Me.Label3.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(param2name, 'Не задан') FROM PriceGroup WHERE ID=" & Me.cmbPriceGroup.SelectedItem(0) & ""))

                'If idConfig = 56789082 Then
                '    Me.lblMatTypes.Text = Me.cmbPriceGroup.Text
                'Else

                'End If

                'Dim strSQL1$ = "SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.lblMatTypes.Text & "'"
                'Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & Module1.NonQuery1ScalarString(strSQL1) & ") order by Name", mcnnInt)
                'Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

                'Me.cmbMatTypes.DataSource = dtMatType 'Связать данные со списком
                'Me.cmbMatTypes.DisplayMember = "Name"
                'Me.cmbMatTypes.ValueMember = "ID"



                '    Me.cmbPriceName.SelectedIndex = -1
                '  Me.cmbParam2.SelectedIndex = -1
                ' Me.cmbMatTypes.SelectedIndex = -1
            Catch ex As System.Exception
            End Try
        End If
    End Sub
#End Region

    Private Sub LoadMat(labelText As String)
        Try
            Dim strSQL1$ = "SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.lblMatTypes.Text & "'"
            Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & Module1.NonQuery1ScalarString(strSQL1) & ") order by Name", mcnnInt)
            Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

            Me.cmbMatTypes.DataSource = dtMatType 'Связать данные со списком
            Me.cmbMatTypes.DisplayMember = "Name"
            Me.cmbMatTypes.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub

#Region " Загрузка прайсов "
    Private Sub LoadPrice()
        Try
            Dim odaPriceName As New SqlClient.SqlDataAdapter("select distinct rrr.ID, rrr.namePrice, rrr.groupID from [PriceCost] pc inner join (SELECT ID, namePrice, groupID FROM PriceName) rrr on pc.priceNameID=rrr.id inner join (SELECT [ID] FROM [PriceParam2]) p2 ON p2.ID = pc.param2ID where rrr.groupID  = " & Me.cmbPriceGroup.SelectedItem(0) & " order by rrr.namePrice", mcnnInt)
            Dim dtPriceName As New DataTable : odaPriceName.Fill(dtPriceName)

            Me.cmbPriceName.DataSource = dtPriceName
            Me.cmbPriceName.DisplayMember = "namePrice"
            Me.cmbPriceName.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

#Region " Загрузка операций "
    Private Sub LoadOper()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, name FROM tech_Operations WHERE ID IN (SELECT techOperID FROM tech_OperControlTag WHERE controlItem0=" & Me.cmbPriceGroup.SelectedItem(0) & " AND controlTag='" & Me.cmbPriceName.Tag & "' AND serviceID=" & serviceID & ") order by name", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbOper.DataSource = dtNacenki
            Me.clbOper.DisplayMember = "name"
            Me.clbOper.ValueMember = "ID"

        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddRowFastOrder()
    End Sub

    Private Sub AddRowFastOrder()
        Try
            Dim mdrIndiv As DataRow

            mdrIndiv = dtData.NewRow
            mdrIndiv.BeginEdit()

            mdrIndiv("costID") = 1 'costID пока еще не знаем идешник
            mdrIndiv("number") = dtData.Rows.Count + 1
            mdrIndiv("serviceID") = serviceID
            mdrIndiv("sizeCut") = "" '
            mdrIndiv("kolvo") = Me.nudQuantity1.Value
            mdrIndiv("sostav") = Me.cmbPriceName.SelectedItem(0)
            mdrIndiv("data") = Now()

            If Me.nudQuantity2.Visible = True Then
                mdrIndiv("matCount") = Math.Round(Me.nudQuantity1.Value * Me.nudQuantity2.Value * Module1.NonQuery1Scalar("SELECT kolvoSlista FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedValue & ""), 2)
            Else
                mdrIndiv("matCount") = RoundUp(Me.nudQuantity1.Value * Module1.NonQuery1Scalar("SELECT kolvoSlista FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedValue & ""))
            End If

            mdrIndiv("technology") = colorStr 'Цветность
            mdrIndiv("prim") = "Печать " '+ Me.cmbOperations.Text
            mdrIndiv("matID") = Me.cmbMat.SelectedItem(0)
            mdrIndiv("nameForDoc") = Me.cmbPriceGroup.Text + ", " + Me.cmbPriceName.Text + ", " + Me.cmbParam2.Text
            mdrIndiv("cost") = cost
            mdrIndiv("costUnit") = cost / Me.nudQuantity1.Value ' Math.Round((pechat + mat) / Me.nudTirag.Value, 2)
            mdrIndiv("primeCostTotal") = 0
            mdrIndiv("AccUnitID") = Module1.NonQuery1Scalar("SELECT TOP 1 unitID FROM SkladAccountingUnits WHERE matID=" & Me.cmbMat.SelectedItem(0) & "")

            'mdrIndiv("printFormatID") = Module1.NonQuery1Scalar("SELECT TOP 1 unitID FROM SkladAccountingUnits WHERE matID=" & Me.cmbMat.SelectedItem(0) & "")
            'mdrIndiv("printFormatCount") = 0

            mdrIndiv.EndEdit() 'Завершить редактировать строку данных
            dtData.Rows.Add(mdrIndiv) 'добавляем только печать

            Me.dgDataTable.DataSource = dtData

            ColHideDG()

            Itogo = dtData.Compute("SUM(cost)", "")
            Me.tstxtItog.Text = Itogo
            Me.btnAdd.Enabled = False
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub Oplata(typePay As Integer)
        If Me.dtData.Rows.Count = 0 Then
            MsgBox("Пустой заказ не может быть создан.", MsgBoxStyle.Critical, appName)
        Else
            Try
                costID = CreateOrderFast(False, typePay)

                Try
                    Dim rowSpec As DataRow

                    For Each rowSpec In dtData.Rows
                        rowSpec("costID") = costID
                    Next
                    'Сделать запись в спецификацию
                    Dim custCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(modaLookupData)

                    mcnnInt.Open()

                    modaLookupData.InsertCommand = custCB.GetInsertCommand
                    modaLookupData.Update(dtData)
                    dtData.AcceptChanges()
                    modaLookupData.InsertCommand.Connection.Close()

                    Me.Close()
                Catch oexpData As System.Exception
                    MsgBox("Старый КБЗ " + oexpData.Message, MsgBoxStyle.Critical, appName)
                    Exit Sub
                End Try
            Catch oexpData As System.Exception
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
                Exit Sub
            Finally
                mcnnInt.Close()
            End Try
        End If
    End Sub

    Function CreateOrderFast(ByVal bezOplaty As Boolean, ByVal typePay As Integer) As Integer 'счет безнальный
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt

            If bezOplaty = True Then
                cmd.CommandText = "sp_Order_FastCreateWOoplata"
            Else
                Select Case typePay
                    Case Is = 1
                        cmd.CommandText = "sp_Order_FastCreate"
                    Case Is = 2
                        cmd.CommandText = "sp_Order_FastCreateBankCard"
                End Select
            End If

            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
            cmd.Parameters("@emplID").Value = emplID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@ofID", SqlDbType.Int))
            cmd.Parameters("@ofID").Value = ofID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@Itogo", SqlDbType.Decimal))
            cmd.Parameters("@Itogo").Value = Itogo * ((100 - Val(Me.tstxtNac.Text)) / 100)

            mcnnInt.Open()
            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Private Sub tsbtnSetPrice_Click(sender As Object, e As EventArgs) Handles tsbtnSetPrice.Click
        If emplID = Module1.NonQuery1Scalar("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
            ModCallForm.CallForm("Быстрый заказ", 2, 2)
        Else
            MsgBox("Доступ запрещен", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub cmbPriceName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPriceName.SelectedValueChanged
        Try
            Dim strSQL$ = "SELECT DISTINCT PriceParam2.ID, PriceParam2.name FROM PriceCost INNER JOIN PriceParam2 ON PriceCost.param2ID=PriceParam2.ID "
            strSQL &= "WHERE PriceParam2.serviceID=" & serviceID & " and PriceCost.priceNameID=" & Me.cmbPriceName.SelectedItem(0) & " order by name"

            'Читаем наименования парметра-2
            Dim odaPriceParam2 As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtPriceParam2 As New DataTable : odaPriceParam2.Fill(dtPriceParam2)
            Me.cmbParam2.DataSource = dtPriceParam2
            Me.cmbParam2.DisplayMember = "name"
            Me.cmbParam2.ValueMember = "ID"

            LoadOper()

        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub ConfigCalc(ByRef ob As Object)
        Dim frmSelect As New frmConfigCalcMat
        Dim c As Control
        'ob контрол к которому привязано меню

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

    Private Sub КофигураторToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsConfigMat.SourceControl)

        LoadMat(Me.lblMatTypes.Text)
    End Sub

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbMatTypes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMatTypes.SelectedValueChanged
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

    Private Sub btnDelRow_Click(sender As Object, e As EventArgs) Handles btnDelRow.Click
        If dtData.Rows.Count > 0 Then
            dtData.Rows.RemoveAt(Me.dgDataTable.CurrentRow.Index)
            Me.dgDataTable.DataSource = dtData

            ColHideDG()

            If dtData.Rows.Count > 0 Then
                Itogo = dtData.Compute("SUM(cost)", "")
            Else
                Itogo = 0
            End If

            Me.tstxtItog.Text = Itogo
        Else
            MsgBox("Готово.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Function CalcCost(quantity As Integer)
        If Me.nudQuantity2.Visible = True Then
            quantity *= 100 * Me.nudQuantity2.Value
        End If

        Dim costFromPrice@
        Dim newCost@ = 0

        If Me.cmbPriceGroup.SelectedIndex = -1 Or Me.cmbPriceName.SelectedIndex = -1 Or Me.cmbParam2.SelectedIndex = -1 Or Me.cmbMat.SelectedIndex = -1 Then
            Return 0
            Exit Function
        Else
            Try
                Dim signFerst As Boolean = True
                Dim strOper$ = Nothing

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

                Dim minTir% = Module1.NonQueryScalarInt("select min(name) from PriceParam1 WHERE groupID=" & Me.cmbPriceGroup.SelectedItem(0) & "")

                If quantity < minTir Then
                    Me.Text = "Минимальный тираж с такими параметрами = " & CStr(minTir)
                    ' Return 0
                    ' Exit Function
                    costFromPrice = Module1.NonQuery1Scalar("Select dbo.[costFastOrder](" & Me.cmbMat.SelectedItem(0) & "," & Me.cmbPriceName.SelectedItem(0) & "," & Me.cmbParam2.SelectedItem(0) & "," & minTir & ",'" & strOper & "')") * (100 + Val(Me.tstxtNac.Text)) / 100

                Else
                    Me.Text = "Быстрые заказы"
                    costFromPrice = Module1.NonQuery1Scalar("Select dbo.[costFastOrder](" & Me.cmbMat.SelectedItem(0) & "," & Me.cmbPriceName.SelectedItem(0) & "," & Me.cmbParam2.SelectedItem(0) & "," & quantity & ",'" & strOper & "')") * (100 + Val(Me.tstxtNac.Text)) / 100
                End If

                newCost = RoundUp(costFromPrice / quantity * 100) / 100 * quantity


                Me.btnAdd.Text = "Стоимость " + Format(newCost, "C").ToString + " Добавить к заказу"
                Me.btnAdd.Enabled = True
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try

            Return newCost
        End If
    End Function

    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMat.SelectedValueChanged
        cost = CalcCost(Me.nudQuantity1.Value)
    End Sub

    Private Sub cmbParam2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbParam2.SelectedValueChanged
        If Module1.NonQuery1ScalarString("SELECT coalesce(description,'') FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "") = "wda" Then
            Me.nudQuantity2.Visible = True
            Me.nudQuantity2.Focus()
        Else
            Me.nudQuantity2.Visible = False
            Me.nudQuantity1.Focus()
        End If

        cost = CalcCost(Me.nudQuantity1.Value)
    End Sub

    Private Sub clbNacenki_SelectedValueChanged(sender As Object, e As EventArgs) Handles clbOper.SelectedValueChanged
        cost = CalcCost(Me.nudQuantity1.Value)
    End Sub

    Private Sub tstxtNac_TextChanged(sender As Object, e As EventArgs) Handles tstxtNac.TextChanged
        Me.tstxtItog.Text = Itogo / 100 * (100 - Val(Me.tstxtNac.Text))
    End Sub

    Private Sub nudQuantity1_GotFocus(sender As Object, e As EventArgs) Handles nudQuantity1.GotFocus
        Me.nudQuantity1.Select(0, (Len(Me.nudQuantity1.Value.ToString)))
    End Sub

    Private Sub nudQuantity1_KeyUp(sender As Object, e As KeyEventArgs) Handles nudQuantity1.KeyUp
        cost = CalcCost(Me.nudQuantity1.Value)
    End Sub

    Private Sub nudQuantity1_MouseClick(sender As Object, e As MouseEventArgs) Handles nudQuantity1.MouseClick
        Me.nudQuantity1.Select(0, (Len(Me.nudQuantity1.Value.ToString)))
    End Sub

    Private Sub nudQuantity1_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity1.ValueChanged
        cost = CalcCost(Me.nudQuantity1.Value)
    End Sub

    Private Sub nudQuantity2_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity2.ValueChanged
        If Me.nudQuantity2.Visible = True Then
            cost = CalcCost(Me.nudQuantity1.Value)
        End If
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(cmsConfigTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub tsbtnCard_Click(sender As Object, e As EventArgs) Handles tsbtnCard.Click
        Oplata(1)
    End Sub
End Class