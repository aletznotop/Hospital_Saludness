<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroUsuarios
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.appUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.apmUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.passContrasena = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.conContrasena = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tipoUsuario
        '
        Me.tipoUsuario.FormattingEnabled = True
        Me.tipoUsuario.Items.AddRange(New Object() {" ", "Administrador", "Usuario", "Farmacia", "Almacen"})
        Me.tipoUsuario.Location = New System.Drawing.Point(300, 34)
        Me.tipoUsuario.Name = "tipoUsuario"
        Me.tipoUsuario.Size = New System.Drawing.Size(203, 21)
        Me.tipoUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(110, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nombreUsuario
        '
        Me.nombreUsuario.Location = New System.Drawing.Point(300, 77)
        Me.nombreUsuario.Name = "nombreUsuario"
        Me.nombreUsuario.Size = New System.Drawing.Size(203, 20)
        Me.nombreUsuario.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(110, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido Paterno:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'appUsuario
        '
        Me.appUsuario.Location = New System.Drawing.Point(300, 117)
        Me.appUsuario.Name = "appUsuario"
        Me.appUsuario.Size = New System.Drawing.Size(203, 20)
        Me.appUsuario.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(110, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellido Materno:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'apmUsuario
        '
        Me.apmUsuario.Location = New System.Drawing.Point(300, 156)
        Me.apmUsuario.Name = "apmUsuario"
        Me.apmUsuario.Size = New System.Drawing.Size(203, 20)
        Me.apmUsuario.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(110, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Usuario:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(300, 200)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(203, 20)
        Me.usuario.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(110, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contraseña:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passContrasena
        '
        Me.passContrasena.Location = New System.Drawing.Point(300, 243)
        Me.passContrasena.Name = "passContrasena"
        Me.passContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passContrasena.Size = New System.Drawing.Size(203, 20)
        Me.passContrasena.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(110, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Confirmar Contraseña:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'conContrasena
        '
        Me.conContrasena.Location = New System.Drawing.Point(300, 284)
        Me.conContrasena.Name = "conContrasena"
        Me.conContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.conContrasena.Size = New System.Drawing.Size(203, 20)
        Me.conContrasena.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 20)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(415, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 20)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'registroUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 366)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.conContrasena)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.passContrasena)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.apmUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.appUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombreUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tipoUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "registroUsuarios"
        Me.Text = "Registro de Usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tipoUsuario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nombreUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents appUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents apmUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents usuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents passContrasena As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents conContrasena As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
