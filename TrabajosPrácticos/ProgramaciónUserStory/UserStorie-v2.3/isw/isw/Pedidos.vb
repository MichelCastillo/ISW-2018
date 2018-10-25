Public Class Pedidos

    Public Property numero As Integer
    Public Property direcComercio As String
    Public Property direcEntrega As String
    Public Property detalle As String
    Public Property fechaEntrega As String
    Public Property horaEntrega As String
    Public Property costo As Double
    Public Property monto As Double
    Public Property nroTarjeta As Long
    Public Property titular As String
    Public Property pin As String
    Public Property vencimiento As String
    Public Property photo As Image



    Public Sub set_pedidosT(ByVal dirC As String, ByVal dirE As String, ByRef det As String, ByVal fecha As String, ByVal hs As String, ByVal nroT As Long, ByVal tit As String, ByVal pinT As Integer, ByVal venc As String, ByVal img As Image)

        numero = numP
        direcComercio = dirC
        direcEntrega = dirE
        fechaEntrega = fecha
        horaEntrega = hs

        nroTarjeta = nroT
        titular = tit
        pin = pinT
        vencimiento = venc
        detalle = det
        photo = img
    End Sub

    Public Sub set_pedidosE(ByVal dirC As String, ByVal dirE As String, ByRef det As String, ByVal fecha As String, ByVal hs As String, ByVal cos As Double, ByVal mon As Double, ByVal img As Image)

        numero = numP
        direcComercio = dirC
        direcEntrega = dirE
        fechaEntrega = fecha
        horaEntrega = hs
        costo = cos
        monto = mon
        detalle = det
        photo = img
    End Sub


End Class
