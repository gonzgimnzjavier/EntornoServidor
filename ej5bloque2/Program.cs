namespace ej5bloque2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int [3];
            String userInpunt = "";
            int media=0;

            for (int i = 0; i < notas.Length; i++) { 
            Console.WriteLine("Introduce una nota:");
                int.TryParse(userInpunt=Console.ReadLine(), out notas[i]);
                media += notas[i];
            }
            media = media / notas.Length;
            Console.WriteLine("La media es: "+media);
            Console.ReadKey();
        }
    }
}
