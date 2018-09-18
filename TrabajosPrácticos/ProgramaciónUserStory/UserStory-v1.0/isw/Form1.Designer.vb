<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISW
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRealizarPedido = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(43, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ver Pedidos Pendientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRealizarPedido
        '
        Me.btnRealizarPedido.Location = New System.Drawing.Point(43, 28)
        Me.btnRealizarPedido.Name = "btnRealizarPedido"
        Me.btnRealizarPedido.Size = New System.Drawing.Size(235, 23)
        Me.btnRealizarPedido.TabIndex = 1
        Me.btnRealizarPedido.Text = "Realizar Pedido a comercio no adherido"
        Me.btnRealizarPedido.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(43, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ISW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(338, 163)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnRealizarPedido)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ISW"
        Me.Text = "Ingenieria de Software"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnRealizarPedido As Button
    Friend WithEvents Button3 As Button
End Class
