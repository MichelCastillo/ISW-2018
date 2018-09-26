﻿Public Class Pedido

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
        'urlMaps = "http://maps.google.es/maps?q=" & txtDireccion.Text & "&output=embed"
        urlMaps = "https://www.google.com/maps/search/" & txtDireccion.Text

        Dim direccion As New Uri(urlMaps)

        WebBrowser1.Navigate(direccion)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEfectivo.CheckedChanged
        Panel1.Visible = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTarjeta.CheckedChanged
        Panel1.Visible = True

    End Sub

    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtEfectivo.Select()
        rbtAntesPosible.Select()
        imagen = False
    End Sub


    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        If validar() Then

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
                    Modulo.guardar_pedido_tarjeta(txtDireccion.Text, txtEntrega.Text, txtDetalle.Text, DateTimePicker1.Text, hora, txtCosto.Text, txtNroT.Text, txtTitular.Text, txtPin.Text, vencimiento, PictureBox1.Image)
                End If
                If rbtTarjeta.Checked = False Then
                    Modulo.guardar_pedido_efectivo(txtDireccion.Text, txtEntrega.Text, txtDetalle.Text, DateTimePicker1.Text, hora, txtCosto.Text, txtMonto.Text, PictureBox1.Image)
                End If

                Me.Close()
            End If
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

    Private Sub txtNroT_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs)
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
    End Sub


    Private Sub rbtAntesPosible_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAntesPosible.CheckedChanged
        txtHora.Text = ""
        txtMin.Text = ""
        Panel2.Enabled = False
    End Sub

    Private Sub rbtProgramar_CheckedChanged(sender As Object, e As EventArgs) Handles rbtProgramar.CheckedChanged
        Panel2.Enabled = True
    End Sub

    Private Sub txtNroT_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtNroT.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Function validar()
        If txtDetalle.Text.Length = 0 Then
            MsgBox("Porfavor ingrese un detalle")
            Return False
            Exit Function
        End If

        If txtDireccion.Text.Length = 0 Then
            MsgBox("Porfavor ingrese una direccion de entrega")
            Return False
            Exit Function
        End If

        If rbtTarjeta.Checked Then
            If (txtNroT.Text = "" Or txtPin.Text = "" Or txtTitular.Text = "" Or txtAñoT.Text = "" Or txtMesT.Text = "") Then
                MessageBox.Show("Complete todos los datos de la tarjeta para continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
                Exit Function
            End If
            If txtNroT.Text.Length <> 16 Then
                MsgBox("El numero de tarjeta debe tener 16 digitos")
                Return False
                Exit Function
            End If

            If txtPin.Text.Length <> 3 Then
                MsgBox("El numero de pin debe tener 3 digitos")
                Return False
                Exit Function

            End If
            If txtAñoT.Text < Date.Now.Year Then
                MsgBox("La tarjeta esta vencida")
                Return False
                Exit Function

            End If

        End If
        If rbtEfectivo.Checked And txtMonto.Text = "" Then
            MessageBox.Show("Complete el monto a abonar para continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If

        If rbtProgramar.Checked And (txtHora.Text = "" Or txtMin.Text = "") Then
            MessageBox.Show("Los campos indicados con * son obligatorios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If


        If rbtProgramar.Checked Then
            If txtHora.Text < 0 Or txtHora.Text > 23 Or txtMin.Text < 0 Or txtMin.Text > 59 Then
                MessageBox.Show("Error en la hora ingresada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHora.Text = ""
                txtMin.Text = ""
                Return False
                Exit Function

            End If
        Else
            Return True
        End If
    End Function

    Private Sub txtPin_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMesT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMesT.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAñoT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAñoT.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTitular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTitular.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class