<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBorrarBusquedaDeItem = New System.Windows.Forms.Button()
        Me.lblListaItemsPorVenta = New System.Windows.Forms.Label()
        Me.cmbTipoDeCampoItem = New System.Windows.Forms.ComboBox()
        Me.btnEditarItem = New System.Windows.Forms.Button()
        Me.txtCampoItem = New System.Windows.Forms.TextBox()
        Me.btnEliminarItem = New System.Windows.Forms.Button()
        Me.btnAgregarItem = New System.Windows.Forms.Button()
        Me.dgvVentasItems = New System.Windows.Forms.DataGridView()
        Me.btnBorrarBusquedaDeVenta = New System.Windows.Forms.Button()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.cmbTipoDeCampoVenta = New System.Windows.Forms.ComboBox()
        Me.btnEditarVenta = New System.Windows.Forms.Button()
        Me.txtCampoVenta = New System.Windows.Forms.TextBox()
        Me.btnEliminarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.pnlAltaYModificacion = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblIDCliente = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblIDVenta = New System.Windows.Forms.Label()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.txtIDVenta = New System.Windows.Forms.TextBox()
        Me.btnCancelarVenta = New System.Windows.Forms.Button()
        Me.lblPreciounitario = New System.Windows.Forms.Label()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.lblIDProducto = New System.Windows.Forms.Label()
        Me.lblIDVentaVI = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnGuardarEditarVenta = New System.Windows.Forms.Button()
        Me.lblAltaYModificación = New System.Windows.Forms.Label()
        Me.btnGuardarAgregarVenta = New System.Windows.Forms.Button()
        Me.txtIDItem = New System.Windows.Forms.TextBox()
        Me.btnCancelarItem = New System.Windows.Forms.Button()
        Me.txtIDVenta2 = New System.Windows.Forms.TextBox()
        Me.txtIDProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.btnGuardarEditarItem = New System.Windows.Forms.Button()
        Me.btnGuardarAgregarItem = New System.Windows.Forms.Button()
        CType(Me.dgvVentasItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAltaYModificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBorrarBusquedaDeItem
        '
        Me.btnBorrarBusquedaDeItem.BackColor = System.Drawing.Color.White
        Me.btnBorrarBusquedaDeItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarBusquedaDeItem.FlatAppearance.BorderSize = 0
        Me.btnBorrarBusquedaDeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarBusquedaDeItem.Image = Global.CapaDePresentacion.My.Resources.Resources.Cruz
        Me.btnBorrarBusquedaDeItem.Location = New System.Drawing.Point(642, 341)
        Me.btnBorrarBusquedaDeItem.Name = "btnBorrarBusquedaDeItem"
        Me.btnBorrarBusquedaDeItem.Size = New System.Drawing.Size(16, 16)
        Me.btnBorrarBusquedaDeItem.TabIndex = 16
        Me.btnBorrarBusquedaDeItem.UseVisualStyleBackColor = False
        '
        'lblListaItemsPorVenta
        '
        Me.lblListaItemsPorVenta.AutoSize = True
        Me.lblListaItemsPorVenta.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaItemsPorVenta.ForeColor = System.Drawing.Color.Black
        Me.lblListaItemsPorVenta.Location = New System.Drawing.Point(59, 299)
        Me.lblListaItemsPorVenta.Name = "lblListaItemsPorVenta"
        Me.lblListaItemsPorVenta.Size = New System.Drawing.Size(254, 24)
        Me.lblListaItemsPorVenta.TabIndex = 84
        Me.lblListaItemsPorVenta.Text = "Lista de ítems por venta"
        '
        'cmbTipoDeCampoItem
        '
        Me.cmbTipoDeCampoItem.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cmbTipoDeCampoItem.FormattingEnabled = True
        Me.cmbTipoDeCampoItem.ItemHeight = 17
        Me.cmbTipoDeCampoItem.Items.AddRange(New Object() {"ID", "IDVenta", "IDProducto", "PrecioUnitario", "Cantidad", "PrecioTotal"})
        Me.cmbTipoDeCampoItem.Location = New System.Drawing.Point(63, 336)
        Me.cmbTipoDeCampoItem.Name = "cmbTipoDeCampoItem"
        Me.cmbTipoDeCampoItem.Size = New System.Drawing.Size(90, 25)
        Me.cmbTipoDeCampoItem.TabIndex = 14
        Me.cmbTipoDeCampoItem.Text = "ID"
        '
        'btnEditarItem
        '
        Me.btnEditarItem.BackColor = System.Drawing.Color.White
        Me.btnEditarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarItem.ForeColor = System.Drawing.Color.Black
        Me.btnEditarItem.Location = New System.Drawing.Point(164, 532)
        Me.btnEditarItem.Name = "btnEditarItem"
        Me.btnEditarItem.Size = New System.Drawing.Size(74, 35)
        Me.btnEditarItem.TabIndex = 19
        Me.btnEditarItem.Text = "Editar"
        Me.btnEditarItem.UseVisualStyleBackColor = False
        '
        'txtCampoItem
        '
        Me.txtCampoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCampoItem.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtCampoItem.Location = New System.Drawing.Point(152, 336)
        Me.txtCampoItem.Name = "txtCampoItem"
        Me.txtCampoItem.Size = New System.Drawing.Size(511, 25)
        Me.txtCampoItem.TabIndex = 15
        '
        'btnEliminarItem
        '
        Me.btnEliminarItem.BackColor = System.Drawing.Color.White
        Me.btnEliminarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarItem.ForeColor = System.Drawing.Color.Black
        Me.btnEliminarItem.Location = New System.Drawing.Point(252, 532)
        Me.btnEliminarItem.Name = "btnEliminarItem"
        Me.btnEliminarItem.Size = New System.Drawing.Size(79, 35)
        Me.btnEliminarItem.TabIndex = 20
        Me.btnEliminarItem.Text = "Eliminar"
        Me.btnEliminarItem.UseVisualStyleBackColor = False
        '
        'btnAgregarItem
        '
        Me.btnAgregarItem.BackColor = System.Drawing.Color.White
        Me.btnAgregarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarItem.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarItem.Location = New System.Drawing.Point(64, 532)
        Me.btnAgregarItem.Name = "btnAgregarItem"
        Me.btnAgregarItem.Size = New System.Drawing.Size(86, 35)
        Me.btnAgregarItem.TabIndex = 18
        Me.btnAgregarItem.Text = "Agregar"
        Me.btnAgregarItem.UseVisualStyleBackColor = False
        '
        'dgvVentasItems
        '
        Me.dgvVentasItems.AllowDrop = True
        Me.dgvVentasItems.AllowUserToAddRows = False
        Me.dgvVentasItems.AllowUserToDeleteRows = False
        Me.dgvVentasItems.AllowUserToResizeColumns = False
        Me.dgvVentasItems.AllowUserToResizeRows = False
        Me.dgvVentasItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVentasItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentasItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentasItems.ColumnHeadersHeight = 50
        Me.dgvVentasItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentasItems.EnableHeadersVisualStyles = False
        Me.dgvVentasItems.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvVentasItems.Location = New System.Drawing.Point(63, 360)
        Me.dgvVentasItems.Name = "dgvVentasItems"
        Me.dgvVentasItems.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVentasItems.RowHeadersVisible = False
        Me.dgvVentasItems.RowHeadersWidth = 50
        Me.dgvVentasItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvVentasItems.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentasItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentasItems.Size = New System.Drawing.Size(600, 160)
        Me.dgvVentasItems.TabIndex = 0
        Me.dgvVentasItems.TabStop = False
        '
        'btnBorrarBusquedaDeVenta
        '
        Me.btnBorrarBusquedaDeVenta.BackColor = System.Drawing.Color.White
        Me.btnBorrarBusquedaDeVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarBusquedaDeVenta.FlatAppearance.BorderSize = 0
        Me.btnBorrarBusquedaDeVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarBusquedaDeVenta.Image = Global.CapaDePresentacion.My.Resources.Resources.Cruz
        Me.btnBorrarBusquedaDeVenta.Location = New System.Drawing.Point(642, 60)
        Me.btnBorrarBusquedaDeVenta.Name = "btnBorrarBusquedaDeVenta"
        Me.btnBorrarBusquedaDeVenta.Size = New System.Drawing.Size(16, 16)
        Me.btnBorrarBusquedaDeVenta.TabIndex = 3
        Me.btnBorrarBusquedaDeVenta.UseVisualStyleBackColor = False
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLista.ForeColor = System.Drawing.Color.Black
        Me.lblLista.Location = New System.Drawing.Point(58, 18)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(161, 24)
        Me.lblLista.TabIndex = 75
        Me.lblLista.Text = "Lista de ventas"
        '
        'cmbTipoDeCampoVenta
        '
        Me.cmbTipoDeCampoVenta.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cmbTipoDeCampoVenta.FormattingEnabled = True
        Me.cmbTipoDeCampoVenta.Items.AddRange(New Object() {"ID", "IDCliente", "Fecha", "Total"})
        Me.cmbTipoDeCampoVenta.Location = New System.Drawing.Point(62, 55)
        Me.cmbTipoDeCampoVenta.Name = "cmbTipoDeCampoVenta"
        Me.cmbTipoDeCampoVenta.Size = New System.Drawing.Size(90, 25)
        Me.cmbTipoDeCampoVenta.TabIndex = 1
        Me.cmbTipoDeCampoVenta.Text = "ID"
        '
        'btnEditarVenta
        '
        Me.btnEditarVenta.BackColor = System.Drawing.Color.White
        Me.btnEditarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarVenta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEditarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarVenta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarVenta.ForeColor = System.Drawing.Color.Black
        Me.btnEditarVenta.Location = New System.Drawing.Point(163, 251)
        Me.btnEditarVenta.Name = "btnEditarVenta"
        Me.btnEditarVenta.Size = New System.Drawing.Size(74, 35)
        Me.btnEditarVenta.TabIndex = 6
        Me.btnEditarVenta.Text = "Editar"
        Me.btnEditarVenta.UseVisualStyleBackColor = False
        '
        'txtCampoVenta
        '
        Me.txtCampoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCampoVenta.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtCampoVenta.Location = New System.Drawing.Point(151, 55)
        Me.txtCampoVenta.Name = "txtCampoVenta"
        Me.txtCampoVenta.Size = New System.Drawing.Size(511, 25)
        Me.txtCampoVenta.TabIndex = 2
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.BackColor = System.Drawing.Color.White
        Me.btnEliminarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarVenta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarVenta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarVenta.ForeColor = System.Drawing.Color.Black
        Me.btnEliminarVenta.Location = New System.Drawing.Point(251, 251)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Size = New System.Drawing.Size(79, 35)
        Me.btnEliminarVenta.TabIndex = 7
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = False
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.BackColor = System.Drawing.Color.White
        Me.btnAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarVenta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarVenta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarVenta.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarVenta.Location = New System.Drawing.Point(63, 251)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(86, 35)
        Me.btnAgregarVenta.TabIndex = 5
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = False
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowDrop = True
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AllowUserToResizeColumns = False
        Me.dgvVentas.AllowUserToResizeRows = False
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVentas.ColumnHeadersHeight = 50
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentas.EnableHeadersVisualStyles = False
        Me.dgvVentas.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvVentas.Location = New System.Drawing.Point(62, 79)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.RowHeadersWidth = 50
        Me.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvVentas.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(600, 160)
        Me.dgvVentas.TabIndex = 0
        Me.dgvVentas.TabStop = False
        '
        'pnlAltaYModificacion
        '
        Me.pnlAltaYModificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.pnlAltaYModificacion.Controls.Add(Me.dtpFecha)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblTotal)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblPrecioTotal)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblFecha)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblCantidad)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblIDCliente)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtCantidad)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblIDVenta)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtPrecioTotal)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtIDVenta)
        Me.pnlAltaYModificacion.Controls.Add(Me.btnCancelarVenta)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblPreciounitario)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtIDCliente)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblIDProducto)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblIDVentaVI)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtTotal)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblID)
        Me.pnlAltaYModificacion.Controls.Add(Me.btnGuardarEditarVenta)
        Me.pnlAltaYModificacion.Controls.Add(Me.lblAltaYModificación)
        Me.pnlAltaYModificacion.Controls.Add(Me.btnGuardarAgregarVenta)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtIDItem)
        Me.pnlAltaYModificacion.Controls.Add(Me.btnCancelarItem)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtIDVenta2)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtIDProducto)
        Me.pnlAltaYModificacion.Controls.Add(Me.txtPrecioUnitario)
        Me.pnlAltaYModificacion.Controls.Add(Me.btnGuardarEditarItem)
        Me.pnlAltaYModificacion.Controls.Add(Me.btnGuardarAgregarItem)
        Me.pnlAltaYModificacion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pnlAltaYModificacion.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlAltaYModificacion.Location = New System.Drawing.Point(838, 0)
        Me.pnlAltaYModificacion.Name = "pnlAltaYModificacion"
        Me.pnlAltaYModificacion.Size = New System.Drawing.Size(426, 587)
        Me.pnlAltaYModificacion.TabIndex = 76
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(201, 178)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(111, 20)
        Me.dtpFecha.TabIndex = 10
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(108, 215)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(49, 21)
        Me.lblTotal.TabIndex = 78
        Me.lblTotal.Text = "Total"
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.AutoSize = True
        Me.lblPrecioTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotal.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioTotal.Location = New System.Drawing.Point(108, 483)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(99, 21)
        Me.lblPrecioTotal.TabIndex = 44
        Me.lblPrecioTotal.Text = "Precio total"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(108, 177)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(59, 21)
        Me.lblFecha.TabIndex = 77
        Me.lblFecha.Text = "Fecha"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Black
        Me.lblCantidad.Location = New System.Drawing.Point(108, 453)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(87, 21)
        Me.lblCantidad.TabIndex = 43
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblIDCliente
        '
        Me.lblIDCliente.AutoSize = True
        Me.lblIDCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCliente.ForeColor = System.Drawing.Color.Black
        Me.lblIDCliente.Location = New System.Drawing.Point(108, 138)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(87, 21)
        Me.lblIDCliente.TabIndex = 76
        Me.lblIDCliente.Text = "ID Cliente"
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(201, 454)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(111, 23)
        Me.txtCantidad.TabIndex = 25
        Me.txtCantidad.Text = "0"
        '
        'lblIDVenta
        '
        Me.lblIDVenta.AutoSize = True
        Me.lblIDVenta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDVenta.ForeColor = System.Drawing.Color.Black
        Me.lblIDVenta.Location = New System.Drawing.Point(108, 95)
        Me.lblIDVenta.Name = "lblIDVenta"
        Me.lblIDVenta.Size = New System.Drawing.Size(27, 21)
        Me.lblIDVenta.TabIndex = 75
        Me.lblIDVenta.Text = "ID"
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Enabled = False
        Me.txtPrecioTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioTotal.Location = New System.Drawing.Point(213, 483)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.Size = New System.Drawing.Size(99, 23)
        Me.txtPrecioTotal.TabIndex = 26
        Me.txtPrecioTotal.Text = "0"
        '
        'txtIDVenta
        '
        Me.txtIDVenta.Enabled = False
        Me.txtIDVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDVenta.Location = New System.Drawing.Point(201, 96)
        Me.txtIDVenta.Name = "txtIDVenta"
        Me.txtIDVenta.Size = New System.Drawing.Size(111, 23)
        Me.txtIDVenta.TabIndex = 8
        '
        'btnCancelarVenta
        '
        Me.btnCancelarVenta.BackColor = System.Drawing.Color.White
        Me.btnCancelarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarVenta.Enabled = False
        Me.btnCancelarVenta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarVenta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarVenta.ForeColor = System.Drawing.Color.Black
        Me.btnCancelarVenta.Location = New System.Drawing.Point(218, 251)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(94, 35)
        Me.btnCancelarVenta.TabIndex = 13
        Me.btnCancelarVenta.Text = "Cancelar"
        Me.btnCancelarVenta.UseVisualStyleBackColor = False
        '
        'lblPreciounitario
        '
        Me.lblPreciounitario.AutoSize = True
        Me.lblPreciounitario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreciounitario.ForeColor = System.Drawing.Color.Black
        Me.lblPreciounitario.Location = New System.Drawing.Point(108, 424)
        Me.lblPreciounitario.Name = "lblPreciounitario"
        Me.lblPreciounitario.Size = New System.Drawing.Size(120, 21)
        Me.lblPreciounitario.TabIndex = 40
        Me.lblPreciounitario.Text = "Precio unitario"
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Enabled = False
        Me.txtIDCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDCliente.Location = New System.Drawing.Point(201, 138)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(111, 23)
        Me.txtIDCliente.TabIndex = 9
        '
        'lblIDProducto
        '
        Me.lblIDProducto.AutoSize = True
        Me.lblIDProducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDProducto.ForeColor = System.Drawing.Color.Black
        Me.lblIDProducto.Location = New System.Drawing.Point(108, 396)
        Me.lblIDProducto.Name = "lblIDProducto"
        Me.lblIDProducto.Size = New System.Drawing.Size(105, 21)
        Me.lblIDProducto.TabIndex = 39
        Me.lblIDProducto.Text = "ID producto"
        '
        'lblIDVentaVI
        '
        Me.lblIDVentaVI.AutoSize = True
        Me.lblIDVentaVI.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDVentaVI.ForeColor = System.Drawing.Color.Black
        Me.lblIDVentaVI.Location = New System.Drawing.Point(108, 366)
        Me.lblIDVentaVI.Name = "lblIDVentaVI"
        Me.lblIDVentaVI.Size = New System.Drawing.Size(79, 21)
        Me.lblIDVentaVI.TabIndex = 38
        Me.lblIDVentaVI.Text = "ID venta"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(163, 216)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(149, 23)
        Me.txtTotal.TabIndex = 11
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(108, 338)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(27, 21)
        Me.lblID.TabIndex = 37
        Me.lblID.Text = "ID"
        '
        'btnGuardarEditarVenta
        '
        Me.btnGuardarEditarVenta.BackColor = System.Drawing.Color.White
        Me.btnGuardarEditarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarEditarVenta.Enabled = False
        Me.btnGuardarEditarVenta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGuardarEditarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEditarVenta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEditarVenta.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarEditarVenta.Location = New System.Drawing.Point(112, 251)
        Me.btnGuardarEditarVenta.Name = "btnGuardarEditarVenta"
        Me.btnGuardarEditarVenta.Size = New System.Drawing.Size(87, 35)
        Me.btnGuardarEditarVenta.TabIndex = 12
        Me.btnGuardarEditarVenta.Text = "Guardar"
        Me.btnGuardarEditarVenta.UseVisualStyleBackColor = False
        '
        'lblAltaYModificación
        '
        Me.lblAltaYModificación.AutoSize = True
        Me.lblAltaYModificación.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaYModificación.ForeColor = System.Drawing.Color.Black
        Me.lblAltaYModificación.Location = New System.Drawing.Point(108, 18)
        Me.lblAltaYModificación.Name = "lblAltaYModificación"
        Me.lblAltaYModificación.Size = New System.Drawing.Size(208, 24)
        Me.lblAltaYModificación.TabIndex = 36
        Me.lblAltaYModificación.Text = "Alta y modificación"
        '
        'btnGuardarAgregarVenta
        '
        Me.btnGuardarAgregarVenta.BackColor = System.Drawing.Color.White
        Me.btnGuardarAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarAgregarVenta.Enabled = False
        Me.btnGuardarAgregarVenta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGuardarAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarAgregarVenta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAgregarVenta.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarAgregarVenta.Location = New System.Drawing.Point(112, 251)
        Me.btnGuardarAgregarVenta.Name = "btnGuardarAgregarVenta"
        Me.btnGuardarAgregarVenta.Size = New System.Drawing.Size(87, 35)
        Me.btnGuardarAgregarVenta.TabIndex = 74
        Me.btnGuardarAgregarVenta.Text = "Guardar"
        Me.btnGuardarAgregarVenta.UseVisualStyleBackColor = False
        '
        'txtIDItem
        '
        Me.txtIDItem.Enabled = False
        Me.txtIDItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDItem.Location = New System.Drawing.Point(201, 338)
        Me.txtIDItem.Name = "txtIDItem"
        Me.txtIDItem.Size = New System.Drawing.Size(111, 23)
        Me.txtIDItem.TabIndex = 21
        '
        'btnCancelarItem
        '
        Me.btnCancelarItem.BackColor = System.Drawing.Color.White
        Me.btnCancelarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarItem.Enabled = False
        Me.btnCancelarItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarItem.ForeColor = System.Drawing.Color.Black
        Me.btnCancelarItem.Location = New System.Drawing.Point(218, 532)
        Me.btnCancelarItem.Name = "btnCancelarItem"
        Me.btnCancelarItem.Size = New System.Drawing.Size(94, 35)
        Me.btnCancelarItem.TabIndex = 28
        Me.btnCancelarItem.Text = "Cancelar"
        Me.btnCancelarItem.UseVisualStyleBackColor = False
        '
        'txtIDVenta2
        '
        Me.txtIDVenta2.Enabled = False
        Me.txtIDVenta2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDVenta2.Location = New System.Drawing.Point(201, 367)
        Me.txtIDVenta2.Name = "txtIDVenta2"
        Me.txtIDVenta2.Size = New System.Drawing.Size(111, 23)
        Me.txtIDVenta2.TabIndex = 22
        '
        'txtIDProducto
        '
        Me.txtIDProducto.Enabled = False
        Me.txtIDProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDProducto.Location = New System.Drawing.Point(218, 396)
        Me.txtIDProducto.Name = "txtIDProducto"
        Me.txtIDProducto.Size = New System.Drawing.Size(94, 23)
        Me.txtIDProducto.TabIndex = 23
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Enabled = False
        Me.txtPrecioUnitario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(234, 425)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(78, 23)
        Me.txtPrecioUnitario.TabIndex = 24
        Me.txtPrecioUnitario.Text = "0"
        '
        'btnGuardarEditarItem
        '
        Me.btnGuardarEditarItem.BackColor = System.Drawing.Color.White
        Me.btnGuardarEditarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarEditarItem.Enabled = False
        Me.btnGuardarEditarItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGuardarEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEditarItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEditarItem.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarEditarItem.Location = New System.Drawing.Point(112, 532)
        Me.btnGuardarEditarItem.Name = "btnGuardarEditarItem"
        Me.btnGuardarEditarItem.Size = New System.Drawing.Size(87, 35)
        Me.btnGuardarEditarItem.TabIndex = 27
        Me.btnGuardarEditarItem.Text = "Guardar"
        Me.btnGuardarEditarItem.UseVisualStyleBackColor = False
        '
        'btnGuardarAgregarItem
        '
        Me.btnGuardarAgregarItem.BackColor = System.Drawing.Color.White
        Me.btnGuardarAgregarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarAgregarItem.Enabled = False
        Me.btnGuardarAgregarItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGuardarAgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarAgregarItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAgregarItem.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarAgregarItem.Location = New System.Drawing.Point(112, 532)
        Me.btnGuardarAgregarItem.Name = "btnGuardarAgregarItem"
        Me.btnGuardarAgregarItem.Size = New System.Drawing.Size(87, 35)
        Me.btnGuardarAgregarItem.TabIndex = 31
        Me.btnGuardarAgregarItem.Text = "Guardar"
        Me.btnGuardarAgregarItem.UseVisualStyleBackColor = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 587)
        Me.Controls.Add(Me.btnBorrarBusquedaDeItem)
        Me.Controls.Add(Me.lblListaItemsPorVenta)
        Me.Controls.Add(Me.cmbTipoDeCampoItem)
        Me.Controls.Add(Me.btnEditarItem)
        Me.Controls.Add(Me.txtCampoItem)
        Me.Controls.Add(Me.btnEliminarItem)
        Me.Controls.Add(Me.btnAgregarItem)
        Me.Controls.Add(Me.dgvVentasItems)
        Me.Controls.Add(Me.btnBorrarBusquedaDeVenta)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.cmbTipoDeCampoVenta)
        Me.Controls.Add(Me.btnEditarVenta)
        Me.Controls.Add(Me.txtCampoVenta)
        Me.Controls.Add(Me.btnEliminarVenta)
        Me.Controls.Add(Me.btnAgregarVenta)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.pnlAltaYModificacion)
        Me.Name = "frmVentas"
        Me.Text = "frmVentas"
        CType(Me.dgvVentasItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAltaYModificacion.ResumeLayout(False)
        Me.pnlAltaYModificacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBorrarBusquedaDeItem As Button
    Friend WithEvents lblListaItemsPorVenta As Label
    Friend WithEvents cmbTipoDeCampoItem As ComboBox
    Friend WithEvents btnEditarItem As Button
    Friend WithEvents txtCampoItem As TextBox
    Friend WithEvents btnEliminarItem As Button
    Friend WithEvents btnAgregarItem As Button
    Friend WithEvents dgvVentasItems As DataGridView
    Friend WithEvents btnBorrarBusquedaDeVenta As Button
    Friend WithEvents lblLista As Label
    Friend WithEvents cmbTipoDeCampoVenta As ComboBox
    Friend WithEvents btnEditarVenta As Button
    Friend WithEvents txtCampoVenta As TextBox
    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents pnlAltaYModificacion As Panel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblIDCliente As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblIDVenta As Label
    Friend WithEvents txtPrecioTotal As TextBox
    Friend WithEvents txtIDVenta As TextBox
    Friend WithEvents btnCancelarVenta As Button
    Friend WithEvents lblPreciounitario As Label
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents lblIDProducto As Label
    Friend WithEvents lblIDVentaVI As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnGuardarEditarVenta As Button
    Friend WithEvents lblAltaYModificación As Label
    Friend WithEvents btnGuardarAgregarVenta As Button
    Friend WithEvents txtIDItem As TextBox
    Friend WithEvents btnCancelarItem As Button
    Friend WithEvents txtIDVenta2 As TextBox
    Friend WithEvents txtIDProducto As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents btnGuardarEditarItem As Button
    Friend WithEvents btnGuardarAgregarItem As Button
End Class
