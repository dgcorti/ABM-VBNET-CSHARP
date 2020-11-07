<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlFormularios = New System.Windows.Forms.Panel()
        Me.pctTactica = New System.Windows.Forms.PictureBox()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.pnlFormularios.SuspendLayout()
        CType(Me.pctTactica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFormularios
        '
        Me.pnlFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.pnlFormularios.Controls.Add(Me.pctTactica)
        Me.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFormularios.Location = New System.Drawing.Point(0, 55)
        Me.pnlFormularios.Name = "pnlFormularios"
        Me.pnlFormularios.Size = New System.Drawing.Size(1264, 626)
        Me.pnlFormularios.TabIndex = 4
        '
        'pctTactica
        '
        Me.pctTactica.Image = Global.CapaDePresentacion.My.Resources.Resources.TacticaSoft
        Me.pctTactica.Location = New System.Drawing.Point(482, 163)
        Me.pctTactica.Name = "pctTactica"
        Me.pctTactica.Size = New System.Drawing.Size(300, 300)
        Me.pctTactica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTactica.TabIndex = 0
        Me.pctTactica.TabStop = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnClientes)
        Me.pnlMenu.Controls.Add(Me.btnProductos)
        Me.pnlMenu.Controls.Add(Me.btnVentas)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(1264, 55)
        Me.pnlMenu.TabIndex = 36
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.White
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.Black
        Me.btnClientes.Image = Global.CapaDePresentacion.My.Resources.Resources.Cliente
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(135, 10)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(98, 35)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.TabStop = False
        Me.btnClientes.Text = "    Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.White
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.Black
        Me.btnProductos.Image = Global.CapaDePresentacion.My.Resources.Resources.Producto
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(10, 10)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(114, 35)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.TabStop = False
        Me.btnProductos.Text = "    Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.White
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.Black
        Me.btnVentas.Image = Global.CapaDePresentacion.My.Resources.Resources.Venta
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(245, 10)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(91, 35)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.TabStop = False
        Me.btnVentas.Text = "    Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.pnlFormularios)
        Me.Controls.Add(Me.pnlMenu)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TACTICASOFT"
        Me.pnlFormularios.ResumeLayout(False)
        CType(Me.pctTactica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFormularios As Panel
    Friend WithEvents pctTactica As PictureBox
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnVentas As Button
End Class
