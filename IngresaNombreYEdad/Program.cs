namespace IngresaNombreYEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;

            int edad;

            Console.WriteLine("Ingrese su nombre:");

            nombre = Console.ReadLine();

            Console.WriteLine("A continuacion ingrese su edad:");

            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hola "+nombre+" tienes "+edad+" años.");
        }
    }
}
