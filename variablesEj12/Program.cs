namespace variablesEj12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            String userInput = "";

            Console.WriteLine("Introduce el lado de un cuadrado:");
            double.TryParse(userInput=Console.ReadLine(), out lado);
            double perimetro = 4*lado;
            double diagonal = lado * Math.Sqrt(2.0);
            double area = Math.Pow(lado, 2.0);
            Console.WriteLine("El perimetro es: "+perimetro+ " El area es: "+area+ " La diagonal es: "+diagonal);
            Console.ReadKey();
        }
    }
}
