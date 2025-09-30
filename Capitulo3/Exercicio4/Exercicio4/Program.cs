using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExercicioSenha();
            ExercicioCoordenadas();

        }

        private static void ExercicioSenha()
        {
            Console.WriteLine("Digite a senha: ");
            int tentativaSenha = int.Parse(Console.ReadLine());
            int senha = 2002;

            while(tentativaSenha != senha)
            {
                Console.WriteLine("Senha Incorreta, tente novamente.");

                Console.WriteLine("Digite a senha: ");
                tentativaSenha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido.");

        }

        private static void ExercicioCoordenadas()
        {
            Console.WriteLine("Digite as coordenadas X e Y");
            string[] coordenadas = Console.ReadLine().Split(" ");

            int eixoX = int.Parse(coordenadas[0]);
            int eixoY = int.Parse(coordenadas[1]);

            while(eixoX != 0 && eixoY != 0)
            {
                if(eixoX > 0 && eixoY > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (eixoX < 0 && eixoY > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (eixoX < 0 && eixoY < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante");
                }

                Console.WriteLine("Digite as coordenadas X e Y");
                coordenadas = Console.ReadLine().Split(" ");
                eixoX = int.Parse(coordenadas[0]);
                eixoY = int.Parse(coordenadas[1]);
            }

        }
    }
}