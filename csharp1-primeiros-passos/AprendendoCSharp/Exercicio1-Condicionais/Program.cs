using System.Globalization;

Console.WriteLine("Digite seu salário: ");
double salario = double.Parse(Console.ReadLine());

if (salario < 1900)
{
    Console.WriteLine($"Salário: R$ {salario.ToString("F2", CultureInfo.InvariantCulture)} - IR: 0.0% - Dedução: R$ 00.00");
}
else if (salario >= 1900 && salario <= 2800)
{
    Console.WriteLine($"Salário: R$ {salario.ToString("F2", CultureInfo.InvariantCulture)} - IR: 7.5% - Dedução: R$ 142.00");
}
else if (salario > 2800 && salario <= 3751)
{
    Console.WriteLine($"Salário: R$ {salario.ToString("F2", CultureInfo.InvariantCulture)} - IR: 15.0% - Dedução: R$ 350.00");
}
else if (salario > 3751 && salario <= 4664)
{
    Console.WriteLine($"Salário: R$ {salario.ToString("F2", CultureInfo.InvariantCulture)} - IR: 22.5% - Dedução: R$ 636.00");
}
else
{
    Console.WriteLine("A definir");
}