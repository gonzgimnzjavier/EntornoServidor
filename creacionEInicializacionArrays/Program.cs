namespace creacionEInicializacionArrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*

			//Ejercio 1
			int[] arrayEj1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


			//Ejercicio 2
			float[] arrayEj2 =new float [20];
			//Console.WriteLine(arrayEj2.Length);

			//Ejercicio 3

			int[] arrayEj3 = new int [10];

			Random random = new Random();

			for (int i = 0; i < arrayEj3.Length; i++) {
				
					arrayEj3 [i] = random.Next();
					Console.WriteLine(arrayEj3[i]);
			}

			static int[] modificaValores(int[] array)
			{
				array [0] = 123;
				array[2] = 123;
				array[5] = 123;
				array[9] = 123;

				return array;
			}

			Console.WriteLine("");

			modificaValores (arrayEj3);

			for (int i = 0; i < arrayEj3.Length; i++)
			{

				Console.WriteLine(arrayEj3 [i]);
			}
			*/

			/*

			String[] mejoresLibors = new string[5];

			String userInput = "";

			for (int i = 0; i < mejoresLibors.Length; i++)
			{
				Console.WriteLine("Introduce la "+(i + 1) + "ª cadena:");
				mejoresLibors[i] = userInput = Console.ReadLine();
			}

			for (int i = 0;i < mejoresLibors.Length; i++)
				Console.WriteLine(mejoresLibors[i]);
			*/


			/*

			double[] arraysEj6 = new double[50];

			Random rnd = new Random();

			for (int i = 0; i < arraysEj6.Length; i++) 
			{ 
				arraysEj6[i] = Math.Round((rnd.NextDouble()*100), 2); 
				Console.WriteLine(arraysEj6[i]);
			}

			static double[] modificaUltimoValor(double[] arrays)
			{
				arrays[arrays.Length - 1] = -1;
				return arrays;
			}

			modificaUltimoValor(arraysEj6);

			Console.WriteLine("-------------------------------------------------");

			for (int i = 0; i < arraysEj6.Length; i++)
			{
				Console.WriteLine(arraysEj6[i]);
			}

			*/

			/*

			string userInpunt = "";

			int numeroPosiciones = 0;

			int primerValorAsignado = 0;

			int ultimoValorAsignado = 0;

			Console.WriteLine("Introduce el numero de posiciones que tendra el array:");

			int.TryParse(userInpunt=Console.ReadLine(), out numeroPosiciones);

			int[] arrayEj7 = new int[numeroPosiciones];

			Console.WriteLine("Introduce el valor que se le asignara al primer elemento:");

			int.TryParse(userInpunt = Console.ReadLine(), out primerValorAsignado);

			arrayEj7[0] = primerValorAsignado;

			Console.WriteLine("Introduce el valor que se le asignara al ultimo elemento:");

			int.TryParse(userInpunt = Console.ReadLine(), out ultimoValorAsignado);

			arrayEj7[arrayEj7.Length-1] = ultimoValorAsignado;

			Random random = new Random();

			for (int i = 1; i < arrayEj7.Length-1; i++)
			{
				arrayEj7[i] = random.Next(0, 256);
			}

			foreach (int i in arrayEj7)
			{
				Console.WriteLine(i);
			}
			*/

			/*

			int valorAAsignar = 0;

			int[] arrayEj10 = new int[100];

			for (int i = 0; i < arrayEj10.Length; i += 2)
			{
				valorAAsignar += 1;
				arrayEj10[i] = valorAAsignar;
			}

			foreach (int i in arrayEj10)
			{
				Console.WriteLine(i);
			}

			*/

			/*

			Random random = new Random();

			int[] arrayEj10 = new int[100];

			for (int i = 1; i < arrayEj10.Length; i += 2)
			{
				arrayEj10[i] = random.Next(10,36);
			}

			for(int i = 0; i < arrayEj10.Length; i++)
			{
				Console.WriteLine(arrayEj10[i]);
			}

			*/

			Random random = new Random();

			int[] ints = new int[50];

			for (int i = 0; i < ints.Length; i++)
			{
				ints[i] = random.Next(-10,50);
				if (ints[i] < 0)
				{
					Console.WriteLine("Valor: " + ints[i]+ " posicion "+i);
				}
			}

			Console.ReadKey();
		}
	}
}

