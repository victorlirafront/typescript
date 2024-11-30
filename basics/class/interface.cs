//Definem contratos que classes devem implementar.

interface IAnimal
{
    void FazerSom();
}

class Cachorro : IAnimal
{
    public void FazerSom() => Console.WriteLine("Au Au!");
}
