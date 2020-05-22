<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroMedicamentos
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
        Me.claveMedica = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombreMedica = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.medidaMedica = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave: "
        '
        'claveMedica
        '
        Me.claveMedica.Location = New System.Drawing.Point(101, 26)
        Me.claveMedica.Name = "claveMedica"
        Me.claveMedica.Size = New System.Drawing.Size(146, 20)
        Me.claveMedica.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre: "
        '
        'nombreMedica
        '
        Me.nombreMedica.Location = New System.Drawing.Point(101, 80)
        Me.nombreMedica.Name = "nombreMedica"
        Me.nombreMedica.Size = New System.Drawing.Size(146, 20)
        Me.nombreMedica.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Unidad Medida:"
        '
        'medidaMedica
        '
        Me.medidaMedica.FormattingEnabled = True
        Me.medidaMedica.Items.AddRange(New Object() {"Pieza", "Miligramos", "Mililitros", "Gramos"})
        Me.medidaMedica.Location = New System.Drawing.Point(101, 127)
        Me.medidaMedica.Name = "medidaMedica"
        Me.medidaMedica.Size = New System.Drawing.Size(146, 21)
        Me.medidaMedica.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(172, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'registroMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 216)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.medidaMedica)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombreMedica)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.claveMedica)
        Me.Controls.Add(Me.Label1)
        Me.Name = "registroMedicamentos"
        Me.Text = "Registro de Medicamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents claveMedica As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nombreMedica As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents medidaMedica As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
