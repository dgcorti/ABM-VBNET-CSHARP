Imports CapaDeNegocio
Imports System.Data.SqlClient

Public MustInherit Class GenericDAO

    'Public MustOverride ReadOnly Property Tabla As String
    'Public MustOverride ReadOnly Property objCN As String


    'Private Conexion As New ConexionDAO
    'Private Comando As New SqlCommand()
    'Private DA As SqlDataAdapter

    'Public Function Listar(Objeto As Object) As List(Of Object)
    '    Dim ListaGenerica As New List(Of Object)
    '    Try
    '        Call Conexion.Abrir()
    '        DA = New SqlDataAdapter("SELECT * FROM " + Tabla, Conexion.Cadena)
    '        Dim DT As New DataTable
    '        DA.Fill(DT)
    '        Call Conexion.Cerrar()
    '        For Each row As DataRow In DT.Rows
    '            Dim cliente As New Cliente(row(0), row(1), row(2), row(3))
    '            ListaGenerica.Add(cliente)
    '        Next
    '        Return ListaGenerica
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function



End Class
