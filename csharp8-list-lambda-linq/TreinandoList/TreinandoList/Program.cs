/*** Treinando List<> no .NET ***/

// Criando uma lista - List<GENERIC>

using TreinandoList;

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
foreach(int age in ages) {
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
