namespace PideNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;

            int num2;

            int suma;

            int resta;

            int multiplicacion;

            double division;

            Console.WriteLine("Ingrese el primer numero:");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");

            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine("La suma de dichos numeros es: "+suma);

            resta = num1 - num2;

            Console.WriteLine("La resta de dichos numeros es: "+resta);

            multiplicacion = num1 * num2;

            Console.WriteLine("La multiplicacion de dichos numeros es: " + multiplicacion);

            division = Convert.ToDouble(num1/num2);

            Console.WriteLine("La division de dichos numeros es: "+division);
        }
    }
}
