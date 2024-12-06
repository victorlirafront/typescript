using System;

namespace arithmetic
{
    public class Methods
    {
        public int FindMaxNum(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }

    public class Program
    {
        // Em C#, o método Main precisa declarar explicitamente o tipo de parâmetro, mesmo que não use nenhum parâmetro. Ele deve ser definido da seguinte forma:
        static void Main(string[] args)
        {
            // O static em C# significa que o método ou variável é associado à classe em vez de a uma instância específica dessa classe. Isso implica que você pode chamar um método ou acessar uma variável static sem precisar criar uma instância da classe.

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Methods num = new Methods();
            int result = num.FindMaxNum(arr);
            Console.WriteLine(result);
        }
    }
}