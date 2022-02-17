using IO.Models;

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

                // Convertendo para ContaCorrente
                var contaCorrente = ConverterStringParaContaCorrente(leitorLinha);

                Console.WriteLine($"Titular: {contaCorrente.Titular.Nome} - Agência: {contaCorrente.Agencia} - Conta: {contaCorrente.Numero} - " +
                    $"Saldo: R$ {contaCorrente.Saldo}");
            }
        }
        // Lendo até o final - Usar com cuidado
        //var leitorFim = leitorStream.ReadToEnd();
        //Console.WriteLine(leitorFim);
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(',');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2].Replace('.', ',');
        var nomeTitular = campos[3];

        var agenciaInt = int.Parse(agencia);
        var numeroInt = int.Parse(numero);

        var saldoDouble = double.Parse(saldo);

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agenciaInt, numeroInt);

        resultado.Depositar(saldoDouble);
        resultado.Titular = titular;

        return resultado;
    }


}

