Imports Microsoft.Win32.Registry
Imports Microsoft.Win32.RegistryKey
Imports System.Security.Cryptography

Public Class frmConfigParam
    Private Sub ConfigParam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtSQLlogin.PasswordChar = "*"
        Me.txtSQLpasword.Enabled = False

        If CType(Key.GetValue("Autentification"), String) = "Win" Then
            Me.cmbAutentification.SelectedIndex = 0
        Else
            Me.cmbAutentification.SelectedIndex = 1
        End If

        Me.chkTerminal.Checked = CType(Key.GetValue("terminal"), Boolean)


        'Me.txtSQLlogin.Text = CType(Key.GetValue("SQLlogin"), String)
        ''Me.txtSQLpasword.Text = CType(Key.GetValue("SQLpasword"), Byte)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        PressOK()
    End Sub

    Private Sub PressOK()
        If Me.cmbAutentification.SelectedIndex = 0 Then
            Key.SetValue("Autentification", "Win")
        Else
            Key.SetValue("Autentification", "SQL")
            Key.SetValue("SQLlogin", Me.txtSQLlogin.Text)

            If Me.txtSQLpasword.Enabled = True Then
                Dim Encoding As New System.Text.UTF8Encoding()

                Key.SetValue("SQLpasword", Convert.ToBase64String(Encoding.GetBytes(Me.txtSQLpasword.Text)))
            End If
        End If

        If Me.chkTerminal.Checked = True Then
            Key.SetValue("terminal", "1")
        Else
            Key.SetValue("terminal", "0")
        End If

        Key.SetValue("server", Trim(Me.cmbSelectServer.Text))
        Key.SetValue("db", Trim(Me.cmbDataBase.Text))

        'Select Case MessageBox.Show("Параметры подключения записаны. Завершить настройку?", appName & _
        '                      "-Параметры подключения", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    Case Is = DialogResult.Yes
        '        Me.Close()
        '    Case Is = DialogResult.No
        '        Exit Sub
        'End Select

        Me.txtSQLpasword.Enabled = False

        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbHostType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.btnOK.Enabled = True
        Me.cmbDataBase.Enabled = True
    End Sub

    Private Sub cmbAutentification_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAutentification.SelectedIndexChanged
        Dim SQLAutentification As Boolean

        If Me.cmbAutentification.SelectedIndex = 0 Then
            SQLAutentification = False 'win
            Me.cmbSelectServer.Text = CType(Key.GetValue("server"), String)
            Me.cmbDataBase.Text = CType(Key.GetValue("db"), String)
            Me.txtSQLlogin.Text = Nothing
            '  Me.cmbSelectServer.Enabled = True
            Me.Label4.Visible = False
            Me.txtSQLlogin.Visible = False
            Me.Label1.Visible = False
            Me.txtSQLpasword.Visible = False
            Me.btnNewPassSQL.Visible = False
            Me.btnNewLogin.Visible = False
        Else
            SQLAutentification = True 'SQL
            Me.cmbDataBase.Text = CType(Key.GetValue("db"), String)
            Me.txtSQLlogin.Text = CType(Key.GetValue("SQLlogin"), String)
            Me.cmbSelectServer.Text = CType(Key.GetValue("server"), String)
            '   Me.cmbSelectServer.ForeColor = Color.White
            Me.Label4.Visible = True
            Me.txtSQLlogin.Visible = True
            Me.Label1.Visible = True
            Me.txtSQLpasword.Visible = True
            Me.btnNewPassSQL.Visible = True
            Me.btnNewLogin.Visible = True
        End If

        Me.btnNewPassSQL.Enabled = SQLAutentification
        Me.txtSQLlogin.Enabled = SQLAutentification

    End Sub

    Private Sub btnPriceFileWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If OpenFileDialog1.FileName.ToString = Nothing Then
        '    MsgBox("Не указан файл ключа. Необходимо выбрать ключ и повторить попытку.", MsgBoxStyle.Critical, appName)
        '    Exit Sub
        'Else
        '    Key.SetValue("price", OpenFileDialog1.FileName.ToString)
        'End If
    End Sub

    Private Sub btnNewPassSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPassSQL.Click
        Me.txtSQLpasword.Enabled = True
        Me.txtSQLpasword.Focus()
    End Sub

    Private Sub cmbDataBase_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbDataBase.KeyDown
        If e.KeyCode = Keys.Enter Then PressOK()
        e.Handled = True
    End Sub

    Private Sub txtSQLlogin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSQLlogin.MouseClick
        Me.txtSQLlogin.Select(0, Len(Me.txtSQLlogin.Text))
    End Sub

    Private Sub btnNewLogin_Click(sender As Object, e As EventArgs) Handles btnNewLogin.Click
        '  Me.txtSQLlogin.PasswordChar = "*"
        Me.txtSQLlogin.Text = Nothing
        Me.txtSQLlogin.PasswordChar = ""
        Me.txtSQLlogin.Focus()
        '  Me.txtSQLlogin.SelectedText
    End Sub

    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        Me.txtSQLlogin.PasswordChar = ""
    End Sub

    Private Sub txtSQLlogin_TextChanged(sender As Object, e As EventArgs) Handles txtSQLlogin.TextChanged

    End Sub
End Class