using System.Globalization;

namespace Exercicio2
{
    class Program 
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qtd1, qtd2;
            double preco1, preco2, total;

            Console.WriteLine("Digite as informações do primeiro produto");

            string[] info = Console.ReadLine().Split(' ');

            cod1 = int.Parse(info[0]);
            qtd1 = int.Parse(info[1]);
            preco1 = double.Parse(info[2], CultureInfo.InvariantCulture);


            Console.WriteLine("Digite as informações do segundo produto");

            info = Console.ReadLine().Split(' ');

            cod2 = int.Parse(info[0]);
            qtd2 = int.Parse(info[1]);
            preco2 = double.Parse(info[2], CultureInfo.InvariantCulture);


            total = (qtd1 * preco1) + (qtd2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

