partial class Program
{
    // Utilizando o stream de input da Console
    static void UsarStreamDeEntrada()
    {
        using (var fluxoEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("testeInput.txt", FileMode.Create))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var bytesLidos = fluxoEntrada.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, bytesLidos);

                fs.Flush();

                Console.WriteLine($"Bytes lidos da Console: {bytesLidos}");
            }
        }
    }
}