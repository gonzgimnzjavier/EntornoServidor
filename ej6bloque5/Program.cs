namespace ej6bloque5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[2];
            String userInput = "";
            double suma = 0;

            for (int i = 0; i < numeros.Length; i++) { 
            Console.WriteLine("Introduce un numero:");
                 double.TryParse(userInput=Console.ReadLine(), out numeros[i]);
                suma += numeros[i];
            }
            if (suma > 0)
            {
                Console.WriteLine(Math.Sqrt(suma));
            }
            else
            {
                Console.WriteLine("No se puede hacer la raiz cuadrada de un numero negativo");
            }
            Console.ReadKey();
        }
    }
}
