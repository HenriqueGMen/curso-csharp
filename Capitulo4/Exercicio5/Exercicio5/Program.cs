using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titula da conta:");
            string titular = Console.ReadLine();

            Console.Write("Deseja fazer um depósito inicial (s/n)? ");
            string resp = Console.ReadLine().ToLower();

            if(resp == "s")
            {
                Console.Write("Informe o valor do depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
            Console.ReadKey();
        }
    }
}