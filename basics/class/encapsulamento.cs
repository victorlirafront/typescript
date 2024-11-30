//Protege os dados da classe, fornecendo acesso controlado.

class ContaBancaria
{
    private decimal saldo;

    public void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public decimal ConsultarSaldo()
    {
        return saldo;
    }
}
