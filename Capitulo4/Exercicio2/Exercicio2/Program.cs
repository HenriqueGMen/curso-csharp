using System.Globalization;

namespace Cap4Exercico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + produto);


            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite a quantidade de produtos a serem adicionados:");
            int qtdAdicionada = int.Parse(Console.ReadLine());

            produto.AdicionarQtdEstoque(qtdAdicionada);

            Console.WriteLine("Dados do Produto: " + produto);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite a quantidade de produtos a serem removidos:");
            int qtdRemovida = int.Parse(Console.ReadLine());

            produto.RemoverQtdEstoque(qtdRemovida);

            Console.WriteLine("Dados do Produto: " + produto);



            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}