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
}