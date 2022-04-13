﻿Imports ByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas

    Public Class GerenciadorBonificacao
        Private _totalBonificacao As Double
        Public Sub Registrar(_Funcionario As Funcionario)
            _totalBonificacao += _Funcionario.GetBonificacao()
        End Sub
        Public Function getBonificacao() As Double
            Return _totalBonificacao
        End Function

    End Class

End Namespace