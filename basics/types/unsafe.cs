// O código inseguro permite manipulação direta de memória usando ponteiros.
// É necessário habilitar o suporte a código "unsafe" no projeto.
unsafe
{
    int numero = 10;
    int* ptr = &numero;
    Console.WriteLine($"Valor: {numero}, Endereço: {(int)ptr}");
}
