

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Criação dos clientes, testes com métodos e consultas ###");
            Cliente cliente1 = new Cliente("Lucas", "123.456.789-10");
            Cliente cliente2 = new Cliente("Lara", "444.264.233-20");

            ContaCorrente contaCorrente1 = new ContaCorrente(13, 132597, cliente1);

            Console.WriteLine(contaCorrente1.Saldo);

            contaCorrente1.Depositar(700);
            contaCorrente1.Sacar(100);

            Console.WriteLine(Conta.TotalDeContasCriadas);

            Console.WriteLine();

            Console.WriteLine("### Bloco try catch com a função estática Metodo() ###");

            try
            {
                Metodo();
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch dentro do Main");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Continue");

            Console.WriteLine();

            Console.WriteLine("### Forçando erro dentro da conta ###");

            // Tentando criar uma conta com valores inválidos definidos no construtor
            ContaCorrente contaCorrente2 = new ContaCorrente(100, 100955, cliente1);

            try
            {
                contaCorrente2.Sacar(100);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Argumento com problema: {e.ParamName}");
                Console.WriteLine("Aconteceu um ArgumentException");
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            Console.WriteLine("### Testando transferência entre as contas e forçando erros ###");

            try
            {
                contaCorrente1.Transferir(800, contaCorrente2);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
                Console.WriteLine(e.Message);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine();

            Console.WriteLine($"Contador de saques não permitidos: {contaCorrente2.ContadorSaquesNaoPermitidos}");
            Console.WriteLine($"Cotnador de transferências não permitidas: {contaCorrente1.ContadorTransferenciasNaoPermitidas}");


        }




        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Divisao(10, divisor);
        }

        static int Divisao(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exceção capturada na Divisao() -> Throw");

                // Passa a exception a diante
                throw;
            }

        }
    }
}