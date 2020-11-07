Imports CapaDeNegocio
Imports System.Data.SqlClient

Public Class ClienteDAO
    'Inherits GenericDAO
    Private Conexion As New ConexionDAO
    Private Comando As New SqlCommand()
    Private DA As SqlDataAdapter

    Public Function Listar() As List(Of Cliente)
        Dim Clientes As New List(Of Cliente)
        Try
            Call Conexion.Abrir()
            DA = New SqlDataAdapter("SELECT * FROM CLIENTES", Conexion.Cadena)
            Dim DTClientes As New DataTable
            DA.Fill(DTClientes)
            Call Conexion.Cerrar()
            For Each row As DataRow In DTClientes.Rows
                Dim cliente As New Cliente(row(0), row(1), row(2), row(3))
                Clientes.Add(cliente)
            Next
            Return Clientes
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Buscar(TipoDeCampo As String, Campo As String) As List(Of Cliente)
        Dim ClientesBuscados As New List(Of Cliente)
        Try
            DA = New SqlDataAdapter("SELECT * FROM CLIENTES WHERE " & TipoDeCampo & " LIKE '%" & Campo & "%'", Conexion.Cadena)
            Dim DTClientesBuscados As New DataTable
            DA.Fill(DTClientesBuscados)
            For Each row As DataRow In DTClientesBuscados.Rows
                Dim cliente As New Cliente(row(0), row(1), row(2), row(3))
                ClientesBuscados.Add(cliente)
            Next
            Return ClientesBuscados
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Agregar(Cliente As Cliente)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdAgregar As String = "INSERT INTO CLIENTES (CLIENTE, TELEFONO, CORREO) VALUES ('" & Cliente.Cliente &
                                       "', '" & Cliente.Telefono & "', '" & Cliente.Correo & "')"
            Using Comando As New SqlCommand(CmdAgregar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Cliente
    End Function

    Public Function Editar(Cliente As Cliente)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdEditar As String = "UPDATE CLIENTES SET CLIENTE = '" & Cliente.Cliente & "', TELEFONO = " & Cliente.Telefono &
                                   ", CORREO = '" & Cliente.Correo & "' WHERE ID = " & Cliente.ID
            Using Comando As New SqlCommand(CmdEditar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Cliente
    End Function

    Public Function Eliminar(Cliente As Cliente)
        Using Cadena As New SqlConnection(My.Settings.Conexion)
            Dim CmdEliminar As String = "DELETE FROM CLIENTES WHERE ID = " & Cliente.ID
            Using Comando As New SqlCommand(CmdEliminar, Cadena)
                Cadena.Open()
                Comando.ExecuteNonQuery()
            End Using
        End Using
        Return Cliente
    End Function
End Class
