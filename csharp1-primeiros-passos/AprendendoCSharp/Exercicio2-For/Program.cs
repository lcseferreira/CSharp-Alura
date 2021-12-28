// Executando a tabuada do 1 ao 10 com o FOR
for (int n = 1; n <= 10; n++)
{
    Console.WriteLine($"Tabuada do {n}");
    for (int m = 1; m <= 10; m++)
    {
        Console.WriteLine($"{n} x {m} = {n * m}");
    }
    Console.WriteLine();
}

// Exibindo os múltiplos de 3 do 1 ao 100 com o FOR
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0) Console.WriteLine($"{i} é múltiplo de 3");
}

Console.WriteLine();

// Imprimindo os fatoriais de 1 a 10 com o FOR


for (int f1 = 1; f1 <= 10; f1++)
{
    int fatorial1 = 1;
    for (int g = 1; g <= 10; g++)
    {
        if (g > f1) break;
        fatorial1 *= g;
    }
    Console.WriteLine($"Fatorial de {f1} = {fatorial1}");
}

Console.WriteLine();

int fatorial2 = 1;
for (int f2 = 1; f2 <= 10; f2++)
{
    fatorial2 *= f2;
    Console.WriteLine($"Fatorial de {f2} = {fatorial2}");
}