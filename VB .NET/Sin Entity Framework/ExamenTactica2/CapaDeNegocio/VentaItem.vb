Public Class VentaItem
    Private _ID As Integer
    Private _IDVenta As Integer
    Private _IDProducto As Integer
    Private _PrecioUnitario As Single
    Private _Cantidad As Single
    Private _PrecioTotal As Single

    Public Sub New()
        _ID = 0
        _IDVenta = 0
        _IDProducto = 0
        _PrecioUnitario = 0
        _Cantidad = 0
        _PrecioTotal = 0
    End Sub

    Public Sub New(id As Integer, idventa As Integer, idproducto As Integer, preciounitario As Single,
                   cantidad As Single, preciototal As Single)
        _ID = id
        _IDVenta = idventa
        _IDProducto = idproducto
        _PrecioUnitario = preciounitario
        _Cantidad = cantidad
        _PrecioTotal = preciototal
    End Sub

    Public Property ID
        Get
            Return _ID
        End Get
        Set(value)
            _ID = value
        End Set
    End Property

    Public Property IDVenta
        Get
            Return _IDVenta
        End Get
        Set(value)
            _IDVenta = value
        End Set
    End Property

    Public Property IDProducto
        Get
            Return _IDProducto
        End Get
        Set(value)
            _IDProducto = value
        End Set
    End Property

    Public Property Cantidad
        Get
            Return _Cantidad
        End Get
        Set(value)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioTotal
        Get
            Return _PrecioTotal
        End Get
        Set(value)
            _PrecioTotal = value
        End Set
    End Property

    Public Property PrecioUnitario
        Get
            Return _PrecioUnitario
        End Get
        Set(value)
            _PrecioUnitario = value
        End Set
    End Property
End Class
