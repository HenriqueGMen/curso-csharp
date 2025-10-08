using System.Globalization;

namespace Capitulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            ComparaIdade();
            MediaSalarios();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        public static void ComparaIdade()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da Pessoa 1: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da Pessoa 2: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine($"{p1.Nome} tem {p1.Idade} e é mais velho(a)");
            }
            else
            {
                Console.WriteLine($"{p2.Nome} tem {p2.Idade} e é mais velho(a)");
            }
        }
        public static void MediaSalarios()
        {
            Console.WriteLine("Quantidade de Funcionários.");
            int qtdFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();
            double somaSalarios = 0.0;


            for(int i = 0; i < qtdFuncionarios; i++)
            {
                Funcionario f = new Funcionario();

                Console.WriteLine($"Dados do funcionário {i+1}");
                Console.Write("Nome: ");
                f.Nome = Console.ReadLine();

                Console.Write("Salario: ");
                f.Salario = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                funcionarios.Add(f);
                somaSalarios += f.Salario;
            }

            double mediaSalario = somaSalarios / qtdFuncionarios;

            Console.WriteLine($"\nSalário médio = {mediaSalario.ToString("C", new CultureInfo("pt-BR"))}");

        }
    }
}