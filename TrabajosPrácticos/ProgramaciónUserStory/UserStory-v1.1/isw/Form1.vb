Public Class ISW
    Private Sub btnRealizarPedido_Click(sender As Object, e As EventArgs) Handles btnRealizarPedido.Click
        Dim a As New Pedido()
        a.ShowDialog()
    End Sub
End Class
