Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Principal"
        lbl_Principal.Text = "Principal"
        btn_Click.Text = "Clique aqui"

    End Sub

    Private Sub Btn_Click_Click(sender As Object, e As EventArgs) Handles btn_Click.Click

        Dim gerenciadorBonificacao As New GerenciadorBonificacao()

        Dim Carlos As New Gerente()
        Carlos.nome = "Carlos Antônio"
        Carlos.cpf = "543.445.434-00"
        Carlos.salario = 10000

        gerenciadorBonificacao.Registrar(Carlos)

        Dim Bia As New Diretor()
        Bia.nome = "Beatriz Regina"
        Bia.cpf = "522.476.980-12"
        Bia.salario = 20000

        gerenciadorBonificacao.Registrar(Bia)

        MsgBox("O salário do " + Carlos.nome + " é " + Carlos.salario.ToString)
        MsgBox("A bonificação de " + Carlos.nome + " será de  " +
            Carlos.GetBonificacao().ToString)

        MsgBox("O salário da " + Bia.nome + " é " + Bia.salario.ToString)
        MsgBox("A bonificação da " + Bia.nome + " será de  " +
            Bia.GetBonificacao().ToString)

        MsgBox("O valor total de bonificação a ser pago será de " +
            gerenciadorBonificacao.getBonificacao.ToString)

    End Sub

End Class