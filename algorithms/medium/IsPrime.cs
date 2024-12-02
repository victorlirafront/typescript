using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        
        int num = int.Parse("3");

        if (IsPrime(num))
            Console.WriteLine($"{num} is prime.");
        else
            Console.WriteLine($"{num} is not prime.");
    }
}
