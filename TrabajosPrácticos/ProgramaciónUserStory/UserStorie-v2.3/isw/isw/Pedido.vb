Public Class Pedido

    Dim imagen As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Imagen|*.bmp;*.jpg;*.jpeg;*.gif;*.png"
        If file.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(file.FileName)
            imagen = True
        End If
        btnQuitarImagen.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub btnMapa_Click(sender As Object, e As EventArgs) Handles btnMapa.Click
        If txtDireccion.Text = "" Then
            Exit Sub
        End If
        Dim urlMaps As String
        urlMaps = "https://www.google.com/maps/search/" & txtDireccion.Text
        Dim direccion As New Uri(urlMaps)

        WebBrowser1.Navigate(direccion)

    End Sub


    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtEfectivo.Select()
        rbtAntesPosible.Select()
        imagen = False
        DateTimePicker1.MinDate = Now

    End Sub


    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If validaciones() Then
            Exit Sub
        End If


        If MessageBox.Show("¿Confirmar la operacion?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = vbYes Then
            numP = numP + 1
            Dim hora As String = ""
            If rbtAntesPosible.Checked Then
                hora = "Lo antes posible"
            End If
            If rbtProgramar.Checked Then
                hora = txtHora.Text & ":" & txtMin.Text & " Hs."
            End If
            If rbtTarjeta.Checked Then

                Dim vencimiento As String = txtMesT.Text & "/" & txtAñoT.Text
                Modulo.guardar_pedido_tarjeta(txtDireccion.Text, txtEntrega.Text, txtDetalle.Text, DateTimePicker1.Text, hora, txtNroT.Text, txtTitular.Text, txtPin.Text, vencimiento, PictureBox1.Image)
            End If
            If rbtTarjeta.Checked = False Then
                Modulo.guardar_pedido_efectivo(txtDireccion.Text, txtEntrega.Text, txtDetalle.Text, DateTimePicker1.Text, hora, txtCosto.Text, txtMonto.Text, PictureBox1.Image)
            End If
           
            Me.Close()
        End If
    End Sub


    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtHora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHora.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMin.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click
        If imagen Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
            imagen = False
        End If
        btnQuitarImagen.Enabled = False
        Button1.Enabled = True
    End Sub


    Private Sub rbtAntesPosible_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAntesPosible.CheckedChanged
        txtHora.Text = ""
        txtMin.Text = ""
        Panel2.Enabled = False
    End Sub

    Private Sub rbtProgramar_CheckedChanged(sender As Object, e As EventArgs) Handles rbtProgramar.CheckedChanged
        Panel2.Enabled = True
    End Sub

    Private Sub rbtEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEfectivo.CheckedChanged
        Panel1.Visible = False
    End Sub

    Private Sub rbtTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTarjeta.CheckedChanged
        Panel1.Visible = True
        txtMonto.Text = ""
        txtCosto.Text = ""
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtNroT_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtNroT.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMesT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMesT.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAñoT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAñoT.KeyPress
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Public Function validaciones() As Boolean
        'Validar campo vacio
        If txtDireccion.Text = "" Or txtEntrega.Text = "" Then
            MessageBox.Show("Complete las direcciones solicitadas", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        If rbtTarjeta.Checked And (txtNroT.Text = "" Or txtPin.Text = "" Or txtTitular.Text = "" Or txtAñoT.Text = "" Or txtMesT.Text = "") Then
            MessageBox.Show("Complete todos los datos de la tarjeta para continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        If rbtEfectivo.Checked And (txtMonto.Text = "" Or txtCosto.Text = "") Then
            MessageBox.Show("Complete el monto y/o costo estimado para continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        If rbtProgramar.Checked And (txtHora.Text = "" Or txtMin.Text = "") Then
            MessageBox.Show("Los campos fecha y hora son obligatorios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        If txtDetalle.Text = "" Then
            MessageBox.Show("El detalle esta vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If


        'Validar que los datos esten bien 
        If rbtTarjeta.Checked Then
            If (txtMesT.Text > 12 Or txtMesT.Text = 0) Then
                MessageBox.Show("Mes incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
        End If
        If rbtProgramar.Checked Then
            If txtHora.Text < 0 Or txtHora.Text > 23 Or txtMin.Text < 0 Or txtMin.Text > 59 Then
                MessageBox.Show("Error en la hora ingresada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHora.Text = ""
                txtMin.Text = ""
                Return True
            End If
        End If
        If rbtEfectivo.Checked And txtMonto.Text < txtCosto.Text Then
            MessageBox.Show("El costo supera el monto a abonar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        If rbtTarjeta.Checked And txtPin.TextLength < 3 Then
            MessageBox.Show("Ingresar pin correctamente ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        If rbtTarjeta.Checked And txtNroT.TextLength < 16 Then
            MessageBox.Show("Ingresar numero de tarjeta correctamente ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        If rbtTarjeta.Checked Then
            If ((txtAñoT.Text < Date.Now.Date.Year) Or (txtAñoT.Text = Date.Now.Date.Year And txtMesT.Text < Date.Now.Date.Month)) Then
                MessageBox.Show("La tarjeta esta vencida ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
        End If

        If rbtProgramar.Checked And DateTimePicker1.Value.Month = Date.Now.Date.Month And DateTimePicker1.Value.Day = Date.Now.Date.Day Then
            If Now.ToString("HH") > txtHora.Text Or (Now.ToString("HH") = txtHora.Text And Now.ToString("mm") >= txtMin.Text) Then
                MessageBox.Show("Error en la hora programada ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
        End If


        Return False
    End Function



















End Class


