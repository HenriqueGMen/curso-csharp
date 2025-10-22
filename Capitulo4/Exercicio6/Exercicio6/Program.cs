namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estudantes = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int quartosAlugados = int.Parse(Console.ReadLine());

            for(int i = 0; i < quartosAlugados; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel ● {i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                while (estudantes[quarto] != null)
                {
                    Console.WriteLine("❌ Esse quarto já está ocupado! Escolha outro.");
                    quarto = int.Parse(Console.ReadLine());
                }

                estudantes[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Relatório de ocupação");

            for(int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine(i + ": " + estudantes[i]);
                }
            }
        }
    }
}