Imports Exercicios.Programas.Classes

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim GerenciadorVelocidade As New GerenciadorVelocidade
        GerenciadorVelocidade.Registrar(New Carro())
    End Sub
End Class
