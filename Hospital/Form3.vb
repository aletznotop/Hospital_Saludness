Imports MySql.Data.MySqlClient

Public Module GlobalVariables
    Public usuarioGlobal, idusuarioGlobal As String
End Module

Public Class Form3
    Friend conexion As MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand

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
            'MsgBox("Correcto")

            sql = "select contrasena,id_tipousuario,usuario,id_usuario from usuario where usuario = '" & usu.Text() & "';"
            com = New MySqlCommand(sql, conexion)
            rs = com.ExecuteReader()

            If rs.HasRows = True Then

                rs.Read()

                If rs(0).ToString <> pass.Text() Then
                    MsgBox("Error en la contraseña, verifique")
                    pass.Clear()
                    pass.Select()
                Else
                    Form1.Show()
                    Me.Hide()
                    usuarioGlobal = rs(2).ToString
                    idusuarioGlobal = rs(3).ToString
                    conexion.Close()
                End If
            Else
                MsgBox("No se encuentra el usuario, verifique")
                usu.Clear()
                usu.Select()
                pass.Clear()
            End If



        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try







    End Sub


End Class