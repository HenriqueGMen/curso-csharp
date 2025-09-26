using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercicioCardapio();
            //ExercicioDuracaoJogo();
            //ExercicioImposto();

        }
        static void ExercicioCardapio()
        {
            Console.WriteLine("Digite o código e a quantidade do seu pedido");

            string[] pedido = Console.ReadLine().Split(' ');
            int codigo = int.Parse(pedido[0]);
            int quantidade = int.Parse(pedido[1]);

            double precoTotal;

            if (codigo == 1)
            {
                precoTotal = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                precoTotal = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                precoTotal = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                precoTotal = quantidade * 2.0;
            }
            else
            {
                precoTotal = quantidade * 1.5;
            }

            Console.WriteLine($"Total do Pedido: {precoTotal.ToString("C", new CultureInfo("pt-BR"))}");
        }

        static void ExercicioDuracaoJogo()
        {
            Console.WriteLine("Digite a hora inicial e a final da duração do jogo");

            string[] dadosJogo = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(dadosJogo[0]);
            int horaFinal = int.Parse(dadosJogo[1]);

            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = (24 - horaInicial) + horaFinal;
            }

            Console.WriteLine($"O Jogo durou {duracao} horas");
        }

        static void ExercicioImposto()
        {
            Console.WriteLine("Digite seu salário");

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;

            if (salario <= 2000.0)
            {
                imposto = 0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if(imposto == 0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine(imposto.ToString("C", new CultureInfo("pt-BR")));
            }

        }
    }
}