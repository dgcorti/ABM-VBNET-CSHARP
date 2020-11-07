Imports CapaDeDatos
Imports CapaDeNegocio

Public Class frmProductos
    Private ProductoDAO As New ProductoDAO
    Private Producto As New Producto
    Private IndexFilaSeleccionada As Integer

    Public Sub Listar()
        dgvProductos.DataSource = ProductoDAO.Listar
        'Si lo que me devuelve la lista es NULL, mostrar un mensaje de error.
    End Sub

    Public Sub Buscar()
        dgvProductos.DataSource = ProductoDAO.Buscar(cmbTipoDeCampo.Text, txtCampo.Text)
    End Sub

    Public Sub RellenarTextBoxes()
        txtID.Text = dgvProductos.CurrentRow.Cells(0).Value
        txtNombre.Text = dgvProductos.CurrentRow.Cells(1).Value
        txtPrecio.Text = dgvProductos.CurrentRow.Cells(2).Value
        txtCategoria.Text = dgvProductos.CurrentRow.Cells(3).Value
    End Sub

    Public Sub LimpiarTextBoxes()
        txtCampo.Clear()
        txtID.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtCategoria.Clear()
    End Sub

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        RellenarTextBoxes()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        If txtCampo.Text = "" Then
            Listar()
        Else
            If (dgvProductos.Rows.Count > 0) Then
                Buscar()
            End If
        End If
    End Sub

    Private Sub btnBorrarBusqueda_Click(sender As Object, e As EventArgs) Handles btnBorrarBusqueda.Click
        txtCampo.Text = ""
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        RellenarTextBoxes()
        IndexFilaSeleccionada = dgvProductos.CurrentRow.Index
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AcceptButton = btnGuardarAgregar
        LimpiarTextBoxes()
        txtNombre.Enabled = True
        txtNombre.Select()
        txtPrecio.Enabled = True
        txtCategoria.Enabled = True
        btnAgregar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardarAgregar.Enabled = True
        btnGuardarAgregar.Visible = True
        btnGuardarEditar.Visible = False
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.AcceptButton = btnGuardarEditar
        txtNombre.Enabled = True
        txtNombre.Select()
        txtPrecio.Enabled = True
        txtCategoria.Enabled = True
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
            Producto.ID = txtID.Text
            ProductoDAO.Eliminar(Producto)
            Listar()
            RellenarTextBoxes()
            MessageBox.Show("Producto eliminado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar el producto seleccionado. " + ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarAgregar_Click(sender As Object, e As EventArgs) Handles btnGuardarAgregar.Click
        Try
            Producto.Nombre = txtNombre.Text
            Producto.Precio = txtPrecio.Text
            Producto.Categoria = txtCategoria.Text
            ProductoDAO.Agregar(Producto)
            Listar()
            Me.AcceptButton = btnAgregar
            dgvProductos.Rows(0).Selected = False
            dgvProductos.Rows(dgvProductos.Rows.Count - 1).Selected = True
            txtNombre.Enabled = False
            txtPrecio.Enabled = False
            txtCategoria.Enabled = False
            btnAgregar.Enabled = True
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
            btnGuardarAgregar.Enabled = False
            btnGuardarAgregar.Visible = False
            btnGuardarEditar.Visible = True
            btnGuardarEditar.Enabled = False
            btnCancelar.Enabled = False
            MessageBox.Show("Producto agregado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar el producto seleccionado. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarEditar_Click(sender As Object, e As EventArgs) Handles btnGuardarEditar.Click
        Try
            Producto.ID = txtID.Text
            Producto.Nombre = txtNombre.Text
            Producto.Precio = txtPrecio.Text
            Producto.Categoria = txtCategoria.Text
            ProductoDAO.Editar(Producto)
            Listar()
            Me.AcceptButton = btnAgregar
            dgvProductos.Rows(0).Selected = False
            dgvProductos.Rows(IndexFilaSeleccionada).Selected = True
            txtNombre.Enabled = False
            txtPrecio.Enabled = False
            txtCategoria.Enabled = False
            btnAgregar.Enabled = True
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
            btnGuardarEditar.Enabled = False
            btnCancelar.Enabled = False
            MessageBox.Show("Producto editado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo editar el producto seleccionado. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        RellenarTextBoxes()
        Me.AcceptButton = btnAgregar
        txtNombre.Enabled = False
        txtPrecio.Enabled = False
        txtCategoria.Enabled = False
        btnAgregar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardarAgregar.Visible = False
        btnGuardarEditar.Enabled = False
        btnGuardarEditar.Visible = True
        btnCancelar.Enabled = False
    End Sub

End Class