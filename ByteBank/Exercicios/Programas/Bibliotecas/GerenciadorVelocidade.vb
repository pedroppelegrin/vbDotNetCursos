Namespace Programas.Classes

    Public Class GerenciadorVelocidade

        Private _totalVelocidade As Double

        Public Sub Registrar(Onibus As Onibus)
            _totalVelocidade += Onibus.AceleraVeiculo()
        End Sub

        Public Sub Registrar(Carro As Carro)
            _totalVelocidade += Carro.AceleraVeiculo()
        End Sub

        Public Sub Registrar(Bicicleta As Bicicleta)
            _totalVelocidade += Bicicleta.AceleraVeiculo()
        End Sub

        Public Function getVelocidade() As Double
            Return _totalVelocidade
        End Function

    End Class

End Namespace