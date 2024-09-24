namespace variablesEj15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            string userInput = "";

            Console.WriteLine("Introduce el lado del cubo:");
            double.TryParse(userInput=Console.ReadLine(), out lado);
            double diagonal = Math.Sqrt(3)*lado;
            double altura = 4 * Math.Pow(lado, 2);
            double volumen = Math.Pow(lado, 3);
            Console.WriteLine("La diagonal es: " + diagonal);
            Console.WriteLine("La altura es: "+altura);
            Console.WriteLine("El volumen es: "+volumen);
            Console.ReadKey();
        }
    }
}
