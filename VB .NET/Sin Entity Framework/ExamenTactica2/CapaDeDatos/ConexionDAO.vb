Imports System.Data.SqlClient

Public Class ConexionDAO
    Public Cadena As New SqlConnection(My.Settings.Conexion)

    Public Function Abrir()
        If (Cadena.State = 0) Then
            Cadena.Open()
        End If
        Return Cadena
    End Function

    Public Function Cerrar()
        If (Cadena.State = 1) Then
            Cadena.Close()
        End If
        Return Cadena
    End Function
End Class
