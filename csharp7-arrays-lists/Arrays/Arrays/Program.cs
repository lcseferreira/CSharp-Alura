

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeString lista = new ListaDeString();

            lista.Adicionar("1");
            lista.Adicionar("2");
            lista.Adicionar("3");
            lista.Adicionar("4");
            lista.Adicionar("5");
            lista.Adicionar("6");

            Console.WriteLine(lista);

            // Parâmetros nomeados
            lista.TesteParam(opcional2: 1997);

            lista.EscreveLista();

            lista.Remover(2);

            Console.WriteLine();

            lista.EscreveLista();

            Console.WriteLine();

            for (int i = 0; i < lista.Tamanho; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine();

            string[] varios = { "Lucas", "Eduardo", "Ferreira" };

            lista.AdicionarVarios(varios);

            lista.EscreveLista();
        }

        static void TreinandoArray()
        {
            /*** Criando um ARRAY e adicionando idades nele. Array é um tipo de REFERÊNCIA ***/
            // int[] idades = new int[4]
            // int[] idades = new int[]{}
            int[] idades = { 17, 23, 55, 47 };
            int somaIdades = 0;
            double mediaIdades;

            // Atribuindo a soma das idades na variável somaIdades
            foreach (int i in idades)
            {
                somaIdades += i;
            }

            mediaIdades = somaIdades / idades.Length;

            Console.WriteLine(mediaIdades);
        }
    }
}