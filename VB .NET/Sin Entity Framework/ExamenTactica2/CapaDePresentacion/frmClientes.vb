Imports CapaDeDatos
Imports CapaDeNegocio

Public Class frmClientes
    Private ClienteDAO As New ClienteDAO
    Private Cliente As New Cliente
    Private IndexFilaSeleccionada As Integer

    Public Sub Listar()
        dgvClientes.DataSource = ClienteDAO.Listar
        'Si lo que me devuelve la lista es NULL, mostrar un mensaje de error.
    End Sub

    Public Sub Buscar()
        dgvClientes.DataSource = ClienteDAO.Buscar(cmbTipoDeCampo.Text, txtCampo.Text)
        RellenarTextBoxes()
    End Sub

    Public Sub RellenarTextBoxes()
        txtID.Text = dgvClientes.CurrentRow.Cells(0).Value
        txtCliente.Text = dgvClientes.CurrentRow.Cells(1).Value
        txtTelefono.Text = dgvClientes.CurrentRow.Cells(2).Value
        txtCorreo.Text = dgvClientes.CurrentRow.Cells(3).Value
    End Sub

    Public Sub LimpiarTextBoxes()
        txtCampo.Clear()
        txtID.Clear()
        txtCliente.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        RellenarTextBoxes()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        If txtCampo.Text = "" Then
            Listar()
        Else
            If (dgvClientes.Rows.Count > 0) Then
                Buscar()
            End If
        End If
    End Sub

    Private Sub btnBorrarBusqueda_Click(sender As Object, e As EventArgs) Handles btnBorrarBusqueda.Click
        txtCampo.Text = ""
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        RellenarTextBoxes()
        IndexFilaSeleccionada = dgvClientes.CurrentRow.Index
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AcceptButton = btnGuardarAgregar
        txtCliente.Enabled = True
        txtCliente.Select()
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        btnAgregar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardarAgregar.Enabled = True
        btnGuardarAgregar.Visible = True
        btnGuardarEditar.Visible = False
        btnCancelar.Enabled = True
        LimpiarTextBoxes()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.AcceptButton = btnGuardarEditar
        txtCliente.Enabled = True
        txtCliente.Select()
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        btnAgregar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardarAgregar.Visible = False
        btnGuardarEditar.Enabled = True
        btnGuardarEditar.Visible = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Cliente.ID = txtID.Text
            ClienteDAO.Eliminar(Cliente)
            Listar()
            RellenarTextBoxes()
            MessageBox.Show("Cliente eliminado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar el cliente seleccionado. " + ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarAgregar_Click(sender As Object, e As EventArgs) Handles btnGuardarAgregar.Click
        Try
            Cliente.Cliente = txtCliente.Text
            Cliente.Telefono = txtTelefono.Text
            Cliente.Correo = txtCorreo.Text
            ClienteDAO.Agregar(Cliente)
            Listar()
            Me.AcceptButton = btnAgregar
            dgvClientes.Rows(0).Selected = False
            dgvClientes.Rows(dgvClientes.Rows.Count - 1).Selected = True
            txtCliente.Enabled = False
            txtTelefono.Enabled = False
            txtCorreo.Enabled = False
            btnAgregar.Enabled = True
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
            btnGuardarAgregar.Enabled = False
            btnGuardarAgregar.Visible = False
            btnGuardarEditar.Enabled = False
            btnGuardarEditar.Visible = True
            btnCancelar.Enabled = False
            MessageBox.Show("Cliente agregado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar el cliente seleccionado. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarEditar_Click(sender As Object, e As EventArgs) Handles btnGuardarEditar.Click
        Try
            Cliente.ID = txtID.Text
            Cliente.Cliente = txtCliente.Text
            Cliente.Telefono = txtTelefono.Text
            Cliente.Correo = txtCorreo.Text
            ClienteDAO.Editar(Cliente)
            Listar()
            Me.AcceptButton = btnAgregar
            dgvClientes.Rows(0).Selected = False
            dgvClientes.Rows(IndexFilaSeleccionada).Selected = True
            txtCliente.Enabled = False
            txtTelefono.Enabled = False
            txtCorreo.Enabled = False
            btnAgregar.Enabled = True
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
            btnGuardarEditar.Enabled = False
            btnCancelar.Enabled = False
            MessageBox.Show("Cliente editado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo editar el cliente seleccionado. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        RellenarTextBoxes()
        Me.AcceptButton = btnAgregar
        txtCliente.Enabled = False
        txtTelefono.Enabled = False
        txtCorreo.Enabled = False
        btnAgregar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardarAgregar.Visible = False
        btnGuardarEditar.Enabled = False
        btnGuardarEditar.Visible = True
        btnCancelar.Enabled = False
    End Sub

End Class