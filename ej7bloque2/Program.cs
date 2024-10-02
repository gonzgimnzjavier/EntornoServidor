namespace ej7bloque2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] contrasenas = new string[2];
            string userInput = "";
            for (int i = 0; i < contrasenas.Length; i++)
            {
                Console.WriteLine("introduce la " + (i + 1) + "º contraseña:");
                userInput = Console.ReadLine();
                contrasenas[i] += userInput;
            }
            if (contrasenas[0] == contrasenas[1])
            {
                Console.WriteLine("Las contraseñas coinciden");
            }
            else
            {
                Console.WriteLine("Las contraseñas no coinciden");
            }
            Console.ReadLine();
        }
    }
}
