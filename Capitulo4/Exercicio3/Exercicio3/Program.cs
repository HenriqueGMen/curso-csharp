using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.Write("Digite a Largura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite a Altura do retangulo: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Área: {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}" );
            Console.WriteLine($"Perímetro: {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}" );
            Console.WriteLine($"Diagonal: {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}" );

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}