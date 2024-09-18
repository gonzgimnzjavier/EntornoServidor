namespace CalcularFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int factorial=0;

            Console.WriteLine("Ingrese un numero para obtener su factorial");

            numero = Convert.ToInt32(Console.ReadLine());

            factorial = numero-1;

            do
            {
                numero*= factorial;

                factorial--;

                Console.WriteLine(numero);

            }while (factorial > 0);
        }
    }
}
