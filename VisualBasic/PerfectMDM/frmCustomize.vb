Public Class frmCustomize
    Private Sub frmCustomize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nameColumn As String
        Dim m As Integer

        For Each nameColumn In columnNameMF 'Заполняем все атрибуты  по именам столбцов
            Me.clbColumnMain.Items.Add(columnNameMF(m), True)
            m = m + 1
        Next

        If Me.clbColumnMain.Items.Count = 0 Then
            MsgBox("Перед вызовом кастомайзера необходимо обновить реестр заказов чтобы прочитались его существующие поля." + Chr(13) + "Нажать кнопку Обновить на главной форме.", MsgBoxStyle.Information, appName)
            Me.Close()
        Else
            KeySettings.OpenSubKey(True)
            If KeySettings Is Nothing Then
                KeySettings.SetValue("order1", "1")
            Else
                Me.txtTest.Text = CType(KeySettings.GetValue("order1"), String)
            End If
        End If
    End Sub

    Private Sub tsbtnSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSaveSettings.Click
        Dim setString As String = Nothing
        Dim n As Integer

        For n = 0 To Me.clbColumnMain.CheckedItems.Count - 1
            If setString <> Nothing Then setString = setString & "/"
            setString = setString & Me.clbColumnMain.CheckedItems.Item(n)
        Next

        If n = 0 Then
            MsgBox("Перед вызовом кастомайзера необходимо обновить реестр заказов чтобы прочитались существующие поля.", MsgBoxStyle.Information, appName)
        Else
            KeySettings.SetValue("order1", setString)
        End If
        Me.Close()
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
End Class