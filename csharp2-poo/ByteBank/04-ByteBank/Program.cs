using System.Globalization;

// Instanciando a nossa classe ContaCorrente
ContaCorrente contaLucas = new ContaCorrente();

contaLucas.titular = "Lucas";
contaLucas.agencia = 10;
contaLucas.numero = 10750;
contaLucas.saldo = 200.70;

// Usando a função (método) Sacar
bool resultadoSaque = contaLucas.Sacar(50);

Console.WriteLine($"Saldo na conta: R$ {contaLucas.saldo.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine(resultadoSaque);

// Usando a função (método) Sacar
resultadoSaque = contaLucas.Sacar(200);

Console.WriteLine($"Saldo na conta: R$ {contaLucas.saldo.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine(resultadoSaque);

// Usando o método (função) Depositar
contaLucas.Depositar(200);

Console.WriteLine($"Saldo na conta: R$ {contaLucas.saldo.ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine();

// Instanciando a nossa classe ContaCorrente
ContaCorrente contaMaria = new ContaCorrente();

contaMaria.titular = "Maria";
contaMaria.agencia = 10;
contaMaria.numero = 10127;
contaMaria.saldo = 1720.77;

// Usando a função (método) Transferir
Console.WriteLine($"Saldo Lucas: R$ {contaLucas.saldo.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Saldo Maria: R$ {contaMaria.saldo.ToString("F2", CultureInfo.InvariantCulture)}");

contaMaria.Transferir(500, contaLucas);

Console.WriteLine($"Novo saldo Lucas: R$ {contaLucas.saldo.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Novo saldo Maria: R$ {contaMaria.saldo.ToString("F2", CultureInfo.InvariantCulture)}");