Imports CapaDeNegocio
Imports System.Data.SqlClient

Public Class VentaItemDAO
    'Inherits GenericDAO
    Private Conexion As New ConexionDAO
    Private Comando As New SqlCommand()
    Private DA As SqlDataAdapter

    Public Function Listar(IDVenta As Integer) As List(Of VentaItem)
        Dim VentasItems As New List(Of VentaItem)
        Try
            Call Conexion.Abrir()
            DA = New SqlDataAdapter("SELECT * FROM VENTASITEMS WHERE IDVENTA = " & IDVenta, Conexion.Cadena)
            Dim DTVentasItems As New DataTable
            DA.Fill(DTVentasItems)
            Call Conexion.Cerrar()
            For Each row As DataRow In DTVentasItems.Rows
                Dim VentaItem As New VentaItem(row(0), row(1), row(2), row(3), row(4), row(5))
                VentasItems.Add(VentaItem)
            Next
            Return VentasItems
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Buscar(TipoDeCampo As String, Campo As String, VentaItem As VentaItem) As List(Of VentaItem)
        Dim ItemsBuscados As New List(Of VentaItem)
        Try
            DA = New SqlDataAdapter("SELECT * FROM VENTASITEMS WHERE " & TipoDeCampo & " LIKE '%" & Campo &
                                    "%' AND IDVENTA = " & VentaItem.IDVenta, Conexion.Cadena)
            Dim DTBuscar As New DataTable
            DA.Fill(DTBuscar)
            For Each row As DataRow In DTBuscar.Rows
                Dim item As New VentaItem(row(0), row(1), row(2), row(3), row(4), row(5))
                ItemsBuscados.Add(item)
            Next
            Return ItemsBuscados
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Agregar(VentaItem As VentaItem)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdAgregar As String = "INSERT INTO VENTASITEMS (IDVENTA, IDPRODUCTO, PRECIOUNITARIO, CANTIDAD, PRECIOTOTAL)
                                    VALUES ('" & VentaItem.IDVenta & "', '" & VentaItem.IDProducto & "', '" & VentaItem.PrecioUnitario & "', '" &
                                    VentaItem.Cantidad & "', '" & VentaItem.PrecioTotal & "')"
            Using Comando As New SqlCommand(CmdAgregar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return VentaItem
    End Function

    Public Function Editar(VentaItem As VentaItem, SumaDePrecios As Single)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdEditar As String = "UPDATE VENTASITEMS SET
                                   PRECIOUNITARIO = " & VentaItem.PrecioUnitario & "
                                   , IDPRODUCTO = " & VentaItem.IDProducto & "     
                                   , CANTIDAD = " & VentaItem.Cantidad & "
                                   , PRECIOTOTAL = " & VentaItem.PrecioTotal &
                                   " WHERE ID = " & VentaItem.ID &
                                   " UPDATE VENTAS SET TOTAL = '" & SumaDePrecios & "' 
                                   WHERE ID = " & VentaItem.IDVenta
            Using Comando As New SqlCommand(CmdEditar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return VentaItem
    End Function

    Public Function Eliminar(VentaItem As VentaItem)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdEliminar As String = "DELETE FROM VENTASITEMS WHERE ID = " & VentaItem.ID
            Using Comando As New SqlCommand(CmdEliminar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return VentaItem
    End Function
End Class
