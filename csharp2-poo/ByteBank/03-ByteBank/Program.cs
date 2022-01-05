// Instanciando um objeto da classe ContaCorrente
ContaCorrente contaLucas = new ContaCorrente();
contaLucas.titular = "Lucas";
contaLucas.agencia = 13;
contaLucas.numero = 13975;
contaLucas.saldo = 0;

ContaCorrente contaLucasEduardo = new ContaCorrente();
contaLucasEduardo.titular = "Lucas";
contaLucasEduardo.agencia = 13;
contaLucasEduardo.numero = 13975;
contaLucas.saldo = 0;

// Isso irá retornar 'False', pois é uma comparação por referência de memória e os objetos referenciam alocações diferentes
Console.WriteLine($"Igualdade de tipo de referência: {contaLucas == contaLucasEduardo}");

int idade = 24;
int mesmaIdade = 24;

// Isso irá retornar 'True', pois é uma comparação por valor e não por referência de memória
Console.WriteLine($"Igualdade de tipo de valor: {idade == mesmaIdade}");