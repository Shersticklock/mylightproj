Public Class tech_OperCost
    Dim addFundCost As Boolean


    Private Sub tech_OperCost_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim odaEquipment As SqlClient.SqlDataAdapter
        Dim dtEquipment As DataTable = New DataTable

        Try
            odaEquipment = New SqlClient.SqlDataAdapter("SELECT ID, Name FROM tech_Equipment ", mcnnInt)
            odaEquipment.Fill(dtEquipment)

            Me.cmbEquip.DataSource = dtEquipment
            Me.cmbEquip.DisplayMember = "Name"
            Me.cmbEquip.ValueMember = "ID"

        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try

        Dim odaOperType As SqlClient.SqlDataAdapter
        Dim dtOperType As DataTable = New DataTable

        Try
            odaOperType = New SqlClient.SqlDataAdapter("SELECT ID, Name FROM tech_OperTypes ", mcnnInt)
            odaOperType.Fill(dtOperType)

            Me.cmbOperType.DataSource = dtOperType
            Me.cmbOperType.DisplayMember = "Name"
            Me.cmbOperType.ValueMember = "ID"

        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try

        Dim odaOper As SqlClient.SqlDataAdapter
        Dim dtOper As DataTable = New DataTable

        Try
            odaOper = New SqlClient.SqlDataAdapter("SELECT ID, Name FROM tech_Operations", mcnnInt)
            odaOper.Fill(dtOper)

            Me.lstOperations.DataSource = dtOper
            Me.lstOperations.DisplayMember = "Name"
            Me.lstOperations.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub LoadPrice()
        Dim objDA As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Tech_OperCost"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ID_equip", SqlDbType.Int))
            cmd.Parameters("@ID_equip").Value = Me.cmbEquip.SelectedItem(0)

            objDA = New SqlClient.SqlDataAdapter(cmd)

            Dim dtItog As New DataTable

            objDA.Fill(dtItog)
            Me.dgPrice.DataSource = dtItog

            For n As Integer = 0 To Me.dgPrice.ColumnCount - 1
                If Me.dgPrice.Columns(n).Name = "ID" Then
                    Me.dgPrice.Columns("ID").Visible = False 'скрываем колонку с ид
                End If
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub ДобавитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ДобавитьToolStripMenuItem.Click
        addFundCost = True
        Me.tlpRow.Enabled = True
    End Sub

    Private Sub ИзменитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ИзменитьToolStripMenuItem.Click
        addFundCost = False
        Try
            Dim ID% = Me.dgPrice("ID", Me.dgPrice.CurrentRow.Index).Value()
            Me.nudCost.Value = Module1.NonQuery1Scalar("SELECT coalesce(Cost, 0) FROM tech_OperCost WHERE ID = " & ID & " ")
            Me.nudProd.Value = Module1.NonQuery1Scalar("SELECT coalesce(productivity, 0) FROM tech_OperCost WHERE ID = " & ID & " ")
            Me.cmbOperType.SelectedValue = Module1.NonQuery1Scalar("SELECT operType_ID FROM tech_OperCost WHERE ID = " & ID & " ")
            Me.lstOperations.SelectedValue = Module1.NonQuery1Scalar("SELECT oper_ID FROM tech_OperCost WHERE ID = " & ID & " ")
            Me.tlpRow.Enabled = True
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub УдалитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles УдалитьToolStripMenuItem.Click
        Try
            Dim str5SQL As String = "DELETE FROM OperPrintCost WHERE ID = " & Me.dgPrice("ID", Me.dgPrice.CurrentRow.Index).Value() & " "
            Select Case MsgBox(Prompt:="Удалить строку?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1(str5SQL)
                    LoadPrice()
                Case Is = vbNo
                    Exit Sub
            End Select
        Catch ex As System.Exception
            MsgBox("Возможно не выбрана строка для удаления." & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    

    Private Sub cmbEquip_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbEquip.SelectedValueChanged
        LoadPrice()
    End Sub

    Private Sub cmbEquip_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbEquip.SelectedIndexChanged

    End Sub

    Private Sub btnSaveCost_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCost.Click
        If addFundCost = True Then
            Dim strSQL$ = "INSERT INTO tech_OperCost (equip_ID, oper_ID, operType_ID, Cost, Prod) VALUES (" & Me.cmbEquip.SelectedItem(0) & ", "
            strSQL &= " " & Me.lstOperations.SelectedItem(0) & ", " & Me.cmbOperType.SelectedItem(0) & ", " & Replace(Me.nudCost.Value, ",", ".") & ", " & Replace(Me.nudProd.Value, ",", ".") & ")"
            Module1.NonQuery1(strSQL)
        Else
            Module1.NonQuery1("UPDATE tech_OperCost SET equip_ID = " & Me.cmbEquip.SelectedItem(0) & ", oper_ID = " & Me.lstOperations.SelectedItem(0) & ", operType_ID = " & Me.cmbOperType.SelectedItem(0) & ", Cost = " & Replace(Me.nudCost.Value, ",", ".") & ", Prod = " & Replace(Me.nudProd.Value, ",", ".") & " WHERE ID = " & Me.dgPrice("ID", Me.dgPrice.CurrentRow.Index).Value() & " ")
        End If

        Me.tlpRow.Enabled = False

        LoadPrice()
    End Sub
End Class