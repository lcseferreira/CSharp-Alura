// Pegando uma data específica
using Humanizer;

DateTime testeData = new DateTime(1997, 12, 31);

Console.WriteLine($"Imprimindo data específica: {testeData}");
Console.WriteLine($"Pegando o ano da data: {testeData.Year}");
Console.WriteLine($"Pegando o dia da semana: {testeData.DayOfWeek}");
Console.WriteLine($"Pegando o mês: {testeData.Month}");
Console.WriteLine($"Adicionando 24 anos na data: {testeData.AddYears(24)}");

DateTime dataAgora = DateTime.Now;
Console.WriteLine($"Data e hora de agora: {dataAgora}");

DateTime testeData2 = DateTime.Today;
Console.WriteLine($"Data de hoje: {testeData2}");

// Fazendo operações entre datas
TimeSpan direncaEntreDatas = dataAgora - testeData;
Console.WriteLine($"Diferença entre datas: {GetIntervaloDeTempoLegivel(direncaEntreDatas)}");

Console.WriteLine();

Console.WriteLine("Utilizando a biblioteca Humanizer");

Console.WriteLine($"Tempo em semanas: {TimeSpanHumanizeExtensions.Humanize(direncaEntreDatas)}");

TimeSpan minutes = TimeSpan.FromMinutes(60);

Console.WriteLine($"60 minutos Humanizer: {TimeSpanHumanizeExtensions.Humanize(minutes)}");


// Método que retorna o intervalo de tempo em dias
static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
{
    if (timeSpan.Days > 30)
    {
        int quantidadeMeses = timeSpan.Days / 30;
        int restoMeses = timeSpan.Days % 30;
        return quantidadeMeses + " mese(s) e " + restoMeses + " dia(s).";
    }

    return timeSpan.Days + " dia(s).";
    
}