Public Class PrintCheckErrorForm

    Public ResumeCheck As Boolean = False
    Public CancelCheck As Boolean = False


    Private Sub ResumePrintButton_Click(sender As Object, e As EventArgs) Handles ResumePrintButton.Click
        CancelCheck = False
        ResumeCheck = True
        Me.Close()
    End Sub

    Private Sub CancelCheckButton_Click(sender As Object, e As EventArgs) Handles CancelCheckButton.Click
        CancelCheck = True
        ResumeCheck = False
        Me.Close()
    End Sub
End Class