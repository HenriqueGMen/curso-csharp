
using System.Globalization;

namespace Exercicio5
{
    class App
    {
        static void Main(string[] args)
        {
            //RetornaNumImpar(8);
            //VerificaIntervalo();

            //Exercicio3
            Console.WriteLine("Digite a quantidade de casos de teste: ");
            int n = int.Parse(Console.ReadLine());
            CalculaMedia(n);
        }

        private static void RetornaNumImpar(int x)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 0; i < numero; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine("Número: " + i);
                }
            }

        }

        private static void VerificaIntervalo()
        {

            Console.WriteLine("Digite um número: ");
            int qtdNum = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < qtdNum; i++)
            {
                Console.WriteLine("Digite o número: ");
                int num = int.Parse(Console.ReadLine());

                if(num >= 10 && num <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine("In: " + dentro);
            Console.WriteLine("Out: " + fora);

        }

        private static void CalculaMedia(int n)
        {
            Console.WriteLine("Escreva os 3 numeros para calcular a média ponderada");

            for(int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                double a = double.Parse(numbers[0], CultureInfo.InvariantCulture);
                double b = double.Parse(numbers[1], CultureInfo.InvariantCulture);
                double c = double.Parse(numbers[2], CultureInfo.InvariantCulture);

                double media = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}