using ByteBank.Funcionarios;

public class GerenciadorBonificacao
{
    private double _totalBonificacao;

    // pode haver dois metodos com argumentos diferentes
    public void Registrar(Funcionario funcionario)
    {
        _totalBonificacao += funcionario.GetBonificacao();
    }


    public double GetTotalBonificacao()
    {
        return _totalBonificacao;
    }
}