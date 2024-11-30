// Uma classe é um tipo de referência que pode conter propriedades, métodos e eventos.
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

// Criando uma instância de classe e acessando suas propriedades.
Pessoa pessoa = new Pessoa { Nome = "Victor", Idade = 30 };
Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");

// Uma interface define um contrato que deve ser implementado pelas classes.
interface IAnimal
{
    void FazerSom();
}

class Cachorro : IAnimal
{
    public void FazerSom() => Console.WriteLine("Au Au!");
}

IAnimal cachorro = new Cachorro();
cachorro.FazerSom();
