using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        int start = 0;
        int end = str.Length - 1;

        while (start < end)
        {
            if (str[start] != str[end])
                return false;

            start++;
            end--;
        }
        return true;
    }

    static void Main()
    {
        string input = "33";

        if (IsPalindrome(input))
            Console.WriteLine($"{input} is a palindrome.");
        else
            Console.WriteLine($"{input} is not a palindrome.");
    }
}
