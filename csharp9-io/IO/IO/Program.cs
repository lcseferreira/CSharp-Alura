using System.IO; // IO = Input Output (Entrada e Saída)

/*** Criando um FileStream ***/

var enderecoArquivo = "contas.txt";

// FileStream(endereco, ação)
var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open);

// buffer = usado para guardar informações temporárias
var buffer = new byte[1024]; // 1 kb
var numeroBytesLidos = -1;

while (numeroBytesLidos != 0) // Quando for 0, significa que acabou a leitura
{
    // Read(array de bytes para gravar informações, índice de preenchimento, quantidade de bytes do array) 
    numeroBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);
    EscreverBuffer(buffer);
}





// Classe estática para escrever meus bytes
static void EscreverBuffer(byte[] buffer)
{
    foreach (var myByte in buffer)
    {
        Console.Write($"{myByte} ");
    }
}