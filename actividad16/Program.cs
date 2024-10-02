namespace actividad16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salchichon, numero;
            String userInput = "";
            Console.WriteLine("Introduce un numero");
            int.TryParse(userInput=Console.ReadLine(), out numero);

            calcularCuadrado = calcularCuadrado(salchichon);

            Console.WriteLine("El cuadrado es: " + calcularCuadrado);


        }
        static int calcularCuadrado(int numero) {
            int cuadrado;
            cuadrado = numero * numero;
            return cuadrado;
        }
    }
}
