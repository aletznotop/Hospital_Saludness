Imports MySql.Data.MySqlClient

Public Class consultaMedicamentos
    Friend conexion As MySqlConnection
    'Private mysqldataadapter As MySqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand
        Dim dt = New DataTable()
        dt.Columns.Add("Existencia")
        dt.Columns.Add("UnidadMedida")
        If nombreMedica.Text() = "" Then
            MsgBox("Favor de capturar el nombre")
        Else
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
                sql = "select existencia,unidadmedida from medicamento where nombre  = '" & nombreMedica.Text() & "';"
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

        End If
    End Sub
End Class