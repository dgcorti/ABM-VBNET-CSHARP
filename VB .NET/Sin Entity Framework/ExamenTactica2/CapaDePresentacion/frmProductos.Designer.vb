<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
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
        Me.btnBorrarBusqueda = New System.Windows.Forms.Button()
        Me.lblListaDeProductos = New System.Windows.Forms.Label()
        Me.cmbTipoDeCampo = New System.Windows.Forms.ComboBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtCampo = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblAltaYModificación = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.btnGuardarEditar = New System.Windows.Forms.Button()
        Me.btnGuardarAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBorrarBusqueda
        '
        Me.btnBorrarBusqueda.BackColor = System.Drawing.Color.White
        Me.btnBorrarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarBusqueda.FlatAppearance.BorderSize = 0
        Me.btnBorrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarBusqueda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBorrarBusqueda.Image = Global.CapaDePresentacion.My.Resources.Resources.Cruz
        Me.btnBorrarBusqueda.Location = New System.Drawing.Point(642, 148)
        Me.btnBorrarBusqueda.Name = "btnBorrarBusqueda"
        Me.btnBorrarBusqueda.Size = New System.Drawing.Size(16, 16)
        Me.btnBorrarBusqueda.TabIndex = 3
        Me.btnBorrarBusqueda.UseVisualStyleBackColor = False
        '
        'lblListaDeProductos
        '
        Me.lblListaDeProductos.AutoSize = True
        Me.lblListaDeProductos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaDeProductos.ForeColor = System.Drawing.Color.Black
        Me.lblListaDeProductos.Location = New System.Drawing.Point(58, 105)
        Me.lblListaDeProductos.Name = "lblListaDeProductos"
        Me.lblListaDeProductos.Size = New System.Drawing.Size(196, 24)
        Me.lblListaDeProductos.TabIndex = 58
        Me.lblListaDeProductos.Text = "Lista de productos"
        '
        'cmbTipoDeCampo
        '
        Me.cmbTipoDeCampo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cmbTipoDeCampo.FormattingEnabled = True
        Me.cmbTipoDeCampo.Items.AddRange(New Object() {"ID", "Nombre", "Precio", "Categoria"})
        Me.cmbTipoDeCampo.Location = New System.Drawing.Point(63, 143)
        Me.cmbTipoDeCampo.Name = "cmbTipoDeCampo"
        Me.cmbTipoDeCampo.Size = New System.Drawing.Size(90, 25)
        Me.cmbTipoDeCampo.TabIndex = 1
        Me.cmbTipoDeCampo.Text = "ID"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.White
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Location = New System.Drawing.Point(163, 430)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(74, 35)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'txtCampo
        '
        Me.txtCampo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCampo.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtCampo.Location = New System.Drawing.Point(152, 143)
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.Size = New System.Drawing.Size(511, 25)
        Me.txtCampo.TabIndex = 2
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(251, 430)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(79, 35)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(63, 430)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(86, 35)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowDrop = True
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.ColumnHeadersHeight = 50
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvProductos.Location = New System.Drawing.Point(63, 167)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowHeadersWidth = 50
        Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(600, 250)
        Me.dgvProductos.TabIndex = 4
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.lblCategoria)
        Me.PanelMenu.Controls.Add(Me.lblPrecio)
        Me.PanelMenu.Controls.Add(Me.lblNombre)
        Me.PanelMenu.Controls.Add(Me.lblID)
        Me.PanelMenu.Controls.Add(Me.lblAltaYModificación)
        Me.PanelMenu.Controls.Add(Me.txtID)
        Me.PanelMenu.Controls.Add(Me.btnCancelar)
        Me.PanelMenu.Controls.Add(Me.txtNombre)
        Me.PanelMenu.Controls.Add(Me.txtPrecio)
        Me.PanelMenu.Controls.Add(Me.txtCategoria)
        Me.PanelMenu.Controls.Add(Me.btnGuardarEditar)
        Me.PanelMenu.Controls.Add(Me.btnGuardarAgregar)
        Me.PanelMenu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelMenu.Location = New System.Drawing.Point(838, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(426, 587)
        Me.PanelMenu.TabIndex = 59
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Black
        Me.lblCategoria.Location = New System.Drawing.Point(109, 345)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(91, 21)
        Me.lblCategoria.TabIndex = 40
        Me.lblCategoria.Text = "Categoría"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Black
        Me.lblPrecio.Location = New System.Drawing.Point(109, 285)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 21)
        Me.lblPrecio.TabIndex = 39
        Me.lblPrecio.Text = "Precio"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(109, 225)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 21)
        Me.lblNombre.TabIndex = 38
        Me.lblNombre.Text = "Nombre"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(109, 165)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(27, 21)
        Me.lblID.TabIndex = 37
        Me.lblID.Text = "ID"
        '
        'lblAltaYModificación
        '
        Me.lblAltaYModificación.AutoSize = True
        Me.lblAltaYModificación.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaYModificación.ForeColor = System.Drawing.Color.Black
        Me.lblAltaYModificación.Location = New System.Drawing.Point(109, 105)
        Me.lblAltaYModificación.Name = "lblAltaYModificación"
        Me.lblAltaYModificación.Size = New System.Drawing.Size(208, 24)
        Me.lblAltaYModificación.TabIndex = 36
        Me.lblAltaYModificación.Text = "Alta y modificación"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(112, 190)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(200, 23)
        Me.txtID.TabIndex = 8
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(218, 430)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 35)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(112, 250)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 23)
        Me.txtNombre.TabIndex = 9
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(112, 310)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(200, 23)
        Me.txtPrecio.TabIndex = 10
        '
        'txtCategoria
        '
        Me.txtCategoria.Enabled = False
        Me.txtCategoria.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(112, 370)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(200, 23)
        Me.txtCategoria.TabIndex = 11
        '
        'btnGuardarEditar
        '
        Me.btnGuardarEditar.BackColor = System.Drawing.Color.White
        Me.btnGuardarEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarEditar.Enabled = False
        Me.btnGuardarEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGuardarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEditar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEditar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarEditar.Location = New System.Drawing.Point(112, 430)
        Me.btnGuardarEditar.Name = "btnGuardarEditar"
        Me.btnGuardarEditar.Size = New System.Drawing.Size(87, 35)
        Me.btnGuardarEditar.TabIndex = 12
        Me.btnGuardarEditar.Text = "Guardar"
        Me.btnGuardarEditar.UseVisualStyleBackColor = False
        '
        'btnGuardarAgregar
        '
        Me.btnGuardarAgregar.BackColor = System.Drawing.Color.White
        Me.btnGuardarAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarAgregar.Enabled = False
        Me.btnGuardarAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGuardarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarAgregar.Location = New System.Drawing.Point(112, 430)
        Me.btnGuardarAgregar.Name = "btnGuardarAgregar"
        Me.btnGuardarAgregar.Size = New System.Drawing.Size(87, 35)
        Me.btnGuardarAgregar.TabIndex = 12
        Me.btnGuardarAgregar.Text = "Guardar"
        Me.btnGuardarAgregar.UseVisualStyleBackColor = False
        '
        'frmProductos
        '
        Me.AcceptButton = Me.btnAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(1264, 587)
        Me.Controls.Add(Me.btnBorrarBusqueda)
        Me.Controls.Add(Me.lblListaDeProductos)
        Me.Controls.Add(Me.cmbTipoDeCampo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtCampo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "frmProductos"
        Me.Text = "frmProducto"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBorrarBusqueda As Button
    Friend WithEvents lblListaDeProductos As Label
    Friend WithEvents cmbTipoDeCampo As ComboBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents txtCampo As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblAltaYModificación As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnGuardarEditar As Button
    Friend WithEvents btnGuardarAgregar As Button
End Class
