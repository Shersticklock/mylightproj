Public Class CustomProfessionalRenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderLabelBackground(e As ToolStripItemRenderEventArgs)
        if (e.Item.BackColor <> Color.WhiteSmoke ) Then
            Dim brush As SolidBrush = new SolidBrush(e.Item.BackColor)
            e.Graphics.FillRectangle(brush, e.Item.ContentRectangle)
            brush.Dispose()
        End If
    End Sub
End Class