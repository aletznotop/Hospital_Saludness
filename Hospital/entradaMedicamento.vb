Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class entradaMedicamento
    Friend conexion As MySqlConnection

    Private Sub entradaMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text() = Now
        usuario.Text() = usuarioGlobal

    End Sub

    Private Sub claveMedica_Leave(sender As Object, e As EventArgs) Handles claveMedica.Leave

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql, inserta1, inserta2, lastrecord As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand
        Dim lastid, lastcant As Integer

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
            lastrecord = "select id_detalle from ent_med_detalle order by id_detalle desc limit 1;"
            com = New MySqlCommand(lastrecord, conexion)
            rs = com.ExecuteReader()
            If rs.HasRows = True Then
                rs.Read()
                lastid = rs(0).ToString()
                lastid += 1
                conexion.Close()
            Else
                lastid = 1
                conexion.Close()
            End If

            If Grid.Rows.Count > 0 Then
                For i As Integer = 0 To Grid.Rows.Count - 1
                    conexion.Open()
                    inserta1 = "insert into ent_med_detalle (entradamedicamento_idEntrada,medicamento_idMedicamento,id_entrada,id_medicamento,cantidad) values ('" _
                            & lastid & "','" _
                            & Grid.Rows.Item(i).Cells(0).Value & "','" _
                            & lastid & "','" _
                            & Grid.Rows.Item(i).Cells(0).Value & "','" _
                            & Grid.Rows.Item(i).Cells(1).Value & "');"
                    com = New MySqlCommand(inserta1, conexion)
                    rs = com.ExecuteReader()

                    conexion.Close()

                    conexion.Open()
                    inserta2 = "insert into entrada_medicamento (usuario_idUsuario,fecha,idUsuario) values ('" _
                            & idusuarioGlobal & "',CURDATE(),'" _
                            & idusuarioGlobal & "');"
                    com = New MySqlCommand(inserta2, conexion)
                    rs = com.ExecuteReader()
                    conexion.Close()

                    conexion.Open()
                    sql = "select existencia from medicamento where id_medicamento= '" & Grid.Rows.Item(i).Cells(0).Value + "';"
                    com = New MySqlCommand(sql, conexion)
                    rs = com.ExecuteReader()
                    If rs.HasRows = True Then
                        rs.Read()
                        lastcant = rs(0).ToString()
                        lastcant = lastcant + Int32.Parse(Grid.Rows.Item(i).Cells(1).Value)
                        conexion.Close()
                    End If

                    conexion.Close()
                    conexion.Open()
                    sql = "update medicamento set existencia = " & lastcant & " where id_medicamento = " & Grid.Rows.Item(i).Cells(0).Value & ";"
                    com = New MySqlCommand(sql, conexion)
                    rs = com.ExecuteReader()
                    conexion.Close()
                Next
            End If
            MsgBox("Entrada Correcta")
            medica.Select()
            cantidadMedica.Clear()
            claveMedica.Clear()
            medida.Text = ""
            medica.Clear()
            Grid.Rows.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub entradaMedicamento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub

    Private Sub medica_Leave(sender As Object, e As EventArgs) Handles medica.Leave
        Dim sql As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand
        Dim cantidad As Integer

        If medica.Text() = "" Then
            'MsgBox("No puedes buscar, verifique")
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
                sql = "select id_medicamento,existencia,unidadmedida from medicamento where nombre  = '" & medica.Text() & "';"
                com = New MySqlCommand(sql, conexion)
                rs = com.ExecuteReader()
                If rs.HasRows = True Then
                    rs.Read()
                    claveMedica.Text() = rs(0).ToString
                    cantidad = rs(1).ToString
                    'MsgBox(cantidad)
                    medida.Text = rs(2).ToString
                    conexion.Close()
                Else
                    MsgBox("No se encuentra el medicamento")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim columna1, columna2, columna3 As String
        Dim row(2) As String
        columna1 = claveMedica.Text()
        columna2 = cantidadMedica.Text()
        columna3 = medica.Text()
        row = {columna1, columna2, columna3}
        Grid.Rows.Add(row)
        medica.Select()
        medica.Clear()
        cantidadMedica.Clear()
        claveMedica.Clear()
        medida.Text = ""
        medica.Clear()
    End Sub
End Class