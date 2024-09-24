namespace variablesEj14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioInicial;
            double porcentajeDescuento;
            double precioFinal;
            String userInput = "";

            Console.WriteLine("Introduce el precio inicial:");
            double.TryParse(userInput=Console.ReadLine(), out precioInicial);
            Console.WriteLine("Introduce el porcentaje de descuento:");
            double.TryParse(userInput = Console.ReadLine(), out porcentajeDescuento);
            porcentajeDescuento = (100 - porcentajeDescuento) / 100;
            precioFinal = precioInicial * porcentajeDescuento;
            porcentajeDescuento *= 100;
            porcentajeDescuento = 100 - porcentajeDescuento;
            Console.WriteLine("El precio tras aplicarle un descuento del "+ porcentajeDescuento+"% es de €"+precioFinal);
            Console.ReadKey();

        }
    }
}
