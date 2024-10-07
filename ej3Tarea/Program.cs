namespace ej3Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();

            int numeroElementos = random.Next(1,11);

            int[] numeros = new int[numeroElementos];

            for (int i = 0; i < numeros.Length; i++) { 
            numeros[i] = random.Next(1, 1001);
                Console.WriteLine(numeros[i]);
            }

            Array.Sort(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i+"");
            }
            Console.ReadKey();
        }
        
    }
}
