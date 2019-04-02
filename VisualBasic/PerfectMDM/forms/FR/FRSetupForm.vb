Imports Cassa

Public Class FRSetupForm
    Private Sub FRSetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFiscalRegistrars()

        RestoreValues()
    End Sub

    Private Sub LoadFiscalRegistrars()
        SelectFRComboBox.ValueMember = "ID"
        SelectFRComboBox.DisplayMember = "Name"

        Try
            Dim sql As String = "SELECT ID As 'ID', ('(ID ' + CAST(ID As varchar)  + ') ' + shortName) AS 'Name' FROM FiscalRegistrar"
            Dim frSqlDataAdapter As New SqlClient.SqlDataAdapter(sql, mcnnInt)
            Dim frDataTable As DataTable = New DataTable()
            frSqlDataAdapter.Fill(frDataTable)

            SelectFRComboBox.DataSource = frDataTable
        Catch excData As Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub RestoreValues()
        Try
            Dim id As Integer = KeySettings.GetValue("IDkassa")
            Dim connectToFr As Boolean = KeySettings.GetValue("connectToFR")
            Dim tcpConnection As Boolean = KeySettings.GetValue("tcpKassa")

            If (id > 0) Then
                SelectFRComboBox.SelectedValue = id
            End If

            ConnectToFRCheckBox.Checked = connectToFr
            TCPConnectionCheckBox.Checked = tcpConnection
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckConnectionButton_Click(sender As Object, e As EventArgs) Handles CheckConnectionButton.Click
        Dim id As Integer = SelectFRComboBox.SelectedValue
        Dim sql As String = "SELECT ID, comPort, password, computerIP, isVirtual FROM FiscalRegistrar WHERE ID = " & id & ""
        Dim frSqlDataAdapter As New SqlClient.SqlDataAdapter(sql, mcnnInt)
        Dim frDataTable As DataTable = New DataTable()
        frSqlDataAdapter.Fill(frDataTable)

        Dim port As Integer = frDataTable.Rows(0).Item("comPort")
        Dim password As String = frDataTable.Rows(0).Item("password")
        Dim ip As String = frDataTable.Rows(0).Item("computerIP")
        Dim isVirtual As Boolean = frDataTable.Rows(0).Item("isVirtual")
        Dim connectToFr As Boolean = ConnectToFRCheckBox.Checked
        Dim tcpConnection As Boolean = TCPConnectionCheckBox.Checked

        If (isVirtual) Then
            SaveSettings(port, password, ip, id, connectToFr, tcpConnection)
            MessageTextBox.Text = "Настройки виртуальной кассы сохранены!"
        Else
            Dim cassaHelper As CassaHelper = New CassaHelper()
            If (tcpConnection) Then
                cassaHelper.CheckConnection(port, password, ip)
            Else
                cassaHelper.CheckConnection(port, password)
            End If
            Dim response = "(" & cassaHelper.ResultCode & ") " & cassaHelper.ResultCodeDescription
            MessageTextBox.Text = response
            If (cassaHelper.ResultCode = 0) Then
                SaveSettings(port, password, ip, id, connectToFr, tcpConnection)
            End If
        End If
    End Sub

    Private Sub SaveSettings(port As Integer, password As String, ip As String, id As Integer, connectToFr As Boolean, tcpConnection As Boolean)
        KeySettings.SetValue("portKassa", port)
        KeySettings.SetValue("passKassa", password)
        KeySettings.SetValue("IPkassa", ip)
        KeySettings.SetValue("IDkassa", id)
        KeySettings.SetValue("connectToFR", connectToFr)
        KeySettings.SetValue("tcpKassa", tcpConnection)
    End Sub
End Class