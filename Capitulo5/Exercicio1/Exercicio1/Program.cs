using System.Globalization;
using System.Collections.Generic;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> empregados = new List<Empregado>();

            for(int i = 0; i < n; i++)
            {
                empregados.Add(LerEmpregado(i + 1));
            }


            Console.Write("Deseja atualizar o salário de algum funcionário? (S/N) ");
            string decisao = Console.ReadLine().ToUpper();

            if(decisao == "S")
            {
                Console.Write("Digite o ID do funcionário: ");
                int idAlteracao = int.Parse(Console.ReadLine());

                Empregado emp = empregados.Find(x => x.Id == idAlteracao);

                if(emp != null)
                {
                    Console.Write("Digite a porcentagem do aumento no salario: ");
                    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    emp.AumentaSalario(porcentagem);
                }
                else
                {
                    Console.WriteLine("Funcionário não existe!");
                }

            }

            Console.WriteLine("\nLista atualizada de funcionários:");
            foreach (Empregado empregado in empregados)
            {
                Console.WriteLine(empregado);
            }
        }

        static Empregado LerEmpregado(int numero)
        {
            Console.WriteLine($"Informações do funcionário #{numero}: ");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Empregado(id, nome, salario);
        }
    }
}