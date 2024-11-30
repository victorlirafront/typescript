// O struct é um tipo de valor usado para representar objetos com dados simples e de tamanho fixo.
struct Ponto
{
    public int X;
    public int Y;
}

// Instanciando um struct e acessando seus valores.
Ponto ponto = new Ponto { X = 5, Y = 10 };
Console.WriteLine($"Ponto: ({ponto.X}, {ponto.Y})");

// O enum é usado para definir um conjunto de constantes nomeadas.
// Por padrão, cada item enum é atribuído a um valor inteiro sequencial, começando em 0.
enum DiaDaSemana { Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo }
DiaDaSemana hoje = DiaDaSemana.Sexta;
Console.WriteLine($"Hoje é: {hoje}");
