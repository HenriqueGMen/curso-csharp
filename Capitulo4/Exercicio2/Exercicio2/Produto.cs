using System;
using System.Globalization;

namespace Cap4Exercico2
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarQtdEstoque(int qtdAdicionada)
        {
            Quantidade += qtdAdicionada;
        }

        public void RemoverQtdEstoque(int qtdRemovida)
        {
            Quantidade -= qtdRemovida;
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
