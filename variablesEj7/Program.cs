namespace variablesEj7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosCelsius = 0;
            String userInput = "";

            Console.WriteLine("Introduce temperatura en celsius");
            double.TryParse(userInput=Console.ReadLine(), out gradosCelsius);
            double gradosFarenheit = (9 / 5) * gradosCelsius + 32;
            Console.WriteLine("La temeperatura en farenheit es de: "+gradosFarenheit);

            Console.ReadKey();
        }
    }
}
