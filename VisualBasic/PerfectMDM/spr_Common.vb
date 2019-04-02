Public Class spr_Common
    Dim modaLookupData As SqlClient.SqlDataAdapter
    Dim dtData As DataTable
    Dim curRow As Integer

    Private Sub spr_Common_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '   LoadData()
    End Sub

    Private Sub Spr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = sprCaption
        LoadData()
    End Sub

#Region " Загрузить данные "
    Private Sub LoadData()
        Try
            dtData = New DataTable
            '  dtData.Clear()

            modaLookupData = New SqlClient.SqlDataAdapter(spravSQL, mcnnInt)
            modaLookupData.Fill(dtData)

            Dim viewDT As New DataView(dtData)
            viewDT.Sort = "name"

            Me.dgTableData.DataSource = viewDT

            Me.dgTableData.Columns("ID").Visible = False 'скрываем первую колонку с ид
            '  Me.dgTableData.Columns(1).Width = 232
            '  Me.dgTableData.Columns(2).Width = 232
            Me.dgTableData.ClearSelection()
        Catch excData As System.Exception
            MessageBox.Show(excData.Message)
        End Try
    End Sub
#End Region

#Region " Выход "
    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Dim resp As Integer
        Dim sMsg As String

        sMsg = "Закончить работу со справочником? "
        resp = MessageBox.Show(sMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then Me.Close()
    End Sub
#End Region

#Region " Измененить "
    Private Sub dgTableData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTableData.DoubleClick
        EditRow()
    End Sub

    Private Sub EditRow()
        If Me.dgTableData.SelectedCells.Count = 0 Then
            MsgBox("Не выбрана строка для редактирования.", MsgBoxStyle.Critical, appName)
        Else
            curRow = Me.dgTableData.CurrentRow.Index

            Dim modaRow As New SqlClient.SqlDataAdapter(spravSQL + " WHERE ID=" & Me.dgTableData(0, curRow).Value() & "", mcnnInt)
            Dim dtRowData As New DataTable : modaRow.Fill(dtRowData)
            Dim dr As DataRow = dtRowData.Rows(0)

            spr_Dialog.TextBox1.Text = dr("name")
            spr_Dialog.TextBox2.Text = dr("description")

            spr_Dialog.ShowDialog()

            If spr_Dialog.DialogResult = DialogResult.OK Then
                Try
                    dr.BeginEdit()

                    dr("name") = Trim(spr_Dialog.TextBox1.Text)
                    dr("description") = Trim(spr_Dialog.TextBox2.Text)

                    dr.EndEdit()

                    Dim ocbIndiv As SqlClient.SqlCommandBuilder

                    ocbIndiv = New SqlClient.SqlCommandBuilder(modaRow)
                    modaRow.UpdateCommand = ocbIndiv.GetUpdateCommand
                    modaRow.Update(dtRowData)
                    dtRowData.AcceptChanges()
                    modaRow.UpdateCommand.Connection.Close()

                    LoadData()

                    Me.dgTableData.Rows(curRow).Selected = True
                Catch oexpData As System.Exception
                    MessageBox.Show("Error loading individual data: " & oexpData.Message, appName)
                End Try
            Else
                spr_Dialog = Nothing
            End If
        End If
    End Sub
#End Region

#Region " Удалить "
    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        If Me.dgTableData.SelectedRows.Count = 0 Then MsgBox("Выбери позицию для удаления. ") : Exit Sub

        Dim modaRow As New SqlClient.SqlDataAdapter(spravSQL + " WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value().ToString & "", mcnnInt)

        Dim dtRowData As New DataTable : modaRow.Fill(dtRowData)

        Dim dr As DataRow = dtRowData.Rows(0)
        Dim resp As Integer = MsgBox(Prompt:="Удалить " & Trim(dr("name")) & "? ", Buttons:=vbYesNo, Title:=appName)

        Select Case resp
            Case Is = vbYes
                Dim ocbIndiv As SqlClient.SqlCommandBuilder

                Try
                    dr.Delete()
                    ocbIndiv = New SqlClient.SqlCommandBuilder(modaRow)
                    modaRow.DeleteCommand = ocbIndiv.GetDeleteCommand
                    modaRow.Update(dtRowData)
                    dtRowData.AcceptChanges()
                    modaRow.DeleteCommand.Connection.Close()

                    LoadData()
                Catch oexpData As System.Exception
                    MsgBox("Возникла ошибка при удалении. " & Chr(13) & "Скорее всего с этим объектом связан другой объект." & Chr(13) & oexpData.Message)
                End Try
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub
#End Region

#Region " Добавить "
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        spr_Dialog.ShowDialog()

        If spr_Dialog.DialogResult = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim dr As DataRow = dtData.NewRow()

                dr("name") = Trim(spr_Dialog.TextBox1.Text)
                dr("description") = Trim(spr_Dialog.TextBox2.Text)

                dtData.Rows.Add(dr)

                Dim ocbIndiv As SqlClient.SqlCommandBuilder

                ocbIndiv = New SqlClient.SqlCommandBuilder(modaLookupData)
                modaLookupData.InsertCommand = ocbIndiv.GetInsertCommand
                modaLookupData.Update(dtData)
                dtData.AcceptChanges()
                modaLookupData.InsertCommand.Connection.Close()

                LoadData()
            Catch excData As System.Exception
                MsgBox("error" & excData.Message, MsgBoxStyle.Critical, appName)
            End Try
        Else
            spr_Dialog = Nothing
        End If
    End Sub
#End Region


    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        EditRow()

        LoadData()
    End Sub
End Class