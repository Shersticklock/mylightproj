Public Class c_GM

    Private Sub mdm_GM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WebBrowser1.Navigate("http://online.gmprint.ru/?from=gmprint.ru")
    End Sub

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
End Class