partial class Program
{
    // Criando método para escrever em binário
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("escritaBinaria.txt", FileMode.Create))
        using (var bw = new BinaryWriter(fs)) // Escrita binária
        {
            bw.Write(567); // Agência
            bw.Write(94291); // Número
            bw.Write(7773.19); // Saldo
            bw.Write("Lucas Ferreira"); // Nome do titular
        }
    }

    // Criando método para ler arquivos binários
    static void LeituraBinaria()
    {
        using (var fs = new FileStream("escritaBinaria.txt", FileMode.Open))
        using (var br = new BinaryReader(fs)) // Leitura binária
        {
            var agencia = br.ReadInt32();
            var numero = br.ReadInt32();
            var saldo = br.ReadDouble();
            var titular = br.ReadString();

            Console.WriteLine($"Agência {agencia}\n" +
                $"Número {numero}\n" +
                $"Saldo {saldo}\n" +
                $"Titular {titular}");
        }
    }
}