Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class registroPacientes
    Friend conexion As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand
        Dim ver As Boolean = False
        If noControl.Text() = "" Then
            MsgBox("Favor de Capturar un número")
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

                sql = "select noControl,nombre,a_paterno,a_materno,id_carrera,id_genero from pacientes where noControl = " & noControl.Text() & ";"
                com = New MySqlCommand(sql, conexion)
                rs = com.ExecuteReader()
                'conexion.Close()

                If rs.HasRows = True Then
                    rs.Read()
                    nombrePaciente.Text() = rs(1).ToString()
                    paternoPaciente.Text() = rs(2).ToString()
                    maternoPaciente.Text() = rs(3).ToString()
                    carrera.SelectedIndex() = rs(4).ToString()
                    genero.SelectedIndex() = rs(5).ToString()
                    conexion.Close()
                    ver = True
                Else
                    MsgBox("No se encuentra el paciente, verifique")
                    ver = False
                End If

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

        End If
    End Sub

    Private Sub noControl_Click(sender As Object, e As EventArgs) Handles noControl.Click
        maternoPaciente.Clear()
        paternoPaciente.Clear()
        nombrePaciente.Clear()
        noControl.Clear()
        carrera.SelectedIndex = -1
        genero.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql, inserta As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand

        If nombrePaciente.Text() = "" Or paternoPaciente.Text() = "" Or maternoPaciente.Text() = "" Or genero.Text() = "" Or carrera.Text() = "" Then
            MsgBox("Existen campos vacios, verifique")
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
                sql = "select * from pacientes where nocontrol = '" _
                & noControl.Text() & "';"

                inserta = "insert into pacientes (nocontrol,usuario_idUsuario, genero_idGenero,carreras_idCarrera,nombre,a_paterno,a_materno,id_carrera,id_genero) values ('" _
                    & noControl.Text & "','" _
                    & idusuarioGlobal & "','" _
                    & genero.SelectedIndex() & "','" _
                    & carrera.SelectedIndex() & "','" _
                    & nombrePaciente.Text() & "','" _
                    & paternoPaciente.Text() & "','" _
                    & maternoPaciente.Text() & "','" _
                    & carrera.SelectedIndex() & "','" _
                    & genero.SelectedIndex() & "');"
                com = New MySqlCommand(sql, conexion)
                rs = com.ExecuteReader()
                'conexion.Close()

                If rs.HasRows = False Then
                    conexion.Close()
                    conexion.Open()

                    com = New MySqlCommand(inserta, conexion)
                    rs = com.ExecuteReader()
                    MsgBox("El paciente se ha registrado correctamente")
                    conexion.Close()
                    maternoPaciente.Clear()
                    paternoPaciente.Clear()
                    nombrePaciente.Clear()
                    genero.SelectedIndex = -1
                    carrera.SelectedIndex = -1
                    noControl.Clear()
                Else
                    conexion.Close()
                    conexion.Open()
                    sql = "Update pacientes set usuario_idusuario= " & idusuarioGlobal & ",genero_idgenero=" & genero.SelectedIndex() & ",carreras_idcarrera=" & carrera.SelectedIndex() & ",nombre='" & nombrePaciente.Text() & "',a_paterno='" & paternoPaciente.Text() & "',a_materno='" & maternoPaciente.Text() & "',id_carrera=" & carrera.SelectedIndex() & ",id_genero=" & genero.SelectedIndex() & " where nocontrol=" & noControl.Text() & ";"
                    com = New MySqlCommand(sql, conexion)
                    rs = com.ExecuteReader()
                    MsgBox("El paciente se ha Actualizado correctamente")
                    maternoPaciente.Clear()
                    paternoPaciente.Clear()
                    nombrePaciente.Clear()
                    genero.SelectedIndex = -1
                    carrera.SelectedIndex = -1
                    noControl.Clear()
                    conexion.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

        End If

    End Sub

    Private Sub registroPacientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub

    Private Sub noControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noControl.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class