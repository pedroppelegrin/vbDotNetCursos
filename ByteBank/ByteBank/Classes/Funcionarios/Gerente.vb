Namespace Classes.Funcionarios
    Public Class Gerente
        Inherits Funcionario
#Region "Propriedades"
#End Region
#Region "Construtores"

#End Region
#Region "Médotos"
        Public Overrides Function GetBonificacao() As Double
            Return salario * 0.1
        End Function
#End Region
    End Class

End Namespace