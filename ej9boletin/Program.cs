namespace ej9boletin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            String userInput = "";

            Console.WriteLine("Introduce un numero:");

            double.TryParse(userInput=Console.ReadLine(), out numero);

            if (numero % 2 == 0)
                Console.WriteLine("Es multiplo de 2");
            else if (numero % 3 == 0)
                Console.WriteLine("Es multiplo de 3");
            Console.ReadKey();
        }
    }
}
