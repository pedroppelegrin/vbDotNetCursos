Namespace Programas.Classes

    Public Class Veiculo

#Region "PROPRIEDADES"

        Public Property NumeroRodas As Integer
        Public Property NumeroPassageiros As Integer
        Public Property Nome As String
        Public Property Velocidade As Double
        Public Property TipoVeiculo As String

#End Region

#Region "CONSTRUTORES"

        Public Sub New(_TipoVeiculo As String)
            TipoVeiculo = _TipoVeiculo
        End Sub

#End Region

#Region "MÉTODOS"

        Public Function AceleraVeiculo() As Double

            If TipoVeiculo = "ONIBUS" Then
                Return Velocidade * 1.05
            ElseIf TipoVeiculo = "CARRO" Then
                Return Velocidade * 1.2
            ElseIf TipoVeiculo = "BICICLETA" Then
                Return Velocidade * 2
            End If
            Return 0

        End Function

#End Region

    End Class

End Namespace