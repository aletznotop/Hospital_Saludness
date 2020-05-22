Imports System.ComponentModel

Public Class Reportes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        consultaMedicamentos.Show()
    End Sub

    Private Sub Reportes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReporteConsultas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReporteInventario.Show()
    End Sub
End Class