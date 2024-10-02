using System.Diagnostics.CodeAnalysis;

namespace actividad7B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;

            int suma = 0;

            String userInput = ""; 

            Console.WriteLine("Inserta un numero:");

            int.TryParse(userInput=Console.ReadLine(), out numeroIngresado);

            for (int i = 0; i <= numeroIngresado; i+=2)
            {
                suma += i;
            }

            Console.WriteLine("La suma es: " + suma);
            Console.ReadKey();
        }
    }
}
