/*** Treinando List<> no .NET ***/

// Criando uma lista - List<GENERIC>
using TreinandoList;

List<int> ages = new List<int>();

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
ages.AdicionarVarios(14, 20, 33, 12);

Console.WriteLine();

foreach (int age in ages)
{
    Console.WriteLine($"Age: {age}");
}



