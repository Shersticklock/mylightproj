Module OneInstanceTest
    Public Sub Main()
        Dim Proc() As Process

        Dim ModuleName, ProcName As String

        ModuleName = Process.GetCurrentProcess.MainModule.ModuleName
        ProcName = System.IO.Path.GetFileNameWithoutExtension(ModuleName)

        Proc = Process.GetProcessesByName(ProcName)
        If Proc.Length > 1 Then
            MsgBox("Приложение " & appName & " уже запущено.") : Application.Exit()
        End If
        'Console.ReadLine()
    End Sub
End Module
