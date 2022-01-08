using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System.Globalization;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();
            UsarSistema();
        }

        // Método estático - não precisa de instância para ser acessado
        public static void CalcularBonificacao()
        {
            // Variável        Instância
            Auxiliar funcAux = new Auxiliar("Auxiliar", "456.111.222-88");

            // Variável                Instância
            Funcionario funcAuxTeste = new Auxiliar("Auxiliar Teste", "456.111.222-88");

            Designer funcDes = new Designer("Designer", "456.111.222-88");

            GerenteDeConta funcGer = new GerenteDeConta("GerenteDeConta", "456.111.222-88");

            Diretor funcDir = new Diretor("Diretor", "456.111.222-88");


            GerenciadoBonificacao gerenciadoBonificacao = new GerenciadoBonificacao();

            gerenciadoBonificacao.Registrar(funcAux);
            gerenciadoBonificacao.Registrar(funcDes);
            gerenciadoBonificacao.Registrar(funcGer);
            gerenciadoBonificacao.Registrar(funcDir);

            Console.WriteLine($"Total de bonificação: R$ {gerenciadoBonificacao.RetornaTotalBonificacao()}");
        }

        // Método estático para usar o sistema
        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor diretor = new Diretor("Lucas", "456.888.222-44");
            diretor.Senha = "123456";

            sistema.Logar(diretor, "123456");
            sistema.Logar(diretor, "456789");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "445566";

            sistema.Logar(parceiro, "445566");

        }
    }
}