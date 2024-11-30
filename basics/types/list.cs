class Program
{
    static void Main()
    {
        List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Adicionar elementos
        intList.Add(11);
        intList.Insert(0, 0);

        // Remover elementos
        intList.Remove(5); // Remove o primeiro 5
        intList.RemoveAt(0); // Remove o item na posição 0

        // Modificar elementos
        intList[0] = 99;

        // Ordenar a lista
        intList.Sort();

        // Filtrar elementos
        var evenNumbers = intList.Where(x => x % 2 == 0).ToList();

        // Projeção (transformar a lista)
        var squaredNumbers = intList.Select(x => x * x).ToList();

        // Contar elementos
        int count = intList.Count;

        // Verificar se existe um elemento
        bool containsFive = intList.Contains(5);

        // Encontrar um elemento
        int firstEven = intList.FirstOrDefault(x => x % 2 == 0);

        // Imprimir a lista
        Console.WriteLine("Lista original: " + string.Join(", ", intList));
        Console.WriteLine("Lista de números pares: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Lista de números ao quadrado: " + string.Join(", ", squaredNumbers));
        Console.WriteLine($"Contagem de elementos: {count}");
        Console.WriteLine($"Contém o número 5? {containsFive}");
        Console.WriteLine($"Primeiro número par: {firstEven}");
    }
}


// Add: Adiciona um item no final da lista.
// Insert: Insere um item em uma posição específica.
// Remove: Remove o primeiro item que corresponde ao valor especificado.
// RemoveAt: Remove o item na posição indicada.
// Sort: Ordena a lista.
// Where: Filtra a lista com base em uma condição.
// Select: Projeta (transforma) os elementos da lista.
// Count: Retorna o número de elementos na lista.
// Contains: Verifica se um item existe na lista.
// FirstOrDefault: Retorna o primeiro item que satisfaz uma condição ou o valor padrão se não encontrado.