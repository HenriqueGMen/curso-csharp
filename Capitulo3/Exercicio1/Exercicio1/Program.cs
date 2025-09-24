

using System.Globalization;

namespace Exercicio1
{
    class App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();


            Console.WriteLine("Quantos Quartos tem em sua casa? ");
            int QtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu sobrenome, idade e altura: ");
            string[] infoUsuario = Console.ReadLine().Split(" "); 


            Console.WriteLine(nomeCompleto);
            Console.WriteLine(QtdQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{infoUsuario[0]} {infoUsuario[1]} {infoUsuario[2]}");
        }
    }
}