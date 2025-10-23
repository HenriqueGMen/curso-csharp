using System.Globalization;
using System.Xml.Linq;

namespace Exercicio1
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentaSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }
    }
}
