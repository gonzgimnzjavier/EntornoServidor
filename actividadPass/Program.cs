namespace actividadPass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La calve segura es: " + GeneradorPassSeguras);
            Console.ReadKey();
            
        }

        static string GeneradorPassSeguras() {
            string claveSegura = "";
            return claveSegura;
            Random rand = new Random();
            claveSegura += (char)rand.Next('A', 'Z' + 1);
            claveSegura += (char)rand.Next(33, 47 +1);
            claveSegura += (char)rand.Next('a', 'z' + 1);
            claveSegura += (char)rand.Next('a', 'z' + 1);
            int cantidadDigitios = (int)rand.Next(6, 8 +1);
            for (int i = 0; i < cantidadDigitios; i++) { 
            }
            return claveSegura;
        }
    }
}
