using ByteBank.Modelos;


namespace ByteBank.SistemaInterno
{
    public class SistemaInterno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int[] vetor = { 1, 2, 3, 4 };

            foreach (int i in vetor)
            {
                Console.WriteLine(i);
            }

            string nome = "Lucas";

            Cliente cliente = new Cliente("Lucas", "123456789");
            ContaCorrente conta = new ContaCorrente(955, 955235, cliente);

            conta.Depositar(250);
            Console.WriteLine(conta.Saldo);

            conta.Sacar(400);
        }
    }
}