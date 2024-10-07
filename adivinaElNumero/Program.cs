namespace adivinaElNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numIntentos = 3;
            String userInput = "";
            int numAleatorio = rand.Next(1, 16);
            int numerosDadosPorElUsuario = 0;

            Console.WriteLine("Bienvenido al juego de adivinar el numero:");
            Console.WriteLine("---------------------------------------------");
            do
            {
                Console.WriteLine("Inserte un numero:");
                int.TryParse(userInput = Console.ReadLine(), out numerosDadosPorElUsuario);
                if (numerosDadosPorElUsuario == numAleatorio)
                {
                    Console.WriteLine("Has acertado pulsa enter para continuar");
                    break;
                }
                else
                {
                    numIntentos--;
                    if (numIntentos > 0)
                        Console.WriteLine("Ese no es el numero te quedan " + numIntentos + " intentos");
                    if (numAleatorio < numerosDadosPorElUsuario && numIntentos > 0)
                        Console.WriteLine("Pista el numero es menor...");
                    else if (numIntentos > 0)
                    {
                        Console.WriteLine("Pista el numero es mayor...");
                    }
                }
                if (numIntentos == 0)
                {
                    Console.WriteLine("Lo siento has perdido, el numero a acertar era " + numAleatorio + " pulsa enter:");
                }
            }
            while (numIntentos > 0);
            Console.ReadKey();

            if (numIntentos > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Bienvenido al nivel 2");
                Console.WriteLine("-------------------------------------------------");
                numAleatorio = rand.Next(1, 31);
                numIntentos = 4;
                do
                {
                    Console.WriteLine("Inserte un numero:");
                    int.TryParse(userInput = Console.ReadLine(), out numerosDadosPorElUsuario);
                    if (numerosDadosPorElUsuario == numAleatorio)
                    {
                        Console.WriteLine("Has acertado pulsa enter para continuar");
                        break;
                    }
                    else
                    {
                        numIntentos--;
                        if (numIntentos > 0)
                            Console.WriteLine("Ese no es el numero te quedan " + numIntentos + " intentos");
                        if (numAleatorio < numerosDadosPorElUsuario && numIntentos > 0)
                            Console.WriteLine("Pista el numero es menor...");
                        else if (numIntentos > 0)
                        {
                            Console.WriteLine("Pista el numero es mayor...");
                        }
                    }
                    if (numIntentos == 0)
                    {
                        Console.WriteLine("Lo siento has perdido, el numero a acertar era " + numAleatorio + " pulsa enter:");
                    }
                } while (numIntentos > 0);

                if (numIntentos > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bienvenido al nivel 3");
                    Console.WriteLine("-------------------------------------------------");
                    numAleatorio = rand.Next(1, 51);
                    numIntentos = 6;
                    do
                    {
                        Console.WriteLine("Inserte un numero:");
                        int.TryParse(userInput = Console.ReadLine(), out numerosDadosPorElUsuario);
                        if (numerosDadosPorElUsuario == numAleatorio)
                        {
                            Console.WriteLine("TE HAS PASADO EL JUEGO...");
                            break;
                        }
                        else
                        {
                            numIntentos--;
                            if (numIntentos > 0)
                                Console.WriteLine("Ese no es el numero te quedan " + numIntentos + " intentos");
                            if (numAleatorio < numerosDadosPorElUsuario && numIntentos > 0)
                                Console.WriteLine("Pista el numero es menor...");
                            else if (numIntentos > 0)
                            {
                                Console.WriteLine("Pista el numero es mayor...");
                            }
                        }
                        if (numIntentos == 0)
                        {
                            Console.WriteLine("Lo siento has perdido, el numero a acertar era " + numAleatorio + " pulsa enter:");
                        }
                    } while (numIntentos > 0);

                }
                Console.ReadKey();
            }
        }
    }
}
