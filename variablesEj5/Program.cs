namespace variablesEj5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            double precio=0;
            short cantidad = 0;
            String userInput="";
            Console.WriteLine("Introduzca el precio");
            double.TryParse(userInput=Console.ReadLine(), out precio);
            Console.WriteLine("Introduzca la cantidad");
            short.TryParse(userInput = Console.ReadLine(), out cantidad);
            double resultado = precio*cantidad;

            Console.WriteLine("Pagas "+resultado);
            Console.ReadKey();
        }
    }
}
