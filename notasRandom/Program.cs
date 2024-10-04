namespace notasRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int cantidadNotas = rand.Next(1,11);

            int[] almacenNotas = new int[cantidadNotas];

            double maximaNota = 0;

            double minimaNota = 0;

            double media = 0;

            Console.WriteLine("El alumno ha realizado: " + cantidadNotas + " examenes:");

            for (int i = 0; i < almacenNotas.Length; i++)
            {
                almacenNotas[i] = rand.Next(0,11);
                Console.WriteLine(i+1+"ª calificacion "+almacenNotas[i]);
                media += almacenNotas[i];
            }
            maximaNota = almacenNotas.Max();
            minimaNota = almacenNotas.Min();
            media = media / almacenNotas.Length;
            Console.WriteLine("La nota maxima del alumno es: " + maximaNota);
            Console.WriteLine("La nota minima del alumno es: " + minimaNota);
            Console.WriteLine("La media del alumno es: " + Math.Round(media, 2));
            Console.ReadKey();

        }
    }
}
