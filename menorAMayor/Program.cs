namespace menorAMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            String userInpunt = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Introduzca el "+(i+1)+"º numero:");
                int.TryParse(userInpunt=Console.ReadLine(), out numeros[i]);
            }
            Array.Sort(numeros);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Los numeros correctamente ordenados son:");

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
