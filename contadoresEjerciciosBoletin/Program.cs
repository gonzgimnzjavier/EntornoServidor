namespace contadoresEjerciciosBoletin
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arrayCienValoresAleatorios = new int[100];

			Random random = new Random();

			int contador = 0;

			for (int i = 0; i < 100; i++) {
				arrayCienValoresAleatorios[i] = random.Next(-10, 11);
				if (arrayCienValoresAleatorios[i] < 0)
				{
					contador++;
				}
			}
			Console.WriteLine("El numero de elementos negativos presentes en el array es: "+contador);

			contador = 0;

			for (int i = 0; i < 100; i++)
			{
				arrayCienValoresAleatorios[i] = random.Next(-10, 11);
				if (arrayCienValoresAleatorios[i] %2 !=0)
				{
					contador++;
				}
			}
			Console.WriteLine("El porcentaje de elementos imapres es  del: " + contador+"%");

			string[] array10string = new string[10];

			contador = 0;

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Ingrese el " + (i + 1) + "º valor");
				array10string[i] = Console.ReadLine();

				if(array10string[i] == "" || array10string[i]==" " || array10string[i] == null)
				{
					contador ++;
				}
			}

			Console.WriteLine("El numero de posiciones vacias es: " + contador);

			int[] ints = new int[100];

			contador= 0;

			for (int i = 0;i < 100; i++)
			{
				ints[i]= random.Next(500, 2001);
			}

			for (int i = 0; i < 100; i++)
			{
				if(ints[i] > 1000)
				{
					Console.WriteLine(ints[i]);
				}
			}


				Console.ReadKey();
		}
	}
}
