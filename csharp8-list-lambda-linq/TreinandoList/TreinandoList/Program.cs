/*** Treinando List<> no .NET ***/

// Criando uma lista - List<GENERIC>

using TreinandoList;
using TreinandoList.Comparers;

var ages = new List<int>();

// Adicionando itens na lista 
ages.Add(23);
ages.Add(32);
ages.Add(50);

// for em List
for (int i = 0; i < ages.Count; i++)
{
    Console.WriteLine($"Age: {ages[i]}");
}

Console.WriteLine();

// foreach em List
foreach (int age in ages)
{
    Console.WriteLine($"Age: {age}");
}

// Adicionando vários itens em uma List
ages.AddRange(new int[] { 45, 55, 23, 9 });

// Utilizando um método de extensão
ages.AdicionarVarios<int>(14, 20, 33, 12);

Console.WriteLine();

foreach (int age in ages)
{
    Console.WriteLine($"Age: {age}");
}

Console.WriteLine();

// Utilizando método de extensão genérico
var nomes = new List<string>();

nomes.AdicionarVarios<string>("Lucas", "Lara", "Eduardo");

// Também podemos usar assim, pois AdicionarVarios<T>(this List<T>...)
nomes.AdicionarVarios("Renata", "Maria");


foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

Console.WriteLine();

// Ordenação de listas
nomes.Sort();

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

Console.WriteLine();

// IComparable
var contas = new List<ContaCorrente>()
{
    new ContaCorrente(12345, 12),
    new ContaCorrente(99999, 14),
    new ContaCorrente(12311, 11),
    new ContaCorrente(89930, 10),
};

contas.Sort();

foreach (var conta in contas)
{
    Console.WriteLine($"Número: {conta.Numero}, Agência: {conta.Agencia}");
}

Console.WriteLine();

// ICompare
contas.Sort(new ComparadorContaCorrenteAgencia());

foreach (var conta in contas)
{
    Console.WriteLine($"Número: {conta.Numero}, Agência: {conta.Agencia}");
}

Console.WriteLine();

// OrderBy
var contasOrderBy = new List<ContaCorrente>()
{
    new ContaCorrente(12345, 10),
    new ContaCorrente(54123, 18),
    new ContaCorrente(11111, 14),
    new ContaCorrente(67734, 12),
    new ContaCorrente(34563, 16)
};

// Ordenando pelo número da conta
var contasOrdenadasPorNumero = contasOrderBy.OrderBy(conta => conta.Numero);

foreach(var conta in contasOrdenadasPorNumero)
{
    Console.WriteLine($"Número: {conta.Numero}, Agência: {conta.Agencia}");
}

Console.WriteLine();

// Ordenando pela agência da conta
var contasOrdenadasPorAgencia = contasOrderBy.OrderBy(conta => conta.Agencia);

foreach (var conta in contasOrdenadasPorAgencia)
{
    Console.WriteLine($"Número: {conta.Numero}, Agência: {conta.Agencia}");
}

