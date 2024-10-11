using System.Security.Cryptography;

namespace sumaBolEj12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] cienValoresAleatorios = new int[100];

			Random rnd = new Random();

			int suma = 0;

			for (int i = 0; i < 100; i++)
			{
				cienValoresAleatorios[i] = rnd.Next(-10, 11);
				suma += cienValoresAleatorios[i];
			}

			Console.WriteLine("La suma de todos los valores aleatorios del array es: "+suma);

			suma = 0;

			for (int i = 0; i < 100; i+=2)
			{
				cienValoresAleatorios[i] = rnd.Next(-10, 11);
				suma += cienValoresAleatorios[i];
			}

			Console.WriteLine("La suma de todos los valores aleatorios del array cuyo indice es par es: " + suma);

			suma= 0;

			for (int i = 0; i < 100; i++)
			{
				int numRand = rnd.Next(-10, 11);
				cienValoresAleatorios[i] = (numRand * numRand);
				suma += cienValoresAleatorios[i];
			}

			Console.WriteLine("La suma de todos los valores aleatorios al cuadrado del array es: " + suma);

			suma = 0;

			for (int i = 0; i < 100; i++)
			{
				cienValoresAleatorios[i] = rnd.Next(-10, 11);
				suma += cienValoresAleatorios[i];
			}

			for (int i = 0; i < 100; i++)
			{
				if (cienValoresAleatorios[i] > 0)
				{
					suma += cienValoresAleatorios[i];
				}
			}

			Console.WriteLine("La suma de todos los valores aleatorios positivos es: " + suma);

			Console.ReadKey();
		}
	}
}
