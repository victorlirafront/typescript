using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        int num = int.Parse("4");
        Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
    }
}
