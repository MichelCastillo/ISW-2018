<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostrarPedido
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.Label()
        Me.txtFormaP = New System.Windows.Forms.Label()
        Me.txtComercio = New System.Windows.Forms.Label()
        Me.txtNPedido = New System.Windows.Forms.Label()
        Me.txtNroTar = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.Label()
        Me.txtVenc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMomento = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.Label()
        Me.txtEntrega = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbxImagenP = New System.Windows.Forms.PictureBox()
        Me.txtVuelto = New System.Windows.Forms.Label()
        CType(Me.pbxImagenP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Pedido: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion de comercio: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Forma de pago: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Detalle del Pedido"
        '
        'txtMonto
        '
        Me.txtMonto.AutoSize = True
        Me.txtMonto.Location = New System.Drawing.Point(278, 126)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(13, 13)
        Me.txtMonto.TabIndex = 4
        Me.txtMonto.Text = "--"
        '
        'txtFormaP
        '
        Me.txtFormaP.AutoSize = True
        Me.txtFormaP.Location = New System.Drawing.Point(161, 126)
        Me.txtFormaP.Name = "txtFormaP"
        Me.txtFormaP.Size = New System.Drawing.Size(13, 13)
        Me.txtFormaP.TabIndex = 5
        Me.txtFormaP.Text = "--"
        '
        'txtComercio
        '
        Me.txtComercio.AutoSize = True
        Me.txtComercio.Location = New System.Drawing.Point(161, 67)
        Me.txtComercio.Name = "txtComercio"
        Me.txtComercio.Size = New System.Drawing.Size(13, 13)
        Me.txtComercio.TabIndex = 6
        Me.txtComercio.Text = "--"
        '
        'txtNPedido
        '
        Me.txtNPedido.AutoSize = True
        Me.txtNPedido.Location = New System.Drawing.Point(161, 41)
        Me.txtNPedido.Name = "txtNPedido"
        Me.txtNPedido.Size = New System.Drawing.Size(13, 13)
        Me.txtNPedido.TabIndex = 7
        Me.txtNPedido.Text = "--"
        '
        'txtNroTar
        '
        Me.txtNroTar.AutoSize = True
        Me.txtNroTar.Location = New System.Drawing.Point(161, 150)
        Me.txtNroTar.Name = "txtNroTar"
        Me.txtNroTar.Size = New System.Drawing.Size(13, 13)
        Me.txtNroTar.TabIndex = 8
        Me.txtNroTar.Text = "--"
        '
        'txtPin
        '
        Me.txtPin.AutoSize = True
        Me.txtPin.Location = New System.Drawing.Point(278, 150)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(13, 13)
        Me.txtPin.TabIndex = 9
        Me.txtPin.Text = "--"
        '
        'txtTitular
        '
        Me.txtTitular.AutoSize = True
        Me.txtTitular.Location = New System.Drawing.Point(399, 150)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(13, 13)
        Me.txtTitular.TabIndex = 10
        Me.txtTitular.Text = "--"
        '
        'txtVenc
        '
        Me.txtVenc.AutoSize = True
        Me.txtVenc.Location = New System.Drawing.Point(161, 172)
        Me.txtVenc.Name = "txtVenc"
        Me.txtVenc.Size = New System.Drawing.Size(13, 13)
        Me.txtVenc.TabIndex = 11
        Me.txtVenc.Text = "--"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Momento de entrega: "
        '
        'txtMomento
        '
        Me.txtMomento.AutoSize = True
        Me.txtMomento.Location = New System.Drawing.Point(150, 195)
        Me.txtMomento.Name = "txtMomento"
        Me.txtMomento.Size = New System.Drawing.Size(13, 13)
        Me.txtMomento.TabIndex = 13
        Me.txtMomento.Text = "--"
        '
        'txtDetalle
        '
        Me.txtDetalle.AutoSize = True
        Me.txtDetalle.Location = New System.Drawing.Point(42, 254)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(13, 13)
        Me.txtDetalle.TabIndex = 14
        Me.txtDetalle.Text = "--"
        '
        'txtEntrega
        '
        Me.txtEntrega.AutoSize = True
        Me.txtEntrega.Location = New System.Drawing.Point(161, 91)
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(13, 13)
        Me.txtEntrega.TabIndex = 16
        Me.txtEntrega.Text = "--"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Direccion de entrega: "
        '
        'pbxImagenP
        '
        Me.pbxImagenP.Location = New System.Drawing.Point(333, 216)
        Me.pbxImagenP.Name = "pbxImagenP"
        Me.pbxImagenP.Size = New System.Drawing.Size(300, 164)
        Me.pbxImagenP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImagenP.TabIndex = 17
        Me.pbxImagenP.TabStop = False
        '
        'txtVuelto
        '
        Me.txtVuelto.AutoSize = True
        Me.txtVuelto.Location = New System.Drawing.Point(399, 126)
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.Size = New System.Drawing.Size(13, 13)
        Me.txtVuelto.TabIndex = 18
        Me.txtVuelto.Text = "--"
        '
        'MostrarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 381)
        Me.Controls.Add(Me.txtVuelto)
        Me.Controls.Add(Me.pbxImagenP)
        Me.Controls.Add(Me.txtEntrega)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.txtMomento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVenc)
        Me.Controls.Add(Me.txtTitular)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.txtNroTar)
        Me.Controls.Add(Me.txtNPedido)
        Me.Controls.Add(Me.txtComercio)
        Me.Controls.Add(Me.txtFormaP)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MostrarPedido"
        Me.Text = "MostrarPedido"
        CType(Me.pbxImagenP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMonto As Label
    Friend WithEvents txtFormaP As Label
    Friend WithEvents txtComercio As Label
    Friend WithEvents txtNPedido As Label
    Friend WithEvents txtNroTar As Label
    Friend WithEvents txtPin As Label
    Friend WithEvents txtTitular As Label
    Friend WithEvents txtVenc As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMomento As Label
    Friend WithEvents txtDetalle As System.Windows.Forms.Label
    Friend WithEvents txtEntrega As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbxImagenP As System.Windows.Forms.PictureBox
    Friend WithEvents txtVuelto As System.Windows.Forms.Label
End Class
