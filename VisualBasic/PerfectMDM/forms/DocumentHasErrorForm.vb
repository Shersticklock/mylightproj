Public Class DocumentHasErrorForm

    Friend IsOkButtonClicked As Boolean = False

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        isOkButtonClicked = True
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        isOkButtonClicked = False
        Me.Close()
    End Sub
End Class