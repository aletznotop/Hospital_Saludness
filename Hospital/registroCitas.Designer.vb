<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroCitas
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
        Me.ConsultaCita = New System.Windows.Forms.TextBox()
        Me.UsuarioCita = New System.Windows.Forms.TextBox()
        Me.ObsCita = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MedicaCita = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CantiCita = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.medicamento = New System.Windows.Forms.DataGridView()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.l = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PacienteCita = New System.Windows.Forms.ComboBox()
        CType(Me.medicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Consulta: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Paciente: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Observacion: "
        '
        'ConsultaCita
        '
        Me.ConsultaCita.Location = New System.Drawing.Point(118, 32)
        Me.ConsultaCita.Name = "ConsultaCita"
        Me.ConsultaCita.Size = New System.Drawing.Size(100, 20)
        Me.ConsultaCita.TabIndex = 4
        '
        'UsuarioCita
        '
        Me.UsuarioCita.Enabled = False
        Me.UsuarioCita.Location = New System.Drawing.Point(118, 70)
        Me.UsuarioCita.Name = "UsuarioCita"
        Me.UsuarioCita.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioCita.TabIndex = 5
        '
        'ObsCita
        '
        Me.ObsCita.Location = New System.Drawing.Point(118, 163)
        Me.ObsCita.MaxLength = 80
        Me.ObsCita.Multiline = True
        Me.ObsCita.Name = "ObsCita"
        Me.ObsCita.Size = New System.Drawing.Size(324, 85)
        Me.ObsCita.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Medicamento:"
        '
        'MedicaCita
        '
        Me.MedicaCita.FormattingEnabled = True
        Me.MedicaCita.Location = New System.Drawing.Point(118, 278)
        Me.MedicaCita.Name = "MedicaCita"
        Me.MedicaCita.Size = New System.Drawing.Size(169, 21)
        Me.MedicaCita.Sorted = True
        Me.MedicaCita.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cantidad: "
        '
        'CantiCita
        '
        Me.CantiCita.Location = New System.Drawing.Point(111, 332)
        Me.CantiCita.Name = "CantiCita"
        Me.CantiCita.Size = New System.Drawing.Size(61, 20)
        Me.CantiCita.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'medicamento
        '
        Me.medicamento.AllowUserToAddRows = False
        Me.medicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.medicamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cantidad, Me.l})
        Me.medicamento.Location = New System.Drawing.Point(31, 367)
        Me.medicamento.Name = "medicamento"
        Me.medicamento.Size = New System.Drawing.Size(319, 105)
        Me.medicamento.TabIndex = 16
        '
        'cantidad
        '
        Me.cantidad.Frozen = True
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'l
        '
        Me.l.Frozen = True
        Me.l.HeaderText = "Medicamento"
        Me.l.Name = "l"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(433, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 15
        '
        'PacienteCita
        '
        Me.PacienteCita.FormattingEnabled = True
        Me.PacienteCita.Location = New System.Drawing.Point(118, 115)
        Me.PacienteCita.Name = "PacienteCita"
        Me.PacienteCita.Size = New System.Drawing.Size(242, 21)
        Me.PacienteCita.TabIndex = 7
        '
        'registroCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 512)
        Me.Controls.Add(Me.PacienteCita)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.medicamento)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CantiCita)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MedicaCita)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ObsCita)
        Me.Controls.Add(Me.UsuarioCita)
        Me.Controls.Add(Me.ConsultaCita)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "registroCitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Citas"
        CType(Me.medicamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ConsultaCita As TextBox
    Friend WithEvents UsuarioCita As TextBox
    Friend WithEvents ObsCita As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MedicaCita As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CantiCita As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents medicamento As DataGridView
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents l As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PacienteCita As ComboBox
End Class
