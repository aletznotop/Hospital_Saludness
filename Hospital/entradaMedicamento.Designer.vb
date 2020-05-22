<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entradaMedicamento
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.claveMedica = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.medica = New System.Windows.Forms.TextBox()
        Me.cantidadMedica = New System.Windows.Forms.TextBox()
        Me.medida = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medicamento: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Unidad Medida"
        '
        'claveMedica
        '
        Me.claveMedica.Enabled = False
        Me.claveMedica.Location = New System.Drawing.Point(127, 84)
        Me.claveMedica.Name = "claveMedica"
        Me.claveMedica.Size = New System.Drawing.Size(198, 20)
        Me.claveMedica.TabIndex = 3
        '
        'usuario
        '
        Me.usuario.Enabled = False
        Me.usuario.Location = New System.Drawing.Point(127, 48)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(198, 20)
        Me.usuario.TabIndex = 2
        '
        'medica
        '
        Me.medica.Location = New System.Drawing.Point(127, 12)
        Me.medica.Name = "medica"
        Me.medica.Size = New System.Drawing.Size(198, 20)
        Me.medica.TabIndex = 1
        '
        'cantidadMedica
        '
        Me.cantidadMedica.Location = New System.Drawing.Point(127, 122)
        Me.cantidadMedica.Name = "cantidadMedica"
        Me.cantidadMedica.Size = New System.Drawing.Size(198, 20)
        Me.cantidadMedica.TabIndex = 4
        '
        'medida
        '
        Me.medida.Enabled = False
        Me.medida.FormattingEnabled = True
        Me.medida.Location = New System.Drawing.Point(127, 157)
        Me.medida.Name = "medida"
        Me.medida.Size = New System.Drawing.Size(198, 21)
        Me.medida.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label6"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Cantidad, Me.UMedida})
        Me.Grid.Location = New System.Drawing.Point(41, 200)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.Size = New System.Drawing.Size(284, 116)
        Me.Grid.TabIndex = 12
        Me.Grid.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(357, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Agrega"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'UMedida
        '
        Me.UMedida.HeaderText = "Unidad Medida"
        Me.UMedida.Name = "UMedida"
        Me.UMedida.ReadOnly = True
        Me.UMedida.Width = 80
        '
        'entradaMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 326)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.medida)
        Me.Controls.Add(Me.cantidadMedica)
        Me.Controls.Add(Me.medica)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.claveMedica)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "entradaMedicamento"
        Me.Text = "Entrada de Medicamento"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents claveMedica As TextBox
    Friend WithEvents usuario As TextBox
    Friend WithEvents medica As TextBox
    Friend WithEvents cantidadMedica As TextBox
    Friend WithEvents medida As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Grid As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents UMedida As DataGridViewTextBoxColumn
End Class
