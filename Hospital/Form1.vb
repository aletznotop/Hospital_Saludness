Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class Form1
    Friend conexion As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        registroPacientes.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        registroUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

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
            MsgBox("Correcto")
        Catch ex As Exception
            MsgBox("Error en la Conexion")
        End Try
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        entradaMedicamento.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        registroMedicamentos.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Reportes.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        registroCitas.Show()
        Me.Hide()
    End Sub
End Class
