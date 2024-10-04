namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 18, 32, 223, 34, 75, 61 };

            Console.WriteLine("Array original:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }

            int[] numerosOrdenados = new int[numeros.Length];

            Array.Sort(numeros);

            Console.WriteLine("Array original:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.ReadKey();

        }
    }
}
