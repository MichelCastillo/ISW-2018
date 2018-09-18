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

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarjeta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombteTitular.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtHora.TextChanged
        If Me.txtHora.Text.Length <> 0 Then
            If Me.txtHora.Text > 24 Then
                MsgBox("Ingrese una Hora Valida (0-24hs)")
                Me.txtHora.Clear()
            End If
        End If
    End Sub

    Private Sub MaskedTextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtMinutos.TextChanged
        If Me.txtMinutos.Text.Length <> 0 Then
            If Me.txtMinutos.Text > 59 Then
                MsgBox("Ingrese Minutos Validos (0-59hs)")
                Me.txtMinutos.Clear()

            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub


End Class