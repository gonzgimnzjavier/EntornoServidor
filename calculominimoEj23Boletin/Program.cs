namespace calculominimoEj23Boletin
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numeros = new int[100];

			Random random = new Random();

			for (int i = 0; i < numeros.Length; i++)
			{
				numeros[i] = random.Next(-10,11);
			}

			Console.WriteLine(numeros.Min());

			Console.ReadKey();
		}
	}
}
