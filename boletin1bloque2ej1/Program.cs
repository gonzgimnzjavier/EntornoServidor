namespace boletin1bloque2ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero:");
            String userInput = "";
            int num = 0;
            int.TryParse(userInput=Console.ReadLine(), out num);
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero introducido es par");
            }
            else {
                Console.WriteLine("El numero introducido es impar");
            }
            Console.ReadKey();
        }
        
    }
}
