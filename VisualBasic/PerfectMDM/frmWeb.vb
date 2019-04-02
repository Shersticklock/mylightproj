Imports Microsoft.Win32

Public Class frmWeb

    Private Sub frmWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBrowserFeatureControlKeys()
        Me.WebBrowser1.Navigate(Me.Text)
    End Sub


    Private Sub SetBrowserFeatureControlKey(feature As String, appName As String, value As Integer)
        Using microsoftIeKey As RegistryKey = Registry.CurrentUser.CreateSubKey(String.Concat("Software\Microsoft\Internet Explorer\Main\FeatureControl\", feature), RegistryKeyPermissionCheck.ReadWriteSubTree)
            microsoftIeKey.SetValue(appName, value, RegistryValueKind.DWord)
        End Using
    End Sub



    Private Sub SetBrowserFeatureControlKeys()
        'Dim fileName As String : IO.Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName)
        Dim fileName = IO.Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName)

        If (String.Compare(fileName, "devenv.exe", True) = 0 Or String.Compare(fileName, "XDesProc.exe", True) = 0) Then
            Return
        End If

        SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", fileName, GetBrowserEmulationMode())
        SetBrowserFeatureControlKey("FEATURE_AJAX_CONNECTIONEVENTS", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_MANAGE_SCRIPT_CIRCULAR_REFS", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_DOMSTORAGE ", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_GPU_RENDERING ", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_IVIEWOBJECTDRAW_DMLT9_WITH_GDI  ", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_DISABLE_LEGACY_COMPRESSION", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_LOCALMACHINE_LOCKDOWN", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_OBJECT", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_SCRIPT", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_DISABLE_NAVIGATION_SOUNDS", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_SCRIPTURL_MITIGATION", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_SPELLCHECKING", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_STATUS_BAR_THROTTLING", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_TABBED_BROWSING", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_VALIDATE_NAVIGATE_URL", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_WEBOC_DOCUMENT_ZOOM", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_WEBOC_POPUPMANAGEMENT", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_WEBOC_MOVESIZECHILD", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_ADDON_MANAGEMENT", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_WEBSOCKET", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_WINDOW_RESTRICTIONS ", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_XMLHTTP", fileName, 1)
    End Sub

    Private Function GetBrowserEmulationMode() As Integer
        Dim browserVersion As Integer = 7
        Using ieKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer", RegistryKeyPermissionCheck.ReadSubTree, System.Security.AccessControl.RegistryRights.QueryValues)
            Dim version As Object = ieKey.GetValue("svcVersion")
            If IsNothing(version) Then
                version = ieKey.GetValue("Version")
                If IsNothing(version) Then
                    Throw New ApplicationException("Microsoft Internet Explorer is required!")
                End If
            End If
            Integer.TryParse(version.ToString().Split(".")(0), browserVersion)
        End Using

        Dim mode As Integer = 11000
        Select Case browserVersion
            Case 7
                mode = 7000
            Case 8
                mode = 8000
            Case 9
                mode = 9000
            Case 10
                mode = 10000
        End Select
        Return mode
    End Function

End Class