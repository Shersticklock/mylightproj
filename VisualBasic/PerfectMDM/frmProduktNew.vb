Public Class frmProduktNew

    Private Sub ProduktNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim odaGroup As New SqlClient.SqlDataAdapter("SELECT ID, name From awc_TypeProd order by name", mcnnInt)
            Dim dtGroup As New DataTable : odaGroup.Fill(dtGroup)
            Me.cmbTypeProd.DataSource = dtGroup
            Me.cmbTypeProd.DisplayMember = "name"
            Me.cmbTypeProd.ValueMember = "ID"

            Dim odaServices As New SqlClient.SqlDataAdapter("SELECT ID, name From Services WHERE active=1 order by name", mcnnInt)
            Dim dtServices As New DataTable : odaServices.Fill(dtServices)
            Me.cmbServices.DataSource = dtServices
            Me.cmbServices.DisplayMember = "name"
            Me.cmbServices.ValueMember = "ID"

            Me.cmbServices.SelectedValue = serviceID
            Me.txtName.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub Save()
        Module1.NonQuery1("INSERT INTO awc_Polygraph (Name, serviceID, typeProdID, tagCalc, paramCost)  VALUES ('" & Me.txtName.Text & "', " & Me.cmbServices.SelectedItem(0) & ", " & Me.cmbTypeProd.SelectedItem(0) & ", '" & formTagNewProd & "', " & Me.nudParamCost.Value & ")")

        addProdawcPoly = True

        Me.Close()
    End Sub

    Private Sub btnSaveProd_Click(sender As Object, e As EventArgs) Handles btnSaveProd.Click
        Save()
    End Sub

    Dim allowSave As Boolean = False

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter And allowSave = True Then
            Save()
        End If
        e.Handled = True
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        allowSave = True
        Me.btnSaveProd.Enabled = True
    End Sub
End Class