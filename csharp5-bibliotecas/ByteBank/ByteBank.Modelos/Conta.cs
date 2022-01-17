using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public abstract class Conta
    {
        public static int TotalDeContasCriadas { get; private set; }

        // ATRIBUTOS DA CLASSE
        public double _saldo = 0;

        // Propriedades para SOMENTE LEITURA
        private readonly int _agencia;
        private readonly int _numero;
        // É a mesma coisa que:
        // public int Agencia { get; }
        // public int Numero { get; }


        public int Agencia { get { return _agencia; } }
        public int Numero { get { return _numero; } }
        public Cliente Titular { get; set; }

        public double Saldo
        {
            get { return _saldo; }
            protected set { _saldo = value; }
        }

        public Conta(int agencia, int numero, Cliente titular)
        {
            if (agencia <= 0)
            {
                // Retornando um erro para não criar contas com agencia <= 0 
                // nameof → pegando o valor passado e transformando em string
                throw new ArgumentException("Número da agência deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                // Retornando um erro para não criar contas com numero <= 0
                throw new ArgumentException("Número da conta deve ser maior que 0.", "numero");
            }

            _agencia = agencia;
            _numero = numero;
            Titular = titular;

            TotalDeContasCriadas++;
        }

        // MÉTODOS DA CLASSE
        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
    }
}
