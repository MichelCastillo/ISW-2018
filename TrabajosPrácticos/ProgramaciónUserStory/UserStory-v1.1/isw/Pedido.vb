Public Class Pedido

    Dim carro As Carrito
    Dim imagen As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        ' OpenFileDialog1.Filter = "images files(*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg*.jpeg;;*.gif;*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            imagen = True
        End If

    End Sub

    Private Sub btnMapa_Click(sender As Object, e As EventArgs) Handles btnMapa.Click

        Dim urlMaps As String
        urlMaps = "http://maps.google.es/maps?q=" & txtDireccion.Text & "&output=embed"
        Dim direccion As New Uri(urlMaps)
        WebBrowser1.Url = direccion
    End Sub

    Private Sub btnCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click
        carro.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Panel1.Visible = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Panel1.Visible = True

    End Sub

    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Select()
        carro = New Carrito()
        carro.Show()
        imagen = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        carro.DataGridView1.Rows.Add(txtProducto.Text, txtCantidad.Text)
        txtCantidad.Text = ""
        txtProducto.Text = ""
        If imagen Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If


    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If MessageBox.Show("¿Confirmar la operacion?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = vbYes Then
            Me.Close()
        End If
    End Sub
End Class