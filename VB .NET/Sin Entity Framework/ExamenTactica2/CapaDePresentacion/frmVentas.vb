Imports CapaDeDatos
Imports CapaDeNegocio

Public Class frmVentas
    Private VentaDAO As New VentaDAO
    Private Venta As New Venta
    Private VentaItemDAO As New VentaItemDAO
    Private VentaItem As New VentaItem
    Private IndexFilaSeleccionadaVentas As Integer
    Private IndexFilaSeleccionadaVentasItems As Integer
    Private SumaDePreciosItems As Single

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarVentas()
        RellenarTextBoxesVentas()
        ListarItems()
        RellenarTextBoxesItems()
    End Sub

#Region "Ventas"

    Public Sub ListarVentas()
        dgvVentas.DataSource = VentaDAO.Listar
        'Si lo que me devuelve la lista es NULL, mostrar un mensaje de error.
    End Sub

    Public Sub BuscarVenta()
        dgvVentas.DataSource = VentaDAO.Buscar(cmbTipoDeCampoVenta.Text, txtCampoVenta.Text)
        RellenarTextBoxesVentas()
        ListarItems()
        RellenarTextBoxesItems()
    End Sub

    Public Sub RellenarTextBoxesVentas()
        txtIDVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        txtIDCliente.Text = dgvVentas.CurrentRow.Cells(1).Value
        dtpFecha.Value = dgvVentas.CurrentRow.Cells(2).Value
        txtTotal.Text = dgvVentas.CurrentRow.Cells(3).Value
    End Sub

    Public Sub LimpiarTextBoxesVentas()
        txtIDVenta.Clear()
        txtIDCliente.Clear()
        dtpFecha.ResetText()
        txtTotal.Clear()
    End Sub

    Public Sub ActivarBotonesItems()
        btnAgregarItem.Enabled = True
        btnEditarItem.Enabled = True
        btnEliminarItem.Enabled = True
        btnGuardarAgregarItem.Enabled = True
        btnGuardarEditarItem.Enabled = True
        btnCancelarItem.Enabled = True
    End Sub

    Public Sub DesactivarBotonesItems()
        btnAgregarItem.Enabled = False
        btnEditarItem.Enabled = False
        btnEliminarItem.Enabled = False
        btnGuardarAgregarItem.Enabled = False
        btnGuardarEditarItem.Enabled = False
        btnCancelarItem.Enabled = False
    End Sub

    Private Sub txtCampoVenta_TextChanged(sender As Object, e As EventArgs) Handles txtCampoVenta.TextChanged
        If txtCampoVenta.Text = "" Then
            ListarVentas()
            ListarItems()
        Else
            If (dgvVentas.Rows.Count > 0) Then
                BuscarVenta()
            End If
        End If
    End Sub

    Private Sub btnBorrarBusquedaDeVenta_Click(sender As Object, e As EventArgs) Handles btnBorrarBusquedaDeVenta.Click
        txtCampoVenta.Text = ""
    End Sub

    Private Sub dgvVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellClick
        RellenarTextBoxesVentas()
        IndexFilaSeleccionadaVentas = dgvVentas.CurrentRow.Index
        ListarItems()
        RellenarTextBoxesItems()
    End Sub

    Private Sub btnAgregarVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarVenta.Click
        Me.AcceptButton = btnGuardarAgregarVenta
        Me.CancelButton = btnCancelarVenta
        LimpiarTextBoxesVentas()
        DesactivarBotonesItems()
        txtIDCliente.Enabled = True
        txtIDCliente.Select()
        dtpFecha.Enabled = True
        btnAgregarVenta.Enabled = False
        btnEliminarVenta.Enabled = False
        btnEditarVenta.Enabled = False
        btnCancelarVenta.Enabled = True
        btnGuardarAgregarVenta.Enabled = True
        btnGuardarEditarVenta.Visible = True
        btnGuardarEditarVenta.Visible = False
    End Sub

    Private Sub btnEditarVenta_Click(sender As Object, e As EventArgs) Handles btnEditarVenta.Click
        Me.AcceptButton = btnGuardarEditarVenta
        Me.CancelButton = btnCancelarVenta
        DesactivarBotonesItems()
        txtIDCliente.Enabled = True
        txtIDCliente.Select()
        dtpFecha.Enabled = True
        btnAgregarVenta.Enabled = False
        btnEditarVenta.Enabled = False
        btnEliminarVenta.Enabled = False
        btnCancelarVenta.Enabled = True
        btnGuardarAgregarVenta.Visible = False
        btnGuardarEditarVenta.Enabled = True
        btnGuardarEditarVenta.Visible = True
    End Sub

    Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
        Try
            'If txtIDVenta.Text <> 0 Then
            Venta.ID = txtIDVenta.Text
                'Else
                '    Venta.ID = 0
                'End If

                VentaDAO.Eliminar(Venta)
            ListarVentas()
            RellenarTextBoxesVentas()
            ListarItems()
            LimpiarTextBoxesItems()
            MessageBox.Show("Venta eliminada correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar la venta seleccionada. " + ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarAgregarVenta_Click(sender As Object, e As EventArgs) Handles btnGuardarAgregarVenta.Click
        Try
            Venta.IDCliente = txtIDCliente.Text
            Venta.Fecha = dtpFecha.Value
            VentaDAO.Agregar(Venta)
            ListarVentas()
            ListarItems()
            dgvVentas.Rows(0).Selected = False
            dgvVentas.Rows(dgvVentas.Rows.Count - 1).Selected = True
            'dgvVentasItems.DataSource = ""
            txtIDCliente.Enabled = False
            dtpFecha.Enabled = False
            btnAgregarVenta.Enabled = True
            btnEditarVenta.Enabled = True
            btnEliminarVenta.Enabled = True
            btnGuardarEditarVenta.Enabled = False
            btnGuardarEditarVenta.Visible = True
            btnCancelarVenta.Enabled = False
            RellenarTextBoxesItems()
            ActivarBotonesItems()
            MessageBox.Show("Venta agregada correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar la venta seleccionada. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarEditarVenta_Click(sender As Object, e As EventArgs) Handles btnGuardarEditarVenta.Click
        Try
            Venta.ID = txtIDVenta.Text
            Venta.IDCliente = txtIDCliente.Text
            Venta.Fecha = dtpFecha.Value
            Venta.Total = txtTotal.Text
            VentaDAO.Editar(Venta)
            ListarVentas()
            dgvVentas.Rows(0).Selected = False
            dgvVentas.Rows(IndexFilaSeleccionadaVentas).Selected = True
            txtIDCliente.Enabled = False
            dtpFecha.Enabled = False
            btnAgregarVenta.Enabled = True
            btnEditarVenta.Enabled = True
            btnEliminarVenta.Enabled = True
            btnGuardarEditarVenta.Enabled = False
            btnCancelarVenta.Enabled = False
            ActivarBotonesItems()
            MessageBox.Show("Venta editada correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo editar la venta seleccionada. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click
        txtIDCliente.Enabled = False
        dtpFecha.Enabled = False
        btnAgregarVenta.Enabled = True
        btnEliminarVenta.Enabled = True
        btnEditarVenta.Enabled = True
        btnGuardarAgregarVenta.Visible = False
        btnGuardarEditarVenta.Enabled = False
        btnGuardarEditarVenta.Visible = True
        btnCancelarVenta.Enabled = False
        RellenarTextBoxesVentas()
        ActivarBotonesItems()
    End Sub
#End Region

#Region "VentasItems"
    Public Sub ListarItems()
        If txtIDVenta.Text <> "" Then
            dgvVentasItems.DataSource = VentaItemDAO.Listar(txtIDVenta.Text)
        Else
            dgvVentasItems.DataSource = VentaItemDAO.Listar(0)
        End If

        'Si lo que me devuelve la lista es NULL, mostrar un mensaje de error.
    End Sub

    Public Sub BuscarItem()
        dgvVentas.DataSource = VentaDAO.Buscar(cmbTipoDeCampoVenta.Text, txtCampoVenta.Text)
        RellenarTextBoxesItems()

    End Sub

    Public Sub RellenarTextBoxesItems()

        If dgvVentasItems.Rows.Count > 0 Then
            txtIDItem.Text = dgvVentasItems.CurrentRow.Cells(0).Value
            txtIDVenta2.Text = dgvVentasItems.CurrentRow.Cells(1).Value
            txtIDProducto.Text = dgvVentasItems.CurrentRow.Cells(2).Value
            txtPrecioUnitario.Text = dgvVentasItems.CurrentRow.Cells(5).Value
            txtCantidad.Text = dgvVentasItems.CurrentRow.Cells(3).Value
            txtPrecioTotal.Text = dgvVentasItems.CurrentRow.Cells(4).Value
        Else
            txtIDItem.Clear()
            txtIDVenta2.Clear()
            txtIDProducto.Clear()
            txtPrecioUnitario.Clear()
            txtCantidad.Clear()
            txtPrecioTotal.Clear()
        End If

    End Sub

    Public Sub LimpiarTextBoxesItems()
        txtIDItem.Clear()
        txtIDVenta2.Text = txtIDVenta.Text
        txtIDProducto.Clear()
        txtPrecioUnitario.Text = 0
        txtCantidad.Text = 0
        txtPrecioTotal.Text = 0
    End Sub

    Public Sub ActivarBotonesVentas()
        btnAgregarVenta.Enabled = True
        btnEditarVenta.Enabled = True
        btnEliminarVenta.Enabled = True
        btnGuardarAgregarVenta.Enabled = True
        btnGuardarEditarVenta.Enabled = True
        btnCancelarVenta.Enabled = True
    End Sub

    Public Sub DesactivarBotonesVentas()
        btnAgregarVenta.Enabled = False
        btnEditarVenta.Enabled = False
        btnEliminarVenta.Enabled = False
        btnGuardarAgregarVenta.Enabled = False
        btnGuardarEditarVenta.Enabled = False
        btnCancelarVenta.Enabled = False
    End Sub

    Private Sub txtCampoItem_TextChanged(sender As Object, e As EventArgs) Handles txtCampoItem.TextChanged
        If txtCampoItem.Text = "" Then
            ListarItems()
        Else
            If (dgvVentasItems.Rows.Count > 0) Then
                BuscarItem()
            End If
        End If
    End Sub

    Private Sub btnBorrarBusquedaDeItem_Click(sender As Object, e As EventArgs) Handles btnBorrarBusquedaDeItem.Click
        txtCampoItem.Text = ""
    End Sub

    Private Sub dgvVentasItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentasItems.CellClick
        RellenarTextBoxesItems()
        IndexFilaSeleccionadaVentasItems = dgvVentasItems.CurrentRow.Index
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click
        Me.AcceptButton = btnGuardarAgregarItem
        Me.CancelButton = btnCancelarItem
        LimpiarTextBoxesItems()
        txtIDProducto.Enabled = True
        txtIDProducto.Select()
        txtPrecioUnitario.Enabled = True
        txtPrecioUnitario.Text = 0
        txtCantidad.Enabled = True
        txtPrecioTotal.Enabled = True
        btnAgregarItem.Enabled = False
        btnEditarItem.Enabled = False
        btnEliminarItem.Enabled = False
        btnGuardarAgregarItem.Enabled = True
        btnGuardarAgregarItem.Visible = True
        btnGuardarEditarItem.Enabled = True
        btnGuardarEditarItem.Visible = False
        btnCancelarItem.Enabled = True
    End Sub

    Private Sub btnEditarItem_Click(sender As Object, e As EventArgs) Handles btnEditarItem.Click
        Me.AcceptButton = btnGuardarEditarItem
        Me.CancelButton = btnCancelarItem
        txtIDProducto.Enabled = True
        txtIDProducto.Select()
        txtPrecioUnitario.Enabled = True
        txtCantidad.Enabled = True
        txtPrecioTotal.Enabled = True
        btnAgregarItem.Enabled = False
        btnEditarItem.Enabled = False
        btnEliminarItem.Enabled = False
        btnGuardarAgregarItem.Visible = False
        btnGuardarEditarItem.Enabled = True
        btnGuardarEditarItem.Visible = True
        btnCancelarItem.Enabled = True
    End Sub

    Private Sub btnEliminarItem_Click(sender As Object, e As EventArgs) Handles btnEliminarItem.Click
        Try
            SumaDePreciosItems = 0
            VentaItem.ID = txtIDItem.Text
            VentaItemDAO.Eliminar(VentaItem)
            ListarItems()
            For Each row As DataGridViewRow In dgvVentasItems.Rows
                SumaDePreciosItems += row.Cells("PrecioTotal").Value
            Next
            Venta.ID = txtIDVenta.Text
            Venta.IDCliente = txtIDCliente.Text
            Venta.Fecha = dtpFecha.Value
            Venta.Total = SumaDePreciosItems
            VentaDAO.Editar(Venta)
            ListarVentas()
            dgvVentas.Rows(0).Selected = False
            dgvVentas.Rows(IndexFilaSeleccionadaVentas).Selected = True
            MessageBox.Show("Ítem eliminado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar el ítem seleccionado. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub txtPrecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioUnitario.KeyPress
        If txtPrecioUnitario.Text = "0" Then
            txtPrecioUnitario.Text = ""
        End If
    End Sub

    Private Sub txtPrecioUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioUnitario.TextChanged
        If txtPrecioUnitario.Text <> Trim(" ") And txtCantidad.Text <> Trim(" ") Then
            txtPrecioTotal.Text = (txtPrecioUnitario.Text) * txtCantidad.Text
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If txtCantidad.Text = "0" Then
            txtCantidad.Text = ""
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text <> Trim("") And txtPrecioUnitario.Text <> Trim("") Then
            txtPrecioTotal.Text = (txtPrecioUnitario.Text) * txtCantidad.Text
        End If
    End Sub

    Private Sub txtPrecioTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioTotal.KeyPress
        If txtPrecioTotal.Text = "0" Then
            txtPrecioTotal.Text = ""
        End If
    End Sub

    Private Sub txtPrecioTotal_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioTotal.TextChanged
        If txtPrecioTotal.Text <> Trim(" ") And txtCantidad.Text <> Trim(" ") Then
            txtPrecioUnitario.Text = (txtPrecioTotal.Text) / txtCantidad.Text
        End If
    End Sub

    Private Sub btnGuardarAgregarItem_Click(sender As Object, e As EventArgs) Handles btnGuardarAgregarItem.Click
        Try
            SumaDePreciosItems = 0
            VentaItem.IDVenta = txtIDVenta2.Text
            VentaItem.IDProducto = txtIDProducto.Text
            VentaItem.PrecioUnitario = txtPrecioUnitario.Text
            VentaItem.Cantidad = txtCantidad.Text
            VentaItem.PrecioTotal = txtPrecioTotal.Text
            VentaItemDAO.Agregar(VentaItem)
            ListarItems()

            For Each row As DataGridViewRow In dgvVentasItems.Rows
                SumaDePreciosItems += row.Cells("PrecioTotal").Value
            Next

            Venta.ID = txtIDVenta.Text
            Venta.IDCliente = txtIDCliente.Text
            Venta.Fecha = dtpFecha.Value
            Venta.Total = SumaDePreciosItems
            VentaDAO.Editar(Venta)

            ListarVentas()
            dgvVentas.Rows(0).Selected = False
            dgvVentas.Rows(IndexFilaSeleccionadaVentas).Selected = True

            ListarItems()
            dgvVentasItems.Rows(0).Selected = False
            dgvVentasItems.Rows(dgvVentasItems.Rows.Count - 1).Selected = True

            txtIDProducto.Enabled = False
            txtPrecioUnitario.Enabled = False
            txtCantidad.Enabled = False
            txtPrecioTotal.Enabled = False
            btnAgregarItem.Enabled = True
            btnEliminarItem.Enabled = True
            btnEditarItem.Enabled = True
            btnGuardarAgregarItem.Enabled = False
            btnGuardarAgregarItem.Visible = False
            btnGuardarEditarItem.Enabled = False
            btnGuardarEditarItem.Visible = True
            btnCancelarItem.Enabled = False
            MessageBox.Show("Ítem agregado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar el ítem seleccionado. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarEditarItem_Click(sender As Object, e As EventArgs) Handles btnGuardarEditarItem.Click
        Try
            SumaDePreciosItems = 0
            VentaItem.ID = txtIDItem.Text
            VentaItem.IDVenta = txtIDVenta2.Text
            VentaItem.IDProducto = txtIDProducto.Text
            VentaItem.PrecioUnitario = txtPrecioUnitario.Text
            VentaItem.Cantidad = txtCantidad.Text
            VentaItem.PrecioTotal = SumaDePreciosItems
            ListarItems()
            dgvVentasItems.Rows(0).Selected = False
            dgvVentasItems.Rows(IndexFilaSeleccionadaVentasItems).Selected = True

            For Each row As DataGridViewRow In dgvVentasItems.Rows
                SumaDePreciosItems += row.Cells("PrecioTotal").Value
            Next

            Venta.ID = txtIDVenta.Text
            Venta.IDCliente = txtIDCliente.Text
            Venta.Fecha = dtpFecha.Value
            Venta.Total = SumaDePreciosItems
            VentaDAO.Editar(Venta)
            ListarVentas()
            dgvVentas.Rows(0).Selected = False
            dgvVentas.Rows(IndexFilaSeleccionadaVentas).Selected = True

            txtIDProducto.Enabled = False
            txtPrecioUnitario.Enabled = False
            txtCantidad.Enabled = False
            txtPrecioTotal.Enabled = False
            btnAgregarItem.Enabled = True
            btnEditarItem.Enabled = True
            btnEliminarItem.Enabled = True
            btnGuardarEditarItem.Enabled = False
            btnCancelarItem.Enabled = False
            MessageBox.Show("Ítem editado correctamente")
        Catch ex As Exception
            MessageBox.Show("No se pudo editar el ítem seleccionado. Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCancelarItem_Click(sender As Object, e As EventArgs) Handles btnCancelarItem.Click
        txtIDProducto.Enabled = False
        txtPrecioUnitario.Enabled = False
        txtCantidad.Enabled = False
        txtPrecioTotal.Enabled = False
        btnAgregarItem.Enabled = True
        btnEditarItem.Enabled = True
        btnEliminarItem.Enabled = True
        btnGuardarAgregarItem.Visible = False
        btnGuardarEditarItem.Enabled = False
        btnGuardarEditarItem.Visible = True
        btnCancelarItem.Enabled = False
    End Sub

    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick

    End Sub

#End Region

End Class