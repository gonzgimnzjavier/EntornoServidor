using System.Diagnostics.CodeAnalysis;

namespace problemaEj31Boletin
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduce el numero de posiciones que deseas para el array:");
			int numPosiciones = int.Parse(Console.ReadLine());

			int[] numeros = new int[numPosiciones];

			int[] copiaDeNumeros = new int[numPosiciones];

			int suma  = 0;

			int valorABuscar = 0;

			Random rand = new Random();

			for (int i = 0; i < 5; i++)
			{
				numeros[i] = rand.Next(-10,11);
			}

			for (int i = numeros.Length-1; i > numeros.Length-6; i--)
			{
				numeros[i] = rand.Next(-10, 11);
			}


			for(int i = 5; i<=numeros.Length-6; i++)
			{
				numeros[i] = 48;
			}

			Console.WriteLine("El valor de la primera psocion es: " + numeros[0]+" El valor de la ultima posicion del array es: " + numeros[numeros.Length-1]);

			Array.Copy(numeros, copiaDeNumeros, numPosiciones);

			Array.Sort(copiaDeNumeros);

			for (int i = 0; i < 10; i++) { 
			
				suma += numeros[i];
			}


			suma = 0;

			for (int i = 0; i < 10; i++)
			{
				suma += copiaDeNumeros[i];
			}

			for (int i = 0; i < copiaDeNumeros.Length; i++) {
				copiaDeNumeros[i] += 10;
			}

			double mediaArrayOriginal = numeros.Average();

			double mediaCopiaArray = copiaDeNumeros.Average();

			for (int i = 0; i < copiaDeNumeros.Length; i++)
			{
				if (numeros[i] > mediaArrayOriginal) {

					numeros[i] = 0;
				}
			}

			for (int i = 0; i < copiaDeNumeros.Length; i++)
			{
				if (copiaDeNumeros[i] > mediaCopiaArray)
				{

					copiaDeNumeros[i] = 0;
				}
			}

			Console.WriteLine("Introduce un valor para buscarlo:");
			valorABuscar = int.Parse(Console.ReadLine());

			int indice = Array.IndexOf(numeros, valorABuscar);

			if (indice == -1)
			{
				Console.WriteLine(valorABuscar + " no se encuentra en el array");
			}
			else { 
				Console.WriteLine(valorABuscar + " esta en la posicion numero "+indice);
			}

			indice = Array.IndexOf(copiaDeNumeros, valorABuscar);

			if (indice == -1)
			{
				Console.WriteLine(valorABuscar + " no se encuentra en el array");
			}
			else
			{
				Console.WriteLine(valorABuscar + " esta en la posicion numero " + indice);
			}

			Console.ReadKey();

		}
	}
}
