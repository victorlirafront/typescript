using System;

class Program
{
    static int FindMax(int[] arr)
    {
        int max = arr[0];
        foreach (var num in arr)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

    static void Main()
    {
        int[] arr = { 10, 50, 20, 90, 30 };
        Console.WriteLine($"The maximum value is: {FindMax(arr)}");
    }
}
