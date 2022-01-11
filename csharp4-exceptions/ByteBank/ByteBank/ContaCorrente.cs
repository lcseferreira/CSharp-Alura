using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ByteBank
{
    public class ContaCorrente : Conta
    {
        public double TaxaTransferencia { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        // CONSTRUTOR DA CLASSE
        public ContaCorrente(int agencia, int numero, Cliente titular) : base(agencia, numero, titular)
        {
            TaxaTransferencia = 30 / TotalDeContasCriadas;
        }

        // MÉTODOS DA CLASSE
        public override void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Você depositou R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Seu saldo atual é de R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public override void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (valor > Saldo)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            Saldo -= valor;

            Console.WriteLine($"Você sacou R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Seu saldo atual é de R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                // Lançando a exceção
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            contaDestino.Depositar(valor);
            Console.WriteLine("Transferência realizada com sucesso.");
        }
    }
}
