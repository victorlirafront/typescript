// Um array é uma coleção de elementos do mesmo tipo, acessados por índices.
int[] numeros = { 1, 2, 3, 4, 5 };
Console.WriteLine($"Primeiro número: {numeros[0]}");

// O tipo dynamic permite armazenar valores de qualquer tipo, mas a verificação de tipo ocorre em tempo de execução.
dynamic valorDinamico = 10;
valorDinamico = "Texto Dinâmico";
Console.WriteLine(valorDinamico);
