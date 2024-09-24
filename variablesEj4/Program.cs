namespace variablesEj4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaramos la variable radio
            double radio = 0;
            double PI = Math.PI;

            // Pedimos al usuario que introduzca un número para el radio
            Console.WriteLine("Introduce un número para el radio:");
            String input = Console.ReadLine();

            // Intentamos convertir la entrada a double
            if (double.TryParse(input, out radio))
            {
                // Calculamos longitud, área y volumen después de asignar el valor a radio
                double longitud = 2 * PI * radio;
                double area = PI * Math.Pow(radio, 2.0);
                double volumen = (4.0 / 3.0) * PI * Math.Pow(radio, 3.0);

                // Mostramos los resultados
                Console.WriteLine($"Longitud de la circunferencia: {longitud}");
                Console.WriteLine($"Área del círculo: {area}");
                Console.WriteLine($"Volumen de la esfera: {volumen}");
            }
            else
            {
                // Si la conversión falla, mostramos un mensaje de error
                Console.WriteLine("El valor ingresado no es un número válido.");
            }

            // Esperamos una tecla para cerrar el programa
            Console.ReadKey();
        }
    }
}
