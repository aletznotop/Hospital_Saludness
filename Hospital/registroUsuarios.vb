
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class registroUsuarios
    Friend conexion As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql, inserta As String
        Dim rs As MySqlDataReader
        Dim com, cam As MySqlCommand


        If tipoUsuario.Text() = "" Or
            nombreUsuario.Text() = "" Or
            apmUsuario.Text() = "" Or
            appUsuario.Text() = "" Or
            passContrasena.Text() = "" Or
            conContrasena.Text() = "" Then
            MsgBox("No puede haber texto vacío, verifique")
        End If

        If passContrasena.Text() <> conContrasena.Text() Then
            MsgBox("Las contraseñas no coinciden, verifique")
            passContrasena.Clear()
            conContrasena.Clear()
            passContrasena.Select()
        End If

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
            sql = "select * from usuario where usuario = '" & usuario.Text() & "';"
            inserta = "insert into usuario 
            (tipo_usuario_id, nombre,a_paterno,a_materno,id_tipousuario, usuario, contrasena) values ('" _
            & tipoUsuario.SelectedIndex() & "','" _
            & nombreUsuario.Text() & "','" _
            & appUsuario.Text() & "','" _
            & apmUsuario.Text() & "','" _
            & tipoUsuario.SelectedIndex() & "','" _
            & usuario.Text() & "','" _
            & passContrasena.Text() & "');"


            com = New MySqlCommand(sql, conexion)
            rs = com.ExecuteReader()
            conexion.Close()

            If rs.HasRows = False Then
                conexion.Open()
                cam = New MySqlCommand(inserta, conexion)
                rs = cam.ExecuteReader()
                MsgBox("Usuario Registrado Correctamente")
                conexion.Close()
                tipoUsuario.SelectedIndex = 0
                nombreUsuario.Clear()
                appUsuario.Clear()
                apmUsuario.Clear()
                usuario.Clear()
                passContrasena.Clear()
                conContrasena.Clear()
                tipoUsuario.Select()
            Else
                MsgBox("El usuario ya existe, verifique")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub

    Private Sub registroUsuarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub
End Class