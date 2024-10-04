namespace ej11bolbloq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioProducto = 0;

            String userInpunt = "";

            Console.WriteLine("Introduce precio del producto:");
            double.TryParse(userInpunt=Console.ReadLine(), out precioProducto);
            if (precioProducto < 100)
            {
                precioProducto *= 0.9;
                Console.WriteLine("El precio del producto tras un descuento del 10% es: " + precioProducto + "euros"); 
            }
            else
            {
                precioProducto *= 0.85;
                Console.WriteLine("El precio del producto tras un descuento del 15% es: " + precioProducto + "euros");
            }
            Console.ReadKey();
        }
    }
}
