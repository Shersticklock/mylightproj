Public Class tech_OperParam

    Dim mdsPersonIndiv As DataSet
    Dim modaPersonIndiv As SqlClient.SqlDataAdapter
    Dim mdrPersonIndiv As DataRow
    Dim mblnAdd As Boolean
    Dim currentRow As Integer

    Private Sub frmTechOperParam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterParamTechOp]"
        cmd.CommandType = CommandType.StoredProcedure

        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)

        Me.cmbParamTechOper.DataSource = dtMan
        Me.cmbParamTechOper.DisplayMember = "Name"
        Me.cmbParamTechOper.ValueMember = "ID"

        Dim dtDep As New DataTable : odaMan.Fill(dtDep)

        Me.cmbDep.DataSource = dtDep
        Me.cmbDep.DisplayMember = "Name"
        Me.cmbDep.ValueMember = "ID"

        Dim odaTypeOper As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM tech_OperTypes", mcnnInt)
        Dim dtTypeOper As New DataTable : odaTypeOper.Fill(dtTypeOper)

        Me.cmbTypeOper.DataSource = dtTypeOper
        Me.cmbTypeOper.DisplayMember = "Name"
        Me.cmbTypeOper.ValueMember = "ID"
 
        Dim odaMatFormat As New SqlClient.SqlDataAdapter("SELECT ID, formatName FROM MatFormats order by formatName", mcnnInt)
        Dim dtMatFormat As New DataTable : odaMatFormat.Fill(dtMatFormat)

        Me.clbPrintFormat.DataSource = dtMatFormat
        Me.clbPrintFormat.DisplayMember = "formatName"
        Me.clbPrintFormat.ValueMember = "ID"

        Dim odaMatFormat1 As New SqlClient.SqlDataAdapter("SELECT ID, formatName FROM MatFormats order by formatName", mcnnInt)
        Dim dtMatFormat1 As New DataTable : odaMatFormat1.Fill(dtMatFormat1)

        Me.clbDouble.DataSource = dtMatFormat1
        Me.clbDouble.DisplayMember = "formatName"
        Me.clbDouble.ValueMember = "ID"

        ActivateEditing(False)
    End Sub

#Region " Загрузка лист "
    Private Sub LoadList()
        Try
            mdsPersonIndiv = New DataSet

            modaPersonIndiv = New SqlClient.SqlDataAdapter("SELECT * FROM tech_Operations WHERE ParamTechOperID=" & Me.cmbDep.SelectedItem(0) & " order by name", mcnnInt)
            modaPersonIndiv.FillSchema(mdsPersonIndiv, 2, "Services") 'загружаем схему для работы получения строки
            modaPersonIndiv.Fill(mdsPersonIndiv, "Services")

            Me.lstData.DataSource = mdsPersonIndiv.Tables("Services")
            Me.lstData.DisplayMember = "Name"
            Me.lstData.ValueMember = "ID"
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub
#End Region

#Region " Перемещение "
    Private Sub LoadIndividual()
        Dim strName As String
        Dim oCtl2 As Object

        If Me.lstData.SelectedIndex <> -1 Then
            'Нахождение единственной строки в дата сете по идентификатору
            mdrPersonIndiv = mdsPersonIndiv.Tables("Services").Rows.Find(Me.lstData.SelectedItem(0))

            For Each oCtl2 In Me.tlpParam.Controls
                If TypeOf oCtl2 Is TextBox Then
                    strName = Mid(oCtl2.name, 4)

                    Try
                        oCtl2.text = mdrPersonIndiv(strName).ToString
                    Catch oexp As System.Exception
                    End Try
                End If
            Next

            Me.cmbParamTechOper.SelectedValue = mdrPersonIndiv("ParamTechOperID") 'депратмент или оборудование

            Me.nudKC.Value = mdrPersonIndiv("KC")
            Me.nudAC.Value = mdrPersonIndiv("AC")
            Me.nudKT.Value = mdrPersonIndiv("KT")
            Me.nudAT.Value = mdrPersonIndiv("AT")

            Me.nudSaleK1.Value = mdrPersonIndiv("SaleK1")
            Me.nudSaleK2.Value = mdrPersonIndiv("SaleK2")
            Me.nudSaleA.Value = mdrPersonIndiv("SaleA")
            Me.nudSaleMin.Value = mdrPersonIndiv("SaleMin")
            Me.nudSaleMax.Value = mdrPersonIndiv("SaleMax")

            Me.chkDefaultState.Checked = mdrPersonIndiv("defaultState")
            Me.cmbTypeOper.SelectedValue = mdrPersonIndiv("typeOperID")
            Me.chkMatForOper.Checked = mdrPersonIndiv("matForOper")

            Dim n As Integer = 0
            Dim nv As Integer = 0

            Try
                Dim numbers As New ArrayList()

                For Each itemChecked As Object In Me.clbPrintFormat.Items
                    If NonQueryScalarInt("SELECT count(*) FROM tech_OperFormat WHERE operID=" & Me.lstData.SelectedItem(0) & " AND printFormatID=" & itemChecked.item(0) & "") = 0 Then
                        numbers.Add(0)
                    Else
                        numbers.Add(1)
                    End If

                    n += 1
                Next

                For nv = 0 To Me.clbPrintFormat.Items.Count - 1
                    '    ' тут ломается не установить новые значения
                    Me.clbDouble.SetItemChecked(nv, CType(numbers(nv), Boolean))
                    '    itemChecked.SetItemChecked(nv, CType(numbers(nv), Boolean))
                Next


            Catch oexpData As System.Exception
                MessageBox.Show("Ошибка при777. " & oexpData.Message, appName)
                Exit Sub
            End Try
        Else
            For Each oCtl2 In Me.tlpParam.Controls
                If TypeOf oCtl2 Is TextBox Then
                    strName = Mid(oCtl2.name, 4)

                    Try
                        oCtl2.text = ""
                    Catch oexp As System.Exception
                    End Try
                End If
            Next

            Me.cmbParamTechOper.SelectedIndex = -1

            Me.nudKC.Value = 0
            Me.nudAC.Value = 0
            Me.nudKT.Value = 0
            Me.nudAT.Value = 0

            Me.nudSaleK1.Value = 0
            Me.nudSaleK2.Value = 0
            Me.nudSaleA.Value = 0
            Me.nudSaleMin.Value = 0
            Me.nudSaleMax.Value = 0
        End If
    End Sub
#End Region

#Region " Сохранить изменения "
    Private Sub SaveRecord()
        If Me.txtName.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtName, "Поле")
            Me.txtName.Focus()
            Exit Sub
        End If

        If Me.cmbParamTechOper.SelectedIndex = -1 Then ' наименование
            Me.ErrorProvider1.SetError(Me.cmbParamTechOper, "Значение должно быть задано")
            Me.cmbParamTechOper.Focus()
            Exit Sub
        End If

        If Me.cmbTypeOper.SelectedIndex = -1 Then ' наименование
            Me.ErrorProvider1.SetError(Me.cmbTypeOper, "Значение должно быть задано")
            Me.cmbTypeOper.Focus()
            Exit Sub
        End If

        Try
            Dim strName As String
            Dim oCtl As Object

            If mblnAdd = True Then
                mdrPersonIndiv = mdsPersonIndiv.Tables("Services").NewRow
            End If

            mdrPersonIndiv.BeginEdit() 'приступить к редактированию строки

            For Each oCtl In Me.tlpParam.Controls
                If TypeOf oCtl Is TextBox Then
                    strName = Mid(oCtl.name, 4)

                    Try
                        mdrPersonIndiv(strName) = oCtl.text
                    Catch oexp As System.Exception
                    End Try
                End If
            Next

            mdrPersonIndiv("KC") = Me.nudKC.Value
            mdrPersonIndiv("AC") = Me.nudAC.Value
            mdrPersonIndiv("KT") = Me.nudKT.Value
            mdrPersonIndiv("AT") = Me.nudAT.Value

            mdrPersonIndiv("SaleK1") = Me.nudSaleK1.Value
            mdrPersonIndiv("SaleK2") = Me.nudSaleK2.Value
            mdrPersonIndiv("SaleA") = Me.nudSaleA.Value
            mdrPersonIndiv("SaleMin") = Me.nudSaleMin.Value
            mdrPersonIndiv("SaleMax") = Me.nudSaleMax.Value
            mdrPersonIndiv("typeOperID") = Me.cmbTypeOper.SelectedItem(0)
            mdrPersonIndiv("ParamTechOperID") = Me.cmbParamTechOper.SelectedItem(0)
            mdrPersonIndiv("defaultState") = CInt(Me.chkDefaultState.Checked)
            mdrPersonIndiv("matForOper") = CInt(Me.chkMatForOper.Checked)

            mdrPersonIndiv.EndEdit() 'Завершить редактирование строки данных

            Dim ocbPersonIndiv As SqlClient.SqlCommandBuilder 'создать экземпляр пострителя команды
            ocbPersonIndiv = New SqlClient.SqlCommandBuilder(modaPersonIndiv)

            If mblnAdd = True Then
                mdsPersonIndiv.Tables("Services").Rows.Add(mdrPersonIndiv)
                modaPersonIndiv.InsertCommand = ocbPersonIndiv.GetInsertCommand  ' Обеспечить создание оператора Insert SQL
            Else
                modaPersonIndiv.UpdateCommand = ocbPersonIndiv.GetUpdateCommand
            End If

            modaPersonIndiv.Update(mdsPersonIndiv, "Services") 'выполнить команду SQL и закрыть соед.
            mdsPersonIndiv.Tables("Services").AcceptChanges()

            Dim signFerst As Boolean = True
            Dim strOper$ = ""

            For Each itemChecked1 As Object In Me.clbPrintFormat.CheckedItems
                If signFerst = False Then
                    strOper += "," + itemChecked1.item(0).ToString
                Else
                    strOper = itemChecked1.item(0).ToString
                    signFerst = False
                End If
            Next

            Dim cmd As New SqlClient.SqlCommand

            Try
                cmd.Connection = mcnnInt
                cmd.CommandText = "sp_InsOperFormat"
                cmd.CommandType = CommandType.StoredProcedure

                'Описываем параметры
                If mblnAdd = True Then
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
                    cmd.Parameters("@operID").Value = Module1.NonQueryScalarInt("SELECT MAX(ID) FROM tech_Operations")
                Else
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
                    cmd.Parameters("@operID").Value = Me.lstData.SelectedItem(0)
                End If

                cmd.Parameters.Add(New SqlClient.SqlParameter("@OperStr", SqlDbType.NVarChar))
                cmd.Parameters("@OperStr").Value = strOper

                mcnnInt.Open()
                cmd.ExecuteNonQuery()
            Catch excp As System.Exception
                MessageBox.Show(excp.Message, appName)
                Exit Sub
            Finally
                mcnnInt.Close()
            End Try

            If mblnAdd = True Then
                LoadList()

                Me.lstData.SelectedIndex = Me.lstData.Items.Count - 1
                mblnAdd = False
            Else
                '      MsgBox("gg")
                '  Me.lstData.SelectedIndex = currentRow
                '    LoadIndividual()
            End If


            ActivateEditing(False)

            LoadIndividual()
        Catch excData As System.Exception
            MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " Меню "
    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        mblnAdd = True

        Dim oCtl As Object

        For Each oCtl In Me.tlpParam.Controls
            If TypeOf oCtl Is TextBox Then
                oCtl.text = ""
            End If
        Next

        ActivateEditing(True)
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        SaveRecord()
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        If Me.lstData.SelectedItems.Count = 0 Then
            MsgBox("Не выбрана операция для редактирования.", MsgBoxStyle.Critical, appName) : Exit Sub
        Else
            currentRow = Me.lstData.SelectedIndex

            ActivateEditing(True)

            LoadIndividual()
        End If
    End Sub

#Region " Активация редактирования  "
    Private Sub ActivateEditing(ByVal bEnable As Boolean)

        Dim oCtl As Object

        For Each oCtl In Me.tlpParam.Controls
            If TypeOf oCtl Is TextBox Or TypeOf oCtl Is CheckBox Then
                If bEnable Then
                    ' oCtl.BorderStyle() = System.Windows.Forms.BorderStyle.Fixed3D
                    oCtl.BackColor() = System.Drawing.Color.White
                Else
                    'oCtl.BorderStyle() = System.Windows.Forms.BorderStyle.FixedSingle
                    oCtl.BackColor() = System.Drawing.Color.White
                    'oCtl2.BackColor() = Me.BackColor
                End If
                oCtl.enabled = bEnable
                'oCtl.readOnly = Not bEnable
            End If

            If TypeOf oCtl Is NumericUpDown Or TypeOf oCtl Is ComboBox Then
                oCtl.enabled = bEnable
            End If

            Me.tsbtnNew.Enabled = Not bEnable
            Me.lstData.Enabled = Not bEnable
            Me.clbPrintFormat.Enabled = bEnable

            Me.clbPrintFormat.Visible = bEnable
            Me.clbDouble.Visible = Not bEnable
            Me.Label12.Visible = bEnable

            Me.txtName.Focus()
        Next
    End Sub
#End Region

    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        Me.ErrorProvider1.Clear()
        Dim current As Integer = Me.lstData.SelectedIndex

        If mblnAdd Then
            mblnAdd = False
        End If

        ActivateEditing(False)

        Me.lstData.SelectedIndex = current
    End Sub

    Private Sub tsbtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelete.Click

        Dim resp2% = MessageBox.Show("Удалить " & Trim(CStr(mdrPersonIndiv("Name"))) & "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp2 = DialogResult.Yes Then
            Dim ocbPartIndiv As SqlClient.SqlCommandBuilder

            Try
                mdrPersonIndiv.Delete()
                ocbPartIndiv = New SqlClient.SqlCommandBuilder(modaPersonIndiv)
                modaPersonIndiv.DeleteCommand = ocbPartIndiv.GetDeleteCommand
                modaPersonIndiv.Update(mdsPersonIndiv.Tables("Services"))
                mdsPersonIndiv.Tables("Services").AcceptChanges()
                modaPersonIndiv.DeleteCommand.Connection.Close()
            Catch excData As System.Exception
                MessageBox.Show("Error Occured:" & excData.Message, appName)
            End Try

            ActivateEditing(False)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
#End Region

    Private Sub cmbDep_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDep.SelectedValueChanged
        ' If Me.cmbDep.SelectedIndex <> -1 Then
        LoadList()   ' загружаем список 
        '   End If
    End Sub

    Private Sub lstData_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstData.SelectedValueChanged
        LoadIndividual()
    End Sub

    Private Sub cmbTypeOper_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeOper.SelectedIndexChanged
        If Me.cmbTypeOper.SelectedIndex <> -1 Then
            Me.ErrorProvider1.SetError(Me.cmbTypeOper, "")
        End If
    End Sub

    Private Sub cmbParamTechOper_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbParamTechOper.SelectedIndexChanged
        If Me.cmbParamTechOper.SelectedIndex <> -1 Then
            Me.ErrorProvider1.SetError(Me.cmbParamTechOper, "")
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If Me.txtName.Text <> "" Then
            Me.ErrorProvider1.SetError(Me.txtName, "")
        End If
    End Sub

    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged

    End Sub
End Class