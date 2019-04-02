Imports Cassa

Public Class fin_KassOper
    '    Connect
    'Disconnect
    'Beep
    'GetCash
    'PrintZReport
    'PrintXReport
    'Date
    'State


    Private Sub PuncheredButton_Click(sender As Object, e As EventArgs) Handles PuncheredButton.Click
        Dim cassa As New Global.Cassa.CassaHelper()
        Try
            Dim port As Integer = CInt(KeySettings.GetValue("portKassa"))
            Dim password As Integer = CInt(KeySettings.GetValue("passKassa"))
            Dim ip As String = KeySettings.GetValue("IPkassa")
            Dim tcpCassa As Boolean = KeySettings.GetValue("tcpKassa")
            If (tcpCassa) Then
                cassa.Connect(port,password, ip)
            Else 
                cassa.Connect(port, password)
            End If
            Dim cash As Decimal = cassa.GetCash()
            Me.PuncheredTextBox.Text = cash & " руб."
            cassa.Disconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, appName)
            cassa.Disconnect()
        End Try
    End Sub

    Private Sub PrintXReportButton_Click(sender As Object, e As EventArgs) Handles PrintXReportButton.Click
        If MessageBox.Show("Вы уверены, что хотите снять X-отчет?", appName, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim cassa As New Global.Cassa.CassaHelper()
            Dim port As Integer = CInt(KeySettings.GetValue("portKassa"))
            Dim password As Integer = CInt(KeySettings.GetValue("passKassa"))
            Dim ip As String = KeySettings.GetValue("IPkassa")
            Dim tcpCassa As Boolean = KeySettings.GetValue("tcpKassa")
            If (tcpCassa) Then
                cassa.Connect(port,password, ip)
            Else 
                cassa.Connect(port, password)
            End If
            cassa.LockPort()
            cassa.Beep()
            cassa.PrintXReport()
            cassa.UnLockPort()
            cassa.Disconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub CancelCheckButton_Click(sender As Object, e As EventArgs) Handles CancelCheckButton.Click
        If MessageBox.Show("Вы уверены, что хотите отменить чек?", appName, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim cassa As New Cassa.CassaHelper()
            cassa.CancelCheck()
        Catch ex As Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub

    Private Sub PrintZReportButton_Click(sender As Object, e As EventArgs) Handles PrintZReportButton.Click
        If MessageBox.Show("Вы уверены, что хотите закрыть смену?", appName, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Me.PrintZReportButton.Enabled = False
            Dim cassa As New Global.Cassa.CassaHelper()
            Dim port As Integer = CInt(KeySettings.GetValue("portKassa"))
            Dim password As Integer = CInt(KeySettings.GetValue("passKassa"))
            Dim ip As String = KeySettings.GetValue("IPkassa")
            Dim tcpCassa As Boolean = KeySettings.GetValue("tcpKassa")
            If (tcpCassa) Then
                cassa.Connect(port,password, ip)
            Else 
                cassa.Connect(port, password)
            End If
            cassa.LockPort()
            cassa.Beep()
            cassa.PrintZReport()
            cassa.UnLockPort()
            cassa.Disconnect()


            Dim idCassa
            Try
                idCassa = CInt(KeySettings.GetValue("IDkassa"))
            Catch ex As Exception
                idCassa = Nothing
            End Try

            If ((Not idCassa Is Nothing) And (Not idCassa = 0)) Then
                Module1.NonQuery1("INSERT INTO fin_Inkass (summa, ofID, frID) VALUES ((SELECT total FROM fin_Cash WHERE office_ID=" & ofID & "), " & ofID & ", " & idCassa & ")")
            Else
                Module1.NonQuery1("INSERT INTO fin_Inkass (summa, ofID) SELECT total, office_ID FROM fin_Cash WHERE office_ID=" & ofID & "")
            End If

            Module1.NonQuery1("INSERT INTO fin_ManyOut (amount, description, fopl_ID, office_ID, found_ID)  VALUES ((Select total FROM fin_Cash WHERE office_ID=" & ofID & "), 'z-отчет', 1, " & ofID & ", " & emplID & ")")

            MsgBox("Готово.", MsgBoxStyle.Information, appName)
        Catch excData As Exception
            MsgBox("Ошибка при инкассировании", MessageBoxIcon.Stop, appName)
            Module1.NonQuery1("INSERT INTO Logs (textErrors) VALUES ('" & "Ошибка при инкассировании-" & excData.Message & "')")
            Exit Sub
        Finally
            mcnnInt.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub RequestStateButton_Click(sender As Object, e As EventArgs) Handles RequestStateButton.Click
        Dim cassa As CassaHelper = Nothing
        Try
            cassa = New CassaHelper()
            Dim port As Integer = CInt(KeySettings.GetValue("portKassa"))
            Dim password As Integer = CInt(KeySettings.GetValue("passKassa"))
            Dim ip As String = KeySettings.GetValue("IPkassa")
            Dim tcpCassa As Boolean = KeySettings.GetValue("tcpKassa")
            If (tcpCassa) Then
                cassa.Connect(port,password, ip)
            Else 
                cassa.Connect(port, password)
            End If
            cassa.GetShortECRStatus()

            Dim result As String = "(" & cassa.ResultCode & ") " & cassa.ResultCodeDescription
            Dim mode As String = "(" & cassa.EcrMode & ") " & cassa.EcrModeDescription
            Dim advancedMode As String = "(" & cassa.EcrAdvancedMode & ") " & cassa.EcrAdvancedModeDescription

            StateTextBox.Text = result & ", " & mode & ", " & advancedMode
            ResultTextBox.Text = "- " & result & Environment.NewLine & "- " & mode & Environment.NewLine & "- " & advancedMode
        Catch ex As Exception
            MessageBox.Show("Ошибка при запросе состояния" & Environment.NewLine & ex.Message, appName)
        Finally
            If (Not cassa Is Nothing) Then
                cassa.Disconnect()
            End If
        End Try

    End Sub
End Class