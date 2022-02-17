using IO.Models;

partial class Program
{
    static void Main(string[] args)
    {
        //CriarArquivo();
        //CriarArquivoWriter();
        //CriarArquivoEscreverNaHora();
        //EscritaBinaria();
        //LeituraBinaria();
        //UsarStreamDeEntrada();

        var linhas = File.ReadAllLines("contas.txt");

        Console.WriteLine(linhas.Length);

        foreach (var row in linhas)
        {
            Console.WriteLine(row);
        }
        Console.WriteLine("Aplicação finalizada!");


    }
}