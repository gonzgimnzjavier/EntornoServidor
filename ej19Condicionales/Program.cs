namespace ej19Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una vocal:");
            char userInpunt = Console.ReadLine()[0];
            if (userInpunt == 65 || userInpunt ==69 || userInpunt == 73 || userInpunt == 79 || userInpunt == 85 || userInpunt == 97 || userInpunt == 101 || userInpunt == 105 || userInpunt == 111 || userInpunt == 117)
            {
                Console.WriteLine("Has introducido una vocal");
            }
            else
            {
                Console.WriteLine("No pusiste una vocal");
            }
            Console.ReadKey();
        }
    }
}
