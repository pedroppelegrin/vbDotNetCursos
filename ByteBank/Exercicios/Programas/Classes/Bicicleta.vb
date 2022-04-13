Namespace Programas.Classes

    Public Class Bicicleta

#Region "PROPRIEDADES"

        Public Property NumeroRodas As Integer
        Public Property NumeroPassageiros As Integer
        Public Property Nome As String
        Public Property Velocidade As Double
#End Region

#Region "CONSTRUTORES"

        Public Sub New()
        End Sub

#End Region

#Region "MÉTODOS"

        Public Function AceleraVeiculo() As Double
            Return Velocidade * 2
        End Function

#End Region

    End Class

End Namespace