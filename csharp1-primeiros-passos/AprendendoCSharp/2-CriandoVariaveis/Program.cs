using System.Globalization;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variáveis");

            int minhaIdade = 24;
            Console.WriteLine($"Minha idade é {minhaIdade} anos");

            double meuSalario = 1500.50;
            Console.WriteLine($"Meu salário é R$ {meuSalario.ToString("F2", CultureInfo.InvariantCulture)}");

            // Fazendo casting de um double para int
            int testeCast = (int)15.6;
            Console.WriteLine(testeCast);

            // Desse jeito, o retorno será truncado e sem casa decimais
            double divisao1 = 15 / 2;
            Console.WriteLine($"15 / 2 = {divisao1}");

            // Para ver o resultado com dados decimais, precisamos colocar um dos números como double
            double divisao2 = 15.0 / 2;
            Console.WriteLine($"15.0 / 2 = {divisao2}");

            Console.WriteLine("Execução finalizada. Tecle enter para sair.");
            Console.ReadLine();
        }
    }
}