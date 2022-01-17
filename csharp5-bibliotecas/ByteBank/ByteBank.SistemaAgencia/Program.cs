using System.Text;
using ByteBank.Funcionarios;
using ByteBank.Modelos;
using ByteBank.Sistemas;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Lucas", "456.842.222-72");
            ContaCorrente conta1 = new ContaCorrente(13, 1345, cliente1);

            Auxiliar auxiliar = new Auxiliar("Eduardo", "222.444.887-25");

            Console.WriteLine(auxiliar.GetBonificacao()); ;

            Cliente cliente2 = new Cliente("José", "222.479.234-22");
            ContaCorrente conta2 = new ContaCorrente(13, 1325, cliente2);
           
        }
    }
}