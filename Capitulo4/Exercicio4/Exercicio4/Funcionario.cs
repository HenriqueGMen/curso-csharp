
using System.Globalization;

namespace Exercicio4
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return $"Funcionário: {Nome}\n" +
            $"Salário Líquido: {SalarioLiquido().ToString("C", new CultureInfo("pt-BR"))}";
        }
    }
}
