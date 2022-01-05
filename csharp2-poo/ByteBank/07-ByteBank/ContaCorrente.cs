using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{

    // Criando uma classe para o objeto ContaCorrente
    public class ContaCorrente
    {
        // Getter e Setter sem regras de negócio
        public Cliente Titular { get; set; }

        // Membro estático: propriedade da classe - Somente com o uso do Getter público e o Setter sendo acessado somente dentro da classe
        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia { get; set; }

        public int Numero { get; set; }

        private double _saldo;

        // Getter e Setter (o set possue um propriedade chamada 'value' que representa o parâmetro) 
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        // Getter
        public double GetSaldo()
        {
            return _saldo;
        }

        // Setter
        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }

            this._saldo += saldo;
        }

        // Construtor
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            // Sempre que uma conta for criada, vamos acumular no total
            TotalDeContasCriadas++;
        }

        // MÉTODOS da classe
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}