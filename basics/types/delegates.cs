// O delegate é um tipo que representa referências a métodos.
// Ele pode ser usado para passar métodos como parâmetros.
delegate void MostrarMensagem(string mensagem);

void Exibir(string msg) => Console.WriteLine(msg);

MostrarMensagem mostrar = Exibir;
mostrar("Olá, Delegates!");
