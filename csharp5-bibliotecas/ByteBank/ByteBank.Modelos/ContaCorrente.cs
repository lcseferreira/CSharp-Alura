using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank
    /// </summary>
    public class ContaCorrente : Conta
    {
        public double TaxaTransferencia { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        // CONSTRUTOR DA CLASSE
        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Conta.Agencia"/> e deve possuir um valor maior que zero.</param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Conta.Numero"/> e deve possuir um valor maior que zero.</param>
        /// <param name="titular">Representa o valor da propriedade <see cref="Conta.Titular"/> e deve possuir um cliente válido.</param>
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

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Conta.Saldo"/>
        /// </summary>
        /// <param name="valor">Representa o valor do saque, deve ser maior que 0 e menor que o <see cref="Conta.Saldo"/></param>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o <see cref="Conta.Saldo"/> é insuficiente para transação.</exception>
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
