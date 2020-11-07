Imports CapaDeNegocio
Imports System.Data.SqlClient

Public Class ProductoDAO
    'Inherits GenericDAO
    Private Conexion As New ConexionDAO
    Private Comando As New SqlCommand()
    Private DA As SqlDataAdapter

    Public Function Listar() As List(Of Producto)
        Dim Productos As New List(Of Producto)
        Try
            Call Conexion.Abrir()
            DA = New SqlDataAdapter("SELECT * FROM PRODUCTOS", Conexion.Cadena)
            Dim DTProductos As New DataTable
            DA.Fill(DTProductos)
            Call Conexion.Cerrar()
            For Each row As DataRow In DTProductos.Rows
                Dim producto As New Producto(row(0), row(1), row(2), row(3))
                Productos.Add(producto)
            Next
            Return Productos
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Buscar(TipoDeCampo As String, Campo As String) As List(Of Producto)
        Dim ProductosBuscados As New List(Of Producto)
        Try
            DA = New SqlDataAdapter("SELECT * FROM PRODUCTOS WHERE " & TipoDeCampo & " LIKE '%" & Campo & "%'", Conexion.Cadena)
            Dim DTProductosBuscados As New DataTable
            DA.Fill(DTProductosBuscados)
            For Each row As DataRow In DTProductosBuscados.Rows
                Dim producto As New Producto(row(0), row(1), row(2), row(3))
                ProductosBuscados.Add(producto)
            Next
            Return ProductosBuscados
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Agregar(Producto As Producto)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdAgregar As String = "INSERT INTO PRODUCTOS (NOMBRE, PRECIO, CATEGORIA) VALUES ('" & Producto.Nombre &
                                    "', '" & Producto.Precio & "', '" & Producto.Categoria & "')"
            Using Comando As New SqlCommand(CmdAgregar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Producto
    End Function

    Public Function Editar(Producto As Producto)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdEditar As String = "UPDATE PRODUCTOS SET NOMBRE = '" & Producto.Nombre & "', PRECIO = " & Producto.Precio &
                                   ", CATEGORIA = '" & Producto.Categoria & "' WHERE ID = " & Producto.ID
            Using Comando As New SqlCommand(CmdEditar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Producto
    End Function

    Public Function Eliminar(Producto As Producto)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdEliminar As String = "DELETE FROM PRODUCTOS WHERE ID = " & Producto.ID
            Using Comando As New SqlCommand(CmdEliminar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Producto
    End Function
End Class
