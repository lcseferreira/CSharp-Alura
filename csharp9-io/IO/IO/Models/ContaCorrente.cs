using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Models
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; private set; }
        public Cliente Cliente { get; set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor do depósito deve ser maior que 0", nameof(valor));
            }

            Saldo += valor;
        }
    }
}
