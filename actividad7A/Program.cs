namespace actividad7A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String userInpunt = "";
            int numIngresado = 0;
            int sumaBluque = 0;

            int.TryParse(userInpunt=Console.ReadLine(), out numIngresado);

            while (numIngresado != 0) {

                Console.WriteLine("Introduce un numero:");

                for (int i = numIngresado; i >= 1; i--) { 
                sumaBluque = numIngresado - 1;
                    numIngresado += sumaBluque;
                }
                Console.WriteLine(numIngresado);

                
            }

            Console.ReadKey();

        }
    }
}
