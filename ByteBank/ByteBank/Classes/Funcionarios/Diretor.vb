Namespace Classes.Funcionarios

    Public Class Diretor
        Inherits Funcionario
#Region "Propriedades"
#End Region
#Region "Construtores"

#End Region
#Region "Médotos"
        Public Overrides Function GetBonificacao() As Double
            Return salario * 1
        End Function
#End Region
    End Class
End Namespace