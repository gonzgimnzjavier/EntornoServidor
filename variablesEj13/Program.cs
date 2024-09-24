namespace variablesEj13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primerCateto;
            double segundoCateto;
            String userInput = "";

            Console.WriteLine("Introduce el primer cateto:");
            double.TryParse(userInput=Console.ReadLine(), out primerCateto);
            Console.WriteLine("Introduce el segundo cateto");
            double.TryParse(userInput = Console.ReadLine(), out segundoCateto);
            double hipotenusa = Math.Sqrt(primerCateto + primerCateto);
            Console.WriteLine("La hipotenusa dados: "+ primerCateto + " y "+ segundoCateto+ " como catetos es: "+hipotenusa);
            Console.ReadKey();
        }
    }
}
