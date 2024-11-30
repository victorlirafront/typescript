class Animal
{
    public void Comer() => Console.WriteLine("Comendo...");
}

class Cachorro : Animal
{
    public void Latir() => Console.WriteLine("Au Au!");
}

// Uso
Cachorro cachorro = new Cachorro();
cachorro.Comer(); // Herança de Animal
cachorro.Latir();
