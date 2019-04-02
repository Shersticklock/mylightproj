Imports System
Imports System.IO
Imports System.Text

Public Class classLog


    Class FSOpenWrite

        Public Shared Sub Main(ByVal ttt)
            Dim fs As New FileStream(paramLocalTempPath & "PRFLog.txt", FileMode.Append, FileAccess.Write, FileShare.Write)
            fs.Close()
            Dim sw As New StreamWriter(paramLocalTempPath & "PRFLog.txt", True, Encoding.ASCII)
            Dim NextLine As String = ttt
            sw.Write(NextLine)
            sw.Close()
        End Sub 'Main
    End Class 'FSOpenWrite
End Class
