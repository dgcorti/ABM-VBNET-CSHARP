Public Class Cliente
    Private _ID As Integer
    Private _Cliente As String
    Private _Telefono As String
    Private _Correo As String

    Public Sub New()
        _ID = 0
        _Cliente = ""
        _Telefono = ""
        _Correo = ""
    End Sub

    Public Sub New(id As Integer, cliente As String, telefono As String, correo As String)
        _ID = id
        _Cliente = cliente
        _Telefono = telefono
        _Correo = correo
    End Sub

    Public Property ID
        Get
            Return _ID
        End Get
        Set(value)
            _ID = value
        End Set
    End Property

    Public Property Cliente
        Get
            Return _Cliente
        End Get
        Set(value)
            _Cliente = value
        End Set
    End Property

    Public Property Telefono
        Get
            Return _Telefono
        End Get
        Set(value)
            _Telefono = value
        End Set
    End Property

    Public Property Correo
        Get
            Return _Correo
        End Get
        Set(value)
            _Correo = value
        End Set
    End Property

End Class
