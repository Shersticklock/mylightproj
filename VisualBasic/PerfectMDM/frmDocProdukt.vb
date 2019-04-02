Public Class frmDocProdukt
    Dim strSQL, strSQL1 As String
    Dim nameColumn As String
    Dim procNotepad As Process
    Public IsAddedPosition As Boolean = False

    Private Sub ProdForInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbTypeCost.SelectedIndex = 0
        'Dim odaProd As SqlClient.SqlDataAdapter
        'Dim dtProd As DataTable = New DataTable

        'Try
        '    odaProd = New SqlClient.SqlDataAdapter(" SELECT ID, name FROM  TypesProdukt", mcnnInt)
        '    dtProd.Clear()
        '    odaProd.Fill(dtProd)
        '    Me.cmbTypeProd.DataSource = dtProd
        '    Me.cmbTypeProd.DisplayMember = "name"
        '    Me.cmbTypeProd.ValueMember = "ID"
        'Catch oexpData As OleDb.OleDbException
        '    MsgBox(oexpData.Message)
        'End Try

        LoadEdIzm()
        LoadProdukts()
    End Sub

#Region " Загружаем единиц измерения "
    Private Sub LoadEdIzm()
        Dim odaProd As New SqlClient.SqlDataAdapter(" SELECT ID, name FROM  Units", mcnnInt)
        Dim dtProd As New DataTable

        Try
            odaProd.Fill(dtProd)

            Me.cmbEdIz1.DataSource = dtProd
            Me.cmbEdIz1.DisplayMember = "name"
            Me.cmbEdIz1.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Private Sub txtFindPr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFindPr.TextChanged
        LoadProdukts()
    End Sub

#Region " Загружаем список продуктов "
    Private Sub LoadProdukts()
        Try
            Dim odaProd As New SqlClient.SqlDataAdapter("SELECT distinct ID, name  FROM awc_Polygraph WHERE name LIKE '%" & Trim(Me.txtFindPr.Text) & "%' order by name", mcnnInt)
            Dim dtProd As New DataTable

            odaProd.Fill(dtProd)
            'Связать данные со списком
            Me.lstProd.DataSource = dtProd
            Me.lstProd.DisplayMember = "name"
            Me.lstProd.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message)
        End Try
    End Sub
#End Region

#Region " Сохранить изменения состава счета "
    Private Sub SaveProd()
        If Me.txtFindPr.Text = "" Then MsgBox("Отсутствует нименование продукции", MessageBoxIcon.Error, appName) : Exit Sub
        If Me.nudQuantity.Value = 0 Then MsgBox("Отсутствует количество продукции", MessageBoxIcon.Error, appName) : Exit Sub
        If Me.cmbTypeCost.SelectedIndex = -1 Then MsgBox("Не выбран тип цены", MessageBoxIcon.Error, appName) : Exit Sub
        If Me.nudCost.Value = 0 Then MsgBox("Некорректная стоимость", MessageBoxIcon.Error, appName) : Exit Sub
        '  Dim typeProd%

        'Select Case Me.cmbTypeProd.SelectedIndex
        '    Case Is = 0 : typeProd = 1 'товар
        '    Case Is = 1 : typeProd = 2 'услуга
        'End Select
        Dim cost@ = 0, total@ = 0

        Select Case Me.cmbTypeCost.SelectedIndex
            Case Is = 0 'Цена за единицу, с НДС (руб.)
                cost = Me.nudCost.Value
                total = Me.nudCost.Value * Me.nudQuantity.Value
            Case Is = 1 'Цена за количество, с НДС (руб.)
                total = Me.nudCost.Value
                cost = Me.nudCost.Value / Me.nudQuantity.Value
        End Select
        'Replace(Me.txtCost.Text, ",", ".") 

        'strSQL = "INSERT INTO Offering (prodName, unitID, kolvo, country, gtd, summa, invoiceID, total)  VALUES "
        'strSQL &= " ('" & Trim(Me.txtFindPr.Text) & "',"
        'strSQL &= " " & Me.cmbEdIz1.SelectedItem(0) & ", " & Me.nudQuantity.Value & ","
        'strSQL &= " '" & Trim(Me.txtCountry.Text) & "', '" & Me.txtGTD.Text & " ', "
        'strSQL &= " " & Replace(cost, ",", ".") & ", " & currentInvoice & ", " & Replace(total, ",", ".") & ") "
        'Module1.NonQuery1(strSQL)

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = "[sp_ProduktInsert]"
        cmd.Parameters.Add(New SqlClient.SqlParameter("@prodName", SqlDbType.NVarChar))
        cmd.Parameters("@prodName").Value = Me.txtFindPr.Text

        cmd.Parameters.Add(New SqlClient.SqlParameter("@unitID", SqlDbType.Int))
        cmd.Parameters("@unitID").Value = Me.cmbEdIz1.SelectedItem(0)

        cmd.Parameters.Add(New SqlClient.SqlParameter("@kolvo", SqlDbType.Decimal))
        cmd.Parameters("@kolvo").Value = Me.nudQuantity.Value

        cmd.Parameters.Add(New SqlClient.SqlParameter("@country", SqlDbType.NVarChar))
        cmd.Parameters("@country").Value = Trim(Me.txtCountry.Text)

        cmd.Parameters.Add(New SqlClient.SqlParameter("@gtd", SqlDbType.NVarChar))
        cmd.Parameters("@gtd").Value = Me.txtGTD.Text

        cmd.Parameters.Add(New SqlClient.SqlParameter("@summa", SqlDbType.Decimal))
        cmd.Parameters("@summa").Value = cost

        cmd.Parameters.Add(New SqlClient.SqlParameter("@invoiceID", SqlDbType.Int))
        cmd.Parameters("@invoiceID").Value = currentInvoice

        cmd.Parameters.Add(New SqlClient.SqlParameter("@total", SqlDbType.Decimal))
        cmd.Parameters("@total").Value = total

        cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
        cmd.Parameters("@orgID").Value = 0

        mcnnInt.Open()
        cmd.ExecuteNonQuery()
        mcnnInt.Close()
        isAddedPosition = True
        '  MsgBox("Выполнено", MsgBoxStyle.Information, appName)
        Me.Close()
    End Sub
#End Region

    Private Sub lstProd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProd.DoubleClick
        Me.txtFindPr.Text = Trim(Me.lstProd.SelectedItem(1).ToString)
    End Sub

#Region " Добавить наименование в справочник "
    Private Sub AddRow()
        Dim produkt, newProdukt As String

        produkt = InputBox(Prompt:="Введите наименование", Title:=appName, DefaultResponse:="")

        If Len(produkt) = 0 Then
            MsgBox("Новое наименование НЕ добавлено. ", MessageBoxIcon.Error) : Exit Sub
        Else
            newProdukt = produkt
        End If

        Try
            Dim mdrProdukt As DataRow
            Dim dtProdukt As New DataTable
            Dim ocbProdukt As SqlClient.SqlCommandBuilder
            Dim modaProdukt As New SqlClient.SqlDataAdapter(strSQL1, mcnnInt)
            'Заполнить набор данных
            modaProdukt.Fill(dtProdukt)
            'заполнение строки затрат
            mdrProdukt = dtProdukt.NewRow
            mdrProdukt.BeginEdit()
            'запись в таблицу
            mdrProdukt(nameColumn) = newProdukt
            mdrProdukt("description") = ""
            'Завершить редактировать строку данных
            mdrProdukt.EndEdit()
            dtProdukt.Rows.Add(mdrProdukt)
            ocbProdukt = New SqlClient.SqlCommandBuilder(modaProdukt)
            modaProdukt.InsertCommand = ocbProdukt.GetInsertCommand
            modaProdukt.Update(dtProdukt)
            dtProdukt.AcceptChanges()
            modaProdukt.InsertCommand.Connection.Close()
        Catch excData As System.Exception
            MsgBox("error" & excData.Message)
        End Try
    End Sub
#End Region

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        SaveProd()
    End Sub

    Private Sub tsbtnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCalc.Click
        procNotepad = Process.Start("calc.exe")
    End Sub

    Private Sub tsbtnNewProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNewProd.Click
        '  strSQL1 = " SELECT * FROM Produkts "
        ' nameColumn = "name"

        ModCallForm.CallForm("Новая продукция", 42, 3)

        '  AddRow()
        LoadProdukts()
    End Sub

    Private Sub tsbtnEdIzm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdIzm.Click
        strSQL1 = " SELECT * FROM Units "
        nameColumn = "name"
        AddRow()
        LoadEdIzm()
    End Sub

    Private Sub nudCost_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles nudCost.KeyDown
        If e.KeyCode = Keys.Enter Then SaveProd()
        e.Handled = True
    End Sub

End Class