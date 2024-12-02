using System;

class Program {
    static void SolveHanoi(int n, char from, char to, char aux) {
        if (n == 1) {
            Console.WriteLine($"Mover disco 1 de {from} para {to}");
            return;
        }

        SolveHanoi(n - 1, from, aux, to);
        Console.WriteLine($"Mover disco {n} de {from} para {to}");
        SolveHanoi(n - 1, aux, to, from);
    }

    static void Main() {
        int n = 3;
        SolveHanoi(n, 'A', 'C', 'B');
    }
}
