Public Class FRDirectoryForm
    Private Sub FRDirectoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFiscalRegistrars()
    End Sub

    Private Sub LoadFiscalRegistrars()
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_GetFiscalRegistrars"
            cmd.CommandType = CommandType.StoredProcedure
            
            Dim frSqlDataAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
            Dim frDataTable As DataTable = New DataTable()
            frSqlDataAdapter.Fill(frDataTable)

            FRDataGridView.DataSource = frDataTable
        Catch excData As Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub AddFRButton_Click(sender As Object, e As EventArgs) Handles AddFRButton.Click
        Dim addFrForm As AddFRForm = New AddFRForm()
        addFrForm.NoteID = 0
        addFrForm.ShowDialog(Me)
        LoadFiscalRegistrars()
    End Sub

    Private Sub EditFRButton_Click(sender As Object, e As EventArgs) Handles EditFRButton.Click
        If (FRDataGridView.SelectedRows.Count <= 0) Then
            MessageBox.Show("Не выбрана запись для изменения!", "Ошибка")
            Exit Sub
        End If

        Dim addFrForm As AddFRForm = New AddFRForm()
        Dim id As Integer = FRDataGridView.SelectedRows(0).Cells("ID").Value
        addFrForm.NoteId = id
        addFrForm.ShowDialog(Me)
        LoadFiscalRegistrars()
    End Sub

    Private Sub DeleteFRButton_Click(sender As Object, e As EventArgs) Handles DeleteFRButton.Click
        If (FRDataGridView.SelectedRows.Count <= 0) Then
            MessageBox.Show("Не выбрана запись для удаления!", "Ошибка")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Удалить выбранную позицию?", "Удаление позиции", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow
            selectedRow = FRDataGridView.SelectedRows(0)
            Dim selectedId = selectedRow.Cells("ID").Value
            Module1.NonQuery1("DELETE FROM FiscalRegistrar WHERE ID = " & selectedId)
            LoadFiscalRegistrars()
        End If
    End Sub
End Class