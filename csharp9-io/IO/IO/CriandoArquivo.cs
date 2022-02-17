using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        // Caminho e nome do arquivo que vamos criar
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))

        {
            {
                var contaComoString = "456,12345,7728.98,Lucas Ferreira";

                var encoding = Encoding.UTF8;

                // Obtendo os bytes da string
                var bytes = encoding.GetBytes(contaComoString);

                fluxoArquivo.Write(bytes, 0, bytes.Length);
            }
        }
    }

    static void CriarArquivoWriter()
    {
        // Caminho e nome do arquivo que vamos criar
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoArquivo, Encoding.UTF8))
        {
            escritor.Write("456,12345,7728.98,Lucas Ferreira");
        }
    }

    static void CriarArquivoEscreverNaHora()
    {
        var caminhoNovoArquivo = "flush.txt";

        using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoArquivo))
        {
            for (int i = 0; i < 100000; i++)
            {
                escritor.WriteLine($"Linha {i}");

                // Despeja o buffer para o Stream
                escritor.Flush();

                Console.WriteLine($"Linha {i} escrita no arquivo");
                Console.ReadLine();
            }
        }
    }
}