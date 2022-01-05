using _07_ByteBank;

ContaCorrente conta1 = new ContaCorrente(867, 867125);

Console.WriteLine($"Agência: {conta1.Agencia } Número: {conta1.Numero}");

ContaCorrente conta = new ContaCorrente(867, 867772);

// Acessando um membro estático (static)

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

