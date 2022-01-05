using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();

            cliente1.nome = "Lucas";
            cliente1.cpf = "444.555.666-77";
            cliente1.profissao = "Desenvolvedor Júnior";

            ContaCorrente conta1 = new ContaCorrente();

            conta1.titular = cliente1;
            conta1.agencia = 45;
            conta1.numero = 45750;
            conta1.saldo = 7500.72;

            Console.WriteLine(cliente1.nome);
            Console.WriteLine(conta1.titular.nome);

        }
    }
}