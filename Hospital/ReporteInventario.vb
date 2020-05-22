Imports MySql.Data.MySqlClient
Public Class ReporteInventario
    Friend conexion As MySqlConnection
    Private Sub ReporteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text() = "Fecha: " + Now

        'carga
        Dim sql As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand
        Dim dt = New DataTable()
        dt.Columns.Add("id_medicamento")
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Existencia")
        dt.Columns.Add("UnidadMedida")
        Try
            conexion = New MySqlConnection With {
                .ConnectionString =
                "server=localhost;" &
                "user id=dbadmin;" &
                "password=admin;" &
                "port=3306;" &
                "database=hospital;"
            }
            conexion.Open()
            sql = "select id_medicamento,nombre,existencia,unidadmedida from medicamento;"
            com = New MySqlCommand(sql, conexion)
            rs = com.ExecuteReader()
            'conexion.Close()
            If rs.HasRows = True Then
                'rs.Read()
                dt.Load(rs)
                grid.DataSource = dt
                grid.Refresh()
                conexion.Close()
            Else
                MsgBox("No se encuentra el medicamento")
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Definimos la fuente que vamos a usar para imprimir
        ' en este caso Arial de 10
        Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim leftMargin As Double = e.MarginBounds.Right
        Dim yPos As Double = 0
        Dim linesPerPage As Double = 0
        Dim count As Integer = 0
        Dim i As Integer = 0
        Dim texto As String = ""
        Dim newimagen As Image = Image.FromFile("user.png") 'Aqui esta el logo, se debe de guardar en la Carpeta Debug
        Dim x As Single = 100.0F
        Dim y As Single = 10.0F
        Dim rect As New Rectangle(50.0F, 50.0F, 150.0F, 150.0F)
        Dim units As GraphicsUnit = GraphicsUnit.Pixel
        Dim row As System.Windows.Forms.DataGridViewRow

        ' Calculamos el número de líneas que caben en cada página
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)

        ' Imprimimos las cabeceras
        Dim header As DataGridViewHeaderCell
        For Each column As DataGridViewColumn In grid.Columns
            header = column.HeaderCell
            texto += vbTab + header.FormattedValue.ToString()
        Next

        e.Graphics.DrawString("Reporte de Inventario " + Now, printFont, System.Drawing.Brushes.Red, (leftMargin / 2) - 50, 20)
        e.Graphics.DrawImage(newimagen, x, y, rect, units)
        count += 6

        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        ' Dejamos una línea de separación
        count += 2

        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid.
        While count < linesPerPage AndAlso i < grid.Rows.Count
            row = grid.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor, en caso de 
                'permitir añadir filas esto es muy importante
                If celda.Value IsNot Nothing Then
                    texto += vbTab + celda.Value.ToString()
                End If
            Next

            ' Calculamos la posición en la que se escribe la línea
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))

            ' Escribimos la línea con el objeto Graphics
            e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            ' Incrementamos los contadores
            count += 1
            i += 1
        End While

        ' Una vez fuera del bucle comprobamos si nos quedan más filas
        ' por imprimir, si quedan saldrán en la siguente página
        If i < grid.Rows.Count Then
            e.HasMorePages = True
        Else
            ' si llegamos al final, se establece HasMorePages a
            ' false para que se acabe la impresión
            e.HasMorePages = False
            ' Es necesario poner el contador a 0 porque, por ejemplo si se hace
            ' una impresión desde PrintPreviewDialog, se vuelve disparar este
            ' evento como si fuese la primera vez, y si i está con el valor de la
            ' última fila del grid no se imprime nada
            i = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub
End Class
