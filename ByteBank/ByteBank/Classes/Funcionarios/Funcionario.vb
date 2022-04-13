Namespace Classes.Funcionarios
    Public Class Funcionario
#Region "Propriedades"
        Public Property nome As String
        Public Property cpf As String
        Public Property salario As Double
#End Region
#Region "Construtores"


#End Region
#Region "Médotos"
        Public Overridable Function GetBonificacao() As Double
            Return salario * 0.1
        End Function
#End Region
    End Class
End Namespace