namespace Ej6Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] multiplosDeCinco = new int[101];
            int[] multiplosDeSiete = new int[101];

            for (int i = 0; i < multiplosDeCinco.Length; i++)
            {
                multiplosDeCinco[i] =i;
                multiplosDeSiete[i] =i;
                multiplosDeCinco[i] *= 5;
                multiplosDeSiete[i] *= 7;
            }

            Console.WriteLine("MULTIPLOS DE 5");
            Console.WriteLine("-------------------------------------");

            foreach (int resultados  in multiplosDeCinco)
            {
                Console.Write(resultados+" ");
            }
            Console.WriteLine();
            Console.WriteLine("MULTIPLOS DE 7");
            Console.WriteLine("-------------------------------------");

            foreach(int resultados in multiplosDeSiete)
            {
                Console.Write(resultados + " ");
            }
            Console.ReadKey();
        }
    }
}
