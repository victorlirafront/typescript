// Exemplo: Imprimir números de 1 a 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Número: {i}");
}


//BREAK
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
        break; // Sai do loop quando i for 5
    Console.WriteLine($"Número: {i}");
}



//CONTINUE
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
        continue; // Pula o resto do código para i = 3
    Console.WriteLine($"Número: {i}");
}
