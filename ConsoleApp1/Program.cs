namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int num;

            Console.WriteLine("Introduce un número entre 1 y 5:");
            int.TryParse(userInput = Console.ReadLine(), out num);

            if (num < 1 || num > 5)
            {
                Console.WriteLine("Número fuera del rango permitido (1-5).");
            }
            else
            {
                bool esPrimo = EsNumeroPrimo(num);

                if (esPrimo)
                    Console.WriteLine(num + " es primo.");
                else
                    Console.WriteLine(num + " no es primo.");
            }

            Console.ReadKey();
        }

        static bool EsNumeroPrimo(int num)
        {
            if (num == 1) return false; // 1 no es primo
            if (num == 2) return true;  // 2 es primo

            // Comprobar si num es divisible por algún número entre 2 y num - 1
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false; // Si es divisible por algún número distinto de sí mismo, no es primo
                }
            }

            return true; // Si no es divisible por otros números, es primo
        }
    }
}
