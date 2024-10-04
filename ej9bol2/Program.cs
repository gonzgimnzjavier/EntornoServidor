namespace ej9bol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaNucleo;
            double presionNucleo;
            String userInpunt = "";

            Console.WriteLine("Introduce la temperatura del nucleo");
            userInpunt = Console.ReadLine();
            double.TryParse(userInpunt, out temperaturaNucleo);
            Console.WriteLine("Introduce la presion del nucleo");
            userInpunt = Console.ReadLine();
            double.TryParse(userInpunt, out presionNucleo);

            if (presionNucleo < 2 && temperaturaNucleo < 500)
            {
                Console.WriteLine("Todo en orden");
            }
            else if (presionNucleo > 2 && temperaturaNucleo > 500)
            {
                Console.WriteLine("Abrir valvula y reducir la temperatura");
            }
            else if (presionNucleo > 2)
            {
                Console.WriteLine("Abrir valvula");
            }
            else if (temperaturaNucleo > 500)
            {
                Console.WriteLine("Reducir la temperatura");
            }

            Console.ReadKey();
        }
    }
}
