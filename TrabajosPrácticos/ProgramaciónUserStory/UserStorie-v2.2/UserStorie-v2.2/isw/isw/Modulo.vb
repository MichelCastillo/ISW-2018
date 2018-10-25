Module Modulo

    Public pedidos As New ArrayList()
    Public numP As Integer = 0



    Public Sub guardar_pedido_tarjeta(ByVal dirC As String, ByVal dirE As String, ByRef det As String, ByVal fecha As String, ByVal hs As String, ByVal nroT As Integer, ByVal tit As String, ByVal pinT As Integer, ByVal venc As String, ByVal img As Image)
        Dim nuevo_pedido As New Pedidos
        nuevo_pedido.set_pedidosT(dirC, dirE, det, fecha, hs, nroT, tit, pinT, venc, img)
        pedidos.Add(nuevo_pedido)
    End Sub

    Public Sub guardar_pedido_efectivo(ByVal dirC As String, ByVal dirE As String, ByRef det As String, ByVal fecha As String, ByVal hs As String, ByVal cos As Double, ByVal mon As Double, ByVal img As Image)
        Dim nuevo_pedido As New Pedidos
        nuevo_pedido.set_pedidosE(dirC, dirE, det, fecha, hs, cos, mon, img)
        pedidos.Add(nuevo_pedido)
    End Sub
End Module
