Public Class ISW
    Private Sub btnRealizarPedido_Click(sender As Object, e As EventArgs) Handles btnRealizarPedido.Click
        Dim a As New Pedido()
        a.ShowDialog()
    End Sub

    Private Sub ISW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
