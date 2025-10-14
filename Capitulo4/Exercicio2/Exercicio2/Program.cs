using System.Globalization;

namespace Cap4Exercico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

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