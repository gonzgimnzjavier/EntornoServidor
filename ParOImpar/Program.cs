namespace ParOImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un numero:");

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero%2 ==0) Console.WriteLine("El numero es par");
            else Console.WriteLine("El numero es impar");
        }
    }
}
