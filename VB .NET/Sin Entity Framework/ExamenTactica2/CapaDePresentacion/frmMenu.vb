Public Class frmMenu
    Public Sub AbrirFormularioEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = pnlFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            pnlFormularios.Controls.Add(Formulario)
            pnlFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormularioEnPanel(Of frmProductos)()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormularioEnPanel(Of frmClientes)()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormularioEnPanel(Of frmVentas)()
    End Sub
End Class