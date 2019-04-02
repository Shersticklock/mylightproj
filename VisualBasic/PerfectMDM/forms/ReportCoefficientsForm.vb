Imports System.Data.SqlClient

Public Class ReportCoefficientsForm
    Private Sub ReportCoefficientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RestoreData()
    End Sub

    Private Sub RestoreData()
        Try
            Dim sql As String = "SELECT * FROM ReportCoefficients"
            Dim sqlDataAdapter As New SqlDataAdapter(sql, mcnnInt)
            Dim dataTable As New DataTable()
            sqlDataAdapter.Fill(dataTable)

            For Each dataRow As DataRow In dataTable.Rows
                Select Case (CStr(dataRow.Item("coeff_key")))
                    Case "k1_man"
                        txtK1DutyManager.Text = dataRow.Item("coeff_value")
                    Case "k2_man"
                        txtK2DutyManager.Text = dataRow.Item("coeff_value")
                    Case "k3_man"
                        txtK3DutyManager.Text = dataRow.Item("coeff_value")
                    Case "k1_oper"
                        txtK1Operator.Text = dataRow.Item("coeff_value")
                    Case "k2_oper"
                        txtK2Operator.Text = dataRow.Item("coeff_value")
                    Case "k3_oper"
                        txtK3Operator.Text = dataRow.Item("coeff_value")
                End Select
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub btnSaveDutyManagerSettings_Click(sender As Object, e As EventArgs) Handles btnSaveDutyManagerSettings.Click
        If (Not isValid(Replace(txtK1DutyManager.Text, ".", ","))) Then
            txtK1DutyManager.Focus()
            MessageBox.Show(Me, "Неправильные данные!", appName)
            Exit Sub
        End If

        If (Not isValid(Replace(txtK2DutyManager.Text, ".", ","))) Then
            txtK2DutyManager.Focus()
            MessageBox.Show(Me, "Неправильные данные!", appName)
            Exit Sub
        End If

        If (Not isValid(Replace(txtK3DutyManager.Text, ".", ","))) Then
            txtK3DutyManager.Focus()
            MessageBox.Show(Me, "Неправильные данные!", appName)
            Exit Sub
        End If

        Try
            Dim sql As String = "UPDATE [ReportCoefficients] SET 
                coeff_value=" & Replace(txtK1DutyManager.Text, ",", ".") & " WHERE coeff_key='k1_man'
                IF @@ROWCOUNT=0
                insert into [ReportCoefficients](coeff_key,coeff_value) values
                ('k1_man', " & Replace(txtK1DutyManager.Text, ",", ".") & ")

                UPDATE [ReportCoefficients] SET 
                coeff_value=" & Replace(txtK2DutyManager.Text, ",", ".") & " WHERE coeff_key='k2_man'
                IF @@ROWCOUNT=0
                insert into [ReportCoefficients](coeff_key,coeff_value) values
                ('k2_man', " & Replace(txtK2DutyManager.Text, ",", ".") & ")

                UPDATE [ReportCoefficients] SET 
                coeff_value=" & Replace(txtK3DutyManager.Text, ",", ".") & " WHERE coeff_key='k3_man'
                IF @@ROWCOUNT=0
                insert into [ReportCoefficients](coeff_key,coeff_value) values
                ('k3_man', " & Replace(txtK3DutyManager.Text, ",", ".") & ")"
            Module1.NonQuery1(sql)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSaveOperatorSettings_Click(sender As Object, e As EventArgs) Handles btnSaveOperatorSettings.Click
        If (Not isValid(Replace(txtK1Operator.Text, ".", ","))) Then
            txtK1Operator.Focus()
            MessageBox.Show(Me, "Неправильные данные!", appName)
            Exit Sub
        End If

        If (Not isValid(Replace(txtK2Operator.Text, ".", ","))) Then
            txtK2Operator.Focus()
            MessageBox.Show(Me, "Неправильные данные!", appName)
            Exit Sub
        End If

        If (Not isValid(Replace(txtK3Operator.Text, ".", ","))) Then
            txtK3Operator.Focus()
            MessageBox.Show(Me, "Неправильные данные!", appName)
            Exit Sub
        End If

        Try
            Dim sql As String = "UPDATE [ReportCoefficients] SET 
                coeff_value=" & Replace(txtK1Operator.Text, ",", ".") & " WHERE coeff_key='k1_oper'
                IF @@ROWCOUNT=0
                insert into [ReportCoefficients](coeff_key,coeff_value) values
                ('k1_oper', " & Replace(txtK1Operator.Text, ",", ".") & ")

                UPDATE [ReportCoefficients] SET 
                coeff_value=" & Replace(txtK2Operator.Text, ",", ".") & " WHERE coeff_key='k2_oper'
                IF @@ROWCOUNT=0
                insert into [ReportCoefficients](coeff_key,coeff_value) values
                ('k2_oper', " & Replace(txtK2Operator.Text, ",", ".") & ")

                UPDATE [ReportCoefficients] SET 
                coeff_value=" & Replace(txtK3Operator.Text, ",", ".") & " WHERE coeff_key='k3_oper'
                IF @@ROWCOUNT=0
                insert into [ReportCoefficients](coeff_key,coeff_value) values
                ('k3_oper', " & Replace(txtK3Operator.Text, ",", ".") & ")"
            Module1.NonQuery1(sql)
        Catch ex As Exception
        End Try
    End Sub

    Private Function isValid(value As String) As Boolean
        Return Double.TryParse(value, 0)
    End Function
End Class