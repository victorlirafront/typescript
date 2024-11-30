 // -- CODE RUNNER BELOW --

//onecompiler.com/csharp/

using System;

namespace Name
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayPersonInformations()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    public class WeatherForecast
    {
        // O modificador public no C# define o nível de acesso de um método, classe ou propriedade.
        // Significado de public:
        // Acesso irrestrito: O método DisplayForecast pode ser chamado de qualquer lugar, tanto dentro quanto fora da classe ou do assembly onde foi definido.

        public void DisplayForecast()
        {
            Console.WriteLine("Date: Today");
            Console.WriteLine("TemperatureC: 25°C");
            Console.WriteLine("TemperatureF: 77°F");
            Console.WriteLine("Summary: Sunny");
        }
    }

    class Program
    {
        // Significa que o método pertence à classe e não a uma instância da classe.
        // Isso é necessário porque o método Main é chamado automaticamente pelo runtime da aplicação antes que qualquer objeto seja criado.
        // Você não precisa criar uma instância da classe para chamá-lo.
        static void Main()
            // O método Main é o ponto inicial da execução do programa, ou seja, é onde a execução começa. Quando você executa um aplicativo C#, o sistema operacional chama o método Main para iniciar o programa.
        {
            var forecast = new WeatherForecast();
            var person = new Person
            {
                Name = "Victor Lira", 
                Age = 30
            };

            forecast.DisplayForecast();
            person.DisplayPersonInformations();
        }
    }
}
