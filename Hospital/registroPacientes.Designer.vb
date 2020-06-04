<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroPacientes
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
        Me.noControl = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nombrePaciente = New System.Windows.Forms.TextBox()
        Me.paternoPaciente = New System.Windows.Forms.TextBox()
        Me.maternoPaciente = New System.Windows.Forms.TextBox()
        Me.carrera = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.genero = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Control"
        '
        'noControl
        '
        Me.noControl.Location = New System.Drawing.Point(155, 81)
        Me.noControl.MaxLength = 7
        Me.noControl.Name = "noControl"
        Me.noControl.Size = New System.Drawing.Size(100, 20)
        Me.noControl.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(499, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Materno:"
        '
        'nombrePaciente
        '
        Me.nombrePaciente.Location = New System.Drawing.Point(155, 117)
        Me.nombrePaciente.Name = "nombrePaciente"
        Me.nombrePaciente.Size = New System.Drawing.Size(143, 20)
        Me.nombrePaciente.TabIndex = 7
        '
        'paternoPaciente
        '
        Me.paternoPaciente.Location = New System.Drawing.Point(155, 156)
        Me.paternoPaciente.Name = "paternoPaciente"
        Me.paternoPaciente.Size = New System.Drawing.Size(143, 20)
        Me.paternoPaciente.TabIndex = 8
        '
        'maternoPaciente
        '
        Me.maternoPaciente.Location = New System.Drawing.Point(155, 190)
        Me.maternoPaciente.Name = "maternoPaciente"
        Me.maternoPaciente.Size = New System.Drawing.Size(143, 20)
        Me.maternoPaciente.TabIndex = 9
        '
        'carrera
        '
        Me.carrera.FormattingEnabled = True
        Me.carrera.Items.AddRange(New Object() {"Ingenieria", "Matematicas", "Desarrollo de Software", "Actuario", "Trabajador Social"})
        Me.carrera.Location = New System.Drawing.Point(497, 121)
        Me.carrera.Name = "carrera"
        Me.carrera.Size = New System.Drawing.Size(121, 21)
        Me.carrera.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Carrera:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(387, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Genero:"
        '
        'genero
        '
        Me.genero.FormattingEnabled = True
        Me.genero.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.genero.Location = New System.Drawing.Point(497, 159)
        Me.genero.Name = "genero"
        Me.genero.Size = New System.Drawing.Size(121, 21)
        Me.genero.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(505, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 20)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'registroPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 256)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.genero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.carrera)
        Me.Controls.Add(Me.maternoPaciente)
        Me.Controls.Add(Me.paternoPaciente)
        Me.Controls.Add(Me.nombrePaciente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.noControl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "registroPacientes"
        Me.Text = "Registro de Pacientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents noControl As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nombrePaciente As TextBox
    Friend WithEvents paternoPaciente As TextBox
    Friend WithEvents maternoPaciente As TextBox
    Friend WithEvents carrera As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents genero As ComboBox
    Friend WithEvents Button2 As Button
End Class
