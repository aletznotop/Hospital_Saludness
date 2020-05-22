<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteConsultas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.desde = New System.Windows.Forms.TextBox()
        Me.hasta = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta"
        '
        'desde
        '
        Me.desde.Location = New System.Drawing.Point(62, 17)
        Me.desde.MaxLength = 10
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(124, 20)
        Me.desde.TabIndex = 2
        '
        'hasta
        '
        Me.hasta.Location = New System.Drawing.Point(299, 17)
        Me.hasta.MaxLength = 10
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(124, 20)
        Me.hasta.TabIndex = 3
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(20, 106)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(403, 163)
        Me.grid.TabIndex = 9
        Me.grid.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 47)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generar &Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Imprimir
        '
        Me.Imprimir.Location = New System.Drawing.Point(332, 292)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(90, 37)
        Me.Imprimir.TabIndex = 6
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'ReporteConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 336)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.hasta)
        Me.Controls.Add(Me.desde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReporteConsultas"
        Me.Text = "ReporteConsultas"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents desde As TextBox
    Friend WithEvents hasta As TextBox
    Friend WithEvents grid As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Imprimir As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
