//Membros estáticos pertencem à classe, e não a uma instância.

class Calculadora
{
    public static int Somar(int a, int b) => a + b;
}

// Uso
int resultado = Calculadora.Somar(3, 5); // Sem criar instância
Console.WriteLine(resultado); // Saída: 8
