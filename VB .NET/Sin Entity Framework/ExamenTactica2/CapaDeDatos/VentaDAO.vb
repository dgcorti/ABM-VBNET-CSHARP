Imports CapaDeNegocio
Imports System.Data.SqlClient

Public Class VentaDAO
    'Inherits GenericDAO
    Private Conexion As New ConexionDAO
    Private Comando As New SqlCommand()
    Private DA As SqlDataAdapter

    Public Function Listar() As List(Of Venta)
        Dim Ventas As New List(Of Venta)
        Try
            Call Conexion.Abrir()
            DA = New SqlDataAdapter("SELECT * FROM VENTAS", Conexion.Cadena)
            Dim DTVentas As New DataTable
            DA.Fill(DTVentas)
            Call Conexion.Cerrar()
            For Each row As DataRow In DTVentas.Rows
                Dim Venta As New Venta(row(0), row(1), row(2), row(3))
                Ventas.Add(Venta)
            Next
            Return Ventas
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Buscar(TipoDeCampo As String, Campo As String) As List(Of Venta)
        Dim VentasBuscadas As New List(Of Venta)
        Try
            DA = New SqlDataAdapter("SELECT * FROM VENTAS WHERE " & TipoDeCampo & " LIKE '%" & Campo & "%'", Conexion.Cadena)
            Dim DTVentasBuscadas As New DataTable
            DA.Fill(DTVentasBuscadas)
            For Each row As DataRow In DTVentasBuscadas.Rows
                Dim venta As New Venta(row(0), row(1), row(2), row(3))
                VentasBuscadas.Add(venta)
            Next
            Return VentasBuscadas
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Agregar(Venta As Venta)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdAgregar As String = "INSERT INTO VENTAS (IDCLIENTE, FECHA, TOTAL) VALUES ('" & Venta.IDCliente &
                                       "', '" & Venta.Fecha & "', '0')"
            Using Comando As New SqlCommand(CmdAgregar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Venta
    End Function

    Public Function Editar(Venta As Venta)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdEditar As String = "UPDATE VENTAS SET IDCLIENTE = '" & Venta.IDCliente & "', FECHA = '" & Venta.Fecha &
                                      "', TOTAL = '" & Venta.Total & "' WHERE ID = " & Venta.ID
            Using Comando As New SqlCommand(CmdEditar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Venta
    End Function

    Public Function Eliminar(Venta As Venta)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdEliminar As String = "DELETE FROM VENTAS WHERE ID = " & Venta.ID &
                                        " DELETE FROM VENTASITEMS WHERE IDVENTA = " & Venta.ID
            Using Comando As New SqlCommand(CmdEliminar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Venta
    End Function
End Class
