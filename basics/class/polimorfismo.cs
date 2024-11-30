//Permite que métodos sejam sobrescritos (override) para oferecer comportamentos diferentes em classes derivadas.

class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

// Uso
Animal animal = new Gato();
animal.EmitirSom(); // Saída: Miau!
