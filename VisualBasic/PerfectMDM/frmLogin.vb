Imports System.ComponentModel

Public Class frmLogin

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If terminal = True Then
            Application.Exit()
        End If
    End Sub

    ' TODO: вставить код для настраиваемой проверки подлинности с использованием переданного имени пользователя и пароля 
    ' (См. http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Пользовательский принципал можно затем подключить к принципалу потока следующим образом: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' где CustomPrincipal - реализация интерфейса IPrincipal, используемая для аутентификации. 
    ' Впоследствии My.User будет возвращать идентификационную информацию, заключенную в объекте CustomPrincipal,
    ' например, имя пользователя, отображаемое имя и т.д.

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '  appName = "Perfect ERP forMDM"

        'Проверка запуска только одного экземпляра приложения
        '   Module1.Main()
        '  Me.Font = New System.Drawing.Font("Tahoma", 50.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Text = "HelloPrint 1.5.6" 'appName
        'Module1.vendorCode.LoginLogout() ' проверка наличия ключа проверка примитивная подумать над ней
        Try
            If Key Is Nothing Then
                Key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\MS\Perfect", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)

                Key.SetValue("server", "0")
                Key.SetValue("db", "0")
                Key.SetValue("user", "supervisor")
                Key.SetValue("Autentification", "Win")
                Key.SetValue("SQLlogin", "")
                Key.SetValue("SQLpasword", BitConverter.GetBytes(1), Microsoft.Win32.RegistryValueKind.Binary)
                Key.SetValue("user", "supervisor")
                Key.SetValue("Autentification", "Win")
                Key.SetValue("SQLlogin", "")
                Key.SetValue("SQLpasword", BitConverter.GetBytes(1), Microsoft.Win32.RegistryValueKind.Binary)
                Key.SetValue("user", "supervisor")

                MsgBox("Для работы системы необходимо указать параметры подключения.", MsgBoxStyle.Critical, appName)

                CallConfigParam()
            Else ' ключ есть
                Me.txtLogin.Text = CType(Key.GetValue("user"), String)
                Me.txtPassword.Select()
            End If
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
        'проверка количества запущеных приложений
        ' OneInstanceTest.Main() 
    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        InputUser()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        If Me.btnOK.Visible = True Then
            Me.Close()
        Else
            Me.btnBSK.Enabled = True
            Me.Label1.Visible = False
            Me.UsernameLabel.Visible = True

            Me.txtLogin.BorderStyle = BorderStyle.FixedSingle
            Me.txtLogin.ForeColor = Color.Black
            Me.txtPassword.Visible = True
            Me.btnOK.Visible = True
            Me.txtLogin.Text = CType(Key.GetValue("user"), String)
            Me.txtPassword.Focus()
        End If
    End Sub

    Private Sub InputUser()
        serverName = CType(Key.GetValue("server"), String)
        strPath = Application.StartupPath ' путь к стартовому каталогу программы
        terminal = CType(Key.GetValue("terminal"), Boolean)

        If CType(Key.GetValue("Autentification"), String) = "Win" Then
            strConnection = "Data Source='" & serverName & "'; Integrated Security=SSPI; Initial Catalog='MDM';"
        Else
            Dim Encoding As New System.Text.UTF8Encoding()

            strConnection = "Data Source='" & serverName & "'; user='" & CType(Key.GetValue("SQLlogin"), String) & "'; password='" & CStr(Encoding.GetString(Convert.FromBase64String(Key.GetValue("SQLpasword")))) & "'; Initial Catalog='MDM';"
        End If

        mcnnInt.ConnectionString = strConnection

        emplID = Module1.NonQuery1Scalar("SELECT case when not exists (SELECT * FROM Employees WHERE login='" & Trim(Me.txtLogin.Text) & "') then 0 else (SELECT emplID FROM Employees WHERE  login='" & Trim(Me.txtLogin.Text) & "') end")

        If emplID = 0 Then
            MessageBox.Show("Доступ запрещен." + Chr(13) + "Проверь раскладку клавиатуры и не включен ли CapsLock.", appName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If Me.txtPassword.Visible = True Then
                If Module1.Test1(Trim(Me.txtLogin.Text), Trim(Me.txtPassword.Text)) = False Then
                    MessageBox.Show("Доступ запрещен." + Chr(13) + "Проверь раскладку клавиатуры и не включен ли CapsLock.", appName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Me.txtPassword.ResetText()
                    Me.txtPassword.Focus()
                Else
                    InSysPer()
                End If
            Else 'BSK
                If Module1.Test1(Trim(Me.txtLogin.Text), Trim(Me.txtLogin.Text)) = True Then
                    InSysPer()
                End If
            End If
        End If
    End Sub

    Private Sub InSysPer()
        Dim odaIDconfig As SqlClient.SqlDataAdapter
        Dim dtIdconfig As New DataTable
        Dim dr As DataRow

        Try
            odaIDconfig = New SqlClient.SqlDataAdapter("select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='IDconfig'", mcnnInt)
            odaIDconfig.Fill(dtIdconfig)

            For Each dr In dtIdconfig.Rows
                Select Case dr("column_Name")
                    Case Is = "autoAccount" ': autoAccount = True

                    Case Else

                End Select
            Next

            If Me.txtLogin.Visible = True Then
                Key.SetValue("user", Me.txtLogin.Text) 'записываем в реестр имя последнего юзера
            End If
        Catch ex As System.SystemException
            MessageBox.Show("Error loading data: " & ex.Message) : Exit Sub
        End Try

        If terminal = True And postPrioritet <> 1 Then ' терминал
            Dim odaParam As New SqlClient.SqlDataAdapter("SELECT name, description FROM Parameters", mcnnInt)
            Dim dtParam As New DataTable
            odaParam.Fill(dtParam)

            dtParam.Columns("name").Unique = True
            dtParam.PrimaryKey = New DataColumn() {dtParam.Columns("name")}
            paramUrlCalcFastorder = dtParam.Rows.Find("UrlCalcFastorder")("description")

            ModCallForm.CallForm("Быстрый заказ", 178, 1)
        Else
            frmSelect = New frmMainForm

            frmSelect.Show()
            frmSelect.Opacity = 100

            Me.Close()
            '*************
        End If

        frmSelect.Show()
        frmSelect.Opacity = 100
        ''*************
        Me.Close()
    End Sub

    Dim frmSelect As Form

    Private Sub btnParam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParam.Click
        Me.txtPassword.Select()
        CallConfigParam()
    End Sub

    Private Sub btnBSK_Click(sender As Object, e As EventArgs) Handles btnBSK.Click
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New Globalization.CultureInfo("en-US")) 'Меняем язык ввода на русский

        Me.txtLogin.Text = ""
        Me.btnBSK.Enabled = False

        Me.Label1.Visible = True
        Me.UsernameLabel.Visible = False

        Me.txtLogin.BorderStyle = BorderStyle.None
        Me.txtLogin.ForeColor = Color.White
        Me.txtPassword.Visible = False
        Me.txtLogin.SelectAll()

        'замигал считыватель
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then InputUser()
        e.Handled = True
    End Sub

    Private Sub txtLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLogin.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.txtPassword.Select()
        End If

        e.Handled = True
    End Sub
    'вот эта команда работает
    '   = xx1xxxxxb -> Поддержка  7B UID  / 7/10 Bytes UID Display Support 

    'Пример 4В: ce 84 69 28			Команда: E0 00 00 40 02 20 00

    Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged
        If Me.txtPassword.Visible = False Then
            If Len(Me.txtLogin.Text) = 9 Then
                InputUser()
            End If
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
