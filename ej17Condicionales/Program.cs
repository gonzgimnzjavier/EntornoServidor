namespace ej17Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userInpunt = "";
            int[] numeros = new int[3];
            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine("Introduce el "+(i+1)+"º numero:");
                int.TryParse(userInpunt=Console.ReadLine(), out numeros[i]);
            }
            HashSet<int> list = new HashSet<int>();
        }
    }
}
