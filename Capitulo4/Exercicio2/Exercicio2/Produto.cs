using System;
using System.Globalization;

namespace Cap4Exercico2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
           return $"Produto: {Nome}\n" +
           $"Preço: {Preco.ToString("C", new CultureInfo("pt-BR"))}\n" +
           $"Quantidade: {Quantidade} unidades\n" +
           $"Preço Total: {ValorTotalEstoque().ToString("C", new CultureInfo("pt-BR"))}";
        }
    }
}
