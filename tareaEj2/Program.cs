namespace tareaEj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] almacenadorCadenas = new String[5];
            String[] almacenadorCadenasInverso = new String[5];
            Console.WriteLine("Las 5 cadenas generadas son:");
            for (int i = 0; i < 5; i++)
            {
                almacenadorCadenas[i] = generadorCadenasAleatorias();
                almacenadorCadenasInverso[i] = new String (almacenadorCadenas[i].Reverse().ToArray());
                Console.WriteLine(almacenadorCadenas[i]);
            }

            Console.WriteLine("--------------------------------------------- ");
            Console.WriteLine("Las 5 cadenas generadas de forma iversa son:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(almacenadorCadenasInverso[i]);
            }

            Console.ReadKey();

            static String generadorCadenasAleatorias()
            {
                Random random = new Random();
                String cadenaAleatoria = "";
                int numeroCaracteres = random.Next(1, 21);
                for (int i = 0; i < numeroCaracteres; i++)
                {
                    cadenaAleatoria += (char)random.Next(97,123);
                }
                return cadenaAleatoria;
            }
            
        }

    }
}
