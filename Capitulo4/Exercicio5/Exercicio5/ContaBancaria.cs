using System;
using System.Globalization;

namespace Exercicio5
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public bool Saque(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo!");
                return false;
            }

            if (quantia > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
                return false;
            }

            Saldo -= quantia;
            return true;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("C", new CultureInfo("pt-BR"));
        }
    }
}