// Tipos anuláveis permitem armazenar null em tipos de valor, como int.
int? idade = null;
if (idade.HasValue)
    Console.WriteLine($"Idade: {idade}");
else
    Console.WriteLine("Idade não definida.");

// Tipos anônimos são usados para criar objetos com propriedades sem definir uma classe.
var produto = new { Nome = "Laptop", Preco = 3500.50 };
Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}");

// Tipos implícitos permitem que o compilador infira o tipo da variável a partir do valor atribuído.
var nome = "Victor";
var idade = 30;
Console.WriteLine($"Nome: {nome}, Idade: {idade}");
