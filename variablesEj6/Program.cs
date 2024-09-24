namespace variablesEj6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            String userInput = "";

            Console.WriteLine("Introduce el primer numero:");
            double.TryParse(userInput=Console.ReadLine(), out num1);
            Console.WriteLine("Introduce el segundo numero:");
            double.TryParse(userInput=Console.ReadLine(), out num2);  

            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;

            Console.WriteLine("El resultado de la suma es: "+suma);
            Console.WriteLine("El resultado de la multiplicacion es: "+ multiplicacion);
            Console.WriteLine("El resultado de la resta es: "+resta);
            Console.ReadKey();
        }
    }
}
