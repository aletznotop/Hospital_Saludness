Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class registroMedicamentos
    Friend conexion As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql, inserta As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand

        If claveMedica.Text() = "" Or nombreMedica.Text() = "" Or medidaMedica.Text() = "" Then
            MsgBox("Existen Campos vacios, verifique")
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
                sql = "select * from medicamento where nombre= '" & nombreMedica.Text() + "';"
                inserta = "insert into medicamento (id_medicamento,unidadmedida_idunidadmedida,nombre,existencia,unidadmedida) values ('" _
                & claveMedica.Text() & "','" _
                & medidaMedica.SelectedIndex() & "','" _
                & nombreMedica.Text() & "','" _
                & "0" & "','" _
                & medidaMedica.Text() & "');"

                com = New MySqlCommand(sql, conexion)
                rs = com.ExecuteReader()

                If rs.HasRows = False Then
                    conexion.Close()
                    conexion.Open()
                    com = New MySqlCommand(inserta, conexion)
                    rs = com.ExecuteReader()
                    MsgBox("El medicamento se ha registrado correctamente")
                    conexion.Close()
                    nombreMedica.Clear()
                    medidaMedica.SelectedIndex = -1
                    claveMedica.Clear()
                    'claveMedica.Text() = Int((6 * Rnd()) + 1)
                Else
                    MsgBox("El medicamento ya existe")
                    conexion.Close()
                    nombreMedica.Select()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub registroMedicamentos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub

    Private Sub claveMedica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles claveMedica.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class