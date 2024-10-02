using System;

namespace actividad7c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int factorial = 0;
            String userInpunt = "";

            do
            {
                Console.WriteLine("Introduce un numero:");

                int.TryParse(userInpunt = Console.ReadLine(), out num);
                factorial = num;
                for (int i = num-1; i >= 1; i--)
                {
                    factorial *= i;
                }
                Console.WriteLine("El factorial es: " + factorial);
            } while (num >= 0);
        }
    }
}
