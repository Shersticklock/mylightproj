Public Class frmMatFormatInOut

#Region " Загрузка формы "
    Private Sub frmMatFormatInOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dtMatIN As DataTable = New DataTable
            Dim odaMatIN As New SqlClient.SqlDataAdapter("SELECT ID, name From Units order by name", mcnnInt)

            odaMatIN.Fill(dtMatIN)
         
            'Связать данные со списком
            Me.cmbFormatIN.DataSource = dtMatIN
            Me.cmbFormatIN.DisplayMember = "name"
            Me.cmbFormatIN.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub cmbFormatIN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFormatIN.SelectedIndexChanged
        LoadAccessibleFormates()
    End Sub

#Region " Загрузка доступных форматов "
    Private Sub LoadAccessibleFormates()
        'Читаем наименования типов услуг

        Try
            Dim strSQL$ = "SELECT MatFormatINOUT.ID, MatFormats.formatName AS Формат, MatFormatINOUT.kolvo AS Количество FROM MatFormatINOUT"
            strSQL &= " INNER JOIN MatFormats ON MatFormatINOUT.formatPrintID=MatFormats.ID  WHERE MatFormatINOUT.unitID=" & Me.cmbFormatIN.SelectedItem(0) & ""
            strSQL &= " order by MatFormats.formatName"

            Dim odaFormatOut As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtFormatOut As New DataTable : odaFormatOut.Fill(dtFormatOut)
            Me.dgFormatInOut.DataSource = dtFormatOut
            Me.dgFormatInOut.Columns("ID").Visible = False


            Dim str1SQL$ = "SELECT ID, formatName FROM MatFormats WHERE ID NOT IN (SELECT formatPrintID FROM MatFormatINOUT WHERE unitID=" & Me.cmbFormatIN.SelectedItem(0) & ") order by formatName"
            Dim odaTiragList As New SqlClient.SqlDataAdapter(str1SQL, mcnnInt)
            Dim dtTiragList As New DataTable : odaTiragList.Fill(dtTiragList)

            'Связать данные со списком
            Me.lstFormatOut.DataSource = dtTiragList
            Me.lstFormatOut.DisplayMember = "formatName"
            Me.lstFormatOut.ValueMember = "ID"
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message)
        End Try
    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str5SQL As String = "INSERT INTO MatFormatINOUT (unitID, formatPrintID, kolvo)  VALUES"
        str5SQL &= " (" & Me.cmbFormatIN.SelectedItem(0) & ", " & Me.lstFormatOut.SelectedItem(0) & ", " & Replace(Me.nudQuantity.Value, ",", ".") & ")"

        Module1.NonQuery1(str5SQL)

        LoadAccessibleFormates()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Select Case MsgBox(Prompt:="Удалить строку? ", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM MatFormatINOUT WHERE ID=" & Me.dgFormatInOut(0, Me.dgFormatInOut.CurrentRow.Index).Value & "")

                LoadAccessibleFormates()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub nudQuantity_MouseClick(sender As Object, e As MouseEventArgs) Handles nudQuantity.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

End Class