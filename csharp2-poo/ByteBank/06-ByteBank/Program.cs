using _06_ByteBank;
using System.Globalization;

ContaCorrente conta = new ContaCorrente();
Cliente cliente = new Cliente();

cliente.Nome = "Lucas";
cliente.CPF = "444.222.333-88";
cliente.Profissao = "Desenvolvedor";

conta.Titular = cliente;
conta.Saldo = 7000;

Console.WriteLine($"Titular: {conta.Titular.Nome}");
Console.WriteLine($"Saldo: R$ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
  
