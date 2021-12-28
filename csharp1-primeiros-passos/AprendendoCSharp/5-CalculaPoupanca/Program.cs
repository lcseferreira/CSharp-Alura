using System.Globalization;

Console.WriteLine("Projeto Calcula Poupança");

double valorInvestido = 1000;

// 0.0036 = 0.36%
valorInvestido += valorInvestido * 0.36 / 100;

Console.WriteLine($"Após 1 mês, você terá R$ {valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine();

// Usando o while para calcular a variação da poupança de acordo com os meses
int contadorMes = 1;

while (contadorMes <= 12)
{
    valorInvestido += valorInvestido * 0.36 / 100;
    Console.WriteLine($"Após {contadorMes} mês/meses, você terá R$ {valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");
    // contadorMes = contadorMes + 1;
    // contadorMes += 1;
    contadorMes++;
}