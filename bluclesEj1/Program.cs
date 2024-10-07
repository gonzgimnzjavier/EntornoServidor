namespace bluclesEj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Serie 1
            Console.WriteLine("PRIMERA SERIE");
            Console.WriteLine("------------------");
            for (int i = 1; i < 12; i+=2) { 
            Console.Write(i+", ");
            }

            // Serie 2
            Console.WriteLine("SEGUNDA SERIE");
            Console.WriteLine("------------------");
            for (int i = 2; i < 11; i += 2)
            {
                Console.Write(i + ", ");
            }

            // Serie 3
            Console.WriteLine("TERCERA SERIE");
            Console.WriteLine("------------------");
            for (int i = 5; i < 26; i += 5)
            {
                Console.Write(i + ", ");
            }

            // Serie 4
            Console.WriteLine("CUARTA SERIE");
            Console.WriteLine("------------------");
            for (int i = 100; i > 49; i -= 10)
            {
                Console.Write(i + ", ");
            }

            Console.ReadKey();
        }
    }
}
