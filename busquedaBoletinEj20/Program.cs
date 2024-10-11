namespace busquedaBoletinEj20
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numeros = new int[100];

			Random random = new Random();

			for (int i = 0; i < numeros.Length; i++)
			{
				numeros[i] = random.Next(500, 2001);
			}

			for (int i = 0; i < numeros.Length; i++)
			{
				if (numeros[i] > 1000)
				{
					Console.WriteLine("El primer numero mayor a 1000 es: "+numeros[i]+" ocupando la "+i+"º posicion");
					break;
				}
			}
			Console.ReadKey();
		}
	}
}
