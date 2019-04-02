Public Class frmDesTemp

    Private Sub frmDesTemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTemp()
    End Sub

    Private Sub LoadTemp()
        Dim odaProd As New SqlClient.SqlDataAdapter("SELECT ID, desTemplName FROM DescriptionTemlate order by desTemplName", mcnnInt)
        Dim dtProd As New DataTable : odaProd.Fill(dtProd)

        Me.cmbTemplate.DataSource = dtProd 'Связать данные со списком
        Me.cmbTemplate.DisplayMember = "desTemplName"
        Me.cmbTemplate.ValueMember = "ID"
    End Sub

    Private Sub tsbtnSaveTemplate_Click(sender As Object, e As EventArgs) Handles tsbtnSaveTemplate.Click

        Module1.NonQuery1("INSERT INTO DescriptionTemlate (desTemplName, desText) VALUES ('" & Me.txtNewTemplare.Text & "', '" & Replace(Me.txtTemplate.Text, "'", " ` ") & "')")

        MsgBox("Шаблон сохранил.", MsgBoxStyle.Information, appName)
        ' Me.tsbtnSaveTemplate.Enabled = False
    End Sub

    Private Sub cmbTemplate_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTemplate.SelectedValueChanged
        If Me.cmbTemplate.SelectedIndex <> -1 Then
            Me.txtTemplate.Text = Module1.NonQuery1ScalarString("SELECT desText FROM DescriptionTemlate WHERE ID =" & Me.cmbTemplate.SelectedItem(0) & " ")
        End If
    End Sub

    Private Sub tsbtnDel_Click(sender As Object, e As EventArgs) Handles tsbtnDel.Click
        Select Case MsgBox(Prompt:="Удалить шаблон " + Me.cmbTemplate.SelectedItem(1) + "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM DescriptionTemlate WHERE ID = " & Me.cmbTemplate.SelectedValue & "")

                LoadTemp()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub
End Class