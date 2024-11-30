class Pessoa
{
    // Campos
    private string nome;

    // Propriedade
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    // Construtor
    public Pessoa(string nome)
    {
        this.nome = nome;
    }

    // Método
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {nome}.");
    }
}


// Componentes Principais de uma Classe
// 1. Campos
// Armazenam dados dentro da classe.
// Normalmente são declarados como private para proteger a integridade dos dados.


Pessoa pessoa = new Pessoa();
pessoa.Nome = "Victor";
pessoa.Apresentar();