partial class Program
{
    static void Main(string[] args)
    {
        var enderecoArquivo = "Contas.txt";

        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open)) // Abrindo o arquivo
        using (var leitorStream = new StreamReader(fluxoArquivo)) // Leitor de Stream)
        {
            while (!leitorStream.EndOfStream)
            {
                // Lendo linha por linha
                var leitorLinha = leitorStream.ReadLine();
                Console.WriteLine(leitorLinha);
            }
        }
        // Lendo até o final - Usar com cuidado
        //var leitorFim = leitorStream.ReadToEnd();
        //Console.WriteLine(leitorFim);
    }


}

