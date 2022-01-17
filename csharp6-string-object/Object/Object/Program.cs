namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Lucas", "444.555.666-77", 24);
            Console.WriteLine(cliente1);

            Cliente cliente2 = new Cliente("Lucas", "444.555.666-77", 24);
            Console.WriteLine(cliente2);

            Console.WriteLine(cliente1.Equals(cliente2));

            // Toda classe deriva de objetc
            object clienteObject = new Cliente("João", "222.333.444-55", 40);
            Console.WriteLine(clienteObject.GetType());
        }
    }
}