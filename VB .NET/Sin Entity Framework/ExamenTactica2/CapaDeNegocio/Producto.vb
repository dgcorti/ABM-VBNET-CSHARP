Public Class Producto
    Private _ID As Integer
    Private _Nombre As String
    Private _Precio As Single
    Private _Categoria As String

    Public Sub New()
        _ID = 0
        _Nombre = ""
        _Precio = 0
        _Categoria = ""
    End Sub

    Public Sub New(id As Integer, nombre As String, precio As Single, categoria As String)
        _ID = id
        _Nombre = nombre
        _Precio = precio
        _Categoria = categoria
    End Sub

    Public Property ID
        Get
            Return _ID
        End Get
        Set(value)
            _ID = value
        End Set
    End Property

    Public Property Nombre
        Get
            Return _Nombre
        End Get
        Set(value)
            _Nombre = value
        End Set
    End Property

    Public Property Precio
        Get
            Return _Precio
        End Get
        Set(value)
            _Precio = value
        End Set
    End Property

    Public Property Categoria
        Get
            Return _Categoria
        End Get
        Set(value)
            _Categoria = value
        End Set
    End Property

End Class
