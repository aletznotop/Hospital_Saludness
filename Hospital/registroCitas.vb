Imports System.ComponentModel
Imports MySql.Data.MySqlClient


Public Class registroCitas
    Friend conexion As MySqlConnection
    Private Sub registroCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text() = "Fecha: " + Now
        'ConsultaCita.Text() = Int((99999 * Rnd()) + 1)
        UsuarioCita.Text = usuarioGlobal

        Dim sql As String
        Dim com As MySqlCommand
        Dim ada As MySqlDataAdapter = New MySqlDataAdapter()
        Dim ado As MySqlDataAdapter = New MySqlDataAdapter()
        Dim das, dos As New DataSet()


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
            sql = "select id_medicamento,nombre from medicamento;"
            com = New MySqlCommand(sql, conexion)
            ada.SelectCommand = com
            ada.Fill(das)
            'ada.Dispose()
            'com.Dispose()
            'conexion.Close()
            'MedicaCita.DataSource = das.Tables(0)
            'MedicaCita.DisplayMember = "nombre"
            MedicaCita.Items.Add("")
            For i As Integer = 0 To das.Tables(0).Rows.Count - 1
                MedicaCita.Items.Add(das.Tables(0).Rows(i)(0).ToString + " -" +
                                     das.Tables(0).Rows(i)(1))
            Next
            conexion.Close()

            conexion.Open()
            sql = "select nocontrol,nombre,a_paterno,a_materno from pacientes;"
            com = New MySqlCommand(sql, conexion)
            ado.SelectCommand = com
            ado.Fill(dos)
            'ado.Dispose()
            'com.Dispose()
            'conexion.Close()
            'PacienteCita.DataSource = dos.Tables(0)
            'PacienteCita.DisplayMember = "nombre"
            PacienteCita.Items.Add("")
            For i As Integer = 0 To dos.Tables(0).Rows.Count - 1
                PacienteCita.Items.Add(dos.Tables(0).Rows(i)(0).ToString + " " +
                                       dos.Tables(0).Rows(i)(1) + " " +
                                       dos.Tables(0).Rows(i)(2) + " " +
                                       dos.Tables(0).Rows(i)(3))
            Next
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub registroCitas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim columna1, columna2 As String
        Dim row(1) As String
        columna1 = MedicaCita.Text()
        columna2 = CantiCita.Text()
        row = {columna2, columna1}
        medicamento.Rows.Add(row)

        'If medicamento.Rows.Count > 0 Then
        'For i As Integer = 0 To medicamento.Rows.Count - 1
        'MsgBox(medicamento.Rows.Item(i).Cells(0).Value + " " +
        'medicamento.Rows.Item(i).Cells(1).Value)
        'Next
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand
        Dim ada As MySqlDataAdapter = New MySqlDataAdapter()
        Dim ado As MySqlDataAdapter = New MySqlDataAdapter()
        Dim das, dos As New DataSet()
        Dim cantidad As Integer = 0

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

            If ConsultaCita.Text() = "" Or PacienteCita.Text() = "" Or MedicaCita.Text() = "" Or CantiCita.Text() = "" Or medicamento.Rows.Count.ToString = "0" Then
                MsgBox("No puedes guardar sin datos")
            Else
                sql = "insert into consultas (id_consulta,pacientes_noControl,usuario_idusuario,id_usuario,fecha,nocontrol,descripcion) values (" _
                    & ConsultaCita.Text() & "," _ 'pacientes_nocontrol
                    & PacienteCita.Text.Substring(0, 1) & "," _ 'pacientes_nocontrol
                    & idusuarioGlobal & "," _ 'usuario_idusuario
                    & idusuarioGlobal & ",CURDATE()," _ 'id_usuario y fecha
                    & PacienteCita.Text.Substring(0, 1) & ",'" _
                    & ObsCita.Text() & "');" 'descrpcion
                com = New MySqlCommand(sql, conexion)
                rs = com.ExecuteReader()
                conexion.Close()
                MsgBox("Se ha guardado la cita")

                If medicamento.Rows.Count > 0 Then
                    For i As Integer = 0 To medicamento.Rows.Count - 1
                        conexion.Open()
                        Dim medica As String = medicamento.Rows.Item(i).Cells(1).Value.ToString.Substring(0, medicamento.Rows.Item(i).Cells(1).Value.ToString.IndexOf("-"))
                        sql = "insert into consultasdetalle (medicamento_idmedicamento,consulta_idconsulta,id_consulta,id_medicamento,cantidad) values (" _
                            & medica & "," _
                            & ConsultaCita.Text() & "," _
                            & ConsultaCita.Text() & "," _
                            & medica & "," _
                            & medicamento.Rows.Item(i).Cells(0).Value & ");"
                        com = New MySqlCommand(sql, conexion)
                        rs = com.ExecuteReader()
                        conexion.Close()

                        conexion.Open()
                        sql = "select existencia from medicamento where id_medicamento=" & medica & ";"
                        com = New MySqlCommand(sql, conexion)
                        rs = com.ExecuteReader()
                        rs.Read()
                        cantidad = rs(0).ToString
                        cantidad -= medicamento.Rows.Item(i).Cells(0).Value
                        conexion.Close()

                        conexion.Open()
                        sql = "update medicamento set existencia=" & cantidad & " where id_medicamento= " & medica
                        com = New MySqlCommand(sql, conexion)
                        rs = com.ExecuteReader()
                        conexion.Close()
                    Next
                End If
            End If
            ConsultaCita.Clear()
            PacienteCita.SelectedIndex = 0
            ObsCita.Clear()
            MedicaCita.SelectedIndex = 0
            CantiCita.Clear()
            medicamento.Rows.Clear()
            ConsultaCita.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ConsultaCita_Leave(sender As Object, e As EventArgs) Handles ConsultaCita.Leave
        Dim sql As String
        Dim rs As MySqlDataReader
        Dim com As MySqlCommand
        If ConsultaCita.Text() = "" Then

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

                sql = "select * from consultas where id_consulta = " & ConsultaCita.Text() & ";"
                com = New MySqlCommand(sql, conexion)
                rs = com.ExecuteReader()
                If rs.HasRows = True Then
                    MsgBox("Ese número de cita ya esta ocupado,verifique")
                    ConsultaCita.Clear()
                    ConsultaCita.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub ConsultaCita_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ConsultaCita.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class