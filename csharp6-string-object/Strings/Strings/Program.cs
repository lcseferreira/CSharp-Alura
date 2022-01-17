

using System.Text.RegularExpressions;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings são imutáveis
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            Console.WriteLine(url);

            // Método para pegar uma parte da nossa string - url.Substring(início, tamanho)
            // O método Substring é inclusivo, ou seja, o valor passado no início é incluído no resultado
            string argumentos = url.Substring(7, url.Length - 7);

            Console.WriteLine(argumentos);

            // Descobrindo o índice onde se encontra o caracter "?"
            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            argumentos = url.Substring(indiceInterrogacao++);

            Console.WriteLine(argumentos);


            /*** Brincando com o indexOf ***/
            Console.WriteLine("\n*** Brincando com o indexOf ***");

            string testeStringArgumento = "moedaOrigem=";
            int testeIndiceStringArgumento = url.IndexOf(testeStringArgumento);

            Console.WriteLine($"Índice do argumento: {testeIndiceStringArgumento}");

            string testeValorArgumento = url.Substring(testeIndiceStringArgumento + testeStringArgumento.Length);

            Console.WriteLine(testeValorArgumento);


            /*** StartsWith, EndsWith, Contains ***/
            Console.WriteLine("\n*** StartsWith, EndsWith, Contains ***");

            string urlByteBank = "https://www.bytebank.com/cambio";

            if (urlByteBank.StartsWith("https://www.bytebank.com"))
            {
                Console.WriteLine("É uma url do ByteBank");
            }
            else
            {
                Console.WriteLine("Não é uma url do ByteBank");
            }


            /*** Testando a classe de extração de argumentos ***/
            Console.WriteLine("\n*** Testando a classe de extração de argumentos ***");

            string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

            ExtratorArgumentosURL extratorDeValores = new ExtratorArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaOrigem");

            Console.WriteLine($"Valor de moedaOrigem = {valor}");


            /*** Expressões Regulares ***/
            Console.WriteLine("\n*** Expressões Regulares ***");

            // Criando um padrão para ser procurado
            string pattern = "[0-9]{4,5}-?[0-9]{4}";
            string textoTeste = "Meu nome é Lucas e meu número é 98525-2535";

            Match resultado = Regex.Match(textoTeste, pattern);
            Console.WriteLine(resultado);

        }
    }
}