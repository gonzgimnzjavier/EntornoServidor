namespace variablesEj11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double espacioEnMetros;
            double tiempoEnSegundos;
            String userInput = "";
            Console.WriteLine("Introduce el espacio en metros:");
            double.TryParse(userInput=Console.ReadLine(), out espacioEnMetros);
            Console.WriteLine("Introduce el tiempo en segundos:");
            double.TryParse(userInput = Console.ReadLine(), out tiempoEnSegundos);
            double velocidad = espacioEnMetros / tiempoEnSegundos;
            Console.WriteLine("La velocidad es de " + velocidad + " metros/segundo");
            Console.ReadKey();
        }
    }
}
