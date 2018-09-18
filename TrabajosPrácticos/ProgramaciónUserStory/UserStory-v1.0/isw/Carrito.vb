Imports System.ComponentModel

Public Class Carrito
    Private Sub Carrito_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub Carrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1.Columns
            .Add("", "Producto")
            .Add("", "Cantidad")
            '.Add("", "Imagen")
        End With

    End Sub

End Class