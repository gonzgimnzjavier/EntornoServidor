namespace variablesEj8
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double presion = 0;
            double volumen = 0;
            double numeroMoles = 0;
            double constanteR = 0.082;
            double temperaturaKelvin = 0;
            String userInput = "";

            Console.WriteLine("Intoduce el volumen:");
            double.TryParse(userInput=Console.ReadLine(), out volumen);
            Console.WriteLine("Introduce el numero de moles:");
            double.TryParse(userInput=Console.ReadLine(), out numeroMoles);
            Console.WriteLine("Introduce la temperatura en kelvin:");
            double.TryParse(userInput=Console.ReadLine(), out temperaturaKelvin);

            presion = (numeroMoles * constanteR * temperaturaKelvin) / volumen;

            Console.WriteLine("Con un volumen de "+volumen+ " litros, y una temperatura de " +temperaturaKelvin+" kelvin, "+ numeroMoles+" moles de un gas ideal tienen una presión de " +presion +" atmósferas");

            Console.ReadKey();
        }
    }
}
