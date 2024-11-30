using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Modificar elementos (acessando diretamente pelo índice)
        intArray[0] = 99;

        // Ordenar o array
        Array.Sort(intArray);

        // Filtrar elementos (usando LINQ)
        var evenNumbers = intArray.Where(x => x % 2 == 0).ToArray();

        // Projeção (transformar o array)
        var squaredNumbers = intArray.Select(x => x * x).ToArray();

        // Contar elementos
        int count = intArray.Length;

        // Verificar se existe um elemento
        bool containsFive = intArray.Contains(5);

        // Encontrar um elemento (primeiro número par)
        int firstEven = intArray.FirstOrDefault(x => x % 2 == 0);

        // Imprimir o array
        Console.WriteLine("Array original: " + string.Join(", ", intArray));
        Console.WriteLine("Array de números pares: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Array de números ao quadrado: " + string.Join(", ", squaredNumbers));
        Console.WriteLine($"Contagem de elementos: {count}");
        Console.WriteLine($"Contém o número 5? {containsFive}");
        Console.WriteLine($"Primeiro número par: {firstEven}");
    }
}

// Array.Sort: Ordena o array em ordem crescente.
// Where: Filtra o array com base em uma condição (LINQ).
// Select: Projeta (transforma) os elementos do array (LINQ).
// Length: Retorna o número de elementos do array.
// Contains: Verifica se um item existe no array.
// FirstOrDefault: Retorna o primeiro item que satisfaz a condição ou o valor padrão se não encontrado.
// Lembre-se de que o tamanho do array é fixo após sua criação. Se precisar de uma coleção que suporte redimensionamento dinâmico, você deve usar uma List<T>.