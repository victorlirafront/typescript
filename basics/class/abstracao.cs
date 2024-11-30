//Permite focar apenas nos detalhes importantes, escondendo implementações complexas.


abstract class Forma
{
    public abstract void Desenhar(); // Método abstrato
}

class Circulo : Forma
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um círculo");
    }
}
