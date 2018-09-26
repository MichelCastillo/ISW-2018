Public Class PedidosRealizados
    Private Sub PedidosRealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1.Columns
            .Add("", "Nro Pedido")
            .Add("", "Direccion Comercio")
        End With

        For Each row In Modulo.pedidos
            DataGridView1.Rows.Add(row.numero, row.direcComercio)
        Next

    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim indice As Integer = DataGridView1.CurrentRow.Cells(0).Value

        Dim a As New MostrarPedido()
        'a.DataGridView1.Columns.Add("", "Producto")
        'a.DataGridView1.Columns.Add("", "Cantidad")
        'Dim colImagen As DataGridViewImageColumn = New DataGridViewImageColumn()
        'colImagen.HeaderText = "Imagen"
        'colImagen.Name = ""
        'a.DataGridView1.Columns.Add(colImagen)
        For Each row In Modulo.pedidos
            If row.numero = indice Then
                a.txtNPedido.Text = row.numero
                a.txtComercio.Text = row.direcComercio
                a.txtEntrega.Text = row.direcEntrega
                'If row.horaEntrefa = "-:- Hs." Then
                '    row.horaEntrefa = "Lo antes posible"
                'End If
                'a.txtMomento.Text = row.fechaEntrega & " - " & row.horaEntrefa
                a.txtMomento.Text = row.fechaEntrega & " - " & row.horaEntrega
                'For Each fila In row.detalle.Rows
                '    a.DataGridView1.Rows.Add(fila.cells(0).value, fila.cells(1).value, fila.cells(2).value)
                'Next
                a.txtDetalle.Text = row.detalle
                If row.monto = 0 Then
                    a.txtFormaP.Text = "Tarjeta Visa"
                    a.txtNroTar.Text = "Nro Tarjeta: " & row.nroTarjeta
                    a.txtTitular.Text = "Nombre Titular: " & row.titular
                    a.txtPin.Text = "PIN: " & row.pin
                    a.txtVenc.Text = "Vencimiento(mm/aaaa): " & row.vencimiento
                    a.txtMonto.Text = ""
                    a.txtVuelto.Text = ""
                End If
                If Not (row.monto = 0) Then
                    a.txtFormaP.Text = "Efectivo"
                    a.txtNroTar.Text = ""
                    a.txtTitular.Text = ""
                    a.txtPin.Text = ""
                    a.txtVenc.Text = ""
                    a.txtMonto.Text = "Monto a abonar: " & row.monto
                    a.txtVuelto.Text = "Vuelto de la compra: " & (row.monto - row.costo)
                End If

                a.pbxImagenP.Image = row.photo

                a.ShowDialog()

            End If
        Next


    End Sub
End Class