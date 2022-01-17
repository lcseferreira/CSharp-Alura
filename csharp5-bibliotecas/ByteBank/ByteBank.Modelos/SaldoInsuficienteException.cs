using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(string message) : base(message)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) : this($"Tentativa de saque no valor de R$ {valorSaque} em uma conta com saldo de R$ {saldo}")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string message, Exception excecaoInterna) : base(message, excecaoInterna) { }
    }
}
