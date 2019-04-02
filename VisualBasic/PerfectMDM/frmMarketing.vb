Public Class frmMarketing
    Dim dtInterrogation As New DataTable
    Dim modaInterrogation As SqlClient.SqlDataAdapter


    Private Sub Marketing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            modaInterrogation = New SqlClient.SqlDataAdapter("SELECT * FROM IDconfig", mcnnInt)
            modaInterrogation.Fill(dtInterrogation)
            Me.chkSet.Checked = dtInterrogation.Rows(0)("InterrogationMode")

            Me.dtpDataStart.SelectionRange.End = dtInterrogation.Rows(0)("InterrogationDataStart")
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub


    Private Sub SaveOpros()
        Dim sMsg1$

        If Me.chkSet.Checked = True Then
            sMsg1 = "Опрос включить, дата начала опроса  " & CStr(Format(Me.dtpDataStart.SelectionRange.End, "dd.MM.yyyy")) & "?"
        Else
            sMsg1 = "Опрос выключить?"
        End If

        If MessageBox.Show(sMsg1, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Me.chkSet.Checked = True Then
                '    clsINI.writeINI(Key.GetValue("price"), "Marketing", "dataStart", Format(Me.dtpDataStart.Value, "dd.MM.yyyy").ToString)
                dtInterrogation.Rows(0)("InterrogationDataStart") = Me.dtpDataStart.SelectionRange.End
            End If

            Dim custCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(modaInterrogation)

            Try
                dtInterrogation.Rows(0)("InterrogationMode") = Me.chkSet.Checked
                modaInterrogation.Update(dtInterrogation)
                dtInterrogation.AcceptChanges()
            Catch ex As System.Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click

        Me.Close()

    End Sub

    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        SaveOpros()

        Me.Close()
    End Sub
End Class