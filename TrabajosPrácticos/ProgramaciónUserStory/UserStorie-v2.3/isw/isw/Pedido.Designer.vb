<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnMapa = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbtTarjeta = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnQuitarImagen = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEntrega = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbtAntesPosible = New System.Windows.Forms.RadioButton()
        Me.rbtProgramar = New System.Windows.Forms.RadioButton()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAñoT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMesT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.txtNroT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SketchFlow Print", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedido a comercio no adherido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion de comercio: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Detalle de pedido"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(142, 61)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(136, 20)
        Me.txtDireccion.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(857, 355)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1077, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(77, 52)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cargar una imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnMapa
        '
        Me.btnMapa.Location = New System.Drawing.Point(201, 87)
        Me.btnMapa.Name = "btnMapa"
        Me.btnMapa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMapa.Size = New System.Drawing.Size(77, 22)
        Me.btnMapa.TabIndex = 2
        Me.btnMapa.Text = "Ver en Mapa"
        Me.btnMapa.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(315, 26)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(845, 323)
        Me.WebBrowser1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SketchFlow Print", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Forma de Pago"
        '
        'rbtEfectivo
        '
        Me.rbtEfectivo.AutoSize = True
        Me.rbtEfectivo.Location = New System.Drawing.Point(15, 13)
        Me.rbtEfectivo.Name = "rbtEfectivo"
        Me.rbtEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbtEfectivo.TabIndex = 6
        Me.rbtEfectivo.TabStop = True
        Me.rbtEfectivo.Text = "Efectivo"
        Me.rbtEfectivo.UseVisualStyleBackColor = True
        '
        'rbtTarjeta
        '
        Me.rbtTarjeta.AutoSize = True
        Me.rbtTarjeta.Location = New System.Drawing.Point(15, 36)
        Me.rbtTarjeta.Name = "rbtTarjeta"
        Me.rbtTarjeta.Size = New System.Drawing.Size(81, 17)
        Me.rbtTarjeta.TabIndex = 7
        Me.rbtTarjeta.TabStop = True
        Me.rbtTarjeta.Text = "Tarjeta Visa"
        Me.rbtTarjeta.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 507)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Monto con el que abonara: "
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(302, 504)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(146, 20)
        Me.txtMonto.TabIndex = 8
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Location = New System.Drawing.Point(461, 623)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnConfirmar.Size = New System.Drawing.Size(135, 23)
        Me.btnConfirmar.TabIndex = 20
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(602, 623)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancelar.Size = New System.Drawing.Size(135, 23)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("SketchFlow Print", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(637, 473)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(267, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Momento de entrega del pedido"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 23)
        Me.DateTimePicker1.MinDate = New Date(2018, 10, 2, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(274, 23)
        Me.txtHora.MaxLength = 2
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(29, 20)
        Me.txtHora.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(234, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "  Hora: "
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(315, 23)
        Me.txtMin.MaxLength = 2
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(29, 20)
        Me.txtMin.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(346, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Hs."
        '
        'btnQuitarImagen
        '
        Me.btnQuitarImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarImagen.Enabled = False
        Me.btnQuitarImagen.Location = New System.Drawing.Point(1077, 424)
        Me.btnQuitarImagen.Name = "btnQuitarImagen"
        Me.btnQuitarImagen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnQuitarImagen.Size = New System.Drawing.Size(77, 46)
        Me.btnQuitarImagen.TabIndex = 31
        Me.btnQuitarImagen.Text = "Quitar imagen"
        Me.btnQuitarImagen.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 157)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Direccion de entrega: "
        '
        'txtEntrega
        '
        Me.txtEntrega.Location = New System.Drawing.Point(142, 154)
        Me.txtEntrega.MaxLength = 50
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(136, 20)
        Me.txtEntrega.TabIndex = 3
        '
        'txtDetalle
        '
        Me.txtDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetalle.Location = New System.Drawing.Point(15, 355)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(836, 115)
        Me.txtDetalle.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtHora)
        Me.Panel2.Controls.Add(Me.txtMin)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(788, 498)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(398, 59)
        Me.Panel2.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = ":"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbtEfectivo)
        Me.Panel3.Controls.Add(Me.rbtTarjeta)
        Me.Panel3.Location = New System.Drawing.Point(13, 492)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(123, 59)
        Me.Panel3.TabIndex = 38
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbtAntesPosible)
        Me.Panel4.Controls.Add(Me.rbtProgramar)
        Me.Panel4.Location = New System.Drawing.Point(640, 498)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(123, 59)
        Me.Panel4.TabIndex = 39
        '
        'rbtAntesPosible
        '
        Me.rbtAntesPosible.AutoSize = True
        Me.rbtAntesPosible.Location = New System.Drawing.Point(15, 13)
        Me.rbtAntesPosible.Name = "rbtAntesPosible"
        Me.rbtAntesPosible.Size = New System.Drawing.Size(102, 17)
        Me.rbtAntesPosible.TabIndex = 15
        Me.rbtAntesPosible.TabStop = True
        Me.rbtAntesPosible.Text = "Lo antes posible"
        Me.rbtAntesPosible.UseVisualStyleBackColor = True
        '
        'rbtProgramar
        '
        Me.rbtProgramar.AutoSize = True
        Me.rbtProgramar.Location = New System.Drawing.Point(15, 36)
        Me.rbtProgramar.Name = "rbtProgramar"
        Me.rbtProgramar.Size = New System.Drawing.Size(103, 17)
        Me.rbtProgramar.TabIndex = 16
        Me.rbtProgramar.TabStop = True
        Me.rbtProgramar.Text = "Programar fecha"
        Me.rbtProgramar.UseVisualStyleBackColor = True
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(302, 530)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(145, 20)
        Me.txtCosto.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(221, 533)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Costo estimado: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtAñoT)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtMesT)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtPin)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtTitular)
        Me.Panel1.Controls.Add(Me.txtNroT)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(158, 485)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 72)
        Me.Panel1.TabIndex = 44
        '
        'txtAñoT
        '
        Me.txtAñoT.Location = New System.Drawing.Point(410, 44)
        Me.txtAñoT.MaxLength = 4
        Me.txtAñoT.Name = "txtAñoT"
        Me.txtAñoT.Size = New System.Drawing.Size(39, 20)
        Me.txtAñoT.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Año"
        '
        'txtMesT
        '
        Me.txtMesT.Location = New System.Drawing.Point(340, 44)
        Me.txtMesT.MaxLength = 2
        Me.txtMesT.Name = "txtMesT"
        Me.txtMesT.Size = New System.Drawing.Size(38, 20)
        Me.txtMesT.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(312, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Mes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(196, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Fecha de Vencimiento:"
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(77, 44)
        Me.txtPin.MaxLength = 3
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(105, 20)
        Me.txtPin.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "PIN: "
        '
        'txtTitular
        '
        Me.txtTitular.Location = New System.Drawing.Point(278, 18)
        Me.txtTitular.MaxLength = 60
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(171, 20)
        Me.txtTitular.TabIndex = 11
        '
        'txtNroT
        '
        Me.txtNroT.Location = New System.Drawing.Point(77, 18)
        Me.txtNroT.MaxLength = 16
        Me.txtNroT.Name = "txtNroT"
        Me.txtNroT.Size = New System.Drawing.Size(105, 20)
        Me.txtNroT.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(196, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Nombre Titular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Nro de tarjeta: "
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 658)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.txtEntrega)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnQuitarImagen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnMapa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pedido"
        Me.Text = "Pedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnMapa As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label6 As Label
    Friend WithEvents rbtEfectivo As RadioButton
    Friend WithEvents rbtTarjeta As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtHora As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMin As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnQuitarImagen As Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEntrega As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbtProgramar As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents rbtAntesPosible As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAñoT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMesT As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPin As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTitular As System.Windows.Forms.TextBox
    Friend WithEvents txtNroT As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
