Public Class webMaper
    Private Sub Update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Text = appName  'url
        'url = "www.medias.spb.ru/update/Classika-m.htm"

        'If Not browserUrl.StartsWith("http://") Then
        'browserUrl = "http://" & browserUrl()
        'End If
        ' browserUrl = "http://www.medias.spb.ru/update/Classika-m.htm" ' & browserUrl()
        'Try
        'WebBrowser1.Navigate(New Uri(browserUrl))
        ' WebBrowser1.Navigate(paramUrlGanter)
        'Catch
        'MessageBox.Show("Invalid Url.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    ' Provide an accessor for the browserAddressTextBox control
    Private Property browserUrl() As String
        Get
            Return url
        End Get
        Set(ByVal value As String)
            Me.Text = value
        End Set
    End Property

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Doc As HtmlDocument = WebBrowser1.Document
        Dim obj$ = Doc.GetElementById("pole").OuterText
        Dim sss As String
        sss = WebBrowser1.Document.GetElementsByTagName("pole").Item(0).OuterText
        'Dim ddd As mshtml.HTMLDocument
        '  sss = frmUpdate.WebBrowser1.Document.Body.InnerText()
        MsgBox(sss)
        'MsgBox(WebBrowser1.Document.GetElementFromPoint(e.ClientMousePosition).OuterHtml)
    End Sub
End Class