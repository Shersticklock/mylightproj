Imports System.Data.SqlClient

Public Class OnlinePaymentDirectoryForm
    Private Sub OnlinePaymentDirectoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOnlinePaymentsTypes()
    End Sub

    Private Sub LoadOnlinePaymentsTypes()
        Try
            Dim sql As String
            sql = "SELECT opt.ID, opt.name As Название, org.Name As [Юр. лицо], opt.isActive As Активность FROM OnlinePaymentsType opt INNER JOIN Organizations org ON org.custID = opt.orgID"

            Dim sqlDataAdapter As New SqlDataAdapter(sql, mcnnInt)
            Dim dataTable As New DataTable()
            sqlDataAdapter.Fill(dataTable)
            OnlinePaymentsTypeDataGridView.DataSource = dataTable
        Catch excData As Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub AddOnlinePaymentsTypeButton_Click(sender As Object, e As EventArgs) Handles AddOnlinePaymentsTypeButton.Click
        Dim addOnlinePaymentForm As AddOnlinePaymentForm = New AddOnlinePaymentForm()
        addOnlinePaymentForm.NoteID = 0
        addOnlinePaymentForm.ShowDialog(Me)
        LoadOnlinePaymentsTypes()
    End Sub

    Private Sub EditOnlinePaymentsTypeButton_Click(sender As Object, e As EventArgs) Handles EditOnlinePaymentsTypeButton.Click
        If (OnlinePaymentsTypeDataGridView.SelectedRows.Count <= 0) Then
            MessageBox.Show("Не выбрана запись для изменения!", "Ошибка")
            Exit Sub
        End If

        Dim addOnlinePaymentForm As AddOnlinePaymentForm = New AddOnlinePaymentForm()
        Dim id As Integer = OnlinePaymentsTypeDataGridView.SelectedRows(0).Cells("ID").Value
        addOnlinePaymentForm.NoteId = id
        addOnlinePaymentForm.ShowDialog(Me)
        LoadOnlinePaymentsTypes()
    End Sub

    Private Sub DeleteOnlinePaymentsTypeButton_Click(sender As Object, e As EventArgs) Handles DeleteOnlinePaymentsTypeButton.Click
        If (OnlinePaymentsTypeDataGridView.SelectedRows.Count <= 0) Then
            MessageBox.Show("Не выбрана запись для удаления!", "Ошибка")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Удалить выбранную позицию?", "Удаление позиции", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow
            selectedRow = OnlinePaymentsTypeDataGridView.SelectedRows(0)
            Dim selectedId = selectedRow.Cells("ID").Value
            Module1.NonQuery1("DELETE FROM OnlinePaymentsType WHERE ID = " & selectedId)
            LoadOnlinePaymentsTypes()
        End If
    End Sub
End Class