Public Class Venta
    Private _ID As Integer
    Private _IDCliente As Integer
    Private _Fecha As DateTime
    Private _Total As Single

    Public Sub New()
        _ID = 0
        _IDCliente = 0
        _Fecha = Today
        _Total = 0
    End Sub

    Public Sub New(id As Integer, idcliente As Integer, fecha As DateTime, total As Single)
        _ID = id
        _IDCliente = idcliente
        _Fecha = fecha
        _Total = total
    End Sub

    Public Property ID
        Get
            Return _ID
        End Get
        Set(value)
            _ID = value
        End Set
    End Property

    Public Property IDCliente
        Get
            Return _IDCliente
        End Get
        Set(value)
            _IDCliente = value
        End Set
    End Property

    Public Property Fecha
        Get
            Return _Fecha
        End Get
        Set(value)
            _Fecha = value
        End Set
    End Property

    Public Property Total
        Get
            Return _Total
        End Get
        Set(value)
            _Total = value
        End Set
    End Property

End Class
