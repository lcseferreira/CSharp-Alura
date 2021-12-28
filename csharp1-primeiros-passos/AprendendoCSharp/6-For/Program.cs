using System.Globalization;

// Usando laço de repetição FOR
double valorInvestido = 1000;
double fatorRendimento = 1.0036;

for (int mes = 1; mes <= 12; mes++)
{
    valorInvestido *= fatorRendimento;
    Console.WriteLine($"Mês: {mes} - Valor: R${valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");
}

// Usando laço de repetição FOR encadeado
valorInvestido = 2000;


// O tempo do investimento será de 5 anos
for (int ano = 1; ano <= 5; ano++)
{
    for (int mes = 1; mes <= 12; mes++)
    {
        valorInvestido *= fatorRendimento;
        Console.WriteLine($"Ano: {ano} - Mês: {mes} - Valor: R${valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");
    }
    fatorRendimento += 0.0010;
}

Console.WriteLine();

// Transformando WHILE em FOR
int contador = 1;

Console.WriteLine("WHILE");
while (contador <= 10)
{
    Console.WriteLine(contador);
    contador++;
}

Console.WriteLine();

Console.WriteLine("FOR");
for (int c1 = 1; c1 <= 10; c1++)
{
    Console.WriteLine(c1);
}

Console.WriteLine();

// O uso do BREAK
for (int linha = 0; linha <= 10; linha++)
{
    for (int coluna = 0; coluna <= 10; coluna++)
    {
        Console.Write("*");
        if (coluna >= linha) break;
    }
    Console.WriteLine();
}

Console.WriteLine();

// Forma alternativa sem o BREAK
for (int linha = 0; linha <= 10; linha++)
{
    for (int coluna = 0; coluna <= linha; coluna++) Console.Write("*");
    Console.WriteLine();
}

// Exercício com FOR
for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        if (x < y) break;
        Console.Write(y + 1);
    }
    Console.WriteLine();
}