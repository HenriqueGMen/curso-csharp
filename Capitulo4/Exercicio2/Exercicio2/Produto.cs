using System;
using System.Globalization;

namespace Cap4Exercico2
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
           return $"Produto: {_nome}\n" +
           $"Preço: {Preco.ToString("C", new CultureInfo("pt-BR"))}\n" +
           $"Quantidade: {Quantidade} unidades\n" +
           $"Preço Total: {ValorTotalEstoque().ToString("C", new CultureInfo("pt-BR"))}";
        }

    }
}
