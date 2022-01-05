using System.Globalization;

// Instanciando o nosso objeto ContaCorrente    
ContaCorrente contaLucas = new ContaCorrente();

contaLucas.titular = "Lucas";
contaLucas.agencia = 72;
contaLucas.numero = 72535;
contaLucas.saldo = 7400.50;

Console.WriteLine($"Titular: {contaLucas.titular}");
Console.WriteLine($"Agência: {contaLucas.agencia}");
Console.WriteLine($"Número: {contaLucas.numero}");
Console.WriteLine($"Saldo: R$ {contaLucas.saldo.ToString("F2", CultureInfo.InvariantCulture)}");