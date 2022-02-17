using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoArquivo = "contas.txt";

        // FileStream(endereco, ação) - Depois que usar, será chamado o Dispose
        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            // buffer = usado para guardar informações temporárias
            var buffer = new byte[1024]; // 1 kb
            var numeroBytesLidos = -1;

            while (numeroBytesLidos != 0) // Quando for 0, significa que acabou a leitura
            {
                // Read(array de bytes para gravar informações, índice de preenchimento, quantidade de bytes do array) 
                numeroBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroBytesLidos);
            }

            // Fechando o arquivo
            //fluxoArquivo.Close();
        }
    }


    // Classe estática para escrever meus bytes
    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        // Codificador de UTF-8
        //var utf8 = Encoding.UTF8;
        //var utf8 = new UTF8Encoding();
        var utf8 = Encoding.Default;

        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);

        //foreach (var myByte in buffer)
        //{
        //    Console.Write($"{myByte} ");
        //}
    }
}