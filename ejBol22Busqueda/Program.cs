namespace ejBol22Busqueda
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] cienValores = new int[100];

			Random rnd = new Random();

			for (int i = 0; i < cienValores.Length; i++)
			{
				cienValores[i] = rnd.Next(-10, 11);
			}

			for (int i = 0; i < cienValores.Length; i++)
			{
				if (cienValores[i] % 2 == 0)
				{
					Console.WriteLine("El primer numero par en el array esta en la " + i + "ª posicion");
					break;
				}
			}
			Console.ReadKey();
		}
	}
}
